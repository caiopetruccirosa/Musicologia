CREATE PROC sp_carregaralternativas @numeroFase int, @numeroPergunta int
AS
SELECT TOP 6 alternativa FROM alternativas WHERE numeroFase=@numeroFase AND numeroPergunta=@numeroPergunta ORDER BY NEWID