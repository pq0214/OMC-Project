<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TutorStudent
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
        Me.tableStudentClass = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TitleSubject = New System.Windows.Forms.Label()
        Me.TitleDate = New System.Windows.Forms.Label()
        Me.TitleStudent = New System.Windows.Forms.Label()
        Me.tableStudentClass.SuspendLayout()
        Me.PanelTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Kristen ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblTitle.Location = New System.Drawing.Point(28, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(131, 54)
        Me.lblTitle.TabIndex = 31
        Me.lblTitle.Text = "Class"
        '
        'tableStudentClass
        '
        Me.tableStudentClass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tableStudentClass.AutoScroll = True
        Me.tableStudentClass.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tableStudentClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tableStudentClass.ColumnCount = 1
        Me.tableStudentClass.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 752.0!))
        Me.tableStudentClass.Controls.Add(Me.PanelTitle, 0, 0)
        Me.tableStudentClass.Location = New System.Drawing.Point(34, 80)
        Me.tableStudentClass.Name = "tableStudentClass"
        Me.tableStudentClass.RowCount = 1
        Me.tableStudentClass.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tableStudentClass.Size = New System.Drawing.Size(752, 426)
        Me.tableStudentClass.TabIndex = 30
        '
        'PanelTitle
        '
        Me.PanelTitle.AutoScroll = True
        Me.PanelTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelTitle.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelTitle.Controls.Add(Me.Label2)
        Me.PanelTitle.Controls.Add(Me.TitleSubject)
        Me.PanelTitle.Controls.Add(Me.TitleDate)
        Me.PanelTitle.Controls.Add(Me.TitleStudent)
        Me.PanelTitle.Location = New System.Drawing.Point(3, 3)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(746, 55)
        Me.PanelTitle.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(746, 3)
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
        Me.TitleDate.Location = New System.Drawing.Point(288, 13)
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
        Me.TitleStudent.Location = New System.Drawing.Point(451, 13)
        Me.TitleStudent.Name = "TitleStudent"
        Me.TitleStudent.Size = New System.Drawing.Size(98, 28)
        Me.TitleStudent.TabIndex = 1
        Me.TitleStudent.Text = "Student"
        '
        'TutorStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.tableStudentClass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TutorStudent"
        Me.Text = "StudentClass"
        Me.tableStudentClass.ResumeLayout(False)
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents tableStudentClass As TableLayoutPanel
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TitleSubject As Label
    Friend WithEvents TitleDate As Label
    Friend WithEvents TitleStudent As Label
End Class
