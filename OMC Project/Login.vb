'Login.vb
Imports System.Data.OleDb
Public Class Login
    'Variable delcaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Public Sub ShowAndTriggerLoadEvent()
        Me.Show()
        Me.OnLoad(EventArgs.Empty)
    End Sub
    Public Class GlobalVariables
        'Declare GLobal Variables that can be access from various form
        Public Shared UserType As String = ""
        Public Shared UserID As Integer
    End Class
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        txtEmail.Text = ""
        txtPassword.Text = ""
    End Sub
    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        'Set password char to * if checked box is checked
        If chkShow.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Check if user key in all the information
        If txtEmail.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please fill in all the information!")
        Else
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            sql = "SELECT * FROM [User] WHERE Email = @Email and Password = @Password"
            cmd = New OleDbCommand(sql, con)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            Dim check = Convert.ToInt32(cmd.ExecuteScalar())
            If check > 0 Then
                rd = cmd.ExecuteReader()
                'Loop through all returned records 
                While rd.Read()
                    Login.GlobalVariables.UserType = rd("UserType").ToString
                    Login.GlobalVariables.UserID = rd("UserID")
                    'handle returned value before next loop here
                End While
                con.Close()
                MsgBox("Welcome to NetGenius!", MsgBoxStyle.OkOnly, "NetGenius")
                SideButton.ShowAndTriggerLoadEvent()
                Me.Hide()
            Else
                'Display if username and password is incorrect
                MsgBox("Please enter a valid username and password!", MsgBoxStyle.Critical, "Login")
            End If
        End If
    End Sub
    Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click
        'Open SignUp form
        SignUp.Show()
        Me.Hide()
    End Sub
    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        'Exit Confirmation
        Dim response As String
        response = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Exit")
        If response = MsgBoxResult.Yes Then
            MsgBox(Space(8) & "Thank you for using NetGenius" & vbCrLf & Space(20) & "Have A Nice Day", MsgBoxStyle.OkOnly, "Exit")
            Me.Close()
        End If
    End Sub
    'Set Placeholder for txtEmail
    Private Sub txtEmail_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.GotFocus
        txtEmail.Text = ""
        txtEmail.ForeColor = SystemColors.WindowFrame
    End Sub
    Private Sub txtEmail_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.LostFocus
        If txtEmail.Text = "" Then
            txtEmail.Text = "Email Address"
            txtEmail.ForeColor = SystemColors.ScrollBar
        End If
    End Sub
End Class