Imports System.Data.Odbc
Public Class CancelarServicio
    Dim cancelado As String
    Private Sub CancelarServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CS.Enabled = False
        NR.Enabled = False
        NP.Enabled = False
        cancelado = "select estado from servicios where idServicio =  " & CS.Text

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim opc As Integer = InputBox("Ingrese numero de contrato de servicio")
        CS.Text = opc

        consulta = "select idPresupuesto from servicios where idServicio = " & opc
        NP.Text = consultarValor(consulta)

        consulta = "select idReserva from notareserva where idPresupuesto = " & NP.Text
        NR.Text = consultarValor(consulta)


        If CS.Text = "" Or NP.Text = "" Or NR.Text = "" Then
            MsgBox("Datos erroneos o inexistentes")
        Else MsgBox("Datos encontrados ")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        consulta = ("select estado from servicios where idServicio= " & CS.Text)
        Dim resultado = cargarConsulta(consulta)
        If resultado = "Cancelado" Or resultado = "Finalizado" Then
            MsgBox("El servicio ya esta cancelado o finalizado")
        Else
            Dim opc As String
            opc = MsgBox("¿Desea cancelar este servicio?", vbYesNo)

            If opc = vbYes Then
                Dim CSvalor As Integer = Val(CS.Text)

                Dim actualizar = "update servicios set estado = 'Cancelado' where idServicio = " & CSvalor
                cargarActualización(actualizar)
                actualizar = "update presupuesto set estado = 'Cancelado' where idPresupuesto = " & NP.Text
                cargarActualización(actualizar)
                actualizar = "update notaReserva set estado = 'Cancelado' where idReserva = " & NR.Text
                cargarActualización(actualizar)
                consulta = ("delete from servicioRecursos where idServicio = " & CS.Text)
                cargarActualización(consulta)
            Else : MsgBox("El servicio no fue cancelado")
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim opc As Integer = InputBox("Ingrese numero de reserva")
        NR.Text = opc

        consulta = "select idPresupuesto from notareserva where idreserva = " & opc
        NP.Text = consultarValor(consulta)

        consulta = "select idServicio from servicios where idPresupuesto = " & NP.Text
        CS.Text = consultarValor(consulta)


        If CS.Text = "" Or NP.Text = "" Or NR.Text = "" Then
            MsgBox("Datos erroneos o inexistentes")
        Else MsgBox("Datos encontrados ")
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim opc As Integer = InputBox("Ingrese numero de presupuesto")
        NP.Text = opc

        consulta = "select idReserva from notareserva where idPresupuesto = " & opc
        NR.Text = consultarValor(consulta)

        consulta = "select idServicio from servicios where idPresupuesto = " & opc
        CS.Text = consultarValor(consulta)


        If CS.Text = "" Or NP.Text = "" Or NR.Text = "" Then
            MsgBox("Datos erroneos o inexistentes")
        Else : MsgBox("Datos encontrados")
        End If
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Inicio.Show()
    End Sub
End Class