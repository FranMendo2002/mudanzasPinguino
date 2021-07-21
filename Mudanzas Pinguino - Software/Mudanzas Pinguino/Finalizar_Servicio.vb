Public Class Finalizar_Servicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFinalizarServicio.Click
        Dim consulta = "select idservicio from servicios where idservicio = " & txtServicio.Text
        Dim idServicio = cargarConsulta(consulta)
        
        If String.IsNullOrEmpty(idServicio) Then
            MsgBox("El id de servicio ingresado no coincide con ninguno existente. Porfavor, vuelva a intentar")
        Else
            consulta = ("select estado from servicios where idServicio= " & txtServicio.Text)
            Dim resultado = cargarConsulta(consulta)
            If resultado = "Cancelado" Or resultado = "Finalizado" Then
                MsgBox("El servicio ya esta cancelado o finalizado")
            Else
                ' A continuacion vamos a realizar la actualizacion de todas las tablas correspondientes
                Dim actualizacion = "update servicios set Estado = 'Finalizado' where idservicio = " & CInt(txtServicio.Text)
                cargarActualización(actualizacion)
                MsgBox("El estadio del servicio " & txtServicio.Text & " ahora es 'Finalizado'")

                ' Ahora vamos a obtener el id de presupuesto de este servicio el cual estamos sellando como finalizado
                consulta = "select idPresupuesto from servicios where idservicio = " & CInt(txtServicio.Text)
                Dim idPresupuesto As Integer = cargarConsulta(consulta)
                ' Obtenemos el id de reserva de ese presupuesto
                'consulta = "select idReserva from notareserva where idPresupuesto = " & idPresupuesto
                'Dim idReserva As Integer = cargarConsulta(consulta)
                ' Ahora vamos a obtener el maximo id de recibo para poder registrar el nuevo
                consulta = "select max(idRecibo)+1 from recibos"
                Dim reciboNuevo As Integer = cargarConsulta(consulta)
                ' Por ultimo, ingresamos el nuevo dato
                actualizacion = "insert into recibos values(" & reciboNuevo & ", " & idPresupuesto & ", null)"
                cargarActualización(actualizacion)
                MsgBox("Datos de recibo " & reciboNuevo & " registrados correctamente")
                MsgBox("Porfavor, entregue el documento del recibo " & reciboNuevo & " registrado al cliente")
                consulta = ("delete from servicioRecursos where idServicio = " & txtServicio.Text)
                cargarActualización(consulta)
            End If
            
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub Finalizar_Servicio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class