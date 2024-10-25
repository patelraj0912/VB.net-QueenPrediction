Imports System.Data.OleDb
Public Class play_form
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ABC\source\repos\Queen Predication\Queen Predication\queen_predication.accdb"
    Dim user_choice As Integer = 0
    Dim score As Integer = 0
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        PanelStartExitBtn.Visible = False
        PanelScore.Visible = True
        Panel3.Visible = True
    End Sub

    Private Sub Card1_Click(sender As Object, e As EventArgs) Handles Card1.Click
        user_choice = 1
        Card1.BackColor = Color.Green
        Card2.BackColor = Color.Transparent
        Card3.BackColor = Color.Transparent
        result()
    End Sub
    Private Sub Card2_Click(sender As Object, e As EventArgs) Handles Card2.Click
        user_choice = 2
        Card1.BackColor = Color.Transparent
        Card2.BackColor = Color.Green
        Card3.BackColor = Color.Transparent
        result()
    End Sub
    Private Sub Card3_Click(sender As Object, e As EventArgs) Handles Card3.Click
        user_choice = 3
        Card1.BackColor = Color.Transparent
        Card2.BackColor = Color.Transparent
        Card3.BackColor = Color.Green
        result()
    End Sub
    Sub result()
        Dim rand As System.Random = New System.Random()
        Dim randomnum As Integer = rand.Next(1, 4)
        Select Case randomnum
            Case 1
                Card1.Image = Image.FromFile("C:\Users\ABC\source\repos\Queen Predication\Queen Predication\Resources\queen_card.png")
                Card2.Image = Image.FromFile("C:\Users\ABC\source\repos\Queen Predication\Queen Predication\Resources\card_back_transferent.png")
                Card3.Image = Image.FromFile("C:\Users\ABC\source\repos\Queen Predication\Queen Predication\Resources\card_back_transferent.png")
            Case 2
                Card2.Image = Image.FromFile("C:\Users\ABC\source\repos\Queen Predication\Queen Predication\Resources\queen_card.png")
                Card1.Image = Image.FromFile("C:\Users\ABC\source\repos\Queen Predication\Queen Predication\Resources\card_back_transferent.png")
                Card3.Image = Image.FromFile("C:\Users\ABC\source\repos\Queen Predication\Queen Predication\Resources\card_back_transferent.png")
            Case 3
                Card3.Image = Image.FromFile("C:\Users\ABC\source\repos\Queen Predication\Queen Predication\Resources\queen_card.png")
                Card1.Image = Image.FromFile("C:\Users\ABC\source\repos\Queen Predication\Queen Predication\Resources\card_back_transferent.png")
                Card2.Image = Image.FromFile("C:\Users\ABC\source\repos\Queen Predication\Queen Predication\Resources\card_back_transferent.png")
        End Select
        If randomnum = user_choice Then
            score = score + 3
            PictureWinLoss.Visible = True
            PictureWinLoss.Image = Image.FromFile("C:\Users\ABC\source\repos\Queen Predication\Queen Predication\Resources\win.png")
            lblScore.Text = score
        Else
            score = score - 1
            PictureWinLoss.Visible = True
            PictureWinLoss.Image = Image.FromFile("C:\Users\ABC\source\repos\Queen Predication\Queen Predication\Resources\lose.png")
            lblScore.Text = score
        End If
        btnStop.Visible = True
        btnPlayAgain.Visible = True
    End Sub
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Panel3.Visible = False
        btnPlayAgain.Visible = False
        PanelStartExitBtn.Visible = True
        PictureWinLoss.Visible = False
        btnStop.Visible = False
        Dim highscore As Integer = home_form.lblHighScore.Text
        If score >= highscore Then
            home_form.lblHighScore.Text = score
            Dim connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim updateUserQuery As String = "UPDATE tbl_highscore SET [highscore] = @score WHERE ID = @targetId"
            Dim updateUserCommand As New OleDbCommand(updateUserQuery, connection)
            updateUserCommand.Parameters.AddWithValue("@score", score)
            updateUserCommand.Parameters.AddWithValue("@targetId", Form1.targetid)
            Dim rowsAffectedUser As Integer = updateUserCommand.ExecuteNonQuery()
        End If
    End Sub
    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        Card1.Image = Image.FromFile("C:\Users\ABC\source\repos\Queen Predication\Queen Predication\Resources\card_back_transferent.png")
        Card2.Image = Image.FromFile("C:\Users\ABC\source\repos\Queen Predication\Queen Predication\Resources\card_back_transferent.png")
        Card3.Image = Image.FromFile("C:\Users\ABC\source\repos\Queen Predication\Queen Predication\Resources\card_back_transferent.png")
        user_choice = 0
        Card1.BackColor = Color.Transparent
        Card2.BackColor = Color.Transparent
        Card3.BackColor = Color.Transparent
        PictureWinLoss.Visible = False
        btnStop.Visible = False
        btnPlayAgain.Visible = False
    End Sub
End Class