using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraView
{
    public partial class RemoteScreenForm : Form
    {
        private readonly int port;
        private TcpClient client;
        private TcpListener server;
        private NetworkStream mainStream;

        private readonly Thread Listening;
        private readonly Thread GetImage;

        public RemoteScreenForm(int Port)
        {
            port = Port;
            client = new TcpClient();
            Listening = new Thread(StartListening);
            GetImage = new Thread(ReceiveImage);
            MessageBox.Show("Open connection success!");
            InitializeComponent();
        }

        private void StartListening()
        {
            try
            {
                while (!client.Connected)
                {
                    server.Start();
                    client = server.AcceptTcpClient();
                }
                GetImage.Start();
            }
            catch
            {
                MessageBox.Show("Listening failed!");
            }
            
        }
        private void StopListening()
        {
            server.Stop();
            client = null;
            if (Listening.IsAlive) Listening.Abort();
            if (GetImage.IsAlive) GetImage.Abort();
            MessageBox.Show("Disconnect success!");
        }
        private void ReceiveImage()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            while (client.Connected)
            {
                try
                {
                    mainStream = client.GetStream();
                    picShowScreen.Image = (Image)binFormatter.Deserialize(mainStream);
                }
                catch { }               
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            server = new TcpListener(IPAddress.Any, port);
            Listening.Start();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopListening();
        }
       
        private void RemoteScreenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.RemoteScreenFormCount--;
        }
    }
}
