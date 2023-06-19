Public Class Ranking
    Private Sub Rankingvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListRanking.Items.Clear()
        ListRanking.Items.Add("----------RANKING DE LAS JUGADORAS----------")
        Dim jugadoraAux = New Jugadora()
        Try
            jugadoraAux.LeerTodasJugadoras()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each jugadoraAux In jugadoraAux.JugadoraDAO.Jugadoras
            Dim finales = jugadoraAux.leerFinalesJugadora
            Dim partidos = jugadoraAux.leerPartidosGanadosJugadora
            ListRanking.Items.Add(jugadoraAux.NombreJugadora & " con " & jugadoraAux.PuntosJugadora & " puntos, " & partidos & " partidos ganados y " & finales & " finales")

        Next
    End Sub

    Private Sub ListRanking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListRanking.SelectedIndexChanged

    End Sub
End Class