using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VPGNewOne
{
    public partial class DHS_2 : Form
    {
        int flag = 0;
        public TcpClient client;
        public NetworkStream stream;
        DateTime now = new DateTime();
        public DHS_2()
        {
            InitializeComponent();
           
        }

        private async void DHS_2_Load(object sender, EventArgs e)
        {
           
        }

        public async void loadGauge(string IP, int Port)
        {
            int i = 10;
            // connVPG.Close();
            try
            {
                // Create a TcpClient
                //TcpClient client = new TcpClient(IP, Port);

                // Get the network stream from the TcpClient
               // NetworkStream stream = client.GetStream();

                // Buffer to store the response bytes
                client = new TcpClient(IP, Port); // Replace "DeviceIPAddress" and PortNumber with actual values
                stream = client.GetStream();

                // Start a timer to periodically update the gauge
                timerDHS.Interval = 1000; // Update every second (adjust as needed)
                timerDHS.Start();

                // Close the stream and TcpClient
                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //public void Loading()
        //{
        //    var random = new Random();
        //    var timer = new Timer { Interval = 1000 }; // Update every second
        //    timer.Tick += (sender, e) => {
        //        aggeVPG.Value = random.Next(0, 500); // Random value between 0 and 100
        //    };
        //    timer.Start();
        //}
        private async void btnIpConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Connect to the TCP/IP device
                VPGConnection conn = new VPGConnection();
                conn.ShowDialog();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the TCP/IP device: " + ex.Message);
            }
           // DateTime now = new DateTime();
          //  try
          //  {
                // Create a TcpClient
             //    TcpClient client = new TcpClient("10.10.112.19", 8888);

                // Get the network stream from the TcpClient
                //  NetworkStream stream = client.GetStream();

                // Buffer to store the response bytes
                // byte[] buffer = new byte[1024];
                // aggeVPG.Value = 0;
                //while (true)
                // {
                //  int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                // int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                // string responseData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                //string binaryString = "101010"; // Your binary string here
                // int decimalNumber = Convert.ToInt32(bytesRead.ToString(),4);
                //MessageBox.Show(bytesRead.ToString());



                // chtVPG.Series[0].Points.AddXY(now, bytesRead);
                // chtGraph.Series[0].Points.AddXY(now, bytesRead);
                // aggeVPG.Value += i;
                //Console.WriteLine("Received: " + responseData);
                // i++;
                //  var random = new Random();
                //var timer = new Timer { Interval = 1000 }; // Update every second
                //aggeVPG.Value = random.Next(0, 1000);
                //timer.Tick += (sender, e) =>
                //{
                //  int ran = random.Next(0, 1000);
                //  aggeVPG.Value = ran; // Random value between 0 and 100
                //};
                //timer.Start();
                //// MessageBox.Show(bytesRead.ToString());
                // int readValue = bytesRead;
                //aggeVPG.Value = bytesRead;
                // aggeVPG.Value = 0;
                // Thread.Sleep(1000);
                //  }

                // Close the stream and TcpClient
                //   stream.Close();
                //   client.Close();
             //   timerDHS.Interval = 1000;
              //  timerDHS.Start();
           // }
           // catch (Exception ex)
           // {
              //  MessageBox.Show(ex.Message);
           // }
        }
     
        private async void timerDHS_Tick(object sender, EventArgs e)
        {
            try
            {
                // Send request to the device
                //byte[] request = Encoding.ASCII.GetBytes("GET_VALUE"); // Adjust "GET_VALUE" according to your device's protocol
                //stream.Write(request, 0, request.Length);

                //// Receive response from the device
                //byte[] responseBuffer = new byte[1024]; // Adjust buffer size as needed
                //int bytesRead = stream.Read(responseBuffer, 0, responseBuffer.Length);
                //string responseData = Encoding.ASCII.GetString(responseBuffer, 0, bytesRead);

                //// Update the gauge with the received value
                //float gaugeValue = float.Parse(responseData); // Convert the received data to double (adjust parsing as needed)
                byte[] buffer = new byte[1024];
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                aggeVPG.Value = bytesRead;
                chtVPG.Series[0].Points.AddXY(now, bytesRead);
                chtGraph.Series[0].Points.AddXY(now, bytesRead);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error communicating with the TCP/IP device: " + ex.Message);
            }
        }
    }
}

