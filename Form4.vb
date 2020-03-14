Public Class Form4
    Public Property username As String
    Public Property ldbscore As Integer
    Private Sub home_click(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = username
        Label2.Text = ldbscore

    End Sub
End Class