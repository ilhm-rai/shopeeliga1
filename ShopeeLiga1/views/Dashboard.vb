Public Class Dashboard

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Dim users As New Users
        addControlsToPanel(users, panelControls)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Login.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnTeams.Click
        Dim teams As New Teams
        addControlsToPanel(teams, panelControls)
    End Sub

    Private Sub btnMatches_Click(sender As Object, e As EventArgs) Handles btnMatches.Click
        Dim matches As New Matches
        addControlsToPanel(matches, panelControls)
    End Sub

    Private Sub btnTickets_Click(sender As Object, e As EventArgs) Handles btnTickets.Click
        Dim tickets As New Tickets
        addControlsToPanel(tickets, panelControls)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim home As New Home
        addControlsToPanel(home, panelControls)
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim home As New Home
        addControlsToPanel(home, panelControls)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim logoutConfirmation As Integer
        logoutConfirmation = MessageBox.Show("Apa anda yakin?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If logoutConfirmation = 6 Then
            Me.Dispose()
            Login.Show()
        End If
    End Sub
End Class