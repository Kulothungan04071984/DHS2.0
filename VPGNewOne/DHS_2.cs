using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VPGNewOne
{
    public partial class DHS_2 : Form
    {
        VPGConnection connVPG = new VPGConnection();
        public DHS_2()
        {
            InitializeComponent();
        }

        private void DHS_2_Load(object sender, EventArgs e)
        {

         
        }

        public async void loadGauge(string IP, int Port)
        {
            int i = 10;
            connVPG.Close();
            try
            {
                // Create a TcpClient
                TcpClient client = new TcpClient(IP, Port);

                // Get the network stream from the TcpClient
                NetworkStream stream = client.GetStream();

                // Buffer to store the response bytes
                byte[] buffer = new byte[1024];

                while (true)
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string responseData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    aggeVPG.Value = Convert.ToUInt32(responseData);
                    // aggeVPG.Value += i;
                    //Console.WriteLine("Received: " + responseData);
                    // i++;
                    //var random = new Random();
                    //var timer = new Timer { Interval = 1000 }; // Update every second
                    //timer.Tick += (sender, e) => {
                    //    aggeVPG.Value = random.Next(0, 1000); // Random value between 0 and 100
                    //};
                    //timer.Start();
                }

                // Close the stream and TcpClient
               // stream.Close();
               // client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Loading()
        {
            var random = new Random();
            var timer = new Timer { Interval = 1000 }; // Update every second
            timer.Tick += (sender, e) => {
                aggeVPG.Value = random.Next(0, 500); // Random value between 0 and 100
            };
            timer.Start();
        }
        private void btnIpConnect_Click(object sender, EventArgs e)
        {
            try
            {
               // Loading();

                connVPG.ShowDialog();
               

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            //Console.ReadLine();
        }
    }
}
