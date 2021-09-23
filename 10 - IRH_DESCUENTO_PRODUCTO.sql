
USE [RRHH]
GO

drop view [IRH_DESCUENTO_PRODUCTO]
go

/****** Object:  View [dbo].[IRH_DESCUENTO_PRODUCTO]    Script Date: 08/06/2021 08:30:12 a.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[IRH_DESCUENTO_PRODUCTO]
AS
SELECT        ROW_NUMBER() over(order by ca_estatus) as prodId,
convert(date,cast(ca_aino_proc as char(4)) + '-' + cast(ca_mes_proc as char(2)) + '-' + cast(ca_dia_proc as char(2))) as fecha,*
FROM            dbo.PS_CA_ROL_DESCUEN_PROD
GO


