<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnCreateAcc = New System.Windows.Forms.Button()
        Me.rbtFemale = New System.Windows.Forms.RadioButton()
        Me.rbtMale = New System.Windows.Forms.RadioButton()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.PanelGender = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.PanelUser = New System.Windows.Forms.Panel()
        Me.rbtStudent = New System.Windows.Forms.RadioButton()
        Me.rbtTutor = New System.Windows.Forms.RadioButton()
        Me.btnLogin = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGender.SuspendLayout()
        Me.PanelUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(86, -22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(285, 176)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.Font = New System.Drawing.Font("Kristen ITC", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShow.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.chkShow.Location = New System.Drawing.Point(49, 253)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(141, 22)
        Me.chkShow.TabIndex = 51
        Me.chkShow.Text = "Show Password"
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Menu
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Kristen ITC", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtPassword.Location = New System.Drawing.Point(47, 216)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(371, 32)
        Me.txtPassword.TabIndex = 50
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblPassword.Location = New System.Drawing.Point(48, 189)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(97, 24)
        Me.lblPassword.TabIndex = 49
        Me.lblPassword.Text = "Password"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Menu
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Kristen ITC", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtName.Location = New System.Drawing.Point(46, 146)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(372, 32)
        Me.txtName.TabIndex = 48
        Me.txtName.Text = "Your Name"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblName.Location = New System.Drawing.Point(48, 119)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(62, 24)
        Me.lblName.TabIndex = 47
        Me.lblName.Text = "Name"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Menu
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Kristen ITC", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtEmail.Location = New System.Drawing.Point(47, 311)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(372, 32)
        Me.txtEmail.TabIndex = 53
        Me.txtEmail.Text = "xxx@utp.edu.my"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblEmail.Location = New System.Drawing.Point(53, 284)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(60, 24)
        Me.lblEmail.TabIndex = 52
        Me.lblEmail.Text = "Email"
        '
        'btnCreateAcc
        '
        Me.btnCreateAcc.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCreateAcc.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateAcc.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAcc.ForeColor = System.Drawing.SystemColors.Menu
        Me.btnCreateAcc.Location = New System.Drawing.Point(52, 471)
        Me.btnCreateAcc.Name = "btnCreateAcc"
        Me.btnCreateAcc.Size = New System.Drawing.Size(173, 46)
        Me.btnCreateAcc.TabIndex = 54
        Me.btnCreateAcc.Text = "Sign Up"
        Me.btnCreateAcc.UseVisualStyleBackColor = False
        '
        'rbtFemale
        '
        Me.rbtFemale.AutoSize = True
        Me.rbtFemale.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFemale.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.rbtFemale.Location = New System.Drawing.Point(6, 6)
        Me.rbtFemale.Name = "rbtFemale"
        Me.rbtFemale.Size = New System.Drawing.Size(79, 26)
        Me.rbtFemale.TabIndex = 0
        Me.rbtFemale.TabStop = True
        Me.rbtFemale.Text = "Female"
        Me.rbtFemale.UseVisualStyleBackColor = True
        '
        'rbtMale
        '
        Me.rbtMale.AutoSize = True
        Me.rbtMale.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMale.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.rbtMale.Location = New System.Drawing.Point(96, 6)
        Me.rbtMale.Name = "rbtMale"
        Me.rbtMale.Size = New System.Drawing.Size(67, 26)
        Me.rbtMale.TabIndex = 1
        Me.rbtMale.TabStop = True
        Me.rbtMale.Text = "Male"
        Me.rbtMale.UseVisualStyleBackColor = True
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblGender.Location = New System.Drawing.Point(48, 364)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(79, 24)
        Me.lblGender.TabIndex = 57
        Me.lblGender.Text = "Gender"
        '
        'PanelGender
        '
        Me.PanelGender.Controls.Add(Me.rbtMale)
        Me.PanelGender.Controls.Add(Me.rbtFemale)
        Me.PanelGender.Location = New System.Drawing.Point(140, 358)
        Me.PanelGender.Name = "PanelGender"
        Me.PanelGender.Size = New System.Drawing.Size(273, 38)
        Me.PanelGender.TabIndex = 58
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblUser.Location = New System.Drawing.Point(48, 425)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(55, 24)
        Me.lblUser.TabIndex = 59
        Me.lblUser.Text = "User"
        '
        'PanelUser
        '
        Me.PanelUser.Controls.Add(Me.rbtStudent)
        Me.PanelUser.Controls.Add(Me.rbtTutor)
        Me.PanelUser.Location = New System.Drawing.Point(140, 419)
        Me.PanelUser.Name = "PanelUser"
        Me.PanelUser.Size = New System.Drawing.Size(273, 38)
        Me.PanelUser.TabIndex = 59
        '
        'rbtStudent
        '
        Me.rbtStudent.AutoSize = True
        Me.rbtStudent.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtStudent.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.rbtStudent.Location = New System.Drawing.Point(87, 6)
        Me.rbtStudent.Name = "rbtStudent"
        Me.rbtStudent.Size = New System.Drawing.Size(91, 26)
        Me.rbtStudent.TabIndex = 2
        Me.rbtStudent.TabStop = True
        Me.rbtStudent.Text = "Student"
        Me.rbtStudent.UseVisualStyleBackColor = True
        '
        'rbtTutor
        '
        Me.rbtTutor.AutoSize = True
        Me.rbtTutor.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtTutor.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.rbtTutor.Location = New System.Drawing.Point(5, 6)
        Me.rbtTutor.Name = "rbtTutor"
        Me.rbtTutor.Size = New System.Drawing.Size(75, 26)
        Me.rbtTutor.TabIndex = 1
        Me.rbtTutor.TabStop = True
        Me.rbtTutor.Text = "Tutor"
        Me.rbtTutor.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Kristen ITC", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnLogin.Location = New System.Drawing.Point(236, 471)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(183, 46)
        Me.btnLogin.TabIndex = 60
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(459, 538)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.PanelUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.PanelGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.btnCreateAcc)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.chkShow)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUp"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGender.ResumeLayout(False)
        Me.PanelGender.PerformLayout()
        Me.PanelUser.ResumeLayout(False)
        Me.PanelUser.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents chkShow As CheckBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnCreateAcc As Button
    Friend WithEvents rbtFemale As RadioButton
    Friend WithEvents rbtMale As RadioButton
    Friend WithEvents lblGender As Label
    Friend WithEvents PanelGender As Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents PanelUser As Panel
    Friend WithEvents rbtTutor As RadioButton
    Friend WithEvents rbtStudent As RadioButton
    Friend WithEvents btnLogin As Button
End Class
