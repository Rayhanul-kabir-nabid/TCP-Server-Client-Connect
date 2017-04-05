using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;

namespace final._2
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private TcpClient client;
        string ip;
        string port;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            ip = textbox_ip.Text;
            port = textbox_port.Text;
            client   = new TcpClient();
            try
            {
                IPEndPoint ip_end = new IPEndPoint(IPAddress.Parse(ip), int.Parse(port));
                client.Connect(ip_end);
                if (client.Connected)
                {
                    MessageBox.Show("Connected");
                }
                else
                {
                    MessageBox.Show("Not connected");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
