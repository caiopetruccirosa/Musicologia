CREATE TABLE usuariosdisponiveis (
	id int not null,
	username varchar(50) not null,
	IP varchar(50) not null
	constraint FkIdUsuarioDisponivel foreign key (id) references usuario(id),
	constraint FkUsernameUsuarioDisponivel foreign key (username) references usuario(username)
)