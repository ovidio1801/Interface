USE [RRHH]
GO
/****** Object:  StoredProcedure [dbo].[USP_CA_ROL_PAGO_ACREEDOR]    Script Date: 08/04/2021 16:36:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[USP_CA_ROL_PAGO_ACREEDOR] @opcion int, @usuario varchar(20)

AS
BEGIN
DECLARE @DTS VARCHAR(200)
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	--CREATE USER user1 FOR LOGIN anelb
	--GRANT IMPERSONATE ON USER::  INTERFACE TO anelb

	--EXECUTE AS LOGIN = 'INTERFACE' -- Cambia al Usuario Autorizado para ejecutar el proceso
	
	IF @opcion = 0
	BEGIN 
		INSERT dbo.PS_CA_ROL_PAGO_ACREEDOR
		SELECT 
		 CA_EMPRESA,
		 CA_OFICINA,
		 RECIPIENT_ID,
		 DATE_POSTED,
		 CA_MONEDA,
		 CA_FORMATO,		 		 
		 CA_CHEQUE,
		 CA_MONTO,
		 CA_FORMULARIO,		 		 
		 CA_CREDITO,
		 CA_DEBITO,
		 CA_COMENTARIO,
		 CA_USUARIO,
		 DESCRFORMAL AS NOMBRE,
		 CA_FORMA_PAGO,'P',NULL,NULL,TYPE_1
		FROM PPS..PS_CA_ROL_PAGO_ACREEDOR A -- ORACLE..SYSADM.PS_CA_ROL_PAGO_ACR A
 	WHERE  NOT EXISTS (SELECT 1 FROM dbo.PS_CA_ROL_PAGO_ACREEDOR B
 	                          WHERE A.CA_EMPRESA = B.empresa
		                        AND A.CA_OFICINA = B.oficina
		                        AND A.RECIPIENT_ID = B.CODIGO
		                        AND A.CA_MONTO = B.monto
		                        AND convert(datetime,A.DATE_POSTED) = convert(datetime,B.fecha_registro))
		                        and convert(datetime,A.DATE_POSTED) <> '2019-12-17 00:00:00'
	END 
	Else
	BEGIN
--EXEC xp_cmdshell 'dtexec /f "d:\DTS\PAGO_ACREEDOR\PAGO_ACREEDOR\DESCUENTO.dtsx" /conf "d:\DTS\PAGO_ACREEDOR\PAGO_ACREEDOR\Config.dtsConfig" '	
 
		SET @DTS = '/SET "\Package.Variables[User::USUARIO].Properties[Value]";"'+@usuario+'" >D:\DTS\PAGO_ACREEDOR\Log_acre.txt'
		SET @DTS = 'dtexec /f "d:\DTS\PAGO_ACREEDOR\PAGO_ACREEDOR\DESCUENTO.dtsx" '+@DTS	

		--EXEC xp_cmdshell @DTS
		--/SET \package\DataFlowTask.Variables[User::USUARIO].Value;@usuario
	END
	--REVERT --Cambia a Usuario de origen 
--	DROP USER user1
END
