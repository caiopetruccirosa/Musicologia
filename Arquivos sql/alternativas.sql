CREATE TABLE Alternativas(
	id int identity(1,1) primary key,
	alternativa varchar(100) not null,
	numeroFase int not null,
	numeroPergunta int not null,
)