Imports System.Data.SqlClient
Public Class Form4
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim itemcoll(100) As String
    Dim da2 As SqlDataAdapter
    Dim ds2 As DataSet
    Dim itemcoll2(100) As String
    Public Property username As String
    Public Property ldbscore As Integer
    Private Sub home_click(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick

        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Joz Files\JackNPoy\JackNPoy\jnpdb.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        Label1.Text = username
        Label2.Text = ldbscore


        Me.ListView1.View = View.Details
        Me.ListView1.GridLines = True
        Me.ListView2.View = View.Details
        Me.ListView2.GridLines = True
        Dim strQ As String = String.Empty
        Dim strQ2 As String = String.Empty
        strQ = "SELECT score FROM Scoreboard ORDER BY score DESC"
        strQ2 = "SELECT name FROM Scoreboard ORDER BY score DESC"
        cmd = New SqlCommand(strQ, con)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "Table")

        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim ii As Integer = 0
        Dim jj As Integer = 0

        For i = 0 To ds.Tables(0).Columns.Count - 1
            Me.ListView1.Columns.Add(ds.Tables(0).Columns(i).ColumnName.ToString())
        Next
        For i = 0 To ds.Tables(0).Rows.Count - 1

            For j = 0 To ds.Tables(0).Columns.Count - 1

                itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()
            Next

            Dim lvi As New ListViewItem(itemcoll)
            Me.ListView1.Items.Add(lvi)
            Me.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None

        Next
        cmd = New SqlCommand(strQ2, con)
        da2 = New SqlDataAdapter(cmd)
        ds2 = New DataSet
        da2.Fill(ds2, "Table")
        For ii = 0 To ds2.Tables(0).Columns.Count - 1
            Me.ListView2.Columns.Add(ds2.Tables(0).Columns(ii).ColumnName.ToString())
        Next
        For ii = 0 To ds2.Tables(0).Rows.Count - 1

            For jj = 0 To ds2.Tables(0).Columns.Count - 1

                itemcoll2(jj) = ds2.Tables(0).Rows(ii)(jj).ToString()
            Next

            Dim lvi2 As New ListViewItem(itemcoll2)
            Me.ListView2.Items.Add(lvi2)
            Me.ListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None

        Next



    End Sub
End Class