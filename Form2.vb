Public Class Form2
    Public Property total As String
    Dim wins As Integer = 0
    Dim losses As Integer = 0
    Dim ties As Integer = 0


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
    End Sub

    Private Sub rock_click(sender As Object, e As MouseEventArgs) Handles Panel8.MouseClick
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = True
        PictureBox5.Visible = False
        PictureBox6.Visible = False


        Dim rnd As New Random
        Dim comp As Integer


        comp = rnd.Next(3) + 1

        If wins < 4 Then
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
                PictureBox3.Visible = True
                PictureBox9.Left -= 15
                wins = wins + 1
            End If
        Else
            Form3.Show()
        End If
        total = wins

        Label4.Text = total
        Label5.Text = losses
        Label6.Text = ties


    End Sub

    Private Sub home_click(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub paper_click(sender As Object, e As MouseEventArgs) Handles Panel7.MouseClick
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = True
        PictureBox6.Visible = False

        Dim rnd As New Random
        Dim comp As Integer
        comp = rnd.Next(3) + 1

        If wins < 4 Then
            '1 = rock; rock vs paper
            If comp = 1 Then
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
        Else
            Form3.Show()
        End If
        total = wins
        Label4.Text = total
        Label5.Text = losses
        Label6.Text = ties
    End Sub

    Private Sub scissor_click(sender As Object, e As MouseEventArgs) Handles Panel6.MouseClick
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = True

        Dim rnd As New Random
        Dim comp As Integer
        comp = rnd.Next(3) + 1

        If wins < 4 Then
            '1 = rock; rock vs scissor
            If comp = 1 Then
                PictureBox1.Visible = True
                PictureBox8.Left += 15
                losses = losses + 1

                '2 = paper; paper vs scissor
            ElseIf comp = 2 Then
                PictureBox2.Visible = True
                PictureBox9.Left -= 15
                wins = wins + 1

                '3 = scissor; scissor vs scissor
            ElseIf comp = 3 Then
                PictureBox3.Visible = True
                ties = ties + 1
            End If
        Else
            Form3.Show()
        End If

        total = wins

        Label4.Text = total
        Label5.Text = losses
        Label6.Text = ties


    End Sub


End Class