Public Class Teams

    Private Sub Teams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData("teams", DataGridView1, , "ORDER BY id_team ASC")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addNew = True
        addFormToPanel(AddTeam)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData("teams", DataGridView1, , "ORDER BY id_team ASC")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        addNew = False
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                AddTeam.txtIdTeam.Text = .Item("id_team", row).Value
                AddTeam.txtLocation.Text = .Item("location", row).Value
                AddTeam.txtCoach.Text = .Item("coach", row).Value
                AddTeam.txtManager.Text = .Item("manager", row).Value
                AddTeam.txtPresident.Text = .Item("president", row).Value
                AddTeam.txtSince.Text = .Item("since", row).Value
                AddTeam.txtTeam.Text = .Item("team_name", row).Value
                AddTeam.txtVenue.Text = .Item("venue", row).Value
                AddTeam.txtWebsite.Text = .Item("website", row).Value
            End If
        End With
        addFormToPanel(AddTeam)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With DataGridView1
            If .RowCount > 0 Then
                row = .CurrentRow.Index
                DeleteData("teams", "id_team", .Item("id_team", row).Value)
            End If
        End With
    End Sub
End Class
