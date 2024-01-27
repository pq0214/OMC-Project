'RateUser.vb
Imports System.Data.OleDb
Public Class RateUser
    'Variable Declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim RaterID As String = Login.GlobalVariables.UserID
    Public UserID, SubjectID As Integer
    Private Sub Rating_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        'Load HandlerCode for 5 buttons
        For i As Integer = 1 To 5
            Dim buttonName As String = "Button" & i
            Dim button As Button = DirectCast(Me.Controls(buttonName), Button)
            If button IsNot Nothing Then
                button.Tag = i
            End If
            AddHandler button.Click, AddressOf Button_Click ' Add event handler for click event' Add the button to the form
        Next
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs)
        'Insert different RatingValue for the User
        Dim btnRate As Button = DirectCast(sender, Button)
        Dim RateValue As Integer = 0
        con.Open()
        RateValue = CInt(btnRate.Tag)
        sql = "INSERT INTO Rating([RaterID], [UserID], [SubjectID],[Rate]) VALUES(@RaterID,@UserID,@SubjectID,@Rate)"
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@RaterID", RaterID)
        cmd.Parameters.AddWithValue("@UserID", UserID)
        cmd.Parameters.AddWithValue("@SubjectID", SubjectID)
        cmd.Parameters.AddWithValue("@Rate", RateValue)
        rd = cmd.ExecuteReader()
        con.Close()
        MsgBox("Thank you for your rating!", MsgBoxStyle.Information, "Class")
        Me.Close()
    End Sub
End Class