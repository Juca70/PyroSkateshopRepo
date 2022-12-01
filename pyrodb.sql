-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 23-11-2022 a las 20:32:46
-- Versión del servidor: 8.0.17
-- Versión de PHP: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `pyrodb`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `articulo`
--

CREATE TABLE `articulo` (
  `id` int(11) NOT NULL,
  `descripcion` varchar(128) NOT NULL,
  `tipo` enum('Hardgoods','Softgoods') NOT NULL,
  `categoria` varchar(50) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `medida` varchar(50) DEFAULT NULL,
  `cant_existencia` int(11) NOT NULL,
  `precio_venta` decimal(18,2) NOT NULL,
  `precio_dolares` decimal(18,2) NOT NULL,
  `costo_compra` decimal(18,2) NOT NULL,
  `estado` enum('Activo','Inactivo') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_venta`
--

CREATE TABLE `detalle_venta` (
  `id_venta` int(11) NOT NULL,
  `id_articulo` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL,
  `importe` decimal(18,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
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
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`id`, `nombre`, `contraseña`, `fecha_alta`, `pregunta_recup`, `Respuesta_recup`, `tipo_usuario`) VALUES
(1, 'Admin', '12345', '2022-11-16', '¿Cuál es su animal favorito?', 'gato', 'Administrador'),
(2, 'Employee', 'password', '2022-11-16', '¿Cuál es su animal favorito?', 'cuyo', 'Empleado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
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
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `articulo`
--
ALTER TABLE `articulo`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `detalle_venta`
--
ALTER TABLE `detalle_venta`
  ADD PRIMARY KEY (`id_venta`,`id_articulo`),
  ADD KEY `detalle_venta_ibfk_2` (`id_articulo`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`id`),
  ADD KEY `venta_ibfk_1` (`id_usuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `articulo`
--
ALTER TABLE `articulo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `venta`
--
ALTER TABLE `venta`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `detalle_venta`
--
ALTER TABLE `detalle_venta`
  ADD CONSTRAINT `detalle_venta_ibfk_1` FOREIGN KEY (`id_venta`) REFERENCES `venta` (`id`) ON DELETE RESTRICT ON UPDATE CASCADE,
  ADD CONSTRAINT `detalle_venta_ibfk_2` FOREIGN KEY (`id_articulo`) REFERENCES `articulo` (`id`) ON DELETE RESTRICT ON UPDATE CASCADE;

--
-- Filtros para la tabla `venta`
--
ALTER TABLE `venta`
  ADD CONSTRAINT `venta_ibfk_1` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id`) ON DELETE RESTRICT ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

/*ALTAS*/
INSERT INTO `articulo` (`id`, `categoria`, `tipo`, `descripcion`, `marca`, `medida`, `cant_existencia`, `costo_compra`, `costo_dolares`, `precio_venta`, `estado`) VALUES (NULL, 'Stickers', 'Softgoods', 'ALIEN WORKSHOP OG Logo', 'ALIEN WORKSHOP', NULL, '6', '0.00', '0.00', '20', 'Activo'), (NULL, 'Stickers', 'Softgoods', 'ATM Lowcard', 'ATM', NULL, '12', '0.00', '0.00', '10', 'Activo');
INSERT INTO `articulo` (`id`, `categoria`, `tipo`, `descripcion`, `marca`, `medida`, `cant_existencia`, `costo_compra`, `costo_dolares`, `precio_venta`, `estado`) VALUES (NULL, 'Pants', 'Softgoods', 'NIKE Performance Cargo Shorts', 'NIKE', '30', '1', '131.29', '6.91', '550', 'Activo'), (NULL, 'Pants', 'Softgoods', 'O\'NEILL Campbell Cargo Shorts Grn', 'O\'NEILL', '30', '1', '207.29', '10.91', '550', 'Activo');
INSERT INTO `articulo` (`id`, `categoria`, `tipo`, `descripcion`, `marca`, `medida`, `cant_existencia`, `costo_compra`, `costo_dolares`, `precio_venta`, `estado`) VALUES (NULL, 'Fleece', 'Softgoods', 'CREATURE Skeleton Key Pin Up Coach WB Blk', 'CREATURE', 'Sm', '2', '779', '38', '800', 'Activo'), (NULL, 'Fleece', 'Softgoods', 'INDEPENDENT O.G.B.C. Standard Crew Neck Blk', 'INDEPENDENT', 'Md', '2', '958.17', '46.74', '900', 'Activo');
INSERT INTO `articulo` (`id`, `categoria`, `tipo`, `descripcion`, `marca`, `medida`, `cant_existencia`, `costo_compra`, `costo_dolares`, `precio_venta`, `estado`) VALUES (NULL, 'T-Shirt', 'Softgoods', 'BAKER Torn Blk', 'BAKER', 'Md', '2', '264', '12', '400', 'Activo'), (NULL, 'T-Shirt', 'Softgoods', 'BONES Branded Wht', 'BONES', NULL, '1', '0.00', '0.00', '400', 'Activo');
INSERT INTO `articulo` (`id`, `categoria`, `tipo`, `descripcion`, `marca`, `medida`, `cant_existencia`, `costo_compra`, `costo_dolares`, `precio_venta`, `estado`) VALUES (NULL, 'Hats', 'Softgoods', 'BUJWAH STRANGERS Los Strangers Navy Dad Hat', 'BUJWAH STRANGERS', 'os', '4', '350', '0.00', '400', 'Activo'), (NULL, 'Hats', 'Softgoods', 'BUJWAH STRANGERS Smoking Bear Kaki dat Hat', 'BUJWAH STRANGERS', 'os', '1', '350', '0.00', '400', 'Activo');
