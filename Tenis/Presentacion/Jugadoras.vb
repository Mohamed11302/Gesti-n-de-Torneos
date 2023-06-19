Public Class Jugadoras

    Private Sub click_Limpiar_Jugadora(sender As Object, e As EventArgs) Handles Button_ClearJ.Click
        Me.IDJugadoraTxt.Text = String.Empty
        Me.NombreJTxt.Text = String.Empty
        Me.FechaTxt.Text = String.Empty
        Me.PuntosTxT.Text = String.Empty
        Me.PaisTxt.Text = String.Empty
        Me.Button_ActualizarJ.Enabled = False
        Me.Button_EliminarJ.Enabled = False
        ListJugadoras.ClearSelected()
    End Sub
    Private Sub seleccion_Jugadora_Lista(sender As Object, e As EventArgs)

        Dim jugadoraAux As Jugadora

        If ListJugadoras.SelectedItem IsNot Nothing Then
            Me.Button_ActualizarJ.Enabled = True
            Me.Button_EliminarJ.Enabled = True
            jugadoraAux = New Jugadora(CInt(Split(ListJugadoras.SelectedItem.ToString(), " ")(0)))

            Try
                jugadoraAux.LeerJugadora()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            IDJugadoraTxt.Text = CStr(jugadoraAux.idJugadora)
            NombreJTxt.Text = "-" & jugadoraAux.NombreJugadora & "-"
            FechaTxt.Text = jugadoraAux.FechaNacimientoJugadora
            PuntosTxT.Text = jugadoraAux.PuntosJugadora.ToString
            PaisTxt.Text = jugadoraAux.PaisJugadora.idPais


        End If

    End Sub

    Private Sub Jugadoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IDJugadoraTxt.Enabled = False
        Me.PuntosTxT.Enabled = False
        ActualizaListaJugadoras()
        AñadePaises()
        Me.PaisTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList

        Button_ActualizarJ.Enabled = False
        Button_EliminarJ.Enabled = False
    End Sub
    Private Sub AñadePaises()
        Dim paisAux = New Pais()

        PaisTxt.Items.Clear()

        Try
            paisAux.LeerTodosPaises()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each paisAux In paisAux.PaisDAO.Paises

            PaisTxt.Items.Add(paisAux.idPais)


        Next

    End Sub
    Private Sub ActualizaListaJugadoras()
        Dim jugadoraAux = New Jugadora()
        ListJugadoras.Items.Clear()
        Try
            jugadoraAux.LeerTodasJugadoras()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each jugadoraAux In jugadoraAux.JugadoraDAO.Jugadoras

            ListJugadoras.Items.Add(jugadoraAux.idJugadora & " " & jugadoraAux.NombreJugadora)
        Next

    End Sub

    Private Sub ListJugadoras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListJugadoras.SelectedIndexChanged

        Dim jugadoraAux As Jugadora

        If ListJugadoras.SelectedItem IsNot Nothing Then
            Me.Button_ActualizarJ.Enabled = True
            Me.Button_EliminarJ.Enabled = True
            jugadoraAux = New Jugadora(CInt(Split(ListJugadoras.SelectedItem.ToString(), " ")(0)))

            Try
                jugadoraAux.LeerJugadora()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            IDJugadoraTxt.Text = CStr(jugadoraAux.idJugadora)
            NombreJTxt.Text = jugadoraAux.NombreJugadora
            FechaTxt.Text = jugadoraAux.FechaNacimientoJugadora
            PuntosTxT.Text = jugadoraAux.PuntosJugadora.ToString
            PaisTxt.Text = jugadoraAux.PaisJugadora.idPais

        End If
    End Sub

    Private Sub Button_EliminarJ_Click(sender As Object, e As EventArgs) Handles Button_EliminarJ.Click
        Dim jugadoraAux As Jugadora

        If IDJugadoraTxt.Text IsNot String.Empty And NombreJTxt.Text IsNot String.Empty And FechaTxt.Text IsNot String.Empty And PuntosTxT.Text IsNot String.Empty And PaisTxt.Text IsNot String.Empty Then

            jugadoraAux = New Jugadora(CInt(Me.IDJugadoraTxt.Text))

            If MessageBox.Show("¿Estas seguro que quieres borrar a " & jugadoraAux.idJugadora & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If jugadoraAux.BorrarJugadora() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                Catch ex1 As MySql.Data.MySqlClient.MySqlException
                    MessageBox.Show("No puede borrarse la jugadora seleccionada debido a que existen ejemplares de la tabla Edicion de la base de datos en las que ella aparece registrada.", ex1.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Catch ex2 As Exception
                    MessageBox.Show(ex2.Message, ex2.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                ActualizaListaJugadoras()
            End If

            Me.Button_ClearJ.PerformClick()
        Else
            MsgBox("Es necesario que rellene todos los campos ", vbExclamation)
        End If
    End Sub

    Private Sub ButtonInsertarJ_Click(sender As Object, e As EventArgs) Handles ButtonInsertarJ.Click
        Dim jugadoraAux As Jugadora
        Dim paisAux As Pais

        If NombreJTxt.Text IsNot String.Empty And FechaTxt.Text IsNot String.Empty And PaisTxt.Text IsNot String.Empty Then

            FechaTxt.Format = DateTimePickerFormat.Custom

            jugadoraAux = New Jugadora()
            jugadoraAux.NombreJugadora = NombreJTxt.Text
            jugadoraAux.FechaNacimientoJugadora = FechaTxt.Value.ToString("yyyy/MM/dd")

            paisAux = New Pais(PaisTxt.Text)

            Try

                paisAux.LeerPais()
                jugadoraAux.PaisJugadora = paisAux

                If jugadoraAux.InsertarJugadora() <> 1 Then
                    MessageBox.Show("INSERT <> 1", String.Empty, MessageBoxButtons.OK)
                    Exit Sub
                End If

            Catch ex As Exception
                Me.Button_ClearJ.PerformClick()
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            ActualizaListaJugadoras()

        Else
            MsgBox("Es necesario que rellene todos los campos ", vbExclamation)

        End If
    End Sub

    Private Sub Button_ActualizarJ_Click(sender As Object, e As EventArgs) Handles Button_ActualizarJ.Click

        Dim jugadoraAux As Jugadora
        Dim paisAux As Pais


        If IDJugadoraTxt.Text IsNot String.Empty And NombreJTxt.Text IsNot String.Empty And FechaTxt.Text IsNot String.Empty And PuntosTxT.Text IsNot String.Empty And PaisTxt.Text IsNot String.Empty Then

            FechaTxt.Format = DateTimePickerFormat.Custom

            jugadoraAux = New Jugadora(CInt(IDJugadoraTxt.Text))
            jugadoraAux.NombreJugadora = NombreJTxt.Text
            jugadoraAux.FechaNacimientoJugadora = FechaTxt.Value.ToString("yyyy/MM/dd")
            jugadoraAux.PuntosJugadora = CInt(PuntosTxT.Text)

            Try
                paisAux = New Pais(PaisTxt.Text)
                paisAux.LeerPais()
                jugadoraAux.PaisJugadora = paisAux

                If jugadoraAux.ActualizarJugadora() <> 1 Then 'si es distinto de 1'
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                Me.Button_ClearJ.PerformClick()
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            MessageBox.Show(jugadoraAux.NombreJugadora.ToString & " Actualizado correctamente")

            ActualizaListaJugadoras()
        Else
            MsgBox("Es necesario que rellene todos los campos ", vbExclamation)


        End If
    End Sub

End Class