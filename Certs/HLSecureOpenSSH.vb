Imports System.ComponentModel
Imports System.IO

Public Class HLSecureOpenSSH

    'Public Function Cliente_Peticion(ByVal CN As String, ByVal name As String, ByVal surname As String, ByVal petic_cert_client As String, Optional ByRef emailAddress As String = " ") As Boolean
    '    ' Ahora generamos la petición del certificado: Aquí debemos de llenar los datos del certificado como son el CN (muy importante) y demás datos que ponemos.
    '    If EjecutaProceso("OpenSSL", "req -new -key " & VasClass.client_priv & " -passin pass:HobN211aa -subj ""/CN=" & CN & "/givenName=" & name & "/surname=" & surname & "/emailAddress=" & emailAddress & "/dnQualifier=" & CN & """ -out " & petic_cert_client) = True Then
    '        Cliente_Peticion = True
    '    Else
    '        Cliente_Peticion = False
    '    End If
    'End Function
    'Public Function Cliente_EmitirCert(ByVal petic_cert_client As String, ByVal DuracionDias As Integer, ByVal ClienteCertPem As String) As Boolean
    '    If EjecutaProceso("OpenSSL", "x509 -CA " & VasClass.cacert & " -CAkey " & VasClass.cakey & " -req -in " & petic_cert_client & " -set_serial 3 -days " & DuracionDias & " -extfile " & VasClass.ConfigFile & " -sha1  -out " & ClienteCertPem) = True Then
    '        Cliente_EmitirCert = True
    '    Else
    '        Cliente_EmitirCert = False
    '    End If
    '    'Emitimos el certificado cliente:
    'End Function
    'Public Function Cliente_HOBEA(ByVal ClienteCertPem As String, ByVal ClienteCert_HOBEA As String) As Boolean
    '    ' Generamos el certificado para el HOB EA
    '    If EjecutaProceso("openssl", "x509 -inform PEM -in " & ClienteCertPem & " -outform DER -out " & ClienteCert_HOBEA) = True Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
    'Public Function Cliente_certPer(ByVal ClienteCertPem As String, ByVal _Cliente_CertPer As String, ByVal TextFile As String) As Boolean
    '    'Y por último vamos a exportarlo para enviárselo a su nuevo dueño. Para ello necesitamos crear con nuestro certificado un fichero comprimido en formato pkcs12.
    '    Dim Password As String = RandomPassword(8)
    '    If EjecutaProceso("openssl", "pkcs12 -export -in " & ClienteCertPem & " -inkey " & VasClass.client_priv & " -certfile " & VasClass.cacert & " -out " & _Cliente_CertPer & " -passin pass:HobN211aa -passout pass:" & Password) = True Then
    '        CreaArchivoTexto(TextFile, Password)
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function

    'Function CreaArchivoTexto(ByVal TextFile As String, ByVal Linea As String) As Boolean
    '    Try
    '        Dim oSW As New StreamWriter(TextFile)
    '        oSW.WriteLine(Linea)
    '        oSW.Flush()
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function


    'Function RandomPassword(ByVal Length As Integer, Optional ByVal Upper As Boolean = True, Optional ByVal Number As Boolean = True, Optional ByVal Lower As Boolean = True) As String
    '    If Not Upper And Not Lower And Not Number Then
    '        RandomPassword = ""
    '        Exit Function
    '    End If

    '    Dim Ret As String
    '    Dim Num As Integer
    '    Dim Repeat As Boolean
    '    Dim Chars As Integer
    '    Randomize()

    '    Chars = 26 * 2 + 10 '26 (a-z) + 26 (A-Z) + 10 (0-9)
    '    'a-z = 97-122
    '    'A-Z = 65-90
    '    '0-9 = 48-57

    '    For i = 1 To Length
    '        Repeat = False

    '        Num = Int(Chars * Rnd())  'Int((upperbound - lowerbound + 1) * Rnd + lowerbound)

    '        If Num < 26 Then        'a-z
    '            If Lower Then
    '                Ret = Ret & Chr(Num + 97)
    '            Else
    '                Repeat = True
    '            End If
    '        ElseIf Num < 52 Then    'A-Z
    '            If Upper Then
    '                Ret = Ret & Chr(Num - 26 + 65)
    '            Else
    '                Repeat = True
    '            End If
    '        ElseIf Num < 62 Then    '0-9
    '            If Number Then
    '                Ret = Ret & Chr(Num - 52 + 48)
    '            Else
    '                Repeat = True
    '            End If
    '        End If

    '        If Repeat Then
    '            i = i - 1
    '        End If
    '    Next i

    '    RandomPassword = Ret
    'End Function


    'Public Function EjecutaProceso(ByVal mandato As String, ByVal argumentos As String) As Boolean

    '    Dim MiProceso As Process = New Process()
    '    Try
    '        MiProceso.StartInfo.FileName = mandato ' mandato
    '        MiProceso.StartInfo.Arguments = argumentos 'argumentos
    '        MiProceso.Start()  'iniciamos el proceso
    '        ' Controlamos el proceso...
    '        MiProceso.WaitForExit()

    '        Dim Codigo As Integer = MiProceso.ExitCode
    '        MiProceso.Dispose()
    '        If Codigo = 0 Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Win32Exception
    '        Dim x As String = ex.Message
    '        Return False
    '    End Try
    'End Function

End Class
