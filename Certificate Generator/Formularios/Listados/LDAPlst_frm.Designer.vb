<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LDAPlst_frm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LDAPlst_frm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pB1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.btnCancelar = New System.Windows.Forms.ToolStripSplitButton()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónDetalladaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónGeneralCompactaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónDeProductosHOBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónDeContraseñasDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosPorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosConSesionesHOBLinkJWTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Export2excel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._ayuda_Buscar_BTN = New System.Windows.Forms.Button()
        Me.Buscar_txt = New System.Windows.Forms.TextBox()
        Me.BuscarPor_combo = New System.Windows.Forms.ComboBox()
        Me.FiltradoBtn = New System.Windows.Forms.Button()
        Me.OUs_ComboBox = New System.Windows.Forms.ComboBox()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.FiltradoPanel = New System.Windows.Forms.Panel()
        Me.FiltradoGpo = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Filtro_txt = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Bw1 = New System.ComponentModel.BackgroundWorker()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.FiltradoPanel.SuspendLayout()
        Me.FiltradoGpo.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pB1, Me.btnCancelar, Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 398)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(722, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pB1
        '
        Me.pB1.Name = "pB1"
        Me.pB1.Size = New System.Drawing.Size(100, 16)
        Me.pB1.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancelar.Image = Global.CertificateGenerator.My.Resources.Resources.md_error
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(32, 20)
        Me.btnCancelar.Text = "ToolStripSplitButton1"
        Me.btnCancelar.ToolTipText = "Cancelar Proceso"
        Me.btnCancelar.Visible = False
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VerToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(722, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarComoExcelToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'GuardarComoExcelToolStripMenuItem
        '
        Me.GuardarComoExcelToolStripMenuItem.Image = CType(resources.GetObject("GuardarComoExcelToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuardarComoExcelToolStripMenuItem.Name = "GuardarComoExcelToolStripMenuItem"
        Me.GuardarComoExcelToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.GuardarComoExcelToolStripMenuItem.Text = "Guardar como Excel..."
        Me.GuardarComoExcelToolStripMenuItem.Visible = False
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformaciónDetalladaToolStripMenuItem, Me.InformaciónGeneralCompactaToolStripMenuItem, Me.InformaciónDeProductosHOBToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'InformaciónDetalladaToolStripMenuItem
        '
        Me.InformaciónDetalladaToolStripMenuItem.Name = "InformaciónDetalladaToolStripMenuItem"
        Me.InformaciónDetalladaToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.InformaciónDetalladaToolStripMenuItem.Text = "Información General Detallada"
        '
        'InformaciónGeneralCompactaToolStripMenuItem
        '
        Me.InformaciónGeneralCompactaToolStripMenuItem.Name = "InformaciónGeneralCompactaToolStripMenuItem"
        Me.InformaciónGeneralCompactaToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.InformaciónGeneralCompactaToolStripMenuItem.Text = "Información General compacta"
        '
        'InformaciónDeProductosHOBToolStripMenuItem
        '
        Me.InformaciónDeProductosHOBToolStripMenuItem.Name = "InformaciónDeProductosHOBToolStripMenuItem"
        Me.InformaciónDeProductosHOBToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.InformaciónDeProductosHOBToolStripMenuItem.Text = "Información de Productos HOB"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformaciónDeContraseñasDeUsuarioToolStripMenuItem, Me.UsuariosPorToolStripMenuItem, Me.UsuariosConSesionesHOBLinkJWTToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ReportesToolStripMenuItem.Text = "Gráficas"
        Me.ReportesToolStripMenuItem.Visible = False
        '
        'InformaciónDeContraseñasDeUsuarioToolStripMenuItem
        '
        Me.InformaciónDeContraseñasDeUsuarioToolStripMenuItem.Name = "InformaciónDeContraseñasDeUsuarioToolStripMenuItem"
        Me.InformaciónDeContraseñasDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.InformaciónDeContraseñasDeUsuarioToolStripMenuItem.Text = "Información de contraseñas de usuario"
        '
        'UsuariosPorToolStripMenuItem
        '
        Me.UsuariosPorToolStripMenuItem.Name = "UsuariosPorToolStripMenuItem"
        Me.UsuariosPorToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.UsuariosPorToolStripMenuItem.Text = "Usuarios por OU"
        '
        'UsuariosConSesionesHOBLinkJWTToolStripMenuItem
        '
        Me.UsuariosConSesionesHOBLinkJWTToolStripMenuItem.Name = "UsuariosConSesionesHOBLinkJWTToolStripMenuItem"
        Me.UsuariosConSesionesHOBLinkJWTToolStripMenuItem.Size = New System.Drawing.Size(272, 22)
        Me.UsuariosConSesionesHOBLinkJWTToolStripMenuItem.Text = "Usuarios con sesiones HOBLink JWT"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(722, 62)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Export2excel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me._ayuda_Buscar_BTN)
        Me.GroupBox1.Controls.Add(Me.Buscar_txt)
        Me.GroupBox1.Controls.Add(Me.BuscarPor_combo)
        Me.GroupBox1.Controls.Add(Me.FiltradoBtn)
        Me.GroupBox1.Controls.Add(Me.OUs_ComboBox)
        Me.GroupBox1.Controls.Add(Me.BuscarBtn)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(722, 62)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'Export2excel
        '
        Me.Export2excel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Export2excel.Image = CType(resources.GetObject("Export2excel.Image"), System.Drawing.Image)
        Me.Export2excel.Location = New System.Drawing.Point(605, 17)
        Me.Export2excel.Name = "Export2excel"
        Me.Export2excel.Size = New System.Drawing.Size(38, 38)
        Me.Export2excel.TabIndex = 16
        Me.Export2excel.UseVisualStyleBackColor = True
        Me.Export2excel.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(374, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Seleccionar Onidad Organizacional"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(246, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Buscar por:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Criterio de búsqueda"
        '
        '_ayuda_Buscar_BTN
        '
        Me._ayuda_Buscar_BTN.AutoSize = True
        Me._ayuda_Buscar_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me._ayuda_Buscar_BTN.Image = Global.CertificateGenerator.My.Resources.Resources.md_quest
        Me._ayuda_Buscar_BTN.Location = New System.Drawing.Point(649, 17)
        Me._ayuda_Buscar_BTN.Name = "_ayuda_Buscar_BTN"
        Me._ayuda_Buscar_BTN.Size = New System.Drawing.Size(38, 38)
        Me._ayuda_Buscar_BTN.TabIndex = 12
        Me._ayuda_Buscar_BTN.UseVisualStyleBackColor = True
        '
        'Buscar_txt
        '
        Me.Buscar_txt.Location = New System.Drawing.Point(6, 34)
        Me.Buscar_txt.Name = "Buscar_txt"
        Me.Buscar_txt.Size = New System.Drawing.Size(154, 20)
        Me.Buscar_txt.TabIndex = 11
        '
        'BuscarPor_combo
        '
        Me.BuscarPor_combo.FormattingEnabled = True
        Me.BuscarPor_combo.Items.AddRange(New Object() {"cn, nombre, apellido", "Unidad Organizacional"})
        Me.BuscarPor_combo.Location = New System.Drawing.Point(246, 34)
        Me.BuscarPor_combo.Name = "BuscarPor_combo"
        Me.BuscarPor_combo.Size = New System.Drawing.Size(121, 21)
        Me.BuscarPor_combo.TabIndex = 9
        '
        'FiltradoBtn
        '
        Me.FiltradoBtn.AutoSize = True
        Me.FiltradoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FiltradoBtn.Image = Global.CertificateGenerator.My.Resources.Resources.SMALL_PRTRED
        Me.FiltradoBtn.Location = New System.Drawing.Point(205, 28)
        Me.FiltradoBtn.Name = "FiltradoBtn"
        Me.FiltradoBtn.Size = New System.Drawing.Size(33, 28)
        Me.FiltradoBtn.TabIndex = 8
        Me.FiltradoBtn.UseVisualStyleBackColor = True
        '
        'OUs_ComboBox
        '
        Me.OUs_ComboBox.FormattingEnabled = True
        Me.OUs_ComboBox.Location = New System.Drawing.Point(374, 34)
        Me.OUs_ComboBox.Name = "OUs_ComboBox"
        Me.OUs_ComboBox.Size = New System.Drawing.Size(226, 21)
        Me.OUs_ComboBox.TabIndex = 10
        '
        'BuscarBtn
        '
        Me.BuscarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BuscarBtn.Image = Global.CertificateGenerator.My.Resources.Resources.QuickSearch
        Me.BuscarBtn.Location = New System.Drawing.Point(166, 28)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(33, 28)
        Me.BuscarBtn.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.BuscarBtn, "Buscar usuario en el Directorio Activo")
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'FiltradoPanel
        '
        Me.FiltradoPanel.Controls.Add(Me.FiltradoGpo)
        Me.FiltradoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.FiltradoPanel.Location = New System.Drawing.Point(0, 86)
        Me.FiltradoPanel.Name = "FiltradoPanel"
        Me.FiltradoPanel.Size = New System.Drawing.Size(722, 69)
        Me.FiltradoPanel.TabIndex = 3
        Me.FiltradoPanel.Visible = False
        '
        'FiltradoGpo
        '
        Me.FiltradoGpo.Controls.Add(Me.Label6)
        Me.FiltradoGpo.Controls.Add(Me.Button1)
        Me.FiltradoGpo.Controls.Add(Me.ComboBox2)
        Me.FiltradoGpo.Controls.Add(Me.Label2)
        Me.FiltradoGpo.Controls.Add(Me.ComboBox1)
        Me.FiltradoGpo.Controls.Add(Me.Label1)
        Me.FiltradoGpo.Controls.Add(Me.Filtro_txt)
        Me.FiltradoGpo.Location = New System.Drawing.Point(3, 6)
        Me.FiltradoGpo.Name = "FiltradoGpo"
        Me.FiltradoGpo.Size = New System.Drawing.Size(694, 55)
        Me.FiltradoGpo.TabIndex = 2
        Me.FiltradoGpo.TabStop = False
        Me.FiltradoGpo.Text = "Opciones de filtrado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Texto a filtrar"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Image = Global.CertificateGenerator.My.Resources.Resources.md_quest
        Me.Button1.Location = New System.Drawing.Point(650, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(278, 29)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Buscar en"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(151, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Aplicar Filtro"
        '
        'Filtro_txt
        '
        Me.Filtro_txt.Location = New System.Drawing.Point(10, 29)
        Me.Filtro_txt.Name = "Filtro_txt"
        Me.Filtro_txt.Size = New System.Drawing.Size(125, 20)
        Me.Filtro_txt.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 155)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(722, 243)
        Me.Panel3.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(722, 243)
        Me.DataGridView1.TabIndex = 1
        '
        'Bw1
        '
        '
        'LDAPlst_frm
        '
        Me.AcceptButton = Me.BuscarBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 420)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.FiltradoPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "LDAPlst_frm"
        Me.Text = "Listado de usuarios existentes en el Servidor LDAP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FiltradoPanel.ResumeLayout(False)
        Me.FiltradoGpo.ResumeLayout(False)
        Me.FiltradoGpo.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FiltradoPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents FiltradoGpo As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Filtro_txt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _ayuda_Buscar_BTN As System.Windows.Forms.Button
    Friend WithEvents Buscar_txt As System.Windows.Forms.TextBox
    Friend WithEvents BuscarPor_combo As System.Windows.Forms.ComboBox
    Friend WithEvents FiltradoBtn As System.Windows.Forms.Button
    Friend WithEvents OUs_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents pB1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Bw1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarComoExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Export2excel As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents InformaciónDetalladaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformaciónGeneralCompactaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformaciónDeProductosHOBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformaciónDeContraseñasDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosPorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosConSesionesHOBLinkJWTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
