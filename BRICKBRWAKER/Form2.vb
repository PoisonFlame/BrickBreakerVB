Imports System.Net
Public Class Form2
    Dim WithEvents wc As WebClient = New WebClient
    Dim WithEvents wc2 As WebClient = New WebClient
    Dim Cry As Boolean = False

    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'If Cry = False Then

        '    e.Cancel = True

        'Else

        '    e.Cancel = False

        'End If

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Parent = Form1
        ' My.Computer.Network.DownloadFile("https://dl.dropboxusercontent.com/u/22655120/BrickBreaker/brickbreaker.exe", My.Computer.FileSystem.CurrentDirectory)
        Form1.Enabled = False

        'wc.DownloadFileAsync(New Uri("http://dl.dropboxusercontent.com/u/22655120/BrickBreaker/brickbreaker.exe"), Application.StartupPath & "\BrickBreakerNew.exe")

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = ProgressBar1.Value & " %"

        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            MsgBox("Application Restarting To Finish Updating")

            wc2.DownloadFileAsync(New Uri("https://dl.dropboxusercontent.com/u/22655120/BrickBreaker/Updater.exe"), Application.StartupPath & "\Updater.exe")

            'If wc2.IsBusy = False Then

            '    Process.Start(Application.StartupPath & "\Updater.exe")
            '    Cry = True
            '    Application.Exit()
            'End If

            'Process.Start(Application.StartupPath & "\BrickBreakerNew.exe")

        End If



    End Sub
    Private Sub WC_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles wc.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub
    Private Sub WC2_DownloadProgressCompleted(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles wc2.DownloadProgressChanged
        If e.ProgressPercentage = 100 Then
            Process.Start(Application.StartupPath & "\Updater.exe")
            '  Cry = True
            Application.Exit()
            Me.Close()
            Form1.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim url As Uri = New Uri("https://dl.dropboxusercontent.com/u/22655120/BrickBreaker/brickbreaker.exe")

        If IO.File.Exists(Application.StartupPath & "\BrickBreakerNew.exe") Then

            IO.File.Delete(Application.StartupPath & "\BrickBreakerNew.exe")

        End If

        wc.DownloadFileAsync(url, Application.StartupPath & "\BrickBreakerNew.exe")
        ' wc2.DownloadFileAsync(New Uri("https://dl.dropboxusercontent.com/u/22655120/BrickBreaker/Updater.exe"), Application.StartupPath & "\Updater.exe")
        'Process.Start("https://dl.dropboxusercontent.com/u/22655120/BrickBreaker/brickbreaker.exe")
        'MsgBox(Application.StartupPath & "\BrickBreakerNew.exe")


    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        Button1.PerformClick()
    End Sub
End Class