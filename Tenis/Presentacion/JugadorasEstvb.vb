Public Class JugadorasEstvb
    Private Sub ListaEstJugadoras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaEstJugadoras.SelectedIndexChanged
        Dim JugadoraAux As Jugadora
        Dim Datos As Collection

        If ListaEstJugadoras.SelectedItem IsNot Nothing Then

            ListaEstJugadorasEdiciones.Items.Clear()
            ListaEstAnio.Items.Clear()
            JugadoraAux = New Jugadora(CInt(Split(ListaEstJugadoras.SelectedItem.ToString(), " ")(0)))
            Try
                JugadoraAux.LeerJugadora()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Datos = JugadoraAux.leerPartidosJugadora2()
            ImprimirPartidos(Datos, JugadoraAux, Me.ListaEstJugadorasEdiciones)

        End If

    End Sub

    Private Sub Anio_Click(sender As Object, e As EventArgs) Handles Anio.Click
        Dim Datos As Collection
        Dim JugadoraAux As Jugadora
        Dim anio As Integer
        If ListaEstJugadoras.SelectedItem IsNot Nothing And TextAnio.Text <> String.Empty Then

            ListaEstAnio.Items.Clear()
            JugadoraAux = New Jugadora(CInt(Split(ListaEstJugadoras.SelectedItem.ToString(), " ")(0)))
            Try
                JugadoraAux.LeerJugadora()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Try
                anio = CInt(TextAnio.Text)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            Datos = JugadoraAux.leerPartidosJugadoraPorAño(anio)
            ImprimirPartidos(Datos, JugadoraAux, Me.ListaEstAnio)

        End If
    End Sub

    Private Sub Jugadoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ActualizaListaJugadoras()

    End Sub
    Private Sub ActualizaListaJugadoras()
        Dim jugadoraAux = New Jugadora()

        ListaEstJugadoras.Items.Clear()
        Try
            jugadoraAux.LeerTodasJugadoras()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each jugadoraAux In jugadoraAux.JugadoraDAO.Jugadoras
            ListaEstJugadoras.Items.Add(jugadoraAux.idJugadora & " " & jugadoraAux.NombreJugadora)
        Next

    End Sub

    Private Sub ImprimirPartidos(ByVal Datos As Collection, ByVal JugadoraAux As Jugadora, ByVal listbox As ListBox)
        Dim aux As Collection
        Dim partidoAux = New Partido()

        Dim hayPartido As Boolean = False
        Dim cadena As String
        For Each aux In Datos
            partidoAux.idPartido = CInt(aux(1))
            partidoAux.LeerJuegosPartido()

            If partidoAux.Ronda().Equals("c") Then
                listbox.Items.Add("Torneo :" & CStr(partidoAux.Torneo.idTorneo) & ". Edicion: " & partidoAux.Edicion.Anualidad)
            End If
            cadena = "    " & partidoAux.TraduceNombreRondas() & ": " & partidoAux.Ganadora.NombreJugadora & " vs " & partidoAux.Perdedora.NombreJugadora & ":" & partidoAux.GSet1 & "-" & partidoAux.PSet1 & " | " & partidoAux.GSet2 & "-" & partidoAux.PSet2
            If (partidoAux.GSet3 <> 0 And partidoAux.PSet3 <> 0) Then
                cadena = cadena & " | " & partidoAux.GSet3 & "-" & partidoAux.PSet3
            End If
            listbox.Items.Add(cadena)
                cadena = ""

        Next



    End Sub
End Class