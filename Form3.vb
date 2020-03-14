Imports System.Data.SqlClient
Public Class Form3
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Public Property status As String
    Private Sub nickname_click(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        Dim F4 As New Form4
        F4.username = TextBox1.Text
        F4.ldbscore = Form2.score + Form2.wins
        'Dim F2 As New Form2
        Label2.Text = Form2.score
        Me.Hide()
        F4.Show()


        Dim score As String = F4.ldbscore.ToString()


        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO Scoreboard (name, score) VALUES('" + TextBox1.Text + "','" + score + "')"
        cmd.ExecuteNonQuery()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label2.Text = Form2.score + Form2.wins

        If Form2.losses > Form2.wins Then
            Label1.Text = "You Lose!"
        Else
            Label1.Text = "You Win!"
        End If

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Joz Files\JackNPoy\JackNPoy\jnpdb.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()


    End Sub
End Class