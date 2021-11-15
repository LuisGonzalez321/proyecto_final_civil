
Public Class Index

    Public idProyecto = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
        Dim i As Integer
        For i = 0 To CProyecto.listarProyectoListbox("Id").Rows.Count - 1 Step 1
            ListBox1.Items.Add(CProyecto.listarProyectoListbox("Id").Rows(i)(0).ToString())
        Next
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Dispose()
        Inicio.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        Dim Inicio As New NuevoProyecto(idProyecto)
        label_titulo.Text = "Nuevo Proyecto"
        panelGeneral.Controls.Clear()
        panelGeneral.Controls.Add(Inicio)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim calculoBomba As New CalculoBomba(idProyecto)
        label_titulo.Text = "Calculo de bomba"
        panelGeneral.Controls.Clear()
        panelGeneral.Controls.Add(calculoBomba)
    End Sub

    Private Sub btn_nuevaProyeccion_Click(sender As Object, e As EventArgs) Handles btn_nuevaProyeccion.Click
        Dim nuevaProyeccion As New NuevaProyeccion(idProyecto)
        label_titulo.Text = "Nueva Proyección"
        panelGeneral.Controls.Clear()
        panelGeneral.Controls.Add(nuevaProyeccion)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        idProyecto = ListBox1.SelectedItem.ToString()
        renderView(idProyecto)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim resultados As New Resultados(idProyecto)
        label_titulo.Text = "Resultados"
        panelGeneral.Controls.Clear()
        panelGeneral.Controls.Add(resultados)
    End Sub

    Private Sub btn__Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_calidadAgua_Click(sender As Object, e As EventArgs) Handles btn_calidadAgua.Click
        Dim calidadAgua As New CalidadAgua(idProyecto)
        label_titulo.Text = "Calidad de agua"
        panelGeneral.Controls.Clear()
        panelGeneral.Controls.Add(calidadAgua)
    End Sub

    Public Sub renderView(idProyecto_ As Integer)
        Select Case label_titulo.Text
            Case "Nuevo Proyecto"
                Dim Inicio As New NuevoProyecto(idProyecto_)
                panelGeneral.Controls.Clear()
                panelGeneral.Controls.Add(Inicio)
            Case "Calculo de bomba"
                Dim calculoBomba As New CalculoBomba(idProyecto_)
                panelGeneral.Controls.Clear()
                panelGeneral.Controls.Add(calculoBomba)

            Case "Nueva Proyección"
                Dim nuevaProyeccion As New NuevaProyeccion(idProyecto_)
                panelGeneral.Controls.Clear()
                panelGeneral.Controls.Add(nuevaProyeccion)
            Case "Resultados"
                Dim resultados As New Resultados(idProyecto_)
                panelGeneral.Controls.Clear()
                panelGeneral.Controls.Add(resultados)
            Case "Calidad de agua"
                Dim calidadAgua As New CalidadAgua(idProyecto_)
                panelGeneral.Controls.Clear()
                panelGeneral.Controls.Add(calidadAgua)
        End Select
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ayuda As New Ayuda
        panelGeneral.Controls.Clear()
        panelGeneral.Controls.Add(ayuda)
    End Sub
End Class
