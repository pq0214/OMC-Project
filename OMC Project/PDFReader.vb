'PDFReader.vb
Imports System.Data.OleDb
Public Class PDFReader
    'Variable Declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Public MaterialFile As String = ""
    Private Sub PDFReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        con.Open()
        sql = "SELECT * FROM Material WHERE MaterialFile='" & MaterialFile & "'"
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                Dim MaterialName As String
                MaterialName = rd("MaterialName").ToString
                Me.Text = MaterialName
            End While
        End If
        con.Close()
        'Open PDFReader for user to view file
        AxAcroPDF.src = MaterialFile
    End Sub
End Class