Imports System.Data.Odbc
Public Class IngresarDetallePedido

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        consulta = "select max(idNota) from notaPedido"
        Dim idNota As Integer = cargarConsulta(consulta)
        consulta = "select (max(idDetalle))+1 from detallePedido"
        Dim idDP As Integer = cargarConsulta(consulta)
        Dim fechaM As String = String.Format("{0:yyyy-MM-dd}", DateTimePicker1.Value)

        consulta = ("insert into detallePedido values(" & idDP & ", " & idNota & ", " & TextBox1.Text & ", " & TextBox2.Text & ", " & TextBox3.Text & ", " & TextBox4.Text & ", '" & fechaM & "')")
        cargarActualización(consulta)

        consulta = ("select idDetalle from detallePedido where idNota=" & idNota)
        Dim resultado = cargarConsulta(consulta)
        If resultado = Nothing Then
            MsgBox("No se puede cargar una nueva solicitud hasta que se hayan cargado todos los datos")
        Else
            consulta = ("select * from detallePedido where idDetalle=" & idDP)

            Me.DataGridView1.DataSource = cargarGrid(consulta)
            Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As System.Object, e As System.EventArgs) Handles Me.FormClosing
        IngresarSolicitudServicio.TextBox1.Text = Nothing
        IngresarSolicitudServicio.TextBox2.Text = Nothing
        IngresarSolicitudServicio.TextBox3.Text = Nothing
        IngresarSolicitudServicio.TextBox4.Text = Nothing
        IngresarSolicitudServicio.Label5.Visible = False
        IngresarSolicitudServicio.DateTimePicker1.Visible = False
        IngresarSolicitudServicio.Label6.Visible = False
        IngresarSolicitudServicio.TextBox4.Visible = False
        IngresarSolicitudServicio.Button3.Visible = False
        IngresarSolicitudServicio.Label7.Visible = False
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

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
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
End Class