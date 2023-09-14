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

SELECT * FROM dbo.SachMoi
DELETE FROM dbo.SachMoi WHERE bID=1