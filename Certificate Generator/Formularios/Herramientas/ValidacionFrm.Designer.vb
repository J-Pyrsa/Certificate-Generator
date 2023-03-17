<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValidacionFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ValidacionFrm))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Iniciar_btn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AyudaBtn = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AyudaBtn)
        Me.Panel2.Controls.Add(Me.Iniciar_btn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 253)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(773, 51)
        Me.Panel2.TabIndex = 1
        '
        'Iniciar_btn
        '
        Me.Iniciar_btn.Image = CType(resources.GetObject("Iniciar_btn.Image"), System.Drawing.Image)
        Me.Iniciar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Iniciar_btn.Location = New System.Drawing.Point(3, 6)
        Me.Iniciar_btn.Name = "Iniciar_btn"
        Me.Iniciar_btn.Size = New System.Drawing.Size(121, 42)
        Me.Iniciar_btn.TabIndex = 0
        Me.Iniciar_btn.Text = "Volver a validar"
        Me.Iniciar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Iniciar_btn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(773, 253)
        Me.DataGridView1.TabIndex = 2
        '
        'AyudaBtn
        '
        Me.AyudaBtn.Image = Global.CertificateGenerator.My.Resources.Resources.md_quest
        Me.AyudaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AyudaBtn.Location = New System.Drawing.Point(130, 6)
        Me.AyudaBtn.Name = "AyudaBtn"
        Me.AyudaBtn.Size = New System.Drawing.Size(77, 42)
        Me.AyudaBtn.TabIndex = 1
        Me.AyudaBtn.Text = "Ayuda"
        Me.AyudaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AyudaBtn.UseVisualStyleBackColor = True
        '
        'ValidacionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 304)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ValidacionFrm"
        Me.Text = "Validar Directorios y variables de entorno"
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Iniciar_btn As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AyudaBtn As System.Windows.Forms.Button
End Class
