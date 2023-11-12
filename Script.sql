USE master
GO
DROP DATABASE CINEMA
GO
CREATE DATABASE CINEMA
GO
USE CINEMA
GO

CREATE TABLE BapNuoc
(
  maDichVu CHAR(10) NOT NULL,
  donGia MONEY NOT NULL,
  tenCombo NVARCHAR(100) NOT NULL,
  PRIMARY KEY (maDichVu)
);

CREATE TABLE KhachHang
(
  maKhachHang INT IDENTITY(1,1) NOT NULL,
  matKhau CHAR(10) NOT NULL,
  tenKhachHang NVARCHAR(100) NOT NULL,
  ngaySinh DATE NOT NULL,
  soDienThoai VARCHAR(100) NOT NULL,
  diaChi NVARCHAR(100) NOT NULL,
  diemTichLuy INT NOT NULL,
  PRIMARY KEY (maKhachHang)
);

CREATE TABLE Admin
(
  taiKhoan CHAR(10) NOT NULL,
  matKhau CHAR(10) NOT NULL,
  chucVu NVARCHAR(50) NOT NULL,
  PRIMARY KEY (taiKhoan),
);

CREATE TABLE Phim
(
  maPhim CHAR(10) NOT NULL,
  tenPhim NVARCHAR(100) NOT NULL,
  theLoai NVARCHAR(100) NOT NULL,
  PRIMARY KEY (maPhim)
);

CREATE TABLE KhuVuc
(
  maKhuVuc CHAR(10) NOT NULL,
  tenKhuVuc NVARCHAR(50) NOT NULL,
  PRIMARY KEY (maKhuVuc)
);

CREATE TABLE Rap
(
  maRap CHAR(10) NOT NULL,
  tenRap NVARCHAR(50) NOT NULL,
  maKhuVuc CHAR(10) NOT NULL,
  PRIMARY KEY (maRap),
  FOREIGN KEY (maKhuVuc) REFERENCES KhuVuc(maKhuVuc)
);

CREATE TABLE DanhGia
(
  maKhachHang INT,
  maPhim CHAR(10) NOT NULL,
  PRIMARY KEY (maKhachHang, maPhim),
  FOREIGN KEY (maKhachHang) REFERENCES KhachHang(maKhachHang),
  FOREIGN KEY (maPhim) REFERENCES Phim(maPhim)
);

CREATE TABLE PhongChieu
(
  maPhongChieu CHAR(10) NOT NULL,
  soPhongChieu INT NOT NULL,
  maRap CHAR(10) NOT NULL,
  PRIMARY KEY (maPhongChieu),
  FOREIGN KEY (maRap) REFERENCES Rap(maRap)
);

CREATE TABLE SuatChieu
(
  ngayChieu DATE NOT NULL,
  donGia MONEY NOT NULL,
  maSuatChieu CHAR(10) NOT NULL,
  maPhim CHAR(10) NOT NULL,
  maPhongChieu CHAR(10) NOT NULL,
  gioChieu TIME NOT NULL,
  PRIMARY KEY (maSuatChieu),
  FOREIGN KEY (maPhim) REFERENCES Phim(maPhim),
  FOREIGN KEY (maPhongChieu) REFERENCES PhongChieu(maPhongChieu)
);

CREATE TABLE HoaDon
(
  maHoaDon CHAR(10) NOT NULL,
  tongTien MONEY NOT NULL,
  ngayLapHoaDon DATE NOT NULL,
  maDichVu CHAR(10) NOT NULL,
  maSuatChieu CHAR(10) NOT NULL,
  PRIMARY KEY (maHoaDon),
  FOREIGN KEY (maDichVu) REFERENCES BapNuoc(maDichVu),
  FOREIGN KEY (maSuatChieu) REFERENCES SuatChieu(maSuatChieu)
);

CREATE TABLE Ve
(
  soGhe INT NOT NULL,
  maVe CHAR(10) NOT NULL,
  maHoaDon CHAR(10) NOT NULL,
  PRIMARY KEY (maVe),
  FOREIGN KEY (maHoaDon) REFERENCES HoaDon(maHoaDon)
);

