create database QuanLyBanHangZoziCoffee
go
Use QuanLyBanHangZoziCoffee
go
drop database QuanLyBanHangZoziCoffee
--Tạo TK_QL
create table TK_QL
(
	TenDangNhap varchar(10) not null,
	MatKhau varchar(10) not null,
	primary key (TenDangNhap)
)
go
	--Nhap du lieu bang TK_QL
insert into TK_QL values ('QL1','123456')
insert into TK_QL values ('QL2','123456')
go

select * from KhachHang

--Tạo TK_NV
create table TK_NV
(
	TenDangNhap varchar(10) not null,
	MatKhau varchar(10) not null,
	primary key (TenDangNhap)
)
go
	--Nhap du lieu bang TK_NV
insert into TK_NV values ('NV1','123456')
insert into TK_NV values ('NV2','123456')
go

--Xây dựng cơ sở dữ liệu cho bản thiết kế
	-- Tạo bảng NHAN VIEN
create table NhanVien
(
	MaNV varchar(10) not null,
	TenNV nvarchar(100),
	ChucVu nvarchar(50),
	DiaChi nvarchar(100),
	SDT numeric (10,0),
	GioiTinh varchar(10),
	primary key (MaNV)
)
go
	-- Tạo bảng KHACH HANG
create table KhachHang
(
	MaKH varchar (10),
	TenKH nvarchar(100),
	primary key (MaKH),
)
go
	-- Tạo bảng HANG HOA
create table HangHoa
(
	MaHH varchar (10) not null,
	TenHH nvarchar (100),
	DVT nvarchar (20),
	DonGia money,
	primary key (MaHH),
)
go
	-- Tạo bảng SAN PHAM
create table SanPham
(
	MaSP varchar(10),
	TenSP nvarchar(100),
	DonGia money,
	primary key (MaSP),
)
go
	-- Tạo bảng NHA CUNG CAP
create table NhaCungCap
(
	MaNCC varchar (10),
	TenNCC nvarchar (100),
	DiaChi nvarchar (100),
	SDT numeric (10,0)
	primary key (MaNCC),
)
go
	-- Tạo bảng HOA DON NHAP HANG
create table Nhap
(
	SoHD varchar(20) not null,
	MaNCC varchar (10),
	NgayNhap date,
	MaNV varchar (10),
	primary key (SoHD),
	foreign key (MaNCC) references NhaCungCap(MaNCC),
	foreign key (MaNV) references NhanVien (MaNV)
)
go
	-- Tạo bảng HOA DON NHAP HANG CHI TIET
create table Nhap_ChiTiet
(
	SoHD varchar(20) not null,
	MaHH varchar(10),
	SL int,
	ThanhTien money,
	foreign key (SoHD) references Nhap(SoHD),
	foreign key (MaHH) references HangHoa(MaHH)
)
go
	-- Tạo bảng HOA DON BAN HANG
 
create table Ban
(
	MaHD varchar(20)not null,
	NgayLap date,
	MaNV varchar (10),
	MaKH varchar (10),
	primary key(MaHD),
	foreign key (MaNV) references NhanVien(MaNV),
	foreign key (MaKH) references KhachHang(MaKH)
)
go
	-- Tạo bảng HOA DON BAN HANG CHI TIET
create table Ban_ChiTiet
(
	MaHD varchar(20) not null,
	MaSP varchar(10),
	SL int,
	ThanhTien money,
	ChietKhau int,
	TongTien money,
	foreign key (MaHD) references Ban(MaHD),
	foreign key (MaSP) references SanPham(MaSP)
)
go
 
	--Nhap du lieu bang NhanVien
insert into NhanVien values ('QL', N'Nguyễn Minh Hiếu', N'Quản lý', N'123 Tiểu La, Hải Châu, Đà Nẵng', 0123234289, 'Nam')
insert into NhanVien values ('PC1',N'Lê Nguyễn Hoàng Anh', N'Pha chế', N'456 Núi Thành, Hải Châu, Đà Nẵng', 0483902899, 'Nữ')
insert into NhanVien values ('PC2', N'Hoàng Minh Hiếu', N'Pha chế', N'789 Nguyễn Văn Thoại, Ngũ Hành Sơn, Đà Nẵng', 0394532455, 'Nam')
insert into NhanVien values ('PV1', N'Nguyễn Thanh Thanh Hiền', N'Phục vụ', N'213 Ngô Quyền, Sơn Trà, Đà Nẵng', 0384921943, 'Nữ')
go
 
	--Nhap du lieu bang Khachhang
insert into KhachHang values (1, N'Nguyễn Đình Hân')
insert into KhachHang values (2, N'Đoàn Ngọc Hương Giang')
insert into KhachHang values (3, N'Võ Hồ Hạnh Hoàng')
insert into KhachHang values (4, N'Trần Thị Ngọc Quý')
go
 
	--Nhap du lieu bang HangHoa
insert into HangHoa values ('SP000001', N'Trà đen Lộc Phát', N'Gói', 155000)
insert into HangHoa values ('SP000002', N'Trà Cozy Vải túi lọc', N'Hộp', 34000)
insert into HangHoa values ('SP000003', N'Trà Cozy Đào túi lọc', N'Hộp', 34000)
insert into HangHoa values ('SP000004', N'Syrup Torani Vải', N'Chai', 160000)
go
 
	--Nhap du lieu bang SanPham
insert into SanPham values ('CB1', N'Cold Brew Cam', 35000)
insert into SanPham values ('CB2', N'Cold Brew Dâu Tằm', 35000)
insert into SanPham values ('CB3', N'Cold Brew Kem Sữa', 35000)
insert into SanPham values ('CB4', N'Cold Brew Thơm', 35000)
go
 
	--Nhap du lieu bang NhaCungCap
