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
	id INTEGER PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR(100),
	cpf varchar (14),
	rg varchar (12),
	data_nascimento DATETIME2,
	idade INTEGER
);

INSERT INTO pessoas (nome, cpf,rg, data_nascimento, idade) Values ('Erick Brian Enrico Vierira', '699.734.958-70', '90.745.276-0',
	'1989-05-28',29);

INSERT INTO pessoas (nome,cpf, rg, data_nascimento, idade) VALUES ('Samuel Ruan Dias', '802.790.194-40', '55.318.691-7',
	'1988-02-08', 29);

INSERT INTO pessoas (nome, cpf, rg, data_nascimento, idade) VALUES ('Fábio benjamin Souza', '522.445.349-60', '54.715.232-2',
	'1970-03-22', 48);

INSERT INTO pessoas(nome, cpf, rg, data_nascimento, idade) VALUES ('Elias Miguel Aparicio', '293.928.821-65', '12.680.444-8',
	'1986-06-07', 32);

INSERT INTO pessoas (nome, cpf, rg, data_nascimento, idade) VALUES ('Alexandre Gustavo Cardoso','617.408.878-24', '8.888.574-4',
	'2003-04-15', 15);

INSERT INTO pessoas (nome, cpf,rg, data_nascimento, idade) VALUES ('Kaue lucca Duarte', '943.163.990-47', '46.977.509-9', 
	'1968-06-15', 53);

INSERT INTO pessoas (nome, cpf,rg, data_nascimento, idade) VALUES ('Marcos Bryan Guilherme Mendes', '955.129.235-95', '84.050.077-4',
	'2015-02-06', 3);

INSERT INTO pessoas (nome,cpf,rg, data_nascimento, idade) VALUES ('Benedito Pedro Carlos da Mota', '510.505.472-50', '43.588.124-3',
	'1981-04-19', 37);

INSERT INTO pessoas (nome, cpf,rg, data_nascimento, idade) VALUES ('Luís Igor Barbosa', '370.570.311-06', '40.651.407-0', 
	'2013-05-06', 5);

INSERT INTO pessoas(nome,cpf,rg,data_nascimento, idade) VALUES ('José Heitor Ramos', '675.624.925-81', '83.962.258-2',
	'1965-04-11',53);

INSERT INTO pessoas (nome,cpf,rg, data_nascimento, idade) VALUES ('Lucca Tiago Galvão','788.124.508-57', '3.293.335-6', 
	'1977-06-17', 41);

INSERT INTO pessoas (nome,cpf,rg,data_nascimento, idade) VALUES ('Tiago Edson Oliveira', '389.969.352-39', '8.198.446-9',
	'1977-06-09', 41);

INSERT INTO pessoas (nome, cpf,rg, data_nascimento, idade) VALUES ('Enrico Julio Fábio Martins', '8.198.446-9', '99.886.242-3',
	'2017-03-11', 1);

INSERT INTO pessoas (nome, cpf,rg, data_nascimento, idade) VALUES ('Oliver Victor BEnjamin da Mota', '798.556.805-02', '5.103.578-9',
	'1985-03-27', 33);	

INSERT INTO pessoas (nome, cpf, rg, data_nascimento, idade) VALUES ('Bryan Caio Lopes', '213.217.201-30', '12.949.454-9',
	'1970-06-18', 33);


SELECT id, nome, cpf, rg, data_nascimento, idade FROM pessoas

-- Exercicio 2 ---------

CREATE TABLE enderecos (
	id INTEGER PRIMARY KEY IDENTITY (1,1),
	estado VARCHAR (2),
	cidade VARCHAR (140),
	bairro VARCHAR (120),
	cep VARCHAR (10),
	logradouro VARCHAR (250),
	numero INTEGER,
	complemento TEXT);

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES ('AC', 'Rio Branco', 'Ayrton Senna', '69.911-866',
	'Estrada Deputado José Rui da Silveira Lino', 282,'Casa');

INSERT INTO enderecos (estado, cidade, bairro, cep, numero) VALUES ('SC', 'Biguaçu', 'Fundos', '88.161-400', 995);

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES ('MG', 'Santa Luzia', 'Padre Miguel', '33.082-050',
	'Rua Buenos Aires', 371, 'Apartamento');

INSERT INTO enderecos (estado, bairro, cep, logradouro, numero) VALUES ('BA','São Tomé de Paripe', '40.800-361', 
	'Travessa Luís Hage', 685);
	
INSERT INTO enderecos (estado, cidade, bairro, logradouro, numero) VALUES ('MG', 'Ipatinga', 'Vila Celeste',
	'Rua Antônio Boaventura Batista', 645);

INSERT INTO enderecos (estado, cidade, bairro, cep, numero) VALUES ('RS', 'Passo Fundo', 'Nenê Graeff', '99.030-250',
	 154);

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento) VALUES ('AM', 'Manaus', 'Petrópolis', '69.079-300', 
	'Rua Coronel Ferreira Sobrinho', 264, 'Fundos');

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero) VALUES ( 'TO', 'Gurupi', 'Muniz Santana', '77.402-130',
	'Rua Adelmo Aires Negri', 794);

