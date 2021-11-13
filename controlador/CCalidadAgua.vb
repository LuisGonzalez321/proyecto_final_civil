Public Class CCalidadAgua

    Dim cantidadA As Integer
    Dim cantidadB As Integer


    Public Function Oxigeno(valor As Decimal)
        If valor < 4 Then
            cantidadA += 1
            Return "CA"
        Else
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function demanda(valor As Decimal)
        If valor > 0 And valor <= 2 Then
            cantidadA += 1
            Return "CA"

        ElseIf valor > 5 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function ph(valor As Decimal)
        If valor >= 6 And valor <= 8.5 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor > 8.5 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function colorReal(valor As Decimal)
        If valor <= 15 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor > 15 And valor < 150 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function turbiedad(valor As Decimal)
        If valor <= 5 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor > 5 And valor < 250 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function fluoruros(valor As Decimal)
        If valor >= 0.7 And valor <= 1.5 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor <= 1.7 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function hierroTotal(valor As Decimal)
        If valor = 0.3 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor = 3 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function mercurioTotal(valor As Decimal)
        If valor = 0.001 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor = 0.01 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function plomoTotal(valor As Decimal)
        If valor = 0.01 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor = 0.05 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function solidosTotales(valor As Decimal)
        If valor = 1000 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor = 1500 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function sulfatos(valor As Decimal)
        If valor = 250 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor = 400 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function zinc(valor As Decimal)
        If valor = 3 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor = 5 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function cloruros(valor As Decimal)
        If valor = 250 Then
            cantidadA += 1
            Return "CA"
        ElseIf valor = 600 Then
            cantidadB += 1
            Return "CB"
        End If
    End Function

    Public Function tipoCalidadAgua(mcalidad As MCalidadAgua)
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


End Class
