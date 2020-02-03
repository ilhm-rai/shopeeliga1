<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matches
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Matches))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridTextBoxIdMatch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridTextBoxIdHomeTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridTextBoxIdAwayTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridTextBoxHomeTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridTextBoxAwayTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridTextBoxVenue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridTextBoxMatchday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxKickOff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridTextBoxKickoff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridTextBoxTimeLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_ticket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddTicket = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeight = 35
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridTextBoxIdMatch, Me.DataGridTextBoxIdHomeTeam, Me.DataGridTextBoxIdAwayTeam, Me.DataGridTextBoxHomeTeam, Me.DataGridTextBoxAwayTeam, Me.DataGridTextBoxVenue, Me.DataGridTextBoxMatchday, Me.DataGridViewTextBoxKickOff, Me.DataGridTextBoxKickoff, Me.DataGridTextBoxTimeLocation, Me.stock_ticket})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
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
        'DataGridTextBoxIdMatch
        '
        Me.DataGridTextBoxIdMatch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridTextBoxIdMatch.DataPropertyName = "id_match"
        Me.DataGridTextBoxIdMatch.HeaderText = "Id Match"
        Me.DataGridTextBoxIdMatch.Name = "DataGridTextBoxIdMatch"
        Me.DataGridTextBoxIdMatch.ReadOnly = True
        '
        'DataGridTextBoxIdHomeTeam
        '
        Me.DataGridTextBoxIdHomeTeam.DataPropertyName = "id_home_team"
        Me.DataGridTextBoxIdHomeTeam.HeaderText = "Id Home Team"
        Me.DataGridTextBoxIdHomeTeam.Name = "DataGridTextBoxIdHomeTeam"
        Me.DataGridTextBoxIdHomeTeam.ReadOnly = True
        Me.DataGridTextBoxIdHomeTeam.Visible = False
        '
        'DataGridTextBoxIdAwayTeam
        '
        Me.DataGridTextBoxIdAwayTeam.DataPropertyName = "id_away_team"
        Me.DataGridTextBoxIdAwayTeam.HeaderText = "Id Away Team"
        Me.DataGridTextBoxIdAwayTeam.Name = "DataGridTextBoxIdAwayTeam"
        Me.DataGridTextBoxIdAwayTeam.ReadOnly = True
        Me.DataGridTextBoxIdAwayTeam.Visible = False
        '
        'DataGridTextBoxHomeTeam
        '
        Me.DataGridTextBoxHomeTeam.DataPropertyName = "home_team"
        Me.DataGridTextBoxHomeTeam.HeaderText = "Tim Tuan Rumah"
        Me.DataGridTextBoxHomeTeam.Name = "DataGridTextBoxHomeTeam"
        Me.DataGridTextBoxHomeTeam.ReadOnly = True
        '
        'DataGridTextBoxAwayTeam
        '
        Me.DataGridTextBoxAwayTeam.DataPropertyName = "away_team"
        Me.DataGridTextBoxAwayTeam.HeaderText = "Tim Tamu"
        Me.DataGridTextBoxAwayTeam.Name = "DataGridTextBoxAwayTeam"
        Me.DataGridTextBoxAwayTeam.ReadOnly = True
        '
        'DataGridTextBoxVenue
        '
        Me.DataGridTextBoxVenue.DataPropertyName = "venue"
        Me.DataGridTextBoxVenue.HeaderText = "Stadion"
        Me.DataGridTextBoxVenue.Name = "DataGridTextBoxVenue"
        Me.DataGridTextBoxVenue.ReadOnly = True
        '
        'DataGridTextBoxMatchday
        '
        Me.DataGridTextBoxMatchday.DataPropertyName = "matchday"
        Me.DataGridTextBoxMatchday.HeaderText = "Jadwal"
        Me.DataGridTextBoxMatchday.Name = "DataGridTextBoxMatchday"
        Me.DataGridTextBoxMatchday.ReadOnly = True
        '
        'DataGridViewTextBoxKickOff
        '
        Me.DataGridViewTextBoxKickOff.HeaderText = "Kick Off"
        Me.DataGridViewTextBoxKickOff.Name = "DataGridViewTextBoxKickOff"
        Me.DataGridViewTextBoxKickOff.ReadOnly = True
        '
        'DataGridTextBoxKickoff
        '
        Me.DataGridTextBoxKickoff.DataPropertyName = "kickoff"
        Me.DataGridTextBoxKickoff.HeaderText = "Kick Off"
        Me.DataGridTextBoxKickoff.Name = "DataGridTextBoxKickoff"
        Me.DataGridTextBoxKickoff.ReadOnly = True
        Me.DataGridTextBoxKickoff.Visible = False
        '
        'DataGridTextBoxTimeLocation
        '
        Me.DataGridTextBoxTimeLocation.DataPropertyName = "time_location"
        Me.DataGridTextBoxTimeLocation.HeaderText = "Waktu Lokasi"
        Me.DataGridTextBoxTimeLocation.Name = "DataGridTextBoxTimeLocation"
        Me.DataGridTextBoxTimeLocation.ReadOnly = True
        Me.DataGridTextBoxTimeLocation.Visible = False
        '
        'stock_ticket
        '
        Me.stock_ticket.DataPropertyName = "stock_ticket"
        Me.stock_ticket.HeaderText = "Stok Ticket"
        Me.stock_ticket.Name = "stock_ticket"
        Me.stock_ticket.ReadOnly = True
        Me.stock_ticket.Visible = False
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
        Me.Panel1.TabIndex = 2
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnAddTicket)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1096, 60)
        Me.Panel2.TabIndex = 0
        '
        'btnAddTicket
        '
        Me.btnAddTicket.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddTicket.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddTicket.FlatAppearance.BorderSize = 0
        Me.btnAddTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTicket.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTicket.ForeColor = System.Drawing.Color.White
        Me.btnAddTicket.Image = CType(resources.GetObject("btnAddTicket.Image"), System.Drawing.Image)
        Me.btnAddTicket.Location = New System.Drawing.Point(520, 0)
        Me.btnAddTicket.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnAddTicket.Name = "btnAddTicket"
        Me.btnAddTicket.Size = New System.Drawing.Size(165, 60)
        Me.btnAddTicket.TabIndex = 9
        Me.btnAddTicket.Text = "Tambah Tiket"
        Me.btnAddTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddTicket.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Location = New System.Drawing.Point(390, 0)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(130, 60)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(260, 0)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 60)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(130, 0)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(130, 60)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Ubah"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Poppins", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(0, 0)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(130, 60)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Tambah"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Matches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Matches"
        Me.Size = New System.Drawing.Size(1096, 669)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxIdMatch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridTextBoxIdHomeTeam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridTextBoxIdAwayTeam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridTextBoxHomeTeam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridTextBoxAwayTeam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridTextBoxVenue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridTextBoxMatchday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxKickOff As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridTextBoxKickoff As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridTextBoxTimeLocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock_ticket As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnAddTicket As System.Windows.Forms.Button

End Class
