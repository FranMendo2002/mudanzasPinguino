Public Class IngresarDaños
    Dim cargado = 0

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("No se ingresó información en los cuadros")
        Else
            consulta = ("select * from servicios where idServicio=" & TextBox1.Text)
            Dim respuesta = cargarConsulta(consulta)
            If respuesta <> Nothing Then
                consulta = ("select estado from servicios where idServicio=" & TextBox1.Text)
                respuesta = cargarConsulta(consulta)
                If respuesta <> "Cancelado" Then
                    consulta = ("select idCheque from danios where idServicios=" & TextBox1.Text)
                    respuesta = cargarConsulta(consulta)

                    If respuesta = Nothing Or respuesta = 0 Then
                        consulta = "Select (max(idDanios))+1 from danios"
                        Dim resultado = cargarConsulta(consulta)
                        Dim idDanio As Integer
                        If resultado = Nothing Then
                            idDanio = 1
                        Else
                            idDanio = resultado
                        End If
                        consulta = ("Insert into danios values(" & idDanio & ", 0, " & TextBox1.Text & ", '" & TextBox2.Text & "')")
                        MsgBox(consulta)
                        cargarActualización(consulta)

                        If errorIngreso = False And cargado = 0 Then
                            Button2.Visible = True
                            TextBox1.Enabled = False
                            Button4.Visible = False
                            MsgBox("No podrá cargar los daños de otros servicios, ni volver a la pantalla principal hasta que se cargue el cheque correspondiente")
                            cargado = 1
                        End If
                        errorIngreso = False
                    Else
                        MsgBox("Ya se confeccionó el cheque de este servicio")
                    End If
                Else
                    MsgBox("El servicio esta cancelado, no se puede confeccionar un cheque")
                End If
            Else
                MsgBox("El servicio no existe ingrese otro")
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

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
        Inicio.Show()
    End Sub
End Class
