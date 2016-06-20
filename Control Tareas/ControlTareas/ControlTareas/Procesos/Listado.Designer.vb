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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProcActivo = New System.Windows.Forms.TextBox()
        Me.txtProcPausa = New System.Windows.Forms.TextBox()
        Me.DataGrid1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "CANTIDAD PROCESOS ACTIVOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(291, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "CANTIDAD PROCESOS PAUSADOS"
        '
        'txtProcActivo
        '
        Me.txtProcActivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProcActivo.Location = New System.Drawing.Point(311, 59)
        Me.txtProcActivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProcActivo.Name = "txtProcActivo"
        Me.txtProcActivo.Size = New System.Drawing.Size(123, 19)
        Me.txtProcActivo.TabIndex = 12
        '
        'txtProcPausa
        '
        Me.txtProcPausa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProcPausa.Location = New System.Drawing.Point(311, 123)
        Me.txtProcPausa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProcPausa.Name = "txtProcPausa"
        Me.txtProcPausa.Size = New System.Drawing.Size(123, 19)
        Me.txtProcPausa.TabIndex = 12
        '
        'DataGrid1
        '
        Me.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid1.Location = New System.Drawing.Point(15, 198)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(779, 321)
        Me.DataGrid1.TabIndex = 13
        '
        'Listado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 542)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.txtProcPausa)
        Me.Controls.Add(Me.txtProcActivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Listado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProcActivo As TextBox
    Friend WithEvents txtProcPausa As TextBox
    Friend WithEvents DataGrid1 As DataGridView
End Class
