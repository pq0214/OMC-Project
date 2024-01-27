<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnChgPW = New System.Windows.Forms.Button()
        Me.TitleEmail = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.TitleGender = New System.Windows.Forms.Label()
        Me.TitleName = New System.Windows.Forms.Label()
        Me.lblProfile = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UploadPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.TitleBio = New System.Windows.Forms.Label()
        Me.txtBio = New System.Windows.Forms.TextBox()
        Me.picEdit = New System.Windows.Forms.PictureBox()
        Me.picDone = New System.Windows.Forms.PictureBox()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picProfile
        '
        Me.picProfile.BackColor = System.Drawing.Color.Transparent
        Me.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProfile.Location = New System.Drawing.Point(586, 150)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(160, 160)
        Me.picProfile.TabIndex = 50
        Me.picProfile.TabStop = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnUpload.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnUpload.Location = New System.Drawing.Point(586, 326)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(160, 53)
        Me.btnUpload.TabIndex = 49
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'btnChgPW
        '
        Me.btnChgPW.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnChgPW.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChgPW.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnChgPW.Location = New System.Drawing.Point(246, 410)
        Me.btnChgPW.Name = "btnChgPW"
        Me.btnChgPW.Size = New System.Drawing.Size(243, 52)
        Me.btnChgPW.TabIndex = 48
        Me.btnChgPW.Text = "Change Password"
        Me.btnChgPW.UseVisualStyleBackColor = False
        '
        'TitleEmail
        '
        Me.TitleEmail.AutoSize = True
        Me.TitleEmail.BackColor = System.Drawing.Color.Transparent
        Me.TitleEmail.Font = New System.Drawing.Font("Kristen ITC", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleEmail.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleEmail.Location = New System.Drawing.Point(122, 243)
        Me.TitleEmail.Name = "TitleEmail"
        Me.TitleEmail.Size = New System.Drawing.Size(86, 30)
        Me.TitleEmail.TabIndex = 41
        Me.TitleEmail.Text = "Email:"
        Me.TitleEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblEmail.Location = New System.Drawing.Point(216, 247)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(63, 24)
        Me.lblEmail.TabIndex = 46
        Me.lblEmail.Text = "Email"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblGender.Location = New System.Drawing.Point(214, 201)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(82, 24)
        Me.lblGender.TabIndex = 44
        Me.lblGender.Text = "Gender"
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblName.Location = New System.Drawing.Point(216, 156)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(65, 24)
        Me.lblName.TabIndex = 43
        Me.lblName.Text = "Name"
        '
        'TitleGender
        '
        Me.TitleGender.AutoSize = True
        Me.TitleGender.BackColor = System.Drawing.Color.Transparent
        Me.TitleGender.Font = New System.Drawing.Font("Kristen ITC", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleGender.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleGender.Location = New System.Drawing.Point(99, 196)
        Me.TitleGender.Name = "TitleGender"
        Me.TitleGender.Size = New System.Drawing.Size(111, 30)
        Me.TitleGender.TabIndex = 39
        Me.TitleGender.Text = "Gender:"
        Me.TitleGender.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitleName
        '
        Me.TitleName.AutoSize = True
        Me.TitleName.BackColor = System.Drawing.Color.Transparent
        Me.TitleName.Font = New System.Drawing.Font("Kristen ITC", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleName.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleName.Location = New System.Drawing.Point(122, 150)
        Me.TitleName.Name = "TitleName"
        Me.TitleName.Size = New System.Drawing.Size(90, 30)
        Me.TitleName.TabIndex = 38
        Me.TitleName.Text = "Name:"
        '
        'lblProfile
        '
        Me.lblProfile.AutoSize = True
        Me.lblProfile.BackColor = System.Drawing.Color.Transparent
        Me.lblProfile.Font = New System.Drawing.Font("Kristen ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfile.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblProfile.Location = New System.Drawing.Point(232, 31)
        Me.lblProfile.Name = "lblProfile"
        Me.lblProfile.Size = New System.Drawing.Size(356, 83)
        Me.lblProfile.TabIndex = 37
        Me.lblProfile.Text = "My Profile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Kristen ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(53, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(717, 83)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "______________________"
        '
        'UploadPhoto
        '
        Me.UploadPhoto.FileName = "OpenFileDialog1"
        '
        'TitleBio
        '
        Me.TitleBio.AutoSize = True
        Me.TitleBio.BackColor = System.Drawing.Color.Transparent
        Me.TitleBio.Font = New System.Drawing.Font("Kristen ITC", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleBio.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleBio.Location = New System.Drawing.Point(142, 291)
        Me.TitleBio.Name = "TitleBio"
        Me.TitleBio.Size = New System.Drawing.Size(60, 30)
        Me.TitleBio.TabIndex = 40
        Me.TitleBio.Text = "Bio:"
        Me.TitleBio.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtBio
        '
        Me.txtBio.Enabled = False
        Me.txtBio.Font = New System.Drawing.Font("Kristen ITC", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBio.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtBio.Location = New System.Drawing.Point(219, 291)
        Me.txtBio.Multiline = True
        Me.txtBio.Name = "txtBio"
        Me.txtBio.Size = New System.Drawing.Size(272, 97)
        Me.txtBio.TabIndex = 51
        Me.txtBio.Text = "Describe something about yourself......"
        '
        'picEdit
        '
        Me.picEdit.BackgroundImage = CType(resources.GetObject("picEdit.BackgroundImage"), System.Drawing.Image)
        Me.picEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEdit.Location = New System.Drawing.Point(503, 293)
        Me.picEdit.Name = "picEdit"
        Me.picEdit.Size = New System.Drawing.Size(30, 28)
        Me.picEdit.TabIndex = 52
        Me.picEdit.TabStop = False
        '
        'picDone
        '
        Me.picDone.BackgroundImage = CType(resources.GetObject("picDone.BackgroundImage"), System.Drawing.Image)
        Me.picDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDone.Location = New System.Drawing.Point(503, 292)
        Me.picDone.Name = "picDone"
        Me.picDone.Size = New System.Drawing.Size(30, 28)
        Me.picDone.TabIndex = 53
        Me.picDone.TabStop = False
        Me.picDone.Visible = False
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.txtBio)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnChgPW)
        Me.Controls.Add(Me.TitleEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.TitleBio)
        Me.Controls.Add(Me.TitleGender)
        Me.Controls.Add(Me.TitleName)
        Me.Controls.Add(Me.lblProfile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picDone)
        Me.Controls.Add(Me.picEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Profile"
        Me.Text = "Profile"
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picProfile As PictureBox
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnChgPW As Button
    Friend WithEvents TitleEmail As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblName As Label
    Friend WithEvents TitleGender As Label
    Friend WithEvents TitleName As Label
    Friend WithEvents lblProfile As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UploadPhoto As OpenFileDialog
    Friend WithEvents TitleBio As Label
    Friend WithEvents txtBio As TextBox
    Friend WithEvents picEdit As PictureBox
    Friend WithEvents picDone As PictureBox
End Class
