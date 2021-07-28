USE [TEST_CONTA]
GO

/****** Object:  View [dbo].[IRH_PERIODOS_SECUENCIA]    Script Date: 07/22/2021 12:08:55 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[IRH_PERIODOS_SECUENCIA]
AS
SELECT        ROW_NUMBER() over(order by cod_ejer, cod_per) as persecId, cod_empresa, cod_contab, cod_comp, cod_ejer, cod_per, cod_geografico, seq_comp, dcod_comp_camb, dnum_ejer_camb, dnum_per_camb, ccod_comp_camb, 
                         cnum_ejer_camb, cnum_per_camb, dcod_comp_conv, dnum_ejer_conv, dnum_per_conv, ccod_comp_conv, cnum_ejer_conv, cnum_per_conv
FROM            dbo.CN_SEQPER
GO
