CREATE DATABASE [DB_PI_GERENCIAMENTO_LOJA]

USE [DB_PI_GERENCIAMENTO_LOJA]

CREATE TABLE [dbo].[TB_CARGO] (
  [CAR_ID] uniqueidentifier NOT NULL PRIMARY KEY default newid(),
  [CAR_DESC] varchar(20) NULL,
);

CREATE TABLE [dbo].[TB_FUNCIONARIO] (
  [FUN_ID] uniqueidentifier NOT NULL PRIMARY KEY default newid(),  
  [FUN_NOME] varchar(45) NOT NULL,
  [CAR_ID] uniqueidentifier NOT NULL FOREIGN KEY REFERENCES [TB_CARGO] (CAR_ID),
);

CREATE TABLE [dbo].[TB_MARCA] (
  [MAR_ID] uniqueidentifier NOT NULL PRIMARY KEY default newid(),
  [MAR_NOME] varchar(20) NOT NULL,
);

CREATE TABLE [dbo].[TB_SETOR] (
  [SET_ID] uniqueidentifier NOT NULL PRIMARY KEY default newid(),
  [SET_NOME] varchar(15) NOT NULL
);

CREATE TABLE [dbo].[TB_TIPO] (
  [TIP_ID] uniqueidentifier NOT NULL PRIMARY KEY default newid(),
  [TIP_NOME] varchar(15) NOT NULL
);

CREATE TABLE [dbo].[TB_FORNECEDOR] (
  [FOR_ID] uniqueidentifier NOT NULL PRIMARY KEY default newid(),
  [FOR_NOME] varchar(45) NOT NULL
);

CREATE TABLE [dbo].[TB_PRODUTO] (
  [PRO_ID] uniqueidentifier NOT NULL PRIMARY KEY default newid(),
  [PRO_TAMANHO] varchar(10) NOT NULL,
  [PRO_COR] varchar(12) NOT NULL,
  [MAR_ID] uniqueidentifier NOT NULL FOREIGN KEY REFERENCES [TB_MARCA] (MAR_ID),
  [FUN_ID] uniqueidentifier NOT NULL FOREIGN KEY REFERENCES [TB_FUNCIONARIO] (FUN_ID),
  [SET_ID] uniqueidentifier NOT NULL FOREIGN KEY REFERENCES [TB_SETOR] (SET_ID),
  [TIP_ID] uniqueidentifier NOT NULL FOREIGN KEY REFERENCES [TB_TIPO] (TIP_ID),
  [FOR_ID] uniqueidentifier NOT NULL FOREIGN KEY REFERENCES [TB_FORNECEDOR] (FOR_ID),
);

INSERT INTO [dbo].[TB_CARGO]
VALUES (default, 'Gerente'), (default, 'Vendedor');

INSERT INTO [dbo].[TB_MARCA]
VALUES (default, 'Hollister'), 
(default, 'Abercrombie'), 
(default, 'Brooksfield'), 
(default, 'Adidas'), 
(default, 'Nike'), 
(default, 'Volcom'), 
(default, 'Zoo York'), 
(default, 'Aeropostale');

INSERT INTO [dbo].[TB_SETOR]
VALUES (default, 'Calças'), 
(default, 'Blusas'), 
(default, 'Camisas'), 
(default, 'Camisetas'), 
(default, 'Regatas'), 
(default, 'Bermudas'), 
(default, 'Meias');

INSERT INTO [dbo].[TB_TIPO]
VALUES (default, 'Jeans'), 
(default, 'Moletom'), 
(default, 'Camisa'), 
(default, 'Camiseta'), 
(default, 'Regata'), 
(default, 'Bermuda'), 
(default, 'Meia');

INSERT INTO [dbo].[TB_FORNECEDOR]
VALUES (default, 'Pedro Imports'), 
(default, 'Bruna Tecidos'), 
(default, 'Emanoel Dor Nelas'), 
(default, 'Flavio Clothes'), 
(default, 'Kaian Style'), 
(default, 'Caique Roupas');