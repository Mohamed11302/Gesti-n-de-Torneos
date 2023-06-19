Public Class TorneosEst
    Private Sub TorneosEst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim torneoAux = New Torneo()

        ListaEstTorneos2.Items.Clear()
        Try
            torneoAux.LeerTodosTorneo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each torneoAux In torneoAux.TorneoDAO.Torneos
            ListaEstTorneos2.Items.Add(torneoAux.idTorneo & " " & torneoAux.NombreTorneo)

        Next

    End Sub
    Private Sub seleccion_Edicion_ListaEstadistica(sender As Object, e As EventArgs)


        Dim torneoAux As Torneo
        Dim anualidad As Integer
        Dim edicionAux As Edicion
        Dim partidoAux = New Partido()

        If Me.ListaEdiciones2.SelectedItem IsNot Nothing Then

            torneoAux = New Torneo(CInt(Split(ListaEstTorneos2.SelectedItem.ToString(), " ")(0)))
            anualidad = CInt(Me.ListaEdiciones2.SelectedItem.ToString.Substring(9))

            Try
                torneoAux.LeerTorneo()
                edicionAux = New Edicion(anualidad, torneoAux)
                edicionAux.LeerEdicion()
                partidoAux.Edicion = edicionAux
                partidoAux.LeerPartidosEdicion()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Limpia_Imagen_Torneo()
            If partidoAux.EdicionDAO.Partidos.Count = 7 Then
                Imprime_Rondas_Edicion(partidoAux.EdicionDAO.Partidos)
            End If

        End If
    End Sub


    Private Sub ListaEdiciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaEdiciones2.SelectedIndexChanged

        Dim torneoAux As Torneo
        Dim anualidad As Integer
        Dim edicionAux As Edicion
        Dim partidoAux = New Partido()

        If Me.ListaEdiciones2.SelectedItem IsNot Nothing Then
            torneoAux = New Torneo(CInt(Split(ListaEstTorneos2.SelectedItem.ToString(), " ")(0)))
            anualidad = CInt(Me.ListaEdiciones2.SelectedItem.ToString.Substring(9))

            Try
                torneoAux.LeerTorneo()
                edicionAux = New Edicion(anualidad, torneoAux)
                edicionAux.LeerEdicion()
                partidoAux.Edicion = edicionAux
                partidoAux.LeerPartidosEdicion()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Limpia_Imagen_Torneo()
            If partidoAux.EdicionDAO.Partidos.Count = 7 Then
                Imprime_Rondas_Edicion(partidoAux.EdicionDAO.Partidos)
            End If

        End If
    End Sub
    Public Sub Limpia_Imagen_Torneo()
        For i = 1 To 7
            eligeLabelTorneo(i).Text = ""
            eligeLabelTorneo(i).Visible = True
        Next
    End Sub

    Public Sub Imprime_Rondas_Edicion(ByVal PartidosEdicion As Collection)

        For i = 1 To PartidosEdicion.Count
            Imprime_Juegos_Partido(CType(PartidosEdicion(i), Partido), eligeLabelTorneo(i))
        Next

    End Sub
    Public Function eligeLabelTorneo(ByVal contador As Integer) As Label

        Dim LabelElegido = New Label()
        Select Case contador
            Case 1
                LabelElegido = Label17
            Case 2
                LabelElegido = Label18
            Case 3
                LabelElegido = Label19
            Case 4
                LabelElegido = Label20
            Case 5
                LabelElegido = Label21
            Case 6
                LabelElegido = Label22
            Case 7
                LabelElegido = Label23
        End Select
        Return LabelElegido
    End Function
    Private Sub Imprime_Juegos_Partido(ByVal PartidoSeleccionado As Partido, LabelPartido As Label)

        LabelPartido.Text = PartidoSeleccionado.Ganadora.NombreJugadora & "-" & PartidoSeleccionado.Perdedora.NombreJugadora & vbCrLf & " Set 1: " & PartidoSeleccionado.GSet1 & "-" & PartidoSeleccionado.PSet1 & vbCrLf & " Set 2: " & PartidoSeleccionado.GSet2 & "-" & PartidoSeleccionado.PSet2

        If (Not PartidoSeleccionado.GSet3.Equals(PartidoSeleccionado.PSet3)) Then
            LabelPartido.Text = LabelPartido.Text & vbCrLf & " Set 3: " & PartidoSeleccionado.GSet3 & "-" & PartidoSeleccionado.PSet3
        End If


    End Sub


    Private Sub ListaEstTorneos2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaEstTorneos2.SelectedIndexChanged
        Dim torneoAux As Torneo
        Dim edicionAux = New Edicion()

        If ListaEstTorneos2.SelectedItem IsNot Nothing Then

            ListaGanadoras2.Items.Clear()
            ListaEdiciones2.Items.Clear()
            Limpia_Imagen_Torneo()

            torneoAux = New Torneo(CInt(Split(ListaEstTorneos2.SelectedItem.ToString(), " ")(0)))
            edicionAux.Torneo = torneoAux
            Try
                edicionAux.LeerEdicionesTorneo()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            For Each edicionAux In edicionAux.EdicionDAO.Ediciones
                ListaGanadoras2.Items.Add("Edicion: " & edicionAux.Anualidad & ", ganadora: " & edicionAux.Ganadora.NombreJugadora)
                ListaEdiciones2.Items.Add("Edicion: " & edicionAux.Anualidad)
            Next

        End If
    End Sub


End Class