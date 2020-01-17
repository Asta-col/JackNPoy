Public Class Form1

    Private Sub btnSingle_Click(sender As Object, e As MouseEventArgs) Handles btnSingle.MouseClick
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub leaderboards_click(sender As Object, e As MouseEventArgs) Handles Panel4.MouseClick
        Form4.Show()
        Me.Hide()
    End Sub



    'Private Sub btnSingle_Hover(sender As Object, e As EventArgs) Handles btnSingle.MouseHover
    '    btnSingle.BackgroundImage = Image.FromFile _
    '    (System.Environment.GetFolderPath _
    '    (System.Environment.SpecialFolder.Personal) _
    '    & "\btnMulti.png")
    'End Sub
End Class
