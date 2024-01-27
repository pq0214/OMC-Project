<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminVerification
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
        Me.tableTutorVerification = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TitleSubject = New System.Windows.Forms.Label()
        Me.TitleDate = New System.Windows.Forms.Label()
        Me.TitleStatus = New System.Windows.Forms.Label()
        Me.TitleName = New System.Windows.Forms.Label()
        Me.tableTutorVerification.SuspendLayout()
        Me.PanelTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Kristen ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblTitle.Location = New System.Drawing.Point(25, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(406, 54)
        Me.lblTitle.TabIndex = 26
        Me.lblTitle.Text = "Tutor Verification"
        '
        'tableTutorVerification
        '
        Me.tableTutorVerification.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tableTutorVerification.AutoScroll = True
        Me.tableTutorVerification.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tableTutorVerification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tableTutorVerification.ColumnCount = 1
        Me.tableTutorVerification.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 745.0!))
        Me.tableTutorVerification.Controls.Add(Me.PanelTitle, 0, 0)
        Me.tableTutorVerification.Location = New System.Drawing.Point(31, 77)
        Me.tableTutorVerification.Name = "tableTutorVerification"
        Me.tableTutorVerification.RowCount = 1
        Me.tableTutorVerification.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tableTutorVerification.Size = New System.Drawing.Size(752, 426)
        Me.tableTutorVerification.TabIndex = 25
        '
        'PanelTitle
        '
        Me.PanelTitle.AutoScroll = True
        Me.PanelTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelTitle.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelTitle.Controls.Add(Me.Label2)
        Me.PanelTitle.Controls.Add(Me.TitleSubject)
        Me.PanelTitle.Controls.Add(Me.TitleDate)
        Me.PanelTitle.Controls.Add(Me.TitleStatus)
        Me.PanelTitle.Controls.Add(Me.TitleName)
        Me.PanelTitle.Location = New System.Drawing.Point(3, 3)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(745, 55)
        Me.PanelTitle.TabIndex = 0
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
        Me.TitleSubject.Location = New System.Drawing.Point(201, 13)
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
        Me.TitleDate.Location = New System.Drawing.Point(449, 13)
        Me.TitleDate.Name = "TitleDate"
        Me.TitleDate.Size = New System.Drawing.Size(65, 28)
        Me.TitleDate.TabIndex = 2
        Me.TitleDate.Text = "Date"
        '
        'TitleStatus
        '
        Me.TitleStatus.AutoSize = True
        Me.TitleStatus.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleStatus.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleStatus.Location = New System.Drawing.Point(616, 13)
        Me.TitleStatus.Name = "TitleStatus"
        Me.TitleStatus.Size = New System.Drawing.Size(81, 28)
        Me.TitleStatus.TabIndex = 1
        Me.TitleStatus.Text = "Status"
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
        'AdminVerification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.tableTutorVerification)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminVerification"
        Me.Text = "AdminVerification"
        Me.tableTutorVerification.ResumeLayout(False)
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents tableTutorVerification As TableLayoutPanel
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents TitleStatus As Label
    Friend WithEvents TitleName As Label
    Friend WithEvents TitleSubject As Label
    Friend WithEvents TitleDate As Label
    Friend WithEvents Label2 As Label
End Class
