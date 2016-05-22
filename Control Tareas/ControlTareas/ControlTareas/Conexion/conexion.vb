Imports System.Data.SqlClient


Module conexion

    Private cadenaconexion As String = "Data Source=SILFE-PC\SQLEXPRESS;Initial Catalog=SILFE_2;Persist Security Info=True;User ID=sa;Password=Fede7122"


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

    Public Function ActualizarSQL(ByRef sql As String) As Boolean

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
            ' MsgBox("Se realizó la actualización con éxito")
            Return True
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return False
        End Try

    End Function

End Module
