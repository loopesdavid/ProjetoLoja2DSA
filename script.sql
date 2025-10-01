-- CRIANDO O BANCO DE DADOS
CREATE DATABASE bdLoja2dsa;

-- USANDO O BANCO DE DADOS;
USE bdLoja2dsa;

-- CRIANDO AS TABELAS DO BANCO DE DADOS
CREATE TABLE Usuario(
id int primary key auto_increment,
email varchar(40) not null,
senha varchar(40) not null
);

CREATE TABLE Cliente(
codCli int primary key auto_increment,
nomeCli varchar(40) not null,
telCli varchar(40) not null,
emailCli varchar(40) not null
);

-- CONSULTANDO AS TABELAS DO BANCO DE DADOS
SELECT * FROM Usuario;
SELECT * FROM Cliente;

DROP DATABASE bdLoja2dsa;