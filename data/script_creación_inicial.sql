USE [GD2C2018]

--Se usan BEGINs para que puedan minimizar las secciones como si fuera un region de C#

BEGIN /*BORRADO DE SCHEMA/TABLAS POR SI EXISTEN*/
IF OBJECT_ID('PMD.Rol_X_Usuario', 'U') IS NOT NULL DROP TABLE PMD.Rol_X_Usuario
IF OBJECT_ID('PMD.Func_Rol', 'U') IS NOT NULL DROP TABLE PMD.Func_Rol
IF OBJECT_ID('PMD.Premio_X_Cliente', 'U') IS NOT NULL DROP TABLE PMD.Premio_X_Cliente
IF OBJECT_ID('PMD.Espec_Empresa', 'U') IS NOT NULL DROP TABLE PMD.Espec_Empresa
IF OBJECT_ID('PMD.Funcionalidad', 'U') IS NOT NULL DROP TABLE PMD.Funcionalidad
IF OBJECT_ID('PMD.Item_Factura', 'U') IS NOT NULL DROP TABLE PMD.Item_Factura
IF OBJECT_ID('PMD.Premio', 'U') IS NOT NULL DROP TABLE PMD.Premio
IF OBJECT_ID('PMD.Puntos', 'U') IS NOT NULL DROP TABLE PMD.Puntos
IF OBJECT_ID('PMD.Rol', 'U') IS NOT NULL DROP TABLE PMD.Rol
IF OBJECT_ID('PMD.Ubicacion', 'U') IS NOT NULL DROP TABLE PMD.Ubicacion
IF OBJECT_ID('PMD.Compra', 'U') IS NOT NULL DROP TABLE PMD.Compra
IF OBJECT_ID('PMD.Cliente', 'U') IS NOT NULL DROP TABLE PMD.Cliente 
IF OBJECT_ID('PMD.Usuario', 'U') IS NOT NULL DROP TABLE PMD.Usuario
IF OBJECT_ID('PMD.Factura', 'U') IS NOT NULL DROP TABLE PMD.Factura
IF OBJECT_ID('PMD.Publicacion', 'U') IS NOT NULL DROP TABLE PMD.Publicacion
IF OBJECT_ID('PMD.Espectaculo', 'U') IS NOT NULL DROP TABLE PMD.Espectaculo 
IF OBJECT_ID('PMD.Estado', 'U') IS NOT NULL DROP TABLE PMD.Estado
IF OBJECT_ID('PMD.Rubro', 'U') IS NOT NULL DROP TABLE PMD.Rubro
IF OBJECT_ID('PMD.Grado_Publicacion', 'U') IS NOT NULL DROP TABLE PMD.Grado_Publicacion
IF OBJECT_ID('PMD.ComprasNegativas', 'TR') IS NOT NULL DROP TRIGGER PMD.ComprasNegativas
IF OBJECT_ID('PMD.FinalizarPublicaciones', 'TR') IS NOT NULL DROP TRIGGER PMD.FinalizarPublicaciones
IF OBJECT_ID('PMD.VerificarRol', 'TR') IS NOT NULL DROP TRIGGER PMD.VerificarRol
IF OBJECT_ID('PMD.VerificarFechas', 'TR') IS NOT NULL DROP TRIGGER PMD.VerificarFechas
IF OBJECT_ID('PMD.VerificarEstado', 'TR') IS NOT NULL DROP TRIGGER PMD.VerificarEstado
IF OBJECT_ID('PMD.GenerarBorradores', 'P') IS NOT NULL DROP PROCEDURE PMD.GenerarBorradores
IF EXISTS (SELECT name FROM sysobjects WHERE name='UbicacionesLibres' AND type in ( N'FN', N'IF', N'TF', N'FS', N'FT' ))
DROP FUNCTION PMD.UbicacionesLibres
IF EXISTS (SELECT name FROM sysobjects WHERE name='localidadesVendidas' AND type in ( N'FN', N'IF', N'TF', N'FS', N'FT' ))
DROP FUNCTION PMD.localidadesVendidas
IF EXISTS (SELECT name FROM sysobjects WHERE name='localidadesTotales' AND type in ( N'FN', N'IF', N'TF', N'FS', N'FT' ))
DROP FUNCTION PMD.localidadesTotales
IF EXISTS (SELECT * FROM sys.schemas WHERE name = 'PMD') DROP SCHEMA PMD
END

GO

CREATE SCHEMA [PMD]

GO

BEGIN /*CREADO DE TABLAS*/

CREATE TABLE [PMD].[Cliente](
	[Cli_Nro_Doc] [numeric](10, 0) NOT NULL,
	[Cli_Tipo_Doc] [nvarchar](40) NOT NULL,
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
	[Cli_Habilitado] [bit] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Cli_Nro_Doc] ASC,
	[Cli_Tipo_Doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Compra]    Script Date: 09/12/2018 2:18:51 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Compra](
	[Compra_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Compra_Fecha] [datetime] NOT NULL,
	[Compra_Cantidad] [numeric](18, 0) NOT NULL,
	[Compra_Forma_Pago] [nvarchar](255) NOT NULL,
	[Compra_Tipo_Doc_Cliente] [nvarchar](40) NOT NULL,
	[Compra_Num_Doc_Cliente] [numeric](10, 0) NOT NULL,
	[Compra_Total] [numeric](18, 2) NOT NULL,
	[Compra_Publicacion] [numeric](18, 0) NOT NULL,
	[Compra_Facturada] [bit] NOT NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[Compra_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Espec_Empresa]    Script Date: 09/12/2018 2:18:52 ******/
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
	[Espec_Empresa_Habilitado] [bit] NULL,
 CONSTRAINT [PK_Espec_Empresa_1] PRIMARY KEY CLUSTERED 
(
	[Espec_Empresa_Cuit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Espec_Empresa_Cuit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Espec_Empresa_Razon_Social] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Espectaculo]    Script Date: 09/12/2018 2:18:52 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Espectaculo](
	[Espectaculo_Cod] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Espectaculo_Descripcion] [nvarchar](255) NULL,
	[Espectaculo_Rubro] [int] NULL,
	[Espectaculo_Direccion] [nvarchar](255) NULL,
 CONSTRAINT [PK_Espectaculo] PRIMARY KEY CLUSTERED 
