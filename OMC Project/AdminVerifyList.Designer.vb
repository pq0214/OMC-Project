<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminVerifyList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminVerifyList))
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.TitleDocument = New System.Windows.Forms.Label()
        Me.TitleSubject = New System.Windows.Forms.Label()
        Me.TitleGender = New System.Windows.Forms.Label()
        Me.TitleName = New System.Windows.Forms.Label()
        Me.btnReject = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.TitlePrice = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tableViewDocument = New System.Windows.Forms.TableLayoutPanel()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.picApprove = New System.Windows.Forms.PictureBox()
        Me.picReject = New System.Windows.Forms.PictureBox()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picApprove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picReject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.BackColor = System.Drawing.Color.Transparent
        Me.lblSubject.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblSubject.Location = New System.Drawing.Point(226, 190)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(94, 28)
        Me.lblSubject.TabIndex = 58
        Me.lblSubject.Text = "Subject" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblSubject.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblGender.Location = New System.Drawing.Point(226, 138)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(91, 28)
        Me.lblGender.TabIndex = 57
        Me.lblGender.Text = "Gender"
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblName.Location = New System.Drawing.Point(226, 85)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(72, 28)
        Me.lblName.TabIndex = 56
        Me.lblName.Text = "Name"
        '
        'TitleDocument
        '
        Me.TitleDocument.AutoSize = True
        Me.TitleDocument.BackColor = System.Drawing.Color.Transparent
        Me.TitleDocument.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleDocument.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleDocument.Location = New System.Drawing.Point(87, 301)
        Me.TitleDocument.Name = "TitleDocument"
        Me.TitleDocument.Size = New System.Drawing.Size(130, 28)
        Me.TitleDocument.TabIndex = 54
        Me.TitleDocument.Text = "Document:"
        Me.TitleDocument.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitleSubject
        '
        Me.TitleSubject.AutoSize = True
        Me.TitleSubject.BackColor = System.Drawing.Color.Transparent
        Me.TitleSubject.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleSubject.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleSubject.Location = New System.Drawing.Point(116, 190)
        Me.TitleSubject.Name = "TitleSubject"
        Me.TitleSubject.Size = New System.Drawing.Size(101, 28)
        Me.TitleSubject.TabIndex = 53
        Me.TitleSubject.Text = "Subject:"
        Me.TitleSubject.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitleGender
        '
        Me.TitleGender.AutoSize = True
        Me.TitleGender.BackColor = System.Drawing.Color.Transparent
        Me.TitleGender.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleGender.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleGender.Location = New System.Drawing.Point(119, 138)
        Me.TitleGender.Name = "TitleGender"
        Me.TitleGender.Size = New System.Drawing.Size(98, 28)
        Me.TitleGender.TabIndex = 52
        Me.TitleGender.Text = "Gender:"
        Me.TitleGender.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitleName
        '
        Me.TitleName.AutoSize = True
        Me.TitleName.BackColor = System.Drawing.Color.Transparent
        Me.TitleName.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleName.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleName.Location = New System.Drawing.Point(138, 85)
        Me.TitleName.Name = "TitleName"
        Me.TitleName.Size = New System.Drawing.Size(79, 28)
        Me.TitleName.TabIndex = 51
        Me.TitleName.Text = "Name:"
        '
        'btnReject
        '
        Me.btnReject.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReject.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReject.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnReject.Location = New System.Drawing.Point(457, 451)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(148, 48)
        Me.btnReject.TabIndex = 59
        Me.btnReject.Text = "Reject  "
        Me.btnReject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReject.UseVisualStyleBackColor = False
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnApprove.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApprove.ForeColor = System.Drawing.Color.LimeGreen
        Me.btnApprove.Location = New System.Drawing.Point(633, 451)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(148, 48)
        Me.btnApprove.TabIndex = 61
        Me.btnApprove.Text = "Approve "
        Me.btnApprove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblPrice.Location = New System.Drawing.Point(226, 245)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(69, 28)
        Me.lblPrice.TabIndex = 64
        Me.lblPrice.Text = "Price"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitlePrice
        '
        Me.TitlePrice.AutoSize = True
        Me.TitlePrice.BackColor = System.Drawing.Color.Transparent
        Me.TitlePrice.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitlePrice.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitlePrice.Location = New System.Drawing.Point(141, 245)
        Me.TitlePrice.Name = "TitlePrice"
        Me.TitlePrice.Size = New System.Drawing.Size(76, 28)
        Me.TitlePrice.TabIndex = 63
        Me.TitlePrice.Text = "Price:"
        Me.TitlePrice.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Kristen ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblTitle.Location = New System.Drawing.Point(25, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(406, 54)
        Me.lblTitle.TabIndex = 65
        Me.lblTitle.Text = "Tutor Verification"
        '
        'tableViewDocument
        '
        Me.tableViewDocument.AutoScroll = True
        Me.tableViewDocument.ColumnCount = 1
        Me.tableViewDocument.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableViewDocument.Location = New System.Drawing.Point(228, 298)
        Me.tableViewDocument.Name = "tableViewDocument"
        Me.tableViewDocument.RowCount = 1
        Me.tableViewDocument.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableViewDocument.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139.0!))
        Me.tableViewDocument.Size = New System.Drawing.Size(553, 139)
        Me.tableViewDocument.TabIndex = 66
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Location = New System.Drawing.Point(633, 85)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(148, 144)
        Me.picProfile.TabIndex = 67
        Me.picProfile.TabStop = False
        '
        'picApprove
        '
        Me.picApprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picApprove.BackgroundImage = CType(resources.GetObject("picApprove.BackgroundImage"), System.Drawing.Image)
        Me.picApprove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picApprove.Location = New System.Drawing.Point(641, 457)
        Me.picApprove.Name = "picApprove"
        Me.picApprove.Size = New System.Drawing.Size(39, 36)
        Me.picApprove.TabIndex = 62
        Me.picApprove.TabStop = False
        '
        'picReject
        '
        Me.picReject.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picReject.BackgroundImage = CType(resources.GetObject("picReject.BackgroundImage"), System.Drawing.Image)
        Me.picReject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picReject.Location = New System.Drawing.Point(471, 457)
        Me.picReject.Name = "picReject"
        Me.picReject.Size = New System.Drawing.Size(39, 36)
        Me.picReject.TabIndex = 60
        Me.picReject.TabStop = False
        '
        'AdminVerifyList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.tableViewDocument)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.TitlePrice)
        Me.Controls.Add(Me.picApprove)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.picReject)
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.TitleDocument)
        Me.Controls.Add(Me.TitleSubject)
        Me.Controls.Add(Me.TitleGender)
        Me.Controls.Add(Me.TitleName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminVerifyList"
        Me.Text = "AdminVerifyList"
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picApprove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picReject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSubject As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblName As Label
    Friend WithEvents TitleDocument As Label
    Friend WithEvents TitleSubject As Label
    Friend WithEvents TitleGender As Label
    Friend WithEvents TitleName As Label
    Friend WithEvents btnReject As Button
    Friend WithEvents picReject As PictureBox
    Friend WithEvents btnApprove As Button
    Friend WithEvents picApprove As PictureBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents TitlePrice As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents tableViewDocument As TableLayoutPanel
    Friend WithEvents picProfile As PictureBox
End Class
