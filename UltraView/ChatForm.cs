using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace UltraView
{
    public partial class ChatForm : Form
    {
        //Chú ý: test trên visual& trên 1 máy sẽ không chạy được tính năng này đâu=> nên copy file debug của nó ra 2 cái rồi mở lên test
        //Ý tưởng: 
        //Loai 0: khi mở form này lên, nếu mở form này bằng btn OpenConnect bên main form thì sẽ là server, chờ kết nối từ phía client
        //Loai 1:Nếu mở bằng btn Connect thì sẽ là client và lấy các chỉ số ip, port đã nhập sẵn truyền vô sài!
        //Khai báo kết nối, có cả 2 cái
        TcpClient client;
        TcpListener server;
        private readonly Thread Listening;
        private readonly Thread GetText;
        private int port; //đem cái port gửi hình +1 để ra cái port khác sài cho gọn đường
        private byte loai;
        private string ip;
        public ChatForm(byte Loai, string IP, int Port) //loai form= 0 server, 1 client
        {

            loai = Loai;
            port = Port;
            ip = IP;
            if (loai == 0)//server
            {
                client = new TcpClient();
                Listening = new Thread(StartListening);
                GetText = new Thread(ReceiveText);
            }
            else //loai=1 , client
            {
                client = new TcpClient();
                GetText = new Thread(ReceiveText);
            }
            InitializeComponent();
            Writelogfile("OpenChatForm" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
        }
        protected override void OnLoad(EventArgs e)
        {
            
            base.OnLoad(e);
            if(loai==0)
            {
                server = new TcpListener(IPAddress.Any, port);
                Listening.Start();
                
            }
            else
            {
                try
                {
                    client.Connect(ip, port);
                    GetText.Start();
                }
                catch (Exception)
                {
                }
            }
        }
        //Bắt kết nối và ngắt kết nối
        private void StartListening()
        {
            try
            {
                while (!client.Connected)
                {
                    server.Start();
                    client = server.AcceptTcpClient();
                }
                GetText.Start();
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
            if (GetText.IsAlive) GetText.Abort();
            MessageBox.Show("Disconnect success!");
        }

        //Nhận tin nhắn
        private NetworkStream istream;
        private void ReceiveText()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            while (client.Connected)
            {
                try
                {
                    istream = client.GetStream();
                    string str = (String)binFormatter.Deserialize(istream);
                    string result = str.Substring(0, 3);
                    if(result=="MS:")
                    {
                        tbxShowMessage.Text += "\nĐối tác: " + str.Substring(3);
                    }
                }
                catch { }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopListening();
            Writelogfile("FormChatClose" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
        }
        
        //Gửi tin nhắn
        private NetworkStream stream;

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            if (tbxMessage.Text != "")
            {
                try
                {
                    sendText("MS:" + tbxMessage.Text);
                }
                catch
                {
                    tbxShowMessage.Text += "\nTin nhắn không gửi được!";
                    return;
                }
                tbxShowMessage.Text += "\nTôi: " + tbxMessage.Text;
                tbxMessage.Text = "";
            }

        }
        private void sendText(string str)
        {
            //dang la server //server se lay stream cua client va truyen vo do
            //dang la client// client se su dung stream cua minh de truyen cho server
            if (client.Connected)
            {
                BinaryFormatter binFormatter = new BinaryFormatter();
                stream = client.GetStream();
                binFormatter.Serialize(stream, str);
            }

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



