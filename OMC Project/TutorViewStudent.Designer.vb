<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutorViewStudent
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
        Me.tableViewStudent = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.TitleStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TitleDate = New System.Windows.Forms.Label()
        Me.TitleName = New System.Windows.Forms.Label()
        Me.OpenMaterial = New System.Windows.Forms.OpenFileDialog()
        Me.tableViewStudent.SuspendLayout()
        Me.PanelTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.BackColor = System.Drawing.Color.Transparent
        Me.lblSubject.Font = New System.Drawing.Font("Kristen ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblSubject.Location = New System.Drawing.Point(28, 15)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(311, 54)
        Me.lblSubject.TabIndex = 31
        Me.lblSubject.Text = "Subject Name"
        '
        'tableViewStudent
        '
        Me.tableViewStudent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tableViewStudent.AutoScroll = True
        Me.tableViewStudent.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tableViewStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tableViewStudent.ColumnCount = 1
        Me.tableViewStudent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 752.0!))
        Me.tableViewStudent.Controls.Add(Me.PanelTitle, 0, 0)
        Me.tableViewStudent.Location = New System.Drawing.Point(34, 80)
        Me.tableViewStudent.Name = "tableViewStudent"
        Me.tableViewStudent.RowCount = 2
        Me.tableViewStudent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tableViewStudent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableViewStudent.Size = New System.Drawing.Size(752, 426)
        Me.tableViewStudent.TabIndex = 30
        '
        'PanelTitle
        '
        Me.PanelTitle.AutoScroll = True
        Me.PanelTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelTitle.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelTitle.Controls.Add(Me.TitleStatus)
        Me.PanelTitle.Controls.Add(Me.Label2)
        Me.PanelTitle.Controls.Add(Me.TitleDate)
        Me.PanelTitle.Controls.Add(Me.TitleName)
        Me.PanelTitle.Location = New System.Drawing.Point(3, 3)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(745, 54)
        Me.PanelTitle.TabIndex = 0
        '
        'TitleStatus
        '
        Me.TitleStatus.AutoSize = True
        Me.TitleStatus.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleStatus.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleStatus.Location = New System.Drawing.Point(586, 13)
        Me.TitleStatus.Name = "TitleStatus"
        Me.TitleStatus.Size = New System.Drawing.Size(81, 28)
        Me.TitleStatus.TabIndex = 7
        Me.TitleStatus.Text = "Status"
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
        'TitleDate
        '
        Me.TitleDate.AutoSize = True
        Me.TitleDate.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleDate.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleDate.Location = New System.Drawing.Point(408, 13)
        Me.TitleDate.Name = "TitleDate"
        Me.TitleDate.Size = New System.Drawing.Size(65, 28)
        Me.TitleDate.TabIndex = 2
        Me.TitleDate.Text = "Date"
        '
        'TitleName
        '
        Me.TitleName.AutoSize = True
        Me.TitleName.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleName.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleName.Location = New System.Drawing.Point(16, 13)
        Me.TitleName.Name = "TitleName"
        Me.TitleName.Size = New System.Drawing.Size(72, 28)
        Me.TitleName.TabIndex = 0
        Me.TitleName.Text = "Name"
        '
        'OpenMaterial
        '
        Me.OpenMaterial.FileName = "OpenFileDialog1"
        '
        'TutorViewStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.tableViewStudent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TutorViewStudent"
        Me.Text = "TutorViewStudent"
        Me.tableViewStudent.ResumeLayout(False)
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSubject As Label
    Friend WithEvents tableViewStudent As TableLayoutPanel
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TitleDate As Label
    Friend WithEvents TitleName As Label
    Friend WithEvents OpenMaterial As OpenFileDialog
    Friend WithEvents TitleStatus As Label
End Class
