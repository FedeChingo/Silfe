<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarEstado
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
        Me.comboProcesos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFechaFin = New System.Windows.Forms.TextBox()
        Me.txtHsFin = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtNotas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.comboEstado = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'comboProcesos
        '
        Me.comboProcesos.Font = New System.Drawing.Font("Arial Unicode MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboProcesos.FormattingEnabled = True
        Me.comboProcesos.Location = New System.Drawing.Point(13, 55)
        Me.comboProcesos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.comboProcesos.Name = "comboProcesos"
        Me.comboProcesos.Size = New System.Drawing.Size(347, 26)
        Me.comboProcesos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ELEGIR PROCESO"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.Location = New System.Drawing.Point(194, 185)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Size = New System.Drawing.Size(166, 23)
        Me.txtFechaFin.TabIndex = 1
        '
        'txtHsFin
        '
        Me.txtHsFin.Location = New System.Drawing.Point(194, 228)
        Me.txtHsFin.Name = "txtHsFin"
        Me.txtHsFin.Size = New System.Drawing.Size(166, 23)
        Me.txtHsFin.TabIndex = 2
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(194, 314)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(166, 23)
        Me.txtCantidad.TabIndex = 4
        '
        'txtNotas
        '
        Me.txtNotas.Location = New System.Drawing.Point(194, 357)
        Me.txtNotas.Multiline = True
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(166, 91)
        Me.txtNotas.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FECHA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "HORARIO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ESTADO DEL PROCESO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(111, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "CANTIDAD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(135, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "NOTAS"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(194, 467)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(166, 29)
        Me.btnActualizar.TabIndex = 7
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(13, 467)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(107, 29)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(13, 99)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(347, 60)
        Me.txtDescripcion.TabIndex = 8
        '
        'comboEstado
        '
        Me.comboEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.comboEstado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboEstado.ForeColor = System.Drawing.Color.White
        Me.comboEstado.FormattingEnabled = True
        Me.comboEstado.Items.AddRange(New Object() {"Iniciado", "Pausado", "Terminado"})
        Me.comboEstado.Location = New System.Drawing.Point(194, 273)
        Me.comboEstado.Name = "comboEstado"
        Me.comboEstado.Size = New System.Drawing.Size(166, 25)
        Me.comboEstado.TabIndex = 3
        '
        'CambiarEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 524)
        Me.Controls.Add(Me.comboEstado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNotas)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtHsFin)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtFechaFin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboProcesos)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "CambiarEstado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CambiarEstado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboProcesos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFechaFin As TextBox
    Friend WithEvents txtHsFin As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtNotas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents comboEstado As ComboBox
End Class
