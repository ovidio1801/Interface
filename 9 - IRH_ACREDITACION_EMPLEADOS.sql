USE [RRHH]
GO

/****** Object:  View [dbo].[IRH_ACREDITACION_EMPLEADOS]    Script Date: 07/29/2021 11:11:31 a.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[IRH_ACREDITACION_EMPLEADOS]
AS
SELECT        ROW_NUMBER() over(order by ca_fec_pago) as acredId, dbo.PS_CA_ROL_ACRED_EMPL.*
FROM            dbo.PS_CA_ROL_ACRED_EMPL

