using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MQTTnet;
//using MQTTnet.Client;
//using MQTTnet.Client.Options;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt;

namespace SmartFarmV3
{
    public partial class Form1 : Form
    {
        //objekti senzora1
        MqttClient sensor1Temp, sensor1Hum, sensor1Light, sensor1AllData;

        //Mqtt info
        string broker = "test.mosquitto.org";
        bool firstBoot = true;
        char[] removedCharacters = { '~' };

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelSensor1_Click(object sender, EventArgs e)
        {

        }

        private void sensorLight1_Click(object sender, EventArgs e)
        {

        }

        private void labelSensor1Light_Click(object sender, EventArgs e)
        {

        }

        private void sensorHum1_Click(object sender, EventArgs e)
        {

        }

        private void labelSensor1Hum_Click(object sender, EventArgs e)
        {

        }

        private void labelSensor1Temp_Click(object sender, EventArgs e)
        {

        }

        private void sensorTemp1_Click(object sender, EventArgs e)
        {

        }

        private void sensor1Data_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

            connectToBroker(broker, "SmartFarmKarlo/Temperatura1", "sensor1temp", sensor1Temp);
            connectToBroker(broker, "SmartFarmKarlo/Vlaga1", "sensor1hum", sensor1Hum);
            connectToBroker(broker, "SmartFarmKarlo/Svijetlo1", "sensor1light", sensor1Light);
            connectToBroker(broker, "SmartFarmKarlo/DataSet1", "dataSet1", sensor1AllData);
        }

        private void MqttClient_MqttMsgPublishReceivedTopic1(object sender, MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);

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
                }
                else
                {
                    Console.WriteLine("Svijetlo je upaljeno");
                    sensorLight1.Invoke((MethodInvoker)(() => sensorLight1.Text = "Svijetlo je upaljeno"));
                }
            }

            if (e.Topic == "SmartFarmKarlo/DataSet1" && IsHandleCreated)
            {
                sensor1HistoryData.Invoke((MethodInvoker)(() => sensor1HistoryData.Items.Add(message)));
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
                firstBoot = false;
            }
        }
    }
}
