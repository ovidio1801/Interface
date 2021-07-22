USE [TEST_CONTA]
GO

/****** Object:  View [dbo].[IRH_PERIODOS]    Script Date: 07/22/2021 11:51:29 a.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[IRH_PERIODOS]
AS
SELECT        ROW_NUMBER() over(order by b.cod_ejer, c.cod_per) as periodoId, B.seq_comp, C.seq_comp AS Expr1, B.cod_ejer, C.cod_per
FROM            dbo.CN_SEQEJER AS B INNER JOIN
                         dbo.CN_SEQPER AS C ON B.cod_ejer = C.cod_ejer AND B.cod_comp = C.cod_comp
WHERE        (B.cod_comp = '01')

