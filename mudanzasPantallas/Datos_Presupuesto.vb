Imports System.Data.Odbc
Public Class Datos_Presupuesto
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Ahora guardaremos el maximo id de presupuesto
        Dim maxPresupConsulta As String = "select max(idPresupuesto)+1 from presupuesto;"
        Dim maxPresup As Integer = consultarValor(maxPresupConsulta)


        ' Ingresamos los datos en detalle pedido

        ' Obtenemos la fecha de hoy
        Dim fechaRegistro As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now)
        ' A la fecha de hoy le agregamos 15 dias que sera la fecha de vencimiento
        Dim fechaVencimiento As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(15))

        Dim ingresoDatos As String = "insert into presupuesto values(" & maxPresup & ", " & CInt(Datos_Detalle.txtNotaPedido.Text) &
            ", " & CInt(txtPrecio.Text) & ", '" & fechaRegistro & "', '" & fechaVencimiento & "', " & CInt(txtMontoReserva.Text) & ", 'Pendiente');"
        actualizar(ingresoDatos)

        MsgBox("Datos de presupuesto " & maxPresup & " ingresados correctamente")

        Datos_Detalle.Show()
        Me.Close()
    End Sub

    Private Sub txtMontoReserva_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoReserva.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub
    Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub
    Private Sub Datos_Presupuesto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Desea cerrar el formulario? De ser asi, los datos ingresados al registrar el ultimo detalle de pedido seran eliminados de la base de datos. Presione cancelar para registrar el presupuesto", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim actualizacion As String = "delete from detallepedido where idDetalle = " & Datos_Detalle.maxDetalle
            'MsgBox(actualizacion)
            'actualizar(actualizacion)
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub
End Class