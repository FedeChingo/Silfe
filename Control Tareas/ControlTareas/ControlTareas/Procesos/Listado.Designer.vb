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
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.btnNuevoProceso = New System.Windows.Forms.Button()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datalistado
        '
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Location = New System.Drawing.Point(12, 155)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.Size = New System.Drawing.Size(784, 375)
        Me.datalistado.TabIndex = 0
        '
        'btnNuevoProceso
        '
        Me.btnNuevoProceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNuevoProceso.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!)
        Me.btnNuevoProceso.Location = New System.Drawing.Point(12, 56)
        Me.btnNuevoProceso.Name = "btnNuevoProceso"
        Me.btnNuevoProceso.Size = New System.Drawing.Size(140, 71)
        Me.btnNuevoProceso.TabIndex = 1
        Me.btnNuevoProceso.Text = "NUEVO PROCESO"
        Me.btnNuevoProceso.UseVisualStyleBackColor = False
        '
        'Listado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 542)
        Me.Controls.Add(Me.btnNuevoProceso)
        Me.Controls.Add(Me.datalistado)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Listado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado"
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datalistado As DataGridView
    Friend WithEvents btnNuevoProceso As Button
End Class
