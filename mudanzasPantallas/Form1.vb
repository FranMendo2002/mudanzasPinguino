﻿Imports System.Data.Odbc

Public Class formDatosDetalle
    Public maxDetalle As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
    End Sub
    Private Sub txtMuebles_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMuebles.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If


    End Sub
    Private Sub txtCamiones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCamiones.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If


    End Sub
    Private Sub txtFletes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFletes.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If


    End Sub
    Private Sub txtEmpleados_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmpleados.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub

    Private Sub txtNotaPedido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNotaPedido.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If String.IsNullOrEmpty(txtEmpleados.Text) Or String.IsNullOrEmpty(txtMuebles.Text) Or String.IsNullOrEmpty(txtNotaPedido.Text) Then
            MsgBox("Porfavor, no deje datos vacios en los muebles, empleados o nota de pedido")
        Else
            Dim maxDetalleConsulta As String = "select max(idDetalle)+1 from detallepedido"
            cmd = New OdbcCommand(maxDetalleConsulta, cnn)
            MsgBox(maxDetalleConsulta)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader
            cmd.Dispose()

            ' Guardamos en la variable maxDetalle el valor del nuevo id de detalle que crearemos
            While rs.Read = True
                maxDetalle = rs(0)
                MsgBox(maxDetalle)
            End While

            ' Ingresamos los datos en detalle pedido
            Dim ingresoDatos As String = "insert into detallepedido values(" & maxDetalle & ", " & CInt(txtNotaPedido.Text) &
                ", " & CInt(txtMuebles.Text) & ", " & CInt(txtCamiones.Text) & ", " & CInt(txtFletes.Text) & ", " & CInt(txtEmpleados.Text) &
                ", '" & dtimeFechaMud.Text & "');"
            cmd = New OdbcCommand(ingresoDatos, cnn)
            MsgBox(ingresoDatos)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader
            cmd.Dispose()

            formDatosPresupuesto.Show()
            Me.Hide()
        End If
    End Sub
End Class
