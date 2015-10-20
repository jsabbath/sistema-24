USE Sistema

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Charly Blues
-- =============================================
CREATE PROCEDURE clientes_eliminarRegistro

@idcliente int

AS
BEGIN
	
	delete from dbo.Clientes where idcliente=@idcliente
END
GO
