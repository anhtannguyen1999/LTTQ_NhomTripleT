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

        private void Update_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(UltraViewLTTQ))
            {
                //tạo file current.txt
                StreamWriter st = new StreamWriter(currenttxt);
                st.WriteLine(label1.Text);
                st.Close();
                if (Directory.Exists(apppath))
                {

                }
                else
                {
                    Directory.CreateDirectory(apppath);
                }
            }
            else
            {
                Directory.CreateDirectory(UltraViewLTTQ);
                Directory.CreateDirectory(apppath);

            }
            //

            // code kiểm tra kết nối mạng
            if (InternetConnection.IsConnectedToInternet())
            {
                //tai ve ma hieu moi
                WebClient ud = new WebClient();
                ud.DownloadFileCompleted += new AsyncCompletedEventHandler(udcom);
                Uri update = new Uri(updatetxtlink);
                ud.DownloadFileAsync(update, updatetxt);
            }
            else
                MessageBox.Show("Không thể kiểm tra bản cập nhật do chưa kết nối mạng");
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
        string apppath = @"UltraViewLTTQ\app";          //Tạo thư mục lưu chương trình sẽ giải nén của bạn.
        string apprar = @"UltraViewLTTQ\app.rar";       //tên file.rar chương trình của bạn sẽ được tải về từ google drive
        string rarpath = @"UltraViewLTTQ\rarpath";      //tạo thư mục lưu file cài đặt winrar  
        string rarexe = @"UltraViewLTTQ\rarpath\WinRaR.exe"; //file khởi động winrar
        string updateeexe = @"UltraViewLTTQ\app\UltraView.exe"; //file khởi động chương trình của bạn.
        string updatetxtlink = "https://docs.google.com/uc?export=download&id=1xN64qP6z4n6yKF-3ydilrXnw6RhGbMnt";
        string applink = "https://docs.google.com/uc?export=download&id=1vJk30TWlaUHApmL6zLhyH9BV3m9T7wUe";
        string cai1 = Application.StartupPath + @"\cai.exe"; //duong dan den file ơ thu muc cung với chương trình
        string cai2 = @"UltraViewLTTQ\app\cai.exe";     //duong dan copy den thuc muc khoi dong
       
        //tai ve hoàn tất file update.txt
        private void udcom(object sender, AsyncCompletedEventArgs e)
        {
            //doc file này cho vào label 2
            //StreamReader str = new StreamReader(currenttxt);
            //label1.Text = str.ReadLine();
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
                    //copy chương trình cài đặt trung gian vào c:\\nguon
                    if (File.Exists(cai1))
                        File.Copy(cai1, cai2, true);
                    else
                        File.Copy(cai1, cai2);
                    //chạy cài trung gian

                    Process.Start(cai1);

                    // thoát chương trình này
                    Application.Exit();
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
