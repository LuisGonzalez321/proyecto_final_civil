<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalidadAgua
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.text_color = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.text_ph = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.text_demanda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.text_oxigeno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.text_turbiedad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.text_hierro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.text_fluoruros = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.text_plomo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.text_mercurio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.text_organismos = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.text_cloruros = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.text_zinc = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.text_sulfatos = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.text_solidos = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.label_cat = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lista_calculos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.lista_calculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'text_color
        '
        Me.text_color.Location = New System.Drawing.Point(261, 182)
        Me.text_color.Name = "text_color"
        Me.text_color.Size = New System.Drawing.Size(170, 27)
        Me.text_color.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Color real:"
        '
        'text_ph
        '
        Me.text_ph.Location = New System.Drawing.Point(261, 129)
        Me.text_ph.Name = "text_ph"
        Me.text_ph.Size = New System.Drawing.Size(170, 27)
        Me.text_ph.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "PH:"
        '
        'text_demanda
        '
        Me.text_demanda.Location = New System.Drawing.Point(261, 76)
        Me.text_demanda.Name = "text_demanda"
        Me.text_demanda.Size = New System.Drawing.Size(170, 27)
        Me.text_demanda.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Demanda de oxigeno  (DBO5,20):"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'text_oxigeno
        '
        Me.text_oxigeno.Location = New System.Drawing.Point(261, 23)
        Me.text_oxigeno.Name = "text_oxigeno"
        Me.text_oxigeno.Size = New System.Drawing.Size(170, 27)
        Me.text_oxigeno.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Oxigeno Disuelto: "
        '
        'text_turbiedad
        '
        Me.text_turbiedad.Location = New System.Drawing.Point(261, 235)
        Me.text_turbiedad.Name = "text_turbiedad"
        Me.text_turbiedad.Size = New System.Drawing.Size(170, 27)
        Me.text_turbiedad.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Turbiedad:"
        '
        'text_hierro
        '
        Me.text_hierro.Location = New System.Drawing.Point(261, 341)
        Me.text_hierro.Name = "text_hierro"
        Me.text_hierro.Size = New System.Drawing.Size(170, 27)
        Me.text_hierro.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Hierro total:"
        '
        'text_fluoruros
        '
        Me.text_fluoruros.Location = New System.Drawing.Point(261, 288)
        Me.text_fluoruros.Name = "text_fluoruros"
        Me.text_fluoruros.Size = New System.Drawing.Size(170, 27)
        Me.text_fluoruros.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Fluoruros:"
        '
        'text_plomo
        '
        Me.text_plomo.Location = New System.Drawing.Point(261, 447)
        Me.text_plomo.Name = "text_plomo"
        Me.text_plomo.Size = New System.Drawing.Size(170, 27)
        Me.text_plomo.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 450)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 20)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Plomo total:"
        '
        'text_mercurio
        '
        Me.text_mercurio.Location = New System.Drawing.Point(261, 394)
        Me.text_mercurio.Name = "text_mercurio"
        Me.text_mercurio.Size = New System.Drawing.Size(170, 27)
        Me.text_mercurio.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 397)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Mercurio total:"
        '
        'text_organismos
        '
        Me.text_organismos.Location = New System.Drawing.Point(637, 233)
        Me.text_organismos.Name = "text_organismos"
        Me.text_organismos.Size = New System.Drawing.Size(170, 27)
        Me.text_organismos.TabIndex = 35
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(458, 236)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 20)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Organismos Colif:"
        '
        'text_cloruros
        '
        Me.text_cloruros.Location = New System.Drawing.Point(637, 180)
        Me.text_cloruros.Name = "text_cloruros"
        Me.text_cloruros.Size = New System.Drawing.Size(170, 27)
        Me.text_cloruros.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(458, 183)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 20)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Cloruros:"
        '
        'text_zinc
        '
        Me.text_zinc.Location = New System.Drawing.Point(637, 127)
        Me.text_zinc.Name = "text_zinc"
        Me.text_zinc.Size = New System.Drawing.Size(170, 27)
        Me.text_zinc.TabIndex = 31
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(458, 130)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 20)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Zinc:"
        '
        'text_sulfatos
        '
        Me.text_sulfatos.Location = New System.Drawing.Point(637, 74)
        Me.text_sulfatos.Name = "text_sulfatos"
        Me.text_sulfatos.Size = New System.Drawing.Size(170, 27)
        Me.text_sulfatos.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(458, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 20)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Sulfatos:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'text_solidos
        '
        Me.text_solidos.Location = New System.Drawing.Point(637, 21)
        Me.text_solidos.Name = "text_solidos"
        Me.text_solidos.Size = New System.Drawing.Size(170, 27)
        Me.text_solidos.TabIndex = 27
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(458, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(173, 20)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Solidos totales disueltos:"
        '
        'label_cat
        '
        Me.label_cat.AutoSize = True
        Me.label_cat.Location = New System.Drawing.Point(458, 295)
        Me.label_cat.Name = "label_cat"
        Me.label_cat.Size = New System.Drawing.Size(90, 20)
        Me.label_cat.TabIndex = 36
        Me.label_cat.Text = "CATEGORIA:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.Location = New System.Drawing.Point(680, 361)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Padding = New System.Windows.Forms.Padding(0, 0, 100, 0)
        Me.btn_cancelar.Size = New System.Drawing.Size(202, 39)
        Me.btn_cancelar.TabIndex = 39
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_guardar.FlatAppearance.BorderSize = 0
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(458, 435)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Padding = New System.Windows.Forms.Padding(0, 0, 100, 0)
        Me.btn_guardar.Size = New System.Drawing.Size(202, 39)
        Me.btn_guardar.TabIndex = 38
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_calcular
        '
        Me.btn_calcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_calcular.FlatAppearance.BorderSize = 0
        Me.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_calcular.ForeColor = System.Drawing.Color.White
        Me.btn_calcular.Location = New System.Drawing.Point(458, 361)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Padding = New System.Windows.Forms.Padding(0, 0, 100, 0)
        Me.btn_calcular.Size = New System.Drawing.Size(202, 39)
        Me.btn_calcular.TabIndex = 37
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lista_calculos)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 513)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(859, 138)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de calculos"
        '
        'lista_calculos
        '
        Me.lista_calculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lista_calculos.Location = New System.Drawing.Point(6, 38)
        Me.lista_calculos.Name = "lista_calculos"
        Me.lista_calculos.RowHeadersWidth = 51
        Me.lista_calculos.RowTemplate.Height = 29
        Me.lista_calculos.Size = New System.Drawing.Size(847, 94)
        Me.lista_calculos.TabIndex = 0
        '
        'CalidadAgua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.label_cat)
        Me.Controls.Add(Me.text_organismos)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.text_cloruros)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.text_zinc)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.text_sulfatos)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.text_solidos)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.text_plomo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.text_mercurio)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.text_hierro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.text_fluoruros)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.text_turbiedad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.text_color)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.text_ph)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.text_demanda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.text_oxigeno)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CalidadAgua"
        Me.Size = New System.Drawing.Size(906, 670)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.lista_calculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents text_color As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents text_ph As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents text_demanda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents text_oxigeno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents text_turbiedad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents text_hierro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents text_fluoruros As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents text_plomo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents text_mercurio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents text_organismos As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents text_cloruros As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents text_zinc As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents text_sulfatos As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents text_solidos As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents label_cat As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_calcular As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lista_calculos As DataGridView
End Class
