Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Public Class sign_up_form
    Dim pwdeye As Boolean = False
    Dim cnfpwdeye As Boolean = False
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ABC\source\repos\Queen Predication\Queen Predication\queen_predication.accdb"
    Private Sub sign_up_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim contact As String = txtContactNumber.Text
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text
        Dim confirmpwd As String = txtCnfrmPassword.Text
        Dim status As String = "Active"
        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(contact) OrElse String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(password) OrElse String.IsNullOrWhiteSpace(confirmpwd) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If
        If confirmpwd <> password Then
            MessageBox.Show("Password and Confirm Password must be Same.")
            Return
        End If
        If Not IsValidEmail(email) Then
            MessageBox.Show("Please enter a valid email address.")
            Return
        End If
        If Not IsValidContact(contact) Then
            MessageBox.Show("Please enter a valid contact number.")
            Return
        End If

        Try
            Dim connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim query_user As String = "INSERT INTO tbl_user([username], [contact_num], [email], [password],[status]) VALUES(@username_user, @contact, @email, @password,@status)"
            Dim cmd_user As New OleDbCommand(query_user, connection)
            cmd_user.Parameters.AddWithValue("@username_user", username)
            cmd_user.Parameters.AddWithValue("@contact", contact)
            cmd_user.Parameters.AddWithValue("@email", email)
            cmd_user.Parameters.AddWithValue("@password", password)
            cmd_user.Parameters.AddWithValue("@status", status)
            cmd_user.ExecuteNonQuery()


            Dim query_highscore As String = "INSERT INTO tbl_highscore([username], [highscore]) VALUES(@username_highscore,0)"
            Dim cmd_highscore As New OleDbCommand(query_highscore, connection)
            cmd_highscore.Parameters.AddWithValue("@username_highscore", username)
            cmd_highscore.ExecuteNonQuery()

            MessageBox.Show("Registration successful!")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error registering user: " & ex.Message)
        End Try
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function

    Private Function IsValidContact(contact As String) As Boolean
        Dim pattern As String = "^\d{10}$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(contact)
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPasswordShowHide_Click(sender As Object, e As EventArgs) Handles btnPasswordShowHide.Click
        If pwdeye = False Then
            txtPassword.PasswordChar = ""
            pwdeye = True
        Else
            txtPassword.PasswordChar = "*"
            pwdeye = False
        End If
    End Sub

    Private Sub btnConfirmPasswordShowHide_Click(sender As Object, e As EventArgs) Handles btnConfirmPasswordShowHide.Click
        If cnfpwdeye = False Then
            txtCnfrmPassword.PasswordChar = ""
            cnfpwdeye = True
        Else
            txtCnfrmPassword.PasswordChar = "*"
            cnfpwdeye = False
        End If
    End Sub
End Class