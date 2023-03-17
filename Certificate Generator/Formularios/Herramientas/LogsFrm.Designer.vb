<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogsFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiltrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AyudaBtn = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VerToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(472, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarComoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'GuardarComoToolStripMenuItem
        '
        Me.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        Me.GuardarComoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.GuardarComoToolStripMenuItem.Text = "Guardar como..."
        Me.GuardarComoToolStripMenuItem.Visible = False
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.CertificateGenerator.My.Resources.Resources.TB_BIG_CLOSE
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiltrosToolStripMenuItem, Me.LimpiarVistaToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        Me.VerToolStripMenuItem.Visible = False
        '
        'FiltrosToolStripMenuItem
        '
        Me.FiltrosToolStripMenuItem.Name = "FiltrosToolStripMenuItem"
        Me.FiltrosToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.FiltrosToolStripMenuItem.Text = "Filtros..."
        '
        'LimpiarVistaToolStripMenuItem
        '
        Me.LimpiarVistaToolStripMenuItem.Name = "LimpiarVistaToolStripMenuItem"
        Me.LimpiarVistaToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.LimpiarVistaToolStripMenuItem.Text = "Limpiar vista"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AyudaToolStripMenuItem1})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        Me.AyudaToolStripMenuItem.Visible = False
        '
        'AyudaToolStripMenuItem1
        '
        Me.AyudaToolStripMenuItem1.Name = "AyudaToolStripMenuItem1"
        Me.AyudaToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.AyudaToolStripMenuItem1.Text = "Ayuda"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 353)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(472, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AyudaBtn)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 302)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 51)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Image = Global.CertificateGenerator.My.Resources.Resources.TB_BIG_EXITALL
        Me.Button2.Location = New System.Drawing.Point(3, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 38)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cerrar"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.CertificateGenerator.My.Resources.Resources.BIG_MENU
        Me.Button1.Location = New System.Drawing.Point(353, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Limpiar vista"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 278)
        Me.Panel2.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(472, 278)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Fecha / hora"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 5
        '
        'Column2
        '
        Me.Column2.HeaderText = "Acción"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 5
        '
        'Column3
        '
        Me.Column3.HeaderText = "Comentario"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 5
        '
        'AyudaBtn
        '
        Me.AyudaBtn.Image = Global.CertificateGenerator.My.Resources.Resources.md_quest
        Me.AyudaBtn.Location = New System.Drawing.Point(101, 6)
        Me.AyudaBtn.Name = "AyudaBtn"
        Me.AyudaBtn.Size = New System.Drawing.Size(92, 38)
        Me.AyudaBtn.TabIndex = 2
        Me.AyudaBtn.Text = "Ayuda"
        Me.AyudaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AyudaBtn.UseVisualStyleBackColor = True
        '
        'LogsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 375)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "LogsFrm"
        Me.Text = "Registro del Certificate Generator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FiltrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LimpiarVistaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AyudaBtn As System.Windows.Forms.Button
End Class
