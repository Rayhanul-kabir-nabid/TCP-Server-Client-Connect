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
using MetroFramework.Components;

using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Net.NetworkInformation;

namespace final._1
{
    public partial class Form1 : MetroForm
    {
        private TcpClient[] client;
        private string port;
        private int clientno;
        public Form1()
        {
            InitializeComponent();

            IPAddress[] localip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    textbox_ip.Text = address.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            port = textbox_port.Text;
            clientno = int.Parse(textbox_noofclient.Text);
            MessageBox.Show("Done");
            //text_box_clientlist.AppendText ("Waiting for connection...\n");
        }

        private void button_start_server_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient[clientno];
                text_box_clientlist.AppendText("Waiting for connection...\n");
                TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(port));
                listener.Start();
                int i = 0;
                for (; i < clientno; i++)
                {
                    client[i] = listener.AcceptTcpClient();
                    if (client[i].Connected)
                    {
                        text_box_clientlist.AppendText("Client no " + i + " IP " + ((IPEndPoint)client[i].Client.RemoteEndPoint).Address.ToString() + "\n");
                       
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }
        // for next version .. extra work is needed to be done for next lab here is the beginnng 
        //public bool isClientConnected()
        //{
        //    IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();

        //    TcpConnectionInformation[] tcpConnections = ipProperties.GetActiveTcpConnections();

        //    foreach (TcpConnectionInformation c in tcpConnections)
        //    {
        //        TcpState stateOfConnection = c.State;

        //        if (c.LocalEndPoint.Equals(ClientSocket.Client.LocalEndPoint) && c.RemoteEndPoint.Equals(ClientSocket.Client.RemoteEndPoint))
        //        {
        //            if (stateOfConnection == TcpState.Established)
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }

        //        }

        //    }

        //    return false;


        //}
    }
}
