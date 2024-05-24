

using SuperSimpleTcp;
using System.Text;
using uPLibrary.Networking.M2Mqtt;

namespace wirelessCommProject
{
    public partial class Form1 : Form
    {


        public static SimpleTcpClient client;
        MqttClient Mqttclient;
        string mqttclientId;
        string topic;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            client = new SimpleTcpClient(textBox1.Text);
            client.Connect();
            if (client.IsConnected)
            {
                pictureBox2.Visible = true;
                Thread.Sleep(30);
                client.Send("micro" + "\r\n");
                Thread.Sleep(30);
                client.Send("python" + "\r\n");

                client.Events.DataReceived += Events_DataReceived;
            }
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    String newData = Encoding.UTF8.GetString(e.Data);
                    Mqttclient.Publish(topic, Encoding.UTF8.GetBytes(newData));
                    textBox6.Text += newData;

                });
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string BrokerAddress = textBox2.Text;
            Mqttclient = new MqttClient(BrokerAddress);
            mqttclientId = Guid.NewGuid().ToString();
            Mqttclient.Connect(mqttclientId, textBox4.Text, textBox3.Text);
            topic = textBox5.Text;

            Mqttclient.Publish(topic, Encoding.UTF8.GetBytes("helooo"));

            if (Mqttclient.IsConnected)
            {
                pictureBox1.Visible = true;
            }
        }
    }
}
