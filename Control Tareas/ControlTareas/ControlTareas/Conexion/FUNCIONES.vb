Module FUNCIONES

    Function ListadoTarea() As DataTable

        Return conexion.ConsultaSQL("Select * from tarea order by detalle").Tables(0)

    End Function

    Function ListadoOperario() As DataTable

        Return conexion.ConsultaSQL("Select * from usuario order by usuario").Tables(0)

    End Function

    Function CargarProceso(ByVal id_proceso As String, ByVal id_actividad As String, ByVal hora_inicio As String, ByVal hora_fin As String,
                           ByVal fecha_inicio As Date, ByVal fecha_fin As Date, ByVal cantidad As String, ByVal estado As String) As String


        Dim cadena As String = "INSERT INTO proceso (id_proceso, id_tarea, horainicio, horafin, fechainicio, fechafin, cantidad, estado)" &
                                " VALUES ('" & id_proceso & "','" & id_actividad & "','" & hora_inicio & "','" & hora_fin & "'," &
                                "'" & fecha_inicio & "','" & fecha_fin & "','" & cantidad & "','" & estado & "')"

        Return cadena


    End Function

    Function CargarProcesoUsuario(ByVal id_proceso As String, ByVal id_usuario As String, ByVal hora_inicio As String, ByVal hora_fin As String, ByVal fecha_incio As String, ByVal fecha_fin As String, ByVal cantidad As String) As String

        Dim cadena As String = "INSERT INTO ProcesoUsuario (id_proceso, id_usuario, horainicio, horafin, fechainicio, fechafin, cantidad)" &
                                " VALUES ('" & id_proceso & "','" & id_usuario & "','" & hora_inicio & "','" & hora_fin & "','" & fecha_incio & "','" & fecha_fin & "','" & cantidad & "')"
        Return cadena
    End Function

    Function UltimoRegistro(ByVal columna As String, ByVal tabla As String) As Integer

        Return conexion.ConsultaSQL("SELECT TOP(1) " & columna & " FROM " & tabla & " ORDER BY " & columna & " DESC ").Tables(0).Rows(0).Item(0)

    End Function
End Module
