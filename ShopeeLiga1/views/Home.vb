Public Class Home

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        closeConnection()
        openConnection()
        ExecuteReader("teams", "COUNT(id_team)")
        If dataReader.Read Then
            labelTeam.Text = dataReader.GetValue(0)
        End If
        closeConnection()
        openConnection()
        ExecuteReader("ticket_transaction", "qty_normal, qty_vip")
        Dim totalTransaction As Integer
        While dataReader.Read
            totalTransaction += dataReader.GetUInt32(0) + dataReader.GetUInt32(1)
        End While
        labelTicket.Text = totalTransaction
        closeConnection()
        openConnection()
        ExecuteReader("matches", "COUNT(id_match)")
        If dataReader.Read Then
            labelMatch.Text = dataReader.GetValue(0)
        End If
        closeConnection()
    End Sub
End Class
