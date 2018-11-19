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

        //Tab2_Connect to other device
        #region Tab2_Connect to other device
        private readonly TcpClient client = new TcpClient();
        private NetworkStream ostream;
        private int portNumber;
        private int width;
        private int height;
        //Get screen size
        public  Size GetDpiSafeResolution()
        {
            using (Graphics graphics = this.CreateGraphics())
            {
                return new Size((Screen.PrimaryScreen.Bounds.Width * (int)graphics.DpiX) / 96
                  , (Screen.PrimaryScreen.Bounds.Height * (int)graphics.DpiY) / 96);
            }
        }
        private Image CaptureScreen()
        {
            
            height = GetDpiSafeResolution().Height+215;
            width = GetDpiSafeResolution().Width+385;
            Rectangle bounds = new Rectangle(0,0,width,height);
            Bitmap screenShot = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(screenShot);
            graphics.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);
            return screenShot;
        }
        private Image CaptureScreen(int width,int height)
        {
            Rectangle bounds = new Rectangle(0, 0, width, height);
            Bitmap screenShot = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(screenShot);
            graphics.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);
            return screenShot;
        }
        private void SendDesktopImage()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            ostream = client.GetStream();
            if(txtWidth2.Text!=""&&txtHeight2.Text!="")
            {
                //Không cần phải check thêm nhiều điều kiện vì ngay chỗ click btn share screen đã check rồi
                binFormatter.Serialize(ostream, CaptureScreen(int.Parse(txtWidth2.Text),int.Parse(txtHeight2.Text)));
            }
            else
                binFormatter.Serialize(ostream, CaptureScreen());
        }
        private void btnConnect2_Click(object sender, EventArgs e)//nhớ Xét các textbox
        {
            portNumber = int.Parse(txtPort2.Text);
            try
            {
                client.Connect(txtIP2.Text, portNumber);
                MessageBox.Show("Connected!");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to connect...");
            }
        }
        //Share screen 
        private void btnShareScreen2_Click(object sender, EventArgs e)
        {
            if(txtWidth2.Text!=""||txtHeight2.Text!="")
            {
                try
                {
                    int.Parse(txtWidth2.Text);
                    int.Parse(txtHeight2.Text);
                }
                catch
                {
                    MessageBox.Show("You should fill width and height text box or you can empty both.");
                    return;
                }
            }
            if (btnShareScreen2.Text.StartsWith("Share"))//Nếu btn...Text có dạng "Share%" thì... 
            {
                timer1.Start();
                btnShareScreen2.Text = "Stop sharing";
            }
            else
            {
                timer1.Stop();
                btnShareScreen2.Text = "Share my screen";
            }
        }
        //đếm giờ, cài tick của nó khoảng 40 là vừa 
        private void timer1_Tick(object sender, EventArgs e)
        {
            SendDesktopImage();
        }
        #endregion
    }
}
