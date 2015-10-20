USE [Sistema]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 20/10/2015 11:36:30 a.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Clientes](
	[idcliente] [int] NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[domicilio] [varchar](50) NULL,
	[localidad] [varchar](50) NULL,
	[cuil] [varchar](11) NULL,
	[telpart] [varchar](50) NULL,
	[telcel] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[observa] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


