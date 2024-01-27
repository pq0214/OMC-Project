<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminView
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
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableTutor = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.BackColor = System.Drawing.Color.Transparent
        Me.lblUserType.Font = New System.Drawing.Font("Kristen ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserType.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblUserType.Location = New System.Drawing.Point(25, 12)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(145, 54)
        Me.lblUserType.TabIndex = 27
        Me.lblUserType.Text = "Tutor"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label2.Location = New System.Drawing.Point(31, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(756, 3)
        Me.Label2.TabIndex = 28
        '
        'TableTutor
        '
        Me.TableTutor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableTutor.AutoScroll = True
        Me.TableTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TableTutor.ColumnCount = 1
        Me.TableTutor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 753.0!))
        Me.TableTutor.Location = New System.Drawing.Point(34, 84)
        Me.TableTutor.Name = "TableTutor"
        Me.TableTutor.RowCount = 1
        Me.TableTutor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 422.0!))
        Me.TableTutor.Size = New System.Drawing.Size(753, 422)
        Me.TableTutor.TabIndex = 29
        '
        'AdminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 529)
        Me.Controls.Add(Me.TableTutor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblUserType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminTutor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserType As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableTutor As TableLayoutPanel
End Class
