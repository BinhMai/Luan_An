Mô tả
Hệ thống thông tin sinh viên khoa Toán – Cơ – Tin học và theo vết sinh viên ra trường là bộ công cụ lưu trữ thông tin của các sinh viên đã ra trường 10 năm gần đây nhằm hỗ trợ người quản lý sinh viên lưu trữ và kiểm soát thông tin sinh viên một cách hiệu quả và đơn giản nhất. Từ đó giúp người quản lý sinh viên biết được sinh viên ra trường nên làm những công việc nào phù hợp với sở thích và năng lực của họ.
Hệ thống cho phép người dùng có thể theo dõi thông tin sinh viên dưới nhiều góc nhìn khác nhau:
•	Quản lý thông tin sinh viên: thêm, sửa , xóa và tìm kiếm
•	Hỗ trợ tư vấn việc làm ứng với từng đối tượng sinh viên
Chương trình có thể sử dụng file Exel(dưới dạng xml) để nhập dữ liệu sinh viên
Tương tác
Sử dụng các nút nhấn trên trang chủ để thực hiện các hành động như: mở màn hình tư vấn, quản lý sinh viên, hướng dẫn và thoát chương trình.
Tại giao diện tư vấn, tích chọn các ô thông tin để được tư vấn.
Tại giao diện Kết quả tư vấn, sử dụng nút nhấn để xem thêm gợi ý khác hoặc quay lại màn hình tư vấn ban đầu. Ngoài ra, nhập mức lương cần quan tâm để tham khảo tỷ lệ sinh viên có đạt được mức lương như thế.
Tại giao diện Quản lý sinh viên, tích chọn các ô thông tin để lọc các sinh viên muốn theo dõi. Ngoài ra, sử dụng các nút nhấn trên màn hình để thực hiện các hành động như: tải một tệp xml lên, thêm, xem, sửa, xóa,… thông tin sinh viên.

Hướng dẫn cài đặt:
• Cài đặt cơ sở dữ liệu: Dùng SQL Server cài đặt file database_dss.sql
• Cấu hình kết nối cơ sở dữ liệu: Vào file Final/ConnectDB/Config.txt cung cấp đầy đủ 2 trường thông tin theo mẫu
	- SQL Server: SQLEXPRESS 
	- Tên cơ sở dữ liệu: DSS (do phần cài đặt cơ sở dữ liệu định nghĩa).
• Chạy chương trình: Mở project bằng Visual Studio 2017. Nhấn run để chạy.

Hướng dẫn sử dụng tính năng import dữ liệu từ file excel:
• Lấy file excel mẫu Student.xlsx
• Cung cấp đầy đủ và đúng dạng dữ liệu mà mỗi trường yêu cầu
• Vào mục quản lí, chọn chức năng Import excel để thực hiện
• Chờ trong ít giây để hệ thống có thể hoàn thiện và đưa thông báo hoàn thành