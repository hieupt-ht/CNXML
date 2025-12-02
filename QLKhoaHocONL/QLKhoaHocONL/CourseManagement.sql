-------------------------------------------------------------
-- RESET DATABASE (SAFELY)
-------------------------------------------------------------
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

-------------------------------------------------------------
-- TABLES
-------------------------------------------------------------

-- Account (login)
CREATE TABLE Account (
    AccountId    INT IDENTITY PRIMARY KEY,
    Username     VARCHAR(50)  NOT NULL UNIQUE,
    [Password]   VARCHAR(255) NOT NULL,
    FullName     NVARCHAR(100) NULL,
    Role         VARCHAR(10)  NOT NULL CONSTRAINT DF_Account_Role DEFAULT ('User'),
    CONSTRAINT CK_Account_Role CHECK (Role IN ('Admin','User'))
);
GO

-- Instructor
CREATE TABLE Instructor (
    InstructorId INT IDENTITY PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Email VARCHAR(100) NULL UNIQUE,
    Phone VARCHAR(20) NULL,
    Expertise NVARCHAR(200) NULL
);
GO

-- Student
CREATE TABLE Student (
    StudentId INT IDENTITY PRIMARY KEY,
    FullName  NVARCHAR(100) NOT NULL,
    Email     VARCHAR(100) NULL UNIQUE,
    Phone     VARCHAR(20) NULL,
    [Address] NVARCHAR(255) NULL
);
GO

-- Course
CREATE TABLE Course (
    CourseId     INT IDENTITY PRIMARY KEY,
    TenKhoaHoc   NVARCHAR(200) NOT NULL,
    GiaGoc       NVARCHAR(50) NULL,
    GiaGiam      NVARCHAR(50) NULL,
    SoHocVien    INT NOT NULL CONSTRAINT DF_Course_SoHocVien DEFAULT (0),
    ThoiLuong    NVARCHAR(50) NULL,
    TenAnh       NVARCHAR(255) NULL,
    MauBatDau    VARCHAR(20) NULL,
    MauKetThuc   VARCHAR(20) NULL,
    DemoLink     VARCHAR(255) NULL,
    InstructorId INT NULL,
    CONSTRAINT FK_Course_Instructor FOREIGN KEY (InstructorId) REFERENCES Instructor(InstructorId)
);
GO

-- AccountCourse (mua khóa học)
CREATE TABLE AccountCourse (
    AccountId   INT NOT NULL,
    CourseId    INT NOT NULL,
    PurchasedAt DATETIME NOT NULL CONSTRAINT DF_AccountCourse_PurchasedAt DEFAULT (GETDATE()),
    CONSTRAINT PK_AccountCourse PRIMARY KEY (AccountId, CourseId),
    CONSTRAINT FK_AccountCourse_Account FOREIGN KEY (AccountId) REFERENCES Account(AccountId),
    CONSTRAINT FK_AccountCourse_Course FOREIGN KEY (CourseId) REFERENCES Course(CourseId)
);
GO

-- Video
CREATE TABLE Video (
    VideoId INT IDENTITY PRIMARY KEY,
    CourseId INT NOT NULL,
    Title NVARCHAR(200) NOT NULL,
    Url VARCHAR(255) NOT NULL,
    [Order] INT NOT NULL CONSTRAINT DF_Video_Order DEFAULT(1),
    CONSTRAINT FK_Video_Course FOREIGN KEY (CourseId) REFERENCES Course(CourseId)
);
GO


-------------------------------------------------------------
-- ADD AccountId TO Student (SAFE)
-------------------------------------------------------------
IF COL_LENGTH('Student','AccountId') IS NULL
BEGIN
    ALTER TABLE Student ADD AccountId INT NULL;
END
GO

-- Backfill (nếu email trùng username)
UPDATE s
SET s.AccountId = a.AccountId
FROM Student s
JOIN Account a ON a.Username = s.Email;
GO

-- Index + Foreign Key
IF NOT EXISTS (
    SELECT * FROM sys.indexes WHERE name = 'IX_Student_AccountId'
)
BEGIN
    CREATE INDEX IX_Student_AccountId ON Student(AccountId);
