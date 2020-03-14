Public Class Form5

    Private Sub RadioButton8_MouseClick(sender As Object, e As MouseEventArgs) Handles RadioButton8.MouseClick
        Me.Hide()
    End Sub

    Private Sub RadioButton7_MouseClick(sender As Object, e As MouseEventArgs) Handles RadioButton7.MouseClick
        Me.Hide()
    End Sub

    Private Sub RadioButton6_MouseClick(sender As Object, e As MouseEventArgs) Handles RadioButton6.MouseClick
        Me.Hide()
    End Sub

    Private Sub RadioButton5_MouseClick(sender As Object, e As MouseEventArgs) Handles RadioButton5.MouseClick
        Me.Hide()
        Form2.score = +5
        Form2.PictureBox8.Location = New Point(75, 3)
    End Sub
End Class