'StudentTutor.vb
Imports System.Data.OleDb
Public Class StudentTutor
    'Variable Declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Public UserID As Integer
    Dim UserName, Gender, Profile, SubjectName, Price As String
    Dim Rating As Double
    Dim NoStudent, SubjectID As Integer
    Private Sub StudentTutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        con.Open()
        '----------------------Tutor Info---------------------------------------
        sql = "SELECT * FROM [User] WHERE UserID=" & UserID
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            rd.Read()
            UserName = rd("UserName").ToString
            Gender = rd("Gender").ToString
            If Not rd.IsDBNull(rd.GetOrdinal("Profile")) Then
                Profile = rd.GetString(rd.GetOrdinal("Profile"))
                'Display profile picture
                picProfile.Image = Image.FromFile(Profile)
            Else
                'Display default image if no picture is stored
                picProfile.Image = Image.FromFile("C:\Users\Lee Pei Qi\Documents\ProfilePic\NoProfile.jpg")
            End If
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        Rating = GetAverage(UserID)
        lblName.Text = UserName
        lblGender.Text = Gender
        'Clear row before new data is added into the table
        AdminVerification.ClearRows(tableViewSubject, 0)
        '----------------------Display SubjectName&Price---------------------------------------
        sql = "SELECT * FROM Subject WHERE UserID=" & UserID
        cmd = New OleDbCommand(sql, con)
        check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                SubjectID = rd("SubjectID")
                SubjectName = rd("SubjectName").ToString
                Price = rd("Price").ToString
                'handle returned value before next loop here
                tableViewSubject.GrowStyle = TableLayoutPanelGrowStyle.AddRows
                tableViewSubject.RowStyles.Add(New RowStyle(SizeType.Absolute, 35.0!))
                tableViewSubject.RowCount += 1
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
                Dim lblSubject As New Label
                lblSubject.Anchor = AnchorStyles.None
                lblSubject.AutoSize = True
                lblSubject.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblSubject.ForeColor = SystemColors.AppWorkspace
                lblSubject.Location = New Point(0, 7)
                lblSubject.Size = New Size(102, 24)
                lblSubject.Text = SubjectName
                '
                'lblPrice
                '
                Dim lblPrice As New Label
                lblPrice.Anchor = AnchorStyles.None
                lblPrice.AutoSize = True
                lblPrice.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblPrice.ForeColor = SystemColors.AppWorkspace
                lblPrice.Location = New Point(150, 7)
                lblPrice.Size = New Size(102, 24)
                lblPrice.Text = Format(Price, "Currency")
                '----------------------Check whether class is full/registered---------------------------------------
                Dim sql1 = "SELECT * FROM Registration WHERE UserID= " & Login.GlobalVariables.UserID & " AND SubjectID=" & SubjectID
                Dim cmd1 = New OleDbCommand(sql1, con)
                Dim check1 = Convert.ToInt32(cmd1.ExecuteScalar())
                If check1 > 0 Then
                    '
                    'lblSubReg
                    '
                    Dim lblSubReg As New Label
                    lblSubReg.Anchor = AnchorStyles.None
                    lblSubReg.AutoSize = True
                    lblSubReg.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                    lblSubReg.ForeColor = SystemColors.AppWorkspace
                    lblSubReg.Location = New Point(245, 7)
                    lblSubReg.Size = New Size(102, 24)
                    lblSubReg.Text = "Registered"
                    PanelDocument.Controls.Add(lblSubReg)
                Else
                    Dim sql2 = "SELECT Count(UserID) As NoStudent FROM Registration WHERE SubjectID=" & SubjectID
                    Dim cmd2 = New OleDbCommand(sql2, con)
                    Dim check2 = Convert.ToInt32(cmd2.ExecuteScalar())
                    Dim rd2 = cmd2.ExecuteReader()
                    rd2.Read()
                    NoStudent = rd2("NoStudent")
                    If NoStudent < 5 Then
                        'Display btnEnroll if Class is not full
                        '
                        'btnEnroll
                        '
                        Dim btnEnroll As New Button
                        btnEnroll.BackColor = SystemColors.ScrollBar
                        btnEnroll.Font = New Font("Kristen ITC", 7.8!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                        btnEnroll.ForeColor = SystemColors.WindowFrame
                        btnEnroll.Location = New Point(270, 2)
                        btnEnroll.Tag = SubjectID
                        btnEnroll.Size = New Size(70, 23)
                        btnEnroll.Text = "Enroll"
                        btnEnroll.UseVisualStyleBackColor = False
                        AddHandler btnEnroll.Click, AddressOf btnEnroll_Click
                        PanelDocument.Controls.Add(btnEnroll)
                    Else
                        '
                        'lblClassFull
                        '
                        Dim lblClassFull As New Label
                        lblClassFull.Anchor = AnchorStyles.None
                        lblClassFull.AutoSize = True
                        lblClassFull.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                        lblClassFull.ForeColor = SystemColors.AppWorkspace
                        lblClassFull.Location = New Point(70, 7)
                        lblClassFull.Size = New Size(102, 24)
                        lblClassFull.Text = "Class is fully registered!"
                        PanelDocument.Controls.Add(lblClassFull)
                    End If
                End If
                'Add all element into panel
                PanelDocument.Controls.Add(lblSubject)
                PanelDocument.Controls.Add(lblPrice)
                tableViewSubject.Controls.Add(PanelDocument, 0, tableViewSubject.RowCount - 1)
            End While
        Else
            'Clear row before new data is added into the table
            AdminVerification.ClearRows(tableViewSubject, 0)
            'handle returned value before next loop here
            tableViewSubject.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            tableViewSubject.RowStyles.Add(New RowStyle(SizeType.Absolute, 45.0!))
            tableViewSubject.RowCount += 1
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
            tableViewSubject.Controls.Add(PanelDocument, 0, 0)
        End If
        con.Close()
    End Sub
    Private Function GetAverage(UserID As Integer)
        'Calculate AverageRating for the student
        sql = "SELECT Avg(Rate) As AvgRating FROM Rating WHERE UserID=" & UserID
        cmd = New OleDbCommand(sql, con)
        Dim result As Object = cmd.ExecuteScalar()
        'Check if value of rating is null
        Dim check As Integer
        If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
            check = Convert.ToInt32(result)
        Else
            check = 0
        End If
        'Return rating
        If check > 0 Then
            rd = cmd.ExecuteReader()
            rd.Read()
            Rating = rd.GetDouble(rd.GetOrdinal("AvgRating"))
            Return Rating
            Rating = 0
        End If
        Return Rating
    End Function
    Private Sub btnEnroll_Click(sender As Object, e As EventArgs)
        Dim btnEnroll As Button = DirectCast(sender, Button)
        Dim DateSubmit As Date = FormatDateTime(Today, DateFormat.ShortDate)
        Dim RegistrationID As Integer
        Dim SubjectID As Integer = CInt(btnEnroll.Tag)
        'Enrollment Confirmation
        Dim response As String
        response = MsgBox("Do you want to enroll to this subject?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Enrollment")
        If response = MsgBoxResult.Yes Then
            con.Open()
            'Enter registration information
            Dim sql = "INSERT INTO Registration([UserID], [SubjectID], [DateSubmit]) VALUES(@UserID,@SubjectID,@DateSubmit)"
            Dim cmd = New OleDbCommand(sql, con)
            cmd.Parameters.AddWithValue("@UserID", Login.GlobalVariables.UserID)
            cmd.Parameters.AddWithValue("@SubjectID", SubjectID)
            cmd.Parameters.AddWithValue("@DateSubmit", DateSubmit)
            Dim rd = cmd.ExecuteReader()
            MsgBox("Registration Completed. Please choose your schedule!", MsgBoxStyle.Information, "Registration")
            sql = "SELECT * FROM Registration WHERE UserID=" & Login.GlobalVariables.UserID & " AND SubjectID=" & SubjectID
            cmd = New OleDbCommand(sql, con)
            Dim check = Convert.ToInt32(cmd.ExecuteScalar())
            If check > 0 Then
                rd = cmd.ExecuteReader()
                rd.Read()
                RegistrationID = rd("RegistrationID")
                StudentBook.RegistrationID = RegistrationID
                SideButton.OpenChildFormRefresh(StudentBook)
            End If
            con.Close()
        End If
    End Sub
    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        'Open Dialog SendEmail
        SendEmail.SenderID = Login.GlobalVariables.UserID
        SendEmail.ReceiverID = UserID
        SendEmail.ShowDialog()
    End Sub
End Class