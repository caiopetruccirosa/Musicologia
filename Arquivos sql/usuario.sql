create table usuario(
	id int identity(1,1) primary key,
	username varchar(50) not null,
	email varchar(50) not null,
	pw varchar(250) not null,
)