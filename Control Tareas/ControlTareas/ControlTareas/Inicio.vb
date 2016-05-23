Public Class Inicio



    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtoperador = New DataTable
        dtoperador = FUNCIONES.ListadoOperario

        cmbListOperador.DataSource = dtoperador
        cmbListOperador.DisplayMember = "usuario"
        cmbListOperador.ValueMember = "id"

    End Sub


End Class
