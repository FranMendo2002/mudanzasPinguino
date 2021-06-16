Public Class IngresarDaños

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        conexion()
    End Sub

    Dim cargado = 0

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("No se ingresó información en los cuadros")
        Else
            consulta = ("select idCheque from danios where idServicios=" & TextBox1.Text)
            Dim respuesta = cargarConsulta(consulta)

            If respuesta = Nothing Then
                consulta = "Select (max(idDanios))+1 from danios"
                Dim idDanio As Integer = cargarConsulta(consulta)
                consulta = ("Insert into danios values(" & idDanio & ", null, " & TextBox1.Text & ", '" & TextBox2.Text & "')")
                cargarActualización(consulta)

                If errorIngreso = False And cargado = 0 Then
                    Button2.Enabled = True
                    TextBox1.Enabled = False
                    MsgBox("No podrá cargar los daños de otros servicios hasta que se cargue el cheque correspondiente")
                    cargado = 1
                End If
                errorIngreso = False
            Else
                MsgBox("Ya se confeccionó el cheque de este servicio")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        IngresarCheque.Show()
        Me.Hide()
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

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        TextBox2.Text = ""
    End Sub
End Class
