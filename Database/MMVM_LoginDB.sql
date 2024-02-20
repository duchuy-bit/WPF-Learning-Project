create database MMVM_LoginDB
go

use MMVM_LoginDB
go

create table [User]
(
	Id UNiqueIDentifier primary key  default  NEWID(),
	UserName nvarchar(100) unique  not null,
	[Password] nvarchar(100) not null,
	[Name] nvarchar(100) not null,
	LastName nvarchar(100) not null,
	Email  nvarchar(100) unique not null,
)
go

insert into [User] values( NEWID(), 'admin', '123', 'Dev Bear', 'Advance', 'admin@gmail.com')
insert into [User] values( NEWID(), 'duchuy', '123', 'Duc Huy', 'Nguyen', 'duchuy@gmail.com')
insert into [User] values( NEWID(), 'user1', '123', 'Test User 1', 'Chan', 'user1@gmail.com')

select * from [User]