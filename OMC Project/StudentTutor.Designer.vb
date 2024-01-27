<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentTutor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentTutor))
        Me.tableViewSubject = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.TitleRating = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.TitleSubject = New System.Windows.Forms.Label()
        Me.TitleGender = New System.Windows.Forms.Label()
        Me.TitleName = New System.Windows.Forms.Label()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnEmail = New System.Windows.Forms.Button()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableViewSubject
        '
        Me.tableViewSubject.AutoScroll = True
        Me.tableViewSubject.ColumnCount = 1
        Me.tableViewSubject.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableViewSubject.Location = New System.Drawing.Point(224, 245)
        Me.tableViewSubject.Name = "tableViewSubject"
        Me.tableViewSubject.RowCount = 1
        Me.tableViewSubject.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableViewSubject.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 209.0!))
        Me.tableViewSubject.Size = New System.Drawing.Size(561, 209)
        Me.tableViewSubject.TabIndex = 82
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Kristen ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblTitle.Location = New System.Drawing.Point(29, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(145, 54)
        Me.lblTitle.TabIndex = 81
        Me.lblTitle.Text = "Tutor"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblPrice.Location = New System.Drawing.Point(227, 198)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(82, 28)
        Me.lblPrice.TabIndex = 80
        Me.lblPrice.Text = "Rating"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitleRating
        '
        Me.TitleRating.AutoSize = True
        Me.TitleRating.BackColor = System.Drawing.Color.Transparent
        Me.TitleRating.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleRating.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleRating.Location = New System.Drawing.Point(129, 198)
        Me.TitleRating.Name = "TitleRating"
        Me.TitleRating.Size = New System.Drawing.Size(89, 28)
        Me.TitleRating.TabIndex = 79
        Me.TitleRating.Text = "Rating:"
        Me.TitleRating.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.lblGender.TabIndex = 73
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
        Me.lblName.TabIndex = 72
        Me.lblName.Text = "Name"
        '
        'TitleSubject
        '
        Me.TitleSubject.AutoSize = True
        Me.TitleSubject.BackColor = System.Drawing.Color.Transparent
        Me.TitleSubject.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleSubject.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleSubject.Location = New System.Drawing.Point(117, 245)
        Me.TitleSubject.Name = "TitleSubject"
        Me.TitleSubject.Size = New System.Drawing.Size(101, 28)
        Me.TitleSubject.TabIndex = 71
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
        Me.TitleGender.TabIndex = 69
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
        Me.TitleName.TabIndex = 68
        Me.TitleName.Text = "Name:"
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Location = New System.Drawing.Point(637, 94)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(148, 144)
        Me.picProfile.TabIndex = 83
        Me.picProfile.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Khaki
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(655, 467)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 36)
        Me.PictureBox2.TabIndex = 94
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
        Me.btnEmail.TabIndex = 93
        Me.btnEmail.Text = "Email    "
        Me.btnEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmail.UseVisualStyleBackColor = False
        '
        'StudentTutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.tableViewSubject)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.TitleRating)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.TitleSubject)
        Me.Controls.Add(Me.TitleGender)
        Me.Controls.Add(Me.TitleName)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnEmail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentTutor"
        Me.Text = "StudentTutor"
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picProfile As PictureBox
    Friend WithEvents tableViewSubject As TableLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents TitleRating As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblName As Label
    Friend WithEvents TitleSubject As Label
    Friend WithEvents TitleGender As Label
    Friend WithEvents TitleName As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnEmail As Button
End Class
