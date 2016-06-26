Public Class IniciarProceso


    Private ListTarea As DataTable 'VARIABLE PARA GUARDAR LAS TAREAS
    Private listOpeario As DataTable 'VARIABLE PARA GUARDAR LOS OPERARIOS

    Private dtUsuario As DataTable 'VARIABLE PARA GUARDAR LOS DATOS DE LOS USUARIOS}

    Private user As ClaseUsuario = New ClaseUsuario
    Private proc As ClaseProceso = New ClaseProceso

    Private Sub IniciarProceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'CARGO EL COMBO BOX CON LAS TAREAS. LLAMO A LA FUNCION LISTADOTAREA
        ListTarea = FUNCIONES.ListadoTarea
        cmbTareas.DataSource = ListTarea 'ASIGNO LAS PROPIEDADES
        cmbTareas.ValueMember = "id"
        cmbTareas.DisplayMember = "Nombre"

        'CARGO EL COMBO BOX CON LOS USUARIOS. LLAMO A LA FUNCION LISTADOUSUARIO

        comboOperario.DataSource = dtoperador
        comboOperario.DisplayMember = "Nombre"
        comboOperario.ValueMember = "id"

        comboOperario.SelectedValue = id_operador

        'COLOCAR FECHA Y HORA EN LOS TEXTBOX
        txtFecha.Text = Format(Now(), "dd/MM/yy")
        txtHora.Text = Format(Now(), "hh:mm tt")

        'CARGO EL DATAGRIDVIEW
        ArmarDataUsuario()
        CambiarColorBoton()

        AgregarOperador()

    End Sub

    Private Sub ArmarDataUsuario()

        dtUsuario = New DataTable
        'ARMO LAS COLUMNAS     
        dtUsuario.Columns.Add("id")
        dtUsuario.Columns.Add("user")
        dtUsuario.Clear()
        'VINCULO EL DATATABLE AL DATAGRIDVIEW
        dataGridOperador.DataSource = dtUsuario

        dataGridOperador.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        dataGridOperador.Columns(0).Width = 60
        dataGridOperador.Columns(0).ReadOnly = True

        dataGridOperador.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dataGridOperador.Columns(1).ReadOnly = True

    End Sub

    Private Sub AgregarOperador()
        Dim newCustomersRow As DataRow = dtUsuario.NewRow()

        newCustomersRow("id") = comboOperario.SelectedValue
        newCustomersRow("user") = DirectCast(comboOperario.SelectedItem, DataRowView).Item("Nombre").ToString()

        dtUsuario.Rows.Add(newCustomersRow)

        CambiarColorBoton()

    End Sub

    Private Sub CambiarColorBoton()
        If dtUsuario.Rows.Count > 0 Then
            btnCargar.Enabled = True
            btnCargar.BackColor = Color.Green
        Else
            btnCargar.Enabled = False
            btnCargar.BackColor = Color.Red
        End If
    End Sub

    Private Sub btnAgregarOperario_Click(sender As Object, e As EventArgs) Handles btnAgregarOperario.Click
        AgregarOperador()
        dataGridOperador.Update()
    End Sub

    Private Sub btnBorrarOperador_Click(sender As Object, e As EventArgs) Handles btnBorrarOperador.Click
        dtUsuario.Clear()
        dataGridOperador.Refresh()
        CambiarColorBoton()
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click

        Try
            proc.id_estado = "1"
            proc.id_tarea = cmbTareas.SelectedValue
            proc.fecha_inicio = CDate(txtFecha.Text + " " + txtHora.Text)
            proc.cantidad = "0"
            proc.notas = ""

            proc.CargarProceso()

            'Busco y guardo el ID del proceso cargado recientemente.

            proc.id = FUNCIONES.UltimoRegistro("id", "procesos")

            For i As Integer = 0 To (dtUsuario.Rows.Count - 1)

                Dim usuario = dtUsuario.Rows(i).Item("id")
                proc.CargarProcUsuario(usuario)

            Next
        Catch ex As Exception

        End Try









    End Sub
End Class