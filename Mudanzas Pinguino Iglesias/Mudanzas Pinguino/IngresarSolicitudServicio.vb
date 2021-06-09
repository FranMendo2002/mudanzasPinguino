Imports System.Data.Odbc
Public Class IngresarSolicitudServicio
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conexion()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing) Then
            MsgBox("Debe completar los datos")
        Else
            consulta = ("select idCliente from cliente where DNI=" & TextBox1.Text)
            Dim respuesta As Integer = ModuloIglesias.cargarConsulta(consulta)
            consulta = ("select * from cliente where direccionOrigen= '" & TextBox2.Text & "'")
            Dim respuesta2 As Integer = ModuloIglesias.cargarConsulta(consulta)

            If (respuesta = Nothing) Then
                MsgBox("El cliente no esta registrado, complete el formulario para ingresarlo")
                IngresarCliente.Show()
            ElseIf (respuesta2 = Nothing) Then
                MsgBox("La dirección de origen esta mal, revisela")
            Else
                consulta = ("select DNI from cliente, notaPedido where cliente.idcliente=notaPedido.cliente and DNI=" & TextBox1.Text)
                If (cargarConsulta(consulta) <> Nothing) Then
                    MsgBox("El cliente ya tiene un pedido de servicio registrado")
                Else
                    MsgBox("Solicitud de servicio aceptada" & vbNewLine & "Ingrese una fecha y hora posibles para la visita")
                    Label5.Visible = True
                    DateTimePicker1.Visible = True
                    Label6.Visible = True
                    TextBox4.Visible = True
                    Button3.Visible = True
                    Label7.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        consulta = "select (max(idNota))+1 from notaPedido"
        Dim idNota As Integer = cargarConsulta(consulta)
        consulta = ("select idCliente from cliente where DNI=" & TextBox1.Text)
        Dim cliente As Integer = cargarConsulta(consulta)
        Dim fechaP As String = String.Format("{0:yyyy-MM-dd}", DateTimePicker1.Value)
        Dim respuesta As Integer = MsgBox("DNI= " & TextBox1.Text & vbNewLine & "Fecha Posible= " & fechaP & vbNewLine & "Hora Posible= " & TextBox4.Text & vbNewLine & "Dirección Destino= " & TextBox3.Text & vbNewLine & "Los datos están bien?", 4)
        If (respuesta = 7) Then
            MsgBox("Revise los datos y vuelva  a ingresar")
        Else
            Dim fechaE As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now)
            consulta = ("insert into notaPedido values(" & idNota & ", " & cliente & ", '" & fechaP & "', '" & TextBox4.Text & "', '" & TextBox3.Text & "', '" & fechaE & "')")
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
End Class
