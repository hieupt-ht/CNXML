IF EXISTS (SELECT * FROM sys.databases WHERE name = N'OnlineCourseDB')
BEGIN
    USE master;
    ALTER DATABASE OnlineCourseDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE OnlineCourseDB;
END
GO

CREATE DATABASE OnlineCourseDB;
GO

USE OnlineCourseDB;
GO

CREATE TABLE TaiKhoan (
    MaTaiKhoan INT IDENTITY PRIMARY KEY,
    TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(255) NOT NULL,
    HoTen NVARCHAR(100) NULL,
    VaiTro VARCHAR(10) NOT NULL CONSTRAINT DF_TaiKhoan_VaiTro DEFAULT ('User'),
    CONSTRAINT CK_TaiKhoan_VaiTro CHECK (VaiTro IN ('Admin','User'))
);
GO

CREATE TABLE GiangVien (
    MaGiangVien INT IDENTITY PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    DienThoai VARCHAR(10) NULL, 
    ChuyenMon NVARCHAR(200) NULL,
    CONSTRAINT CK_GiangVien_DienThoai CHECK (
        DienThoai IS NULL OR 
        (LEN(DienThoai) = 10 AND DienThoai NOT LIKE '%[^0-9]%')
    )
);
GO

CREATE TABLE HocVien (
    MaHocVien INT IDENTITY PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    DienThoai VARCHAR(10) NULL,
    DiaChi NVARCHAR(255) NULL,
    NgayDK DATETIME NOT NULL CONSTRAINT DF_HocVien_NgayDK DEFAULT (GETDATE()),
    MaTaiKhoan INT NULL,
    CONSTRAINT CK_HocVien_DienThoai CHECK (
        DienThoai IS NULL OR 
        (LEN(DienThoai) = 10 AND DienThoai NOT LIKE '%[^0-9]%')
    )
);
GO

CREATE TABLE KhoaHoc (
    MaKhoaHoc INT IDENTITY PRIMARY KEY,
    TenKhoaHoc NVARCHAR(200) NOT NULL,
    GiaGoc NVARCHAR(50) NULL,
    GiaGiam NVARCHAR(50) NULL,
    SoHocVien INT NOT NULL CONSTRAINT DF_KhoaHoc_SoHocVien DEFAULT (0),
    ThoiLuong NVARCHAR(50) NULL,
    TenAnh NVARCHAR(255) NULL,
    MauBatDau VARCHAR(20) NULL,
    MauKetThuc VARCHAR(20) NULL,
    LinkDemo VARCHAR(255) NULL,
    MaGiangVien INT NULL,
    CONSTRAINT FK_KhoaHoc_GiangVien FOREIGN KEY (MaGiangVien) REFERENCES GiangVien(MaGiangVien)
);
GO

CREATE TABLE TaiKhoan_KhoaHoc (
    MaTaiKhoan INT NOT NULL,
    MaKhoaHoc INT NOT NULL,
    NgayMua DATETIME NOT NULL CONSTRAINT DF_TaiKhoan_KhoaHoc_NgayMua DEFAULT (GETDATE()),
    CONSTRAINT PK_TaiKhoan_KhoaHoc PRIMARY KEY (MaTaiKhoan, MaKhoaHoc),
    CONSTRAINT FK_TKKH_TaiKhoan FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan),
    CONSTRAINT FK_TKKH_KhoaHoc FOREIGN KEY (MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc)
);
GO

CREATE TABLE ThongBao (
    MaThongBao INT IDENTITY PRIMARY KEY,
    TieuDe NVARCHAR(200) NOT NULL,
    NoiDung NVARCHAR(500) NOT NULL,
    NgayTao DATETIME NOT NULL CONSTRAINT DF_ThongBao_NgayTao DEFAULT (GETDATE()),
    DaDoc BIT NOT NULL CONSTRAINT DF_ThongBao_DaDoc DEFAULT (0),
    MaKhoaHoc INT NULL,
    MaTaiKhoan INT NULL,
    CONSTRAINT FK_ThongBao_KhoaHoc FOREIGN KEY (MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc),
    CONSTRAINT FK_ThongBao_TaiKhoan FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan)
);
GO

CREATE TABLE VideoBaiGiang (
    MaVideo INT IDENTITY PRIMARY KEY,
    MaKhoaHoc INT NOT NULL,
    TieuDe NVARCHAR(200) NOT NULL,
    Link VARCHAR(255) NOT NULL,
    ThuTu INT NOT NULL CONSTRAINT DF_Video_ThuTu DEFAULT(1),
    CONSTRAINT FK_Video_KhoaHoc FOREIGN KEY (MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc)
);
GO

