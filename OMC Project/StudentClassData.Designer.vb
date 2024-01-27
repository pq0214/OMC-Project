<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentClassData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentClassData))
        Me.tableViewMaterial = New System.Windows.Forms.TableLayoutPanel()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.TitleProgress = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.TitleRating = New System.Windows.Forms.Label()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblTimeSlot = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.TitleSubject = New System.Windows.Forms.Label()
        Me.TitleName = New System.Windows.Forms.Label()
        Me.btnRating = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.linkGroup = New System.Windows.Forms.LinkLabel()
        Me.picRating = New System.Windows.Forms.PictureBox()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableViewMaterial
        '
        Me.tableViewMaterial.AutoScroll = True
        Me.tableViewMaterial.ColumnCount = 1
        Me.tableViewMaterial.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableViewMaterial.Location = New System.Drawing.Point(114, 272)
        Me.tableViewMaterial.Name = "tableViewMaterial"
        Me.tableViewMaterial.RowCount = 1
        Me.tableViewMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171.0!))
        Me.tableViewMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171.0!))
        Me.tableViewMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171.0!))
        Me.tableViewMaterial.Size = New System.Drawing.Size(662, 171)
        Me.tableViewMaterial.TabIndex = 115
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.BackColor = System.Drawing.Color.Transparent
        Me.lblProgress.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgress.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblProgress.Location = New System.Drawing.Point(224, 204)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(93, 24)
        Me.lblProgress.TabIndex = 114
        Me.lblProgress.Text = "Progress"
        Me.lblProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitleProgress
        '
        Me.TitleProgress.AutoSize = True
        Me.TitleProgress.BackColor = System.Drawing.Color.Transparent
        Me.TitleProgress.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleProgress.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleProgress.Location = New System.Drawing.Point(116, 204)
        Me.TitleProgress.Name = "TitleProgress"
        Me.TitleProgress.Size = New System.Drawing.Size(99, 24)
        Me.TitleProgress.TabIndex = 113
        Me.TitleProgress.Text = "Progress:"
        Me.TitleProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.BackColor = System.Drawing.Color.Transparent
        Me.lblSubject.Font = New System.Drawing.Font("Kristen ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblSubject.Location = New System.Drawing.Point(29, 21)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(311, 54)
        Me.lblSubject.TabIndex = 111
        Me.lblSubject.Text = "Subject Name"
        '
        'TitleRating
        '
        Me.TitleRating.AutoSize = True
        Me.TitleRating.BackColor = System.Drawing.Color.Transparent
        Me.TitleRating.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleRating.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleRating.Location = New System.Drawing.Point(109, 241)
        Me.TitleRating.Name = "TitleRating"
        Me.TitleRating.Size = New System.Drawing.Size(110, 28)
        Me.TitleRating.TabIndex = 109
        Me.TitleRating.Text = "Material:"
        Me.TitleRating.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnEmail
        '
        Me.btnEmail.BackColor = System.Drawing.Color.Khaki
        Me.btnEmail.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmail.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnEmail.Location = New System.Drawing.Point(637, 460)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(148, 48)
        Me.btnEmail.TabIndex = 107
        Me.btnEmail.Text = "Email    "
        Me.btnEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmail.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnQuit.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnQuit.Location = New System.Drawing.Point(461, 460)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(148, 48)
        Me.btnQuit.TabIndex = 105
        Me.btnQuit.Text = "Quit   "
        Me.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lblTimeSlot
        '
        Me.lblTimeSlot.AutoSize = True
        Me.lblTimeSlot.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeSlot.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeSlot.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblTimeSlot.Location = New System.Drawing.Point(221, 124)
        Me.lblTimeSlot.Name = "lblTimeSlot"
        Me.lblTimeSlot.Size = New System.Drawing.Size(85, 24)
        Me.lblTimeSlot.TabIndex = 104
        Me.lblTimeSlot.Text = "Subject" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblTimeSlot.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblName.Location = New System.Drawing.Point(221, 84)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(65, 24)
        Me.lblName.TabIndex = 103
        Me.lblName.Text = "Name"
        '
        'TitleSubject
        '
        Me.TitleSubject.AutoSize = True
        Me.TitleSubject.BackColor = System.Drawing.Color.Transparent
        Me.TitleSubject.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleSubject.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleSubject.Location = New System.Drawing.Point(152, 124)
        Me.TitleSubject.Name = "TitleSubject"
        Me.TitleSubject.Size = New System.Drawing.Size(63, 24)
        Me.TitleSubject.TabIndex = 102
        Me.TitleSubject.Text = "Time:"
        Me.TitleSubject.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitleName
        '
        Me.TitleName.AutoSize = True
        Me.TitleName.BackColor = System.Drawing.Color.Transparent
        Me.TitleName.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleName.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleName.Location = New System.Drawing.Point(142, 84)
        Me.TitleName.Name = "TitleName"
        Me.TitleName.Size = New System.Drawing.Size(73, 24)
        Me.TitleName.TabIndex = 101
        Me.TitleName.Text = "Tutor:"
        '
        'btnRating
        '
        Me.btnRating.BackColor = System.Drawing.Color.Black
        Me.btnRating.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRating.ForeColor = System.Drawing.Color.Gold
        Me.btnRating.Location = New System.Drawing.Point(291, 460)
        Me.btnRating.Name = "btnRating"
        Me.btnRating.Size = New System.Drawing.Size(148, 48)
        Me.btnRating.TabIndex = 116
        Me.btnRating.Text = "Rating  "
        Me.btnRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRating.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label2.Location = New System.Drawing.Point(88, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 24)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Group Link:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'linkGroup
        '
        Me.linkGroup.AutoSize = True
        Me.linkGroup.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkGroup.Location = New System.Drawing.Point(224, 164)
        Me.linkGroup.Name = "linkGroup"
        Me.linkGroup.Size = New System.Drawing.Size(227, 24)
        Me.linkGroup.TabIndex = 120
        Me.linkGroup.TabStop = True
        Me.linkGroup.Text = "WhatsApp Group Link"
        '
        'picRating
        '
        Me.picRating.BackColor = System.Drawing.Color.Black
        Me.picRating.BackgroundImage = CType(resources.GetObject("picRating.BackgroundImage"), System.Drawing.Image)
        Me.picRating.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picRating.Location = New System.Drawing.Point(308, 466)
        Me.picRating.Name = "picRating"
        Me.picRating.Size = New System.Drawing.Size(36, 35)
        Me.picRating.TabIndex = 117
        Me.picRating.TabStop = False
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Location = New System.Drawing.Point(616, 94)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(160, 160)
        Me.picProfile.TabIndex = 112
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
        Me.PictureBox2.TabIndex = 108
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(475, 466)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 36)
        Me.PictureBox1.TabIndex = 106
        Me.PictureBox1.TabStop = False
        '
        'StudentClassData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.linkGroup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picRating)
        Me.Controls.Add(Me.btnRating)
        Me.Controls.Add(Me.tableViewMaterial)
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.TitleProgress)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.TitleRating)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblTimeSlot)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.TitleSubject)
        Me.Controls.Add(Me.TitleName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentClassData"
        Me.Text = "StudentClassData"
        CType(Me.picRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tableViewMaterial As TableLayoutPanel
    Friend WithEvents lblProgress As Label
    Friend WithEvents TitleProgress As Label
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents lblSubject As Label
    Friend WithEvents TitleRating As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnEmail As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents lblTimeSlot As Label
    Friend WithEvents lblName As Label
    Friend WithEvents TitleSubject As Label
    Friend WithEvents TitleName As Label
    Friend WithEvents picRating As PictureBox
    Friend WithEvents btnRating As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents linkGroup As LinkLabel
End Class
