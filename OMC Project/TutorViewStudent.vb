'TutorViewStudent.vb
Imports System.Data.OleDb
Public Class TutorViewStudent
    'Variable Declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim UserName, DateSubmit, Status, SubjectName As String
    Dim RegistrationID As Integer
    Private Sub TutorViewStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear all rows before inserting the new info from the database
        ClearRows(tableViewStudent, 1)
        'COnnection to access database
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        con.Open()
        'Display subject name
        sql = "SELECT * FROM Subject WHERE SubjectID=" & TutorClass.SubID
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
        sql = " SELECT * FROM Registration INNER Join [User] On Registration.UserID=[User].UserID WHERE Registration.SubjectID=" & TutorClass.SubID
        cmd = New OleDbCommand(sql, con)
        check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                RegistrationID = rd("RegistrationID").ToString
                UserName = rd("UserName").ToString
                DateSubmit = rd("DateSubmit").ToString
                Status = rd("Status").ToString
                'handle returned value before next loop here
                tableViewStudent.GrowStyle = TableLayoutPanelGrowStyle.AddRows
                tableViewStudent.RowStyles.Add(New RowStyle(SizeType.Absolute, 45.0!))
                tableViewStudent.RowCount += 1
                '
                'PanelViewStudent
                '
                Dim PanelViewStudent As New Panel
                PanelViewStudent.BackColor = SystemColors.ButtonHighlight
                PanelViewStudent.Location = New Point(3, 63)
                PanelViewStudent.Size = New Size(745, 35)
                PanelViewStudent.Dock = DockStyle.Top
                '
                'lblName
                '
                Dim lblName As New Label
                lblName.AutoSize = True
                lblName.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblName.ForeColor = SystemColors.WindowFrame
                lblName.Location = New Point(16, 3)
                lblName.Size = New Size(95, 24)
                lblName.Text = UserName
                lblName.TextAlign = ContentAlignment.TopCenter
                '
                'lblDate
                '
                Dim lblDate As New Label
                lblDate.AutoSize = True
                lblDate.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblDate.ForeColor = SystemColors.WindowFrame
                lblDate.Location = New Point(300, 3)
                lblDate.Size = New Size(72, 24)
                lblDate.Text = FormatDateTime(DateSubmit, DateFormat.ShortDate)
                lblDate.TextAlign = ContentAlignment.TopCenter
                'Check if student is being approved in the course
                If Status = False Then
                    '
                    'btnVerify
                    '
                    Dim btnVerify As New Button
                    btnVerify.FlatAppearance.BorderColor = SystemColors.ScrollBar
                    btnVerify.FlatAppearance.BorderSize = 2
                    btnVerify.Font = New Font("Kristen ITC", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                    btnVerify.ForeColor = SystemColors.WindowFrame
                    btnVerify.BackColor = SystemColors.ScrollBar
                    btnVerify.Location = New Point(445, 0)
                    btnVerify.Size = New Size(60, 29)
                    btnVerify.Text = "Verify"
                    btnVerify.UseVisualStyleBackColor = False
                    btnVerify.Tag = RegistrationID
                    AddHandler btnVerify.Click, AddressOf btnVerify_Click
                    'Add button into the panel
                    PanelViewStudent.Controls.Add(btnVerify)
                Else
                    '
                    'lblApprove
                    '
                    Dim lblApprove As New Label
                    lblApprove.AutoSize = True
                    lblApprove.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                    lblApprove.ForeColor = SystemColors.WindowFrame
                    lblApprove.Location = New Point(430, 3)
                    lblApprove.Size = New Size(72, 24)
                    lblApprove.Text = "Approved"
                    lblApprove.TextAlign = ContentAlignment.TopCenter
                    PanelViewStudent.Controls.Add(lblApprove)
                End If
                '
                'Label1
                '
                Dim label1 As New Label
                label1.BackColor = SystemColors.ScrollBar
                label1.Dock = DockStyle.Bottom
                label1.Location = New Point(0, 36)
                label1.Size = New Size(745, 3)
                'Add all element into panel
                PanelViewStudent.Controls.Add(lblName)
                PanelViewStudent.Controls.Add(lblDate)
                PanelViewStudent.Controls.Add(label1)
                tableViewStudent.Controls.Add(PanelViewStudent, 0, tableViewStudent.RowCount - 1)
            End While
        Else
            'Clear rows before inserting new data into the table
            ClearRows(tableViewStudent, 1)
            tableViewStudent.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            tableViewStudent.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            tableViewStudent.RowCount += 1
            '
            'PanelViewStudent            
            '
            Dim PanelViewStudent As New Panel
            PanelViewStudent.BackColor = SystemColors.ButtonHighlight
            PanelViewStudent.Location = New Point(31, 185)
            PanelViewStudent.Size = New Size(745, 39)
            PanelViewStudent.TabIndex = 8
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
            lblNoRecord.Text = "No Student Found"
            lblNoRecord.TextAlign = ContentAlignment.TopCenter
            '
            'Add element to panel 2
            PanelViewStudent.Controls.Add(label3)
            PanelViewStudent.Controls.Add(lblNoRecord)
            tableViewStudent.Controls.Add(PanelViewStudent, 0, 1)
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
    Public RegID As String
    Private Sub btnVerify_Click(sender As Object, e As EventArgs)
        'Open TutorVerifyStudentForm
        Dim btnVerify As Button = DirectCast(sender, Button)
        RegID = CInt(btnVerify.Tag)
        SideButton.OpenChildFormRefresh(TutorVerifyStudent)
    End Sub
End Class