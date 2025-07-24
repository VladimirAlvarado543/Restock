CREATE DATABASE SistemaInventario
GO
USE SistemaInventario
Go
---Tabla para clientes---
CREATE TABLE Cliente(
idCliente INT IDENTITY(100,1) PRIMARY KEY,
--Id generado automaticamente desde 100--
nombre VARCHAR(50) NOT NULL, 
--Ingresar el nombre de el cliente, el espacio se define como not null ya que es un campo nesesario--
nombreEmpresa VARCHAR(50),
--En caso que el cliente sea una empresa--
detalles VARCHAR (max),
--Descripcion o detalles del cliente--
idDocumento VARCHAR(50),
--Documento de el cliente--
contacto VARCHAR(50),
--Contacto en redes sociales como instagram o facebook--
correoElectronico Varchar(50),
--E-mail del cliente--
direccion VARCHAR(50),
--Direccion del cliente o de la entrega--
numeroTelefono INT);
--Numero de telefono--
GO

--Tabla Proveedor--
CREATE TABLE Proveedor (
idProveedor INT IDENTITY(100,1) PRIMARY KEY,
--Id generado automaticamente desde 100--
nombre VARCHAR(50)NOT NULL, 
--Ingresar el nombre de el cliente, el espacio se define como not null ya que es un campo nesesario--
nombreEmpresa VARCHAR(50)NOT NULL,
--Nombre de la empresa proveedora, definido not null ya que es un campo obligatorio--
detalles VARCHAR(MAX),
--Descripcion o detalles de proveedor--
producto VARCHAR(MAX)NOT NULL,
--Nombre de el o los productos que provee, definifo como not null ya que es un campo obligatorio--
idDocumento VARCHAR(50),
--Documento de el Proveedor--
correoElectronico VARCHAR(50),
--E-mail del Proveedor--
direccion VARCHAR(100),
--Direccion del Proveedor--
numeroTelefono VARCHAR(20),
--Numero de telefono del Proveedor--
paginaWeb VARCHAR(MAX),
--Pagina web de el proveedor--
contactoAdicional VARCHAR(50),
--Contactos adicionales--
contactoAdicionalDos VARCHAR(50)
);
--En el area de contacto no es nesesario llenar todos los campo ya que con uno es suficiente--
--Definido al momento de ingresar datos en visual estudio--
GO

CREATE TABLE Rol(
id_Rol INT IDENTITY(1,1) PRIMARY KEY,
nombreRol VARCHAR(30) NOT NULL UNIQUE);
GO
--Define si es un empleado un administrador--


--Tabla Usuario--
CREATE TABLE Usuario(
idUsuario INT IDENTITY(10000,372) PRIMARY KEY,
--Id usando Identity ya que la id de usuario se nos pidio que fuera mas larga ya que funciona de forma similar aun carnet--
contrasenia VARCHAR(30)NOT NULL,
--Contraseña obligatoria de 15 caracteres como maximo, se escribe "contrasena" para evitar problemas de compatibilidad con el codigo--
nombre VARCHAR(50)NOT NULL,
apellido VARCHAR(50)NOT NULL,
--Nombres obligatorios--
idRol INT NOT NULL		,
--Define los permisos que tendra dentro de la aplicacion ya sea usuario o administrador--
numeroTelefono VARCHAR(50) NOT NULL,
--Numero de telefono obligatorio para tener una forma de contacto--
contacto VARCHAR(50)
--Contacto adicional--
FOREIGN KEY(idRol) REFERENCES Rol(id_Rol)
);
--LLave foranea--
GO

--Tabla para definir una categoria--
CREATE TABLE Categoria(
idCategoria INT IDENTITY(1,1)PRIMARY KEY,
nombreCategoria VARCHAR(50)NOT NULL UNIQUE,
detalles VARCHAR(MAX));
GO

--Tabla para definir una Marca--
CREATE TABLE Marca(
idMarca INT IDENTITY(1,1)PRIMARY KEY,
nombreMarca VARCHAR(50) NOT NULL UNIQUE,
detalles VARCHAR(MAX));
GO

