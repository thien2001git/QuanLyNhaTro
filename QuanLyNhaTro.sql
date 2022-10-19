use master
go
if(exists(select * from sysdatabases where name ='QLPhongTro'))
Drop database QLPhongTro

create database QLPhongTro
go

use QLPhongTro
go

create table TAIkHOAN
(
    TenTaiKhoan nvarchar(100) primary key,
	MatKhau nvarchar(100),
	SDT varchar(12),
	Email nvarchar(100),
)
go
create table KHACHHANG
(
    maKH int not null primary key,
	TenKH nvarchar(100) not null,
	GioiTinh nvarchar(5),
	NgaySinh date,
	DiaChi nvarchar(200),
	SDT nvarchar(25),
)
go

create table PHONGTRO
(
    MaPhongTro int not null primary key,
	TenPhongTro nvarchar(100),
	DienTich float, --met vuong
	LoaiPhong varchar(30) not null,
	GiaPhong float,
	trangThai nvarchar(50),
)
go
create table THIETBI
(
    MaThietBi int not null primary key,
	TenThietBi nvarchar(100),
)
go
create table CHITETTHIETBI
(
    MaThietBi int not null,
	foreign key(MaThietBi) references THIETBI(MaThietBi) on delete cascade on update cascade,
	soLuong int,
	maphong int not null,
	primary key(MaThietBi,maphong),
	foreign key(maphong) references PHONGTRO(MaPhongTro) on delete cascade on update cascade,
)
go
create table DichVu
(
    MaDV int not null primary key,
	TenDV nvarchar(20),
	Gia float DEFAULT 0,
)
go
create table DienNuoc
(
    MaDN int not null primary key,
    MaDV int  not null,
	foreign key(MaDV) references DichVu(MaDV) on delete cascade on update cascade,
	SoCu int not null,
	SoMoi int not null,
	ngayChot date not null,
	MaPhongTro int  not null,	
	foreign key(MaPhongTro) references PHONGTRO(MaPhongTro) on delete cascade on update cascade,
)
go
create table HOADON
(
     SoHD int not null primary key,
	 KhachHang nvarchar(100),
	 NgayLap date,
	 TrangThai nvarchar(20),
     MaPhongTro int not null,
     foreign key(MaPhongTro) references PHONGTRO(MaPhongTro) on delete cascade on update cascade,
	 GiaPhong float DEFAULT 0,
	 SoDienSuDung int,
	 TienDien float DEFAULT 0,
	 SoNuocSuDung int,
	 TienNuoc float DEFAULT 0,
)
go

create table THUEPHONG
(
     MaSoThue int not null primary key ,
	 KhachHang nvarchar(100),
	 NgayThue date not null,
	 trangThai nvarchar(20),
	 MaPhongTro int not null,
	 foreign key(MaPhongTro) references PHONGTRO(MaPhongTro) on delete cascade on update cascade,
	 TienCoc float DEFAULT 0,
	 GiaPhong float DEFAULT 0,
)
go

