'StudentClassData.vb
Imports System.Data.OleDb
Public Class StudentClassData
    'Variable Declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim UserName, SubjectName, Profile, MaterialName, MaterialFile, GroupLink As String
    Dim SubjectID, MaterialNo, CompletedNo, MaterialID, TutorID, Slot As Integer
    Dim DateClass As Date
    Dim Progress As Double
    Public RegistrationID As Integer
    Public Sub StudentClassData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UserID As Integer = Login.GlobalVariables.UserID
        'Display all relevant information
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "SELECT * FROM Registration WHERE RegistrationID = " & RegistrationID
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            rd.Read()
            SubjectID = rd("SubjectID")
        End If
        sql = "SELECT * FROM Subject INNER Join [User] ON Subject.UserID=[User].UserID WHERE SubjectID = " & SubjectID
        cmd = New OleDbCommand(sql, con)
        check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            rd.Read()
            SubjectName = rd("SubjectName").ToString
            UserName = rd("UserName").ToString
            TutorID = rd("Subject.UserID")
            GroupLink = rd("GroupLink").ToString
            If Not rd.IsDBNull(rd.GetOrdinal("Profile")) Then
                Profile = rd.GetString(rd.GetOrdinal("Profile"))
                picProfile.Image = Image.FromFile(Profile)
            Else
                picProfile.Image = Image.FromFile("C:\Users\Lee Pei Qi\Documents\ProfilePic\NoProfile.jpg")
            End If
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        lblSubject.Text = SubjectName
        lblName.Text = UserName
        '--------------------------Display Progress---------------------------
        Dim sql1 As String = "SELECT COUNT(MaterialID) As MaterialNo FROM Material WHERE SubjectID=" & SubjectID
        Dim cmd1 = New OleDbCommand(sql1, con)
        Dim check1 = Convert.ToInt32(cmd1.ExecuteScalar())
        If check1 > 0 Then
            Dim rd1 As OleDbDataReader = cmd1.ExecuteReader()
            'Set initial value to 0 and get No of material for the entire subject
            MaterialNo = 0
            While rd1.Read()
                MaterialNo = rd1("MaterialNo")
            End While
            rd1.Close()
            Dim sql2 As String = "SELECT COUNT(ProgressID) As CompletedNo FROM Progress WHERE UserID=" & UserID & " AND SubjectID=" & SubjectID
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
            End If
            'Set initial value to 0 and Calculate progress
            Progress = 0
            Progress = (CompletedNo / MaterialNo) * 100
            lblProgress.Text = Str(Progress) & "/100"
        Else
            lblProgress.Text = "No Material"
        End If
        '----------------------Display rating button if progress is 100---------------------------------------
        If Progress = 100 Then
            sql = "SELECT * FROM Rating WHERE RaterID=" & Login.GlobalVariables.UserID & " AND UserID=" & TutorID & " AND SubjectID=" & SubjectID
            cmd = New OleDbCommand(sql, con)
            check = Convert.ToInt32(cmd.ExecuteScalar())
            'Check if user rate before
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
        '----------------------Display TimeSlot---------------------------------------
        sql = "SELECT * FROM Schedule WHERE RegistrationID=" & RegistrationID
        cmd = New OleDbCommand(sql, con)
        check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                Slot = rd("Slot")
                Dim DateValue As Date = rd.GetDateTime(rd.GetOrdinal("DateClass"))
                DateClass = DateValue.ToString("d/M/yyyy")
            End While
        End If
        Dim TimeClass As String
        If Slot = 1 Then
            TimeClass = "8am-10am"
        ElseIf Slot = 2 Then
            TimeClass = "10am-12pm"
        ElseIf Slot = 3 Then
            TimeClass = "2pm-4pm"
        ElseIf Slot = 4 Then
            TimeClass = "4pm-6pm"
        Else
            TimeClass = "8pm-10pm"
        End If
        lblTimeSlot.Text = DateClass & " " & TimeClass
        '----------------------Document List---------------------------------------
        'Clear rows before inserting new data into the tab;e
        AdminVerification.ClearRows(tableViewMaterial, 0)
        'Display tutor submitted document
        sql = "SELECT * FROM Material WHERE SubjectID=" & SubjectID
        cmd = New OleDbCommand(sql, con)
        check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                MaterialName = rd("MaterialName").ToString
                MaterialID = rd("MaterialID")
                'handle returned value before next loop here
                tableViewMaterial.GrowStyle = TableLayoutPanelGrowStyle.AddRows
                tableViewMaterial.RowStyles.Add(New RowStyle(SizeType.Absolute, 35.0!))
                tableViewMaterial.RowCount += 1
                '
                'PanelDocument
                '
                Dim PanelDocument As New Panel
                PanelDocument.Dock = DockStyle.Top
                PanelDocument.Location = New Point(3, 3)
                PanelDocument.Size = New Size(371, 40)
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
                '
                'btnView
                '
                Dim btnView As New Button
                btnView.BackColor = SystemColors.ScrollBar
                btnView.Font = New Font("Kristen ITC", 7.8!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                btnView.ForeColor = SystemColors.WindowFrame
                btnView.Location = New Point(370, 2)
                btnView.Name = "btnView"
                btnView.Tag = MaterialID
                btnView.Size = New Size(70, 23)
                btnView.Text = "View"
                btnView.UseVisualStyleBackColor = False
                AddHandler btnView.Click, AddressOf btnView_Click
                'Add all element into panel
                PanelDocument.Controls.Add(btnView)
                PanelDocument.Controls.Add(lblMaterial)
                tableViewMaterial.Controls.Add(PanelDocument, 0, tableViewMaterial.RowCount - 1)
            End While
        Else
            'handle returned value before next loop here
            AdminVerification.ClearRows(tableViewMaterial, 0)
            tableViewMaterial.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            tableViewMaterial.RowStyles.Add(New RowStyle(SizeType.Absolute, 45.0!))
            tableViewMaterial.RowCount += 1
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
            tableViewMaterial.Controls.Add(PanelDocument, 0, 0)
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
    Private Sub btnRating_Click(sender As Object, e As EventArgs) Handles btnRating.Click
        'Open Dialog RateUser
        Dim rateUser As New RateUser()
        rateUser.UserID = TutorID
        rateUser.SubjectID = SubjectID
        AddHandler rateUser.FormClosed, AddressOf RateUser_FormClosed
        rateUser.ShowDialog()
    End Sub
    Private Sub RateUser_FormClosed(sender As Object, e As FormClosedEventArgs)
        'Refresh Me when RateUser form is closed
        SideButton.OpenChildFormRefresh(Me)
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'Quit confirmation
        Dim response As String
        response = MsgBox("Do you want to quit this subject?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Verification")
        If response = MsgBoxResult.Yes Then
            con.Open()
            'Delete Student from Subject
            sql = "DELETE FROM Registration WHERE RegistrationID=" & RegistrationID
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Subject successfully quit!", MsgBoxStyle.Information, "Verification")
            SideButton.OpenChildFormRefresh(StudentClass)
            con.Close()
        End If
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs)
        Dim btnView As Button = DirectCast(sender, Button)
        MaterialID = btnView.Tag
        con.Open()
        sql = "SELECT * FROM Progress WHERE SubjectID=" & SubjectID & " AND MaterialID=" & MaterialID & " AND UserID=" & Login.GlobalVariables.UserID
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
        Else
            Dim sql1 = "INSERT INTO Progress([UserID], [SubjectID], [MaterialID],[RegistrationID]) VALUES(@UserID,@SubjectID,@MaterialID,@RegistrationID)"
            Dim cmd1 = New OleDbCommand(sql1, con)
            cmd1.Parameters.AddWithValue("@UserID", Login.GlobalVariables.UserID)
            cmd1.Parameters.AddWithValue("@SubjectID", SubjectID)
            cmd1.Parameters.AddWithValue("@MaterialID", MaterialID)
            cmd1.Parameters.AddWithValue("@RegistrationID", RegistrationID)
            Dim rd1 = cmd1.ExecuteReader()
        End If
        sql = "SELECT * FROM Material WHERE MaterialID = " & MaterialID
        cmd = New OleDbCommand(sql, con)
        check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            rd.Read()
            MaterialFile = rd("MaterialFile").ToString
        End If
        'Send MaterialFile path to pdf Reader
        PDFReader.MaterialFile = MaterialFile
        con.Close()
        StudentClassData_Load(Me, EventArgs.Empty)
        'Open Dialog PDFReader Form
        PDFReader.ShowDialog()
    End Sub
    Private Sub linkGroup_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkGroup.LinkClicked
        'Open GroupLink
        Dim website As String = GroupLink
        linkGroup.LinkVisited = True
        ' Navigate to a URL.
        Process.Start(website)
    End Sub
    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        'Open Dialog SendEmail Form
        SendEmail.SenderID = Login.GlobalVariables.UserID
        SendEmail.ReceiverID = TutorID
        SendEmail.ShowDialog()
    End Sub
End Class