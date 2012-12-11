CREATE PROCEDURE IniciarConfiguracoes
AS
	---- TRUNCATE TABLE ConfiguracoesBotoes
	INSERT INTO ConfiguracoesBotoes 
	VALUES ( 'Botao Amigos','337','228'),
		   ( 'Botao Musicas','660','50'),
		   ('Botao Agenda','138','409'),
		   ('Botao Mubox','138','50'),
		   ('Botao Emprestimos','462','49'),
		   ('Botao Media player','138','230'),
		   ('Botao Consulta','658','228')
		   
	-- TRUNCATE TABLE ConfiguracoesPanel
	INSERT INTO ConfiguracoesPanel
	VALUES ('Panel Configuracoes','55','134'),
			('Panel Timer','730','458')

	-- TRUNCATE TABLE ConfiguracoesForm
	INSERT INTO ConfiguracoesForm
	VALUES('Azul','0')
	
	--TRUNCATE TABLE ConfiguracoesListView
	INSERT INTO ConfiguracoesListView
	VALUES  ('Devolucoes','337','409')--337; 409
	
GO

CREATE PROCEDURE Padrao
AS
	UPDATE ConfiguracoesBotoes SET Localizacaox ='337', Localizacaoy ='228' WHERE Botao = 'Botao Amigos'
	UPDATE ConfiguracoesBotoes SET Localizacaox ='660', Localizacaoy ='50' WHERE Botao = 'Botao Musicas'
	UPDATE ConfiguracoesBotoes SET Localizacaox ='138', Localizacaoy ='409' WHERE Botao = 'Botao Agenda'
	UPDATE ConfiguracoesBotoes SET Localizacaox ='138', Localizacaoy ='50' WHERE Botao = 'Botao Mubox'
	UPDATE ConfiguracoesBotoes SET Localizacaox ='462', Localizacaoy ='49' WHERE Botao = 'Botao Emprestimos'
	UPDATE ConfiguracoesBotoes SET Localizacaox ='138', Localizacaoy ='230' WHERE Botao = 'Botao Media player'
	UPDATE ConfiguracoesBotoes SET Localizacaox ='658', Localizacaoy ='228' WHERE Botao = 'Botao Consulta'
	
	UPDATE ConfiguracoesPanel SET Localizacaox ='55', Localizacaoy ='134' WHERE Panel = 'Panel Configuracoes'
	UPDATE ConfiguracoesPanel SET Localizacaox ='730', Localizacaoy ='458' WHERE Panel = 'Panel Timer'
	
	UPDATE ConfiguracoesForm SET FundoFormulario ='Azul', TravarBotoes =0
	
	UPDATE ConfiguracoesListView SET LocalizacaoX ='337', LocalizacaoY ='409'	
GO



