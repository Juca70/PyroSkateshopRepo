-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Dec 01, 2022 at 09:52 PM
-- Server version: 8.0.17
-- PHP Version: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pyrodb`
--

-- --------------------------------------------------------

--
-- Table structure for table `articulo`
--

CREATE TABLE `articulo` (
  `id` int(11) NOT NULL,
  `categoria` enum('Accesories','Bearings','Decks','Fleece','Garment','Griptape','Hardware','Hats','Pants','Protecciones','Riser pads-bushing','Shoes','Socks','Stickers','T-Shirt','Truck','Wax','Wheels') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `tipo` enum('Hardgoods','Softgoods') NOT NULL,
  `descripcion` varchar(128) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `medida` varchar(50) DEFAULT NULL,
  `cant_existencia` int(11) NOT NULL,
  `costo_compra` decimal(18,2) NOT NULL DEFAULT '0.00',
  `costo_dolares` decimal(18,2) DEFAULT '0.00',
  `precio_venta` decimal(18,2) NOT NULL,
  `estado` enum('Activo','Inactivo') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `articulo`
--

INSERT INTO `articulo` (`id`, `categoria`, `tipo`, `descripcion`, `marca`, `medida`, `cant_existencia`, `costo_compra`, `costo_dolares`, `precio_venta`, `estado`) VALUES
(12, 'Stickers', 'Softgoods', 'ALIEN WORKSHOP OG Logo', 'ALIEN WORKSHOP', NULL, 6, '0.00', '0.00', '20.00', 'Activo'),
(13, 'Stickers', 'Softgoods', 'ATM Lowcard', 'ATM', NULL, 12, '0.00', '0.00', '10.00', 'Activo'),
(14, 'Pants', 'Softgoods', 'NIKE Performance Cargo Shorts', 'NIKE', '30', 1, '131.29', '6.91', '550.00', 'Activo'),
(15, 'Pants', 'Softgoods', 'O\'NEILL Campbell Cargo Shorts Grn', 'O\'NEILL', '30', 1, '207.29', '10.91', '550.00', 'Activo'),
(16, 'Fleece', 'Softgoods', 'CREATURE Skeleton Key Pin Up Coach WB Blk', 'CREATURE', 'Sm', 2, '779.00', '38.00', '800.00', 'Activo'),
(17, 'Fleece', 'Softgoods', 'INDEPENDENT O.G.B.C. Standard Crew Neck Blk', 'INDEPENDENT', 'Md', 2, '958.17', '46.74', '900.00', 'Activo'),
(18, 'T-Shirt', 'Softgoods', 'BAKER Torn Blk', 'BAKER', 'Md', 2, '264.00', '12.00', '400.00', 'Activo'),
(19, 'T-Shirt', 'Softgoods', 'BONES Branded Wht', 'BONES', NULL, 1, '0.00', '0.00', '400.00', 'Activo'),
(20, 'Hats', 'Softgoods', 'BUJWAH STRANGERS Los Strangers Navy Dad Hat', 'BUJWAH STRANGERS', 'os', 4, '350.00', '0.00', '400.00', 'Activo'),
(21, 'Hats', 'Softgoods', 'BUJWAH STRANGERS Smoking Bear Kaki dat Hat', 'BUJWAH STRANGERS', 'os', 1, '350.00', '0.00', '400.00', 'Activo'),
(22, 'Socks', 'Softgoods', 'CREATE Wobble Crew Wht', 'CREATE', NULL, 1, '0.00', '0.00', '180.00', 'Activo'),
(23, 'Socks', 'Softgoods', 'PLAYFUN Checkers', 'PLAYFUN', NULL, 3, '420.00', '0.00', '180.00', 'Activo'),
(24, 'Shoes', 'Softgoods', 'REYNO FOOTWEAR Ali Blk/Wht', 'REYNO FOOTWEAR', '8.5', 1, '460.00', '0.00', '850.00', 'Activo'),
(25, 'Shoes', 'Softgoods', 'REYNO FOOTWEAR Ali Blk/Wht', 'REYNO FOOTWEAR', '9', 1, '460.00', '0.00', '850.00', 'Activo'),
(26, 'Shoes', 'Softgoods', 'REYNO FOOTWEAR Ali Blk/Wht', 'REYNO FOOTWEAR', '10', 1, '460.00', '0.00', '850.00', 'Activo'),
(27, 'Decks', 'Hardgoods', 'BAKER Brand Logo Blk', 'BAKER', '8.475', 1, '741.62', '33.71', '950.00', 'Activo'),
(28, 'Decks', 'Hardgoods', 'BAKER Brand Logo Blk/Wht', 'BAKER', '8.25', 1, '708.00', '32.21', '950.00', 'Activo'),
(29, 'Decks', 'Hardgoods', 'BORDER Black Eyes Wht', 'BORDER', '8.25', 1, '430.00', '0.00', '650.00', 'Activo'),
(30, 'Truck', 'Hardgoods', 'INDEPENDENT Polished 215 Standard', 'INDEPENDENT', '10', 1, '520.00', '0.00', '850.00', 'Activo'),
(31, 'Truck', 'Hardgoods', 'INDEPENDENT Stage XI Bar Flat Blk Standard 144', 'INDEPENDENT', '8.25', 1, '673.20', '30.60', '1100.00', 'Activo'),
(32, 'Wheels', 'Hardgoods', 'BONES 100\'s #5 Party Pack Assrtd V4', 'BONES', '52 mm', 2, '264.94', '0.00', '0.00', ''),
(33, '', '', 'OJ\'S II Team Rider Speed Wheels Original Wht 97a', 'OJ\'S II Team Rider Speed Wheels Original Wht 97a', NULL, 0, '0.00', '0.00', '0.00', ''),
(34, 'Wheels', 'Hardgoods', 'OJ\'S Elite Hardline 99a', 'OJ\'S II', '56 mm', 1, '406.80', '20.34', '800.00', 'Activo');

-- --------------------------------------------------------

--
-- Table structure for table `detalle_venta`
--

CREATE TABLE `detalle_venta` (
  `id_venta` int(11) NOT NULL,
  `id_articulo` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `importe` decimal(18,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `contraseña` varchar(50) NOT NULL,
  `fecha_alta` date NOT NULL,
  `pregunta_recup` enum('¿Cuál es su animal favorito?','¿Cuál es su cumpleaños?') NOT NULL,
  `Respuesta_recup` varchar(30) NOT NULL,
  `tipo_usuario` enum('Administrador','Empleado') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`id`, `nombre`, `contraseña`, `fecha_alta`, `pregunta_recup`, `Respuesta_recup`, `tipo_usuario`) VALUES
(1, 'Admin', '12345', '2022-11-16', '¿Cuál es su animal favorito?', 'gato', 'Administrador'),
(2, 'Employee', 'password', '2022-11-16', '¿Cuál es su animal favorito?', 'cuyo', 'Empleado');

-- --------------------------------------------------------

--
-- Table structure for table `venta`
--

CREATE TABLE `venta` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `tipo_pago` enum('Efectivo','Tarjeta') NOT NULL,
  `total` decimal(18,2) NOT NULL,
  `estado` enum('Activo','Inactivo') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `articulo`
--
ALTER TABLE `articulo`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `detalle_venta`
--
ALTER TABLE `detalle_venta`
  ADD PRIMARY KEY (`id_venta`,`id_articulo`),
  ADD KEY `detalle_venta_ibfk_2` (`id_articulo`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`id`),
  ADD KEY `venta_ibfk_1` (`id_usuario`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `articulo`
--
ALTER TABLE `articulo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `venta`
--
ALTER TABLE `venta`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `detalle_venta`
--
ALTER TABLE `detalle_venta`
  ADD CONSTRAINT `detalle_venta_ibfk_1` FOREIGN KEY (`id_venta`) REFERENCES `venta` (`id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  ADD CONSTRAINT `detalle_venta_ibfk_2` FOREIGN KEY (`id_articulo`) REFERENCES `articulo` (`id`) ON DELETE RESTRICT ON UPDATE CASCADE;

--
-- Constraints for table `venta`
--
ALTER TABLE `venta`
  ADD CONSTRAINT `venta_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id`) ON DELETE RESTRICT ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
