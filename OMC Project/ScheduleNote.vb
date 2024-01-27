'ScheduleNote.vb
Imports System.Data.OleDb
Public Class ScheduleNote
    Public RegistrationID As Integer
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim Reminder As String
    Private Sub ScheduleNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        con.Open()
        sql = "SELECT * FROM Registration WHERE RegistrationID=" & RegistrationID
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            Dim rd = cmd.ExecuteReader()
            rd.Read()
            'Display reminder for class
            If Login.GlobalVariables.UserType = "Student" Then
                Reminder = rd("Reminder").ToString
            Else
                Reminder = rd("TutorReminder").ToString
            End If
            txtNotes.Text = Reminder
        End If
        con.Close()
    End Sub
    Private Sub picEdit_Click(sender As Object, e As EventArgs) Handles picEdit.Click
        txtNotes.Enabled = True
        picSave.Visible = True
    End Sub

    Private Sub picSave_Click(sender As Object, e As EventArgs) Handles picSave.Click
        picEdit.Visible = True
        txtNotes.Enabled = False
        con.Open()
        'Saved updated reminder 
        If Login.GlobalVariables.UserType = "Student" Then
            sql = "UPDATE Registration SET Reminder='" & txtNotes.Text & "' WHERE RegistrationID=" & RegistrationID
        Else
            sql = "UPDATE Registration SET TutorReminder='" & txtNotes.Text & "' WHERE RegistrationID=" & RegistrationID
        End If
        cmd = New OleDbCommand(sql, con)
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Reminder successfully updated!", MessageBoxIcon.Information, "Reminder")
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    'Create placeholder for txtNotes
    Private Sub txtNotes_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNotes.GotFocus
        txtNotes.Text = ""
        txtNotes.ForeColor = SystemColors.WindowFrame
    End Sub
    Private Sub txtNotes_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNotes.LostFocus
        If txtNotes.Text = "" Then
            txtNotes.Text = "Write some notes......"
            txtNotes.ForeColor = SystemColors.ScrollBar
        End If
    End Sub
End Class