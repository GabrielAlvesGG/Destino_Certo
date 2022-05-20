-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 21-Maio-2022 às 00:07
-- Versão do servidor: 10.4.18-MariaDB
-- versão do PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `destino_certo`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `pacotesturisticos`
--

CREATE TABLE `pacotesturisticos` (
  `idViagem` int(11) NOT NULL,
  `NomeCliente` varchar(100) DEFAULT NULL,
  `Origem` varchar(100) DEFAULT NULL,
  `Destino` varchar(100) DEFAULT NULL,
  `Atrativos` varchar(100) DEFAULT NULL,
  `Saida` varchar(30) DEFAULT NULL,
  `Retorno` varchar(30) DEFAULT NULL,
  `Usuario` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `pacotesturisticos`
--

INSERT INTO `pacotesturisticos` (`idViagem`, `NomeCliente`, `Origem`, `Destino`, `Atrativos`, `Saida`, `Retorno`, `Usuario`) VALUES
(1, 'Gabriel', 'maua', 'bahia', 'praias', '1997-05-18 00:00:00.000000', '1365-05-18 00:00:00.000000', NULL),
(2, 'leonice', 'salvador', 'bahia', 'praias', '0001-01-01 00:00:00.000000', '1512-05-04 00:00:00.000000', NULL),
(6, 'gab', 'sp', 'maldivas', 'praias', '2022-04-21 00:00:00.000000', '2022-04-30 00:00:00.000000', NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `nome` varchar(100) DEFAULT NULL,
  `login` varchar(100) DEFAULT NULL,
  `senha` varchar(200) DEFAULT NULL,
  `dataNascimento` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`id`, `nome`, `login`, `senha`, `dataNascimento`) VALUES
(1, 'gabriel', 'gg', '1234', '1997-05-18 00:00:00.000000'),
(2, 'Leonice Alves Garcia', 'll', '1234', '1961-05-09 00:00:00.000000'),
(3, 'jonas', 'marcelino', '1235', '1997-05-18 00:00:00.000000'),
(4, 'jonas', 'Jonas macelino', '555', '1997-05-18 00:00:00.000000'),
(5, 'Gabriel alves de oliveira', 'gggg', NULL, '1997-05-18 00:00:00.000000'),
(6, 'Gabriel alves de oliveira', 'gggg', NULL, '1997-05-18 00:00:00.000000'),
(7, 'ggggggg', 'ggggggg', '3433', '1997-05-18 00:00:00.000000'),
(8, 'ggggggg', 'ggggggg', NULL, '1997-05-18 00:00:00.000000'),
(11, 'gab', 'gab', '123', '1997-03-18 00:00:00.000000'),
(12, 'gabriel ', 'gbl', 'gbl', '1977-05-18 00:00:00.000000'),
(13, 'gabriel', 'gbl', 'gbl', '1977-01-18 00:00:00.000000');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `pacotesturisticos`
--
ALTER TABLE `pacotesturisticos`
  ADD PRIMARY KEY (`idViagem`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `pacotesturisticos`
--
ALTER TABLE `pacotesturisticos`
  MODIFY `idViagem` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
