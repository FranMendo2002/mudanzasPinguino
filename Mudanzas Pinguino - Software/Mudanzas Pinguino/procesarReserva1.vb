Public Class procesarReserva1
    Dim idCli As Integer
    Private Sub procesarReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formato()
    End Sub

    Public Sub BVerificar_Click(sender As Object, e As EventArgs) Handles BVerificar.Click
        Dim existe As Integer
        Dim sql = "from notareserva nr, cliente c, presupuesto p, notaPedido np, detallepedido dp  where nr.idpresupuesto = p.idpresupuesto and dp.idnota= np.idnota and p.idnota = np.idnota and np.cliente= c.idCliente and idreserva = " & CInt(TBReserva.Text)
        existe = consultaExiste("Select * " & sql)
        idCli = consultaRowEsp("select c.idCliente " & sql)
        If existe > 0 Then
            TBNomApe.Text = consultaRowEsp(" select c.nombre " + sql) & "   " & consultaRowEsp(" select c.apellido " + sql)
            TBFMud.Text = consultaRowEsp(" select dp.fechamud " + sql)
            TBDIni.Text = consultaRowEsp(" select c.direccionOrigen " + sql)
            TBMon.Text = consultaRowEsp(" select p.precio " + sql)
            TBCEmp.Text = consultaRowEsp(" select dP.Empleados " + sql)
            TBCamion.Text = consultaRowEsp(" select dP.camiones " + sql)
            TBFlete.Text = consultaRowEsp(" select dP.fletes " + sql)
            TBDViaje.Text = consultaRowEsp(" select np.direccionDestino " + sql)

            consulta = ("select idServicio from servicios S, Presupuesto P, notaReserva NR where idReserva=" & TBReserva.Text & " and NR.idPresupuesto=P.idPresupuesto and P.IdPresupuesto=S.idPresupuesto;")
            Dim resultado = cargarConsulta(consulta)
            If resultado = Nothing Then
                MsgBox("Esta nota de reserva no tiene un servicio asociado resgistrado")
                TBHini.Text = Nothing
                TBHini.Enabled = True
                BIngresar.Visible = True
            Else
                consulta = ("select hora from servicios S, Presupuesto P, notaReserva NR where idReserva=" & TBReserva.Text & " and NR.idPresupuesto=P.idPresupuesto and P.IdPresupuesto=S.idPresupuesto;")
                x = 1
                TBHini.Text = cargarConsulta(consulta)
                TBHini.Enabled = False
                BIngresar.Visible = False
                MsgBox("Esta nota de reserva ya tiene un servicio asociado resgistrado")
            End If

            TBFlete.ForeColor = Color.Black
            TBNomApe.ForeColor = Color.Black
            TBFMud.ForeColor = Color.Black
            TBDIni.ForeColor = Color.Black
            TBMon.ForeColor = Color.Black
            TBCEmp.ForeColor = Color.Black
            TBCamion.ForeColor = Color.Black
            TBDViaje.ForeColor = Color.Black
            TBHini.ForeColor = Color.Black
        Else
            MsgBox("id no encontrada, ingrese denuevo")
            TBNomApe.Text = "✘"
            TBFMud.Text = "✘"
            TBDIni.Text = "✘"
            TBMon.Text = "✘"
            TBCEmp.Text = "✘"
            TBCamion.Text = "✘"
            TBHini.Text = "✘"
            TBDViaje.Text = "✘"
            TBFlete.Text = "✘"
            TBNomApe.ForeColor = Color.Red
            TBFMud.ForeColor = Color.Red
            TBDIni.ForeColor = Color.Red
            TBMon.ForeColor = Color.Red
            TBCEmp.ForeColor = Color.Red
            TBCamion.ForeColor = Color.Red
            TBDViaje.ForeColor = Color.Red
            TBHini.ForeColor = Color.Red
            TBHini.Enabled = False
            BIngresar.Enabled = False
        End If
    End Sub

    Public Sub BIngresar_Click(sender As Object, e As EventArgs) Handles BIngresar.Click
        If TBHini.Text = Nothing Then
            MsgBox("Tiene que ingresar la fecha de la mudanza")
        Else
            Dim idpresup As Integer
            idpresup = CInt(consultaRowEsp("select idpresupuesto from notareserva where idreserva =" & TBReserva.Text))
            consulta = ("select max(idServicio)+1 from servicios")
            Dim resultado = cargarConsulta(consulta)
            Dim idServicio
            If resultado = Nothing Then
                idServicio = 1
            Else
                idServicio = resultado
            End If
            consulta = "insert into servicios values(" & idServicio & ", '" & TBFMud.Text & "','" & TBHini.Text & "'," & idpresup & "," & idCli & ",'" & TBDIni.Text & "','" & TBDViaje.Text & "','Pendiente')"
            MsgBox(consulta)
            cargarActualización(consulta)
            TBNomApe.Text = ""
            TBFMud.Text = ""
            TBDIni.Text = ""
            TBMon.Text = ""
            TBCEmp.Text = ""
            TBCamion.Text = ""
            TBHini.Text = ""
            TBDViaje.Text = ""
            TBFlete.Text = ""
            TBReserva.Text = ""
            TBHini.Enabled = False
            BIngresar.Visible = False
        End If
    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
        Inicio.Show()
    End Sub
End Class