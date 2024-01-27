'StudentBook.vb
Imports System.Data.OleDb
Public Class StudentBook
    'Variable Declaration
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim DateList(6) As Date
    Dim DayList(6) As String
    Public RegistrationID As Integer
    Private Sub StudentBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                        button.BackColor = Color.Khaki
                    Else
                        button.BackColor = SystemColors.GradientInactiveCaption
                    End If
                    Dim DateClass As Date = tagValue.Item1
                    Dim Slot As Integer = tagValue.Item2
                    con.Open()
                    '----------------------Check Availability----------------------------------
                    sql = "SELECT Count(*) FROM Schedule WHERE (((Schedule.[DateClass])=Format(@DateClass, 'd/M/yyyy')) AND ((Schedule.[Slot])=@Slot))"
                    Dim cmd As New OleDbCommand(sql, con)
                    cmd.Parameters.AddWithValue("@DateClass", DateClass)
                    cmd.Parameters.AddWithValue("@Slot", Slot)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    con.Close()
                    'Disable button if the schedule is booked
                    If count > 0 Then
                        button.Enabled = False
                        button.Text = "Booked"
                        button.BackColor = Color.LightCoral
                    Else
                        button.Enabled = True
                        button.Text = ""
                    End If
                    AddHandler button.Click, AddressOf Button_Click
                End If
            Next
        Next
    End Sub
    Private Sub Button_Click(sender As Object, e As EventArgs)
        ' handle the button click event here
        Dim ButtonBook As Button = DirectCast(sender, Button)
        Dim tagvalue As Tuple(Of Date, Integer, String) = DirectCast(ButtonBook.Tag, Tuple(Of Date, Integer, String))
        ' access the properties or perform actions related to the clicked button
        Dim DateClass As Date = tagvalue.Item1
        Dim Slot As Integer = tagvalue.Item2
        con.Open()
        'Check whether the date and slot is booked
        Dim sql = "SELECT COUNT(*) FROM Schedule WHERE DateClass = @DateClass AND Slot = @Slot"
        Dim cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@DateClass", DateClass.ToString("d/M/yyyy"))
        cmd.Parameters.AddWithValue("@Slot", Slot)
        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
        If count > 0 Then
        Else
            'Insert selected slot and date
            sql = "INSERT INTO Schedule([RegistrationID], [DateClass], [Slot]) VALUES(@RegistrationID, @DateClass, @Slot)"
            cmd = New OleDbCommand(sql, con)
            cmd.Parameters.AddWithValue("@RegistrationID", RegistrationID)
            cmd.Parameters.Add("@DateClass", OleDbType.DBDate).Value = DateClass
            cmd.Parameters.AddWithValue("@Slot", Slot)
            cmd.ExecuteNonQuery()
            MsgBox("Registration completed! please wait for tutor verification.", MsgBoxStyle.Information, "registration")
        End If
        con.Close()
        'Open StudentTutor form
        SideButton.OpenChildFormRefresh(StudentTutor)
    End Sub
End Class