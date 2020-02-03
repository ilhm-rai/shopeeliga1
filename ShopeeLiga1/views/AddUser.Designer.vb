<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUser))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtIdUser = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.labelPasswordMessage = New System.Windows.Forms.Label()
        Me.radioBtnUser = New System.Windows.Forms.RadioButton()
        Me.radioBtnAdmin = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRegister = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPhone = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRetypePwd = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFullname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtIdUser)
        Me.Panel1.Controls.Add(Me.labelPasswordMessage)
        Me.Panel1.Controls.Add(Me.radioBtnUser)
        Me.Panel1.Controls.Add(Me.radioBtnAdmin)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnRegister)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtPhone)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtRetypePwd)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtFullname)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 511)
        Me.Panel1.TabIndex = 1
        '
        'txtIdUser
        '
        Me.txtIdUser.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtIdUser.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtIdUser.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtIdUser.BorderThickness = 1
        Me.txtIdUser.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdUser.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtIdUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIdUser.isPassword = False
        Me.txtIdUser.Location = New System.Drawing.Point(345, 371)
        Me.txtIdUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdUser.MaxLength = 32767
        Me.txtIdUser.Name = "txtIdUser"
        Me.txtIdUser.Size = New System.Drawing.Size(206, 35)
        Me.txtIdUser.TabIndex = 61
        Me.txtIdUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIdUser.Visible = False
        '
        'labelPasswordMessage
        '
        Me.labelPasswordMessage.AutoSize = True
        Me.labelPasswordMessage.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.labelPasswordMessage.ForeColor = System.Drawing.Color.LightCoral
        Me.labelPasswordMessage.Location = New System.Drawing.Point(193, 169)
        Me.labelPasswordMessage.Name = "labelPasswordMessage"
        Me.labelPasswordMessage.Size = New System.Drawing.Size(358, 23)
        Me.labelPasswordMessage.TabIndex = 60
        Me.labelPasswordMessage.Text = "* Biarkan Kosong, Jika Tidak akan Mengubah Password"
        Me.labelPasswordMessage.Visible = False
        '
        'radioBtnUser
        '
        Me.radioBtnUser.AutoSize = True
        Me.radioBtnUser.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.radioBtnUser.ForeColor = System.Drawing.SystemColors.WindowText
        Me.radioBtnUser.Location = New System.Drawing.Point(127, 393)
        Me.radioBtnUser.Name = "radioBtnUser"
        Me.radioBtnUser.Size = New System.Drawing.Size(98, 27)
        Me.radioBtnUser.TabIndex = 59
        Me.radioBtnUser.TabStop = True
        Me.radioBtnUser.Text = "Pelanggan"
        Me.radioBtnUser.UseVisualStyleBackColor = True
        '
        'radioBtnAdmin
        '
        Me.radioBtnAdmin.AutoSize = True
        Me.radioBtnAdmin.Checked = True
        Me.radioBtnAdmin.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.radioBtnAdmin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.radioBtnAdmin.Location = New System.Drawing.Point(51, 393)
        Me.radioBtnAdmin.Name = "radioBtnAdmin"
        Me.radioBtnAdmin.Size = New System.Drawing.Size(70, 27)
        Me.radioBtnAdmin.TabIndex = 58
        Me.radioBtnAdmin.TabStop = True
        Me.radioBtnAdmin.Text = "Admin"
        Me.radioBtnAdmin.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(47, 367)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 23)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Role"
        '
        'btnRegister
        '
        Me.btnRegister.ActiveBorderThickness = 1
        Me.btnRegister.ActiveCornerRadius = 5
        Me.btnRegister.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnRegister.ActiveForecolor = System.Drawing.Color.White
        Me.btnRegister.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnRegister.BackColor = System.Drawing.Color.White
        Me.btnRegister.BackgroundImage = CType(resources.GetObject("btnRegister.BackgroundImage"), System.Drawing.Image)
        Me.btnRegister.ButtonText = "DAFTAR"
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnRegister.IdleBorderThickness = 1
        Me.btnRegister.IdleCornerRadius = 5
        Me.btnRegister.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnRegister.IdleForecolor = System.Drawing.Color.White
        Me.btnRegister.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnRegister.Location = New System.Drawing.Point(51, 428)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(5)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(500, 45)
        Me.btnRegister.TabIndex = 56
        Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(47, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 23)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Phone"
        '
        'txtPhone
        '
        Me.txtPhone.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtPhone.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtPhone.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtPhone.BorderThickness = 1
        Me.txtPhone.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtPhone.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPhone.isPassword = False
        Me.txtPhone.Location = New System.Drawing.Point(51, 328)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.MaxLength = 32767
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(500, 35)
        Me.txtPhone.TabIndex = 54
        Me.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(47, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 23)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Retype Password"
        '
        'txtRetypePwd
        '
        Me.txtRetypePwd.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtRetypePwd.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtRetypePwd.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtRetypePwd.BorderThickness = 1
        Me.txtRetypePwd.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtRetypePwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRetypePwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtRetypePwd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRetypePwd.isPassword = True
        Me.txtRetypePwd.Location = New System.Drawing.Point(51, 262)
        Me.txtRetypePwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRetypePwd.MaxLength = 32767
        Me.txtRetypePwd.Name = "txtRetypePwd"
        Me.txtRetypePwd.Size = New System.Drawing.Size(500, 35)
        Me.txtRetypePwd.TabIndex = 52
        Me.txtRetypePwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(47, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 23)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtPassword.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtPassword.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtPassword.BorderThickness = 1
        Me.txtPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassword.isPassword = True
        Me.txtPassword.Location = New System.Drawing.Point(51, 196)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(500, 35)
        Me.txtPassword.TabIndex = 50
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(47, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 23)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtUsername.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtUsername.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtUsername.BorderThickness = 1
        Me.txtUsername.characterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtUsername.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUsername.isPassword = False
        Me.txtUsername.Location = New System.Drawing.Point(51, 130)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.MaxLength = 32767
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(500, 35)
        Me.txtUsername.TabIndex = 48
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(47, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 23)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Fullname"
        '
        'txtFullname
        '
        Me.txtFullname.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtFullname.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtFullname.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtFullname.BorderThickness = 1
        Me.txtFullname.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFullname.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtFullname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFullname.isPassword = False
        Me.txtFullname.Location = New System.Drawing.Point(51, 64)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFullname.MaxLength = 32767
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(500, 35)
        Me.txtFullname.TabIndex = 46
        Me.txtFullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 511)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Pengguna"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtIdUser As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents labelPasswordMessage As System.Windows.Forms.Label
    Friend WithEvents radioBtnUser As System.Windows.Forms.RadioButton
    Friend WithEvents radioBtnAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnRegister As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRetypePwd As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFullname As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
