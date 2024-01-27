<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutorStudentList
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
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.tableStudentList = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TitleName = New System.Windows.Forms.Label()
        Me.TitleDate = New System.Windows.Forms.Label()
        Me.TitleProgress = New System.Windows.Forms.Label()
        Me.tableStudentList.SuspendLayout()
        Me.PanelTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.BackColor = System.Drawing.Color.Transparent
        Me.lblSubject.Font = New System.Drawing.Font("Kristen ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblSubject.Location = New System.Drawing.Point(28, 19)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(311, 54)
        Me.lblSubject.TabIndex = 33
        Me.lblSubject.Text = "Subject Name"
        '
        'tableStudentList
        '
        Me.tableStudentList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tableStudentList.AutoScroll = True
        Me.tableStudentList.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tableStudentList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tableStudentList.ColumnCount = 1
        Me.tableStudentList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 752.0!))
        Me.tableStudentList.Controls.Add(Me.PanelTitle, 0, 0)
        Me.tableStudentList.Location = New System.Drawing.Point(34, 84)
        Me.tableStudentList.Name = "tableStudentList"
        Me.tableStudentList.RowCount = 1
        Me.tableStudentList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tableStudentList.Size = New System.Drawing.Size(752, 426)
        Me.tableStudentList.TabIndex = 32
        '
        'PanelTitle
        '
        Me.PanelTitle.AutoScroll = True
        Me.PanelTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelTitle.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelTitle.Controls.Add(Me.Label2)
        Me.PanelTitle.Controls.Add(Me.TitleName)
        Me.PanelTitle.Controls.Add(Me.TitleDate)
        Me.PanelTitle.Controls.Add(Me.TitleProgress)
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
        'TitleName
        '
        Me.TitleName.AutoSize = True
        Me.TitleName.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleName.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleName.Location = New System.Drawing.Point(16, 13)
        Me.TitleName.Name = "TitleName"
        Me.TitleName.Size = New System.Drawing.Size(72, 28)
        Me.TitleName.TabIndex = 3
        Me.TitleName.Text = "Name"
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
        'TitleProgress
        '
        Me.TitleProgress.AutoSize = True
        Me.TitleProgress.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleProgress.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleProgress.Location = New System.Drawing.Point(439, 13)
        Me.TitleProgress.Name = "TitleProgress"
        Me.TitleProgress.Size = New System.Drawing.Size(104, 28)
        Me.TitleProgress.TabIndex = 1
        Me.TitleProgress.Text = "Progress"
        '
        'TutorStudentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.tableStudentList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TutorStudentList"
        Me.Text = "TutorStudentList"
        Me.tableStudentList.ResumeLayout(False)
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSubject As Label
    Friend WithEvents tableStudentList As TableLayoutPanel
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TitleName As Label
    Friend WithEvents TitleDate As Label
    Friend WithEvents TitleProgress As Label
End Class
