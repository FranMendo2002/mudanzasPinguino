Public Class FinalizarServicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFinalizarServicio.Click
        Dim consulta = "select idservicio from servicios where idservicio = " & txtServicio.Text
        Dim idServicio = consultarValor(consulta)
        If String.IsNullOrEmpty(idServicio) Then
            MsgBox("El id de servicio ingresado no coincide con ninguno existente. Porfavor, vuelva a intentar")
        Else
            ' A continuacion vamos a realizar la actualizacion de todas las tablass correspondientes
            Dim actualizacion = "update servicios set Estado = 'Finalizado' 
                                         where idservicio = " & CInt(txtServicio.Text)
            actualizar(actualizacion)

            ' Ahora vamos a obtener el id de presupuesto de este servicio el cual estamos sellando como finalizado
            consulta = "select idPresupuesto from servicios where idservicio = " & CInt(txtServicio.Text)
            Dim idPresupuesto As Integer = consultarValor(consulta)
            ' Obtenemos el id de reserva de ese presupuesto
            consulta = "select idReserva from notareserva where idPresupuesto = " & idPresupuesto
            Dim idReserva As Integer = consultarValor(consulta)
            ' Ahora vamos a obtener el maximo id de recibo para poder registrar el nuevo
            consulta = "select max(idRecibo)+1 from recibos"
            Dim reciboNuevo As Integer = consultarValor(consulta)
            ' Por ultimo, ingresamos el nuevo dato
            actualizacion = "insert into recibos values(" & reciboNuevo & ", " & idPresupuesto & ", " & idReserva & ")"
            actualizar(actualizacion)
            MsgBox("Porfavor, entreguele al cliente la documentacion correspondiente")
        End If
    End Sub
    Private Sub txtServicio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtServicio.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If


    End Sub

    Private Sub FinalizarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
    End Sub
End Class