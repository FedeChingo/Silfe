Imports System.Data.SqlClient


Module conexion

    Public cadenaconexion As String = "Data Source=SILFE-PC\SQLEXPRESS;Initial Catalog=SILFE_2;Persist Security Info=True;User ID=sa;Password=Fede7122"


    Public Function ConsultaSQL(ByRef consulta As String) As DataSet

        Dim cnn As New SqlConnection
        Dim sql As String
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim rt As New DataSet

        Try
            sql = consulta
            cnn = New SqlConnection(cadenaconexion)
            cnn.Open()
            da = New SqlDataAdapter(sql, cnn)
            da.Fill(ds)
            cnn.Close()
            ConsultaSQL = ds

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return rt
        End Try

    End Function

    Sub ActualizarSQL(ByRef sql As String)

        Dim cnn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New Data.DataSet

        Try
            ds.Clear()
            cnn = New SqlConnection(cadenaconexion)
            cnn.Open()
            da = New SqlDataAdapter(sql, cnn)
            da.Fill(ds)
            cnn.Close()
            MsgBox("Se realizó la actualización con éxito")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try

    End Sub

End Module
