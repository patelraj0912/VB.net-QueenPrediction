<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class play_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.PictureWinLoss = New System.Windows.Forms.PictureBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Card2 = New System.Windows.Forms.PictureBox()
        Me.Card3 = New System.Windows.Forms.PictureBox()
        Me.Card1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelScore = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelStartExitBtn = New System.Windows.Forms.Panel()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureWinLoss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.Card2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PanelScore.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelStartExitBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.BackgroundImage = Global.Queen_Predication.My.Resources.Resources.game_page_background
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnPlayAgain)
        Me.Panel1.Controls.Add(Me.PictureWinLoss)
        Me.Panel1.Controls.Add(Me.btnStop)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PanelStartExitBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1924, 1055)
        Me.Panel1.TabIndex = 0
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.BackColor = System.Drawing.Color.Transparent
        Me.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlayAgain.Font = New System.Drawing.Font("Modern No. 20", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayAgain.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPlayAgain.Image = Global.Queen_Predication.My.Resources.Resources.replay__1_
        Me.btnPlayAgain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlayAgain.Location = New System.Drawing.Point(997, 745)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(303, 100)
        Me.btnPlayAgain.TabIndex = 12
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPlayAgain.UseVisualStyleBackColor = False
        Me.btnPlayAgain.Visible = False
        '
        'PictureWinLoss
        '
        Me.PictureWinLoss.BackColor = System.Drawing.Color.Transparent
        Me.PictureWinLoss.Image = Global.Queen_Predication.My.Resources.Resources.lose
        Me.PictureWinLoss.Location = New System.Drawing.Point(855, 745)
        Me.PictureWinLoss.Name = "PictureWinLoss"
        Me.PictureWinLoss.Size = New System.Drawing.Size(136, 109)
        Me.PictureWinLoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureWinLoss.TabIndex = 0
        Me.PictureWinLoss.TabStop = False
        Me.PictureWinLoss.Visible = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Red
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStop.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnStop.Image = Global.Queen_Predication.My.Resources.Resources.close
        Me.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStop.Location = New System.Drawing.Point(1850, 12)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(174, 60)
        Me.btnStop.TabIndex = 11
        Me.btnStop.Text = "Close"
        Me.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStop.UseVisualStyleBackColor = False
        Me.btnStop.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Card2)
        Me.Panel3.Controls.Add(Me.Card3)
        Me.Panel3.Controls.Add(Me.Card1)
        Me.Panel3.Location = New System.Drawing.Point(518, 209)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1101, 530)
        Me.Panel3.TabIndex = 7
        Me.Panel3.Visible = False
        '
        'Card2
        '
        Me.Card2.BackColor = System.Drawing.Color.Transparent
        Me.Card2.Image = Global.Queen_Predication.My.Resources.Resources.card_back_transferent
        Me.Card2.Location = New System.Drawing.Point(374, 25)
        Me.Card2.Name = "Card2"
        Me.Card2.Size = New System.Drawing.Size(352, 480)
        Me.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card2.TabIndex = 9
        Me.Card2.TabStop = False
        '
        'Card3
        '
        Me.Card3.BackColor = System.Drawing.Color.Transparent
        Me.Card3.Image = Global.Queen_Predication.My.Resources.Resources.card_back_transferent
        Me.Card3.Location = New System.Drawing.Point(732, 25)
        Me.Card3.Name = "Card3"
        Me.Card3.Size = New System.Drawing.Size(352, 480)
        Me.Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card3.TabIndex = 1
        Me.Card3.TabStop = False
        '
        'Card1
        '
        Me.Card1.BackColor = System.Drawing.Color.Transparent
        Me.Card1.Image = Global.Queen_Predication.My.Resources.Resources.card_back_transferent
        Me.Card1.Location = New System.Drawing.Point(16, 25)
        Me.Card1.Name = "Card1"
        Me.Card1.Size = New System.Drawing.Size(352, 480)
        Me.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card1.TabIndex = 0
        Me.Card1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.PanelScore)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1924, 83)
        Me.Panel2.TabIndex = 6
        '
        'PanelScore
        '
        Me.PanelScore.Controls.Add(Me.Label1)
        Me.PanelScore.Controls.Add(Me.lblScore)
        Me.PanelScore.Controls.Add(Me.PictureBox2)
        Me.PanelScore.Location = New System.Drawing.Point(453, 3)
        Me.PanelScore.Name = "PanelScore"
        Me.PanelScore.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PanelScore.Size = New System.Drawing.Size(801, 83)
        Me.PanelScore.TabIndex = 5
        Me.PanelScore.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MingLiU-ExtB", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(96, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(195, 48)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Score :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblScore
        '
        Me.lblScore.AutoEllipsis = True
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("MingLiU-ExtB", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblScore.Location = New System.Drawing.Point(362, 21)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblScore.Size = New System.Drawing.Size(45, 48)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Queen_Predication.My.Resources.Resources.score_icon
        Me.PictureBox2.Location = New System.Drawing.Point(17, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PanelStartExitBtn
        '
        Me.PanelStartExitBtn.BackColor = System.Drawing.Color.Transparent
        Me.PanelStartExitBtn.Controls.Add(Me.btnStart)
        Me.PanelStartExitBtn.Controls.Add(Me.btnClose)
        Me.PanelStartExitBtn.Location = New System.Drawing.Point(712, 488)
        Me.PanelStartExitBtn.Name = "PanelStartExitBtn"
        Me.PanelStartExitBtn.Size = New System.Drawing.Size(609, 85)
        Me.PanelStartExitBtn.TabIndex = 5
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Green
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStart.Font = New System.Drawing.Font("Rockwell", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnStart.Image = Global.Queen_Predication.My.Resources.Resources.play__2_
        Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStart.Location = New System.Drawing.Point(37, 3)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(230, 84)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start"
        Me.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Font = New System.Drawing.Font("Rockwell", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Image = Global.Queen_Predication.My.Resources.Resources.logout__4_
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.Location = New System.Drawing.Point(327, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(230, 84)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Exit"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'play_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "play_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "play_form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureWinLoss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.Card2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.PanelScore.ResumeLayout(False)
        Me.PanelScore.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelStartExitBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents PanelStartExitBtn As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelScore As Panel
    Friend WithEvents lblScore As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Card1 As PictureBox
    Friend WithEvents Card3 As PictureBox
    Friend WithEvents Card2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureWinLoss As PictureBox
    Friend WithEvents btnPlayAgain As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents Label1 As Label
End Class
