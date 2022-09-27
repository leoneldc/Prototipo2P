DROP DATABASE IF EXISTS `parcial2`;
CREATE DATABASE IF NOT EXISTS `parcial2`;
USE `parcial2`;

DROP TABLE IF EXISTS `tbl_pedidos`;
CREATE TABLE IF NOT EXISTS `tbl_pedidos`(
codigoPedido int not null auto_increment,
fechaPedido date not null,
estadoPedido tinyint default 0,
primary key (codigoPedido)
);

DROP TABLE IF EXISTS `tbl_productos`;
CREATE TABLE IF NOT EXISTS `tbl_productos`(
codigoProducto int not null auto_increment,
nombreProducto varchar(50) not null,
marcaProducto varchar(25) not null,
precioProducto float default 0,
existenciasProducto float default 0,
estadoProducto tinyint default 0,
primary key (codigoProducto)
);

DROP TABLE IF EXISTS `tbl_solicitudPedidos`;
CREATE TABLE IF NOT EXISTS `tbl_solicitudPedidos`(
codigoPedido int not null,
codigoProducto int not null,
cantidadPedido float not null,
primary key (codigoPedido, codigoProducto),
foreign key (codigoProducto) references tbl_productos (codigoProducto),
foreign key (codigoPedido) references tbl_pedidos (codigoPedido)
);

DROP TABLE IF EXISTS `tbl_clientes`;
CREATE TABLE IF NOT EXISTS `tbl_clientes`(
nitCliente int not null,
nombreCliente varchar(100) not null,
correoCliente varchar(25) not null,
telefonoCliente int not null,
estadoCliente tinyint default 0,
primary key (nitCliente)
);

DROP TABLE IF EXISTS `tbl_encabezadoVentas`;
CREATE TABLE IF NOT EXISTS `tbl_encabezadoVentas`(
codigoEncabezado int not null auto_increment,
codigoCliente int not null,
fechaVenta date not null,
totalVenta float not null,
estadoVenta tinyint default 0,
primary key (codigoEncabezado),
foreign key (codigoCliente) references tbl_clientes (nitCliente)
);

DROP TABLE IF EXISTS `tbl_detalleVentas`;
CREATE TABLE IF NOT EXISTS `tbl_detalleVentas`(
codigoEncabezado int not null,
codigoPedido int not null,
primary key (codigoEncabezado, codigoPedido),
foreign key (codigoEncabezado) references tbl_encabezadoVentas (codigoEncabezado),
foreign key (codigoPedido) references tbl_pedidos (codigoPedido)
);
