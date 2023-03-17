<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigFrm))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DB_txt = New System.Windows.Forms.TextBox()
        Me.cakey_txt = New System.Windows.Forms.TextBox()
        Me.ConfigFile_txt = New System.Windows.Forms.TextBox()
        Me.cacert_txt = New System.Windows.Forms.TextBox()
        Me.RutaCerts_txt = New System.Windows.Forms.TextBox()
        Me.Usuario_LDAP_txt = New System.Windows.Forms.TextBox()
        Me.Pass_LDAP_txt = New System.Windows.Forms.TextBox()
        Me.Dominio_txt = New System.Windows.Forms.TextBox()
        Me.Direccion_LDAP_txt = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Ayuda_txt = New System.Windows.Forms.Button()
        Me.Cancelar_btn = New System.Windows.Forms.Button()
        Me.Guardar_btn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ConfigFile_rtb = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'DB_txt
        '
        Me.DB_txt.Location = New System.Drawing.Point(8, 208)
        Me.DB_txt.Name = "DB_txt"
        Me.DB_txt.Size = New System.Drawing.Size(281, 20)
        Me.DB_txt.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.DB_txt, "Base de Datos MS Access 2003")
        '
        'cakey_txt
        '
        Me.cakey_txt.Location = New System.Drawing.Point(8, 117)
        Me.cakey_txt.Name = "cakey_txt"
        Me.cakey_txt.Size = New System.Drawing.Size(281, 20)
        Me.cakey_txt.TabIndex = 48
        Me.ToolTip1.SetToolTip(Me.cakey_txt, "Ruta de la llave privada de la CA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ej. cakey.pem)")
        '
        'ConfigFile_txt
        '
        Me.ConfigFile_txt.Location = New System.Drawing.Point(8, 164)
        Me.ConfigFile_txt.Name = "ConfigFile_txt"
        Me.ConfigFile_txt.Size = New System.Drawing.Size(281, 20)
        Me.ConfigFile_txt.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.ConfigFile_txt, "Archivo de configuración para Open SSL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(pe. config.conf)")
        '
        'cacert_txt
        '
        Me.cacert_txt.Location = New System.Drawing.Point(8, 73)
        Me.cacert_txt.Name = "cacert_txt"
        Me.cacert_txt.Size = New System.Drawing.Size(281, 20)
        Me.cacert_txt.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.cacert_txt, "Ruta del Certificado de la CA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ej. cacert.pem)")
        '
        'RutaCerts_txt
        '
        Me.RutaCerts_txt.Location = New System.Drawing.Point(8, 30)
        Me.RutaCerts_txt.Name = "RutaCerts_txt"
        Me.RutaCerts_txt.Size = New System.Drawing.Size(281, 20)
        Me.RutaCerts_txt.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.RutaCerts_txt, "Ruta dónde se guardarán" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "los certificados creados")
        '
        'Usuario_LDAP_txt
        '
        Me.Usuario_LDAP_txt.Location = New System.Drawing.Point(6, 46)
        Me.Usuario_LDAP_txt.Name = "Usuario_LDAP_txt"
        Me.Usuario_LDAP_txt.Size = New System.Drawing.Size(183, 20)
        Me.Usuario_LDAP_txt.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Usuario_LDAP_txt, "Ejemplo; Admniistrador")
        '
        'Pass_LDAP_txt
        '
        Me.Pass_LDAP_txt.Location = New System.Drawing.Point(6, 93)
        Me.Pass_LDAP_txt.Name = "Pass_LDAP_txt"
        Me.Pass_LDAP_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Pass_LDAP_txt.Size = New System.Drawing.Size(183, 20)
        Me.Pass_LDAP_txt.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Pass_LDAP_txt, "Contraseña del usaurio de dominio")
        '
        'Dominio_txt
        '
        Me.Dominio_txt.Location = New System.Drawing.Point(6, 143)
        Me.Dominio_txt.Name = "Dominio_txt"
        Me.Dominio_txt.Size = New System.Drawing.Size(183, 20)
        Me.Dominio_txt.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.Dominio_txt, "Ejemplo;  HOB")
        '
        'Direccion_LDAP_txt
        '
        Me.Direccion_LDAP_txt.Location = New System.Drawing.Point(6, 193)
        Me.Direccion_LDAP_txt.Name = "Direccion_LDAP_txt"
        Me.Direccion_LDAP_txt.Size = New System.Drawing.Size(183, 20)
        Me.Direccion_LDAP_txt.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.Direccion_LDAP_txt, "Ejemplo;  192.168.1.1, o bien; principal.mi_empresa.local")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Ayuda_txt)
        Me.Panel2.Controls.Add(Me.Cancelar_btn)
        Me.Panel2.Controls.Add(Me.Guardar_btn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 351)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(479, 61)
        Me.Panel2.TabIndex = 1
        '
        'Ayuda_txt
        '
        Me.HelpProvider1.SetHelpKeyword(Me.Ayuda_txt, "Configuración")
        Me.HelpProvider1.SetHelpNavigator(Me.Ayuda_txt, System.Windows.Forms.HelpNavigator.Find)
        Me.HelpProvider1.SetHelpString(Me.Ayuda_txt, "Configuración")
        Me.Ayuda_txt.Image = Global.CertificateGenerator.My.Resources.Resources.md_quest
        Me.Ayuda_txt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Ayuda_txt.Location = New System.Drawing.Point(387, 7)
        Me.Ayuda_txt.Name = "Ayuda_txt"
        Me.HelpProvider1.SetShowHelp(Me.Ayuda_txt, True)
        Me.Ayuda_txt.Size = New System.Drawing.Size(83, 42)
        Me.Ayuda_txt.TabIndex = 49
        Me.Ayuda_txt.Text = "Ayuda"
        Me.Ayuda_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Ayuda_txt.UseVisualStyleBackColor = True
        '
        'Cancelar_btn
        '
        Me.Cancelar_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancelar_btn.Image = Global.CertificateGenerator.My.Resources.Resources.md_error
        Me.Cancelar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancelar_btn.Location = New System.Drawing.Point(100, 7)
        Me.Cancelar_btn.Name = "Cancelar_btn"
        Me.Cancelar_btn.Size = New System.Drawing.Size(88, 42)
        Me.Cancelar_btn.TabIndex = 48
        Me.Cancelar_btn.Text = "Cancelar"
        Me.Cancelar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cancelar_btn.UseVisualStyleBackColor = True
        '
        'Guardar_btn
        '
        Me.HelpProvider1.SetHelpNavigator(Me.Guardar_btn, System.Windows.Forms.HelpNavigator.Topic)
        Me.Guardar_btn.Image = Global.CertificateGenerator.My.Resources.Resources.TB_BIG_SAVESESSION
        Me.Guardar_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Guardar_btn.Location = New System.Drawing.Point(11, 7)
        Me.Guardar_btn.Name = "Guardar_btn"
        Me.HelpProvider1.SetShowHelp(Me.Guardar_btn, True)
        Me.Guardar_btn.Size = New System.Drawing.Size(83, 42)
        Me.Guardar_btn.TabIndex = 47
        Me.Guardar_btn.Text = "Guardar"
        Me.Guardar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Guardar_btn.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(479, 351)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Controls.Add(Me.DB_txt)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.cakey_txt)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.ConfigFile_rtb)
        Me.TabPage1.Controls.Add(Me.ConfigFile_txt)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.cacert_txt)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.RutaCerts_txt)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(471, 325)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Configuración general"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(348, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(299, 206)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(32, 23)
        Me.Button7.TabIndex = 55
        Me.Button7.Text = "..."
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Base de Datos Access 2003"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(299, 116)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 23)
        Me.Button5.TabIndex = 49
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Llave privada de la CA"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(299, 162)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 23)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(300, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 23)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(299, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Contenido del archivo de configuración"
        '
        'ConfigFile_rtb
        '
        Me.ConfigFile_rtb.Location = New System.Drawing.Point(8, 254)
        Me.ConfigFile_rtb.Name = "ConfigFile_rtb"
        Me.ConfigFile_rtb.ReadOnly = True
        Me.ConfigFile_rtb.Size = New System.Drawing.Size(456, 59)
        Me.ConfigFile_rtb.TabIndex = 38
        Me.ConfigFile_rtb.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Archivo de configuración"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Certificado CA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Ruta de salida"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CheckBox1)
        Me.TabPage3.Controls.Add(Me.PictureBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(471, 325)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Conexión LDAP"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(17, 17)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(123, 17)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Use Active Directory"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(260, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(193, 87)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Usuario_LDAP_txt)
        Me.GroupBox1.Controls.Add(Me.Direccion_LDAP_txt)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Dominio_txt)
        Me.GroupBox1.Controls.Add(Me.Pass_LDAP_txt)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 246)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de conexión"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Usuario de dominio"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 174)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(179, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Dirección del controlador de dominio"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(169, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Contraseña del usaurio de dominio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Dominio"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\CertificateGenerator\Debug\bin\Certificate Generator.chm"
        '
        'ConfigFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancelar_btn
        Me.ClientSize = New System.Drawing.Size(479, 412)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConfigFrm"
        Me.Text = "Configuración"
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Ayuda_txt As System.Windows.Forms.Button
    Friend WithEvents Cancelar_btn As System.Windows.Forms.Button
    Friend WithEvents Guardar_btn As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents DB_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents cakey_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ConfigFile_rtb As System.Windows.Forms.RichTextBox
    Friend WithEvents ConfigFile_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cacert_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RutaCerts_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Pass_LDAP_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Usuario_LDAP_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Dominio_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Direccion_LDAP_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
