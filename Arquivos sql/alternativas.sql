CREATE TABLE Alternativas(
	id int identity(1,1) primary key,
	alternativa varchar(100) not null,
	idPergunta int not null,
	constraint FkIdPergunta foreign key (id) references Pergunta(id)
)