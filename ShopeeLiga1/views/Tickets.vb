Public Class Tickets

    Private Sub Tickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTickets(DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addNew = True
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                addFormToPanel(AddTransactionTicket)
                AddTransactionTicket.txtIdTicket.Text = .Item(0, row).Value
                AddTransactionTicket.txtHomeTeam.Text = .Item(2, row).Value
                AddTransactionTicket.txtAwayTeam.Text = .Item(3, row).Value
                AddTransactionTicket.txtVenue.Text = .Item(4, row).Value.ToString
                AddTransactionTicket.txtMatchday.Text = .Item(5, row).Value.ToString
                AddTransactionTicket.txtKickoff.Text = .Item(6, row).Value
                AddTransactionTicket.txtStockNormal.Text = .Item(8, row).Value
                AddTransactionTicket.txtStockVip.Text = .Item(9, row).Value
                AddTransactionTicket.txtNormalPrice.Text = .Item(10, row).Value
                AddTransactionTicket.txtVipPrice.Text = .Item(11, row).Value
            End If
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                DeleteData("tickets", "id_ticket", .Item(0, row).Value)
                LoadTickets(DataGridView1)
            End If
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        addNew = False
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                addFormToPanel(AddTicket)
                AddTicket.txtIdTicket.Text = .Item(0, row).Value
                AddTicket.txtIdMatch.Text = .Item(1, row).Value
                AddTicket.txtHomeTeam.Text = .Item(2, row).Value
                AddTicket.txtAwayTeam.Text = .Item(3, row).Value
                AddTicket.txtVenue.Text = .Item(4, row).Value.ToString
                AddTicket.txtMatchday.Text = .Item(5, row).Value.ToString
                AddTicket.txtKickoff.Text = .Item(6, row).Value
                AddTicket.txtStockNormal.Text = .Item(8, row).Value
                AddTicket.txtStockVip.Text = .Item(9, row).Value
                AddTicket.txtNormalPrice.Text = .Item(10, row).Value
                AddTicket.txtVipPrice.Text = .Item(11, row).Value
            End If
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        LoadTickets(DataGridView1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim transactionTicket As New TransactionTicket
        addControlsToPanel(transactionTicket, Dashboard.panelControls)
    End Sub
End Class
