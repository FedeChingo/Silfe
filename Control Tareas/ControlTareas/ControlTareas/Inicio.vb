Public Class Inicio

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cmbListOperador.DataSource = dtoperador
        cmbListOperador.DisplayMember = "Operador"
        cmbListOperador.ValueMember = "id"

    End Sub

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click
        id_operador = cmbListOperador.SelectedValue
        'MsgBox(cmbListOperador.SelectedItem)
        'MsgBox(cmbListOperador.SelectedValue)

        'Listado.ShowDialog()
        'Tareas.Show()
        IniciarProceso.Show()

    End Sub
End Class
