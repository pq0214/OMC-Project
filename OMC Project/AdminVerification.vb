'AdminVerification.vb
Imports System.Data.OleDb
Public Class AdminVerification
    'Variable declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim SubjectID, SubjectName, DateSubmit, UserName As String
    Private Sub AdminVerification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearRows(tableTutorVerification, 1)
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        con.Open()
        sql = "SELECT * FROM Subject INNER Join [User] On Subject.UserID=[User].UserID WHERE Subject.Status=False"
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                SubjectID = rd("SubjectID").ToString
                SubjectName = rd("SubjectName").ToString
                DateSubmit = rd("DateSubmit").ToString
                UserName = rd("UserName").ToString
                'handle returned value before next loop here
                tableTutorVerification.GrowStyle = TableLayoutPanelGrowStyle.AddRows
                tableTutorVerification.RowStyles.Add(New RowStyle(SizeType.Absolute, 45.0!))
                tableTutorVerification.RowCount += 1
                '
                'PanelVerification
                '
                Dim PanelVerification As New Panel
                PanelVerification.BackColor = SystemColors.ButtonHighlight
                PanelVerification.Location = New Point(3, 63)
                PanelVerification.Size = New Size(745, 35)
                PanelVerification.Dock = DockStyle.Top
                '
                'lblSubject
                '
                Dim lblSubject As New Label
                lblSubject.AutoSize = True
                lblSubject.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblSubject.ForeColor = SystemColors.WindowFrame
                lblSubject.Location = New Point(150, 3)
                lblSubject.Size = New Size(95, 24)
                lblSubject.Text = SubjectName
                lblSubject.TextAlign = ContentAlignment.TopCenter
                '
                'lblDate
                '
                Dim lblDate As New Label
                lblDate.AutoSize = True
                lblDate.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblDate.ForeColor = SystemColors.WindowFrame
                lblDate.Location = New Point(330, 3)
                lblDate.Size = New Size(72, 24)
                lblDate.Text = FormatDateTime(DateSubmit, DateFormat.ShortDate)
                lblDate.TextAlign = ContentAlignment.TopCenter
                '
                'lblName
                '
                Dim lblName As New Label
                lblName.AutoSize = True
                lblName.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                lblName.ForeColor = SystemColors.WindowFrame
                lblName.Location = New Point(10, 3)
                lblName.Size = New Size(78, 24)
                lblName.Text = UserName
                lblName.TextAlign = ContentAlignment.TopCenter
                '
                'btnVerify
                '
                Dim btnVerify As New Button
                btnVerify.FlatAppearance.BorderColor = SystemColors.InactiveCaptionText
                btnVerify.FlatAppearance.BorderSize = 2
                btnVerify.Font = New Font("Kristen ITC", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                btnVerify.ForeColor = SystemColors.WindowFrame
                btnVerify.BackColor = SystemColors.ScrollBar
                btnVerify.Location = New Point(455, 0)
                btnVerify.Size = New Size(91, 29)
                btnVerify.Text = "Verify"
                btnVerify.UseVisualStyleBackColor = False
                btnVerify.Tag = SubjectID
                AddHandler btnVerify.Click, AddressOf btnVerify_Click
                '
                'Line for table
                '
                Dim label1 As New Label
                label1.BackColor = SystemColors.ScrollBar
                label1.Dock = DockStyle.Bottom
                label1.Location = New Point(0, 36)
                label1.Size = New Size(745, 3)
                'Add all element into panel
                PanelVerification.Controls.Add(btnVerify)
                PanelVerification.Controls.Add(label1)
                PanelVerification.Controls.Add(lblSubject)
                PanelVerification.Controls.Add(lblDate)
                PanelVerification.Controls.Add(lblName)
                tableTutorVerification.Controls.Add(PanelVerification, 0, tableTutorVerification.RowCount - 1)
            End While
        Else
            ClearRows(tableTutorVerification, 1)
            tableTutorVerification.GrowStyle = TableLayoutPanelGrowStyle.AddRows
            tableTutorVerification.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            tableTutorVerification.RowCount += 1
            'Panel2
            '
            Dim PanelVerification As New Panel
            PanelVerification.BackColor = SystemColors.ButtonHighlight
            PanelVerification.Location = New Point(31, 185)
            PanelVerification.Size = New Size(745, 39)
            '
            'Label3
            '
            Dim label3 As New Label
            label3.BackColor = SystemColors.ScrollBar
            label3.Dock = DockStyle.Bottom
            label3.Location = New Point(0, 36)
            label3.Size = New Size(745, 3)
            '
            'lblNoRecord
            '
            Dim lblNoRecord As New Label
            lblNoRecord.AutoSize = True
            lblNoRecord.Font = New Font("Kristen ITC", 10.2!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            lblNoRecord.ForeColor = SystemColors.WindowFrame
            lblNoRecord.Location = New Point(200, 5)
            lblNoRecord.Size = New Size(255, 24)
            lblNoRecord.Text = "All Verification is Completed"
            lblNoRecord.TextAlign = ContentAlignment.MiddleCenter
            '
            'Add element to PanelVerification
            PanelVerification.Controls.Add(label3)
            PanelVerification.Controls.Add(lblNoRecord)
            tableTutorVerification.Controls.Add(PanelVerification, 0, 1)
        End If
        con.Close()
    End Sub
    Public Sub ClearRows(tableLayoutPanel As TableLayoutPanel, startRow As Integer)
        ' Remove controls from the specified row till the end
        For row As Integer = tableLayoutPanel.RowCount - 1 To startRow Step -1
            For column As Integer = tableLayoutPanel.ColumnCount - 1 To 0 Step -1
                Dim control As Control = tableLayoutPanel.GetControlFromPosition(column, row)
                If control IsNot Nothing Then
                    tableLayoutPanel.Controls.Remove(control)
                    control.Dispose() ' Optionally, dispose of the control if necessary
                End If
            Next
            tableLayoutPanel.RowStyles.RemoveAt(row)
            tableLayoutPanel.RowCount -= 1
        Next
    End Sub
    Public SubID As String
    Private Sub btnVerify_Click(sender As Object, e As EventArgs)
        'Open AdminVerifyList when buttonVerify is press
        Dim btnVerify As Button = DirectCast(sender, Button)
        SubID = CInt(btnVerify.Tag)
        SideButton.OpenChildFormRefresh(AdminVerifyList)
    End Sub
End Class