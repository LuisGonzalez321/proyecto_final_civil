Imports System.Data.OleDb

Public Class CCalidadAgua

    Dim cantidadA As Integer
    Dim cantidadB As Integer


    Public Function Oxigeno(valor As Double)
        If valor < 4 Then
            cantidadA += 1
            Return "CA"
        Else
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function demanda(valor As Double)
        If valor > 0 And valor <= 2 Then
            cantidadA += 1
            Return "CA"

        ElseIf valor > 5 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function ph(valor As Double)
        If valor >= 6 And valor <= 8.5 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor > 8.5 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function colorReal(valor As Double)
        If valor <= 15 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor > 15 And valor < 150 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function turbiedad(valor As Double)
        If valor <= 5 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor > 5 And valor < 250 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function fluoruros(valor As Double)
        If valor >= 0.7 And valor <= 1.5 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor <= 1.7 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function hierroTotal(valor As Double)
        If valor = 0.3 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor = 3 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function mercurioTotal(valor As Double)
        If valor = 0.001 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor = 0.01 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function plomoTotal(valor As Double)
        If valor = 0.01 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor = 0.05 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function solidosTotales(valor As Double)
        If valor = 1000 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor = 1500 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function sulfatos(valor As Double)
        If valor = 250 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor = 400 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function zinc(valor As Double)
        If valor = 3 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor = 5 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function cloruros(valor As Double)
        If valor = 250 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor = 600 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function tipoCalidadAgua(mcalidad As MCalidadAgua) As String
        Oxigeno(mcalidad.OxigenoDisuelto1)
        demanda(mcalidad.Demanda1)
        ph(mcalidad.Ph1)
        colorReal(mcalidad.ColorReal1)
        turbiedad(mcalidad.Turbiedad1)
        fluoruros(mcalidad.Fluoruros1)
        hierroTotal(mcalidad.HierroTotal1)
        mercurioTotal(mcalidad.Mercurio1)
        plomoTotal(mcalidad.PlomoTotal1)
        solidosTotales(mcalidad.SolidosTotalesDisueltos1)
        sulfatos(mcalidad.Sulfatos1)
        zinc(mcalidad.Zinc1)
        cloruros(mcalidad.Cloruros1)
        If cantidadA > cantidadB Then
            Return "CA"
        Else
            Return "CB"
        End If
    End Function

    Public Function guardarCalidadAgua(calidad As MCalidadAgua)
        comando = New OleDb.OleDbCommand("INSERT INTO CalidadAgua(Categoria, OxigenoDisuelto, demanda, ph, colorReal, turbiedad, fluoruros, hierroTotal, mercurio, plomoTotal, solidosTotalesDisueltos, sulfatos, zinc, cloruros, organismosColif, idProyecto)" &
                                         "VALUES (" & calidad.Categoria1 & "," & calidad.OxigenoDisuelto1 & "," & calidad.Demanda1 & "," & calidad.Ph1 & "," & calidad.ColorReal1 & ", " & calidad.Turbiedad1 & "," & calidad.Fluoruros1 & ", " & calidad.HierroTotal1 & "," & calidad.Mercurio1 & "," & calidad.PlomoTotal1 & ", " & calidad.SolidosTotalesDisueltos1 & ", " & calidad.Sulfatos1 & "," & calidad.Zinc1 & "," & calidad.Cloruros1 & ", " & calidad.OrganismosColif1 & ", " & calidad.IdProyecto1 & ")", conexion_)

        comando.Parameters.AddWithValue("@Categoria", calidad.Categoria1)
        comando.Parameters.AddWithValue("@OxigenoDisuelto", calidad.OxigenoDisuelto1)
        comando.Parameters.AddWithValue("@demanda", calidad.Demanda1)
        comando.Parameters.AddWithValue("@ph", calidad.Ph1)
        comando.Parameters.AddWithValue("@colorReal", calidad.ColorReal1)
        comando.Parameters.AddWithValue("@turbiedad", calidad.Turbiedad1)
        comando.Parameters.AddWithValue("@fluoruros", calidad.Fluoruros1)
        comando.Parameters.AddWithValue("@hierroTotal", calidad.HierroTotal1)
        comando.Parameters.AddWithValue("@mercurio", calidad.Mercurio1)
        comando.Parameters.AddWithValue("@plomoTotal", calidad.PlomoTotal1)
        comando.Parameters.AddWithValue("@solidosTotalesDisueltos", calidad.SolidosTotalesDisueltos1)
        comando.Parameters.AddWithValue("@sulfatos", calidad.Sulfatos1)
        comando.Parameters.AddWithValue("@zinc", calidad.Zinc1)
        comando.Parameters.AddWithValue("@cloruros", calidad.Cloruros1)
        comando.Parameters.AddWithValue("@organismosColif", calidad.OrganismosColif1)
        comando.Parameters.AddWithValue("@idProyecto", calidad.IdProyecto1)

        Try
            comando.ExecuteNonQuery()
            conexion_.Close()
            MsgBox("Se guardó la información")
        Catch ex As Exception
            MsgBox("No se ha guardado, " + ex.Message)
        End Try

    End Function


    Public Function listarCalidadAgua(id As Integer) As DataTable
        comando = New OleDb.OleDbCommand("select * from CalidadAgua where idProyecto=" & id, conexion_)
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
