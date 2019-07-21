Imports System.IO

Public Class menuadmin
    Private Sub menuadmin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        admin.Show()
    End Sub
    Private Sub exi_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Close()
        admin.Show()
    End Sub
End Class
