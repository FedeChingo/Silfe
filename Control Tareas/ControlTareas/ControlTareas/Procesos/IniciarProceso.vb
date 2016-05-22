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
        cmbListOperario.DataSource = listOpeario        'ASIGNO LAS PROPIEDADES
        cmbListOperario.ValueMember = "id"
        cmbListOperario.DisplayMember = "usuario"

        'COLOCAR FECHA Y HORA EN LOS TEXTBOX
        txtFecha.Text = Format(Now(), "dd/mm/yy")
        txtHora.Text = Format(Now(), "hh:mm tt")

        'CARGO EL DATAGRIDVIEW
        ArmarDataUsuario()

    End Sub

    Private Sub AgregarOperador()
        Dim newCustomersRow As DataRow = dtUsuario.NewRow()

        newCustomersRow("id") = cmbListOperario.SelectedValue
        newCustomersRow("user") = DirectCast(cmbListOperario.SelectedItem, DataRowView).Item("usuario").ToString()


        dtUsuario.Rows.Add(newCustomersRow)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        AgregarOperador()
        dataGridOperador.Update()

    End Sub


End Class