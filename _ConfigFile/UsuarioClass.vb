Imports Microsoft.VisualBasic
Imports System.Data
Imports System.DirectoryServices
Imports System.IO
Imports System.Xml

Public Class UsuarioClass

    Private _Usuario_LDAP As String
    Private _Pwd_LDAP As String
    Private _Path_LDAP As String
    Private _DirdelLog As String
    Private _rastreo As rastreo

    Sub New(Path_LDAP As String, Usuario_LDAP As String, Pwd_LDAP As String, DirdelLog As String)
        _Usuario_LDAP = Usuario_LDAP
        _Pwd_LDAP = Pwd_LDAP
        _Path_LDAP = Path_LDAP
        _DirdelLog = DirdelLog
        _rastreo = New rastreo
    End Sub

    ''' 
    ''' <param name="busqueda"></param>
    Public Function buscar(ByVal busqueda As String) As DataTable
        Dim _ldap As hob_LDAP = New hob_LDAP(_Path_LDAP, _Usuario_LDAP, _Pwd_LDAP, _DirdelLog, True)
        Try
            buscar = _ldap.Listarusuarios(busqueda)
        Catch ex As Exception
            'LOG
            _rastreo.ErrorLog(_DirdelLog, "Error al tratar de realizar la búsqueda " & busqueda & ". Mensaje. " & ex.Message, "error", True)
            buscar = Nothing
        End Try
    End Function

End Class
