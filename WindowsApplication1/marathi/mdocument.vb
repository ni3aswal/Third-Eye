Imports System.IO

Public Class mdocument
    Public a, b, c, d, f, g As String
    Private Sub mdocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(Application.StartupPath + "\audio\marathi\mdoc.wav", AudioPlayMode.BackgroundLoop)
        AxWindowsMediaPlayer1.Hide()
        a = File.ReadAllText(Application.StartupPath + "\\third eye\marathi\document\1.txt")
        b = File.ReadAllText(Application.StartupPath + "\\third eye\marathi\document\2.txt")
        c = File.ReadAllText(Application.StartupPath + "\\third eye\marathi\document\3.txt")
        d = File.ReadAllText(Application.StartupPath + "\\third eye\marathi\document\4.txt")
        f = File.ReadAllText(Application.StartupPath + "\\third eye\marathi\document\5.txt")
        g = File.ReadAllText(Application.StartupPath + "\\third eye\marathi\document\6.txt")
    End Sub
    Private Sub mdocument_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
        If My.Computer.Network.IsAvailable Then
            maramenu.Show()
            My.Computer.Audio.Play(Application.StartupPath + "\audio\marathi\mon.wav", AudioPlayMode.BackgroundLoop)
        Else
            maramenu.Show()
            My.Computer.Audio.Play(Application.StartupPath + "\audio\marathi\moff.wav", AudioPlayMode.BackgroundLoop)
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
                maramenu.Show()
                My.Computer.Audio.Play(Application.StartupPath + "\audio\marathi\mon.wav", AudioPlayMode.BackgroundLoop)
            Else
                maramenu.Show()
                My.Computer.Audio.Play(Application.StartupPath + "\audio\marathi\moff.wav", AudioPlayMode.BackgroundLoop)
            End If
        Else
            TextBox1.Clear()
            My.Computer.Audio.Play(Application.StartupPath + "\audio\marathi\mwrong.wav", AudioPlayMode.Background)
            Me.Show()
        End If
    End Sub
End Class