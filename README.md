# LTTQ_NhomTripleT
Đồ án cuối kỳ môn Lập trình trực quan của nhóm TripleT- Lớp IT008.J11

Phần mềm điều khiển máy tính từ xa UltraView

GVHD: thầy Huỳnh Tuấn Anh.

SV1: Nguyễn Anh Tấn-17521013

SV2: Lộc Đức Thắng-17521039

SV3: Nguyễn Văn Tuấn-17521218

-> Link youtube: https://www.youtube.com/watch?v=c3QPU6xLJF4

-> Phiên bản khác, tốc độ nhanh hơn bằng java: https://github.com/anhtannguyen1999/my-java-ultra-view


# GIAO DIỆN CHƯƠNG TRÌNH VÀ CHỨC NĂNG CHÍNH
1.	Màn hình giao diện chính
 
a)	Open Connect	Mở kết nối để máy khác kết nối
(Điều khiển máy khác)

b)	Connect	Kết nối tới máy mở kết nối
(Để máy khác điều khiển)

c)	Share your screen	Truyền màn hình khi đã connect

d)	Option	Đổi ngôn ngữ, Thông tin phần mềm,
Help,Thoát

e)	 	Thông tin phiên bản , update phần mềm





2.	Chi tiết chức năng

a)	Open Connect
-	Trước khi kết nối
 
My IP là địa chỉ của máy mình để máy khác kết nối (Phầm mềm sẽ tự động lấy IP)
My Port tùy chọn 

-	Sau khi Open Connect:
Form RemoteScreen để nhận màn hình từ Client và điều khiển Client
ChatForm dùng để nhận và gửi tin nhắn với Client
 
-	Để điều khiển chuột và bàn phím tích vào Mouse Remote và Keyboard remote
 
-	Sau khi có máy kết nối tới
 

b)	Connect
-	Trước khi connect
 
Partner IP: nhập IP của máy mở kết nối(server)
My Port:  Nhập Port đã mở của Server
-	Sau khi Connect
 
Share your screen: Để cho phép máy server nhận màn hình và điều khiển
Stop sharing: Để dừng truyền màn hình
Nút màu xanh bên cạnh button connect sẽ chuyển từ màu vàng sang xanh
*Note: Chỉ khi server không nhận được full screen thì nhập thêm kích thước màn hình vào Width và Height
-	Khi mất kết nối: sau một thời gian time out sẽ tự động đóng connect và stop sharing	
c)	Option

 
	Languages: Chức năng đổi ngôn ngữ
	Tiếng Việt:
 
	Tiếng Anh:
 
	Help: Chức năng phát triển thêm
	About: Thông tin về nhóm TripleT, thông tin phần mềm
 
	Exit: Thoát khỏi ứng dụng

d)	Update
  Khi có bản cập nhất thì sẽ hỏi người dùng tải xuống bản update mới
 

e)	Ghi lại nhật kí sử dụng phần mềm 
 