ALTER TABLE HocVien
ADD CONSTRAINT FK_HocVien_TaiKhoan
FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan);
GO

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, HoTen, VaiTro) VALUES
('admin', 'admin123', N'Quản trị viên', 'Admin'),
('hocvien', '123456', N'Học viên F8', 'User');
GO

INSERT INTO GiangVien (HoTen, Email, DienThoai, ChuyenMon) VALUES
(N'Nguyễn Văn A','nguyenvana@edu.com','0901000100',N'Fullstack Web'),
(N'Trần Thị B','tranthib@edu.com','0902000200',N'UI/UX'),
(N'Lê Hoàng C','lehoangc@edu.com','0903000300',N'Mobile'),
(N'Phạm Đình D','phamdinhd@edu.com','0904000400',N'Backend & Database'),
(N'Hoàng Minh E','hoangminhe@edu.com','0905000500',N'Frontend React');
GO

INSERT INTO HocVien (HoTen, Email, DienThoai, DiaChi) VALUES
(N'Nguyễn Tuấn Anh','anhnt@student.com','0911111111',N'Hà Nội'),
(N'Phạm Thị Hoa','hoapt@student.com','0922222222',N'Đà Nẵng'),
(N'Lê Minh Đức','duclm@student.com','0933333333',N'Hồ Chí Minh'),
(N'Hòai Thu','thuh@student.com','0944444444',N'Cần Thơ'),
(N'Trần Quang Hưng','hungtq@student.com','0955555555',N'Huế');
GO

INSERT INTO KhoaHoc (TenKhoaHoc, GiaGoc, GiaGiam, SoHocVien, ThoiLuong, TenAnh, MauBatDau, MauKetThuc, LinkDemo, MaGiangVien) VALUES
(N'HTML, CSS Pro','2.500.000d','1.299.000d',590,N'116h50p','html_css_pro.png','#2979FF','#4C3AE3','https://www.youtube.com/watch?v=3Cg3smqsOmk',1),
(N'JavaScript Pro','3.299.000d','1.399.000d',254,N'49h34p','js_pro.png','#FFD600','#FF6D00','https://www.youtube.com/watch?v=3Cg3smqsOmk',2),
(N'ReactJS Master','4.000.000d','2.100.000d',1200,N'52h00p','reactjs.png','#00c6ff','#0072ff','https://www.youtube.com/watch?v=3Cg3smqsOmk',5),
(N'NodeJS & ExpressJS','3.500.000d','1.800.000d',850,N'38h15p','nodejs.png','#11998e','#38ef7d','https://www.youtube.com/watch?v=3Cg3smqsOmk',4),
(N'Ngôn ngữ Sass','400.000d','299.000d',300,N'6h18p','sass.png','#ec008c','#fc6767','https://www.youtube.com/watch?v=3Cg3smqsOmk',2),
(N'App Design System','1.200.000d','899.000d',150,N'12h30p','design.png','#8E2DE2','#4A00E0','https://www.youtube.com/watch?v=3Cg3smqsOmk',3);
GO

INSERT INTO VideoBaiGiang (MaKhoaHoc, TieuDe, Link, ThuTu) VALUES
(1,N'Giới thiệu khóa HTML/CSS','https://www.youtube.com/watch?v=zWSkX8r08i0',1),
(1,N'Thiết lập VSCode cho HTML/CSS','https://www.youtube.com/watch?v=R6plN3FvzFY',2),
(2,N'JavaScript cơ bản - Biến và kiểu dữ liệu','https://www.youtube.com/watch?v=MGhw6XliFgo',1),
(3,N'ReactJS - Component và Props','https://www.youtube.com/watch?v=Ke90Tje7VS0',1);
GO

INSERT INTO ThongBao (TieuDe, NoiDung, MaKhoaHoc, MaTaiKhoan, DaDoc)
VALUES (N'Thông báo demo', N'Học viên demo đã mua khóa HTML/CSS Pro', 1, 2, 0);
GO

SELECT * FROM TaiKhoan;
SELECT * FROM GiangVien;
SELECT * FROM KhoaHoc;
SELECT * FROM HocVien;
SELECT * FROM VideoBaiGiang;
SELECT * FROM ThongBao;
SELECT * FROM TaiKhoan_KhoaHoc;
GO