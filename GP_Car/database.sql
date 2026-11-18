-- Script de Criação do Banco de Dados GP CAR
CREATE DATABASE IF NOT EXISTS gp_car_db;
USE gp_car_db;

-- 1. Tabela Cliente
CREATE TABLE IF NOT EXISTS cliente (
    id_cliente INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cnh VARCHAR(20) NOT NULL UNIQUE,
    telefone VARCHAR(20),
    endereco VARCHAR(200)
);

-- 2. Tabela Veículo
-- Status permitidos: 'Disponivel', 'Alugado', 'Manutencao'
CREATE TABLE IF NOT EXISTS veiculo (
    id_veiculo INT AUTO_INCREMENT PRIMARY KEY,
    placa VARCHAR(10) NOT NULL UNIQUE,
    modelo VARCHAR(50) NOT NULL,
    marca VARCHAR(50) NOT NULL,
    categoria VARCHAR(30),
    ano INT NOT NULL,
    status VARCHAR(20) NOT NULL DEFAULT 'Disponivel',
    cor VARCHAR(30)
);

-- 3. Tabela Aluguel
CREATE TABLE IF NOT EXISTS aluguel (
    id_aluguel INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT NOT NULL,
    id_veiculo INT NOT NULL,
    data_inicio DATETIME NOT NULL,
    data_devolucao DATETIME,
    valor_total DECIMAL(10,2),
    CONSTRAINT fk_aluguel_cliente FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente),
    CONSTRAINT fk_aluguel_veiculo FOREIGN KEY (id_veiculo) REFERENCES veiculo(id_veiculo)
);

-- 4. Tabela Vistoria
CREATE TABLE IF NOT EXISTS vistoria (
    id_vistoria INT AUTO_INCREMENT PRIMARY KEY,
    id_aluguel INT NOT NULL,
    km_atual INT NOT NULL,
    danos_observados TEXT,
    data_vistoria DATETIME NOT NULL,
    CONSTRAINT fk_vistoria_aluguel FOREIGN KEY (id_aluguel) REFERENCES aluguel(id_aluguel)
);

-- Dados de Exemplo para Teste
INSERT IGNORE INTO veiculo (placa, modelo, marca, categoria, ano, status, cor) VALUES
('ABC1D23', 'Onix 1.0', 'Chevrolet', 'Hatch', 2023, 'Disponivel', 'Branco'),
('BRA2E19', 'HB20 Sense', 'Hyundai', 'Hatch', 2022, 'Alugado', 'Prata'),
('KRT3F45', 'Corolla XEi', 'Toyota', 'Sedan', 2024, 'Disponivel', 'Preto'),
('MNP4G56', 'Renegade Longitude', 'Jeep', 'SUV', 2021, 'Manutencao', 'Cinza');

INSERT IGNORE INTO cliente (nome, cnh, telefone, endereco) VALUES
('Arthur Yan', '12345678900', '(11) 98765-4321', 'Rua das Flores, 100'),
('Gabriel Guimarães', '98765432100', '(11) 91234-5678', 'Av. Paulista, 1500');
