Create database DoAn_1881101
Go
Use DoAn_1881101
Go

Create table ThongTinCuocGoi
(
	Id int identity(1, 1) not null,
	SDT varchar(20),
	TenKH nvarchar(70),
	DiaChiDon nvarchar(150),
	DiaChiDon_Lat float,
	DiaChiDon_Long float,
	SoNha nvarchar(20),
	Duong nvarchar(100),
	Phuong nvarchar(50),
	Quan nvarchar(50),
	ThanhPho nvarchar(20),
	LoaiXe int,
	TinhTrang int default(0),
	ThoiGian datetime2 default(getdate()),
	Primary key (Id)
)
Go

Create table ThanhPho
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50), 
	Primary key (Id)
)
Go

Create table QuanHoChiMinh
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongThanhPhoThuDuc
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongQuan1
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongQuan3
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongQuan4
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongQuan5
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongQuan6
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongQuan7
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongQuan8
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongQuan10
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongQuan11
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongQuan12
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongQuanBinhTan
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongQuanBinhThanh
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongQuanGoVap
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongQuanPhuNhuan
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongQuanTanBinh
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table PhuongQuanTanPhu
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table XaHuyenBinhChanh
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table XaHuyenCanGio
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table XaHuyenCuChi
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table XaHuyenHocMon
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table XaHuyenNhaBe
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50),
	Primary key (Id)
)
Go

Create table Duong
(
	Id int identity(1, 1) not null,
	Ten nvarchar(50), 
	Primary key (Id)
)
Go

CREATE TABLE TaiXe 
(
	Id INT identity(1, 1) not null,
	HoTen NVARCHAR(50) NOT NULL,
	CCCD VARCHAR(12) NOT NULL,
	NgaySinh VARCHAR(50) NOT NULL,
	GioiTinh NVARCHAR(3),
	DiaChi NVARCHAR(50) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	BangLai VARCHAR(20) NOT NULL,
	SDT VARCHAR(12) NOT NULL,
	PhuongTien NVARCHAR(12) NOT NULL,
	BienSoXe VARCHAR(10) NOT NULL,
	IdHinh INT,
	IdXe INT,
	TrangThai NVARCHAR(10),
	PRIMARY KEY (Id)
);

CREATE TABLE LoaiXe 
(
	Id INT identity(1, 1) not null,
	TenXe NVARCHAR(50) NOT NULL,
	MoTa NVARCHAR(50),
	PRIMARY KEY (Id)
);

CREATE TABLE KhachHang 
(
	Id INT identity(1, 1) not null,
	IdAvartar INT,
	HoTen NVARCHAR(50) NOT NULL,
	GioiTinh NVARCHAR(3),
	Email NVARCHAR(50),
	SDT VARCHAR(12) NOT NULL,
	NgaySinh Varchar(50),
	DiaChi NVARCHAR(50),
	PRIMARY KEY (Id)
);

CREATE TABLE CuocXe 
(
	MaCuocXe INT identity(1, 1) not null,
	DiemDon VARCHAR(255) NOT NULL,
	DiemDen VARCHAR(255) NOT NULL,
	LoaiXe VARCHAR(20) NOT NULL,
	PRIMARY KEY (MaCuocXe)
);

CREATE TABLE ChiTietCuocXe 
(
	IdTaiXe INT NOT NULL,
	IdKhachHang INT NOT NULL,
	MaCuocXe INT NOT NULL,
	TongTien FLOAT NOT NULL,
	GPSDiemDon VARCHAR(255) NOT NULL,
	IdLoaiXe INT NOT NULL
);

CREATE TABLE LuuTru 
(
	Id INT identity(1, 1) not null,
	IdTaiXe INT NOT NULL,
	GPSTaiXe VARCHAR(255) NOT NULL,
	TrangThai VARCHAR(255) NOT NULL,
	ThoiDiem DATETIME NOT NULL,
	PRIMARY KEY (Id)
);

CREATE TABLE HinhAnhTaiXe 
(
	Id INT NOT NULL,
	DuongDan VARCHAR(255) NOT NULL,
	PRIMARY KEY (Id)
);

