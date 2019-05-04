create database UsersAndAwards
go

use UsersAndAwards
create table Users(
	UserID int primary key identity(1,1) not null,
	FirstName nvarchar(50) not null,
	LastName nvarchar(50) not null,
	BirthDate datetime2 not null,
)

use UsersAndAwards
create table Awards(
	AwardID int primary key identity(1,1) not null,
	Title nvarchar(50) not null,
	[Description] nvarchar(250)
)

use UsersAndAwards
create table UserAwards(
	[User] int not null,
	Award int not null
)

alter table UserAwards
 add constraint PK_UserAwards
   primary key([User], Award)

alter table UserAwards
 add constraint FK_UserAwards_User
	foreign key([User])
	references Users(UserID)
	on delete cascade

alter table UserAwards
 add constraint FK_UserAwards_Award
	foreign key(Award)
	references Awards(AwardID)
	on delete cascade

insert into Users(FirstName,
				  LastName,
				  BirthDate)
 values
	('user1 name','user1 lastname','1991-10-27'),
	('user2 name','user2 lastname','1992-10-27'),
	('user3 name','user3 lastname','1993-10-27')
	
insert into Awards(Title,
				   [Description])
 values
	('award1','award1'),
	('award2','award2')
	
insert into UserAwards
	values
		(1,2),
		(1,1),
		(2,1),
	    (3,2)