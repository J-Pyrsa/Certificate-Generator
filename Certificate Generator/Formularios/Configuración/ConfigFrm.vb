Imports System.IO
Imports hobtools

Public Class ConfigFrm
    'Dim _conf As New xml_configfile
    Private _conf As xml_configfile
    Private _RutaCerts As String
    Private _cacert As String
    Private _cakey As String
    Private _ConfigFile As String
    Private _ConfigFile_content As String
    Private _openssl_path As String
    Private _access2003_path As String
    Private _use_LDAP As Integer
    Private _Usuario_LDAP As String
    Private _Pass_LDAP As String
    Private _Direccion_LDAP As String
    Private _Dominio As String
    Private DirDelLog As String
    Private _rastreo As rastreo

    Public _Continuar_ As Boolean = False
    Private configMode As Boolean = False
    Dim _UserConfigFile As String
    Dim chm_file As String

    Sub New(UserConfigFile As String, _chm_file As String, _DirdelLog As String)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _UserConfigFile = UserConfigFile
        _conf = New xml_configfile(_UserConfigFile)
        'HelpProvider1.HelpNamespace = chm_file
        chm_file = _chm_file
        _rastreo = New rastreo
        DirDelLog = _DirdelLog
    End Sub

    Private Sub ConfigFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ch As New checks(_UserConfigFile)
        Try
            If ch.isEmpty_configFile = False Then
                _RutaCerts = _conf.getValue(_UserConfigFile, "config", "RutaCerts")
                _cacert = _conf.getValue(_UserConfigFile, "config", "cacert")
                _cakey = _conf.getValue(_UserConfigFile, "config", "cakey")
                _openssl_path = _conf.getValue(_UserConfigFile, "config", "openssl_path")
                _access2003_path = _conf.getValue(_UserConfigFile, "config", "access2003_path")

                _use_LDAP = _conf.getValue(_UserConfigFile, "config", "use_LDAP")
                _Usuario_LDAP = _conf.getValue(_UserConfigFile, "config", "Usuario_LDAP")
                _Pass_LDAP = _conf.getValue(_UserConfigFile, "config", "Pass_LDAP")
                _Direccion_LDAP = _conf.getValue(_UserConfigFile, "config", "Direccion_LDAP")
                _Dominio = _conf.getValue(_UserConfigFile, "config", "Dominio")


                RutaCerts_txt.Text = _RutaCerts
                cacert_txt.Text = _cacert
                cakey_txt.Text = _cakey
                DB_txt.Text = _access2003_path

                Select Case _use_LDAP
                    Case 0
                        GroupBox1.Enabled = False
                        CheckBox1.Checked = False
                    Case 1
                        CheckBox1.Enabled = True
                        CheckBox1.Checked = True
                End Select

                Usuario_LDAP_txt.Text = _Usuario_LDAP
                Pass_LDAP_txt.Text = _Pass_LDAP
                Dominio_txt.Text = _Dominio
                Direccion_LDAP_txt.Text = _Direccion_LDAP

                Dim s As String = _conf.getValue(_UserConfigFile, "config", "ConfigFile")
                ConfigFile_txt.Text = s

                If File.Exists(s) Then
                    ConfigFile_rtb.LoadFile(s, RichTextBoxStreamType.PlainText)
                Else
                    ConfigFile_rtb.Text = ""
                End If
            Else
                configMode = True
                Cancelar_btn.Enabled = False
            End If
        Catch ex As Exception
            _rastreo.ErrorLog(DirDelLog, "Error al cargar la ventana de configuración. Mensaje: " & ex.Message, "error", True)
        End Try
    End Sub

    Private Function Archivo() As String
        Try
            OpenFileDialog1.InitialDirectory = "c:\tmp\"
            OpenFileDialog1.Filter = "Archivos BASE 64(*.b64)|*.b64|Archivos PEM(*.pem)|*.pem|Archivos CER(*.cer)|*.cer|Todos los archivos(*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.RestoreDirectory = True
            OpenFileDialog1.FileName = ""

            If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
                Archivo = OpenFileDialog1.FileName
            Else
                Archivo = Nothing
            End If
        Catch ex As Exception
            _rastreo.ErrorLog(DirDelLog, "Error al abrir un archivo tipo .pem. b64. .cer. Mensaje: " & ex.Message, "error", True)
            MsgBox(ex.Message)
            Archivo = Nothing
        End Try
    End Function

    Private Function txts() As String
        Try
            OpenFileDialog1.InitialDirectory = "c:\tmp\"
            OpenFileDialog1.Filter = "Archivos de configuración(*.conf)|*.conf|Todos los archivos(*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.RestoreDirectory = True
            OpenFileDialog1.FileName = ""

            If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
                txts = OpenFileDialog1.FileName
            Else
                txts = Nothing
            End If
        Catch ex As Exception
            _rastreo.ErrorLog(DirDelLog, "Error al abrir el archivo " & OpenFileDialog1.FileName & ". Mensaje: " & ex.Message, "error", True)
            MsgBox(ex.Message)
            txts = Nothing
        End Try
    End Function

    Sub GuardarConfig()
        Try
            _conf.recordValue(_UserConfigFile, "config", "RutaCerts", RutaCerts_txt.Text)
            _conf.recordValue(_UserConfigFile, "config", "cacert", cacert_txt.Text)
            _conf.recordValue(_UserConfigFile, "config", "cakey", cakey_txt.Text)
            _conf.recordValue(_UserConfigFile, "config", "ConfigFile", ConfigFile_txt.Text)
            _conf.recordValue(_UserConfigFile, "config", "access2003_path", DB_txt.Text)
            _conf.recordValue(_UserConfigFile, "config", "Usuario_LDAP", _Usuario_LDAP_txt.Text)
            _conf.recordValue(_UserConfigFile, "config", "Pass_LDAP", _Pass_LDAP_txt.Text)
            _conf.recordValue(_UserConfigFile, "config", "Direccion_LDAP", _Direccion_LDAP_txt.Text)
            _conf.recordValue(_UserConfigFile, "config", "Dominio", _Dominio_txt.Text)

            If CheckBox1.Checked = False Then
                _conf.recordValue(_UserConfigFile, "config", "use_LDAP", "0")
            Else
                _conf.recordValue(_UserConfigFile, "config", "use_LDAP", "1")
            End If

            _Continuar_ = True
            Me.Close()
        Catch ex As Exception
            _rastreo.ErrorLog(DirDelLog, "Error al tratar de guardar la configuración. Mensaje: " & ex.Message, "error", True)
        End Try
        
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            With (FolderBrowserDialog1)
                .RootFolder = Environment.SpecialFolder.MyComputer
                If RutaCerts_txt.Text = Nothing Then
                    .SelectedPath = "C:\"
                Else
                    .SelectedPath = RutaCerts_txt.Text
                End If
                .Description = "Selecciona el directorio de salida para los certificados"
                If .ShowDialog = DialogResult.OK Then
                    RutaCerts_txt.Text = .SelectedPath
                End If
            End With

        Catch ex As Exception
            _rastreo.ErrorLog(DirDelLog, "Error al tratar de obtener la ruta para almacenar los certificados. Mensaje: " & ex.Message, "error", True)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim s As String = Archivo()
        If Not s = Nothing Then
            cacert_txt.Text = s
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ConfigFile_txt.Text = txts()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim s As String = Archivo()
        If Not s = Nothing Then
            cakey_txt.Text = s
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Try
            OpenFileDialog1.InitialDirectory = "c:\"
            OpenFileDialog1.Filter = "Base de Datos MS Access 2003(*.mdb)|*.mdb"
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.RestoreDirectory = True
            OpenFileDialog1.FileName = ""

            If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
                DB_txt.Text = OpenFileDialog1.FileName
            Else
                DB_txt.Text = Nothing
            End If
        Catch ex As Exception
            _rastreo.ErrorLog(DirDelLog, "Error al tratar de obtener el archivo de Base de datos. Mensaje: " & ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guardar_btn_Click(sender As System.Object, e As System.EventArgs) Handles Guardar_btn.Click
        GuardarConfig()
        configMode = False
    End Sub

    Private Sub ConfigFrm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'verifica cambios y errores, por ejemplo; sino existen los archivos o rutas y
        'la caducidad de la entidad Certifidadora
        If configMode = True Then
            Application.Exit()
        End If
    End Sub 'Form1_Closing

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            GroupBox1.Enabled = False
        Else
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub Ayuda_txt_Click(sender As System.Object, e As System.EventArgs) Handles Ayuda_txt.Click
        Try
            Help.ShowHelp(ParentForm, chm_file, HelpNavigator.TopicId, "23")
        Catch ex As Exception
            _rastreo.ErrorLog(DirDelLog, "Error al tratar de acceder al archivo de ayuda " & chm_file & ". Mensaje: " & ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try
    End Sub
End Class