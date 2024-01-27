'TutorStudent.vb
Imports System.Data.OleDb
Public Class TutorStudent
    'Variable Declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim SubjectName, DateSubmit As String
    Dim SubjectID, NoStudent As Integer
    Private Sub StudentClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UserID As String = Login.GlobalVariables.UserID
        'Clear rows before new data is inserted into the table
        ClearRows(tableStudentClass, 1)
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        con.Open()
        sql = "SELECT * FROM Subject INNER Join [User] On Subject.UserID=[User].UserID WHERE Status=True AND Subject.UserID=" & UserID
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                SubjectID = rd("SubjectID")
                SubjectName = rd("SubjectName").ToString
                DateSubmit = rd("DateSubmit").ToString
                'handle returned value before next loop here
                tableStudentClass.GrowStyle = TableLayoutPanelGrowStyle.AddRows
                tableStudentClass.RowStyles.Add(New RowStyle(SizeType.Absolute, 45.0!))
                tableStudentClass.RowCount += 1
                '
                'PanelStudentClass
                '
                Dim PanelStudentClass As New Panel
                PanelStudentClass.BackColor = SystemColors.ButtonHighlight
                PanelStudentClass.Location = New Point(3, 63)
                PanelStudentClass.Size = New Size(745, 35)
                PanelStudentClass.Dock = DockStyle.Top
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
                lblDate.Location = New Point(215, 3)
                lblDate.Size = New Size(72, 24)
                lblDate.Text = FormatDateTime(DateSubmit, DateFormat.ShortDate)
                lblDate.TextAlign = ContentAlignment.TopCenter
                '
                'lblNo
                '
                Dim lblNo As New Label
                lblNo.AutoSize = True
                lblNo.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblNo.Location = New Point(355, 3)
                lblNo.Size = New Size(90, 24)
                lblNo.TextAlign = ContentAlignment.TopCenter
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
                '
                'btnView
                '
                Dim btnView As New Button
                btnView.FlatAppearance.BorderColor = SystemColors.ScrollBar
                btnView.FlatAppearance.BorderSize = 2
                btnView.Font = New Font("Kristen ITC", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                btnView.ForeColor = SystemColors.WindowFrame
                btnView.BackColor = SystemColors.ScrollBar
                btnView.Location = New Point(445, 0)
                btnView.Size = New Size(68, 29)
                btnView.TabIndex = 1
                btnView.Text = "View"
                btnView.UseVisualStyleBackColor = False
                btnView.Tag = SubjectID
                AddHandler btnView.Click, AddressOf btnView_Click
                '
                'Label1
                '
                Dim label1 As New Label
                label1.BackColor = SystemColors.ScrollBar
                label1.Dock = DockStyle.Bottom
                label1.Location = New Point(0, 36)
                label1.Size = New Size(745, 3)

                'Add all element to panel
                PanelStudentClass.Controls.Add(label1)
                PanelStudentClass.Controls.Add(lblSubject)
                PanelStudentClass.Controls.Add(lblDate)
                PanelStudentClass.Controls.Add(lblNo)
                PanelStudentClass.Controls.Add(btnView)
                tableStudentClass.Controls.Add(PanelStudentClass, 0, tableStudentClass.RowCount - 1)
            End While
        Else
            'Clear rows before new data is inserted into the table
            ClearRows(tableStudentClass, 1)
            tableStudentClass.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            tableStudentClass.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            tableStudentClass.RowCount += 1
            'Panel2
            '
            Dim Panel2 As New Panel
            Panel2.BackColor = SystemColors.ButtonHighlight
            Panel2.Location = New Point(31, 185)
            Panel2.Size = New Size(745, 39)
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
            lblNoRecord.Text = "No Subject Found"
            lblNoRecord.TextAlign = ContentAlignment.MiddleCenter
            '
            'Add element to panel 2
            Panel2.Controls.Add(label3)
            Panel2.Controls.Add(lblNoRecord)
            tableStudentClass.Controls.Add(Panel2, 0, 1)
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
    Private Sub btnView_Click(sender As Object, e As EventArgs)
        'Open TutorStudentList Form
        Dim btnView As Button = DirectCast(sender, Button)
        TutorStudentList.SubID = CInt(btnView.Tag)
        SideButton.OpenChildFormRefresh(TutorStudentList)
    End Sub
End Class