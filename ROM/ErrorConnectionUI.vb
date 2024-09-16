Public Class ErrorConnectionUI
    Public ErrorInfo As String
    Private Sub ErrorConnectionUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorDisplay.Text = ErrorInfo
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DBConn.Connect(1)
    End Sub
End Class