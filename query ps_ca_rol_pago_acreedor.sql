/****** Script for SelectTopNRows command from SSMS  ******/
SELECT  [empresa]
      ,[oficina]
      ,[codigo]
      ,[fecha_registro]
      ,[moneda]
      ,[formulario]
      ,[cheque]
      ,[monto]
      ,[formato]
      ,[credito]
      ,[debito]
      ,[comentario]
      ,[usuario]
      ,[nombre]
      ,[forma_pago]
      ,[status]
      ,[fecha_impresion]
      ,[fecha_proceso]
      ,[tipo_acreedor]
  FROM [RRHH].[dbo].[PS_CA_ROL_PAGO_ACREEDOR]
where usuario like '%ovidio%'


--delete FROM [RRHH].[dbo].[PS_CA_ROL_PAGO_ACREEDOR]
--where usuario like '%ovidio%'


/****** Script for SelectTopNRows command from SSMS  ******/
SELECT  *
  FROM [RRHH].[dbo].[PS_CA_ROL_PAGO_ACREEDOR]
where usuario like '%ovidio%' and tipo_acreedor = 'AS'


SELECT  *
  FROM [RRHH].[dbo].[PS_CA_ROL_PAGO_ACREEDOR]
where [status] = 'P'


