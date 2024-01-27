<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TutorStudentData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TutorStudentData))
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.TitleRating = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.picRemove = New System.Windows.Forms.PictureBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.TitleSubject = New System.Windows.Forms.Label()
        Me.TitleName = New System.Windows.Forms.Label()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.TitleProgress = New System.Windows.Forms.Label()
        Me.tableProgress = New System.Windows.Forms.TableLayoutPanel()
        Me.picRating = New System.Windows.Forms.PictureBox()
        Me.btnRating = New System.Windows.Forms.Button()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Location = New System.Drawing.Point(616, 94)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(160, 160)
        Me.picProfile.TabIndex = 97
        Me.picProfile.TabStop = False
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
        Me.lblTitle.TabIndex = 95
        Me.lblTitle.Text = "Student Approval"
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.BackColor = System.Drawing.Color.Transparent
        Me.lblRating.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRating.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblRating.Location = New System.Drawing.Point(230, 201)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(82, 28)
        Me.lblRating.TabIndex = 94
        Me.lblRating.Text = "Rating"
        Me.lblRating.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitleRating
        '
        Me.TitleRating.AutoSize = True
        Me.TitleRating.BackColor = System.Drawing.Color.Transparent
        Me.TitleRating.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleRating.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleRating.Location = New System.Drawing.Point(132, 201)
        Me.TitleRating.Name = "TitleRating"
        Me.TitleRating.Size = New System.Drawing.Size(89, 28)
        Me.TitleRating.TabIndex = 93
        Me.TitleRating.Text = "Rating:"
        Me.TitleRating.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Khaki
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(655, 467)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 36)
        Me.PictureBox2.TabIndex = 92
        Me.PictureBox2.TabStop = False
        '
        'btnEmail
        '
        Me.btnEmail.BackColor = System.Drawing.Color.Khaki
        Me.btnEmail.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmail.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnEmail.Location = New System.Drawing.Point(637, 460)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(148, 48)
        Me.btnEmail.TabIndex = 91
        Me.btnEmail.Text = "Email    "
        Me.btnEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmail.UseVisualStyleBackColor = False
        '
        'picRemove
        '
        Me.picRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picRemove.BackgroundImage = CType(resources.GetObject("picRemove.BackgroundImage"), System.Drawing.Image)
        Me.picRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picRemove.Location = New System.Drawing.Point(475, 466)
        Me.picRemove.Name = "picRemove"
        Me.picRemove.Size = New System.Drawing.Size(39, 36)
        Me.picRemove.TabIndex = 90
        Me.picRemove.TabStop = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRemove.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnRemove.Location = New System.Drawing.Point(461, 460)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(148, 48)
        Me.btnRemove.TabIndex = 89
        Me.btnRemove.Text = "Remove "
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.BackColor = System.Drawing.Color.Transparent
        Me.lblSubject.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblSubject.Location = New System.Drawing.Point(230, 146)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(94, 28)
        Me.lblSubject.TabIndex = 88
        Me.lblSubject.Text = "Subject" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblSubject.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.lblName.TabIndex = 86
        Me.lblName.Text = "Name"
        '
        'TitleSubject
        '
        Me.TitleSubject.AutoSize = True
        Me.TitleSubject.BackColor = System.Drawing.Color.Transparent
        Me.TitleSubject.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleSubject.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleSubject.Location = New System.Drawing.Point(120, 146)
        Me.TitleSubject.Name = "TitleSubject"
        Me.TitleSubject.Size = New System.Drawing.Size(101, 28)
        Me.TitleSubject.TabIndex = 84
        Me.TitleSubject.Text = "Subject:"
        Me.TitleSubject.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.TitleName.TabIndex = 82
        Me.TitleName.Text = "Name:"
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.BackColor = System.Drawing.Color.Transparent
        Me.lblProgress.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgress.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblProgress.Location = New System.Drawing.Point(230, 254)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(104, 28)
        Me.lblProgress.TabIndex = 99
        Me.lblProgress.Text = "Progress"
        Me.lblProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitleProgress
        '
        Me.TitleProgress.AutoSize = True
        Me.TitleProgress.BackColor = System.Drawing.Color.Transparent
        Me.TitleProgress.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleProgress.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleProgress.Location = New System.Drawing.Point(110, 254)
        Me.TitleProgress.Name = "TitleProgress"
        Me.TitleProgress.Size = New System.Drawing.Size(111, 28)
        Me.TitleProgress.TabIndex = 98
        Me.TitleProgress.Text = "Progress:"
        Me.TitleProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tableProgress
        '
        Me.tableProgress.AutoScroll = True
        Me.tableProgress.ColumnCount = 1
        Me.tableProgress.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableProgress.Location = New System.Drawing.Point(114, 293)
        Me.tableProgress.Name = "tableProgress"
        Me.tableProgress.RowCount = 1
        Me.tableProgress.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tableProgress.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tableProgress.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tableProgress.Size = New System.Drawing.Size(662, 150)
        Me.tableProgress.TabIndex = 100
        '
        'picRating
        '
        Me.picRating.BackColor = System.Drawing.Color.Black
        Me.picRating.BackgroundImage = CType(resources.GetObject("picRating.BackgroundImage"), System.Drawing.Image)
        Me.picRating.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picRating.Location = New System.Drawing.Point(309, 466)
        Me.picRating.Name = "picRating"
        Me.picRating.Size = New System.Drawing.Size(36, 35)
        Me.picRating.TabIndex = 119
        Me.picRating.TabStop = False
        '
        'btnRating
        '
        Me.btnRating.BackColor = System.Drawing.Color.Black
        Me.btnRating.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRating.ForeColor = System.Drawing.Color.Gold
        Me.btnRating.Location = New System.Drawing.Point(292, 460)
        Me.btnRating.Name = "btnRating"
        Me.btnRating.Size = New System.Drawing.Size(148, 48)
        Me.btnRating.TabIndex = 118
        Me.btnRating.Text = "Rating  "
        Me.btnRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRating.UseVisualStyleBackColor = False
        '
        'TutorStudentData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.picRating)
        Me.Controls.Add(Me.btnRating)
        Me.Controls.Add(Me.tableProgress)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.TitleProgress)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblRating)
        Me.Controls.Add(Me.TitleRating)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.picRemove)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.TitleSubject)
        Me.Controls.Add(Me.TitleName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TutorStudentData"
        Me.Text = "TutorStudentData"
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picProfile As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRating As Label
    Friend WithEvents TitleRating As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnEmail As Button
    Friend WithEvents picRemove As PictureBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblName As Label
    Friend WithEvents TitleSubject As Label
    Friend WithEvents TitleName As Label
    Friend WithEvents lblProgress As Label
    Friend WithEvents TitleProgress As Label
    Friend WithEvents tableProgress As TableLayoutPanel
    Friend WithEvents picRating As PictureBox
    Friend WithEvents btnRating As Button
End Class