--Tabla Productos--
CREATE TABLE Producto (
idProducto INT IDENTITY(1000,1) PRIMARY KEY,
--Id Producto empezando desde el numero 1000 como se solicito--
nombreProducto VARCHAR(100)NOT NULL,
--Nombre obligatorio del producto--
detalles VARCHAR(MAX),
--Detalles o descripcion del producto--
idCategoria INT,
--Define la categoria del producto que se podra asignar desde la aplicacion--
idMarca INT,
--Define la marca comercial del producto--
existencia INT NOT NULL,
--Muestra cuantos productos hay en existencia--
precioCompra DECIMAL(10,2),
--Para poder registrar el precio de la compra del producto al proveedor--
fechaIngreso DATE NOT NULL,
--Fecha de ingreso del producto--
precioVenta DECIMAL(10,2)NOT NULL,
--Precio de venta que tendra en el emprendimiento o empresa--
idProveedor INT,
--Id del proveedor del producto--
FOREIGN KEY(idProveedor) REFERENCES Proveedor(idProveedor),
--Llaves foraneas--
FOREIGN KEY(idCategoria) REFERENCES Categoria(idCategoria),
FOREIGN KEY(idMarca) REFERENCES Marca(idMarca));
 GO 
 
insert into Marca(nombreMarca) VALUES('Marca de prueba');
select *from Marca;

insert into Categoria(nombreCategoria) Values('Categoria de prueba');
select *from Categoria

insert into Proveedor Values('Sujeto de prueba','EmpresaSimulada','Proveedor Prueba',
'Producto X','1909090','dummy@gmail.com','Calle Rosa linda','98900191','Web.Net','Facebook','instagram');
 select *from Proveedor;

 insert into Producto(nombreProducto, detalles, idCategoria, idMarca, existencia, precioCompra, fechaIngreso, precioVenta, idProveedor)
 Values('Producto Prueba','Producto para prueba de registros', 1, 1, 10,10.99,'2025/7/22',20.00,101);
select *from Producto

 --Tabla ventas en la que se llevara registro de las ventas realizadas--
CREATE TABLE detalleFactura (
idDetalleFactura INT IDENTITY(1,1) PRIMARY KEY,
idProducto INT NOT NULL,
--idDelProducto--
detalles VARCHAR(MAX),
cantidad INT NOT NULL,
--Cantidad de producto vendido--
fechaVenta DATE NOT NULL,
--Fecha en que se realizo la venta--
FOREIGN KEY(idProducto) REFERENCES Producto(idProducto));
--llaves foraneas--
GO

CREATE TABLE Factura(
idFactura INT IDENTITY(1,1)	PRIMARY KEY,
idDetalleFactura INT,
idCliente INT,
FOREIGN KEY(idCliente) REFERENCES Cliente(idCliente));
GO

--Tabla para llevar registro de productos que se descarten--
CREATE TABLE ProductoDescartado (
idDescarte INT IDENTITY(100,1) PRIMARY KEY,
detalles VARCHAR(MAX)NOT NULL,
--Detalles y descripcion de porque se descarto el producto--
cantidad INT NOT NULL,
--Cantidad de el producto que se descarto--
fechaDescarte DATE NOT NULL,
--Fecha que se descarto--
idProducto INT NOT NULL,
--Id del producto que se descarto--
FOREIGN KEY(idProducto) REFERENCES Producto(idProducto));
--Llaves foraneas--
GO

--Eliminar tablas en orden--
DROP TABLE ProductoDescartado
DROP TABLE Cliente
DROP TABLE Categoria
DROP TABLE Marca
DROP TABLE Producto
DROP TABLE Proveedor
DROP TABLE Rol
DROP TABLE Usuario

--Consultas--

SELECT idUsuario, contrasenia, nombre, apellido, R.nombreRol AS Rol, numeroTelefono, contacto 
FROM Usuario U
INNER JOIN Rol R ON U.idRol = R.id_Rol;

SELECT *FROM Cliente
SELECT *FROM Proveedor
