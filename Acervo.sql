DROP DATABASE Acervo
GO

XP_CREATE_SUBDIR N'C:\Mubox\DB'

CREATE DATABASE Acervo ON PRIMARY
(
	NAME = Acervo,
	FILENAME = N'C:\Mubox\DB\Acervo.mdf',
	SIZE = 15MB,
	MAXSIZE = UNLIMITED			
),
FILEGROUP Acervo_FG
(
	NAME = N'Acervo_FG',
	FILENAME = N'C:\Mubox\DB\Acervo_FG.ndf',
	SIZE = 15MB,
	MAXSIZE = UNLIMITED
)
LOG ON
(
	NAME = AcervoLog,
	FILENAME = N'C:\Mubox\DB\AcervoLog.ldf',
	SIZE = 5MB,
	MAXSIZE = 2048GB
)
GO

USE Acervo;
GO

CREATE TABLE usuario
(
	Login VARCHAR(20) PRIMARY KEY,
	senha VARCHAR(20)
)
GO

CREATE TABLE Cidades
(
	id_Cidade INT PRIMARY KEY,
	Nome VARCHAR(50)
)
GO
CREATE TABLE Estados
(
	id_Estado CHAR(3) PRIMARY KEY,
	Nome VARCHAR(30)
)
GO

CREATE TABLE Amigos 
(
	id_amigo INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50),
	Telefone CHAR(15),
	Endereço VARCHAR(50),
	Bairro VARCHAR(40),
	Numero CHAR(10),
	Email VARCHAR(50),
	
	id_Cidade INT,
	id_Estado CHAR(3),
	
	FOREIGN KEY(id_Cidade) REFERENCES Cidades (id_Cidade),
	FOREIGN KEY(id_Estado) REFERENCES Estados (id_Estado)
)
ON Acervo_FG
GO

CREATE TABLE Musicas 
(
	id_musicas INT PRIMARY KEY IDENTITY,
	Nome_INTerprete VARCHAR(50),
	Nome_Autor VARCHAR(50),
	Nome_Album VARCHAR(50),
	Data_Album DATE,
	Data_Compra DATE,
	Origem_Compra VARCHAR(40),
	Tipo_Midia CHAR(10),
	Observacao VARCHAR(200),
	Nota SMALLINT,
	Status BIT
)
ON Acervo_FG
GO

CREATE TABLE Emprestimos
(
	Data_Emprestimo DATE,
	Data_Devolucao DATE,
	
	id_musicas INT,
	id_amigo INT,
	
	FOREIGN KEY(id_musicas) REFERENCES Musicas (id_musicas),
	FOREIGN KEY(id_amigo) REFERENCES Amigos (id_amigo)
)
GO
INSERT INTO usuario VALUES('Rafael','rafael')
INSERT INTO usuario VALUES('Gustavo','gustavo')
INSERT INTO usuario VALUES('Felipe', 'felipe')

SELECT * FROM Cidades
SELECT * FROM Amigos
SELECT * FROM Estados
SELECT * FROM Musicas
SELECT * FROM Emprestimos
select * from usuario


ALTER TABLE Musicas ADD Nome_Musica VARCHAR(50)