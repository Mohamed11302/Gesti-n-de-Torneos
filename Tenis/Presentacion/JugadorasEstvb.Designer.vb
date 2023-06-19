<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JugadorasEstvb
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
        Me.ListaEstAnio = New System.Windows.Forms.ListBox()
        Me.ListaEstJugadorasEdiciones = New System.Windows.Forms.ListBox()
        Me.ListaEstJugadoras = New System.Windows.Forms.ListBox()
        Me.Anio = New System.Windows.Forms.Button()
        Me.TextAnio = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListaEstAnio
        '
        Me.ListaEstAnio.FormattingEnabled = True
        Me.ListaEstAnio.Location = New System.Drawing.Point(229, 376)
        Me.ListaEstAnio.Margin = New System.Windows.Forms.Padding(2)
        Me.ListaEstAnio.Name = "ListaEstAnio"
        Me.ListaEstAnio.Size = New System.Drawing.Size(411, 95)
        Me.ListaEstAnio.TabIndex = 19
        '
        'ListaEstJugadorasEdiciones
        '
        Me.ListaEstJugadorasEdiciones.FormattingEnabled = True
        Me.ListaEstJugadorasEdiciones.Location = New System.Drawing.Point(229, 30)
        Me.ListaEstJugadorasEdiciones.Margin = New System.Windows.Forms.Padding(2)
        Me.ListaEstJugadorasEdiciones.Name = "ListaEstJugadorasEdiciones"
        Me.ListaEstJugadorasEdiciones.Size = New System.Drawing.Size(411, 277)
        Me.ListaEstJugadorasEdiciones.TabIndex = 18
        '
        'ListaEstJugadoras
        '
        Me.ListaEstJugadoras.FormattingEnabled = True
        Me.ListaEstJugadoras.Location = New System.Drawing.Point(9, 30)
        Me.ListaEstJugadoras.Margin = New System.Windows.Forms.Padding(2)
        Me.ListaEstJugadoras.Name = "ListaEstJugadoras"
        Me.ListaEstJugadoras.Size = New System.Drawing.Size(190, 277)
        Me.ListaEstJugadoras.TabIndex = 17
        '
        'Anio
        '
        Me.Anio.Location = New System.Drawing.Point(34, 376)
        Me.Anio.Name = "Anio"
        Me.Anio.Size = New System.Drawing.Size(100, 26)
        Me.Anio.TabIndex = 16
        Me.Anio.Text = "Año"
        Me.Anio.UseVisualStyleBackColor = True
        '
        'TextAnio
        '
        Me.TextAnio.Location = New System.Drawing.Point(34, 409)
        Me.TextAnio.Name = "TextAnio"
        Me.TextAnio.Size = New System.Drawing.Size(102, 20)
        Me.TextAnio.TabIndex = 15
        '
        'JugadorasEstvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(670, 580)
        Me.Controls.Add(Me.ListaEstAnio)
        Me.Controls.Add(Me.ListaEstJugadorasEdiciones)
        Me.Controls.Add(Me.ListaEstJugadoras)
        Me.Controls.Add(Me.Anio)
        Me.Controls.Add(Me.TextAnio)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "JugadorasEstvb"
        Me.Text = "JugadorasEstvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListaEstAnio As ListBox
    Friend WithEvents ListaEstJugadorasEdiciones As ListBox
    Friend WithEvents ListaEstJugadoras As ListBox
    Friend WithEvents Anio As Button
    Friend WithEvents TextAnio As TextBox
End Class
