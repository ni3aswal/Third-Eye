Imports System.IO

Public Class enews
    Public a, b, c, d, f, g As String
    Private Sub enews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(Application.StartupPath + "\audio\english\enews.wav", AudioPlayMode.BackgroundLoop)
        AxWindowsMediaPlayer1.Hide()
        a = File.ReadAllText(Application.StartupPath + "\\third eye\english\news\1.txt")
        b = File.ReadAllText(Application.StartupPath + "\\third eye\english\news\2.txt")
        c = File.ReadAllText(Application.StartupPath + "\\third eye\english\news\3.txt")
        d = File.ReadAllText(Application.StartupPath + "\\third eye\english\news\4.txt")
        f = File.ReadAllText(Application.StartupPath + "\\third eye\english\news\5.txt")
        g = File.ReadAllText(Application.StartupPath + "\\third eye\english\news\6.txt")
    End Sub
    Private Sub enews_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
        If My.Computer.Network.IsAvailable Then
            engmenu.Show()
            My.Computer.Audio.Play(Application.StartupPath + "\audio\english\eon.wav", AudioPlayMode.BackgroundLoop)
        Else
            engmenu.Show()
            My.Computer.Audio.Play(Application.StartupPath + "\audio\english\eoff.wav", AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.AcceptButton = Button1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        AxWindowsMediaPlayer1.Show()
        If TextBox1.Text = 1 Then
            TextBox1.Clear()
            AxWindowsMediaPlayer1.URL = a
        ElseIf TextBox1.Text = 2 Then
            TextBox1.Clear()
            AxWindowsMediaPlayer1.URL = b
        ElseIf TextBox1.Text = 3 Then
            TextBox1.Clear()
            AxWindowsMediaPlayer1.URL = c
        ElseIf TextBox1.Text = 4 Then
            TextBox1.Clear()
            AxWindowsMediaPlayer1.URL = d
        ElseIf TextBox1.Text = 5 Then
            TextBox1.Clear()
            AxWindowsMediaPlayer1.URL = f
        ElseIf TextBox1.Text = 6 Then
            TextBox1.Clear()
            AxWindowsMediaPlayer1.URL = g
        ElseIf TextBox1.Text = 7 Then
            TextBox1.Clear()
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        ElseIf TextBox1.Text = 8 Then
            TextBox1.Clear()
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
        ElseIf TextBox1.Text = 9 Then
            TextBox1.Clear()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        ElseIf TextBox1.Text = 0 Then
            TextBox1.Clear()
            Me.Close()
            If My.Computer.Network.IsAvailable Then
                engmenu.Show()
                My.Computer.Audio.Play(Application.StartupPath + "\audio\english\eon.wav", AudioPlayMode.BackgroundLoop)
            Else
                engmenu.Show()
                My.Computer.Audio.Play(Application.StartupPath + "\audio\english\eoff.wav", AudioPlayMode.BackgroundLoop)
            End If
        Else
            TextBox1.Clear()
            My.Computer.Audio.Play(Application.StartupPath + "\audio\english\ewrong.wav", AudioPlayMode.Background)
            Me.Show()
        End If
    End Sub
End Class