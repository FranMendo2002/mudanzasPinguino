Public Class Inicio
    Private Sub btnConfeccionarPresup_Click(sender As Object, e As EventArgs) Handles btnConfeccionarPresup.Click
        Datos_Detalle.Show()
        Me.Hide()
    End Sub

    Private Sub btnFormFinalizar_Click(sender As Object, e As EventArgs) Handles btnFormFinalizar.Click
        Finalizar_Servicio.Show()
        Me.Hide()
    End Sub

    Private Sub btnFormNotaP_Click(sender As System.Object, e As System.EventArgs) Handles btnFormNotaP.Click
        IngresarSolicitudServicio.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrarCliente_Click(sender As System.Object, e As System.EventArgs) Handles btnRegistrarCliente.Click
        IngresarCliente.Show()
        Me.Hide()
    End Sub

    Private Sub btnFormCheque_Click(sender As System.Object, e As System.EventArgs) Handles btnFormCheque.Click
        IngresarDaños.Show()
        Me.Hide()
    End Sub

    Private Sub btnFormBorrarPresup_Click(sender As System.Object, e As System.EventArgs) Handles btnFormBorrarPresup.Click
        If consultarValor("Select * from presupuesto where datediff(now(),fecha)>=15 and estado = 'Pendiente'") = 0 Then
            btnFormBorrarPresup.Enabled = False
            MsgBox("no hay presupuesto vencidos")
        Else
            MsgBox("se encontraron presupuestos vencidos")
            BorrarPresupuestos.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnFormContrato_Click(sender As System.Object, e As System.EventArgs) Handles btnFormContrato.Click
        procesarReserva.Show()
    End Sub

    Private Sub btnFormProcesarPresup_Click(sender As System.Object, e As System.EventArgs) Handles btnFormProcesarPresup.Click
        ProcesarPresupuesto.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        RegistrarRecibo.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        FormInsert.Show()
    End Sub

    Private Sub btnFormCancelarServ_Click(sender As System.Object, e As System.EventArgs) Handles btnFormCancelarServ.Click
        CancelarServicio.Show()
    End Sub

    Private Sub Inicio_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If administracion = False Then
            btnFormBorrarPresup.Visible = False
            Button2.Visible = False
        End If
    End Sub
End Class