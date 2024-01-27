'AdminView.vb
Imports System.Data.OleDb
Imports System.Drawing.Drawing2D
Public Class AdminView
    'Variable declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim UserName, SubjectName, Bio, Profile As String
    Dim Rating As Double
    Dim UserID As Integer
    Public UserType As String
    Public Sub AdminView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display UserType
        lblUserType.Text = UserType
        'Clear rows before entering new data
        AdminVerification.ClearRows(TableTutor, 0)
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        con.Open()
        sql = "SELECT * FROM [User] WHERE UserType='" & UserType & "'"
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                UserID = rd("UserID")
                UserName = rd("UserName").ToString
                Bio = rd("Bio").ToString
                If Not rd.IsDBNull(rd.GetOrdinal("Profile")) Then
                    'Display profilepic
                    Profile = rd.GetString(rd.GetOrdinal("Profile"))
                Else
                    'Display default picture if no profile pic is stored
                    Profile = "C:\Users\Lee Pei Qi\Documents\ProfilePic\NoProfile.jpg"
                End If
                '------------------------------Add Row to table------------------------------------------
                'handle returned value before next loop here
                TableTutor.GrowStyle = TableLayoutPanelGrowStyle.AddRows
                TableTutor.RowStyles.Add(New RowStyle(SizeType.Absolute, 170.0!))
                TableTutor.RowCount += 1
                '--------------------------Display SubjectName/RegisterSubject---------------------------
                Dim sql1 As String
                If UserType = "Tutor" Then
                    sql1 = "SELECT * FROM Subject WHERE UserID=" & UserID
                Else
                    sql1 = "SELECT * FROM Registration INNER JOIN Subject ON Registration.SubjectID=Subject.SubjectID WHERE Registration.[UserID]=" & UserID
                End If
                Dim cmd1 = New OleDbCommand(sql1, con)
                Dim check1 As Integer = Convert.ToInt32(cmd1.ExecuteScalar())
                SubjectName = ""
                If check1 > 0 Then
                    Dim rd1 As OleDbDataReader = cmd1.ExecuteReader()
                    While rd1.Read()
                        SubjectName = rd1("SubjectName").ToString & " | " & SubjectName
                    End While
                    rd1.Close()
                Else
                    SubjectName = "No subject found"
                End If
                '-------------------------------Display Rating--------------------------------------
                Rating = 0
                Rating = GetAverage(UserID)
                '
                'PanelTutor
                '
                Dim PanelTutor As New Panel
                PanelTutor.BackColor = SystemColors.ControlLight
                PanelTutor.Location = New Point(3, 3)
                PanelTutor.Size = New Size(650, 159)
                PanelTutor.Dock = DockStyle.Top
                '-------------------------------Rounded Panel--------------------------------------
                Dim path As New GraphicsPath()
                ' Set the rounded rectangle shape with desired radius and dimensions for panel1
                Dim cornerRadius As Integer = 20
                Dim rect As New Rectangle(0, 0, PanelTutor.Width, PanelTutor.Height)
                path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90) ' Top-left corner
                path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90) ' Top-right corner
                path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90) ' Bottom-right corner
                path.AddArc(rect.X, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90) ' Bottom-left corner
                PanelTutor.Region = New Region(path)
                path.CloseAllFigures()
                '-------------------------------Rounded Panel--------------------------------------
                If Login.GlobalVariables.UserType = "Student" Then
                    '
                    'Display btnEnquire for UserType Student
                    '
                    Dim btnEnquire As New Button
                    btnEnquire.Anchor = AnchorStyles.None
                    btnEnquire.FlatStyle = FlatStyle.Flat
                    btnEnquire.Font = New Font("Kristen ITC", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
                    btnEnquire.ForeColor = SystemColors.HighlightText
                    btnEnquire.Location = New Point(487, 123)
                    btnEnquire.Size = New Size(95, 30)
                    btnEnquire.UseVisualStyleBackColor = False
                    btnEnquire.Text = "Enquire"
                    btnEnquire.Tag = UserID
                    btnEnquire.BackColor = SystemColors.WindowFrame
                    btnEnquire.FlatAppearance.BorderColor = SystemColors.WindowFrame
                    btnEnquire.ForeColor = SystemColors.ButtonHighlight
                    AddHandler btnEnquire.Click, AddressOf btnEnquire_Click
                    PanelTutor.Controls.Add(btnEnquire)
                Else
                    '
                    'Display btnRemove for UserType Admin
                    '
                    Dim btnRemove As New Button
                    btnRemove.Anchor = AnchorStyles.None
                    btnRemove.FlatStyle = FlatStyle.Flat
                    btnRemove.Font = New Font("Kristen ITC", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
                    btnRemove.ForeColor = SystemColors.HighlightText
                    btnRemove.Location = New Point(487, 123)
                    btnRemove.Size = New Size(95, 30)
                    btnRemove.UseVisualStyleBackColor = False
                    btnRemove.Text = "Remove"
                    btnRemove.Tag = UserID
                    If Rating >= 3 Or Rating = 0 Then
                        'Disabled btnRemove if the rating is more than 3
                        btnRemove.Enabled = False
                        btnRemove.BackColor = SystemColors.WindowFrame
                        btnRemove.FlatAppearance.BorderColor = SystemColors.WindowFrame
                        btnRemove.ForeColor = SystemColors.ButtonHighlight
                    Else
                        'Enabled btnRemove if the rating is more than 3
                        btnRemove.Enabled = True
                        btnRemove.BackColor = Color.IndianRed
                        btnRemove.FlatAppearance.BorderColor = Color.IndianRed
                        btnRemove.ForeColor = SystemColors.ButtonHighlight
                    End If
                    PanelTutor.Controls.Add(btnRemove)
                    AddHandler btnRemove.Click, AddressOf btnRemove_Click
                End If
                '
                'lblRating
                '
                Dim lblRating As New Label
                lblRating.AutoSize = True
                lblRating.Font = New Font("Kristen ITC", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblRating.ForeColor = SystemColors.WindowFrame
                lblRating.Location = New Point(157, 125)
                lblRating.Size = New Size(74, 22)
                'If Rating>0 display rating
                If Rating > 0 Then
                    lblRating.Text = "Rating: " & Rating.ToString("#0.00") & " /5.00"
                Else
                    'Display no rating if no rating record found
                    lblRating.Text = "No Rating"
                End If
                '
                'lblSubject
                '
                Dim lblSubject As New TextBox
                lblSubject.BackColor = SystemColors.ScrollBar
                lblSubject.BorderStyle = BorderStyle.None
                lblSubject.Font = New Font("Kristen ITC", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblSubject.ForeColor = SystemColors.WindowFrame
                lblSubject.Location = New Point(157, 65)
                lblSubject.Multiline = True
                lblSubject.Enabled = False
                lblSubject.Size = New Size(380, 54)
                lblSubject.Text = SubjectName
                '
                'lblBio
                '
                Dim lblBio As New Label
                lblBio.AutoSize = True
                lblBio.Font = New Font("Kristen ITC", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblBio.ForeColor = SystemColors.WindowFrame
                lblBio.Location = New Point(155, 39)
                lblBio.Name = "lblSubject"
                lblBio.Size = New Size(83, 22)
                lblBio.Text = Bio
                '
                'lblUserName
                '
                Dim lblUserName As New Label
                lblUserName.AutoSize = True
                lblUserName.Font = New Font("Kristen ITC", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
                lblUserName.ForeColor = SystemColors.WindowFrame
                lblUserName.Location = New Point(151, 10)
                lblUserName.Size = New Size(155, 28)
                lblUserName.Text = UserName
                '
                'picProfile
                '
                Dim picProfile As New PictureBox
                picProfile.BackColor = SystemColors.ButtonHighlight
                picProfile.BorderStyle = BorderStyle.FixedSingle
                picProfile.Location = New Point(12, 14)
                picProfile.Name = "picProfile"
                picProfile.Size = New Size(132, 132)
                picProfile.TabStop = False
                picProfile.Image = Image.FromFile(Profile)
                picProfile.SizeMode = PictureBoxSizeMode.StretchImage
                'Add element into PanelTutor
                PanelTutor.Controls.Add(lblRating)
                PanelTutor.Controls.Add(lblBio)
                PanelTutor.Controls.Add(lblSubject)
                PanelTutor.Controls.Add(lblUserName)
                PanelTutor.Controls.Add(picProfile)
                TableTutor.Controls.Add(PanelTutor, 0, TableTutor.RowCount - 1)
            End While
        Else
            'Clear table before new data is added
            AdminVerification.ClearRows(TableTutor, 0)
            TableTutor.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            TableTutor.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            TableTutor.RowCount += 1
            '
            'PanelNoRecord
            '
            Dim PanelNoRecord As New Panel
            PanelNoRecord.BackColor = SystemColors.ControlLight
            PanelNoRecord.Dock = DockStyle.Fill
            PanelNoRecord.Location = New Point(3, 168)
            PanelNoRecord.Size = New Size(747, 159)
            '-------------------------------Rounded Panel--------------------------------------
            Dim path As New GraphicsPath()
            ' Set the rounded rectangle shape with desired radius and dimensions for panel1
            Dim cornerRadius As Integer = 20
            Dim rect As New Rectangle(0, 0, PanelNoRecord.Width, PanelNoRecord.Height)
            path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90) ' Top-left corner
            path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90) ' Top-right corner
            path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90) ' Bottom-right corner
            path.AddArc(rect.X, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90) ' Bottom-left corner
            PanelNoRecord.Region = New Region(path)
            path.CloseAllFigures()
            '-------------------------------Rounded Panel--------------------------------------
            '
            'lblNoRecord
            '
            Dim lblNoRecord As New Label
            lblNoRecord.AutoSize = True
            lblNoRecord.Font = New Font("Kristen ITC", 22.2!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            lblNoRecord.ForeColor = SystemColors.WindowFrame
            lblNoRecord.Location = New Point(150L, 44)
            lblNoRecord.Size = New Size(334, 51)
            lblNoRecord.Text = "No Tutor Found"
            '
            'Add element to panel 2
            PanelNoRecord.Controls.Add(lblNoRecord)
            TableTutor.Controls.Add(PanelNoRecord, 0, 0)
        End If
        con.Close()
    End Sub
    Private Function GetAverage(UserID As Integer)
        'Count average rating for user
        Dim sql2 = "SELECT Avg(Rate) As AvgRating FROM Rating WHERE UserID=" & UserID
        Dim cmd2 = New OleDbCommand(sql2, con)
        Dim result As Object = cmd2.ExecuteScalar()
        'Check if value of rating is null
        Dim check As Integer
        If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
            check = Convert.ToInt32(result)
        Else
            check = 0
        End If
        'Return rating
        If check > 0 Then
            Dim rd2 = cmd2.ExecuteReader()
            rd2.Read()
            Rating = rd2.GetDouble(rd2.GetOrdinal("AvgRating"))
            Return Rating
            Rating = 0
        End If
        Return Rating
    End Function
    Private Sub btnRemove_Click(sender As Object, e As EventArgs)
        'Remove student from the whole system
        Dim btnView As Button = DirectCast(sender, Button)
        Dim response As String
        response = MsgBox("Do you want to delete this user?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Remove User")
        If response = MsgBoxResult.Yes Then
            con.Open()
            sql = "DELETE FROM [User] WHERE UserID=" & btnView.Tag
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("User Succesfully Removed!", MsgBoxStyle.Information, "Remove User")
            con.Close()
        End If
        AdminView_Load(Me, EventArgs.Empty)
    End Sub
    Private Sub btnEnquire_Click(sender As Object, e As EventArgs)
        'Display StudentTutor after btnEnquire is clicked
        Dim btnEnquire As Button = DirectCast(sender, Button)
        StudentTutor.UserID = btnEnquire.Tag
        SideButton.OpenChildFormRefresh(StudentTutor)
    End Sub
End Class