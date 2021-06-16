Public Class Cheque

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        consulta = ("select max(idCheque) from cheques")
        Dim idCheque = cargarConsulta(consulta)
        consulta = ("select year(fechaE) from cheques where idCheque=" & idCheque)
        x = 1
        Label1.Text = cargarConsulta(consulta)
        consulta = ("select month(fechaE) from cheques where idCheque=" & idCheque)
        Label2.Text = cargarConsulta(consulta)
        consulta = ("select day(fechaE) from cheques where idCheque=" & idCheque)
        Label3.Text = cargarConsulta(consulta)
        x = 0
        consulta = ("select monto from cheques where idCheque=" & idCheque)
        Label4.Text = cargarConsulta(consulta)
        Label5.Text = idCheque
        consulta = ("select nombre from cliente C, cheques Ch where C.idCliente=Ch.cliente and idCheque=" & idCheque)
        Label6.Text = cargarConsulta(consulta)
        consulta = ("select apellido from cliente C, cheques Ch where C.idCliente=Ch.cliente and idCheque=" & idCheque)
        Label11.Text = cargarConsulta(consulta)
        consulta = ("select montoEscrito from cheques where idCheque=" & idCheque)
        Label7.Text = cargarConsulta(consulta)
        consulta = ("select year(fechaP) from cheques where idCheque=" & idCheque)
        x = 1
        Label8.Text = cargarConsulta(consulta)
        consulta = ("select month(fechaP) from cheques where idCheque=" & idCheque)
        Label9.Text = cargarConsulta(consulta)
        consulta = ("select day(fechaP) from cheques where idCheque=" & idCheque)
        Label10.Text = cargarConsulta(consulta)

    End Sub

    Private Sub Form1_FormClosed(sender As System.Object, e As System.EventArgs) Handles Me.Closed
        IngresarCheque.Close()
        IngresarDaños.Show()
        IngresarDaños.TextBox1.Text = ""
        IngresarDaños.TextBox2.Text = ""
        IngresarDaños.TextBox1.Enabled = True
        IngresarDaños.Button2.Enabled = False
    End Sub
End Class