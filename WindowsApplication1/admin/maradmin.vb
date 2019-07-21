
Public Class maradmin
    Private Sub maradmin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        admin.Show()
    End Sub
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
        admin.Show()
    End Sub

    Private Sub radio_Click(sender As Object, e As EventArgs) Handles Radio.Click
        mradioset.Show()
    End Sub

    Private Sub maradmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub News_Click(sender As Object, e As EventArgs) Handles News.Click
        mnewsset.Show()
    End Sub

    Private Sub Music_Click(sender As Object, e As EventArgs) Handles Music.Click
        mmusicset.Show()
    End Sub

    Private Sub Stories_Click(sender As Object, e As EventArgs) Handles Stories.Click
        mstoryset.Show()
    End Sub

    Private Sub Jokes_Click(sender As Object, e As EventArgs) Handles Jokes.Click
        mjokesset.Show()
    End Sub

    Private Sub Book_Click(sender As Object, e As EventArgs) Handles Book.Click
        mbookset.Show()
    End Sub

    Private Sub Document_Click(sender As Object, e As EventArgs) Handles Document.Click
        mdocumentset.Show()
    End Sub

    Private Sub Interview_Click(sender As Object, e As EventArgs) Handles Interview.Click
        minterviewset.Show()
    End Sub
End Class