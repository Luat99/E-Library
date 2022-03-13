create database ELIBRARY
go
use ELIBRARY
go
create table tailieumonhoc
(
	id_tlmh int NOT NULL primary key,
	name_tlmh nvarchar(max) NOT NULL,	
)
go

create table nganhangdethi
(
	id_nhdt int NOT NULL primary key,
	name_nhdt nvarchar(max) NOT NULL,
)

create table files
(
	id_file int NOT NULL primary key,
	name_file nvarchar(max) NOT NULL,
)

create table thongbao
(
	id_tb int NOT NULL primary key,
	name_tb nvarchar(max) NOT NULL,
)

create table dsmongiangday
(
	id_dsmgd int NOT NULL primary key,
	name_dsmgd nvarchar(max) NOT NULL,
)

create table baigiang
(
	id_bg int NOT NULL primary key,
	name_bg nvarchar(max) NOT NULL,
)

create table tainguyen
(
	id_tn int NOT NULL primary key,
	name_tn nvarchar(max) NOT NULL,
)

create table dethikiemtra
(
	id_dtkt int NOT NULL primary key,
	name_dtkt nvarchar NOT NULL,
)

create table help
(
	id_help int NOT NULL primary key,
	name_help nvarchar(max) NOT NULL,
)

create table account
(
	id_ac int NOT NULL primary key,
	name_ac nvarchar(20) NOT NULL,
	pass_ac nvarchar(16) NOT NULL,
	role_ac bit,
)

create table teacher
(
	id_teacher int NOT NULL primary key,
	name_teacher nvarchar(20) NOT NULL,
	id_ac int FOREIGN KEY REFERENCES account(id_ac),
	id_dsmgd int FOREIGN KEY REFERENCES dsmongiangday(id_dsmgd),
	id_bg int FOREIGN KEY REFERENCES baigiang(id_bg),
	id_tn int FOREIGN KEY REFERENCES tainguyen(id_tn),
	id_dtkt int FOREIGN KEY REFERENCES dethikiemtra(id_dtkt),
	id_help int FOREIGN KEY REFERENCES help(id_help),
	id_tb int FOREIGN KEY REFERENCES thongbao(id_tb),
)
create table admins
(
	id_admin int NOT NULL primary key,
	name_admin nvarchar(20) NOT NULL,
	user_admin nvarchar(20) NOT NULL,
	pass_admin nvarchar(16) NOT NULL,
	id_tlmh int FOREIGN KEY REFERENCES tailieumonhoc(id_tlmh),
	id_nhdt int FOREIGN KEY REFERENCES nganhangdethi(id_nhdt),
	id_file int FOREIGN KEY REFERENCES files(id_file),
	id_tb int FOREIGN KEY REFERENCES thongbao(id_tb),
	id_ac int FOREIGN KEY REFERENCES account(id_ac),
)

