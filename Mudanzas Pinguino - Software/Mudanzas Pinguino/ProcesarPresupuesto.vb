Imports System.Data.Odbc

Public Class ProcesarPresupuesto
    'Public sql As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clientetxt.Enabled = True
    End Sub

    Public Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click

        consulta = "select estado from presupuesto where idPresupuesto=" & clientetxt.Text
        Dim estado As String = cargarConsulta(consulta)
        Dim opc As Integer

        If estado = "Cancelado" Or estado = "Finalizado" Then
            MsgBox("El presupuesto está cancelado")
            opc = 0
        ElseIf estado = "Pendiente" Then
            MsgBox("El presupuesto está Pendiente, se cambiará el estado a Aceptado")
            consulta = ("update presupuesto set estado = 'Aceptado' where idPresupuesto=" & clientetxt.Text)
            cargarActualización(consulta)
            opc = 1
        ElseIf estado = Nothing Then
            MsgBox("El presupuesto " & clientetxt.Text & " no existe")
        Else
            MsgBox("El presupuesto ya esta aceptado")
            consulta = ("select idReserva from notaReserva where idPresupuesto=" & clientetxt.Text)
            Dim resultado = cargarConsulta(consulta)
            If resultado = Nothing Then
                Dim respuesta = MsgBox("No hay una nota de reserva registrada para este presupuesto, desea registrar una?", 4, "Registrar nota?")
                If respuesta = 6 Then
                    opc = 1
                End If
            Else
                MsgBox("Ya hay una nota de reserva registrada para este presupuesto")
            End If
        End If
        If opc = 1 Then
            ProcesarPresupuesto2.Show()
            Me.Close()
        Else
            MsgBox("No se puede registrar una nota de reserva")
        End If



    End Sub

    Private Sub clientetxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles clientetxt.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else : e.Handled = True
        End If


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Inicio.Show()
        Me.Close()
    End Sub
End Class
