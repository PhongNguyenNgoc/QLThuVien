CREATE DATABASE QLTV

USE QLTV


CREATE TABLE DangNhap (
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	username VARCHAR(150) NOT NULL,
	pass VARCHAR(150) NOT NULL
)
INSERT INTO dbo.DangNhap
(
    username,
    pass
)
VALUES
(   'admin', -- username - varchar(150)
    'admin'  -- pass - varchar(150)
    )

SELECT * FROM dbo.DangNhap