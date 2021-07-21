Imports System.Data.Odbc
Module ModuloIglesias
    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs As OdbcDataReader
    Public consulta As String
    Public ds As New DataSet
    Public adp As OdbcDataAdapter

    Public x As Integer
    Public servicio As Boolean = False
    Public errorIngreso As Boolean = False
    Public cambio As New Globalization.CultureInfo("es-ES")
    Public reserva As Boolean = False
    Public errorConsulta As Boolean = False
    Public administracion As Boolean = False
    Public recepcion As Boolean = False

    Public Sub conexion()
        Try
            cnn = New OdbcConnection("DSN=mudanzas_pinguino")
            cnn.Open()
            MsgBox("Conexión Satisfactoria")
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Conexión fallida")
        End Try
    End Sub

    Public Sub formato()
        cambio.NumberFormat.NumberDecimalSeparator = (".")
        System.Threading.Thread.CurrentThread.CurrentCulture = cambio
        Format(Date.Today, "yyyy/MM/dd")

    End Sub

    Public Function consultaRowEsp(ByVal sql As String)
        Dim rta As String
        Try
            cmd = New OdbcCommand(sql, cnn)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader()
            cmd.Dispose()
            While rs.Read = True
                rta = rta & rs(0).ToString
            End While
        Catch ex As Exception
            MsgBox("No se pudo realizar la actualizacion correctamente. Intente de nuevo")
            errorConsulta = True
        End Try
        Return rta
    End Function

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
            errorIngreso = True
        End Try
    End Sub

    Public Function cargarGrid(ByVal sql As String)
        Try
            If (ds.Tables.Contains(sql)) Then
                ds.Tables.Remove(sql)
            End If
            ds.Tables.Add(sql)
            adp = New OdbcDataAdapter(sql, cnn)
            adp.Fill(ds.Tables(sql))
            Return ds.Tables(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function consultaExiste(ByVal sql As String)
        Dim cont As Integer
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader()
        cmd.Dispose()
        While rs.Read = True
            cont += 1
        End While
        Return cont
    End Function
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
            'MsgBox(ex.Message)
        End Try
    End Function

    Public Function GetMyNumberToWords(ByVal value As String) As String
        Dim str As String = String.Empty

        Try
            Select Case Convert.ToDouble(value)
                Case 0 : str = "CERO"
                Case 1 : str = "UN"
                Case 2 : str = "DOS"
                Case 3 : str = "TRES"
                Case 4 : str = "CUATRO"
                Case 5 : str = "CINCO"
                Case 6 : str = "SEIS"
                Case 7 : str = "SIETE"
                Case 8 : str = "OCHO"
                Case 9 : str = "NUEVE"
                Case 10 : str = "DIEZ"
                Case 11 : str = "ONCE"
                Case 12 : str = "DOCE"
                Case 13 : str = "TRECE"
                Case 14 : str = "CATORCE"
                Case 15 : str = "QUINCE"
                Case Is < 20 : str = "DIECI" & GetMyNumberToWords(value - 10)
                Case 20 : str = "VEINTE"
                Case Is < 30 : str = "VEINTI" & GetMyNumberToWords(value - 20)
                Case 30 : str = "TREINTA"
                Case 40 : str = "CUARENTA"
                Case 50 : str = "CINCUENTA"
                Case 60 : str = "SESENTA"
                Case 70 : str = "SETENTA"
                Case 80 : str = "OCHENTA"
                Case 90 : str = "NOVENTA"
                Case Is < 100 : str = GetMyNumberToWords(Int(value \ 10) * 10) & " Y " & GetMyNumberToWords(value Mod 10)
                Case 100 : str = "CIEN"
                Case Is < 200 : str = "CIENTO " & GetMyNumberToWords(value - 100)
                Case 200, 300, 400, 600, 800 : str = GetMyNumberToWords(Int(value \ 100)) & "CIENTOS"
                Case 500 : str = "QUINIENTOS"
                Case 700 : str = "SETECIENTOS"
                Case 900 : str = "NOVECIENTOS"
                Case Is < 1000 : str = GetMyNumberToWords(Int(value \ 100) * 100) & " " & GetMyNumberToWords(value Mod 100)
                Case 1000 : str = "MIL"
                Case Is < 2000 : str = "MIL " & GetMyNumberToWords(value Mod 1000)
                Case Is < 1000000 : str = GetMyNumberToWords(Int(value \ 1000)) & " MIL"
                    If value Mod 1000 Then str = str & " " & GetMyNumberToWords(value Mod 1000)
                Case 1000000 : str = "UN MILLON"
                Case Is < 2000000 : str = "UN MILLON " & GetMyNumberToWords(value Mod 1000000)
                Case Is < 1000000000000.0# : str = GetMyNumberToWords(Int(value / 1000000)) & " MILLONES "
                    If (value - Int(value / 1000000) * 1000000) Then str = str & " " & GetMyNumberToWords(value - Int(value / 1000000) * 1000000)
                Case 1000000000000.0# : str = "UN BILLON"
                Case Is < 2000000000000.0# : str = "UN BILLON " & GetMyNumberToWords(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
                Case Else : str = str(Int(value / 1000000000000.0#)) & " BILLONES"
                    If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then str = str & " " & GetMyNumberToWords(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            End Select

            Return str
        Catch ex As Exception
            MsgBox("No se puede realizar la conversión de un elemento vacío")
        End Try
    End Function

    Public Function consultaEspecifica(ByVal sql As String, posicion As Integer)
        Dim cont As Integer
        Try

            cmd = New OdbcCommand(sql, cnn)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader()

            cmd.Dispose()

            While rs.Read = True
                If cont = posicion Then
                    Return rs(0).ToString
                End If
                cont += 1
            End While
        Catch ex As Exception
            MsgBox("Hubo un error, verifique la información ingresada")
            errorIngreso = True
        End Try
    End Function

End Module
