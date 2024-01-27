'SignUp.vb
Imports System.Data.OleDb
Imports System.Net.Mail

Public Class SignUp
    'Variable Declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim UserType, Gender As String
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connection to database
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        'Set initial value to null
        txtName.Text = "Name"
        txtPassword.Text = ""
        txtEmail.Text = "xxx@utp.edu.my"
    End Sub
    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        'Show password without * when check box is unchecked
        If chkShow.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Button login press to go to login page
        Login.Show()
        Me.Close()
    End Sub
    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnCreateAcc.Click
        'Check usertype
        If rbtStudent.Checked = True Then
            UserType = "Student"
        ElseIf rbtTutor.Checked = True Then
            UserType = "Tutor"
        Else
            MsgBox("Please choose type of user!", MessageBoxIcon.Warning, "Sign Up")
        End If
        'Check gender
        If rbtFemale.Checked = True Then
            Gender = "Female"
        ElseIf rbtMale.Checked = True Then
            Gender = "Male"
        Else
            MsgBox("Please choose your gender!", MessageBoxIcon.Warning, "Sign Up")
        End If
        'Check if user key in all the information required
        If (txtName.Text = Nothing Or txtEmail.Text = Nothing Or txtPassword.Text = Nothing) Then
            MsgBox("Please key in all the required information!", MessageBoxIcon.Warning, "Sign Up")
        Else
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            'Check if email duplicate
            sql = "SELECT * FROM [User] WHERE Email = @Email"
            cmd = New OleDbCommand(sql, con)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            Dim check = Convert.ToInt32(cmd.ExecuteScalar())
            If check > 0 Then
                MsgBox("This email is registered. Please try another email!", MessageBoxIcon.Warning, "Sign Up")
                txtEmail.Text = ""
            Else
                ' Call the IsEmailValid function and display the result
                If IsUTPEmail(txtEmail.Text) Then
                    'Add record into the system
                    sql = "INSERT INTO [User]([UserName], [Gender], [UserType],[Password],[Email]) VALUES(@UserName,@Gender,@UserType,@Password,@Email)"
                    cmd = New OleDbCommand(sql, con)
                    cmd.Parameters.AddWithValue("@UserName", txtName.Text)
                    cmd.Parameters.AddWithValue("@Gender", Gender)
                    cmd.Parameters.AddWithValue("@UserType", UserType)
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    rd = cmd.ExecuteReader()
                    con.Close()
                    MsgBox("Account successfully created!", MessageBoxIcon.Information, "Create New Account")
                    'Show Login form
                    Login.Show()
                    Me.Close()
                Else
                    MsgBox("Please use your UTP email address to register.")
                End If
            End If
        End If
    End Sub
    'Check if is utp email address
    Public Function IsUTPEmail(ByVal emailAddress As String) As Boolean
        Dim utpDomain As String = "@utp.edu.my" ' UTP email domain
        ' Check if the email address has the UTP domain and is a Microsoft email
        If emailAddress.EndsWith(utpDomain, StringComparison.OrdinalIgnoreCase) Then
            Return True ' Email is a UTP Microsoft email
        Else
            Return False ' Email is not a UTP Microsoft email
        End If
    End Function
    'Set placeholder for txtName and txtEmail
    Private Sub txtName_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.GotFocus
        txtName.Text = ""
        txtName.ForeColor = SystemColors.WindowFrame
    End Sub
    Private Sub txtName_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.LostFocus
        If txtName.Text = "" Then
            txtName.Text = "Name"
            txtName.ForeColor = SystemColors.ScrollBar
        End If
    End Sub
    Private Sub txtEmail_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.GotFocus
        txtEmail.Text = ""
        txtEmail.ForeColor = SystemColors.WindowFrame
    End Sub
    Private Sub txtEmail_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.LostFocus
        If txtEmail.Text = "" Then
            txtEmail.Text = "xxx@utp.edu.my"
            txtEmail.ForeColor = SystemColors.ScrollBar
        End If
    End Sub
End Class