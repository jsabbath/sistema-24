USE Sistema
-- ================================================
-- PROCEDIMIENTOS ALMACENADOS
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Cata
-- Create date: 25/09/2014
-- Description:	Obtiene un registro de la tabla
-- Clientes según valor asignado a @idpersona
-- =============================================
CREATE PROCEDURE  clientes_obtenerRegistro
	@idcliente int	
AS

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT * FROM Clientes WHERE idcliente = @idcliente
END
GO
