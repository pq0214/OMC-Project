'SideButton.vb
Imports System.Drawing.Drawing2D
Imports System.Reflection
Imports OMC_Project.Login
Public Class SideButton
    Private activeForm As Form = Nothing
    Public Sub ShowAndTriggerLoadEvent()
        Me.Show()
        Me.OnLoad(EventArgs.Empty)
    End Sub
    Public Shared Function OpenChildFormRefresh(childForm As Form) As String
        'Open and refresh form in Panel
        If SideButton.activeForm IsNot Nothing Then
            SideButton.activeForm.Hide()
        End If
        SideButton.activeForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        SideButton.pnlChildForm.Controls.Add(childForm)
        SideButton.pnlChildForm.Tag = childForm
        childForm.Show()
        Dim onLoadMethod As MethodInfo = GetType(Form).GetMethod("OnLoad", BindingFlags.NonPublic Or BindingFlags.Instance)
        onLoadMethod.Invoke(childForm, New Object() {EventArgs.Empty})
    End Function
    Public Sub SideButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set Right panel white rectangle to round
        ' Create a GraphicsPath object
        Dim path As New GraphicsPath()
        ' Set the rounded rectangle shape with desired radius and dimensions for panel1
        Dim cornerRadius As Integer = 20
        Dim rect As New Rectangle(0, 0, pnlChildForm.Width, pnlChildForm.Height)
        path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90) ' Top-left corner
        path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90) ' Top-right corner
        path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90) ' Bottom-right corner
        path.AddArc(rect.X, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90) ' Bottom-left corner
        pnlChildForm.Region = New Region(path)
        path.CloseAllFigures()

        Dim path2 As New GraphicsPath()
        cornerRadius = 10
        Dim rect2 As New Rectangle(0, 0, Panel2.Width, Panel2.Height)
        path2.AddArc(rect2.X, rect2.Y, cornerRadius, cornerRadius, 180, 90) ' Top-left corner
        path2.AddArc(rect2.X + rect2.Width - cornerRadius, rect2.Y, cornerRadius, cornerRadius, 270, 90) ' Top-right corner
        path2.AddArc(rect2.X + rect2.Width - cornerRadius, rect2.Y + rect2.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90) ' Bottom-right corner
        path2.AddArc(rect2.X, rect2.Y + rect2.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90) ' Bottom-left corner
        Panel2.Region = New Region(path2)
        path2.CloseAllFigures()
        'Set button name and open different form for different user
        Dim UserType As String = Login.GlobalVariables.UserType
        If GlobalVariables.UserType = "Admin" Then
            SideButton.OpenChildFormRefresh(AdminStart)
            btn1.Text = "Verify"
            btn2.Text = "Tutor"
            btn3.Text = "Student"
        ElseIf GlobalVariables.UserType = "Tutor" Then
            SideButton.OpenChildFormRefresh(TutorStart)
            btn1.Text = "Class"
            btn2.Text = "Student"
            btn3.Text = "Schedule"
        Else
            SideButton.OpenChildFormRefresh(StudentStart)
            btn1.Text = "Tutor"
            btn2.Text = "Classes"
            btn3.Text = "Schedule"
        End If
    End Sub
    Private Sub picHome_Click(sender As Object, e As EventArgs) Handles picHome.Click
        'Open start form for different user
        Dim UserType As String = Login.GlobalVariables.UserType
        If UserType = "Admin" Then
            OpenChildFormRefresh(AdminStart)
        ElseIf UserType = "Student" Then
            OpenChildFormRefresh(StudentStart)
        Else
            OpenChildFormRefresh(TutorStart)
        End If
    End Sub
    Protected Sub btnProfile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnProfile.Click
        'Open Profile Form
        OpenChildFormRefresh(Profile)
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        'Set button name and open different form for different user
        Dim UserType As String = Login.GlobalVariables.UserType
        If UserType = "Admin" Then
            OpenChildFormRefresh(AdminVerification)
        ElseIf UserType = "Tutor" Then
            OpenChildFormRefresh(TutorClass)
        Else
            AdminView.UserType = "Tutor"
            OpenChildFormRefresh(AdminView)
        End If
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        'Set button name and open different form for different user
        Dim UserType As String = Login.GlobalVariables.UserType
        If UserType = "Admin" Then
            AdminView.UserType = "Tutor"
            OpenChildFormRefresh(AdminView)
        ElseIf UserType = "Tutor" Then
            OpenChildFormRefresh(TutorStudent)
        Else
            OpenChildFormRefresh(StudentClass)
        End If
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        'Set button name and open different form for different user
        Dim UserType As String = Login.GlobalVariables.UserType
        If UserType = "Admin" Then
            AdminView.UserType = "Student"
            OpenChildFormRefresh(AdminView)
        ElseIf UserType = "Tutor" Then
            OpenChildFormRefresh(Schedule)
        Else
            OpenChildFormRefresh(Schedule)
        End If
        'OpenChildForm(StudentForm)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim response As String
        'Exit Confirmation
        response = MsgBox("Do you want to log out?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Log Out")
        If response = MsgBoxResult.Yes Then
            MsgBox(Space(8) & "Account log out succesfully!" & vbCrLf & Space(20) & "Thank You", MsgBoxStyle.OkOnly, "Log Out")
            Login.Show()
            Login.ShowAndTriggerLoadEvent()
            Me.Hide()
        End If
    End Sub
    Private Sub picAbout_Click(sender As Object, e As EventArgs) Handles picAbout.Click
        'Show AboutBox
        AboutBox.ShowDialog()
    End Sub
End Class