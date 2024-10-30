CREATE DATABASE IF NOT EXISTS `base_datos_ferreteria`;
USE `base_datos_ferreteria`;

-- Table structure for table `clientejuridico`
DROP TABLE IF EXISTS `clientejuridico`;
CREATE TABLE `clientejuridico` (
  `idClienteJuridico` int NOT NULL AUTO_INCREMENT primary key,
  `NumeroRuc` varchar(45) NOT NULL,
  `NombreEmpresa` varchar(145) NOT NULL
);

-- Table structure for table `tiposcliente`
DROP TABLE IF EXISTS `tiposcliente`;
CREATE TABLE `tiposcliente` (
  `idTiposCliente` int NOT NULL AUTO_INCREMENT primary key,
  `TipoCliente` varchar(45) NOT NULL,
  `ClienteJuridico_idClienteJuridico` int,
  CONSTRAINT `fk_TiposCliente_ClienteJuridico1` 
    FOREIGN KEY (`ClienteJuridico_idClienteJuridico`) 
    REFERENCES `clientejuridico` (`idClienteJuridico`)
    ON DELETE SET NULL
);

-- Table structure for table `clientenatural`
DROP TABLE IF EXISTS `clientenatural`;
CREATE TABLE `clientenatural` (
  `idClienteNatural` int NOT NULL AUTO_INCREMENT primary key,
  `dni` varchar(45) NOT NULL,
  `Nombre` varchar(145) NOT NULL,
  `Apellido` varchar(145) NOT NULL,
  `TiposCliente_idTiposCliente` int NOT NULL,
  CONSTRAINT `fk_ClienteNatural_TiposCliente1` 
    FOREIGN KEY (`TiposCliente_idTiposCliente`) 
    REFERENCES `tiposcliente` (`idTiposCliente`)
    ON DELETE CASCADE
);

-- Table structure for table `clientes`
DROP TABLE IF EXISTS `clientes`;
CREATE TABLE `clientes` (
  `CodigoCliente` int NOT NULL AUTO_INCREMENT primary key,
  `TiposCliente_idTiposCliente` int NOT NULL,
  `Direccion` varchar(145) NOT NULL,
  `Telefono` varchar(45) NOT NULL,
  CONSTRAINT `fk_Clientes_TiposCliente1` 
    FOREIGN KEY (`TiposCliente_idTiposCliente`) 
    REFERENCES `tiposcliente` (`idTiposCliente`)
    ON DELETE CASCADE
);

-- Table structure for table `usuariosistema`
DROP TABLE IF EXISTS `usuariosistema`;
CREATE TABLE `usuariosistema` (
  `idUsuarioSistema` int NOT NULL AUTO_INCREMENT primary key,
  `NombreUsuario` varchar(45) NOT NULL,
  `Contraseña` varchar(255) NOT NULL  -- Cambié a varchar para manejar contraseñas
);

-- Table structure for table `ventas`
DROP TABLE IF EXISTS `ventas`;
CREATE TABLE `ventas` (
  `idVentas` int NOT NULL AUTO_INCREMENT primary key,
  `NumeroComprobante` varchar(45) NOT NULL,
  `FechaEmitida` date NOT NULL,
  `HoraEmitida` time NOT NULL,
  `Clientes_CodigoCliente` int NOT NULL,
  `UsuarioSistema_idUsuarioSistema` int NOT NULL,
  CONSTRAINT `fk_Ventas_Clientes1` 
    FOREIGN KEY (`Clientes_CodigoCliente`) 
    REFERENCES `clientes` (`CodigoCliente`)
    ON DELETE CASCADE,
  CONSTRAINT `fk_Ventas_UsuarioSistema1` 
    FOREIGN KEY (`UsuarioSistema_idUsuarioSistema`) 
    REFERENCES `usuariosistema` (`idUsuarioSistema`)
    ON DELETE CASCADE
);

-- Table structure for table `tipocomprobante`
DROP TABLE IF EXISTS `tipocomprobante`;
CREATE TABLE `tipocomprobante` (
  `idTipoComprobante` int NOT NULL AUTO_INCREMENT primary key,
  `NombreTipoComprobante` varchar(45) NOT NULL,
  `Ventas_idVentas` int NOT NULL,
  CONSTRAINT `fk_TipoComprobante_Ventas1` 
    FOREIGN KEY (`Ventas_idVentas`) 
    REFERENCES `ventas` (`idVentas`)
    ON DELETE CASCADE
);

-- Table structure for table `factura`
DROP TABLE IF EXISTS `factura`;
CREATE TABLE `factura` (
  `idFactura` int NOT NULL AUTO_INCREMENT primary key,
  `SubTotal` decimal(9,2) NOT NULL,
  `Total` decimal(9,2) NOT NULL,
  `IVA` decimal(9,2) NOT NULL,
  `TipoComprobante_idTipoComprobante` int NOT NULL,
  CONSTRAINT `fk_Factura_TipoComprobante1` 
    FOREIGN KEY (`TipoComprobante_idTipoComprobante`) 
    REFERENCES `tipocomprobante` (`idTipoComprobante`)
    ON DELETE CASCADE
);

-- Table structure for table `tipoproducto`
DROP TABLE IF EXISTS `tipoproducto`;
CREATE TABLE `tipoproducto` (
  `idTipoProducto` int NOT NULL AUTO_INCREMENT primary key,
  `NombreTipoProducto` varchar(45) NOT NULL
);

-- Table structure for table `productos`
DROP TABLE IF EXISTS `productos`;
CREATE TABLE `productos` (
  `idProductos` int NOT NULL AUTO_INCREMENT primary key,
  `NombreProducto` varchar(145) NOT NULL,
  `Descripcion` varchar(255) NOT NULL,  -- Aumenté la longitud de Descripción
  `Precio_compra` decimal(9,2) NOT NULL,
  `Precio_venta` decimal(9,2) NOT NULL,
  `Stock` int NOT NULL,  -- Cambié a int para representar cantidad de stock
  `FechaRegistro` date NOT NULL,  -- Cambié a date para mayor precisión
  `TipoProducto_idTipoProducto` int NOT NULL,
  CONSTRAINT `fk_Productos_TipoProducto` 
    FOREIGN KEY (`TipoProducto_idTipoProducto`) 
    REFERENCES `tipoproducto` (`idTipoProducto`)
    ON DELETE CASCADE
);

-- Table structure for table `detalleventa`
DROP TABLE IF EXISTS `detalleventa`;
CREATE TABLE `detalleventa` (
iddetalleventa int auto_increment primary key,
  `Productos_idProductos` int NOT NULL,
  `Ventas_idVentas` int NOT NULL,
  `Unidades` int NOT NULL,
  `Importe` decimal(9,2) NOT NULL,  -- Cambié a decimal para manejar importes
  CONSTRAINT `fk_Productos_has_Ventas_Productos1` 
    FOREIGN KEY (`Productos_idProductos`) 
    REFERENCES `productos` (`idProductos`)
    ON DELETE CASCADE,
  CONSTRAINT `fk_Productos_has_Ventas_Ventas1` 
    FOREIGN KEY (`Ventas_idVentas`) 
    REFERENCES `ventas` (`idVentas`)
    ON DELETE CASCADE
);
