Public Class Listado
    Dim estadopausa As Integer = 0
    Dim estadoactivo As Integer = 0
    Private dtinforme As DataTable

    Private Sub Listado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtinforme = New DataTable

        Dim consulta As String = "Select id, cast(FechaIni as varchar(10)) + ' - ' + cast(HsIni as varchar(10)) as Fecha, detalle, estado, id_estado from Vista_procesos where id_usuario = " & id_operador

        dtinforme = conexion.ConsultaSQL(consulta).Tables(0)


        DataGrid1.DataSource = dtinforme

        'DataGrid1.Columns(0).Width = 100
        'DataGrid1.Columns(2).Visible = False
        'DataGrid1.Columns(3).Visible = False
        'DataGrid1.Columns(4).Visible = False
        'DataGrid1.Columns(5).Visible = False
        'DataGrid1.Columns(6).Visible = False
        'DataGrid1.Columns(8).Visible = False

        DataGrid1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        DataGrid1.RowHeadersVisible = False
        DataGrid1.AllowUserToAddRows = False


        CambiarColorData()


    End Sub

    Private Sub CambiarColorData()


        txtProcActivo.Text = estadoactivo.ToString
        txtProcPausa.Text = estadopausa.ToString

    End Sub

    Private Sub DataGrid1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGrid1.CellFormatting


        For Each fila As DataGridViewRow In DataGrid1.Rows
            If fila.Cells("id_estado").Value = "1" Then
                fila.DefaultCellStyle.BackColor = Color.Green
            ElseIf fila.Cells("id_estado").Value = "2" Then
                fila.DefaultCellStyle.BackColor = Color.Yellow
            Else
                fila.DefaultCellStyle.BackColor = Color.Red

            End If

        Next

    End Sub
End Class