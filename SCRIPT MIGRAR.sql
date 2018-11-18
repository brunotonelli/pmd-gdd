USE GD2C2018

/*SE LIMPIA LA BD EN CASO DE QUE YA SE HAYA EJECUTADO SCRIPT*/
DELETE FROM PMD.Cliente
DELETE FROM PMD.Publicacion
DELETE FROM PMD.Espectaculo
DELETE FROM PMD.Ubicacion
DELETE FROM PMD.Tipo_Ubicacion
DELETE FROM PMD.Espec_Empresa
DELETE FROM PMD.Rubro
DELETE FROM PMD.Estado
DELETE FROM PMD.Compra
DELETE FROM PMD.Forma_Pago
DELETE FROM PMD.Item_Factura
DELETE FROM PMD.Factura
DELETE FROM PMD.Grado_Publicacion
DELETE FROM PMD.Func_Rol
DELETE FROM PMD.Rol
DELETE FROM PMD.Funcionalidad
DELETE FROM PMD.Usuario

/*CARGA DE ROLES*/
INSERT INTO PMD.Rol VALUES ('EMP', 'Empresa', 1), ('ADM', 'Administrativo', 1), ('CLI', 'Cliente', 1)
	   
/*CARGA DE FUNCIONALIDADES*/
DBCC CHECKIDENT ('GD2C2018.PMD.Funcionalidad', RESEED, 0)
INSERT INTO PMD.Funcionalidad(Func_Descripcion)
VALUES ('ABM de Rol'), ('ABM de Clientes'), ('ABM de Empresa de Espectáculos'),
	   ('ABM de Rubro'), ('ABM Grado de Publicación'), ('Generar publicación'),
	   ('Editar publicación'), ('Comprar'), ('Historial de cliente'),
	   ('Canje y administración de puntos'), ('Generar rendición de comisiones'),
	   ('Listado Estadistico')

/*SE RELACIONAN LOS ROLES CON SUS FUNCIONALIDADES (many to many)*/
INSERT INTO PMD.Func_Rol(Rol_ID, Func_ID)
VALUES ('EMP', 4), ('EMP', 5), ('EMP', 6), ('EMP', 7), --funcs de empresa
	   ('CLI', 8), ('CLI', 9), ('CLI', 10), --funcs de cliente
	   ('ADM', 1), ('ADM', 2), ('ADM', 3), ('ADM', 4), ('ADM', 5),
	   ('ADM', 7), ('ADM', 11), ('ADM', 12) --funcs de admin	

/*GRADOS DE PUBLICACION PREEXISTENTES*/
INSERT INTO PMD.Grado_Publicacion(Grado_Nombre, Grado_Comision)
VALUES ('Bajo', 10), ('Medio', 30), ('Alto', 50)

/*CARGAR CLIENTES EXISTENTES*/
INSERT INTO PMD.Cliente (Cli_Dni, Cli_Apellido, Cli_Nombre, Cli_Fecha_Nac, Cli_Mail, 
Cli_Dom_Calle, Cli_Nro_Calle, Cli_Piso, Cli_Depto, Cli_Cod_Postal)
SELECT Cli_Dni, Cli_Apeliido, Cli_Nombre, Cli_Fecha_Nac, Cli_Mail,
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
DBCC CHECKIDENT ('GD2C2018.PMD.Estado', RESEED, 0)
INSERT INTO PMD.Estado (Estado_Descripcion)
VALUES ('Borrador'), ('Publicada'), ('Finalizada')

/*CARGAR RUBROS DE ESPECTACULOS*/
--hay una opcion vacia ya que el dataset inicial tiene todos los espectaculos con este tipo de rubro
DBCC CHECKIDENT ('GD2C2018.PMD.Rubro', RESEED, 0)
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
DBCC CHECKIDENT ('GD2C2018.PMD.Publicacion', RESEED, 0)
INSERT INTO PMD.Publicacion(Publicacion_Empresa, Publicacion_Espectaculo,
Publicacion_Fecha, Publicacion_Estado)
SELECT Espec_Empresa_Cuit, Espectaculo_Cod, Espectaculo_Fecha, Estado_ID 
FROM gd_esquema.Maestra JOIN PMD.Estado ON Espectaculo_Estado = Estado_Descripcion
GROUP BY Espec_Empresa_Cuit, Espectaculo_Cod, Espectaculo_Fecha, Estado_ID
	
/*FORMAS DE PAGO*/
DBCC CHECKIDENT ('GD2C2018.PMD.Forma_Pago', RESEED, 0)
INSERT INTO PMD.Forma_Pago
VALUES ('Efectivo'), ('Debito'), ('Credito'), ('Cheque')

/*CARGAR COMPRAS*/
DBCC CHECKIDENT ('GD2C2018.PMD.Compra', RESEED, 0)
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

/*CARGA DE DATOS NECESARIOS PREVIO A EJECUCION SISTEMA*/

/*La aplicación deberá contar con un usuario de sistema ya creado y listo para ser
utilizado, con las siguientes características:
 Username: admin
 Password: w23e
 Rol:
o Nombre: Administrador General
o Funcionalidades: todas las existentes*/

/*desde sql server 2012 se usa SHA_512*/
--carga de rol con funcionalidades
INSERT INTO PMD.Rol VALUES ('GOD', 'Administrador General', 1);
DECLARE @funcionalidad int = 1;
WHILE @funcionalidad <= 12 --existen 12 funcionalidades
BEGIN
	INSERT INTO PMD.Func_Rol VALUES ('GOD', @funcionalidad);
	SET @funcionalidad += 1
END

--carga de usuario

DECLARE @password VARBINARY(MAX) = 'w23e'

--SHA256

--INSERT INTO PMD.Usuario VALUES ('admin', @encoded, 0, 'GOD');
