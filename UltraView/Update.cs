using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraView
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }


        class InternetConnection
        {
            [DllImport("wininet.dll")]
            private extern static bool InternetGetConnectedState(out int description, int reservedValuine);
            public static bool IsConnectedToInternet()
            {
                int desc;
                return InternetGetConnectedState(out desc, 0);
            }
        }
        string UltraViewLTTQ = @"UltraViewLTTQ";                //tạo thư mục nguồn lưu tất cả chương trình và cập nhật
        string updatetxt = @"UltraViewLTTQ\update.txt";    //tạo file.txt ghi mã hiệu bản cập nhật mới
        string currenttxt = @"UltraViewLTTQ\current.txt";  //tạo file.txt ghi mã hiệu bản hiện tại đang dùng.
        string apppath = @"UltraViewLTTQ";          //Tạo thư mục lưu chương trình sẽ giải nén của bạn.
        string applink = "https://docs.google.com/uc?export=download&id=1SXmr8SJbetgtJL0Y1QbBH44SsOqoqGDF";
        string cailink = "https://docs.google.com/uc?export=download&id=1IXrGlrHv3ZEMoh5bMAq-wI_LWHU8EEmM";


        string updatetxtlink = "https://docs.google.com/uc?export=download&id=1xN64qP6z4n6yKF-3ydilrXnw6RhGbMnt";

        string cai1 = Application.StartupPath + @"\cai.exe"; //duong dan den file ơ thu muc cung với chương trình
        string cai2 = @"UltraViewLTTQ\app\cai.exe";     //duong dan copy den thuc muc khoi dong
        private void Update_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(UltraViewLTTQ))
            {
                //tạo file current.txt
                StreamWriter st = new StreamWriter(currenttxt);

                st.Close();

            }
            else
            {
                Directory.CreateDirectory(UltraViewLTTQ);


            }
            //

            // code kiểm tra kết nối mạng
            if (InternetConnection.IsConnectedToInternet())
            {
                //tai ve ma hieu moi


                WebClient ud = new WebClient();
                // MessageBox.Show("...");

                ud.DownloadFileCompleted += new AsyncCompletedEventHandler(udcom);
                Uri update = new Uri(updatetxtlink);
                ud.DownloadFileAsync(update, updatetxt);

            }
            else
                MessageBox.Show("Không thể kiểm tra bản cập nhật do chưa kết nối mạng");
        }
        //tai ve hoàn tất file update.txt
        private void udcom(object sender, AsyncCompletedEventArgs e)
        {

            //doc file này cho vào label 2
            
            //StreamReader rd = new StreamReader(currenttxt);
            //label1.Text = rd.ReadLine();
            //rd.Close();
            StreamReader st = new StreamReader(updatetxt);
            label2.Text = st.ReadLine();
            st.Close();
            //thưc hien kiểm tra phiên bản de thong bao cap nhat
            if (label1.Text == label2.Text)
            {
                //nếu bằng nhau thì không có bản cập nhật
                MessageBox.Show("Không có bản cập nhật mới");
            }
            else //nếu không bằng nhau
            {

                //thong báo có bản cập nhật và phiên bản mới
                DialogResult di = MessageBox.Show("Phiên bản cập nhật mới " + label2.Text + " Đã sẵng sàn cài đặt",
                    "Bản cập nhật mới", MessageBoxButtons.YesNo);
                if (di == DialogResult.Yes) //neu nhan yes thì cập nhật
                {
                    Process myProcess = new Process();

                    try
                    {
                        // true is the default, but it is important not to set it to false 
                        myProcess.StartInfo.UseShellExecute = true;
                        myProcess.StartInfo.FileName = applink;
                        myProcess.Start();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Can not download update file");
                    }
                }
                
            }
        }
    }
}