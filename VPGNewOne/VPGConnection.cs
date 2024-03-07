using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPGNewOne
{
    public partial class VPGConnection : Form
    {
        public VPGConnection()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string serverIP = txtIP.Text.ToString(); // Change this to your server's IP address
                int port = Convert.ToInt32(txtPORT.Text.ToString()); // Change this to your server's port number
                //this.Close();
                DHS_2 dHS_2 = new DHS_2();
                dHS_2.loadGauge(serverIP,port);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
