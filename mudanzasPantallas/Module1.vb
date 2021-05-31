Imports System.Data.Odbc
Imports System.Globalization

Module Module1
    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs As OdbcDataReader
    Public cambio As New Globalization.CultureInfo("es-ES")

    Public ds As New DataSet
    Public adp As OdbcDataAdapter

    Public Sub conexion()
        Try
            cnn = New OdbcConnection("DSN=mudanzas")
            cnn.Open()
            MsgBox("Conexion satisfactoria")
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Fallo la conexion")
        End Try
        cambio.NumberFormat.NumberDecimalSeparator = (".")
        System.Threading.Thread.CurrentThread.CurrentCulture = cambio
        Format(Date.Today, "yyyy/MM, dd")

    End Sub
    Public Sub actualizar(ByVal actualizacion As String)
        Dim ds As New DataSet
        Try
            cmd = New OdbcCommand(actualizacion, cnn)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader()
            cmd.Dispose()
            MsgBox("Actualizacion realizada correctamente")
        Catch ex As Exception
            MsgBox("No se pudo realizar la actualizacion correctamente. Intente de nuevo")
        End Try
    End Sub
    Public Function consultarValor(ByVal consulta As String)
        Dim ds As New DataSet
        Try
            cmd = New OdbcCommand(consulta, cnn)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader()
            cmd.Dispose()
            Dim resultado As String
            While rs.Read
                resultado = rs(0)
            End While
            Return resultado
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

End Module