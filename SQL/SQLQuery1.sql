--if exists (select * from sys.databases where name = 'mytools')  
--  drop database mytools 
--go
--create database mytools
--go

use mytools

go
--����md5��ԭʼ�ַ��������ַ�������ʱ�䣬����IP 
--create table md5
--(
--id int primary key,
--text1 nvarchar(255) not null,
--text2 varchar(255) not null,
--time datetime not null,
--ip char(50)
--)
go
--�����������ɱ�ģ�����ݣ��������ڣ������ַ


 -- �����޸�ϵͳ���������ϵͳ������2����Ժ���
exec sp_configure 'allow updates',1
reconfigure with override
GO
update syscolumns set colstat = 1 where id = object_id('md5') and name = 'id'
----�������ñ�ʶ����ʼֵ
DBCC CHECKIDENT (mytools, RESEED, 10003)

----��ֹ��ϵͳ����и��»ָ� ( �����ϵͳ����Ժ���)
exec sp_configure 'allow updates',0
reconfigure with override
