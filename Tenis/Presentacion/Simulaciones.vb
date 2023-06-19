Public Class Simulaciones
    Private Sub Simulaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizaListaTorneos()
    End Sub
    Private Function imprime_Participantes() As Collection

        Dim jugadoraAux = New Jugadora()
        Dim Participantes = jugadoraAux.elegir8Jugadoras()
        Participantes = jugadoraAux.ordenarJugadorasPorPuntos(Participantes)


        For i = 1 To Participantes.Count
            ListJugRandoms.Items.Add(i & "º " & CType(Participantes(i), Jugadora).NombreJugadora)
        Next
        Return Participantes
    End Function

    Private Function imprime_Resultados_Torneo(ByVal Edicion As Edicion) As Collection

        Dim jugadoraAux = New Jugadora()
        Dim PartidoAux = New Partido()
        Dim PartidosEdicion = PartidoAux.ObtenerPartidosEdicion(Edicion)
        Dim obj1 As Collection
        Dim PuestosJugadoras = New Collection


        For Each obj1 In PartidosEdicion
            PartidoAux.idPartido = CInt(obj1(1))
            Try
                PartidoAux.LeerJuegosPartido()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

            ListEdicTorneo.Items.Add(PartidoAux.TraduceNombreRondas() & " (Partido número " & PartidoAux.idPartido & ")")
            ListEdicTorneo.Items.Add("  Jugadora: " & PartidoAux.Ganadora.NombreJugadora & "  -->  " & PartidoAux.GSet1 & " | " & PartidoAux.GSet2 & " | " & PartidoAux.GSet3)
            ListEdicTorneo.Items.Add("  Jugadora: " & PartidoAux.Perdedora.NombreJugadora & "  -->  " & PartidoAux.PSet1 & " | " & PartidoAux.PSet2 & " | " & PartidoAux.PSet3)
            PuestosJugadoras.Add(PartidoAux.Perdedora)

        Next
            PuestosJugadoras.Add(Edicion.Ganadora)
        Return PuestosJugadoras

    End Function

    Private Sub imprime_Clasificacion_Torneo(ByVal PuestosJugadoras As Collection)
        Dim jugadoraAux = New Jugadora()


        For i = 0 To PuestosJugadoras.Count - 1
            ListResumenTor.Items.Add((i + 1) & "º --> " & CType(PuestosJugadoras(PuestosJugadoras.Count - i), Jugadora).NombreJugadora)
        Next
        jugadoraAux.incrementaPuntosJugadoras(PuestosJugadoras)
    End Sub

    Private Sub click_Simular_Edicion(sender As Object, e As EventArgs) Handles Button1.Click

        Dim jugadoraAux = New Jugadora()
        Dim TorneoPrueba As Torneo
        Dim EdicionPrueba = New Edicion()
        Dim CuartosDeFinal = New Collection
        Dim Semifinales = New Collection
        Dim Final = New Collection
        Dim ResultadosControl = New ResultadosControl
        Dim DatosEdiciones, DatosJugadoras, aux As Collection
        Dim numEdiciones, idJugadoraTemporal As Integer

        If TextBox1.Text <> String.Empty And ListTorneosSimulaciones.SelectedItem IsNot Nothing Then

            ListJugRandoms.Items.Clear()
            ListResumenTor.Items.Clear()
            ListEdicTorneo.Items.Clear()

            Try
                TorneoPrueba = New Torneo(CInt(Split(ListTorneosSimulaciones.SelectedItem.ToString(), " ")(0)))
                DatosEdiciones = EdicionPrueba.devuelveNumEdionesTorneo_PorAño(TorneoPrueba, CInt(TextBox1.Text))
                DatosJugadoras = jugadoraAux.leerIdPrimeraJugadora()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            For Each aux In DatosEdiciones
                numEdiciones = CInt(aux(1).ToString)
            Next
            For Each aux In DatosJugadoras
                idJugadoraTemporal = CInt(aux(1).ToString)
            Next


            If numEdiciones = 0 Then
                EdicionPrueba.Torneo = TorneoPrueba
                EdicionPrueba.Anualidad = CInt(TextBox1.Text)
                EdicionPrueba.LeerEdicion()
                EdicionPrueba.Ganadora = New Jugadora(idJugadoraTemporal)
                EdicionPrueba.InsertarEdicion()
                CuartosDeFinal = ResultadosControl.creaCuartosDeFinal(EdicionPrueba, imprime_Participantes())
                Semifinales = ResultadosControl.creaSemifinales(EdicionPrueba, CuartosDeFinal)
                Final = ResultadosControl.creaFinal(EdicionPrueba, Semifinales)
                imprime_Clasificacion_Torneo(imprime_Resultados_Torneo(EdicionPrueba))
                ListEdicionesSimulaciones.Items.Add("Edicion: " & EdicionPrueba.Anualidad & ", ganadora: " & EdicionPrueba.Ganadora.NombreJugadora)
            Else
                MessageBox.Show("La edición de ese torneo ya fue disputada", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If

    End Sub
    Private Sub ActualizaListaTorneos()
        Dim torneoAux = New Torneo()
        ListTorneosSimulaciones.Items.Clear()

        Try
            torneoAux.LeerTodosTorneo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each torneoAux In torneoAux.TorneoDAO.Torneos
            ListTorneosSimulaciones.Items.Add(torneoAux.idTorneo & " " & torneoAux.NombreTorneo & " " & torneoAux.CiudadTorneo & " " & torneoAux.PaisTorneo.idPais)
        Next

    End Sub

    Private Sub seleccion_Torneo_Simulaciones(sender As Object, e As EventArgs) Handles ListTorneosSimulaciones.SelectedIndexChanged
        Dim torneoAux As Torneo
        Dim edicionAux = New Edicion()


        If ListTorneosSimulaciones.SelectedItem IsNot Nothing Then

            ListJugRandoms.Items.Clear()
            ListResumenTor.Items.Clear()
            ListEdicTorneo.Items.Clear()
            ListEdicionesSimulaciones.Items.Clear()

            torneoAux = New Torneo(CInt(Split(ListTorneosSimulaciones.SelectedItem.ToString(), " ")(0)))
            edicionAux.Torneo = torneoAux
            Try
                edicionAux.LeerEdicionesTorneo()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            For Each edicionAux In edicionAux.EdicionDAO.Ediciones
                ListEdicionesSimulaciones.Items.Add("Edicion: " & edicionAux.Anualidad & ", ganadora: " & edicionAux.Ganadora.NombreJugadora)
            Next

        End If
    End Sub

End Class