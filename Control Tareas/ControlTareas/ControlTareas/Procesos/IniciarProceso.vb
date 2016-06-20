Public Class IniciarProceso


    Private ListTarea As DataTable 'VARIABLE PARA GUARDAR LAS TAREAS
    Private listOpeario As DataTable 'VARIABLE PARA GUARDAR LOS OPERARIOS

    Private dtUsuario As DataTable 'VARIABLE PARA GUARDAR LOS DATOS DE LOS USUARIOS

    Private Sub IniciarProceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'CARGO EL COMBO BOX CON LAS TAREAS. LLAMO A LA FUNCION LISTADOTAREA
        ListTarea = FUNCIONES.ListadoTarea
        cmbTareas.DataSource = ListTarea 'ASIGNO LAS PROPIEDADES
        cmbTareas.ValueMember = "id"
        cmbTareas.DisplayMember = "detalle"

        'CARGO EL COMBO BOX CON LOS USUARIOS. LLAMO A LA FUNCION LISTADOUSUARIO

        comboOperario.DataSource = dtoperador
        comboOperario.DisplayMember = "Operador"
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
        newCustomersRow("user") = DirectCast(comboOperario.SelectedItem, DataRowView).Item("Operador").ToString()

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

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        'VALIDAR LA HORA 
        If IsDate(txtHora.Text) = False Then
            MsgBox("Hora No válida", vbCritical, "SIL-FE")
            Exit Sub
        Else
            txtHora.Text = CDate(txtHora.Text)
        End If

        'VALIDAR ID_TAREA Y CREO VARIABLE PARA GUARDAR
        Dim id_tarea As Integer = cmbTareas.SelectedValue

        'VALIDAR FECHA
        If IsDate(txtFecha.Text) = False Then
            MsgBox("Fecha No válida", vbCritical, "SIL-FE")
            Exit Sub
        Else
            txtFecha.Text = CDate(txtFecha.Text)
        End If


        If conexion.ActualizarSQL(FUNCIONES.CargarProceso(id_tarea, 0, "", txtFecha.Text, "", "1")) = False Then
            MsgBox("Error primera carga")
            Exit Sub
        End If

        'id proceso cargado 

        Dim UltimoRegistro As Integer = FUNCIONES.UltimoRegistro("id", "procesos")

        For i As Integer = 0 To (dtUsuario.Rows.Count - 1)
            Dim usuario = dtUsuario.Rows(i).Item("id")

            'conexion.ActualizarSQL(FUNCIONES.CargaUsuario(UltimoRegistro, usuario, "", 0))

            If conexion.ActualizarSQL(FUNCIONES.CargaProcesoEstado(UltimoRegistro, usuario, txtHora.Text, txtFecha.Text, "1", "", "00:00", "", 0)) Then
                MsgBox("Se cargo el proceso", MsgBoxStyle.Information)
                Me.Close()
            Else
                MsgBox("Error segunda carga")

            End If

        Next

    End Sub

    Private Sub btnBorrarOperador_Click(sender As Object, e As EventArgs) Handles btnBorrarOperador.Click
        dtUsuario.Clear()
        dataGridOperador.Refresh()
        CambiarColorBoton()
    End Sub

    '--------------------------------------------------------------------------------------------------------------'

End Class