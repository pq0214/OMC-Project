'TutorClass.vb
Imports System.Data.OleDb
Public Class TutorClass
    'Variable Declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim SubjectName, DateSubmit, Status As String
    Dim SubjectID, NoStudent As Integer
    Private Sub TutorClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear rows before new data is inserted into the table
        ClearRows(tableTutorClass, 1)
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        con.Open()
        Dim UserID As String = Login.GlobalVariables.UserID
        sql = "SELECT * FROM Subject INNER Join [User] On Subject.UserID=[User].UserID WHERE Subject.UserID=" & UserID
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                SubjectID = rd("SubjectID").ToString
                SubjectName = rd("SubjectName").ToString
                DateSubmit = rd("DateSubmit").ToString
                Status = rd("Status").ToString
                'handle returned value before next loop here
                tableTutorClass.GrowStyle = TableLayoutPanelGrowStyle.AddRows
                tableTutorClass.RowStyles.Add(New RowStyle(SizeType.Absolute, 45.0!))
                tableTutorClass.RowCount += 1
                '
                'PanelTutorClass
                '
                Dim PanelTutorClass As New Panel
                PanelTutorClass.BackColor = SystemColors.ButtonHighlight
                PanelTutorClass.Location = New Point(3, 63)
                PanelTutorClass.Size = New Size(745, 35)
                PanelTutorClass.Dock = DockStyle.Top
                '
                'lblSubject
                '
                Dim lblSubject As New Label
                lblSubject.AutoSize = True
                lblSubject.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblSubject.ForeColor = SystemColors.WindowFrame
                lblSubject.Location = New Point(10, 3)
                lblSubject.Size = New Size(95, 24)
                lblSubject.Text = SubjectName
                lblSubject.TextAlign = ContentAlignment.TopCenter
                '
                'lblDate
                '
                Dim lblDate As New Label
                lblDate.AutoSize = True
                lblDate.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblDate.ForeColor = SystemColors.WindowFrame
                lblDate.Location = New Point(180, 3)
                lblDate.Size = New Size(72, 24)
                lblDate.Text = FormatDateTime(DateSubmit, DateFormat.ShortDate)
                lblDate.TextAlign = ContentAlignment.TopCenter
                '
                'lblNo
                '
                Dim lblNo As New Label
                lblNo.AutoSize = True
                lblNo.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblNo.Location = New Point(320, 3)
                lblNo.Size = New Size(90, 24)
                lblNo.TextAlign = ContentAlignment.TopCenter
                'Calculate No of Student in the subject
                Dim sql1 = "SELECT Count(UserID) As NoStudent FROM Registration WHERE SubjectID=" & SubjectID
                Dim cmd1 = New OleDbCommand(sql1, con)
                Dim check1 = Convert.ToInt32(cmd1.ExecuteScalar())
                Dim rd1 = cmd1.ExecuteReader()
                rd1.Read()
                NoStudent = rd1("NoStudent")
                lblNo.Text = NoStudent & "/5"
                If NoStudent = 5 Then
                    lblNo.ForeColor = Color.DarkRed
                Else
                    lblNo.ForeColor = SystemColors.WindowFrame
                End If
                'Check if subject verification approved
                If Status = True Then
                    '
                    'btnClass
                    '
                    Dim btnClass As New Button
                    btnClass.FlatAppearance.BorderColor = SystemColors.ScrollBar
                    btnClass.FlatAppearance.BorderSize = 2
                    btnClass.Font = New Font("Kristen ITC", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                    btnClass.ForeColor = SystemColors.WindowFrame
                    btnClass.BackColor = SystemColors.ScrollBar
                    btnClass.Location = New Point(410, 0)
                    btnClass.Size = New Size(68, 29)
                    btnClass.TabIndex = 1
                    btnClass.Text = "Class"
                    btnClass.UseVisualStyleBackColor = False
                    btnClass.Tag = SubjectID
                    AddHandler btnClass.Click, AddressOf btnClass_Click
                    '
                    'btnStudent
                    '
                    Dim btnStudent As New Button
                    btnStudent.FlatAppearance.BorderColor = SystemColors.ScrollBar
                    btnStudent.FlatAppearance.BorderSize = 2
                    btnStudent.Font = New Font("Kristen ITC", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                    btnStudent.ForeColor = SystemColors.WindowFrame
                    btnStudent.BackColor = SystemColors.ScrollBar
                    btnStudent.Location = New Point(480, 0)
                    btnStudent.Size = New Size(68, 29)
                    btnStudent.TabIndex = 2
                    btnStudent.Text = "Student"
                    btnStudent.UseVisualStyleBackColor = False
                    btnStudent.Tag = SubjectID
                    AddHandler btnStudent.Click, AddressOf btnStudent_Click
                    'Add button to panel
                    PanelTutorClass.Controls.Add(btnClass)
                    PanelTutorClass.Controls.Add(btnStudent)
                Else
                    '
                    'lblPending
                    '
                    Dim lblPending As New Label
                    lblPending.AutoSize = True
                    lblPending.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                    lblPending.ForeColor = SystemColors.WindowFrame
                    lblPending.Location = New Point(410, 3)
                    lblPending.Size = New Size(72, 24)
                    lblPending.Text = "Verification Pending"
                    lblPending.TextAlign = ContentAlignment.TopCenter
                    PanelTutorClass.Controls.Add(lblPending)
                End If
                '
                'Label1
                '
                Dim label1 As New Label
                label1.BackColor = SystemColors.ScrollBar
                label1.Dock = DockStyle.Bottom
                label1.Location = New Point(0, 36)
                label1.Size = New Size(745, 3)
                'Add all element to panel
                PanelTutorClass.Controls.Add(label1)
                PanelTutorClass.Controls.Add(lblSubject)
                PanelTutorClass.Controls.Add(lblDate)
                PanelTutorClass.Controls.Add(lblNo)
                tableTutorClass.Controls.Add(PanelTutorClass, 0, tableTutorClass.RowCount - 1)
            End While
        Else
            'Clear rows before inserting new data to the table
            ClearRows(tableTutorClass, 1)
            tableTutorClass.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            tableTutorClass.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            tableTutorClass.RowCount += 1
            '
            'PanelTutorClass
            '
            Dim PanelTutorClass As New Panel
            PanelTutorClass.BackColor = SystemColors.ButtonHighlight
            PanelTutorClass.Location = New Point(31, 185)
            PanelTutorClass.Size = New Size(745, 39)
            '
            'Label3
            '
            Dim label3 As New Label
            label3.BackColor = SystemColors.ScrollBar
            label3.Dock = DockStyle.Bottom
            label3.Location = New Point(0, 36)
            label3.Size = New Size(745, 3)
            '
            'lblNoRecord
            '
            Dim lblNoRecord As New Label
            lblNoRecord.AutoSize = True
            lblNoRecord.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            lblNoRecord.ForeColor = SystemColors.WindowFrame
            lblNoRecord.Location = New Point(200, 5)
            lblNoRecord.Size = New Size(255, 24)
            lblNoRecord.Text = "No Classes Found"
            lblNoRecord.TextAlign = ContentAlignment.MiddleCenter
            '
            'Add element to panel 2
            PanelTutorClass.Controls.Add(label3)
            PanelTutorClass.Controls.Add(lblNoRecord)
            tableTutorClass.Controls.Add(PanelTutorClass, 0, 1)
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
    Public SubID As Integer
    Private Sub btnClass_Click(sender As Object, e As EventArgs)
        'Open TutorViewMaterial Form
        Dim btnClass As Button = DirectCast(sender, Button)
        TutorViewMaterial.SubID = CInt(btnClass.Tag)
        SideButton.OpenChildFormRefresh(TutorViewMaterial)
    End Sub
    Private Sub btnStudent_Click(sender As Object, e As EventArgs)
        'Open TutorViewStudent Form
        Dim btnStudent As Button = DirectCast(sender, Button)
        SubID = CInt(btnStudent.Tag)
        SideButton.OpenChildFormRefresh(TutorViewStudent)
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Open TutorAddClass Form
        SideButton.OpenChildFormRefresh(TutorAddClass)
    End Sub
End Class