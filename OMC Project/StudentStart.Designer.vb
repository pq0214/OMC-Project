<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentStart))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.lblHi = New System.Windows.Forms.Label()
        Me.PicAdmin = New System.Windows.Forms.PictureBox()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblWelcome.Location = New System.Drawing.Point(36, 357)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(202, 25)
        Me.lblWelcome.TabIndex = 24
        Me.lblWelcome.Text = "Welcome to NetGenius"
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Location = New System.Drawing.Point(39, 66)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(160, 160)
        Me.picProfile.TabIndex = 21
        Me.picProfile.TabStop = False
        '
        'lblHi
        '
        Me.lblHi.AutoSize = True
        Me.lblHi.BackColor = System.Drawing.Color.Transparent
        Me.lblHi.Font = New System.Drawing.Font("Kristen ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHi.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblHi.Location = New System.Drawing.Point(21, 279)
        Me.lblHi.Name = "lblHi"
        Me.lblHi.Size = New System.Drawing.Size(392, 83)
        Me.lblHi.TabIndex = 23
        Me.lblHi.Text = "Hi, Student"
        '
        'PicAdmin
        '
        Me.PicAdmin.BackColor = System.Drawing.SystemColors.HighlightText
        Me.PicAdmin.BackgroundImage = CType(resources.GetObject("PicAdmin.BackgroundImage"), System.Drawing.Image)
        Me.PicAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PicAdmin.Location = New System.Drawing.Point(342, 35)
        Me.PicAdmin.Name = "PicAdmin"
        Me.PicAdmin.Size = New System.Drawing.Size(556, 461)
        Me.PicAdmin.TabIndex = 22
        Me.PicAdmin.TabStop = False
        '
        'StudentStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.lblHi)
        Me.Controls.Add(Me.PicAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentStart"
        Me.Text = "StudentStart"
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents lblHi As Label
    Friend WithEvents PicAdmin As PictureBox
End Class
