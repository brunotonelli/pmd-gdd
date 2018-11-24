USE [GD2C2018]

BEGIN /*BORRADO DE SCHEMA/TABLAS POR SI EXISTEN*/
IF OBJECT_ID('PMD.Espec_Empresa', 'U') IS NOT NULL DROP TABLE PMD.Espec_Empresa
IF OBJECT_ID('PMD.Estado', 'U') IS NOT NULL DROP TABLE PMD.Estado
IF OBJECT_ID('PMD.Forma_Pago', 'U') IS NOT NULL DROP TABLE PMD.Forma_Pago
IF OBJECT_ID('PMD.Func_Rol', 'U') IS NOT NULL DROP TABLE PMD.Func_Rol
IF OBJECT_ID('PMD.Funcionalidad', 'U') IS NOT NULL DROP TABLE PMD.Funcionalidad
IF OBJECT_ID('PMD.Grado_Publicacion', 'U') IS NOT NULL DROP TABLE PMD.Grado_Publicacion
IF OBJECT_ID('PMD.Item_Factura', 'U') IS NOT NULL DROP TABLE PMD.Item_Factura
IF OBJECT_ID('PMD.Premio', 'U') IS NOT NULL DROP TABLE PMD.Premio
IF OBJECT_ID('PMD.Publicacion', 'U') IS NOT NULL DROP TABLE PMD.Publicacion
IF OBJECT_ID('PMD.Puntos', 'U') IS NOT NULL DROP TABLE PMD.Puntos
IF OBJECT_ID('PMD.Rol', 'U') IS NOT NULL DROP TABLE PMD.Rol
IF OBJECT_ID('PMD.Tipo_Ubicacion', 'U') IS NOT NULL DROP TABLE PMD.Tipo_Ubicacion
IF OBJECT_ID('PMD.Ubicacion', 'U') IS NOT NULL DROP TABLE PMD.Ubicacion
IF OBJECT_ID('PMD.Compra', 'U') IS NOT NULL DROP TABLE PMD.Compra
IF OBJECT_ID('PMD.Cliente', 'U') IS NOT NULL DROP TABLE PMD.Cliente 
IF OBJECT_ID('PMD.Usuario', 'U') IS NOT NULL DROP TABLE PMD.Usuario
IF OBJECT_ID('PMD.Espectaculo', 'U') IS NOT NULL DROP TABLE PMD.Espectaculo 
IF OBJECT_ID('PMD.Factura', 'U') IS NOT NULL DROP TABLE PMD.Factura
IF OBJECT_ID('PMD.Rubro', 'U') IS NOT NULL DROP TABLE PMD.Rubro
IF EXISTS (SELECT * FROM sys.schemas WHERE name = 'PMD') DROP SCHEMA PMD
END
GO
CREATE SCHEMA [PMD]
GO
BEGIN /*CREADO DE TABLAS*/

