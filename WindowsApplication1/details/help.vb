Public Class help

    Private Sub help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(Application.StartupPath + "\audio\manual.wav", AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        Me.Close()
        My.Computer.Audio.Play(Application.StartupPath + "\audio\main.wav", AudioPlayMode.BackgroundLoop)
    End Sub
End Class