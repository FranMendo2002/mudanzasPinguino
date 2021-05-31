Imports System.Data.Odbc
Public Class formDatosPresupuesto
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Ahora guardaremos el maximo id de presupuesto
        Dim maxPresupConsulta As String = "select max(idPresupuesto)+1 from presupuesto;"
        Dim maxPresup As Integer
        cmd = New OdbcCommand(maxPresupConsulta, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader
        cmd.Dispose()

        ' Guardamos en la variable maxPresup el valor del nuevo id de presupuesto que crearemos
        While rs.Read = True
            maxPresup = rs(0)
            MsgBox(maxPresup)
        End While


        ' Ingresamos los datos en detalle pedido

        ' Obtenemos la fecha de hoy
        Dim fechaRegistro As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now)
        ' A la fecha de hoy le agregamos 15 dias que sera la fecha de vencimiento
        Dim fechaVencimiento As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(15))

        Dim ingresoDatos As String = "insert into presupuesto values(" & maxPresup & ", " & CInt(formDatosDetalle.txtNotaPedido.Text) &
            ", " & CInt(txtPrecio.Text) & ", '" & fechaRegistro & "', '" & fechaVencimiento & "', " & CInt(txtMontoReserva.Text) & ", 'Pendiente');"
        cmd = New OdbcCommand(ingresoDatos, cnn)
        MsgBox(ingresoDatos)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader
        cmd.Dispose()

        MsgBox("Datos ingresados correctamente")

        formDatosDetalle.Show()
        Me.Close()
    End Sub

    Private Sub txtMontoReserva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoReserva.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub
    Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub
End Class