<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IniciarProceso
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTareas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAgregarOperario = New System.Windows.Forms.Button()
        Me.dataGridOperador = New System.Windows.Forms.DataGridView()
        Me.btnBorrarOperador = New System.Windows.Forms.Button()
        Me.comboOperario = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dataGridOperador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PROCESO"
        '
        'cmbTareas
        '
        Me.cmbTareas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbTareas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTareas.FormattingEnabled = True
        Me.cmbTareas.Location = New System.Drawing.Point(135, 37)
        Me.cmbTareas.Name = "cmbTareas"
        Me.cmbTareas.Size = New System.Drawing.Size(366, 23)
        Me.cmbTareas.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FECHA INICIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(281, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "HORA INICIO"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(152, 86)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 23)
        Me.txtFecha.TabIndex = 6
        '
        'txtHora
        '
        Me.txtHora.Location = New System.Drawing.Point(401, 86)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(100, 23)
        Me.txtHora.TabIndex = 6
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.Color.White
        Me.btnCargar.Location = New System.Drawing.Point(423, 268)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(78, 63)
        Me.btnCargar.TabIndex = 8
        Me.btnCargar.Text = "CARGAR"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "OPERARIO"
        '
        'btnAgregarOperario
        '
        Me.btnAgregarOperario.Location = New System.Drawing.Point(414, 139)
        Me.btnAgregarOperario.Name = "btnAgregarOperario"
        Me.btnAgregarOperario.Size = New System.Drawing.Size(87, 23)
        Me.btnAgregarOperario.TabIndex = 10
        Me.btnAgregarOperario.Text = "AGREGAR"
        Me.btnAgregarOperario.UseVisualStyleBackColor = True
        '
        'dataGridOperador
        '
        Me.dataGridOperador.AllowUserToAddRows = False
        Me.dataGridOperador.AllowUserToDeleteRows = False
        Me.dataGridOperador.AllowUserToResizeColumns = False
        Me.dataGridOperador.AllowUserToResizeRows = False
        Me.dataGridOperador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridOperador.Location = New System.Drawing.Point(27, 189)
        Me.dataGridOperador.Name = "dataGridOperador"
        Me.dataGridOperador.RowHeadersVisible = False
        Me.dataGridOperador.Size = New System.Drawing.Size(381, 150)
        Me.dataGridOperador.TabIndex = 11
        '
        'btnBorrarOperador
        '
        Me.btnBorrarOperador.BackColor = System.Drawing.Color.White
        Me.btnBorrarOperador.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarOperador.Location = New System.Drawing.Point(423, 181)
        Me.btnBorrarOperador.Name = "btnBorrarOperador"
        Me.btnBorrarOperador.Size = New System.Drawing.Size(75, 41)
        Me.btnBorrarOperador.TabIndex = 12
        Me.btnBorrarOperador.Text = "BORRAR OPERARIO"
        Me.btnBorrarOperador.UseVisualStyleBackColor = False
        '
        'comboOperario
        '
        Me.comboOperario.FormattingEnabled = True
        Me.comboOperario.Location = New System.Drawing.Point(135, 134)
        Me.comboOperario.Name = "comboOperario"
        Me.comboOperario.Size = New System.Drawing.Size(198, 23)
        Me.comboOperario.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(241, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IniciarProceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(524, 427)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.comboOperario)
        Me.Controls.Add(Me.dataGridOperador)
        Me.Controls.Add(Me.btnBorrarOperador)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.btnAgregarOperario)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTareas)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "IniciarProceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NUEVO PROCESO - SILFE"
        CType(Me.dataGridOperador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTareas As ComboBox


    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtHora As TextBox
    Friend WithEvents btnCargar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAgregarOperario As Button
    Friend WithEvents dataGridOperador As DataGridView
    Friend WithEvents btnBorrarOperador As Button
    Friend WithEvents comboOperario As ComboBox
    Friend WithEvents Button1 As Button
End Class
