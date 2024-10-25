Imports System.Drawing.Drawing2D
Imports System.Data.OleDb
Public Class home_form
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ABC\source\repos\Queen Predication\Queen Predication\queen_predication.accdb"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub
    Private Sub home_form_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblUserName.Text = Form1.txtUserName.Text
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT highscore FROM tbl_highscore WHERE targetId = @targetId"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@targetId", Form1.targetid)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        lblHighScore.Text = result.ToString()
                    Else
                        lblHighScore.Text = "N/A"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching highscore: " & ex.Message)
        End Try
    End Sub
    Private Sub SetRoundedCorner(panel As PictureBox, radius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(New Rectangle(0, 0, radius * 2, radius * 2), 180, 90)
        path.AddArc(New Rectangle(panel.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90)
        path.AddArc(New Rectangle(panel.Width - radius * 2, panel.Height - radius * 2, radius * 2, radius * 2), 0, 90)
        path.AddArc(New Rectangle(0, panel.Height - radius * 2, radius * 2, radius * 2), 90, 90)
        path.CloseFigure()
        panel.Region = New Region(path)
    End Sub
    Private Sub lblHelp_Click(sender As Object, e As EventArgs) Handles lblHelp.Click
        help_form.Show()
    End Sub
    Private Sub lblSettings_Click(sender As Object, e As EventArgs) Handles lblSettings.Click
        settigs_form.Show()
    End Sub
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        play_form.Show()
    End Sub
    Private Sub btnScoreBoard_Click(sender As Object, e As EventArgs) Handles btnScoreBoard.Click
        view_scoreboard.Show()
    End Sub
End Class