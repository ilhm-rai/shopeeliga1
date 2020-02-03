<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddTicket))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVipPrice = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNormalPrice = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStockVip = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStockNormal = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKickoff = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMatchday = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVenue = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAwayTeam = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHomeTeam = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtIdTicket = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtIdMatch = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtIdMatch)
        Me.Panel1.Controls.Add(Me.txtIdTicket)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtVipPrice)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtNormalPrice)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtStockVip)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtStockNormal)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtKickoff)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtMatchday)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtVenue)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAwayTeam)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtHomeTeam)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 521)
        Me.Panel1.TabIndex = 0
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
        Me.btnSave.Location = New System.Drawing.Point(51, 438)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(500, 45)
        Me.btnSave.TabIndex = 66
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(303, 367)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 23)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Harga Tiket VIP"
        '
        'txtVipPrice
        '
        Me.txtVipPrice.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtVipPrice.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtVipPrice.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtVipPrice.BorderThickness = 1
        Me.txtVipPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVipPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVipPrice.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtVipPrice.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVipPrice.isPassword = False
        Me.txtVipPrice.Location = New System.Drawing.Point(306, 394)
        Me.txtVipPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVipPrice.MaxLength = 32767
        Me.txtVipPrice.Name = "txtVipPrice"
        Me.txtVipPrice.Size = New System.Drawing.Size(245, 35)
        Me.txtVipPrice.TabIndex = 64
        Me.txtVipPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(47, 367)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 23)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Harga Tiket Normal"
        '
        'txtNormalPrice
        '
        Me.txtNormalPrice.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtNormalPrice.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtNormalPrice.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtNormalPrice.BorderThickness = 1
        Me.txtNormalPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtNormalPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNormalPrice.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtNormalPrice.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNormalPrice.isPassword = False
        Me.txtNormalPrice.Location = New System.Drawing.Point(51, 394)
        Me.txtNormalPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNormalPrice.MaxLength = 32767
        Me.txtNormalPrice.Name = "txtNormalPrice"
        Me.txtNormalPrice.Size = New System.Drawing.Size(245, 35)
        Me.txtNormalPrice.TabIndex = 62
        Me.txtNormalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(303, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 23)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Stok Tiket VIP"
        '
        'txtStockVip
        '
        Me.txtStockVip.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtStockVip.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtStockVip.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtStockVip.BorderThickness = 1
        Me.txtStockVip.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtStockVip.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStockVip.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtStockVip.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStockVip.isPassword = False
        Me.txtStockVip.Location = New System.Drawing.Point(306, 328)
        Me.txtStockVip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStockVip.MaxLength = 32767
        Me.txtStockVip.Name = "txtStockVip"
        Me.txtStockVip.Size = New System.Drawing.Size(245, 35)
        Me.txtStockVip.TabIndex = 60
        Me.txtStockVip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(47, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 23)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Stok Tiket Normal"
        '
        'txtStockNormal
        '
        Me.txtStockNormal.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtStockNormal.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtStockNormal.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtStockNormal.BorderThickness = 1
        Me.txtStockNormal.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtStockNormal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStockNormal.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtStockNormal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStockNormal.isPassword = False
        Me.txtStockNormal.Location = New System.Drawing.Point(51, 328)
        Me.txtStockNormal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStockNormal.MaxLength = 32767
        Me.txtStockNormal.Name = "txtStockNormal"
        Me.txtStockNormal.Size = New System.Drawing.Size(245, 35)
        Me.txtStockNormal.TabIndex = 58
        Me.txtStockNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(303, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Kick Off"
        '
        'txtKickoff
        '
        Me.txtKickoff.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtKickoff.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtKickoff.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtKickoff.BorderThickness = 1
        Me.txtKickoff.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtKickoff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKickoff.Enabled = False
        Me.txtKickoff.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtKickoff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtKickoff.isPassword = False
        Me.txtKickoff.Location = New System.Drawing.Point(307, 262)
        Me.txtKickoff.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKickoff.MaxLength = 32767
        Me.txtKickoff.Name = "txtKickoff"
        Me.txtKickoff.Size = New System.Drawing.Size(244, 35)
        Me.txtKickoff.TabIndex = 56
        Me.txtKickoff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(47, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 23)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Matchday"
        '
        'txtMatchday
        '
        Me.txtMatchday.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtMatchday.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtMatchday.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtMatchday.BorderThickness = 1
        Me.txtMatchday.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtMatchday.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMatchday.Enabled = False
        Me.txtMatchday.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtMatchday.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMatchday.isPassword = False
        Me.txtMatchday.Location = New System.Drawing.Point(51, 262)
        Me.txtMatchday.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMatchday.MaxLength = 32767
        Me.txtMatchday.Name = "txtMatchday"
        Me.txtMatchday.Size = New System.Drawing.Size(245, 35)
        Me.txtMatchday.TabIndex = 54
        Me.txtMatchday.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(47, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 23)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Stadion"
        '
        'txtVenue
        '
        Me.txtVenue.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtVenue.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtVenue.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtVenue.BorderThickness = 1
        Me.txtVenue.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVenue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVenue.Enabled = False
        Me.txtVenue.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtVenue.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVenue.isPassword = False
        Me.txtVenue.Location = New System.Drawing.Point(51, 196)
        Me.txtVenue.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVenue.MaxLength = 32767
        Me.txtVenue.Name = "txtVenue"
        Me.txtVenue.Size = New System.Drawing.Size(500, 35)
        Me.txtVenue.TabIndex = 52
        Me.txtVenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(47, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 23)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Tim Tamu"
        '
        'txtAwayTeam
        '
        Me.txtAwayTeam.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtAwayTeam.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtAwayTeam.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtAwayTeam.BorderThickness = 1
        Me.txtAwayTeam.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAwayTeam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAwayTeam.Enabled = False
        Me.txtAwayTeam.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtAwayTeam.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAwayTeam.isPassword = False
        Me.txtAwayTeam.Location = New System.Drawing.Point(51, 130)
        Me.txtAwayTeam.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAwayTeam.MaxLength = 32767
        Me.txtAwayTeam.Name = "txtAwayTeam"
        Me.txtAwayTeam.Size = New System.Drawing.Size(500, 35)
        Me.txtAwayTeam.TabIndex = 50
        Me.txtAwayTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(47, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 23)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Tim Tuan Rumah"
        '
        'txtHomeTeam
        '
        Me.txtHomeTeam.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtHomeTeam.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtHomeTeam.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtHomeTeam.BorderThickness = 1
        Me.txtHomeTeam.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtHomeTeam.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHomeTeam.Enabled = False
        Me.txtHomeTeam.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtHomeTeam.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHomeTeam.isPassword = False
        Me.txtHomeTeam.Location = New System.Drawing.Point(51, 64)
        Me.txtHomeTeam.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHomeTeam.MaxLength = 32767
        Me.txtHomeTeam.Name = "txtHomeTeam"
        Me.txtHomeTeam.Size = New System.Drawing.Size(500, 35)
        Me.txtHomeTeam.TabIndex = 48
        Me.txtHomeTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtIdTicket
        '
        Me.txtIdTicket.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtIdTicket.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtIdTicket.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtIdTicket.BorderThickness = 1
        Me.txtIdTicket.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdTicket.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdTicket.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtIdTicket.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIdTicket.isPassword = False
        Me.txtIdTicket.Location = New System.Drawing.Point(431, 21)
        Me.txtIdTicket.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdTicket.MaxLength = 32767
        Me.txtIdTicket.Name = "txtIdTicket"
        Me.txtIdTicket.Size = New System.Drawing.Size(120, 35)
        Me.txtIdTicket.TabIndex = 67
        Me.txtIdTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIdTicket.Visible = False
        '
        'txtIdMatch
        '
        Me.txtIdMatch.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtIdMatch.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtIdMatch.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtIdMatch.BorderThickness = 1
        Me.txtIdMatch.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdMatch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdMatch.Font = New System.Drawing.Font("Poppins", 9.75!)
        Me.txtIdMatch.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtIdMatch.isPassword = False
        Me.txtIdMatch.Location = New System.Drawing.Point(303, 21)
        Me.txtIdMatch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdMatch.MaxLength = 32767
        Me.txtIdMatch.Name = "txtIdMatch"
        Me.txtIdMatch.Size = New System.Drawing.Size(120, 35)
        Me.txtIdMatch.TabIndex = 68
        Me.txtIdMatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIdMatch.Visible = False
        '
        'AddTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 521)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Tiket"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtVipPrice As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNormalPrice As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtStockVip As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStockNormal As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKickoff As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMatchday As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVenue As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAwayTeam As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHomeTeam As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtIdTicket As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtIdMatch As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
