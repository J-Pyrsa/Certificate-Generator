Imports hobtools
Imports System.IO

Public Class checks
    Private _conf As xml_configfile
    Private _RutaCerts As String
    Private _cacert As String
    Private _cakey As String
    Private _ConfigFile As String
    Private _openssl_path As String
    Private _access2003_path As String
    Private _use_LDAP As String
    Private _Usuario_LDAP As String
    Private _Pass_LDAP As String
    Private _Direccion_LDAP As String
    Private _Dominio As String
    Private _config_xml As String

    Sub New(config_xml As String)
        ' TODO: Complete member initialization 
        _conf = New xml_configfile(config_xml)
        _config_xml = config_xml
    End Sub

    ''' <summary>
    ''' Verifica si el archivo de configuración está vacío o si algún parámetro está incorrecto
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function isEmpty_configFile() As Boolean
        Try
            _RutaCerts = _conf.getValue(_config_xml, "config", "RutaCerts")
            _cacert = _conf.getValue(_config_xml, "config", "cacert")
            _cakey = _conf.getValue(_config_xml, "config", "cakey")
            _ConfigFile = _conf.getValue(_config_xml, "config", "ConfigFile")
            _openssl_path = _conf.getValue(_config_xml, "config", "openssl_path")
            _access2003_path = _conf.getValue(_config_xml, "config", "access2003_path")
            _use_LDAP = _conf.getValue(_config_xml, "config", "use_LDAP")
            _Usuario_LDAP = _conf.getValue(_config_xml, "config", "Usuario_LDAP")
            _Pass_LDAP = _conf.getValue(_config_xml, "config", "Pass_LDAP")
            _Direccion_LDAP = _conf.getValue(_config_xml, "config", "Direccion_LDAP")
            _Dominio = _conf.getValue(_config_xml, "config", "Dominio")

            If (_RutaCerts = Nothing) Or (_cacert = Nothing) Or (_cakey = Nothing) Or _
                (_ConfigFile = Nothing) Or (_openssl_path = Nothing) Or (_access2003_path = Nothing) Or _
                (_Usuario_LDAP = Nothing) Or (_use_LDAP = Nothing) Or (_Pass_LDAP = Nothing) Or _
                (_Direccion_LDAP = Nothing) Or (_Dominio = Nothing) Then
                Return True
            End If
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            Return True
        End Try
        Return False
    End Function
    ''' <summary>
    ''' Verifica si existe o no el archivo o la ruta
    ''' </summary>
    ''' <param name="_value">El varlor en el XML</param>
    ''' <param name="_type">0 = Ruta, 1 = Archivo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function does_path_exist(_value As String, _type As Integer) As Boolean
        Dim result As String = String.Empty
        Try
            result = _conf.getValue(_config_xml, "config", _value)
            If _type = 0 Then
                If Directory.Exists(result) = False Then
                    Return False
                Else
                    Return True
                End If
            End If
            If _type = 1 Then
                If File.Exists(result) = False Then
                    Return False
                Else
                    Return True
                End If
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function
End Class
