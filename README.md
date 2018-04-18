Mô tả
Hệ thống dự báo nguồn nhân lực công nghệ thông tin là bộ công cụ lưu trữ thông tin của các trường đại học trên cả nước nhằm hỗ trợ người quản lý lưu trữ và kiểm soát thông tin trường học một cách hiệu quả và đơn giản nhất. Từ đó giúp người quản lý sinh viên có thể dự báo được nguồn cung cho ngành công nghệ thông tin qua các năm.
Hệ thống cho phép người dùng có thể theo dõi thông tin sinh viên dưới nhiều góc nhìn khác nhau:
•	Quản lý thông tin trường đại học: thêm, sửa , xóa và tìm kiếm
•	Hỗ trợ dự báo nguồn nhân lực công nghệ thông tin
Tương tác
Sử dụng các nút nhấn trên trang chủ để thực hiện các hành động như: mở màn hình dự báo, quản lý trường, hướng dẫn và thoát chương trình.
Khi ấn dự báo cung, một dialog sẽ hiện ra, yêu cầu nhập năm cần dự báo nguồn nhân lực
Tại giao diện dự báo cung, tích chọn input File, chọn file TiLeTotNghiep.xlsx. Khi đó trên màn hình sẽ xuất hiện thông tin chỉ tiêu tuyển sinh qua các năm, và dự báo cho năm muốn dự báo.
Tại giao diện Quản lý Trường, nhập thông tin tìm kiếm dạng theo tên trường hoặc mã trường. Ngoài ra, sử dụng các nút nhấn trên màn hình để thực hiện các hành động như: thêm, xem, sửa, xóa,… thông tin trường.

Hướng dẫn cài đặt:
• Cài đặt cơ sở dữ liệu: Dùng SQL Server cài đặt file script_nhan_luc.sql
• Cấu hình kết nối cơ sở dữ liệu: Vào file Final/ConnectDB/Config.txt cung cấp đầy đủ 2 trường thông tin theo mẫu
	- SQL Server: SQLEXPRESS 
	- Tên cơ sở dữ liệu: nguon_nhan_luc (do phần cài đặt cơ sở dữ liệu định nghĩa).
• Chạy chương trình: Mở project bằng Visual Studio 2008. Nhấn run để chạy.