using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            txtMyIP.Text = GetIP();
        }

        //Tab1_Open connect for other device
        #region Tab1_Open connect for other device
        public static int RemoteScreenFormCount=0;
        //Lấy ra IP của card mạng đang dùng
        public string GetIP()
        {
            string output = GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (output == "")
            {
                output = GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }

            return output;
        }
        private string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }

        private void btnOpenConnect_Click_1(object sender, EventArgs e)
        {
            if (RemoteScreenFormCount != 0)//Nếu đã có 1 form mở lên rồi thì k connect nữa
            {
                MessageBox.Show("You can't open more than 1 connection!");
                return;
            }
            int port;
            try
            {
                port = int.Parse(txtMyPort.Text);
            }
            catch
            {
                MessageBox.Show("Your port is not correct!");
                return;
            }
            new RemoteScreenForm(port).Show();
            RemoteScreenFormCount++;
        }
        #endregion
        
    }
}
