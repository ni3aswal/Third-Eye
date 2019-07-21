<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maradmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(maradmin))
        Me.back = New System.Windows.Forms.Button()
        Me.News = New System.Windows.Forms.Button()
        Me.Jokes = New System.Windows.Forms.Button()
        Me.Radio = New System.Windows.Forms.Button()
        Me.Movies = New System.Windows.Forms.Button()
        Me.Music = New System.Windows.Forms.Button()
        Me.Stories = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Interview = New System.Windows.Forms.Button()
        Me.Document = New System.Windows.Forms.Button()
        Me.Book = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(9, 202)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(339, 43)
        Me.back.TabIndex = 3
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'News
        '
        Me.News.Location = New System.Drawing.Point(9, 12)
        Me.News.Name = "News"
        Me.News.Size = New System.Drawing.Size(104, 27)
        Me.News.TabIndex = 7
        Me.News.Text = "News"
        Me.News.UseVisualStyleBackColor = True
        '
        'Jokes
        '
        Me.Jokes.Location = New System.Drawing.Point(246, 45)
        Me.Jokes.Name = "Jokes"
        Me.Jokes.Size = New System.Drawing.Size(99, 27)
        Me.Jokes.TabIndex = 8
        Me.Jokes.Text = "Jokes"
        Me.Jokes.UseVisualStyleBackColor = True
        '
        'Radio
        '
        Me.Radio.Location = New System.Drawing.Point(246, 12)
        Me.Radio.Name = "Radio"
        Me.Radio.Size = New System.Drawing.Size(99, 27)
        Me.Radio.TabIndex = 9
        Me.Radio.Text = "Radio"
        Me.Radio.UseVisualStyleBackColor = True
        '
        'Movies
        '
        Me.Movies.Location = New System.Drawing.Point(119, 45)
        Me.Movies.Name = "Movies"
        Me.Movies.Size = New System.Drawing.Size(121, 27)
        Me.Movies.TabIndex = 10
        Me.Movies.Text = "Movies"
        Me.Movies.UseVisualStyleBackColor = True
        '
        'Music
        '
        Me.Music.Location = New System.Drawing.Point(119, 12)
        Me.Music.Name = "Music"
        Me.Music.Size = New System.Drawing.Size(121, 27)
        Me.Music.TabIndex = 11
        Me.Music.Text = "Music"
        Me.Music.UseVisualStyleBackColor = True
        '
        'Stories
        '
        Me.Stories.Location = New System.Drawing.Point(9, 45)
        Me.Stories.Name = "Stories"
        Me.Stories.Size = New System.Drawing.Size(104, 27)
        Me.Stories.TabIndex = 12
        Me.Stories.Text = "Stories"
        Me.Stories.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 26)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "  MUSIC , MOVIES, JOKES AND STORIES CAN " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BE USED WHILE OFFLINE AND ONLINE BOTH"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 39)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "RADIO AND NEWS REQUIRES INTERNET CONNECTION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     YOU CAN ALSO USE THESE FEATURES" & _
    " IF YOU HAVE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ALREADY DOWNLAODED THE EPISODE OR PODCAST  "
        '
        'Interview
        '
        Me.Interview.Location = New System.Drawing.Point(246, 78)
        Me.Interview.Name = "Interview"
        Me.Interview.Size = New System.Drawing.Size(99, 27)
        Me.Interview.TabIndex = 21
        Me.Interview.Text = "Interview"
        Me.Interview.UseVisualStyleBackColor = True
        '
        'Document
        '
        Me.Document.Location = New System.Drawing.Point(119, 78)
        Me.Document.Name = "Document"
        Me.Document.Size = New System.Drawing.Size(121, 27)
        Me.Document.TabIndex = 20
        Me.Document.Text = "Documentries"
        Me.Document.UseVisualStyleBackColor = True
        '
        'Book
        '
        Me.Book.Location = New System.Drawing.Point(9, 78)
        Me.Book.Name = "Book"
        Me.Book.Size = New System.Drawing.Size(104, 27)
        Me.Book.TabIndex = 19
        Me.Book.Text = "Book"
        Me.Book.UseVisualStyleBackColor = True
        '
        'maradmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 274)
        Me.Controls.Add(Me.Interview)
        Me.Controls.Add(Me.Document)
        Me.Controls.Add(Me.Book)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Stories)
        Me.Controls.Add(Me.Music)
        Me.Controls.Add(Me.Movies)
        Me.Controls.Add(Me.Radio)
        Me.Controls.Add(Me.Jokes)
        Me.Controls.Add(Me.News)
        Me.Controls.Add(Me.back)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "maradmin"
        Me.Text = "Marathi admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents News As System.Windows.Forms.Button
    Friend WithEvents Jokes As System.Windows.Forms.Button
    Friend WithEvents Radio As System.Windows.Forms.Button
    Friend WithEvents Movies As System.Windows.Forms.Button
    Friend WithEvents Music As System.Windows.Forms.Button
    Friend WithEvents Stories As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Interview As System.Windows.Forms.Button
    Friend WithEvents Document As System.Windows.Forms.Button
    Friend WithEvents Book As System.Windows.Forms.Button
End Class
