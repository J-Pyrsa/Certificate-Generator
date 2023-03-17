Imports System.Data.OleDb
Imports hobtools
Imports Microsoft.Office.Interop
Imports System.IO

Public Class ListadoCertificados

    Dim _ConfigFile As String
    Dim dt As New DataTable
    Private _DirDelLog As String
    Private _rastreo As rastreo
    Private chm_file As String

    Sub New(ConfigFile As String, DirDelLog As String, _chm_file As String)
        _ConfigFile = ConfigFile
        chm_file = _chm_file

        _rastreo = New rastreo
        _DirDelLog = DirDelLog

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub ListadoCertificados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Bd1DataSet.Usr' Puede moverla o quitarla según sea necesario.
        ' Me.UsrTableAdapter.Fill(Me.Bd1DataSet.Usr)

        BuscarPanel.Visible = False
        TextBox1.Text = ""
        DataGridView1.DataSource = Nothing

        SelectAll()
    End Sub

    ' Variable de tipo Recordset y con evento  

    Private Sub SelectAll()


        Dim _Config As New xml_configfile(_ConfigFile)
        Try
            Dim _access2003_path As String = _Config.getValue(_ConfigFile, "config", "access2003_path")
            Dim cnn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _access2003_path & "; User Id=admin;Password=;")
            Dim da As New OleDbDataAdapter("SELECT cn, sn, givenname, mail, telefono, passcert, PassKey, fechaemision, fechavencimiento FROM usr;", cnn)
            Dim ds As New DataSet

            da.Fill(dt)
            'DataGridView1.DataSource = dt

            BindingSource1.DataSource = dt
            DataGridView1.DataSource = BindingSource1

            Dim a01 As String = "Usuario ID (cn)"
            Dim A02 As String = "Apellidos (sn)"
            Dim a03 As String = "Nombre(s)"
            Dim a04 As String = "email"
            Dim a05 As String = "Teléfono"
            Dim a06 As String = "Emitido el"
            Dim a07 As String = "Expira el"

            DataGridView1.Columns("cn").HeaderText = a01
            DataGridView1.Columns("cn").ToolTipText = "El usuario ID es el ""cn"" en el Active Directory"
            DataGridView1.Columns("sn").HeaderText = A02
            DataGridView1.Columns("sn").ToolTipText = "El ""sn"" en el Active Directory representan al campo de los Apellidos"
            DataGridView1.Columns("givenName").HeaderText = a03
            DataGridView1.Columns("givenName").ToolTipText = "El ""givenName"" en el Active Directory representan al nombre de Pila"
            DataGridView1.Columns("mail").HeaderText = a04
            DataGridView1.Columns("Telefono").HeaderText = a05
            DataGridView1.Columns("passcert").HeaderText = "Contraseña del certificado"
            DataGridView1.Columns("PassKey").HeaderText = "Contraseña de la llave"
            DataGridView1.Columns("fechaemision").HeaderText = a06
            DataGridView1.Columns("fechavencimiento").HeaderText = a07

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
        Catch ex As Exception
            _rastreo.ErrorLog(_DirDelLog, "Error al crear al aobtener los datos: " & ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        SelectAll()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ExcelExport_Btn_Click(sender As System.Object, e As System.EventArgs) Handles ExcelExport_Btn.Click
        Try
            If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
                'http://www.dotnetcr.com/recurso.aspx?stag=Exportar-datos-a-Excel
                Dim egot As New egOfficeTools(_ConfigFile)
                egot.DataTableToExcel(dt, SaveFileDialog1.FileName, False)
                'Else
                '    MessageBox.Show("The Cancel button was clicked or Esc was pressed")
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
                    End Try
                End If
            End If
        Catch ex As Exception
            _rastreo.ErrorLog(_DirDelLog, ex.Message, "error", True)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BuscarBtn_Click(sender As System.Object, e As System.EventArgs) Handles BuscarBtn.Click
        If BuscarPanel.Visible = False Then
            BuscarPanel.Visible = True
        Else
            BuscarPanel.Visible = False
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

        ' filtrar por el campo Producto  
        ''''''''''''''''''''''''''''''''''''''''''''''''''''  
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

    Private Sub TópicosDeAyudaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TópicosDeAyudaToolStripMenuItem.Click
        Try
            Help.ShowHelp(ParentForm, chm_file, HelpNavigator.TopicId, "26")
        Catch ex As Exception
            _rastreo.ErrorLog(_DirDelLog, "Error al tratar de acceder al archivo de ayuda " & chm_file & " desde " & Me.Text & "elemento " & TópicosDeAyudaToolStripMenuItem.Text & ". Mensaje: " & ex.Message, "error", True)
        End Try

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Help.ShowHelp(ParentForm, chm_file, HelpNavigator.TopicId, "27")
        Catch ex As Exception
            _rastreo.ErrorLog(_DirDelLog, "Error al tratar de acceder al archivo de ayuda " & chm_file & " desde " & Me.Text & "elemento " & Button1.Text & ". Mensaje: " & ex.Message, "error", True)
        End Try

    End Sub
End Class