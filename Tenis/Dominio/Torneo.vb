Public Class Torneo

    Public Property idTorneo As Integer
    Public Property NombreTorneo As String
    Public Property CiudadTorneo As String
    Public Property PaisTorneo As Pais
    Public ReadOnly Property TorneoDAO As TorneoDAO


    Public Sub New()
        Me.TorneoDAO = New TorneoDAO
    End Sub

    Public Sub New(id As Integer)
        Me.TorneoDAO = New TorneoDAO
        Me.idTorneo = id
    End Sub

    Public Sub LeerTodosTorneo()
        Me.TorneoDAO.LeerTodas()
    End Sub

    Public Sub LeerTorneo()
        Me.TorneoDAO.Leer(Me)
    End Sub

    Public Function InsertarTorneo() As Integer
        Return Me.TorneoDAO.Insertar(Me)
    End Function

    Public Function ActualizarTorneo() As Integer
        Return Me.TorneoDAO.Actualizar(Me)
    End Function

    Public Function BorrarTorneo() As Integer
        Return Me.TorneoDAO.Borrar(Me)
    End Function

End Class
