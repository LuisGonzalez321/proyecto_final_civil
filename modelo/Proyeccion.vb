Public Class MProyeccion
    Private perdidasTecnicas As Double
    Private consumoPublico As Double
    Private consumoComercial As Double
    Private consumoIndustrial As Double
    Private almacenamiento As Double
    Private factorCMD As Double
    Private factorCMH As Double
    Private IdProyecto As Integer

    Private año As Double
    Private poblacion As Double
    Private CPD As Double
    Private CPD20 As Double
    Private CPDSP As Double
    Private CPDT As Double
    Private CPDTLPS As Double
    Private Dia1 As Double
    Private LPS As Double
    Private m3dia As Double
    Private GPM As Double
    Private Dia1_ As Double
    Private LPS_ As Double
    Private m3dia_ As Double
    Private GMP_ As Double
    Private Galones As Double
    Private m3 As Double

    Public Sub New()

    End Sub

    Public Sub New(perdidasTecnicas As Double, consumoPublico As Double, consumoComercial As Double, consumoIndustrial As Double, almacenamiento As Double, factorCMD As Double, factorCMH As Double, idProyecto As Integer, año As Double, poblacion As Double, cPD As Double, cPD20 As Double, cPDSP As Double, cPDT As Double, cPDTLPS As Double, dia1 As Double, lPS As Double, m3dia As Double, gPM As Double, dia1_ As Double, lPS_ As Double, m3dia_ As Double, gMP_ As Double, galones As Double, m3 As Double)
        Me.perdidasTecnicas = perdidasTecnicas
        Me.consumoPublico = consumoPublico
        Me.consumoComercial = consumoComercial
        Me.consumoIndustrial = consumoIndustrial
        Me.almacenamiento = almacenamiento
        Me.factorCMD = factorCMD
        Me.factorCMH = factorCMH
        Me.IdProyecto = idProyecto
        Me.año = año
        Me.poblacion = poblacion
        Me.CPD = cPD
        Me.CPD20 = cPD20
        Me.CPDSP = cPDSP
        Me.CPDT = cPDT
        Me.CPDTLPS = cPDTLPS
        Me.Dia1 = dia1
        Me.LPS = lPS
        Me.m3dia = m3dia
        Me.GPM = gPM
        Me.Dia1_ = dia1_
        Me.LPS_ = lPS_
        Me.m3dia_ = m3dia_
        Me.GMP_ = gMP_
        Me.Galones = galones
        Me.m3 = m3
    End Sub

    Public Property PerdidasTecnicas1 As Double
        Get
            Return perdidasTecnicas
        End Get
        Set(value As Double)
            perdidasTecnicas = value
        End Set
    End Property

    Public Property ConsumoPublico1 As Double
        Get
            Return consumoPublico
        End Get
        Set(value As Double)
            consumoPublico = value
        End Set
    End Property

    Public Property ConsumoComercial1 As Double
        Get
            Return consumoComercial
        End Get
        Set(value As Double)
            consumoComercial = value
        End Set
    End Property

    Public Property ConsumoIndustrial1 As Double
        Get
            Return consumoIndustrial
        End Get
        Set(value As Double)
            consumoIndustrial = value
        End Set
    End Property

    Public Property Almacenamiento1 As Double
        Get
            Return almacenamiento
        End Get
        Set(value As Double)
            almacenamiento = value
        End Set
    End Property

    Public Property FactorCMD1 As Double
        Get
            Return factorCMD
        End Get
        Set(value As Double)
            factorCMD = value
        End Set
    End Property

    Public Property FactorCMH1 As Double
        Get
            Return factorCMH
        End Get
        Set(value As Double)
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

    Public Property Año1 As Double
        Get
            Return año
        End Get
        Set(value As Double)
            año = value
        End Set
    End Property

    Public Property Poblacion1 As Double
        Get
            Return poblacion
        End Get
        Set(value As Double)
            poblacion = value
        End Set
    End Property

    Public Property CPD1 As Double
        Get
            Return CPD
        End Get
        Set(value As Double)
            CPD = value
        End Set
    End Property

    Public Property CPD201 As Double
        Get
            Return CPD20
        End Get
        Set(value As Double)
            CPD20 = value
        End Set
    End Property

    Public Property CPDSP1 As Double
        Get
            Return CPDSP
        End Get
        Set(value As Double)
            CPDSP = value
        End Set
    End Property

    Public Property CPDT1 As Double
        Get
            Return CPDT
        End Get
        Set(value As Double)
            CPDT = value
        End Set
    End Property

    Public Property CPDTLPS1 As Double
        Get
            Return CPDTLPS
        End Get
        Set(value As Double)
            CPDTLPS = value
        End Set
    End Property

    Public Property Dia11 As Double
        Get
            Return Dia1
        End Get
        Set(value As Double)
            Dia1 = value
        End Set
    End Property

    Public Property LPS1 As Double
        Get
            Return LPS
        End Get
        Set(value As Double)
            LPS = value
        End Set
    End Property

    Public Property M3dia1 As Double
        Get
            Return m3dia
        End Get
        Set(value As Double)
            m3dia = value
        End Set
    End Property

    Public Property GPM1 As Double
        Get
            Return GPM
        End Get
        Set(value As Double)
            GPM = value
        End Set
    End Property

    Public Property Dia1_1 As Double
        Get
            Return Dia1_
        End Get
        Set(value As Double)
            Dia1_ = value
        End Set
    End Property

    Public Property LPS_1 As Double
        Get
            Return LPS_
        End Get
        Set(value As Double)
            LPS_ = value
        End Set
    End Property

    Public Property M3dia_1 As Double
        Get
            Return m3dia_
        End Get
        Set(value As Double)
            m3dia_ = value
        End Set
    End Property

    Public Property GMP_1 As Double
        Get
            Return GMP_
        End Get
        Set(value As Double)
            GMP_ = value
        End Set
    End Property

    Public Property Galones1 As Double
        Get
            Return Galones
        End Get
        Set(value As Double)
            Galones = value
        End Set
    End Property

    Public Property M31 As Double
        Get
            Return m3
        End Get
        Set(value As Double)
            m3 = value
        End Set
    End Property
End Class
