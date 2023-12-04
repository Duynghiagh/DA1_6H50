use [master]
go

create database Moviet
go

use Moviet
go

create table DaoDien
(
    MaDaoDien nchar(10) not null primary key,
    TenDaoDien nvarchar(30) not null,
    MoTaDaoDien nvarchar(MAX)
)
go

create table DichVu
(
    MaDichVu nchar(10) not null primary key,
    TenDichVu nvarchar(70) not null,
    GiaDichVu money not null,
    TrangThaiDichVu nvarchar(70) not null
)
go

create table DienVien
(
    MaDienVien nchar(10) not null primary key,
    TenDienVien nvarchar(30) not null,
    MoTaDienVien nvarchar(MAX)
)
go

create table Ghe
(
    MaGhe nchar(10) not null primary key,
    MaPhongChieu nchar(10) not null,
    HangGhe nchar(20) not null,
    GiaGhe money not null,
    TrangThai nvarchar(70) not null
)
go

create table HoaDon
(
    MaHoaDon nchar(10) not null primary key,
    HinhThucThanhToan nvarchar(30) not null,
    SoTien money not null,
    ThoiGianThanhToan datetime,
    TrangThaiThanhToan nvarchar(20) not null,
    MaKhachHang nchar(10) not null,
    MaVoucher nchar(10),
    ThoiGianXacNhanHoaDon datetime
)

create table HoaDonChiTiet
(
    MaHoaDonChiTiet nchar(10) not null primary key,
    MaHoaDon nchar(10) not null,
    MaVe nchar(10) not null,
    MaDichVu nchar(10),
    SoLuongVe int,
    TongTien money
)
go

create table KhachHang
(
    MaKhachHang nchar(10) not null primary key,
    SDTKhachHang nchar(20) not null,
    DiaChi nvarchar(255),
    TichDiem int,
    HangKhachHang nvarchar(50)
)
go

create table LichChieu
(
    MaLichChieu nchar(10) not null primary key,
    MaPhim nchar(10) not null,
    MaPhongChieu nchar(10) not null,
    ThoiGianChieu datetime
)
go

create table Phim
(
    MaPhim nchar(10) not null primary key,
    TenPhim nvarchar(70) not null,
    NgonNgu nvarchar(30) not null,
    MaTheLoai nchar(10) not null,
    MaDaoDien nchar(10) not null,
    MaDienVien nchar(10) not null,
    MoTa nvarchar(MAX),
    Rated nchar(10),
    NgayPhatHanh datetime not null,
    ThoiLuong decimal
)
go

create table PhongChieu
(
    MaPhongChieu nchar(10) not null primary key,
    SoGhe int not null,
    SoGheDaDat int,
    TrangThai nvarchar(30)
)
go

create table TheLoai
(
    MaTheLoai nchar(10) not null primary key,
    TenTheLoai nvarchar(50)
)
go

create table ThongKe
(
    MaThongKe nchar(10) not null primary key,
    DoanhThuPhimNgay money,
    DoanhThuDichVuNgay money,
    SoVeDaBan int
)
go

create table Ve
(
    MaVe nchar(10) not null primary key,
    MaPhim nchar(10) not null,
    MaPhongChieu nchar(10) not null,
    MaGhe nchar(10) not null,
    MaLichChieu nchar(10) not null
)
go

create table Voucher
(
    MaVoucher nchar(10) not null primary key,
    LoaiVoucher nvarchar(100) not null,
    GiaTri money,
    HanSuDung datetime
)

alter table Ghe add foreign key(MaPhongChieu)
references PhongChieu (MaPhongChieu)
go
alter table HoaDon add foreign key(MaVoucher)
references Voucher (MaVoucher)
go
alter table HoaDon add foreign key(MaKhachHang)
references KhachHang (MaKhachHang)
go
alter table HoaDonChiTiet add foreign key(MaDichVu)
references DichVu (MaDichVu)
go
alter table HoaDonChiTiet add foreign key(MaHoaDon)
references HoaDon (MaHoaDon)
go
alter table HoaDonChiTiet add foreign key(MaVe)
references Ve (MaVe)
go
alter table LichChieu add foreign key(MaPhim)
references Phim (MaPhim)
go
alter table LichChieu add foreign key(MaPhongChieu)
references PhongChieu (MaPhongChieu)
go
alter table Phim add foreign key(MaDaoDien)
references DaoDien (MaDaoDien)
go
alter table Phim add foreign key(MaDienVien)
references DienVien (MaDienVien)
go
alter table Phim add foreign key(MaTheLoai)
references TheLoai (MaTheLoai)
go
alter table Ve add foreign key(MaGhe)
references Ghe (MaGhe)
go
alter table Ve add foreign key(MaLichChieu)
references LichChieu(MaLichChieu)
go
alter table Ve add foreign key(MaPhim)
references Phim (MaPhim)
go
alter table Ve add foreign key(MaPhongChieu)
references PhongChieu (MaPhongChieu)
go