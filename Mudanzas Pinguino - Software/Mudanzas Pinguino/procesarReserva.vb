Public Class procesarReserva
    Dim idCli As Integer
    Dim flag1 As Boolean
    Dim flag2 As Boolean
    Dim flag3 As Boolean
    Dim idsVeh(2) As Integer
    Dim idveh As Integer
    Dim contVeh As Integer
    Dim idsEmp(4) As Integer
    Dim idEmp As Integer
    Dim contEmp As Integer
    Dim limiteVeh As Integer
    Dim limiteEmp As Integer
    Private Sub procesarReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formato()
    End Sub

    Public Sub BVerificar_Click(sender As Object, e As EventArgs) Handles BVerificar.Click
        If TBReserva.Text <> Nothing Then
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
                    flag1 = True
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

                Dim consultaEmp As String
                Dim consultaVeh As String

                consultaEmp = " From empleados e Where idEmpleado Not In( Select e.idEmpleado From empleados e, serviciorecursos sr, servicios s Where e.idEmpleado = sr.idEmpleado And sr.idServicio = s.idServicio And s.fecha = '" & TBFMud.Text & "') and especialidad != 'recepcionista'"
                consultaVeh = " From camiones c Where idCamion Not In( Select c.idCamion From camiones c, serviciorecursos sr, servicios s Where c.idCamion = sr.idCamion And sr.idServicio = s.idServicio And s.fecha = '" & TBFMud.Text & "')"
                Dim empDis As Integer
                empDis = consultaExiste("select *" + consultaEmp)
                Dim vehDis As Integer
                vehDis = consultaExiste("select *" + consultaVeh)

                Dim respuesta
                For Counter As Integer = 0 To empDis
                    respuesta = consultaEspecifica("Select e.idEmpleado" + consultaEmp, Counter)
                    If respuesta <> Nothing Then
                        CBEmpleado.Items.Add(respuesta)
                    End If
                Next Counter
                For Counter As Integer = 0 To vehDis
                    respuesta = consultaEspecifica("Select C.idCamion" + consultaVeh, Counter)
                    If respuesta <> Nothing Then
                        CBVehiculo.Items.Add(respuesta)
                    End If
                Next Counter

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
                flag1 = False
            End If
            If flag1 Then
                GBEmpleados.Visible = True
                GBVehiculos.Visible = True
                GBEmpleados.Enabled = True
                GBVehiculos.Enabled = True
                limiteEmp = CInt(TBCEmp.Text)
                limiteVeh = CInt(TBCamion.Text)
                Select Case limiteEmp
                    Case 1
                        LEmpIngresado1.Visible = True

                    Case 2
                        LEmpIngresado1.Visible = True
                        LEmpIngresado2.Visible = True
                    Case 3
                        LEmpIngresado1.Visible = True
                        LEmpIngresado3.Visible = True
                        LEmpIngresado4.Visible = True
                    Case 4
                        LEmpIngresado1.Visible = True
                        LEmpIngresado2.Visible = True
                        LEmpIngresado3.Visible = True
                        LEmpIngresado4.Visible = True
                End Select
                Select Case limiteVeh
                    Case 1
                        LVehIngresado1.Visible = True

                    Case 2
                        LVehIngresado1.Visible = True
                        LVehIngresado2.Visible = True
                End Select
            Else

                flag1 = False
                flag2 = False
                flag3 = False
                GBEmpleados.Enabled = False
                GBVehiculos.Enabled = False
            End If
        Else
            MsgBox("No se ingreso un id de reserva")
        End If

    End Sub

    Public Sub BIngresar_Click(sender As Object, e As EventArgs) Handles BIngresar.Click
        Dim ConsultaRecurso As String
        Dim cambioVeh As Integer = 2
        If flag1 And flag2 And flag3 Then
            If TBHini.Text = Nothing Then
                MsgBox("Tiene que ingresar la hora de la mudanza")
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
                Dim fechaM As String = String.Format("{0:yyyy-MM-dd}", TBFMud.Text)

                consulta = "insert into servicios values(" & idServicio & ", '" & fechaM & "','" & TBHini.Text & "'," & idpresup & "," & idCli & ",'" & TBDIni.Text & "','" & TBDViaje.Text & "','Pendiente')"
                MsgBox(consulta)
                cargarActualización(consulta)

                For Counter As Integer = 1 To limiteEmp
                    If CInt(TBCamion.Text) > 1 Then
                        If (Counter - 1) > cambioVeh Then
                            ConsultaRecurso = "insert into serviciorecursos values (" & idServicio & ", " & idsEmp(Counter - 1) & "," & idsVeh(0) & ")"
                            cargarActualización(ConsultaRecurso)
                        Else
                            ConsultaRecurso = "insert into serviciorecursos values (" & idServicio & ", " & idsEmp(Counter - 1) & "," & idsVeh(1) & ")"
                            cargarActualización(ConsultaRecurso)
                        End If
                    Else
                        ConsultaRecurso = "insert into serviciorecursos values (" & idServicio & ", " & idsEmp(Counter - 1) & "," & idsVeh(0) & ")"
                        cargarActualización(ConsultaRecurso)
                    End If
                Next Counter

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
                CBEmpleado.Items.Clear()
                CBVehiculo.Items.Clear()
                GBEmpleados.Visible = False
                GBVehiculos.Visible = False
                flag1 = False
                flag2 = False
                flag3 = False
            End If
        Else
            MsgBox("necesita llenar todos los datos Bingresar")
        End If

    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub BtEmpleadoIngresar_Click(sender As Object, e As EventArgs) Handles BtVEmpleados.Click
        Dim limite As Integer
        If contEmp = 0 Then
            CBEmpleado.Items.Remove(idsEmp(contEmp))
            LEmpIngresado1.Text += "✓"
            idsEmp(contEmp) = idEmp
            contEmp += 1
            BtBorrarEmp.Enabled = True

        ElseIf contEmp = 1 And contEmp <= CInt(TBCEmp.Text) Then
            CBEmpleado.Items.Remove(idsEmp(contEmp))
            LEmpIngresado2.Text += "✓"
            idsEmp(contEmp) = idEmp
            contEmp += 1
            BtBorrarEmp.Enabled = True

        ElseIf contEmp = 2 And contEmp <= CInt(TBCEmp.Text) Then
            CBEmpleado.Items.Remove(idsEmp(contEmp))
            LEmpIngresado3.Text += "✓"
            idsEmp(contEmp) = idEmp
            contEmp += 1
            BtBorrarEmp.Enabled = True

        ElseIf contEmp = 3 And contEmp <= CInt(TBCEmp.Text) Then
            CBEmpleado.Items.Remove(idsEmp(contEmp))
            LEmpIngresado4.Text += "✓"
            idsEmp(contEmp) = idEmp
            contEmp += 1
            BtBorrarEmp.Enabled = True

        Else
            BtVEmpleados.Enabled = False
            flag2 = True
        End If
        If contEmp = CInt(TBCEmp.Text) Then
            BtVEmpleados.Enabled = False
            flag2 = True
        End If
        If flag2 And flag3 Then
            BIngresar.Enabled = True
        End If


    End Sub

    Private Sub BtVVehiculos_Click(sender As Object, e As EventArgs) Handles BtVVehiculos.Click

        Dim limite As Integer

        If contVeh = 0 And contVeh <= CInt(TBCamion.Text) Then
            LVehIngresado1.Text += "✓"
            idsVeh(contVeh) = idveh
            contVeh += 1
            BtBorrarVeh.Enabled = True
        ElseIf contVeh = 1 And contVeh <= CInt(TBCamion.Text) Then
            LVehIngresado2.Text += "✓"
            idsVeh(contVeh) = idveh
            contVeh += 1
            BtBorrarVeh.Enabled = True
        Else
            BtVVehiculos.Enabled = False
            flag3 = True
        End If
        If contVeh = CInt(TBCamion.Text) Then
            BtVVehiculos.Enabled = False
            flag3 = True
        End If
        If flag2 And flag3 Then
            BIngresar.Enabled = True
        End If

    End Sub

    Private Sub CBEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEmpleado.SelectedIndexChanged
        Dim consultaEmp As String
        idEmp = CInt(CBEmpleado.SelectedItem.ToString)
        consultaEmp = " From empleados e Where Especialidad Not In( Select e.Especialidad From empleados e, serviciorecursos sr, servicios s Where e.idEmpleado = sr.idEmpleado And sr.idServicio = s.idServicio And s.fecha = '" & TBFMud.Text & "' and e.idEmpleado = " & idEmp & ") and idEmpleado = " & CBEmpleado.SelectedItem

        LNombre.Text = consultaRowEsp("select e.nombre" + consultaEmp)
        LEspecialidad.Text = consultaRowEsp("select e.Especialidad" + consultaEmp)
        LTelefono.Text = consultaRowEsp("select e.telefono" + consultaEmp)
    End Sub

    Private Sub CBVehiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBVehiculo.SelectedIndexChanged
        Dim consultaVeh As String

        idveh = CInt(CBVehiculo.SelectedItem.ToString)
        consultaVeh = " From camiones c Where idCamion Not In( Select c.idCamion From camiones c, serviciorecursos sr, servicios s Where c.idCamion = sr.idCamion And sr.idServicio = s.idServicio And s.fecha = '" & TBFMud.Text & "' and c.idCamion = " & idveh & ") and c.idCamion = " & CBVehiculo.SelectedItem


        LMarca.Text = consultaRowEsp("select c.marca" + consultaVeh)
        LModelo.Text = consultaRowEsp("select c.modelo" + consultaVeh)
        LPatente.Text = consultaRowEsp("select c.patente" + consultaVeh)
        LTara.Text = consultaRowEsp("select c.taraDisponible" + consultaVeh)
    End Sub

    Private Sub BtBorrarEmp_Click(sender As Object, e As EventArgs) Handles BtBorrarEmp.Click

        Dim consultaEmp As String
        BIngresar.Enabled = False
        BtVEmpleados.Enabled = True
        consultaEmp = " From empleados e Where Especialidad Not In( Select e.Especialidad From empleados e, serviciorecursos sr, servicios s Where e.idEmpleado = sr.idEmpleado And sr.idServicio = s.idServicio And s.fecha = '" & TBFMud.Text & "')"
        If contEmp = 4 Then
            CBEmpleado.Items.Add(idsEmp(contEmp - 1))
            LEmpIngresado4.Text = "Ingresado 4: "
            contEmp -= 1
        ElseIf contEmp = 3 Then
            CBEmpleado.Items.Add(idsEmp(contEmp - 1))
            LEmpIngresado3.Text = "Ingresado 3: "
            contEmp -= 1
        ElseIf contEmp = 2 Then
            CBEmpleado.Items.Add(idsEmp(contEmp - 1))
            LEmpIngresado2.Text = "Ingresado 2: "
            contEmp -= 1
        ElseIf contEmp = 1 Then
            CBEmpleado.Items.Add(idsEmp(contEmp - 1))
            LEmpIngresado1.Text = "Ingresado 1: "
            contEmp -= 1
            BtBorrarEmp.Enabled = False
        End If
        flag2 = False
    End Sub

    Private Sub BtBorrarVeh_Click(sender As Object, e As EventArgs) Handles BtBorrarVeh.Click
        Dim consultaVeh As String
        BIngresar.Enabled = False
        BtVVehiculos.Enabled = True
        consultaVeh = " From camiones c Where idCamion Not In( Select c.idCamion From camiones c, serviciorecursos sr, servicios s Where c.idCamion = sr.idCamion And sr.idServicio = s.idServicio And s.fecha = '" & TBFMud.Text & "')"
        If contVeh = 2 Then
            CBVehiculo.Items.Add(idsVeh(contVeh - 1))
            LVehIngresado2.Text = "Ingresado 2: "
            contVeh -= 1
        ElseIf contVeh = 1 Then
            CBVehiculo.Items.Add(idsVeh(contVeh - 1))
            LVehIngresado1.Text = "Ingresado 1: "
            contVeh -= 1
            BtBorrarVeh.Enabled = False
        End If
        flag3 = False
    End Sub

    Private Sub TBReserva_TextChanged(sender As Object, e As EventArgs) Handles TBReserva.TextChanged
        For counter As Integer = 1 To idsEmp.Length

        Next counter
        BIngresar.Enabled = False
    End Sub
End Class