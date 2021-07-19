USE [RRHH]
GO

/****** Object:  Table [dbo].[PS_CA_ROL_PAGO_ACREEDOR]    Script Date: 06/08/2021 02:21:11 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PS_CA_ROL_PAGO_ACREEDOR](
	[empresa] [char](2) NOT NULL,
	[oficina] [char](3) NOT NULL,
	[codigo] [varchar](8) NOT NULL,
	[fecha_registro] [datetime] NOT NULL,
	[moneda] [char](3) NULL,
	[formulario] [char](1) NULL,
	[cheque] [varchar](20) NULL,
	[monto] [numeric](18, 2) NOT NULL,
	[formato] [char](1) NULL,
	[credito] [varchar](20) NULL,
	[debito] [varchar](20) NULL,
	[comentario] [varchar](50) NULL,
	[usuario] [varchar](20) NULL,
	[nombre] [varchar](50) NOT NULL,
	[forma_pago] [char](3) NULL,
	[status] [char](1) NULL,
	[fecha_impresion] [datetime] NULL,
	[fecha_proceso] [datetime] NULL,
	[tipo_acreedor] [varchar](3) NULL,
 CONSTRAINT [PK_PS_CA_ROL_PAGO_ACREEDOR] PRIMARY KEY CLUSTERED 
(
	[empresa] ASC,
	[oficina] ASC,
	[codigo] ASC,
	[fecha_registro] ASC,
	[monto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


