Public Class Form1

    Private Sub btnSingle_Click(sender As Object, e As MouseEventArgs) Handles btnSingle.MouseClick
        Form2.Show()
        Me.Hide()
        Form2.wins = 0
        Form2.losses = 0
        Form2.ties = 0
        Form2.score = 0

        Form2.Label9.Text = Form2.wins + Form2.score
        Form2.Label10.Text = Form2.losses

        Form2.PictureBox8.Location = New Point(75, 3)
        Form2.PictureBox9.Location = New Point(375, 3)
    End Sub

    Private Sub leaderboards_click(sender As Object, e As MouseEventArgs) Handles Panel4.MouseClick
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        Form6.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.wins = 0
        Form2.losses = 0
        Form2.ties = 0
        Form2.score = 0
    End Sub
End Class
