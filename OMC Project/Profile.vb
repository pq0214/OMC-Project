'Profile.vb
Imports System.Data.OleDb
Imports System.IO
Public Class Profile
    'Variable Declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim UserName, Gender, Email, Bio As String
    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UserID As Integer = Login.GlobalVariables.UserID
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        con.Open()
        sql = "SELECT * FROM [User] WHERE UserID = @UserID"
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@UserID", UserID)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            If rd.Read() Then
                'This will loop through all returned records 
                UserName = rd("UserName").ToString
                Gender = rd("Gender").ToString
                Email = rd("Email").ToString
                Bio = rd("Bio").ToString
                If Not rd.IsDBNull(rd.GetOrdinal("Profile")) Then
                    'Hide btnUpload if profile pic is uploaded
                    Dim profilePath As String = rd.GetString(rd.GetOrdinal("Profile"))
                    picProfile.Image = Image.FromFile(profilePath)
                    btnUpload.Visible = False
                Else
                    'Show btnUpload and default profile pic if no profile pic is stored 
                    picProfile.Image = Image.FromFile("C:\Users\Lee Pei Qi\Documents\ProfilePic\NoProfile.jpg")
                    btnUpload.Visible = True
                End If
                picProfile.SizeMode = PictureBoxSizeMode.StretchImage
                'handle returned value before next loop here
            End If
            rd.Close()
        End If
        con.Close()
        lblName.Text = UserName
        lblGender.Text = Gender
        lblEmail.Text = Email
        If Bio Is Nothing Then
            'Set placeholder if no Bio is added
            txtBio.Text = "Describe something about yourself......"
        Else
            txtBio.Text = Bio
        End If
    End Sub
    Private Sub btnChgPW_Click(sender As Object, e As EventArgs) Handles btnChgPW.Click
        'Open ChangePassword Form
        SideButton.OpenChildFormRefresh(ChangePassword)
    End Sub

    Private Sub picEdit_Click(sender As Object, e As EventArgs) Handles picEdit.Click
        'Show picDone when picEdit is press
        picEdit.Visible = False
        picDone.Visible = True
        txtBio.Enabled = True
    End Sub

    Private Sub picDone_Click(sender As Object, e As EventArgs) Handles picDone.Click
        'Update bio, show picEdit and disbale textbox edit when picDone is press
        picEdit.Visible = True
        picDone.Visible = False
        txtBio.Enabled = False
        If txtBio.Text = Nothing Then
        Else
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            'Update record into user table
            Dim UserID As Integer = Login.GlobalVariables.UserID
            sql = "UPDATE [User] SET Bio='" & txtBio.Text & "' WHERE UserID= " & UserID
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Bio successfully updated!", MessageBoxIcon.Information, "Profile")
        End If
    End Sub
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        'Initialize directory
        UploadPhoto.InitialDirectory = "C:\"
        UploadPhoto.Filter = "Image Files|*.jpg;*.jpeg;*.png;"
        'Set file type to only pdf
        If UploadPhoto.ShowDialog = DialogResult.OK Then
            'Get file path name
            picProfile.Image.Dispose()
            picProfile.Image = Nothing
            Dim filePath As String = UploadPhoto.FileName
            ' Set the destination path and filename
            Dim UserID As String = Login.GlobalVariables.UserID
            Dim fileExtension As String = Path.GetExtension(filePath)
            Dim destinationFilePath As String = "C:\Users\Lee Pei Qi\Documents\ProfilePic\" & UserID & fileExtension
            ' Copy the file to the destination path
            File.Copy(filePath, destinationFilePath, True)
            MsgBox("Picture Successfully Uploaded", MsgBoxStyle.Information, "Material")
            'Insert file path 
            con.Open()
            sql = "UPDATE [User] SET Profile='" & destinationFilePath & "' WHERE UserID=" & UserID
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            'Display profile pic
            picProfile.Image = Image.FromFile(destinationFilePath)
            picProfile.SizeMode = PictureBoxSizeMode.Zoom
        End If
        'Refresh Profile Form
        Profile_Load(Me, EventArgs.Empty)
    End Sub
    'Create placeholder if no value stored
    Private Sub txtBio_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBio.GotFocus
        If txtBio.Text = Nothing Or txtBio.Text = "Describe something about yourself......" Then
            txtBio.Text = ""
            txtBio.ForeColor = SystemColors.WindowFrame
        End If
    End Sub
    Private Sub txtBio_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBio.LostFocus
        If txtBio.Text = Nothing Then
            txtBio.Text = "Describe something about yourself......"
            txtBio.ForeColor = SystemColors.ScrollBar
            txtBio.Enabled = False
            picEdit.Visible = True
            picDone.Visible = False
        End If
    End Sub
End Class