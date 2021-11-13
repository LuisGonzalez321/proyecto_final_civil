Public Class MProyeccion
    Private perdidasTecnicas As Decimal
    Private consumoPublico As Decimal
    Private consumoComercial As Decimal
    Private consumoIndustrial As Decimal
    Private almacenamiento As Decimal
    Private factorCMD As Decimal
    Private factorCMH As Decimal
    Private IdProyecto As Integer

    Public Sub New()

    End Sub

    Public Sub New(perdidasTecnicas As Decimal, consumoPublico As Decimal, consumoComercial As Decimal, consumoIndustrial As Decimal, almacenamiento As Decimal, factorCMD As Decimal, factorCMH As Decimal, idProyecto As Integer)
        Me.perdidasTecnicas = perdidasTecnicas
        Me.consumoPublico = consumoPublico
        Me.consumoComercial = consumoComercial
        Me.consumoIndustrial = consumoIndustrial
        Me.almacenamiento = almacenamiento
        Me.factorCMD = factorCMD
        Me.factorCMH = factorCMH
        Me.IdProyecto = idProyecto
    End Sub

    Public Property PerdidasTecnicas1 As Decimal
        Get
            Return perdidasTecnicas
        End Get
        Set(value As Decimal)
            perdidasTecnicas = value
        End Set
    End Property

    Public Property ConsumoPublico1 As Decimal
        Get
            Return consumoPublico
        End Get
        Set(value As Decimal)
            consumoPublico = value
        End Set
    End Property

    Public Property ConsumoComercial1 As Decimal
        Get
            Return consumoComercial
        End Get
        Set(value As Decimal)
            consumoComercial = value
        End Set
    End Property

    Public Property ConsumoIndustrial1 As Decimal
        Get
            Return consumoIndustrial
        End Get
        Set(value As Decimal)
            consumoIndustrial = value
        End Set
    End Property

    Public Property Almacenamiento1 As Decimal
        Get
            Return almacenamiento
        End Get
        Set(value As Decimal)
            almacenamiento = value
        End Set
    End Property

    Public Property FactorCMD1 As Decimal
        Get
            Return factorCMD
        End Get
        Set(value As Decimal)
            factorCMD = value
        End Set
    End Property

    Public Property FactorCMH1 As Decimal
        Get
            Return factorCMH
        End Get
        Set(value As Decimal)
            factorCMH = value
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
End Class
