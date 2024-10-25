Imports System.Drawing.Drawing2D
Imports System.Data.OleDb
Public Class settigs_form
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ABC\source\repos\Queen Predication\Queen Predication\queen_predication.accdb"
    Private Sub settigs_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserName.Text = "Patelraj"
        SetRoundedCorner(PanelOptionChangeUNmPwd, 35)
        SetRoundedCorner(Panel4, 20)
        SetRoundedCorner(Panel5, 20)
        SetRoundedCorner(PanelChangeUserName, 20)
        SetRoundedCorner(Panel8, 20)
        txtUserName.Text = Form1.txtUserName.Text
    End Sub
    Private Sub SetRoundedCorner(panel As Panel, radius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(New Rectangle(0, 0, radius * 2, radius * 2), 180, 90)
        path.AddArc(New Rectangle(panel.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90)
        path.AddArc(New Rectangle(panel.Width - radius * 2, panel.Height - radius * 2, radius * 2, radius * 2), 0, 90)
        path.AddArc(New Rectangle(0, panel.Height - radius * 2, radius * 2, radius * 2), 90, 90)
        path.CloseFigure()
        panel.Region = New Region(path)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnChangeUserName_Click(sender As Object, e As EventArgs) Handles btnChangeUserName.Click
        Dim newUsername As String = txtNewUserName.Text
        home_form.lblUserName.Text = newUsername
        lblUserName.Text = newUsername
        If String.IsNullOrWhiteSpace(newUsername) And newUsername = txtUserName.Text Then
            MessageBox.Show("Please enter Proper Username.")
            Return
        End If
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim updateUserQuery As String = "UPDATE tbl_user SET [username] = @newUsername WHERE id = @targetId"
                Using updateUserCommand As New OleDbCommand(updateUserQuery, connection)
                    updateUserCommand.Parameters.AddWithValue("@newUsername", newUsername)
                    updateUserCommand.Parameters.AddWithValue("@targetId", Form1.targetid)
                    Dim rowsAffectedUser As Integer = updateUserCommand.ExecuteNonQuery()
                End Using
                Dim updateHighScoreQuery As String = "UPDATE tbl_highscore SET [username] = @newUsername WHERE targetId = @targetId"
                Using updateHighScoreCommand As New OleDbCommand(updateHighScoreQuery, connection)
                    updateHighScoreCommand.Parameters.AddWithValue("@newUsername", newUsername)
                    updateHighScoreCommand.Parameters.AddWithValue("@targetId", Form1.targetid)
                    Dim rowsAffectedHighScore As Integer = updateHighScoreCommand.ExecuteNonQuery()
                    If rowsAffectedHighScore > 0 Then
                        MessageBox.Show("Username updated Successfully.")
                    Else
                        MessageBox.Show("Username update failed in tbl_highscore table.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating username: " & ex.Message)
        End Try
        PanelChangeUserName.Visible = False
        PanelOptionChangeUNmPwd.Visible = True
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblChangeName.Click
        PanelChangeUserName.Visible = True
        PanelOptionChangeUNmPwd.Visible = False
    End Sub
    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT username FROM tbl_highscore WHERE targetId = @targetId"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@targetId", Form1.targetid)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        txtUserName.Text = result
                    Else
                        txtUserName.Text = "Server Down"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching highscore: " & ex.Message)
        End Try
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim delete_user As String = "delete from tbl_user where ID = @tagertId"
                Using cmd_delete_user As New OleDbCommand(delete_user, connection)
                    cmd_delete_user.Parameters.AddWithValue("@targetId", Form1.targetid)
                    Dim rowsAffectedUser As Integer = cmd_delete_user.ExecuteNonQuery()
                End Using
                Dim delete_highscore As String = "delete from tbl_highscore where ID = @tagertId"
                Using cmd_delete_highscore As New OleDbCommand(delete_user, connection)
                    cmd_delete_highscore.Parameters.AddWithValue("@targetId", Form1.targetid)
                    Dim rowsAffectedUser As Integer = cmd_delete_highscore.ExecuteNonQuery()
                End Using
            End Using
            home_form.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error updating username: " & ex.Message)
        End Try
    End Sub
End Class