<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutorVerifyStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TutorVerifyStudent))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.TitleRating = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.TitleDescription = New System.Windows.Forms.Label()
        Me.TitleSubject = New System.Windows.Forms.Label()
        Me.TitleGender = New System.Windows.Forms.Label()
        Me.TitleName = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Kristen ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblTitle.Location = New System.Drawing.Point(29, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(393, 54)
        Me.lblTitle.TabIndex = 79
        Me.lblTitle.Text = "Student Approval"
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.BackColor = System.Drawing.Color.Transparent
        Me.lblRating.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRating.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblRating.Location = New System.Drawing.Point(230, 254)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(82, 28)
        Me.lblRating.TabIndex = 78
        Me.lblRating.Text = "Rating"
        Me.lblRating.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitleRating
        '
        Me.TitleRating.AutoSize = True
        Me.TitleRating.BackColor = System.Drawing.Color.Transparent
        Me.TitleRating.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleRating.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleRating.Location = New System.Drawing.Point(132, 254)
        Me.TitleRating.Name = "TitleRating"
        Me.TitleRating.Size = New System.Drawing.Size(89, 28)
        Me.TitleRating.TabIndex = 77
        Me.TitleRating.Text = "Rating:"
        Me.TitleRating.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(645, 466)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 36)
        Me.PictureBox2.TabIndex = 76
        Me.PictureBox2.TabStop = False
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnApprove.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.ForeColor = System.Drawing.Color.LimeGreen
        Me.btnApprove.Location = New System.Drawing.Point(637, 460)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(148, 48)
        Me.btnApprove.TabIndex = 75
        Me.btnApprove.Text = "Approve "
        Me.btnApprove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(475, 466)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 36)
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'btnReject
        '
        Me.btnReject.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReject.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReject.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnReject.Location = New System.Drawing.Point(461, 460)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(148, 48)
        Me.btnReject.TabIndex = 73
        Me.btnReject.Text = "Reject  "
        Me.btnReject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReject.UseVisualStyleBackColor = False
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.BackColor = System.Drawing.Color.Transparent
        Me.lblSubject.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblSubject.Location = New System.Drawing.Point(230, 199)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(94, 28)
        Me.lblSubject.TabIndex = 72
        Me.lblSubject.Text = "Subject" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblSubject.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblGender.Location = New System.Drawing.Point(230, 147)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(91, 28)
        Me.lblGender.TabIndex = 71
        Me.lblGender.Text = "Gender"
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblName.Location = New System.Drawing.Point(230, 94)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(72, 28)
        Me.lblName.TabIndex = 70
        Me.lblName.Text = "Name"
        '
        'TitleDescription
        '
        Me.TitleDescription.AutoSize = True
        Me.TitleDescription.BackColor = System.Drawing.Color.Transparent
        Me.TitleDescription.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleDescription.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleDescription.Location = New System.Drawing.Point(75, 311)
        Me.TitleDescription.Name = "TitleDescription"
        Me.TitleDescription.Size = New System.Drawing.Size(146, 28)
        Me.TitleDescription.TabIndex = 69
        Me.TitleDescription.Text = "Description:"
        Me.TitleDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitleSubject
        '
        Me.TitleSubject.AutoSize = True
        Me.TitleSubject.BackColor = System.Drawing.Color.Transparent
        Me.TitleSubject.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleSubject.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleSubject.Location = New System.Drawing.Point(120, 199)
        Me.TitleSubject.Name = "TitleSubject"
        Me.TitleSubject.Size = New System.Drawing.Size(101, 28)
        Me.TitleSubject.TabIndex = 68
        Me.TitleSubject.Text = "Subject:"
        Me.TitleSubject.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitleGender
        '
        Me.TitleGender.AutoSize = True
        Me.TitleGender.BackColor = System.Drawing.Color.Transparent
        Me.TitleGender.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleGender.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleGender.Location = New System.Drawing.Point(123, 147)
        Me.TitleGender.Name = "TitleGender"
        Me.TitleGender.Size = New System.Drawing.Size(98, 28)
        Me.TitleGender.TabIndex = 67
        Me.TitleGender.Text = "Gender:"
        Me.TitleGender.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitleName
        '
        Me.TitleName.AutoSize = True
        Me.TitleName.BackColor = System.Drawing.Color.Transparent
        Me.TitleName.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleName.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleName.Location = New System.Drawing.Point(142, 94)
        Me.TitleName.Name = "TitleName"
        Me.TitleName.Size = New System.Drawing.Size(79, 28)
        Me.TitleName.TabIndex = 66
        Me.TitleName.Text = "Name:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblDescription.Location = New System.Drawing.Point(233, 311)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(139, 28)
        Me.lblDescription.TabIndex = 80
        Me.lblDescription.Text = "Description"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Location = New System.Drawing.Point(616, 94)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(160, 160)
        Me.picProfile.TabIndex = 81
        Me.picProfile.TabStop = False
        '
        'TutorVerifyStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblRating)
        Me.Controls.Add(Me.TitleRating)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.TitleDescription)
        Me.Controls.Add(Me.TitleSubject)
        Me.Controls.Add(Me.TitleGender)
        Me.Controls.Add(Me.TitleName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TutorVerifyStudent"
        Me.Text = "TutorVerifyStudent"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRating As Label
    Friend WithEvents TitleRating As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnApprove As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnReject As Button
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblName As Label
    Friend WithEvents TitleDescription As Label
    Friend WithEvents TitleSubject As Label
    Friend WithEvents TitleGender As Label
    Friend WithEvents TitleName As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents picProfile As PictureBox
End Class
