


Public Class CambiarEstado

    Dim dtprocesos As DataTable


    Private Sub CambiarEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtFechaFin.Focus()


        dtprocesos = New DataTable

        Dim consultasql As String = "SELECT id, cast(FechaIni as varchar(10)) + ' ---- ' + detalle as Detalle1, id_usuario, fechaini, fechafin, hsini, hsfin, cantidad, Notas, id_estado  FROM vista_procesos WHERE id_usuario = " & id_operador & " and id_estado <> '3'  Order by FechaIni"

        dtprocesos = conexion.ConsultaSQL(consultasql)

        comboProcesos.DataSource = dtprocesos
        comboProcesos.DisplayMember = "Detalle1"
        comboProcesos.ValueMember = "id_estado"


    End Sub


    Private Sub CargarDatos(ByRef ID)

        txtDescripcion.Text = "ID Proceso: " & dtprocesos.Rows(ID).Item("id") & vbCrLf &
                               "Proceso iniciado el dia: " & dtprocesos.Rows(ID).Item("fechaini") & vbCrLf &
                              "Hora Inicio: " & dtprocesos.Rows(ID).Item("hsini").ToString

        txtDescripcion.ReadOnly = True

        txtFechaFin.Text = Format(Now(), "dd/MM/yy")
        txtHsFin.Text = Format(Now(), "hh:mm tt")
        txtCantidad.Text = ""

        comboEstado.SelectedIndex = 1
    End Sub

    Private Sub comboProcesos_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboProcesos.SelectedValueChanged
        CargarDatos(comboProcesos.SelectedIndex)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        'VALIDAR FECHA
        If IsDate(txtFechaFin.Text) = False Then
            MsgBox("Fecha No válida", vbCritical, "SIL-FE")
            Exit Sub
        Else
            txtFechaFin.Text = CDate(txtFechaFin.Text)
        End If

        'VALIDAR LA HORA 
        If IsDate(txtHsFin.Text) = False Then
            MsgBox("Hora No válida", vbCritical, "SIL-FE")
            Exit Sub
        Else
            txtHsFin.Text = CDate(txtHsFin.Text)
        End If

        Dim EstadoCombo As Integer

        If comboEstado.SelectedIndex = 0 Then
            EstadoCombo = 1
        ElseIf comboestado.SelectedIndex = 1 Then
            EstadoCombo = 2
        Else
            EstadoCombo = 3
        End If

        If txtCantidad.Text = "" Then
            txtCantidad.Text = "0"
        End If

        Dim cadena As String = "UPDATE ProcesoEstado   SET   HsFin = '" & txtHsFin.Text & "', " &
                                              "FechaFin = '" & txtFechaFin.Text & "', " &
                                              "id_estado = " & EstadoCombo & ", " &
                                              "cantidad = " & txtCantidad.Text & ", " &
                                              "Notas = '.'" & txtNotas.Text &
                                              " Where id =  " & dtprocesos.Rows(comboProcesos.SelectedIndex).Item("id")

        If conexion.ActualizarSQL(cadena) Then
            MsgBox("Se actualizo el Proceso")
            Me.Close()
        Else
            MsgBox("Error")
        End If

    End Sub

End Class