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
        Me.DatagridTareasActivas = New System.Windows.Forms.DataGridView()
        Me.DatagridTareasPausa = New System.Windows.Forms.DataGridView()
        CType(Me.DatagridTareasActivas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatagridTareasPausa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatagridTareasActivas
        '
        Me.DatagridTareasActivas.AllowUserToAddRows = False
        Me.DatagridTareasActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridTareasActivas.Location = New System.Drawing.Point(12, 59)
        Me.DatagridTareasActivas.Name = "DatagridTareasActivas"
        Me.DatagridTareasActivas.RowHeadersVisible = False
        Me.DatagridTareasActivas.Size = New System.Drawing.Size(894, 210)
        Me.DatagridTareasActivas.TabIndex = 8
        '
        'DatagridTareasPausa
        '
        Me.DatagridTareasPausa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridTareasPausa.Location = New System.Drawing.Point(10, 314)
        Me.DatagridTareasPausa.Name = "DatagridTareasPausa"
        Me.DatagridTareasPausa.Size = New System.Drawing.Size(896, 227)
        Me.DatagridTareasPausa.TabIndex = 9
        '
        'Listado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 587)
        Me.Controls.Add(Me.DatagridTareasPausa)
        Me.Controls.Add(Me.DatagridTareasActivas)
        Me.Name = "Listado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado"
        CType(Me.DatagridTareasActivas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatagridTareasPausa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DatagridTareasActivas As DataGridView
    Friend WithEvents DatagridTareasPausa As DataGridView
End Class
