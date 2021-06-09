Public Class NotaPedido

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim respuesta
        x = 0
        consulta = ("select max(idNota) from notaPedido")
        Label1.Text = cargarConsulta(consulta)
        consulta = ("select fechaE from notaPedido where idNota=" & Label1.Text)
        Label2.Text = cargarConsulta(consulta)
        consulta = ("select nombre from cliente, notaPedido where cliente.idcliente=notaPedido.cliente and idNota=" & Label1.Text)
        Label3.Text = cargarConsulta(consulta)
        consulta = ("select apellido from cliente, notaPedido where cliente.idcliente=notaPedido.cliente and idNota=" & Label1.Text)
        Label12.Text = cargarConsulta(consulta)
        consulta = ("select DNI from cliente, notaPedido where cliente.idcliente=notaPedido.cliente and idNota=" & Label1.Text)
        Label4.Text = cargarConsulta(consulta)
        consulta = ("select telefono from cliente, notaPedido where cliente.idcliente=notaPedido.cliente and idNota=" & Label1.Text)
        respuesta = cargarConsulta(consulta)
        If (respuesta <> Nothing) Then
            Label5.Text = respuesta
        Else
            Label5.Text = "No tiene"
        End If
        consulta = ("select telefonoL from cliente, notaPedido where cliente.idcliente=notaPedido.cliente and idNota=" & Label1.Text)
        respuesta = cargarConsulta(consulta)
        If (respuesta <> Nothing) Then
            Label6.Text = respuesta
        Else
            Label6.Text = "No tiene"
        End If
        consulta = ("select email from cliente, notaPedido where cliente.idcliente=notaPedido.cliente and idNota=" & Label1.Text)
        Label7.Text = cargarConsulta(consulta)
        consulta = ("select direccionOrigen from cliente, notaPedido where cliente.idcliente=notaPedido.cliente and idNota=" & Label1.Text)
        Label8.Text = cargarConsulta(consulta)
        consulta = ("select direccionDestino from notaPedido where idNota=" & Label1.Text)
        Label9.Text = cargarConsulta(consulta)
        consulta = ("select fechaPosible from notaPedido where idNota=" & Label1.Text)
        Label10.Text = cargarConsulta(consulta)
        consulta = ("select horaPosible from notaPedido where idNota=" & Label1.Text)
        x = 1
        Label11.Text = cargarConsulta(consulta)
        x = 0

    End Sub

    Private Sub Form1_FormClosed(sender As System.Object, e As System.EventArgs) Handles Me.FormClosed
        IngresarDetallePedido.Show()
    End Sub
End Class