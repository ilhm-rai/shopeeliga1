Public Class AddTeam

    Private Sub AddTeam_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dim teams As New Teams
        addControlsToPanel(teams, Dashboard.panelControls)
    End Sub

    Private Sub AddTeam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If addNew Then
            txtSince.Text = Now.Year
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Integer.Parse(txtSince.Text) > Now.Year Then
            MessageBox.Show("Masukan tahun berdiri tim dengan benar!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSince.Text = Now.Year
        Else
            If addNew Then
                AddNewData("teams", "team_name, since, president, manager, coach, venue, location, website", "'" + txtTeam.Text + "','" + txtSince.Text _
                           + "','" + txtPresident.Text + "','" + txtManager.Text + "','" + txtCoach.Text + "','" + txtVenue.Text + "','" _
                           + txtLocation.Text + "','" + txtWebsite.Text + "'")
            Else
                UpdateData("teams", "team_name='" + txtTeam.Text + "', since='" + txtSince.Text + "', president='" + txtPresident.Text + "', manager='" + txtManager.Text _
                           + "', coach='" + txtCoach.Text + "', venue='" + txtVenue.Text + "', location='" + txtLocation.Text + "', website='" + txtWebsite.Text _
                           + "'", "id_team", txtIdTeam.Text)
            End If
            clearForm()
        End If
    End Sub

    Private Sub clearForm()
        txtCoach.Text = ""
        txtIdTeam.Text = ""
        txtLocation.Text = ""
        txtManager.Text = ""
        txtPresident.Text = ""
        txtSince.Text = ""
        txtTeam.Text = ""
        txtVenue.Text = ""
        txtWebsite.Text = ""
    End Sub
End Class