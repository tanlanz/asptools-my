use mytools
go
/*用户表*/
--CREATE TABLE users
--(
--id INT PRIMARY KEY,
--username VARCHAR(50) NOT NULL UNIQUE,
--name NVARCHAR(25) NOT NULL,
--password VARCHAR(25) NOT NULL,
--signInTime DATETIME NOT NULL,
--state INT DEFAULT'0'
--)

/*用户信息*/
--CREATE TABLE UserInfo(
--id INT PRIMARY KEY,
--userId INT NOT NULL,
--username VARCHAR(50) NOT NULL,
--age INT,
--sex NVARCHAR(2),
--phone INT,
--ID_Card VARCHAR(25),
--email VARCHAR(25),
--photo VARCHAR(50),
--FOREIGN  KEY(username) REFERENCES users(username),
--FOREIGN  KEY(userId) REFERENCES users(id)
)