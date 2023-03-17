Option Explicit On
Option Strict On

Imports System.Data
Imports System.Security.Cryptography.X509Certificates
Imports System.Data.OleDb
Imports System.Text


Public Class certificados
    ''' 
    ''' <param name="sn"></param>
    Public Function Crear(ByVal sn As String) As Boolean
        Crear = False
    End Function

    ''' 
    ''' <param name="CertificateByte"></param>
    ''' <summary>"Regresa "</summary>
    Public Function info(ByVal CertificateByte As Byte()) As String()
        Dim result(5) As String
        If CertificateByte Is Nothing Then
            Return result
        End If
        Try
            Dim cert As New X509Certificate2(CertificateByte)

            ' CertificadoEfectivoDesde
            result(0) = cert.GetEffectiveDateString
            ' Certificado expira
            result(1) = cert.GetExpirationDateString
            result(2) = cert.GetSerialNumberString
            result(3) = cert.GetKeyAlgorithm

            Return result
        Catch ex As Exception
            ' Ponemos el LOG
            Dim x As String = ex.Message
            Return Nothing
        End Try
        info = Nothing
    End Function
End Class ' certificados