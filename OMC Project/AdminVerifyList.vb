'AdminVerifyList.vb
Imports System.Data.OleDb
Public Class AdminVerifyList
    'Variable declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim Gender, SubjectName, UserName, Price, MaterialName, MaterialFile, Profile As String
    Dim SubjectID As Integer
    Public Sub AdminVerifyList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        con.Open()
        'Display tutor profile message
        sql = "SELECT * FROM Subject INNER Join [User] On Subject.UserID=[User].UserID WHERE Subject.SubjectID=" & AdminVerification.SubID
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            rd.Read()
            Gender = rd("Gender").ToString
            SubjectName = rd("SubjectName").ToString
            UserName = rd("UserName").ToString
            Price = rd("Price").ToString
            If Not rd.IsDBNull(rd.GetOrdinal("Profile")) Then
                Profile = rd.GetString(rd.GetOrdinal("Profile"))
                'Display Profile Picture
                picProfile.Image = Image.FromFile(Profile)
            Else
                'Display default image if no picture is stored
                picProfile.Image = Image.FromFile("C:\Users\Lee Pei Qi\Documents\ProfilePic\NoProfile.jpg")
            End If
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        lblName.Text = UserName
        lblGender.Text = Gender
        lblSubject.Text = SubjectName
        lblPrice.Text = Format(Price, "Currency")
        '----------------------Document List---------------------------------------
        'Clear rows before inserting new info
        AdminVerification.ClearRows(tableViewDocument, 0)
        'Display tutor submitted document
        sql = "SELECT * FROM Material WHERE SubjectID=" & AdminVerification.SubID
        cmd = New OleDbCommand(sql, con)
        check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                MaterialName = rd("MaterialName").ToString
                MaterialFile = rd("MaterialFile").ToString
                'handle returned value before next loop here
                tableViewDocument.GrowStyle = TableLayoutPanelGrowStyle.AddRows
                tableViewDocument.RowStyles.Add(New RowStyle(SizeType.Absolute, 35.0!))
                tableViewDocument.RowCount += 1
                '
                'PanelDocument
                '
                Dim PanelDocument As New Panel
                PanelDocument.Dock = DockStyle.Top
                PanelDocument.Location = New Point(3, 3)
                PanelDocument.Size = New Size(371, 40)
                '
                'lblMaterial
                '
                Dim lblMaterial As New Label
                lblMaterial.Anchor = AnchorStyles.None
                lblMaterial.AutoSize = True
                lblMaterial.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblMaterial.ForeColor = SystemColors.AppWorkspace
                lblMaterial.Location = New Point(6, 7)
                lblMaterial.Size = New Size(102, 24)
                lblMaterial.Text = MaterialName
                lblMaterial.Dock = DockStyle.Top
                '
                'btnView
                '
                Dim btnView As New Button
                btnView.BackColor = SystemColors.ScrollBar
                btnView.Font = New Font("Kristen ITC", 7.8!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                btnView.ForeColor = SystemColors.WindowFrame
                btnView.Location = New Point(320, 2)
                btnView.Name = "btnView"
                btnView.Tag = MaterialFile
                btnView.Size = New Size(70, 23)
                btnView.Text = "View"
                btnView.UseVisualStyleBackColor = False
                AddHandler btnView.Click, AddressOf btnView_Click
                'Add all element into panel
                PanelDocument.Controls.Add(btnView)
                PanelDocument.Controls.Add(lblMaterial)
                tableViewDocument.Controls.Add(PanelDocument, 0, tableViewDocument.RowCount - 1)
            End While
        Else
            'handle returned value before next loop here
            AdminVerification.ClearRows(tableViewDocument, 0)
            tableViewDocument.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            tableViewDocument.RowStyles.Add(New RowStyle(SizeType.Absolute, 45.0!))
            tableViewDocument.RowCount += 1
            '
            'PanelDocument
            '
            Dim PanelDocument As New Panel
            PanelDocument.Dock = DockStyle.Top
            PanelDocument.Location = New Point(3, 3)
            PanelDocument.Size = New Size(371, 40)
            '
            'lblNoRecord
            '
            Dim lblNoRecord As New Label
            lblNoRecord.Anchor = AnchorStyles.None
            lblNoRecord.AutoSize = True
            lblNoRecord.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            lblNoRecord.ForeColor = SystemColors.AppWorkspace
            lblNoRecord.Location = New Point(40, 7)
            lblNoRecord.Size = New Size(102, 24)
            lblNoRecord.Text = "No document submitted"
            lblNoRecord.Dock = DockStyle.Top
            'Add element into panel
            PanelDocument.Controls.Add(lblNoRecord)
            tableViewDocument.Controls.Add(PanelDocument, 0, 0)
        End If
        con.Close()
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs)
        'Send MaterialFile path to pdf Reader
        Dim btnView As Button = DirectCast(sender, Button)
        PDFReader.MaterialFile = btnView.Tag
        PDFReader.ShowDialog()
    End Sub
    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        'Remove student from the subject
        Dim response As String
        response = MsgBox("Do you want to reject this subject?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Verification")
        If response = MsgBoxResult.Yes Then
            con.Open()
            sql = "DELETE FROM Subject WHERE SubjectID=" & AdminVerification.SubID
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Subject successfully rejected!", MsgBoxStyle.Information, "Verification")
            SideButton.OpenChildFormRefresh(AdminVerification)
            con.Close()
        End If
    End Sub
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        'Add student to the subject
        Dim response As String
        response = MsgBox("Do you want to approve this subject?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Verification")
        If response = MsgBoxResult.Yes Then
            con.Open()
            sql = "UPDATE Subject SET Status=True WHERE SubjectID= " & AdminVerification.SubID
            cmd = New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Subject Successfully Approved!", MsgBoxStyle.Information, "Verification")
            SideButton.OpenChildFormRefresh(AdminVerification)
            con.Close()
        End If
    End Sub
End Class