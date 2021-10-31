Public Class Proyecto
    Private pais As String
    Private departamento As String
    Private municipio As String
    Private comunidad As String
    Private poblacionInicial As Decimal
    Private tasaCrecimiento As Decimal
    Private dotacion As Decimal
    Private tipoFuente As String
    Private elevacionPuente As Decimal
    Private elevacionTanque As Decimal

    Public Sub New()

    End Sub

    Public Sub New(pais As String, departamento As String, municipio As String, comunidad As String, poblacionInicial As Decimal, tasaCrecimiento As Decimal, dotacion As Decimal, tipoFuente As String, elevacionPuente As Decimal, elevacionTanque As Decimal)
        Me.pais = pais
        Me.departamento = departamento
        Me.municipio = municipio
        Me.comunidad = comunidad
        Me.poblacionInicial = poblacionInicial
        Me.tasaCrecimiento = tasaCrecimiento
        Me.dotacion = dotacion
        Me.tipoFuente = tipoFuente
        Me.elevacionPuente = elevacionPuente
        Me.elevacionTanque = elevacionTanque
    End Sub

    Public Property Pais1 As String
        Get
            Return pais
        End Get
        Set(value As String)
            pais = value
        End Set
    End Property

    Public Property Departamento1 As String
        Get
            Return departamento
        End Get
        Set(value As String)
            departamento = value
        End Set
    End Property

    Public Property Municipio1 As String
        Get
            Return municipio
        End Get
        Set(value As String)
            municipio = value
        End Set
    End Property

    Public Property Comunidad1 As String
        Get
            Return comunidad
        End Get
        Set(value As String)
            comunidad = value
        End Set
    End Property

    Public Property PoblacionInicial1 As Decimal
        Get
            Return poblacionInicial
        End Get
        Set(value As Decimal)
            poblacionInicial = value
        End Set
    End Property

    Public Property TasaCrecimiento1 As Decimal
        Get
            Return tasaCrecimiento
        End Get
        Set(value As Decimal)
            tasaCrecimiento = value
        End Set
    End Property

    Public Property Dotacion1 As Decimal
        Get
            Return dotacion
        End Get
        Set(value As Decimal)
            dotacion = value
        End Set
    End Property

    Public Property TipoFuente1 As String
        Get
            Return tipoFuente
        End Get
        Set(value As String)
            tipoFuente = value
        End Set
    End Property

    Public Property ElevacionPuente1 As Decimal
        Get
            Return elevacionPuente
        End Get
        Set(value As Decimal)
            elevacionPuente = value
        End Set
    End Property

    Public Property ElevacionTanque1 As Decimal
        Get
            Return elevacionTanque
        End Get
        Set(value As Decimal)
            elevacionTanque = value
        End Set
    End Property
End Class
