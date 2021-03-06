--DROP DATABASE Acervo
--GO

--Cria��o do diretorio
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
	SIZE = 10MB,
	MAXSIZE = UNLIMITED
),
FILEGROUP Acervo_Default
(
	NAME = N'Acervo_Default',
	FILENAME = N'C:\Mubox\DB\Acervo_FGDefault',
	SIZE = 10MB,
	MAXSIZE = 2048MB,
	FILEGROWTH = 10%
	
)
LOG ON
(
	NAME = AcervoLog,
	FILENAME = N'C:\Mubox\DB\AcervoLog.ldf',
	SIZE = 5MB,
	MAXSIZE = 2048GB
)
ALTER DATABASE Acervo MODIFY FILEGROUP Acervo_Default DEFAULT
GO

USE Acervo;
GO

CREATE TABLE Usuario
(
	IdLogin INT IDENTITY,
	Login VARCHAR(20) PRIMARY KEY,
	Senha VARCHAR(20),
	Email VARCHAR(20),
	EmailSenha VARCHAR(20),
	Smtp VARCHAR(25),
	AtivarLogin BIT,	
	Imagem VARBINARY(MAX)
)
GO

CREATE TABLE ConfiguracoesBotoes
(
	Botao VARCHAR(18),
	Localizacaox VARCHAR(8),
	Localizacaoy VARCHAR(8)	
)
GO

CREATE TABLE ConfiguracoesPanel
(
	Panel VARCHAR(20),
	LocalizacaoX VARCHAR(8),
	LocalizacaoY VARCHAR(8)
)
GO

CREATE TABLE ConfiguracoesForm
(
	FundoFormulario VARCHAR(10),
	TravarBotoes TINYINT
)
GO

CREATE TABLE ConfiguracoesListView
(
	ListView VARCHAR(20),
	LocalizacaoX VARCHAR(8),
	LocalizacaoY VARCHAR(8)
)

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
GO

CREATE TABLE Amigos 
(
	id_amigo INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50),
	Telefone CHAR(15),
	Endere�o VARCHAR(50),
	Bairro VARCHAR(40),
	Numero VARCHAR(10),
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
	Nome_Interprete VARCHAR(50)NOT NULL,
	Nome_Autor VARCHAR(50)NOT NULL,
	Nome_Album VARCHAR(50),
	Data_Album DATE,
	Data_Compra DATE,
	Origem_Compra VARCHAR(40),
	Tipo_Midia VARCHAR(10)NOT NULL,
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
	EmprestimosTipo_Midia VARCHAR(20),
	
	EmprestimosId_musicas INT,
	EmprestimosId_amigo INT,
	
	FOREIGN KEY(EmprestimosId_musicas) REFERENCES Musicas (id_musicas),
	FOREIGN KEY(EmprestimosId_amigo) REFERENCES Amigos (id_amigo)
)
GO

SELECT * FROM Usuario
TRUNCATE TABLE Usuario
INSERT INTO Usuario
VALUES 
	('Admin','admin','','','',0,0)
GO		  

EXEC IniciarConfiguracoes
GO

EXEC Padrao
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
SELECT * FROM ConfiguracoesListView

/*Scripts para teste ===========================================================
Delete From Amigos

DELETE FROM
INSERT INTO Estados VALUES  ('SP','SAO PAULO')
INSERT INTO Estados VALUES  ('RJ','Rio de Janeiro')
GO

INSERT INTO Cidades VALUES(1,'Campos do Jordao','SP'),(2,'Taubate','SP')
INSERT INTO Cidades VALUES(3,'Niteroi','RJ')
GO

SELECT Cidades.Nome, Estados.id_Estado FROM Cidades INNER JOIN Estados 
ON Cidades.CidadeId_uf = Estados.id_Estado WHERE Estados.id_Estado = 'SP'

Select * from Usuario where  (Nome_Musica like '%i%')

SELECT Cidades.Nome, Estados.id_Estado FROM Cidades INNER JOIN Estados 
ON Cidades.CidadeId_uf = Estados.id_Estado WHERE Estados.id_Estado = 'RJ'
Insert into Musicas (Nome_Interprete, Nome_Autor, Nome_Album, Data_Album, Data_Compra, Origem_Compra, Tipo_Midia, Observacao, Nota,Nome_Musica, Status) values ('iron', 'iron', 'iron', '11-11-2011', '11-11-2012', ' ', 'CD', ' ', 9, '', 0)
INSERT INTO Estados VALUES('SP','Sao Paulo')
INSERT INTO Cidades VALUES('12460','Campos do jordao','SP') 
INSERT INTO Amigos VALUES('Rafael','36624530','rua hum','ceu azul','14','phaelrlz@gmail.com','12460','SP')

Select Amigos.Nome, Amigos.Telefone, Amigos.Endere�o, Amigos.Numero, Amigos.Email, Cidades.NomeCidade, Cidades.CidadeId_uf FROM Amigos INNER JOIN Cidades ON Amigos.AmigosId_Cidade = Cidades.id_Cidade
SELECT * FROM Amigos

SELECT id_amigo FROM Amigos WHERE Nome = 'Rafael'

SELECT * FROM Musicas
SELECT Amigos.Nome, Musicas.Nome_Album, Emprestimos.Data_Emprestimo FROM Emprestimos INNER JOIN Amigos ON Emprestimos.EmprestimosId_amigo = Amigos.id_amigo INNER JOIN Musicas ON Emprestimos.EmprestimosId_musicas = Musicas.id_musicas  

UPDATE Musicas SET Status = 0 WHERE id_musicas ; SELECT * FROM Musicas
TRUNCATE TABLE Emprestimos
SELECT * FROM Emprestimos
SELECT * FROM Usuario

SELECT id_musicas FROM Musicas WHERE Nome_Album = 'Fear of the Dark'

SELECT Amigos.Nome_Amigo, Musicas.Tipo_Midia, Musicas.Nome_Album, Emprestimos.Data_Emprestimo FROM Emprestimos INNER JOIN Amigos ON Amigo.id_amigo = Emprestimos.EmprestimosId_amigo INNER JOIN Musicas ON Musicas.id_musicas = EmprestimosId_musica
--=================================================================================*/

