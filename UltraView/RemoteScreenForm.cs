using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        #region Connect and ReceiveImage
        private readonly int port;
        private TcpClient client;
        private TcpListener server;
        private NetworkStream mainStream;
        private readonly Thread Listening;
        private readonly Thread GetImage;
        private Size receivedImageSize;//xét xem có cần k
        private bool gotten = false;
        public RemoteScreenForm(int Port)
        {
            port = Port;
            client = new TcpClient();
            Listening = new Thread(StartListening);
            GetImage = new Thread(ReceiveImage);
            //MessageBox.Show("Open connection success!");
            InitializeComponent();
            this.ActiveControl = picShowScreen;
            Writelogfile("OpenFormRemote " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
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
                //MessageBox.Show("Listening failed!");
                StopListening();
            }
            
        }
        
        public void StopListening()
        {
            try
            {
                server.Stop();
                client.Close();
                client = null;
                if (Listening.IsAlive) Listening.Abort();


                if (GetImage.IsAlive) GetImage.Abort();
                MessageBox.Show("Disconnect success!");
            }
            catch { }
        }

        private void ReceiveImage()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            while (client.Connected)
            {
                try
                {

                    mainStream = client.GetStream();
                    if (gotten==true)
                    {
                        picShowScreen.Image = (Image)binFormatter.Deserialize(mainStream);
                    }
                    else
                    {
                        Image receivedImage = (Image)binFormatter.Deserialize(mainStream);
                        picShowScreen.Image = receivedImage;
                        receivedImageSize.Height = receivedImage.Height;
                        receivedImageSize.Width = receivedImage.Width;
                        gotten = true;
                    }
                }
                catch { }               
            }
            //Thêm để thoong báo khi bên client out
            MessageBox.Show("Connection has been lost!");
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            server = new TcpListener(IPAddress.Any, port);
            Listening.Start();
            //Show size on statusbar
            lbSize.Text = "\tSize: " + picShowScreen.Width + "x" + (picShowScreen.Height);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopListening();
            Writelogfile("FormRemoteClose " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
        }
        private void RemoteScreenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.RemoteScreenFormCount--;
        }
        #endregion


        #region SendClick
        
        private NetworkStream ostream;
        private void sendText(string str)
        {
            if(client.Connected)
            {
                BinaryFormatter binFormatter = new BinaryFormatter();
                ostream = client.GetStream();
                binFormatter.Serialize(ostream, str);
            }
        }
        private void picShowScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (!cbxMouse.Checked)
                return;
            //Lay toa do
            int posX = this.PointToClient(Cursor.Position).X;
            int posY = this.PointToClient(Cursor.Position).Y;
            lbMouseMove.Text = "\tPoint: " + posX + ":" + posY;
            sendText("MM:" + posX + ":" + posY + ":" + picShowScreen.Width + ":" + picShowScreen.Height);
        }

        private void picShowScreen_MouseClick(object sender, MouseEventArgs e)
        {
            if (!cbxMouse.Checked)
                return;
            //Lay toa do
            int posX = this.PointToClient(Cursor.Position).X;
            int posY = this.PointToClient(Cursor.Position).Y;
            //if (e.Button == MouseButtons.Left)
            //{
            //    lbStatus.Text = "Left click " + posX + " : " + posY;
            //    sendText("LC:" + posX + ":" + posY+ ":"+ picShowScreen.Width+":"+ picShowScreen.Height);
            //}
            /*else*/ if (e.Button == MouseButtons.Right)
            {
                lbStatus.Text = "Right click " + posX + " : " + posY;
                sendText("RC:" + posX + ":" + posY + ":" + picShowScreen.Width + ":" + picShowScreen.Height);
            }
            else if(e.Button==MouseButtons.Middle)
            {
                lbStatus.Text = "Middle click " + posX + " : " + posY;
                sendText("MC:" + posX + ":" + posY + ":" + picShowScreen.Width + ":" + picShowScreen.Height);
            }

        }
        private void picShowScreen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!cbxMouse.Checked)
                return;
            int posX = this.PointToClient(Cursor.Position).X;
            int posY = this.PointToClient(Cursor.Position).Y;
            //if (e.Button == MouseButtons.Left)
            //{
            //    lbStatus.Text = "Double left click " + posX + " : " + posY;
            //    sendText("DL:" + posX + ":" + posY + ":" + picShowScreen.Width + ":" + picShowScreen.Height);
            //}
            /*else*/ if (e.Button == MouseButtons.Right)
            {
                lbStatus.Text = "Double right click " + posX + " : " + posY;
                sendText("DR:" + posX + ":" + posY + ":" + picShowScreen.Width + ":" + picShowScreen.Height);
            } 
        }

        //Giu chuot
        private void picShowScreen_MouseDown(object sender, MouseEventArgs e)
        {
            if (!cbxMouse.Checked)
                return;
            //Lay toa do
            int posX = this.PointToClient(Cursor.Position).X;
            int posY = this.PointToClient(Cursor.Position).Y;
            if (e.Button == MouseButtons.Left)
            {
                lbStatus.Text = "Mouse Left Down " + posX + " : " + posY;
                sendText("LD:" + posX + ":" + posY + ":" + picShowScreen.Width + ":" + picShowScreen.Height);
                //richTextBox1.Text += "Mouse Down " + posX + " : " + posY+"\n";
            }
        }

        private void picShowScreen_MouseUp(object sender, MouseEventArgs e)
        {
            if (!cbxMouse.Checked)
                return;
            //Lay toa do
            int posX = this.PointToClient(Cursor.Position).X;
            int posY = this.PointToClient(Cursor.Position).Y;
            if (e.Button == MouseButtons.Left)
            {
                lbStatus.Text = "Mouse Left Up " + posX + " : " + posY;
                sendText("LU:" + posX + ":" + posY + ":" + picShowScreen.Width + ":" + picShowScreen.Height);
                //richTextBox1.Text += "Mouse Up " + posX + " : " + posY+"\n";
            }
        }

        #endregion

        #region SendKey
      
        private void RemoteScreenForm_KeyDown(object sender, KeyEventArgs e)
        {
            //Nếu không cho điều khiển phím thì return
            if (cbxKeyBoard.Checked == false)
                return;

            //Nếu cho phép điều khiển
            try
            {
                string keystr = "KD:" + e.KeyValue.ToString();
                //richTextBox1.Text += keystr + "\n";
                sendText(keystr);
            }
            catch { }
            
        }

        private void RemoteScreenForm_KeyUp(object sender, KeyEventArgs e)
        {
            //Nếu không cho điều khiển phím thì return
            if (cbxKeyBoard.Checked == false)
                return;

            //Nếu cho phép điều khiển
            try
            {
                string keystr = "KU:" + e.KeyValue.ToString();
                //richTextBox1.Text += keystr + "\n";
                sendText(keystr);
            }
            catch { }
            
        }
        #endregion
        
        #region Status Strip
        //label lay picture box size => set gia tri trong OnLoad va SizeChanged
        private void RemoteScreenForm_SizeChanged(object sender, EventArgs e)
        {
            //Show size on statusbar
            lbSize.Text = "\tSize: " + picShowScreen.Width + "x" + (picShowScreen.Height);
        }




        //label point =>MouseMove
        //label status
        #endregion

        private void cbxMouse_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = picShowScreen;
            if(cbxMouse.Checked)
                Writelogfile("cbxMouse_Check" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
            else
                Writelogfile("cbxMouse_UnCheck" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
        }

        private void cbxKeyBoard_CheckedChanged(object sender, EventArgs e)
        {
            this.ActiveControl = picShowScreen;
            if (cbxMouse.Checked)
                Writelogfile("cbxKeyBoard_Check" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
            else
                Writelogfile("cbxKeyBoard_UnCheck" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
        }

        //WriteLog
        private void Writelogfile(string txt)
        {
            using (FileStream fs = new FileStream(@"log.txt", FileMode.Append))
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                {
                    writer.WriteLine(txt);
                }
            }
        }
    }
}
