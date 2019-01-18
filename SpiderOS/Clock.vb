Public Class Clock
    Private Sub Clock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("HH:mm")
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 60 Then
            ProgressBar1.Value = 0

        End If
    End Sub
End Class