CREATE TABLE HinhAnhKhachHang 
(
	Id INT NOT NULL,
	DuongDan VARCHAR(255),
	PRIMARY KEY (Id)
);

ALTER TABLE TaiXe 
	ADD CONSTRAINT TaiXe_fk0 
	FOREIGN KEY (IdHinh) 
	REFERENCES HinhAnhTaiXe(Id);

ALTER TABLE TaiXe 
	ADD CONSTRAINT TaiXe_fk1 
	FOREIGN KEY (IdXe) 
	REFERENCES LoaiXe(Id);

ALTER TABLE KhachHang 
	ADD CONSTRAINT KhachHang_fk0 
	FOREIGN KEY (IdAvartar) 
	REFERENCES HinhAnhKhachHang(Id);

ALTER TABLE ChiTietCuocXe 
	ADD CONSTRAINT ChiTietCuocXe_fk0 
	FOREIGN KEY (IdTaiXe) 
	REFERENCES TaiXe(Id);

ALTER TABLE ChiTietCuocXe 
	ADD CONSTRAINT 
	ChiTietCuocXe_fk1 
	FOREIGN KEY (IdKhachHang) 
	REFERENCES KhachHang(Id);

ALTER TABLE ChiTietCuocXe 
	ADD CONSTRAINT ChiTietCuocXe_fk2 
	FOREIGN KEY (MaCuocXe) 
	REFERENCES CuocXe(MaCuocXe);

ALTER TABLE ChiTietCuocXe 
	ADD CONSTRAINT ChiTietCuocXe_fk3 
	FOREIGN KEY (IdLoaiXe) 
	REFERENCES LoaiXe(Id);

ALTER TABLE LuuTru 
	ADD CONSTRAINT LuuTru_fk0 
	FOREIGN KEY (IdTaiXe) 
	REFERENCES TaiXe(Id);

Insert into ThanhPho values(N'Hồ Chí Minh')					
go

Insert into QuanHoChiMinh values(N'Thành Phố Thủ Đức'), 
								(N'Quận 1'),
								(N'Quận 3'),
								(N'Quận 4'),
								(N'Quận 5'),
								(N'Quận 6'),
								(N'Quận 7'),
								(N'Quận 8'),
								(N'Quận 10'),
								(N'Quận 11'),
								(N'Quận 12'),
								(N'Quận Bình Tân'),
								(N'Quận Bình Thạnh'),
								(N'Quận Gò Vấp'),
								(N'Quận Phú Nhuận'),
								(N'Quận Tân Bình'),
								(N'Quận Tân Phú'),
								(N'Huyện Bình Chánh'),
								(N'Huyện Cần Giờ'),
								(N'Huyện Củ Chi'),
								(N'Huyện Hóc Môn'),
								(N'Huyện Nhà Bè')
go

Insert into PhuongThanhPhoThuDuc values(N'Phường An Khánh'),
										(N'Phường An Lợi Đông'),
										(N'Phường An Phú'),
										(N'Phường Thảo Điền'),
										(N'Phường Bình Chiểu'),
										(N'Phường Bình Thọ'),
										(N'Phường Trưng Đông'),
										(N'Phường Trưng Tây'),
										(N'Phường Cát Lái'),
										(N'Phường Hiệp Bình Chánh'),
										(N'Phường Hiệp Bình Phước'),
										(N'Phường Hiệp Phú'),
										(N'Phường Linh Chiểu'),
										(N'Phường Linh Đông'),
										(N'Phường Linh Tây'),
										(N'Phường Linh Trung'),
										(N'Phường Linh Xuân'),
										(N'Phường Long Bình'),
										(N'Phường Long Phước'),
										(N'Phường Long Thạnh Mỹ'),
										(N'Phường Long Trường'),
										(N'Phường Phú Hữu'),
										(N'Phường Phước Bình'),
										(N'Phường Phước Long A'),
										(N'Phường Phước Long B'),
										(N'Phường Tam Bình'),
										(N'Phường Tam Phú'),
										(N'Phường Tăng Nhơn Phú A'),
										(N'Phường Tăng Nhơn Phú B'),
										(N'Phường Tân Phú'),
										(N'Phường Thảo Điền'),
										(N'Phường Thạnh Mỹ Lợi'),
										(N'Phường Thủ Thiêm'),
										(N'Phường Trường Thạnh'),
										(N'Phường Trường Thọ')
