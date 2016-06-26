Public Class Listado

    Dim dtListado As DataTable

    Private Sub CargarDataListado()
        dtListado = New DataTable

        dtListado = ConsultaSQL("select * from vista_proceso_usuario where iduser = " & id_operador)

        dataListado.DataSource = dtListado



    End Sub

    Private Sub Listado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarDataListado()


    End Sub

    Private Sub DataGrid1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)


        For Each fila As DataGridViewRow In datalistado.Rows
            If fila.Cells("estado").Value = "iniciado" Then
                fila.DefaultCellStyle.BackColor = Color.Green
            ElseIf fila.Cells("estado").Value = "Pausado" Then
                fila.DefaultCellStyle.BackColor = Color.Yellow
            Else
                fila.DefaultCellStyle.BackColor = Color.Red
            End If

        Next

    End Sub

    Private Sub btnNuevoProceso_Click(sender As Object, e As EventArgs) Handles btnNuevoProceso.Click

        Dim frm As New IniciarProceso

        frm.ShowDialog()



    End Sub
End Class