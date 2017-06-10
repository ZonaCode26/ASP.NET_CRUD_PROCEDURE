USE NEGOCIOS2017
GO

CREATE TABLE TB_PROVEEDOR
(
idprov int primary key,
nomprov varchar(100)
)
GO
CREATE TABLE TB_HERRAMIENTA
(
idHer char(7) primary key,
desHer varchar(100),
idprov int references TB_PROVEEDOR,
preUni decimal,
stock int 
)
GO

INSERT INTO TB_PROVEEDOR VALUES(1,'Comercial San Juan');

INSERT INTO TB_PROVEEDOR VALUES(2,'Industria Zamorra');

INSERT INTO TB_PROVEEDOR VALUES(3,'Jorge Ruiz');

INSERT INTO TB_PROVEEDOR VALUES(4,'Comercial Becerra');
GO


CREATE PROCEDURE USP_LISTAHERRAMIENTA
AS
SELECT * FROM TB_HERRAMIENTA
GO

CREATE PROCEDURE USP_LISTAPROVEEDOR
AS
SELECT * FROM TB_PROVEEDOR
GO

CREATE PROCEDURE USP_AGREGARHERRAMIENTA
@id as char(7),
@des as varchar(100),
@idp as int ,
@pre as decimal,
@stock as int 
AS
INSERT INTO TB_HERRAMIENTA VALUES(@id,@des,@idp,@pre,@stock)

GO


INSERT INTO TB_HERRAMIENTA VALUES('AAAAAAA','asdasfda',1,20,10)
go


CREATE PROCEDURE USP_ACTUALIZARHERRAMIENTA
@id as char(7),
@des as varchar(100),
@idp as int ,
@pre as decimal,
@stock as int 
AS
UPDATE TB_HERRAMIENTA
SET 
	desHer=@des,
	idprov=@idp,
	preUni=@pre,
	stock=@stock
WHERE 
	idHer=@id
GO


SELECT * FROM TB_PROVEEDOR
