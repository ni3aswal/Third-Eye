Imports System.IO

Public Class hmusicset
    Private Sub hmusicset_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        hinadmin.Show()
    End Sub
    Private Sub hmusicset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '1
        hmusic.a = File.ReadAllText(Application.StartupPath + "\\third eye\hindi\music\1.txt")
        file1.Text = My.Computer.FileSystem.GetName(hmusic.a)
        '2
        hmusic.b = File.ReadAllText(Application.StartupPath + "\\third eye\hindi\music\2.txt")
        file2.Text = My.Computer.FileSystem.GetName(hmusic.b)
        '3 
        hmusic.c = File.ReadAllText(Application.StartupPath + "\\third eye\hindi\music\3.txt")
        file3.Text = My.Computer.FileSystem.GetName(hmusic.c)
        '4
        hmusic.d = File.ReadAllText(Application.StartupPath + "\\third eye\hindi\music\4.txt")
        file4.Text = My.Computer.FileSystem.GetName(hmusic.d)
        '5
        hmusic.f = File.ReadAllText(Application.StartupPath + "\\third eye\hindi\music\5.txt")
        file5.Text = My.Computer.FileSystem.GetName(hmusic.f)
        '6
        hmusic.g = File.ReadAllText(Application.StartupPath + "\\third eye\hindi\music\6.txt")
        file6.Text = My.Computer.FileSystem.GetName(hmusic.g)

    End Sub

    Private Sub exi_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Close()
        hinadmin.Show()
    End Sub

    Private Sub update1_Click(sender As Object, e As EventArgs) Handles update1.Click
        If TextBox1.Text = String.Empty Or TextBox1.Text = "" Or TextBox1.Text.Length <= 0 Then
            MsgBox("pls give a file path or url")
        Else
            File.WriteAllText(Application.StartupPath + "\\third eye\hindi\music\1.txt", TextBox1.Text)
            hmusic.a = File.ReadAllText(Application.StartupPath + "\\third eye\hindi\music\1.txt")
            MsgBox("Media updated")
            file1.Text = My.Computer.FileSystem.GetName(hmusic.a)
        End If
    End Sub

    Private Sub update2_Click(sender As Object, e As EventArgs) Handles update2.Click
        If TextBox2.Text = String.Empty Or TextBox2.Text = "" Or TextBox2.Text.Length <= 0 Then
            MsgBox("pls give a file path or url")
        Else
            File.WriteAllText(Application.StartupPath + "\\third eye\hindi\music\2.txt", TextBox2.Text)
            hmusic.b = File.ReadAllText(Application.StartupPath + "\\third eye\hindi\music\2.txt")
            MsgBox("Media updated")
            file2.Text = My.Computer.FileSystem.GetName(hmusic.b)
        End If
    End Sub

    Private Sub update3_Click(sender As Object, e As EventArgs) Handles update3.Click
        If TextBox3.Text = String.Empty Or TextBox3.Text = "" Or TextBox3.Text.Length <= 0 Then
            MsgBox("pls give a file path or url")
        Else
            File.WriteAllText(Application.StartupPath + "\\third eye\hindi\music\3.txt", TextBox3.Text)
            hmusic.c = File.ReadAllText(Application.StartupPath + "\\third eye\hindi\music\3.txt")
            MsgBox("Media updated")
            file3.Text = My.Computer.FileSystem.GetName(hmusic.c)
        End If
    End Sub

    Private Sub update4_Click(sender As Object, e As EventArgs) Handles update4.Click
        If TextBox4.Text = String.Empty Or TextBox4.Text = "" Or TextBox4.Text.Length <= 0 Then
            MsgBox("pls give a file path or url")
        Else
            File.WriteAllText(Application.StartupPath + "\\third eye\hindi\music\4.txt", TextBox4.Text)
            hmusic.d = File.ReadAllText(Application.StartupPath + "\\third eye\hindi\music\4.txt")
            MsgBox("Media updated")
            file4.Text = My.Computer.FileSystem.GetName(hmusic.d)
        End If
    End Sub

    Private Sub update5_Click(sender As Object, e As EventArgs) Handles update5.Click
        If TextBox5.Text = String.Empty Or TextBox5.Text = "" Or TextBox5.Text.Length <= 0 Then
            MsgBox("pls give a file path or url")
        Else
            File.WriteAllText(Application.StartupPath + "\\third eye\hindi\music\5.txt", TextBox5.Text)
            hmusic.f = File.ReadAllText(Application.StartupPath + "\\third eye\hindi\music\5.txt")
            MsgBox("Media updated")
            file5.Text = My.Computer.FileSystem.GetName(hmusic.f)
        End If
    End Sub

    Private Sub update6_Click(sender As Object, e As EventArgs) Handles update6.Click
        If TextBox6.Text = String.Empty Or TextBox6.Text = "" Or TextBox6.Text.Length <= 0 Then
            MsgBox("pls give a file path or url")
        Else
            File.WriteAllText(Application.StartupPath + "\\third eye\hindi\music\6.txt", TextBox6.Text)
            hmusic.g = File.ReadAllText(Application.StartupPath + "\\third eye\hindi\music\6.txt")
            MsgBox("Media updated")
            file6.Text = My.Computer.FileSystem.GetName(hmusic.g)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            TextBox1.Text = dialog.FileName
            File.WriteAllText(Application.StartupPath + "\\third eye\hindi\music\1.txt", TextBox1.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            TextBox2.Text = dialog.FileName
            File.WriteAllText(Application.StartupPath + "\\third eye\hindi\music\2.txt", TextBox2.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            TextBox3.Text = dialog.FileName
            File.WriteAllText(Application.StartupPath + "\\third eye\hindi\music\3.txt", TextBox3.Text)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            TextBox4.Text = dialog.FileName
            File.WriteAllText(Application.StartupPath + "\\third eye\hindi\music\4.txt", TextBox4.Text)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            TextBox5.Text = dialog.FileName
            File.WriteAllText(Application.StartupPath + "\\third eye\hindi\music\5.txt", TextBox5.Text)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dialog As New OpenFileDialog()
        If DialogResult.OK = dialog.ShowDialog Then
            TextBox6.Text = dialog.FileName
            File.WriteAllText(Application.StartupPath + "\\third eye\hindi\music\6.txt", TextBox6.Text)
        End If
    End Sub
End Class