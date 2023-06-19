<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paises
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Paises))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ELIMINAR = New System.Windows.Forms.Button()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.ACTUALIZAR = New System.Windows.Forms.Button()
        Me.Button_Insertarp = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.ListPaises = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(48, 225)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 14)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "NOMBRE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(48, 173)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 14)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "ID PAIS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Forte", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(162, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 38)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "PAISES"
        '
        'ELIMINAR
        '
        Me.ELIMINAR.AutoSize = True
        Me.ELIMINAR.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ELIMINAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.ELIMINAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ELIMINAR.Location = New System.Drawing.Point(44, 458)
        Me.ELIMINAR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(102, 50)
        Me.ELIMINAR.TabIndex = 22
        Me.ELIMINAR.Text = "ELIMINAR"
        Me.ELIMINAR.UseVisualStyleBackColor = False
        '
        'Btn_Clear
        '
        Me.Btn_Clear.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Btn_Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Clear.Location = New System.Drawing.Point(150, 458)
        Me.Btn_Clear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(94, 50)
        Me.Btn_Clear.TabIndex = 21
        Me.Btn_Clear.Text = "LIMPIAR CAMPOS"
        Me.Btn_Clear.UseVisualStyleBackColor = False
        '
        'ACTUALIZAR
        '
        Me.ACTUALIZAR.AutoSize = True
        Me.ACTUALIZAR.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ACTUALIZAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.ACTUALIZAR.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ACTUALIZAR.Location = New System.Drawing.Point(150, 394)
        Me.ACTUALIZAR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ACTUALIZAR.Name = "ACTUALIZAR"
        Me.ACTUALIZAR.Size = New System.Drawing.Size(113, 48)
        Me.ACTUALIZAR.TabIndex = 20
        Me.ACTUALIZAR.Text = "ACTUALIZAR"
        Me.ACTUALIZAR.UseVisualStyleBackColor = False
        '
        'Button_Insertarp
        '
        Me.Button_Insertarp.AutoSize = True
        Me.Button_Insertarp.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Button_Insertarp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Button_Insertarp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Insertarp.Location = New System.Drawing.Point(44, 394)
        Me.Button_Insertarp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button_Insertarp.Name = "Button_Insertarp"
        Me.Button_Insertarp.Size = New System.Drawing.Size(102, 48)
        Me.Button_Insertarp.TabIndex = 19
        Me.Button_Insertarp.Text = "INSERTAR"
        Me.Button_Insertarp.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(150, 223)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(149, 20)
        Me.txtNombre.TabIndex = 18
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(150, 173)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(149, 20)
        Me.txtID.TabIndex = 17
        '
        'ListPaises
        '
        Me.ListPaises.FormattingEnabled = True
        Me.ListPaises.Location = New System.Drawing.Point(336, 102)
        Me.ListPaises.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListPaises.Name = "ListPaises"
        Me.ListPaises.Size = New System.Drawing.Size(223, 212)
        Me.ListPaises.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(412, 394)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Paises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(582, 580)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ELIMINAR)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.ACTUALIZAR)
        Me.Controls.Add(Me.Button_Insertarp)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.ListPaises)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Paises"
        Me.Text = "Paises"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ELIMINAR As Button
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents ACTUALIZAR As Button
    Friend WithEvents Button_Insertarp As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents ListPaises As ListBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
