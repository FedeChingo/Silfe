Public Class ClaseProceso

    Public Property id As String
    Public Property id_tarea As String
    Public Property fecha_inicio As Date
    Public Property fecha_fin As Date
    Public Property id_estado As String
    Public Property cantidad As String
    Public Property notas As String



                Public Sub CargarProceso()

        Try
            Dim cadena1 As String = "INSERT INTO procesos (id_tarea, cantidad, notas, fecha_inicio, fecha_fin, id_estado)" &
                                " VALUES ('" & id_tarea & "','" & cantidad & "','" & notas & "','" & fecha_inicio & "','" & fecha_fin & "','" & id_estado & "')"



        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Public Sub CargarProcUsuario(ByRef User As String)

        Dim cadena2 As String = "INSERT INTO procesos_usuarios (id_proceso, id_usuario, fecha_inicio, fecha_fin, id_estado)" &
                                "values ('" & id & "','" & User & "','" & fecha_inicio & "','" & fecha_fin & "','" & id_estado & "')"

    End Sub


End Class
