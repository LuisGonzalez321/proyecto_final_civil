Public Class Bomba
    Private alturaBombeo As Double
    Private densidadAgua As Double
    Private coeficienteGravedad As Double
    Private caudal As Double
    Private idProyecto As Integer


    Public Sub New()

    End Sub

    Public Sub New(idProyecto As Integer, alturaBombeo As Double, densidadAgua As Double, coeficienteGravedad As Double, caudal As Double)
        Me.idProyecto = idProyecto
        Me.alturaBombeo = alturaBombeo
        Me.densidadAgua = densidadAgua
        Me.coeficienteGravedad = coeficienteGravedad
        Me.caudal = caudal
    End Sub

    Public Property AlturaBombeo1 As Double
        Get
            Return alturaBombeo
        End Get
        Set(value As Double)
            alturaBombeo = value
        End Set
    End Property

    Public Property DensidadAgua1 As Double
        Get
            Return densidadAgua
        End Get
        Set(value As Double)
            densidadAgua = value
        End Set
    End Property

    Public Property CoeficienteGravedad1 As Double
        Get
            Return coeficienteGravedad
        End Get
        Set(value As Double)
            coeficienteGravedad = value
        End Set
    End Property

    Public Property Caudal1 As Double
        Get
            Return caudal
        End Get
        Set(value As Double)
            caudal = value
        End Set
    End Property

    Public Property IdProyecto1 As Integer
        Get
            Return idProyecto
        End Get
        Set(value As Integer)
            idProyecto = value
        End Set
    End Property

    Public Function calcularW()
        Dim calculo As Double
        calculo = alturaBombeo * densidadAgua * coeficienteGravedad * caudal
        MsgBox(calculo.ToString())
        Return calculo
    End Function

    Public Function calcularHP()
        Return calcularW() / 750
    End Function

End Class
