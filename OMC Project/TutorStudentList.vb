'TutorStudentList.vb
Imports System.Data.OleDb
Public Class TutorStudentList
    'Variable Declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim SubjectName, UserName, DateSubmit, Payment, Status As String
    Dim RegistrationID, UserID, MaterialNo, CompletedNo As Integer
    Public SubID As Integer
    Private Sub TutorStudentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        con.Open()
        '-----------------------------Display Subject Name-----------------------------
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
        '-----------------------------Display Student List-----------------------------
        'Clears rows before add new data into the table
        ClearRows(tableStudentList, 1)
        sql = "SELECT * FROM Registration INNER Join [User] On Registration.UserID=[User].UserID WHERE SubjectID=" & SubID
        cmd = New OleDbCommand(sql, con)
        check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                UserID = rd("Registration.UserID")
                RegistrationID = rd("RegistrationID")
                UserName = rd("UserName").ToString
                DateSubmit = rd("DateSubmit").ToString
                Payment = rd("Payment").ToString
                Status = rd("Status").ToString
                'handle returned value before next loop here
                tableStudentList.GrowStyle = TableLayoutPanelGrowStyle.AddRows
                tableStudentList.RowStyles.Add(New RowStyle(SizeType.Absolute, 45.0!))
                tableStudentList.RowCount += 1
                '
                'PanelTutorStudentList
                '
                Dim PanelTutorStudentList As New Panel
                PanelTutorStudentList.BackColor = SystemColors.ButtonHighlight
                PanelTutorStudentList.Location = New Point(3, 63)
                PanelTutorStudentList.Size = New Size(745, 35)
                PanelTutorStudentList.Dock = DockStyle.Top
                '
                'lblName
                '
                Dim lblName As New Label
                lblName.AutoSize = True
                lblName.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblName.ForeColor = SystemColors.WindowFrame
                lblName.Location = New Point(10, 3)
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
                lblDate.Location = New Point(210, 3)
                lblDate.Size = New Size(72, 24)
                lblDate.Text = FormatDateTime(DateSubmit, DateFormat.ShortDate)
                lblDate.TextAlign = ContentAlignment.TopCenter
                'Display Status, btnView, PaymentPending
                If Status = True Then
                    If Payment = True Then
                        '
                        'lblProgress
                        '
                        Dim lblProgress As New Label
                        lblProgress.AutoSize = True
                        lblProgress.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                        lblProgress.ForeColor = SystemColors.WindowFrame
                        lblProgress.Location = New Point(340, 3)
                        lblProgress.Size = New Size(90, 24)
                        '--------------------------Display Progress---------------------------
                        Dim sql1 As String = "SELECT COUNT(MaterialID) As MaterialNo FROM Material WHERE SubjectID=" & SubID
                        Dim cmd1 = New OleDbCommand(sql1, con)
                        Dim check1 = Convert.ToInt32(cmd1.ExecuteScalar())
                        'Set initial value to 0 and get No of material for the entire subject
                        MaterialNo = 0
                        If check1 > 0 Then
                            Dim rd1 As OleDbDataReader = cmd1.ExecuteReader()
                            While rd1.Read()
                                MaterialNo = rd1("MaterialNo")
                            End While
                            rd1.Close()
                            Dim sql2 As String = "SELECT COUNT(ProgressID) As CompletedNo FROM Progress WHERE UserID=" & UserID & " AND SubjectID=" & SubID
                            Dim cmd2 = New OleDbCommand(sql2, con)
                            Dim check2 = Convert.ToInt32(cmd2.ExecuteScalar())
                            'Set initial value to 0 and get No of material completed for the entire subject
                            CompletedNo = 0
                            If check2 > 0 Then
                                Dim rd2 As OleDbDataReader = cmd2.ExecuteReader()
                                While rd2.Read()
                                    CompletedNo = rd2("CompletedNo")
                                End While
                                rd2.Close()
                            Else
                                CompletedNo = 0
                            End If
                            'Calculate Progress
                            lblProgress.Text = Str((CompletedNo / MaterialNo) * 100) + "/100"
                        Else
                            lblProgress.Text = "No Material"
                        End If
                        PanelTutorStudentList.Controls.Add(lblProgress)
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
                        btnView.Tag = RegistrationID
                        AddHandler btnView.Click, AddressOf btnView_Click
                        PanelTutorStudentList.Controls.Add(btnView)
                    Else
                        '
                        'lblPaymentPending
                        '
                        Dim lblPaymentPending As New Label
                        lblPaymentPending.AutoSize = True
                        lblPaymentPending.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                        lblPaymentPending.ForeColor = SystemColors.WindowFrame
                        lblPaymentPending.Location = New Point(340, 3)
                        lblPaymentPending.Size = New Size(72, 24)
                        lblPaymentPending.Text = "Payment Pending"
                        lblPaymentPending.TextAlign = ContentAlignment.TopCenter
                        PanelTutorStudentList.Controls.Add(lblPaymentPending)
                    End If
                Else
                    '
                    'lblPending
                    '
                    Dim lblPending As New Label
                    lblPending.AutoSize = True
                    lblPending.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                    lblPending.ForeColor = SystemColors.WindowFrame
                    lblPending.Location = New Point(340, 3)
                    lblPending.Size = New Size(72, 24)
                    lblPending.Text = "Verification Pending"
                    lblPending.TextAlign = ContentAlignment.TopCenter
                    PanelTutorStudentList.Controls.Add(lblPending)
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
                PanelTutorStudentList.Controls.Add(label1)
                PanelTutorStudentList.Controls.Add(lblName)
                PanelTutorStudentList.Controls.Add(lblDate)
                tableStudentList.Controls.Add(PanelTutorStudentList, 0, tableStudentList.RowCount - 1)
            End While
        Else
            'Clears rows before add new data into the table
            ClearRows(tableStudentList, 1)
            tableStudentList.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            tableStudentList.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            tableStudentList.RowCount += 1
            '
            'PanelTutorStudentList
            '
            Dim PanelTutorStudentList As New Panel
            PanelTutorStudentList.BackColor = SystemColors.ButtonHighlight
            PanelTutorStudentList.Location = New Point(31, 185)
            PanelTutorStudentList.Size = New Size(745, 39)
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
            lblNoRecord.Text = "No Student Found"
            lblNoRecord.TextAlign = ContentAlignment.MiddleCenter
            '
            'Add element to panel 2
            PanelTutorStudentList.Controls.Add(label3)
            PanelTutorStudentList.Controls.Add(lblNoRecord)
            tableStudentList.Controls.Add(PanelTutorStudentList, 0, 1)
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
        'OpenTutorStudentData Form
        Dim btnView As Button = DirectCast(sender, Button)
        TutorStudentData.RegistrationID = btnView.Tag
        SideButton.OpenChildFormRefresh(TutorStudentData)
    End Sub
End Class
