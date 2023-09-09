Public Class loding
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MyProgress.Increment(1)
        Dim percentage As String
        percentage = Convert.ToString(MyProgress.Value)
        PerLb.Text = percentage + "%"
        If MyProgress.Value = 100 Then
            Me.Hide()
            Dim obj = New home
            obj.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub loding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


End Class