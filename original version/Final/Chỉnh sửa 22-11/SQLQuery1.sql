CREATE DATABASE KATICAS;
GO

USE KATICAS;
GO

DROP TABLE IF EXISTS NHANVIEN

CREATE TABLE NhanVien
(
	id NVARCHAR(20) PRIMARy KEY,
	TaiKhoan VARCHAR(MAX) NULL,
	MatKhau VARCHAR(MAX) NULL,
	HoTen NVARCHAR(MAX) NULL,
	ChucVu NVARCHAR(MAX) NULL,
	TrangThai NVARCHAR(MAX) NULL,
	NgayVaoLam DATE NULL
)
GO

SELECT * FROM NhanVien
GO


CREATE TABLE HangHoa
(
	MaHang NVARCHAR(20) PRIMARY KEY,
	TenHang NVARCHAR(MAX) NULL,
	SoLuong INT NULL,
	DonViTinh NVARCHAR(MAX) NULL,
	Gia FLOAT NULL,
	TrangThai NVARCHAR(MAX) NULL
)
GO
SELECT DISTINCT MaHang FROM HangHoa WHERE TrangThai = N'Đang bán'
SELECT * FROM HangHoa
GO
SELECT * FROM HangHoa WHERE MaHang = (SELECT NguyenLieu FROM Mon WHERE MaMon = 'N001')


UPDATE HangHoa 
SET SoLuong = ISNULL(SoLuong, 0) + 50

WHERE MaHang = (SELECT NguyenLieu FROM Mon WHERE MaMon = 'N001')

CREATE TABLE Mon
(
	MaMon NVARCHAR(20) PRIMARY KEY,
	TenMon NVARCHAR(MAX) NULL,
	Loai NVARCHAR(MAX) NULL,
	Gia FLOAT NULL,
	DonViTinh NVARCHAR(MAX) NULL,
	NguyenLieu NVARCHAR(20) NULL,
	TrangThai NVARCHAR(MAX) NULL
	CONSTRAINT FK_Mon_NguyenLieu FOREIGN KEY (NguyenLieu) REFERENCES HangHoa(MaHang)
)
GO

SELECT DISTINCT TenMon FROM Mon;

SELECT * FROM Mon WHERE TrangThai = N'Đang bán';

SELECT MaMon FROM Mon WHERE Loai = N'Nước uống' AND TrangThai = N'Đang bán'
SELECT * FROM Mon
GO

CREATE TABLE QuyDoi
(
	id INT PRIMARY KEY IDENTITY(1,1),
	DonViLon NVARCHAR(MAX),
	DonViNho NVARCHAR(MAX),
	SoLuong INT NULL
)
GO

SELECT * FROM QuyDoi
GO

CREATE TABLE HoaDon
(
	MaHoaDon INT PRIMARY KEY IDENTITY(1,1),
	TongTien FLOAT NULL,
	Ngay DATE NULL
)
GO

SELECT * FROM HoaDon
GO

CREATE TABLE ChiTietHoaDon
(
	id INT PRIMARY KEY IDENTITY(1,1),
	MaHoaDon INT NULL,
	MaSanPham NVARCHAR(20) NULL,
	Loai NVARCHAR(MAX) NULL,
	SoLuong INT NULL,
	Gia FLOAT NULL,
	Ngay DATE NULL,
	CONSTRAINT FK_ChiTietHoaDon_HoaDon FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
	CONSTRAINT FK_ChiTietHoaDon_SanPham FOREIGN KEY (MaSanPham) REFERENCES Mon(MaMon)
)
GO

SELECT * FROM ChiTietHoaDon
GO

DELETE FROM ChiTietHoaDon WHERE TenMon = '" + "Cà phê" + "'
SELECT MaSanPham, TenMon, Loai, SoLuong, Gia FROM ChiTietHoaDon WHERE MaHoaDon = 29
INSERT INTO HoaDon (Ngay, TongTien, TienThua, TienNhan)
VALUES ('2024-12-14', 1000, 200, 1200)

SELECT SCOPE_IDENTITY() AS MaHoaDon;

INSERT INTO ChiTietHoaDon (MaHoaDon, MaSanPham, Loai, SoLuong, Gia, Ngay, DonGia, TenMon)
VALUES (29, 'N001', N'Nước uống', 2, 40, '2024-12-14', 20, N'Cà phê');

UPDATE HangHoa SET SoLuong = SoLuong - 1 WHERE MaHang  = (SELECT TOP 1 NguyenLieu FROM Mon WHERE MaMon = 'N001') AND SoLuong >= 1

ALTER TABLE ChiTietHoaDon 
ADD TenMon NVARCHAR(MAX);

