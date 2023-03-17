<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TópicosDeAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeVersionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HowToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaciónDeCertificadosDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApéndiceACrearHLUnitsSinLlavesPúblicasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeCertificadosEmitidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarLDAPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerificaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cn_column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.givenName_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sn_column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.duration_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeySize_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcesarAD_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Crear_Btn = New System.Windows.Forms.Button()
        Me.Cargar_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pB1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.lbl_output = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnCancelar = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Salida_txt = New System.Windows.Forms.RichTextBox()
        Me.Bw1 = New System.ComponentModel.BackgroundWorker()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.LimpiarRejilla_Btn = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.ListadosToolStripMenuItem, Me.HerramientasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(851, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.ToolTip1.SetToolTip(Me.MenuStrip1, "Barra de menú")
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraciónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Image = CType(resources.GetObject("ConfiguraciónToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.CertificateGenerator.My.Resources.Resources.TB_BIG_EXITALL
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TópicosDeAyudaToolStripMenuItem, Me.ControlDeVersionesToolStripMenuItem, Me.ToolStripSeparator2, Me.HowToToolStripMenuItem, Me.ToolStripSeparator1, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Image = CType(resources.GetObject("AyudaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'TópicosDeAyudaToolStripMenuItem
        '
        Me.TópicosDeAyudaToolStripMenuItem.Name = "TópicosDeAyudaToolStripMenuItem"
        Me.TópicosDeAyudaToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.TópicosDeAyudaToolStripMenuItem.Text = "Tópicos de ayuda"
        '
        'ControlDeVersionesToolStripMenuItem
        '
        Me.ControlDeVersionesToolStripMenuItem.Image = CType(resources.GetObject("ControlDeVersionesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ControlDeVersionesToolStripMenuItem.Name = "ControlDeVersionesToolStripMenuItem"
        Me.ControlDeVersionesToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ControlDeVersionesToolStripMenuItem.Text = "Control de versiones"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(181, 6)
        '
        'HowToToolStripMenuItem
        '
        Me.HowToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreaciónDeCertificadosDeUsuarioToolStripMenuItem, Me.ApéndiceACrearHLUnitsSinLlavesPúblicasToolStripMenuItem})
        Me.HowToToolStripMenuItem.Name = "HowToToolStripMenuItem"
        Me.HowToToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.HowToToolStripMenuItem.Text = "How to"
        '
        'CreaciónDeCertificadosDeUsuarioToolStripMenuItem
        '
        Me.CreaciónDeCertificadosDeUsuarioToolStripMenuItem.Name = "CreaciónDeCertificadosDeUsuarioToolStripMenuItem"
        Me.CreaciónDeCertificadosDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.CreaciónDeCertificadosDeUsuarioToolStripMenuItem.Text = "Creación de certificados de usuario"
        '
        'ApéndiceACrearHLUnitsSinLlavesPúblicasToolStripMenuItem
        '
        Me.ApéndiceACrearHLUnitsSinLlavesPúblicasToolStripMenuItem.Name = "ApéndiceACrearHLUnitsSinLlavesPúblicasToolStripMenuItem"
        Me.ApéndiceACrearHLUnitsSinLlavesPúblicasToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.ApéndiceACrearHLUnitsSinLlavesPúblicasToolStripMenuItem.Text = "Crear HLUnits sin llaves públicas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(181, 6)
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de ..."
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeCertificadosEmitidosToolStripMenuItem, Me.ConsultarLDAPToolStripMenuItem})
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ListadosToolStripMenuItem.Text = "Listados"
        '
        'ListadoDeCertificadosEmitidosToolStripMenuItem
        '
        Me.ListadoDeCertificadosEmitidosToolStripMenuItem.Image = CType(resources.GetObject("ListadoDeCertificadosEmitidosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListadoDeCertificadosEmitidosToolStripMenuItem.Name = "ListadoDeCertificadosEmitidosToolStripMenuItem"
        Me.ListadoDeCertificadosEmitidosToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ListadoDeCertificadosEmitidosToolStripMenuItem.Text = "Listado de certificados emitidos"
        '
        'ConsultarLDAPToolStripMenuItem
        '
        Me.ConsultarLDAPToolStripMenuItem.Image = CType(resources.GetObject("ConsultarLDAPToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarLDAPToolStripMenuItem.Name = "ConsultarLDAPToolStripMenuItem"
        Me.ConsultarLDAPToolStripMenuItem.Size = New System.Drawing.Size(234, 22)
        Me.ConsultarLDAPToolStripMenuItem.Text = "Consultar LDAP"
        Me.ConsultarLDAPToolStripMenuItem.ToolTipText = "Muestra los certificados que están" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "almacenados en LDAP"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerificaciónToolStripMenuItem, Me.VerRegistroToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'VerificaciónToolStripMenuItem
        '
        Me.VerificaciónToolStripMenuItem.Name = "VerificaciónToolStripMenuItem"
        Me.VerificaciónToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.VerificaciónToolStripMenuItem.Text = "Verificación"
        '
        'VerRegistroToolStripMenuItem
        '
        Me.VerRegistroToolStripMenuItem.Name = "VerRegistroToolStripMenuItem"
        Me.VerRegistroToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.VerRegistroToolStripMenuItem.Text = "Ver registro"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.RestoreDirectory = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cn_column, Me.givenName_Column, Me.sn_column, Me.email_Column, Me.tel_Column, Me.duration_Column, Me.KeySize_Column, Me.ProcesarAD_Column})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(851, 285)
        Me.DataGridView1.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.DataGridView1, "Informe de certificados a crear")
        '
        'cn_column
        '
        Me.cn_column.HeaderText = "Nombre de usaurio"
        Me.cn_column.Name = "cn_column"
        Me.cn_column.ToolTipText = "Nombre de usaurio (ej; s239762)"
        '
        'givenName_Column
        '
        Me.givenName_Column.HeaderText = "Nombre de pila"
        Me.givenName_Column.Name = "givenName_Column"
        Me.givenName_Column.ToolTipText = "Por ejemplo: César Erwin"
        '
        'sn_column
        '
        Me.sn_column.HeaderText = "Apellidos"
        Me.sn_column.Name = "sn_column"
        Me.sn_column.ToolTipText = "sn, Por ejemplo: Palma Soto"
        '
        'email_Column
        '
        Me.email_Column.HeaderText = "email"
        Me.email_Column.Name = "email_Column"
        '
        'tel_Column
        '
        Me.tel_Column.HeaderText = "Teléfono"
        Me.tel_Column.Name = "tel_Column"
        '
        'duration_Column
        '
        Me.duration_Column.HeaderText = "Duración"
        Me.duration_Column.Name = "duration_Column"
        '
        'KeySize_Column
        '
        Me.KeySize_Column.HeaderText = "Tamaño de la llave"
        Me.KeySize_Column.Name = "KeySize_Column"
        '
        'ProcesarAD_Column
        '
        Me.ProcesarAD_Column.HeaderText = "ProcesarAD"
        Me.ProcesarAD_Column.Name = "ProcesarAD_Column"
        Me.ProcesarAD_Column.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(156, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 49)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Configuración"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.Button1, "Abre la ventana de configuración del programa")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Crear_Btn
        '
        Me.Crear_Btn.Image = CType(resources.GetObject("Crear_Btn.Image"), System.Drawing.Image)
        Me.Crear_Btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Crear_Btn.Location = New System.Drawing.Point(90, 13)
        Me.Crear_Btn.Name = "Crear_Btn"
        Me.Crear_Btn.Size = New System.Drawing.Size(60, 49)
        Me.Crear_Btn.TabIndex = 10
        Me.Crear_Btn.Text = "Crear"
        Me.Crear_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Crear_Btn, "Crear los certificados a partir de la rejilla")
        Me.Crear_Btn.UseVisualStyleBackColor = True
        '
        'Cargar_btn
        '
        Me.Cargar_btn.AutoSize = True
        Me.Cargar_btn.Image = CType(resources.GetObject("Cargar_btn.Image"), System.Drawing.Image)
        Me.Cargar_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cargar_btn.Location = New System.Drawing.Point(12, 13)
        Me.Cargar_btn.Name = "Cargar_btn"
        Me.Cargar_btn.Size = New System.Drawing.Size(72, 49)
        Me.Cargar_btn.TabIndex = 9
        Me.Cargar_btn.Text = "Abrir"
        Me.Cargar_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cargar_btn, "Abrir Archivo CVS")
        Me.Cargar_btn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LimpiarRejilla_Btn)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Crear_Btn)
        Me.Panel1.Controls.Add(Me.Cargar_btn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(851, 77)
        Me.Panel1.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(751, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "TestButton"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.pB1, Me.lbl_output, Me.btnCancelar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 364)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(851, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        Me.StatusStrip1.Visible = False
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'pB1
        '
        Me.pB1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pB1.Name = "pB1"
        Me.pB1.Size = New System.Drawing.Size(100, 16)
        '
        'lbl_output
        '
        Me.lbl_output.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_output.Name = "lbl_output"
        Me.lbl_output.Size = New System.Drawing.Size(0, 17)
        '
        'btnCancelar
        '
        Me.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(62, 20)
        Me.btnCancelar.Text = "Cancelar"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Controls.Add(Me.Splitter1)
        Me.Panel2.Controls.Add(Me.Salida_txt)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(851, 285)
        Me.Panel2.TabIndex = 10
        '
        'Splitter1
        '
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 122)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(851, 3)
        Me.Splitter1.TabIndex = 7
        Me.Splitter1.TabStop = False
        '
        'Salida_txt
        '
        Me.Salida_txt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Salida_txt.Location = New System.Drawing.Point(0, 125)
        Me.Salida_txt.Name = "Salida_txt"
        Me.Salida_txt.Size = New System.Drawing.Size(851, 160)
        Me.Salida_txt.TabIndex = 6
        Me.Salida_txt.Text = ""
        Me.Salida_txt.Visible = False
        '
        'Bw1
        '
        '
        'LimpiarRejilla_Btn
        '
        Me.LimpiarRejilla_Btn.Location = New System.Drawing.Point(259, 39)
        Me.LimpiarRejilla_Btn.Name = "LimpiarRejilla_Btn"
        Me.LimpiarRejilla_Btn.Size = New System.Drawing.Size(75, 23)
        Me.LimpiarRejilla_Btn.TabIndex = 14
        Me.LimpiarRejilla_Btn.Text = "Limpiar rejilla"
        Me.LimpiarRejilla_Btn.UseVisualStyleBackColor = True
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 386)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainFrm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Crear_Btn As System.Windows.Forms.Button
    Friend WithEvents Cargar_btn As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlDeVersionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pB1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lbl_output As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Bw1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents Salida_txt As System.Windows.Forms.RichTextBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ListadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeCertificadosEmitidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarLDAPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerificaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cn_column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents givenName_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sn_column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents duration_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeySize_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcesarAD_Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents VerRegistroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents TópicosDeAyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HowToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreaciónDeCertificadosDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ApéndiceACrearHLUnitsSinLlavesPúblicasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimpiarRejilla_Btn As System.Windows.Forms.Button

End Class
