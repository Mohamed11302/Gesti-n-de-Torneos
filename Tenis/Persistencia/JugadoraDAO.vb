Public Class JugadoraDAO

    Public ReadOnly Property Jugadoras As Collection
    Public Property PaisDAO As PaisDAO

    Public Sub New()
        Me.Jugadoras = New Collection
        Me.PaisDAO = New PaisDAO
    End Sub

    Public Sub LeerTodas()
        Dim p As Jugadora
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM jugadoras ORDER BY PuntosJugadora DESC;")
        For Each aux In col
            p = New Jugadora(CInt(aux(1)))
            p.NombreJugadora = aux(2).ToString
            p.FechaNacimientoJugadora = aux(3).ToString.Substring(6, 4) & "-" & aux(3).ToString.Substring(3, 2) & "-" & aux(3).ToString.Substring(0, 2)
            p.PuntosJugadora = CInt(aux(4))
            p.PaisJugadora = New Pais(aux(5).ToString)
            Me.PaisDAO.Leer(p.PaisJugadora)
            Me.Jugadoras.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Jugadora)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM jugadoras WHERE idJugadora='" & p.idJugadora & "';")
        For Each aux In col
            p.NombreJugadora = aux(2).ToString
            p.FechaNacimientoJugadora = aux(3).ToString.Substring(6, 4) & "-" & aux(3).ToString.Substring(3, 2) & "-" & aux(3).ToString.Substring(0, 2)
            p.PuntosJugadora = CInt(aux(4))
            p.PaisJugadora = New Pais(aux(5).ToString)
            Me.PaisDAO.Leer(p.PaisJugadora)
        Next
    End Sub

    Public Function leerIdPrimeraJugadora() As Collection
        Return AgenteBD.ObtenerAgente.Leer("SELECT idJugadora FROM jugadoras WHERE PuntosJugadora IN (SELECT MAX(PuntosJugadora) FROM jugadoras);")
    End Function

    Public Function leerPartidosJugadora2(ByVal Jugadora As Jugadora) As Collection
        Return AgenteBD.ObtenerAgente().Leer("Select idPartido from tenis.partidos where idPartido IN (Select Partido from tenis.juegos where jugadora = '" & Jugadora.idJugadora & "')  Order by Torneo, Anualidad ;")
    End Function
    Public Function leerPartidoJugadora(ByVal idPartido As Integer) As Collection
        Return AgenteBD.ObtenerAgente().Leer("Select j.nombreJugadora, g.set1, g.set2, g.set3 From tenis.juegos g, tenis.jugadoras j Where g.partido ='" & idPartido & "' and j.idJugadora = g.Jugadora;")
    End Function

    Public Function leerPartidosJugadoraPorAño(ByVal Jugadora As Jugadora, ByVal año As Integer) As Collection
        Return AgenteBD.ObtenerAgente().Leer("Select idPartido from tenis.partidos where idPartido IN (Select Partido from tenis.juegos where jugadora = '" & Jugadora.idJugadora & "') and Anualidad = '" & año & "' Order by Torneo ;")
    End Function

    Public Function leerFinalesJugadora(ByVal Jugadora As Jugadora) As Collection
        Return AgenteBD.ObtenerAgente().Leer("SELECT COUNT(*) FROM juegos WHERE Jugadora='" & Jugadora.idJugadora & "' AND Partido IN (SELECT idPartido FROM partidos WHERE Ronda='f');")
    End Function

    Public Function leerPartidosGanadosJugadora(ByVal Jugadora As Jugadora) As Collection
        Return AgenteBD.ObtenerAgente().Leer("SELECT COUNT(*) FROM partidos WHERE ganadora='" & Jugadora.idJugadora & "';")
    End Function

    Public Function Insertar(ByVal j As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO jugadoras (NombreJugadora, FechaNacimientoJugadora, PuntosJugadora, PaisJugadora) VALUES ('" & j.NombreJugadora & "', '" & j.FechaNacimientoJugadora & "', '" & 0 & "', '" & j.PaisJugadora.idPais & "');")

    End Function

    Public Function Actualizar(ByVal j As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE jugadoras SET NombreJugadora='" & j.NombreJugadora & "', FechaNacimientoJugadora='" & j.FechaNacimientoJugadora & "', PuntosJugadora='" & j.PuntosJugadora & "', PaisJugadora='" & j.PaisJugadora.idPais & "' WHERE idJugadora='" & j.idJugadora & "';")
    End Function

    Public Function Borrar(ByVal j As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM jugadoras WHERE idJugadora='" & j.idJugadora & "';")
    End Function

End Class
