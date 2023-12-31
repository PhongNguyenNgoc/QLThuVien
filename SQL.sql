﻿CREATE DATABASE QLTV

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
MSSV BIGINT NOT NULL PRIMARY KEY,
HoTen NVARCHAR(250) NOT NULL,
NgaySinh VARCHAR(250) NOT NULL,
Lop VARCHAR(250) NOT NULL,
KhoaHoc VARCHAR(250) NOT NULL,
Nganh NVARCHAR(250) NOT NULL
)

CREATE TABLE MuonSach(
id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
MSSV BIGINT NOT NULL,
HoTen NVARCHAR(250),
Lop VARCHAR(250) NOT NULL,
KhoaHoc VARCHAR(250) NOT NULL,
Nganh NVARCHAR(250) NOT NULL,

SachMuon NVARCHAR(250) NOT NULL,
ngayMuon VARCHAR(250) NOT NULL,
ngayTra VARCHAR(250)

)








SELECT * FROM dbo.MuonSach

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

UPDATE dbo.SV SET HoTen ='Nguyễn Văn A',NgaySinh='26 Tha´ng Chi´n 2023', Lop ='s23-62kt', KhoaHoc='2020-2025', Nganh='QTKD ' WHERE MSSV='2503567895'
UPDATE dbo.SV SET Nganh=N'Công Nghệ Thông Tin' WHERE MSSV='2051067212'

SELECT MSSV, HoTen AS 'Họ và tên' FROM dbo.SV

SELECT * FROM dbo.MuonSach

INSERT dbo.MuonSach
        ( MSSV ,
          HoTen ,
          Lop ,
          KhoaHoc ,
          Nganh ,
          SachMuon ,
          ngayMuon ,
          ngayTra
        )
VALUES  ( 0 , -- MSSV - bigint
          N'a' , -- HoTen - nvarchar(250)
          'a' , -- Lop - varchar(250)
          'a' , -- KhoaHoc - varchar(250)
          N'a' , -- Nganh - nvarchar(250)
          N'a' , -- SachMuon - nvarchar(250)
          'a' , -- ngayMuon - varchar(250)
          ''  -- ngayTra - varchar(250)
        )
SELECT * from dbo.MuonSach WHERE MSSV=2051067212

DELETE FROM dbo.MuonSach WHERE MSSV=2051067212

SELECT COUNT(MSSV) FROM dbo.MuonSach WHERE MSSV='2051067212'
DROP TABLE dbo.MuonSach

SELECT * EXCEPT (ngayTra) fro