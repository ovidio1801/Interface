USE [RRHH]
GO

/****** Object:  View [dbo].[IRH_DESCUENTO_TARJETA]    Script Date: 08/06/2021 09:02:08 a.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[IRH_DESCUENTO_TARJETA]
AS
 select ROW_NUMBER() over(order by ca_anio_trans, ca_mes_trans, ca_dia_trans) as tcId, 
 convert(date,cast(ca_anio_trans as char(4)) + '-' + cast(ca_mes_trans as char(2)) + '-' + cast(ca_dia_trans as char(2))) as fecha,*
 FROM [RRHH].[dbo].[PS_CA_ROL_DESCUEN_TC]
GO


