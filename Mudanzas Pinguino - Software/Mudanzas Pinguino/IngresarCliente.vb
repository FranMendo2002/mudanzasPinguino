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
            telefono = TextBox4.Text
        End If

        consulta = "select (max(idCliente))+1 from cliente"
        Dim respuesta = cargarConsulta(consulta)
        Dim cliente As Integer
        If respuesta = Nothing Then
            cliente = 1
        Else
            cliente = respuesta
        End If

        If servicio = True Then
            consulta = ("insert into cliente values(" & cliente & ", " & Label8.Text & ", '" & TextBox2.Text & "', '" & TextBox3.Text & "', " & telefono & ", " & telefonoL & ", '" & TextBox6.Text & "', '" & TextBox8.Text & "')")
            Call ModuloIglesias.cargarActualización(consulta)
            consulta = ("select idCliente from cliente where DNI=" & Label8.Text)
            respuesta = cargarConsulta(consulta)
            If (respuesta <> "null") Then
                IngresarSolicitudServicio.Label8.Text = TextBox8.Text
                Me.Close()
                MsgBox("Solicitud de servicio aceptada" & vbNewLine & "Ingrese una fecha y hora posibles para la visita")
                IngresarSolicitudServicio.Label5.Visible = True
                IngresarSolicitudServicio.DateTimePicker1.Visible = True
                IngresarSolicitudServicio.Label6.Visible = True
                IngresarSolicitudServicio.DateTimePicker2.Visible = True
                IngresarSolicitudServicio.Button3.Visible = True
                IngresarSolicitudServicio.TextBox2.Visible = False
                IngresarSolicitudServicio.Label8.Visible = True
            End If
        Else
            consulta = ("insert into cliente values(" & cliente & ", " & TextBox7.Text & ", '" & TextBox2.Text & "', '" & TextBox3.Text & "', " & telefono & ", " & telefonoL & ", '" & TextBox6.Text & "', '" & TextBox8.Text & "')")
            Call ModuloIglesias.cargarActualización(consulta)
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Inicio.Show()
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

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub IngresarCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If servicio = True Then
            Label8.Visible = True
            Label8.Text = IngresarSolicitudServicio.TextBox1.Text
        Else
            TextBox7.Visible = True
        End If
    End Sub

    Private Sub IngresarCliente_Closed(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosed
        Label8.Visible = False
        TextBox7.Visible = False
    End Sub
End Class