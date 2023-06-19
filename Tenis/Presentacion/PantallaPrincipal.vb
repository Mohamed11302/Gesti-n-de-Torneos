Public Class PantallaPrincipal
    Private resultado As DialogResult
    Public Property LabelEstado As Object

    Private Sub click_Conectar_Principal(sender As Object, e As EventArgs) Handles Boton_conectar.Click

        Boton_siguiente.Enabled = True
        Label1.Visible = True
        Label1.Text = " CONEXIÓN CORRECTA. PULSE SIGUIENTE PARA CONTINUAR"
        Label1.ForeColor = Color.DarkRed

    End Sub


    Private Sub Boton_siguiente_Click_1(sender As Object, e As EventArgs) Handles Boton_siguiente.Click
        Me.Activate()
        resultado = CType(MsgBox("¿Desea continuar? ", vbOKCancel, "CONFIRMACION"), DialogResult)
        If resultado = 1 Then
            Dim p As Pantalla_carga = New Pantalla_carga
            Me.Visible = False
            p.Show()
        Else
            Me.Close()

        End If
    End Sub
End Class