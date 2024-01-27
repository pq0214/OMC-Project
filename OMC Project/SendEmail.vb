'SendEmail.vb
Imports System.Data.OleDb
Imports System.Net.Mail
Public Class SendEmail
    'Variable Declaration
    Public ReceiverID As String
    Public SenderID As String
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim ReceiverEmail, SenderEmail As String
    Private Sub SendEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        'Display ReceiverEmail
        sql = "SELECT * FROM [User] WHERE UserID = " & ReceiverID
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            rd.Read()
            ReceiverEmail = rd("Email").ToString()
        End If
        'Display SenderEmail
        sql = "SELECT * FROM [User] WHERE UserID = " & SenderID
        cmd = New OleDbCommand(sql, con)
        check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            rd.Read()
            SenderEmail = rd("Email").ToString()
        End If
        txtEmail.Text = SenderEmail
        txtTo.Text = ReceiverEmail
        con.Close()
    End Sub
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            'Connection to the server port and send email
            Dim mail As New MailMessage
            Dim smtpServer As New SmtpClient("smtp.office365.com")
            mail.From = New MailAddress(txtEmail.Text)
            mail.To.Add(txtTo.Text)
            mail.Subject = txtSubject.Text
            mail.Body = txtBody.Text
            smtpServer.Port = 587
            smtpServer.Credentials = New System.Net.NetworkCredential(txtEmail.Text, txtPassword.Text)
            smtpServer.EnableSsl = True
            smtpServer.Send(mail)
            MsgBox("Mail has been successfully sent!", vbInformation, "Email Sent")
            Me.Close()
        Catch ex As Exception
            MsgBox("Incorrect email/password. Please check again.", vbCritical, "Incorrect Email/Password")
        End Try

    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBody.Clear()
        txtSubject.Clear()
    End Sub
    Private Sub chbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chbShowPassword.CheckedChanged
        Select Case chbShowPassword.Checked
            Case True
                txtPassword.UseSystemPasswordChar = False
            Case False
                txtPassword.UseSystemPasswordChar = True
        End Select
    End Sub
End Class