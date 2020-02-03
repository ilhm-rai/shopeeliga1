Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        openConnection()
        ExecuteReader("users", "id_user, fullname,role", "WHERE username='" + txtUsername.Text + "' AND password=SHA1('" + txtPassword.Text + "')")
        If dataReader.Read Then
            id_user = dataReader.GetValue(0)
            Dashboard.labelFullname.Text = dataReader.GetValue(1).ToString.ToUpper
            role = dataReader.GetValue(2)
            Dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau password anda salah!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If
        closeConnection()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnCloseLeave(btnClose)
    End Sub

    Private Sub btnClose_MouseEnter(sender As Object, e As EventArgs) Handles btnClose.MouseEnter
        btnCloseEnter(btnClose)
    End Sub
End Class
