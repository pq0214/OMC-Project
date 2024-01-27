'StartForm.vb
Public Class StartForm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblReportProgress.Text = PBLoading1.Value & "%"
        PBLoading1.Value += 1
        If PBLoading1.Value > 10 Then
            LblStatustext.Text = "Loading Admin's Data"
        End If
        If PBLoading1.Value > 35 Then
            LblStatustext.Text = "Loading Student's Data"
        End If
        If PBLoading1.Value > 65 Then
            LblStatustext.Text = "Loading Tutor's Data"
        End If
        If PBLoading1.Value > 80 Then
            LblStatustext.Text = "Initializing Data"
        End If
        If PBLoading1.Value = 100 Then
            LblStatustext.Text = "Launching Application.........."
            Me.Show()
            Me.Hide()
            Login.Show()
            Timer1.Dispose()
        End If
    End Sub
End Class