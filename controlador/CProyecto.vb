
Imports System.Data.OleDb

Public Class CProyecto

    Public Shared Function guardarProyecto(proyecto As Proyecto)

        'comando = New OleDb.OleDbCommand("INSERT INTO Proyecto(pais, departamento, municipio, comunidad, poblacionInicial, tasaCrecimiento, dotacion, tipoFuente, elevacionPuente, elevacionTanque)" & Chr(13) &
        '                                 "VALUES (?,?,?,?,?,?,?,?,?,?)", conexion_)

        comando = New OleDb.OleDbCommand("INSERT INTO Proyecto(pais, departamento, municipio, comunidad, poblacionInicial, tasaCrecimiento, dotacion, tipoFuente, elevacionPuente, elevacionTanque)" &
                                         "VALUES ('" & proyecto.Pais1 & "','" & proyecto.Departamento1 & "','" & proyecto.Municipio1 & "','" & proyecto.Comunidad1 & "'," & proyecto.PoblacionInicial1 & "," & proyecto.TasaCrecimiento1 & "," & proyecto.Dotacion1 & "," & proyecto.TipoFuente1 & "," & proyecto.ElevacionPuente1 & "," & proyecto.ElevacionTanque1 & ")", conexion_)


        comando.Parameters.AddWithValue("@pais", proyecto.Pais1)
        comando.Parameters.AddWithValue("@departamento", proyecto.Departamento1)
        comando.Parameters.AddWithValue("@municipio", proyecto.Municipio1)
        comando.Parameters.AddWithValue("@comunidad", proyecto.Comunidad1)
        comando.Parameters.AddWithValue("@poblacionInicial", proyecto.PoblacionInicial1)
        comando.Parameters.AddWithValue("@tasaCrecimiento", proyecto.TasaCrecimiento1)
        comando.Parameters.AddWithValue("@dotacion", proyecto.Dotacion1)
        comando.Parameters.AddWithValue("@tipoFuente", proyecto.TipoFuente1)
        comando.Parameters.AddWithValue("@elevacionPuente", proyecto.ElevacionPuente1)
        comando.Parameters.AddWithValue("@elevacionTanque", proyecto.ElevacionTanque1)

        Try
            comando.ExecuteNonQuery()
            conexion_.Close()
            MsgBox("Se guardó xd")
        Catch ex As Exception
            MsgBox("No se ha guardado, " + ex.Message)
        End Try
    End Function

    Public Shared Function listarProyectos() As DataTable
        comando = New OleDb.OleDbCommand("select * from Proyecto", conexion_)
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
