Imports System.Data.Odbc
Module Module1
    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs As OdbcDataReader
    Public consulta As String
    Public ds As New DataSet
    Public adp As OdbcDataAdapter

    Public x As Integer
    Public errorIngreso As Boolean = False

    Public Sub conexion()
        Try
            cnn = New OdbcConnection("DSN=mudanzas_pinguino")
            cnn.Open()
            MsgBox("Conexión Satisfactoria")
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Conexión fallida")
        End Try
    End Sub

    Public Function cargarConsulta(ByVal consulta As String)
        Dim ds As New DataSet

        Try

            cmd = New OdbcCommand(consulta, cnn)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader()

            cmd.Dispose()

            Dim query As String
            While rs.Read
                If x = 0 Then
                    query = rs(0)
                Else
                    query = rs(0).ToString
                End If
            End While

            Return query

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub cargarActualización(ByVal actualización As String)
        Dim ds As New DataSet

        Try

            cmd = New OdbcCommand(actualización, cnn)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader()

            cmd.Dispose()

            MsgBox("La actualización se realizó con éxito")

        Catch ex As Exception
            MsgBox("Hubo un error, verifique la información ingresada")
            errorIngreso = True
        End Try
    End Sub
End Module
