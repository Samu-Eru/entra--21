CREATE TABLE trabalhos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	titulo VARCHAR (100),
	subtitulo VARCHAR (50),
	descricao TEXT, -- textos grandes
	data_publicacao DATETIME2, -- data e hora
	tipo VARChAR (15)
);

INSERT INTO trabalhos
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('A melhor pizza do mundo','Como degustar uma pizza de calabresa','Grande descrição aki','1994-06-04','Receita');

INSERT INTO trabalhos
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Clean code', 'Como trabalhar melhor no seu dia a dia',
	'Utilizar var no lugar de tipo primitivo 
	Identar seu código, Utilizar constantes', '2000-03-20', 'Leitura Técnica');

INSERT INTO trabalhos
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Pudim com ovo','Aprenda o que fazer na sua vida','Jogue o pudim no lixo e faça um ovo','2022-07-06','Receita');

INSERT INTO trabalhos
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Estrutura de dados','Como sofrer sem saber, porém é necessário','Importante para aprender fifo, lifo, fefo, Listas encadeadas',
	'1980-05-11','Leitura técnica');

INSERT INTO trabalhos
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Strogonoff de frango','A vitória da batata palha','Compre frango e batata palha, jogue na panela, acenda o fogão,
	espera 5 minutinhos e tá pronto o sorvetinho','2000-09-10','Receita');

SELECT id, titulo, subtitulo, descricao, data_publicacao, tipo
	FROM trabalhos;

SELECT CONCAT(titulo, ' - ', subtitulo) AS 'Título completo'
	FROM trabalhos;

-- Consultar a descrição limitando a quantidade de caracteres
SELECT
	titulo AS 'Título',
		CONCAT(SUBSTRING (descricao, 0, 30), '...') AS 'Descricao'
	FROM trabalhos;

-- Consultar os trabalhos filtrando por ano de publicacao entre 1990 até 2010
SELECT id, titulo, data_publicacao
	FROM trabalhos 
	WHERE 
		YEAR (data_publicacao) >= 1920 AND
		YEAR (data_publicacao) <= 2010;

-- Consultar data publicacao formato BR heuaheua
-- BR: dia/mes/ano
SELECT id, titulo, 
	CONCAT(
	DAY(data_publicacao), '/',
	MONTH(data_publicacao), '/',
	YEAR(data_publicacao))
	FROM trabalhos;

-- Consultar a data da publicacao formatando no padrão BR, utilizando função para isso
SELECT id, titulo, FORMAT(data_publicacao, 'dd/MM/yyyy')
	FROM trabalhos;

-- limitar a consulta para 2 registros
SELECT TOP(2) id, titulo FROM trabalhos;

--Apresentar os produto código, preço se está favoritado filtrando por placa mãe ou placa de video do maior preco para o menor
--SELECT TOP(20) id, nome, preco, favoritado
--		FROM produtos
--		WHERE categoria = 'Placa mãe' OR categoria = 'Placa de video'
--		ORDER BY preco DESC;

-- Consulta com paginasção apresentando 2 registros da pagina 1
SELECT id, titulo
	FROM trabalhos
	ORDER BY id
	OFFSET 0 ROWS FETCH NEXT 2 ROWS ONLY;

-- Consulta com paginação apresentando 2 registros da página 2 
SELECT id, titulo
	FROM trabalhos
	ORDER BY id
	OFFSET 2 ROWS FETCH NEXT 2 ROWS ONLY;

-- Consulta com paginação apresentando 2 registros da página 3 
	SELECT id, titulo
	FROM trabalhos
	ORDER BY id
	OFFSET 4 ROWS FETCH NEXT 2 ROWS ONLY;


-----------------------------Lista de Exercicios Insert -------------------------

CREATE TABLE pessoas (
	nome VARCHAR(100),
	cpf varchar (14),
	rg varchar (12),
	data_nascimento DATETIME2,
	idade INTEGER
);

INSERT INTO pessoas (nome, cpf,rg, data_nascimento, idade) Values ('Erick Brian Enrico Vierira', '699.734.958-70', '90.745.276-0',
	'1989-05-28',29);

INSERT INTO pessoas (nome,cpf, rg, data_nascimento, idade) VALUES ('Samuel Ruan Dias', '802.790.194-40', '55.318.691-71',
	'1988-02-08', 29);

INSERT INTO pessoas (nome, cpf, rg, data_nascimento, idade) VALUES ('Fábio benjamin Souza', '522.445.349-60', '54.715.232-2',
	'1970-03-22', 48);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade) VALUES ('Elias Miguel Aparicio', '293.928.821-65', '12.680.444-8',
	'1986-06-07', 32);

INSERT INTO pessoas (nome, cpf, rg, data_nascimetno, idade) VALUES ('Alexandre Gustavo Cardoso','617.408.878-24', '8.888.574-4',
	'2003-04-15', 15);

INSERT INTO pessoas (nome, cpf, data_nascimento, idade) VALUES ('Kaue lucca Duarte', '943.163.990-47', '46.977.509-9', 
	'1968-06-15', 53);

INSERT INTO pessoas (nome, cpf, data_nascimento, idade) VALUES ('Marcos Bryan Guilherme Mendes', '955.129.235-95', '84.050.077-41',
	'2015-02-06', 3);

INSERT INTO pessoas (nome,cpf, data_nascimento, idade) VALUES ('Benedito Pedro Carlos da Mota', '510.505.472-50', '43.588.124-3',
	'1981-04-19', 37);

INSERT INTO pessoas (nome, cpf, data_nascimento, idade) VALUES ('Luís Igor Barbosa', '370.570.311-06', '40.651.407-0', 
	'2013-05-06', 5);


SELECT nome, cpf, rg, data_nascimento, idade FROM pessoas



