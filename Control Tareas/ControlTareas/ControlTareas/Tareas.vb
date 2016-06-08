Public Class Tareas

    Private dttareas As DataTable


    Private Sub armarData()

        dttareas = New DataTable

        'dttareas = ListadoProcesos(" where id_usuario = " & id_operador)

        DataGridTareas.DataSource = dttareas


        For Each Row As DataGridViewRow In DataGridTareas.Rows

            If Row.Cells("EstadoTarea").Value = "1" Then
                Row.DefaultCellStyle.BackColor = Color.Green
            ElseIf Row.Cells("EstadoTarea").Value = "2" Then
                Row.DefaultCellStyle.BackColor = Color.Yellow
            End If
        Next


        DataGridTareas.Columns(0).Width = 50
        DataGridTareas.Columns(0).HeaderText = "ID"
        DataGridTareas.Columns(1).Width = 100
        DataGridTareas.Columns(0).HeaderText = "HS."

        DataGridTareas.Columns(2).Width = 100
        DataGridTareas.Columns(4).Width = 100
        DataGridTareas.Columns(4).Width = 100

    End Sub



    Private Sub Tareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        armarData()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IniciarProceso.Show()

    End Sub
End Class