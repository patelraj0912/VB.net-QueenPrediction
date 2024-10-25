Imports System.Drawing.Drawing2D
Imports System.Data.OleDb
Public Class Form1
    Dim eye As Boolean = False
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ABC\source\repos\Queen Predication\Queen Predication\queen_predication.accdb"
    Public targetid As Integer
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPasswordShowHide_Click(sender As Object, e As EventArgs) Handles btnPasswordShowHide.Click
        If eye = False Then
            txtPassword.PasswordChar = ""
            eye = True
        ElseIf eye = True Then
            txtPassword.PasswordChar = "*"
            eye = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetRoundedCorner(Panel2, 30)
        SetRoundedCorner(Panel8, 20)
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

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Dim username As String = txtUserName.Text
        Dim password As String = txtPassword.Text

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.")
            Return
        End If
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT id FROM tbl_user WHERE [username] = @username AND [password] = @password AND [status]='Active'"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        targetid = Convert.ToInt32(result)
                        home_form.Show()
                    Else
                        MessageBox.Show("Invalid username or password.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error during login: " & ex.Message)
        End Try
    End Sub

    Private Sub linkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSignUp.LinkClicked
        sign_up_form.Show()
    End Sub
End Class
