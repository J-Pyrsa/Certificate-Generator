Imports hobtools
Imports System.DirectoryServices
Imports System.Security.Cryptography.X509Certificates

Public Class ListadoLDAP
    Dim view As DataView
    Dim busqueda As String
    Dim tabla As DataTable
    Dim item_cbx As Integer
    Dim base As String

    Dim styFecha As DataGridViewCellStyle
    Dim styDecimal As DataGridViewCellStyle
    Dim _ConfigFile As String
    Private _DirDelLog As String
    Private _rastreo As rastreo
    Private chm_file As String

    ' ==================== Variables para obtener las sesiones de HOB
    'Dim sesionesbyte As Object = Nothing
    'Dim sesionftpbyte As Object = Nothing
    'Dim sesionjtermbyte As Object = Nothing
    'Dim sesionwspucbyte As Object = Nothing
    'Dim sesionusyte As Object = Nothing
    'Dim sesiondodyte As Object = Nothing
    'Dim hobjwt As String
    'Dim hobhobte As String
    'Dim hobh As String
    'Dim hobk As String
    'Dim hobl As String
    'Dim hobj As String

    Dim CertificateByte As Object = Nothing
    Dim JWTByte As Object = Nothing
    Dim JWTXML As String = ""

    Sub New(ConfigFile As String, DirDelLog As String, _chm_file As String)
        chm_file = _chm_file

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _ConfigFile = ConfigFile
        _rastreo = New rastreo
        _DirDelLog = DirDelLog

    End Sub
    
    Private Sub Bw1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles Bw1.DoWork


        Dim Config As New xml_configfile(_ConfigFile)
        Dim _certificados As certificados = New certificados
        Dim _hobldap As New hob_LDAP
        Dim arreglo(3) As String
        arreglo = Config.Conexion_LDAP(_ConfigFile)

        'buscamos por usuario, nombre, etc
        Try
            Dim objDirectoryEntry As DirectoryEntry
            Dim mySearcher As DirectorySearcher

            'Establecemos los criteros de búsqueda para encontrar al Usuario
            If (item_cbx = 0) Or (item_cbx = Nothing) Then
                objDirectoryEntry = New DirectoryEntry(arreglo(0), arreglo(1), arreglo(2))
                mySearcher = New DirectorySearcher(objDirectoryEntry)
                If busqueda = "todos" Then
                    mySearcher.Filter = "(&(objectClass=user) (!objectClass=Computer))"
                Else
                    mySearcher.Filter = "(&(objectClass=user)(anr=" & busqueda & "))"
                End If
            Else
                'http://geekswithblogs.net/mhamilton/archive/2005/10/04/55920.aspx
                'DirectoryEntry userEntry = new DirectoryEntry(“LDAP://developer.hamilton.com/CN=Mike Hamilton,DC=developer,DC=Hamilton,DC=com”, “<adminAccountName>”,”<adminPassword”);
                objDirectoryEntry = New DirectoryEntry(arreglo(0) & "/" & base)
                objDirectoryEntry.Username = arreglo(1)
                objDirectoryEntry.Password = arreglo(2)
                mySearcher = New DirectorySearcher(objDirectoryEntry)
                mySearcher.Filter = "(&(objectClass=user) (!objectClass=Computer))"
            End If

            Dim i As Integer = 0
            If Bw1.CancellationPending Then
                e.Cancel = True
            End If
            Try
                tabla = New DataTable()
                tabla.Columns.Add("id").AutoIncrement = True
                tabla.Columns.Add("cn")
                tabla.Columns.Add("sn")
                tabla.Columns.Add("GivenName")
                tabla.Columns.Add("passwordLastSet")
                tabla.Columns.Add("ExpCert")
                tabla.Columns.Add("CaducaCert")
                tabla.Columns.Add("jwt")
                tabla.Columns.Add("Jterm")
                tabla.Columns.Add("HOBftp")
                tabla.Columns.Add("DoD")
                tabla.Columns.Add("WSPUC")
                tabla.Columns.Add("UserSettings")
                tabla.Columns.Add("distinguishedName")

                Dim r As Integer = mySearcher.FindAll.Count
                For Each result In mySearcher.FindAll()

                    Dim reg As DataRow = tabla.NewRow()
                    If Not result.GetDirectoryEntry().Properties("cn").Value = Nothing Then
                        'reg("id") = i + 1
                        Dim cn As String = result.GetDirectoryEntry().Properties("cn").Value
                        reg("cn") = cn
                        reg("sn") = result.GetDirectoryEntry().Properties("sn").Value
                        reg("GivenName") = result.GetDirectoryEntry().Properties("givenname").Value
                        Try
                            reg("passwordLastSet") = Convert.ToInt64(_hobldap.GetExpiration(CType(result.Properties("pwdLastSet")(0), Long))).ToString
                        Catch ex As Exception
                            reg("passwordLastSet") = "NA"
                        End Try

                        Dim Arreglo2() As String = _certificados.info(result.GetDirectoryEntry().Properties("usercertificate").Value)
                        If Arreglo2(0) = Nothing Then
                            reg("ExpCert") = ""
                            reg("CaducaCert") = ""
                        Else
                            Try
                                reg("ExpCert") = Date.Parse(Arreglo2(0))
                                reg("CaducaCert") = Date.Parse(Arreglo2(1))
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            End Try
                        End If

                        If result.GetDirectoryEntry().Properties("hobjwt").Value Is Nothing Then
                            reg("jwt") = ""
                        Else
                            reg("jwt") = "SI"
                        End If
                        If result.GetDirectoryEntry().Properties("hobhobte").Value Is Nothing Then
                            reg("Jterm") = ""
                        Else
                            reg("Jterm") = "SI"
                        End If
                        If result.GetDirectoryEntry().Properties("hobh").Value Is Nothing Then
                            reg("HOBftp") = ""
                        Else
                            reg("HOBftp") = "SI"
                        End If
                        If result.GetDirectoryEntry().Properties("hobj").Value Is Nothing Then
                            reg("DoD") = ""
                        Else
                            reg("DoD") = "SI"
                        End If
                        If result.GetDirectoryEntry().Properties("hobk").Value Is Nothing Then
                            reg("WSPUC") = ""
                        Else
                            reg("WSPUC") = "SI"
                        End If
                        If result.GetDirectoryEntry().Properties("hobl").Value Is Nothing Then
                            reg("UserSettings") = ""
                        Else
                            reg("UserSettings") = "SI"
                        End If
                        Dim t1 As String = result.GetDirectoryEntry().Properties("distinguishedName").Value().ToString
                        reg("distinguishedName") = t1.Replace("CN=" & cn & ",", "")

                        tabla.Rows.Add(reg)
                        tabla.AcceptChanges()
                    End If
                    If Not i >= r Then
                        Bw1.ReportProgress((i * 100) / r)
                        i = i + 1
                    End If
                Next
            Catch ex As Exception
                _rastreo.ErrorLog(_DirDelLog, "Tratando de conectarse al servidor LDAP o la tabla destino está corrupta. Mensaje: " & ex.Message, "error", True)
                MsgBox(ex.Message)
            End Try
            'Next
            busqueda = ""
        Catch ex As Exception
            _rastreo.ErrorLog(_DirDelLog, "Error al tratar de armar la estructura de conexión al servidor LDAP. Mensaje: " & ex.Message, "error", True)
            MsgBox(ex.Message)
        Finally
            'Dim Config As New xml_configfile(_ConfigFile)
            '_certificados As certificados = New certificados
            '_hobldap As New hob_LDAP
            'TODO: liberar memoria
        End Try
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
            'view = New DataView(tabla)
            'DataGridView1.DataSource = view

            BindingSource1.DataSource = tabla
            DataGridView1.DataSource = BindingSource1
            HeadreTitles()
            tabla.Dispose()
        End If
        BuscarBtn.Enabled = True
        btnCancelar.Enabled = False
        btnCancelar.Visible = False
        pB1.Value = 0
        pB1.Visible = False
        StatusLabel.Text = ""
    End Sub

    Private Sub ListadoLDAP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LimpiarDataGrid1()
        StatusLabel.Text = ""
        With (ComboBox1)
            'cargar los items de opciones para filtrar  
            .Items.Add("No filtrar")
            .Items.Add("Que comience con")
            .Items.Add("Que No comience con")
            .Items.Add("Que contenga")
            .Items.Add("Que No contenga")
            .Items.Add("Que sea igual")
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = 1
        End With

        Dim a01 As String = "Usuario ID (cn)"
        Dim A02 As String = "Apellidos (sn)"
        Dim a03 As String = "Nombre(s)"
        Dim a04 As String = "email"
        Dim a05 As String = "Teléfono"
        Dim a06 As String = "Emitido el"
        Dim a07 As String = "Expira el"

        With (ComboBox2)
            'cargar los items de opciones para filtrar  
            .Items.Add(a01)
            .Items.Add(A02)
            .Items.Add(a03)
            .Items.Add(a04)
            .Items.Add(a05)
            .Items.Add(a06)
            .Items.Add(a07)

            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = 0
        End With
        'Me.AcceptButton = btnProcesar
        Me.ActiveControl = Buscar_txt
        BuscarPor_combo.SelectedIndex = 0
    End Sub

    Sub CargarComboBox()
        Try
            Dim Config As New xml_configfile(_ConfigFile)
            Dim arreglo = Config.Conexion_LDAP(_ConfigFile)
            Dim _hob_LDAP As New hob_LDAP(arreglo(0), arreglo(1), arreglo(2), _DirDelLog, True)

            Dim dt As New DataTable
            dt = _hob_LDAP.listar_OUs
            dt.Select("", "distinguishedName ASC")
            OUs_ComboBox.DataSource = dt
            OUs_ComboBox.DisplayMember = "distinguishedName"


            OUs_ComboBox.DropDownStyle = ComboBoxStyle.DropDown
            OUs_ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            OUs_ComboBox.AutoCompleteSource = AutoCompleteSource.ListItems
        Catch ex As Exception
            _rastreo.ErrorLog(_DirDelLog, "Error al trar de listar las OUs. Mensaje: " & ex.Message, "error", True)
        Finally
            'TODO: Liberar Memoria
        End Try
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        If Me.DataGridView1.Columns(e.ColumnIndex).Name = "CaducaCert" Then
            Try
                DataGridView1.Columns("CaducaCert").DefaultCellStyle.Format = "MMMM (yyyy)"
            Catch ex As Exception
                _rastreo.ErrorLog(_DirDelLog, "Mensaje: " & ex.Message, "error", True)
                MsgBox(ex.Message)
            End Try
        End If
        If Me.DataGridView1.Columns(e.ColumnIndex).Name = "passwordLastSet" Then
            ' y el valor cumple con cierta condición
            Try
                If e.Value <> "NA" Then
                    If CDec(e.Value) <= 0 Then
                        ' aplicar formato a la totalidad de la fila
                        Me.DataGridView1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
                    End If
                End If

            Catch ex As Exception
                _rastreo.ErrorLog(_DirDelLog, "Mensaje: " & ex.Message, "error", True)
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Sub HeadreTitles()
        Try
            DataGridView1.Columns("cn").HeaderText = "Usuario ID (cn)"
            DataGridView1.Columns("cn").ToolTipText = "El usuario ID es el ""cn"" en el Active Directory"
            DataGridView1.Columns("sn").HeaderText = "Apellidos (sn)"
            DataGridView1.Columns("sn").ToolTipText = "El ""sn"" en el Active Directory representan al campo de los Apellidos"
            DataGridView1.Columns("givenName").HeaderText = "Nombre(s)"
            DataGridView1.Columns("givenName").ToolTipText = "El ""givenName"" en el Active Directory representan al nombre de Pila"
            DataGridView1.Columns("passwordLastSet").HeaderText = "pwd status"
            DataGridView1.Columns("passwordLastSet").ToolTipText = "La contraseña caduca en: ""n"" días"
            DataGridView1.Columns("ExpCert").HeaderText = "Fecha Emisión"
            DataGridView1.Columns("ExpCert").ToolTipText = "El certificado fué emitido el día..."
            DataGridView1.Columns("CaducaCert").HeaderText = "Fecha expiración"
            DataGridView1.Columns("distinguishedName").HeaderText = "OU de procedencia"
            DataGridView1.Columns("distinguishedName").ToolTipText = "Unidad Organizacional de procedencia del usuario"

            DataGridView1.Columns("jwt").ToolTipText = "Muestra si un usuario tiene configurada una sesión HOBLink JWT"
            DataGridView1.Columns("Jterm").ToolTipText = "Muestra si un usuario tiene configurada una sesión HOBftp"
            DataGridView1.Columns("HOBftp").ToolTipText = "Muestra si un usuario tiene configurada una sesión HOBLink J-Term"
            DataGridView1.Columns("DoD").ToolTipText = "Muestra si un usuario tiene configurada una sesión Desktop On Demand"
            DataGridView1.Columns("WSPUC").ToolTipText = "Muestra si un usuario tiene configurada una sesión Web Secure Proxy Universal Client"
            DataGridView1.Columns("UserSettings").ToolTipText = "Muestra si un usuario tiene configurada una personalizada de HOB RD VPN"

            DataGridView1.Columns("id").HeaderText = ""
        Catch ex As Exception
            _rastreo.ErrorLog(_DirDelLog, "error al trata de establecer las cabezeras de la rejilla. Mensaje: " & ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub LimpiarDataGrid1()
        If Not tabla Is Nothing Then
            tabla.Clear()
            DataGridView1.DataSource = Nothing
            DataGridView1.Refresh()
        End If
    End Sub

    Private Sub btnProcesar_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Bw1.CancelAsync()
    End Sub

    Private Sub Export2excel_Click(sender As System.Object, e As System.EventArgs)
        Try
            If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
                'http://www.dotnetcr.com/recurso.aspx?stag=Exportar-datos-a-Excel
                Dim egot As New egOfficeTools(_ConfigFile)
                egot.DataTableToExcel(tabla, SaveFileDialog1.FileName, False)
                _rastreo.ErrorLog(_DirDelLog, "Exportación del archivo " & SaveFileDialog1.FileName & " exitosa", "mensaje", True)
                Dim response As MsgBoxResult
                response = MsgBox("Sel archivo se exportó con éxito, ¿desea abrirlo en Microsoft Excel?", MsgBoxStyle.YesNo, "Exportar a Microsoft Excel")
                If response = MsgBoxResult.Yes Then
                    Try
                        Dim p As New System.Diagnostics.Process
                        p.EnableRaisingEvents = False
                        p.Start("excel.exe", """" & SaveFileDialog1.FileName & """")
                    Catch ex As Exception
                        _rastreo.ErrorLog(_DirDelLog, ex.Message, "error", True)
                        MsgBox(ex.Message)
                    Finally
                        'TODO: Liberar memoria
                    End Try
                End If
            End If
        Catch ex As Exception
            _rastreo.ErrorLog(_DirDelLog, ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Try
            DataGridView1.DataSource = Nothing
        Catch ex As Exception
            _rastreo.ErrorLog(_DirDelLog, "Error al tratar de salir de la ventana " & Me.Text & ". Mensaje: " & ex.Message, "error", True)
        Finally
            Me.Close()
        End Try

    End Sub

    Private Sub FiltradoBtn_Click(sender As System.Object, e As System.EventArgs)
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay resultados para mostrar, hága primero una búsqueda para poder filtrar los resultados")
        Else
            If BuscarPanel.Visible = False Then
                BuscarPanel.Visible = True
            Else
                BuscarPanel.Visible = False
            End If
        End If

    End Sub

    Enum e_FILTER_OPTION
        SIN_FILTRO = 0
        CADENA_QUE_COMIENCE_CON = 1
        CADENA_QUE_NO_COMIENCE_CON = 2
        CADENA_QUE_CONTENGA = 3
        CADENA_QUE_NO_CONTENGA = 4
        CADENA_IGUAL = 5
    End Enum

    Private Sub Aplicar_Filtro(ByVal columna As String)
        If columna = "" Then
            columna = "cn"
        End If

        Dim ret As Integer = Filtrar_DataGridView( _
                                        columna, _
                                        TextBox1.Text.Trim, _
                                        BindingSource1, _
                                        DataGridView1, _
                                        CType(ComboBox1.SelectedIndex, e_FILTER_OPTION))

        If ret = 0 Then
            ' si no hay registros cambiar el color del txtbox  
            TextBox1.BackColor = Color.Red
        Else
            TextBox1.BackColor = Color.White
        End If
        ' visualizar la cantidad de registros  
        Me.Text = ret & " Registros encontrados"

    End Sub

    Function Filtrar_DataGridView( _
        ByVal Columna As String, _
        ByVal texto As String, _
        ByVal BindingSource As BindingSource, _
        ByVal DataGridView As DataGridView, _
        Optional ByVal Opcion_Filtro As e_FILTER_OPTION = Nothing) As Integer

        ' verificar que el DataSource no esté vacio  
        If BindingSource1.DataSource Is Nothing Then
            Return 0
        End If
        Try

            Dim filtro As String = String.Empty
            ' Seleccionar la opción   
            Select Case Opcion_Filtro
                Case e_FILTER_OPTION.CADENA_QUE_COMIENCE_CON
                    filtro = "like '" & texto.Trim & "%'"
                Case e_FILTER_OPTION.CADENA_QUE_NO_COMIENCE_CON
                    filtro = "Not like '" & texto.Trim & "%'"
                Case e_FILTER_OPTION.CADENA_QUE_NO_CONTENGA
                    filtro = "Not like '%" & texto.Trim & "%'"
                Case e_FILTER_OPTION.CADENA_QUE_CONTENGA
                    filtro = "like '%" & texto.Trim & "%'"
                Case e_FILTER_OPTION.CADENA_IGUAL
                    filtro = "='" & texto.Trim & "'"
            End Select
            ' Opción para no filtrar  
            If Opcion_Filtro = e_FILTER_OPTION.SIN_FILTRO Then
                filtro = String.Empty
            End If

            ' armar el sql  
            If filtro <> String.Empty Then
                filtro = "[" & Columna & "]" & filtro
            End If

            ' asigar el criterio a la propiedad Filter del BindingSource  
            BindingSource.Filter = filtro
            ' enlzar el datagridview al BindingSource  
            DataGridView.DataSource = BindingSource.DataSource

            ' retornar la cantidad de registros encontrados  
            Return BindingSource.Count

            ' errores  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

        Return 0

    End Function

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Dim indice As Integer = 0
        Dim x As String = "cn"

        Select Case ComboBox2.SelectedIndex
            Case 1
                x = "sn"
            Case 2
                x = "givenName"
            Case 3
                x = "mail"
            Case 4
                x = "telefono"
            Case 5
                x = "fechaemision"
            Case 6
                x = "fechavencimiento"
        End Select

        Aplicar_Filtro(x)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Help.ShowHelp(ParentForm, chm_file, HelpNavigator.TopicId, "27")
        Catch ex As Exception
            _rastreo.ErrorLog(_DirDelLog, "Error al tratar de acceder al archivo de ayuda " & chm_file & " desde " & Me.Text & "elemento " & Button1.Text & ". Mensaje: " & ex.Message, "error", True)
        End Try

    End Sub

    Private Sub DataGridView1_RowsAdded(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        Try
            Dim f As Date = Now
            MyBase.SuspendLayout()
            For Each row As DataGridViewRow In DirectCast(Me.DataGridView1.Rows, IEnumerable)
                Dim _a As String = row.Cells("cn").Value.ToString
                Dim _b As String = row.Cells("sn").Value.ToString
                Dim _c As String = row.Cells("GivenName").Value.ToString
                Dim _d As String = row.Cells("passwordLastSet").Value.ToString
                Dim _e As String = row.Cells("ExpCert").Value.ToString
                Dim _f As String = row.Cells("CaducaCert").Value.ToString

                Dim CalcDate As New hob_LDAP
                If Not _e = "" Then
                    f = Date.Parse(_f)
                    Dim __r As Long = CalcDate.GetExpiration(f)
                    If (__r < 7) Then
                        row.DefaultCellStyle.BackColor = Color.Pink
                    End If
                    If (__r >= 7) And (__r < 30) Then
                        row.DefaultCellStyle.BackColor = Color.Yellow
                    End If
                Else
                    row.DefaultCellStyle.BackColor = Color.White
                End If
            Next
            MyBase.ResumeLayout(True)
        Catch ex As Exception
            _rastreo.ErrorLog(_DirDelLog, "StackTrace: " & ex.StackTrace, "error", True)
            _rastreo.ErrorLog(_DirDelLog, "Mensaje: " & ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Iniciar_UserDetails(True)
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Iniciar_UserDetails(True)
    End Sub

    Sub Iniciar_UserDetails(PuedeIniciar As Boolean)
        If PuedeIniciar = True Then
            Dim UserDetail As New UserDetail(DataGridView1.CurrentRow.Cells(1).Value.ToString, _ConfigFile, _DirDelLog)
            UserDetail.ShowDialog()
        End If
    End Sub

    Private Sub ListadoLDAP_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        DataGridView1.Dispose()
        DataGridView1 = Nothing
        tabla = Nothing
    End Sub

    
    

    Sub buscar()
        base = OUs_ComboBox.Text
        LimpiarDataGrid1()
        If (Buscar_txt.Text = "") Or (Buscar_txt.Text = "*") Or (Buscar_txt.Text = "todos") Then
            busqueda = "todos"
        Else
            busqueda = Buscar_txt.Text
        End If
        Bw1.WorkerReportsProgress = True
        Bw1.WorkerSupportsCancellation = True
        Bw1.RunWorkerAsync()
        BuscarBtn.Enabled = False
        btnCancelar.Enabled = True
        btnCancelar.Visible = True
        pB1.Visible = True
        item_cbx = BuscarPor_combo.SelectedIndex

        Buscar_txt.Focus()
    End Sub

    Private Sub FiltradoBtn_Click_1(sender As System.Object, e As System.EventArgs) Handles FiltradoBtn.Click
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay resultados para mostrar, hága primero una búsqueda para poder filtrar los resultados")
        Else
            If BuscarPanel.Visible = False Then
                BuscarPanel.Visible = True
            Else
                BuscarPanel.Visible = False
            End If
        End If
    End Sub

    Private Sub BuscarBtn_Click(sender As System.Object, e As System.EventArgs) Handles BuscarBtn.Click
        buscar()
    End Sub

    Private Sub _ayuda_Buscar_BTN_Click(sender As System.Object, e As System.EventArgs) Handles _ayuda_Buscar_BTN.Click
        Try
            Help.ShowHelp(ParentForm, chm_file, HelpNavigator.TopicId, "28")
        Catch ex As Exception
            MsgBox(ex.Message)
            _rastreo.ErrorLog(_DirDelLog, "Error al tratar de acceder al archivo de ayuda " & chm_file & " desde " & Me.Text & " Mensaje: " & ex.Message, "error", True)
        End Try
    End Sub

    Private Sub BuscarPor_combo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles BuscarPor_combo.SelectedIndexChanged
        If BuscarPor_combo.SelectedIndex = 1 Then
            OUs_ComboBox.Visible = True
            CargarComboBox()
        Else
            OUs_ComboBox.Visible = False
            OUs_ComboBox.DataSource = Nothing
        End If
    End Sub
End Class

'Formatear y resaltar valores en el control DataGridView con el evento CellFormatting (I)
'http://geeks.ms/blogs/lmblanco/archive/2008/03/04/formatear-y-resaltar-valores-en-el-control-datagridview-con-el-evento-cellformatting-i.aspx

'Formatear y resaltar valores en el control DataGridView con el evento CellFormatting (II)
'http://geeks.ms/blogs/lmblanco/archive/2008/03/05/formatear-y-resaltar-valores-en-el-control-datagridview-con-el-evento-cellformatting-ii.aspx

'Formatear y resaltar valores en el control DataGridView con el evento CellFormatting (y III)
'http://geeks.ms/blogs/lmblanco/archive/2008/03/06/formatear-y-resaltar-valores-en-el-control-datagridview-con-el-evento-cellformatting-y-iii.aspx

'Cambio de color en las celdas de un Datagridview
'http://social.msdn.microsoft.com/Forums/es/vcses/thread/c00ea570-d0d8-4d0e-9f2a-a246a841dd91

'DateTime.Parse Method (String)
' Con la info de esta página pude cambiar de String a Date
'http://msdn.microsoft.com/en-us/library/1k1skd40.aspx


'Net Directory Services Programming - C# - Part 2 - DirectoryEntry Binding and AD Properties
'http://geekswithblogs.net/mhamilton/archive/2005/10/04/55920.aspx
'DirectoryEntry.Username (Propiedad) 
'http://msdn.microsoft.com/es-es/library/ms180841%28v=vs.80%29.aspx
'Cadenas de enlace
'http://msdn.microsoft.com/es-es/library/system.directoryservices.directoryentry.username.aspx