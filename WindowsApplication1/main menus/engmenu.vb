Public Class engmenu
    Dim mode As Integer
    Private Sub engmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'audio of offline and online select
        If My.Computer.Network.IsAvailable Then
            'your computer is online you can access all features
            mode = 1
            My.Computer.Audio.Play(Application.StartupPath + "\audio\english\eon.wav", AudioPlayMode.BackgroundLoop)
        Else
            'your computer is offline some features will not work
            mode = 2 'short audio menu for offline
            My.Computer.Audio.Play(Application.StartupPath + "\audio\english\eoff.wav", AudioPlayMode.BackgroundLoop)
        End If

    End Sub
    Private Sub engmenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
        main.Show()
        My.Computer.Audio.Play(Application.StartupPath + "\audio\main.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.AcceptButton = Button1
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        If mode = 1 Then
            If TextBox1.Text = 0 Then
                Me.Close()
                My.Computer.Audio.Stop()
                main.Show()
                My.Computer.Audio.Play(Application.StartupPath + "\audio\main.wav", AudioPlayMode.BackgroundLoop)
            ElseIf TextBox1.Text = String.Empty Or TextBox1.Text = "" Or TextBox1.Text.Length < 0 Then
                TextBox1.Clear()
                My.Computer.Audio.Play(Application.StartupPath + "\audio\english\ewrong.wav", AudioPlayMode.Background)
                Me.Show()
            ElseIf TextBox1.Text = 1 Then
                TextBox1.Clear()
                Me.Hide()
                enews.Show()
            ElseIf TextBox1.Text = 2 Then
                TextBox1.Clear()
                Me.Hide()
                emusic.Show()
            ElseIf TextBox1.Text = 3 Then
                TextBox1.Clear()
                Me.Hide()
                enradio.Show()
            ElseIf TextBox1.Text = 4 Then
                TextBox1.Clear()
                Me.Hide()
                estory.Show()
            ElseIf TextBox1.Text = 5 Then
                TextBox1.Clear()
                Me.Hide()
                ejokes.Show()
            ElseIf TextBox1.Text = 6 Then
                TextBox1.Clear()
                Me.Hide()
                ebook.Show()
            ElseIf TextBox1.Text = 7 Then
                TextBox1.Clear()
                Me.Hide()
                edocument.Show()
            ElseIf TextBox1.Text = 8 Then
                TextBox1.Clear()
                Me.Hide()
                einterview.Show()
            ElseIf TextBox1.Text = 9 Then
                TextBox1.Clear()
                Me.Hide()
                ecricket.Show()
            Else
                TextBox1.Clear()
                My.Computer.Audio.Play(Application.StartupPath + "\audio\english\ewrong.wav", AudioPlayMode.Background)
                Me.Show()
            End If
        Else
            If TextBox1.Text = 0 Then
                Me.Close()
                My.Computer.Audio.Stop()
                main.Show()
                My.Computer.Audio.Play(Application.StartupPath + "\audio\main.wav", AudioPlayMode.BackgroundLoop)
            ElseIf TextBox1.Text = String.Empty Or TextBox1.Text = "" Or TextBox1.Text.Length < 0 Then
                TextBox1.Clear()
                My.Computer.Audio.Play(Application.StartupPath + "\audio\english\ewrong.wav", AudioPlayMode.Background)
                Me.Show()
            ElseIf TextBox1.Text = 1 Then
                TextBox1.Clear()
                Me.Hide()
                emusic.Show()
            ElseIf TextBox1.Text = 2 Then
                TextBox1.Clear()
                Me.Hide()
                estory.Show()
            ElseIf TextBox1.Text = 3 Then
                TextBox1.Clear()
                Me.Hide()
                ejokes.Show()
            ElseIf TextBox1.Text = 4 Then
                TextBox1.Clear()
                Me.Hide()
                ebook.Show()
            ElseIf TextBox1.Text = 5 Then
                TextBox1.Clear()
                Me.Hide()
                edocument.Show()
            ElseIf TextBox1.Text = 6 Then
                TextBox1.Clear()
                Me.Hide()
                einterview.Show()
            Else
                TextBox1.Clear()
                My.Computer.Audio.Play(Application.StartupPath + "\audio\english\ewrong.wav", AudioPlayMode.Background)
                Me.Show()
            End If
        End If
    End Sub
End Class