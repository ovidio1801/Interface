USE [RRHH]
GO
/****** Object:  StoredProcedure [dbo].[USP_CA_ROL_DESCUENTO]    Script Date: 08/04/2021 16:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[USP_CA_ROL_DESCUENTO] @opcion int, @usuario varchar(20)

AS
BEGIN
DECLARE @DTS VARCHAR(200)
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	IF @opcion = 0
	BEGIN 
		INSERT dbo.PS_CA_ROL_DESCUEN_PROD
		SELECT	CA_AINO_PROC,
				CA_MES_PROC,
				CA_DIA_PROC,
				CA_AINO_VR,
				CA_MES_VR,
				CA_DIA_VALOR,
				CA_CTR_COSTO,
				CA_NUM_CUENTA,
				CA_MONTO_PAG,
				CA_USUARIO_A,CA_TP_PROD,'P',NULL,NAME,National_ID
		FROM PPS..PS_CA_ROL_DCTO_PROD A --ORACLE..SYSADM.PS_CA_ROL_DCTO_PRO A 
 	WHERE NOT EXISTS(SELECT 1 FROM dbo.PS_CA_ROL_DESCUEN_PROD B
 	                          WHERE A.CA_NUM_CUENTA = B.CA_NUM_CUENTA
 	                            AND A.CA_CTR_COSTO = B.CA_CTR_COSTO
 	                            AND A.CA_AINO_VR = B.CA_AINO_VR
 	                            AND A.CA_MES_VR = B.CA_MES_VR
 	                            AND A.CA_DIA_VALOR = B.CA_DIA_VALOR)
 	                            
 	                           
		INSERT dbo.PS_CA_ROL_DESCUEN_TC
		SELECT	CA_ID_CAJERO,
		        CA_MES_TRANS,
		        CA_DIA_TRANS,
		        CA_ANIO_TRANS,
		        CA_COD_TRANS,
		        CA_CONC_PAGO,
		        CA_NUM_TARJ,
		        CA_DIG_VERIF,
		        CA_MONTO_PAG,
		        CA_CTA_CONT,
		        CA_CTR_COSTO,
		        CA_ESTATUS
		FROM PPS..PS_CA_ROL_DESCUEN_TC A -- ORACLE..SYSADM.PS_CA_ROL_DESC_TC A 
 	WHERE NOT EXISTS(SELECT 1 FROM dbo.PS_CA_ROL_DESCUEN_TC B
 	                          WHERE A.CA_ID_CAJERO = B.CA_ID_CAJERO
 	                            AND A.CA_MES_TRANS = B.CA_MES_TRANS
 	                            AND A.CA_DIA_TRANS = B.CA_DIA_TRANS
 	                            AND A.CA_ANIO_TRANS = B.CA_ANIO_TRANS
 	                            AND A.CA_COD_TRANS = B.CA_COD_TRANS
 	                            AND A.CA_CONC_PAGO = B.CA_CONC_PAGO
 	                            AND A.CA_NUM_TARJ = B.CA_NUM_TARJ
 	                            ) 	                            
	END 
	Else
	BEGIN
--EXEC xp_cmdshell 'dtexec /f "d:\DTS\PAGO_ACREEDOR\PAGO_ACREEDOR\DESCUENTO.dtsx" /conf "d:\DTS\PAGO_ACREEDOR\PAGO_ACREEDOR\Config.dtsConfig" '	
 
		--SET @DTS = '/SET "\Package.Variables[User::USUARIO].Properties[Value]";"'+@usuario+'"'
		SET @DTS = 'dtexec /f "d:\DTS\PAGO_ACREEDOR\PAGO_ACREEDOR\PASE_IBS.dtsx" >D:\DTS\PAGO_ACREEDOR\Log.txt'	

		--EXEC xp_cmdshell @DTS
		--/SET \package\DataFlowTask.Variables[User::USUARIO].Value;@usuario
	END

END
