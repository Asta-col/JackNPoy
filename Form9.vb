Public Class Form9

    Public Property wins As Integer = 0
    Public Property score As Integer = 0
    Public Property losses As Integer = 0
    Public Property ties As Integer = 0



    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False

        PictureBox10.Visible = True
        PictureBox11.Visible = True
        PictureBox13.Visible = False
        PictureBox14.Visible = False
        PictureBox15.Visible = False

        wins = 0
        losses = 0
        ties = 0
        score = 0

    End Sub

    Private Sub rock_click(sender As Object, e As MouseEventArgs) Handles Panel8.MouseClick
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = True
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False


        Dim rnd As New Random
        Dim comp As Integer

        Dim F3 As New Form3

        comp = rnd.Next(3) + 1

        If wins < 8 And losses < 8 Then
            '1 = rock; rock vs rock
            If comp = 1 Then
                PictureBox1.Visible = True
                ties = ties + 1

                '2 = paper; paper vs rock
            ElseIf comp = 2 Then
                PictureBox2.Visible = True
                PictureBox8.Left += 15
                losses = losses + 1

                '3 = scissor; scissor vs rock
            ElseIf comp = 3 Then
                PictureBox13.Visible = True
                PictureBox3.Visible = True
                PictureBox9.Left -= 15
                wins = wins + 1
            End If
        ElseIf losses = 8 Then
            Form3.Show()
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox10.Visible = True
            PictureBox11.Visible = True
        Else
            Form3.Show()
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox10.Visible = True
            PictureBox11.Visible = True
        End If

        Label9.Text = wins + score
        Label10.Text = losses
    End Sub

    Private Sub paper_click(sender As Object, e As MouseEventArgs) Handles Panel7.MouseClick
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = True
        PictureBox6.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False

        Dim rnd As New Random
        Dim comp As Integer

        Dim F3 As New Form3

        comp = rnd.Next(3) + 1

        If wins < 8 And losses < 8 Then
            '1 = rock; rock vs paper
            If comp = 1 Then
                PictureBox14.Visible = True
                PictureBox1.Visible = True
                PictureBox9.Left -= 15
                wins = wins + 1

                '2 = paper; paper vs paper
            ElseIf comp = 2 Then
                PictureBox2.Visible = True
                ties = ties + 1

                '3 = scissor; scissor vs paper
            ElseIf comp = 3 Then
                PictureBox3.Visible = True
                PictureBox8.Left += 15
                losses = losses + 1
            End If
        ElseIf losses = 8 Then
            Form3.Show()
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox10.Visible = True
            PictureBox11.Visible = True
        Else
            Form3.Show()
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox10.Visible = True
            PictureBox11.Visible = True

        End If

        Label9.Text = wins + score
        Label10.Text = losses
    End Sub

    Private Sub scissor_click(sender As Object, e As MouseEventArgs) Handles Panel6.MouseClick
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = True
        PictureBox10.Visible = False
        PictureBox11.Visible = False

        Dim rnd As New Random
        Dim comp As Integer

        Dim F3 As New Form3

        comp = rnd.Next(3) + 1

        If wins < 8 And losses < 8 Then
            '1 = rock; rock vs scissor
            If comp = 1 Then
                PictureBox1.Visible = True
                PictureBox8.Left += 15
                losses = losses + 1

                '2 = paper; paper vs scissor
            ElseIf comp = 2 Then
                PictureBox15.Visible = True
                PictureBox2.Visible = True
                PictureBox9.Left -= 15
                wins = wins + 1

                '3 = scissor; scissor vs scissor
            ElseIf comp = 3 Then
                PictureBox3.Visible = True
                ties = ties + 1
            End If
        ElseIf losses = 8 Then
            Form3.Show()
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox10.Visible = True
            PictureBox11.Visible = True
        Else
            Form3.Show()
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
            PictureBox10.Visible = True
            PictureBox11.Visible = True
        End If

        Label9.Text = wins + score
        Label10.Text = losses
    End Sub



    Private Sub home_click(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        Form1.Show()
        Me.Hide()
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox13.Visible = False
        PictureBox14.Visible = False
        PictureBox15.Visible = False
        PictureBox10.Visible = True
        PictureBox11.Visible = True

        wins = 0
        losses = 0
        ties = 0
        score = 0

        Label9.Text = wins + score
        Label10.Text = losses

        PictureBox8.Location = New Point(75, 3)
        PictureBox9.Location = New Point(375, 3)
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Form5.Show()
        PictureBox13.Visible = False
    End Sub

    Private Sub PictureBox14_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox14.MouseClick
        Form7.Show()
        PictureBox14.Visible = False
    End Sub

    Private Sub PictureBox15_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox15.MouseClick
        Form8.Show()
        PictureBox15.Visible = False
    End Sub
End Class