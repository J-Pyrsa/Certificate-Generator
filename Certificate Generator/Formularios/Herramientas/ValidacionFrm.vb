Imports System.Environment
Imports hobtools
Imports System.Security.Cryptography.X509Certificates

Public Class ValidacionFrm

    Private _ConfigFile As String
    Private _DirDelLog As String
    Private _rastreo As rastreo
    Private chm_file As String

    Sub New(ConfigFile As String, DirDelLog As String, _chm_file As String)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _ConfigFile = ConfigFile
        _rastreo = New rastreo
        _DirDelLog = DirDelLog
        chm_file = _chm_file
    End Sub

    Private Sub ValidacionFrm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MakeDataTableAndDisplay()
        Validar()
    End Sub

    Private Sub Iniciar_btn_Click(sender As System.Object, e As System.EventArgs) Handles Iniciar_btn.Click
        MakeDataTableAndDisplay()
        Validar()
    End Sub

    Sub Validar()
        Try
            _rastreo.ErrorLog(_DirDelLog, " Iniciando el proceso de validación (" & Date.Now.ToString & ")====", "mensaje", True)
            Dim error_Path_OpenSSL As String = "OpenSSL en la variable %PATH%, ERROR: No se encontró la ruta de instalación de OpenSSL en la variable de entorno PATH"
            Dim error_OPENSSL_CONF As String = "OPENSSL_CONF en las variables de entorno, ERROR: No se ncontró la variable de entorno OPENSSL_CONF Este error se debe a: 1) no está instalado OpenSSL, b) no se instaló correctamente OpenSSL, c) está instalando OpenSSL en Windows 7"
            Dim error_RANDFILE As String = "RANDFILE en las variables de entorno WARRING: No se ncontró la variable de entorno RANDFILE Este debe a: 1) no está instalado OpenSSL, b) no se instaló correctamente OpenSSL, c) está instalando OpenSSL en Windows 7"

            If InStr(Environment.GetEnvironmentVariable("PATH"), "OpenSSL") = 0 Then
                DataGridView1.Item("Resultado", 0).Value = "ERROR"
                DataGridView1.Item("Observaciones", 0).Value = error_Path_OpenSSL
                _rastreo.ErrorLog(_DirDelLog, error_Path_OpenSSL, "error", True)
            Else
                DataGridView1.Item("Resultado", 0).Value = "OK"
                _rastreo.ErrorLog(_DirDelLog, "OpenSSL en la variable %PATH%", "OK", True)
            End If
            If Environment.GetEnvironmentVariable("OPENSSL_CONF") = Nothing Then
                DataGridView1.Item("Resultado", 1).Value = "ERROR"
                DataGridView1.Item("Observaciones", 1).Value = error_OPENSSL_CONF
                _rastreo.ErrorLog(_DirDelLog, error_OPENSSL_CONF, "error", True)
            Else
                DataGridView1.Item("Resultado", 1).Value = "OK"
                DataGridView1.Item("Observaciones", 1).Value = error_OPENSSL_CONF
                _rastreo.ErrorLog(_DirDelLog, "OPENSSL_CONF en las variables de entorno", "OK", True)
            End If
            If Environment.GetEnvironmentVariable("") = Nothing Then
                DataGridView1.Item("Resultado", 2).Value = "WARRING"
                DataGridView1.Item("Observaciones", 2).Value = error_RANDFILE
                _rastreo.ErrorLog(_DirDelLog, error_RANDFILE, "Advertencia", True)
            Else
                DataGridView1.Item("Resultado", 2).Value = "OK"
                _rastreo.ErrorLog(_DirDelLog, "RANDFILE en las variables de entorno", "OK", True)
            End If
            Dim _Config As New hobtools.xml_configfile(_ConfigFile)

            Dim OpenSSL_path As String = _Config.getValue(_ConfigFile, "config", "openssl_path")

            Dim _ver As New verificaciones
            If _ver.VerificaRuta(OpenSSL_path, "Archivo") = True Then
                DataGridView1.Item("Resultado", 3).Value = "OK"
                _rastreo.ErrorLog(_DirDelLog, "Path del OpenSSL " & OpenSSL_path, "OK", True)
            Else
                DataGridView1.Item("Resultado", 3).Value = "ERROR"
                DataGridView1.Item("Observaciones", 3).Value = "No se encontró la ruta " & OpenSSL_path & " Verifique las configuraciones del programa u OpenSSL no se encuentra instalado"
                _rastreo.ErrorLog(_DirDelLog, "No se encontró la ruta " & OpenSSL_path & " Verifique las configuraciones del programa u OpenSSL no se encuentra instalado", "error", True)
            End If
            Dim Ruta As String = _Config.getValue(_ConfigFile, "config", "RutaCerts")
            If _ver.VerificaRuta(Ruta, "DIR") = True Then
                DataGridView1.Item("Resultado", 4).Value = "OK"
                _rastreo.ErrorLog(_DirDelLog, "Ruta " & Ruta & " para el repositiorio de los certificados", "OK", True)
            Else
                DataGridView1.Item("Resultado", 4).Value = "ERROR"
                DataGridView1.Item("Observaciones", 4).Value = "No se encontró la ruta " & Ruta & " para el repositiorio de lso certificados, verifique las configuraciones del programa."
                _rastreo.ErrorLog(_DirDelLog, "No se encontró la ruta " & Ruta & " para el repositiorio de lso certificados, verifique las configuraciones del programa.", "ok", True)
            End If

            Dim cacert As String = _Config.getValue(_ConfigFile, "config", "cacert")
            If _ver.VerificaRuta(cacert, "Archivo") = True Then
                DataGridView1.Item("Resultado", 5).Value = "OK"
                _rastreo.ErrorLog(_DirDelLog, "Entidad certificadora", "OK", True)

                Dim CA_Certificate As New X509Certificate2(cacert)
                Dim f As Date = Date.Parse(CA_Certificate.GetExpirationDateString)
                Dim CalcDate As New hob_LDAP

                Dim r As Long = CalcDate.GetExpiration(f)
                If r >= 365 Then
                    DataGridView1.Item("Resultado", 9).Value = "OK"
                    DataGridView1.Item("Observaciones", 9).Value = "Quedan " & r & " para que caduque la entidad certificadora"
                    _rastreo.ErrorLog(_DirDelLog, "Quedan " & r & " para que caduque la entidad certificadora", "ok", True)
                Else
                    DataGridView1.Item("Resultado", 9).Value = "WARRING"
                    DataGridView1.Item("Observaciones", 9).Value = "Queda menos de un año para que la entidad certificadora caduque, tenga encuenta que los certificados tendrán duración de meses"
                    _rastreo.ErrorLog(_DirDelLog, "Queda menos de un año para que la entidad certificadora caduque, tenga encuenta que los certificados tendrán duración de meses", "advertencia", True)
                End If
            Else
                DataGridView1.Item("Resultado", 5).Value = "ERROR"
                DataGridView1.Item("Observaciones", 5).Value = "No se encuentra el certificado de la entidad certificadora " & cacert & ", verifique las configuraciones del programa."
                _rastreo.ErrorLog(_DirDelLog, "No se encuentra el certificado de la entidad certificadora " & cacert & ", verifique las configuraciones del programa.", "error", True)
            End If

            Dim cakey = _Config.getValue(_ConfigFile, "config", "cakey")
            If _ver.VerificaRuta(cacert, "Archivo") = True Then
                DataGridView1.Item("Resultado", 5).Value = "OK"
                _rastreo.ErrorLog(_DirDelLog, "Key de la CA", "ok", True)
            Else
                DataGridView1.Item("Resultado", 5).Value = "ERROR"
                DataGridView1.Item("Observaciones", 5).Value = "No se encuentra la llave de la entidad certificadora " & cakey & ", verifique las configuraciones del programa."
                _rastreo.ErrorLog(_DirDelLog, "No se encuentra la llave de la entidad certificadora " & cakey & ", verifique las configuraciones del programa.", "error", True)
            End If
            Dim ConfigFile = _Config.getValue(_ConfigFile, "config", "ConfigFile")
            If _ver.VerificaRuta(cacert, "Archivo") = True Then
                DataGridView1.Item("Resultado", 6).Value = "OK"
                _rastreo.ErrorLog(_DirDelLog, "Archivo de configuración de OpenSSL", "OK", True)
            Else
                DataGridView1.Item("Resultado", 6).Value = "ERROR"
                DataGridView1.Item("Observaciones", 6).Value = "No se encuentró el archivo de configuración " & ConfigFile & ", verifique las configuraciones del programa."
                _rastreo.ErrorLog(_DirDelLog, "No se encuentró el archivo de configuración " & ConfigFile & ", verifique las configuraciones del programa.", "error", True)
            End If
            Dim access2003_path = _Config.getValue(_ConfigFile, "config", "access2003_path")
            If _ver.VerificaRuta(cacert, "Archivo") = True Then
                DataGridView1.Item("Resultado", 7).Value = "OK"
                _rastreo.ErrorLog(_DirDelLog, "Archivo Access 2003", "OK", True)
            Else
                DataGridView1.Item("Resultado", 7).Value = "ERROR"
                DataGridView1.Item("Observaciones", 7).Value = "No se encuentró el archivo  " & access2003_path & ", verifique las configuraciones del programa."
                _rastreo.ErrorLog(_DirDelLog, "No se encuentró el archivo  " & access2003_path & ", verifique las configuraciones del programa.", "error", True)
            End If
            Dim use_LDAP As Integer = CInt(_Config.getValue(_ConfigFile, "config", "use_LDAP"))
            If use_LDAP <> 1 Then
                DataGridView1.Item("Resultado", 8).Value = "WARRING"
                DataGridView1.Item("Observaciones", 8).Value = "está deshabilitada la opción de conexión con LDAP"
                _rastreo.ErrorLog(_DirDelLog, "está deshabilitada la opción de conexión con LDAP", "Advertencia", True)
            Else
                Dim Usuario_LDAP As String = _Config.getValue(_ConfigFile, "config", "Usuario_LDAP")
                If Usuario_LDAP = "" Then
                    DataGridView1.Item("Resultado", 8).Value = "WARRING"
                    DataGridView1.Item("Observaciones", 8).Value = "No hay un usuario configurado para la conexión con LDAP"
                    _rastreo.ErrorLog(_DirDelLog, "Verificando Usuario LDAP: No hay un usuario configurado para la conexión con LDAP", "Advertencia", True)
                Else
                    Dim arreglo(3) As String
                    arreglo = _Config.Conexion_LDAP(_ConfigFile)
                    Dim hobldap As New hob_LDAP(arreglo(0), arreglo(1), arreglo(2), _DirDelLog, True)
                    DataGridView1.Item("Resultado", 8).Value = "OK"
                    Dim r As String = hobldap.testADConnection(Usuario_LDAP)
                    If r = "1" Then
                        DataGridView1.Item("Observaciones", 8).Value = "Conexión exitosa"
                        _rastreo.ErrorLog(_DirDelLog, "Conexión exitosa", "mensaje", True)
                    Else
                        DataGridView1.Item("Resultado", 8).Value = "ERROR"
                        DataGridView1.Item("Observaciones", 8).Value = r
                        _rastreo.ErrorLog(_DirDelLog, r, "error", True)
                    End If
                End If
            End If
        Catch ex As Exception
            '_rastreo.ErrorLog(_DirDelLog, "StackTrace: " & ex.StackTrace, True)
            _rastreo.ErrorLog(_DirDelLog, "Mensaje: " & ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub MakeDataTableAndDisplay() ' Create new DataTable.
        Try
            Dim table As New DataTable

            ' Declare DataColumn and DataRow variables.
            Dim column As DataColumn
            Dim row As DataRow

            ' Create new DataColumn, set DataType, ColumnName 
            ' and add to DataTable.    
            column = New DataColumn
            column.DataType = System.Type.GetType("System.String")
            column.ColumnName = "Evento"
            table.Columns.Add(column)

            ' Create second column.
            column = New DataColumn
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "Resultado"
            table.Columns.Add(column)


            column = New DataColumn
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "Observaciones"
            table.Columns.Add(column)

            Dim colRes As New DataGridViewImageColumn()
            colRes.Name = "colRes"
            colRes.HeaderText = ""
            DataGridView1.Columns().Add(colRes)


            ' Create new DataRow objects and add to DataTable.

            Dim Verificaciones(10) As String
            Verificaciones(0) = "OpenSSL: se encuentra en la variable de Entorno ""PATH"""
            Verificaciones(1) = "OpenSSL: Se encuentra la variable de entorno OPENSSL_CONF"
            Verificaciones(2) = "OpenSSL: Se encuentra la variable de entorno RANDFILE"
            Verificaciones(3) = "Configuración: Ejecutable en la ruta predeterminada"
            Verificaciones(4) = "Certificados: Repositorio de los certificados"
            Verificaciones(5) = "Certificados: Archivo de la Entidad Certificadora"
            Verificaciones(6) = "OpenSSL: Archivo ConfigFile"
            Verificaciones(7) = "Configuración: Se puede abrir el archivo de base de datos"
            Verificaciones(8) = "Conexiones: Conexión con LDAP"
            Verificaciones(9) = "Entidad Certificadora: Verificando la fecha de la entidad certificadora"

            Dim i As Integer
            For i = 0 To 9
                row = table.NewRow
                row("Evento") = Verificaciones(i)
                row("Resultado") = ""
                row("Observaciones") = ""
                table.Rows.Add(row)
            Next i
            ' Set to DataGrid.DataSource property to the table.
            DataGridView1.DataSource = table
        Catch ex As Exception
            '_rastreo.ErrorLog(_DirDelLog, "StackTrace: " & ex.StackTrace, True)
            _rastreo.ErrorLog(_DirDelLog, "Mensaje: " & ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try
        
    End Sub


    Private Sub DataGridView1_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Try
            If Me.DataGridView1.Columns(e.ColumnIndex).Name = "colRes" Then
                ' establecer la altura de la fila para que se pueda visualizar correctamente
                'Me.DataGridView1.Rows(e.RowIndex).Height = 40

                ' asignar la imagen adecuada
                Select Case DirectCast(Me.DataGridView1.Rows(e.RowIndex).Cells("Resultado").Value, String)
                    Case "OK"
                        e.Value = New Bitmap("accept.jpg")
                        Exit Select
                    Case "WARRING"
                        e.Value = New Bitmap(Me.[GetType](), "warning.jpg")
                        Exit Select
                    Case "ERROR"
                        e.Value = New Bitmap(Me.[GetType](), "remove.jpg")
                        Exit Select
                    Case ""
                        e.Value = New Bitmap(Me.[GetType](), "comment_edit.png")
                        Exit Select
                End Select
            End If
        Catch ex As Exception
            '_rastreo.ErrorLog(_DirDelLog, "StackTrace: " & ex.StackTrace, True)
            _rastreo.ErrorLog(_DirDelLog, "Mensaje: " & ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AyudaBtn_Click(sender As System.Object, e As System.EventArgs) Handles AyudaBtn.Click
        Try
            Help.ShowHelp(ParentForm, chm_file, HelpNavigator.TopicId, "30")
        Catch ex As Exception
            MsgBox(ex.Message)
            _rastreo.ErrorLog(_DirDelLog, "Error al tratar de acceder al archivo de ayuda " & chm_file & " desde " & Me.Text & "elemento " & AyudaBtn.Text & ". Mensaje: " & ex.Message, "error", True)
        End Try
    End Sub
End Class