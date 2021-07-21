Imports System.Data.Odbc
Public Class ProcesarPresupuesto2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim idpresupuesto As String

        idpresupuesto = CInt(ProcesarPresupuesto.clientetxt.Text)
        MsgBox(idpresupuesto)
        consulta = ("select max(idReserva)+1 from notaReserva")
        Dim resultado = cargarConsulta(consulta)
        If resultado = Nothing Then
            Label3.Text = "1"
        Else
            Label3.Text = resultado
        End If
        Label4.Text = idpresupuesto
        consulta = "select montoRes from presupuesto where idPresupuesto=" & idpresupuesto
        Label2.Text = cargarConsulta(consulta)
        Label5.Text = "Pagada"


    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim registrar As String
        Dim fechaE As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now)

        registrar = "insert into notareserva values(" & Label3.Text & ", " & Label4.Text & "," & Label2.Text & ",'" & Label5.Text & "','" & fechaE & "' )"

        MsgBox(registrar)
        Call cargarActualización(registrar)
        reserva = True
        RegistrarRecibo.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ProcesarPresupuesto.Show()
        Me.Close()
    End Sub
End Class