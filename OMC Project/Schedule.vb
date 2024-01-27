'Schedule.vb
Imports System.Data.OleDb
Public Class Schedule
    'Variable Delcaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim DateList(6) As Date
    Dim DayList(6) As String
    Dim RegistrationID As Integer
    Dim SubjectName As String
    Private Sub Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        'Set minDate as Today and maxDate as 3month in advance from today
        DateEnroll.MaxDate = DateTime.Today.AddMonths(3)
        DateEnroll.MinDate = DateTime.Today
        DisplayDate()
        InsertTagForButton()
    End Sub
    Private Sub DateEnroll_ValueChanged(sender As Object, e As EventArgs) Handles DateEnroll.ValueChanged
        DisplayDate()
        InsertTagForButton()
    End Sub
    Private Sub DisplayDate()
        'Display date and day for consecutive 7days from selected date
        Dim SelectedDate As Date = DateEnroll.Value
        Dim EnrollDate As Integer = SelectedDate.Day
        DateList(0) = SelectedDate.ToString("d/M/yyyy")
        StartDate.Text = SelectedDate.ToString("dd/M")
        DayList(0) = SelectedDate.ToString("ddd")
        StartDay.Text = DayList(0)
        'Stored Dates and Day to Array
        For i As Integer = 1 To 6
            Dim labelName As String = "Date" & (i)
            Dim label As Label = DirectCast(Me.Controls(labelName), Label)
            Dim currentDate As Date = SelectedDate.AddDays(i)
            DateList(i) = currentDate
            If label IsNot Nothing Then
                'Format display date to d/M ex: 7/10
                label.Text = currentDate.ToString("d/M")
                Dim dayOfWeekLabelName As String = "Day" & (i)
                Dim dayOfWeekLabel As Label = DirectCast(Me.Controls(dayOfWeekLabelName), Label)
                If dayOfWeekLabel IsNot Nothing Then
                    Dim dayOfWeekText As String = currentDate.ToString("ddd")
                    dayOfWeekLabel.Text = dayOfWeekText
                    'Set Color of day to Red if day is Sun/Sat
                    If dayOfWeekText = "Sun" Or dayOfWeekText = "Sat" Then
                        dayOfWeekLabel.ForeColor = Color.Red
                    Else
                        dayOfWeekLabel.ForeColor = SystemColors.WindowFrame
                    End If
                    DayList(i) = dayOfWeekLabel.Text
                End If
            End If
        Next
    End Sub
    Private Sub InsertTagForButton()
        'Insert Date and Slot into buttontag for all button
        For i As Integer = 0 To 6
            For j As Integer = 1 To 5
                Dim buttonName As String = "btn" & i & j
                Dim button As Button = DirectCast(Me.Controls(buttonName), Button)
                If button IsNot Nothing Then
                    Dim tagValue As Tuple(Of Date, Integer, String) = New Tuple(Of Date, Integer, String)(DateList(i), j, DayList(i))
                    button.Tag = tagValue
                    'Set button color to Khaki if day is Sat/Sun
                    If DayList(i) = "Sun" Or DayList(i) = "Sat" Then
                        button.Text = ""
                        button.BackColor = Color.Khaki
                    Else
                        button.Text = ""
                        button.BackColor = SystemColors.GradientInactiveCaption
                    End If
                    Dim DateClass As Date = tagValue.Item1
                    Dim Slot As Integer = tagValue.Item2
                    con.Open()
                    '----------------------Check Availability----------------------------------
                    sql = "SELECT * FROM Schedule WHERE (((Schedule.[DateClass])=Format(@DateClass, 'd/M/yyyy')) AND ((Schedule.[Slot])=@Slot))"
                    Dim cmd As New OleDbCommand(sql, con)
                    cmd.Parameters.AddWithValue("@DateClass", DateClass)
                    cmd.Parameters.AddWithValue("@Slot", Slot)
                    Dim check As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    'Disable button for class that is not related to the user
                    If check > 0 Then
                        rd = cmd.ExecuteReader()
                        While rd.Read()
                            RegistrationID = rd("RegistrationID")
                            Dim sql1 As String
                            If Login.GlobalVariables.UserType = "Student" Then
                                'Determine class enroll by the student
                                sql1 = "SELECT * FROM Registration INNER Join Subject On Registration.SubjectID=Subject.SubjectID WHERE RegistrationID=" & RegistrationID &
                                " AND Registration.UserID=" & Login.GlobalVariables.UserID
                            Else
                                'Determine class register under the tutor
                                sql1 = "SELECT * FROM Registration INNER Join Subject On Registration.SubjectID=Subject.SubjectID WHERE RegistrationID=" & RegistrationID &
                                " AND Subject.UserID=" & Login.GlobalVariables.UserID
                            End If
                            Dim cmd1 = New OleDbCommand(sql1, con)
                            Dim check1 = Convert.ToInt32(cmd1.ExecuteScalar())
                            If check1 > 0 Then
                                Dim rd1 = cmd1.ExecuteReader()
                                rd1.Read()
                                SubjectName = rd1("SubjectName").ToString
                                button.Text = SubjectName
                                button.Enabled = True
                                button.BackColor = Color.LightCoral
                                button.Tag = RegistrationID
                                AddHandler button.Click, AddressOf Button_Click
                            End If
                        End While
                    Else
                        button.Enabled = False
                        button.Text = ""
                    End If
                End If
                con.Close()
            Next
        Next
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs)
        'Open ScheduleNote form
        Dim ButtonBook As Button = DirectCast(sender, Button)
        ScheduleNote.RegistrationID = ButtonBook.Tag
        ScheduleNote.ShowDialog()
    End Sub
End Class