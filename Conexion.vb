Imports System.Data.OleDb

Module Conexion

    Public conexion_ As New OleDbConnection
    Public estado As String
    Public comando As New OleDbCommand

    Sub enlace()
        Try
            conexion_.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\lgabr\source\repos\proyecto_final_civil\proyecto_civil.accdb"
            conexion_.Open()
            estado = "conectado"
            MsgBox(estado)
        Catch ex As Exception
            estado = "desconectado"
            MsgBox(estado & "" & ex.Message)
        End Try
    End Sub

End Module
