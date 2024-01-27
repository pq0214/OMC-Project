'TutorAddClas.vb
Imports System.Data.OleDb
Public Class TutorAddClass
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim UserID As String = Login.GlobalVariables.UserID
    Dim CurrentID As Integer
    Private Sub TutorAddClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Check whether all information are insert
        If txtSubject.Text = "" Then
            MsgBox("Please fill in the subject!")
        Else
            If txtGrpLink.Text = "" Then
                MsgBox("Please insert Group Link for this subject!")
            Else
                Dim DateSubmit As Date = FormatDateTime(Today, DateFormat.ShortDate)
                'Add Class confirmation
                Dim response As String
                response = MsgBox("Do you want to add class?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Class")
                If response = MsgBoxResult.Yes Then
                    con.Open()
                    sql = "INSERT INTO Subject([UserID], [SubjectName], [DateSubmit],[Price],[GroupLink]) VALUES(@UserID,@SubjectName,@DateSubmit,@Price,@GroupLink)"
                    cmd = New OleDbCommand(sql, con)
                    cmd.Parameters.AddWithValue("@UserID", UserID)
                    cmd.Parameters.AddWithValue("@SubjectName", txtSubject.Text)
                    cmd.Parameters.AddWithValue("@DateSubmit", DateSubmit)
                    cmd.Parameters.AddWithValue("@Price", numPrice.Value)
                    cmd.Parameters.AddWithValue("@GroupLink", txtGrpLink.Text)
                    cmd.ExecuteNonQuery()
                    sql = "SELECT MAX(SubjectID) As CurrentID FROM Subject"
                    cmd = New OleDbCommand(sql, con)
                    Dim check = Convert.ToInt32(cmd.ExecuteScalar())
                    If check > 0 Then
                        rd = cmd.ExecuteReader()
                        rd.Read()
                        CurrentID = rd("CurrentID")
                    End If
                    con.Close()
                    MsgBox(CurrentID)
                    MsgBox("Class successfully added! Please wait for the verification to be completed ", MsgBoxStyle.Information, "Class")
                    'Open TutorViewMaterial Form
                    TutorViewMaterial.SubID = CurrentID
                    SideButton.OpenChildFormRefresh(TutorViewMaterial)
                End If
            End If
        End If
    End Sub
    'Create Placeholder for txtGrpLink
    Private Sub txtGrpLink_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrpLink.GotFocus
        txtGrpLink.Text = ""
        txtGrpLink.ForeColor = SystemColors.WindowFrame
    End Sub
    Private Sub txtGrpLink_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrpLink.LostFocus
        If txtGrpLink.Text = "" Then
            txtGrpLink.Text = "Create link for student to join class"
            txtGrpLink.ForeColor = SystemColors.ScrollBar
        End If
    End Sub
End Class