CREATE TABLE LichSu
(
  maKhachHang INT,
  maHoaDon CHAR(10) NOT NULL,
  PRIMARY KEY (maKhachHang, maHoaDon),
  FOREIGN KEY (maKhachHang) REFERENCES KhachHang(maKhachHang),
  FOREIGN KEY (maHoaDon) REFERENCES HoaDon(maHoaDon)
);

INSERT INTO KhuVuc(maKhuVuc, tenKhuVuc) VALUES ('KV01', N'Hồ Chí Minh');
INSERT INTO KhuVuc(maKhuVuc, tenKhuVuc) VALUES ('KV02', N'Hà Nội');
INSERT INTO KhuVuc(maKhuVuc, tenKhuVuc) VALUES ('KV03', N'Đà Nẵng');
INSERT INTO KhuVuc(maKhuVuc, tenKhuVuc) VALUES ('KV04', N'Đà Lạt');
INSERT INTO KhuVuc(maKhuVuc, tenKhuVuc) VALUES ('KV05', N'Huế');
select * from KhuVuc

INSERT INTO Rap(maRap, tenRap, maKhuVuc) VALUES ('R01', N'CGV Hồ Chí Minh', 'KV01');
INSERT INTO Rap(maRap, tenRap, maKhuVuc) VALUES ('R02', N'CGV Hà Nội', 'KV02');
INSERT INTO Rap(maRap, tenRap, maKhuVuc) VALUES ('R03', N'CGV Đà Nẵng', 'KV03');
INSERT INTO Rap(maRap, tenRap, maKhuVuc) VALUES ('R04', N'CGV Đà Lạt', 'KV04');
INSERT INTO Rap(maRap, tenRap, maKhuVuc) VALUES ('R05', N'CGV Huế', 'KV05');
SELECT * FROM Rap

INSERT INTO PhongChieu(maPhongChieu, soPhongChieu, maRap) VALUES ('PC01R01', '01', 'R01')
INSERT INTO PhongChieu(maPhongChieu, soPhongChieu, maRap) VALUES ('PC02R01', '02', 'R01')
INSERT INTO PhongChieu(maPhongChieu, soPhongChieu, maRap) VALUES ('PC01R02', '01', 'R02')
INSERT INTO PhongChieu(maPhongChieu, soPhongChieu, maRap) VALUES ('PC02R02', '02', 'R02')
INSERT INTO PhongChieu(maPhongChieu, soPhongChieu, maRap) VALUES ('PC01R03', '01', 'R03')
INSERT INTO PhongChieu(maPhongChieu, soPhongChieu, maRap) VALUES ('PC02R03', '02', 'R03')
INSERT INTO PhongChieu(maPhongChieu, soPhongChieu, maRap) VALUES ('PC01R04', '01', 'R04')
INSERT INTO PhongChieu(maPhongChieu, soPhongChieu, maRap) VALUES ('PC02R04', '02', 'R04')
INSERT INTO PhongChieu(maPhongChieu, soPhongChieu, maRap) VALUES ('PC01R05', '01', 'R05')
INSERT INTO PhongChieu(maPhongChieu, soPhongChieu, maRap) VALUES ('PC02R05', '02', 'R05')
SELECT * FROM PhongChieu

INSERT INTO KhachHang(matKhau, tenKhachHang, soDienThoai, ngaySinh, diaChi, diemTichLuy) VALUES ('tanhung', N'Trần Tấn Hưng', '0123456781', '2022-11-10', N'Hồ Chí Minh', 0);
INSERT INTO KhachHang( matKhau, tenKhachHang, soDienThoai, ngaySinh, diaChi, diemTichLuy) VALUES ('dangquang', N'Trần Đăng Quang', '0123456782', '2022-11-20', N'Hồ Chí Minh', 0);
INSERT INTO KhachHang( matKhau, tenKhachHang, soDienThoai, ngaySinh, diaChi, diemTichLuy) VALUES ('thaihoc', N'Phạm Thái Học', '0123456783', '2022-11-20', N'Hồ Chí Minh', 0);
INSERT INTO KhachHang( matKhau, tenKhachHang, soDienThoai, ngaySinh, diaChi, diemTichLuy) VALUES ('nguyen', N'Phạm Nguyễn', '0123456784', '2022-11-20', N'Hồ Chí Minh', 0);
INSERT INTO KhachHang( matKhau, tenKhachHang ,soDienThoai, ngaySinh, diaChi, diemTichLuy) VALUES ('thuhai', N'Học Thứ Hai', '0123456785', '2022-11-20', N'Đà Nẵng', 0);
SELECT * FROM KhachHang

