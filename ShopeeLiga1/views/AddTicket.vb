Public Class AddTicket

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If addNew Then
            AddNewData("tickets", "id_match, normal_price, vip_price, stock_normal, stock_vip", txtIdMatch.Text + "," + txtNormalPrice.Text _
                       + "," + txtVipPrice.Text + "," + txtStockNormal.Text + "," + txtStockVip.Text)
        Else
            UpdateData("tickets", "normal_price=" + txtNormalPrice.Text + ",vip_price=" + txtVipPrice.Text + ",stock_normal=" + txtStockNormal.Text _
                       + ",stock_vip=" + txtStockVip.Text, "id_ticket", txtIdTicket.Text)
        End If
        clearForm()
    End Sub

    Private Sub clearForm()
        txtAwayTeam.Text = ""
        txtHomeTeam.Text = ""
        txtIdMatch.Text = ""
        txtIdTicket.Text = ""
        txtKickoff.Text = ""
        txtMatchday.Text = ""
        txtNormalPrice.Text = ""
        txtStockNormal.Text = ""
        txtStockVip.Text = ""
        txtVenue.Text = ""
        txtVipPrice.Text = ""
    End Sub

    Private Sub AddTicket_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dim tickets As New Tickets
        addControlsToPanel(tickets, Dashboard.panelControls)
    End Sub
End Class