--Loja de Brinquedos 
CREATE DATABASE LojaDeBrinquedos
GO
USE LojadeBrinquedos
GO

CREATE TABLE Brinquedo(
	ID			INT IDENTITY PRIMARY KEY NOT NULL,
	Nome		VARCHAR(25)NOT NULL,
	Cor			VARCHAR(25)NOT NULL,
	Quantidade  INT NOT NULL,
	Ativo		BIT NOT NULL  
	);
GO
INSERT INTO Brinquedo( 
	Nome, 
	Cor, 
	Quantidade,
	Ativo) 
VALUES ('Bola', 'Azul', 10, 1)
GO
INSERT INTO Brinquedo( 
	Nome, 
	Cor, 
	Quantidade,
	Ativo) 
VALUES ('Boneca', 'Vermelho', 2, 1)
GO
INSERT INTO Brinquedo( 
	Nome, 
	Cor, 
	Quantidade,
	Ativo) 
VALUES ('Balão', 'Verde', 0,0)
GO
SELECT * FROM Brinquedo
GO