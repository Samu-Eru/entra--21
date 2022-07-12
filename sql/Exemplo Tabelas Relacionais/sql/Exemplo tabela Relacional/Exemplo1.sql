CREATE TABLE pecas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	tipo INT,
	preco_unitario DECIMAL(6,2)
);


CREATE TABLE clientes(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR (40),
	cpf VARCHAR (14)
);


CREATE TABLE enderecos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_cliente INTEGER NOT NULL, -- FK
	cep VARCHAR (9)NOT NULL,
	estado VARCHAR(2)NOT NULL,
	cidade VARCHAR (30)NOT NULL,
	bairro VARCHAR (30) NOT NULL,
	logradouro VARCHAR (40)NOT NULL,
	numero VARCHAR (10)NOT NULL,
	descricao TEXT,

	--FOREIGN KEY (nome_coluna_tablea_atual) REFERENCES nome_tabela_pai(nome_pai_pk)
	FOREIGN KEY (id_cliente) REFERENCES clientes (id)
);


CREATE TABLE pedidos(
	id INTEGER PRIMARY KEY IDENTITY (1,1),
	id_cliente INTEGER NOT NULL,
	status TINYINT NOT NULL, --0..255
	data_efetivacao_compra DATETIME2,

	data_criacao DATETIME2 NOT NULL
);


CREATE TABLE pedidos_pecas(
	id INTEGER PRIMARY KEY IDENTITY(1,1), --pk
	id_peca INTEGER, -- fk tabela peças
	id_pedido INTEGER, --fk tabela pedido

	quantidade SMALLINT ,

	FOREIGN KEY (id_pedido) REFERENCES pedidos(id),
	FOREIGN KEY (id_peca) REFERENCES pecas (id)
);


INSERT INTO pecas (nome, tipo, preco_unitario) VALUES 
('SSD 240 GB' , 1, 200),
('SSD 240 M2', 1, 420.39),
('RTX 3090 TI', 2, 9999.90),
('GTX 1060', 2, 1500),
('16GB DDR5 4800GHZ',5,800),
('16GB DDR4 3200',5,350);

INSERT INTO clientes (nome,cpf) VALUES
--('Claudio', '070.355.489-73'),
--('Cry', '032.599.384.69'),
('Juliana', '123.123.123-20');

INSERT INTO enderecos (id_cliente, estado, cidade,bairro, cep, logradouro, numero)
	VALUES
	(1,'SC','Blumenau','Velha','89070-301','Rua Divinopolis',777),
	(2,'SC','Blumenau','Velha Grande',	'89070-472','Morro da Edith',36),
	(3,'SC','Blumenau','Judity','Sem cep','Rua da kellen',23);

SELECT * FROM pecas;
SELECT * FROM clientes;
SELECT * FROM enderecos;

SELECT 
	c.nome,
	c.cpf,
	CONCAT(
		e.estado, ' - ',
		e.cidade,' - ',
		e.bairro, ' - ',
		e.logradouro, ' ',
		e.numero) AS 'Endereço Completo'
	FROM clientes AS c 
	INNER JOIN enderecos As e ON (e.id_cliente = c.id);

-- CONSULTAR O SENDEREECOS APREDENTANDO SEU CLIENTES FILTRANFO POR BAIRRO COM NOME VELHA CONUSLTA PARTINDO DA TABEKA DE ENDERECOS COM OUTRA CONSULTA NA TABELA DE CLIENTES
SELECT 
	c.nome,
	e.bairro,
	e.logradouro
	FROM enderecos AS e
	INNER JOIN clientes AS c ON (c.id = e.id_cliente)
	WHERE e.bairro LIKE '%Velha%';

-- STATUS DEE PEDIDOS
-- 0 - CARRINHO
-- 1 - AGUARFDANDO PAGAMENTO
-- 2 - pagamento EFETIVADO
--3 - entrega realizada
INSERT INTO pedidos(id_cliente, status, data_criacao) VALUES 
(1,0,GETDATE()), -- PEDIDO PARA O CALUDIO
((SELECT id FROM clientes WHERE nome = 'Cry'), 0, GETDATE()); -- PEDIDIO PARA O CRY


SELECT * FROM pedidos
SELECT * FROM clientes

--Consultar pedidos listando data da ciracao formato ptbr status com texto e nome so cliente
--Consulta partindo da tabela de pedidos com JOIIN em clientes
SELECT 
	FORMAT (p.data_criacao, 'dd/MM/yyyy'),
	CASE	
		WHEN [STATUS] = 0 THEN 'Carrinho'
		WHEN [status] = 1 THEN 'Aguardando pagamento'
		WHEN [status] = 2 THEN 'Pagamento Efetivo' 
		ELSE 'Entrega realizada'
	END AS 'Status pedido',
	c.nome
	FROM pedidos AS p
	INNER JOIN clientes AS c ON (p.id_cliente = c.id);

update PEDIDOS set STATUS = 1 WHERE id = 2;

