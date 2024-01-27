<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutorAddClass
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblGroupLink = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.numPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtGrpLink = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Kristen ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblTitle.Location = New System.Drawing.Point(29, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(131, 54)
        Me.lblTitle.TabIndex = 79
        Me.lblTitle.Text = "Class"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblPrice.Location = New System.Drawing.Point(204, 167)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(76, 28)
        Me.lblPrice.TabIndex = 77
        Me.lblPrice.Text = "Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGroupLink
        '
        Me.lblGroupLink.AutoSize = True
        Me.lblGroupLink.BackColor = System.Drawing.Color.Transparent
        Me.lblGroupLink.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupLink.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblGroupLink.Location = New System.Drawing.Point(134, 229)
        Me.lblGroupLink.Name = "lblGroupLink"
        Me.lblGroupLink.Size = New System.Drawing.Size(142, 28)
        Me.lblGroupLink.TabIndex = 69
        Me.lblGroupLink.Text = "Group Link:"
        Me.lblGroupLink.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.BackColor = System.Drawing.Color.Transparent
        Me.lblSubject.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblSubject.Location = New System.Drawing.Point(179, 103)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(101, 28)
        Me.lblSubject.TabIndex = 66
        Me.lblSubject.Text = "Subject:"
        '
        'numPrice
        '
        Me.numPrice.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPrice.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.numPrice.Location = New System.Drawing.Point(286, 167)
        Me.numPrice.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New System.Drawing.Size(98, 31)
        Me.numPrice.TabIndex = 80
        Me.numPrice.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(390, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "/Class"
        '
        'txtSubject
        '
        Me.txtSubject.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtSubject.Location = New System.Drawing.Point(286, 103)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(384, 31)
        Me.txtSubject.TabIndex = 82
        '
        'txtGrpLink
        '
        Me.txtGrpLink.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrpLink.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtGrpLink.Location = New System.Drawing.Point(286, 229)
        Me.txtGrpLink.Multiline = True
        Me.txtGrpLink.Name = "txtGrpLink"
        Me.txtGrpLink.Size = New System.Drawing.Size(384, 181)
        Me.txtGrpLink.TabIndex = 83
        Me.txtGrpLink.Text = "Create link for student to join class"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAdd.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnAdd.Location = New System.Drawing.Point(308, 444)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(195, 43)
        Me.btnAdd.TabIndex = 84
        Me.btnAdd.Text = "Add Class"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'TutorAddClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtGrpLink)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numPrice)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblGroupLink)
        Me.Controls.Add(Me.lblSubject)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TutorAddClass"
        Me.Text = "TutorAddClass"
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblGroupLink As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents numPrice As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtGrpLink As TextBox
    Friend WithEvents btnAdd As Button
End Class
