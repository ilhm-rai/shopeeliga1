<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tickets
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tickets))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxIdTicket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxIdMatch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxHomeTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxAwayTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxMatchday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxKickoff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxVenue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxStockTicket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxStockNormal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxStockVip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxNormalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxVipPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1096, 669)
        Me.Panel1.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 60)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1096, 609)
        Me.Panel3.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxIdTicket, Me.DataGridViewTextBoxIdMatch, Me.DataGridViewTextBoxHomeTeam, Me.DataGridViewTextBoxAwayTeam, Me.DataGridViewTextBoxMatchday, Me.DataGridViewTextBoxKickoff, Me.DataGridViewTextBoxVenue, Me.DataGridViewTextBoxStockTicket, Me.DataGridViewTextBoxStockNormal, Me.DataGridViewTextBoxStockVip, Me.DataGridViewTextBoxNormalPrice, Me.DataGridViewTextBoxVipPrice})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.Color.LightGray
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1096, 609)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxIdTicket
        '
        Me.DataGridViewTextBoxIdTicket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxIdTicket.HeaderText = "Id Ticket"
        Me.DataGridViewTextBoxIdTicket.Name = "DataGridViewTextBoxIdTicket"
        Me.DataGridViewTextBoxIdTicket.ReadOnly = True
        '
        'DataGridViewTextBoxIdMatch
        '
        Me.DataGridViewTextBoxIdMatch.HeaderText = "Id Match"
        Me.DataGridViewTextBoxIdMatch.Name = "DataGridViewTextBoxIdMatch"
        Me.DataGridViewTextBoxIdMatch.ReadOnly = True
        Me.DataGridViewTextBoxIdMatch.Visible = False
        '
        'DataGridViewTextBoxHomeTeam
        '
        Me.DataGridViewTextBoxHomeTeam.HeaderText = "Tim Tuan Rumah"
        Me.DataGridViewTextBoxHomeTeam.Name = "DataGridViewTextBoxHomeTeam"
        Me.DataGridViewTextBoxHomeTeam.ReadOnly = True
        '
        'DataGridViewTextBoxAwayTeam
        '
        Me.DataGridViewTextBoxAwayTeam.HeaderText = "Tim Tamu"
        Me.DataGridViewTextBoxAwayTeam.Name = "DataGridViewTextBoxAwayTeam"
        Me.DataGridViewTextBoxAwayTeam.ReadOnly = True
        '
        'DataGridViewTextBoxMatchday
        '
        Me.DataGridViewTextBoxMatchday.HeaderText = "Jadwal"
        Me.DataGridViewTextBoxMatchday.Name = "DataGridViewTextBoxMatchday"
        Me.DataGridViewTextBoxMatchday.ReadOnly = True
        '
        'DataGridViewTextBoxKickoff
        '
        Me.DataGridViewTextBoxKickoff.HeaderText = "Kickoff"
        Me.DataGridViewTextBoxKickoff.Name = "DataGridViewTextBoxKickoff"
        Me.DataGridViewTextBoxKickoff.ReadOnly = True
        '
        'DataGridViewTextBoxVenue
        '
        Me.DataGridViewTextBoxVenue.HeaderText = "Stadion"
        Me.DataGridViewTextBoxVenue.Name = "DataGridViewTextBoxVenue"
        Me.DataGridViewTextBoxVenue.ReadOnly = True
        '
        'DataGridViewTextBoxStockTicket
        '
        Me.DataGridViewTextBoxStockTicket.HeaderText = "Stok Tiket"
        Me.DataGridViewTextBoxStockTicket.Name = "DataGridViewTextBoxStockTicket"
        Me.DataGridViewTextBoxStockTicket.ReadOnly = True
        '
        'DataGridViewTextBoxStockNormal
        '
        Me.DataGridViewTextBoxStockNormal.HeaderText = "Stok Tiket Normal"
        Me.DataGridViewTextBoxStockNormal.Name = "DataGridViewTextBoxStockNormal"
        Me.DataGridViewTextBoxStockNormal.ReadOnly = True
        Me.DataGridViewTextBoxStockNormal.Visible = False
        '
        'DataGridViewTextBoxStockVip
        '
        Me.DataGridViewTextBoxStockVip.HeaderText = "Stok Tiket VIP"
        Me.DataGridViewTextBoxStockVip.Name = "DataGridViewTextBoxStockVip"
        Me.DataGridViewTextBoxStockVip.ReadOnly = True
        Me.DataGridViewTextBoxStockVip.Visible = False
        '
        'DataGridViewTextBoxNormalPrice
        '
        Me.DataGridViewTextBoxNormalPrice.HeaderText = "Harga Normal"
        Me.DataGridViewTextBoxNormalPrice.Name = "DataGridViewTextBoxNormalPrice"
        Me.DataGridViewTextBoxNormalPrice.ReadOnly = True
        Me.DataGridViewTextBoxNormalPrice.Visible = False
        '
        'DataGridViewTextBoxVipPrice
        '
        Me.DataGridViewTextBoxVipPrice.HeaderText = "Harga VIP"
        Me.DataGridViewTextBoxVipPrice.Name = "DataGridViewTextBoxVipPrice"
        Me.DataGridViewTextBoxVipPrice.ReadOnly = True
        Me.DataGridViewTextBoxVipPrice.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1096, 60)
        Me.Panel2.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(520, 0)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(170, 60)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Lihat Transaksi"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(390, 0)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 60)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Refresh"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(260, 0)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 60)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Hapus"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(130, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 60)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Ubah"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 60)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Beli Tiket"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Tickets"
        Me.Size = New System.Drawing.Size(1096, 669)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxIdTicket As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxIdMatch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxHomeTeam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxAwayTeam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxMatchday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxKickoff As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxVenue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxStockTicket As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxStockNormal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxStockVip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNormalPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxVipPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button

End Class
