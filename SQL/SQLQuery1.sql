--if exists (select * from sys.databases where name = 'mytools')  
--  drop database mytools 
--go
--create database mytools
--go

use mytools

go
--创建md5表：原始字符，加密字符，加密时间，加密IP 
--create table md5
--(
--id int primary key,
--text1 nvarchar(255) not null,
--text2 varchar(255) not null,
--time datetime not null,
--ip char(50)
--)
go
--创建代码生成表：模板内容，创建日期，保存地址


 -- 允许修改系统表，如果不是系统表，下面2句可以忽略
exec sp_configure 'allow updates',1
reconfigure with override
GO
update syscolumns set colstat = 1 where id = object_id('md5') and name = 'id'
----重新设置标识的起始值
DBCC CHECKIDENT (mytools, RESEED, 10003)

----禁止对系统表进行更新恢复 ( 如果非系统表可以忽略)
exec sp_configure 'allow updates',0
reconfigure with override
