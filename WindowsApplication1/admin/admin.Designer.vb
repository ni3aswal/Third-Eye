<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin))
        Me.English = New System.Windows.Forms.Button()
        Me.Hindi = New System.Windows.Forms.Button()
        Me.Marathi = New System.Windows.Forms.Button()
        Me.create = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.changemenu = New System.Windows.Forms.Button()
        Me.changemedia = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'English
        '
        Me.English.Location = New System.Drawing.Point(6, 19)
        Me.English.Name = "English"
        Me.English.Size = New System.Drawing.Size(97, 41)
        Me.English.TabIndex = 0
        Me.English.Text = "English"
        Me.English.UseVisualStyleBackColor = True
        '
        'Hindi
        '
        Me.Hindi.Location = New System.Drawing.Point(109, 19)
        Me.Hindi.Name = "Hindi"
        Me.Hindi.Size = New System.Drawing.Size(97, 41)
        Me.Hindi.TabIndex = 1
        Me.Hindi.Text = "Hindi"
        Me.Hindi.UseVisualStyleBackColor = True
        '
        'Marathi
        '
        Me.Marathi.Location = New System.Drawing.Point(212, 19)
        Me.Marathi.Name = "Marathi"
        Me.Marathi.Size = New System.Drawing.Size(97, 41)
        Me.Marathi.TabIndex = 2
        Me.Marathi.Text = "Marathi"
        Me.Marathi.UseVisualStyleBackColor = True
        '
        'create
        '
        Me.create.Location = New System.Drawing.Point(7, 389)
        Me.create.Name = "create"
        Me.create.Size = New System.Drawing.Size(320, 47)
        Me.create.TabIndex = 7
        Me.create.Text = "create directories"
        Me.create.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(7, 442)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(320, 43)
        Me.back.TabIndex = 8
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(1, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 52)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(291, 90)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.English)
        Me.GroupBox2.Controls.Add(Me.Hindi)
        Me.GroupBox2.Controls.Add(Me.Marathi)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 316)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 67)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Change media"
        Me.GroupBox2.Visible = False
        '
        'changemenu
        '
        Me.changemenu.Location = New System.Drawing.Point(91, 222)
        Me.changemenu.Name = "changemenu"
        Me.changemenu.Size = New System.Drawing.Size(132, 42)
        Me.changemenu.TabIndex = 0
        Me.changemenu.Text = "Change audios of menus"
        Me.changemenu.UseVisualStyleBackColor = True
        '
        'changemedia
        '
        Me.changemedia.Location = New System.Drawing.Point(91, 270)
        Me.changemedia.Name = "changemedia"
        Me.changemedia.Size = New System.Drawing.Size(132, 40)
        Me.changemedia.TabIndex = 18
        Me.changemedia.Text = "Change Media"
        Me.changemedia.UseVisualStyleBackColor = True
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 497)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.changemedia)
        Me.Controls.Add(Me.changemenu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.create)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "admin"
        Me.Text = "admin: select language"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents English As System.Windows.Forms.Button
    Friend WithEvents Hindi As System.Windows.Forms.Button
    Friend WithEvents Marathi As System.Windows.Forms.Button
    Friend WithEvents create As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents changemenu As System.Windows.Forms.Button
    Friend WithEvents changemedia As System.Windows.Forms.Button
End Class
