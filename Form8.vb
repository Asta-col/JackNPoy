Public Class Form8
    Private Sub RadioButton4_MouseClick(sender As Object, e As MouseEventArgs) Handles RadioButton4.MouseClick
        Me.Hide()
        Form2.score = +10
        Form2.PictureBox8.Location = New Point(75, 3)
    End Sub

    Private Sub RadioButton1_MouseClick(sender As Object, e As MouseEventArgs) Handles RadioButton1.MouseClick
        Me.Hide()
    End Sub

    Private Sub RadioButton2_MouseClick(sender As Object, e As MouseEventArgs) Handles RadioButton2.MouseClick
        Me.Hide()
    End Sub
    Private Sub RadioButton3_MouseClick(sender As Object, e As MouseEventArgs) Handles RadioButton3.MouseClick
        Me.Hide()
    End Sub
End Class