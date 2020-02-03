<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTeam
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddTeam))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtWebsite = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLocation = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVenue = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtSince = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCoach = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtManager = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPresident = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtIdTeam = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnSave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTeam = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtWebsite)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtLocation)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtVenue)
        Me.Panel1.Controls.Add(Me.txtSince)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtCoach)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtManager)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtPresident)
        Me.Panel1.Controls.Add(Me.txtIdTeam)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtTeam)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 641)
        Me.Panel1.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(47, 492)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 23)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Website"
        '
        'txtWebsite
        '
        Me.txtWebsite.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtWebsite.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtWebsite.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtWebsite.BorderThickness = 1
        Me.txtWebsite.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtWebsite.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWebsite.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtWebsite.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWebsite.isPassword = False
        Me.txtWebsite.Location = New System.Drawing.Point(51, 519)
        Me.txtWebsite.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWebsite.MaxLength = 32767
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(500, 35)
        Me.txtWebsite.TabIndex = 76
        Me.txtWebsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(47, 426)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 23)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Lokasi"
        '
        'txtLocation
        '
        Me.txtLocation.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtLocation.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtLocation.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtLocation.BorderThickness = 1
        Me.txtLocation.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLocation.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtLocation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLocation.isPassword = False
        Me.txtLocation.Location = New System.Drawing.Point(51, 453)
        Me.txtLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLocation.MaxLength = 32767
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(500, 35)
        Me.txtLocation.TabIndex = 74
        Me.txtLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(47, 360)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 23)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Stadion"
        '
        'txtVenue
        '
        Me.txtVenue.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtVenue.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtVenue.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtVenue.BorderThickness = 1
        Me.txtVenue.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVenue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVenue.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtVenue.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVenue.isPassword = False
        Me.txtVenue.Location = New System.Drawing.Point(51, 387)
        Me.txtVenue.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVenue.MaxLength = 32767
        Me.txtVenue.Name = "txtVenue"
        Me.txtVenue.Size = New System.Drawing.Size(500, 35)
        Me.txtVenue.TabIndex = 72
        Me.txtVenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtSince
        '
        Me.txtSince.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtSince.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtSince.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtSince.BorderThickness = 1
        Me.txtSince.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSince.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSince.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtSince.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSince.isPassword = False
        Me.txtSince.Location = New System.Drawing.Point(51, 125)
        Me.txtSince.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSince.MaxLength = 32767
        Me.txtSince.Name = "txtSince"
        Me.txtSince.Size = New System.Drawing.Size(500, 35)
        Me.txtSince.TabIndex = 71
        Me.txtSince.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(47, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 23)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Pelatih"
        '
        'txtCoach
        '
        Me.txtCoach.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtCoach.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtCoach.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtCoach.BorderThickness = 1
        Me.txtCoach.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtCoach.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCoach.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtCoach.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCoach.isPassword = False
        Me.txtCoach.Location = New System.Drawing.Point(51, 321)
        Me.txtCoach.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCoach.MaxLength = 32767
        Me.txtCoach.Name = "txtCoach"
        Me.txtCoach.Size = New System.Drawing.Size(500, 35)
        Me.txtCoach.TabIndex = 69
        Me.txtCoach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(47, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 23)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Manajer"
        '
        'txtManager
        '
        Me.txtManager.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtManager.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtManager.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtManager.BorderThickness = 1
        Me.txtManager.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtManager.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtManager.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtManager.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtManager.isPassword = False
        Me.txtManager.Location = New System.Drawing.Point(51, 255)
        Me.txtManager.Margin = New System.Windows.Forms.Padding(4)
        Me.txtManager.MaxLength = 32767
        Me.txtManager.Name = "txtManager"
        Me.txtManager.Size = New System.Drawing.Size(500, 35)
        Me.txtManager.TabIndex = 66
        Me.txtManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(47, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 23)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Tahun Berdiri"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(47, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 23)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Presiden"
        '
        'txtPresident
        '
        Me.txtPresident.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtPresident.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtPresident.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtPresident.BorderThickness = 1
        Me.txtPresident.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPresident.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPresident.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtPresident.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPresident.isPassword = False
        Me.txtPresident.Location = New System.Drawing.Point(51, 189)
        Me.txtPresident.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPresident.MaxLength = 32767
        Me.txtPresident.Name = "txtPresident"
        Me.txtPresident.Size = New System.Drawing.Size(500, 35)
        Me.txtPresident.TabIndex = 62
        Me.txtPresident.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtIdTeam
        '
        Me.txtIdTeam.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtIdTeam.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtIdTeam.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtIdTeam.BorderThickness = 1
        Me.txtIdTeam.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdTeam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdTeam.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtIdTeam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIdTeam.isPassword = False
        Me.txtIdTeam.Location = New System.Drawing.Point(414, 20)
        Me.txtIdTeam.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdTeam.MaxLength = 32767
        Me.txtIdTeam.Name = "txtIdTeam"
        Me.txtIdTeam.Size = New System.Drawing.Size(137, 35)
        Me.txtIdTeam.TabIndex = 61
        Me.txtIdTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIdTeam.Visible = False
        '
        'btnSave
        '
        Me.btnSave.ActiveBorderThickness = 1
        Me.btnSave.ActiveCornerRadius = 5
        Me.btnSave.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSave.ActiveForecolor = System.Drawing.Color.White
        Me.btnSave.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.ButtonText = "SIMPAN"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSave.IdleBorderThickness = 1
        Me.btnSave.IdleCornerRadius = 5
        Me.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSave.IdleForecolor = System.Drawing.Color.White
        Me.btnSave.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(51, 563)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(500, 45)
        Me.btnSave.TabIndex = 56
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(47, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 23)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Nama Tim"
        '
        'txtTeam
        '
        Me.txtTeam.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtTeam.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtTeam.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtTeam.BorderThickness = 1
        Me.txtTeam.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTeam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTeam.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtTeam.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTeam.isPassword = False
        Me.txtTeam.Location = New System.Drawing.Point(51, 59)
        Me.txtTeam.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTeam.MaxLength = 32767
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Size = New System.Drawing.Size(500, 35)
        Me.txtTeam.TabIndex = 46
        Me.txtTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AddTeam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 641)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddTeam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Tim"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtIdTeam As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTeam As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPresident As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtManager As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCoach As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtSince As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtWebsite As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLocation As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtVenue As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
