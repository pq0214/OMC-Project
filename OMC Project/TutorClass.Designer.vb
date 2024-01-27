<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TutorClass
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tableTutorClass = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.TitleView = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TitleSubject = New System.Windows.Forms.Label()
        Me.TitleDate = New System.Windows.Forms.Label()
        Me.TitleStudent = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tableTutorClass.SuspendLayout()
        Me.PanelTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Kristen ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblTitle.Location = New System.Drawing.Point(28, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(131, 54)
        Me.lblTitle.TabIndex = 28
        Me.lblTitle.Text = "Class"
        '
        'tableTutorClass
        '
        Me.tableTutorClass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tableTutorClass.AutoScroll = True
        Me.tableTutorClass.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tableTutorClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tableTutorClass.ColumnCount = 1
        Me.tableTutorClass.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 752.0!))
        Me.tableTutorClass.Controls.Add(Me.PanelTitle, 0, 0)
        Me.tableTutorClass.Location = New System.Drawing.Point(34, 84)
        Me.tableTutorClass.Name = "tableTutorClass"
        Me.tableTutorClass.RowCount = 1
        Me.tableTutorClass.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tableTutorClass.Size = New System.Drawing.Size(752, 379)
        Me.tableTutorClass.TabIndex = 27
        '
        'PanelTitle
        '
        Me.PanelTitle.AutoScroll = True
        Me.PanelTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelTitle.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelTitle.Controls.Add(Me.TitleView)
        Me.PanelTitle.Controls.Add(Me.Label2)
        Me.PanelTitle.Controls.Add(Me.TitleSubject)
        Me.PanelTitle.Controls.Add(Me.TitleDate)
        Me.PanelTitle.Controls.Add(Me.TitleStudent)
        Me.PanelTitle.Location = New System.Drawing.Point(3, 3)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(745, 55)
        Me.PanelTitle.TabIndex = 0
        '
        'TitleView
        '
        Me.TitleView.AutoSize = True
        Me.TitleView.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleView.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleView.Location = New System.Drawing.Point(606, 13)
        Me.TitleView.Name = "TitleView"
        Me.TitleView.Size = New System.Drawing.Size(64, 28)
        Me.TitleView.TabIndex = 7
        Me.TitleView.Text = "View"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(745, 3)
        Me.Label2.TabIndex = 6
        '
        'TitleSubject
        '
        Me.TitleSubject.AutoSize = True
        Me.TitleSubject.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleSubject.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleSubject.Location = New System.Drawing.Point(16, 13)
        Me.TitleSubject.Name = "TitleSubject"
        Me.TitleSubject.Size = New System.Drawing.Size(94, 28)
        Me.TitleSubject.TabIndex = 3
        Me.TitleSubject.Text = "Subject"
        '
        'TitleDate
        '
        Me.TitleDate.AutoSize = True
        Me.TitleDate.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleDate.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleDate.Location = New System.Drawing.Point(249, 13)
        Me.TitleDate.Name = "TitleDate"
        Me.TitleDate.Size = New System.Drawing.Size(65, 28)
        Me.TitleDate.TabIndex = 2
        Me.TitleDate.Text = "Date"
        '
        'TitleStudent
        '
        Me.TitleStudent.AutoSize = True
        Me.TitleStudent.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleStudent.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleStudent.Location = New System.Drawing.Point(403, 13)
        Me.TitleStudent.Name = "TitleStudent"
        Me.TitleStudent.Size = New System.Drawing.Size(98, 28)
        Me.TitleStudent.TabIndex = 1
        Me.TitleStudent.Text = "Student"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAdd.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnAdd.Location = New System.Drawing.Point(318, 474)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(195, 43)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add Class"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'TutorClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.tableTutorClass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TutorClass"
        Me.Text = "TutorClass"
        Me.tableTutorClass.ResumeLayout(False)
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents tableTutorClass As TableLayoutPanel
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TitleSubject As Label
    Friend WithEvents TitleDate As Label
    Friend WithEvents TitleStudent As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents TitleView As Label
End Class
