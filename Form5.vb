Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False

        Panel1.Visible = False
        Panel2.Visible = False

        PictureBox2.Visible = True

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim rnd As New Random
        Dim ques As New Integer

        ques = rnd.Next(2) + 1

        If ques = 1 Then
            Label1.Visible = True
            Label4.Visible = False
            'PictureBox2.Visible = False

            Panel1.Visible = True
        ElseIf ques = 2 Then
            Label1.Visible = True
            Label4.Visible = False
            'PictureBox2.Visible = False

            Panel2.Visible = True
        End If
    End Sub

    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles RadioButton4.Click
        Me.Hide()
        Form2.score = +5
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Me.Hide()
        Form2.score = +5
    End Sub


End Class