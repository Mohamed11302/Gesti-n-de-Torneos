Public Class EdicionDAO
    Public ReadOnly Property Ediciones As Collection
    Public ReadOnly Property Juegos As Collection
    Public ReadOnly Property Partidos As Collection
    Public Property TorneoDAO As TorneoDAO
    Public Property JugadoraDAO As JugadoraDAO


    Public Sub New()
        Me.Ediciones = New Collection
        Me.Juegos = New Collection
        Me.Partidos = New Collection
        Me.TorneoDAO = New TorneoDAO
        Me.JugadoraDAO = New JugadoraDAO
    End Sub

    Public Sub LeerTodasEdiciones()
        Dim e As Edicion
        Dim t As Torneo
        Dim j As Jugadora
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM ediciones ORDER BY Anualidad & Torneo")
        For Each aux In col

            t = New Torneo(CInt(aux(2)))
            TorneoDAO.Leer(t)

            j = New Jugadora(CInt(aux(3)))
            JugadoraDAO.Leer(j)

            e = New Edicion(CInt(aux(1)), t)
            e.Ganadora = j

            Me.Ediciones.Add(e)
        Next
    End Sub

    Public Sub LeerEdicion(ByRef e As Edicion)
        Dim t As Torneo
        Dim j As Jugadora
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM ediciones WHERE Anualidad='" & e.Anualidad & "' & Torneo='" & e.Torneo.idTorneo & "';")
        For Each aux In col
            t = New Torneo(CInt(aux(2)))
            TorneoDAO.Leer(t)

            j = New Jugadora(CInt(aux(3)))
            JugadoraDAO.Leer(j)

            e = New Edicion(CInt(aux(1)), t)
            e.Ganadora = j
        Next
    End Sub
    Public Sub LeerEdicionesTorneo(ByRef e As Edicion)
        Dim t As Torneo
        Dim j As Jugadora
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM ediciones WHERE Torneo='" & e.Torneo.idTorneo & "';")

        For Each aux In col

            t = New Torneo(CInt(aux(2)))
            j = New Jugadora(CInt(aux(3)))
            e = New Edicion(CInt(aux(1)), t)
            TorneoDAO.Leer(t)
            JugadoraDAO.Leer(j)
            e.Ganadora = j
            Me.Ediciones.Add(e)
        Next
    End Sub

    Public Function devuelveNumEdionesTorneo_PorAño(ByVal Torneo As Torneo, ByVal Año As Integer) As Collection
        Return AgenteBD.ObtenerAgente.Leer("SELECT COUNT(*) FROM ediciones WHERE Torneo='" & Torneo.idTorneo & "' AND Anualidad='" & Año & "';")
    End Function

    Public Function InsertarEdicion(ByVal e As Edicion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO ediciones VALUES ('" & e.Anualidad & "', '" & e.Torneo.idTorneo & "', '" & e.Ganadora.idJugadora & "');")
    End Function

    Public Function ActualizarEdicion(ByVal e As Edicion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE ediciones SET Ganadora='" & e.Ganadora.idJugadora & "' WHERE Anualidad='" & e.Anualidad & "' AND Torneo='" & e.Torneo.idTorneo & "';")
    End Function

    Public Function BorrarEdicion(ByVal e As Edicion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM ediciones WHERE Anualidad='" & e.Anualidad & "' AND Torneo='" & e.Torneo.idTorneo & "';")
    End Function

    Public Sub LeerJuegosPartido(ByRef partido As Partido)
        Dim t As Torneo
        Dim e As Edicion
        Dim gs1, gs2, gs3, ps1, ps2, ps3 As Integer
        Dim ganadora, perdedora As Jugadora
        Dim col, col2, aux, aux2 As Collection

        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM partidos WHERE idPartido='" & partido.idPartido & "';")

        For Each aux In col
            ganadora = New Jugadora(CInt(aux(4)))
            JugadoraDAO.Leer(ganadora)

            col2 = AgenteBD.ObtenerAgente().Leer("SELECT jugadora, set1, set2, set3 FROM juegos where Partido  = '" & CInt(aux(1)) & "';")
            For Each aux2 In col2
                If aux2(1).Equals(aux(4)) Then
                    gs1 = CInt(aux2(2))
                    gs2 = CInt(aux2(3))
                    gs3 = CInt(aux2(4))
                Else
                    perdedora = New Jugadora(CInt(aux2(1)))
                    JugadoraDAO.Leer(perdedora)
                    ps1 = CInt(aux2(2))
                    ps2 = CInt(aux2(3))
                    ps3 = CInt(aux2(4))
                End If
            Next
            partido.Ronda = CStr(aux(5))
            t = New Torneo(CInt(aux(3)))
            t.LeerTorneo()

            e = New Edicion(CInt(aux(2)), t)
            e.LeerEdicion()


            partido.Edicion = e
            partido.Torneo = t
            partido.Ganadora = ganadora
            partido.GSet1 = gs1
            partido.GSet2 = gs2
            partido.GSet3 = gs3
            partido.Perdedora = perdedora
            partido.PSet1 = ps1
            partido.PSet2 = ps2
            partido.PSet3 = ps3
        Next

    End Sub
    Public Sub LeerTodosPartidos()
        Dim p As Partido
        Dim t As Torneo
        Dim e As Edicion
        Dim gs1, gs2, gs3, ps1, ps2, ps3 As Integer
        Dim ganadora, perdedora As Jugadora
        Dim col, col2, aux, aux2 As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM partidos ORDER BY idPartido")
        For Each aux In col
            ganadora = New Jugadora(CInt(aux(4)))
            JugadoraDAO.Leer(ganadora)

            col2 = AgenteBD.ObtenerAgente().Leer("SELECT jugadora, set1, set2, set3 FROM juegos where Partido  = '" & CInt(aux(1)) & "';")

            For Each aux2 In col2
                If aux2(1).Equals(aux(4)) Then
                    gs1 = CInt(aux2(2))
                    gs2 = CInt(aux2(3))
                    gs3 = CInt(aux2(4))
                Else
                    perdedora = New Jugadora(CInt(aux2(1)))
                    JugadoraDAO.Leer(perdedora)
                    ps1 = CInt(aux2(2))
                    ps2 = CInt(aux2(3))
                    ps3 = CInt(aux2(4))
                End If
            Next


            t = New Torneo(CInt(aux(3)))
            TorneoDAO.Leer(t)

            e = New Edicion(CInt(aux(2)), t)
            LeerEdicion(e)

            p = New Partido(CInt(aux(1)))

            p.Edicion = e
            p.Torneo = t
            p.Ganadora = ganadora
            p.GSet1 = gs1
            p.GSet2 = gs2
            p.GSet3 = gs3
            p.Perdedora = perdedora
            p.PSet1 = ps1
            p.PSet2 = ps2
            p.PSet3 = ps3

            p.Ronda = CStr(aux(5))

            Me.Partidos.Add(p)
        Next
    End Sub
    Public Sub LeerPartido(ByRef p As Partido)

        Dim t As Torneo
        Dim e As Edicion
        Dim j As Jugadora
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM partidos WHERE idPartido='" & p.idPartido & "';")
        For Each aux In col

            j = New Jugadora(CInt(aux(4)))
            JugadoraDAO.Leer(j)

            t = New Torneo(CInt(aux(3)))
            TorneoDAO.Leer(t)

            e = New Edicion(CInt(aux(2)), t)
            LeerEdicion(e)

            p.idPartido = CInt(aux(1))
            p.Edicion = e
            p.Ganadora = j
            p.Ronda = aux(5).ToString
        Next
    End Sub
    Public Sub LeerPartidosEdicion(ByRef e As Edicion)
        Dim p As Partido
        Dim t As Torneo
        Dim gs1, gs2, gs3, ps1, ps2, ps3 As Integer
        Dim ganadora, perdedora As Jugadora
        Dim col, col2, aux, aux2 As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM partidos WHERE Torneo='" & e.Torneo.idTorneo & "' AND Anualidad='" & e.Anualidad & "' Order By idPartido;")
        For Each aux In col
            ganadora = New Jugadora(CInt(aux(4)))
            JugadoraDAO.Leer(ganadora)

            col2 = AgenteBD.ObtenerAgente().Leer("SELECT jugadora, set1, set2, set3 FROM juegos where Partido  = '" & CInt(aux(1)) & "';")

            For Each aux2 In col2
                If aux2(1).Equals(aux(4)) Then
                    gs1 = CInt(aux2(2))
                    gs2 = CInt(aux2(3))
                    gs3 = CInt(aux2(4))
                Else
                    perdedora = New Jugadora(CInt(aux2(1)))
                    JugadoraDAO.Leer(perdedora)
                    ps1 = CInt(aux2(2))
                    ps2 = CInt(aux2(3))
                    ps3 = CInt(aux2(4))
                End If
            Next


            t = New Torneo(e.Torneo.idTorneo)
            TorneoDAO.Leer(t)

            p = New Partido(CInt(aux(1)))

            p.Edicion = e
            p.Torneo = t
            p.Ganadora = ganadora
            p.GSet1 = gs1
            p.GSet2 = gs2
            p.GSet3 = gs3
            p.Perdedora = perdedora
            p.PSet1 = ps1
            p.PSet2 = ps2
            p.PSet3 = ps3

            p.Ronda = CStr(aux(5))

            Me.Partidos.Add(p)
        Next
    End Sub

    Public Function ExtraerJuegosPartido(ByVal Partido As Partido) As Collection
        Return AgenteBD.ObtenerAgente.Leer("SELECT * FROM juegos WHERE Partido='" & Partido.idPartido & "';")
    End Function

    Public Function InsertarPartido(ByVal p As Partido) As Integer
        Dim i As Integer
        Dim idPartido As Integer
        Dim aux As Collection
        i = AgenteBD.ObtenerAgente.Modificar("INSERT INTO partidos (Anualidad, Torneo, Ganadora, Ronda) VALUES ('" & p.Edicion.Anualidad & "', '" & p.Edicion.Torneo.idTorneo & "', '" & p.Ganadora.idJugadora & "', '" & p.Ronda & "');")
        For Each aux In AgenteBD.ObtenerAgente().Leer("SELECT Max(idPartido) FROM partidos;")
            idPartido = CInt(aux(1))
        Next

        If (i = 1) Then
            i = AgenteBD.ObtenerAgente.Modificar("INSERT INTO juegos VALUES ('" & p.Ganadora.idJugadora & "', '" & idPartido & "', '" & p.GSet1 & "', '" & p.GSet2 & "', '" & p.GSet3 & "');")
            If (i = 1) Then
                i = AgenteBD.ObtenerAgente.Modificar("INSERT INTO juegos VALUES ('" & p.Perdedora.idJugadora & "', '" & idPartido & "', '" & p.PSet1 & "', '" & p.PSet2 & "', '" & p.PSet3 & "');")
            End If
        End If
        Return i
    End Function

    Public Function ActualizarPartido(ByVal p As Partido) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE partidos SET Anualidad='" & p.Edicion.Anualidad & "', Torneo='" & p.Edicion.Torneo.idTorneo & "', Ganadora='" & p.Ganadora.idJugadora & "', Ronda='" & p.Ronda & "' WHERE IdPartido='" & p.idPartido & "';")
    End Function

    Public Function BorrarPartido(ByVal p As Partido) As Integer
        Dim i As Integer
        i = AgenteBD.ObtenerAgente.Modificar("DELETE FROM juegos WHERE Jugadora='" & p.Ganadora.idJugadora & "' AND Partido='" & p.idPartido & "';")
        If (i = 1) Then
            i = AgenteBD.ObtenerAgente.Modificar("DELETE FROM juegos WHERE Jugadora='" & p.Perdedora.idJugadora & "' AND Partido='" & p.idPartido & "';")
            If (i = 1) Then
                i = AgenteBD.ObtenerAgente.Modificar("DELETE FROM partidos WHERE idPartido='" & p.idPartido & "';")
            End If
        End If
        Return i
    End Function

    Public Function ObtieneIDNoUsado() As Integer

        Dim idsPartidos, aux As Collection
        Dim ultimoIdUsado As Integer
        idsPartidos = AgenteBD.ObtenerAgente().Leer("SELECT idPartido FROM tenis.partidos ORDER BY idPartido;")
        For Each aux In idsPartidos
            ultimoIdUsado = CInt(aux(1))
        Next
        Return ultimoIdUsado + 1
    End Function


    Public Function ExtraerPartidosEdicion(ByVal Edicion As Edicion) As Collection
        Return AgenteBD.ObtenerAgente.Leer("SELECT idPartido FROM partidos WHERE Anualidad='" & Edicion.Anualidad & "' and Torneo='" & Edicion.Torneo.idTorneo & "'Order by idPartido;")
    End Function

End Class
