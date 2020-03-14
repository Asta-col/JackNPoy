Public Class Form3
    Public Property status As String
    Private Sub nickname_click(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        Dim F4 As New Form4
        F4.username = TextBox1.Text
        F4.ldbscore = Form2.score + Form2.wins
        'Dim F2 As New Form2
        Label2.Text = Form2.score
        Me.Hide()
        F4.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Form2.score + Form2.wins

        If Form2.losses > Form2.wins Then
            Label1.Text = "You Lose!"
        Else
            Label1.Text = "You Win!"
        End If


    End Sub
End Class