CREATE TABLE Fase (
	id int identity(1,1) primary key,
	idJogador int not null,
	numeroFase int not null,
	pontuacao int not null
)