Public Class NuevaProyeccion

    Public idProyecto As Integer
    Public tasaCrecimiento As Double
    Public dotacionlppd As Double

    Public Sub New(idProyecto As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.idProyecto = idProyecto
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.tasaCrecimiento = Double.Parse(CProyecto.listarProyectoDatos("tasaCrecimiento", idProyecto).Rows(0)(0).ToString())
        Me.dotacionlppd = Double.Parse(CProyecto.listarProyectoDatos("dotacion", idProyecto).Rows(0)(0).ToString())
    End Sub

    Private Sub NuevaProyeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label_tasa.Text = "Tasa de crecimiento: " & tasaCrecimiento
        label_dotacion.Text = "Dotación: " & dotacionlppd
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        guardar()
    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        agregarColumnas()
        agregarFilas()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles listaCalculos.CellContentClick

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Public Sub agregarColumnas()
        listaCalculos.Columns.Add("id", "No")
        listaCalculos.Columns.Add("año", "año")
        listaCalculos.Columns.Add("poblacion", "poblacion")
        listaCalculos.Columns.Add("CPD", "CPD: Dot*Hab(1/dia)")
        listaCalculos.Columns.Add("CPD20", "20% x CPD Pérdidas por fugas (1/dia)")
        listaCalculos.Columns.Add("CPDSP", "CPD sin perdidas")
        listaCalculos.Columns.Add("CPDT", "CPDT (1/dia)")
        listaCalculos.Columns.Add("CPDTLPS", "CPDT (LPS)")
        listaCalculos.Columns.Add("1Dia", "1/dia")
        listaCalculos.Columns.Add("LPS", "LPS")
        listaCalculos.Columns.Add("m3dia", "m3/dia")
        listaCalculos.Columns.Add("GPM", "GPM")
        listaCalculos.Columns.Add("1Dia_", "1/dia CMH")
        listaCalculos.Columns.Add("LPS_ ", "LPS CMH")
        listaCalculos.Columns.Add("m3dia_", "m3/dia CMH")
        listaCalculos.Columns.Add("GMP_", "GPM CMH")
        listaCalculos.Columns.Add("Galones", "Galones")
        listaCalculos.Columns.Add("m3", "m3")
        listaCalculos.Columns.Add("idProyecto", "idProyecto")
    End Sub

    Public Sub agregarFilas()
        Dim años = Integer.Parse(text_años.Value)
        Dim poblacion0 = Double.Parse(txt_poblacion0.Text)
        Dim perdidas = Double.Parse(txt_perdidas.Text)
        Dim consumop = Double.Parse(txt_consumoP.Text)
        Dim consumoc = Double.Parse(txt_consumoC.Text)
        Dim consumoI = Double.Parse(txt_consumoI.Text)
        Dim almacena = Double.Parse(txt_almacenamiento.Text)
        Dim factorcmd = Double.Parse(txt_factorcmd.Text)
        Dim factorcmh = Double.Parse(txt_cmh.Text)

        Dim xfutura = poblacion0 * (1 + tasaCrecimiento) ^ años ' 

        listaCalculos.Rows.Add("" & 1, "" &
                               "" & (2021 + años), "" &     '1  años
                               "" & xfutura, "" &                 '2  proyecion poblacion
                               "" & xfutura * dotacionlppd, "" &  '3 CPD: Dot*Hab (l/día)
                               "" & (xfutura * dotacionlppd) * perdidas, "" & '4 20% x  CPD Pérdidas por Fugas (l/día)
                               "" & xfutura * dotacionlppd, "" &  '5 CPD Sin Perdidas
                               "" & (xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas), "" & '6 CPDT  (l/día)
                               "" & ((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas)) / 86400, "" & '7 CPDT (LPS)
                               "" & (xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas) * factorcmd, "" & '8 l/dia
                               "" & ((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas) * factorcmd) / 86400, "" & '9 LPS
                               "" & (((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas) * factorcmd) / 86400) / 1000, "" & '10  m3/dia
                               "" & ((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas) * factorcmd) / (3.785 * 1440), "" & '11  GPM
                               "" & ((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas)) * factorcmh, "" & '12  l/día
                               "" & (((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas)) * factorcmh) / 86400, "" & '13  LPS
                               "" & (((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas)) * factorcmh) / 1000, "" & '14  m3/dia
                               "" & (((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas)) * factorcmh) / (3.785 * 1440), "" & '15  GPM
                               "" & (((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas)) * almacena) / 3.785, "" & '16  Galones
                               "" & (((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas)) * almacena) / 1000, "" & '17  M3
                               "" & idProyecto)

    End Sub

    Public Sub guardar()

        Try
            Dim años = Integer.Parse(text_años.Value)
            Dim proyeccion As New MProyeccion
            Dim poblacion0 = Double.Parse(txt_poblacion0.Text)
            Dim perdidas = Double.Parse(txt_perdidas.Text)
            Dim xfutura = poblacion0 * (1 + tasaCrecimiento) ^ años ' 
            Dim factorcmd = Double.Parse(txt_factorcmd.Text)
            Dim factorcmh = Double.Parse(txt_cmh.Text)
            Dim almacena = Double.Parse(txt_almacenamiento.Text)


            proyeccion.PerdidasTecnicas1 = Double.Parse(txt_perdidas.Text)
            proyeccion.ConsumoPublico1 = Double.Parse(txt_consumoP.Text)
            proyeccion.ConsumoComercial1 = Double.Parse(txt_consumoC.Text)
            proyeccion.ConsumoIndustrial1 = Double.Parse(txt_consumoI.Text)
            proyeccion.Almacenamiento1 = Double.Parse(txt_almacenamiento.Text)
            proyeccion.FactorCMD1 = Double.Parse(txt_factorcmd.Text)
            proyeccion.FactorCMH1 = Double.Parse(txt_cmh.Text)

            proyeccion.IdProyecto1 = idProyecto
            proyeccion.Año1 = (2021 + años)    '1  años
            proyeccion.Poblacion1 = xfutura              '2  proyecion poblacion
            proyeccion.CPD1 = xfutura * dotacionlppd '3 CPD: Dot*Hab (l/día)
            proyeccion.CPD201 = (xfutura * dotacionlppd) * perdidas '4 20% x  CPD Pérdidas por Fugas (l/día)
            proyeccion.CPDSP1 = xfutura * dotacionlppd  '5 CPD Sin Perdidas
            proyeccion.CPDT1 = (xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas) '6 CPDT  (l/día)
            proyeccion.CPDTLPS1 = ((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas)) / 86400 '7 CPDT (LPS)
            proyeccion.Dia11 = (xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas) * factorcmd '8 l/dia
            proyeccion.LPS1 = ((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas) * factorcmd) / 86400 '9 LPS
            proyeccion.M3dia1 = (((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas) * factorcmd) / 86400) / 1000 '10  m3/dia
            proyeccion.GPM1 = ((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas) * factorcmd) / (3.785 * 1440) '11  GPM
            proyeccion.Dia1_1 = ((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas)) * factorcmh '12  l/día
            proyeccion.LPS_1 = (((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas)) * factorcmh) / 86400 '13  LPS
            proyeccion.M3dia_1 = (((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas)) * factorcmh) / 1000 '14  m3/dia
            proyeccion.GMP_1 = (((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas)) * factorcmh) / (3.785 * 1440) '15  GPM
            proyeccion.Galones1 = (((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas)) * almacena) / 3.785 '16  Galones
            proyeccion.M31 = (((xfutura * dotacionlppd) + ((xfutura * dotacionlppd) * perdidas)) * almacena) / 1000 '17  M3

            CProyeccion.guargarProyeccion(proyeccion)
            tabla_proyectos.DataSource = CProyeccion.listarProyecciones(idProyecto)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub text_tasaCrecimiento_ValueChanged(sender As Object, e As EventArgs) Handles text_años.ValueChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_factorcmd.TextChanged

    End Sub
End Class
