Public Class Form3

    Private Sub nickname_click(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        Dim F4 As New Form4
        F4.username = TextBox1.Text
        Dim F2 As New Form2
        Label2.Text = F2.total
        Me.Hide()
        F4.Show()
    End Sub


End Class