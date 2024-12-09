Public Class ControlCenter

    Private Sub Now_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowNowButton.Click
        Me.Hide()
        Dim window As Window = New Window(1, Me)
        window.Show()
    End Sub

    Private Sub Then_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowThenButton.Click
        Me.Hide()
        Dim minutes As Integer = CInt(TextBox1.Text)
        Timer.Interval = minutes * 60000
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer.Tick
        Dim window As Window = New Window(2, Me)
        window.Show()
        Timer.Stop()
    End Sub
End Class
