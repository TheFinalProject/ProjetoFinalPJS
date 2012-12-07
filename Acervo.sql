--DROP DATABASE Acervo
--GO
--Criação do diretorio

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

CREATE TABLE Usuario
(
	Login VARCHAR(20) PRIMARY KEY,
	senha VARCHAR(20)
)
GO

CREATE TABLE ConfiguracoesPanel
(
	PanelConfig CHAR(10),
	ConfigLocalizacaoY CHAR(8),
	ConfigLocalizacaoX CHAR(8),
	
	PanelTime CHAR(10),
	TimeLocalizacaoY CHAR(8),
	TimeLocalizacaoX CHAR(8)
)
GO

CREATE TABLE ConfiguracoesForm
(
	FundoFormulario CHAR(10)
)
GO

CREATE TABLE Estados
(
	id_Estado CHAR(3) PRIMARY KEY,
	Nome VARCHAR(30)
)
GO

CREATE TABLE Cidades
(
	id_Cidade INT PRIMARY KEY,
	NomeCidade VARCHAR(50),
	
	CidadeId_uf CHAR(3),	
	FOREIGN KEY (CidadeId_uf)REFERENCES Estados(id_Estado)
)
CREATE INDEX ICidades ON Cidades(CidadeId_uf)
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
	
	AmigosId_Cidade INT,
	AmigosId_Estado CHAR(3),
	
	FOREIGN KEY(AmigosId_Cidade) REFERENCES Cidades (id_Cidade),
	FOREIGN KEY(AmigosId_Estado) REFERENCES Estados (id_Estado)
)
ON Acervo_FG
GO

CREATE TABLE Musicas 
(
	id_musicas INT PRIMARY KEY IDENTITY,
	Nome_Musica VARCHAR(50),
	Nome_Interprete VARCHAR(50),
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
	
	EmprestimosId_musicas INT,
	EmprestimosId_amigo INT,
	
	FOREIGN KEY(EmprestimosId_musicas) REFERENCES Musicas (id_musicas),
	FOREIGN KEY(EmprestimosId_amigo) REFERENCES Amigos (id_amigo)
)
GO

INSERT INTO Usuario
VALUES 
	('Rafael','rafael'),
	('Gustavo','gustavo'),
	('Felipe', 'felipe')
GO
	  

SELECT * FROM Cidades
SELECT * FROM Amigos
SELECT * FROM Estados
SELECT * FROM Musicas
SELECT * FROM Emprestimos
SELECT * FROM Usuario
SELECT * FROM ConfiguracoesBotoes
SELECT * FROM ConfiguracoesPanel
SELECT * FROM ConfiguracoesPanel




-- Scripts para teste ===========================================================
--Delete From Amigos

--DELETE FROM
--INSERT INTO Estados VALUES  ('SP','SAO PAULO')
--INSERT INTO Estados VALUES  ('RJ','Rio de Janeiro')
--GO

--INSERT INTO Cidades VALUES(1,'Campos do Jordao','SP'),(2,'Taubate','SP')
--INSERT INTO Cidades VALUES(3,'Niteroi','RJ')
--GO

--SELECT Cidades.Nome, Estados.id_Estado FROM Cidades INNER JOIN Estados 
--ON Cidades.CidadeId_uf = Estados.id_Estado WHERE Estados.id_Estado = 'SP'

--SELECT Cidades.Nome, Estados.id_Estado FROM Cidades INNER JOIN Estados 
--ON Cidades.CidadeId_uf = Estados.id_Estado WHERE Estados.id_Estado = 'RJ'
--Insert into Musicas (Nome_Interprete, Nome_Autor, Nome_Album, Data_Album, Data_Compra, Origem_Compra, Tipo_Midia, Observacao, Nota,Nome_Musica, Status) values ('iron', 'iron', 'iron', '11-11-2011', '11-11-2012', ' ', 'CD', ' ', 9, '', 0)
INSERT INTO Estados VALUES('SP','Sao Paulo')
INSERT INTO Cidades VALUES('12460','Campos do jordao','SP') 
INSERT INTO Amigos VALUES('Rafael','36624530','rua hum','ceu azul','14','phaelrlz@gmail.com','12460','SP')
--=================================================================================

Select Amigos.Nome, Amigos.Telefone, Amigos.Endereço, Amigos.Numero, Amigos.Email, Cidades.NomeCidade, Cidades.CidadeId_uf FROM Amigos INNER JOIN Cidades ON Amigos.AmigosId_Cidade = Cidades.id_Cidade
SELECT * FROM Musicas