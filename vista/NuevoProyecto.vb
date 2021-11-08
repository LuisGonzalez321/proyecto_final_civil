Public Class NuevoProyecto


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles text_departamento.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles text_municipio.TextChanged

    End Sub

    Private Sub text_poblacionInicial_TextChanged(sender As Object, e As EventArgs) Handles text_poblacionInicial.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles text_dotacion.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles text_elevacionPuente.TextChanged

    End Sub

    Private Sub btn_inicio_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim proyecto As New Proyecto()
        proyecto.Pais1 = text_pais.Text
        proyecto.Departamento1 = text_departamento.Text
        proyecto.Municipio1 = text_municipio.Text
        proyecto.Comunidad1 = text_comunidad.Text
        proyecto.PoblacionInicial1 = Decimal.Parse(text_poblacionInicial.Text)
        proyecto.TasaCrecimiento1 = Decimal.Parse(text_tasaCrecimiento.Text) / 100
        proyecto.TipoFuente1 = combox_tipoFuente.SelectedItem.ToString
        proyecto.Dotacion1 = Decimal.Parse(text_dotacion.Text)
        proyecto.ElevacionPuente1 = Decimal.Parse(text_elevacionPuente.Text)
        proyecto.ElevacionTanque1 = Decimal.Parse(text_elevacionTanque.Text)
        CProyecto.guardarProyecto(proyecto)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub text_pais_TextChanged(sender As Object, e As EventArgs) Handles text_pais.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combox_tipoFuente.SelectedIndexChanged

    End Sub

    Private Sub NuevoProyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
