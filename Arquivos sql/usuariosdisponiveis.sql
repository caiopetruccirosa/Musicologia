CREATE TABLE usuariosdisponiveis (
	id int not null,
	IP varchar(50) not null,
	constraint FkIdUsuarioDisponivel foreign key (id) references usuario(id)
)