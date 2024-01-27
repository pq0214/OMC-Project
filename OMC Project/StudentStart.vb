'StudentStart.vb
Imports System.Data.OleDb
Public Class StudentStart
    'Variable Declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim Profile As String
    Private Sub StudentStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get UserID from LoginPage
        Dim UserID As Integer = Login.GlobalVariables.UserID
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        con.Open()
        sql = "SELECT * FROM [User] WHERE UserID =" & UserID
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        rd = cmd.ExecuteReader()
        If rd.Read() Then
            ' Row exists, retrieve data from the reader
            If Not rd.IsDBNull(rd.GetOrdinal("Profile")) Then
                'Display profile picture
                Profile = rd.GetString(rd.GetOrdinal("Profile"))
                picProfile.Image = Image.FromFile(Profile)
            Else
                'Display default image if no picture is stored
                picProfile.Image = Image.FromFile("C:\Users\Lee Pei Qi\Documents\ProfilePic\NoProfile.jpg")
            End If
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        con.Close()
    End Sub
End Class