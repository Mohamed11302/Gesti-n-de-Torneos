<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Simulaciones
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListEdicionesSimulaciones = New System.Windows.Forms.ListBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ListTorneosSimulaciones = New System.Windows.Forms.ListBox()
        Me.ListResumenTor = New System.Windows.Forms.ListBox()
        Me.ListEdicTorneo = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListJugRandoms = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(335, 103)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 20)
        Me.TextBox1.TabIndex = 19
        '
        'ListEdicionesSimulaciones
        '
        Me.ListEdicionesSimulaciones.FormattingEnabled = True
        Me.ListEdicionesSimulaciones.Location = New System.Drawing.Point(512, 47)
        Me.ListEdicionesSimulaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListEdicionesSimulaciones.Name = "ListEdicionesSimulaciones"
        Me.ListEdicionesSimulaciones.Size = New System.Drawing.Size(226, 173)
        Me.ListEdicionesSimulaciones.TabIndex = 18
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(310, 76)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(175, 13)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "AÑO DE LA EDICIÓN A SIMULAR:"
        '
        'ListTorneosSimulaciones
        '
        Me.ListTorneosSimulaciones.FormattingEnabled = True
        Me.ListTorneosSimulaciones.Location = New System.Drawing.Point(39, 47)
        Me.ListTorneosSimulaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListTorneosSimulaciones.Name = "ListTorneosSimulaciones"
        Me.ListTorneosSimulaciones.Size = New System.Drawing.Size(233, 173)
        Me.ListTorneosSimulaciones.TabIndex = 16
        '
        'ListResumenTor
        '
        Me.ListResumenTor.FormattingEnabled = True
        Me.ListResumenTor.Location = New System.Drawing.Point(189, 297)
        Me.ListResumenTor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListResumenTor.Name = "ListResumenTor"
        Me.ListResumenTor.Size = New System.Drawing.Size(194, 290)
        Me.ListResumenTor.TabIndex = 15
        '
        'ListEdicTorneo
        '
        Me.ListEdicTorneo.FormattingEnabled = True
        Me.ListEdicTorneo.Location = New System.Drawing.Point(409, 297)
        Me.ListEdicTorneo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListEdicTorneo.Name = "ListEdicTorneo"
        Me.ListEdicTorneo.Size = New System.Drawing.Size(339, 290)
        Me.ListEdicTorneo.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(323, 145)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 46)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "SIMULAR EDICIÓN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListJugRandoms
        '
        Me.ListJugRandoms.FormattingEnabled = True
        Me.ListJugRandoms.Location = New System.Drawing.Point(18, 297)
        Me.ListJugRandoms.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListJugRandoms.Name = "ListJugRandoms"
        Me.ListJugRandoms.Size = New System.Drawing.Size(146, 290)
        Me.ListJugRandoms.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 272)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "JUGADORAS PARTICIPANTES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label2.Location = New System.Drawing.Point(248, 272)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "RESULTADOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label3.Location = New System.Drawing.Point(455, 272)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "RESULTADOS DE LA EDICIÓN DEL TORNEO"
        '
        'Simulaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(775, 609)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListEdicionesSimulaciones)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.ListTorneosSimulaciones)
        Me.Controls.Add(Me.ListResumenTor)
        Me.Controls.Add(Me.ListEdicTorneo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListJugRandoms)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Simulaciones"
        Me.Text = "Simulaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListEdicionesSimulaciones As ListBox
    Friend WithEvents Label24 As Label
    Friend WithEvents ListTorneosSimulaciones As ListBox
    Friend WithEvents ListResumenTor As ListBox
    Friend WithEvents ListEdicTorneo As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ListJugRandoms As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
