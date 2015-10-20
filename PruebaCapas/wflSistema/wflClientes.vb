Imports brlSistema
Public Class wflClientes
    Public Sub obtenerRegistro(ByVal idcliente As Integer, ByRef clientes As DataTable)

        Dim x As New brlClientes
        'MsgBox("WFL-busca ID", vbInformation + vbOKOnly, "Aviso al operador")
        x.obtenerRegistro(idcliente, clientes)

    End Sub
    Public Sub obtenerRegistroCuil(ByVal CUIL As String, ByRef clientes As DataTable)

        Dim x As New brlClientes

        x.obtenerRegistroCuil(CUIL, clientes)

    End Sub
    Public Sub insertarRegistro(ByRef strmensaje As String,
                                ByVal idcliente As Integer,
                                ByVal CUIL As String,
                                ByVal strrazonsocial As String,
                                ByVal strdomicilio As String,
                                ByVal strapellido As String,
                                ByVal strlocalidad As String,
                                ByVal strtelpar As String,
                                ByVal strtelcel As String,
                                ByVal stremail As String,
                                ByVal strobserva As String
                                )
        Dim x As New brlClientes
        Dim clientes As New DataTable
        Dim id As Integer

        If Not x.ExisteCliente(idcliente) Then

            If Not x.ExisteCUIL(CUIL) Then
                x.insertarRegistro(idcliente, CUIL, strrazonsocial, strdomicilio, strapellido, strlocalidad, strtelpar, strtelcel, stremail, strobserva)
                strmensaje = "El cliente se agrego con exito"
            Else
                x.obtenerRegistroCuil(CUIL, clientes)
                If clientes.Rows.Count > 0 Then
                    id = clientes.Rows(0)("idcliente")
                    strmensaje = "El CUIL ya fue ingresado para el IdCliente: " & id.ToString()
                End If
            End If
        Else
            strmensaje = "El cliente Nº: " & idcliente & " ya existe en la base"
        End If

    End Sub

    Public Sub eliminarRegistro(ByVal idcliente As Integer, ByRef strmensaje As String)
        Dim x As New brlClientes
        If x.ExisteCliente(idcliente) Then
            x.eliminarRegistro(idcliente)
            strmensaje = "El cliente se eliminó con exito"
        Else
            strmensaje = "El cliente no existe en la base"
        End If
    End Sub
    'En las wFL generalmente van procesos complejos que invlucran
    ' llamados a las otras capas. 
    ' Ejemplo Procesar Consumos Cliente
    ' En ese caso debere tener en la dtl un una dtl de facturas
    ' Una brl de facturas
    ' y aca traerlas y trabajarlas.

    Sub insertarRegistro(strmensaje As String, p2 As String, p3 As String, p4 As String, p5 As String, p6 As String, p7 As String, p8 As String, p9 As String, p10 As String, p11 As String, p12 As String)
        Throw New NotImplementedException
    End Sub

End Class
