Imports System.Data.Odbc
Public Class RegistrarRecibo
    Dim idRecibo
    Dim idpresu
    Dim idReserva

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If reserva = True Then
            consulta = ("select max(idRecibo)+1 from recibos;")
            idRecibo = cargarConsulta(consulta)
            idpresu = "null"
            idReserva = ProcesarPresupuesto2.Label3.Text
            If idRecibo = Nothing Then
                idRecibo = 1
                Label3.Text = "1"
            Else
                Label3.Text = idRecibo
            End If
            Label4.Text = idReserva
            Label5.Text = idpresu
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Button2.Visible = False
        Else
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            Button2.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim registrar As String
        Dim fechaE As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now)

        If reserva = False Then
            idRecibo = TextBox1.Text
            idpresu = TextBox3.Text
            idReserva = TextBox3.Text
        End If

        registrar = "insert into recibos values(" & idRecibo & ", " & idpresu & "," & idReserva & ")"

        If reserva = True Then
            Button1.Visible = False
            Button2.Visible = True
        End If
        Call cargarActualización(registrar)
        reserva = False
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Inicio.Show()
        Me.Close()
    End Sub
End Class