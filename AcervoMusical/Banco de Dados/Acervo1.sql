CREATE DATABASE Acervo;
GO

USE Acervo;
go

CREATE TABLE usuario
(
	Login varchar(20) PRIMARY KEY,
	senha varchar(20)
)

CREATE TABLE Amigos 
(
	id_amigo int PRIMARY KEY IDENTITY,
	Nome varchar(50),
	Telefone char(15),
	Endereço varchar(50),
	Bairro varchar(40),
	Numero char(10)
)

CREATE TABLE Musicas 
(
	id_musicas int PRIMARY KEY IDENTITY,
	Nome_Interprete varchar(50),
	Nome_Autor varchar(50),
	Nome_Album varchar(50),
	Data_Album date,
	Data_Compra date,
	Origem_Compra varchar(40),
	Tipo_Midia char(10),
	Observacao varchar(200),
	Nota smallint,
	Status bit
)

CREATE TABLE Emprestimos
(
	id_musicas int,
	id_amigo int,
	Data_Emprestimo Date,
	Data_Devolucao Date,
	FOREIGN KEY(id_musicas) REFERENCES Musicas (id_musicas),
	FOREIGN KEY(id_amigo) REFERENCES Amigos (id_amigo)
)

insert into usuario values('admin', 'admin')