USE [RRHH]
GO
/****** Object:  StoredProcedure [dbo].[USP_CA_ASIENTO]    Script Date: 08/04/2021 16:26:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[USP_CA_ASIENTO] @opcion int, @usuario varchar(20)

AS
BEGIN
DECLARE @DTS VARCHAR(200)
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
	IF @opcion = 0
	BEGIN 
	
	
		INSERT dbo.PS_CA_ROL_CN_ASIENTOS
		SELECT	
	    '01',--CA_EMPRESA,
	    CA_COD_GEOGRAFICO,
	    CA_COD_CONTAB,
	    '01',--CA_COD_COMP1,
	    CA_ANIO_TRANS,
	    CA_COD_PER,
	    CA_NUM_COMP_EJE,
	    CA_NUM_COMP_PER,
	    CA_COD_EMPL,
	    CA_FEC_ASIENTO,
	    CA_NOM_BENEF,
	    CA_REF_BENEF,
	    CA_CONCEPTO,
	    CA_STATUS_ASI,
	    CA_COD_MODULO,
	    CA_COD_MONEDA,
	    CA_COD_VALIDA,
	    CA_OBSERV,
	    CA_FEC_CONTB,
	    CA_TP_ASIENTO,
	    CA_MON_ORIGEN,
	    CA_COMP_EXT,'N',CAL_RUN_ID
		FROM PPS..PS_CA_ROL_CN_ASIENTOS A  --ORACLE..SYSADM.PS_CA_ROL_CN_ASIEN A 
 	WHERE NOT EXISTS(SELECT 1 FROM dbo.PS_CA_ROL_CN_ASIENTOS B
 	                          WHERE '01' = B.CA_EMPRESA
 	                            AND A.CA_COD_GEOGRAFICO = B.CA_COD_GEOGRAFICO
 	                            AND A.CA_COD_CONTAB = B.CA_COD_CONTAB
 	                            AND '01' = B.CA_COD_COMP1
 	                            AND A.CA_ANIO_TRANS = B.CA_ANIO_TRANS
 	                            AND A.CA_COD_PER = B.CA_COD_PER 	                           
 	                         --   AND A.CA_COD_EMPL = B.CA_COD_EMPL
 	                            AND A.CA_FEC_ASIENTO = B.CA_FEC_ASIENTO
 	                            AND A.CAL_RUN_ID = B.CAL_RUN_ID )
 	                            
		INSERT dbo.PS_CA_ROL_CN_MOVIM 
		SELECT '01',CA_COD_GEOGRAFICO,CA_COD_CONTAB,'01',CA_ANIO_TRANS,CA_COD_PER,CA_NUM_COMP_EJE,CA_NUM_COMP_PER,ROW_NUMBER() OVER(ORDER BY CA_COD_SEC_MOV DESC) AS CA_COD_SEC_MOV,CA_COD_UGEO,CA_PCTJE,SUBSTRING(CA_CTR_COSTO1,1,3),CA_COD_MONEDA,CA_COD_CTA,CA_CRD_LOCAL,CA_DEB_LOCAL,CA_CRD_DOLAR,CA_DEB_DOLAR,CA_CRD_OTRA,CA_DEB_OTRA,CA_FEC_CONTB,CA_COMMENT,CA_DEBCRE,CAL_RUN_ID
	  FROM PPS..PS_CA_ROL_CN_MOVIM A --ORACLE..SYSADM.PS_CA_ROL_CN_MOVIM A
		 WHERE NOT EXISTS ( SELECT 1 FROM dbo.PS_CA_ROL_CN_MOVIM  B
		                     WHERE '01' = B.CA_EMPRESA
		                        AND A.CA_COD_GEOGRAFICO = B.CA_COD_GEOGRAFICO
 	                            AND A.CA_COD_CONTAB = B.CA_COD_CONTAB
 	                            AND '01' = B.CA_COD_COMP1
 	                            AND A.CA_ANIO_TRANS = B.CA_ANIO_TRANS
 	                           -- AND A.CA_COD_PER = B.CA_COD_PER
 	                            --AND A.CA_COD_SEC_MOV = B.CA_COD_SEC_MOV
 	                            AND A.CAL_RUN_ID = B.CAL_RUN_ID 
 	                            	  )
 	and A.CA_FEC_CONTB > dateadd(day,-10,GETDATE()) 
 	                            
	END 
	Else
	BEGIN
--EXEC xp_cmdshell 'dtexec /f "d:\DTS\PAGO_ACREEDOR\PAGO_ACREEDOR\DESCUENTO.dtsx" /conf "d:\DTS\PAGO_ACREEDOR\PAGO_ACREEDOR\Config.dtsConfig" '	
 
		--SET @DTS = '/SET "\Package.Variables[User::USUARIO].Properties[Value]";"'+@usuario+'"'

		SET @DTS = 'dtexec /f "D:\DTS\ASIENTO_CONTABLE\ASIENTO_CONTABLE\ASIENTO_CONTABLE.dtsx" >D:\DTS\ASIENTO_CONTABLE\Log.txt'

		--EXEC xp_cmdshell @DTS
		
		--/SET \package\DataFlowTask.Variables[User::USUARIO].Value;@usuario
	END
END

		  