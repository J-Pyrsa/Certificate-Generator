<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoCertificados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoCertificados))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TópicosDeAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ExcelExport_Btn = New System.Windows.Forms.ToolStripButton()
        Me.BuscarBtn = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BuscarPanel = New System.Windows.Forms.Panel()
        Me.BuscarGpo = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BuscarPanel.SuspendLayout()
        Me.BuscarGpo.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(611, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.CertificateGenerator.My.Resources.Resources.TB_BIG_CLOSE
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TópicosDeAyudaToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'TópicosDeAyudaToolStripMenuItem
        '
        Me.TópicosDeAyudaToolStripMenuItem.Image = Global.CertificateGenerator.My.Resources.Resources.md_quest
        Me.TópicosDeAyudaToolStripMenuItem.Name = "TópicosDeAyudaToolStripMenuItem"
        Me.TópicosDeAyudaToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.TópicosDeAyudaToolStripMenuItem.Text = "Tópicos de ayuda"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ExcelExport_Btn, Me.BuscarBtn})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(611, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.CertificateGenerator.My.Resources.Resources.BIG_FILETRANSFER
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(74, 22)
        Me.ToolStripButton1.Text = "Actualizar"
        '
        'ExcelExport_Btn
        '
        Me.ExcelExport_Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExcelExport_Btn.Image = CType(resources.GetObject("ExcelExport_Btn.Image"), System.Drawing.Image)
        Me.ExcelExport_Btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcelExport_Btn.Name = "ExcelExport_Btn"
        Me.ExcelExport_Btn.Size = New System.Drawing.Size(23, 22)
        Me.ExcelExport_Btn.Text = "Exportar a excel"
        Me.ExcelExport_Btn.ToolTipText = "Exportar al Formato de Microsoft Excel"
        '
        'BuscarBtn
        '
        Me.BuscarBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BuscarBtn.Image = Global.CertificateGenerator.My.Resources.Resources.QuickSearch
        Me.BuscarBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(23, 22)
        Me.BuscarBtn.Text = "Buscar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.BuscarPanel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(611, 347)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 75)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(611, 272)
        Me.Panel3.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(611, 272)
        Me.DataGridView1.TabIndex = 1
        '
        'BuscarPanel
        '
        Me.BuscarPanel.Controls.Add(Me.BuscarGpo)
        Me.BuscarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.BuscarPanel.Location = New System.Drawing.Point(0, 0)
        Me.BuscarPanel.Name = "BuscarPanel"
        Me.BuscarPanel.Size = New System.Drawing.Size(611, 75)
        Me.BuscarPanel.TabIndex = 0
        Me.BuscarPanel.Visible = False
        '
        'BuscarGpo
        '
        Me.BuscarGpo.Controls.Add(Me.Button1)
        Me.BuscarGpo.Controls.Add(Me.ComboBox2)
        Me.BuscarGpo.Controls.Add(Me.Label2)
        Me.BuscarGpo.Controls.Add(Me.ComboBox1)
        Me.BuscarGpo.Controls.Add(Me.Label1)
        Me.BuscarGpo.Controls.Add(Me.TextBox1)
        Me.BuscarGpo.Location = New System.Drawing.Point(12, 6)
        Me.BuscarGpo.Name = "BuscarGpo"
        Me.BuscarGpo.Size = New System.Drawing.Size(587, 55)
        Me.BuscarGpo.TabIndex = 0
        Me.BuscarGpo.TabStop = False
        Me.BuscarGpo.Text = "Opciones de búsqueda"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(401, 19)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(339, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Buscar en"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(211, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Aplicar Filtro"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 20)
        Me.TextBox1.TabIndex = 0
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Microsoft Excel|*.xls|Todos los archivos|*.*"
        Me.SaveFileDialog1.Title = "Guardar archivo en formato de Microsoft Excel"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Image = Global.CertificateGenerator.My.Resources.Resources.md_quest
        Me.Button1.Location = New System.Drawing.Point(543, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListadoCertificados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 396)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ListadoCertificados"
        Me.Text = "Listado de certificados emitios"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BuscarPanel.ResumeLayout(False)
        Me.BuscarGpo.ResumeLayout(False)
        Me.BuscarGpo.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SnDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GivennameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PassCertDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadAnosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaEmisionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExcelExport_Btn As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BuscarBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BuscarPanel As System.Windows.Forms.Panel
    Friend WithEvents BuscarGpo As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TópicosDeAyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
