<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tmrScore = New System.Windows.Forms.Timer(Me.components)
        Me.ball = New System.Windows.Forms.PictureBox()
        Me.paddle = New System.Windows.Forms.PictureBox()
        Me.ballMover = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPlay = New System.Windows.Forms.Label()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.lblPause = New System.Windows.Forms.Label()
        Me.Highscores = New System.Windows.Forms.Label()
        Me.txtHighScore = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHitHighscore = New System.Windows.Forms.Label()
        Me.lblPlayAgain = New System.Windows.Forms.Label()
        Me.lblClear = New System.Windows.Forms.Label()
        Me.tmrLevelCheck = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBonuses = New System.Windows.Forms.Timer(Me.components)
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tmrUpdateChecker = New System.Windows.Forms.Timer(Me.components)
        Me.tmrForm2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paddle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrScore
        '
        Me.tmrScore.Interval = 1000
        '
        'ball
        '
        Me.ball.BackColor = System.Drawing.Color.Transparent
        Me.ball.Image = CType(resources.GetObject("ball.Image"), System.Drawing.Image)
        Me.ball.Location = New System.Drawing.Point(180, 469)
        Me.ball.Name = "ball"
        Me.ball.Size = New System.Drawing.Size(32, 32)
        Me.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ball.TabIndex = 1
        Me.ball.TabStop = False
        '
        'paddle
        '
        Me.paddle.Image = CType(resources.GetObject("paddle.Image"), System.Drawing.Image)
        Me.paddle.Location = New System.Drawing.Point(132, 507)
        Me.paddle.Name = "paddle"
        Me.paddle.Size = New System.Drawing.Size(130, 32)
        Me.paddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.paddle.TabIndex = 2
        Me.paddle.TabStop = False
        '
        'ballMover
        '
        Me.ballMover.Interval = 2
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(5, 3)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(380, 24)
        Me.lblScore.TabIndex = 3
        Me.lblScore.Text = "Score: "
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblScore.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(111, 26)
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(-2, 177)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(385, 58)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Brick Breaker"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPlay
        '
        Me.lblPlay.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlay.ForeColor = System.Drawing.Color.White
        Me.lblPlay.Location = New System.Drawing.Point(1, 280)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(382, 65)
        Me.lblPlay.TabIndex = 5
        Me.lblPlay.Text = "PLAY"
        Me.lblPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSettings
        '
        Me.lblSettings.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.ForeColor = System.Drawing.Color.White
        Me.lblSettings.Location = New System.Drawing.Point(0, 336)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(383, 65)
        Me.lblSettings.TabIndex = 6
        Me.lblSettings.Text = "SETTINGS"
        Me.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHighScore
        '
        Me.lblHighScore.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScore.ForeColor = System.Drawing.Color.White
        Me.lblHighScore.Location = New System.Drawing.Point(0, 395)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(383, 65)
        Me.lblHighScore.TabIndex = 7
        Me.lblHighScore.Text = "HIGHSCORES"
        Me.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPause
        '
        Me.lblPause.BackColor = System.Drawing.Color.Transparent
        Me.lblPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPause.ForeColor = System.Drawing.Color.White
        Me.lblPause.Location = New System.Drawing.Point(0, 3)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(385, 554)
        Me.lblPause.TabIndex = 8
        Me.lblPause.Text = "Paused"
        Me.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPause.Visible = False
        '
        'Highscores
        '
        Me.Highscores.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Highscores.ForeColor = System.Drawing.Color.White
        Me.Highscores.Location = New System.Drawing.Point(0, -2)
        Me.Highscores.Name = "Highscores"
        Me.Highscores.Size = New System.Drawing.Size(385, 554)
        Me.Highscores.TabIndex = 9
        Me.Highscores.Text = "HighScores" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "User 1       -       0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "User 2       -       0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "User 3       -     " &
    "  0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "User 4       -       0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "User 5       -       0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Highscores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Highscores.Visible = False
        '
        'txtHighScore
        '
        Me.txtHighScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHighScore.Location = New System.Drawing.Point(100, 61)
        Me.txtHighScore.MaxLength = 8
        Me.txtHighScore.Multiline = True
        Me.txtHighScore.Name = "txtHighScore"
        Me.txtHighScore.Size = New System.Drawing.Size(201, 48)
        Me.txtHighScore.TabIndex = 10
        Me.txtHighScore.Visible = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(17, 74)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(77, 24)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "Name: "
        Me.lblName.Visible = False
        '
        'lblHitHighscore
        '
        Me.lblHitHighscore.AutoSize = True
        Me.lblHitHighscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHitHighscore.ForeColor = System.Drawing.Color.White
        Me.lblHitHighscore.Location = New System.Drawing.Point(142, 34)
        Me.lblHitHighscore.Name = "lblHitHighscore"
        Me.lblHitHighscore.Size = New System.Drawing.Size(115, 24)
        Me.lblHitHighscore.TabIndex = 12
        Me.lblHitHighscore.Text = "HighScore!"
        Me.lblHitHighscore.Visible = False
        '
        'lblPlayAgain
        '
        Me.lblPlayAgain.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayAgain.ForeColor = System.Drawing.Color.White
        Me.lblPlayAgain.Location = New System.Drawing.Point(-2, 482)
        Me.lblPlayAgain.Name = "lblPlayAgain"
        Me.lblPlayAgain.Size = New System.Drawing.Size(383, 65)
        Me.lblPlayAgain.TabIndex = 13
        Me.lblPlayAgain.Text = "PLAY AGAIN"
        Me.lblPlayAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPlayAgain.Visible = False
        '
        'lblClear
        '
        Me.lblClear.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClear.ForeColor = System.Drawing.Color.White
        Me.lblClear.Location = New System.Drawing.Point(1, 446)
        Me.lblClear.Name = "lblClear"
        Me.lblClear.Size = New System.Drawing.Size(381, 55)
        Me.lblClear.TabIndex = 15
        Me.lblClear.Text = "CLEAR"
        Me.lblClear.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblClear.Visible = False
        '
        'tmrLevelCheck
        '
        Me.tmrLevelCheck.Interval = 500
        '
        'tmrBonuses
        '
        Me.tmrBonuses.Interval = 1000
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(378, 485)
        Me.WebBrowser1.TabIndex = 16
        Me.WebBrowser1.TabStop = False
        Me.WebBrowser1.Url = New System.Uri("http://brickbreaker.99k.org", System.UriKind.Absolute)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.WebBrowser1)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 488)
        Me.Panel1.TabIndex = 17
        Me.Panel1.Visible = False
        '
        'tmrUpdateChecker
        '
        Me.tmrUpdateChecker.Interval = 1000
        '
        'tmrForm2
        '
        Me.tmrForm2.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(384, 551)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblClear)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblPlayAgain)
        Me.Controls.Add(Me.lblHitHighscore)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtHighScore)
        Me.Controls.Add(Me.lblHighScore)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.lblPlay)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.paddle)
        Me.Controls.Add(Me.ball)
        Me.Controls.Add(Me.Highscores)
        Me.Controls.Add(Me.lblPause)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Brick Breaker"
        CType(Me.ball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paddle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ball As System.Windows.Forms.PictureBox
    Friend WithEvents paddle As System.Windows.Forms.PictureBox
    Friend WithEvents ballMover As System.Windows.Forms.Timer
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblPlay As System.Windows.Forms.Label
    Friend WithEvents lblSettings As System.Windows.Forms.Label
    Friend WithEvents lblHighScore As System.Windows.Forms.Label
    Friend WithEvents lblPause As System.Windows.Forms.Label
    Friend WithEvents Highscores As System.Windows.Forms.Label
    Friend WithEvents txtHighScore As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblHitHighscore As System.Windows.Forms.Label
    Friend WithEvents lblPlayAgain As System.Windows.Forms.Label
    'Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents lblClear As System.Windows.Forms.Label
    Friend WithEvents tmrScore As System.Windows.Forms.Timer
    Friend WithEvents tmrLevelCheck As System.Windows.Forms.Timer
    Friend WithEvents tmrBonuses As System.Windows.Forms.Timer
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tmrUpdateChecker As System.Windows.Forms.Timer
    Friend WithEvents tmrForm2 As System.Windows.Forms.Timer

End Class
