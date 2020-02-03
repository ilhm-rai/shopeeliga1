Public Class AddTransactionTicket

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        dtpTransaction.Format = DateTimePickerFormat.Custom
        dtpTransaction.CustomFormat = "yyyy-MM-dd"
        If addNew Then
            AddNewData("ticket_transaction", "id_transaction,id_ticket,id_user,qty_normal,qty_vip,bill,payment,transaction_date", "'" & txtIdTransaction.Text & "'," _
                       & txtIdTicket.Text & "," & id_user & "," & nudNormal.Value & "," & nudVip.Value & "," & txtBill.Text & "," & txtPayment.Text _
                       & ",'" & dtpTransaction.Text & "'")
        Else
            UpdateData("ticket_transaction", "qty_normal=" & nudNormal.Value & ",qty_vip=" & nudVip.Value & ",bill=" & txtBill.Text & ",payment=" & txtPayment.Text _
                       & ",transaction_date='" & dtpTransaction.Text & "'", "id_transaction", "'" + txtIdTransaction.Text & "'")
        End If
        clearForm()
        dtpTransaction.Format = DateTimePickerFormat.Short
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles cbVip.CheckedChanged
        If cbVip.Checked Then
            nudVip.Enabled = True
        Else
            nudVip.Enabled = False
            nudVip.Value = 0
        End If
    End Sub

    Private Sub cbNormal_CheckedChanged(sender As Object, e As EventArgs) Handles cbNormal.CheckedChanged
        If cbNormal.Checked Then
            nudNormal.Enabled = True
        Else
            nudNormal.Enabled = False
            nudNormal.Value = 0
        End If
    End Sub

    Private Sub nudVip_ValueChanged(sender As Object, e As EventArgs) Handles nudVip.ValueChanged
        calculate()
    End Sub

    Public Sub calculate()
        If Not txtPayment.Text.Equals("") Then
            Dim bill As Integer = (nudVip.Value * Int32.Parse(txtVipPrice.Text)) + (nudNormal.Value * Int32.Parse(txtNormalPrice.Text))
            Dim refund As Integer = Int32.Parse(txtPayment.Text) - bill
            txtBill.Text = bill
            txtRefund.Text = refund
        End If
    End Sub

    Private Sub txtPayment_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPayment.KeyUp
        If txtPayment.Text.Equals("") Then
            txtPayment.Text = 0
        Else
            If txtPayment.Text.First.ToString.Equals("0") Then
                txtPayment.Text = txtPayment.Text.Remove(0, 1)
            End If
        End If
        calculate()
    End Sub

    Private Sub AddTransactionTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateId("ticket_transaction", "id_transaction", txtIdTransaction, "TRA-")
    End Sub

    Private Sub clearForm()
        If Not addNew Then
            txtAwayTeam.Text = ""
            txtBill.Text = ""
            txtHomeTeam.Text = ""
            txtIdTicket.Text = ""
            txtIdTransaction.Text = ""
            txtKickoff.Text = ""
            txtMatchday.Text = ""
            txtNormalPrice.Text = ""
            txtPayment.Text = ""
            txtRefund.Text = ""
            txtStockNormal.Text = ""
            txtStockVip.Text = ""
            txtVenue.Text = ""
            txtVipPrice.Text = ""
        End If
        nudNormal.Value = 0
        nudVip.Value = 0
        cbNormal.Checked = False
        cbVip.Checked = False
    End Sub

    Private Sub nudNormal_ValueChanged(sender As Object, e As EventArgs) Handles nudNormal.ValueChanged
        calculate()
    End Sub

End Class