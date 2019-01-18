Public Class Clock

    Private Sub Clock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateTime.Now.ToString("HH:mm")
        Dim SecondString As String = DateTime.Now.ToString("ss")
        Dim Second As Int64 = Convert.ToInt64(SecondString)

    End Sub

    Public ReadOnly Property Second As Integer
End Class