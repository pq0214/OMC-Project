<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.txtCurrentPW = New System.Windows.Forms.TextBox()
        Me.txtConfirmPW = New System.Windows.Forms.TextBox()
        Me.txtNewPW = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.TitlePassword = New System.Windows.Forms.Label()
        Me.TitleNewPW = New System.Windows.Forms.Label()
        Me.TitleCurrentPW = New System.Windows.Forms.Label()
        Me.lblProfile = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShow.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.chkShow.Location = New System.Drawing.Point(324, 403)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(174, 28)
        Me.chkShow.TabIndex = 48
        Me.chkShow.Text = "Show Password"
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'txtCurrentPW
        '
        Me.txtCurrentPW.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtCurrentPW.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPW.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCurrentPW.Location = New System.Drawing.Point(404, 169)
        Me.txtCurrentPW.Name = "txtCurrentPW"
        Me.txtCurrentPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCurrentPW.Size = New System.Drawing.Size(290, 35)
        Me.txtCurrentPW.TabIndex = 47
        '
        'txtConfirmPW
        '
        Me.txtConfirmPW.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtConfirmPW.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPW.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtConfirmPW.Location = New System.Drawing.Point(404, 344)
        Me.txtConfirmPW.Name = "txtConfirmPW"
        Me.txtConfirmPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPW.Size = New System.Drawing.Size(290, 35)
        Me.txtConfirmPW.TabIndex = 46
        '
        'txtNewPW
        '
        Me.txtNewPW.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtNewPW.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPW.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtNewPW.Location = New System.Drawing.Point(404, 250)
        Me.txtNewPW.Name = "txtNewPW"
        Me.txtNewPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPW.Size = New System.Drawing.Size(290, 35)
        Me.txtNewPW.TabIndex = 45
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnOK.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnOK.Location = New System.Drawing.Point(649, 455)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(138, 52)
        Me.btnOK.TabIndex = 44
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'TitlePassword
        '
        Me.TitlePassword.AutoSize = True
        Me.TitlePassword.BackColor = System.Drawing.Color.Transparent
        Me.TitlePassword.Font = New System.Drawing.Font("Kristen ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitlePassword.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitlePassword.Location = New System.Drawing.Point(72, 337)
        Me.TitlePassword.Name = "TitlePassword"
        Me.TitlePassword.Size = New System.Drawing.Size(314, 42)
        Me.TitlePassword.TabIndex = 43
        Me.TitlePassword.Text = "Confirm Password:"
        Me.TitlePassword.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitleNewPW
        '
        Me.TitleNewPW.AutoSize = True
        Me.TitleNewPW.BackColor = System.Drawing.Color.Transparent
        Me.TitleNewPW.Font = New System.Drawing.Font("Kristen ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleNewPW.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleNewPW.Location = New System.Drawing.Point(130, 250)
        Me.TitleNewPW.Name = "TitleNewPW"
        Me.TitleNewPW.Size = New System.Drawing.Size(256, 42)
        Me.TitleNewPW.TabIndex = 42
        Me.TitleNewPW.Text = "New Password:"
        Me.TitleNewPW.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TitleCurrentPW
        '
        Me.TitleCurrentPW.AutoSize = True
        Me.TitleCurrentPW.BackColor = System.Drawing.Color.Transparent
        Me.TitleCurrentPW.Font = New System.Drawing.Font("Kristen ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleCurrentPW.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleCurrentPW.Location = New System.Drawing.Point(89, 169)
        Me.TitleCurrentPW.Name = "TitleCurrentPW"
        Me.TitleCurrentPW.Size = New System.Drawing.Size(297, 42)
        Me.TitleCurrentPW.TabIndex = 41
        Me.TitleCurrentPW.Text = "Current Pasword:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.lblProfile.TabIndex = 40
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
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "______________________"
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.chkShow)
        Me.Controls.Add(Me.txtCurrentPW)
        Me.Controls.Add(Me.txtConfirmPW)
        Me.Controls.Add(Me.txtNewPW)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.TitlePassword)
        Me.Controls.Add(Me.TitleNewPW)
        Me.Controls.Add(Me.TitleCurrentPW)
        Me.Controls.Add(Me.lblProfile)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChangePassword"
        Me.Text = "ChangePassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkShow As CheckBox
    Friend WithEvents txtCurrentPW As TextBox
    Friend WithEvents txtConfirmPW As TextBox
    Friend WithEvents txtNewPW As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents TitlePassword As Label
    Friend WithEvents TitleNewPW As Label
    Friend WithEvents TitleCurrentPW As Label
    Friend WithEvents lblProfile As Label
    Friend WithEvents Label2 As Label
End Class
