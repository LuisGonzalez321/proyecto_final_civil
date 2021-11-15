Public Class Resultados

    Public idProyecto As Integer

    Public Sub New(idProyecto As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.idProyecto = idProyecto
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Resultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer
        For i = 0 To CProyecto.queryExex("select LPS from Proyeccion where idProyecto=" & idProyecto).Rows.Count - 1 Step 1
            ListBox1.Items.Add(CProyecto.queryExex("select LPS from Proyeccion where idProyecto=" & idProyecto).Rows(i)(0).ToString())
        Next

        For i = 0 To CProyecto.queryExex("select LPS_ from Proyeccion where idProyecto=" & idProyecto).Rows.Count - 1 Step 1
            ListBox2.Items.Add(CProyecto.queryExex("select LPS_ from Proyeccion where idProyecto=" & idProyecto).Rows(i)(0).ToString())
        Next

        For i = 0 To CProyecto.queryExex("select Galones from Proyeccion where idProyecto=" & idProyecto).Rows.Count - 1 Step 1
            ListBox3.Items.Add(CProyecto.queryExex("select Galones from Proyeccion where idProyecto=" & idProyecto).Rows(i)(0).ToString())
        Next

        For i = 0 To CProyecto.queryExex("select Categoria from CalidadAgua where idProyecto=" & idProyecto).Rows.Count - 1 Step 1
            ListBox4.Items.Add(CProyecto.queryExex("select Categoria from CalidadAgua where idProyecto=" & idProyecto).Rows(i)(0).ToString())
        Next

        For i = 0 To CProyecto.queryExex("select resultadoHP from Proyecto where Id=" & idProyecto).Rows.Count - 1 Step 1
            ListBox1.Items.Add(CProyecto.queryExex("select resultadoHP from Proyecto where Id=" & idProyecto).Rows(i)(0).ToString())
        Next

    End Sub

    Private Sub c_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub label_potencia_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub Cargar()

    End Sub
End Class
