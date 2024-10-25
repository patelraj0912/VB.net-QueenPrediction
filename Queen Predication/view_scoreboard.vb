Imports System.Data.OleDb
Public Class view_scoreboard
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ABC\source\repos\Queen Predication\Queen Predication\queen_predication.accdb"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub view_scoreboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT username, highscore FROM tbl_highscore ORDER BY highscore DESC"
                Using adapter As New OleDbDataAdapter(query, connection)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    DataGridView1.Columns.Clear()

                    Dim usernameColumn As New DataGridViewTextBoxColumn()
                    usernameColumn.HeaderText = "Username"
                    usernameColumn.DataPropertyName = "username"
                    usernameColumn.Width = 500
                    usernameColumn.DefaultCellStyle.BackColor = Color.LightGray
                    usernameColumn.DefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Bold)
                    usernameColumn.DefaultCellStyle.ForeColor = Color.Black
                    DataGridView1.Columns.Add(usernameColumn)

                    Dim highscoreColumn As New DataGridViewTextBoxColumn()
                    highscoreColumn.HeaderText = "Highscore"
                    highscoreColumn.DataPropertyName = "highscore"
                    highscoreColumn.Width = 300
                    highscoreColumn.DefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Bold)
                    highscoreColumn.DefaultCellStyle.BackColor = Color.LightGray
                    DataGridView1.Columns.Add(highscoreColumn)
                    DataGridView1.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error populating DataGridView: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim stu_id As String = txtSearchBox.Text
        Try
            Using connection As New OleDbConnection(connectionString)
                Dim query As String = "SELECT * FROM tbl_highscore where username LIKE @keyword"
                Dim command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@Keyword", stu_id & "%")
                Dim dataAdapter As New OleDbDataAdapter(command)
                Dim dataSet As New DataSet()
                dataAdapter.Fill(dataSet, "tbl_highscore")
                DataGridView1.DataSource = dataSet.Tables("tbl_highscore")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
End Class