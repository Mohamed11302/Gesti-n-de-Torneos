Public Class Jugadora

    Public Property idJugadora As Integer
    Public Property NombreJugadora As String
    Public Property FechaNacimientoJugadora As String
    Public Property PuntosJugadora As Integer
    Public Property PaisJugadora As Pais
    Public ReadOnly Property JugadoraDAO As JugadoraDAO

    Public Sub New()
        Me.JugadoraDAO = New JugadoraDAO
    End Sub

    Public Sub New(id As Integer)
        Me.JugadoraDAO = New JugadoraDAO
        Me.idJugadora = id
    End Sub

    Public Sub LeerTodasJugadoras()
        Me.JugadoraDAO.LeerTodas()
    End Sub

    Public Sub LeerJugadora()
        Me.JugadoraDAO.Leer(Me)
    End Sub

    Public Function leerPartidosJugadora2() As Collection
        Return Me.JugadoraDAO.leerPartidosJugadora2(Me)
    End Function

    Public Function leerIdPrimeraJugadora() As Collection
        Return Me.JugadoraDAO.leerIdPrimeraJugadora()
    End Function

    Public Function leerPartidosJugadora(ByVal idPartido As Integer) As Collection
        Return Me.JugadoraDAO.leerPartidoJugadora(idPartido)
    End Function

    Public Function leerPartidosJugadoraPorAño(ByVal año As Integer) As Collection
        Return Me.JugadoraDAO.leerPartidosJugadoraPorAño(Me, año)
    End Function

    Public Function leerFinalesJugadora() As Integer
        Dim finales As Integer = 0
        Dim aux As Collection
        For Each aux In Me.JugadoraDAO.leerFinalesJugadora(Me)
            finales = CInt(aux(1))
        Next
        Return finales
    End Function
    Public Function leerPartidosGanadosJugadora() As Integer
        Dim partidos As Integer
        Dim aux As Collection
        For Each aux In Me.JugadoraDAO.leerPartidosGanadosJugadora(Me)
            partidos = CInt(aux(1))
        Next
        Return partidos
    End Function

    Public Function InsertarJugadora() As Integer
        Return Me.JugadoraDAO.Insertar(Me)
    End Function

    Public Function ActualizarJugadora() As Integer
        Return Me.JugadoraDAO.Actualizar(Me)
    End Function

    Public Function BorrarJugadora() As Integer
        Return Me.JugadoraDAO.Borrar(Me)
    End Function

    Public Function elegir8Jugadoras() As Collection

        Me.JugadoraDAO.LeerTodas()

        Dim JugadorasSeleccionadas As Collection
        JugadorasSeleccionadas = New Collection

        Dim pAux As Jugadora
        Dim aleatorio As Integer

        For i = 1 To 8
            aleatorio = CInt(Rnd() * (Me.JugadoraDAO.Jugadoras.Count - 1) + 1)
            pAux = CType(Me.JugadoraDAO.Jugadoras.Item(aleatorio), Jugadora)
            JugadorasSeleccionadas.Add(pAux)
            Me.JugadoraDAO.Jugadoras.Remove(aleatorio)
        Next
        Return JugadorasSeleccionadas
    End Function

    Public Function ordenarJugadorasPorPuntos(JugadorasSeleccionadas As Collection) As Collection

        Dim JugadorasOrdenadas As Collection
        JugadorasOrdenadas = New Collection
        Dim maxJugadoraPuntos As Integer
        maxJugadoraPuntos = 0
        Dim posicionMaxPuntos As Integer
        posicionMaxPuntos = 1

        For i = 1 To 8
            For j = 1 To JugadorasSeleccionadas.Count
                If maxJugadoraPuntos <= CType(JugadorasSeleccionadas.Item(j), Jugadora).PuntosJugadora Then
                    maxJugadoraPuntos = CType(JugadorasSeleccionadas.Item(j), Jugadora).PuntosJugadora
                    posicionMaxPuntos = j
                End If
            Next

            JugadorasOrdenadas.Add(JugadorasSeleccionadas.Item(posicionMaxPuntos))
            JugadorasSeleccionadas.Remove(posicionMaxPuntos)
            maxJugadoraPuntos = 0
        Next
        Return JugadorasOrdenadas
    End Function

    Public Sub incrementaPuntosJugadoras(Jugadoras As Collection)

        Dim puntosASumar As Integer

        For i = 1 To Jugadoras.Count
            Select Case (i)
                Case 8
                    puntosASumar = 100
                Case 7
                    puntosASumar = 50
                Case 5, 6
                    puntosASumar = 25
                Case Else
                    puntosASumar = 10
            End Select
            CType(Jugadoras.Item(i), Jugadora).PuntosJugadora += puntosASumar
            CType(Jugadoras.Item(i), Jugadora).JugadoraDAO.Actualizar(CType(Jugadoras.Item(i), Jugadora))
        Next

    End Sub

End Class
