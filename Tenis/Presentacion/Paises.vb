Public Class Paises
    Private Sub Paises_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizaListaPaises()
        ACTUALIZAR.Enabled = False
        ELIMINAR.Enabled = False
    End Sub
    Private Sub ActualizaListaPaises()
        Dim paisAux = New Pais()
        ListPaises.Items.Clear()


        Try
            paisAux.LeerTodosPaises()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each paisAux In paisAux.PaisDAO.Paises
            ListPaises.Items.Add(paisAux.idPais & " " & paisAux.NombrePais)
        Next

    End Sub
    Private Sub click_Insertar_Pais(sender As Object, e As EventArgs) Handles Button_Insertarp.Click

        Dim paisAux = New Pais()

        If txtNombre.Text IsNot String.Empty Then
            txtID.Text = txtNombre.Text.Substring(0, 3).ToUpper()
            paisAux.NombrePais = txtNombre.Text
            paisAux.idPais = txtID.Text

            Try
                If paisAux.InsertarPais() <> 1 Then
                    MessageBox.Show("INSERT <> 1", String.Empty, MessageBoxButtons.OK)
                    Exit Sub
                End If
            Catch ex As Exception
                Me.Btn_Clear.PerformClick()
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            ActualizaListaPaises()
        Else
            MsgBox("Es necesario que rellene todos los campos ", vbExclamation)

        End If

    End Sub


    Private Sub click_Actualizar_Pais(sender As Object, e As EventArgs) Handles ACTUALIZAR.Click

        Dim paisAux As Pais

        If Me.txtID.Text IsNot String.Empty And txtNombre.Text IsNot String.Empty Then
            txtID.Text = txtNombre.Text.Substring(0, 3).ToUpper()
            paisAux = New Pais(txtID.Text)
            paisAux.NombrePais = txtNombre.Text
            Try
                If paisAux.ActualizarPais() <> 1 Then 'si es distinto de 1'
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                Me.Btn_Clear.PerformClick()
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            MessageBox.Show(paisAux.NombrePais.ToString & " Actualizado correctamente")
            ActualizaListaPaises()
        Else
            MsgBox("Es necesario que rellene todos los campos ", vbExclamation)

        End If


    End Sub

    Private Sub click_Eliminar_Pais(sender As Object, e As EventArgs) Handles ELIMINAR.Click

        Dim paisAux As Pais

        If Me.txtID.Text IsNot String.Empty And Me.txtNombre.Text IsNot String.Empty Then

            paisAux = New Pais(Me.txtID.Text)

            If MessageBox.Show("¿Estas seguro que quieres borrar " & paisAux.idPais & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try

                    If paisAux.BorrarPais() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex1 As MySql.Data.MySqlClient.MySqlException
                    MessageBox.Show("No puede borrarse el país seleccionada debido a que existen ejemplares de la tabla Edicion de la base de datos en las que él aparece registrado.", ex1.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try

            End If
            Me.Btn_Clear.PerformClick()
            ActualizaListaPaises()
        Else
            MsgBox("Es necesario que rellene todos los campos ", vbExclamation)
        End If

    End Sub

    Private Sub seleccion_Pais_Lista(sender As Object, e As EventArgs) Handles ListPaises.SelectedIndexChanged


        Dim paisAux As Pais
        If ListPaises.SelectedItem IsNot Nothing Then
            Me.ACTUALIZAR.Enabled = True
            Me.ELIMINAR.Enabled = True
            paisAux = New Pais(Split(ListPaises.SelectedItem.ToString(), " ")(0))
            paisAux.LeerPais()
            Try
                paisAux.LeerPais()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            txtID.Text = paisAux.idPais
            txtNombre.Text = paisAux.NombrePais
        End If
    End Sub

    Private Sub click_Limpiar_Pais(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        Me.txtID.Text = String.Empty
        Me.txtNombre.Text = String.Empty
        Me.ACTUALIZAR.Enabled = False
        Me.ELIMINAR.Enabled = False
        ListPaises.ClearSelected()
    End Sub

End Class