<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TutorViewMaterial
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
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.tableViewMaterial = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TitleDate = New System.Windows.Forms.Label()
        Me.TitleMaterial = New System.Windows.Forms.Label()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.OpenMaterial = New System.Windows.Forms.OpenFileDialog()
        Me.tableViewMaterial.SuspendLayout()
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
        Me.lblSubject.TabIndex = 28
        Me.lblSubject.Text = "Subject Name"
        '
        'tableViewMaterial
        '
        Me.tableViewMaterial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tableViewMaterial.AutoScroll = True
        Me.tableViewMaterial.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tableViewMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tableViewMaterial.ColumnCount = 1
        Me.tableViewMaterial.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 752.0!))
        Me.tableViewMaterial.Controls.Add(Me.PanelTitle, 0, 0)
        Me.tableViewMaterial.Location = New System.Drawing.Point(34, 84)
        Me.tableViewMaterial.Name = "tableViewMaterial"
        Me.tableViewMaterial.RowCount = 2
        Me.tableViewMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tableViewMaterial.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableViewMaterial.Size = New System.Drawing.Size(752, 379)
        Me.tableViewMaterial.TabIndex = 27
        '
        'PanelTitle
        '
        Me.PanelTitle.AutoScroll = True
        Me.PanelTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelTitle.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelTitle.Controls.Add(Me.Label2)
        Me.PanelTitle.Controls.Add(Me.TitleDate)
        Me.PanelTitle.Controls.Add(Me.TitleMaterial)
        Me.PanelTitle.Location = New System.Drawing.Point(3, 3)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(745, 54)
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
        'TitleMaterial
        '
        Me.TitleMaterial.AutoSize = True
        Me.TitleMaterial.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleMaterial.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TitleMaterial.Location = New System.Drawing.Point(16, 13)
        Me.TitleMaterial.Name = "TitleMaterial"
        Me.TitleMaterial.Size = New System.Drawing.Size(103, 28)
        Me.TitleMaterial.TabIndex = 0
        Me.TitleMaterial.Text = "Material"
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnUpload.Font = New System.Drawing.Font("Kristen ITC", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnUpload.Location = New System.Drawing.Point(318, 474)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(195, 43)
        Me.btnUpload.TabIndex = 4
        Me.btnUpload.Text = "Upload Material"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'OpenMaterial
        '
        Me.OpenMaterial.FileName = "OpenFileDialog1"
        '
        'TutorViewMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.tableViewMaterial)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TutorViewMaterial"
        Me.Text = "TutorViewMaterial"
        Me.tableViewMaterial.ResumeLayout(False)
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSubject As Label
    Friend WithEvents tableViewMaterial As TableLayoutPanel
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TitleDate As Label
    Friend WithEvents TitleMaterial As Label
    Friend WithEvents btnUpload As Button
    Friend WithEvents OpenMaterial As OpenFileDialog
End Class