INSERT INTO Phim(maPhim, tenPhim, theLoai) VALUES ('P01', 'FORREST GUMP', N'Tâm Lý')
INSERT INTO Phim(maPhim, tenPhim, theLoai) VALUES ('P02', 'HEM CUT', N'Hài')
INSERT INTO Phim(maPhim, tenPhim, theLoai) VALUES ('P03', 'LOST IN TRANSLATION', N'lãng mạng')
INSERT INTO Phim(maPhim, tenPhim, theLoai) VALUES ('P04', 'VIRUS CUONG LOAI', N'Kinh dị')
INSERT INTO Phim(maPhim, tenPhim, theLoai) VALUES ('P05', 'BONG DUNG TRUNG SO', N'Hài')
INSERT INTO Phim(maPhim, tenPhim, theLoai) VALUES ('P06', 'YES MAN', N'Tâm Lý')
INSERT INTO Phim(maPhim, tenPhim, theLoai) VALUES ('P07', 'ONE PIECE FILM RED', N'Hoạt Hình')
INSERT INTO Phim(maPhim, tenPhim, theLoai) VALUES ('P08', 'IRON MAN', N'Khoa học viễn tưởng')
INSERT INTO Phim(maPhim, tenPhim, theLoai) VALUES ('P09', 'NHA BA NU', N'Gia đình')
INSERT INTO Phim(maPhim, tenPhim, theLoai) VALUES ('P010', 'BO GIA', N'Gia đình')
select * from Phim

INSERT INTO BapNuoc(maDichVu, tenCombo, donGia) VALUES ('DV01', N'1 bắp lớn và 2 nước lớn', 105000)
INSERT INTO BapNuoc(maDichVu, tenCombo, donGia) VALUES ('DV02', N'1 bặp lớn và 2 nước lớn', 85000)
INSERT INTO BapNuoc(maDichVu, tenCombo, donGia) VALUES ('DV03', N'1 bắp vừa và 1 nước lớn', 85000)
INSERT INTO BapNuoc(maDichVu, tenCombo, donGia) VALUES ('DV04', N'combo Onepice', 199000)
INSERT INTO BapNuoc(maDichVu, tenCombo, donGia) VALUES ('DV05', N'1 bắp vị ngọt', 59000)
INSERT INTO BapNuoc(maDichVu, tenCombo, donGia) VALUES ('DV06', N'1 bắp vị mặn', 59000)
INSERT INTO BapNuoc(maDichVu, tenCombo, donGia) VALUES ('DV07', N'1 bắp vị caramel', 74000)
INSERT INTO BapNuoc(maDichVu, tenCombo, donGia) VALUES ('DV08', N'1 bắp vị phô mai', 74000)
INSERT INTO BapNuoc(maDichVu, tenCombo, donGia) VALUES ('DV09', N'1 bắp vị chocolate', 74000)
INSERT INTO BapNuoc(maDichVu, tenCombo, donGia) VALUES ('DV10', N'Nước ngọt tươi', 38000)
INSERT INTO BapNuoc(maDichVu, tenCombo, donGia) VALUES ('DV11', N'Trà sữa đặc biệt', 35000)

INSERT INTO Admin(taiKhoan, matKhau, chucVu) VALUES ('admin', 'admin', N'Quản lí')
select * from Admin

