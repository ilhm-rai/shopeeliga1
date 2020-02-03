Public Class TransactionTicket

    Private Sub TransactionTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransaction()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tickets As New Tickets
        addControlsToPanel(tickets, Dashboard.panelControls)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        addNew = False
        Dim id_match As Integer
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                addFormToPanel(AddTransactionTicket)
                AddTransactionTicket.txtIdTransaction.Text = .Item(0, row).Value
                AddTransactionTicket.txtIdTicket.Text = .Item(1, row).Value
                AddTransactionTicket.dtpTransaction.Text = .Item(8, row).Value.ToString
                AddTransactionTicket.nudNormal.Value = .Item(9, row).Value
                If .Item(9, row).Value > 0 Then
                    AddTransactionTicket.cbNormal.Checked = True
                End If
                AddTransactionTicket.nudVip.Value = .Item(10, row).Value
                If .Item(10, row).Value > 0 Then
                    AddTransactionTicket.cbVip.Checked = True
                End If
                openConnection()
                ExecuteReader("tickets", "*", "WHERE id_ticket=" + .Item(1, row).Value.ToString)
                If dataReader.Read Then
                    AddTransactionTicket.txtNormalPrice.Text = dataReader.GetValue(2)
                    AddTransactionTicket.txtVipPrice.Text = dataReader.GetValue(3)
                    AddTransactionTicket.txtStockNormal.Text = dataReader.GetValue(4)
                    AddTransactionTicket.txtStockVip.Text = dataReader.GetValue(5)
                    id_match = dataReader.GetValue(1)
                End If
                closeConnection()
                openConnection()
                ExecuteReader("matches", "*", "WHERE id_match=" + id_match.ToString)
                If dataReader.Read Then
                    AddTransactionTicket.txtHomeTeam.Text = dataReader.GetValue(3)
                    AddTransactionTicket.txtAwayTeam.Text = dataReader.GetValue(4)
                    AddTransactionTicket.txtVenue.Text = dataReader.GetValue(5)
                    AddTransactionTicket.txtMatchday.Text = dataReader.GetValue(6)
                    AddTransactionTicket.txtKickoff.Text = dataReader.GetValue(7) & " " & dataReader.GetValue(8)
                End If
                closeConnection()
                AddTransactionTicket.txtBill.Text = .Item(5, row).Value
                AddTransactionTicket.txtPayment.Text = .Item(6, row).Value
                AddTransactionTicket.txtRefund.Text = .Item(7, row).Value
            End If
        End With
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadTransaction()
    End Sub

    Private Sub LoadTransaction()
        If role = 1 Then
            LoadData("view_transaction", DataGridView1)
        Else
            LoadData("view_transaction", DataGridView1, "WHERE id_user=" + id_user)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                DeleteData("ticket_transaction", "id_transaction", "'" & .Item(0, row).Value & "'")
                LoadTransaction()
            End If
        End With
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim transactionReport As New PreviewReportTransaction
        addControlsToPanel(transactionReport, Dashboard.panelControls)
    End Sub
End Class
