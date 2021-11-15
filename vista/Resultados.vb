Public Class Resultados

    Public idProyecto As Integer

    Public Sub New(idProyecto As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.idProyecto = idProyecto
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles label_consumoMaximoDia.Click

    End Sub

    Private Sub Resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
