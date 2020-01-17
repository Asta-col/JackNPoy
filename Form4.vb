Public Class Form4
    Public Property username As String
    Private Sub home_click(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = username
        Dim F2 As New Form2
        Label2.Text = F2.total
    End Sub
End Class