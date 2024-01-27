'TutorViewMaterial.vb
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles
Imports System.IO
Public Class TutorViewMaterial
    'Variable Declaratoin
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim SubjectName, MaterialName, DateSubmit, MaterialFile As String
    Dim MaterialID As Integer
    Public SubID As Integer
    Private Sub TutorViewMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear all rows before inserting new data into the table
        ClearRows(tableViewMaterial, 1)
        'Connection to access database
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        con.Open()
        'Display subject name
        sql = "SELECT * FROM Subject WHERE SubjectID=" & SubID
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                SubjectName = rd("SubjectName").ToString
            End While
        End If
        lblSubject.Text = SubjectName
        'Display material information
        sql = "SELECT * FROM Material WHERE SubjectID=" & SubID
        cmd = New OleDbCommand(sql, con)
        check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                MaterialID = rd("MaterialID").ToString
                DateSubmit = rd("DateSubmit").ToString
                MaterialName = rd("MaterialName").ToString
                MaterialFile = rd("MaterialFile").ToString
                'handle returned value before next loop here
                tableViewMaterial.GrowStyle = TableLayoutPanelGrowStyle.AddRows
                tableViewMaterial.RowStyles.Add(New RowStyle(SizeType.Absolute, 45.0!))
                tableViewMaterial.RowCount += 1
                '
                'PanelViewMaterial
                '
                Dim PanelViewMaterial As New Panel
                PanelViewMaterial.BackColor = SystemColors.ButtonHighlight
                PanelViewMaterial.Location = New Point(3, 63)
                PanelViewMaterial.Size = New Size(745, 35)
                PanelViewMaterial.Dock = DockStyle.Top
                '
                'lblMaterial
                '
                Dim lblMaterial As New Label
                lblMaterial.AutoSize = True
                lblMaterial.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblMaterial.ForeColor = SystemColors.WindowFrame
                lblMaterial.Location = New Point(10, 3)
                lblMaterial.Size = New Size(95, 24)
                lblMaterial.Text = MaterialName
                lblMaterial.TextAlign = ContentAlignment.Center
                '
                'lblDate
                '
                Dim lblDate As New Label
                lblDate.AutoSize = True
                lblDate.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblDate.ForeColor = SystemColors.WindowFrame
                lblDate.Location = New Point(305, 3)
                lblDate.Size = New Size(72, 24)
                lblDate.Text = FormatDateTime(DateSubmit, DateFormat.ShortDate)
                lblDate.TextAlign = ContentAlignment.Center
                '
                'btnDelete
                '
                Dim btnDelete As New Button
                btnDelete.FlatAppearance.BorderColor = SystemColors.ScrollBar
                btnDelete.FlatAppearance.BorderSize = 2
                btnDelete.Font = New Font("Kristen ITC", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                btnDelete.ForeColor = SystemColors.WindowFrame
                btnDelete.BackColor = SystemColors.ScrollBar
                btnDelete.Location = New Point(420, 0)
                btnDelete.Size = New Size(60, 29)
                btnDelete.Text = "Delete"
                btnDelete.UseVisualStyleBackColor = False
                btnDelete.Tag = MaterialID
                AddHandler btnDelete.Click, AddressOf btnDelete_Click
                '
                'btnView
                '
                Dim btnView As New Button
                btnView.FlatAppearance.BorderColor = SystemColors.ScrollBar
                btnView.FlatAppearance.BorderSize = 2
                btnView.Font = New Font("Kristen ITC", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                btnView.ForeColor = SystemColors.WindowFrame
                btnView.BackColor = SystemColors.ScrollBar
                btnView.Location = New Point(480, 0)
                btnView.Size = New Size(60, 29)
                btnView.Text = "View"
                btnView.UseVisualStyleBackColor = False
                btnView.Tag = MaterialFile
                AddHandler btnView.Click, AddressOf btnView_Click
                '
                'Label1
                '
                Dim label1 As New Label
                label1.BackColor = SystemColors.ScrollBar
                label1.Dock = DockStyle.Bottom
                label1.Location = New Point(0, 36)
                label1.Size = New Size(745, 3)
                'Add all element into panel
                PanelViewMaterial.Controls.Add(btnDelete)
                PanelViewMaterial.Controls.Add(btnView)
                PanelViewMaterial.Controls.Add(lblMaterial)
                PanelViewMaterial.Controls.Add(lblDate)
                PanelViewMaterial.Controls.Add(label1)
                tableViewMaterial.Controls.Add(PanelViewMaterial, 0, tableViewMaterial.RowCount - 1)
            End While
        Else
            'Clear all rows before inserting new data into the table
            ClearRows(tableViewMaterial, 1)
            tableViewMaterial.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            tableViewMaterial.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            tableViewMaterial.RowCount += 1
            '
            'PanelViewMaterial            
            '
            Dim PanelViewMaterial As New Panel
            PanelViewMaterial.BackColor = SystemColors.ButtonHighlight
            PanelViewMaterial.Location = New Point(31, 185)
            PanelViewMaterial.Size = New Size(745, 39)
            PanelViewMaterial.TabIndex = 8
            '
            'Label3
            '
            Dim label3 As New Label
            label3.BackColor = SystemColors.ScrollBar
            label3.Dock = DockStyle.Bottom
            label3.Location = New Point(0, 36)
            label3.Size = New Size(745, 3)
            label3.TabIndex = 6
            '
            'lblNoRecord
            '
            Dim lblNoRecord As New Label
            lblNoRecord.AutoSize = True
            lblNoRecord.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            lblNoRecord.ForeColor = SystemColors.WindowFrame
            lblNoRecord.Location = New Point(200, 5)
            lblNoRecord.Size = New Size(255, 24)
            lblNoRecord.TabIndex = 3
            lblNoRecord.Text = "No Material Found"
            lblNoRecord.TextAlign = ContentAlignment.Center
            '
            'Add element to panel 2
            PanelViewMaterial.Controls.Add(label3)
            PanelViewMaterial.Controls.Add(lblNoRecord)
            tableViewMaterial.Controls.Add(PanelViewMaterial, 0, 1)
        End If
        con.Close()
    End Sub
    Private Sub ClearRows(tableLayoutPanel As TableLayoutPanel, startRow As Integer)
        ' Remove controls from the specified row till the end
        For row As Integer = tableLayoutPanel.RowCount - 1 To startRow Step -1
            For column As Integer = tableLayoutPanel.ColumnCount - 1 To 0 Step -1
                Dim control As Control = tableLayoutPanel.GetControlFromPosition(column, row)
                If control IsNot Nothing Then
                    tableLayoutPanel.Controls.Remove(control)
                    control.Dispose() ' Optionally, dispose of the control if necessary
                End If
            Next
            tableLayoutPanel.RowStyles.RemoveAt(row)
            tableLayoutPanel.RowCount -= 1
        Next
    End Sub
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Try
            'Initialize directory
            OpenMaterial.InitialDirectory = "C:\"
            'Set file type to only pdf
            OpenMaterial.Filter = "PDF | *.pdf"
            If OpenMaterial.ShowDialog = DialogResult.OK Then
                'Get file path name
                Dim filePath As String = OpenMaterial.FileName
                Dim fileName As String = Path.GetFileName(filePath)
                Dim fileNameWithoutPdf As String = RemovePdfExtension(fileName)
                ' Set the destination path and filename
                Dim destinationFilePath As String = "C:\Users\Lee Pei Qi\Documents\Material\" & SubID & fileName
                'Insert file path 
                Dim DateSubmit As Date = FormatDateTime(Today, DateFormat.ShortDate)
                con.Open()
                sql = "INSERT INTO Material([SubjectID], [MaterialName], [DateSubmit],[MaterialFile]) VALUES(@SubjectID,@MaterialName,@DateSubmit,@MaterialFile)"
                cmd = New OleDbCommand(sql, con)
                cmd.Parameters.AddWithValue("@SubjectID", SubID)
                cmd.Parameters.AddWithValue("@MaterialName", fileNameWithoutPdf)
                cmd.Parameters.AddWithValue("@DateSubmit", DateSubmit)
                cmd.Parameters.AddWithValue("@MaterialFile", destinationFilePath)
                rd = cmd.ExecuteReader()
                con.Close()
                ' Copy the file to the destination path
                File.Copy(filePath, destinationFilePath, True)
                MsgBox("File Successfully Uploaded", MsgBoxStyle.Information, "Material")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        TutorViewMaterial_Load(Me, EventArgs.Empty)
    End Sub
    Public Function RemovePdfExtension(fileName As String) As String
        'Remove pdf word from file name
        Dim fileNameWithoutExtension As String = IO.Path.GetFileNameWithoutExtension(fileName)
        Return fileNameWithoutExtension
    End Function
    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        'Delete Confirmation
        Dim btnDelete As Button = DirectCast(sender, Button)
        Dim response As String
        response = MsgBox("Do you want to delete this material?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Material")
        If response = MsgBoxResult.Yes Then
            con.Open()
            sql = "DELETE FROM Material WHERE MaterialID=" & btnDelete.Tag
            cmd = New OleDbCommand(sql, con)
            Dim check = Convert.ToInt32(cmd.ExecuteScalar())
            If check > 0 Then
                rd = cmd.ExecuteReader()
                While rd.Read()
                    MaterialFile = rd("MaterialFile").ToString
                End While
            End If
            cmd.ExecuteNonQuery()
            File.Delete(MaterialFile)
            MsgBox("Material Successfully Deleted!", MsgBoxStyle.Information, "Verification")
            con.Close()
        End If
        TutorViewMaterial_Load(Me, EventArgs.Empty)
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs)
        'Open Dialog PDFReader Form
        Dim btnView As Button = DirectCast(sender, Button)
        PDFReader.MaterialFile = btnView.Tag
        PDFReader.ShowDialog()
    End Sub
End Class