Public Class Window

    Private controlcenter As ControlCenter

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        controlcenter.Show()
        Close()
    End Sub

    Public Sub New(ByVal windownum As Integer, ByVal callingform As ControlCenter)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Window " & windownum
        controlcenter = callingform

    End Sub
End Class