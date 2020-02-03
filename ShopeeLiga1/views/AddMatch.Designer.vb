<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMatch
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddMatch))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbIdHome = New System.Windows.Forms.ComboBox()
        Me.cbIdAway = New System.Windows.Forms.ComboBox()
        Me.btnSave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.cbTimeLocation = New System.Windows.Forms.ComboBox()
        Me.dtpMatchday = New System.Windows.Forms.DateTimePicker()
        Me.txtKickoff = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVenue = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAwayTeam = New System.Windows.Forms.ComboBox()
        Me.TeamsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShopeeticketDataSet = New ShopeeLiga1.shopeeticketDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbHomeTeam = New System.Windows.Forms.ComboBox()
        Me.TeamsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtIdMatch = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TeamsTableAdapter = New ShopeeLiga1.shopeeticketDataSetTableAdapters.teamsTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.TeamsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShopeeticketDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cbIdHome)
        Me.Panel1.Controls.Add(Me.cbIdAway)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.cbTimeLocation)
        Me.Panel1.Controls.Add(Me.dtpMatchday)
        Me.Panel1.Controls.Add(Me.txtKickoff)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtVenue)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbAwayTeam)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbHomeTeam)
        Me.Panel1.Controls.Add(Me.txtIdMatch)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 461)
        Me.Panel1.TabIndex = 0
        '
        'cbIdHome
        '
        Me.cbIdHome.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIdHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbIdHome.FormattingEnabled = True
        Me.cbIdHome.Location = New System.Drawing.Point(411, 43)
        Me.cbIdHome.Name = "cbIdHome"
        Me.cbIdHome.Size = New System.Drawing.Size(67, 31)
        Me.cbIdHome.TabIndex = 84
        Me.cbIdHome.Visible = False
        '
        'cbIdAway
        '
        Me.cbIdAway.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIdAway.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbIdAway.FormattingEnabled = True
        Me.cbIdAway.Location = New System.Drawing.Point(484, 43)
        Me.cbIdAway.Name = "cbIdAway"
        Me.cbIdAway.Size = New System.Drawing.Size(67, 31)
        Me.cbIdAway.TabIndex = 83
        Me.cbIdAway.Visible = False
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
        Me.btnSave.Location = New System.Drawing.Point(51, 373)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(500, 45)
        Me.btnSave.TabIndex = 81
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbTimeLocation
        '
        Me.cbTimeLocation.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTimeLocation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbTimeLocation.FormattingEnabled = True
        Me.cbTimeLocation.Items.AddRange(New Object() {"WIB", "WIT", "WITA"})
        Me.cbTimeLocation.Location = New System.Drawing.Point(394, 329)
        Me.cbTimeLocation.Name = "cbTimeLocation"
        Me.cbTimeLocation.Size = New System.Drawing.Size(157, 34)
        Me.cbTimeLocation.TabIndex = 80
        Me.cbTimeLocation.Text = "WIB"
        '
        'dtpMatchday
        '
        Me.dtpMatchday.CalendarFont = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMatchday.CalendarForeColor = System.Drawing.SystemColors.WindowText
        Me.dtpMatchday.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.dtpMatchday.CustomFormat = ""
        Me.dtpMatchday.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMatchday.Location = New System.Drawing.Point(51, 269)
        Me.dtpMatchday.Name = "dtpMatchday"
        Me.dtpMatchday.Size = New System.Drawing.Size(500, 27)
        Me.dtpMatchday.TabIndex = 79
        '
        'txtKickoff
        '
        Me.txtKickoff.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtKickoff.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtKickoff.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtKickoff.BorderThickness = 1
        Me.txtKickoff.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtKickoff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKickoff.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtKickoff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtKickoff.isPassword = False
        Me.txtKickoff.Location = New System.Drawing.Point(51, 329)
        Me.txtKickoff.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKickoff.MaxLength = 32767
        Me.txtKickoff.Name = "txtKickoff"
        Me.txtKickoff.Size = New System.Drawing.Size(336, 35)
        Me.txtKickoff.TabIndex = 78
        Me.txtKickoff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(40, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Kick Off"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(47, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 23)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Matchday"
        '
        'txtVenue
        '
        Me.txtVenue.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtVenue.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtVenue.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtVenue.BorderThickness = 1
        Me.txtVenue.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVenue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVenue.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtVenue.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVenue.isPassword = False
        Me.txtVenue.Location = New System.Drawing.Point(51, 204)
        Me.txtVenue.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVenue.MaxLength = 32767
        Me.txtVenue.Name = "txtVenue"
        Me.txtVenue.Size = New System.Drawing.Size(500, 35)
        Me.txtVenue.TabIndex = 74
        Me.txtVenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(40, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Stadion"
        '
        'cbAwayTeam
        '
        Me.cbAwayTeam.DataSource = Me.TeamsBindingSource1
        Me.cbAwayTeam.DisplayMember = "team_name"
        Me.cbAwayTeam.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAwayTeam.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbAwayTeam.FormattingEnabled = True
        Me.cbAwayTeam.Location = New System.Drawing.Point(51, 143)
        Me.cbAwayTeam.Name = "cbAwayTeam"
        Me.cbAwayTeam.Size = New System.Drawing.Size(500, 31)
        Me.cbAwayTeam.TabIndex = 72
        Me.cbAwayTeam.ValueMember = "id_team"
        '
        'TeamsBindingSource1
        '
        Me.TeamsBindingSource1.DataMember = "teams"
        Me.TeamsBindingSource1.DataSource = Me.ShopeeticketDataSet
        '
        'ShopeeticketDataSet
        '
        Me.ShopeeticketDataSet.DataSetName = "shopeeticketDataSet"
        Me.ShopeeticketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(47, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 23)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Tim Tamu"
        '
        'cbHomeTeam
        '
        Me.cbHomeTeam.DataSource = Me.TeamsBindingSource
        Me.cbHomeTeam.DisplayMember = "team_name"
        Me.cbHomeTeam.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHomeTeam.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbHomeTeam.FormattingEnabled = True
        Me.cbHomeTeam.Location = New System.Drawing.Point(51, 80)
        Me.cbHomeTeam.Name = "cbHomeTeam"
        Me.cbHomeTeam.Size = New System.Drawing.Size(500, 31)
        Me.cbHomeTeam.TabIndex = 70
        Me.cbHomeTeam.ValueMember = "id_team"
        '
        'TeamsBindingSource
        '
        Me.TeamsBindingSource.DataMember = "teams"
        Me.TeamsBindingSource.DataSource = Me.ShopeeticketDataSet
        '
        'txtIdMatch
        '
        Me.txtIdMatch.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.txtIdMatch.BorderColorIdle = System.Drawing.Color.LightGray
        Me.txtIdMatch.BorderColorMouseHover = System.Drawing.Color.LightGray
        Me.txtIdMatch.BorderThickness = 1
        Me.txtIdMatch.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtIdMatch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdMatch.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtIdMatch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIdMatch.isPassword = False
        Me.txtIdMatch.Location = New System.Drawing.Point(247, 43)
        Me.txtIdMatch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdMatch.MaxLength = 32767
        Me.txtIdMatch.Name = "txtIdMatch"
        Me.txtIdMatch.Size = New System.Drawing.Size(157, 31)
        Me.txtIdMatch.TabIndex = 69
        Me.txtIdMatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIdMatch.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(47, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 23)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Tim Tuan Rumah"
        '
        'TeamsTableAdapter
        '
        Me.TeamsTableAdapter.ClearBeforeFill = True
        '
        'AddMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 461)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddMatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Jadwal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TeamsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShopeeticketDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbAwayTeam As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbHomeTeam As System.Windows.Forms.ComboBox
    Friend WithEvents txtIdMatch As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKickoff As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVenue As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpMatchday As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbTimeLocation As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ShopeeticketDataSet As ShopeeLiga1.shopeeticketDataSet
    Friend WithEvents TeamsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeamsTableAdapter As ShopeeLiga1.shopeeticketDataSetTableAdapters.teamsTableAdapter
    Friend WithEvents TeamsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents cbIdHome As System.Windows.Forms.ComboBox
    Friend WithEvents cbIdAway As System.Windows.Forms.ComboBox
End Class
