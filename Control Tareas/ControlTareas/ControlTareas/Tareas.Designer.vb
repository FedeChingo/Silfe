<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tareas
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
        Me.DataGridTareas = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridTareas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridTareas
        '
        Me.DataGridTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTareas.Location = New System.Drawing.Point(12, 191)
        Me.DataGridTareas.Name = "DataGridTareas"
        Me.DataGridTareas.Size = New System.Drawing.Size(899, 263)
        Me.DataGridTareas.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(772, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 54)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "NUEVO PROCESO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Tareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 466)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridTareas)
        Me.Name = "Tareas"
        Me.Text = "Tareas"
        CType(Me.DataGridTareas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridTareas As DataGridView
    Friend WithEvents Button1 As Button
End Class