go

Insert into PhuongQuan1 values(N'Phường Bến Nghé'),
								(N'Phường Bến Thành'),
								(N'Phường Cô Giang'),
                                (N'Phường Cầu Kho'),
								(N'Phường Cầu Ông Lãnh'),
								(N'Phường Đakao'),
                                (N'Phường Nguyễn Cư Trinh'),
								(N'Phường Nguyễn Thái Bình'),
								(N'Phường Phạm Ngũ Lão'),
                                (N'Phường Tân Định')
go

Insert into PhuongQuan3 values(N'Phường 1'),
								(N'Phường 2'),
								(N'Phường 3'),
								(N'Phường 4'),
								(N'Phường 5'),
                                (N'Phường 9'),
								(N'Phường 10'),
								(N'Phường 11'),
								(N'Phường 12'),
                                (N'Phường 13'),
								(N'Phường 14'),
								(N'Phường Võ Thị Sáu')
go

Insert into PhuongQuan4 values(N'Phường 1'),
								(N'Phường 2'),
								(N'Phường 3'),
								(N'Phường 4'),
								(N'Phường 6'),
                                (N'Phường 8'),
								(N'Phường 9'),
								(N'Phường 10'),
                                (N'Phường 13'),
								(N'Phường 14'),
								(N'Phường 15'),
								(N'Phường 16'),
								(N'Phường 18')
go

Insert into PhuongQuan5 values(N'Phường 1'),
								(N'Phường 2'),
								(N'Phường 3'),
								(N'Phường 4'),
								(N'Phường 5'),
								(N'Phường 6'),
								(N'Phường 7'),
                                (N'Phường 8'),
								(N'Phường 9'),
								(N'Phường 10'),
								(N'Phường 11'),
								(N'Phường 12'),
                                (N'Phường 13'),
								(N'Phường 14')
go

Insert into PhuongQuan6 values(N'Phường 1'),
								(N'Phường 2'),
								(N'Phường 3'),
								(N'Phường 4'),
								(N'Phường 5'),
								(N'Phường 6'),
								(N'Phường 7'),
                                (N'Phường 8'),
								(N'Phường 9'),
								(N'Phường 10'),
								(N'Phường 11'),
								(N'Phường 12'),
                                (N'Phường 13'),
								(N'Phường 14')
go

Insert into PhuongQuan7 values(N'Phường Bình Thuận'),
								(N'Phường Phú Mỹ'),
								(N'Phường Phú Thuận'),
								(N'Phường Tân Hưng'),
								(N'Phường Tân Kiểng'),
                                (N'Phường Tân Phong'),
								(N'Phường Tân Phú'),
								(N'Phường Tân Quy'),
								(N'Phường Tân Thuận Đông'),
								(N'Phường Tân Thuận Tây')
go

Insert into PhuongQuan8 values(N'Phường 1'),
								(N'Phường 2'),
								(N'Phường 3'),
								(N'Phường 4'),
								(N'Phường 5'),
								(N'Phường 6'),
								(N'Phường 7'),
                                (N'Phường 8'),
								(N'Phường 9'),
								(N'Phường 10'),
								(N'Phường 11'),
								(N'Phường 12'),
                                (N'Phường 13'),
								(N'Phường 14'),
								(N'Phường 15'),
								(N'Phường 16')
go

Insert into PhuongQuan10 values(N'Phường 1'),
								(N'Phường 2'),
								(N'Phường 3'),
								(N'Phường 4'),
								(N'Phường 5'),
								(N'Phường 6'),
								(N'Phường 7'),
                                (N'Phường 8'),
								(N'Phường 9'),
								(N'Phường 10'),
								(N'Phường 11'),
								(N'Phường 12'),
                                (N'Phường 13'),
								(N'Phường 14'),
								(N'Phường 15')
