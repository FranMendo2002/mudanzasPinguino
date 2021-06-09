Public Class IngresarCliente

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim telefonoL As String
        If String.IsNullOrEmpty(TextBox5.Text) Then
            telefonoL = "null"

        Else
            telefonoL = TextBox5.Text
        End If

        Dim telefono As String
        If String.IsNullOrEmpty(TextBox4.Text) Then
            telefono = "null"

        Else
            telefono = TextBox5.Text
        End If

        consulta = "select (max(idCliente))+1 from cliente"
        Dim cliente As Integer = cargarConsulta(consulta)

        consulta = ("insert into cliente values(" & cliente & ", " & Label8.Text & ", '" & TextBox2.Text & "', '" & TextBox3.Text & "', " & telefono & ", " & telefonoL & ", '" & TextBox6.Text & "', '" & Label9.Text & "')")
        Call ModuloIglesias.cargarActualización(consulta)
        consulta = ("select idCliente from cliente where DNI=" & Label8.Text)
        Dim respuesta As String = cargarConsulta(consulta)
        If (respuesta <> "null") Then
            Me.Close()
            MsgBox("Solicitud de servicio aceptada" & vbNewLine & "Ingrese una fecha y hora posibles para la visita")
            IngresarSolicitudServicio.Label5.Visible = True
            IngresarSolicitudServicio.DateTimePicker1.Visible = True
            IngresarSolicitudServicio.Label6.Visible = True
            IngresarSolicitudServicio.TextBox4.Visible = True
            IngresarSolicitudServicio.Button3.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        IngresarSolicitudServicio.Show()
        Me.Close()
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub IngresarCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label8.Text = IngresarSolicitudServicio.TextBox1.Text
        Label9.Text = IngresarSolicitudServicio.TextBox2.Text
    End Sub
End Class