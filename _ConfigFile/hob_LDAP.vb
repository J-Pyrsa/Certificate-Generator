Imports Microsoft.VisualBasic
Imports System.DirectoryServices
Imports System.Data
Imports System.Xml
Imports System.Security.Cryptography.X509Certificates
Imports System.Text


Public Class hob_LDAP

    Private _path_LDAP As String
    Private _usuario_LDAP As String
    Private _pwd_LDAP As String
    Dim _rastreo As rastreo
    Private _DirdelLog As String
    Sub New(Path_LDAP As String, Usuario_LDAP As String, Pwd_LDAP As String, DirdelLog As String, Logs As Boolean)
        _path_LDAP = Path_LDAP
        _usuario_LDAP = Usuario_LDAP
        _pwd_LDAP = Pwd_LDAP
        _DirdelLog = DirdelLog
        _rastreo = New rastreo
    End Sub

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Function testADConnection(_user_search As String) As String
        Try
            Dim objDirectoryEntry As New DirectoryEntry(_path_LDAP.ToString, _usuario_LDAP, _pwd_LDAP)
            Dim mySearcher As New DirectorySearcher(objDirectoryEntry)
            mySearcher.Filter = "(&(objectClass=user)(anr=" & _user_search & "))"

            Dim srcOUs As SearchResultCollection = mySearcher.FindAll()

            Dim y As String = srcOUs.Count.ToString
            For Each result In mySearcher.FindAll()
                Dim x As String = result.GetDirectoryEntry().Properties("cn").Value
            Next
            Return y
        Catch ex As Exception
            _rastreo.ErrorLog(_DirdelLog, "Error al verificar la coneción con Active Directory. Mensaje. " & ex.Message, "error", True)
            Return ex.Message
        End Try
    End Function

    ''' <summary>
    ''' Esta función devuelve el listado de usuarios que hay en el Directorio Activo
    ''' 
    ''' </summary>
    ''' <param name="busqueda"></param>
    ''' <returns>Un DataTable</returns>
    ''' <remarks></remarks>
    Public Function Listarusuarios(Optional ByVal busqueda As String = "todos") As DataTable
        Dim _certificados As certificados = New certificados
        Dim objDirectoryEntry As New DirectoryEntry(_path_LDAP.ToString, _usuario_LDAP, _pwd_LDAP)
        Dim mySearcher As New DirectorySearcher(objDirectoryEntry)

        'Establecemos los criteros de búsqueda para encontrar al Usuario B
        If busqueda = "todos" Then
            mySearcher.Filter = "(&(objectClass=user) (!objectClass=Computer))"
        Else
            mySearcher.Filter = "(&(objectClass=user)(anr=" & busqueda & "))"
        End If
        Try
            Dim tabla As DataTable = New DataTable()
            tabla.Columns.Add("cn")
            tabla.Columns.Add("sn")
            tabla.Columns.Add("GivenName")
            tabla.Columns.Add("passwordLastSet")
            tabla.Columns.Add("ExpCert")
            tabla.Columns.Add("CaducaCert")

            For Each result In mySearcher.FindAll()
                Dim reg As DataRow = tabla.NewRow()
                reg("cn") = result.GetDirectoryEntry().Properties("cn").Value
                reg("sn") = result.GetDirectoryEntry().Properties("sn").Value
                reg("GivenName") = result.GetDirectoryEntry().Properties("givenname").Value
                reg("passwordLastSet") = Convert.ToInt64(GetExpiration(CType(result.Properties("pwdLastSet")(0), Long))).ToString
                Dim Arreglo() As String = _certificados.info(result.GetDirectoryEntry().Properties("usercertificate").Value)
                reg("ExpCert") = Arreglo(0)
                reg("CaducaCert") = Arreglo(1)
                tabla.Rows.Add(reg)
                tabla.AcceptChanges()
            Next
            Return tabla
        Catch ex As Exception
            _rastreo.ErrorLog(_DirdelLog, "Error al tratar de listar los usuarios y crear el datatable. Mensaje. " & ex.Message, "error", True)
            Return Nothing
        End Try
    End Function

    Function listar_OUs() As DataTable
        Try
            Dim ADRootEntry As New DirectoryEntry(_path_LDAP, _usuario_LDAP, _pwd_LDAP)
            Dim searcher As New DirectorySearcher(ADRootEntry)
            Dim queryResults As SearchResultCollection
            Dim result As SearchResult
            Dim tblADOUs As New DataTable
            'dsADOUs.Tables("tblOUs")
            tblADOUs.Columns.Add("canonicalName")
            tblADOUs.Columns.Add("distinguishedName")
            tblADOUs.Columns.Add("name")

            searcher.PropertiesToLoad.Add("distinguishedName")
            searcher.PropertiesToLoad.Add("canonicalName")
            searcher.PropertiesToLoad.Add("name")
            searcher.Filter = "ObjectClass=organizationalUnit"
            queryResults = searcher.FindAll()

            For Each result In queryResults
                Dim rwDefaultUser As DataRow = tblADOUs.NewRow()
                rwDefaultUser("canonicalName") = result.Properties("canonicalName")(0)
                rwDefaultUser("distinguishedName") = result.Properties("distinguishedName")(0)
                rwDefaultUser("name") = result.Properties("name")(0)
                tblADOUs.Rows.Add(rwDefaultUser)
            Next
            'tblADOUs.Select("", "canonicalName ASC")
            Return tblADOUs
        Catch ex As Exception
            _rastreo.ErrorLog(_DirdelLog, "Error al tratar de obtener el listado de las OUs. Mensaje: " & ex.Message, "error", True)
            Return (Nothing)
        End Try
    End Function

    Function GetJWTSessions01(cn As String) As DataTable
        Dim ds As New DataSet

        Dim grupos() As String = GetGroups(cn)
        If grupos.Length <= 0 Then
            Return Nothing
        Else
            Try
                For z As Integer = 0 To (grupos.Count - 1)
                    Dim objDirectoryEntry As DirectoryEntry
                    Dim mySearcher As DirectorySearcher
                    objDirectoryEntry = New DirectoryEntry(_path_LDAP, _usuario_LDAP, _pwd_LDAP)
                    mySearcher = New DirectorySearcher(objDirectoryEntry)
                    mySearcher.Filter = "(&(objectClass=group)(anr=" & grupos(z) & "))"
                    Try
                        For Each result In mySearcher.FindAll()

                            Try
                                Dim jwtsessions() As Byte = result.GetDirectoryEntry().Properties("hobjwt").Value
                                If Not jwtsessions Is Nothing Then
                                    Dim xmlhob As New xml_hob
                                    ds.Tables.Add(xmlhob.jwt(jwtsessions, result.GetDirectoryEntry().Properties("distinguishedName").Value))
                                Else
                                    Return Nothing
                                End If
                            Catch ex As Exception
                                _rastreo.ErrorLog(_DirdelLog, "Error al tratar de obtener las sesiones de HOBLink JWT. Mensaje: " & ex.Message, "error", True)
                            End Try
                        Next
                        For b As Integer = 0 To ds.Tables.Count - 1
                            ds.Tables(0).Merge(ds.Tables(b))
                        Next
                    Catch ex As Exception
                        _rastreo.ErrorLog(_DirdelLog, "Tratando de conectarse al servidor LDAP o la tabla destino está corrupta. Mensaje: " & ex.Message, "error", True)
                        MsgBox(ex.Message)
                    End Try
                Next
                Return ds.Tables(0)
            Catch ex As Exception
                _rastreo.ErrorLog(_DirdelLog, "Error al tratar de armar la estructura de conexión al servidor LDAP. Mensaje: " & ex.Message, "error", True)
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End If
        Return Nothing
    End Function

    Public Function GetGroups(_filterAttribute As String) As String()
        Dim GruposArray() As String = Nothing

        Dim objDirectoryEntry As New DirectoryEntry(_path_LDAP.ToString, _usuario_LDAP, _pwd_LDAP)
        Dim search As DirectorySearcher = New DirectorySearcher(objDirectoryEntry)
        search.Filter = "(cn=" & _filterAttribute & ")"
        search.PropertiesToLoad.Add("memberOf")
        Dim groupNames As StringBuilder = New StringBuilder()
        Try
            Dim result As SearchResult = search.FindOne()
            Dim propertyCount As Integer = result.Properties("memberOf").Count
            Dim dn As String
            Dim equalsIndex, commaIndex
            Dim Grupos(propertyCount - 1) As String

            For propertyCounter As Integer = 0 To propertyCount - 1
                dn = CType(result.Properties("memberOf")(propertyCounter), String)

                equalsIndex = dn.IndexOf("=", 1)
                commaIndex = dn.IndexOf(",", 1)
                If (equalsIndex = -1) Then
                    Return Nothing
                End If
                'Grupos(propertyCounter) = CType(result.Properties("memberOf")(propertyCounter), String)
                Grupos(propertyCounter) = dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1)
            Next
            Return Grupos
        Catch ex As Exception
            _rastreo.ErrorLog(_DirdelLog, "Error al tratar obtener el listado de los grupos. Mensaje. " & ex.Message, "error", True)
            Return Nothing
        End Try
        Return Nothing
    End Function

    Public Function Convertir(ByVal contenido As Object) As String
        If contenido Is Nothing Then
            Return ""
        End If
        Try
            Dim _funciones As type_tools = New type_tools
            Dim USByte As Object = _funciones.ByteArrayToString(contenido)
            Return _funciones.Hexadecimal_Ascci(USByte)
        Catch ex As Exception
            _rastreo.ErrorLog(_DirdelLog, "Error al convertir. Mensaje. " & ex.Message, "error", True)
            Return ""
        End Try

    End Function
    ''' <summary>
    ''' Función que permite conocer los días que quedan para que una contraseña
    ''' caduque, la consulta se hace a MS Active Directory
    ''' </summary>
    ''' <param name="passwordLastSet"></param>
    ''' <param name="Dias">Días que se deben esperar para que una contraseña caduque,
    ''' esta información está dada por las políticas de Dominio.
    ''' </param>
    ''' <returns>Los días que quedan para que la contraseña caduque, en STRING</returns>
    Public Function GetExpiration(ByVal passwordLastSet As Long, Optional Dias As Integer = 30) As String
        Try
            ' Obtenemos el LongInteger de la contraseña
            ' y lo combertimos en formato de Fecha
            Dim pwdSet As DateTime = DateTime.FromFileTime(passwordLastSet)
            ' Una vez que tenemos la fecha, comparamos la ultima fecha en
            '  que fue configurada la contraseña con respecto a 30 días
            ' (que son lo que marcan las políticas del dominio), podría
            ' haber hecho un procedimiento para obtener los 30 días, pero
            ' como conozco ese valor, preferí ponerlo directamente.

            Dim whenPasswordExpires As Date = DateAdd("d", Dias, pwdSet)
            ' Por ultimo comparamos el último día en que se estableció la
            ' la contraseña con el día e n curso, y regresamos el valor

            Return DateDiff(DateInterval.Day, Now.Date, whenPasswordExpires)
        Catch ex As Exception
            _rastreo.ErrorLog(_DirdelLog, "Error al tratar de obtener la Fecha de expiración de la contraseña. Mensaje. " & ex.Message, "error", True)
            Return Nothing
        End Try
    End Function
    Public Function GetExpiration(ByVal fecha As DateTime) As Integer
        Try
            Dim tsResult As System.TimeSpan
            tsResult = fecha.Subtract(Date.Now)
            Return tsResult.Days
        Catch ex As Exception
            _rastreo.ErrorLog(_DirdelLog, "Error al tratar de obtener la Fecha de expiración de la contraseña. Mensaje. " & ex.Message, "error", True)
            Return Nothing
        End Try
    End Function
    ''' <summary>
    ''' Agregamos el certificado .der al atributo del usuario en el active directory
    ''' </summary>
    ''' <param name="username">cn del usuario, por ejemplo: s123456</param>
    ''' <param name="filename">ruta del archivo del certifiado</param>
    ''' <returns>OK,ex.message, UNE. UNE= Usuario no encontrado </returns>
    ''' <remarks></remarks>
    Function AgregarCertLDAP(ByVal username As String, filename As String) As String
        Dim Attribute As String = "userCertificate"

        'http://www.dotnetspark.com/links/14959-active-directory-password-history.aspx

        ' .Net code to set an Active Directory attribute to “not set”
        ' http://stackoverflow.com/questions/7990505/net-code-to-set-an-active-directory-attribute-to-not-set
        'http://www.codeproject.com/Articles/18102/Howto-Almost-Everything-In-Active-Directory-via-C

        Dim objDirectoryEntry As New DirectoryEntry(_path_LDAP.ToString, _usuario_LDAP, _pwd_LDAP)
        Dim deBase As New DirectoryEntry(_path_LDAP, _usuario_LDAP, _pwd_LDAP)

        ' Directory Search
        Try
            Dim dsLookForOUs As New DirectorySearcher(deBase)
            dsLookForOUs.Filter = "(&(objectClass=user)(anr=" & username & "))"
            dsLookForOUs.SearchScope = SearchScope.Subtree
            dsLookForOUs.PropertiesToLoad.Add(Attribute)
            Dim srcOUs As SearchResultCollection = dsLookForOUs.FindAll()
            If srcOUs.Count > 0 Then
                Dim _tools As New tools
                Dim cert As New X509Certificate2()
                Try
                    cert.Import(filename)
                Catch ex As Exception
                    cert.Import(filename.ToString.Replace("""", ""))
                End Try
                Dim a As String = cert.Subject
                Dim b As String = cert.Issuer
                Dim c As Byte() = cert.RawData
                Dim data_byte As Byte() = _tools.ReadBinaryFile(filename)
                Dim usrSID As Byte() = CType(c, Byte())
                For Each srOU As SearchResult In srcOUs
                    Dim de As DirectoryEntry = srOU.GetDirectoryEntry()
                    If de.Properties(Attribute).Value IsNot Nothing Then
                        de.Properties(Attribute).Value = Nothing
                        de.CommitChanges()
                        de.Properties("hobcert").Value = Nothing
                        de.CommitChanges()
                    End If
                    de.Properties(Attribute).Add(usrSID)
                    'de.Properties("hobcert").Add(a & vbNewLine & b)
                    de.CommitChanges()
                Next
                Return "OK"
            Else
                Return "UNE"
            End If
        Catch ex As Exception
            _rastreo.ErrorLog(_DirdelLog, "Error al tratar de agregar el certificado del usaurio " & username & " al Active Diretory. Mensaje. " & ex.Message, "error", True)
            MsgBox(ex.Message)
            Return ex.Message
        End Try
    End Function

  

End Class

'http://msdn.microsoft.com/en-us/library/aa746494(v=vs.85).aspx
'http://msdn.microsoft.com/en-us/library/aa746475(v=vs.85).aspx
'http://www.oav.net/mirrors/LDAP-ObjectClasses.html
'http://www.codeproject.com/KB/system/everythingInAD.aspx#46

'Functiones con Fechas 
'http://www.dotnetpuebla.com/portal/Foros/vb/1270.aspx