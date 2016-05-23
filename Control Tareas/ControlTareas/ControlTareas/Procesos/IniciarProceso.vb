Public Class IniciarProceso


    Private ListTarea As DataTable 'VARIABLE PARA GUARDAR LAS TAREAS
    Private listOpeario As DataTable 'VARIABLE PARA GUARDAR LOS OPERARIOS

    Private dtUsuario As DataTable = New DataTable 'VARIABLE PARA GUARDAR LOS DATOS DE LOS USUARIOS

    Private Sub ArmarDataUsuario()


        'ARMO LAS COLUMNAS     
        dtUsuario.Columns.Add("id")
        dtUsuario.Columns.Add("user")

        'VINCULO EL DATATABLE AL DATAGRIDVIEW
        dataGridOperador.DataSource = dtUsuario

        'CONFIGURO TAMAÑO DE LAS COLUMNAS
        dataGridOperador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataGridOperador.Columns(0).Width = 75


    End Sub

    Private Sub IniciarProceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'CARGO EL COMBO BOX CON LAS TAREAS. LLAMO A LA FUNCION LISTADOTAREA
        ListTarea = FUNCIONES.ListadoTarea
        cmbTareas.DataSource = ListTarea 'ASIGNO LAS PROPIEDADES
        cmbTareas.ValueMember = "id"
        cmbTareas.DisplayMember = "detalle"


        'CARGO EL COMBO BOX CON LOS USUARIOS. LLAMO A LA FUNCION LISTADOUSUARIO
        listOpeario = FUNCIONES.ListadoOperario
        cmbListOperario.DataSource = dtoperador        'ASIGNO LAS PROPIEDADES
        cmbListOperario.ValueMember = "id"
        cmbListOperario.DisplayMember = "usuario"

        'COLOCAR FECHA Y HORA EN LOS TEXTBOX
        txtFecha.Text = Format(Now(), "dd/MM/yy")
        txtHora.Text = Format(Now(), "hh:mm tt")

        'CARGO EL DATAGRIDVIEW
        ArmarDataUsuario()

        CambiarColorBoton()

    End Sub

    Private Sub AgregarOperador()
        Dim newCustomersRow As DataRow = dtUsuario.NewRow()

        newCustomersRow("id") = cmbListOperario.SelectedValue
        newCustomersRow("user") = DirectCast(cmbListOperario.SelectedItem, DataRowView).Item("usuario").ToString()


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


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

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

        'CALCULO EL ULTIMO REGISTRO
        Dim UltimoRegistro As Integer = FUNCIONES.UltimoRegistro("id_proceso", "proceso") + 1

        conexion.ActualizarSQL(FUNCIONES.CargarProceso(UltimoRegistro, id_tarea, txtHora.Text, "00:00", txtFecha.Text, txtFecha.Text, 0, 1))

        For i As Integer = 0 To (dtUsuario.Rows.Count - 1)
            Dim usuario = dtUsuario.Rows(i).Item("id")

            conexion.ActualizarSQL(FUNCIONES.CargarProcesoUsuario(UltimoRegistro, usuario, txtHora.Text, "00:00", txtFecha.Text, txtFecha.Text, "0"))
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dtUsuario.Clear()
        dataGridOperador.Refresh()
        CambiarColorBoton()


    End Sub
End Class