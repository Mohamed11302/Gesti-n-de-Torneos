Public Class Torneos
    Private Sub Torneos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizaListaTorneos()
        AñadePaises()
        Me.PaisTorneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Button_EliminarT.Enabled = False
        Button_ActualizarT.Enabled = False
        Me.IdTorneo.Enabled = False
    End Sub
    Private Sub ActualizaListaTorneos()
        Dim torneoAux = New Torneo()
        ListTorneos.Items.Clear()

        Try
            torneoAux.LeerTodosTorneo()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each torneoAux In torneoAux.TorneoDAO.Torneos
            ListTorneos.Items.Add(torneoAux.idTorneo & " " & torneoAux.NombreTorneo)
        Next

    End Sub
    Private Sub AñadePaises()
        Dim paisAux = New Pais()

        PaisTorneo.Items.Clear()

        Try
            paisAux.LeerTodosPaises()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each paisAux In paisAux.PaisDAO.Paises

            PaisTorneo.Items.Add(paisAux.idPais)


        Next

    End Sub
    Private Sub click_Insertar_Torneo(sender As Object, e As EventArgs) Handles Button_Insertart.Click

        Dim torneoAux = New Torneo()
        Dim paisAux As Pais

        If NombreTorneo.Text IsNot String.Empty And CiudadTOrneo.Text IsNot String.Empty And PaisTorneo.Text IsNot String.Empty Then


            torneoAux.NombreTorneo = NombreTorneo.Text
            torneoAux.CiudadTorneo = CiudadTOrneo.Text

            paisAux = New Pais(PaisTorneo.Text)

            Try
                paisAux.LeerPais()
                torneoAux.PaisTorneo = paisAux

                If torneoAux.InsertarTorneo() <> 1 Then
                    MessageBox.Show("INSERT <> 1", String.Empty, MessageBoxButtons.OK)
                    Exit Sub
                End If
            Catch ex As Exception
                Me.Button_Cleart.PerformClick()
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            ActualizaListaTorneos()
        Else
            MsgBox("Es necesario que rellene todos los campos ", vbExclamation)

        End If
    End Sub

    Private Sub click_Actualizar_Torneo(sender As Object, e As EventArgs) Handles Button_ActualizarT.Click

        Dim torneoAux As Torneo
        Dim paisAux As Pais

        If IdTorneo.Text IsNot String.Empty And NombreTorneo.Text IsNot String.Empty And CiudadTOrneo.Text IsNot String.Empty And PaisTorneo.Text IsNot String.Empty Then

            torneoAux = New Torneo(CInt(IdTorneo.Text))
            torneoAux.NombreTorneo = NombreTorneo.Text
            torneoAux.CiudadTorneo = CiudadTOrneo.Text

            paisAux = New Pais(PaisTorneo.Text)

            Try
                paisAux.LeerPais()
                torneoAux.PaisTorneo = paisAux

                If torneoAux.ActualizarTorneo() <> 1 Then
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                Me.Button_Cleart.PerformClick()
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            MessageBox.Show(torneoAux.NombreTorneo.ToString & " Actualizado correctamente")
            ActualizaListaTorneos()
        Else
            MsgBox("Es necesario que rellene todos los campos ", vbExclamation)

        End If
    End Sub

    Private Sub click_Eliminar_Torneo(sender As Object, e As EventArgs) Handles Button_EliminarT.Click

        Dim torneoAux As Torneo

        If Me.IdTorneo.Text IsNot String.Empty And Me.NombreTorneo.Text IsNot String.Empty And Me.CiudadTOrneo.Text IsNot String.Empty And Me.PaisTorneo.Text IsNot String.Empty Then

            torneoAux = New Torneo(CInt(IdTorneo.Text))

            If MessageBox.Show("¿Estas seguro que quieres borrar " & torneoAux.idTorneo & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try

                    If torneoAux.BorrarTorneo() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex1 As MySql.Data.MySqlClient.MySqlException
                    MessageBox.Show("No puede borrarse el torneo seleccionado debido a que existen ejemplares de la tabla Edicion de la base de datos en las que él aparece registrado.", ex1.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                ActualizaListaTorneos()
            End If
            Me.Button_Cleart.PerformClick()
        Else
            MsgBox("Es necesario que rellene todos los campos ", vbExclamation)
        End If
    End Sub

    Private Sub seleccion_Torneo_Lista(sender As Object, e As EventArgs) Handles ListTorneos.SelectedIndexChanged


        Dim torneoAux As Torneo

        If ListTorneos.SelectedItem IsNot Nothing Then
            Me.Button_ActualizarT.Enabled = True
            Me.Button_EliminarT.Enabled = True
            torneoAux = New Torneo(CInt(Split(ListTorneos.SelectedItem.ToString(), " ")(0)))

            Try
                torneoAux.LeerTorneo()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            IdTorneo.Text = torneoAux.idTorneo.ToString
            NombreTorneo.Text = torneoAux.NombreTorneo
            CiudadTOrneo.Text = torneoAux.CiudadTorneo
            PaisTorneo.Text = torneoAux.PaisTorneo.idPais

        End If
    End Sub

    Private Sub click_Limpiar_Torneo(sender As Object, e As EventArgs) Handles Button_Cleart.Click
        Me.IdTorneo.Text = String.Empty
        Me.NombreTorneo.Text = String.Empty
        Me.CiudadTOrneo.Text = String.Empty
        Me.PaisTorneo.Text = String.Empty
        Me.Button_ActualizarT.Enabled = False
        Me.Button_EliminarT.Enabled = False
        ListTorneos.ClearSelected()
    End Sub
End Class