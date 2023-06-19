<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jugadoras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jugadoras))
        Me.PaisTxt = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FechaTxt = New System.Windows.Forms.DateTimePicker()
        Me.Button_EliminarJ = New System.Windows.Forms.Button()
        Me.Button_ActualizarJ = New System.Windows.Forms.Button()
        Me.Button_ClearJ = New System.Windows.Forms.Button()
        Me.ButtonInsertarJ = New System.Windows.Forms.Button()
        Me.ListJugadoras = New System.Windows.Forms.ListBox()
        Me.NombreJTxt = New System.Windows.Forms.TextBox()
        Me.PuntosTxT = New System.Windows.Forms.TextBox()
        Me.IDJugadoraTxt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PaisTxt
        '
        Me.PaisTxt.FormattingEnabled = True
        Me.PaisTxt.Location = New System.Drawing.Point(178, 269)
        Me.PaisTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.PaisTxt.Name = "PaisTxt"
        Me.PaisTxt.Size = New System.Drawing.Size(109, 21)
        Me.PaisTxt.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 271)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 14)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "PAIS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(39, 232)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 14)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "PUNTOS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 181)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 14)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "FECHA DE NACIEMIENTO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 136)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 14)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "NOMBRE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 98)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 14)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "ID JUGADORA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Forte", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(136, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 38)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "JUGADORAS "
        '
        'FechaTxt
        '
        Me.FechaTxt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaTxt.Location = New System.Drawing.Point(178, 178)
        Me.FechaTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.FechaTxt.Name = "FechaTxt"
        Me.FechaTxt.Size = New System.Drawing.Size(109, 20)
        Me.FechaTxt.TabIndex = 27
        '
        'Button_EliminarJ
        '
        Me.Button_EliminarJ.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button_EliminarJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Button_EliminarJ.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_EliminarJ.Location = New System.Drawing.Point(26, 453)
        Me.Button_EliminarJ.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_EliminarJ.Name = "Button_EliminarJ"
        Me.Button_EliminarJ.Size = New System.Drawing.Size(114, 44)
        Me.Button_EliminarJ.TabIndex = 26
        Me.Button_EliminarJ.Text = "ELIMINAR"
        Me.Button_EliminarJ.UseVisualStyleBackColor = False
        '
        'Button_ActualizarJ
        '
        Me.Button_ActualizarJ.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button_ActualizarJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Button_ActualizarJ.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_ActualizarJ.Location = New System.Drawing.Point(142, 396)
        Me.Button_ActualizarJ.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_ActualizarJ.Name = "Button_ActualizarJ"
        Me.Button_ActualizarJ.Size = New System.Drawing.Size(118, 43)
        Me.Button_ActualizarJ.TabIndex = 25
        Me.Button_ActualizarJ.Text = "ACTUALIZAR"
        Me.Button_ActualizarJ.UseVisualStyleBackColor = False
        '
        'Button_ClearJ
        '
        Me.Button_ClearJ.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button_ClearJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Button_ClearJ.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_ClearJ.Location = New System.Drawing.Point(142, 453)
        Me.Button_ClearJ.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_ClearJ.Name = "Button_ClearJ"
        Me.Button_ClearJ.Size = New System.Drawing.Size(118, 44)
        Me.Button_ClearJ.TabIndex = 24
        Me.Button_ClearJ.Text = "LIMPIAR CAMPOS"
        Me.Button_ClearJ.UseVisualStyleBackColor = False
        '
        'ButtonInsertarJ
        '
        Me.ButtonInsertarJ.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ButtonInsertarJ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonInsertarJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.ButtonInsertarJ.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonInsertarJ.Location = New System.Drawing.Point(26, 396)
        Me.ButtonInsertarJ.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonInsertarJ.Name = "ButtonInsertarJ"
        Me.ButtonInsertarJ.Size = New System.Drawing.Size(114, 43)
        Me.ButtonInsertarJ.TabIndex = 23
        Me.ButtonInsertarJ.Text = "INSERTAR"
        Me.ButtonInsertarJ.UseVisualStyleBackColor = False
        '
        'ListJugadoras
        '
        Me.ListJugadoras.FormattingEnabled = True
        Me.ListJugadoras.Location = New System.Drawing.Point(301, 68)
        Me.ListJugadoras.Margin = New System.Windows.Forms.Padding(2)
        Me.ListJugadoras.Name = "ListJugadoras"
        Me.ListJugadoras.Size = New System.Drawing.Size(272, 238)
        Me.ListJugadoras.TabIndex = 22
        '
        'NombreJTxt
        '
        Me.NombreJTxt.Location = New System.Drawing.Point(178, 136)
        Me.NombreJTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.NombreJTxt.Name = "NombreJTxt"
        Me.NombreJTxt.Size = New System.Drawing.Size(109, 20)
        Me.NombreJTxt.TabIndex = 21
        '
        'PuntosTxT
        '
        Me.PuntosTxT.Location = New System.Drawing.Point(178, 229)
        Me.PuntosTxT.Margin = New System.Windows.Forms.Padding(2)
        Me.PuntosTxT.Name = "PuntosTxT"
        Me.PuntosTxT.Size = New System.Drawing.Size(109, 20)
        Me.PuntosTxT.TabIndex = 20
        '
        'IDJugadoraTxt
        '
        Me.IDJugadoraTxt.Location = New System.Drawing.Point(178, 97)
        Me.IDJugadoraTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.IDJugadoraTxt.Name = "IDJugadoraTxt"
        Me.IDJugadoraTxt.Size = New System.Drawing.Size(109, 20)
        Me.IDJugadoraTxt.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(383, 368)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 187)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Jugadoras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(606, 580)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PaisTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FechaTxt)
        Me.Controls.Add(Me.Button_EliminarJ)
        Me.Controls.Add(Me.Button_ActualizarJ)
        Me.Controls.Add(Me.Button_ClearJ)
        Me.Controls.Add(Me.ButtonInsertarJ)
        Me.Controls.Add(Me.ListJugadoras)
        Me.Controls.Add(Me.NombreJTxt)
        Me.Controls.Add(Me.PuntosTxT)
        Me.Controls.Add(Me.IDJugadoraTxt)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Jugadoras"
        Me.Text = "Jugadoras"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PaisTxt As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FechaTxt As DateTimePicker
    Friend WithEvents Button_EliminarJ As Button
    Friend WithEvents Button_ActualizarJ As Button
    Friend WithEvents Button_ClearJ As Button
    Friend WithEvents ButtonInsertarJ As Button
    Friend WithEvents ListJugadoras As ListBox
    Friend WithEvents NombreJTxt As TextBox
    Friend WithEvents PuntosTxT As TextBox
    Friend WithEvents IDJugadoraTxt As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
