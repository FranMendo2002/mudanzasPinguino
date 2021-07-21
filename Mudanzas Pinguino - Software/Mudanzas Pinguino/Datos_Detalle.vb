Imports System.Data.Odbc

Public Class Datos_Detalle
    Public maxDetalle As Integer
    Public ingresoDatos As String
    Private Sub txtMuebles_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMuebles.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If


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
        If String.IsNullOrEmpty(txtEmpleados.Text) Or String.IsNullOrEmpty(txtMuebles.Text) Or String.IsNullOrEmpty(txtNotaPedido.Text) Or String.IsNullOrEmpty(txtCamiones.Text) Or String.IsNullOrEmpty(txtFletes.Text) Or String.IsNullOrEmpty(txtPrecio.Text) Or String.IsNullOrEmpty(txtMontoReserva.Text) Then
            MsgBox("Porfavor, no deje ningún campo vacio")
        Else
            consulta = ("select idNota from notaPedido where idNota = " & txtNotaPedido.Text)
            Dim resultado = cargarConsulta(consulta)
            If resultado <> Nothing Then
                consulta = ("select idDetalle from detallePedido where idNota=" & txtNotaPedido.Text)
                resultado = cargarConsulta(consulta)
                If resultado <> Nothing Then
                    MsgBox("La nota de pedido " & txtNotaPedido.Text & " ya tiene detalles cargados")
                Else
                    Dim maxDetalleConsulta As String = "select max(idDetalle)+1 from detallepedido"
                    maxDetalle = cargarConsulta(maxDetalleConsulta)
                    MsgBox("El max idDetalle es: " & maxDetalle)

                    ' Ingresamos los datos en detalle pedido
                    ingresoDatos = "insert into detallepedido values(" & maxDetalle & ", " & CInt(txtNotaPedido.Text) &
                        ", " & CInt(txtMuebles.Text) & ", " & CInt(txtCamiones.Text) & ", " & CInt(txtFletes.Text) & ", " & CInt(txtEmpleados.Text) &
                        ", '" & dtimeFechaMud.Text & "');"
                    cargarActualización(ingresoDatos)
                    MsgBox("Los datos de detalle pedido han sido ingresados correctamente")

                    ' A continuacion, realizamos los inserts en presupuesto
                    Dim maxPresupConsulta As String = "select max(idPresupuesto)+1 from presupuesto;"
                    Dim maxPresup As Integer = cargarConsulta(maxPresupConsulta)
                    ' Obtenemos la fecha de hoy
                    Dim fechaRegistro As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now)
                    ' A la fecha de hoy le agregamos 15 dias que sera la fecha de vencimiento
                    Dim fechaVencimiento As String = String.Format("{0:yyyy-MM-dd}", DateTime.Now.AddDays(15))

                    ingresoDatos = "insert into presupuesto values(" & maxPresup & ", " & CInt(txtNotaPedido.Text) &
                    ", " & CInt(txtPrecio.Text) & ", '" & fechaRegistro & "', '" & fechaVencimiento & "', " & CInt(txtMontoReserva.Text) & ", 'Pendiente');"
                    cargarConsulta(ingresoDatos)

                    MsgBox("Datos de presupuesto " & maxPresup & " ingresados correctamente")
                End If
            Else
                MsgBox("La nota de pedido ingresada no existe")
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Inicio.Show()
        Me.Close()
    End Sub

    Private Sub lblPrecio_Click(sender As Object, e As EventArgs) Handles lblPrecio.Click

    End Sub

    Private Sub Datos_Detalle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
