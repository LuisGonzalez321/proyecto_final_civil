Imports System.Data.OleDb
Public Class CBomba

    Dim bomba As Bomba

    Public Shared Function guardarBomba(bomba As Bomba)

        'comando = New OleDb.OleDbCommand("INSERT INTO Proyecto(pais, departamento, municipio, comunidad, poblacionInicial, tasaCrecimiento, dotacion, tipoFuente, elevacionPuente, elevacionTanque)" & Chr(13) &
        '                                 "VALUES (?,?,?,?,?,?,?,?,?,?)", conexion_)

        comando = New OleDb.OleDbCommand("INSERT INTO Bomba(alturaBombeo, densidadAgua, coeficienteGravedad, caudal, idProyecto, resultadoW, resultadoHP)" &
                                         "VALUES (" & bomba.AlturaBombeo1 & "," & bomba.DensidadAgua1 & "," & bomba.CoeficienteGravedad1 & "," & bomba.Caudal1 & "," & bomba.IdProyecto1 & ", '" & bomba.calcularW & "', '" & bomba.calcularHP & "')", conexion_)


        comando.Parameters.AddWithValue("@alturaBombeo", bomba.AlturaBombeo1)
        comando.Parameters.AddWithValue("@densidadAgua", bomba.DensidadAgua1)
        comando.Parameters.AddWithValue("@coeficienteGravedad", bomba.CoeficienteGravedad1)
        comando.Parameters.AddWithValue("@caudal", bomba.Caudal1)
        comando.Parameters.AddWithValue("@idProyecto", bomba.IdProyecto1)
        comando.Parameters.AddWithValue("@resultadoW", bomba.calcularW)
        comando.Parameters.AddWithValue("@resultadoHP", bomba.calcularHP)



        Try
            comando.ExecuteNonQuery()
            conexion_.Close()
            MsgBox("Se guardó la información")
        Catch ex As Exception
            MsgBox("No se ha guardado, " + ex.Message)
        End Try
    End Function

    Public Shared Function listarBomba(id As Integer) As DataTable
        comando = New OleDb.OleDbCommand("select * from Bomba where idProyecto=" & id, conexion_)
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter

        Try
            da.SelectCommand = comando
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dt
    End Function

End Class
