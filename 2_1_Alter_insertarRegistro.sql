USE [Sistema]
GO
/****** Object:  StoredProcedure [dbo].[clientes_insertarRegistro]    Script Date: 20/10/2015 01:27:20 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[clientes_insertarRegistro]
	@idcliente int,
	@nombre varchar (50),
	@CUIL varchar(11),
	@domicilio varchar(50),
	@apellido varchar (50),
	@localidad varchar (50),
	@telpar varchar (50),
	@telcel varchar (50),
	@email varchar (50),
	@observa varchar(max)

	as
	begin
   insert into dbo.Clientes (idcliente,nombre,CUIL,domicilio,apellido, localidad ,telpart ,telcel , email, observa )
                      values(@idcliente,@nombre,@CUIL,@domicilio,@apellido,@localidad,@telpar,@telcel,@email,@observa)

END
