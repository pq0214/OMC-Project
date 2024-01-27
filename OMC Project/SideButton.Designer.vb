<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SideButton
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SideButton))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picHome = New System.Windows.Forms.PictureBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlChildForm = New System.Windows.Forms.Panel()
        Me.picAbout = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.picHome)
        Me.Panel2.Location = New System.Drawing.Point(-6, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(181, 123)
        Me.Panel2.TabIndex = 3
        '
        'picHome
        '
        Me.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picHome.Image = CType(resources.GetObject("picHome.Image"), System.Drawing.Image)
        Me.picHome.Location = New System.Drawing.Point(2, -3)
        Me.picHome.Name = "picHome"
        Me.picHome.Size = New System.Drawing.Size(182, 122)
        Me.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHome.TabIndex = 1
        Me.picHome.TabStop = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn1.Location = New System.Drawing.Point(31, 180)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(136, 53)
        Me.btn1.TabIndex = 5
        Me.btn1.Text = "Verify"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn2.Location = New System.Drawing.Point(31, 233)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(136, 53)
        Me.btn2.TabIndex = 6
        Me.btn2.Text = "Tutor"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn3.Location = New System.Drawing.Point(31, 286)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(136, 53)
        Me.btn3.TabIndex = 7
        Me.btn3.Text = "Student"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnProfile.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnProfile.Location = New System.Drawing.Point(31, 339)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(136, 53)
        Me.btnProfile.TabIndex = 8
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.Location = New System.Drawing.Point(31, 392)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(136, 53)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Log Out"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlChildForm
        '
        Me.pnlChildForm.BackColor = System.Drawing.SystemColors.Menu
        Me.pnlChildForm.Location = New System.Drawing.Point(205, 28)
        Me.pnlChildForm.Name = "pnlChildForm"
        Me.pnlChildForm.Size = New System.Drawing.Size(814, 529)
        Me.pnlChildForm.TabIndex = 18
        '
        'picAbout
        '
        Me.picAbout.BackgroundImage = CType(resources.GetObject("picAbout.BackgroundImage"), System.Drawing.Image)
        Me.picAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAbout.Location = New System.Drawing.Point(31, 516)
        Me.picAbout.Name = "picAbout"
        Me.picAbout.Size = New System.Drawing.Size(39, 39)
        Me.picAbout.TabIndex = 19
        Me.picAbout.TabStop = False
        '
        'SideButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1044, 582)
        Me.Controls.Add(Me.picAbout)
        Me.Controls.Add(Me.pnlChildForm)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SideButton"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NetGenius"
        Me.Panel2.ResumeLayout(False)
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAbout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picHome As PictureBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlChildForm As Panel
    Friend WithEvents picAbout As PictureBox
End Class
