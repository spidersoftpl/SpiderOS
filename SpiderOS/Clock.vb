Public Class Clock
    Private Sub Clock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = TimeOfDay()
    End Sub
End Class