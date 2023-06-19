<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.PanelLateral = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Boton_Jugadoras = New System.Windows.Forms.Button()
        Me.Boton_Paises = New System.Windows.Forms.Button()
        Me.Boton_Torneos = New System.Windows.Forms.Button()
        Me.Boton_Estadisticas = New System.Windows.Forms.Button()
        Me.PanelSubMenu = New System.Windows.Forms.Panel()
        Me.Boton_RankingEst = New System.Windows.Forms.Button()
        Me.Boton_JugadorasEst = New System.Windows.Forms.Button()
        Me.Boton_TorneosEst = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelLateral.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSubMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLateral
        '
        Me.PanelLateral.AutoScroll = True
        Me.PanelLateral.BackColor = System.Drawing.Color.Honeydew
        Me.PanelLateral.Controls.Add(Me.Panel1)
        Me.PanelLateral.Controls.Add(Me.Boton_Jugadoras)
        Me.PanelLateral.Controls.Add(Me.Boton_Paises)
        Me.PanelLateral.Controls.Add(Me.Boton_Torneos)
        Me.PanelLateral.Controls.Add(Me.Boton_Estadisticas)
        Me.PanelLateral.Controls.Add(Me.PanelSubMenu)
        Me.PanelLateral.Controls.Add(Me.Button4)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.ForeColor = System.Drawing.Color.DarkGreen
        Me.PanelLateral.Location = New System.Drawing.Point(26, 0)
        Me.PanelLateral.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(188, 621)
        Me.PanelLateral.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 73)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Boton_Jugadoras
        '
        Me.Boton_Jugadoras.Dock = System.Windows.Forms.DockStyle.Top
        Me.Boton_Jugadoras.FlatAppearance.BorderSize = 0
        Me.Boton_Jugadoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boton_Jugadoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton_Jugadoras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Boton_Jugadoras.Image = CType(resources.GetObject("Boton_Jugadoras.Image"), System.Drawing.Image)
        Me.Boton_Jugadoras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Boton_Jugadoras.Location = New System.Drawing.Point(2, 79)
        Me.Boton_Jugadoras.Margin = New System.Windows.Forms.Padding(2)
        Me.Boton_Jugadoras.Name = "Boton_Jugadoras"
        Me.Boton_Jugadoras.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Boton_Jugadoras.Size = New System.Drawing.Size(185, 54)
        Me.Boton_Jugadoras.TabIndex = 0
        Me.Boton_Jugadoras.Text = "JUGADORAS"
        Me.Boton_Jugadoras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Boton_Jugadoras.UseVisualStyleBackColor = True
        '
        'Boton_Paises
        '
        Me.Boton_Paises.Dock = System.Windows.Forms.DockStyle.Top
        Me.Boton_Paises.FlatAppearance.BorderSize = 0
        Me.Boton_Paises.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boton_Paises.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton_Paises.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Boton_Paises.Image = CType(resources.GetObject("Boton_Paises.Image"), System.Drawing.Image)
        Me.Boton_Paises.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Boton_Paises.Location = New System.Drawing.Point(2, 137)
        Me.Boton_Paises.Margin = New System.Windows.Forms.Padding(2)
        Me.Boton_Paises.Name = "Boton_Paises"
        Me.Boton_Paises.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Boton_Paises.Size = New System.Drawing.Size(185, 54)
        Me.Boton_Paises.TabIndex = 2
        Me.Boton_Paises.Text = "PAISES"
        Me.Boton_Paises.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Boton_Paises.UseVisualStyleBackColor = True
        '
        'Boton_Torneos
        '
        Me.Boton_Torneos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Boton_Torneos.FlatAppearance.BorderSize = 0
        Me.Boton_Torneos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boton_Torneos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton_Torneos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Boton_Torneos.Image = CType(resources.GetObject("Boton_Torneos.Image"), System.Drawing.Image)
        Me.Boton_Torneos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Boton_Torneos.Location = New System.Drawing.Point(2, 195)
        Me.Boton_Torneos.Margin = New System.Windows.Forms.Padding(2)
        Me.Boton_Torneos.Name = "Boton_Torneos"
        Me.Boton_Torneos.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Boton_Torneos.Size = New System.Drawing.Size(185, 57)
        Me.Boton_Torneos.TabIndex = 3
        Me.Boton_Torneos.Text = "TORNEOS"
        Me.Boton_Torneos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Boton_Torneos.UseVisualStyleBackColor = True
        '
        'Boton_Estadisticas
        '
        Me.Boton_Estadisticas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Boton_Estadisticas.FlatAppearance.BorderSize = 0
        Me.Boton_Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boton_Estadisticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton_Estadisticas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Boton_Estadisticas.Image = CType(resources.GetObject("Boton_Estadisticas.Image"), System.Drawing.Image)
        Me.Boton_Estadisticas.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Boton_Estadisticas.Location = New System.Drawing.Point(2, 256)
        Me.Boton_Estadisticas.Margin = New System.Windows.Forms.Padding(2)
        Me.Boton_Estadisticas.Name = "Boton_Estadisticas"
        Me.Boton_Estadisticas.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Boton_Estadisticas.Size = New System.Drawing.Size(185, 46)
        Me.Boton_Estadisticas.TabIndex = 4
        Me.Boton_Estadisticas.Text = "ESTADISTICAS"
        Me.Boton_Estadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Boton_Estadisticas.UseVisualStyleBackColor = True
        '
        'PanelSubMenu
        '
        Me.PanelSubMenu.BackColor = System.Drawing.Color.Honeydew
        Me.PanelSubMenu.Controls.Add(Me.Boton_RankingEst)
        Me.PanelSubMenu.Controls.Add(Me.Boton_JugadorasEst)
        Me.PanelSubMenu.Controls.Add(Me.Boton_TorneosEst)
        Me.PanelSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenu.Location = New System.Drawing.Point(2, 306)
        Me.PanelSubMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSubMenu.Name = "PanelSubMenu"
        Me.PanelSubMenu.Size = New System.Drawing.Size(185, 115)
        Me.PanelSubMenu.TabIndex = 1
        '
        'Boton_RankingEst
        '
        Me.Boton_RankingEst.Dock = System.Windows.Forms.DockStyle.Top
        Me.Boton_RankingEst.FlatAppearance.BorderSize = 0
        Me.Boton_RankingEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boton_RankingEst.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton_RankingEst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Boton_RankingEst.Location = New System.Drawing.Point(0, 74)
        Me.Boton_RankingEst.Margin = New System.Windows.Forms.Padding(2)
        Me.Boton_RankingEst.Name = "Boton_RankingEst"
        Me.Boton_RankingEst.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.Boton_RankingEst.Size = New System.Drawing.Size(185, 39)
        Me.Boton_RankingEst.TabIndex = 6
        Me.Boton_RankingEst.Text = "RANKING"
        Me.Boton_RankingEst.UseVisualStyleBackColor = True
        '
        'Boton_JugadorasEst
        '
        Me.Boton_JugadorasEst.Dock = System.Windows.Forms.DockStyle.Top
        Me.Boton_JugadorasEst.FlatAppearance.BorderSize = 0
        Me.Boton_JugadorasEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boton_JugadorasEst.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton_JugadorasEst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Boton_JugadorasEst.Location = New System.Drawing.Point(0, 37)
        Me.Boton_JugadorasEst.Margin = New System.Windows.Forms.Padding(2)
        Me.Boton_JugadorasEst.Name = "Boton_JugadorasEst"
        Me.Boton_JugadorasEst.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.Boton_JugadorasEst.Size = New System.Drawing.Size(185, 37)
        Me.Boton_JugadorasEst.TabIndex = 5
        Me.Boton_JugadorasEst.Text = "JUGADORAS"
        Me.Boton_JugadorasEst.UseVisualStyleBackColor = True
        '
        'Boton_TorneosEst
        '
        Me.Boton_TorneosEst.Dock = System.Windows.Forms.DockStyle.Top
        Me.Boton_TorneosEst.FlatAppearance.BorderSize = 0
        Me.Boton_TorneosEst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Boton_TorneosEst.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton_TorneosEst.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Boton_TorneosEst.Location = New System.Drawing.Point(0, 0)
        Me.Boton_TorneosEst.Margin = New System.Windows.Forms.Padding(2)
        Me.Boton_TorneosEst.Name = "Boton_TorneosEst"
        Me.Boton_TorneosEst.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.Boton_TorneosEst.Size = New System.Drawing.Size(185, 37)
        Me.Boton_TorneosEst.TabIndex = 1
        Me.Boton_TorneosEst.Text = "TORNEOS"
        Me.Boton_TorneosEst.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(2, 425)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(185, 52)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "SIMULAR"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackgroundImage = CType(resources.GetObject("PanelContenedor.BackgroundImage"), System.Drawing.Image)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(214, 0)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(753, 621)
        Me.PanelContenedor.TabIndex = 1
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 621)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelLateral)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(716, 495)
        Me.Name = "MenuPrincipal"
        Me.Padding = New System.Windows.Forms.Padding(26, 0, 0, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TENIS"
        Me.PanelLateral.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSubMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLateral As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Boton_Jugadoras As Button
    Friend WithEvents Boton_Paises As Button
    Friend WithEvents Boton_Torneos As Button
    Friend WithEvents Boton_Estadisticas As Button
    Friend WithEvents PanelSubMenu As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Boton_RankingEst As Button
    Friend WithEvents Boton_JugadorasEst As Button
    Friend WithEvents Boton_TorneosEst As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PanelContenedor As Panel
End Class
