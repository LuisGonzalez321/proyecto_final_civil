Public Class MCalidadAgua

    Private Categoria As Decimal
    Private OxigenoDisuelto As Decimal
    Private demanda As Decimal
    Private ph As Decimal
    Private colorReal As Decimal
    Private turbiedad As Decimal
    Private fluoruros As Decimal
    Private hierroTotal As Decimal
    Private mercurio As Decimal
    Private plomoTotal As Decimal
    Private solidosTotalesDisueltos As Decimal
    Private sulfatos As Decimal
    Private zinc As Decimal
    Private cloruros As Decimal
    Private organismosColif As Decimal
    Private idProyecto As Integer



    Public Sub New()

    End Sub

    Public Sub New(categoria As Decimal, oxigenoDisuelto As Decimal, demanda As Decimal, ph As Decimal, colorReal As Decimal, turbiedad As Decimal, fluoruros As Decimal, hierroTotal As Decimal, mercurio As Decimal, plomoTotal As Decimal, solidosTotalesDisueltos As Decimal, sulfatos As Decimal, zinc As Decimal, cloruros As Decimal, organismosColif As Decimal, idProyecto As Integer)
        Me.Categoria = categoria
        Me.OxigenoDisuelto = oxigenoDisuelto
        Me.demanda = demanda
        Me.ph = ph
        Me.colorReal = colorReal
        Me.turbiedad = turbiedad
        Me.fluoruros = fluoruros
        Me.hierroTotal = hierroTotal
        Me.mercurio = mercurio
        Me.plomoTotal = plomoTotal
        Me.solidosTotalesDisueltos = solidosTotalesDisueltos
        Me.sulfatos = sulfatos
        Me.zinc = zinc
        Me.cloruros = cloruros
        Me.organismosColif = organismosColif
        Me.idProyecto = idProyecto
    End Sub

    Public Property Categoria1 As Decimal
        Get
            Return Categoria
        End Get
        Set(value As Decimal)
            Categoria = value
        End Set
    End Property

    Public Property OxigenoDisuelto1 As Decimal
        Get
            Return OxigenoDisuelto
        End Get
        Set(value As Decimal)
            OxigenoDisuelto = value
        End Set
    End Property

    Public Property Demanda1 As Decimal
        Get
            Return demanda
        End Get
        Set(value As Decimal)
            demanda = value
        End Set
    End Property

    Public Property Ph1 As Decimal
        Get
            Return ph
        End Get
        Set(value As Decimal)
            ph = value
        End Set
    End Property

    Public Property ColorReal1 As Decimal
        Get
            Return colorReal
        End Get
        Set(value As Decimal)
            colorReal = value
        End Set
    End Property

    Public Property Turbiedad1 As Decimal
        Get
            Return turbiedad
        End Get
        Set(value As Decimal)
            turbiedad = value
        End Set
    End Property

    Public Property Fluoruros1 As Decimal
        Get
            Return fluoruros
        End Get
        Set(value As Decimal)
            fluoruros = value
        End Set
    End Property

    Public Property HierroTotal1 As Decimal
        Get
            Return hierroTotal
        End Get
        Set(value As Decimal)
            hierroTotal = value
        End Set
    End Property

    Public Property PlomoTotal1 As Decimal
        Get
            Return plomoTotal
        End Get
        Set(value As Decimal)
            plomoTotal = value
        End Set
    End Property

    Public Property SolidosTotalesDisueltos1 As Decimal
        Get
            Return solidosTotalesDisueltos
        End Get
        Set(value As Decimal)
            solidosTotalesDisueltos = value
        End Set
    End Property

    Public Property Sulfatos1 As Decimal
        Get
            Return sulfatos
        End Get
        Set(value As Decimal)
            sulfatos = value
        End Set
    End Property

    Public Property Zinc1 As Decimal
        Get
            Return zinc
        End Get
        Set(value As Decimal)
            zinc = value
        End Set
    End Property

    Public Property Cloruros1 As Decimal
        Get
            Return cloruros
        End Get
        Set(value As Decimal)
            cloruros = value
        End Set
    End Property

    Public Property OrganismosColif1 As Decimal
        Get
            Return organismosColif
        End Get
        Set(value As Decimal)
            organismosColif = value
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

    Public Property Mercurio1 As Decimal
        Get
            Return mercurio
        End Get
        Set(value As Decimal)
            mercurio = value
        End Set
    End Property
End Class
