Public Class AddUser
    Public Sub clearForm()
        txtFullname.Text = ""
        txtPassword.Text = ""
        txtPhone.Text = ""
        txtRetypePwd.Text = ""
        txtUsername.Text = ""
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If radioBtnAdmin.Checked Then
            role = 1
        Else
            role = 2
        End If
        If addNew Then
            AddNewData("users", "fullname, username, password, phone, role", "'" + txtFullname.Text + "', '" + txtUsername.Text + "', SHA1('" + txtPassword.Text + "'), '" _
                        + txtPhone.Text + "', '" + role.ToString + "'")
            clearForm()
        Else
            If Not oldData.Equals(txtUsername.Text) Then
                If txtPassword.Text.Equals("") Then
                    UpdateData("users", "fullname='" + txtFullname.Text + "', username='" + txtUsername.Text + "', phone='" + txtPhone.Text _
                                + "', role='" + role.ToString + "'", "id_user", txtIdUser.Text)
                Else
                    UpdateData("users", "fullname='" + txtFullname.Text + "', username='" + txtUsername.Text + "', phone='" + txtPhone.Text + "', password=SHA1('" _
                                + txtPassword.Text + "'), role='" + role.ToString + "'", "id_user", txtIdUser.Text)
                End If
            Else
                If txtPassword.Text.Equals("") Then
                    UpdateData("users", "fullname='" + txtFullname.Text + "', phone='" + txtPhone.Text + "', role='" + role.ToString + "'", "id_user", txtIdUser.Text)
                Else
                    UpdateData("users", "fullname='" + txtFullname.Text + "', phone='" + txtPhone.Text + "', password=SHA1('" _
                                + txtPassword.Text + "'), role='" + role.ToString + "'", "id_user", txtIdUser.Text)
                End If
            End If
            clearForm()
        End If
    End Sub

    Private Sub AddUser_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dim users As New Users
        addControlsToPanel(users, Dashboard.panelControls)
    End Sub

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not addNew Then
            labelPasswordMessage.Visible = True
        End If
    End Sub

    Private Sub txtRetypePwd_KeyUp(sender As Object, e As KeyEventArgs) Handles txtRetypePwd.KeyUp
        If Not txtRetypePwd.Text.Equals(txtPassword.Text) Then
            txtRetypePwd.BorderColorFocused = Color.LightCoral
            txtRetypePwd.BorderColorIdle = Color.LightCoral
        Else
            txtRetypePwd.BorderColorFocused = Color.DodgerBlue
            txtRetypePwd.BorderColorIdle = Color.LightGray
        End If
    End Sub
End Class