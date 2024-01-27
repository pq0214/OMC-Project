<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleNote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScheduleNote))
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.picSave = New System.Windows.Forms.PictureBox()
        Me.picEdit = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.PictureBox()
        CType(Me.picSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Kristen ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.Location = New System.Drawing.Point(11, 14)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(76, 28)
        Me.lblNotes.TabIndex = 5
        Me.lblNotes.Text = "Notes"
        '
        'txtNotes
        '
        Me.txtNotes.Enabled = False
        Me.txtNotes.Font = New System.Drawing.Font("Kristen ITC", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtNotes.Location = New System.Drawing.Point(16, 54)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(454, 315)
        Me.txtNotes.TabIndex = 4
        Me.txtNotes.Text = "Write some notes......"
        '
        'picSave
        '
        Me.picSave.BackgroundImage = CType(resources.GetObject("picSave.BackgroundImage"), System.Drawing.Image)
        Me.picSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSave.Location = New System.Drawing.Point(393, 11)
        Me.picSave.Name = "picSave"
        Me.picSave.Size = New System.Drawing.Size(30, 31)
        Me.picSave.TabIndex = 7
        Me.picSave.TabStop = False
        Me.picSave.Visible = False
        '
        'picEdit
        '
        Me.picEdit.BackgroundImage = CType(resources.GetObject("picEdit.BackgroundImage"), System.Drawing.Image)
        Me.picEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picEdit.Location = New System.Drawing.Point(393, 11)
        Me.picEdit.Name = "picEdit"
        Me.picEdit.Size = New System.Drawing.Size(30, 31)
        Me.picEdit.TabIndex = 6
        Me.picEdit.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Location = New System.Drawing.Point(429, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(41, 43)
        Me.btnExit.TabIndex = 8
        Me.btnExit.TabStop = False
        '
        'ScheduleNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(480, 380)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picSave)
        Me.Controls.Add(Me.picEdit)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.txtNotes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ScheduleNote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScheduleNote"
        CType(Me.picSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSave As PictureBox
    Friend WithEvents picEdit As PictureBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnExit As PictureBox
End Class
