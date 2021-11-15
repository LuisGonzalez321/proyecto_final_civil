Imports System.Data.OleDb

Module Conexion

    Public conexion_ As New OleDbConnection
    Public estado As String
    Public comando As New OleDbCommand

    Dim fileReader As String


    Sub enlace()
        Try

            conexion_.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=D:\proyecto_civil.accdb"
            conexion_.Open()
            estado = "Conectado con la base de datos"
            MsgBox(estado)
        Catch ex As Exception
            estado = "desconectado"
            MsgBox(estado & "" & ex.Message)
        End Try
    End Sub

End Module
