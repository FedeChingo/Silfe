<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Listado
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
        Me.DatagridTareasPausa = New System.Windows.Forms.DataGridView()
        CType(Me.DatagridTareasPausa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatagridTareasPausa
        '
        Me.DatagridTareasPausa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridTareasPausa.Location = New System.Drawing.Point(10, 172)
        Me.DatagridTareasPausa.Name = "DatagridTareasPausa"
        Me.DatagridTareasPausa.Size = New System.Drawing.Size(896, 369)
        Me.DatagridTareasPausa.TabIndex = 9
        '
        'Listado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 587)
        Me.Controls.Add(Me.DatagridTareasPausa)
        Me.Name = "Listado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado"
        CType(Me.DatagridTareasPausa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DatagridTareasPausa As DataGridView
End Class
