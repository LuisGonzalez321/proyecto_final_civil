Public Class CalidadAgua

    Dim idProyecto As Integer

    Public Sub New(idProyecto As Integer)
        InitializeComponent()
        Me.idProyecto = idProyecto
    End Sub

    Private Sub MCalidadAgua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lista_calculos.DataSource = New CCalidadAgua().listarCalidadAgua(idProyecto)
    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Try
            Dim mcalidad As New MCalidadAgua
            Dim ccalidad As New CCalidadAgua


            mcalidad.OxigenoDisuelto1 = Double.Parse(text_oxigeno.Text)
            mcalidad.Demanda1 = Double.Parse(text_demanda.Text)
            mcalidad.Ph1 = Double.Parse(text_ph.Text)
            mcalidad.Categoria1 = Double.Parse(text_color.Text)
            mcalidad.Turbiedad1 = Double.Parse(text_turbiedad.Text)
            mcalidad.Fluoruros1 = Double.Parse(text_fluoruros.Text)
            mcalidad.HierroTotal1 = Double.Parse(text_hierro.Text)
            mcalidad.Mercurio1 = Double.Parse(text_mercurio.Text)
            mcalidad.PlomoTotal1 = Double.Parse(text_plomo.Text)
            mcalidad.SolidosTotalesDisueltos1 = Double.Parse(text_solidos.Text)
            mcalidad.Sulfatos1 = Double.Parse(text_sulfatos.Text)
            mcalidad.Zinc1 = Double.Parse(text_zinc.Text)
            mcalidad.Cloruros1 = Double.Parse(text_cloruros.Text)
            mcalidad.OrganismosColif1 = Double.Parse(text_organismos.Text)
            mcalidad.IdProyecto1 = Integer.Parse(idProyecto)

            label_cat.Text = "CATEGORIA: " + ccalidad.tipoCalidadAgua(mcalidad)

            mcalidad.Categoria1 = ccalidad.tipoCalidadAgua(mcalidad)



        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try
            Dim mcalidad As New MCalidadAgua
            Dim ccalidad As New CCalidadAgua


            mcalidad.OxigenoDisuelto1 = Double.Parse(text_oxigeno.Text)
            mcalidad.Demanda1 = Double.Parse(text_demanda.Text)
            mcalidad.Ph1 = Double.Parse(text_ph.Text)
            mcalidad.ColorReal1 = Double.Parse(text_color.Text)
            mcalidad.Turbiedad1 = Double.Parse(text_turbiedad.Text)
            mcalidad.Fluoruros1 = Double.Parse(text_fluoruros.Text)
            mcalidad.HierroTotal1 = Double.Parse(text_hierro.Text)
            mcalidad.Mercurio1 = Double.Parse(text_mercurio.Text)
            mcalidad.PlomoTotal1 = Double.Parse(text_plomo.Text)
            mcalidad.SolidosTotalesDisueltos1 = Double.Parse(text_solidos.Text)
            mcalidad.Sulfatos1 = Double.Parse(text_sulfatos.Text)
            mcalidad.Zinc1 = Double.Parse(text_zinc.Text)
            mcalidad.Cloruros1 = Double.Parse(text_cloruros.Text)
            mcalidad.OrganismosColif1 = Double.Parse(text_organismos.Text)
            mcalidad.IdProyecto1 = idProyecto

            label_cat.Text = "CATEGORIA: " + ccalidad.tipoCalidadAgua(mcalidad)

            mcalidad.Categoria1 = ccalidad.tipoCalidadAgua(mcalidad)

            ccalidad.guardarCalidadAgua(mcalidad)
            lista_calculos.DataSource = New CCalidadAgua().listarCalidadAgua(idProyecto)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        text_oxigeno.Text = ""
        text_demanda.Text = ""
        text_ph.Text = ""
        text_color.Text = ""
        text_turbiedad.Text = ""
        text_fluoruros.Text = ""
        text_hierro.Text = ""
        text_mercurio.Text = ""
        text_plomo.Text = ""
        text_solidos.Text = ""
        text_sulfatos.Text = ""
        text_zinc.Text = ""
        text_cloruros.Text = ""
        text_organismos.Text = ""

        label_cat.Text = "CATEGORIA: "
    End Sub
End Class