insert into NhaCungCap values ('TOPER', N'Công ty TNHH thương mại và dịch vụ Toper Miền Trung', N'14 Nguyễn Minh Không - Hòa Minh - Liên Chiểu - Đà Nẵng', 0905137955)
go
 
	--Nhap du lieu bang Hoa Don Nhap Hang
insert into Nhap values ('HD01512701', 'TOPER', '8-9-2022','QL')
go
 
	--Nhap du lieu bang Hoa Don Nhap Hang Chi Tiet
insert into Nhap_ChiTiet values ('HD01512701', 'SP000001', 3, 465000)
insert into Nhap_ChiTiet values ('HD01512701', 'SP000002', 4, 136000)
insert into Nhap_ChiTiet values ('HD01512701', 'SP000003', 6, 204000)
insert into Nhap_ChiTiet values ('HD01512701', 'SP000004', 1, 160000)
go
 
	--Nhap du lieu bang Hoa Don Ban Hang
insert into Ban values ('HD1822-001', '2022-08-01', 'QL',1)
insert into Ban values ('HD5822-002', '2022-08-05', 'PC1',2)
insert into Ban values ('HD5822-003', '2022-08-15', 'PC2',3)
insert into Ban values ('HD2922-004', '2022-09-02', 'PV1',4)
go
 
	--Nhap du lieu bang Hoa Don Ban Hang Chi Tiet
insert into Ban_ChiTiet values ('HD1822-001','CB1', 1, 59000, null, 59000)
insert into Ban_ChiTiet values ('HD1822-001','CB1', 2, 70000, null, 70000)
insert into Ban_ChiTiet values ('HD5822-003','CB1', 3, 174000, null, 174000)
insert into Ban_ChiTiet values ('HD2922-004','CB1', 4, 35000, null, 35000)
go

go

--Proc hiển thị danh sách HH.
create proc HienHH
as
begin
    select * from HangHoa
end
go

--Proc thêm mới data HH
create proc ThemHH
@MaHH varchar(10),
@TenHH nvarchar(100),
@DVT nvarchar(20),
@DonGia money
as
begin
    insert into HangHoa values (@MaHH,@TenHH,@DVT,@DonGia)
end
go
drop proc ThemHH
go

--Proc sửa data HH.
create proc SuaHH
@MaHH nvarchar(100),
@TenHH nvarchar(100),
@DVT nvarchar(20),
@DonGia money
as
begin
    update HangHoa set
    MaHH = @MaHH,
    TenHH = @TenHH,
    DVT = @DVT,
	DonGia = @DonGia
    where MaHH = @MaHH
end
go
--Proc xóa data HH
create proc XoaHH
@MaHH nvarchar(100)
as
begin
    delete HangHoa where MaHH = @MaHH
end
go

--Proc hiển thị danh sách NV.
create proc HienNV
as
begin
    select * from NhanVien
end
go

--Proc thêm mới data NV
create proc ThemNV
@MaNV varchar(10),
@TenNV nvarchar(100),
@ChucVu nvarchar(50),
@DiaChi nvarchar(100),
@SDT numeric(10,0),
@GioiTinh varchar(10)
as
begin
    insert into NhanVien values (@MaNV,@TenNV,@ChucVu,@DiaChi,@SDT,@GioiTinh)
end
go
drop proc ThemNV
go

--Proc sửa data NV.
create proc SuaNV
@MaNV varchar(10),
@TenNV nvarchar(100),
@ChucVu nvarchar(50),
@DiaChi nvarchar(100),
@SDT numeric(10,0),
@GioiTinh varchar(10)
as
begin
    update NhanVien set
    MaNV = @MaNV,
    TenNV = @TenNV,
    ChucVu = @ChucVu,
	DiaChi = @DiaChi,
	SDT = @SDT,
	GioiTinh = @GioiTinh
    where MaNV = @MaNV
end
go
--Proc xóa data NV
create proc XoaNV
@MaNV nvarchar(100)
as
begin
    delete NhanVien where MaNV = @MaNV
end
go


--R9: Đề phòng TESTDB bị tấn công
-- MÃ HÓA
UPDATE TK_QL
Set MatKhau = CONVERT (varchar(10), HASHBYTES('MD5', MatKhau), 1)

GO
-- Trigger tự động mã hóa khi insert dữ liệu
Create trigger tgMaTK
On TK_QL
For INSERT 
As
Begin
	UPDATE TK_QL
	Set MatKhau = (Select CONVERT (varchar(10), HASHBYTES('MD5', inserted.MatKhau), 1)
				   From inserted)
				   Where TenDangNhap = (Select TenDangNhap From inserted)
End
GO
-- Trigger tự động mã hóa khi update mật khẩu
Create trigger tgUpTK
On TK_QL
For UPDATE
As
Begin
	If UPDATE (MatKhau)
	Begin
		UPDATE TK_QL 
		Set MatKhau = (Select CONVERT (varchar(10), HASHBYTES('MD5', inserted.MatKhau), 1)
					   From inserted)
					   Where TenDangNhap = (SELECT TenDangNhap From inserted)
	End
End
GO
--Hàm chuyển đổi tài khoản 
Create function fGiaiMa (@ten varchar(30), @MK varchar(10))
RETURNS int
As
Begin
	Return (Select Count(*) from TK_QL where TenDangNhap =  @ten and  MatKhau = CONVERT (varchar(10), HASHBYTES('MD5', @MK), 1))
End
go

select * from TK_QL

SELECT * FROM KhachHang

