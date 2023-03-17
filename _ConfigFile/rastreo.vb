Imports System.IO

Public Class rastreo
    

    Public Sub Log(ByVal sPathName As String, ByVal sMsg As String, Optional ErrorLogDate As Boolean = True)
        ErrorLog(sPathName, sMsg, "test", ErrorLogDate)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sPathName">Directorio dónde se va a guardar el log</param>
    ''' <param name="sErrMsg">Mensaje de error</param>
    ''' <param name="sType">Tipo del LOG: error, advertencia, mensaje, info, test, ok. Es indistinto entre mayúsculas y minúsculas</param>
    ''' <param name="ErrorLogDate"></param>
    ''' <remarks></remarks>
    Public Sub ErrorLog(ByVal sPathName As String, ByVal sErrMsg As String, ByVal sType As String, ErrorLogDate As Boolean, y As String)
        sType = sType.ToUpper

        Try
            Dim sErrorTime As String
            Dim sLogFormat As String

            Dim sYear As String = DateTime.Now.Year.ToString()
            Dim sMonth As String = DateTime.Now.Month.ToString()
            Dim sDay As String = DateTime.Now.Day.ToString()

            sErrorTime = sYear & FormatearNumero(sMonth) & FormatearNumero(sDay)

            sLogFormat = DateTime.Now.ToShortDateString().ToString() & " " & DateTime.Now.ToLongTimeString().ToString()
            Dim sw As System.IO.StreamWriter = New StreamWriter(sPathName.Replace(".", "_" & sErrorTime & "."), True, Text.Encoding.UTF8)
            If ErrorLogDate = True Then
                sw.WriteLine(sLogFormat & "," & sType & "," & sErrMsg)
            Else
                sw.WriteLine(sErrMsg)
            End If

            sw.Flush()
            sw.Close()

        Catch ex As Exception
            Dim fi As FileInfo = New FileInfo(sPathName)
            System.IO.Directory.CreateDirectory(fi.DirectoryName)
            ErrorLog(sPathName, sErrMsg, "error", True)
        End Try
    End Sub


    Public Sub ErrorLog(ByVal sPathName As String, ByVal sErrMsg As String, ByVal sType As String, ErrorLogDate As Boolean)
        sType = sType.ToUpper

        Try
            Dim sErrorTime As String
            Dim sLogFormat As String

            Dim sYear As String = DateTime.Now.Year.ToString()
            Dim sMonth As String = DateTime.Now.Month.ToString()
            Dim sDay As String = DateTime.Now.Day.ToString()


            sErrorTime = sYear & FormatearNumero(sMonth) & FormatearNumero(sDay)
            'Dim FileName As String = 
            Dim FileNameCurrent As String = sPathName.Replace(".", "_current.")
            If File.Exists(FileNameCurrent) = True Then
                Dim x As New FileInfo(FileNameCurrent)
                If x.Length >= 524288 Then
                    My.Computer.FileSystem.RenameFile(FileNameCurrent, "Log_" & sErrorTime & ".txt")
                End If
            End If
            sLogFormat = DateTime.Now.ToShortDateString().ToString() & " " & DateTime.Now.ToLongTimeString().ToString()
            Dim sw As System.IO.StreamWriter = New StreamWriter(FileNameCurrent, True, Text.Encoding.UTF8)
            If ErrorLogDate = True Then
                sw.WriteLine(sLogFormat & "," & sType & "," & sErrMsg)
            Else
                sw.WriteLine(sErrMsg)
            End If
            sw.Flush()
            sw.Close()
        Catch ex As Exception
            Dim fi As FileInfo = New FileInfo(sPathName)
            System.IO.Directory.CreateDirectory(fi.DirectoryName)
            ErrorLog(sPathName, sErrMsg, "error", True)
        End Try
    End Sub


    Private Function FormatearNumero(numero As String) As String
        'Dim n As Integer = CInt(numero)
        If CInt(numero) < 10 Then
            numero = "0" & numero
        End If
        Return numero
    End Function

End Class
