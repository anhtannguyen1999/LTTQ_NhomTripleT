using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
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
        public static int RemoteScreenFormCount = 0;
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
            Writelogfile("Open connect Port:" + port+" " + DateTime.Now.ToShortTimeString());
            RemoteScreenFormCount++;
        }
        #endregion

        //Tab2_Connect to other device
        #region Tab2_Connect to other device_Có sửa đổi
        private readonly TcpClient client = new TcpClient();
        private NetworkStream ostream;
        private int portNumber;
        private int width;
        private int height;
        //Get screen size
        public Size GetDpiSafeResolution()
        {
            using (Graphics graphics = this.CreateGraphics())
            {
                return new Size((Screen.PrimaryScreen.Bounds.Width * (int)graphics.DpiX) / 96
                  , (Screen.PrimaryScreen.Bounds.Height * (int)graphics.DpiY) / 96);
            }
        }
        private Image CaptureScreen()
        {
            height = GetDpiSafeResolution().Height;//Đã sửa
            width = GetDpiSafeResolution().Width;//Đã sửa
            Rectangle bounds = new Rectangle(0, 0, width, height);
            Bitmap screenShot = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(screenShot);
            graphics.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);
            return screenShot;
        }
        private Image CaptureScreen(int width, int height)
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
            if (txtWidth2.Text != "" && txtHeight2.Text != "")
            {
                //Không cần phải check thêm nhiều điều kiện vì ngay chỗ click btn share screen đã check rồi
                binFormatter.Serialize(ostream, CaptureScreen(int.Parse(txtWidth2.Text), int.Parse(txtHeight2.Text)));
            }
            else
                binFormatter.Serialize(ostream, CaptureScreen());
        }
        private void btnConnect2_Click(object sender, EventArgs e)//nhớ Xét các textbox
        {
            try
            {
                portNumber = int.Parse(txtPort2.Text);
                client.Connect(txtIP2.Text, portNumber);
                MessageBox.Show("Connected!");
                Writelogfile("Ket noi toi thiet bi:\n" + "IP: " + txtMyIP.Text + "\t Port: " + txtMyPort.Text+DateTime.Now.ToShortTimeString());
            }
            catch (Exception)
            {
               
                MessageBox.Show("Failed to connect...");
            }
        }
        //Share screen 
        private void btnShareScreen2_Click(object sender, EventArgs e)
        {
            if (txtWidth2.Text != "" || txtHeight2.Text != "")
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
                StartListenText();//Listen texxt
            }
            else
            {
                timer1.Stop();
                btnShareScreen2.Text = "Share my screen";
                //StopListenText();//Stop listen
            }
        }
        //đếm giờ, cài tick của nó khoảng 40 là vừa 
        private void timer1_Tick(object sender, EventArgs e)
        {
            SendDesktopImage();
        }
        
        #endregion

        #region Tuan_Menu_and_Ghilog
        private void Vietnames_CheckedChanged(object sender, EventArgs e)
        {
            
                btnConnect2.Text = "Kết nối";
                btnShareScreen2.Text = "Chia sẻ màn hình";
                btnOpenConnect.Text = "Mở kết nối";
                label1.Text = "Mở kết nối";
                label2.Text = "Kết nối tới thiết bị khác";
                label3.Text = "IP của tôi";
                label4.Text = "Cổng";
                label5.Text = "Chờ kết nối và chia sẻ màn hình";
                label6.Text = "IP đối tác";
                label7.Text = "Cổng";
                label14.Text = "Nếu không thể xem đầy màn hình vui lòng nhập kích thước";
                optionToolStripMenuItem.Text = "Tùy chọn";
                languagesToolStripMenuItem.Text = "Ngôn ngữ";
                aboutToolStripMenuItem.Text = "Thông tin";
                helpToolStripMenuItem.Text = "Trợ giúp";
                exitToolStripMenuItem.Text = "Thoát";

                this.English.Checked = false;
          
        }

        private void English_CheckedChanged(object sender, EventArgs e)
        {
           

                btnConnect2.Text = "Connect";
                btnShareScreen2.Text = "Share your screen";
                btnOpenConnect.Text = "Open connect";
                label1.Text = "OPEN CONNECT";
                label2.Text = "CONECT TTO OTHER ";
                label3.Text = "MY IP";
                label4.Text = "Port";
                label5.Text = "Waiting other device connect and share screen to your device.";
                label6.Text = "Partner IP";
                label7.Text = "Port";
                label14.Text = "If you can't see full screen please type your screen....";
                optionToolStripMenuItem.Text = "Option";
                languagesToolStripMenuItem.Text = "Languages";
                aboutToolStripMenuItem.Text = "About";
                helpToolStripMenuItem.Text = "Help";
                exitToolStripMenuItem.Text = "Exit";
                this.Vietnames.Checked = false;
           
        }

       
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhóm lập trình trực quan Triple T: Nguyễn Anh Tấn 1752                       Lộc Đức Thắng 17520039                                                                          Nguyễn Văn Tuấn 17521218");
        }

        string logName = "Theodoihoatdong " +"Tháng "+ DateTime.Now.Month.ToString() + ".txt";

        private void MainForm_Load(object sender, EventArgs e)
        {

            if (!Directory.Exists(@"D:\Ultraview"))
            {
                Directory.CreateDirectory(@"D:\Ultraview");
            }
            if (!Directory.Exists(@"D:\Ultraview\Theodoinguoidung"))
            {
                Directory.CreateDirectory(@"D:\Ultraview\Theodoinguoidung");
            }
            Writelogfile(DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
        }
        public void Writelogfile(string log)
        {




            FileStream fs = new FileStream(@"D:\Ultraview\Theodoinguoidung\" + logName, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(log);
            sw.Close();
            fs.Close();
        }
        private void Vietnames_Click(object sender, EventArgs e)
        {

            btnConnect2.Text = "Kết nối";
            btnShareScreen2.Text = "Chia sẻ màn hình";
            btnOpenConnect.Text = "Mở kết nối";
            label1.Text = "Mở kết nối";
            label2.Text = "Kết nối tới thiết bị khác";
            label3.Text = "IP của tôi";
            label4.Text = "Cổng";
            label5.Text = "Chờ kết nối và chia sẻ màn hình";
            label6.Text = "IP đối tác";
            label7.Text = "Cổng";
            label14.Text = "Nếu không thể xem đầy màn hình vui lòng nhập kích thước";
            optionToolStripMenuItem.Text = "Tùy chọn";
            languagesToolStripMenuItem.Text = "Ngôn ngữ";
            aboutToolStripMenuItem.Text = "Thông tin";
            helpToolStripMenuItem.Text = "Trợ giúp";
            exitToolStripMenuItem.Text = "Thoát";
        }
        private void English_Click(object sender, EventArgs e)
        {
            btnConnect2.Text = "Connect";
            btnShareScreen2.Text = "Share your screen";
            btnOpenConnect.Text = "Open connect";
            label1.Text = "OPEN CONNECT";
            label2.Text = "CONECT TO OTHER ";
            label3.Text = "MY IP";
            label4.Text = "Port";
            label5.Text = "Waiting other device connect and share screen to your device.";
            label6.Text = "Partner IP";
            label7.Text = "Port";
            label14.Text = "If you can't see full screen please type your screen....";
            optionToolStripMenuItem.Text = "Option";
            languagesToolStripMenuItem.Text = "Languages";
            aboutToolStripMenuItem.Text = "About";
            helpToolStripMenuItem.Text = "Help";
            exitToolStripMenuItem.Text = "Exit";
        }
        #endregion

        #region ReceiveClick
        private Thread ListeningToText;
        private NetworkStream instream;

        //import thu vien de xu ly click
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;
        const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        const uint MOUSEEVENTF_MIDDLEUP = 0x0040;
        const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        const uint MOUSEEVENTF_RIGHTUP = 0x0010;

        private void StartListenText() //btnShareScreen2_Click
        {
            ListeningToText = new Thread(ReceiveText);
            ListeningToText.Start();
        }
        private void StopListenText()//btnShareScreen2_Click
        {
            if (ListeningToText!=null&&ListeningToText.IsAlive)
                ListeningToText.Abort();
        }
        
        private void ReceiveText()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            while (client.Connected)
            {
                try
                {
                    instream = client.GetStream();
                    string str=(String)binFormatter.Deserialize(instream);
                    string[] strArr = str.Split(':');

                    #region Xu ly click
                    int x = (int)(width * Int32.Parse(strArr[1]) / Int32.Parse(strArr[3]));
                    int y = (int)(height * Int32.Parse(strArr[2]) / Int32.Parse(strArr[4]));
                    switch (strArr[0])
                    {
                        case "MM"://mouse move
                            {
                                Cursor.Position = new Point(x, y);
                            }
                            break;
                        case "LD"://left down
                            {
                                Cursor.Position = new Point(x, y);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            }
                            break;
                        case "LU"://left up
                            {
                                Cursor.Position = new Point(x, y);
                                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            }
                            break;
                        case "RC"://right click
                            {
                                Cursor.Position = new Point(x, y);
                                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                            }
                            break;
                        case "MC"://Middle click
                            {
                                Cursor.Position = new Point(x, y);
                                mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
                            }
                            break;
                        case "LC": //left click
                            {
                                Cursor.Position = new Point(x, y);
                                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            }
                            break;
                        case "DL"://double left click
                            {
                                Cursor.Position = new Point(x, y);
                                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            }
                            break;
                        case "DR"://double right click
                            {
                                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                            }
                            break;
                        default:
                            break;
                    }
                      
                    #endregion
                }
                catch { }
            }
        }
        #endregion
    }
}

