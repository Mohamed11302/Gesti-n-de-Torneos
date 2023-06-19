Public Class TorneoDAO
    Public ReadOnly Property Torneos As Collection
    Public Property PaisDAO As PaisDAO

    Public Sub New()
        Me.Torneos = New Collection
        Me.PaisDAO = New PaisDAO
    End Sub

    Public Sub LeerTodas()
        Dim t As Torneo
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM torneos ORDER BY idTorneo")
        For Each aux In col
            t = New Torneo(CInt(aux(1)))
            t.NombreTorneo = aux(2).ToString
            t.CiudadTorneo = aux(3).ToString
            t.PaisTorneo = New Pais(aux(4).ToString)
            Me.PaisDAO.Leer(t.PaisTorneo)
            Me.Torneos.Add(t)
        Next
    End Sub

    Public Sub Leer(ByRef t As Torneo)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM torneos WHERE idTorneo='" & t.idTorneo & "';")
        For Each aux In col
            t.NombreTorneo = aux(2).ToString
            t.CiudadTorneo = aux(3).ToString
            t.PaisTorneo = New Pais(aux(4).ToString)
            Me.PaisDAO.Leer(t.PaisTorneo)
        Next
    End Sub

    Public Function Insertar(ByVal t As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO torneos (NombreTorneo, CiudadTorneo, PaisTorneo) VALUES ('" & t.NombreTorneo & "', '" & t.CiudadTorneo & "', '" & t.PaisTorneo.idPais & "');")
    End Function

    Public Function Actualizar(ByVal t As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE torneos SET NombreTorneo='" & t.NombreTorneo & "', CiudadTorneo='" & t.CiudadTorneo & "', PaisTorneo='" & t.PaisTorneo.idPais & "' WHERE idTorneo='" & t.idTorneo & "';")
    End Function

    Public Function Borrar(ByVal t As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM torneos WHERE idTorneo='" & t.idTorneo & "';")
    End Function
End Class
