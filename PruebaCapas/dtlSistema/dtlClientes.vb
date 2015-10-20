Imports System.Data.SqlClient
Public Class dtlClientes

    Private Property oConn As SqlConnection



    Public Sub obtenerRegistro(ByRef idcliente As Integer, ByRef clientes As DataTable)

        'oConn = New SqlConnection("Server=USUARIO-PC\SQLEXPRESS;Database=optisys;User Id=sa;Password=;")
        oConn = New SqlConnection("Server=.\SQLEXPRESS;Database=Sistema;Trusted_Connection=True;")

        If oConn.State = 1 Then oConn.Close()
        oConn.Open()

        Dim table As New DataTable
        Dim Adp As New SqlDataAdapter()

        Adp.SelectCommand = New SqlCommand() ' Creando una Instancia de SqlCommand
        Adp.SelectCommand.Connection = oConn 'Conexión

        Adp.SelectCommand.CommandType = CommandType.StoredProcedure
        Adp.SelectCommand.CommandText = "Clientes_obtenerRegistro"

        Adp.SelectCommand.Parameters.Add("@idCliente", SqlDbType.Int, 0)
        Adp.SelectCommand.Parameters("@idcliente").Value = idcliente

        Adp.Fill(table)

        clientes = table

        oConn.Close()

    End Sub

    Public Sub obtenerRegistroCuil(ByRef CUIL As String, ByRef clientes As DataTable)

        'oConn = New SqlConnection("Server=USUARIO-PC\SQLEXPRESS;Database=optisys;User Id=sa;Password=;")
        oConn = New SqlConnection("Server=.\SQLEXPRESS;Database=Sistema;Trusted_Connection=True;")

        If oConn.State = 1 Then oConn.Close()
        oConn.Open()

        Dim table As New DataTable
        Dim Adp As New SqlDataAdapter()

        Adp.SelectCommand = New SqlCommand() ' Creando una Instancia de SqlCommand
        Adp.SelectCommand.Connection = oConn 'Conexión

        Adp.SelectCommand.CommandType = CommandType.StoredProcedure
        Adp.SelectCommand.CommandText = "clientes_obtenerRegistroPorCUIL"

        Adp.SelectCommand.Parameters.Add("@CUIL", SqlDbType.Char, 11)
        Adp.SelectCommand.Parameters("@CUIL").Value = CUIL

        Adp.Fill(table)

        clientes = table

        oConn.Close()

    End Sub

    Public Sub insertarRegistro(ByRef intidcliente As Integer, ByRef CUIL As String, ByRef strnombre As String, ByRef strdomicilio As String, ByRef strapellido As String, ByRef strlocalidad As String, ByRef strtelpar As String, ByRef strtelcel As String, ByRef stremail As String, ByRef strobserva As String)
        'oConn = New SqlConnection("Server=USUARIO-PC\SQLEXPRESS;Database=optisys;User Id=sa;Password=;")
        oConn = New SqlConnection("Server=.\SQLEXPRESS;Database=Sistema;Trusted_Connection=True;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(9) As SqlParameter

        param(0) = New SqlParameter("@idcliente", intidcliente)
        param(1) = New SqlParameter("@nombre", strnombre)
        param(2) = New SqlParameter("@cuil", CUIL)
        param(3) = New SqlParameter("@domicilio", strdomicilio)
        param(4) = New SqlParameter("@apellido", strapellido)
        param(5) = New SqlParameter("@localidad", strlocalidad)
        param(6) = New SqlParameter("@telpar", strtelpar)
        param(7) = New SqlParameter("@telcel", strtelcel)
        param(8) = New SqlParameter("@email", stremail)
        param(9) = New SqlParameter("@observa", strobserva)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "clientes_insertarRegistro"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



    End Sub

    Public Sub eliminarRegistro(ByRef intidcliente As Integer)
        'oConn = New SqlConnection("Server=USUARIO-PC\SQLEXPRESS;Database=optisys;User Id=sa;Password=;")
        oConn = New SqlConnection("Server=.\SQLEXPRESS;Database=Sistema;Trusted_Connection=True;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(0) As SqlParameter

        param(0) = New SqlParameter("@idcliente", intidcliente)


        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "clientes_eliminarRegistro"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



    End Sub

  
End Class
