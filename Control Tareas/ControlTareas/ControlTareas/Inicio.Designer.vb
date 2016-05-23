<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.cmbListOperador = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbListOperador
        '
        Me.cmbListOperador.FormattingEnabled = True
        Me.cmbListOperador.Location = New System.Drawing.Point(270, 69)
        Me.cmbListOperador.Name = "cmbListOperador"
        Me.cmbListOperador.Size = New System.Drawing.Size(267, 21)
        Me.cmbListOperador.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(270, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 319)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbListOperador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Inicio"
        Me.Text = "CONTROL DE PROCESO - SIL FE"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbListOperador As ComboBox
    Friend WithEvents Button1 As Button
End Class
