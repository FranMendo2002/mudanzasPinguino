Public Class BorrarPresupuestos
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formato()
        Me.DataGridView1.DataSource = cargarGrid("Select * from presupuesto where datediff(now(),fecha)>=15 and estado = 'Pendiente'")
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        cargarActualización("delete from presupuesto where datediff(now(),fecha)>=15 and estado = 'Pendiente'")
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Inicio.Show()
    End Sub
End Class