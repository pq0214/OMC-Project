'ChangePassword.vb
Imports System.Data.OleDb
Public Class ChangePassword
    'Variable Declaration
    Dim UserID As String = Login.GlobalVariables.UserID
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim oldpassword As String
    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        'Set all field to empty
        txtNewPW.Text = ""
        txtCurrentPW.Text = ""
        txtConfirmPW.Text = ""
    End Sub
    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        'Set password char to * if checked box is checked
        If chkShow.Checked = True Then
            txtConfirmPW.PasswordChar = ""
            txtNewPW.PasswordChar = ""
            txtCurrentPW.PasswordChar = ""
        Else
            txtConfirmPW.PasswordChar = "*"
            txtNewPW.PasswordChar = "*"
            txtCurrentPW.PasswordChar = "*"
        End If
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        con.Open()
        sql = "SELECT * FROM [User] WHERE UserID = @UserID and [Password] = @Password"
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@UserID", UserID)
        cmd.Parameters.AddWithValue("@Password", txtCurrentPW.Text)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        'Check txtCurrentPW same with Password
        If check > 0 Then
            'Check ConfirmPW and NewPW is the same
            If (txtConfirmPW.Text = txtNewPW.Text) Then
                sql = "UPDATE [User] SET [Password]='" & txtConfirmPW.Text & "' WHERE UserID= " & UserID
                cmd = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Password Changed successfully!")
                SideButton.OpenChildFormRefresh(Profile)
            Else
                'Display MsgBox if ConfirmPW and NewPW is different
                MsgBox("Please make sure your new password is same with your confirm password!", MsgBoxStyle.Exclamation, "Login")
                txtConfirmPW.Text = ""
            End If
        Else
            'Display MsgBox if current password incorrect
            MsgBox("Your Current Password is incorrect!")
            txtCurrentPW.Text = ""
            txtConfirmPW.Text = ""
            txtNewPW.Text = ""
        End If
        con.Close()
    End Sub
End Class