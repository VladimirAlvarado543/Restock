CREATE DATABASE SistemaInventario
GO
USE SistemaInventario
Go
---Tabla para clientes---
CREATE TABLE Cliente(
idCliente INT IDENTITY(100,1) PRIMARY KEY,
--Id generado automaticamente desde 100--
nombre VARCHAR(100) NOT NULL, 
--Ingresar el nombre de el cliente, el espacio se define como not null ya que es un campo nesesario--
nombreEmpresa VARCHAR(100),
--En caso que el cliente sea una empresa--
detalles VARCHAR (max),
--Descripcion o detalles del cliente--
idDocumento VARCHAR(100),
--Documento de el cliente--
contacto VARCHAR(75),
--Contacto en redes sociales como instagram o facebook--
correoElectronico Varchar(75),
--E-mail del cliente--
direccion VARCHAR(100),
--Direccion del cliente o de la entrega--
numeroTelefono INT NOT NULL);
--Numero de telefono--
GO

--Tabla Proveedor--
CREATE TABLE Proveedor (
idProveedor INT IDENTITY(100,1) PRIMARY KEY,
--Id generado automaticamente desde 100--
nombre VARCHAR(100)NOT NULL, 
--Ingresar el nombre de el cliente, el espacio se define como not null ya que es un campo nesesario--
nombreEmpresa VARCHAR(100)NOT NULL,
--Nombre de la empresa proveedora, definido not null ya que es un campo obligatorio--
detalles VARCHAR(MAX),
--Descripcion o detalles de proveedor--
producto VARCHAR(MAX)NOT NULL,
--Nombre de el o los productos que provee, definifo como not null ya que es un campo obligatorio--
idDocumento VARCHAR(50),
--Documento de el Proveedor--
correoElectronico VARCHAR(50) NOT NULL,
--E-mail del Proveedor--
direccion VARCHAR(100),
--Direccion del Proveedor--
numeroTelefono VARCHAR(20)NOT NULL,
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
--Nombre de rol es unico y obligatorio--
nombreRol VARCHAR(30) NOT NULL UNIQUE);
GO
--Define si es un empleado un administrador--


--Tabla Usuario--
CREATE TABLE Usuario(
idUsuario INT IDENTITY(10000,372) PRIMARY KEY,
--Id usando Identity ya que la id de usuario se nos pidio que fuera mas larga ya que funciona de forma similar aun carnet--
contrasenia VARCHAR(30)NOT NULL,
--Contrase�a obligatoria de 15 caracteres como maximo, se escribe "contrasena" para evitar problemas de compatibilidad con el codigo--
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
--Nombre categoria es obligatorio y unico--
nombreCategoria VARCHAR(50)NOT NULL UNIQUE,
detalles VARCHAR(MAX));
GO

--Tabla para definir una Marca--
CREATE TABLE Marca(
idMarca INT IDENTITY(1,1)PRIMARY KEY,
--Nombre Marca es obligatorio y unico--
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
idProveedor INT NOT NULL,
--Id del proveedor del producto--
FOREIGN KEY(idProveedor) REFERENCES Proveedor(idProveedor),
--Llaves foraneas--
FOREIGN KEY(idCategoria) REFERENCES Categoria(idCategoria),
FOREIGN KEY(idMarca) REFERENCES Marca(idMarca));
 GO 

 --Tabla ventas en la que se llevara registro de las ventas realizadas--
CREATE TABLE detalleFactura (
idDetalleFactura INT IDENTITY(1,1) PRIMARY KEY,
idProducto INT NOT NULL,
--idDelProducto--
detalles VARCHAR(MAX),
cantidad INT NOT NULL,
--Cantidad de producto vendido--
fechaVenta DATE NOT NULL,
idUsuario INT,
FOREIGN KEY(idProducto) REFERENCES Producto(idProducto),
FOREIGN KEY(idUsuario) REFERENCES Usuario(idUsuario));
--llaves foraneas--
GO

CREATE TABLE Factura(
idFactura INT IDENTITY(1,1)	PRIMARY KEY,
idDetalleFactura INT NOT NULL,
idCliente INT,
--id del cliente si aplica--
--Llaves foraneas--
FOREIGN KEY(idCliente) REFERENCES Cliente(idCliente),
FOREIGN KEY(idDetalleFactura) REFERENCES DetalleFactura(idDetalleFactura));
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

