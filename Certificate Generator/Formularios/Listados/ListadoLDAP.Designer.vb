<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoLDAP
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListadoLDAP))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OcultarColumnasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciHOBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pB1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Bw1 = New System.ComponentModel.BackgroundWorker()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OUs_ComboBox = New System.Windows.Forms.ComboBox()
        Me.BuscarPanel = New System.Windows.Forms.Panel()
        Me.FiltradoGpo = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PanelGrid = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Buscar_txt = New System.Windows.Forms.TextBox()
        Me.BuscarPor_combo = New System.Windows.Forms.ComboBox()
        Me.FiltradoBtn = New System.Windows.Forms.Button()
        Me.BuscarBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me._ayuda_Buscar_BTN = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.BuscarPanel.SuspendLayout()
        Me.FiltradoGpo.SuspendLayout()
        Me.PanelGrid.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(709, 24)
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
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OcultarColumnasToolStripMenuItem, Me.InformaciHOBToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'OcultarColumnasToolStripMenuItem
        '
        Me.OcultarColumnasToolStripMenuItem.Name = "OcultarColumnasToolStripMenuItem"
        Me.OcultarColumnasToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.OcultarColumnasToolStripMenuItem.Text = "Ocultar Columnas"
        Me.OcultarColumnasToolStripMenuItem.Visible = False
        '
        'InformaciHOBToolStripMenuItem
        '
        Me.InformaciHOBToolStripMenuItem.Name = "InformaciHOBToolStripMenuItem"
        Me.InformaciHOBToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.InformaciHOBToolStripMenuItem.Text = "Información HOB"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AllowItemReorder = True
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pB1, Me.btnCancelar, Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 348)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(709, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pB1
        '
        Me.pB1.Name = "pB1"
        Me.pB1.Size = New System.Drawing.Size(100, 16)
        Me.pB1.Visible = False
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(25, 17)
        Me.StatusLabel.Text = "123"
        '
        'Bw1
        '
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Microsoft Excel|*.xls|Todos los archivos|*.*"
        Me.SaveFileDialog1.Title = "Guardar archivo en formato de Microsoft Excel"
        '
        'OUs_ComboBox
        '
        Me.OUs_ComboBox.FormattingEnabled = True
        Me.OUs_ComboBox.Location = New System.Drawing.Point(375, 13)
        Me.OUs_ComboBox.Name = "OUs_ComboBox"
        Me.OUs_ComboBox.Size = New System.Drawing.Size(226, 21)
        Me.OUs_ComboBox.TabIndex = 4
        '
        'BuscarPanel
        '
        Me.BuscarPanel.Controls.Add(Me.FiltradoGpo)
        Me.BuscarPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BuscarPanel.Location = New System.Drawing.Point(0, 255)
        Me.BuscarPanel.Name = "BuscarPanel"
        Me.BuscarPanel.Size = New System.Drawing.Size(709, 93)
        Me.BuscarPanel.TabIndex = 6
        Me.BuscarPanel.Visible = False
        '
        'FiltradoGpo
        '
        Me.FiltradoGpo.Controls.Add(Me.Button1)
        Me.FiltradoGpo.Controls.Add(Me.ComboBox2)
        Me.FiltradoGpo.Controls.Add(Me.Label2)
        Me.FiltradoGpo.Controls.Add(Me.ComboBox1)
        Me.FiltradoGpo.Controls.Add(Me.Label1)
        Me.FiltradoGpo.Controls.Add(Me.TextBox1)
        Me.FiltradoGpo.Location = New System.Drawing.Point(3, 3)
        Me.FiltradoGpo.Name = "FiltradoGpo"
        Me.FiltradoGpo.Size = New System.Drawing.Size(694, 55)
        Me.FiltradoGpo.TabIndex = 1
        Me.FiltradoGpo.TabStop = False
        Me.FiltradoGpo.Text = "Opciones de filtrado"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(401, 19)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 2
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
        Me.ComboBox1.TabIndex = 1
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
        'PanelGrid
        '
        Me.PanelGrid.Controls.Add(Me.DataGridView1)
        Me.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrid.Location = New System.Drawing.Point(0, 24)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(709, 324)
        Me.PanelGrid.TabIndex = 7
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
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(709, 324)
        Me.DataGridView1.TabIndex = 0
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me._ayuda_Buscar_BTN)
        Me.Panel1.Controls.Add(Me.Buscar_txt)
        Me.Panel1.Controls.Add(Me.BuscarPor_combo)
        Me.Panel1.Controls.Add(Me.FiltradoBtn)
        Me.Panel1.Controls.Add(Me.OUs_ComboBox)
        Me.Panel1.Controls.Add(Me.BuscarBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(709, 69)
        Me.Panel1.TabIndex = 9
        '
        'Buscar_txt
        '
        Me.Buscar_txt.Location = New System.Drawing.Point(7, 11)
        Me.Buscar_txt.Name = "Buscar_txt"
        Me.Buscar_txt.Size = New System.Drawing.Size(154, 20)
        Me.Buscar_txt.TabIndex = 4
        '
        'BuscarPor_combo
        '
        Me.BuscarPor_combo.FormattingEnabled = True
        Me.BuscarPor_combo.Items.AddRange(New Object() {"cn, nombre, apellido", "Unidad Organizacional"})
        Me.BuscarPor_combo.Location = New System.Drawing.Point(248, 13)
        Me.BuscarPor_combo.Name = "BuscarPor_combo"
        Me.BuscarPor_combo.Size = New System.Drawing.Size(121, 21)
        Me.BuscarPor_combo.TabIndex = 3
        '
        'FiltradoBtn
        '
        Me.FiltradoBtn.Location = New System.Drawing.Point(7, 37)
        Me.FiltradoBtn.Name = "FiltradoBtn"
        Me.FiltradoBtn.Size = New System.Drawing.Size(75, 23)
        Me.FiltradoBtn.TabIndex = 1
        Me.FiltradoBtn.Text = "Filtrado"
        Me.FiltradoBtn.UseVisualStyleBackColor = True
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Location = New System.Drawing.Point(167, 11)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(75, 23)
        Me.BuscarBtn.TabIndex = 0
        Me.BuscarBtn.Text = "Buscar"
        Me.BuscarBtn.UseVisualStyleBackColor = True
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
        '_ayuda_Buscar_BTN
        '
        Me._ayuda_Buscar_BTN.AutoSize = True
        Me._ayuda_Buscar_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me._ayuda_Buscar_BTN.Image = Global.CertificateGenerator.My.Resources.Resources.md_quest
        Me._ayuda_Buscar_BTN.Location = New System.Drawing.Point(632, 3)
        Me._ayuda_Buscar_BTN.Name = "_ayuda_Buscar_BTN"
        Me._ayuda_Buscar_BTN.Size = New System.Drawing.Size(38, 38)
        Me._ayuda_Buscar_BTN.TabIndex = 6
        Me._ayuda_Buscar_BTN.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.CertificateGenerator.My.Resources.Resources.md_error
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(78, 20)
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Visible = False
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.CertificateGenerator.My.Resources.Resources.TB_BIG_CLOSE
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ListadoLDAP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(709, 370)
        Me.Controls.Add(Me.BuscarPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelGrid)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ListadoLDAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de usaurios LDAP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.BuscarPanel.ResumeLayout(False)
        Me.FiltradoGpo.ResumeLayout(False)
        Me.FiltradoGpo.PerformLayout()
        Me.PanelGrid.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OcultarColumnasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bw1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pB1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OUs_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BuscarPanel As System.Windows.Forms.Panel
    Friend WithEvents PanelGrid As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FiltradoGpo As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents InformaciHOBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents FiltradoBtn As System.Windows.Forms.Button
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents BuscarPor_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Buscar_txt As System.Windows.Forms.TextBox
    Friend WithEvents _ayuda_Buscar_BTN As System.Windows.Forms.Button
    Private WithEvents Panel1 As System.Windows.Forms.Panel
End Class
