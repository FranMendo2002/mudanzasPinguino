Imports System.Data.Odbc
Module ModuloIglesias
    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs As OdbcDataReader
    Public consulta As String
    Public ds As New DataSet
    Public adp As OdbcDataAdapter

    Public x As Integer


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
        Dim query As String
        Try

            cmd = New OdbcCommand(consulta, cnn)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader()

            cmd.Dispose()

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
            query = ""
            Return query
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
        End Try
    End Sub

    Public Function cargarGrid(ByVal sql As String)
        Try
            ds.Tables.Add(sql)
            adp = New OdbcDataAdapter(sql, cnn)
            adp.Fill(ds.Tables(sql))
            Return ds.Tables(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Module