INSERT INTO enderecos (estado, bairro, logradouro, numero, complemento) VALUES ('AC', 'Preventório',
	'Beco da Ligação ||', 212, 'Bloco B');

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero) VALUES ('AP', 'Santana', 'Comercial', '68.925-073',
	'Rua Calçoene', 648);

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero) VALUES ('PB', 'Cabedelo', 'Camalaú', '58.103-052',
	'Rua Siqueira Campos', 249);


UPDATE enderecos SET logradouro = 'Rua DESCONHECIDA', complemento = 'CASA'  WHERE id= 2;

UPDATE enderecos SET cidade = 'SALVADOR', complemento = 'CASA' WHERE id = 4;

UPDATE enderecos SET cep='35.162-484',complemento='CASA' WHERE id=5;

UPDATE enderecos SET logradouro = 'Rua DESCONHECIDA', complemento = 'CASA' WHERE id = 6;

UPDATE enderecos SET complemento = 'CASA' WHERE id=8;
UPDATE enderecos SET cidade = 'RIO BRANCO' WHERE id=9;

UPDATE enderecos SET complemento = 'CASA' WHERE id=10;

UPDATE enderecos SET complemento = 'CASA' WHERE id=11;

SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento FROM enderecos WHERE cidade IS NULL OR bairro IS NULL OR logradouro IS NULL
	OR numero IS NULL OR complemento IS NULL;

SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento FROM enderecos 


DROP TABLE enderecos

DELETE FROM enderecos WHERE id=1


--Exercicio 3 ------

CREATE TABLE champions (
	id INTEGER PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR (45),
	descricao VARCHAR (100),
	habilidade_1 VARCHAR (50),
	habilidade_2 VARCHAR (50),
	habilidade_3 VARCHAR (50),
	habilidade_4 VARCHAR (50),
	habilidade_5 VARCHAR (50)
);

INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2, habilidade_3,habilidade_4, habilidade_5) VALUES ('Katarina', 'A Lâmina Sinistra', 'Voracidade', 
	'Lâmina Saltitante', 'Preparação', 'Shunpo', 'Lótus da Morte');

INSERT INTO champions (nome, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5) VALUES ('Yasuo','Estilo do Errante', 'Tempestade de aço',
	'Parede de Vento', 'Espada Ágil', 'Último Suspiro');

INSERT INTO champions (nome, descricao, habilidade_1) VALUES ('Master Yi', 'o EspadaChim Wuju', 'Ataque Duplo');

INSERT INTO enderecos (nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5) VALUES ('Vayne', 'a Caçadora Noturna', 'Caçadora Noturna',
	'Rolamento', 'Dardos de prata', 'Condenar', 'Hora Final');

INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4) VALUES ('Lee Sin', 'o Monge Cego','Agitação',
	'Onda Sônica | Vontade de Ferro', 'Tempestade / Mutilar', 'Ataque Ressonante');

INSERT INTO champions (nome, descricao, habilidade_1, habilidade_3, habilidade_4, habilidade_5) VALUES ('Vi', 'A defesora de pitlover', 'Blindagem',
	'Pancada Certeira', 'Força Excessiva', 'Sangue e Enterrada');

INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5) VALUES ('Diana', 'O Escârnio da lua', 'Espada de Prata Lunar',
	'Golpe Crescente', 'Cascata Lívida', 'Colapso Minguante', 'Zênite Lunar');

INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5) VALUES ('Annie', 'A Criança Sombria', 'Piromania',
	'Desintegrar', 'Incinerar', 'Escudo Fundido', 'Invocar Tibbers');

INSERT INTO champions (nome, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5) VALUES ('Aatrox', 'Poço de Sangue', 'Voo Sombrio', 
	'Sede de Sangue / Preço em Sangue', 'Lãminas da Aflõçao', 'Massacre');

UPDATE champions SET descricao = 'MUITO LOCO' WHERE id = 3;

UPDATE champions SET habilidade_2 = 'habilidade loca', habilidade_3='loca habilidade', habilidade_4 = 'habili loca', habilidade_5 = 'loca habilit' WHERE id=4

UPDATE champions SET habilidade_5 = 'ncie habilit' WHERE id= 5

UPDATE champions SET descricao = 'boa descricao aki', habilidade_2 = 'boa habilidade aqui ' where id=8


SELECT id, nome, descricao, habilidade_1, habilidade_2, habilidade_3, habilidade_4, habilidade_5 
	FROM champions	
	WHERE nome IS NULL OR descricao IS NULL OR habilidade_1 IS NULL OR
		habilidade_2 IS NULL OR habilidade_3 IS NULL OR habilidade_4 IS NULL OR habilidade_5 IS NULL 