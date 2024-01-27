<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentClassPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentClassPayment))
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.lblTimeSlot = New System.Windows.Forms.Label()
        Me.lblSubjectName = New System.Windows.Forms.Label()
        Me.TitleGender = New System.Windows.Forms.Label()
        Me.TitleSubject = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UploadPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.TitleBio = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.TitlePrice = New System.Windows.Forms.Label()
        Me.lblCardNo = New System.Windows.Forms.Label()
        Me.txtCardNo = New System.Windows.Forms.MaskedTextBox()
        Me.lblCVV = New System.Windows.Forms.Label()
        Me.txtCVV = New System.Windows.Forms.MaskedTextBox()
        Me.txtExpDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblExpDate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.picEdit = New System.Windows.Forms.PictureBox()
        Me.picDone = New System.Windows.Forms.PictureBox()
        Me.rbtMaster = New System.Windows.Forms.RadioButton()
        Me.rbtVISA = New System.Windows.Forms.RadioButton()
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPayment.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnPayment.Location = New System.Drawing.Point(321, 456)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(192, 52)
        Me.btnPayment.TabIndex = 63
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'lblTimeSlot
        '
        Me.lblTimeSlot.AutoSize = True
        Me.lblTimeSlot.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeSlot.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeSlot.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblTimeSlot.Location = New System.Drawing.Point(519, 160)
        Me.lblTimeSlot.Name = "lblTimeSlot"
        Me.lblTimeSlot.Size = New System.Drawing.Size(96, 24)
        Me.lblTimeSlot.TabIndex = 61
        Me.lblTimeSlot.Text = "TimeSlot"
        Me.lblTimeSlot.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSubjectName
        '
        Me.lblSubjectName.AutoSize = True
        Me.lblSubjectName.BackColor = System.Drawing.Color.Transparent
        Me.lblSubjectName.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectName.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblSubjectName.Location = New System.Drawing.Point(266, 160)
        Me.lblSubjectName.Name = "lblSubjectName"
        Me.lblSubjectName.Size = New System.Drawing.Size(140, 24)
        Me.lblSubjectName.TabIndex = 60
        Me.lblSubjectName.Text = "SubjectName"
        '
        'TitleGender
        '
        Me.TitleGender.AutoSize = True
        Me.TitleGender.BackColor = System.Drawing.Color.Transparent
        Me.TitleGender.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleGender.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleGender.Location = New System.Drawing.Point(450, 160)
        Me.TitleGender.Name = "TitleGender"
        Me.TitleGender.Size = New System.Drawing.Size(63, 24)
        Me.TitleGender.TabIndex = 57
        Me.TitleGender.Text = "Time:"
        Me.TitleGender.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitleSubject
        '
        Me.TitleSubject.AutoSize = True
        Me.TitleSubject.BackColor = System.Drawing.Color.Transparent
        Me.TitleSubject.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleSubject.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleSubject.Location = New System.Drawing.Point(169, 160)
        Me.TitleSubject.Name = "TitleSubject"
        Me.TitleSubject.Size = New System.Drawing.Size(91, 24)
        Me.TitleSubject.TabIndex = 56
        Me.TitleSubject.Text = "Subject:"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.BackColor = System.Drawing.Color.Transparent
        Me.lblPayment.Font = New System.Drawing.Font("Kristen ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblPayment.Location = New System.Drawing.Point(259, 24)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(291, 83)
        Me.lblPayment.TabIndex = 55
        Me.lblPayment.Text = "Payment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Kristen ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(47, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 83)
        Me.Label2.TabIndex = 54
        '
        'UploadPhoto
        '
        Me.UploadPhoto.FileName = "OpenFileDialog1"
        '
        'TitleBio
        '
        Me.TitleBio.AutoSize = True
        Me.TitleBio.BackColor = System.Drawing.Color.Transparent
        Me.TitleBio.Font = New System.Drawing.Font("Kristen ITC", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleBio.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleBio.Location = New System.Drawing.Point(325, 197)
        Me.TitleBio.Name = "TitleBio"
        Me.TitleBio.Size = New System.Drawing.Size(193, 28)
        Me.TitleBio.TabIndex = 58
        Me.TitleBio.Text = "Payment Method"
        Me.TitleBio.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblPrice.Location = New System.Drawing.Point(421, 329)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(62, 24)
        Me.lblPrice.TabIndex = 70
        Me.lblPrice.Text = "Price"
        '
        'TitlePrice
        '
        Me.TitlePrice.AutoSize = True
        Me.TitlePrice.BackColor = System.Drawing.Color.Transparent
        Me.TitlePrice.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitlePrice.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitlePrice.Location = New System.Drawing.Point(317, 329)
        Me.TitlePrice.Name = "TitlePrice"
        Me.TitlePrice.Size = New System.Drawing.Size(95, 24)
        Me.TitlePrice.TabIndex = 69
        Me.TitlePrice.Text = "Amount:"
        '
        'lblCardNo
        '
        Me.lblCardNo.AutoSize = True
        Me.lblCardNo.BackColor = System.Drawing.Color.Transparent
        Me.lblCardNo.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardNo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblCardNo.Location = New System.Drawing.Point(290, 366)
        Me.lblCardNo.Name = "lblCardNo"
        Me.lblCardNo.Size = New System.Drawing.Size(100, 24)
        Me.lblCardNo.TabIndex = 71
        Me.lblCardNo.Text = "Card No:"
        '
        'txtCardNo
        '
        Me.txtCardNo.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCardNo.Location = New System.Drawing.Point(396, 363)
        Me.txtCardNo.Mask = "0000-0000-0000-0000"
        Me.txtCardNo.Name = "txtCardNo"
        Me.txtCardNo.Size = New System.Drawing.Size(178, 31)
        Me.txtCardNo.TabIndex = 73
        Me.txtCardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCVV
        '
        Me.lblCVV.AutoSize = True
        Me.lblCVV.BackColor = System.Drawing.Color.Transparent
        Me.lblCVV.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCVV.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblCVV.Location = New System.Drawing.Point(246, 409)
        Me.lblCVV.Name = "lblCVV"
        Me.lblCVV.Size = New System.Drawing.Size(60, 24)
        Me.lblCVV.TabIndex = 74
        Me.lblCVV.Text = "CVV:"
        '
        'txtCVV
        '
        Me.txtCVV.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCVV.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCVV.Location = New System.Drawing.Point(312, 406)
        Me.txtCVV.Mask = "000"
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(51, 31)
        Me.txtCVV.TabIndex = 75
        Me.txtCVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExpDate
        '
        Me.txtExpDate.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpDate.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtExpDate.Location = New System.Drawing.Point(533, 410)
        Me.txtExpDate.Mask = "00/00"
        Me.txtExpDate.Name = "txtExpDate"
        Me.txtExpDate.Size = New System.Drawing.Size(70, 31)
        Me.txtExpDate.TabIndex = 76
        Me.txtExpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblExpDate
        '
        Me.lblExpDate.AutoSize = True
        Me.lblExpDate.BackColor = System.Drawing.Color.Transparent
        Me.lblExpDate.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpDate.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblExpDate.Location = New System.Drawing.Point(393, 413)
        Me.lblExpDate.Name = "lblExpDate"
        Me.lblExpDate.Size = New System.Drawing.Size(134, 24)
        Me.lblExpDate.TabIndex = 77
        Me.lblExpDate.Text = "Expire Date:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label5.Location = New System.Drawing.Point(33, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(756, 3)
        Me.Label5.TabIndex = 98
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblUserName.Location = New System.Drawing.Point(169, 122)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(110, 24)
        Me.lblUserName.TabIndex = 99
        Me.lblUserName.Text = "UserName"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picEdit
        '
        Me.picEdit.BackgroundImage = CType(resources.GetObject("picEdit.BackgroundImage"), System.Drawing.Image)
        Me.picEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEdit.Location = New System.Drawing.Point(454, 238)
        Me.picEdit.Name = "picEdit"
        Me.picEdit.Size = New System.Drawing.Size(149, 77)
        Me.picEdit.TabIndex = 67
        Me.picEdit.TabStop = False
        '
        'picDone
        '
        Me.picDone.BackgroundImage = CType(resources.GetObject("picDone.BackgroundImage"), System.Drawing.Image)
        Me.picDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDone.Location = New System.Drawing.Point(257, 237)
        Me.picDone.Name = "picDone"
        Me.picDone.Size = New System.Drawing.Size(149, 77)
        Me.picDone.TabIndex = 68
        Me.picDone.TabStop = False
        '
        'rbtMaster
        '
        Me.rbtMaster.AutoSize = True
        Me.rbtMaster.Location = New System.Drawing.Point(234, 238)
        Me.rbtMaster.Name = "rbtMaster"
        Me.rbtMaster.Size = New System.Drawing.Size(17, 16)
        Me.rbtMaster.TabIndex = 100
        Me.rbtMaster.TabStop = True
        Me.rbtMaster.UseVisualStyleBackColor = True
        '
        'rbtVISA
        '
        Me.rbtVISA.AutoSize = True
        Me.rbtVISA.Location = New System.Drawing.Point(431, 238)
        Me.rbtVISA.Name = "rbtVISA"
        Me.rbtVISA.Size = New System.Drawing.Size(17, 16)
        Me.rbtVISA.TabIndex = 101
        Me.rbtVISA.TabStop = True
        Me.rbtVISA.UseVisualStyleBackColor = True
        '
        'StudentClassPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.rbtVISA)
        Me.Controls.Add(Me.rbtMaster)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblExpDate)
        Me.Controls.Add(Me.txtExpDate)
        Me.Controls.Add(Me.txtCVV)
        Me.Controls.Add(Me.lblCVV)
        Me.Controls.Add(Me.txtCardNo)
        Me.Controls.Add(Me.lblCardNo)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.TitlePrice)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.lblTimeSlot)
        Me.Controls.Add(Me.lblSubjectName)
        Me.Controls.Add(Me.TitleGender)
        Me.Controls.Add(Me.TitleSubject)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TitleBio)
        Me.Controls.Add(Me.picDone)
        Me.Controls.Add(Me.picEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentClassPayment"
        Me.Text = "StudentClassPayment"
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPayment As Button
    Friend WithEvents lblTimeSlot As Label
    Friend WithEvents lblSubjectName As Label
    Friend WithEvents TitleGender As Label
    Friend WithEvents TitleSubject As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UploadPhoto As OpenFileDialog
    Friend WithEvents TitleBio As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents TitlePrice As Label
    Friend WithEvents lblCardNo As Label
    Friend WithEvents txtCardNo As MaskedTextBox
    Friend WithEvents lblCVV As Label
    Friend WithEvents txtCVV As MaskedTextBox
    Friend WithEvents txtExpDate As MaskedTextBox
    Friend WithEvents lblExpDate As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents picEdit As PictureBox
    Friend WithEvents picDone As PictureBox
    Friend WithEvents rbtMaster As RadioButton
    Friend WithEvents rbtVISA As RadioButton
End Class
