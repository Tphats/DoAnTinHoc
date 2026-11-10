CREATE DATABASE QuanLyThuVien;
GO

USE QuanLyThuVien;
GO

-- Bảng Độc Giả
CREATE TABLE DocGia
(
    MaDocGia INT IDENTITY(1,1) PRIMARY KEY, -- indentity(giá trị bắt đầu , bước nhảy )  : tăng tự động
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(200),
    SDT VARCHAR(15),
    Email VARCHAR(100)
);
-- bảng tài khoản
CREATE TABLE TaiKhoan
(
    MaTK INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap VARCHAR(50) UNIQUE NOT NULL, -- Tên đăng nhập bắt buộc nhập ( not null ) mỗi tên chỉ được nhập một lần unique
    MatKhau VARCHAR(100) NOT NULL,
    VaiTro NVARCHAR(20) NOT NULL
);
-- tác giả
CREATE TABLE TacGia
(
    MaTacGia INT IDENTITY(1,1) PRIMARY KEY,
    TenTacGia NVARCHAR(100) NOT NULL
);
-- Thể loại
CREATE TABLE TheLoai
(
    MaTheLoai INT IDENTITY(1,1) PRIMARY KEY,
    TenTheLoai NVARCHAR(100) NOT NULL
);
-- Nhà xuất bản
CREATE TABLE NhaXuatBan
(
    MaNXB INT IDENTITY(1,1) PRIMARY KEY,
    TenNXB NVARCHAR(150) NOT NULL,
    DiaChi NVARCHAR(200)
);
-- Bảng Sách

CREATE TABLE Sach
(
    MaSach INT IDENTITY(1,1) PRIMARY KEY,

    TenSach NVARCHAR(200) NOT NULL,

    MaTacGia INT NOT NULL,

    MaNXB INT NOT NULL,

    MaTheLoai INT NOT NULL,

    NamXuatBan INT,

    SoLuong INT NOT NULL,

    SoLuongCon INT NOT NULL,

    FOREIGN KEY (MaTacGia)
        REFERENCES TacGia(MaTacGia),

    FOREIGN KEY (MaNXB)
        REFERENCES NhaXuatBan(MaNXB),

    FOREIGN KEY (MaTheLoai)
        REFERENCES TheLoai(MaTheLoai)
);
-- Phiếu mượn : một độc giả có thể mượn nhiều lần , mqh 1-N
CREATE TABLE PhieuMuon
(
    MaPM INT IDENTITY(1,1) PRIMARY KEY,

    MaDocGia INT NOT NULL,

    NgayMuon DATE NOT NULL,

    HanTra DATE NOT NULL,

    TrangThai NVARCHAR(30),

    FOREIGN KEY (MaDocGia)
        REFERENCES DocGia(MaDocGia)
);
-- Chi tiết phiếu mượn : 1 phiếu có thể mượn nhiều sách
CREATE TABLE ChiTietPhieuMuon
(
    MaPM INT,

    MaSach INT,

    SoLuong INT DEFAULT 1,

    PRIMARY KEY (MaPM, MaSach), -- khóa chính kép 

    FOREIGN KEY (MaPM)
        REFERENCES PhieuMuon(MaPM),

    FOREIGN KEY (MaSach)
        REFERENCES Sach(MaSach)
);
--Phieu tra
CREATE TABLE PhieuTra
(
    MaPT INT IDENTITY(1,1) PRIMARY KEY,

    MaPM INT UNIQUE NOT NULL, -- unique : mỗi phiếu mượn chỉ được trả một lần

    NgayTra DATE NOT NULL,

    TienPhat DECIMAL(18,2) DEFAULT 0,

    FOREIGN KEY (MaPM)
        REFERENCES PhieuMuon(MaPM)
);
