Public Class Proyecto
    Private idProyecto As Integer
    Private pais As String
    Private departamento As String
    Private municipio As String
    Private comunidad As String
    Private poblacionInicial As Double
    Private tasaCrecimiento As Double
    Private dotacion As Double
    Private tipoFuente As String
    Private elevacionPuente As Double
    Private elevacionTanque As Double

    Public Sub New()

    End Sub

    Public Sub New(idProyecto As Integer, pais As String, departamento As String, municipio As String, comunidad As String, poblacionInicial As Double, tasaCrecimiento As Double, dotacion As Double, tipoFuente As String, elevacionPuente As Double, elevacionTanque As Double)
        Me.idProyecto = idProyecto
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

    Public Property PoblacionInicial1 As Double
        Get
            Return poblacionInicial
        End Get
        Set(value As Double)
            poblacionInicial = value
        End Set
    End Property

    Public Property TasaCrecimiento1 As Double
        Get
            Return tasaCrecimiento
        End Get
        Set(value As Double)
            tasaCrecimiento = value
        End Set
    End Property

    Public Property Dotacion1 As Double
        Get
            Return dotacion
        End Get
        Set(value As Double)
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

    Public Property ElevacionPuente1 As Double
        Get
            Return elevacionPuente
        End Get
        Set(value As Double)
            elevacionPuente = value
        End Set
    End Property

    Public Property ElevacionTanque1 As Double
        Get
            Return elevacionTanque
        End Get
        Set(value As Double)
            elevacionTanque = value
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
End Class
