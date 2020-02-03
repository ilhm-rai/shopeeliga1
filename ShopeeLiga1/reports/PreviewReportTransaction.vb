Public Class PreviewReportTransaction

    Private Sub PreviewReportTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'siswaDataSet.siswa' table. You can move, or remove it, as needed.
        Me.ticket_transactionTableAdapter.Fill(Me.shopeeticketDataSet.ticket_transaction)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim transactionTicket As New TransactionTicket
        addControlsToPanel(transactionTicket, Dashboard.panelControls)
    End Sub
End Class
