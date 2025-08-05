# Quản lý Ký túc xá Sinh viên

## Giới thiệu

Phần mềm hỗ trợ nhân viên ký túc xá trong việc quản lý sinh viên, phòng ở, dịch vụ và hóa đơn, giúp tin học hóa quá trình làm việc vốn đang thực hiện thủ công.

## Tính năng chính

* Quản lý thông tin sinh viên và người thân
* Quản lý phòng ở, loại phòng và khu vực
* Quản lý hóa đơn, dịch vụ và thanh toán
* Đăng ký và phân bổ phòng
* Báo cáo thống kê theo tháng
* Quản lý tài khoản nhân viên và đổi mật khẩu
* Tính năng gửi OTP qua email khi quên mật khẩu

## Công nghệ sử dụng

* Ngôn ngữ: **C#**
* Giao diện: **WinForms**
* Cơ sở dữ liệu: **SQL Server**
* Mô hình thiết kế: **MVVM tách biệt logic và UI**
* Coding Convention: PascalCase, camelCase, XML Comment, tổ chức bằng Partial Class

## Sơ đồ phân cấp chức năng



## Cấu trúc cơ sở dữ liệu

* **Các bảng chính:**

  * `sinhvien`, `nguoithan`, `phong`, `khuvuc`, `loaiphong`, `dichvu`, `hoadon`, `phieudangky`, `taikhoan`, `nhanvien`


## Giao diện

[![12](https://github.com/user-attachments/assets/6ac94dc2-cc0e-43e1-b904-380693cb0063)](https://github.com/SHADOW5120/HeThongQuanLyKTX/blob/db8b1d49f7dbb4b21db5cb527750258d358ac48f/Img/12.jpg)

Phần mềm có nhiều form riêng biệt cho từng chức năng như:

* Đăng nhập, Đổi mật khẩu, Lấy lại mật khẩu qua email OTP

[<img width="2580" height="862" alt="image" src="https://github.com/user-attachments/assets/a08a5142-59fe-418b-b443-faac4de57a34" />](https://github.com/SHADOW5120/HeThongQuanLyKTX/blob/db8b1d49f7dbb4b21db5cb527750258d358ac48f/Img/11.png)


* Quản lý sinh viên, người thân, phòng, loại phòng, khu vực

[![14](https://github.com/user-attachments/assets/1d90c044-9491-4839-bb50-8f608ad02e18)](https://github.com/SHADOW5120/HeThongQuanLyKTX/blob/db8b1d49f7dbb4b21db5cb527750258d358ac48f/Img/13.png)

[<img width="1436" height="562" alt="13" src="https://github.com/user-attachments/assets/b70d4b38-650e-406e-ad30-667fd31141ae" />
](https://github.com/SHADOW5120/HeThongQuanLyKTX/blob/db8b1d49f7dbb4b21db5cb527750258d358ac48f/Img/14.jpg)

* Quản lý hóa đơn, dịch vụ, biểu mẫu đăng ký

[<img width="1517" height="568" alt="15" src="https://github.com/user-attachments/assets/db075d73-40ff-44bc-8e9b-80b74883e9ab" />](https://github.com/SHADOW5120/HeThongQuanLyKTX/blob/db8b1d49f7dbb4b21db5cb527750258d358ac48f/Img/15.png)

* Giao diện báo cáo trực quan (doanh thu, số lượng dịch vụ, sinh viên,...)

[<img width="1773" height="542" alt="16" src="https://github.com/user-attachments/assets/7ee2e03a-1dc2-43e0-a7af-b04bd8652d17" />](https://github.com/SHADOW5120/HeThongQuanLyKTX/blob/db8b1d49f7dbb4b21db5cb527750258d358ac48f/Img/16.png)

## Thiết kế giao diện

* **Màu sắc chủ đạo:** Đỏ HUST (#C8102E), trắng, xám
* **Phông chữ:** Segoe UI, Roboto, Times New Roman
* **Thiết kế:** Tối giản, dễ thao tác, hiệu ứng mượt, responsive nhẹ nhàng
