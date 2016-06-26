Public Class Inicio

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cmbListOperador.DataSource = dtoperador
        cmbListOperador.DisplayMember = "Nombre"
        cmbListOperador.ValueMember = "id"

    End Sub

    Private Sub btnIngreso_Click(sender As Object, e As EventArgs) Handles btnIngreso.Click

        id_operador = cmbListOperador.SelectedValue
        IniciarProceso.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        id_operador = cmbListOperador.SelectedValue
        Listado.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        id_operador = cmbListOperador.SelectedValue
        CambiarEstado.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        id_operador = cmbListOperador.SelectedValue
        Listado.ShowDialog()

    End Sub
End Class