go

Insert into PhuongQuan11 values(N'Phường 1'),
								(N'Phường 2'),
								(N'Phường 3'),
								(N'Phường 4'),
								(N'Phường 5'),
								(N'Phường 6'),
								(N'Phường 7'),
                                (N'Phường 8'),
								(N'Phường 9'),
								(N'Phường 10'),
								(N'Phường 11'),
								(N'Phường 12'),
                                (N'Phường 13'),
								(N'Phường 14'),
								(N'Phường 15'),
								(N'Phường 16')
go

Insert into PhuongQuan12 values(N'Phường An Phú Đông'),
								(N'Phường Đông Hưng Thuận'),
								(N'Phường Hiệp Thành'),
								(N'Phường Tân Chánh Hiệp'),
                                (N'Phường Tân Hưng Thuận'),
								(N'Phường Tân Thới Hiệp'),
								(N'Phường Tân Thới Nhất'),
								(N'Phường Thạnh Lộc'),
                                (N'Phường Thạnh Xuân'),
								(N'Phường Thới An'),
								(N'Phường Trung Mỹ Tây')
go

Insert into PhuongQuanBinhTan values(N'Phường An Lạc'),
									(N'Phường An Lạc A'),
									(N'Phường Bình Hưng Hòa'),
									(N'Phường Bình Hưng Hòa A'),
                                    (N'Phường Bình Hưng Hòa B'),
									(N'Phường Bình Trị Đông'),
									(N'Phường Bình Trị Đông A'),
									(N'Phường Bình Trị Đông B'),
                                    (N'Phường Tân Tạo'),
									(N'Phường Tân Tạo A')
go

Insert into PhuongQuanBinhThanh values(N'Phường 1'),
										(N'Phường 2'),
										(N'Phường 3'),
										(N'Phường 5'),
										(N'Phường 6'),
										(N'Phường 7'),
										(N'Phường 11'),
										(N'Phường 12'),
										(N'Phường 13'),
										(N'Phường 14'),
										(N'Phường 15'),
										(N'Phường 17'),
										(N'Phường 19'),
										(N'Phường 21'),
										(N'Phường 22'),
										(N'Phường 24'),
										(N'Phường 25'),
										(N'Phường 26'),
										(N'Phường 27'),
										(N'Phường 28')
go

Insert into PhuongQuanGoVap values(N'Phường 1'),
									(N'Phường 3'),
									(N'Phường 4'),
									(N'Phường 5'),
									(N'Phường 6'),
									(N'Phường 7'),
									(N'Phường 8'),
									(N'Phường 9'),
									(N'Phường 10'),
									(N'Phường 11'),
									(N'Phường 12'),
									(N'Phường 13'),
									(N'Phường 14'),
									(N'Phường 15'),
									(N'Phường 16'),
									(N'Phường 17')

go

Insert into PhuongQuanPhuNhuan values(N'Phường 1'),
									(N'Phường 2'),
									(N'Phường 3'),
									(N'Phường 4'),
									(N'Phường 5'),
									(N'Phường 7'),
									(N'Phường 8'),
									(N'Phường 9'),
									(N'Phường 10'),
									(N'Phường 11'),
									(N'Phường 12'),
									(N'Phường 13'),
									(N'Phường 14'),
									(N'Phường 15'),
									(N'Phường 17')
go

Insert into PhuongQuanTanBinh values(N'Phường 1'),
									(N'Phường 2'),
									(N'Phường 3'),
									(N'Phường 4'),
									(N'Phường 5'),
									(N'Phường 6'),
									(N'Phường 7'),
									(N'Phường 8'),
									(N'Phường 9'),
									(N'Phường 10'),
									(N'Phường 11'),
									(N'Phường 12'),
									(N'Phường 13'),
									(N'Phường 14'),
									(N'Phường 15')
go

