--cau1-----------
IF DB_ID(N'QLSinhVien') IS NULL
CREATE DATABASE QLSinhVien;
GO
USE QLSinhVien;
GO
--cau2-----------
CREATE TABLE Khoa
(
MaKhoa VARCHAR(10) PRIMARY KEY,
TenKhoa NVARCHAR(100) NOT NULL UNIQUE
);
CREATE TABLE SinhVien
(
MaSV VARCHAR(15) PRIMARY KEY,
HoTen NVARCHAR(100) NOT NULL,
NgaySinh DATE NOT NULL,
GioiTinh BIT NOT NULL,
MaKhoa VARCHAR(10) NOT NULL,
DiemTB DECIMAL(4,2) NOT NULL DEFAULT 0,
Email VARCHAR(100) NULL,
CONSTRAINT CK_SinhVien_Diem CHECK (DiemTB BETWEEN 0 AND 10),
CONSTRAINT FK_SinhVien_Khoa FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);
--cau3--------------------
CREATE TABLE HocPhan
(
MaHP VARCHAR(10) PRIMARY KEY,
TenHP NVARCHAR(120) NOT NULL,
SoTinChi INT NOT NULL CHECK (SoTinChi BETWEEN 1 AND 6)
);
CREATE TABLE DangKy
(
MaSV VARCHAR(15) NOT NULL,
MaHP VARCHAR(10) NOT NULL,
HocKy INT NOT NULL CHECK (HocKy BETWEEN 1 AND 3),
Diem DECIMAL(4,2) NULL CHECK (Diem BETWEEN 0 AND 10),
PRIMARY KEY (MaSV, MaHP),
FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
FOREIGN KEY (MaHP) REFERENCES HocPhan(MaHP)
);
--cau4-------------------------
INSERT INTO Khoa(MaKhoa, TenKhoa) VALUES
('CNTT', N'Công nghệ thông tin'),
('OTO', N'Công nghệ kỹ thuật ô tô'),
('KT', N'Kinh tế');
INSERT INTO SinhVien(MaSV, HoTen, NgaySinh, GioiTinh, MaKhoa, DiemTB, Email) VALUES
('SV001', N'Nguyễn Văn An', '2005-02-15', 1, 'CNTT', 8.20, 'an@eaut.edu.vn'),
('SV002', N'Trần Thị Bình', '2005-07-21', 0, 'CNTT', 7.40, 'binh@eaut.edu.vn'),
('SV003', N'Lê Văn Cường', '2004-12-03', 1, 'OTO', 6.80, NULL);