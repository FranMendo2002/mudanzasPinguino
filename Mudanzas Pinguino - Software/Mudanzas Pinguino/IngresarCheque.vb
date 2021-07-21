Imports System.Data.Odbc
Public Class IngresarCheque

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("No se puede cargar el cheque hasta que se completen todos los datos")
        Else
            consulta = "select (max(idCheque))+1 from cheques"
            Dim idCheque As Integer = cargarConsulta(consulta)
            consulta = ("select cliente from servicios where idServicio=" & IngresarDaños.TextBox1.Text)
            Dim cliente As Integer = cargarConsulta(consulta)
            Dim fechaE As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now)
            Dim plazo As Integer = TextBox2.Text
            Dim fechaP As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(plazo))

            consulta = ("Insert into cheques values(" & idCheque & ", " & cliente & ", " & TextBox1.Text & ", '" & Label5.Text & "', '" & fechaE & "', '" & fechaP & "')")
            cargarActualización(consulta)


            consulta = ("Update danios set idCheque=" & idCheque & " where idServicios=" & IngresarDaños.TextBox1.Text)
            cargarActualización(consulta)

            Cheque.Show()
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

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Label5.Text = GetMyNumberToWords(TextBox1.Text)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        IngresarDaños.Show()
        Me.Close()
    End Sub
End Class