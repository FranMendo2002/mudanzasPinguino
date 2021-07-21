Public Class FormInsert
    Private Sub FormInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formato()
        Label2.BackColor = System.Drawing.Color.Transparent
    End Sub
    Private Sub mostrarVehiculo()
        Label1.Text = "Patente:"
        Label2.Text = "Marca:"
        Label3.Text = "Modelo"
        Label4.Text = "TaraDisponible:"
    End Sub
    Private Sub mostrarEmpleado()
        Label1.Text = "Nombre:"
        Label2.Text = "Apellido:"
        Label3.Text = "Telefono:"
        Label4.Text = "Especialidad:"

    End Sub

    Private Sub CBInsert_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBInsert.SelectedIndexChanged
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        If CBInsert.SelectedItem = "Empleados" Then
            mostrarEmpleado()
        Else
            mostrarVehiculo()
        End If
    End Sub

    Private Sub BInsert_Click(sender As Object, e As EventArgs) Handles BInsert.Click
        If CBInsert.SelectedItem = Nothing Then
            MsgBox("No se selecciono una opción de ingreso")
        Else
            If CBInsert.SelectedItem = "Empleados" Then

                Try
                    If String.IsNullOrEmpty(TextBox1.Text) = False And String.IsNullOrEmpty(TextBox2.Text) = False And String.IsNullOrEmpty(TextBox3.Text) = False And String.IsNullOrEmpty(TextBox4.Text) = False Then
                        consulta = "insert into empleados (nombre, apellido, telefono, especialidad) values('" & TextBox1.Text & "','" & TextBox2.Text & "'," & CInt(TextBox3.Text) & ",'" & TextBox4.Text & "')"
                        cargarActualización(consulta)
                    End If
                Catch ex As System.InvalidCastException
                    MsgBox("Ingrese los datos correctamente")
                End Try
            Else
                Try
                    If String.IsNullOrEmpty(TextBox1.Text) = False And String.IsNullOrEmpty(TextBox2.Text) = False And String.IsNullOrEmpty(TextBox3.Text) = False And String.IsNullOrEmpty(TextBox4.Text) = False Then
                        consulta = "insert into Camiones (patente, marca, modelo, taradisponible) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "'," & CDec(TextBox4.Text) & ")"
                        cargarActualización(consulta)
                    End If
                Catch ex As System.InvalidCastException
                    MsgBox("Ingrese los datos correctamente")
                End Try
            End If
            If consulta = "" Then
                MsgBox("Debe llenar los espacios vacios y volver a intentarlo")
            Else
                MsgBox("Se efectuo la siguiente consulta: " & consulta)
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Inicio.Show()
        Me.Close()
    End Sub
End Class