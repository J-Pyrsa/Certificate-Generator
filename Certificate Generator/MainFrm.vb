Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Data.OleDb
Imports System.Configuration
Imports hobtools
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography.X509Certificates

Public Class MainFrm
    'Private DirDelLog As String = IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Logs\Log.txt"
    Private DirDelLog As String
    Private _rastreo As rastreo

    Private cn As String
    Private givenName As String
    Private sn As String
    Private emailAddress As String
    Private telefono As String
    Private _Duration As Integer
    Private _KeySize As Integer
    Private _ProcesarAD As String

    Dim Ruta As String
    Dim client_priv As String
    Dim cacert As String
    Dim cakey As String
    Dim useLDAP As Integer
    Dim ConfigFile As String
    Dim pass_Client_key As String
    Dim _access2003_path As String
    Dim Password As String
    Dim rutacerts As String
    Dim petic_cert_client As String
    Dim ClienteCertPem As String
    Dim _Cliente_CertPer As String
    Dim OpenSSL_path As String

    Dim LlaveStatus As String
    Dim PeticionStatus As String
    Dim CertificadoStatus As String
    Dim CertHOBEA_Status As String
    Dim CertPertStatus As String
    Dim DbStatus As String
    Dim exito As Integer
    Dim fracaso As Integer
    Dim ADstatus As String

    Dim userdata_path As String
    Dim userconfig_file As String
    Dim chm_file As String

    Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        _rastreo = New rastreo
        userdata_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\HOB\Certificate Generator"
        DirDelLog = userdata_path & "\Logs\Log.txt"
        userconfig_file = userdata_path & "\config.xml"
    End Sub

    Sub InitVariables()

        'Obtenemos los datos de configuración
        Dim _Config As New hobtools.xml_configfile(userconfig_file)

        Ruta = _Config.getValue(userconfig_file, "config", "RutaCerts") & "\"
        rutacerts = Ruta
        cacert = """" & _Config.getValue(userconfig_file, "config", "cacert") & """"
        cakey = """" & _Config.getValue(userconfig_file, "config", "cakey") & """"
        ConfigFile = """" & _Config.getValue(userconfig_file, "config", "ConfigFile") & """"
        _access2003_path = """" & _Config.getValue(userconfig_file, "config", "access2003_path") & """"
        'OpenSSL_path = """" & _Config.getValue("config.xml", "config", "openssl_path") & """"
        OpenSSL_path = "openssl"

        useLDAP = CInt(_Config.getValue(userconfig_file, "config", "use_LDAP"))
        ' Si se pone un valor diferente de 1, pe, 0, -2, 10, etc... asumimos que NO
        ' se va a usar el LDAP, el único valor que activa la característica es "1"
        If useLDAP <> 1 Then
            useLDAP = 0
        End If

        Dim _v As New verificaciones
        Dim Validacion(6) As Boolean
        Dim _color_aviso As New Color
        _color_aviso = Color.LightPink

        Dim hls As New HLSecure(OpenSSL_path, pass_Client_key)
        'Esta contraseña es la que se envia junto con el certificado, no confundir con la contrasela de la llave privada
        Password = hls.RandomPassword(8)
        pass_Client_key = hls.RandomPassword(8)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        chm_file = Application.StartupPath & "\Certificate Generator.chm"
        'HelpProvider1.HelpNamespace = chm_file
        If Directory.Exists(userdata_path) = False Then
            Try
                Directory.CreateDirectory(userdata_path)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        Me.Text = My.Application.Info.ProductName & ", " & String.Format("Versión {0}", My.Application.Info.Version.ToString)
        Dim ch As New checks(userconfig_file)
        Dim co As New xml_configfile(userconfig_file)

        If File.Exists(userconfig_file) = False Then
            If co.CreaMachoteXML(userdata_path, Application.StartupPath) = False Then
                MsgBox("Error al crear el archivo de configuración por defecto")
            End If
        End If
    End Sub

    Private Sub Crear_Btn_Click(sender As System.Object, e As System.EventArgs) Handles Crear_Btn.Click
        'Le indicamos al BackgroundWorker que puede reportar progresos
        DataGridView1.AllowUserToAddRows = False
        Salida_txt.Visible = True
        Salida_txt.Clear()
        Bw1.WorkerReportsProgress = True
        'Le decimos al BackgroundWorker que puede ser cancelado en cualquier momento
        Bw1.WorkerSupportsCancellation = True
        'Iniciamos el proceso pesado
        Bw1.RunWorkerAsync()
        'Crear_Btn.Enabled = False
        btnCancelar.Enabled = True
        pB1.Visible = True
        StatusStrip1.Visible = True

    End Sub

    Private Sub Cargar_btn_Click(sender As System.Object, e As System.EventArgs) Handles Cargar_btn.Click
        'http://www.codeproject.com/KB/vb/DataGridView_and_CSV.aspx
        Try
            Dim fName As String = ""
            OpenFileDialog1.InitialDirectory = "c:\"
            OpenFileDialog1.Filter = "CSV files (*.csv)|*.CSV"
            OpenFileDialog1.FilterIndex = 2
            OpenFileDialog1.RestoreDirectory = True

            If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
                fName = OpenFileDialog1.FileName
            End If

            Dim TextLine As String = ""
            Dim SplitLine() As String

            If File.Exists(fName) = True Then
                Dim s As Integer = DataGridView1.Rows.Count
                If s >= 2 Then
                    DataGridView1.Rows.Clear()
                End If
                Dim objReader As New StreamReader(fName, System.Text.Encoding.Default)
                Try
                    Do While objReader.Peek() <> -1
                        TextLine = objReader.ReadLine()
                        SplitLine = Split(TextLine, ",")
                        'cn,OU,givenName,sn,mail,telefono
                        If Not SplitLine(0) = "cn" Then
                            cn = SplitLine(0) ' cn = s239762
                            givenName = SplitLine(1) ' givenName = César Erwin
                            sn = SplitLine(2) ' sn (surname) = Palma Soto
                            emailAddress = SplitLine(3)
                            telefono = SplitLine(4)
                            _Duration = SplitLine(5)
                            _KeySize = SplitLine(6)
                            _ProcesarAD = (SplitLine(7)).ToUpper
                            Me.DataGridView1.Rows.Add(SplitLine)
                            Me.DataGridView1.Visible = True
                            Crear_Btn.Enabled = True
                        End If
                    Loop
                Catch ex As Exception
                    _rastreo.ErrorLog(DirDelLog, ex.Message, "error", True)
                    MsgBox(ex.Message)
                Finally
                    objReader.Close()
                    ToolStripStatusLabel1.Text = "Certificados leídos desde el archivo CVS: " & DataGridView1.Rows.Count - 1
                    Crear_Btn.Enabled = True
                End Try
            End If
        Catch ex As Exception
            _rastreo.ErrorLog(DirDelLog, ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        ShowConfigFrm()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ShowConfigFrm()
    End Sub

    Private Sub ControlDeVersionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ControlDeVersionesToolStripMenuItem.Click
        history.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Bw1.CancelAsync()
    End Sub

    Private Sub Bw1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles Bw1.DoWork
        Try
            'StatusStrip1.Visible = True
            Dim a As Integer = DataGridView1.Rows.Count
            Dim DbResult As String
            Dim hls As New HLSecure(OpenSSL_path, pass_Client_key)

            exito = 0
            fracaso = 0
            If a = 0 Then
                Bw1.CancelAsync()
                MsgBox("se debe colocar al menos un certificado a crear")
            Else
                For p As Integer = 0 To (a - 1)
                    'Pregunta si está pendiente de cancelación
                    If Bw1.CancellationPending Then
                        'Si hay cancelacion, cancelamos y terminamos el for
                        e.Cancel = True
                        Exit For
                    End If
                    ' Comenzamos a crear los machotes
                    Try
                        cn = DataGridView1.Rows(p).Cells(0).Value.ToString()
                    Catch ex As Exception
                        MsgBox("El campo CN es requerido verifique sus datos y vuelva a Intentarlo")
                        Exit Sub
                    End Try
                    Try
                        givenName = DataGridView1.Rows(p).Cells(1).Value.ToString()
                    Catch ex As Exception
                        MsgBox("El campo givenName es requerido verifique sus datos y vuelva a Intentarlo")
                        Exit Sub
                    End Try
                    Try
                        sn = DataGridView1.Rows(p).Cells(2).Value.ToString()
                    Catch ex As Exception
                        MsgBox("El campo SN es requerido verifique sus datos y vuelva a Intentarlo")
                        Exit Sub
                    End Try
                    Try
                        emailAddress = DataGridView1.Rows(p).Cells(3).Value.ToString()
                    Catch ex As Exception
                        emailAddress = " "
                        _rastreo.ErrorLog(DirDelLog, "Advertencia: no ese estableció correo electrónico alguno para el usuario " & cn & vbTab & ex.Message, "error", True)
                    End Try
                    Try
                        telefono = DataGridView1.Rows(p).Cells(4).Value.ToString()
                        If telefono = "" Then
                            telefono = " "
                        End If
                    Catch ex As Exception
                        telefono = " "
                        _rastreo.ErrorLog(DirDelLog, "Advertencia: no ese estableció el teléfono," & ex.Message, "error", True)
                    End Try
                    Try
                        _Duration = CDec(DataGridView1.Rows(p).Cells(5).Value)
                        If _Duration = Nothing Then
                            _Duration = "365"
                        End If
                    Catch ex As Exception
                        _Duration = "365"
                    End Try
                    Try
                        _KeySize = CDec(DataGridView1.Rows(p).Cells(6).Value)
                        If _KeySize = Nothing Then
                            _KeySize = 2048
                        End If
                    Catch ex As Exception
                        _KeySize = 2048
                    End Try
                    Try
                        _ProcesarAD = DataGridView1.Rows(p).Cells(7).Value.ToString().ToUpper
                        If _ProcesarAD.ToUpper <> "NO" Then
                            If _ProcesarAD.ToUpper <> "SI" Then
                                _ProcesarAD = "NO"
                                ADstatus = "No se va a procesar el certificado en el Active Directory, debido a que el valor procesarAD es diferente de SI o NO"
                            End If
                        End If
                        If _ProcesarAD = "" Then
                            _ProcesarAD = "NO"
                        End If
                    Catch ex As Exception
                        _rastreo.ErrorLog(DirDelLog, "Advertencia: por defecto el usuario no se va a procesar en el Active Directory," & ex.Message, "error", True)
                        _ProcesarAD = "NO"
                        ADstatus = "No se va a procesar el certificado en el Active Directory, valor por defecto NO"
                    End Try
                    InitVariables()

                    Ruta = """" & Ruta & cn

                    client_priv = Ruta & "_key.key"""
                    petic_cert_client = Ruta & "_peticion.pem """
                    ClienteCertPem = Ruta & "_certificado.pem"""
                    _Cliente_CertPer = Ruta & "_(Personal).pfx"""

                    If emailAddress = "" Then
                        emailAddress = " "
                    End If
                    ' Creamos la llave para el usaurio
                    Dim key_command As String = String.Format("genrsa -des3 -out {0} -passout pass:{1} {2}", client_priv, pass_Client_key, _KeySize)
                    Dim request_command As String = "req -new -key " & client_priv & " -passin pass:" & pass_Client_key & " -subj ""/CN=" & cn & "/givenName=" & givenName & "/surname=" & sn & "/emailAddress=" & emailAddress & "/dnQualifier=" & cn & """ -out " & petic_cert_client
                    Dim certificate_command As String = "x509 -CA " & cacert & " -CAkey " & cakey & " -req -in " & petic_cert_client & " -set_serial 3 -days " & _Duration & " -extfile " & ConfigFile & " -sha1  -out " & ClienteCertPem
                    Dim DerToPfx_command As String = "pkcs12 -export -in " & ClienteCertPem & " -inkey " & client_priv & " -certfile " & cacert & " -out " & _Cliente_CertPer & " -passin pass:" & pass_Client_key & " -passout pass:" & Password

                    _rastreo.ErrorLog(DirDelLog, "Iniciando el proceso para la creación del certificado para " & cn, "mensaje", True)
                    '_rastreo.ErrorLog(DirDelLog, "uso del comando: " & key_command, True)
                    If hls.EjecutaProceso(OpenSSL_path, key_command) = True Then
                        LlaveStatus = "La llave " & client_priv & " se generó correctamente"
                        _rastreo.ErrorLog(DirDelLog, LlaveStatus, "informacion", True)
                        'Creamos la petición de certificado
                        _rastreo.ErrorLog(DirDelLog, "uso del comando: " & request_command, "informacion", True)
                        If hls.EjecutaProceso(OpenSSL_path, request_command) = True Then
                            PeticionStatus = "La petición " & petic_cert_client & " se generó correctamente"
                            _rastreo.ErrorLog(DirDelLog, PeticionStatus, "informacion", True)
                            'Firmamos el certificado
                            _rastreo.ErrorLog(DirDelLog, "uso del comando: " & certificate_command, "informacion", True)
                            If hls.EjecutaProceso(OpenSSL_path, certificate_command) = True Then
                                CertificadoStatus = "El certificado " & ClienteCertPem & " se generó correctamente"
                                _rastreo.ErrorLog(DirDelLog, CertificadoStatus, "informacion", True)
                                'Creamos el certifciado .DER para el HOBEA
                                If hls.EjecutaProceso(OpenSSL_path, DerToPfx_command) = True Then
                                    CertPertStatus = "El certificado Personal " & _Cliente_CertPer & " se generó correctamente"
                                    _rastreo.ErrorLog(DirDelLog, CertPertStatus, "informacion", True)
                                    If useLDAP = 1 Then
                                        If _ProcesarAD = "SI" Then
                                            _rastreo.ErrorLog(DirDelLog, "Se va a procesar el usaurio al AD", "mensaje", True)
                                            Select Case add_ad(cn, ClienteCertPem)
                                                Case "OK"
                                                    ADstatus = "Certificado agregado correctamente al atributo del Active Directory"

                                                Case "UNE"
                                                    ADstatus = "No se encontró el usuario, creé el usuario, e importe este certificado manualmente."
                                            End Select
                                            _rastreo.ErrorLog(DirDelLog, "AD regesa" & ADstatus, "mensaje", True)
                                        End If
                                    Else
                                        Dim admessage As String = "Se encuentra deshabilitada la bandera para activar la conexión con LDAP, si requiere conexión con LDAP, actívela en el menú de configuración del programa"
                                        _rastreo.ErrorLog(DirDelLog, admessage, "mensaje", True)
                                        ADstatus = admessage
                                    End If
                                    Dim _db As New DB(_access2003_path, "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=")
                                    Dim ahora As Date = Now.ToString("d")
                                    ' Si el CN existe en el access, entonces lo actualizamos, sino existe lo agregamos
                                    If _db.CuentaItems("select count(*) as res from usr where cn = """ & cn & """") = 0 Then
                                        ' Lo agregamops
                                        DbResult = _db.insertar("insert into usr (cn,sn,givenname,mail,telefono,passcert,PassKey,cantidadanos,fechaemision,fechavencimiento,proveedor) values (""" & cn & """, """ & sn & """, """ & givenName & """, """ & emailAddress & """, """ & telefono & """, """ & Password & """, """ & pass_Client_key & """, 1, #" & ahora.ToString("d") & "#, #" & DateAdd("d", CDec(_Duration), ahora.ToString("d")) & "#, ""1"");")
                                        _rastreo.ErrorLog(DirDelLog, "DBResult " & DbResult, "mensaje", True)
                                        If DbResult = "1" Then
                                            DbStatus = "Se agregó el elemento " & cn & " a la base de datos"
                                        Else
                                            DbStatus = "ERROR: " & DbResult
                                        End If
                                    Else
                                        ' Lo editamos
                                        DbResult = _db.insertar("update usr set passcert =""" & Password & """, PassKey = """ & pass_Client_key & """, FechaEmision = #" & ahora.ToString("d") & "#, FechaVencimiento=#" & DateAdd("d", CDec(_Duration), ahora.ToString("d")) & "# where cn = """ & cn & """")
                                        _rastreo.ErrorLog(DirDelLog, "DbResult: " & DbResult, "mensaje", True)
                                        If DbResult = "1" Then
                                            DbStatus = "Se actualizó el elemento " & cn & " a la base de datos"
                                        Else
                                            DbStatus = "ERROR: " & DbResult
                                        End If
                                    End If
                                Else
                                    CertPertStatus = "ERROR: " & vbTab & "El certificado Personal " & _Cliente_CertPer & " NO se generó"
                                    _rastreo.ErrorLog(DirDelLog, CertPertStatus, "error", True)
                                End If
                            Else
                                CertificadoStatus = "ERROR: " & vbTab & "El certificado " & ClienteCertPem & " NO se generó"
                                _rastreo.ErrorLog(DirDelLog, CertificadoStatus, "error", True)
                            End If
                        Else
                            PeticionStatus = "ERROR: " & vbTab & "La petición " & petic_cert_client & " no se generó"
                            _rastreo.ErrorLog(DirDelLog, PeticionStatus, "error", True)
                        End If
                    Else
                        LlaveStatus = "ERROR: " & vbTab & "La llave " & client_priv & " NO se generó"
                        _rastreo.ErrorLog(DirDelLog, LlaveStatus, "error", True)
                    End If
                    'Reportamos que hay progreso donde i es el porcentaje de avance
                    lbl_output.Text = "Creando certificado " & p + 1 & " de " & a
                    Bw1.ReportProgress((p * 100) / a)
                Next
                Dim response As MsgBoxResult
                response = MsgBox("Se completó con éxito el proceso, ¿desea abrir la ruta de destino?", MsgBoxStyle.YesNo, "Certificados")
                If response = MsgBoxResult.Yes Then
                    Dim p As New System.Diagnostics.Process
                    p.EnableRaisingEvents = False
                    p.Start("explorer.exe", """" & rutacerts & """")
                End If
            End If
        Catch ex As Exception
            _rastreo.ErrorLog(DirDelLog, ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Bw1_ProgressChanged(sender As System.Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles Bw1.ProgressChanged
        'Al reportar el progreso, actualizamos el progressBar
        Try
            pB1.Value = e.ProgressPercentage
            Dim mensaje As String = "Resultados de la creación del certificado para el usuario " & cn & " " & givenName
            Me.Salida_txt.AppendText(mensaje & vbNewLine)
            Me.Salida_txt.AppendText(PeticionStatus & vbNewLine)
            Me.Salida_txt.AppendText(CertificadoStatus & vbNewLine)
            Me.Salida_txt.AppendText(CertPertStatus & vbNewLine)
            Me.Salida_txt.AppendText(DbStatus & vbNewLine)
            Me.Salida_txt.AppendText(ADstatus & vbNewLine)
            Buscar_Coincidencia(mensaje, Salida_txt, Color.Blue, Color.Yellow)
        Catch ex As Exception
            _rastreo.ErrorLog(DirDelLog, ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Bw1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Bw1.RunWorkerCompleted
        'Este código se ejecuta al terminar el trabajo
        If e.Cancelled Then
            'Se muestra si fue cancelado manualmente
            MsgBox("Se canceló el proceso de creación de certificados")
        ElseIf e.Error IsNot Nothing Then
            'Se muestra, si fue cancelado debido a un error
            MsgBox("Ocurrió un error al procesar los certificados")
        Else
            'Se muestra si termino correctamente
        End If
        Crear_Btn.Enabled = True
        btnCancelar.Enabled = False
        StatusStrip1.Visible = False
        DataGridView1.AllowUserToAddRows = True
        pB1.Value = 0



    End Sub

    Private Sub ListadoDeCertificadosEmitidosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListadoDeCertificadosEmitidosToolStripMenuItem.Click
        Dim ListadoCertificados As New ListadoCertificados(userconfig_file, DirDelLog, chm_file)
        ListadoCertificados.Show()
    End Sub

    Private Sub ConsultarLDAPToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarLDAPToolStripMenuItem.Click
        Dim _Config As New hobtools.xml_configfile(userconfig_file)
        'Dim ListadoLDAP As New ListadoLDAP(userconfig_file, DirDelLog, chm_file)
        'If CInt(_Config.getValue(userconfig_file, "config", "use_LDAP")) = 1 Then
        '    ListadoLDAP.ShowDialog()
        'Else
        '    MsgBox("LA conexión con LDAP está deshabilitada")
        'End If

        Dim listadoldap As New LDAPlst_frm(userconfig_file, DirDelLog, chm_file)
        If CInt(_Config.getValue(userconfig_file, "config", "use_ldap")) = 1 Then
            listadoldap.Show()
        Else
            MsgBox("la conexión con ldap está deshabilitada")
        End If

    End Sub

    Private Sub VerificaciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerificaciónToolStripMenuItem.Click
        Dim ValidacionFrm As New ValidacionFrm(userconfig_file, DirDelLog, chm_file)
        ValidacionFrm.ShowDialog()
    End Sub

    Function add_ad(_cn As String, filename As String) As String
        Dim Config As New xml_configfile(userconfig_file)
        Dim arreglo(3) As String
        arreglo = Config.Conexion_LDAP(userconfig_file)
        Dim r As New hob_LDAP(arreglo(0), arreglo(1), arreglo(2), DirDelLog, True)
        Dim p As String = r.AgregarCertLDAP(_cn, filename)
        Return p
    End Function

    Private Sub Buscar_Coincidencia( _
            ByVal pattern As String, _
            ByVal RichTextBox As RichTextBox, _
            ByVal cColor As Color, _
            ByVal BackColor As Color)

        Dim Resultados As MatchCollection
        Dim Palabra As Match

        Try
            ' PAsar el pattern e indicar que ignore las mayúsculas y minúsculas al mosmento de buscar  
            Dim obj_Expresion As New Regex(pattern.ToString, RegexOptions.IgnoreCase)
            ' Ejecutar el método Matches para buscar la cadena en el texto del control  
            ' y retornar un MatchCollection con los resultados  
            Resultados = obj_Expresion.Matches(RichTextBox.Text)

            ' quitar el coloreado anterior  
            With RichTextBox
                .SelectAll()
                .SelectionColor = Color.Black
            End With
            ' Si se encontraron coincidencias recorre las colección    
            For Each Palabra In Resultados
                With RichTextBox
                    .SelectionStart = Palabra.Index ' comienzo de la selección  
                    .SelectionLength = Palabra.Length ' longitud de la cadena a seleccionar  
                    .SelectionColor = cColor ' color de la selección  
                    .SelectionBackColor = BackColor
                    Debug.Print(Palabra.Value)
                End With
            Next Palabra
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'Dim UserDetail As New UserDetail("s239762", ConfigFile, DirDelLog)
        'UserDetail.ShowDialog()

        'PrincipalTst.ShowDialog()
        Dim hl As New HlSet
        Dim PassDese As String = hl.m_decrypt_password("TQoiaW0MgmFNDEJjrQTiYq0MYmo=", "cn=administrator,cn=users")

    End Sub

    Private Sub VerRegistroToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerRegistroToolStripMenuItem.Click
        Dim LogsFrm As New LogsFrm("", chm_file)
        LogsFrm.Show()
    End Sub

    Private Sub ShowConfigFrm()
        Dim ConfigFrm As New ConfigFrm(userconfig_file, chm_file, DirDelLog)
        ConfigFrm.ShowDialog()
    End Sub

    Private Sub TópicosDeAyudaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TópicosDeAyudaToolStripMenuItem.Click
        Try
            Help.ShowHelp(ParentForm, chm_file, HelpNavigator.TopicId, "0")
        Catch ex As Exception
            _rastreo.ErrorLog(DirDelLog, "Error al tratar de acceder al archivo de ayuda " & chm_file & " desde " & Me.Text & ". Mensaje: " & ex.Message, "error", True)
        End Try
    End Sub

    Private Sub MainFrm_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'If e.KeyCode = Keys.F1 And e.Alt Then
        'If e.KeyCode = Keys.F1 Then
        '    Help.ShowHelp(ParentForm, chm_file, HelpNavigator.TopicId, "36")
        'End If
        If e.KeyCode = Keys.F1 Then
            Try
                Help.ShowHelp(ParentForm, chm_file, HelpNavigator.TopicId, "36")
            Catch ex As Exception
                _rastreo.ErrorLog(DirDelLog, "Error al tratar de acceder al archivo de ayuda " & chm_file & " desde " & Me.Text & ". Mensaje: " & ex.Message, "error", True)
            End Try
        End If
    End Sub

    Private Sub CreaciónDeCertificadosDeUsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreaciónDeCertificadosDeUsuarioToolStripMenuItem.Click
        Try
            Help.ShowHelp(ParentForm, chm_file, HelpNavigator.TopicId, "8")
        Catch ex As Exception
            _rastreo.ErrorLog(DirDelLog, "Error al tratar de acceder al archivo de ayuda " & chm_file & " desde " & Me.Text & "elemento " & CreaciónDeCertificadosDeUsuarioToolStripMenuItem.Text & ". Mensaje: " & ex.Message, "error", True)
        End Try
    End Sub

    Private Sub ApéndiceACrearHLUnitsSinLlavesPúblicasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ApéndiceACrearHLUnitsSinLlavesPúblicasToolStripMenuItem.Click
        Try
            Help.ShowHelp(ParentForm, chm_file, HelpNavigator.TopicId, "12")
        Catch ex As Exception
            _rastreo.ErrorLog(DirDelLog, "Error al tratar de acceder al archivo de ayuda " & chm_file & " desde " & Me.Text & "elemento " & ApéndiceACrearHLUnitsSinLlavesPúblicasToolStripMenuItem.Text & ". Mensaje: " & ex.Message, "error", True)
        End Try
    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As System.Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        'http://www.recursosvisualbasic.com.ar/htm/vb-net/59-solo-numeros-en-datagridview.htm
        Dim validar As TextBox = CType(e.Control, TextBox)
        ' agregar el controlador de eventos para el KeyPress  
        AddHandler validar.KeyPress, AddressOf validar_Keypress
    End Sub

    Private Sub validar_Keypress( _
        ByVal sender As Object, _
        ByVal e As System.Windows.Forms.KeyPressEventArgs)

        ' obtener indice de la columna  
        Dim columna As Integer = DataGridView1.CurrentCell.ColumnIndex

        ' comprobar si la celda en edición corresponde a la columna 1 o 3  
        If columna = 5 Or columna = 6 Then

            ' Obtener caracter  
            Dim caracter As Char = e.KeyChar
            ' comprobar si el caracter es un número o el retroceso  
            If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False Then
                'Me.Text = e.KeyChar  
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub

    Private Sub LimpiarRejilla_Btn_Click(sender As System.Object, e As System.EventArgs) Handles LimpiarRejilla_Btn.Click
        If DataGridView1.Rows.Count > 1 Then
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows.Count = 1 Then
                    Salida_txt.Text = String.Empty
                    Exit Sub
                End If
                DataGridView1.Rows.RemoveAt(0)
            Next
        End If
    End Sub
End Class
