Public Class CalidadAgua

    Private Categoria As String
    Private OxigenoDisuelto As String
    Private ph As String
    Private colorReal As String
    Private turbiedad As String
    Private fluoruros As String
    Private hierroTotal As String
    Private plomoTotal As String
    Private solidosTotalesDisueltos As String
    Private sulfatos As String
    Private zinc As String
    Private cloruros As String
    Private organismosColif As String
    Private durezaCaCO3 As String
    Private mangansoTotal As String
    Private nitritosNitratis As String
    Private sodio As String
    Private IdProyecto As Integer

    Public Sub New()

    End Sub

    Public Sub New(idProyecto As Integer, categoria As String, oxigenoDisuelto As String, ph As String, colorReal As String, turbiedad As String, fluoruros As String, hierroTotal As String, plomoTotal As String, solidosTotalesDisueltos As String, sulfatos As String, zinc As String, cloruros As String, organismosColif As String, durezaCaCO3 As String, mangansoTotal As String, nitritosNitratis As String, sodio As String)
        Me.IdProyecto = idProyecto
        Me.Categoria = categoria
        Me.OxigenoDisuelto = oxigenoDisuelto
        Me.ph = ph
        Me.colorReal = colorReal
        Me.turbiedad = turbiedad
        Me.fluoruros = fluoruros
        Me.hierroTotal = hierroTotal
        Me.plomoTotal = plomoTotal
        Me.solidosTotalesDisueltos = solidosTotalesDisueltos
        Me.sulfatos = sulfatos
        Me.zinc = zinc
        Me.cloruros = cloruros
        Me.organismosColif = organismosColif
        Me.durezaCaCO3 = durezaCaCO3
        Me.mangansoTotal = mangansoTotal
        Me.nitritosNitratis = nitritosNitratis
        Me.sodio = sodio
    End Sub

    Public Property Categoria1 As String
        Get
            Return Categoria
        End Get
        Set(value As String)
            Categoria = value
        End Set
    End Property

    Public Property OxigenoDisuelto1 As String
        Get
            Return OxigenoDisuelto
        End Get
        Set(value As String)
            OxigenoDisuelto = value
        End Set
    End Property

    Public Property Ph1 As String
        Get
            Return ph
        End Get
        Set(value As String)
            ph = value
        End Set
    End Property

    Public Property ColorReal1 As String
        Get
            Return colorReal
        End Get
        Set(value As String)
            colorReal = value
        End Set
    End Property

    Public Property Turbiedad1 As String
        Get
            Return turbiedad
        End Get
        Set(value As String)
            turbiedad = value
        End Set
    End Property

    Public Property Fluoruros1 As String
        Get
            Return fluoruros
        End Get
        Set(value As String)
            fluoruros = value
        End Set
    End Property

    Public Property HierroTotal1 As String
        Get
            Return hierroTotal
        End Get
        Set(value As String)
            hierroTotal = value
        End Set
    End Property

    Public Property PlomoTotal1 As String
        Get
            Return plomoTotal
        End Get
        Set(value As String)
            plomoTotal = value
        End Set
    End Property

    Public Property SolidosTotalesDisueltos1 As String
        Get
            Return solidosTotalesDisueltos
        End Get
        Set(value As String)
            solidosTotalesDisueltos = value
        End Set
    End Property

    Public Property Sulfatos1 As String
        Get
            Return sulfatos
        End Get
        Set(value As String)
            sulfatos = value
        End Set
    End Property

    Public Property Zinc1 As String
        Get
            Return zinc
        End Get
        Set(value As String)
            zinc = value
        End Set
    End Property

    Public Property Cloruros1 As String
        Get
            Return cloruros
        End Get
        Set(value As String)
            cloruros = value
        End Set
    End Property

    Public Property OrganismosColif1 As String
        Get
            Return organismosColif
        End Get
        Set(value As String)
            organismosColif = value
        End Set
    End Property

    Public Property DurezaCaCO31 As String
        Get
            Return durezaCaCO3
        End Get
        Set(value As String)
            durezaCaCO3 = value
        End Set
    End Property

    Public Property MangansoTotal1 As String
        Get
            Return mangansoTotal
        End Get
        Set(value As String)
            mangansoTotal = value
        End Set
    End Property

    Public Property NitritosNitratis1 As String
        Get
            Return nitritosNitratis
        End Get
        Set(value As String)
            nitritosNitratis = value
        End Set
    End Property

    Public Property Sodio1 As String
        Get
            Return sodio
        End Get
        Set(value As String)
            sodio = value
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
