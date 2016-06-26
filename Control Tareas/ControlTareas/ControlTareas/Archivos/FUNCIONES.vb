Module FUNCIONES

    Function ListadoTarea() As DataTable

        'tareas: son las tareas de los procesos.
        Return conexion.ConsultaSQL("Select * from tareas order by Nombre")

    End Function

    Function ListadoOperario() As DataTable

        Return conexion.ConsultaSQL("Select * from usuarios order by nombre")

    End Function

    Function CargarProceso(ByVal id_tarea As String, ByVal cantidad As String, ByVal notas As String, ByVal fechaini As String, ByVal fechafin As String, ByVal estado As String) As String

        Try
            Dim cadena As String = "INSERT INTO procesos (id_tarea, cantidad, notas, fecja_inicio, fecha_fin, id_estado)" &
                                " VALUES ('" & id_tarea & "','" & cantidad & "','" & notas & "','" & fechaini & "','" & fechafin & "','" & estado & "')"
            Return cadena
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return ""
        End Try

    End Function

    Function CargaUsuario(ByVal id_proceso As String, ByVal id_usuario As String, ByVal notas As String, ByVal cantidad As String) As String
        Try
            Dim cadena As String = "INSERT INTO ProcesoUsuario (id_proceso, id_usuario, notas, cantidad)" &
                                " VALUES ('" & id_proceso & "','" & id_usuario & "','" & notas & "','" & cantidad & "')"
            Return cadena
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return ex.ToString
        End Try

    End Function

    Function CargaProcesoEstado(ByVal id_proceso As String, ByVal id_usuario As String, ByVal fecha_fin As Date, ByVal fecha_inicio As Date, ByVal id_estado As String, ByVal notas As String) As String
        Try
            Dim cadena As String = "INSERT INTO Procesos_usuarios(id_proceso, id_usuario, fecha_fin, fecha_incio, id_estado, notas)" &
                                " VALUES ('" & id_proceso & "','" & id_usuario & "','" & fecha_fin & "','" & fecha_inicio & "','" & id_estado & "','" & notas & "')"
            Return cadena
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return ex.ToString
        End Try


    End Function

    Function UltimoRegistro(ByVal columna As String, ByVal tabla As String) As Integer
        Try
            Return conexion.ConsultaSQL("SELECT TOP(1) " & columna & " FROM " & tabla & " ORDER BY " & columna & " DESC ").Rows(0).Item(0)

        Catch ex As Exception
            Return 0

        End Try

    End Function




End Module