SELECT idProducto, nombreProducto, P.detalles, C.nombreCategoria AS Categoria, NM.nombreMarca AS Marca,
PR.nombre AS Proveedor, existencia, precioCompra, fechaIngreso,
precioVenta FROM Producto P INNER JOIN Categoria C ON P.idCategoria = C.idCategoria
INNER JOIN Marca NM ON P.idMarca = NM.idMarca INNER JOIN Proveedor PR ON
P.idProveedor = PR.idProveedor  WHERE 1=1 

Insert into Categoria values ('STEREN', 'MULTIMEDIA')
Insert into Marca values ('STEREN',' ')

SELECT *from Cliente WHERE 1=1 AND idCliente = 100

SELECT *FROM Cliente
SELECT *FROM Proveedor
SELECT *FROM Usuario
SELECT *FROM Producto
SELECT *FROM Marca
SELECT *FROM Categoria


insert into Proveedor values ('Alejandra Ramirez', 'ELECTRONICA STEREN EL SALVADOR SA DE CV
', 'EQUIPOS ELECTRONICOS, IPTV Y CABLEADO','INTV-110 TV BOX','0614-231120-103-5','alejandra_ramirez@steren.com.mx',
'local 287-288 8 etapa metrocentro san salvador san salvador.
','25083134','www.steren.com.mx','78542152','WhatsApp 76300589')
 
insert into Proveedor values ('RIGOBERTO RIVERA','CASA RIVAS','EQUIPOS ELECTRONICOS, CABLES Y COMPONENTES',
'FIBRA','0621-241152-103-2','rigoberto_riv@casarivas.com.sv',' 2a Avenida Norte #312, San Salvador',
'22221718','www.casarivas.com','22220964','WhatsApp 72204545')

insert into Proveedor values ('ARMANDO RODRIGUEZ LARA','ELECTRONICA JAPONESA','CABLEADO Y COMPONENTES',
'CABLEADO','0615-25455-108-1','parquelibertad@electronicajaponesa.com',' 2a Calle Oriente, Portal Sagrera #17-319, San Salvador',
'2221 6558','www.electronicajaponesa.com','  -  ','WhatsApp 77441553')

insert into Proveedor values ('LILIANA ROXANA RIVAS','RG Nieto SA de CV','Tienda de accesorios tecnol�gicos para oficina y hogar.',
'EQUIPO OFICINA','0645-25454-125-5','cm_rgnieto@outlook.com','Metrocentro 8va Etapa, Metrosur, San Salvador, El Salvador',
'2261 0016','  -  ','  -  ','WhatsApp 69252525')

Insert into Proveedor values ('PEDRO ARIZABAL','JMTelcom S.A de C.V.','Telecommunications equipment supplier',
'EQUIPO OFICINA','0615-25454-712-1','info@jmtelcom.com','67 av Sur, # 2-D, Colonia Roma, San Salvador, El Salvador',
'22466000','www.tiendajmtelcom.com','2246 6000','	-  ')

Select * From Proveedor

Insert into Cliente values ('OSCAR ANTONIO SANCHEZ ABREGO','  -  ','00:1A:79:58:8A:39',' ','22251212',
'oscar ant@gmail.com','SAN SALVADOR','79254545')

Insert into Cliente values ('NOE DAVID MORAN ZANCO','  -  ','00:1A:79:58:89:74',' ','23261215','noe david@gmail.com',
'SAN SALVADOR','74562545')

Insert into Cliente values ('PRUEBA OFICINA VERSAILLES REASIGNADA','  -  ','00:1A:79:58:8D:D4',' ','22304444',
'prueba of@gmail.com','SAN SALVADOR','69253698')

Insert into Cliente values ('DORIS ELIZABETH GOMEZ DE RODEZNO','  -  ','00:1A:79:58:88:48',' ','26701112','doris eli@gmail.com',
'SAN SALVADOR','75144578')

Insert into Cliente values ('MARIA LUISA VASQUEZ OSORIO','  -  ','00:1A:79:58:83:77',' ','26701245','maria lui@gmail.com','SAN SALVADOR',
'71184540')

Insert into Cliente values ('NATALY NOHEMY RAMIREZ SANTOS','  -  ','00:1A:79:58:7F:D5',' ','22300058','nataly no@gmail.com',
'SAN SALVADOR','76202525')

Insert into CLiente values ('OSCAR ARMANDO VELASQUEZ REYES','  -  ','00:1A:79:58:8A:B9',' ','22561845','oscar arm@gmail.com',
'SAN SALVADOR','78992545')

Insert into Cliente values ('JULIO ALBERTO PANAME�O HURTADO','  -  ','00:1A:79:58:80:15',' ','21184045','julio alb@gmail.com',
'SAN SALVADOR','78402545')

Insert into Cliente values ('JUAN JOSE FRANCO','  -  ','00:1A:79:58:7F:75',' ','21184978','juan jose@gmail.com','SAN SALVADOR',
'71456589')

Insert into Cliente values('VIRGILIO COMPRAS ONLINE','  -  ','00:1A:79:58:86:2D',' ','22304599','virgilio @gmail.com','SAN SALVADOR',
'70029541')

Insert into Cliente values ('JUAN JOSE FRANCO 1','  -  ','00:1A:79:58:88:4B',' ','22305488','juan jose@gmail.com','SAN SALVADOR',
'70029445')

Insert into Cliente values ('MARIO ERNESTO ORELLANA MARTINEZ','  -  ','00:1A:79:58:83:F1',' ','21184963','mario ern@gmail.com',
'SAN SALVADOR','72204578')

Insert into Cliente values ('DAYSI ALEJANDRA DEL VALLE CALLES VIRTUAL','  -  ','00:1A:79:58:8D:D7',' ','25457878',
'daysi ale@gmail.com','SAN SALVADOR','71124558')

Insert into CLiente values ('VILMA HAYDE CHAVEZ GIRON','  -  ','00:1A:79:58:85:F0',' ','22561744','vilma hay@gmail.com',
'SAN SALVADOR','69254525')

Insert into Cliente values ('JOSE  MANUEL RODRIGUEZ LOVO','  -  ','00:1A:79:58:8A:44',' ','22561844','jose  man@gmail.com',
'SAN SALVADOR','69141414')

Insert into Cliente values ('ERICKA ESTEFANIA CORNEJO TORRES','  -  ','00:1A:79:58:84:FE',' ','22561945','ericka es@gmail.com',
'SAN SALVADOR','61207899')


Insert into Cliente values ('ERICKA ESTEFANIA CORNEJO TORRES','  -  ','00:1A:79:58:87:6F',' ','22408090','ericka es@gmail.com',
'SAN SALVADOR','74401254')

Insert into Cliente values ('ANA RUTH CARBAJAL CORTEZ','  -  ','00:1A:79:58:8A:DC',' ','23264646','ana ruth @gmail.com',
'SAN SALVADOR','76300898')

Insert into Cliente values ('LESLY LISSETT REYES QUEZADA','  -  ','00:1A:79:58:82:6D',' ','28789878','lesly lis@gmail.com',
'SAN SALVADOR','76152025')

Insert into Cliente values ('EDITH ALDANUVIA GARCIA CANJURA','  -  ','00:1A:79:58:82:6F',' ','21184578','edith ald@gmail.com',
'SAN SALVADOR','76904598')
 select *from Cliente


Insert into Categoria values ('STEREN', 'MULTIMEDIA')

Insert into Categoria values ('JMTELCOM','TELECOMUNICACIONES')
 
Insert into Categoria values ('JMTELCOM','EQUIPO OFICINA')
 
Insert into Categoria values ('JMTELCOM','CABLEADO')

Insert into Categoria values ('RG Nieto SA de CV','EQUIPOS PERIFERICOS')
 
Insert into Categoria values ('ELECTRONICA JAPONESA','EQUIPOS FIBRA OPTICA')

Insert into Categoria values ('ELECTRONICA JAPONESA','EQUIPOS CABLE TV ANALOGO')
 
Select *From Categoria
 
Select *from Marca

Insert into Marca values ('STEREN',' ')

Insert into Marca values ('JMTELCOM',' ')

Insert into Marca values ('RG Nieto SA de CV', ' ')

Insert into Marca values ('Electronica Japonesa',' ')
 
 
--ID MULTIMEDIA = 1             STEREN ID = 1

--ID TELECOMUNICACIONES = 2     JMTELECOM ID = 2

--ID EQUIPOS PERIFERICOS = 5    RG NIETO SA DE CV ID = 3

--ID EQUIPOS FIBRA OPTICA = 6   ELECTRINUCA JAPONESA ID = 4
 
--PRovedores

--100 ELECTRONICA STEREN EL SALVAODR SA DE CV

--101 CASA RIVAS

--102 ELECTRONICA JAPONESA

--103 RG Nieto SA de CV

--104JMTelcom S.A de C.V
 
 
--Primer Insert--

Insert into Producto values ('INTV 110','TV BOX','1','1','40',' 29.19','2025/06/25','45',100)

Insert into Producto values ('MXQ 4K','TV BOX','1','1','15','19.40','2025/04/15','25',102)

Insert into Producto values ('RM-325-2','CONTROL TV','1','1','6','9.99','2025/04/12','17',101)

Insert into Producto values ('PO42881','CONVERTIDOR HDMI A VGA','5','3','10','4.25','2025/06/15','9.99',101)

Insert into Producto values ('GRANSTREAM GXP1625','TELEFONOS IP','2','2','10','45.25','2025/06/12','62',104)

Insert into Producto values ('INTV 110 PRO','TV BOX','1','1','20','32.00','2025/06/22','49',100)

Insert into Producto values ('MONITOR AOC','MONITOR','5','3','3','93.25','2025/06/05','0',103)

Insert into Producto values ('INTV 110','TV BOX','1','1','10','29.19','2025/05/03','45',100)

Insert into Producto values ('INTV 110','TV BOX','1','1','15','29.19','2025/05/03','45',100)

Insert into Producto values ('MXQ 4K','TV BOX','1','1','10','19.40','2025/04/12','25',102)

Insert into Producto values ('RM-325 -2','CONTROL TV','1','1','6','9.99','2025/04/01','17',100)

Insert into Producto values ('RM-325 -2','CONTROL TV','1','1','6','9.99','2025/04/05','17',100)

Insert into Producto values ('TX9','TV BOX','1','2','5','18.00','2025/05/04','25',102)
 
Select *from Producto 

INSERT INTO Marca (nombreMarca) VALUES ('SPARTAN STORE')
 
--Categoria--
INSERT INTO Categoria (nombreCategoria) VALUES
('CAMISA'),
('SUDADERA'),
('BUCKET HAT'),
('GORRA'),
('LANYARD'),
('TAZAS'),
('CAMISETAS'),
('BLUSAS'),
('CAMISAS NI�OS'),
('UNIFORMES DEPORTIVOS'),
('UNIFORMES FORMALES'),
('BANDERAS'),
('CALZONETAS'),
('CAMISAS PERSONALIZADAS'),
('SUDADERAS PERSONALIZADAS');
 
--Proveedor--
INSERT INTO Proveedor (nombre, nombreEmpresa, detalles, producto, idDocumento, correoElectronico, direccion, numeroTelefono, paginaWeb, contactoAdicionalDos) VALUES
('WILFREDO LAINEZ', 'Luxor GT S.A de C.V', 'INSUMOS SUBLIMACION', 'PAPEL SUBLIMACION, TAZAS, LANYARD Y MAS', '0615-15545-120-4', 'ventas@serigraficosluxor.com', '65 Av. sur pasaje Caribe #9 Col Escalon., San Salvador, El Salvador', '78645637', 'www.serigraficosluxor.com', 'Whatsap 78645637'),
('WENDY CHACON', 'DEPOSITO DE TELAS', 'TELAS', 'TELAS', '0615-14525-105-1', 'sac@depotelas.com', 'METROCENTRO Y CENTRO SAN SALVADOR', '23473000', 'www.depositodetelas.com', 'Whatsap 78026482'),
('JUAN ROBERTO CHOTO', 'IMPRESIONES Y MAS', 'IMPRESI�N SUBLIMACION', 'SERVICIO DE IMPRESI�N', '-', 'impresos@gmail.com', 'casa #40 las magnolias san salvador', '78402145', '-', 'Whatsap 72204578'),
('Sr. Rodriguez', 'COPLASA S.A. de C.V.', 'INSUMOS MAQUINARIA', 'TELAS, INSUMOS DE MAQUINARIA', '0615-15788-103-7', 'servicioalcliente@coplasa.com.svom.sv', '1�. Calle Pte. Y 9�. Av. Nte. No.531, San Salvador, El salvador.', '25354555', '-', '-'),
('DOULAS QUINTANILLA', 'Mequinsal Sa de CV', 'INSUMOS DE MAQUINARIA', 'AGUJAS ACEITES', '0615-16784-107-8', 'douglasquintanilla@mequinsal.com', 'Alameda Juan Pablo II y 5a. Av Norte N� 403, San Salvador, El Salvador', '22811485', 'www.mequinsal.com', 'Whatsap 76586223'),
('ROXANA RODRIGUEZ', 'H Tech El Salvador', 'FIGURAS, ACCESORIOS Y MAS', 'FIGURAS, ACCESORIOS Y MAS', '-', 'h.internacional19@gmail.com', 'CALLE ARCE LOCAL 125 SAN SALVADOR', '22211222 ', '-', 'Whatsap 22212888');
 
--Producto--
INSERT INTO Producto (nombreProducto, detalles, idCategoria, idMarca, existencia, precioCompra, fechaIngreso, precioVenta, idProveedor) VALUES
('CAMISA DRAGON BALL Z', 'TODAS LAS TALLAS', 1, 1, 50, 6.00, '2025/5/12', 12, 102),
('SUDARAS ONE PIECE', 'TODAS LAS TALLAS', 2, 1, 24, 12.00, '2025/5/13', 25, 102),
('ANIME', 'DISE�OS VARIADOS', 3, 1, 50, 4.00, '2025/5/14', 8, 102),
('GORRA NORMAL ACRILICO', 'DISE�OS VARIADOS', 4, 1, 27, 4.00, '2025/5/15', 8, 101),
('ANIME', 'DISE�OS VARIADOS', 5, 1, 75, 3.00, '2025/5/16', 6, 102),
('BLANCAS PARA SUBLIMAR', 'SIN DISE�O', 6, 1, 36, 2.00, '2025/5/17', 6, 101),
('CAMISAS BASICA NEGRA', 'SIN DISE�O', 7, 1, 125, 6.00, '2025/5/18', 15, 101),
('BLUSA BASICA', 'SIN DISE�O', 8, 1, 24, 6.00, '2025/5/19', 12, 101),
('ANIME', 'DISE�O DRAGON BALL', 9, 1, 36, 4.00, '2025/5/20', 8, 102),
('BARCELONA', 'A�O 2024', 10, 1, 48, 10.00, '2025/5/21', 15, 102),
('REAL MADRID', 'A�O 2024', 11, 1, 12, 10.00, '2025/5/22', 15, 102),
('CHELSEA', 'A�O 2024', 12, 1, 6, 15.00, '2025/5/23', 15, 102),
('NEGRA', 'BASICA SIN DISE�O', 13, 1, 12, 3.00, '2025/5/24', 6, 101),
('BLANCAS PARA SUBLIMAR', 'SIN DISE�O', 14, 1, 6, 4.00, '2025/5/25', 12, 101),
('BLANCAS PARA SUBLIMAR', 'SIN DISE�O', 15, 1, 12, 4.00, '2025/5/26', 12, 101);
 
--Clientes--
INSERT INTO Cliente (nombre, nombreEmpresa, detalles, idDocumento, contacto, correoElectronico, direccion, numeroTelefono) VALUES
('ZOILA YAMILLA AZCUNAGA MONTES', '-', 'COMPRAS HABITUALES', 'DUI 09879743-4', '75253658', 'zoila78@gmail.com', 'QUEZALTEPEQUE', 75253658),
('JOSE OVIDIO PEREZ LOPEZ', '-', 'SOLO SUDADERAS', 'DUI 09879743-5', '77525898', 'jose_78@gmail.com', 'QUEZALTEPEQUE', 77525898),
('LUIS ALONSO MARTINEZ', 'MIKE CARS WASH', 'COMPRAS POR MAYOR', 'DUI 0313131-74', '74589899', 'luisdf@gmail.com', 'QUEZALTEPEQUE', 74589899),
('NATIVIDAD FLORES SIERRA', '-', 'MAYORISTA BUCKET HAT', 'DUI 0313131-75', '74253698', 'natividad@gmail.com', 'QUEZALTEPEQUE', 74253698),
('KARLA GUADALUPE ZELAYA', '-', 'LANYARDS', 'DUI 0313131-76', '78988254', 'karla5@gmail.com', 'QUEZALTEPEQUE', 78988254),
('CHRISTIAN ALEJANDRO RIVAS RAMOS', '-', 'COMPRAS HABITUALES', 'DUI 0313131-77', '78456589', 'chris789@gmail.com', 'QUEZALTEPEQUE', 78456589),
('FLOR DE MARIA BLANCO', '-', 'COMPRAS MAYORISTAS NO HABITUAL', 'DUI 0313131-78', '78541254', 'flordasd3@gmail.com', 'QUEZALTEPEQUE', 78541254),
('YANCI KARINA SALINAS PALACIOS', '-', 'COMPRAS MINIMAS', 'DUI 0897946-4', '62325878', 'yanci9@gmail.com', 'QUEZALTEPEQUE', 62325878),
('ZOILA YAMILLA AZCUNAGA MONTES', '-', 'COMPRAS MINIMAS', 'DUI 0897946-5', '75456987', 'zoila212@gmail.com', 'SAN SALVADOR', 75456987),
('KAREN MELISSA MINEROS MOLINA', 'GOGOS TEMPO', 'COMPRAS POR MAYOR', 'DUI 0897946-6', '72243654', 'karen@gmail.com', 'SAN SALVADOR', 72243654),
('MARIA LILIAN ELETICIA ZAMORA', 'TIENDA LILIAN', 'COMPRAS POR MAYOR', 'DUI 0897946-7', '72547899', 'maria1@gmail.com', 'SAN SALVADOR', 72547899),
('RICARDO ALBERTO GARCIA', '-', 'CAMISAS PERSONALIZADAS', 'DUI 0897946-8', '69202888', 'ricarl@gmail.com', 'SAN SALVADOR', 69202888),
('JOSSELINE ZENAIDA COLORADO GONZALEZ', '-', 'SUDADERAS BLANCAS', 'DUI 0489745-0', '78456589', 'jossee3@gmail.com', 'SAN SALVADOR', 78456589),
('CHRISTIAN JONATHAN CAMPOS GUEVARA', '-', 'UNIFORMES DEPORTIVOS', 'DUI 0489745-1', '78696969', 'chris@gmail.com', 'SAN SALVADOR', 78696969),
('FRANCISCO OTTONIEL PORTILLO', '-', 'UNIFORMES DEPORTIVOS', 'DUI 0489745-2', '76300898', 'franc89@gmail.com', 'SAN SALVADOR', 76300898),
('RIGOBERTO HERNANDEZ BARRERA', '-', 'UNIFORMES DEPORTIVOS', 'DUI 0489745-3', '70029544', 'rigob*@gmail.com', 'SAN SALVADOR', 70029544),
('HEIZEL ALEJANDRA SORIANO SORIANO', '-', 'UNIFORMES DEPORTIVOS ESCUELA', 'DUI 0489745-4', '60247489', 'heize786@gmail.com', 'SAN SALVADOR', 60247489),
('EDGAR BALDOMEDO GUEVARA', 'QUESERIA BALDO', 'CAMISAS SOLO BLANCAS', 'DUI 0489745-5', '78938547', 'edgard@gmail.com', 'SAN SALVADOR', 78938547),
('ROGER MARVIN SANCHEZ HENRIQUEZ', '-', 'CAMISAS SOLO BLANCAS', 'DUI 0489745-6', '62208240', 'rogerw@gmail.com', 'SAN SALVADOR', 62208240);

SELECT *FROM Producto
SELECT *FROM Cliente
SELECT *FROM Proveedor
SELECT *FROM Marca
SELECT *FROM Categoria
