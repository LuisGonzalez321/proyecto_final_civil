Public Class MCalidadAgua

    Private Categoria As String
    Private OxigenoDisuelto As Double
    Private demanda As Double
    Private ph As Double
    Private colorReal As Double
    Private turbiedad As Double
    Private fluoruros As Double
    Private hierroTotal As Double
    Private mercurio As Double
    Private plomoTotal As Double
    Private solidosTotalesDisueltos As Double
    Private sulfatos As Double
    Private zinc As Double
    Private cloruros As Double
    Private organismosColif As Double
    Private idProyecto As Integer



    Public Sub New()

    End Sub

    Public Sub New(categoria As String, oxigenoDisuelto As Double, demanda As Double, ph As Double, colorReal As Double, turbiedad As Double, fluoruros As Double, hierroTotal As Double, mercurio As Double, plomoTotal As Double, solidosTotalesDisueltos As Double, sulfatos As Double, zinc As Double, cloruros As Double, organismosColif As Double, idProyecto As Integer)
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

    Public Property Categoria1 As String
        Get
            Return Categoria
        End Get
        Set(value As String)
            Categoria = value
        End Set
    End Property

    Public Property OxigenoDisuelto1 As Double
        Get
            Return OxigenoDisuelto
        End Get
        Set(value As Double)
            OxigenoDisuelto = value
        End Set
    End Property

    Public Property Demanda1 As Double
        Get
            Return demanda
        End Get
        Set(value As Double)
            demanda = value
        End Set
    End Property

    Public Property Ph1 As Double
        Get
            Return ph
        End Get
        Set(value As Double)
            ph = value
        End Set
    End Property

    Public Property ColorReal1 As Double
        Get
            Return colorReal
        End Get
        Set(value As Double)
            colorReal = value
        End Set
    End Property

    Public Property Turbiedad1 As Double
        Get
            Return turbiedad
        End Get
        Set(value As Double)
            turbiedad = value
        End Set
    End Property

    Public Property Fluoruros1 As Double
        Get
            Return fluoruros
        End Get
        Set(value As Double)
            fluoruros = value
        End Set
    End Property

    Public Property HierroTotal1 As Double
        Get
            Return hierroTotal
        End Get
        Set(value As Double)
            hierroTotal = value
        End Set
    End Property

    Public Property PlomoTotal1 As Double
        Get
            Return plomoTotal
        End Get
        Set(value As Double)
            plomoTotal = value
        End Set
    End Property

    Public Property SolidosTotalesDisueltos1 As Double
        Get
            Return solidosTotalesDisueltos
        End Get
        Set(value As Double)
            solidosTotalesDisueltos = value
        End Set
    End Property

    Public Property Sulfatos1 As Double
        Get
            Return sulfatos
        End Get
        Set(value As Double)
            sulfatos = value
        End Set
    End Property

    Public Property Zinc1 As Double
        Get
            Return zinc
        End Get
        Set(value As Double)
            zinc = value
        End Set
    End Property

    Public Property Cloruros1 As Double
        Get
            Return cloruros
        End Get
        Set(value As Double)
            cloruros = value
        End Set
    End Property

    Public Property OrganismosColif1 As Double
        Get
            Return organismosColif
        End Get
        Set(value As Double)
            organismosColif = value
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

    Public Property Mercurio1 As Double
        Get
            Return mercurio
        End Get
        Set(value As Double)
            mercurio = value
        End Set
    End Property
End Class
