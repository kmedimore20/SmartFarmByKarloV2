#!/usr/bin/python
import paho.mqtt.client as mqtt
import paho.mqtt.publish as publish
from flask import Flask, render_template
import RPi.GPIO as GPIO
import time
from time import sleep
import mysql.connector as mariadb
from datetime import date
import datetime

#Lights controll
GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)
relay_pin = 23
GPIO.setup(relay_pin,GPIO.OUT)

#MQTT
MQTT_SERVER = "test.mosquitto.org"
MQTT_TOPIC_TEMP = "SmartFarmKarlo/Temperatura"
MQTT_TOPIC_HUM = "SmartFarmKarlo/Vlaga"
MQTT_TOPIC_LIGHT = "SmartFarmKarlo/Svijetlo"
MQTT_TOPIC_SEND_DATA = "SmartFarmKarlo/DataSet"

#Databse
mariadb_connection = mariadb.connect(user='###########', password='###########', database='Sensors_data', host='localhost', port='3306')
cursor = mariadb_connection.cursor() 

today = date.today()
averageTemp = 0
averageHum = 0
messageCounterTopic1 = 0
firstBoot = True
tempMessage1 = "0"
humMessage1 = "0"
lightMessage1 = "Ugaseno"

def set_insert_id(table):
    sql_statement_count = 'SELECT COUNT(*) FROM ' + table
    cursor.execute(sql_statement_count)
    return int(str(cursor.fetchall()).replace("[", "").replace("]", "").replace("(", "").replace(")", "").replace(",", "")) + 1

idSensor1 = set_insert_id("sensor1_data")

def on_connect(client, userdata, flags, rc):
    print("Connection code:" +str(rc))
    
    #subscribing to first sensor
    client.subscribe(MQTT_TOPIC_TEMP + "1")
    client.subscribe(MQTT_TOPIC_HUM + "1")
    client.subscribe(MQTT_TOPIC_LIGHT + "1")
    #read_from_database("sensor1_data", "topic")
    
def insert_into_database(table, ID, temperature, humidity, lights, today):
    sql_statement = 'INSERT INTO ' + table + ' (id, temperature, humidity, lights, log_date) VALUES (%s, %s, %s, %s, %s)';
    insert_data = (ID, temperature, humidity, lights, today)
    cursor.execute(sql_statement, insert_data)
    mariadb_connection.commit()
    print("Data saved")
    print("Table = " + table + " - id = " + str(ID) + " - temp = " + str(temperature) + " - hum = " + str(humidity) + " - lights = " + lights)
    print("*******************************************************************************")
    
def read_from_database(table, topic):
    sql_statement = 'SELECT COUNT(*) FROM ' + table
    cursor.execute(sql_statement)
    count = int(str(cursor.fetchall()).replace("[", "").replace("]", "").replace("(", "").replace(")", "").replace(",", ""))
    x = count - 60
    if(x <= 0):
        x = 0
    while x != count:
        sql_statement = 'Select temperature from ' + table + ' where (id=' + str(count) + ')'
        cursor.execute(sql_statement)
        result = "     " + str(cursor.fetchall()).replace("[", "").replace("]", "").replace("(", "").replace(")", "").replace("'", "").replace(",", "") + " C    |    "
        
        sql_statement = 'Select humidity from ' + table + ' where (id=' + str(count) + ')'
        cursor.execute(sql_statement)
        result = result + str(cursor.fetchall()).replace("[", "").replace("]", "").replace("(", "").replace(")", "").replace("'", "").replace(",", "") + " %     |    "
        
        sql_statement = 'Select lights from ' + table + ' where (id=' + str(count) + ')'
        cursor.execute(sql_statement)
        result = result + str(cursor.fetchall()).replace("[", "").replace("]", "").replace("(", "").replace(")", "").replace("'", "").replace(",", "") + "    |    "
        
        sql_statement = 'Select log_date from ' + table + ' where (id=' + str(count) + ')'
        cursor.execute(sql_statement)
        result = result + str(cursor.fetchall()).replace("datetime.date", "").replace("[", "").replace("]", "").replace("(", "").replace(")", "").replace("'", "").replace(",", "-").replace(" ", "")
        
        count -= 1
        publish.single(topic, result, hostname=MQTT_SERVER)
        time.sleep(0.1)
        
global firstLight
firstLight = 0

def on_message(client, userdata, msg):
    global tempMessage1, humMessage1, lightMessage1, today
    global averageTemp, averageHum, messageCounterTopic1, firstBoot
    global firstLight
    
    if(msg.topic == "SmartFarmKarlo/Temperatura1"):
        
        if(str(msg.payload) == "b'FirstConnection'"):
            time.sleep(0.1)
            publish.single("SmartFarmKarlo/Temperatura1", tempMessage1, hostname=MQTT_SERVER)
            time.sleep(0.1)
            publish.single("SmartFarmKarlo/Vlaga1", "~" + humMessage1, hostname=MQTT_SERVER)
            time.sleep(0.1)
            publish.single("SmartFarmKarlo/Svijetlo1", "~" + lightMessage1, hostname=MQTT_SERVER)
            time.sleep(0.1)
            read_from_database("sensor1_data", "SmartFarmKarlo/DataSet1")
            
        else:
            if '~' not in str(msg.payload):
                print("*******" + msg.topic + "*******")
                tempMessage1 = str(msg.payload).replace("'", "").replace("b", "")
                print("Temperature: " + tempMessage1)
                averageTemp += float(tempMessage1)
    
    if(msg.topic == "SmartFarmKarlo/Vlaga1"):
        if '~' in str(msg.payload):
            return
        
        humMessage1 = str(msg.payload).replace("'", "").replace("b", "")
        print("Humidity: " + humMessage1)
        averageHum += float(humMessage1)
    
    if(msg.topic == "SmartFarmKarlo/Svijetlo1"):
        if '~' in str(msg.payload):
            return
        
        if(str(msg.payload) == "b'LightOn'"):
            if firstLight == 0:
                firstLight = 1
                return
            
            GPIO.output (relay_pin,GPIO.LOW)
            print(str(msg.payload))
            return
        
        if(str(msg.payload) == "b'LightOff'"):
            if firstLight == 0:
                firstLight = 1
                return
            
            GPIO.output (relay_pin,GPIO.HIGH)
            print(str(msg.payload))
            return
        
        messageCounterTopic1 += 1
        lightMessage1 = str(msg.payload).replace("'", "").replace("b", "")
        if(lightMessage1 == "0"):
            lightMessage1 = "Upaljeno"
            print("Lights: " + lightMessage1)
        else:
            lightMessage1 = "Ugaseno"
            print("Lights: " + lightMessage1)
        print(datetime.datetime.now())
        if today != date.today():
            global idSensor1
            idSensor1 += 1
            averageTemp /= messageCounterTopic1
            averageHum /= messageCounterTopic1
            averageTemp = round(averageTemp, 2)
            averageHum = round(averageHum, 2)
            insert_into_database("sensor1_data" ,idSensor1, averageTemp, averageHum, lightMessage1, today)
            today = date.today()
            messageCounterTopic1 = 0
            averageTemp = 0
            averageHum = 0
            
    
client = mqtt.Client()
client.on_connect = on_connect
client.on_message = on_message

client.connect(MQTT_SERVER)

client.loop_forever()