ALTER TABLE HoaDon 
ADD TienNhan FLOAT;

ALTER TABLE HoaDon ALTER COLUMN TienThua FLOAT
ALTER TABLE HoaDon ALTER COLUMN TienNhan FLOAT

CREATE TABLE NhaCungCap
(
	MaNCC NVARCHAR(20) PRIMARY KEY,
	Ten NVARCHAR(MAX),
	DiaChi NVARCHAR(MAX),
	SDT NVARCHAR(MAX),
	Email NVARCHAR(MAX),
	TrangThai NVARCHAR(MAX)
)
GO

SELECT * FROM NhaCungCap
GO

CREATE TABLE PhieuNhapHang 
(
	MaPhieu NVARCHAR(20) PRIMARY KEY,
	MaNhaCC NVARCHAR(20),
	MaDonDatHang NVARCHAR(20),
	TongTien FLOAT NULL,
	Ngay DATE NULL,
	CONSTRAINT FK_PhieuNhapHang_NhaCungCap FOREIGN KEY (MaNhaCC) REFERENCES NhaCungCap(MaNCC)
)
GO

SELECT * FROM PhieuNhapHang 
GO

CREATE TABLE ChiTietPhieuNhapHang
(
	id INT PRIMARY KEY IDENTITY(1,1),
	MaPhieu NVARCHAR(20) NULL, 
	MaHang NVARCHAR(20) NULL,
	TenHang NVARCHAR(MAX) NULL,
	SoLuong INT NULL,
    DonViTinh INT NULL,
	Gia FLOAT NULL,
	Ngay DATE NULL,
	CONSTRAINT FK_ChiTietPhieuNhapHang_PhieuNhapHang FOREIGN KEY (MaPhieu) REFERENCES PhieuNhapHang(MaPhieu)
)
GO

SELECT * FROM ChiTietPhieuNhapHang
GO

CREATE TABLE DonDatHang
(
	MaDonDatHang NVARCHAR(20) PRIMARY KEY,
	MaNhaCC NVARCHAR(20),
	NgayDat DATE NULL,
	TongTien FLOAT NULL,
	TrangThai NVARCHAR(MAX),
	NgayNhap DATE NULL,
	CONSTRAINT FK_DonDatHang_NhaCungCap FOREIGN KEY (MaNhaCC) REFERENCES NhaCungCap(MaNCC),
)

SELECT * FROM DonDatHang
GO

CREATE TABLE ChiTietDonDatHang
(
	id INT PRIMARY KEY IDENTITY(1,1),
	MaDonDatHang NVARCHAR(20),
	MaHang NVARCHAR(MAX) NULL,
	TenHang NVARCHAR(MAX)NULL,
	SoLuong INT NULL,
    DonViTinh NVARCHAR(MAX),
	Gia FLOAT NULL,
	CONSTRAINT FK_ChiTietDonDatHang_DonDatHang FOREIGN KEY (MaDonDatHang) REFERENCES DonDatHang(MaDonDatHang)
)
GO

SELECT * FROM ChiTietDonDatHang
GO

INSERT INTO NhanVien (id,TaiKhoan, MatKhau, HoTen, ChucVu, TrangThai, NgayVaoLam) 
VALUES ('A01','admin', 'admin123', 'Jelly', 'Admin', 'Da kich hoat', '2024-10-20'),
		('NV01','nv', 'nv123', 'Jelly', N'Nhân Viên', 'Da kich hoat', '2024-10-20');
GO 

INSERT INTO HangHoa (MaHang,TenHang,SoLuong,DonViTinh,Gia,TrangThai)
VALUES ('SP01',N'Cà phê đen',5,N'Gói',12000,N'Đang bán');
GO

INSERT INTO QuyDoi (DonViLon, DonViNho, SoLuong)
VALUES (N'Thùng',N'Chai',24),
		(N'Hộp',N'Gói',20),
		(N'Cái','Cái',1)
GO

-- SELECT TinhTrang FROM NhanVien WHERE TaiKhoan = 'test1' AND MatKhau = '123'

-- INSERT INTO products(prod_id,prod_name,prod_type,prod_stock) VALUES('pd001','coca','thung','8');

UPDATE HangHoa SET SoLuong =  5  WHERE MaHang = (SELECT NguyenLieu FROM Mon WHERE MaMon = 'N001')
SELECT SoLuong FROM HangHoa WHERE MaHang = (SELECT NguyenLieu FROM Mon WHERE MaMon = 'N001')
SELECT MaMon, TenMon, Loai, SoLuong, Gia FROM ChiTietHoaDon WHERE MaHoaDon = 'NULL'