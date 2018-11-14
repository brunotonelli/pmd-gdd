USE GD2C2018
GO
if OBJECT_ID('CargarClientes', 'P') IS NOT NULL
DROP PROCEDURE CargarClientes
GO
if OBJECT_ID('CargarEmpresas', 'P') IS NOT NULL
DROP PROCEDURE CargarEmpresas
GO
if OBJECT_ID('CargarEstados', 'P') IS NOT NULL
DROP PROCEDURE CargarEstados
GO
if OBJECT_ID('CargarFormasPago', 'P') IS NOT NULL
DROP PROCEDURE CargarFormasPago
GO
if OBJECT_ID('CargarRubros', 'P') IS NOT NULL
DROP PROCEDURE CargarRubros
GO
if OBJECT_ID('CargarEspectaculos', 'P') IS NOT NULL
DROP PROCEDURE CargarEspectaculos
GO
if OBJECT_ID('CargarPublicaciones', 'P') IS NOT NULL
DROP PROCEDURE CargarPublicaciones
GO
if OBJECT_ID('CargarCompras', 'P') IS NOT NULL
DROP PROCEDURE CargarCompras
GO
if OBJECT_ID('CargarTiposUbicacion', 'P') IS NOT NULL
DROP PROCEDURE CargarTiposUbicacion
GO
if OBJECT_ID('CargarUbicaciones', 'P') IS NOT NULL
DROP PROCEDURE CargarUbicaciones
GO
if OBJECT_ID('CargarFacturas', 'P') IS NOT NULL
DROP PROCEDURE CargarFacturas
GO
if OBJECT_ID('CargarItemsFacturas', 'P') IS NOT NULL
DROP PROCEDURE CargarItemsFacturas
GO
DELETE FROM PMD.Cliente PRINT 'Clientes borrados'
DELETE FROM PMD.Publicacion PRINT 'Publicaciones borradas'
DELETE FROM PMD.Espectaculo PRINT 'Espectaculos borrados'
DELETE FROM PMD.Ubicacion PRINT 'Ubicaciones borradas'
DELETE FROM PMD.Tipo_Ubicacion PRINT 'Tipos de ubicacion borrados'
DELETE FROM PMD.Espec_Empresa PRINT 'Empresas borradas'
DELETE FROM PMD.Rubro PRINT 'Rubros borrados'
DELETE FROM PMD.Estado PRINT 'Estados borrados'
DELETE FROM PMD.Compra PRINT 'Compras borradas'
DELETE FROM PMD.Forma_Pago PRINT 'Formas de pago borradas'
DELETE FROM PMD.Item_Factura PRINT 'Items Facturas borrados'
DELETE FROM PMD.Factura PRINT 'Facturas borradas'
DELETE FROM PMD.Grado_Publicacion PRINT 'Grados borrados'

GO

INSERT INTO PMD.Grado_Publicacion(Grado_Nombre, Grado_Comision)
VALUES ('Bajo', 10), ('Medio', 30), ('Alto', 50)

GO

CREATE PROCEDURE CargarClientes
AS
BEGIN
	INSERT INTO PMD.Cliente (Cli_Dni, Cli_Apellido, Cli_Nombre, Cli_Fecha_Nac, Cli_Mail, 
							 Cli_Dom_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto, Cli_Cod_Postal)
	SELECT Cli_Dni, Cli_Apeliido, Cli_Nombre, Cli_Fecha_Nac, Cli_Mail,
	   Cli_Dom_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto, Cli_Cod_Postal  
	FROM gd_esquema.Maestra WHERE Cli_Dni IS NOT NULL 
	GROUP BY Cli_Dni, Cli_Apeliido, Cli_Nombre, Cli_Fecha_Nac, Cli_Mail,
	   Cli_Dom_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto, Cli_Cod_Postal  

	PRINT 'Clientes cargados'
END
GO

CREATE PROCEDURE CargarEmpresas
AS
BEGIN
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
	
	PRINT 'Empresas cargadas'
END
GO

CREATE PROCEDURE CargarEstados
AS
BEGIN
	DBCC CHECKIDENT ('GD2C2018.PMD.Estado', RESEED, 0)
	INSERT INTO PMD.Estado (Estado_Descripcion)
	VALUES ('Borrador'), ('Publicada'), ('Finalizada')
END
GO

CREATE PROCEDURE CargarRubros
AS
BEGIN
	DBCC CHECKIDENT ('GD2C2018.PMD.Rubro', RESEED, 0)
	INSERT INTO PMD.Rubro (Rubro_Descripcion)
	VALUES (''), ('Opera'), ('Drama'), ('Comedia'), ('Musical')

	PRINT 'Rubros cargados'
END
GO

CREATE PROCEDURE CargarEspectaculos
AS
BEGIN
	INSERT INTO PMD.Espectaculo(Espectaculo_Cod, Espectaculo_Descripcion, 
	Espectaculo_Fecha, Espectaculo_Fecha_Venc, Espectaculo_Rubro)
	SELECT Espectaculo_Cod, Espectaculo_Descripcion, 
	Espectaculo_Fecha, Espectaculo_Fecha_Venc, Rubro_ID
	FROM gd_esquema.Maestra
	JOIN PMD.Rubro ON Espectaculo_Rubro_Descripcion = Rubro_Descripcion
	GROUP BY Espectaculo_Cod, Espectaculo_Descripcion, 
	Espectaculo_Fecha, Espectaculo_Fecha_Venc, Rubro_ID

	PRINT 'Espectaculos cargados'
