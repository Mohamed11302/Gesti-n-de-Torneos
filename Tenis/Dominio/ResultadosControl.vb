Public Class ResultadosControl


    Public Sub calculaResultadoPartido(ByRef Partido As Partido, ByVal Jugadora1 As Jugadora, ByVal Jugadora2 As Jugadora)


        Dim j1Set1 As Integer
        Dim j1Set2 As Integer
        Dim j1Set3 As Integer
        Dim j2Set1 As Integer
        Dim j2Set2 As Integer
        Dim j2Set3 As Integer

        Dim aleatorio As Integer
        Dim victoriasJugadora1 As Integer
        Dim victoriasJugadora2 As Integer
        victoriasJugadora1 = 0
        victoriasJugadora2 = 0

        For i = 1 To 3
            aleatorio = CInt(Rnd() + 1)

            Select Case (i)
                Case 1
                    If aleatorio = 1 Then
                        victoriasJugadora1 = victoriasJugadora1 + 1
                        j1Set1 = 6
                        j2Set1 = CInt(Rnd() * (4 - 1))
                    Else
                        victoriasJugadora2 = victoriasJugadora2 + 1
                        j2Set1 = 6
                        j1Set1 = CInt(Rnd() * (4 - 1))
                    End If

                Case 2
                    If aleatorio = 1 Then
                        victoriasJugadora1 = victoriasJugadora1 + 1
                        j1Set2 = 6
                        j2Set2 = CInt(Rnd() * (4 - 1))
                    Else
                        victoriasJugadora2 = victoriasJugadora2 + 1
                        j2Set2 = 6
                        j1Set2 = CInt(Rnd() * (4 - 1))
                    End If
                Case 3
                    If aleatorio = 1 Then
                        victoriasJugadora1 = victoriasJugadora1 + 1
                        j1Set3 = 6
                        j2Set3 = CInt(Rnd() * (4 - 1))
                    Else
                        victoriasJugadora2 = victoriasJugadora2 + 1
                        j2Set3 = 6
                        j1Set3 = CInt(Rnd() * (4 - 1))
                    End If
            End Select

            If victoriasJugadora1 = 2 Or victoriasJugadora2 = 2 Then
                Exit For
            End If

        Next

        If victoriasJugadora1 = 2 Then
            Partido.Ganadora = Jugadora1
            Partido.GSet1 = j1Set1
            Partido.GSet2 = j1Set2
            Partido.GSet3 = j1Set3
            Partido.Perdedora = Jugadora2
            Partido.PSet1 = j2Set1
            Partido.PSet2 = j2Set2
            Partido.PSet3 = j2Set3
        Else
            Partido.Ganadora = Jugadora2
            Partido.GSet1 = j2Set1
            Partido.GSet2 = j2Set2
            Partido.GSet3 = j2Set3
            Partido.Perdedora = Jugadora1
            Partido.PSet1 = j1Set1
            Partido.PSet2 = j1Set2
            Partido.PSet3 = j1Set3
        End If

        Partido.EdicionDAO.InsertarPartido(Partido)



    End Sub

    Public Function creaCuartosDeFinal(ByRef Edicion As Edicion, ByRef Participantes As Collection) As Collection

        Dim CuartosDeFinal As Collection
        CuartosDeFinal = New Collection

        Dim PartidoAux As Partido
        Dim posicion1 As Integer
        Dim posicion2 As Integer
        Dim id As Integer
        PartidoAux = New Partido()
        id = PartidoAux.ObtenerIDNoUsado()
        For i = 0 To 3

            Select Case (i)
                Case 0
                    posicion1 = 1
                    posicion2 = 8
                Case 1
                    posicion1 = 4
                    posicion2 = 5
                Case 2
                    posicion1 = 2
                    posicion2 = 7
                Case 3
                    posicion1 = 3
                    posicion2 = 6

            End Select


            PartidoAux = New Partido(id + i)
            PartidoAux.Edicion = Edicion
            PartidoAux.Ronda = "c"
            Me.calculaResultadoPartido(PartidoAux, CType(Participantes(posicion1), Jugadora), CType(Participantes(posicion2), Jugadora))
            CuartosDeFinal.Add(PartidoAux)
        Next

        Return CuartosDeFinal
    End Function

    Public Function creaSemifinales(ByRef Edicion As Edicion, ByRef CuartosDeFinal As Collection) As Collection

        Dim Semifinales As Collection
        Semifinales = New Collection

        Dim PartidoAux As Partido
        Dim posicion1 As Integer
        Dim posicion2 As Integer
        Dim id As Integer
        PartidoAux = New Partido()
        id = PartidoAux.ObtenerIDNoUsado()

        For i = 0 To 1

            Select Case (i)
                Case 0
                    posicion1 = 1
                    posicion2 = 2
                Case 1
                    posicion1 = 3
                    posicion2 = 4
            End Select

            PartidoAux = New Partido(id + i)
            PartidoAux.Edicion = Edicion
            PartidoAux.Ronda = "s"
            Me.calculaResultadoPartido(PartidoAux, CType(CType(CuartosDeFinal(posicion1), Partido).Ganadora, Jugadora), CType(CType(CuartosDeFinal(posicion2), Partido).Ganadora, Jugadora))
            Semifinales.Add(PartidoAux)

        Next

        Return Semifinales
    End Function

    Public Function creaFinal(ByRef Edicion As Edicion, ByRef Semifinales As Collection) As Collection

        Dim Final As Collection
        Final = New Collection

        Dim PartidoAux As Partido
        Dim id As Integer
        PartidoAux = New Partido()
        id = PartidoAux.ObtenerIDNoUsado()

        PartidoAux = New Partido(id)
        PartidoAux.Edicion = Edicion
        PartidoAux.Ronda = "f"
        Me.calculaResultadoPartido(PartidoAux, CType(CType(Semifinales(1), Partido).Ganadora, Jugadora), CType(CType(Semifinales(2), Partido).Ganadora, Jugadora))

        Edicion.Ganadora = PartidoAux.Ganadora
        Edicion.EdicionDAO.ActualizarEdicion(Edicion)
        Final.Add(PartidoAux)

        Return Final
    End Function




End Class