END
GO

ALTER TABLE Student
WITH CHECK
ADD CONSTRAINT FK_Student_Account
    FOREIGN KEY (AccountId) REFERENCES Account(AccountId);
GO


-------------------------------------------------------------
-- SEED DATA
-------------------------------------------------------------

-- Account
INSERT INTO Account (Username,[Password],FullName,Role) VALUES
('admin','admin123',N'Quản trị viên','Admin'),
('hocvien','123456',N'Học viên F8','User');
GO

-- Instructor
INSERT INTO Instructor (FullName,Email,Phone,Expertise) VALUES
(N'Nguyễn Văn A','nguyenvana@edu.com','0901000100',N'Fullstack Web'),
(N'Trần Thị B','tranthib@edu.com','0902000200',N'UI/UX'),
(N'Lê Hoàng C','lehoangc@edu.com','0903000300',N'Mobile'),
(N'Phạm Đình D','phamdinhd@edu.com','0904000400',N'Backend & Database'),
(N'Hoàng Minh E','hoangminhe@edu.com','0905000500',N'Frontend React');
GO

-- Student
INSERT INTO Student (FullName,Email,Phone,[Address]) VALUES
(N'Nguyễn Tuấn Anh','anhnt@student.com','0911111111',N'Hà Nội'),
(N'Phạm Thị Hoa','hoapt@student.com','0922222222',N'Đà Nẵng'),
(N'Lê Minh Đức','duclm@student.com','0933333333',N'Hồ Chí Minh'),
(N'Hòai Thu','thuh@student.com','0944444444',N'Cần Thơ'),
(N'Trần Quang Hưng','hungtq@student.com','0955555555',N'Huế');
GO

-- Course
INSERT INTO Course (TenKhoaHoc,GiaGoc,GiaGiam,SoHocVien,ThoiLuong,TenAnh,MauBatDau,MauKetThuc,DemoLink,InstructorId) VALUES
(N'HTML, CSS Pro','2.500.000d','1.299.000d',590,N'116h50p','html_css_pro.png','#2979FF','#4C3AE3','https://www.youtube.com/watch?v=3Cg3smqsOmk',1),
(N'JavaScript Pro','3.299.000d','1.399.000d',254,N'49h34p','js_pro.png','#FFD600','#FF6D00','https://www.youtube.com/watch?v=3Cg3smqsOmk',2),
(N'ReactJS Master','4.000.000d','2.100.000d',1200,N'52h00p','reactjs.png','#00c6ff','#0072ff','https://www.youtube.com/watch?v=3Cg3smqsOmk',5),
(N'NodeJS & ExpressJS','3.500.000d','1.800.000d',850,N'38h15p','nodejs.png','#11998e','#38ef7d','https://www.youtube.com/watch?v=3Cg3smqsOmk',4),
(N'Ngôn ngữ Sass','400.000d','299.000d',300,N'6h18p','sass.png','#ec008c','#fc6767','https://www.youtube.com/watch?v=3Cg3smqsOmk',2),
(N'App Design System','1.200.000d','899.000d',150,N'12h30p','design.png','#8E2DE2','#4A00E0','https://www.youtube.com/watch?v=3Cg3smqsOmk',3);
GO

-- Video
INSERT INTO Video (CourseId,Title,Url,[Order]) VALUES
(1,N'Giới thiệu khóa HTML/CSS','https://www.youtube.com/watch?v=zWSkX8r08i0',1),
(1,N'Thiết lập VSCode cho HTML/CSS','https://www.youtube.com/watch?v=R6plN3FvzFY',2),
(2,N'JavaScript cơ bản - Biến và kiểu dữ liệu','https://www.youtube.com/watch?v=MGhw6XliFgo',1),
(3,N'ReactJS - Component và Props','https://www.youtube.com/watch?v=Ke90Tje7VS0',1);
GO


-------------------------------------------------------------
-- CHECK RESULT
-------------------------------------------------------------
SELECT * FROM Account;
SELECT * FROM Instructor;
SELECT * FROM Student;
SELECT * FROM Course;
SELECT * FROM Video;
GO
select * from AccountCourse