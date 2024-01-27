'TutorVerifyStudent.vb
Imports System.Data.OleDb
Public Class TutorVerifyStudent
    'Variable Declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim UserName, Gender, SubjectName, Bio, UserID, SubjectID, Profile As String
    Dim Rating As Double
    Private Sub TutorVerifyStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        'Display all relevant infromation
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        sql = "SELECT * FROM Registration INNER Join [User] ON Registration.UserID=[User].UserID WHERE RegistrationID = " & TutorViewStudent.RegID & ";"
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            rd.Read()
            UserName = rd("UserName").ToString
            Gender = rd("Gender").ToString
            SubjectID = rd("SubjectID")
            Bio = rd("Bio").ToString
            UserID = rd("Registration.UserID").ToString
            If Not rd.IsDBNull(rd.GetOrdinal("Profile")) Then
                Profile = rd.GetString(rd.GetOrdinal("Profile"))
                'Display profile pic
                picProfile.Image = Image.FromFile(Profile)
            Else
                'Display default image if no picture is stored

                picProfile.Image = Image.FromFile("C:\Users\Lee Pei Qi\Documents\ProfilePic\NoProfile.jpg")
            End If
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        lblName.Text = UserName
        lblGender.Text = Gender
        If Bio = "" Then
            lblDescription.Text = "No Bio"
        Else
            lblDescription.Text = Bio
        End If
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
        '----------------Calculate Rating for user----------------------
        sql = "SELECT Avg(Rate) As AvgRating FROM Rating WHERE UserID=" & UserID
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
        con.Close()
    End Sub
    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        'Delete Confirmation
        Dim response As String
        response = MsgBox("Do you want to reject this student?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Verification")
        If response = MsgBoxResult.Yes Then
            con.Open()
            sql = "DELETE FROM Registration WHERE RegistrationID=" & TutorViewStudent.RegID
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Student successfully rejected!", MsgBoxStyle.Information, "Verification")
            'Open TutorViewStudent Form
            SideButton.OpenChildFormRefresh(TutorViewStudent)
            con.Close()
        End If
    End Sub
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        'Approve Confirmation
        Dim response As String
        response = MsgBox("Do you want to approve this student?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Verification")
        If response = MsgBoxResult.Yes Then
            con.Open()
            sql = "UPDATE Registration SET Status=True WHERE RegistrationID= " & TutorViewStudent.RegID
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Student Successfully Approved!", MsgBoxStyle.Information, "Verification")
            'Open TutorViewStudent Form
            SideButton.OpenChildFormRefresh(TutorViewStudent)
            con.Close()
        End If
    End Sub
End Class