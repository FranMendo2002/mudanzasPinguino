Imports System.Data.Odbc
Public Class IngresarSolicitudServicio
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = Nothing Or (TextBox2.Visible = True And TextBox2.Text = Nothing) Or TextBox3.Text = Nothing) Then
            MsgBox("Debe completar los datos")
        Else
            consulta = ("select DNI from cliente, notaPedido where cliente.idcliente=notaPedido.cliente and DNI=" & TextBox1.Text)
            If (cargarConsulta(consulta) <> Nothing) Then
                MsgBox("El cliente ya tiene un pedido de servicio registrado")
            Else
                MsgBox("Solicitud de servicio aceptada" & vbNewLine & "Ingrese una fecha y hora posibles para la visita")
                Label5.Visible = True
                DateTimePicker1.Visible = True
                Label6.Visible = True
                Button3.Visible = True
                TextBox1.Enabled = False
                TextBox2.Enabled = False
                TextBox3.Enabled = False
                DateTimePicker2.Visible = True
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        consulta = "select (max(idNota))+1 from notaPedido"
        Dim idNota As Integer = cargarConsulta(consulta)
        consulta = ("select idCliente from cliente where DNI=" & TextBox1.Text)
        Dim cliente As Integer = cargarConsulta(consulta)
        Dim fechaP As String = String.Format("{0:yyyy-MM-dd}", DateTimePicker1.Value)
        Dim respuesta As Integer = MsgBox("DNI= " & TextBox1.Text & vbNewLine & "Fecha Posible= " & fechaP & vbNewLine & "Hora Posible= " & DateTimePicker2.Text & vbNewLine & "Dirección Destino= " & TextBox3.Text & vbNewLine & "Los datos están bien?", 4)
        If (respuesta = 7) Then
            MsgBox("Revise los datos y vuelva  a ingresar")
        Else
            Dim fechaE As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now)
            consulta = ("insert into notaPedido values(" & idNota & ", " & cliente & ", '" & fechaP & "', '" & DateTimePicker2.Text & "', '" & TextBox3.Text & "', '" & fechaE & "')")
            cargarActualización(consulta)
            NotaPedido.Show()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            MsgBox("No hay un DNI ingresado")
        Else
            consulta = ("select idCliente from cliente where DNI=" & TextBox1.Text)
            Dim respuesta As Integer = cargarConsulta(consulta)
            If (respuesta = Nothing) Then
                MsgBox("El cliente no esta registrado, ingrese sus datos en la pantalla que sigue")
                servicio = True
                IngresarCliente.Show()
            Else
                MsgBox("El cliente esta registrado")
                consulta = ("select direccionOrigen from cliente where DNI= '" & TextBox1.Text & "'")
                Dim respuesta2 As String = cargarConsulta(consulta)
                Dim respuesta3 As Integer = MsgBox("La dirección '" & respuesta2 & "' es la direccion de origen de la mudanza?", 4, )
                If respuesta3 = 6 Then
                    TextBox2.Visible = False
                    Label8.Visible = True
                    Label8.Text = respuesta2
                End If
            End If
        End If
    End Sub
End Class