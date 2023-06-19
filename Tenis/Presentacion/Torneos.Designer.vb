<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Torneos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Torneos))
        Me.PaisTorneo = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_Cleart = New System.Windows.Forms.Button()
        Me.Button_Insertart = New System.Windows.Forms.Button()
        Me.Button_ActualizarT = New System.Windows.Forms.Button()
        Me.Button_EliminarT = New System.Windows.Forms.Button()
        Me.ListTorneos = New System.Windows.Forms.ListBox()
        Me.NombreTorneo = New System.Windows.Forms.TextBox()
        Me.CiudadTOrneo = New System.Windows.Forms.TextBox()
        Me.IdTorneo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PaisTorneo
        '
        Me.PaisTorneo.FormattingEnabled = True
        Me.PaisTorneo.Location = New System.Drawing.Point(157, 297)
        Me.PaisTorneo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PaisTorneo.Name = "PaisTorneo"
        Me.PaisTorneo.Size = New System.Drawing.Size(152, 21)
        Me.PaisTorneo.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(46, 297)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 14)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "PAIS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(38, 248)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 14)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "CIUDAD"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(40, 201)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 14)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "NOMBRE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(38, 151)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 14)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "ID TORNEO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Forte", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(137, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 38)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "TORNEOS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button_Cleart
        '
        Me.Button_Cleart.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button_Cleart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Cleart.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_Cleart.Location = New System.Drawing.Point(154, 505)
        Me.Button_Cleart.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button_Cleart.Name = "Button_Cleart"
        Me.Button_Cleart.Size = New System.Drawing.Size(110, 42)
        Me.Button_Cleart.TabIndex = 26
        Me.Button_Cleart.Text = "LIMPIAR CAMPOS"
        Me.Button_Cleart.UseVisualStyleBackColor = False
        '
        'Button_Insertart
        '
        Me.Button_Insertart.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button_Insertart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Insertart.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_Insertart.Location = New System.Drawing.Point(42, 458)
        Me.Button_Insertart.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button_Insertart.Name = "Button_Insertart"
        Me.Button_Insertart.Size = New System.Drawing.Size(107, 44)
        Me.Button_Insertart.TabIndex = 25
        Me.Button_Insertart.Text = "INSERTAR"
        Me.Button_Insertart.UseVisualStyleBackColor = False
        '
        'Button_ActualizarT
        '
        Me.Button_ActualizarT.AutoSize = True
        Me.Button_ActualizarT.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button_ActualizarT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ActualizarT.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_ActualizarT.Location = New System.Drawing.Point(154, 458)
        Me.Button_ActualizarT.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button_ActualizarT.Name = "Button_ActualizarT"
        Me.Button_ActualizarT.Size = New System.Drawing.Size(113, 44)
        Me.Button_ActualizarT.TabIndex = 24
        Me.Button_ActualizarT.Text = "ACTUALIZAR"
        Me.Button_ActualizarT.UseVisualStyleBackColor = False
        '
        'Button_EliminarT
        '
        Me.Button_EliminarT.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button_EliminarT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_EliminarT.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_EliminarT.Location = New System.Drawing.Point(42, 505)
        Me.Button_EliminarT.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button_EliminarT.Name = "Button_EliminarT"
        Me.Button_EliminarT.Size = New System.Drawing.Size(107, 42)
        Me.Button_EliminarT.TabIndex = 23
        Me.Button_EliminarT.Text = "ELIMINAR"
        Me.Button_EliminarT.UseVisualStyleBackColor = False
        '
        'ListTorneos
        '
        Me.ListTorneos.FormattingEnabled = True
        Me.ListTorneos.Location = New System.Drawing.Point(334, 148)
        Me.ListTorneos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListTorneos.Name = "ListTorneos"
        Me.ListTorneos.Size = New System.Drawing.Size(241, 186)
        Me.ListTorneos.TabIndex = 22
        '
        'NombreTorneo
        '
        Me.NombreTorneo.Location = New System.Drawing.Point(157, 197)
        Me.NombreTorneo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NombreTorneo.Name = "NombreTorneo"
        Me.NombreTorneo.Size = New System.Drawing.Size(152, 20)
        Me.NombreTorneo.TabIndex = 21
        '
        'CiudadTOrneo
        '
        Me.CiudadTOrneo.Location = New System.Drawing.Point(157, 245)
        Me.CiudadTOrneo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CiudadTOrneo.Name = "CiudadTOrneo"
        Me.CiudadTOrneo.Size = New System.Drawing.Size(152, 20)
        Me.CiudadTOrneo.TabIndex = 20
        '
        'IdTorneo
        '
        Me.IdTorneo.Location = New System.Drawing.Point(157, 148)
        Me.IdTorneo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IdTorneo.Name = "IdTorneo"
        Me.IdTorneo.Size = New System.Drawing.Size(152, 20)
        Me.IdTorneo.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(448, 406)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Torneos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(596, 580)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PaisTorneo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button_Cleart)
        Me.Controls.Add(Me.Button_Insertart)
        Me.Controls.Add(Me.Button_ActualizarT)
        Me.Controls.Add(Me.Button_EliminarT)
        Me.Controls.Add(Me.ListTorneos)
        Me.Controls.Add(Me.NombreTorneo)
        Me.Controls.Add(Me.CiudadTOrneo)
        Me.Controls.Add(Me.IdTorneo)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Torneos"
        Me.Text = "Torneos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PaisTorneo As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_Cleart As Button
    Friend WithEvents Button_Insertart As Button
    Friend WithEvents Button_ActualizarT As Button
    Friend WithEvents Button_EliminarT As Button
    Friend WithEvents ListTorneos As ListBox
    Friend WithEvents NombreTorneo As TextBox
    Friend WithEvents CiudadTOrneo As TextBox
    Friend WithEvents IdTorneo As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