CREATE TABLE [PMD].[Cliente](
	[Cli_Nro_Doc] [numeric](10, 0) NOT NULL,
	[Cli_Tipo_Doc] [nvarchar](40) NULL,
	[Cli_Apellido] [nvarchar](255) NULL,
	[Cli_Nombre] [nvarchar](255) NULL,
	[Cli_Fecha_Nac] [datetime] NULL,
	[Cli_Mail] [nvarchar](255) NULL,
	[Cli_Dom_Calle] [nvarchar](255) NULL,
	[Cli_Nro_Calle] [numeric](18, 0) NULL,
	[Cli_Piso] [numeric](18, 0) NULL,
	[Cli_Depto] [nvarchar](255) NULL,
	[Cli_Cod_Postal] [nvarchar](255) NULL,
	[Cli_CUIL] [nvarchar](128) NULL,
	[Cli_Telefono] [nvarchar](40) NULL,
	[Cli_Localidad] [nvarchar](128) NULL,
	[Cli_Fecha_Alta] [datetime] NULL,
	[Cli_Tarjeta_Num] [nvarchar](50) NULL,
	[Cli_Tarjeta_Tipo] [nvarchar](40) NULL,
	[Cli_Usuario] [nvarchar](255) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Cli_Nro_Doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Compra]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Compra](
	[Compra_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Compra_Fecha] [datetime] NULL,
	[Compra_Cantidad] [numeric](18, 0) NULL,
	[Compra_Forma_Pago] [int] NOT NULL,
	[Compra_Cliente] [numeric](10, 0) NOT NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[Compra_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Espec_Empresa]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Espec_Empresa](
	[Espec_Empresa_Cuit] [nvarchar](128) NOT NULL,
	[Espec_Empresa_Razon_Social] [nvarchar](255) NOT NULL,
	[Espec_Empresa_Fecha_Creacion] [datetime] NULL,
	[Espec_Empresa_Mail] [nvarchar](50) NULL,
	[Espec_Empresa_Dom_Calle] [nvarchar](50) NULL,
	[Espec_Empresa_Nro_Calle] [numeric](18, 0) NULL,
	[Espec_Empresa_Piso] [numeric](18, 0) NULL,
	[Espec_Empresa_Depto] [nvarchar](50) NULL,
	[Espec_Empresa_Cod_Postal] [nvarchar](50) NULL,
	[Espec_Empresa_Telefono] [nvarchar](40) NULL,
	[Espec_Empresa_Localidad] [nvarchar](128) NULL,
	[Espec_Empresa_Ciudad] [nvarchar](128) NULL,
	[Espec_Empresa_Usuario] [nvarchar](255) NULL,
 CONSTRAINT [PK_Espec_Empresa_1] PRIMARY KEY CLUSTERED 
(
	[Espec_Empresa_Cuit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Espectaculo]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Espectaculo](
	[Espectaculo_Cod] [numeric](18, 0) NOT NULL,
	[Espectaculo_Descripcion] [nvarchar](255) NULL,
	[Espectaculo_Rubro] [int] NULL,
	[Espectaculo_Fecha] [datetime] NULL,
	[Espectaculo_Fecha_Venc] [datetime] NULL,
 CONSTRAINT [PK_Espectaculo] PRIMARY KEY CLUSTERED 
(
	[Espectaculo_Cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Estado]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Estado](
	[Estado_ID] [int] IDENTITY(1,1) NOT NULL,
	[Estado_Descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[Estado_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Factura]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Factura](
	[Factura_Nro] [numeric](18, 0) NOT NULL,
	[Factura_Fecha] [datetime] NULL,
	[Factura_Total] [numeric](18, 2) NULL,
	[Factura_Publicacion] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[Factura_Nro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Forma_Pago]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Forma_Pago](
	[Forma_Pago_ID] [int] IDENTITY(1,1) NOT NULL,
	[Forma_Pago_Desc] [nvarchar](255) NULL,
 CONSTRAINT [PK_Forma_Pago] PRIMARY KEY CLUSTERED 
(
	[Forma_Pago_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Func_Rol]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Func_Rol](
	[Rol_ID] [char](3) NOT NULL,
	[Func_ID] [int] NOT NULL,
 CONSTRAINT [PK_Func_Rol] PRIMARY KEY CLUSTERED 
(
	[Rol_ID] ASC,
	[Func_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Funcionalidad]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Funcionalidad](
	[Func_ID] [int] IDENTITY(1,1) NOT NULL,
	[Func_Descripcion] [nvarchar](255) NULL,
 CONSTRAINT [PK_Funcionalidad] PRIMARY KEY CLUSTERED 
(
	[Func_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Grado_Publicacion]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Grado_Publicacion](
	[Grado_ID] [int] IDENTITY(1,1) NOT NULL,
	[Grado_Nombre] [nvarchar](50) NULL,
	[Grado_Comision] [numeric](10, 4) NULL,
 CONSTRAINT [PK_Grado_Publicacion] PRIMARY KEY CLUSTERED 
(
	[Grado_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Item_Factura]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Item_Factura](
	[Item_Factura_ID] [int] IDENTITY(1,1) NOT NULL,
	[Item_Factura_Factura] [numeric](18, 0) NOT NULL,
	[Item_Factura_Monto] [numeric](18, 2) NULL,
	[Item_Factura_Cantidad] [numeric](18, 0) NULL,
	[Item_Factura_Descripcion] [nvarchar](60) NULL,
	[Item_Factura_Importe_Comision] [numeric](18, 2) NULL,
	[Item_Factura_Compra] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Item_Factura_1] PRIMARY KEY CLUSTERED 
(
	[Item_Factura_ID] ASC,
	[Item_Factura_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Premio]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Premio](
	[Premio_ID] [int] NOT NULL,
	[Premio_Nombre] [nchar](100) NULL,
	[Premio_Descripcion] [nvarchar](255) NULL,
	[Premio_Puntos_Necesarios] [int] NULL,
	[Premio_Vencimiento] [datetime] NULL,
 CONSTRAINT [PK_Premio] PRIMARY KEY CLUSTERED 
(
	[Premio_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Publicacion]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Publicacion](
	[Publicacion_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Publicacion_Espectaculo] [numeric](18, 0) NOT NULL,
	[Publicacion_Fecha] [datetime] NULL,
	[Publicacion_Localidades] [int] NULL,
	[Publicacion_Grado] [int] NULL,
	[Publicacion_Empresa] [nvarchar](128) NOT NULL,
	[Publicacion_Estado] [int] NOT NULL,
 CONSTRAINT [PK_Publicacion] PRIMARY KEY CLUSTERED 
(
	[Publicacion_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Puntos]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Puntos](
	[Puntos_ID] [numeric](18, 0) NOT NULL,
	[Puntos_Cantidad] [nchar](10) NULL,
	[Puntos_Vencimiento] [datetime] NULL,
	[Puntos_Cliente] [numeric](10, 0) NOT NULL,
 CONSTRAINT [PK_Puntos] PRIMARY KEY CLUSTERED 
(
	[Puntos_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Rol]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Rol](
	[Rol_ID] [char](3) NOT NULL,
	[Rol_Nombre] [nvarchar](255) NULL,
	[Rol_Habilitado] [bit] NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[Rol_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Rubro]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Rubro](
	[Rubro_ID] [int] IDENTITY(1,1) NOT NULL,
	[Rubro_Descripcion] [nchar](10) NULL,
 CONSTRAINT [PK_Rubro] PRIMARY KEY CLUSTERED 
(
	[Rubro_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Tipo_Ubicacion]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Tipo_Ubicacion](
	[Tipo_Ubicacion_Codigo] [numeric](18, 0) NOT NULL,
	[Tipo_Ubicacion_Descripcion] [nvarchar](255) NULL,
 CONSTRAINT [PK_Tipo_Ubicacion] PRIMARY KEY CLUSTERED 
(
	[Tipo_Ubicacion_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Ubicacion]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Ubicacion](
	[Ubicacion_Publicacion] [numeric](18, 0) NOT NULL,
	[Ubicacion_Fila] [varchar](3) NOT NULL,
	[Ubicacion_Asiento] [numeric](18, 0) NOT NULL,
	[Ubicacion_Sin_numerar] [bit] NULL,
	[Ubicacion_Precio] [numeric](18, 2) NULL,
	[Ubicacion_Tipo] [numeric](18, 0) NOT NULL,
	[Ubicacion_Compra] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Ubicacion_1] PRIMARY KEY CLUSTERED 
(
	[Ubicacion_Fila] ASC,
	[Ubicacion_Asiento] ASC,
	[Ubicacion_Publicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Usuario]    Script Date: 18/11/2018 2:44:59 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Usuario](
	[Usuario_Username] [nvarchar](255) NOT NULL,
	[Usuario_Password] [binary](64) NULL,
	[Usuario_Intentos_Fallidos] [int] NULL,
	[Usuario_Rol] [char](3) NULL,
 CONSTRAINT [PK_Usuario_1] PRIMARY KEY CLUSTERED 
(
	[Usuario_Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [PMD].[Usuario] ADD  CONSTRAINT [DF_Usuario_Usuario_Intentos_Fallidos]  DEFAULT ((0)) FOR [Usuario_Intentos_Fallidos]

ALTER TABLE [PMD].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Usuario] FOREIGN KEY([Cli_Usuario])
REFERENCES [PMD].[Usuario] ([Usuario_Username])

ALTER TABLE [PMD].[Cliente] CHECK CONSTRAINT [FK_Cliente_Usuario]

ALTER TABLE [PMD].[Espec_Empresa]  WITH CHECK ADD  CONSTRAINT [FK_Espec_Empresa_Usuario] FOREIGN KEY([Espec_Empresa_Usuario])
REFERENCES [PMD].[Usuario] ([Usuario_Username])

ALTER TABLE [PMD].[Espec_Empresa] CHECK CONSTRAINT [FK_Espec_Empresa_Usuario]

ALTER TABLE [PMD].[Espectaculo]  WITH CHECK ADD  CONSTRAINT [FK_Espectaculo_Rubro] FOREIGN KEY([Espectaculo_Rubro])
REFERENCES [PMD].[Rubro] ([Rubro_ID])

ALTER TABLE [PMD].[Espectaculo] CHECK CONSTRAINT [FK_Espectaculo_Rubro]

ALTER TABLE [PMD].[Func_Rol]  WITH NOCHECK ADD  CONSTRAINT [FK_Func_Rol_Funcionalidad] FOREIGN KEY([Func_ID])
REFERENCES [PMD].[Funcionalidad] ([Func_ID])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [PMD].[Func_Rol] NOCHECK CONSTRAINT [FK_Func_Rol_Funcionalidad]

ALTER TABLE [PMD].[Func_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Func_Rol_Rol] FOREIGN KEY([Rol_ID])
REFERENCES [PMD].[Rol] ([Rol_ID])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [PMD].[Func_Rol] CHECK CONSTRAINT [FK_Func_Rol_Rol]

END
GO
BEGIN /*MIGRACION DE DATOS MAESTRA -> MODELO*/

/*CARGA DE ROLES*/
INSERT INTO PMD.Rol VALUES ('EMP', 'Empresa', 1), ('ADM', 'Administrativo', 1), ('CLI', 'Cliente', 1)
	   
/*CARGA DE FUNCIONALIDADES*/
--DBCC CHECKIDENT ('GD2C2018.PMD.Funcionalidad', RESEED, 0)
INSERT INTO PMD.Funcionalidad(Func_Descripcion)
VALUES ('ABM de Rol'), ('ABM de Clientes'), ('ABM de Empresa de Espectáculos'),
	   ('ABM de Rubro'), ('ABM Grado de Publicación'), ('Generar publicación'),
	   ('Editar publicación'), ('Comprar'), ('Historial de cliente'),
	   ('Canje y administración de puntos'), ('Generar rendición de comisiones'),
	   ('Listado Estadistico')

/*SE RELACIONAN LOS ROLES CON SUS FUNCIONALIDADES (many to many)*/
INSERT INTO PMD.Func_Rol(Rol_ID, Func_ID)
VALUES ('EMP', 6), ('EMP', 7), --funcs de empresa
	   ('CLI', 8), ('CLI', 9), ('CLI', 10), --funcs de cliente
	   ('ADM', 1), ('ADM', 2), ('ADM', 3), ('ADM', 4), ('ADM', 5),
	   ('ADM', 7), ('ADM', 11), ('ADM', 12) --funcs de admin	

/*GRADOS DE PUBLICACION PREEXISTENTES*/
INSERT INTO PMD.Grado_Publicacion(Grado_Nombre, Grado_Comision)
VALUES ('Bajo', 10), ('Medio', 30), ('Alto', 50)

/*CARGAR CLIENTES EXISTENTES*/
INSERT INTO PMD.Cliente (Cli_Tipo_Doc, Cli_Nro_Doc, Cli_Apellido, Cli_Nombre, Cli_Fecha_Nac, Cli_Mail, 
Cli_Dom_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto, Cli_Cod_Postal)
SELECT 'DNI', Cli_Dni, Cli_Apeliido, Cli_Nombre, Cli_Fecha_Nac, Cli_Mail,
Cli_Dom_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto, Cli_Cod_Postal  
FROM gd_esquema.Maestra WHERE Cli_Dni IS NOT NULL 
GROUP BY Cli_Dni, Cli_Apeliido, Cli_Nombre, Cli_Fecha_Nac, Cli_Mail,
Cli_Dom_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto, Cli_Cod_Postal 

/*CARGAR EMPRESAS EXISTENTES*/
INSERT INTO PMD.Espec_Empresa(Espec_Empresa_Cuit, Espec_Empresa_Razon_Social, 
Espec_Empresa_Fecha_Creacion, Espec_Empresa_Mail, Espec_Empresa_Dom_Calle, 
Espec_Empresa_Nro_Calle, Espec_Empresa_Piso, Espec_Empresa_Depto, Espec_Empresa_Cod_Postal)
SELECT Espec_Empresa_Cuit, Espec_Empresa_Razon_Social, 
Espec_Empresa_Fecha_Creacion, Espec_Empresa_Mail, Espec_Empresa_Dom_Calle, 
Espec_Empresa_Nro_Calle, Espec_Empresa_Piso, Espec_Empresa_Depto, Espec_Empresa_Cod_Postal
FROM gd_esquema.Maestra WHERE Espec_Empresa_Cuit IS NOT NULL 
GROUP BY Espec_Empresa_Cuit, Espec_Empresa_Razon_Social, 
Espec_Empresa_Fecha_Creacion, Espec_Empresa_Mail, Espec_Empresa_Dom_Calle, 
Espec_Empresa_Nro_Calle, Espec_Empresa_Piso, Espec_Empresa_Depto, Espec_Empresa_Cod_Postal
	
/*CARGAR ESTADOS DE PUBLICACION*/
--DBCC CHECKIDENT ('GD2C2018.PMD.Estado', RESEED, 0)
INSERT INTO PMD.Estado (Estado_Descripcion)
VALUES ('Borrador'), ('Publicada'), ('Finalizada')

/*CARGAR RUBROS DE ESPECTACULOS*/
--hay una opcion vacia ya que el dataset inicial tiene todos los espectaculos con este tipo de rubro
--DBCC CHECKIDENT ('GD2C2018.PMD.Rubro', RESEED, 0)
INSERT INTO PMD.Rubro (Rubro_Descripcion)
VALUES (''), ('Opera'), ('Drama'), ('Comedia'), ('Musical')

/*CARGAR ESPECTACULOS*/
INSERT INTO PMD.Espectaculo(Espectaculo_Cod, Espectaculo_Descripcion, 
Espectaculo_Fecha, Espectaculo_Fecha_Venc, Espectaculo_Rubro)
SELECT Espectaculo_Cod, Espectaculo_Descripcion, 
Espectaculo_Fecha, Espectaculo_Fecha_Venc, Rubro_ID
FROM gd_esquema.Maestra
JOIN PMD.Rubro ON Espectaculo_Rubro_Descripcion = Rubro_Descripcion
GROUP BY Espectaculo_Cod, Espectaculo_Descripcion, 
Espectaculo_Fecha, Espectaculo_Fecha_Venc, Rubro_ID

/*CARGAR PUBLICACIONES*/
--DBCC CHECKIDENT ('GD2C2018.PMD.Publicacion', RESEED, 0)
INSERT INTO PMD.Publicacion(Publicacion_Empresa, Publicacion_Espectaculo,
Publicacion_Fecha, Publicacion_Estado)
SELECT Espec_Empresa_Cuit, Espectaculo_Cod, Espectaculo_Fecha, Estado_ID 
FROM gd_esquema.Maestra JOIN PMD.Estado ON Espectaculo_Estado = Estado_Descripcion
GROUP BY Espec_Empresa_Cuit, Espectaculo_Cod, Espectaculo_Fecha, Estado_ID
	
/*FORMAS DE PAGO*/
--DBCC CHECKIDENT ('GD2C2018.PMD.Forma_Pago', RESEED, 0)
INSERT INTO PMD.Forma_Pago
VALUES ('Efectivo'), ('Debito'), ('Credito'), ('Cheque')

/*CARGAR COMPRAS*/
--DBCC CHECKIDENT ('GD2C2018.PMD.Compra', RESEED, 0)
INSERT INTO PMD.Compra(Compra_Cliente, Compra_Fecha, Compra_Forma_Pago, Compra_Cantidad)
SELECT Cli_Dni, Compra_Fecha, f.Forma_Pago_ID, Compra_Cantidad 
FROM gd_esquema.Maestra m JOIN PMD.Forma_Pago f ON m.Forma_Pago_Desc = f.Forma_Pago_Desc
GROUP BY Cli_Dni, Compra_Fecha, Forma_Pago_ID, Compra_Cantidad 

/*TIPOS DE UBICACION*/
INSERT INTO PMD.Tipo_Ubicacion(Tipo_Ubicacion_Codigo, Tipo_Ubicacion_Descripcion)
SELECT Ubicacion_Tipo_Codigo, Ubicacion_Tipo_Descripcion 
FROM gd_esquema.Maestra
GROUP BY Ubicacion_Tipo_Codigo, Ubicacion_Tipo_Descripcion 

/*UBICACION*/
INSERT INTO PMD.Ubicacion(Ubicacion_Publicacion, Ubicacion_Fila, 
Ubicacion_Asiento, Ubicacion_Sin_numerar, Ubicacion_Precio, Ubicacion_Tipo,
Ubicacion_Compra)
SELECT Publicacion_ID, Ubicacion_Fila, Ubicacion_Asiento, Ubicacion_Sin_numerar,
Ubicacion_Precio, Tipo_Ubicacion_Codigo, MAX(c.Compra_ID)
FROM gd_esquema.Maestra m
JOIN PMD.Publicacion ON Espectaculo_Cod = Publicacion_Espectaculo
JOIN PMD.Tipo_Ubicacion ON Ubicacion_Tipo_Codigo = Tipo_Ubicacion_Codigo
LEFT JOIN PMD.Compra c ON c.Compra_Fecha = m.Compra_Fecha AND c.Compra_Cliente = m.Cli_Dni
--no tengo formar de joinear esto.. ?
GROUP BY Publicacion_ID, Ubicacion_Fila, Ubicacion_Asiento, Ubicacion_Sin_numerar,
Ubicacion_Precio, Tipo_Ubicacion_Codigo

/*CARGAR FACTURAS*/
INSERT INTO PMD.Factura(Factura_Nro, Factura_Fecha, Factura_Total, Factura_Publicacion)
SELECT Factura_Nro, Factura_Fecha, Factura_Total, Publicacion_ID
FROM gd_esquema.Maestra JOIN PMD.Publicacion ON Publicacion_Espectaculo = Espectaculo_Cod
WHERE Factura_Nro IS NOT NULL
GROUP BY Factura_Nro, Factura_Fecha, Factura_Total, Publicacion_ID

/*CARGAR ITEMS FACTURAS*/
--DBCC CHECKIDENT ('GD2C2018.PMD.Item_Factura', RESEED, 0)
INSERT INTO PMD.Item_Factura(Item_Factura_Factura, Item_Factura_Descripcion, Item_Factura_Cantidad, 
Item_Factura_Monto, Item_Factura_Importe_Comision, Item_Factura_Compra)
SELECT Factura_Nro, Item_Factura_Descripcion, Item_Factura_Cantidad, Item_Factura_Monto,
0, Compra_ID
FROM gd_esquema.Maestra m
JOIN PMD.Compra c ON c.Compra_Fecha = m.Compra_Fecha AND c.Compra_Cliente = m.Cli_Dni
WHERE Factura_Nro IS NOT NULL
GROUP BY Factura_Nro, Item_Factura_Descripcion, Item_Factura_Cantidad,
Item_Factura_Monto, Compra_ID

END
GO
BEGIN /*CREACION DE USUARIO ADMIN Y ROL*/

INSERT INTO PMD.Rol VALUES ('GOD', 'Administrador General', 1);
DECLARE @funcionalidad int = 1;
WHILE @funcionalidad <= 12 --existen 12 funcionalidades
BEGIN
	INSERT INTO PMD.Func_Rol VALUES ('GOD', @funcionalidad);
	SET @funcionalidad += 1
END

DECLARE @password VARBINARY(MAX) = HASHBYTES('SHA2_256','w23e')
INSERT INTO PMD.Usuario VALUES ('admin', @password, 0, 'GOD');

DECLARE @pw VARBINARY(MAX) = HASHBYTES('SHA2_256','1234')
INSERT INTO PMD.Usuario VALUES('brunito', @pw, 0, 'ADM');

DECLARE @pw2 VARBINARY(MAX) = HASHBYTES('SHA2_256','cubito')
INSERT INTO PMD.Usuario VALUES('rolito', @pw2, 0, 'EMP');
INSERT INTO PMD.Espec_Empresa(Espec_Empresa_Razon_Social, Espec_Empresa_Cuit, Espec_Empresa_Mail, Espec_Empresa_Usuario)
VALUES ('Rolito S.A', '27-232323366-1', 'roli@gmail.com', 'rolito')

DECLARE @pw3 VARBINARY(MAX) = HASHBYTES('SHA2_256', 'pepito')
INSERT INTO PMD.Usuario VALUES('pepito', @pw3, 0, 'CLI');
INSERT INTO PMD.Cliente(Cli_Tipo_Doc, Cli_Nro_Doc, Cli_Nombre, Cli_Apellido, Cli_Usuario)
VALUES ('DNI', '40241706', 'pepito', 'perez', 'pepito')

END