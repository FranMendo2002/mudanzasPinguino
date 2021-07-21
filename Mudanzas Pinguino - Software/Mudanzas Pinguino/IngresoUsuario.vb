Imports System.Data.Odbc

Public Class IngresoUsuario

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user As String
        Dim pass As String
        user = TextBox1.Text
        pass = TextBox2.Text

        Call verificar(user, pass)


    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conexion()
    End Sub
    Public Sub verificar(ByVal user As String, ByVal pass As String)
        Dim contraseña As String
        consulta = ("select usuario from users where idUsuario=1")
        Dim usuarioA = cargarConsulta(consulta)
        consulta = ("select usuario from users where idUsuario=2")
        Dim usuarioR = cargarConsulta(consulta)


        If user = usuarioA Then
            consulta = ("select contrasenia from users where Usuario = '" & usuarioA & "'")
            contraseña = cargarConsulta(consulta)
            If pass = contraseña Then
                MsgBox("Bienvenido Admin")
                administracion = True
            End If
        End If

        If user = usuarioR Then
            consulta = ("select contrasenia from users where Usuario = '" & usuarioR & "'")
            contraseña = cargarConsulta(consulta)
            If pass = contraseña Then
                MsgBox("Bienvenido Recepcion")
                recepcion = True
            End If
        End If

        If administracion = False And recepcion = False Then
            MsgBox("El usuario o la contraseña esta mal")
        Else
            consulta = Nothing
            Inicio.Show()
            Me.Hide()
        End If

    End Sub
End Class