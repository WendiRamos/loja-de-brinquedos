USE LojaDeBrinquedos
GO
SELECT * FROM dbo.Brinquedo
GO
INSERT INTO Brinquedo(
	Nome, 
	Cor, 
	Quantidade,
	Ativo)
VALUES ('Mamona', 'Roxo', 25, 1)
GO
INSERT INTO Brinquedo(
	Nome, 
	Cor, 
	Quantidade,
	Ativo)
VALUES ('Upa Upa', 'Diversos', 50, 1)
GO
UPDATE Brinquedo 
SET Cor ='Laranja' WHERE ID= 5
GO
DELETE FROM Brinquedo
WHERE COR = 'laranja'
GO

DELETE FROM Brinquedo
WHERE ID =9
GO

