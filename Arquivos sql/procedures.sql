CREATE PROCEDURE sp_selecionarfases id
SELECT * FROM Fase WHERE idJogador = @id ORDER BY numeroFase CRESCENTE
RETORNAR UM NEGOCIO COM O NUMERO DA FASE E A PONTUACAO


CREATE PROCEDURE sp_guardarscore id, numero da fase, score
INSERT INTO Fase(id, numero da fase, score)
caso nao existe uma pontuacao dessa pessoa nessa fase
ou fazer um update na pontuacao caso ja exista um registro
dessa fase jogado por essa pessoa

CREATE PROCEDURE sp_usuariosdisponiveis
faz um selec na table dos usuarios disponiveis e
retorna o id da pessoa, username dela e o ip

CREATE PROCEDURE sp_ficardisponivel id
caso a pessoa nao esteja na tabela dos usuarios
disponiveis, insere ela

CREATE PROCEDURE sp_ficarindisponivel
caso a pessoa esteja na tabela dos usuarios
disponiveis, deleta ela de la