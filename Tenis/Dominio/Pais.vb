Public Class Pais

    Public Property idPais As String
    Public Property NombrePais As String
    Public Property PaisDAO As PaisDAO

    Public Sub New()
        Me.PaisDAO = New PaisDAO
    End Sub

    Public Sub New(id As String)
        Me.PaisDAO = New PaisDAO
        Me.idPais = id
    End Sub

    Public Sub LeerTodosPaises()
        Me.PaisDAO.LeerTodas()
    End Sub

    Public Sub LeerPais()
        Me.PaisDAO.Leer(Me)
    End Sub

    Public Function InsertarPais() As Integer
        Return Me.PaisDAO.Insertar(Me)
    End Function

    Public Function ActualizarPais() As Integer
        Return Me.PaisDAO.Actualizar(Me)
    End Function

    Public Function BorrarPais() As Integer
        Return Me.PaisDAO.Borrar(Me)
    End Function

End Class
