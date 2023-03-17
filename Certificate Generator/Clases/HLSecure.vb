Imports Microsoft.VisualBasic
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports System.IO

Public Class HLSecure
    Private _openssl_path As String
    Private _pwd As String
    Const _unlock As String = "RSAT34MB34N_2637664B634J"

    Sub New(openssl_path As String, pwd As String)
        ' TODO: Complete member initialization 
        _openssl_path = openssl_path
        _pwd = pwd
    End Sub


    Function RandomPassword(ByVal Length As Integer, Optional ByVal Upper As Boolean = True, Optional ByVal Number As Boolean = True, Optional ByVal Lower As Boolean = True) As String
        If Not Upper And Not Lower And Not Number Then
            RandomPassword = ""
            Exit Function
        End If

        Dim Ret As String = String.Empty
        Dim Num As Integer
        Dim Repeat As Boolean
        Dim Chars As Integer
        Randomize()

        Chars = 26 * 2 + 10 '26 (a-z) + 26 (A-Z) + 10 (0-9)
        'a-z = 97-122
        'A-Z = 65-90
        '0-9 = 48-57

        For i = 1 To Length
            Repeat = False

            Num = Int(Chars * Rnd())  'Int((upperbound - lowerbound + 1) * Rnd + lowerbound)

            If Num < 26 Then        'a-z
                If Lower Then
                    Ret = Ret & Chr(Num + 97)
                Else
                    Repeat = True
                End If
            ElseIf Num < 52 Then    'A-Z
                If Upper Then
                    Ret = Ret & Chr(Num - 26 + 65)
                Else
                    Repeat = True
                End If
            ElseIf Num < 62 Then    '0-9
                If Number Then
                    Ret = Ret & Chr(Num - 52 + 48)
                Else
                    Repeat = True
                End If
            End If

            If Repeat Then
                i = i - 1
            End If
        Next i

        RandomPassword = Ret
    End Function

    Public Function EjecutaProceso(ByVal _mandato As String, ByVal argumentos As String) As Boolean
        Try
            Dim myProcess As New Process()
            ' Start a new instance of this program but specify the 'spawned' version.
            Dim myProcessStartInfo As New ProcessStartInfo(_mandato, argumentos)
            myProcessStartInfo.UseShellExecute = False
            myProcessStartInfo.CreateNoWindow = True
            myProcessStartInfo.RedirectStandardOutput = True
            myProcess.StartInfo = myProcessStartInfo
            myProcess.Start()
            myProcess.WaitForExit()
            Dim Codigo As Integer = myProcess.ExitCode
            myProcess.Dispose()
            If Codigo = 0 Then
                Return True
            Else
                Return False
            End If
            myProcess.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
