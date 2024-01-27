'StudentClassPayment.vb
Imports System.Data.OleDb
Imports System.Drawing.Printing
Public Class StudentClassPayment
    'Variable Declaration
    Public RegistrationID As Integer
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim rd As OleDbDataReader
    Dim sql As String = Nothing
    Dim UserName, SubjectName, Price As String
    Dim Slot As Integer
    Dim DateClass As Date
    Private Sub StudentClassPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lee Pei Qi\Documents\Database1.accdb;")
        con.Open()
        'Display UserName
        sql = "SELECT * FROM [User] WHERE [UserID]=" & Login.GlobalVariables.UserID
        cmd = New OleDbCommand(sql, con)
        Dim check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            rd.Read()
            UserName = rd("UserName").ToString
        End If
        Dim PaymentTime As Date
        PaymentTime = DateTime.Now()
        lblUserName.Text = UserName + " " + PaymentTime
        'Display all relevent information
        sql = "SELECT * FROM Registration INNER Join Subject On Registration.SubjectID=Subject.SubjectID WHERE RegistrationID=" & RegistrationID
        cmd = New OleDbCommand(sql, con)
        check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                SubjectName = rd("SubjectName").ToString
                Price = rd("Price")
            End While
        End If
        lblSubjectName.Text = SubjectName
        lblPrice.Text = Format(Price, "Currency")
        sql = "SELECT * FROM Schedule WHERE RegistrationID=" & RegistrationID
        cmd = New OleDbCommand(sql, con)
        check = Convert.ToInt32(cmd.ExecuteScalar())
        If check > 0 Then
            rd = cmd.ExecuteReader()
            While rd.Read()
                Slot = rd("Slot")
                Dim DateValue As Date = rd.GetDateTime(rd.GetOrdinal("DateClass"))
                DateClass = DateValue.ToString("d/M/yyyy")
            End While
        End If
        Dim TimeClass As String
        If Slot = 1 Then
            TimeClass = "8am-10am"
        ElseIf Slot = 2 Then
            TimeClass = "10am-12pm"
        ElseIf Slot = 3 Then
            TimeClass = "2pm-4pm"
        ElseIf Slot = 4 Then
            TimeClass = "4pm-6pm"
        Else
            TimeClass = "8pm-10pm"
        End If
        lblSubjectName.Text = SubjectName
        lblPrice.Text = Format(Price, "Currency")
        lblTimeSlot.Text = DateClass & " " & TimeClass
        con.Close()
    End Sub
    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        If txtCardNo.Text = "" Or txtCVV.Text = "" Or txtExpDate.Text = "" Then
            MsgBox("Please fill in all the payment details!", MsgBoxStyle.Critical, "Payment")
        Else
            If rbtMaster.Checked = False And rbtVISA.Checked = False Then
                MsgBox("Please choose your payment method!", MsgBoxStyle.Critical, "Payment")
            Else
                lblPayment.Text = "Receipt"
                btnPayment.Visible = False
                lblCardNo.Visible = False
                lblCVV.Visible = False
                lblExpDate.Visible = False
                txtCardNo.Visible = False
                txtCVV.Visible = False
                txtExpDate.Visible = False
                'Update payment status= True
                con.Open()
                sql = "UPDATE Registration Set Payment=True WHERE RegistrationID=" & RegistrationID
                cmd = New OleDbCommand(sql, con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Payment Successful!", MessageBoxIcon.Information, "Payment")
                Dim outputPath As String = "C:\Users\Lee Pei Qi\Downloads\Payment.pdf" ' Specify the output file path here
                PrintFormAsPdf(Me, outputPath)
                'Open StudentClass Form
                SideButton.OpenChildFormRefresh(StudentClass)
            End If
        End If
    End Sub
    Private Sub PrintFormAsPdf(ByVal form As Form, ByVal outputPath As String)
        Using printDoc As New PrintDocument()
            printDoc.PrinterSettings.PrinterName = GetDefaultPrinterName()
            printDoc.PrinterSettings.PrintToFile = True
            printDoc.PrinterSettings.PrintFileName = outputPath
            AddHandler printDoc.PrintPage, Sub(sender, e)
                                               Dim formWidth As Integer = form.Width
                                               Dim formHeight As Integer = form.Height
                                               Dim marginBounds As Rectangle = e.MarginBounds

                                               ' Calculate the center position
                                               Dim marginLeft As Integer = marginBounds.Left + (marginBounds.Width - formWidth) \ 2
                                               Dim marginTop As Integer = marginBounds.Top

                                               Dim formImage As New Bitmap(form.Width, form.Height)
                                               form.DrawToBitmap(formImage, New Rectangle(0, 0, form.Width, form.Height))

                                               e.Graphics.DrawImage(formImage, marginLeft, marginTop)
                                               e.HasMorePages = False
                                               'Dim formImage As New Bitmap(form.Width, form.Height)
                                               'form.DrawToBitmap(formImage, New Rectangle(0, 0, form.Width, form.Height))
                                               'e.Graphics.DrawImage(formImage, 0, 0)
                                               'e.HasMorePages = False
                                           End Sub
            AddHandler printDoc.EndPrint, Sub(sender, e)
                                              MessageBox.Show("Form printed as PDF.")
                                          End Sub
            printDoc.Print()
        End Using
    End Sub
    Function GetDefaultPrinterName() As String
        Dim printDocument As New PrintDocument()
        Return printDocument.PrinterSettings.PrinterName
    End Function
    ' Check if the pressed key is a digit (0-9) or a control key (e.g., Backspace)
    ' Ignore the input (don't allow the character to be entered)
    Private Sub txtExpDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExpDate.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtCardNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCardNo.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtCVV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCVV.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class