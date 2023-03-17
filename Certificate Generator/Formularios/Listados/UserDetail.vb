Imports System.IO
Imports hobtools
Imports System.DirectoryServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Text

Public Class UserDetail

    Dim _ConfigFile As String
    Private _DirDelLog As String
    Private _rastreo As rastreo
    Private cn As String
    Private jwtsessions As DataSet

    Sub New( _
           CommonName As String, _
           ConfigFile As String, _
           DirDelLog As String)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        cn = CommonName
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _ConfigFile = ConfigFile
        _rastreo = New rastreo
        _DirDelLog = DirDelLog

        jwtsessions = New DataSet
    End Sub

    Private Sub UserDetail_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        StatusStrip1.Visible = True
        Bw1.WorkerReportsProgress = True
        Bw1.WorkerSupportsCancellation = True
        Bw1.RunWorkerAsync()
        load_data()
    End Sub

    Sub load_data()
        If cn = "" Then
            MsgBox("No se ha seleccionado ningún usuario")
            Me.Close()
        End If
        Dim Config As New xml_configfile(_ConfigFile)
        Dim _certificados As certificados = New certificados
        Dim arreglo(3) As String

        arreglo = Config.Conexion_LDAP(_ConfigFile)
        Dim _hobldap As New hob_LDAP(arreglo(0), arreglo(1), arreglo(2), _DirDelLog, True)
        Dim xmlhob As New xml_hob

        'buscamos por usuario, nombre, etc
        Try
            Dim objDirectoryEntry As DirectoryEntry
            Dim mySearcher As DirectorySearcher

            'Establecemos los criteros de búsqueda para encontrar al Usuario

            objDirectoryEntry = New DirectoryEntry(arreglo(0), arreglo(1), arreglo(2))
            mySearcher = New DirectorySearcher(objDirectoryEntry)
            mySearcher.Filter = "(&(objectClass=user)(anr=" & cn & "))"

            Try
                For Each result In mySearcher.FindAll()
                    If Not result.GetDirectoryEntry().Properties("cn").Value = Nothing Then
                        UserDetailBox.Text = UserDetailBox.Text & " " & cn
                        givenname_txt.Text = result.GetDirectoryEntry().Properties("givenname").Value
                        sn_txt.Text = result.GetDirectoryEntry().Properties("sn").Value
                        Try
                            passwordLastSet_txt.Text = Convert.ToInt64(_hobldap.GetExpiration(CType(result.Properties("pwdLastSet")(0), Long))).ToString & " dia(s)"
                        Catch ex As Exception
                            passwordLastSet_txt.Text = "NA"
                        End Try

                        If Not result.GetDirectoryEntry().Properties("usercertificate").Value Is Nothing Then
                            Try
                                Dim certificado() As Byte = result.GetDirectoryEntry().Properties("usercertificate").Value

                                'Dim cert As New Chilkat.Cert()
                                Dim cert As New X509Certificate2(certificado)
                                'cert.LoadFromBinary(certificado)

                                If Not cert Is Nothing Then
                                    If cert.GetExpirationDateString < Now Then
                                        With CertificateStatus_lbl
                                            .Text = "Certificado expirado"
                                            .ForeColor = Color.Red
                                        End With
                                    Else
                                        With CertificateStatus_lbl
                                            .Text = "Certificado válido"
                                            .ForeColor = Color.Green
                                        End With
                                    End If
                                    Emisor_Label.Text = Emisor_Label.Text & RegresaCN(cert.IssuerName.Name)
                                    Subject_label.Text = Subject_label.Text & RegresaCN(cert.Subject)
                                    EfectivoDesde_txt.Text = cert.GetEffectiveDateString.ToString
                                    ExpiraCert_txt.Text = cert.GetExpirationDateString
                                    HashCode_lbl.Text = HashCode_lbl.Text & cert.GetHashCode
                                    Version_lbl.Text = Version_lbl.Text & cert.Version

                                    If cert.HasPrivateKey = False Then
                                        Clave_lbl.Text = Clave_lbl.Text & "No"
                                    Else
                                        Clave_lbl.Text = Clave_lbl.Text & "Si"
                                    End If

                                End If
                            Catch ex As Exception
                                MsgBox("Error al tratar de obtener los datos del certificado del usuario")
                            End Try
                        Else
                            With CertificateStatus_lbl
                                .Text = "El usuario no tiene un certificado instalado"
                                .ForeColor = Color.OrangeRed
                            End With
                        End If

                        If result.GetDirectoryEntry().Properties("hobjwt").Value Is Nothing Then
                            jwt_label.Text = jwt_label.Text & " 0"
                        Else
                            Try
                                Dim jwtsessions() As Byte = result.GetDirectoryEntry().Properties("hobjwt").Value

                                Dim dt_grp As New DataTable
                                Dim dt_usr As New DataTable
                                dt_usr = xmlhob.jwt(jwtsessions, "Propia")
                                Dim grupos As DataTable = _hobldap.GetJWTSessions01(cn)

                                dt_grp = _hobldap.GetJWTSessions01(cn)
                                If Not dt_grp Is Nothing Then
                                    dt_usr.Merge(dt_grp)
                                End If
                                Try
                                    DataGridView1.DataSource = dt_usr
                                    jwt_label.Text = jwt_label.Text & dt_usr.Rows.Count.ToString
                                    HeadreTitles()
                                Catch ex As Exception

                                End Try
                            Catch ex As Exception
                                _rastreo.ErrorLog(_DirDelLog, "Error al tratar de obtener las sesiones de HOBLink JWT. Mensaje: " & ex.Message, "error", True)
                            End Try

                            'UsersettingsLabel.Text = UsersettingsLabel.Text & "Por default"
                        End If
                    End If

                        If result.GetDirectoryEntry().Properties("hobhobte").Value Is Nothing Then
                            JTermLabel.Text = JTermLabel.Text & " NO"
                        Else
                            JTermLabel.Text = JTermLabel.Text & " Si"
                        End If
                        If result.GetDirectoryEntry().Properties("hobh").Value Is Nothing Then
                            FTPLabel.Text = FTPLabel.Text & " NO"
                        Else
                            FTPLabel.Text = FTPLabel.Text & " SI"
                        End If
                        If result.GetDirectoryEntry().Properties("hobj").Value Is Nothing Then
                            DoD_label.Text = DoD_label.Text & "NO"
                        Else
                            DoD_label.Text = DoD_label.Text & "SI"
                        End If
                        If result.GetDirectoryEntry().Properties("hobk").Value Is Nothing Then
                            WSPUCLabel.Text = WSPUCLabel.Text & "NO"
                        Else
                            WSPUCLabel.Text = WSPUCLabel.Text & "SI"
                        End If
                    If result.GetDirectoryEntry().Properties("hobl").Value Is Nothing Then
                        'TODO: listar página personal
                        UsersettingsLabel.Text = UsersettingsLabel.Text & "Por default"
                    Else
                        Dim UserSettings() As Byte = result.GetDirectoryEntry().Properties("hobl").Value
                        Dim x As String = xmlhob.GetUserSettings(UserSettings, "")
                        UsersettingsLabel.Text = UsersettingsLabel.Text & x
                    End If
                        Ou_txt.Text = result.GetDirectoryEntry().Properties("distinguishedName").Value().ToString
                Next
                Me.Text = "Detalles del usuario " & cn & " " & givenname_txt.Text & ", " & sn_txt.Text
            Catch ex As Exception
                _rastreo.ErrorLog(_DirDelLog, "Tratando de conectarse al servidor LDAP o la tabla destino está corrupta. Mensaje: " & ex.Message, "error", True)
                MsgBox(ex.Message)
            End Try
            'Next
        Catch ex As Exception
            _rastreo.ErrorLog(_DirDelLog, "Error al tratar de armar la estructura de conexión al servidor LDAP. Mensaje: " & ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Bw1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles Bw1.DoWork

    End Sub

    Private Sub Bw1_ProgressChanged(sender As System.Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles Bw1.ProgressChanged
        pB1.Value = e.ProgressPercentage
    End Sub

    Private Sub Bw1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Bw1.RunWorkerCompleted
        If e.Cancelled Then
            'Se muestra si fue cancelado manualmente
            MsgBox("SE CANCELO EL PROCESO")
        ElseIf e.Error IsNot Nothing Then
            'Se muestra, si fue cancelado debido a un error
            MsgBox("OCURRIO UN ERROR")
        Else
            'Proceso terminado correctamente
            
        End If
        pB1.Value = 0
        'pB1.Visible = False
        StatusStrip1.Visible = False
    End Sub

    Sub HeadreTitles()
        Try
            DataGridView1.Columns("JWT_schNm").HeaderText = "Sesión HOBLink JWT"
            DataGridView1.Columns("JWT_schNm").ToolTipText = "Es la sesión que se muestra en el administrador de Sesiones"
            DataGridView1.Columns("JWT_Schemes_Conn_stApp").HeaderText = "Ruta de la aplicación publicada"
            DataGridView1.Columns("JWT_Schemes_Conn_stApp").ToolTipText = "Si se encuentra en blanco quiere decir que está apuntando al escritorio"
            DataGridView1.Columns("JWT_Schemes_Conn_connType_name").HeaderText = "Tipo de conexión"
            DataGridView1.Columns("JWT_Schemes_Conn_connType_name").ToolTipText = "Directa, Balanceo de cargas, WSP Directa, etc..."
            DataGridView1.Columns("JWT_Schemes_Conn_wspGateName").HeaderText = "Nombre del socket"
            DataGridView1.Columns("JWT_Session_type").HeaderText = "Dueño de la sesión"
            DataGridView1.Columns("JWT_Session_type").ToolTipText = "La Sesión está configurada en: (propia o en el grupo)"
        Catch ex As Exception
            _rastreo.ErrorLog(_DirDelLog, "error al trata de establecer las cabezeras de la rejilla. Mensaje: " & ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function RegresaCN(Cadena As String) As String
        Dim emisor As String = CType(Cadena, String)
        Dim equalsIndex, commaIndex
        'equalsIndex = emisor.IndexOf("=", 1)
        equalsIndex = emisor.IndexOf("CN")

        Dim a As Integer = emisor.Count
        emisor = emisor.Substring(equalsIndex)

        equalsIndex = emisor.IndexOf("=", 1)
        commaIndex = emisor.IndexOf(",", 1)

        emisor = emisor.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1)
        Return emisor
    End Function

End Class