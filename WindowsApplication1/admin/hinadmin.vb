
Public Class hinadmin
    Private Sub hinadmin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        admin.Show()
    End Sub
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
        admin.Show()
    End Sub

    Private Sub radio_Click(sender As Object, e As EventArgs) Handles Radio.Click
        hradioset.Show()
    End Sub

    Private Sub hinadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub News_Click(sender As Object, e As EventArgs) Handles News.Click
        hnewsset.Show()
    End Sub

    Private Sub Music_Click(sender As Object, e As EventArgs) Handles Music.Click
        hmusicset.Show()
    End Sub

    Private Sub Stories_Click(sender As Object, e As EventArgs) Handles Stories.Click
        hstoryset.Show()
    End Sub

    Private Sub Jokes_Click(sender As Object, e As EventArgs) Handles Jokes.Click
        hjokesset.Show()
    End Sub

    Private Sub Book_Click(sender As Object, e As EventArgs) Handles Book.Click
        hbookset.Show()
    End Sub

    Private Sub Document_Click(sender As Object, e As EventArgs) Handles Document.Click
        hdocumentset.Show()
    End Sub

    Private Sub Interview_Click(sender As Object, e As EventArgs) Handles Interview.Click
        hinterviewset.Show()
    End Sub

    Private Sub Cricket_Click(sender As Object, e As EventArgs) Handles Cricket.Click
        hcricketset.Show()
    End Sub
End Class