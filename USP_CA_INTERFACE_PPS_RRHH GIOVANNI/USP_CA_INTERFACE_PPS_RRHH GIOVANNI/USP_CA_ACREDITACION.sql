USE [RRHH]
GO
/****** Object:  StoredProcedure [dbo].[USP_CA_ACREDITACION]    Script Date: 08/04/2021 16:16:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[USP_CA_ACREDITACION] @opcion int, @usuario varchar(20)

AS
BEGIN
DECLARE @DTS VARCHAR(200)
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	IF @opcion = 0
	BEGIN 
		
		INSERT dbo.PS_CA_ROL_ACRED_EMPL
		SELECT 99999,
		       CA_FEC_PAGO,
		       CA_MONTO_PG,
		       CA_CTA_ACRE,
		       CA_NUM_EMPL,
		       CA_TP_PAGO,
		       CA_ESTATUS,'',NULL,NULL,NULL,NULL,NULL,NULL
		FROM PPS..PS_CA_ROL_ACRED_EMPL A -- ORACLE..SYSADM.PS_CA_ROL_ACRED_EM A
		WHERE CA_TP_PAGO not like 'BE%'
		 AND NOT EXISTS (SELECT 1 FROM dbo.PS_CA_ROL_ACRED_EMPL B
								WHERE 99999 = B.CA_COD_COMP
								  AND B.CA_FEC_PAGO = A.CA_FEC_PAGO
								  AND B.CA_MONTO_PG = A.CA_MONTO_PG
								  AND B.CA_CTA_ACRE = A.CA_CTA_ACRE
								  AND B.CA_NUM_EMPL = A.CA_NUM_EMPL
								  AND B.CA_TP_PAGO = A.CA_TP_PAGO ) 
 	   and A.CA_FEC_PAGO > dateadd(day,-10,GETDATE())

 	   
	END 
	Else
	BEGIN
--EXEC xp_cmdshell 'dtexec /f "d:\DTS\PAGO_ACREEDOR\PAGO_ACREEDOR\DESCUENTO.dtsx" /conf "D:\DTS\ACREDITA_NOMIA\ACREDITA_NOMIA\DTSCONFIG.dtsConfig" '	
--SET @DTS = '/SET "\Package.VariablesUser::USUARIO.PropertiesValue";"'+@usuario+'"'

		SET @DTS = 'dtexec /f "D:\DTS\ACREDITA_NOMIA\ACREDITA_NOMIA\ACREDITA_NOMINA.dtsx" /conf "D:\DTS\ACREDITA_NOMIA\ACREDITA_NOMIA\DTSCONFIG.dtsConfig" >D:\DTS_PROD\ACREDITA_NOMIA\Log.txt'

		--EXEC xp_cmdshell @DTS
		--/SET \package\DataFlowTask.VariablesUser::USUARIO.Value;@usuario
		
	END
END



