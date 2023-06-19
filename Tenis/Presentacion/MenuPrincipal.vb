Public Class MenuPrincipal


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarSubMenu()
    End Sub

    Private Sub ocultarSubMenu()
        PanelSubMenu.Visible = False
    End Sub

    Private Sub mostrarSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            ocultarSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False

        End If

    End Sub

    Private Sub Boton_Jugadoras_Click(sender As Object, e As EventArgs) Handles Boton_Jugadoras.Click
        ocultarSubMenu()
        AbrirFormulariosHijos(New Jugadoras())

    End Sub

    Private Sub Boton_Paises_Click(sender As Object, e As EventArgs) Handles Boton_Paises.Click
        ocultarSubMenu()
        abrirFormulariosHijos(New Paises())
    End Sub

    Private Sub Boton_Torneos_Click(sender As Object, e As EventArgs) Handles Boton_Torneos.Click
        ocultarSubMenu()
        abrirFormulariosHijos(New Torneos())
    End Sub

    Private Sub Boton_Estadisticas_Click(sender As Object, e As EventArgs) Handles Boton_Estadisticas.Click
        mostrarSubMenu(PanelSubMenu)

    End Sub

    Private Sub Boton_TorneosEst_Click(sender As Object, e As EventArgs) Handles Boton_TorneosEst.Click
        ocultarSubMenu()
        abrirFormulariosHijos(New TorneosEst())
    End Sub

    Private Sub Boton_JugadorasEst_Click(sender As Object, e As EventArgs) Handles Boton_JugadorasEst.Click
        ocultarSubMenu()
        abrirFormulariosHijos(New JugadorasEstvb())
    End Sub

    Private Sub Boton_RankingEst_Click(sender As Object, e As EventArgs) Handles Boton_RankingEst.Click
        ocultarSubMenu()
        abrirFormulariosHijos(New Ranking())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ocultarSubMenu()
        abrirFormulariosHijos(New Simulaciones())
    End Sub


    Private Sub abrirFormulariosHijos(formularioHijo As Form)
        Dim formularioActual As Form = Nothing
        If formularioActual IsNot Nothing Then formularioActual.Close()
        formularioActual = formularioHijo
        formularioHijo.TopLevel = False
        formularioHijo.FormBorderStyle = FormBorderStyle.None
        formularioHijo.Dock = DockStyle.Fill
        PanelContenedor.Controls.Add(formularioHijo)
        PanelContenedor.Tag = formularioHijo
        formularioHijo.BringToFront()
        formularioHijo.Show()
    End Sub
End Class