INSERT INTO SuatChieu(maSuatChieu, maPhongChieu, maPhim, ngayChieu, donGia, gioChieu) VALUES ('SC01', 'PC01R01', 'P01', '2022-11-20', 80000, '21:00');
INSERT INTO SuatChieu(maSuatChieu, maPhongChieu, maPhim, ngayChieu, donGia, gioChieu) VALUES ('SC02', 'PC02R01', 'P02', '2022-11-20',80000, '20:00')
INSERT INTO SuatChieu(maSuatChieu, maPhongChieu, maPhim, ngayChieu, donGia, gioChieu) VALUES ('SC03', 'PC01R02', 'P03', '2022-11-20', 80000, '20:00')
INSERT INTO SuatChieu(maSuatChieu, maPhongChieu, maPhim, ngayChieu, donGia, gioChieu) VALUES ('SC04', 'PC02R02', 'P04', '2022-11-20', 80000, '21:00')
INSERT INTO SuatChieu(maSuatChieu, maPhongChieu, maPhim, ngayChieu, donGia, gioChieu) VALUES ('SC05', 'PC01R03', 'P05', '2022-11-20', 80000, '20:00')
INSERT INTO SuatChieu(maSuatChieu, maPhongChieu, maPhim, ngayChieu, donGia, gioChieu) VALUES ('SC06', 'PC02R03', 'P06', '2022-11-20', 80000, '21:00')
INSERT INTO SuatChieu(maSuatChieu, maPhongChieu, maPhim, ngayChieu, donGia, gioChieu) VALUES ('SC07', 'PC01R04', 'P07', '2022-11-20', 80000, '20:00')
INSERT INTO SuatChieu(maSuatChieu, maPhongChieu, maPhim, ngayChieu, donGia, gioChieu) VALUES ('SC08', 'PC02R04', 'P08', '2022-11-20', 80000, '21:00')
INSERT INTO SuatChieu(maSuatChieu, maPhongChieu, maPhim, ngayChieu, donGia, gioChieu) VALUES ('SC09', 'PC01R05', 'P09', '2022-11-20', 80000, '20:00')
INSERT INTO SuatChieu(maSuatChieu, maPhongChieu, maPhim, ngayChieu, donGia, gioChieu) VALUES ('SC10', 'PC02R05', 'P09', '2022-11-20', 80000, '21:00')
select * from SuatChieu



--Viết thủ tục thêm khach hàng
GO
CREATE PROCEDURE P_ADD_NEW_User @matkhau  CHAR(10), @tenkhachhang NVARCHAR(100), @sodienthoai VARCHAR(100), @ngaysinh DATE, @diachi NVARCHAR(100), @diemtichluy INT
AS 
	BEGIN
		INSERT INTO KhachHang(matKhau, tenKhachHang, soDienThoai, ngaySinh, diaChi, diemTichLuy) VALUES (@matkhau, @tenkhachhang, @sodienthoai, @ngaysinh, @diachi, @diemtichluy);
	END

-- Viết thủ tục cho biết TÊN PHIM KHI NHẬP từ bàn 
--phím. 
GO
CREATE PROC P_GET_TENPHIM @MAPHIM CHAR(10) = NULL
AS
	BEGIN
		IF @MAPHIM IS NULL
			PRINT'MA PHIM KHONG TON TAI'
		ELSE
		BEGIN
			SELECT tenPhim AS 'TEN PHIM'
			FROM Phim
			WHERE maPhim = @MAPHIM
		END
	END
--Hàm thống kê số lượng khách hàng online
go
CREATE FUNCTION THONGKE_Kh ()
RETURNS INT
AS
	BEGIN
		RETURN (SELECT COUNT(maKhachHang) FROM KhachHang
	END
--Hàm để đếm só lương phòng chiếu của một rạp dựa vào mã rạp
go
CREATE FUNCTION DEM_SL(@maRap CHAR(10))
RETURNS int
AS
	BEGIN
		RETURN (SELECT COUNT(P.maPhongChieu) FROM Rap R, PhongChieu P
		WHERE R.maRap = @maRap and R.maRap = P.maRap)
	END

--Trigger để thêm khách hàng tránh nhập vào KETQUA với số điểm tích lũy âm
go
CREATE TRIGGER INSERT_TRIGG
	ON KhachHang
	FOR INSERT
	AS
	IF (SELECT diemTichLuy FROM inserted) < 0 
	BEGIN
	PRINT 'DIEM KHONG THE NHO HON 0 VA LON HON 10'
	ROLLBACK TRAN
	END

--update trigger để đảm bảo năm trong cột ngay sinh của khachhang nhỏ hơn năm hiên tại
go
CREATE TRIGGER UDATE_TRIGGER
	ON khachHang
	FOR UPDATE
	AS
	BEGIN
	IF (SELECT YEAR(ngaySinh) FROM inserted ) > YEAR(GETDATE())
	PRINT('ERROR')
	ROLLBACK TRAN
	END