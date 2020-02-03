Public Class Matches

    Private Sub Matches_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMatches(DataGridView1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addNew = True
        addFormToPanel(AddMatch)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        addNew = False
        With DataGridView1
            If .RowCount > 0 Then
                addFormToPanel(AddMatch)
                row = .CurrentRow.Index
                AddMatch.cbIdHome.Text = .Item(1, row).Value
                AddMatch.cbIdAway.Text = .Item(2, row).Value
                AddMatch.cbHomeTeam.Text = .Item(3, row).Value
                AddMatch.cbHomeTeam.SelectedValue = .Item(1, row).Value
                AddMatch.cbAwayTeam.Text = .Item(4, row).Value
                AddMatch.txtVenue.Text = .Item(5, row).Value
                AddMatch.dtpMatchday.Text = .Item(6, row).Value.ToString
                AddMatch.txtKickoff.Text = .Item(8, row).Value
                AddMatch.cbTimeLocation.Text = .Item(9, row).Value
                AddMatch.txtIdMatch.Text = .Item(0, row).Value
            End If
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                DeleteData("matches", "id_match", .Item(0, row).Value)
            End If
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadMatches(DataGridView1)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAddTicket.Click
        addNew = True
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                addFormToPanel(AddTicket)
                AddTicket.txtIdMatch.Text = .Item(0, row).Value
                AddTicket.txtHomeTeam.Text = .Item(3, row).Value
                AddTicket.txtAwayTeam.Text = .Item(4, row).Value
                AddTicket.txtVenue.Text = .Item(5, row).Value
                AddTicket.txtMatchday.Text = .Item(6, row).Value.ToString
                AddTicket.txtKickoff.Text = .Item(7, row).Value
                openConnection()
                ExecuteReader("tickets", "*", "WHERE id_match=" + .Item(0, row).Value)
                If dataReader.Read Then
                    addNew = False
                    AddTicket.txtIdTicket.Text = dataReader.GetValue(0)
                    AddTicket.txtNormalPrice.Text = dataReader.GetValue(2)
                    AddTicket.txtVipPrice.Text = dataReader.GetValue(3)
                    AddTicket.txtStockNormal.Text = dataReader.GetValue(4)
                    AddTicket.txtStockVip.Text = dataReader.GetValue(5)
                End If
                closeConnection()
            End If
        End With
    End Sub
End Class
