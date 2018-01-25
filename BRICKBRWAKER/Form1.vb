Imports System.Net
Public Class Form1
    Dim VSpeed As Integer = -2
    Dim HSpeed As Integer = -2
    Dim rows As Integer   '8
    Dim cols As Integer  ' 10
    Dim TopRow As Single = 0.1
    Dim RowHeight As Single = 0.05
    Dim Score As Integer = 0
    Dim Multiplier As Integer
    Dim InGame As Boolean = False
    Dim Seconds As Double
    Dim level As Integer = 1
    Dim hitcount As Integer
    Dim counterA As Integer
    Dim longpaddle As Boolean = False
    Dim bonustime As Integer
    Dim WithEvents WebC As WebClient
    Dim ts As TimeSpan
    Dim h As String
    Dim s As String
    Dim m As String
    Dim brickbreakcount As Integer = 3
    'Dim wb As New WebBrowser
    Private Sub paddle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paddle.Click



    End Sub

    Private Sub Form1_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Me.GotFocus

        If InGame = True Then

            ballMover.Enabled = True
            lblPause.Visible = False
            tmrScore.Enabled = True
        End If


    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            Dim x As Integer = paddle.Location.X - 30 '15
            paddle.Location = New Point(x, 507)

            If paddle.Location.X < 0 Then

                paddle.Location = New Point(0, paddle.Location.Y)

            End If

        End If

        If e.KeyCode = Keys.Right Then

            Dim x As Integer = paddle.Location.X + 30 ' 15

            paddle.Location = New Point(x, 507)

            If longpaddle = True Then
                If paddle.Location.X > 125 Then

                    paddle.Location = New Point(125, paddle.Location.Y)

                End If
            Else
                If paddle.Location.X > 255 Then

                    paddle.Location = New Point(255, paddle.Location.Y)

                End If
            End If


        End If

    End Sub



    Private Sub paddle_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        ' paddle.Location = e.Location

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ballMover.Tick
        lblScore.Text = "Score: " & Score & Space(1) & "Time: " & h & ":" & m & ":" & s & Space(1) & "Multiplier: " & Multiplier '& Space(30) & "QQ"





        If ball.Top < 0 Then

            VSpeed = -VSpeed

        End If

        If ball.Left < 0 Then

            HSpeed = -HSpeed

        End If

        If ball.Right > Me.ClientRectangle.Width Then

            HSpeed = -HSpeed

        End If

        If ball.Bottom > Me.ClientRectangle.Height Then
            'Lost Game
            ballMover.Enabled = False
            InGame = False
            Play()
            For i As Integer = Me.Controls.Count - 1 To 0 Step -1

                If Me.Controls(i).Name = "brick" Then

                    Me.Controls.RemoveAt(i)

                End If

            Next
            lblTitle.TextAlign = ContentAlignment.MiddleCenter
            lblTitle.Text = "You Lose!"
            lblTitle.Visible = True

            If Score > My.Settings.Player5Score Then
                txtHighScore.Enabled = True
                txtHighScore.Visible = True
                lblHitHighscore.Visible = True
                lblName.Visible = True
                lblSettings.Visible = True
                lblSettings.Text = "Submit Score"

                'lblPlayAgain.Visible = True
                'lblPlayAgain.BringToFront()
            End If

            lblPlay.Visible = True
            lblPlay.Text = "PLAY AGAIN"


        End If


        Dim BallCenter As Single = ball.Left + ball.Width / 2


        If BallCenter > paddle.Left And BallCenter < paddle.Right And VSpeed > 0 And ball.Bottom > paddle.Top And ball.Top < paddle.Top Then

            VSpeed = -VSpeed

            Dim offset As Single = (ball.Left + ball.Width / 2) - (paddle.Left + paddle.Width / 2)
            Dim ratio As Single = offset / (paddle.Width / 2)
            HSpeed += 2 * ratio


        End If

        For Each ctrl As Control In Me.Controls

            If ctrl.Name = "brick" Then

                CheckBrick(ctrl, ball)



            End If




        Next



        ball.Left += HSpeed
        ball.Top += VSpeed

    End Sub
    Private Sub CheckBrick(ByVal Bricks As Button, ByVal ball As PictureBox)

        For i As Integer = Me.Controls.Count - 1 To 0 Step -1

            If i = 0 Or i < 0 Then



            End If

        Next




        Dim hit As Boolean = False

        If Bricks.Visible Then
            Dim BallCenter As Single = ball.Left + ball.Width / 2

            If VSpeed < 0 And BallCenter > Bricks.Left And BallCenter < Bricks.Right And ball.Top < Bricks.Bottom And ball.Bottom > Bricks.Bottom Then

                VSpeed = -VSpeed
                hit = True
            End If


            If VSpeed > 0 And BallCenter > Bricks.Left And BallCenter < Bricks.Right And ball.Bottom > Bricks.Top And ball.Top < Bricks.Top Then

                VSpeed = -VSpeed
                hit = True
            End If

            BallCenter = ball.Top + ball.Height / 2

            If HSpeed > 0 And BallCenter > Bricks.Top And BallCenter < Bricks.Bottom And ball.Right > Bricks.Left And ball.Left < Bricks.Left Then

                HSpeed = -HSpeed
                hit = True
            End If

            If HSpeed < 0 And BallCenter > Bricks.Top And BallCenter < Bricks.Bottom And ball.Left < Bricks.Right And ball.Right > Bricks.Right Then

                HSpeed = -HSpeed
                hit = True
            End If
        End If

        If hit Then


            hitcount += 1

            If hitcount = cols * rows Then
                ' Level Complete
                'Dim counterA As Integer
                hitcount = 0
                level += 1
                tmrLevelCheck.Enabled = True
                lblPause.SendToBack()
                lblPause.Text = "Level " & level
                lblPause.Visible = True
                paddle.Location = New Point(132, 507)


                'lblPlayAgain.Text = "Continue"
                MakeBricks()
            End If



            'If brickbreakcount > 0 Then

            'brickbreakcount -= 1
            'Else


            Bricks.Text -= 1

            If Bricks.Text = 0 Then
                Bricks.Visible = False
            End If


            'End If


            Score += Bricks.Tag * Multiplier * level

        End If


    End Sub
    Private Sub MakeBricks()
        ' Change Levels
        If level = 1 Then

            rows = 3 ' 8
            cols = 3 ' 10

        ElseIf level = 2 Then

            rows = 4
            cols = 6
        ElseIf level = 3 Then

            rows = 6
            cols = 8
        ElseIf level = 4 Then

            rows = 7
            cols = 8
        ElseIf level = 5 Then

            rows = 8
            cols = 10
        ElseIf level = 6 Then

            rows = 12
            cols = 14
        ElseIf level = 7 Then

            rows = 13
            cols = 15
        ElseIf level = 0 Then

            rows = 1
            cols = 3
        ElseIf level = -2 Then

            rows = 1
            cols = 3
        ElseIf level = -1 Then

            rows = 2
            cols = 3
        End If

        ' Take out bricks

        For i As Integer = Me.Controls.Count - 1 To 0 Step -1

            If Me.Controls(i).Name = "brick" Then

                Me.Controls.RemoveAt(i)

            End If





        Next


        For R As Integer = 0 To rows - 1

            For C As Integer = 0 To cols - 1

                'Dim B As Image
                Dim b As New Button
                Me.Controls.Add(b)
                b.Visible = True
                b.Tag = rows - R

                b.Width = Me.ClientRectangle.Width / cols
                b.Height = Me.ClientRectangle.Height * RowHeight
                b.Left = C * b.Width
                b.Top = Me.ClientRectangle.Height * (TopRow + R * RowHeight)
                'b.BackColor = Color.Red
                b.TabStop = True
                b.Enabled = False
                b.Name = "brick"
                b.Text = "3"
                'b.ForeColor = b.BackColor
                'ball.BackColor = b.BackColor
                'ball.Parent = b
                'b.Text = b.Tag
                'b.Text = "BRICK"
                'b.ForeColor = Color.Cyan
                b.ForeColor = Color.Yellow

                If (R + C) Mod 2 = 0 Then

                    b.BackColor = Color.Lime ' Red
                    b.ForeColor = b.BackColor
                    'b.BackColor = Color.Transparent

                Else

                    b.BackColor = Color.Red ' White
                    b.ForeColor = b.BackColor

                    ' b.BackColor = Color.Transparent
                End If
                b.FlatStyle = FlatStyle.Flat
            Next

        Next


        With ball
            .Left = Me.ClientRectangle.Width / 2
            .Top = Me.ClientRectangle.Height * 0.9
            VSpeed = -3
            HSpeed = 1

        End With

        ballMover.Enabled = True

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Bricks
        'MakeBricks()

        If IO.File.Exists(Application.ExecutablePath & "\Updater.exe") Then

            IO.File.Delete(Application.ExecutablePath & "\Updater.exe")

        End If

        Play()
        ballMover.Enabled = False
        'AxWindowsMediaPlayer1.Ctlcontrols.play()
        'AxWindowsMediaPlayer1.Ctlcontrols.stop()
        WebBrowser1.Parent = Panel1

    End Sub
    Private Sub Play()

        If InGame = False Then

            ballMover.Enabled = False
            ball.Visible = False
            paddle.Visible = False
            'lblScore.Visible = False
            lblScore.BringToFront()
            tmrScore.Enabled = False
        Else
            level = 1
            ballMover.Enabled = True
            MakeBricks()
            ball.Visible = True
            paddle.Visible = True
            lblScore.Visible = True
            lblPlay.Visible = False
            lblSettings.Visible = False
            lblTitle.Visible = False
            lblHighScore.Visible = False
            lblPlayAgain.Visible = False
            lblClear.Visible = False
            Score = 0
            Seconds = 0
            hitcount = 0
            paddle.Location = New Point(132, 507)
            tmrScore.Enabled = True
            Panel1.Visible = False
            Panel1.Enabled = False
            'lblPause.Visible = False
            Me.Focus()
        End If

    End Sub
    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        MakeBricks()
        Score = 0
    End Sub

    Private Sub lblPlay_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblPlay.Click
        InGame = True
        Play()
        txtHighScore.Visible = False
        lblHitHighscore.Visible = False
        lblName.Visible = False
        txtHighScore.Enabled = False
        lblClear.Visible = False
    End Sub
    Private Sub HighScore(ByVal PlayerName As String, ByVal PlayerScore As String)
        'PlayerName.Replace(Space(1), "%20")
        If PlayerScore = "-1" And PlayerName = "-1" Then

            ' Do Nothing
            '  MsgBox("Just Checking")
            lblPlayAgain.Text = "Go Back"
            'lblClear.Visible = True
            '  lblClear.BringToFront()
        Else



            'Website is DEAD. RiP
            'WebBrowser1.Navigate("brickbreaker.99k.org/?user=" & Replace(PlayerName, " ", "") & "&time=" & Seconds & "&score=" & PlayerScore & "&level=" & level)
            'WebBrowser1.Navigate("brickbreaker.99k.org")
            lblPlayAgain.Text = "PLAY AGAIN"
        End If

        'WebBrowser1.Navigate("localhost/highscore/?user=" & PlayerName & "&time=" & Seconds & "&score=" & PlayerScore & "&level=" & level)




        'WebBrowser1.Parent = paddle



        lblPlayAgain.Visible = True
        lblPlayAgain.BringToFront()
        lblPlayAgain.BringToFront()

        'If PlayerScore > My.Settings.Player1Score And PlayerScore Then

        '    ' Player Has the highest Score
        '    My.Settings.Player5Score = My.Settings.Player4Score
        '    My.Settings.Player5Name = My.Settings.Player4Name
        '    My.Settings.Player4Score = My.Settings.Player3Score
        '    My.Settings.Player4Name = My.Settings.Player3Name
        '    My.Settings.Player3Score = My.Settings.Player2Score
        '    My.Settings.Player3Name = My.Settings.Player2Name
        '    My.Settings.Player2Score = My.Settings.Player1Score
        '    My.Settings.Player2Name = My.Settings.Player1Name
        '    My.Settings.Player1Score = PlayerScore
        '    My.Settings.Player1Name = PlayerName
        '    My.Settings.Save()

        'ElseIf PlayerScore > My.Settings.Player2Score And PlayerScore < My.Settings.Player1Score Then

        '    'Player Has the Second Highest Score
        '    My.Settings.Player5Score = My.Settings.Player4Score
        '    My.Settings.Player5Name = My.Settings.Player4Name
        '    My.Settings.Player4Score = My.Settings.Player3Score
        '    My.Settings.Player4Name = My.Settings.Player3Name
        '    My.Settings.Player3Score = My.Settings.Player2Score
        '    My.Settings.Player3Name = My.Settings.Player2Name
        '    My.Settings.Player2Score = PlayerScore
        '    My.Settings.Player2Name = PlayerName
        '    My.Settings.Save()

        'ElseIf PlayerScore > My.Settings.Player3Score And PlayerScore < My.Settings.Player2Score Then

        '    'Player Has Third Highest Score
        '    My.Settings.Player5Score = My.Settings.Player4Score
        '    My.Settings.Player5Name = My.Settings.Player4Name
        '    My.Settings.Player4Score = My.Settings.Player3Score
        '    My.Settings.Player4Name = My.Settings.Player3Name
        '    My.Settings.Player3Score = PlayerScore
        '    My.Settings.Player3Name = PlayerName
        '    My.Settings.Save()

        'ElseIf PlayerScore > My.Settings.Player4Score And PlayerScore < My.Settings.Player3Score Then

        '    ' Player has Fourth Highest Score
        '    My.Settings.Player5Score = My.Settings.Player4Score
        '    My.Settings.Player5Name = My.Settings.Player4Name
        '    My.Settings.Player4Score = PlayerScore
        '    My.Settings.Player4Name = PlayerName
        '    My.Settings.Save()

        'ElseIf PlayerScore > My.Settings.Player5Score And PlayerScore < My.Settings.Player4Score Then

        '    ' Player has the fifth highest score
        '    My.Settings.Player5Score = PlayerScore
        '    My.Settings.Player5Name = PlayerName
        '    My.Settings.Save()

        'End If

        'Highscores.Text = "HighScores" & vbNewLine & vbNewLine & vbNewLine & vbNewLine &
        'My.Settings.Player1Name & Space(7) & "-" & Space(7) & My.Settings.Player1Score & vbNewLine &
        'My.Settings.Player2Name & Space(7) & "-" & Space(7) & My.Settings.Player2Score & vbNewLine &
        'My.Settings.Player3Name & Space(7) & "-" & Space(7) & My.Settings.Player3Score & vbNewLine &
        'My.Settings.Player4Name & Space(7) & "-" & Space(7) & My.Settings.Player4Score & vbNewLine &
        'My.Settings.Player5Name & Space(7) & "-" & Space(7) & My.Settings.Player5Score & vbNewLine


        'lblClear.Visible = True
        'lblClear.BringToFront()
        'lblClear.BringToFront()
    End Sub
    Private Sub lblHighScore_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblHighScore.Click

        ' Loads a Label with Current HighsCores

        'Highscores.Visible = True
        'Highscores.BringToFront()
        HighScore("-1", "-1")
        Panel1.Visible = True
        'WebBrowser1.Visible = True

        'lblPlayAgain.Text = "PLAY AGAIN"
        'MsgBox("Disabled.", MsgBoxStyle.OkOnly, "Brick Breaker")
    End Sub
    Private Sub lblSettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblSettings.Click

        If lblSettings.Text = "Submit Score" Then

            HighScore(txtHighScore.Text, Score)
            'Highscores.Visible = True
            'Highscores.BringToFront()
            Panel1.Visible = True
            'WebBrowser1.Visible = True
            lblPlayAgain.Visible = True
            lblPlayAgain.BringToFront()
            lblPlayAgain.BringToFront()
            txtHighScore.Enabled = False
            lblSettings.Visible = False
            lblPlay.Visible = False
        Else
            'Settings
            MsgBox("Disabled.", MsgBoxStyle.OkOnly, "Brick Breaker")


        End If



    End Sub

    Private Sub Form1_LostFocus(ByVal sender As Object, ByVal e As EventArgs) Handles Me.LostFocus

        If InGame = True Then
            tmrScore.Enabled = False
            ballMover.Enabled = False
            lblPause.Visible = True
            lblPause.BringToFront()
            lblScore.Visible = True
            lblScore.BringToFront()
        End If
    End Sub

    Private Sub lblPause_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblPause.Click

    End Sub

    Private Sub lblPlayAgain_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblPlayAgain.Click

        If lblPlayAgain.Text = "Go Back" Then
            txtHighScore.Visible = False
            lblHitHighscore.Visible = False
            lblName.Visible = False
            'Highscores.Visible = False
            Panel1.Visible = False
            'WebBrowser1.Visible = False
            txtHighScore.Enabled = False

            lblPlayAgain.Visible = False
            lblClear.Visible = False
            'ElseIf lblPlayAgain.Text = "Continue" Then

            ' MakeBricks()
            'lblPlayAgain.Text = "PLAY AGAIN"

        Else
            InGame = True
            Play()
            txtHighScore.Visible = False
            lblHitHighscore.Visible = False
            lblName.Visible = False
            Highscores.Visible = False
            txtHighScore.Enabled = False
            'paddle.Focus()
            level = 1
        End If

    End Sub

    'Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

    ' End Sub

    'Private Sub AxWindowsMediaPlayer1_StatusChange(ByVal sender As Object, ByVal e As EventArgs) Handles AxWindowsMediaPlayer1.StatusChange
    ' If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then



    'AxWindowsMediaPlayer1.Ctlcontrols.play()
    ' End If
    ' End Sub

    Private Sub tmrScore_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrScore.Tick
        Seconds += 1

        'Seconds to mins conversion
        ts = TimeSpan.FromSeconds(Seconds)
        h = ts.Hours.ToString
        m = ts.Minutes.ToString
        s = ts.Seconds.ToString



        If Seconds < 60 And Seconds > 0 Then

            Multiplier = 15

        ElseIf Seconds < 180 And Seconds > 61 Then

            Multiplier = 12

        ElseIf Seconds < 480 And Seconds > 181 Then

            Multiplier = 8

        ElseIf Seconds > 481 Then
            'Seconds < 720
            Multiplier = 1

        End If

        ' Seconds to Minutes to Second Conversion


    End Sub

    Private Sub lblClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClear.Click
        My.Settings.Player1Name = "User 1"
        My.Settings.Player1Score = "0"
        My.Settings.Player2Name = "User 2"
        My.Settings.Player2Score = "0"
        My.Settings.Player3Score = "0"
        My.Settings.Player3Name = "User 3"
        My.Settings.Player4Name = "User 4"
        My.Settings.Player4Score = "0"
        My.Settings.Player5Score = "0"
        My.Settings.Player5Name = "User 5"
        My.Settings.Save()
        MsgBox("Highscores Cleared Successfully", MsgBoxStyle.Information, "Highscores")
        HighScore("-1", "-1")
    End Sub

    Private Sub tmrLevelCheck_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLevelCheck.Tick
        'If level = 1 Then

        '    rows = 8
        '    cols = 10

        'ElseIf level = 2 Then

        '    rows = 10
        '    cols = 12
        'ElseIf level = 3 Then

        '    rows = 12
        '    cols = 14
        'ElseIf level = 0 Then

        '    rows = 1
        '    cols = 3
        'End If

        counterA += 1

        If counterA > 1 Then

            lblPause.Text = "Paused"
            'lblPause.SendToBack()
            lblPause.Visible = False
            tmrLevelCheck.Enabled = False
            counterA = 0


        End If


    End Sub

    Private Sub tmrBonuses_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBonuses.Tick

        'Random Bonuses
        Dim r As New Random
        Dim x As Integer = r.Next(13, 69)
        'MsgBox(x) ' 34 43 15 67 23 36
        'Dim x As Integer = 43
        If x = 34 Or x = 43 Or x = 15 Or x = 67 Or x = 23 Or x = 36 Then
            ' 34 = Long Paddle
            ' 43 = Multiple Balls
            ' 15 = Catch The Ball
            ' 67 = Short Paddle
            ' 23 = Slow Ball
            ' 36 = Fast Ball
            'MsgBox(x)


            ' Long Paddle
            If x = 34 Then
                bonustime += 1

                If bonustime < 5 Then

                    longpaddle = True
                    paddle.Width = 260

                ElseIf bonustime > 5 Then

                    longpaddle = False
                    paddle.Width = 130
                    bonustime = 0
                End If
            End If

            ' Multiple Balls
            If x = 43 Then
                bonustime += 1

                If bonustime < 5 Then
                    MsgBox("Multiple Balls")
                    ' Do it

                ElseIf bonustime > 5 Then

                    ' Stop It
                    MsgBox("Multiple Balls Stop")
                    bonustime = 0

                End If


            End If



        End If

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        'paddle.Focus()
        'WebBrowser1.Navigate("brickbreaker.99k.org")
        Me.Focus()
    End Sub

    Private Sub tmrUpdateChecker_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUpdateChecker.Tick
        Dim wc As WebClient = New WebClient
        Dim address As String = "https://dl.dropboxusercontent.com/u/22655120/BrickBreaker/version.txt"
        Dim WebVersion As String = wc.DownloadString(address)

        If Not WebVersion = My.Application.Info.Version.ToString Then

            ' An Update is Required
            tmrUpdateChecker.Enabled = False
            Form2.Show()
            'WebC.DownloadFileAsync(New Uri("https://dl.dropboxusercontent.com/u/22655120/BrickBreaker/updater.exe"), "C:\BBUpdate\updater.exe")


        End If

        tmrUpdateChecker.Enabled = False

        ' MsgBox(My.Application.Info.DirectoryPath & "\" & My.Application.Info.ProductName)
        'MsgBox(Application.ExecutablePath)
    End Sub
    'Private Sub WC_DownloadComplete(ByVal sender As Object, ByVal e As DownloadDataCompletedEventArgs) Handles WebC.DownloadFileCompleted

    '   Process.Start("C:\BBUpdate\updater.exe")

    'End Sub

    Private Sub Form1_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Move
        ' Form2.Location = Me.Location
    End Sub

    Private Sub tmrForm2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrForm2.Tick
        If Form2.Visible Then

            Me.Enabled = False


        Else

            Me.Enabled = True

        End If
    End Sub
End Class
