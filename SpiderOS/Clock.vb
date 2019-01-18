Public Class Clock
    Private Sub Clock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeString.ToString("hh:mm")


    End Sub
End Class