<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PDFReader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PDFReader))
        Me.AxAcroPDF = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.AxAcroPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxAcroPDF
        '
        Me.AxAcroPDF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF.Enabled = True
        Me.AxAcroPDF.Location = New System.Drawing.Point(0, 0)
        Me.AxAcroPDF.Name = "AxAcroPDF"
        Me.AxAcroPDF.OcxState = CType(resources.GetObject("AxAcroPDF.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF.Size = New System.Drawing.Size(814, 734)
        Me.AxAcroPDF.TabIndex = 0
        '
        'PDFReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(814, 734)
        Me.Controls.Add(Me.AxAcroPDF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PDFReader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PDFReader"
        CType(Me.AxAcroPDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxAcroPDF As AxAcroPDFLib.AxAcroPDF
End Class
