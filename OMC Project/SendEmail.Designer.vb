<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SendEmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SendEmail))
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chbShowPassword = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnClear.Location = New System.Drawing.Point(590, 49)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(181, 53)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear Message"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnSend.Location = New System.Drawing.Point(590, 125)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(181, 53)
        Me.btnSend.TabIndex = 7
        Me.btnSend.Text = "Send Email"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBody)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtSubject)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtTo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.GroupBox2.Location = New System.Drawing.Point(21, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(764, 303)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New Message"
        '
        'txtBody
        '
        Me.txtBody.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBody.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtBody.Location = New System.Drawing.Point(103, 123)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(647, 163)
        Me.txtBody.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label5.Location = New System.Drawing.Point(41, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 22)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Body:"
        '
        'txtSubject
        '
        Me.txtSubject.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtSubject.Location = New System.Drawing.Point(103, 82)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(270, 28)
        Me.txtSubject.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label4.Location = New System.Drawing.Point(22, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Subject:"
        '
        'txtTo
        '
        Me.txtTo.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtTo.Location = New System.Drawing.Point(103, 45)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.ReadOnly = True
        Me.txtTo.Size = New System.Drawing.Size(270, 28)
        Me.txtTo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label3.Location = New System.Drawing.Point(59, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chbShowPassword)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.GroupBox1.Location = New System.Drawing.Point(21, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(418, 147)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Log In"
        '
        'chbShowPassword
        '
        Me.chbShowPassword.AutoSize = True
        Me.chbShowPassword.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbShowPassword.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.chbShowPassword.Location = New System.Drawing.Point(103, 115)
        Me.chbShowPassword.Name = "chbShowPassword"
        Me.chbShowPassword.Size = New System.Drawing.Size(160, 26)
        Me.chbShowPassword.TabIndex = 3
        Me.chbShowPassword.Text = "Show Password"
        Me.chbShowPassword.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtPassword.Location = New System.Drawing.Point(103, 83)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(270, 28)
        Me.txtPassword.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtEmail.Location = New System.Drawing.Point(103, 43)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(270, 28)
        Me.txtEmail.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label2.Location = New System.Drawing.Point(7, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(41, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Email:"
        '
        'picExit
        '
        Me.picExit.BackgroundImage = CType(resources.GetObject("picExit.BackgroundImage"), System.Drawing.Image)
        Me.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picExit.Location = New System.Drawing.Point(773, -1)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(41, 43)
        Me.picExit.TabIndex = 9
        Me.picExit.TabStop = False
        '
        'SendEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.picExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SendEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SendEmail"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSend As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBody As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chbShowPassword As CheckBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents picExit As PictureBox
End Class
