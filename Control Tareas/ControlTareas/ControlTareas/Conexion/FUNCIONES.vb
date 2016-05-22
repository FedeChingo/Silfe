Module FUNCIONES

    Function ListadoTarea() As DataTable

        Return conexion.ConsultaSQL("Select * from Tarea order by detalle").Tables(0)

    End Function

    Function ListadoOperario() As DataTable

        Return conexion.ConsultaSQL("Select * from usuario order by usuario").Tables(0)

    End Function
End Module
