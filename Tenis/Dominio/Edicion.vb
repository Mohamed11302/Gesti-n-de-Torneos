Public Class Edicion

    Public Property Anualidad As Integer
    Public Property Torneo As Torneo
    Public Property Ganadora As Jugadora
    Public ReadOnly Property EdicionDAO As EdicionDAO

    Public Sub New()
        Me.EdicionDAO = New EdicionDAO
    End Sub

    Public Sub New(año As Integer, torneo As Torneo)
        Me.EdicionDAO = New EdicionDAO
        Me.Anualidad = año
        Me.Torneo = torneo
    End Sub

    Public Sub LeerTodasEdiciones()
        Me.EdicionDAO.LeerTodasEdiciones()
    End Sub

    Public Sub LeerEdicion()
        Me.EdicionDAO.LeerEdicion(Me)
    End Sub
    Public Sub LeerEdicionesTorneo()
        Me.EdicionDAO.LeerEdicionesTorneo(Me)
    End Sub

    Public Function devuelveNumEdionesTorneo_PorAño(ByVal Torneo As Torneo, ByVal Año As Integer) As Collection
        Return Me.EdicionDAO.devuelveNumEdionesTorneo_PorAño(Torneo, Año)
    End Function

    Public Function InsertarEdicion() As Integer
        Return Me.EdicionDAO.InsertarEdicion(Me)
    End Function

    Public Function ActualizarEdicion() As Integer
        Return Me.EdicionDAO.ActualizarEdicion(Me)
    End Function

    Public Function BorrarEdicion() As Integer
        Return Me.EdicionDAO.BorrarEdicion(Me)
    End Function



End Class
