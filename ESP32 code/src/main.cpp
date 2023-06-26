#include <Arduino.h>
#include <U8g2lib.h>
#include <WiFi.h>
#include <string.h>
#include <DHT.h>
#include <stdlib.h>
#include <SPI.h>
#include <Wire.h>
#include <esp_wifi.h>
#include <PubSubClient.h>
#include <unistd.h>
 
//definiranje ekrana
#ifdef U8X8_HAVE_HW_SPI
#endif
#ifdef U8X8_HAVE_HW_I2C
#endif

//definiranje senzora temperature i vlage (DHT11)
#define DHTpin 4
#define DHTtype DHT11

DHT dht(DHTpin, DHTtype);

//definiranje senzora svijetlosti
#define lightSensor 5

//WiFi
#define CONNECTION_TIEMOUT 1;
#define DEEP_SLEEP_DURATION 10;

const char* ssid = "#######";
const char* password = "#######";

//MQTT
const char* mqtt_server = "test.mosquitto.org";
const char* mqtt_password = "#######";
const char* mqtt_ssid = "#######";
const char* mqtt_topic_temperatura = "SmartFarmKarlo/Temperatura1";
const char* mqtt_topic_vlaga = "SmartFarmKarlo/Vlaga1";
const char* mqtt_topic_svijetlo = "SmartFarmKarlo/Svijetlo1";
const int mqtt_port = 1883;

WiFiClient espClient;
PubSubClient client(espClient);

//OLED
U8G2_SSD1306_128X64_NONAME_F_HW_I2C u8g2(U8G2_R0, /* clock=*/ SCL, /* data=*/ SDA, /* reset=*/ U8X8_PIN_NONE);  // High speed I2C
 
// U8G2_SSD1306_128X64_NONAME_F_SW_I2C u8g2(U8G2_R0, /* clock=*/ SCL, /* data=*/ SDA, /* reset=*/ U8X8_PIN_NONE);    //Low spped I2C

void ConnectToWiFi(const char* ssid, const char* password){
    WiFi.mode(WIFI_STA);
    WiFi.begin(ssid, password);
    int timeout = 0;

    while (WiFi.status() != WL_CONNECTED)
    {
        u8g2.clearBuffer();
        u8g2.drawStr(0, 10, "Connecting to WiFi...");
        u8g2.sendBuffer();
        timeout++;
        
        delay(100);
        if(timeout >= 100){
            u8g2.clearBuffer();
            u8g2.clearDisplay();
            u8g2.drawStr(0, 10, "Can't connect to WiFi");
            u8g2.drawStr(0, 25, "Restart in 10s");
            u8g2.sendBuffer();
            //deep sleep, timer je u mikrosekundama
            esp_sleep_enable_timer_wakeup(10000000);
            esp_deep_sleep_start();
        }
    }

    Serial.println(WiFi.localIP());

    u8g2.clearBuffer();
    u8g2.clearDisplay();
    u8g2.drawStr(0, 10, "Connected");
    u8g2.drawStr(0, 20, "IP:");
    u8g2.drawStr(20, 20, WiFi.localIP().toString().c_str());
    u8g2.sendBuffer();
    delay(2000);
}

void ConnectToMqtt(const char* mqttServer, int mqttPort){
    client.setServer(mqttServer, mqttPort);

    while (!client.connected())
    {
        u8g2.clearBuffer();
        u8g2.clearDisplay();
        u8g2.drawStr(0, 10, "Connecting to MQTT");
        u8g2.drawStr(0, 25, "broker...");
        u8g2.sendBuffer();

        delay(2000);

        client.setServer(mqtt_server, mqtt_port);
        //client.setCallback(callback);
        client.connect("ESP32_client");
    }

    u8g2.clearBuffer();
    u8g2.clearDisplay();
    u8g2.drawStr(0, 10, "Broker connected");
    u8g2.sendBuffer();
    delay(2000);
}
 
void setup(void) {
    Serial.begin(115200);
    u8g2.begin();
    dht.begin();
    u8g2.setFont(u8g2_font_t0_12b_tf);
    pinMode(lightSensor, INPUT);
    pinMode(15, OUTPUT);
    delay(1000);

    ConnectToWiFi(ssid, password);

    ConnectToMqtt(mqtt_server, mqtt_port);    

    u8g2.clearBuffer();
    u8g2.clearDisplay();
    u8g2.drawStr(0, 10, "Measuring...");
    u8g2.sendBuffer();
}

char tempBuffer[4];
char humBuffer[5];
int light;
char lightChar[6];

void loop(void) {

    delay(500);

    //citanje vrijednosti temperature i vlage
    //dtostrf() pretvara iz float u char
    dtostrf(dht.readTemperature(), 4, 1, tempBuffer);
    dtostrf(dht.readHumidity(), 4, 1, humBuffer);

    //citanje vrijednosti svijetlosti, 1 ugaseno, 0 upaljeno
    //sprintf() pretvara int u char
    light = digitalRead(lightSensor);
    sprintf(lightChar, "%d", light);

    //citanje sa senzora svakih 5 sekundi
    delay(300);

    u8g2.clearBuffer();
    u8g2.clearDisplay();
    u8g2.drawStr(0, 10, "Temperatura:");
    u8g2.drawStr(76, 10, tempBuffer);
    u8g2.drawStr(102, 10, "C");
    u8g2.drawStr(0, 25, "Vlaga:");
    u8g2.drawStr(40, 25, humBuffer);
    u8g2.drawStr(66, 25, "%");

    if(light)
        u8g2.drawStr(0, 40, "Svijetlo je ugaseno");
    else
        u8g2.drawStr(0, 40, "Svijetlo je upaljeno");

    u8g2.sendBuffer();

    client.publish(mqtt_topic_temperatura, tempBuffer);
    delay(1000);
    client.publish(mqtt_topic_vlaga, humBuffer);
    delay(1000);
    client.publish(mqtt_topic_svijetlo, lightChar);
    delay(1000);
    digitalWrite(15, HIGH);
    delay(100);
    digitalWrite(15, LOW);

    //min * microsec = koliko minute ce spavati
    unsigned int microsec = 60000000;
    esp_sleep_enable_timer_wakeup(30 * microsec);
    esp_deep_sleep_start();
}