CREATE DATABASE QLTV

USE QLTV


CREATE TABLE DangNhap (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	username VARCHAR(150) NOT NULL,
	pass VARCHAR(150) NOT NULL
)

CREATE TABLE SachMoi(
	bID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	bTua NVARCHAR(250) NOT NULL,
	bTheLoai NVARCHAR(250) NOT NULL,
	bTacGia NVARCHAR(250) NOT NULL,
	bNXB NVARCHAR(250) NOT NULL,
	bNgayNhap VARCHAR(250) NOT NULL,
	bGia BIGINT NOT NULL,
	bSoLuong BIGINT NOT NULL

)

CREATE TABLE SV(
MSSV VARCHAR(250) NOT NULL PRIMARY KEY,
HoTen NVARCHAR(250) NOT NULL,
NgaySinh VARCHAR(250) NOT NULL,
Lop VARCHAR(250) NOT NULL,
KhoaHoc VARCHAR(250) NOT NULL,
Nganh NVARCHAR(250) NOT NULL
)

SELECT * FROM dbo.SachMoi

INSERT INTO SachMoi(bTua,bTheLoai,bTacGia,bNXB,bNgayNhap,bGia,bSoLuong)
VALUES  ( N'' , 
          N'' , 
          N'' , 
          N'' ,
          '' , 
          0 , 
          0  
        )
INSERT INTO dbo.SachMoi
        ( bTua ,
          bTheLoai ,
          bTacGia ,
          bNXB ,
          bNgayNhap ,
          bGia ,
          bSoLuong
        )
VALUES  ( N'' , -- bTua - nvarchar(250)
          N'' , -- bTheLoai - nvarchar(250)
          N'' , -- bTacGia - nvarchar(250)
          N'' , -- bNXB - nvarchar(250)
          '' , -- bNgayNhap - varchar(250)
          0 , -- bGia - bigint
          0  -- bSoLuong - bigint
        )

SELECT * FROM dbo.SV
DELETE FROM dbo.SachMoi WHERE bID=1

