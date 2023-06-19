<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaPrincipal))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Boton_siguiente = New System.Windows.Forms.Button()
        Me.Boton_conectar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(486, 596)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(159, 55)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Boton_siguiente
        '
        Me.Boton_siguiente.BackColor = System.Drawing.Color.Firebrick
        Me.Boton_siguiente.Enabled = False
        Me.Boton_siguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton_siguiente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Boton_siguiente.Location = New System.Drawing.Point(-2, 596)
        Me.Boton_siguiente.Margin = New System.Windows.Forms.Padding(2)
        Me.Boton_siguiente.Name = "Boton_siguiente"
        Me.Boton_siguiente.Size = New System.Drawing.Size(130, 35)
        Me.Boton_siguiente.TabIndex = 9
        Me.Boton_siguiente.Text = "SIGUIENTE"
        Me.Boton_siguiente.UseVisualStyleBackColor = False
        '
        'Boton_conectar
        '
        Me.Boton_conectar.BackColor = System.Drawing.Color.Firebrick
        Me.Boton_conectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton_conectar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Boton_conectar.Location = New System.Drawing.Point(-2, 554)
        Me.Boton_conectar.Margin = New System.Windows.Forms.Padding(2)
        Me.Boton_conectar.Name = "Boton_conectar"
        Me.Boton_conectar.Size = New System.Drawing.Size(130, 37)
        Me.Boton_conectar.TabIndex = 8
        Me.Boton_conectar.Text = "CONECTAR"
        Me.Boton_conectar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(87, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'PantallaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(662, 651)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Boton_siguiente)
        Me.Controls.Add(Me.Boton_conectar)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PantallaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONEXIÓN APLICACIÓN"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Boton_siguiente As Button
    Friend WithEvents Boton_conectar As Button
    Friend WithEvents Label1 As Label
End Class
