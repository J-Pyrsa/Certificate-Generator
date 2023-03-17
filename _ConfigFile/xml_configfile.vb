Imports System.Xml
Imports System.IO

Public Class xml_configfile
    Private _ConfigFile As String
    Sub New(ConfigFile As String)
        _ConfigFile = ConfigFile
    End Sub

    Public Function getValue(ByVal ArchivoXml As String, ByVal _nodo As String, ByVal indice As Integer) As String
        Dim m_xmld As New XmlDocument
        Dim m_nodelist As XmlNodeList
        Dim m_node As XmlNode
        Try
            m_xmld.Load(ArchivoXml)
            m_nodelist = m_xmld.SelectNodes(_nodo)
            For Each m_node In m_nodelist
                Return m_node.ChildNodes.Item(indice).InnerText
            Next
        Catch ex As Exception
            'Todo: cambiar el MsBox, ya que podría usado este códuigo en una Web y allui no hay MsgBox
            MsgBox(ex.ToString())
            Return "error"
        End Try
        Return Nothing
    End Function

    Public Function getValue(ByVal sConfigFile As String, ByVal _nodo As String, ByVal indice As String)
        Try
            Dim ds As New DataSet
            ds.ReadXml(sConfigFile)
            Return ds.Tables(_nodo).Rows(0)(indice).ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub recordValue(ByVal sConfigFile As String, ByVal _nodo As String, ByVal indice As String, ByVal valor As String)
        Try
            Dim ds As New DataSet
            ds.ReadXml(sConfigFile)
            ds.Tables(_nodo).Rows(0)(indice) = valor
            ds.WriteXml(sConfigFile)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function CreaMachoteXML(UserData_path As String, SystemData_Path As String) As Boolean
        'verificamos que el archivo de configuración exista
        Try
            '<RutaCerts></RutaCerts>
            '<cacert></cacert>
            '<cakey></cakey>
            '<ConfigFile></ConfigFile>
            '<openssl_path></openssl_path>
            '<access2003_path></access2003_path>
            '<use_LDAP></use_LDAP>
            '<Usuario_LDAP></Usuario_LDAP>
            '<Pass_LDAP></Pass_LDAP>
            '<Dominio></Dominio>
            '<Direccion_LDAP></Direccion_LDAP>

            Dim CertificatesPath As String = UserData_path & "\certificates"
            If Directory.Exists(CertificatesPath) = False Then
                Try
                    System.IO.Directory.CreateDirectory(CertificatesPath)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            Dim OpeSSL_Path As String = String.Empty
            Dim AccessDB As String = UserData_path & "\bd1.mdb"
            'Dim AccessDB As String = Replace(UserData_path & "\bd1.mdb", "\bin", "")
            '

            If File.Exists(AccessDB) = False Then
                'File.Copy(SystemData_Path & "\samples\bd1.mdb", AccessDB)
                File.Copy(Replace(SystemData_Path & "\samples\bd1.mdb", "\bin", ""), AccessDB)
            End If

            If File.Exists("C:\OpenSSL-Win32\bin\openssl.exe") Then
                OpeSSL_Path = "C:\OpenSSL-Win32\bin\openssl.exe"
            Else
                OpeSSL_Path = "C:\OpenSSL\openssl.exe"
            End If


            Dim xml_template As String = "<?xml version=""1.0"" standalone=""yes""?>" & vbNewLine & _
                                         "<config>" & vbNewLine & _
                                             vbTab & "<RutaCerts>" & CertificatesPath & "</RutaCerts>" & vbNewLine & _
                                             vbTab & "<cacert>" & Replace(SystemData_Path & "\pki\demo_rootcacert.b64", "\bin", "") & "</cacert>" & vbNewLine & _
                                             vbTab & "<cakey>" & Replace(SystemData_Path & "\pki\demo_rootcacert.rsapriv.pem", "\bin", "") & "</cakey>" & vbNewLine & _
                                             vbTab & "<ConfigFile>" & Replace(SystemData_Path & "\pki\config.conf", "\bin", "") & "</ConfigFile>" & vbNewLine & _
                                             vbTab & "<openssl_path>" & OpeSSL_Path & "</openssl_path>" & vbNewLine & _
                                             vbTab & "<access2003_path>" & AccessDB & "</access2003_path>" & vbNewLine & _
                                             vbTab & "<use_LDAP>0</use_LDAP>" & vbNewLine & _
                                             vbTab & "<Usuario_LDAP>Ldap User</Usuario_LDAP>" & vbNewLine & _
                                             vbTab & "<Pass_LDAP>password</Pass_LDAP>" & vbNewLine & _
                                             vbTab & "<Dominio>LDAP IP o DNS Address</Dominio>" & vbNewLine & _
                                             vbTab & "<Direccion_LDAP>Dominio de Windows</Direccion_LDAP>" & vbNewLine & _
                                         "</config>"
            CreaArchivoTexto(_ConfigFile, xml_template)
            Return True
        Catch ex As IO.IOException
            MsgBox(ex.Message)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function CreaArchivoTexto(ByVal TextFile As String, ByVal Linea As String) As Boolean
        Try
            Dim oSW As New StreamWriter(TextFile)
            oSW.WriteLine(Linea)
            oSW.Flush()
            oSW.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    ''' <summary>
    ''' Funciona para formar la estructura de Copnexión con LDAP
    ''' </summary>
    ''' <param name="configfile">La ruta del archivo de configuración</param>
    ''' <returns>
    ''' Arreglo(0) = Ruta de LDAP; LDAP://192.168.1.1
    ''' Arreglo(1) = Dominio\usuario: HOBTEST\usuario_ldap
    ''' Arreglo(2) = Contraseña del usuario de dominio
    ''' </returns>
    ''' <remarks></remarks>
    Public Function Conexion_LDAP(configfile As String) As String()
        Dim Arreglo(3) As String
        ' Obtenemos los datos del usuarioA desde el archivo properties.xml
        ' para después hacer una consulta sobre el usuario B
        ' Creamos las variables y las iniciamos
        Dim FileXML As String = configfile
        'Dim xmlRead As xml_configfile = New hobtools.xml_configfile
        Dim UsuarioA As String = getValue(configfile, "Config", "Usuario_LDAP")
        Dim PasswordA As String = getValue(configfile, "Config", "Pass_LDAP")
        Dim IP As String = getValue(configfile, "Config", "Direccion_LDAP")
        ' Dim Dominio As String = xmlRead.regresa_valor(FileXML, "Dominio")
        Dim Dominio As String = getValue(configfile, "Config", "Dominio")
        Dim Name As String = Nothing
        'Asignamos el adPath al elemenot 0 del arreglo 
        Arreglo(0) = "LDAP://" & IP
        'Asignamos el domainAndUsername al elemento 1
        Arreglo(1) = Dominio & "\" & UsuarioA
        'Asignamos el PasswordA al elemento 2
        Arreglo(2) = PasswordA
        Return Arreglo
    End Function

End Class
