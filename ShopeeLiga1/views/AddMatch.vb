Public Class AddMatch

    Private Sub AddMatch_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dim matches As New Matches
        addControlsToPanel(matches, Dashboard.panelControls)
    End Sub

    Private Sub AddMatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShopeeticketDataSet.teams' table. You can move, or remove it, as needed.
        Me.TeamsTableAdapter.Fill(Me.ShopeeticketDataSet.teams)
        If addNew Then
            cbHomeTeam.Text = "- Pilih Tim -"
            cbAwayTeam.Text = "- Pilih Tim -"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        dtpMatchday.Format = DateTimePickerFormat.Custom
        dtpMatchday.CustomFormat = "yyyy-MM-dd"
        If addNew Then
            AddNewData("matches", "id_home_team, id_away_team, home_team, away_team, venue, matchday, kickoff, time_location", "'" + cbIdHome.Text _
                       + "','" + cbIdAway.Text + "','" + cbHomeTeam.Text + "','" + cbAwayTeam.Text + "','" + txtVenue.Text + "','" + dtpMatchday.Text _
                       + "','" + txtKickoff.Text + "','" + cbTimeLocation.Text + "'")
        Else
            UpdateData("matches", "id_home_team='" + cbIdHome.Text + "',id_away_team='" + cbIdAway.Text + "',home_team='" + cbHomeTeam.Text + "',away_team='" _
                       + cbAwayTeam.Text + "',venue='" + txtVenue.Text + "',matchday='" + dtpMatchday.Text + "', kickoff='" + txtKickoff.Text _
                       + "', time_location='" + cbTimeLocation.Text + "'", "id_match", txtIdMatch.Text)
        End If
        dtpMatchday.Format = DateTimePickerFormat.Long
    End Sub

    Private Sub cbHomeTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHomeTeam.SelectedIndexChanged
        cbIdHome.Text = cbHomeTeam.SelectedValue
        If Not cbIdAway.Text.Equals("") Or Not cbIdHome.Text.Equals("") Then
            If cbIdHome.Text.Equals(cbIdAway.Text) Then
                MessageBox.Show("Pilih tim yang berbeda!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub cbAwayTeam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAwayTeam.SelectedIndexChanged
        cbIdAway.Text = cbAwayTeam.SelectedValue
        If Not cbIdAway.Text.Equals("") Or Not cbIdHome.Text.Equals("") Then
            If cbIdHome.Text.Equals(cbIdAway.Text) Then
                MessageBox.Show("Pilih tim yang berbeda!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub clearForm()
        txtIdMatch.Text = ""
        txtKickoff.Text = ""
        txtVenue.Text = ""
        cbAwayTeam.Text = "- Pilih Tim -"
        cbHomeTeam.Text = "- Pilih Tim -"
        cbIdAway.Text = ""
        cbIdHome.Text = ""
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        clearForm()
    End Sub

    Private Sub cbIdHome_TextChanged(sender As Object, e As EventArgs) Handles cbIdHome.TextChanged
        If Not cbIdHome.Text.Equals("") Then
            openConnection()
            ExecuteReader("teams", "venue", "WHERE id_team='" + cbIdHome.Text + "'")
            dataReader.Read()
            txtVenue.Text = dataReader.GetValue(0)
            closeConnection()
        End If
    End Sub
End Class