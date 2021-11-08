Public Class Bomba
    Private alturaBombeo As New Decimal
    Private densidadAgua As New Decimal
    Private coeficienteGravedad As New Decimal
    Private caudal As New Decimal
    Private IdProyecto As Integer


    Public Sub New()

    End Sub

    Public Sub New(idProyecto As Integer, alturaBombeo As Decimal, densidadAgua As Decimal, coeficienteGravedad As Decimal, caudal As Decimal)
        Me.IdProyecto = idProyecto
        Me.alturaBombeo = alturaBombeo
        Me.densidadAgua = densidadAgua
        Me.coeficienteGravedad = coeficienteGravedad
        Me.caudal = caudal
    End Sub

    Public Property AlturaBombeo1 As Decimal
        Get
            Return alturaBombeo
        End Get
        Set(value As Decimal)
            alturaBombeo = value
        End Set
    End Property

    Public Property DensidadAgua1 As Decimal
        Get
            Return densidadAgua
        End Get
        Set(value As Decimal)
            densidadAgua = value
        End Set
    End Property

    Public Property CoeficienteGravedad1 As Decimal
        Get
            Return coeficienteGravedad
        End Get
        Set(value As Decimal)
            coeficienteGravedad = value
        End Set
    End Property

    Public Property Caudal1 As Decimal
        Get
            Return caudal
        End Get
        Set(value As Decimal)
            caudal = value
        End Set
    End Property

    Public Property IdProyecto1 As Integer
        Get
            Return IdProyecto
        End Get
        Set(value As Integer)
            IdProyecto = value
        End Set
    End Property

    Public Function calcularW()
        Return alturaBombeo * densidadAgua * coeficienteGravedad * coeficienteGravedad * caudal
    End Function

    Public Function calcularHP()
        Return calcularW() / 750
    End Function

End Class
