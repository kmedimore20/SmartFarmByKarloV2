using System;
using System.Text;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt;

namespace SmartFarmV3
{
    public partial class Form1 : Form
    {
        //objekti senzora1
        MqttClient sensor1Temp, sensor1Hum, sensor1Light, sensor1AllData, lightOnOff;

        //objekti senzora2
        MqttClient sensor2Temp, sensor2Hum, sensor2Light, sensor2AllData;

        //Mqtt info
        string broker = "test.mosquitto.org";
        bool firstBoot = true;

        char[] removedCharacters = { '~' };

        private bool lightButtonClick = false;
        private bool first = true;

        private void LightControllbtn_Click(object sender, EventArgs e)
        {

            if (first)
            {
                
                lightOnOff = new MqttClient(broker);
                lightOnOff.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceivedTopic1;
                lightOnOff.Subscribe(new string[] { "SmartFarmKarlo/Svijetlo1" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                lightOnOff.Connect("tewteaasdf");
                Console.WriteLine("Connected to light");
                first = false;
            }
            if (lightButtonClick)
            {
                lightOnOff.Publish("SmartFarmKarlo/Svijetlo1", Encoding.UTF8.GetBytes("LightOn"), MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, true);
                Console.WriteLine("Svijetlo je upaljeno");
                lightButtonClick = false;
                lightStatus.Invoke((MethodInvoker)(() => lightStatus.Text = "Svijetlo je upaljeno"));
            }
            else
            {
                lightOnOff.Publish("SmartFarmKarlo/Svijetlo1", Encoding.UTF8.GetBytes("LightOff"), MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, true);
                lightButtonClick = true;
                Console.WriteLine("Light turned off");
                lightStatus.Invoke((MethodInvoker)(() => lightStatus.Text = "Svijetlo je ugaseno"));
            }
        }

        public Form1()
        {
            InitializeComponent();

            //Topic senzora 1
            connectToBroker(broker, "SmartFarmKarlo/Temperatura1", "sensor1temp", sensor1Temp);
            connectToBroker(broker, "SmartFarmKarlo/Vlaga1", "sensor1hum", sensor1Hum);
            connectToBroker(broker, "SmartFarmKarlo/Svijetlo1", "sensor1light", sensor1Light);
            connectToBroker(broker, "SmartFarmKarlo/DataSet1", "dataSet1", sensor1AllData);

            //Topic senzora 2
            connectToBroker(broker, "SmartFarmKarlo/Temperatura2", "sensor2temp", sensor2Temp);
            connectToBroker(broker, "SmartFarmKarlo/Vlaga2", "sensor2hum", sensor2Hum);
            connectToBroker(broker, "SmartFarmKarlo/Svijetlo2", "sensor2light", sensor2Light);
            connectToBroker(broker, "SmartFarmKarlo/DataSet2", "dataSet2", sensor2AllData);
        }

        private void MqttClient_MqttMsgPublishReceivedTopic1(object sender, MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);

            //Poruke za senzor 1
            if (e.Topic == "SmartFarmKarlo/Temperatura1" && IsHandleCreated)
            {
                Console.WriteLine(message);
                string trimmedMessage = message.TrimStart(removedCharacters);
                sensorTemp1.Invoke((MethodInvoker)(() => sensorTemp1.Text = trimmedMessage + " °C"));
            }
            if (e.Topic == "SmartFarmKarlo/Vlaga1" && IsHandleCreated)
            {
                Console.WriteLine(message);
                string trimmedMessage = message.TrimStart(removedCharacters);
                sensorHum1.Invoke((MethodInvoker)(() => sensorHum1.Text = trimmedMessage + " %"));
            }
            if (e.Topic == "SmartFarmKarlo/Svijetlo1" && IsHandleCreated)
            {
                Console.WriteLine(message);
                if (message == "1")
                {
                    Console.WriteLine("Svijetlo je ugaseno");
                    sensorLight1.Invoke((MethodInvoker)(() => sensorLight1.Text = "Svijetlo je ugašeno"));
                    if (first)
                    {
                        lightStatus.Invoke((MethodInvoker)(() => lightStatus.Text = "Svijetlo je ugašeno"));
                    }
                }
                else
                {
                    Console.WriteLine("Svijetlo je upaljeno");
                    sensorLight1.Invoke((MethodInvoker)(() => sensorLight1.Text = "Svijetlo je upaljeno"));
                    if (first)
                    {
                        lightStatus.Invoke((MethodInvoker)(() => lightStatus.Text = "Svijetlo je upaljeno"));
                    }
                }
            }

            if (e.Topic == "SmartFarmKarlo/DataSet1" && IsHandleCreated)
            {
                Console.WriteLine(message);
                sensor1HistoryData.Invoke((MethodInvoker)(() => sensor1HistoryData.Items.Add(message)));
            }

            //Poruke za senzor 2
            if (e.Topic == "SmartFarmKarlo/Temperatura2" && IsHandleCreated)
            {
                Console.WriteLine(message);
                string trimmedMessage = message.TrimStart(removedCharacters);
                sensorTemp2.Invoke((MethodInvoker)(() => sensorTemp2.Text = trimmedMessage + " °C"));
            }
            if (e.Topic == "SmartFarmKarlo/Vlaga2" && IsHandleCreated)
            {
                Console.WriteLine(message);
                string trimmedMessage = message.TrimStart(removedCharacters);
                sensorHum2.Invoke((MethodInvoker)(() => sensorHum2.Text = trimmedMessage + " %"));
            }
            if (e.Topic == "SmartFarmKarlo/Svijetlo2" && IsHandleCreated)
            {
                Console.WriteLine(message);
                if (message == "1")
                {
                    Console.WriteLine("Svijetlo je ugaseno");
                    sensorLight2.Invoke((MethodInvoker)(() => sensorLight2.Text = "Svijetlo je ugašeno"));
                }
                else
                {
                    Console.WriteLine("Svijetlo je upaljeno");
                    sensorLight2.Invoke((MethodInvoker)(() => sensorLight2.Text = "Svijetlo je upaljeno"));
                }
            }

            if (e.Topic == "SmartFarmKarlo/DataSet2" && IsHandleCreated)
            {
                sensor2HistoryData.Invoke((MethodInvoker)(() => sensor2HistoryData.Items.Add(message)));
            }
        }

        private void connectToBroker (string brokerAddress, string topic, string ID, MqttClient client)
        {
            client = new MqttClient(brokerAddress);
            client.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceivedTopic1;
            client.Subscribe(new string[] { topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
            client.Connect(ID);
            Console.WriteLine("Connected to " + topic);
            if(firstBoot)
            {
                client.Publish("SmartFarmKarlo/Temperatura1", Encoding.UTF8.GetBytes("FirstConnection"), MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, true);
                client.Publish("SmartFarmKarlo/Temperatura2", Encoding.UTF8.GetBytes("FirstConnection"), MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, true);
                firstBoot = false;
            }
        }
    }
}
