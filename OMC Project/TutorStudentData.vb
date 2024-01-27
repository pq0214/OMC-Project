'TutorStudentData.vb
Imports System.Data.OleDb
Public Class TutorStudentData
    'Variable Declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim UserName, SubjectName, Profile, MaterialName As String
    Dim StudentID, SubjectID, MaterialNo, CompletedNo, MaterialID, Progress As Integer
    Dim Rating As Double
    Public RegistrationID As String
    Private Sub TutorStudentData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "SELECT * FROM Registration INNER Join [User] ON Registration.UserID=[User].UserID WHERE RegistrationID = " & RegistrationID & ";"
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            rd.Read()
            UserName = rd("UserName").ToString
            SubjectID = rd("SubjectID").ToString
            StudentID = rd("Registration.UserID").ToString
            If Not rd.IsDBNull(rd.GetOrdinal("Profile")) Then
                Profile = rd.GetString(rd.GetOrdinal("Profile"))
                picProfile.Image = Image.FromFile(Profile)
            Else
                picProfile.Image = Image.FromFile("C:\Users\Lee Pei Qi\Documents\ProfilePic\NoProfile.jpg")
            End If
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        lblName.Text = UserName
        '-------------Display subject name through SubjectID------------
        sql = "SELECT * FROM Subject WHERE SubjectID= " & SubjectID
        cmd = New OleDbCommand(sql, con)
        check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            rd.Read()
            SubjectName = rd("SubjectName").ToString
        End If
        lblSubject.Text = SubjectName
        '///////////////////////////////////////////////////////////////
        '----------------Calculate Rating for user----------------------
        sql = "SELECT Avg(Rate) As AvgRating FROM Rating WHERE UserID=" & StudentID
        cmd = New OleDbCommand(sql, con)
        Dim result As Object = cmd.ExecuteScalar()
        'Check if value of rating is null
        If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
            check = Convert.ToInt32(result)
        Else
            check = 0
        End If
        'Display value for rating
        If check > 0 Then
            rd = cmd.ExecuteReader()
            rd.Read()
            Rating = rd.GetDouble(rd.GetOrdinal("AvgRating"))
            'Display value when rating exist
            lblRating.Text = Rating.ToString("#0.00") & " /5.00"
        Else
            'Display for rating that doesn't exist
            lblRating.Text = "No Rating"
        End If
        '///////////////////////////////////////////////////////////////
        '-----If rating too low tutor is able to remove the student-----
        If Rating < 3 Then
            btnRemove.Visible = True
            picRemove.Visible = True
        Else
            btnRemove.Visible = False
            picRemove.Visible = False
        End If
        '///////////////////////////////////////////////////////////////
        '--------------------------Display Progress---------------------
        Dim sql1 As String = "SELECT COUNT(MaterialID) As MaterialNo FROM Material WHERE SubjectID=" & TutorStudentList.SubID
        Dim cmd1 = New OleDbCommand(sql1, con)
        Dim check1 = Convert.ToInt32(cmd1.ExecuteScalar())
        If check1 > 0 Then
            Dim rd1 As OleDbDataReader = cmd1.ExecuteReader()
            While rd1.Read()
                MaterialNo = rd1("MaterialNo")
            End While
            rd1.Close()
            Dim sql2 As String = "SELECT COUNT(ProgressID) As CompletedNo FROM Progress WHERE UserID=" & StudentID & " AND SubjectID=" & TutorStudentList.SubID
            Dim cmd2 = New OleDbCommand(sql2, con)
            Dim check2 = Convert.ToInt32(cmd2.ExecuteScalar())
            If check2 > 0 Then
                Dim rd2 As OleDbDataReader = cmd2.ExecuteReader()
                While rd2.Read()
                    CompletedNo = rd2("CompletedNo")
                End While
                rd2.Close()
            End If
            'Set initial value to 0 and calculate Progress
            Progress = 0
            Progress = (CompletedNo / MaterialNo) * 100
            lblProgress.Text = Str(Progress) & "/100"
        Else
            lblProgress.Text = "No Material"
        End If
        '----------Show Rating button if the user is not being rated before by the tutor-----------
        If Progress = 100 Then
            sql = "SELECT * FROM Rating WHERE RaterID=" & Login.GlobalVariables.UserID & " AND UserID=" & StudentID & " AND SubjectID=" & SubjectID
            cmd = New OleDbCommand(sql, con)
            check = Convert.ToInt32(cmd.ExecuteScalar())
            If check > 0 Then
                btnRating.Visible = False
                picRating.Visible = False
            Else
                btnRating.Visible = True
                picRating.Visible = True
            End If
        Else
            btnRating.Visible = False
            picRating.Visible = False
        End If
        '///////////////////////////////////////////////////////////////
        '----------------------Document List-----------------------------
        'Clear rows before inserting new data into the table
        ClearRows(tableProgress, 0)
        'Display tutor submitted document
        sql = "SELECT * FROM Material WHERE SubjectID=" & TutorStudentList.SubID
        cmd = New OleDbCommand(sql, con)
        check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                MaterialID = rd("MaterialID")
                MaterialName = rd("MaterialName").ToString
                'handle returned value before next loop here
                tableProgress.GrowStyle = TableLayoutPanelGrowStyle.AddRows
                tableProgress.RowStyles.Add(New RowStyle(SizeType.Absolute, 35.0!))
                tableProgress.RowCount += 1
                '
                'PanelDocument
                '
                Dim PanelDocument As New Panel
                PanelDocument.Dock = DockStyle.Top
                PanelDocument.Location = New Point(3, 3)
                PanelDocument.Size = New Size(394, 37)
                '
                'lblMaterial
                '
                Dim lblMaterial As New Label
                lblMaterial.Anchor = AnchorStyles.None
                lblMaterial.AutoSize = True
                lblMaterial.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblMaterial.ForeColor = SystemColors.AppWorkspace
                lblMaterial.Location = New Point(6, 7)
                lblMaterial.Size = New Size(102, 24)
                lblMaterial.Text = MaterialName
                lblMaterial.Dock = DockStyle.Top
                '--------------------------Check Progress---------------------------
                sql1 = "SELECT * FROM Progress WHERE MaterialID=" & MaterialID & " AND UserID=" & StudentID
                cmd1 = New OleDbCommand(sql1, con)
                check1 = Convert.ToInt32(cmd1.ExecuteScalar())
                If check1 > 0 Then
                    Dim rd1 As OleDbDataReader = cmd1.ExecuteReader()
                    While rd1.Read()
                        '
                        'lblDone
                        '
                        Dim lblDone As New Label
                        lblDone.AutoSize = True
                        lblDone.BackColor = Color.Transparent
                        lblDone.Font = New Font("Kristen ITC", 10.2!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
                        lblDone.ForeColor = Color.LimeGreen
                        lblDone.Location = New Point(430, 6)
                        lblDone.Size = New Size(59, 24)
                        lblDone.TabIndex = 102
                        lblDone.Text = "Done"
                        lblDone.TextAlign = ContentAlignment.TopCenter
                        PanelDocument.Controls.Add(lblDone)
                    End While
                    rd1.Close()
                Else
                    '
                    'lblIncomplete
                    '
                    Dim lblIncomplete As New Label
                    lblIncomplete.AutoSize = True
                    lblIncomplete.BackColor = Color.Transparent
                    lblIncomplete.Font = New Font("Kristen ITC", 10.2!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
                    lblIncomplete.ForeColor = Color.Red
                    lblIncomplete.Location = New Point(380, 6)
                    lblIncomplete.Size = New Size(114, 24)
                    lblIncomplete.TabIndex = 102
                    lblIncomplete.Text = "Incomplete"
                    lblIncomplete.TextAlign = ContentAlignment.TopCenter
                    PanelDocument.Controls.Add(lblIncomplete)
                    'Add all element into panel
                End If
                PanelDocument.Controls.Add(lblMaterial)
                tableProgress.Controls.Add(PanelDocument, 0, tableProgress.RowCount - 1)
            End While
        Else
            'Clear rows before new data is inserted into the table
            ClearRows(tableProgress, 0)
            'handle returned value before next loop here
            tableProgress.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            tableProgress.RowStyles.Add(New RowStyle(SizeType.Absolute, 45.0!))
            tableProgress.RowCount += 1
            '
            'PanelDocument
            '
            Dim PanelDocument As New Panel
            PanelDocument.Dock = DockStyle.Top
            PanelDocument.Location = New Point(3, 3)
            PanelDocument.Size = New Size(371, 40)
            '
            'lblNoRecord
            '
            Dim lblNoRecord As New Label
            lblNoRecord.Anchor = AnchorStyles.None
            lblNoRecord.AutoSize = True
            lblNoRecord.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            lblNoRecord.ForeColor = SystemColors.AppWorkspace
            lblNoRecord.Location = New Point(40, 7)
            lblNoRecord.Size = New Size(102, 24)
            lblNoRecord.Text = "No document submitted"
            lblNoRecord.Dock = DockStyle.Top
            'Add element into panel
            PanelDocument.Controls.Add(lblNoRecord)
            tableProgress.Controls.Add(PanelDocument, 0, 0)
        End If
        '///////////////////////////////////////////////////////////////
        con.Close()
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'Remove confirmation
        Dim response As String
        response = MsgBox("Do you want to remove this student?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Verification")
        If response = MsgBoxResult.Yes Then
            con.Open()
            sql = "DELETE FROM Registration WHERE RegistrationID=" & TutorViewStudent.RegID
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Student successfully remove!", MsgBoxStyle.Information, "Verification")
            SideButton.OpenChildFormRefresh(TutorStudentList)
            con.Close()
        End If
    End Sub
    Private Sub btnRating_Click(sender As Object, e As EventArgs) Handles btnRating.Click
        'Open Dialog RateUser Form
        Dim rateUser As New RateUser()
        rateUser.UserID = Me.StudentID
        rateUser.SubjectID = Me.SubjectID
        AddHandler rateUser.FormClosed, AddressOf RateUser_FormClosed
        rateUser.ShowDialog()
    End Sub
    Private Sub RateUser_FormClosed(sender As Object, e As FormClosedEventArgs)
        'Refresh Me once RateUser is closed
        SideButton.OpenChildFormRefresh(Me)
    End Sub
    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        'Open Dialog SendEmail Form
        SendEmail.SenderID = Login.GlobalVariables.UserID
        SendEmail.ReceiverID = StudentID
        SendEmail.ShowDialog()
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
End Class