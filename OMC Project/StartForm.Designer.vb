<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        Me.LblReportProgress = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PBLoading1 = New System.Windows.Forms.ProgressBar()
        Me.LblStatustext = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblReportProgress
        '
        Me.LblReportProgress.AutoSize = True
        Me.LblReportProgress.Font = New System.Drawing.Font("Kristen ITC", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReportProgress.Location = New System.Drawing.Point(162, 291)
        Me.LblReportProgress.Name = "LblReportProgress"
        Me.LblReportProgress.Size = New System.Drawing.Size(137, 58)
        Me.LblReportProgress.TabIndex = 1
        Me.LblReportProgress.Text = "000%"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 40
        '
        'PBLoading1
        '
        Me.PBLoading1.Location = New System.Drawing.Point(50, 394)
        Me.PBLoading1.Name = "PBLoading1"
        Me.PBLoading1.Size = New System.Drawing.Size(353, 42)
        Me.PBLoading1.TabIndex = 2
        '
        'LblStatustext
        '
        Me.LblStatustext.AutoSize = True
        Me.LblStatustext.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatustext.Location = New System.Drawing.Point(128, 366)
        Me.LblStatustext.Name = "LblStatustext"
        Me.LblStatustext.Size = New System.Drawing.Size(197, 22)
        Me.LblStatustext.TabIndex = 3
        Me.LblStatustext.Text = "Launching Application...."
        Me.LblStatustext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-24, -36)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(503, 424)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(459, 538)
        Me.Controls.Add(Me.LblStatustext)
        Me.Controls.Add(Me.PBLoading1)
        Me.Controls.Add(Me.LblReportProgress)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StartForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblReportProgress As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PBLoading1 As ProgressBar
    Friend WithEvents LblStatustext As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
