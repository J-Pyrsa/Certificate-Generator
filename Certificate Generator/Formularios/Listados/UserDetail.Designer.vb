<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserDetail))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UserDetailBox = New System.Windows.Forms.GroupBox()
        Me.Ou_txt = New System.Windows.Forms.TextBox()
        Me.OU_Label = New System.Windows.Forms.Label()
        Me.passwordLastSet_txt = New System.Windows.Forms.TextBox()
        Me.QuedanDias_Label = New System.Windows.Forms.Label()
        Me.sn_txt = New System.Windows.Forms.TextBox()
        Me.givenname_txt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cn_lbl = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CertificateStatus_lbl = New System.Windows.Forms.Label()
        Me.ExpiraCert_txt = New System.Windows.Forms.TextBox()
        Me.EfectivoDesde_txt = New System.Windows.Forms.TextBox()
        Me.Version_lbl = New System.Windows.Forms.Label()
        Me.Clave_lbl = New System.Windows.Forms.Label()
        Me.HashCode_lbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Subject_label = New System.Windows.Forms.Label()
        Me.Emisor_Label = New System.Windows.Forms.Label()
        Me.JWT_Group = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pB1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Bw1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.UsersettingsLabel = New System.Windows.Forms.Label()
        Me.DoD_label = New System.Windows.Forms.Label()
        Me.jwt_label = New System.Windows.Forms.Label()
        Me.WSPUCLabel = New System.Windows.Forms.Label()
        Me.FTPLabel = New System.Windows.Forms.Label()
        Me.JTermLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UserDetailBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.JWT_Group.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(975, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'UserDetailBox
        '
        Me.UserDetailBox.Controls.Add(Me.Ou_txt)
        Me.UserDetailBox.Controls.Add(Me.OU_Label)
        Me.UserDetailBox.Controls.Add(Me.passwordLastSet_txt)
        Me.UserDetailBox.Controls.Add(Me.QuedanDias_Label)
        Me.UserDetailBox.Controls.Add(Me.sn_txt)
        Me.UserDetailBox.Controls.Add(Me.givenname_txt)
        Me.UserDetailBox.Controls.Add(Me.Label10)
        Me.UserDetailBox.Controls.Add(Me.Label2)
        Me.UserDetailBox.Controls.Add(Me.cn_lbl)
        Me.UserDetailBox.Location = New System.Drawing.Point(3, 12)
        Me.UserDetailBox.Name = "UserDetailBox"
        Me.UserDetailBox.Size = New System.Drawing.Size(294, 163)
        Me.UserDetailBox.TabIndex = 3
        Me.UserDetailBox.TabStop = False
        Me.UserDetailBox.Text = "Información del usuario"
        '
        'Ou_txt
        '
        Me.Ou_txt.Location = New System.Drawing.Point(5, 133)
        Me.Ou_txt.Name = "Ou_txt"
        Me.Ou_txt.ReadOnly = True
        Me.Ou_txt.Size = New System.Drawing.Size(279, 20)
        Me.Ou_txt.TabIndex = 9
        '
        'OU_Label
        '
        Me.OU_Label.AutoSize = True
        Me.OU_Label.Location = New System.Drawing.Point(5, 119)
        Me.OU_Label.Name = "OU_Label"
        Me.OU_Label.Size = New System.Drawing.Size(114, 13)
        Me.OU_Label.TabIndex = 8
        Me.OU_Label.Text = "Unidad Organizacional"
        '
        'passwordLastSet_txt
        '
        Me.passwordLastSet_txt.Location = New System.Drawing.Point(5, 92)
        Me.passwordLastSet_txt.Name = "passwordLastSet_txt"
        Me.passwordLastSet_txt.ReadOnly = True
        Me.passwordLastSet_txt.Size = New System.Drawing.Size(279, 20)
        Me.passwordLastSet_txt.TabIndex = 7
        '
        'QuedanDias_Label
        '
        Me.QuedanDias_Label.AutoSize = True
        Me.QuedanDias_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuedanDias_Label.Location = New System.Drawing.Point(121, 104)
        Me.QuedanDias_Label.Name = "QuedanDias_Label"
        Me.QuedanDias_Label.Size = New System.Drawing.Size(0, 13)
        Me.QuedanDias_Label.TabIndex = 6
        '
        'sn_txt
        '
        Me.sn_txt.Location = New System.Drawing.Point(55, 45)
        Me.sn_txt.Name = "sn_txt"
        Me.sn_txt.ReadOnly = True
        Me.sn_txt.Size = New System.Drawing.Size(229, 20)
        Me.sn_txt.TabIndex = 5
        '
        'givenname_txt
        '
        Me.givenname_txt.Location = New System.Drawing.Point(55, 15)
        Me.givenname_txt.Name = "givenname_txt"
        Me.givenname_txt.ReadOnly = True
        Me.givenname_txt.Size = New System.Drawing.Size(229, 20)
        Me.givenname_txt.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Contraseña caduca en"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos"
        '
        'cn_lbl
        '
        Me.cn_lbl.AutoSize = True
        Me.cn_lbl.Location = New System.Drawing.Point(5, 19)
        Me.cn_lbl.Name = "cn_lbl"
        Me.cn_lbl.Size = New System.Drawing.Size(44, 13)
        Me.cn_lbl.TabIndex = 0
        Me.cn_lbl.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CertificateStatus_lbl)
        Me.GroupBox2.Controls.Add(Me.ExpiraCert_txt)
        Me.GroupBox2.Controls.Add(Me.EfectivoDesde_txt)
        Me.GroupBox2.Controls.Add(Me.Version_lbl)
        Me.GroupBox2.Controls.Add(Me.Clave_lbl)
        Me.GroupBox2.Controls.Add(Me.HashCode_lbl)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Subject_label)
        Me.GroupBox2.Controls.Add(Me.Emisor_Label)
        Me.GroupBox2.Location = New System.Drawing.Point(300, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 171)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del certificado"
        '
        'CertificateStatus_lbl
        '
        Me.CertificateStatus_lbl.AutoSize = True
        Me.CertificateStatus_lbl.Location = New System.Drawing.Point(16, 146)
        Me.CertificateStatus_lbl.Name = "CertificateStatus_lbl"
        Me.CertificateStatus_lbl.Size = New System.Drawing.Size(39, 13)
        Me.CertificateStatus_lbl.TabIndex = 9
        Me.CertificateStatus_lbl.Text = "Label1"
        '
        'ExpiraCert_txt
        '
        Me.ExpiraCert_txt.Location = New System.Drawing.Point(242, 58)
        Me.ExpiraCert_txt.Name = "ExpiraCert_txt"
        Me.ExpiraCert_txt.ReadOnly = True
        Me.ExpiraCert_txt.Size = New System.Drawing.Size(104, 20)
        Me.ExpiraCert_txt.TabIndex = 8
        '
        'EfectivoDesde_txt
        '
        Me.EfectivoDesde_txt.Location = New System.Drawing.Point(91, 58)
        Me.EfectivoDesde_txt.Name = "EfectivoDesde_txt"
        Me.EfectivoDesde_txt.ReadOnly = True
        Me.EfectivoDesde_txt.Size = New System.Drawing.Size(104, 20)
        Me.EfectivoDesde_txt.TabIndex = 7
        '
        'Version_lbl
        '
        Me.Version_lbl.AutoSize = True
        Me.Version_lbl.Location = New System.Drawing.Point(16, 104)
        Me.Version_lbl.Name = "Version_lbl"
        Me.Version_lbl.Size = New System.Drawing.Size(126, 13)
        Me.Version_lbl.TabIndex = 6
        Me.Version_lbl.Text = "Versión del certificado:  v"
        '
        'Clave_lbl
        '
        Me.Clave_lbl.AutoSize = True
        Me.Clave_lbl.Location = New System.Drawing.Point(16, 125)
        Me.Clave_lbl.Name = "Clave_lbl"
        Me.Clave_lbl.Size = New System.Drawing.Size(77, 13)
        Me.Clave_lbl.TabIndex = 5
        Me.Clave_lbl.Text = "Clave pública: "
        '
        'HashCode_lbl
        '
        Me.HashCode_lbl.AutoSize = True
        Me.HashCode_lbl.Location = New System.Drawing.Point(16, 83)
        Me.HashCode_lbl.Name = "HashCode_lbl"
        Me.HashCode_lbl.Size = New System.Drawing.Size(74, 13)
        Me.HashCode_lbl.TabIndex = 4
        Me.HashCode_lbl.Text = "Código Hash: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "hasta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Válido desde"
        '
        'Subject_label
        '
        Me.Subject_label.AutoSize = True
        Me.Subject_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject_label.ForeColor = System.Drawing.Color.Magenta
        Me.Subject_label.Location = New System.Drawing.Point(16, 41)
        Me.Subject_label.Name = "Subject_label"
        Me.Subject_label.Size = New System.Drawing.Size(61, 13)
        Me.Subject_label.TabIndex = 1
        Me.Subject_label.Text = "Enviado a: "
        '
        'Emisor_Label
        '
        Me.Emisor_Label.AutoSize = True
        Me.Emisor_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emisor_Label.ForeColor = System.Drawing.Color.Blue
        Me.Emisor_Label.Location = New System.Drawing.Point(16, 20)
        Me.Emisor_Label.Name = "Emisor_Label"
        Me.Emisor_Label.Size = New System.Drawing.Size(44, 13)
        Me.Emisor_Label.TabIndex = 0
        Me.Emisor_Label.Text = "Emisor: "
        '
        'JWT_Group
        '
        Me.JWT_Group.Controls.Add(Me.StatusStrip1)
        Me.JWT_Group.Controls.Add(Me.DataGridView1)
        Me.JWT_Group.Dock = System.Windows.Forms.DockStyle.Fill
        Me.JWT_Group.Location = New System.Drawing.Point(0, 0)
        Me.JWT_Group.Name = "JWT_Group"
        Me.JWT_Group.Size = New System.Drawing.Size(975, 199)
        Me.JWT_Group.TabIndex = 5
        Me.JWT_Group.TabStop = False
        Me.JWT_Group.Text = "Información de sesiones HOBLinik JWT "
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pB1, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 174)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(969, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'pB1
        '
        Me.pB1.Name = "pB1"
        Me.pB1.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(111, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(969, 180)
        Me.DataGridView1.TabIndex = 0
        '
        'Bw1
        '
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.UsersettingsLabel)
        Me.GroupBox4.Controls.Add(Me.DoD_label)
        Me.GroupBox4.Controls.Add(Me.jwt_label)
        Me.GroupBox4.Controls.Add(Me.WSPUCLabel)
        Me.GroupBox4.Controls.Add(Me.FTPLabel)
        Me.GroupBox4.Controls.Add(Me.JTermLabel)
        Me.GroupBox4.Location = New System.Drawing.Point(659, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(289, 171)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Configuraciones HOB RD VPN"
        '
        'UsersettingsLabel
        '
        Me.UsersettingsLabel.AutoSize = True
        Me.UsersettingsLabel.Location = New System.Drawing.Point(6, 119)
        Me.UsersettingsLabel.Name = "UsersettingsLabel"
        Me.UsersettingsLabel.Size = New System.Drawing.Size(165, 13)
        Me.UsersettingsLabel.TabIndex = 5
        Me.UsersettingsLabel.Text = "Página después de autenticarse: "
        '
        'DoD_label
        '
        Me.DoD_label.AutoSize = True
        Me.DoD_label.Location = New System.Drawing.Point(6, 79)
        Me.DoD_label.Name = "DoD_label"
        Me.DoD_label.Size = New System.Drawing.Size(35, 13)
        Me.DoD_label.TabIndex = 4
        Me.DoD_label.Text = "DoD: "
        '
        'jwt_label
        '
        Me.jwt_label.AutoSize = True
        Me.jwt_label.Location = New System.Drawing.Point(6, 19)
        Me.jwt_label.Name = "jwt_label"
        Me.jwt_label.Size = New System.Drawing.Size(120, 13)
        Me.jwt_label.TabIndex = 3
        Me.jwt_label.Text = "Sesiónes JWT listadas: "
        '
        'WSPUCLabel
        '
        Me.WSPUCLabel.AutoSize = True
        Me.WSPUCLabel.Location = New System.Drawing.Point(6, 99)
        Me.WSPUCLabel.Name = "WSPUCLabel"
        Me.WSPUCLabel.Size = New System.Drawing.Size(143, 13)
        Me.WSPUCLabel.TabIndex = 2
        Me.WSPUCLabel.Text = "WebSecureUniversal Client: "
        '
        'FTPLabel
        '
        Me.FTPLabel.AutoSize = True
        Me.FTPLabel.Location = New System.Drawing.Point(6, 59)
        Me.FTPLabel.Name = "FTPLabel"
        Me.FTPLabel.Size = New System.Drawing.Size(30, 13)
        Me.FTPLabel.TabIndex = 1
        Me.FTPLabel.Text = "FTP:"
        '
        'JTermLabel
        '
        Me.JTermLabel.AutoSize = True
        Me.JTermLabel.Location = New System.Drawing.Point(6, 39)
        Me.JTermLabel.Name = "JTermLabel"
        Me.JTermLabel.Size = New System.Drawing.Size(39, 13)
        Me.JTermLabel.TabIndex = 0
        Me.JTermLabel.Text = "JTerm:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UserDetailBox)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(975, 191)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.JWT_Group)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 191)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(975, 199)
        Me.Panel2.TabIndex = 12
        '
        'UserDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 390)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "UserDetail"
        Me.Text = "UserDetail"
        Me.UserDetailBox.ResumeLayout(False)
        Me.UserDetailBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.JWT_Group.ResumeLayout(False)
        Me.JWT_Group.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents UserDetailBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cn_lbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents JWT_Group As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Version_lbl As System.Windows.Forms.Label
    Friend WithEvents Clave_lbl As System.Windows.Forms.Label
    Friend WithEvents HashCode_lbl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Subject_label As System.Windows.Forms.Label
    Friend WithEvents Emisor_Label As System.Windows.Forms.Label
    Friend WithEvents Bw1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents givenname_txt As System.Windows.Forms.TextBox
    Friend WithEvents sn_txt As System.Windows.Forms.TextBox
    Friend WithEvents QuedanDias_Label As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents JTermLabel As System.Windows.Forms.Label
    Friend WithEvents FTPLabel As System.Windows.Forms.Label
    Friend WithEvents WSPUCLabel As System.Windows.Forms.Label
    Friend WithEvents EfectivoDesde_txt As System.Windows.Forms.TextBox
    Friend WithEvents ExpiraCert_txt As System.Windows.Forms.TextBox
    Friend WithEvents jwt_label As System.Windows.Forms.Label
    Friend WithEvents passwordLastSet_txt As System.Windows.Forms.TextBox
    Friend WithEvents DoD_label As System.Windows.Forms.Label
    Friend WithEvents UsersettingsLabel As System.Windows.Forms.Label
    Friend WithEvents Ou_txt As System.Windows.Forms.TextBox
    Friend WithEvents OU_Label As System.Windows.Forms.Label
    Friend WithEvents CertificateStatus_lbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents pB1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
