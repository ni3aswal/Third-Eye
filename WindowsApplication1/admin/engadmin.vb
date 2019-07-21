
Public Class engadmin
    Private Sub engadmin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        admin.Show()
    End Sub
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
        admin.Show()
    End Sub

    Private Sub radio_Click(sender As Object, e As EventArgs) Handles Radio.Click
        enradioset.Show()
    End Sub

    Private Sub engadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub News_Click(sender As Object, e As EventArgs) Handles News.Click
        enewsset.Show()
    End Sub

    Private Sub Music_Click(sender As Object, e As EventArgs) Handles Music.Click
        emusicset.Show()
    End Sub

    Private Sub Stories_Click(sender As Object, e As EventArgs) Handles Stories.Click
        estoryset.Show()
    End Sub
    Private Sub Jokes_Click(sender As Object, e As EventArgs) Handles Jokes.Click
        ejokesset.Show()
    End Sub

    Private Sub Book_Click(sender As Object, e As EventArgs) Handles Book.Click
        ebookset.show()
    End Sub

    Private Sub Document_Click(sender As Object, e As EventArgs) Handles Document.Click
        edocumentset.show()
    End Sub

    Private Sub Interview_Click(sender As Object, e As EventArgs) Handles Interview.Click
        einterviewset.show()
    End Sub

    Private Sub Cricket_Click(sender As Object, e As EventArgs) Handles Cricket.Click
        ecricketset.show()
    End Sub
End Class