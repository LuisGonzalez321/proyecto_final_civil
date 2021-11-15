Imports System.Data.OleDb
Public Class CProyeccion


    Public Shared Sub guargarProyeccion(proyeccion As MProyeccion)
        comando = New OleDb.OleDbCommand("INSERT INTO Proyeccion(perdidasTecnicas, consumoPublico, consumoComercial, consumoIndustrial, almacenamiento, factorCMD, factorCMH, IdProyecto, año, poblacion, CPD, CPD20, CPDSP, CPDT, CPDTLPS, 1Dia, LPS, m3dia, GPM, 1Dia_, LPS_, m3dia_, GMP_, Galones, m3) VALUES (" & proyeccion.PerdidasTecnicas1 & ", " & proyeccion.ConsumoPublico1 & "," & proyeccion.ConsumoComercial1 & "," & proyeccion.ConsumoIndustrial1 & "," & proyeccion.Almacenamiento1 & "," & proyeccion.FactorCMD1 & "," & proyeccion.FactorCMH1 & ", " & proyeccion.IdProyecto1 & "," & proyeccion.Año1 & ", " & proyeccion.Poblacion1 & ", " & proyeccion.CPD1 & ", " & proyeccion.CPD201 & ", " & proyeccion.CPDSP1 & ", " & proyeccion.CPDT1 & "," & proyeccion.CPDTLPS1 & "," & proyeccion.Dia11 & ", " & proyeccion.LPS1 & ", " & proyeccion.M3dia1 & ", " & proyeccion.GPM1 & ", " & proyeccion.Dia1_1 & ", " & proyeccion.LPS_1 & ", " & proyeccion.M3dia_1 & ", " & proyeccion.GMP_1 & ", " & proyeccion.Galones1 & ", " & proyeccion.M31 & ")", conexion_)



        comando.Parameters.AddWithValue("@perdidasTecnicas", proyeccion.PerdidasTecnicas1)
        comando.Parameters.AddWithValue("@consumoPublico", proyeccion.ConsumoPublico1)
        comando.Parameters.AddWithValue("@consumoComercial", proyeccion.ConsumoComercial1)
        comando.Parameters.AddWithValue("@consumoIndustrial", proyeccion.ConsumoIndustrial1)
        comando.Parameters.AddWithValue("@almacenamiento", proyeccion.Almacenamiento1)
        comando.Parameters.AddWithValue("@factorCMD", proyeccion.FactorCMD1)
        comando.Parameters.AddWithValue("@factorCMH", proyeccion.FactorCMH1)
        comando.Parameters.AddWithValue("@IdProyecto", proyeccion.IdProyecto1)

        comando.Parameters.AddWithValue("@año", proyeccion.Año1)
        comando.Parameters.AddWithValue("@poblacion", proyeccion.Poblacion1)
        comando.Parameters.AddWithValue("@CPD", proyeccion.CPD1)
        comando.Parameters.AddWithValue("@CPD20", proyeccion.CPD201)
        comando.Parameters.AddWithValue("@CPDSP", proyeccion.CPDSP1)
        comando.Parameters.AddWithValue("@CPDT", proyeccion.CPDT1)
        comando.Parameters.AddWithValue("@CPDTLPS", proyeccion.CPDTLPS1)
        comando.Parameters.AddWithValue("@1Dia", proyeccion.Dia11)
        comando.Parameters.AddWithValue("@LPS", proyeccion.LPS1)
        comando.Parameters.AddWithValue("@m3dia", proyeccion.M3dia1)
        comando.Parameters.AddWithValue("@GPM", proyeccion.GPM1)
        comando.Parameters.AddWithValue("@1Dia_", proyeccion.Dia1_1)
        comando.Parameters.AddWithValue("@LPS_", proyeccion.LPS_1)
        comando.Parameters.AddWithValue("@m3dia_", proyeccion.M3dia_1)
        comando.Parameters.AddWithValue("@GMP_", proyeccion.GMP_1)
        comando.Parameters.AddWithValue("@Galones", proyeccion.Galones1)
        comando.Parameters.AddWithValue("@m3", proyeccion.M31)


        Try
            comando.ExecuteNonQuery()
            conexion_.Close()
            MsgBox("Se guardó la información")
        Catch ex As Exception
            MsgBox("No se ha guardado, " + ex.Message)
        End Try
    End Sub

    Public Shared Function listarProyecciones(id As Integer) As DataTable
        comando = New OleDb.OleDbCommand("select * from Proyeccion where IdProyecto=" & id, conexion_)
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
