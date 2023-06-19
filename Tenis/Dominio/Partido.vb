Public Class Partido

    Public Property idPartido As Integer
    Public Property Edicion As Edicion
    Public Property Ronda As String
    Public Property Torneo As Torneo

    Public Property Ganadora As Jugadora
    Public Property GSet1 As Integer
    Public Property GSet2 As Integer
    Public Property GSet3 As Integer

    Public Property Perdedora As Jugadora
    Public Property PSet1 As Integer
    Public Property PSet2 As Integer
    Public Property PSet3 As Integer

    Public ReadOnly Property EdicionDAO As EdicionDAO

    Public Sub New()
        Me.EdicionDAO = New EdicionDAO
    End Sub

    Public Sub New(id As Integer)
        Me.EdicionDAO = New EdicionDAO
        Me.idPartido = id
    End Sub

    Public Sub LeerTodosPartidos()
        Me.EdicionDAO.LeerTodosPartidos()
    End Sub

    Public Sub LeerPartidosEdicion()
        Me.EdicionDAO.LeerPartidosEdicion(Me.Edicion)
    End Sub

    Public Function InsertarPartido() As Integer 'MODIFICARLO PARA QUE PRIMERO META EL PARTIDO Y DESPUES LOS JUEGOS
        Return Me.EdicionDAO.InsertarPartido(Me)
    End Function

    Public Function ActualizarPartido() As Integer 'MODIFICARLO PARA QUE SI SE EDITA LOS ATRIBUTOS DE UN PARTIDO CAMBIEN LOS DEL JUEGO
        Return Me.EdicionDAO.ActualizarPartido(Me)
    End Function

    Public Function BorrarPartido() As Integer 'MODIFICARLO PARA QUE SE BORREN LOS JUEGOS Y DESPUES EL PARTIDO
        Return Me.EdicionDAO.BorrarPartido(Me)
    End Function

    Public Function ObtenerIDNoUsado() As Integer
        Return Me.EdicionDAO.ObtieneIDNoUsado()
    End Function

    Public Function ObtenerPartidosEdicion(ByVal Edicion As Edicion) As Collection
        Return Me.EdicionDAO.ExtraerPartidosEdicion(Edicion)
    End Function

    Public Function TraduceNombreRondas() As String
        Dim cadena As String
        cadena = ""
        Select Case (Me.Ronda)
            Case "c"
                cadena = "Cuartos de final"
            Case "s"
                cadena = "Semifinal"
            Case "f"
                cadena = "Final"
        End Select
        Return cadena
    End Function

    Public Shared Widening Operator CType(v As Pais) As Partido
        Throw New NotImplementedException()
    End Operator

    Public Sub LeerJuegosPartido() '
        Me.EdicionDAO.LeerJuegosPartido(Me)
    End Sub







End Class
