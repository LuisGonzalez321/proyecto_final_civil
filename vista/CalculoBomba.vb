Public Class CalculoBomba
    Public idProyecto As Integer

    Public Sub New(idProyect As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.idProyecto = idProyect
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub CalculoBomba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lista_bomba.DataSource = CBomba.listarBomba()
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Dim bomba As New Bomba
        bomba.AlturaBombeo1 = Decimal.Parse(text_alturaBombeo.Text)
        bomba.DensidadAgua1 = Decimal.Parse(text_densidad.Text)
        bomba.CoeficienteGravedad1 = Decimal.Parse(text_coeficiente.Text)
        bomba.Caudal1 = Decimal.Parse(text_caudal.Text)
        bomba.IdProyecto1 = idProyecto
        label_resultadoHP.Text = "Resultado HP: " + bomba.calcularHP().ToString()
        label_resultadoW.Text = "Resultado W: " + bomba.calcularW().ToString()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim bomba As New Bomba
        bomba.AlturaBombeo1 = Decimal.Parse(text_alturaBombeo.Text)
        bomba.DensidadAgua1 = Decimal.Parse(text_densidad.Text)
        bomba.CoeficienteGravedad1 = Decimal.Parse(text_coeficiente.Text)
        bomba.Caudal1 = Decimal.Parse(text_caudal.Text)
        bomba.IdProyecto1 = idProyecto
        CBomba.guardarBomba(bomba)
        lista_bomba.DataSource = CBomba.listarBomba()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        text_alturaBombeo.Text = ""
        text_densidad.Text = ""
        text_coeficiente.Text = ""
        text_caudal.Text = ""
        label_resultadoHP.Text = "Resultado HP: "
        label_resultadoW.Text = "Resultado W: "

    End Sub
End Class
