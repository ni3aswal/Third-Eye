Imports System.IO

Public Class main
    Public a, b, c, d, f, g As String
    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        My.Computer.Audio.Stop()
        Me.Hide()
        If TextBox1.Text = String.Empty Or TextBox1.Text = "" Or TextBox1.Text.Length <= 0 Then
            TextBox1.Clear()
            My.Computer.Audio.Play(Application.StartupPath + "\audio\langwrong.wav", AudioPlayMode.Background)
            Me.Show()
        ElseIf TextBox1.Text = 1 Then
            TextBox1.Clear()
            engmenu.Show()
        ElseIf TextBox1.Text = 2 Then
            TextBox1.Clear()
            hinmenu.Show()
        ElseIf TextBox1.Text = 3 Then
            TextBox1.Clear()
            maramenu.Show()
        ElseIf TextBox1.Text = 4 Then
            Me.Show()
            TextBox1.Clear()
            My.Computer.Audio.Play(Application.StartupPath + "\audio\manual.wav", AudioPlayMode.Background)
        Else
            TextBox1.Clear()
            My.Computer.Audio.Play(Application.StartupPath + "\audio\langwrong.wav", AudioPlayMode.Background)
            Me.Show()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\") Then
            If (My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\english\") And
                My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\hindi\") And
                My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\marathi\")) Then

                If (My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\english\news") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\english\music\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\english\radio\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\english\stories\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\english\jokes\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\english\book\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\english\document\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\english\interview\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\english\cricket\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\hindi\news") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\hindi\music\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\hindi\radio\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\hindi\stories\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\hindi\jokes\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\hindi\book\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\hindi\document\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\hindi\interview\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\hindi\cricket\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\marathi\news") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\marathi\music\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\marathi\radio\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\marathi\stories\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\marathi\jokes\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\marathi\book\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\marathi\document\") And
                    My.Computer.FileSystem.DirectoryExists(Application.StartupPath + "\\third eye\marathi\interview\")) Then
                Else
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\news")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\music")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\radio")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\stories")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\jokes")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\book")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\document")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\interview")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\cricket")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\news")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\music")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\radio")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\stories")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\jokes")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\book")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\document")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\interview")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\cricket")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\news")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\music")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\radio")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\stories")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\jokes")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\book")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\document")
                    My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\interview")
                End If
            Else
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\news")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\music")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\radio")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\stories")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\jokes")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\book")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\document")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\interview")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\cricket")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\news")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\music")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\radio")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\stories")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\jokes")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\book")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\document")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\interview")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\cricket")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\news")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\music")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\radio")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\stories")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\jokes")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\book")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\document")
                My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\interview")
            End If
        Else
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\news")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\music")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\radio")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\stories")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\jokes")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\book")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\document")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\interview")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\english\cricket")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\news")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\music")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\radio")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\stories")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\jokes")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\book")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\document")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\interview")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\hindi\cricket")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\news")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\music")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\radio")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\stories")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\jokes")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\book")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\document")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\\third eye\marathi\interview")
        End If

        If (File.Exists(Application.StartupPath + "\\third eye\english\news\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\news\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\news\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\news\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\news\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\news\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\music\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\music\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\music\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\music\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\music\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\music\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\radio\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\radio\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\radio\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\radio\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\radio\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\radio\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\stories\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\stories\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\stories\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\stories\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\stories\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\stories\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\jokes\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\jokes\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\jokes\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\jokes\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\jokes\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\jokes\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\book\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\book\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\book\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\book\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\book\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\book\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\document\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\document\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\document\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\document\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\document\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\document\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\interview\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\interview\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\interview\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\interview\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\interview\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\interview\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\cricket\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\cricket\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\cricket\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\cricket\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\cricket\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\english\cricket\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\news\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\news\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\news\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\news\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\news\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\news\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\music\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\music\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\music\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\music\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\music\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\music\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\radio\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\radio\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\radio\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\radio\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\radio\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\radio\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\stories\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\stories\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\stories\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\stories\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\stories\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\stories\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\jokes\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\jokes\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\jokes\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\jokes\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\jokes\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\jokes\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\book\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\book\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\book\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\book\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\book\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\book\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\document\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\document\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\document\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\document\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\document\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\document\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\interview\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\interview\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\interview\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\interview\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\interview\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\interview\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\cricket\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\cricket\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\cricket\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\cricket\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\cricket\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\hindi\cricket\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\news\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\news\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\news\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\news\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\news\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\news\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\music\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\music\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\music\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\music\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\music\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\music\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\radio\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\radio\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\radio\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\radio\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\radio\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\radio\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\stories\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\stories\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\stories\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\stories\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\stories\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\stories\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\jokes\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\jokes\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\jokes\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\jokes\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\jokes\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\jokes\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\book\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\book\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\book\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\book\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\book\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\book\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\document\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\document\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\document\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\document\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\document\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\document\6.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\interview\1.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\interview\2.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\interview\3.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\interview\4.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\interview\5.txt") And
            File.Exists(Application.StartupPath + "\\third eye\marathi\interview\6.txt")) Then
        Else
            File.Create(Application.StartupPath + "\\third eye\english\news\1.txt")
            File.Create(Application.StartupPath + "\\third eye\english\news\2.txt")
            File.Create(Application.StartupPath + "\\third eye\english\news\3.txt")
            File.Create(Application.StartupPath + "\\third eye\english\news\4.txt")
            File.Create(Application.StartupPath + "\\third eye\english\news\5.txt")
            File.Create(Application.StartupPath + "\\third eye\english\news\6.txt")
            File.Create(Application.StartupPath + "\\third eye\english\music\1.txt")
            File.Create(Application.StartupPath + "\\third eye\english\music\2.txt")
            File.Create(Application.StartupPath + "\\third eye\english\music\3.txt")
            File.Create(Application.StartupPath + "\\third eye\english\music\4.txt")
            File.Create(Application.StartupPath + "\\third eye\english\music\5.txt")
            File.Create(Application.StartupPath + "\\third eye\english\music\6.txt")
            File.Create(Application.StartupPath + "\\third eye\english\radio\1.txt")
            File.Create(Application.StartupPath + "\\third eye\english\radio\2.txt")
            File.Create(Application.StartupPath + "\\third eye\english\radio\3.txt")
            File.Create(Application.StartupPath + "\\third eye\english\radio\4.txt")
            File.Create(Application.StartupPath + "\\third eye\english\radio\5.txt")
            File.Create(Application.StartupPath + "\\third eye\english\radio\6.txt")
            File.Create(Application.StartupPath + "\\third eye\english\stories\1.txt")
            File.Create(Application.StartupPath + "\\third eye\english\stories\2.txt")
            File.Create(Application.StartupPath + "\\third eye\english\stories\3.txt")
            File.Create(Application.StartupPath + "\\third eye\english\stories\4.txt")
            File.Create(Application.StartupPath + "\\third eye\english\stories\5.txt")
            File.Create(Application.StartupPath + "\\third eye\english\stories\6.txt")
            File.Create(Application.StartupPath + "\\third eye\english\jokes\1.txt")
            File.Create(Application.StartupPath + "\\third eye\english\jokes\2.txt")
            File.Create(Application.StartupPath + "\\third eye\english\jokes\3.txt")
            File.Create(Application.StartupPath + "\\third eye\english\jokes\4.txt")
            File.Create(Application.StartupPath + "\\third eye\english\jokes\5.txt")
            File.Create(Application.StartupPath + "\\third eye\english\jokes\6.txt")
            File.Create(Application.StartupPath + "\\third eye\english\book\1.txt")
            File.Create(Application.StartupPath + "\\third eye\english\book\2.txt")
            File.Create(Application.StartupPath + "\\third eye\english\book\3.txt")
            File.Create(Application.StartupPath + "\\third eye\english\book\4.txt")
            File.Create(Application.StartupPath + "\\third eye\english\book\5.txt")
            File.Create(Application.StartupPath + "\\third eye\english\book\6.txt")
            File.Create(Application.StartupPath + "\\third eye\english\document\1.txt")
            File.Create(Application.StartupPath + "\\third eye\english\document\2.txt")
            File.Create(Application.StartupPath + "\\third eye\english\document\3.txt")
            File.Create(Application.StartupPath + "\\third eye\english\document\4.txt")
            File.Create(Application.StartupPath + "\\third eye\english\document\5.txt")
            File.Create(Application.StartupPath + "\\third eye\english\document\6.txt")
            File.Create(Application.StartupPath + "\\third eye\english\interview\1.txt")
            File.Create(Application.StartupPath + "\\third eye\english\interview\2.txt")
            File.Create(Application.StartupPath + "\\third eye\english\interview\3.txt")
            File.Create(Application.StartupPath + "\\third eye\english\interview\4.txt")
            File.Create(Application.StartupPath + "\\third eye\english\interview\5.txt")
            File.Create(Application.StartupPath + "\\third eye\english\interview\6.txt")
            File.Create(Application.StartupPath + "\\third eye\english\cricket\1.txt")
            File.Create(Application.StartupPath + "\\third eye\english\cricket\2.txt")
            File.Create(Application.StartupPath + "\\third eye\english\cricket\3.txt")
            File.Create(Application.StartupPath + "\\third eye\english\cricket\4.txt")
            File.Create(Application.StartupPath + "\\third eye\english\cricket\5.txt")
            File.Create(Application.StartupPath + "\\third eye\english\cricket\6.txt")

            File.Create(Application.StartupPath + "\\third eye\hindi\news\1.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\news\2.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\news\3.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\news\4.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\news\5.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\news\6.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\music\1.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\music\2.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\music\3.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\music\4.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\music\5.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\music\6.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\radio\1.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\radio\2.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\radio\3.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\radio\4.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\radio\5.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\radio\6.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\stories\1.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\stories\2.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\stories\3.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\stories\4.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\stories\5.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\stories\6.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\jokes\1.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\jokes\2.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\jokes\3.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\jokes\4.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\jokes\5.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\jokes\6.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\book\1.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\book\2.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\book\3.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\book\4.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\book\5.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\book\6.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\document\1.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\document\2.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\document\3.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\document\4.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\document\5.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\document\6.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\interview\1.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\interview\2.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\interview\3.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\interview\4.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\interview\5.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\interview\6.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\cricket\1.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\cricket\2.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\cricket\3.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\cricket\4.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\cricket\5.txt")
            File.Create(Application.StartupPath + "\\third eye\hindi\cricket\6.txt")

            File.Create(Application.StartupPath + "\\third eye\marathi\news\1.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\news\2.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\news\3.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\news\4.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\news\5.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\news\6.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\music\1.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\music\2.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\music\3.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\music\4.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\music\5.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\music\6.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\radio\1.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\radio\2.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\radio\3.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\radio\4.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\radio\5.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\radio\6.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\stories\1.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\stories\2.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\stories\3.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\stories\4.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\stories\5.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\stories\6.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\jokes\1.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\jokes\2.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\jokes\3.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\jokes\4.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\jokes\5.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\jokes\6.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\book\1.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\book\2.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\book\3.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\book\4.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\book\5.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\book\6.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\document\1.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\document\2.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\document\3.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\document\4.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\document\5.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\document\6.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\interview\1.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\interview\2.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\interview\3.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\interview\4.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\interview\5.txt")
            File.Create(Application.StartupPath + "\\third eye\marathi\interview\6.txt")
        End If
        My.Computer.Audio.Play(Application.StartupPath + "\audio\main.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Stop()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.AcceptButton = submit
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

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        My.Computer.Audio.Stop()
        admin.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Stop()
        About.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Stop()
        help.Show()
    End Sub
End Class