(
	[Espectaculo_Cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Estado]    Script Date: 09/12/2018 2:18:52 ******/
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

/****** Object:  Table [PMD].[Factura]    Script Date: 09/12/2018 2:18:52 ******/
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

/****** Object:  Table [PMD].[Func_Rol]    Script Date: 09/12/2018 2:18:52 ******/
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

/****** Object:  Table [PMD].[Funcionalidad]    Script Date: 09/12/2018 2:18:52 ******/
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

/****** Object:  Table [PMD].[Grado_Publicacion]    Script Date: 09/12/2018 2:18:52 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Grado_Publicacion](
	[Grado_ID] [int] IDENTITY(1,1) NOT NULL,
	[Grado_Nombre] [nvarchar](50) NULL,
	[Grado_Comision] [numeric](10, 4) NULL,
	[Grado_Habilitado] [bit] NULL,
 CONSTRAINT [PK_Grado_Publicacion] PRIMARY KEY CLUSTERED 
(
	[Grado_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Item_Factura]    Script Date: 09/12/2018 2:18:52 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Item_Factura](
	[Item_Factura_ID] [int] IDENTITY(1,1) NOT NULL,
	[Item_Factura_Factura] [numeric](18, 0) NOT NULL,
	[Item_Factura_Monto] [numeric](18, 2) NOT NULL,
	[Item_Factura_Cantidad] [numeric](18, 0) NULL,
	[Item_Factura_Descripcion] [nvarchar](60) NULL,
	[Item_Factura_Compra] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Item_Factura_1] PRIMARY KEY CLUSTERED 
(
	[Item_Factura_ID] ASC,
	[Item_Factura_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Premio]    Script Date: 09/12/2018 2:18:52 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Premio](
	[Premio_ID] [int] IDENTITY(1,1) NOT NULL,
	[Premio_Nombre] [nchar](100) NULL,
	[Premio_Descripcion] [nvarchar](255) NULL,
	[Premio_Puntos_Necesarios] [int] NULL,
	[Premio_Imagen] [nvarchar](255) NULL,
 CONSTRAINT [PK_Premio] PRIMARY KEY CLUSTERED 
(
	[Premio_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Premio_X_Cliente]    Script Date: 09/12/2018 2:18:52 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Premio_X_Cliente](
	[Pre_Cli_Tipo_Doc] [nvarchar](40) NOT NULL,
	[Pre_Cli_Nro_Doc] [numeric](10, 0) NOT NULL,
	[Pre_Premio_ID] [int] NOT NULL,
	[Pre_Cli_Canje_ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Premio_X_Cliente] PRIMARY KEY CLUSTERED 
(
	[Pre_Cli_Tipo_Doc] ASC,
	[Pre_Cli_Nro_Doc] ASC,
	[Pre_Premio_ID] ASC,
	[Pre_Cli_Canje_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Publicacion]    Script Date: 09/12/2018 2:18:52 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Publicacion](
	[Publicacion_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Publicacion_Espectaculo] [numeric](18, 0) NOT NULL,
	[Publicacion_Fecha] [datetime] NOT NULL,
	[Publicacion_Localidades] [int] NULL,
	[Publicacion_Grado] [int] NULL,
	[Publicacion_Empresa] [nvarchar](128) NOT NULL,
	[Publicacion_Estado] [int] NOT NULL,
	[Publicacion_Fecha_Espectaculo] [datetime] NOT NULL,
 CONSTRAINT [PK_Publicacion] PRIMARY KEY CLUSTERED 
(
	[Publicacion_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Puntos]    Script Date: 09/12/2018 2:18:52 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Puntos](
	[Puntos_ID] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Puntos_Cantidad] [int] NOT NULL,
	[Puntos_Vencimiento] [datetime] NOT NULL,
	[Puntos_Tipo_Doc_Cliente] [nvarchar](40) NOT NULL,
	[Puntos_Num_Doc_Cliente] [numeric](10, 0) NOT NULL,
 CONSTRAINT [PK_Puntos] PRIMARY KEY CLUSTERED 
(
	[Puntos_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Rol]    Script Date: 09/12/2018 2:18:52 ******/
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

/****** Object:  Table [PMD].[Rol_X_Usuario]    Script Date: 09/12/2018 2:18:52 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Rol_X_Usuario](
	[Usuario_Username] [nvarchar](255) NOT NULL,
	[Rol_ID] [char](3) NOT NULL,
 CONSTRAINT [PK_Rol_X_Usuario_1] PRIMARY KEY CLUSTERED 
(
	[Usuario_Username] ASC,
	[Rol_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Rubro]    Script Date: 09/12/2018 2:18:52 ******/
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

/****** Object:  Table [PMD].[Ubicacion]    Script Date: 09/12/2018 2:18:52 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Ubicacion](
	[Ubicacion_Publicacion] [numeric](18, 0) NOT NULL,
	[Ubicacion_Fila] [varchar](3) NOT NULL,
	[Ubicacion_Asiento] [numeric](18, 0) NOT NULL,
	[Ubicacion_Sin_numerar] [bit] NULL,
	[Ubicacion_Precio] [numeric](18, 2) NOT NULL,
	[Ubicacion_Tipo] [nvarchar](255) NOT NULL,
	[Ubicacion_Compra] [numeric](18, 0) NULL,
	[Ubicacion_Disponible] [bit] NOT NULL,
 CONSTRAINT [PK_Ubicacion_1] PRIMARY KEY CLUSTERED 
(
	[Ubicacion_Fila] ASC,
	[Ubicacion_Asiento] ASC,
	[Ubicacion_Publicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [PMD].[Usuario]    Script Date: 09/12/2018 2:18:52 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [PMD].[Usuario](
	[Usuario_Username] [nvarchar](255) NOT NULL,
	[Usuario_Password] [binary](64) NULL,
	[Usuario_Intentos_Fallidos] [int] NULL,
	[Usuario_Habilitado] [bit] NULL,
	[Usuario_Autogenerado] [bit] NULL,
	[Usuario_Inicios] [int] NOT NULL,
 CONSTRAINT [PK_Usuario_1] PRIMARY KEY CLUSTERED 
(
	[Usuario_Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [PMD].[Cliente] ADD  CONSTRAINT [DF_Cliente_Cli_Habilitado]  DEFAULT ((1)) FOR [Cli_Habilitado]

ALTER TABLE [PMD].[Espec_Empresa] ADD  CONSTRAINT [DF_Espec_Empresa_Espec_Empresa_Habilitado]  DEFAULT ((1)) FOR [Espec_Empresa_Habilitado]

ALTER TABLE [PMD].[Grado_Publicacion] ADD  CONSTRAINT [DF_Grado_Publicacion_Grado_Habilitado]  DEFAULT ((1)) FOR [Grado_Habilitado]

ALTER TABLE [PMD].[Rol] ADD  CONSTRAINT [DF_Rol_Rol_Habilitado]  DEFAULT ((1)) FOR [Rol_Habilitado]

ALTER TABLE [PMD].[Usuario] ADD  CONSTRAINT [DF_Usuario_Usuario_Intentos_Fallidos]  DEFAULT ((0)) FOR [Usuario_Intentos_Fallidos]

ALTER TABLE [PMD].[Usuario] ADD  CONSTRAINT [DF_Usuario_Usuario_Habilitado]  DEFAULT ((1)) FOR [Usuario_Habilitado]

ALTER TABLE [PMD].[Usuario] ADD  CONSTRAINT [DF_Usuario_Usuario_Inicios]  DEFAULT ((0)) FOR [Usuario_Inicios]

ALTER TABLE [PMD].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Usuario] FOREIGN KEY([Cli_Usuario])
REFERENCES [PMD].[Usuario] ([Usuario_Username])

ALTER TABLE [PMD].[Cliente] CHECK CONSTRAINT [FK_Cliente_Usuario]

ALTER TABLE [PMD].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Cliente] FOREIGN KEY([Compra_Num_Doc_Cliente], [Compra_Tipo_Doc_Cliente])
REFERENCES [PMD].[Cliente] ([Cli_Nro_Doc], [Cli_Tipo_Doc])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [PMD].[Compra] CHECK CONSTRAINT [FK_Compra_Cliente]

ALTER TABLE [PMD].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Publicacion] FOREIGN KEY([Compra_Publicacion])
REFERENCES [PMD].[Publicacion] ([Publicacion_ID])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [PMD].[Compra] CHECK CONSTRAINT [FK_Compra_Publicacion]

ALTER TABLE [PMD].[Espec_Empresa]  WITH CHECK ADD  CONSTRAINT [FK_Espec_Empresa_Usuario] FOREIGN KEY([Espec_Empresa_Usuario])
REFERENCES [PMD].[Usuario] ([Usuario_Username])

ALTER TABLE [PMD].[Espec_Empresa] CHECK CONSTRAINT [FK_Espec_Empresa_Usuario]

ALTER TABLE [PMD].[Espectaculo]  WITH CHECK ADD  CONSTRAINT [FK_Espectaculo_Rubro] FOREIGN KEY([Espectaculo_Rubro])
REFERENCES [PMD].[Rubro] ([Rubro_ID])

ALTER TABLE [PMD].[Espectaculo] CHECK CONSTRAINT [FK_Espectaculo_Rubro]

ALTER TABLE [PMD].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Publicacion] FOREIGN KEY([Factura_Publicacion])
REFERENCES [PMD].[Publicacion] ([Publicacion_ID])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [PMD].[Factura] CHECK CONSTRAINT [FK_Factura_Publicacion]

ALTER TABLE [PMD].[Func_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Func_Rol_Funcionalidad] FOREIGN KEY([Func_ID])
REFERENCES [PMD].[Funcionalidad] ([Func_ID])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [PMD].[Func_Rol] CHECK CONSTRAINT [FK_Func_Rol_Funcionalidad]

ALTER TABLE [PMD].[Func_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Func_Rol_Rol] FOREIGN KEY([Rol_ID])
REFERENCES [PMD].[Rol] ([Rol_ID])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [PMD].[Func_Rol] CHECK CONSTRAINT [FK_Func_Rol_Rol]

ALTER TABLE [PMD].[Item_Factura]  WITH CHECK ADD  CONSTRAINT [FK_Item_Factura_Factura] FOREIGN KEY([Item_Factura_Factura])
REFERENCES [PMD].[Factura] ([Factura_Nro])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [PMD].[Item_Factura] CHECK CONSTRAINT [FK_Item_Factura_Factura]

ALTER TABLE [PMD].[Item_Factura]  WITH CHECK ADD  CONSTRAINT [FK_Item_Factura_Compra] FOREIGN KEY([Item_Factura_Compra])
REFERENCES [PMD].[Compra] ([Compra_ID])

ALTER TABLE [PMD].[Item_Factura] CHECK CONSTRAINT [FK_Item_Factura_Compra]

ALTER TABLE [PMD].[Premio_X_Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Premio_X_Cliente_Cliente] FOREIGN KEY([Pre_Cli_Nro_Doc], [Pre_Cli_Tipo_Doc])
REFERENCES [PMD].[Cliente] ([Cli_Nro_Doc], [Cli_Tipo_Doc])

ALTER TABLE [PMD].[Premio_X_Cliente] CHECK CONSTRAINT [FK_Premio_X_Cliente_Cliente]

ALTER TABLE [PMD].[Premio_X_Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Premio_X_Cliente_Premio] FOREIGN KEY([Pre_Premio_ID])
REFERENCES [PMD].[Premio] ([Premio_ID])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [PMD].[Premio_X_Cliente] CHECK CONSTRAINT [FK_Premio_X_Cliente_Premio]

ALTER TABLE [PMD].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Espectaculo] FOREIGN KEY([Publicacion_Espectaculo])
REFERENCES [PMD].[Espectaculo] ([Espectaculo_Cod])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [PMD].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Espectaculo]

ALTER TABLE [PMD].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Estado] FOREIGN KEY([Publicacion_Estado])
REFERENCES [PMD].[Estado] ([Estado_ID])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [PMD].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Estado]

ALTER TABLE [PMD].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Grado] FOREIGN KEY([Publicacion_Grado])
REFERENCES [PMD].[Grado_Publicacion] ([Grado_ID])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [PMD].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Grado]

ALTER TABLE [PMD].[Puntos]  WITH CHECK ADD  CONSTRAINT [FK_Puntos_Cliente] FOREIGN KEY([Puntos_Num_Doc_Cliente], [Puntos_Tipo_Doc_Cliente])
REFERENCES [PMD].[Cliente] ([Cli_Nro_Doc], [Cli_Tipo_Doc])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [PMD].[Puntos] CHECK CONSTRAINT [FK_Puntos_Cliente]

ALTER TABLE [PMD].[Rol_X_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Rol_X_Usuario_Rol] FOREIGN KEY([Rol_ID])
REFERENCES [PMD].[Rol] ([Rol_ID])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [PMD].[Rol_X_Usuario] CHECK CONSTRAINT [FK_Rol_X_Usuario_Rol]

ALTER TABLE [PMD].[Rol_X_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Rol_X_Usuario_Usuario] FOREIGN KEY([Usuario_Username])
REFERENCES [PMD].[Usuario] ([Usuario_Username])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [PMD].[Rol_X_Usuario] CHECK CONSTRAINT [FK_Rol_X_Usuario_Usuario]

ALTER TABLE [PMD].[Ubicacion]  WITH CHECK ADD  CONSTRAINT [FK_Ubicacion_Compra] FOREIGN KEY([Ubicacion_Compra])
REFERENCES [PMD].[Compra] ([Compra_ID])

ALTER TABLE [PMD].[Ubicacion] CHECK CONSTRAINT [FK_Ubicacion_Compra]

ALTER TABLE [PMD].[Ubicacion]  WITH CHECK ADD  CONSTRAINT [FK_Ubicacion_Publicacion] FOREIGN KEY([Ubicacion_Publicacion])
REFERENCES [PMD].[Publicacion] ([Publicacion_ID])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [PMD].[Ubicacion] CHECK CONSTRAINT [FK_Ubicacion_Publicacion]

END

GO

/*función que, dada una empresa, un año y un trimestre, me devuelve la 
cantidad de ubicaciones que vendió en ese periodo.*/
CREATE FUNCTION PMD.localidadesVendidas(@idEmpresa nvarchar(128),@ano int,@trimestre int)
RETURNS INT 
BEGIN
	DECLARE @Entradas INT 
	SELECT @Entradas=ISNULL(SUM(cm.Compra_Cantidad),0)
	FROM  PMD.Publicacion pl JOIN PMD.Compra cm ON (pl.Publicacion_ID=cm.Compra_Publicacion)
	WHERE pl.Publicacion_Empresa=@idEmpresa AND @ano=YEAR(pl.Publicacion_Fecha) AND 
	DATEPART(QUARTER, pl.Publicacion_Fecha)=@trimestre
	
	RETURN @Entradas
END

GO

/*función similar a la anterior, devuelve el total de entradas que esa empresa tenía en ese periodo.*/
CREATE FUNCTION PMD.localidadesTotales(@idEmpresa nvarchar(128),@ano int,@trimestre int)
RETURNS INT 
BEGIN
	DECLARE @Entradas INT 
	SELECT @Entradas=ISNULL(SUM(p.Publicacion_Localidades),0) 
	FROM PMD.Publicacion p 
	WHERE p.Publicacion_Empresa=@idEmpresa AND @ano=YEAR(p.Publicacion_Fecha) AND 
	DATEPART(QUARTER, p.Publicacion_Fecha)=@trimestre
	RETURN @Entradas
END

GO

/*trigger que, al realizarse compras, verifica que no sean negativas (su total). 
Caso contrario, se elimina la compra.*/
CREATE TRIGGER PMD.ComprasNegativas ON PMD.Compra AFTER UPDATE, INSERT
AS
BEGIN
	DECLARE compras CURSOR FOR
	SELECT Compra_ID, Compra_Total FROM inserted
	DECLARE @compra numeric(18, 0), @monto numeric(18, 2)
	OPEN compras
	FETCH NEXT FROM compras INTO @compra, @monto
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF @monto < 0
		BEGIN
			DELETE FROM PMD.Compra
			WHERE Compra_ID = @compra		
		END
		FETCH NEXT FROM compras INTO @compra, @monto
	END
	CLOSE compras
	DEALLOCATE compras
END

GO

/*función que recibe una publicación y me devuelve la cantidad de asientos/ubicaciones
libres*/
CREATE FUNCTION PMD.UbicacionesLibres(@publicacion numeric(18, 0))
RETURNS INT 
AS
BEGIN 
	DECLARE @totales int, @ocupadas int
	SELECT @totales = Publicacion_Localidades, @ocupadas = COUNT(*) FROM PMD.Publicacion
	JOIN PMD.Ubicacion ON Ubicacion_Disponible = 0 AND Ubicacion_Publicacion = Publicacion_ID
	WHERE Publicacion_ID = 63
	GROUP BY Publicacion_Localidades
	RETURN @totales - @ocupadas
END

GO

/*trigger que, luego de realizada una compra, verifica la cantidad restante de
ubicaciones disponibles en esa publicación. Si la cantidad es 0, se pasa a 
estado Finalizada esa publicación.*/
CREATE TRIGGER PMD.FinalizarPublicaciones ON PMD.Compra AFTER INSERT, UPDATE
AS 
BEGIN
	DECLARE publicaciones CURSOR FOR
	SELECT Compra_Publicacion FROM inserted
	DECLARE @publicacion numeric(18, 0)
	OPEN publicaciones
	FETCH NEXT FROM publicaciones INTO @publicacion
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF PMD.UbicacionesLibres(@publicacion) <= 0
		BEGIN
			UPDATE PMD.Publicacion
			SET Publicacion_Estado = 3 --finalizada
			WHERE Publicacion_ID = @publicacion
		END
		FETCH NEXT FROM publicaciones INTO @publicacion
	END
	CLOSE publicaciones
	DEALLOCATE publicaciones
END
GO

/*trigger para no poder asignarle rol deshabilitado a usuario*/
CREATE TRIGGER PMD.VerificarRol ON PMD.Rol_X_Usuario FOR UPDATE, INSERT
AS
BEGIN
	DECLARE rolesXusuarios CURSOR FOR
	SELECT Rol_ID, Usuario_Username FROM inserted
	DECLARE @rol char(3), @usuario nvarchar(255), @habilitado bit
	OPEN rolesXusuarios
	FETCH NEXT FROM rolesXusuarios INTO @rol, @usuario
	WHILE @@FETCH_STATUS = 0
	BEGIN
		SELECT @habilitado = Rol_Habilitado FROM PMD.Rol WHERE Rol_ID = @rol
		IF @habilitado = 0
		BEGIN
			PRINT 'No puede asignar rol inhabilitado a usuario'
			DELETE FROM PMD.Rol_X_Usuario WHERE Rol_ID = @rol --le borro a todos los users el rol
		END
		FETCH NEXT FROM rolesXusuarios INTO @rol, @usuario
	END
	CLOSE rolesXusuarios
	DEALLOCATE rolesXusuarios
END
GO

/*trigger para que una public. finalizada no pueda cambiar estado*/
CREATE TRIGGER PMD.VerificarEstado ON PMD.Publicacion FOR UPDATE
AS
BEGIN
	DECLARE publis CURSOR FOR
	SELECT Publicacion_ID, Publicacion_Estado
	FROM inserted
	DECLARE @publi int, @estado int
	OPEN publis
	FETCH NEXT FROM publis INTO @publi, @estado
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF @estado = 3 --finalizada
		BEGIN
			PRINT 'La public. ya esta finalizada, no puede cambiar estado'
			DELETE FROM PMD.Publicacion WHERE Publicacion_ID = @publi
		END
		FETCH NEXT FROM publis INTO @publi, @estado
	END
	CLOSE publis
	DEALLOCATE publis
END
GO

/*trigger para que una public. no tenga fecha posterior a la del evento*/
CREATE TRIGGER PMD.VerificarFechas ON PMD.Publicacion FOR INSERT, UPDATE
AS
BEGIN
	DECLARE publis CURSOR FOR
	SELECT Publicacion_ID, Publicacion_Fecha, Publicacion_Fecha_Espectaculo
	FROM inserted
	DECLARE @publi int, @fecha smalldatetime, @fecha_final smalldatetime
	OPEN publis
	FETCH NEXT FROM publis INTO @publi, @fecha, @fecha_final
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF @fecha > @fecha_final
		BEGIN
			PRINT 'Error de fechas ingresadas'
			DELETE FROM PMD.Publicacion WHERE Publicacion_ID = @publi
		END
		FETCH NEXT FROM publis INTO @publi, @fecha, @fecha_final
	END
	CLOSE publis
	DEALLOCATE publis
END
GO

/*procedure para cargar publicaciones en estado borrador, y sus ubicaciones,
para poder testear la funcionalidad Editar Publicacion ya que ninguna esta en borrador*/
CREATE PROCEDURE PMD.GenerarBorradores
AS
BEGIN
	INSERT INTO PMD.Publicacion(Publicacion_Grado, Publicacion_Espectaculo,
	 Publicacion_Empresa, Publicacion_Estado, Publicacion_Fecha, 
	 Publicacion_Fecha_Espectaculo)
	 VALUES (1, 12370, '19-67139304-09', 1, '2017-04-01', '2017-04-05'),
			(1, 12370, '11-78419949-35', 1, '2017-04-01', '2017-04-10'),
			(1, 12370, '19-96704728-16', 1, '2018-04-01', '2019-04-10')
	DECLARE borradores CURSOR FOR SELECT Publicacion_ID FROM PMD.Publicacion WHERE Publicacion_Estado = 1
	DECLARE @id int
	OPEN borradores
	FETCH NEXT FROM borradores INTO @id
	WHILE @@FETCH_STATUS = 0
	BEGIN
		INSERT INTO PMD.Ubicacion(Ubicacion_Tipo, Ubicacion_Fila, Ubicacion_Asiento, Ubicacion_Sin_numerar, 
								Ubicacion_Disponible, Ubicacion_Precio, Ubicacion_Publicacion)
		VALUES('Campo', 'A', 1, 1, 1, 100, @id),
			 ('Campo', 'B', 1, 1, 1, 100, @id), 
			 ('Campo', 'C', 1, 1, 1, 100, @id)
		FETCH NEXT FROM borradores INTO @id
	END
	CLOSE borradores
	DEALLOCATE borradores
END

GO

/*MIGRACION DE DATOS MAESTRA -> MODELO*/


/*CARGA DE ROLES*/
INSERT INTO PMD.Rol VALUES ('EMP', 'Empresa', 1), ('ADM', 'Administrativo', 1), ('CLI', 'Cliente', 1)
	   

/*CARGA DE FUNCIONALIDADES*/
/*EL ID es autoincrement, no se asigna.
se cargan las 12 funcionalidades (las que faltan son generales
para todo el que entre al sistema, no tiene sentido ponerlas como registros)*/
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
--EL BAJO ES EL QUE VIENE DEFAULT EN TODOS
--Se asumió el 10% por los valores de precio_ubicacion y item_factura total, que da 10%
INSERT INTO PMD.Grado_Publicacion(Grado_Nombre, Grado_Comision)
VALUES ('Bajo', 10), ('Medio', 30), ('Alto', 50)


/*CARGAR CLIENTES EXISTENTES*/
--se les asignó el tipo dni por default, ya que no existe campo "tipo".
--se sabe que es dni porque el campo se llama Cli_Dni igual
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
--id es autoincrement, se cargan los estados mencionados en enunciado
INSERT INTO PMD.Estado (Estado_Descripcion)
VALUES ('Borrador'), ('Publicada'), ('Finalizada')


/*CARGAR RUBROS DE ESPECTACULOS*/
--hay una opcion vacia ya que el dataset inicial tiene todos los espectaculos con este tipo de rubro
--a esa opcion se les asigna "N/A" para que no quede un estado vacio que queda horrible
INSERT INTO PMD.Rubro (Rubro_Descripcion)
VALUES ('N/A'), ('Opera'), ('Drama'), ('Comedia'), ('Musical')


/*CARGAR ESPECTACULOS*/
--la direccion del espectaculo se asume es la de la empresa, para la migracion al menos
SET IDENTITY_INSERT PMD.Espectaculo ON
INSERT INTO PMD.Espectaculo(Espectaculo_Cod, Espectaculo_Descripcion, Espectaculo_Rubro, Espectaculo_Direccion)
SELECT Espectaculo_Cod, Espectaculo_Descripcion, 1, CONCAT(Espec_Empresa_Dom_Calle, ' ', Espec_Empresa_Nro_Calle)
FROM gd_esquema.Maestra
GROUP BY Espectaculo_Cod, Espectaculo_Descripcion, Espec_Empresa_Dom_Calle, Espec_Empresa_Nro_Calle
SET IDENTITY_INSERT PMD.Espectaculo OFF

/*CARGAR PUBLICACIONES*/
--por cada espectaculo de la maestra creo una publicacion por su fecha
/*IMPORTANTE: las fechas "vencimiento" son anteriores a la fecha de publicacion, 
no tiene sentido (o se eligio un nombre poco expresivo en Maestra), se invierte al migrar*/
INSERT INTO PMD.Publicacion(Publicacion_Empresa, Publicacion_Espectaculo,
Publicacion_Fecha, Publicacion_Fecha_Espectaculo, Publicacion_Estado, Publicacion_Grado)
SELECT Espec_Empresa_Cuit, Espectaculo_Cod, Espectaculo_Fecha_Venc, Espectaculo_Fecha, Estado_ID, 1 --grado bajo, es asi
FROM gd_esquema.Maestra JOIN PMD.Estado ON Espectaculo_Estado = Estado_Descripcion
GROUP BY Espec_Empresa_Cuit, Espectaculo_Cod, Espectaculo_Fecha, Estado_ID, Espectaculo_Fecha_Venc
	
/*CARGAR COMPRAS*/
INSERT INTO PMD.Compra(Compra_Publicacion, Compra_Num_Doc_Cliente, Compra_Tipo_Doc_Cliente,
Compra_Total, Compra_Fecha, Compra_Cantidad, Compra_Forma_Pago, Compra_Facturada)
SELECT Publicacion_ID, Cli_Dni, 'DNI', Ubicacion_Precio, Compra_Fecha, 
Item_Factura_Cantidad, Forma_Pago_Desc, 1
FROM gd_esquema.Maestra m
JOIN PMD.Publicacion ON Publicacion_Espectaculo = m.Espectaculo_Cod
WHERE Factura_Nro IS NOT NULL
GROUP BY Publicacion_ID, Cli_Dni, Ubicacion_Precio, Compra_Fecha, Item_Factura_Cantidad, Forma_Pago_Desc

/*UBICACION*/
--se usa el MAX en caso de que haya dos ubicaciones identicas (la misma) pero su compra sea NULL
--es decir se verfiica si esta disponible o no por el campo NULL
INSERT INTO PMD.Ubicacion(Ubicacion_Publicacion, Ubicacion_Fila, 
Ubicacion_Asiento, Ubicacion_Sin_numerar, Ubicacion_Precio, Ubicacion_Tipo,
Ubicacion_Compra, Ubicacion_Disponible)
SELECT Publicacion_ID, Ubicacion_Fila, Ubicacion_Asiento, Ubicacion_Sin_numerar,
Ubicacion_Precio, Ubicacion_Tipo_Descripcion, MAX(c.Compra_ID), (CASE WHEN MAX(c.Compra_ID) IS NULL THEN 1 ELSE 0 END)
FROM gd_esquema.Maestra m
JOIN PMD.Publicacion ON Espectaculo_Cod = Publicacion_Espectaculo
LEFT JOIN PMD.Compra c ON c.Compra_Fecha = m.Compra_Fecha AND c.Compra_Num_Doc_Cliente = m.Cli_Dni
AND c.Compra_Tipo_Doc_Cliente = 'DNI'
GROUP BY Publicacion_ID, Ubicacion_Fila, Ubicacion_Asiento, Ubicacion_Sin_numerar,
Ubicacion_Precio, Ubicacion_Tipo_Descripcion


/*CARGAR FACTURAS*/
INSERT INTO PMD.Factura(Factura_Nro, Factura_Fecha, Factura_Total, Factura_Publicacion)
SELECT Factura_Nro, Factura_Fecha, Factura_Total, Publicacion_ID
FROM gd_esquema.Maestra 
JOIN PMD.Publicacion ON Publicacion_Espectaculo = Espectaculo_Cod
JOIN PMD.Grado_Publicacion ON Publicacion_Grado = Grado_ID
WHERE Factura_Nro IS NOT NULL
GROUP BY Factura_Nro, Factura_Fecha, Factura_Total, Publicacion_ID

/*CARGAR ITEM_FACTURAS*/
INSERT INTO PMD.Item_Factura
SELECT Factura_Nro, Item_Factura_Monto, Item_Factura_Cantidad, Item_Factura_Descripcion, Compra_ID
FROM gd_esquema.Maestra m
JOIN PMD.Publicacion ON Publicacion_Espectaculo = Espectaculo_Cod
JOIN PMD.Compra ON 
Compra_Publicacion = Publicacion_ID
AND Compra_Num_Doc_Cliente = Cli_Dni
WHERE Factura_Nro IS NOT NULL
GROUP BY Factura_Nro, Item_Factura_Monto, Item_Factura_Cantidad, 
Item_Factura_Descripcion, Publicacion_ID, Compra_ID

/*CARGAR PUNTOS*/
--se asumió por cada compra, se generan puntos iguales al 35% del total de compra
--los puntos vencen en 6 meses a partir de la compra
INSERT INTO PMD.Puntos(Puntos_Tipo_Doc_Cliente, Puntos_Num_Doc_Cliente, Puntos_Cantidad, Puntos_Vencimiento)
SELECT Compra_Tipo_Doc_Cliente, Compra_Num_Doc_Cliente, Compra_Total * 0.35, DATEADD(month, 6, Compra_Fecha)
FROM PMD.Compra --POR CADA COMPRA SE GENERAN PUNTOS

GO

/*CARGA DE LOCALIDADES*/
/*esto se hace despues de cargar tanto publis como ubis, porque necesito saber la cantidad de ubicaciones
de esa publicacion, es una forma de no tener que calcularlo siempre y ya queda en el campo precalculado*/
UPDATE PMD.Publicacion
SET Publicacion_Localidades = (SELECT COUNT(*) FROM PMD.Ubicacion
WHERE Ubicacion_Publicacion = Publicacion_ID)


/*CREACION DE USUARIO ADMIN Y ROL*/
--se asumió que se necesita un nuevo rol: GOD con todas las funcs
--se podria haber pensado en simplemente crear un usuario con los 3 roles y listo
--pero así visualmente el GOD puede ver el menú completo en la aplicacion, y no tener
--que cerrar sesion cada vez que quiere hacer otra operacion
INSERT INTO PMD.Rol VALUES ('GOD', 'Administrador General', 1);
DECLARE @funcionalidad int = 1;
WHILE @funcionalidad <= 12 --existen 12 funcionalidades
BEGIN
	INSERT INTO PMD.Func_Rol VALUES ('GOD', @funcionalidad); --le asigno todas las funcionalidades
	SET @funcionalidad += 1
END
--para ese GOD, se necesitan 1 cliente y 1 empresa a su nombre, ya que las compras
--requieren un cliente, y las publicaciones una empresa, al ser generadas
DECLARE @password VARBINARY(MAX) = HASHBYTES('SHA2_256','w23e')
INSERT INTO PMD.Usuario VALUES ('admin', @password, 0, 1, 0, 0);
INSERT INTO PMD.Rol_X_Usuario 
VALUES ('admin', 'GOD'), ('admin', 'CLI'), ('admin', 'EMP'), ('admin', 'ADM')
INSERT INTO PMD.Cliente(Cli_Tipo_Doc, Cli_Nro_Doc, Cli_Nombre, Cli_Apellido, Cli_Usuario, Cli_Fecha_Nac, Cli_CUIL)
VALUES ('DNI', '12345678', 'Administrador', 'General', 'admin', '2017-04-01 00:00:00.000', '27-11111111-3')
INSERT INTO PMD.Espec_Empresa(Espec_Empresa_Razon_Social, Espec_Empresa_Cuit, Espec_Empresa_Mail, Espec_Empresa_Usuario)
VALUES ('Administrador General', '27-12345678-1', 'admin@gmail.com', 'admin')

/*A PARTIR DE ACA SE CREAN USUARIOS DE PRUEBA CON UN SOLO ROL (lo pueden borrar eso)*/
--usuario admin (normal, no general) de ejemplo
DECLARE @pw VARBINARY(MAX) = HASHBYTES('SHA2_256','1234')
INSERT INTO PMD.Usuario VALUES('brunito', @pw, 0, 1, 0, 0);
INSERT INTO PMD.Rol_X_Usuario 
VALUES ('brunito', 'ADM')

--usuario empresa de ejemplo
DECLARE @pw2 VARBINARY(MAX) = HASHBYTES('SHA2_256','empre1')
INSERT INTO PMD.Usuario VALUES('empre1', @pw2, 0, 1, 0, 0);
INSERT INTO PMD.Espec_Empresa(Espec_Empresa_Razon_Social, Espec_Empresa_Cuit, Espec_Empresa_Mail, Espec_Empresa_Usuario)
VALUES ('Rolito S.A', '27-23232336-1', 'rolitosa@gmail.com', 'empre1')
INSERT INTO PMD.Rol_X_Usuario 
VALUES ('empre1', 'EMP')

--usuario cliente de ejemplo
DECLARE @pw3 VARBINARY(MAX) = HASHBYTES('SHA2_256', 'pepito')
INSERT INTO PMD.Usuario VALUES('pepito', @pw3, 0, 1, 0, 0);
INSERT INTO PMD.Cliente(Cli_Tipo_Doc, Cli_Nro_Doc, Cli_Nombre, Cli_Apellido, Cli_Usuario, Cli_Fecha_Nac, Cli_CUIL)
VALUES ('DNI', '4525424', 'pepito', 'perez', 'pepito', '2017-04-01 00:00:00.000', '27-11111111-9')
INSERT INTO PMD.Rol_X_Usuario 
VALUES ('pepito', 'CLI')

/*PUBLICACIONES BORRADOR DE EJEMPLO*/
EXEC PMD.GenerarBorradores

/*COMPRAS NO FACTURADAS DE EJEMPLO*/
--para poder probar la funcionalidad "Generar rendicion de comisiones" es necesario
--tener compras que no fueron facturadas, asi el admin puede seleccionar las que desea
--generarles la factura
INSERT INTO PMD.Compra(Compra_Cantidad, Compra_Fecha, Compra_Forma_Pago, 
Compra_Num_Doc_Cliente, Compra_Tipo_Doc_Cliente, Compra_Total, Compra_Publicacion, Compra_Facturada)
VALUES 
(5, '2017-01-01 00:00:00.000', 'Efectivo', 1625043, 'DNI', 1503.30, 59, 0),
(1, '2017-02-01 00:00:00.000', 'Crédito', 1625043, 'DNI', 1027.00, 20, 0),
(2, '2017-03-01 00:00:00.000', 'Débito', 1360518, 'DNI', 90.63, 70, 0),
(10, '2017-04-01 00:00:00.000', 'Efectivo', 1360518, 'DNI', 4000.00, 122, 0),
(5, '2017-05-01 00:00:00.000', 'Efectivo', 3348591, 'DNI', 153.22, 50, 0),
(1, '2017-06-01 00:00:00.000', 'Efectivo', 3407370, 'DNI', 777.77, 52, 0),
(3, '2017-07-01 00:00:00.000', 'Efectivo', 5053260, 'DNI', 69.69, 322, 0)


/*PREMIOS*/
--aca se inventó que un premio requiere puntos, y tienen imagen tmb
--las imagenes son resources en el proyecto, antes se cargaban desde una URL web pero
--tardaba demasiado, asi que no agreguen premios porque la imagen no va a estar en el proyecto
INSERT INTO PMD.Premio(Premio_Nombre, Premio_Descripcion, Premio_Puntos_Necesarios, Premio_Imagen)
VALUES
('Parrilla Eléctrica portátil', 'Parrilla eléctrica transportable con tapa de vidrio desmontable y bandejas anti-adherentes y de goteo. Con termostato y control de temperatura ajustable.', 1000, 'brp740_grilla'),
('Salero o pimentero Gravity', 'Salero o pimentero Gravity.', 200, 'brq304_2'),
('Escalera 5 posiciones', 'Escalera de aluminio extensible de 5 posiciones.', 700, 'sc_escalera5posiciones_det_1'),
('Pop Corn Maker', 'Máquina para hacer pochoclos saludables con aire caliente, en lugar de aceite. Salen hasta 12 tazas por tanda de pochoclos. Marca: Nostalgia línea Coca-Cola®.', 800, 'brp760_grilla'),
('Ejercitador 20 en 1', 'Ejercitador 20 en 1 ideal para el ejercicio en casa. Disponible en color negro combinado con rojo.', 800, 'brp518_1'),
('Bolso con herramientas 58 piezas', 'Bolso con herramientas de 58 piezas. Disponible en color negro con rojo.', 750, '_mg_3896'),
('Funda de Edredón Percal + Edredón Twin', 'Excelente calidad: funda de edredón + edredón Campomar tamaño Twin.', 650, 'brh636'),
('Radio despertador con luz', 'Reloj despertador táctil con simulador de amanecer. Posee radio AM/Fm y display LED. Disponible en color blanco.', 400, 'sc_brq294_det_1'),
('Reproductor de música duo', 'Reproductor de música inalámbrico DUO. Bluetooth. Disponible en color negro.', 500, 'brp502_1'),
('Escalera Telescópica', 'Escalera telescópica de aluminio extensible de 7 escalones.', 700, 'brq306_1')

--ACA CARGO puntos de ejemplo para el administrador general
--para poder probar los premios, los puntos y el vencimiento
--no se especifica nada de la administracion de puntos, asumimos
--ver los vencidos y ver disponibles nada mas (en la app)
INSERT INTO PMD.Puntos(Puntos_Cantidad, Puntos_Num_Doc_Cliente, Puntos_Tipo_Doc_Cliente, Puntos_Vencimiento)
VALUES (5000, 12345678, 'DNI', '2030-01-01 00:00:00.000'), (1000, 12345678, 'DNI', '2010-01-01 00:00:00.000'),
	   (1500, 12345678, 'DNI', '2020-01-01 00:00:00.000')

--Corre en 11 segundos (depende la pc supongo)