Insert into PhuongQuanTanPhu values(N'Phường Hiệp Tân'),
									(N'Phường Hòa Thạnh'),
									(N'Phường Phú Thạnh'),
									(N'Phường Phú Thọ Hòa'),
									(N'Phường Phú Trung'),
                                    (N'Phường Sơn Kỳ'),
									(N'Phường Tân Quý'),
									(N'Phường Tân Sơn Nhì'),
									(N'Phường Tân Thành'),
                                    (N'Phường Tân Thới Hòa'),
									(N'Phường Tây Thạnh')
go

Insert into XaHuyenBinhChanh values(N'Thị Trấn Tân Túc'),
									(N'Xã An Phú Tây'),
									(N'Xã Bình Chánh'),
									(N'Xã Bình Hưng'),
									(N'Xã Bình Lợi'),
									(N'Xã Đa Phước'),
                                    (N'Xã Hưng Long'),
									(N'Xã Lê Minh Xuân'),
									(N'Xã Pham Văn Hai'),
									(N'Xã Phong Phú'),
									(N'Xã Qui Đức'),
                                    (N'Xã Tân Kiên'),
									(N'Xã Tân Nhựt'),
									(N'Xã Tân Quý Tây'),
									(N'Xã Vĩnh Lộc A'),
									(N'Xã Vĩnh Lộc B')
go

Insert into XaHuyenCanGio values(N'Thị Trấn Cần Thạnh'),
								(N'Xã An Thới Đông'),
								(N'Xã Bình Khánh'),
								(N'Xã Long Hòa'),
								(N'Xã Lý Nhơn'),
                                (N'Xã Tam Thôn Hiệp'),
								(N'Xã Thạnh An')
go

Insert into XaHuyenCuChi values(N'Thị Trấn Củ Chi'),
								(N'Xã Tân Phú Trung'),
								(N'Xã Tân Thông Hội'),
								(N'Xã Tân An Hội'),
								(N'Xã Phước Hiệp'),
								(N'Xã Phước Thạnh'),
                                (N'Xã Thái Mỹ'),
								(N'Xã Trung Lập Hạ'),
								(N'Xã Trung Lập Thượng'),
								(N'Xã An Nhơn Tây'),
								(N'Xã An Phú'),
                                (N'Xã Phú Mỹ Hưng'),
								(N'Xã Nhuận Đức'),
								(N'Xã Phạm Văn Cội'),
								(N'Xã Phú Hòa Đông'),
								(N'Xã Tân Thạnh Tây'),
                                (N'Xã Trung An'),
								(N'Xã Hòa Phú'),
								(N'Xã Bình Mỹ'),
								(N'Xã Tân Thạnh Đông'),
								(N'Xã Phước Vĩnh An')
go

Insert into XaHuyenHocMon values(N'Thị Trấn Hóc Môn'),
								(N'Xã Đông Thạnh'),
								(N'Xã Bà Điểm'),
								(N'Xã Nhị Bình'),
								(N'Xã Tân Thới Nhì'),
								(N'Xã Tân Hiệp'),
                                (N'Xã Tân Xuân'),
								(N'Xã Thới Tam Thôn'),
								(N'Xã Trung Chánh'),
								(N'Xã Xuân Thới Sơn'),
								(N'Xã Xuân Thới Thượng'),
                                (N'Xã Xuân Thới Đông')
go

Insert into XaHuyenNhaBe values(N'Thị Trấn Nhà Bè'),
								(N'Xã Phú Xuân'),
								(N'Xã Phước Kiển'),
                                (N'Xã Hiệp Phước'),
								(N'Xã Phước Lộc'),
								(N'Xã Nhơn Đức'),
								(N'Xã Long Thới')
go


Insert into Duong values(N'Ngô Tất Tố'),
						(N'Trần Não'),
						(N'Điện Biên Phủ'),
						(N'Võ Nguyên Giáp'),
						(N'Xa Lộ Hà Nội'),
						(N'Xô Viết Nghệ Tỉnh')
go

select * from ThongTinCuocGoi
go

select * from Duong
go

select * from KhachHang
select * from TaiXe

--Use master
go
--drop database DoAn_1881101
go