Public Class Index

    Public idProyecto As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox2.DoubleClick

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles panelGeneral.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_inicio.Click
        Dim Inicio As New NuevoProyecto
        label_titulo.Text = "Nuevo Proyecto"
        panelGeneral.Controls.Clear()
        panelGeneral.Controls.Add(Inicio)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        idProyecto = 1
        Dim calculoBomba As New CalculoBomba(idProyecto)
        label_titulo.Text = "Calculo de bomba"
        panelGeneral.Controls.Clear()
        panelGeneral.Controls.Add(calculoBomba)
    End Sub

    Private Sub btn_nuevaProyeccion_Click(sender As Object, e As EventArgs) Handles btn_nuevaProyeccion.Click
        Dim nuevaProyeccion As New NuevaProyeccion
        label_titulo.Text = "Nueva Proyección"
        panelGeneral.Controls.Clear()
        panelGeneral.Controls.Add(nuevaProyeccion)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles label_titulo.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim resultados As New Resultados
        label_titulo.Text = "Resultados"
        panelGeneral.Controls.Clear()
        panelGeneral.Controls.Add(resultados)
    End Sub

    Private Sub btn__Click(sender As Object, e As EventArgs) Handles btn_calidadAgua.Click
        Dim calidadAgua As New CalidadAgua
        label_titulo.Text = "Calidad de agua"
        panelGeneral.Controls.Clear()
        panelGeneral.Controls.Add(calidadAgua)
    End Sub
End Class