-- chen thông tin table TAIKHOAN
insert into TAIkHOAN values('Admin1','123456','0987654321','phamhien@gmail.com')
insert into TAIkHOAN values('Admin2','123456','0987654321','phamhien@gmail.com')
go
-- chen thông tin table KHACHHANG
insert into KHACHHANG values(1 ,N'Hoàng Tùng Tú',N'Nữ','09/10/1998',N'Cầu Giấy - Hà Nội','0987635423')
insert into KHACHHANG values(2,N'Trần Thu Thảo',N'Nam','10/03/1997',N'Trung Hòa - Hà Nội','0987635423')
go
-- chen thông tin table PHONGTRO
insert into PHONGTRO values(1,N'Phòng 1',20,N'khép kín',1500000,N'Đang Thuê')
insert into PHONGTRO values(2,N'Phòng 2',19,N'không khép kín',800000, N'Trống')
insert into PHONGTRO values(3,N'Phòng 3',20,N'khép kín',1500000, N'Trống')
insert into PHONGTRO values(4,N'Phòng 4',19,N'không khép kín',800000, N'Đang Thuê')
insert into PHONGTRO values(5,N'Phòng 5',20,N'khép kín',1500000, N'Trống')
insert into PHONGTRO values(7,N'Phòng 7',19,N'không khép kín',800000, N'Trống')
go
-- chen thông tin table THIETBI
insert into THIETBI values(1,N'Bóng Đèn')
insert into THIETBI values(2,N'Giường')
insert into THIETBI values(3,N'Quạt')
insert into THIETBI values(4,N'Giá treo đồ')
go
-- chen thông tin table CHITIETTHIETBI
insert into CHITETTHIETBI values(1,4,1)
insert into CHITETTHIETBI values(3,2,2)
insert into CHITETTHIETBI values(2,1,1)
go
--Chen thông tin table Dichvu
insert into DichVu values(1,N'Điện',4000)
insert into DichVu values(2,N'Nước',15000)
insert into DichVu values(3,N'Internet',40000)
go
--Chen thông tin table ChiTietDichvu
insert into DienNuoc values(1,1,1200,1248,'03/01/2020',1)
insert into DienNuoc values(2,2,200,205,'09/02/2020',1)
insert into DienNuoc values(3,1,1250,1288,'01/03/2020',1)
insert into DienNuoc values(4,1,1200,1248,'02/03/2020',2)
insert into DienNuoc values(5,2,200,205,'02/03/2020',2)
insert into DienNuoc values(6,2,1250,1288,'05/01/2020',2)
insert into DienNuoc values(7,1,1250,1288,'07/03/2020',2)
go
--Chen Thông tin table HoaDon
insert into HOADON values(1,N'Nguyễn Hải Đăng','1/1/2020',N'đã thanh toán',1,1200000,20,80000,5,75000)
insert into HOADON values(2,N'Trần Thái Sơn','1/2/2020',N'chưa thanh toán',1,1200000,20,80000,5,75000)
go


-- chen thông tin table Thue Phong
insert into THUEPHONG values(1,N'Hoàng Thảo','09/10/1998',N'Đang Thuê Phòng',1,500000,1200000)
insert into THUEPHONG values(2,N'Thúy My','09/10/2019',N'Đã Trả Phòng',2,500000,1200000)
go


--hien thi
select TenTaiKhoan, MatKhau from TAIkHOAN

select * from KHACHHANG

select * from PHONGTRO

select * from THIETBI

select * from CHITETTHIETBI

select * from DichVu

select * from DienNuoc

select * from HOADON

select * from THUEPHONG
go

 --Tạo thủ tục Lấy thông tin điện nước 
 
 create Proc getDienNuoc_info
As 
  begin 
        select d.MaDN, p.TenPhongTro , dv.TenDV AS TenDV , SoCu , SoMoi,  (SoMoi - SoCu) AS N'SoDaSuDung', ngayChot 
		from DienNuoc d 
		inner join PhongTro p on d.MaPhongTro = p.MaPhongTro 
		inner join DichVu dv  on dv.MaDV = d.MaDV
  end
go
   -- chạy
 EXEC getDienNuoc_info
 go

 --Tạo thủ tục HoaDon

 create Proc getHoaDon_info
As 
  begin 
        select hd.SoHD,KhachHang, hd.NgayLap, pt.MaPhongTro , pt.GiaPhong, hd.SoDienSuDung ,hd.TienDien, hd.SoNuocSuDung, hd.TienNuoc, (pt.GiaPhong + hd.TienDien + hd.TienNuoc) As 'ThanhTien', hd.TrangThai
        from HOADON hd
        inner join PHONGTRO pt on pt.MaPhongTro  = hd.MaPhongTro
  end
go

EXEC getHoaDon_info
go

select maDN, (SoMoi - SoCu ),(SoMoi - SoCu )*dv.Gia AS 'SodienSudung' from DienNuoc dn
inner join DichVu dv on dv.MaDV = dn.MaDV
where maDN  = 1



