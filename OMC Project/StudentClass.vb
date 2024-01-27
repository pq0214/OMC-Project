'StudentClass.vb
Imports System.Data.OleDb
Public Class StudentClass
    'Variable Declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim SubjectName, DateSubmit, Status, Payment As String
    Dim RegistrationID, SubjectID, MaterialNo, CompletedNo As Integer
    Private Sub StudentClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UserID As String = Login.GlobalVariables.UserID
        'Clear row before new data is added into the table
        ClearRows(tableStudentClass, 1)
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        con.Open()
        sql = "SELECT * FROM Registration INNER Join Subject On Registration.SubjectID=Subject.SubjectID WHERE Registration.UserID=" & UserID
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                SubjectID = rd("Registration.SubjectID")
                RegistrationID = rd("RegistrationID")
                SubjectName = rd("SubjectName").ToString
                DateSubmit = rd("Registration.DateSubmit").ToString
                Status = rd("Registration.Status").ToString
                Payment = rd("Payment").ToString
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
                lblDate.Location = New Point(170, 3)
                lblDate.Size = New Size(72, 24)
                lblDate.Text = FormatDateTime(DateSubmit, DateFormat.ShortDate)
                lblDate.TextAlign = ContentAlignment.TopCenter
                '
                'lblNo
                '
                Dim lblProgress As New Label
                lblProgress.AutoSize = True
                lblProgress.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblProgress.ForeColor = SystemColors.WindowFrame
                lblProgress.Location = New Point(300, 3)
                lblProgress.Size = New Size(90, 24)
                '--------------------------Display Progress---------------------------
                'Check if registration is approved
                If Status = True Then
                    'Check if payment is made
                    If Payment = True Then
                        '
                        'btnView
                        '
                        Dim btnView As New Button
                        btnView.FlatAppearance.BorderColor = SystemColors.ScrollBar
                        btnView.FlatAppearance.BorderSize = 2
                        btnView.Font = New Font("Kristen ITC", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                        btnView.ForeColor = SystemColors.WindowFrame
                        btnView.BackColor = SystemColors.ScrollBar
                        btnView.Location = New Point(485, 0)
                        btnView.Size = New Size(68, 29)
                        btnView.TabIndex = 1
                        btnView.Text = "View"
                        btnView.UseVisualStyleBackColor = False
                        btnView.Tag = RegistrationID
                        AddHandler btnView.Click, AddressOf btnView_Click
                        PanelStudentClass.Controls.Add(btnView)
                        'Display progress if registration status is true(approve)
                        Dim sql1 As String = "SELECT COUNT(MaterialID) As MaterialNo FROM Material WHERE SubjectID=" & SubjectID
                        Dim cmd1 = New OleDbCommand(sql1, con)
                        Dim check1 = Convert.ToInt32(cmd1.ExecuteScalar())
                        If check1 > 0 Then
                            Dim rd1 As OleDbDataReader = cmd1.ExecuteReader()
                            While rd1.Read()
                                'Set initial value to 0 and get No of material for the entired subject
                                MaterialNo = 0
                                MaterialNo = rd1("MaterialNo")
                            End While
                            rd1.Close()
                            Dim sql2 As String = "SELECT COUNT(ProgressID) As CompletedNo FROM Progress WHERE UserID=" & UserID & " AND SubjectID=" & SubjectID
                            Dim cmd2 = New OleDbCommand(sql2, con)
                            Dim check2 = Convert.ToInt32(cmd2.ExecuteScalar())
                            If check2 > 0 Then
                                Dim rd2 As OleDbDataReader = cmd2.ExecuteReader()
                                'Set initial value to 0 and get No of material for the entired subject
                                CompletedNo = 0
                                While rd2.Read()
                                    CompletedNo = rd2("CompletedNo")
                                End While
                                rd2.Close()
                            Else
                                CompletedNo = 0
                            End If
                            'Calculated Progress
                            lblProgress.Text = Str((CompletedNo / MaterialNo) * 100) + "/100"
                        Else
                            'Display if no material is uploaded by tutor
                            lblProgress.Text = "No Material"
                        End If
                    Else
                        '
                        'btnPayment
                        '
                        Dim btnPayment As New Button
                        btnPayment.FlatAppearance.BorderColor = SystemColors.ScrollBar
                        btnPayment.FlatAppearance.BorderSize = 2
                        btnPayment.Font = New Font("Kristen ITC", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                        btnPayment.ForeColor = SystemColors.WindowFrame
                        btnPayment.BackColor = SystemColors.ScrollBar
                        btnPayment.Location = New Point(300, 0)
                        btnPayment.Size = New Size(68, 29)
                        btnPayment.TabIndex = 1
                        btnPayment.Text = "Payment"
                        btnPayment.UseVisualStyleBackColor = False
                        btnPayment.Tag = RegistrationID
                        AddHandler btnPayment.Click, AddressOf btnPayment_Click
                        PanelStudentClass.Controls.Add(btnPayment)
                    End If
                Else
                    lblProgress.Text = "Registration Pending"
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
                PanelStudentClass.Controls.Add(label1)
                PanelStudentClass.Controls.Add(lblSubject)
                PanelStudentClass.Controls.Add(lblDate)
                PanelStudentClass.Controls.Add(lblProgress)
                tableStudentClass.Controls.Add(PanelStudentClass, 0, tableStudentClass.RowCount - 1)
            End While
        Else
            'Clear rows before new data is added into the table
            ClearRows(tableStudentClass, 1)
            tableStudentClass.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            tableStudentClass.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            tableStudentClass.RowCount += 1
            '
            'PanelStudentClass
            '
            Dim PanelStudentClass As New Panel
            PanelStudentClass.BackColor = SystemColors.ButtonHighlight
            PanelStudentClass.Location = New Point(31, 185)
            PanelStudentClass.Size = New Size(745, 39)
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
            lblNoRecord.Text = "No Subject Register"
            lblNoRecord.TextAlign = ContentAlignment.MiddleCenter
            '
            'Add element to panel 2
            PanelStudentClass.Controls.Add(label3)
            PanelStudentClass.Controls.Add(lblNoRecord)
            tableStudentClass.Controls.Add(PanelStudentClass, 0, 1)
        End If
        con.Close()
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs)
        'Open StudentClassData Form
        Dim btnView As Button = DirectCast(sender, Button)
        StudentClassData.RegistrationID = btnView.Tag
        SideButton.OpenChildFormRefresh(StudentClassData)
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
    Private Sub btnPayment_Click(sender As Object, e As EventArgs)
        'Open StudentClassPayment Form
        Dim btnPayment As Button = DirectCast(sender, Button)
        StudentClassPayment.RegistrationID = btnPayment.Tag
        SideButton.OpenChildFormRefresh(StudentClassPayment)
    End Sub
End Class