END
GO

CREATE PROCEDURE CargarPublicaciones --los eventos cargados tienen una publicacion por ahora
AS
BEGIN
	DBCC CHECKIDENT ('GD2C2018.PMD.Publicacion', RESEED, 0)

	INSERT INTO PMD.Publicacion(Publicacion_Empresa, Publicacion_Espectaculo,
	Publicacion_Fecha, Publicacion_Estado)
	SELECT Espec_Empresa_Cuit, Espectaculo_Cod, Espectaculo_Fecha, Estado_ID 
	FROM gd_esquema.Maestra JOIN PMD.Estado ON Espectaculo_Estado = Estado_Descripcion
	GROUP BY Espec_Empresa_Cuit, Espectaculo_Cod, Espectaculo_Fecha, Estado_ID
	
	PRINT 'Publicaciones cargadas'
END
GO

CREATE PROCEDURE CargarFormasPago
AS
BEGIN
	DBCC CHECKIDENT ('GD2C2018.PMD.Forma_Pago', RESEED, 0)

	INSERT INTO PMD.Forma_Pago
	VALUES ('Efectivo'), ('Debito'), ('Credito'), ('Cheque')

	PRINT 'Formas de pago cargadas'
END
GO

CREATE PROCEDURE CargarCompras
AS
BEGIN
	DBCC CHECKIDENT ('GD2C2018.PMD.Compra', RESEED, 0)

	INSERT INTO PMD.Compra(Compra_Cliente, Compra_Fecha, Compra_Forma_Pago, Compra_Cantidad)
	SELECT Cli_Dni, Compra_Fecha, f.Forma_Pago_ID, Compra_Cantidad 
	FROM gd_esquema.Maestra m JOIN PMD.Forma_Pago f ON m.Forma_Pago_Desc = f.Forma_Pago_Desc
	GROUP BY Cli_Dni, Compra_Fecha, Forma_Pago_ID, Compra_Cantidad 
	
	PRINT 'Compras cargadas'
END
GO

CREATE PROCEDURE CargarTiposUbicacion
AS
BEGIN
	INSERT INTO PMD.Tipo_Ubicacion(Tipo_Ubicacion_Codigo, Tipo_Ubicacion_Descripcion)
	SELECT Ubicacion_Tipo_Codigo, Ubicacion_Tipo_Descripcion 
	FROM gd_esquema.Maestra
	GROUP BY Ubicacion_Tipo_Codigo, Ubicacion_Tipo_Descripcion 

	PRINT 'Tipos de ubicaciones cargadas'
END
GO

CREATE PROCEDURE CargarUbicaciones
AS
BEGIN
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

	PRINT 'Ubicaciones cargadas'
END
GO

CREATE PROCEDURE CargarFacturas
AS
BEGIN
	INSERT INTO PMD.Factura(Factura_Nro, Factura_Fecha, Factura_Total, Factura_Publicacion)
	SELECT Factura_Nro, Factura_Fecha, Factura_Total, Publicacion_ID
	FROM gd_esquema.Maestra JOIN PMD.Publicacion ON Publicacion_Espectaculo = Espectaculo_Cod
	WHERE Factura_Nro IS NOT NULL
	GROUP BY Factura_Nro, Factura_Fecha, Factura_Total, Publicacion_ID
	
	PRINT 'Facturas cargadas'
END
GO

CREATE PROCEDURE CargarItemsFacturas
AS 
BEGIN
	DBCC CHECKIDENT ('GD2C2018.PMD.Item_Factura', RESEED, 0)

	INSERT INTO PMD.Item_Factura(Item_Factura_Factura, Item_Factura_Descripcion, Item_Factura_Cantidad, 
	Item_Factura_Monto, Item_Factura_Importe_Comision, Item_Factura_Compra)
	SELECT Factura_Nro, Item_Factura_Descripcion, Item_Factura_Cantidad, Item_Factura_Monto,
	0, Compra_ID
	FROM gd_esquema.Maestra m
	JOIN PMD.Compra c ON c.Compra_Fecha = m.Compra_Fecha AND c.Compra_Cliente = m.Cli_Dni
	WHERE Factura_Nro IS NOT NULL
	GROUP BY Factura_Nro, Item_Factura_Descripcion, Item_Factura_Cantidad,
	Item_Factura_Monto, Compra_ID

	PRINT 'Items factura cargados'
END
GO

EXEC CargarClientes
EXEC CargarEmpresas
EXEC CargarEstados
EXEC CargarRubros
EXEC CargarEspectaculos
EXEC CargarPublicaciones
EXEC CargarFormasPago
EXEC CargarCompras
EXEC CargarTiposUbicacion
EXEC CargarUbicaciones
EXEC CargarFacturas
EXEC CargarItemsFacturas
GO