Public Class Inicio
    Private Sub btnConfeccionarPresup_Click(sender As Object, e As EventArgs) Handles btnConfeccionarPresup.Click
        Datos_Detalle.Show()
        Me.Hide()
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
    End Sub

    Private Sub btnFormFinalizar_Click(sender As Object, e As EventArgs) Handles btnFormFinalizar.Click
        Finalizar_Servicio.Show()
        Me.Hide()
    End Sub
End Class