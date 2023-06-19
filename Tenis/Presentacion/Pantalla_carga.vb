Public Class Pantalla_carga
    Private Sub Pantalla_carga_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If (ProgressBar1.Value = ProgressBar1.Maximum) Then
            Timer1.Stop()
            Me.Hide()
            MenuPrincipal.Show()
        Else
            ProgressBar1.PerformStep()
            lblPercentage.Text = ProgressBar1.Value & ("%")
        End If
    End Sub
End Class