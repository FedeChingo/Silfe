Module FUNCIONES

    Function ListadoTarea() As DataTable

        'tareas: son las tareas de los procesos.
        Return conexion.ConsultaSQL("Select * from tareas order by detalle").Tables(0)

    End Function

    Function ListadoOperario() As DataTable

        Return conexion.ConsultaSQL("Select * from operador order by operador").Tables(0)

    End Function

    Function CargarProceso(ByVal id_tarea As String, ByVal cantidad As String, ByVal notas As String) As String

        Try
            Dim cadena As String = "INSERT INTO procesos (detalle, cantidad, notas)" &
                                " VALUES ('" & id_tarea & "','" & cantidad & "','" & notas & "')"
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
            Return ""
        End Try

    End Function

    Function CargaProcesoEstado(ByVal id_proceso As String, ByVal id_usuario As String, ByVal Hora As String, ByVal fecha As String, ByVal estado As String, ByVal notas As String) As String
        Try
            Dim cadena As String = "INSERT INTO ProcesoEstado(id_proceso, id_usuario, Hs, fecha, estado, notas)" &
                                " VALUES ('" & id_proceso & "','" & id_usuario & "','" & Hora & "','" & fecha & "','" & estado & "','" & notas & "')"
            Return cadena
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return ""
        End Try


    End Function

    Function UltimoRegistro(ByVal columna As String, ByVal tabla As String) As Integer

        Return conexion.ConsultaSQL("SELECT TOP(1) " & columna & " FROM " & tabla & " ORDER BY " & columna & " DESC ").Tables(0).Rows(0).Item(0)

    End Function




End Module
