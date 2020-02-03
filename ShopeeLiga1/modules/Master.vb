Module Master
    Public Sub btnCloseEnter(ByVal button As Button)
        button.ForeColor = Color.White
    End Sub

    Public Sub btnCloseLeave(ByVal button As Button)
        button.ForeColor = Color.LightGray
    End Sub

    Public Sub addControlsToPanel(ByVal userControl As UserControl, ByVal panelControls As Panel)
        panelControls.Controls.Clear()
        userControl.Dock = DockStyle.Fill
        panelControls.Controls.Add(userControl)
    End Sub

    Public Sub addFormToPanel(ByVal form As Form)
        form.Show()
        form.Focus()
    End Sub

End Module
