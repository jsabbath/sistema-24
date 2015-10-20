Imports wflSistema
Public Class FormIngreso

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim x As New wflClientes

        Dim dt As New DataTable

        If txtIdCliente.Text = Nothing Then
            x.obtenerRegistroCuil(txtCUIL.Text, dt)
        Else

            x.obtenerRegistro(txtIdCliente.Text, dt)
            'MsgBox("BUSQUEDA POR CLIENTE", vbInformation + vbOKOnly, "Aviso al operador")

        End If

        If dt.Rows.Count > 0 Then
            For Each MiDataRow As DataRow In dt.Rows
                Me.txtIdCliente.Text = MiDataRow(0).ToString()
                Me.txtnombre.Text = MiDataRow(1).ToString()
                Me.txtApellido.Text = MiDataRow(2).ToString()
                Me.txtdomicilio.Text = MiDataRow(3).ToString()
                Me.txtLocalidad.Text = MiDataRow(4).ToString()
                Me.txtCUIL.Text = MiDataRow(5).ToString()
                Me.txttelpart.Text = MiDataRow(6).ToString()
                Me.Txttelcel.Text = MiDataRow(7).ToString()
                Me.txtemail.Text = MiDataRow(8).ToString()
                Me.txtobserva.Text = MiDataRow(9).ToString()


            Next
        Else
            MsgBox("El cliente no existe en la base de datos", vbInformation + vbOKOnly, "Aviso al operador")
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertar.Click
        Dim x As New wflClientes
        Dim strmensaje As String = ""

        x.insertarRegistro(strmensaje, txtIdCliente.Text, txtCUIL.Text, txtnombre.Text, txtdomicilio.Text, txtApellido.Text, txtLocalidad.Text, txttelpart.Text, Txttelcel.Text, txtemail.Text, txtobserva.Text)


        MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")

        Me.LimpiaPantalla()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim x As New wflClientes
        Dim strmensaje As String = ""

        x.eliminarRegistro(txtIdCliente.Text, strmensaje)
        MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")

        Me.LimpiaPantalla()

    End Sub
    Public Sub LimpiaPantalla()
        txtIdCliente.Text = ""
        txtnombre.Text = ""
        txtCUIL.Text = ""
        txtdomicilio.Text = ""
        txtApellido.Text = ""
        txtLocalidad.Text = ""
        txttelpart.Text = ""
        Txttelcel.Text = ""
        txtemail.Text = ""
        txtobserva.Text = ""

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcalle_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCUIL_TextChanged(sender As Object, e As EventArgs) Handles txtCUIL.TextChanged

    End Sub

    Private Sub txtLocalidad_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtIdCliente_TextChanged(sender As Object, e As EventArgs) Handles txtIdCliente.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtdomicilio_TextChanged(sender As Object, e As EventArgs) Handles txtdomicilio.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtrazonsocial_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub
End Class
