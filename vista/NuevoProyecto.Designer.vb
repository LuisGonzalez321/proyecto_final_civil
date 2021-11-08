<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoProyecto
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.text_pais = New System.Windows.Forms.TextBox()
        Me.text_departamento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.text_municipio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.text_poblacionInicial = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.text_comunidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.text_elevacionPuente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.text_dotacion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.text_elevacionTanque = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.combox_tipoFuente = New System.Windows.Forms.ComboBox()
        Me.text_tasaCrecimiento = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.text_tasaCrecimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "País"
        '
        'text_pais
        '
        Me.text_pais.Location = New System.Drawing.Point(156, 63)
        Me.text_pais.Name = "text_pais"
        Me.text_pais.Size = New System.Drawing.Size(229, 27)
        Me.text_pais.TabIndex = 1
        '
        'text_departamento
        '
        Me.text_departamento.Location = New System.Drawing.Point(156, 112)
        Me.text_departamento.Name = "text_departamento"
        Me.text_departamento.Size = New System.Drawing.Size(229, 27)
        Me.text_departamento.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Departamento"
        '
        'text_municipio
        '
        Me.text_municipio.Location = New System.Drawing.Point(156, 164)
        Me.text_municipio.Name = "text_municipio"
        Me.text_municipio.Size = New System.Drawing.Size(229, 27)
        Me.text_municipio.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Municipio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(454, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tasa de Crecimiento:"
        '
        'text_poblacionInicial
        '
        Me.text_poblacionInicial.Location = New System.Drawing.Point(577, 63)
        Me.text_poblacionInicial.Name = "text_poblacionInicial"
        Me.text_poblacionInicial.Size = New System.Drawing.Size(218, 27)
        Me.text_poblacionInicial.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(454, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Población Inicial"
        '
        'text_comunidad
        '
        Me.text_comunidad.Location = New System.Drawing.Point(156, 212)
        Me.text_comunidad.Name = "text_comunidad"
        Me.text_comunidad.Size = New System.Drawing.Size(229, 27)
        Me.text_comunidad.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Comunidad"
        '
        'text_elevacionPuente
        '
        Me.text_elevacionPuente.Location = New System.Drawing.Point(969, 115)
        Me.text_elevacionPuente.Name = "text_elevacionPuente"
        Me.text_elevacionPuente.Size = New System.Drawing.Size(218, 27)
        Me.text_elevacionPuente.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(846, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Elevación Puente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(846, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Tipo de puente"
        '
        'text_dotacion
        '
        Me.text_dotacion.Location = New System.Drawing.Point(577, 161)
        Me.text_dotacion.Name = "text_dotacion"
        Me.text_dotacion.Size = New System.Drawing.Size(218, 27)
        Me.text_dotacion.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(454, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Dotación"
        '
        'text_elevacionTanque
        '
        Me.text_elevacionTanque.Location = New System.Drawing.Point(969, 167)
        Me.text_elevacionTanque.Name = "text_elevacionTanque"
        Me.text_elevacionTanque.Size = New System.Drawing.Size(218, 27)
        Me.text_elevacionTanque.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(846, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Elevación tanque"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_nuevo.FlatAppearance.BorderSize = 0
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.ForeColor = System.Drawing.Color.White
        Me.btn_nuevo.Location = New System.Drawing.Point(490, 212)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Padding = New System.Windows.Forms.Padding(0, 0, 100, 0)
        Me.btn_nuevo.Size = New System.Drawing.Size(202, 39)
        Me.btn_nuevo.TabIndex = 20
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_guardar.FlatAppearance.BorderSize = 0
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(741, 212)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Padding = New System.Windows.Forms.Padding(0, 0, 100, 0)
        Me.btn_guardar.Size = New System.Drawing.Size(202, 39)
        Me.btn_guardar.TabIndex = 21
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.Location = New System.Drawing.Point(985, 212)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Padding = New System.Windows.Forms.Padding(0, 0, 100, 0)
        Me.btn_cancelar.Size = New System.Drawing.Size(202, 39)
        Me.btn_cancelar.TabIndex = 22
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 262)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1218, 312)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de proyectos"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 26)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 29
        Me.DataGridView2.Size = New System.Drawing.Size(1206, 280)
        Me.DataGridView2.TabIndex = 1
        '
        'combox_tipoFuente
        '
        Me.combox_tipoFuente.FormattingEnabled = True
        Me.combox_tipoFuente.Items.AddRange(New Object() {"Subterranea", "Superficial"})
        Me.combox_tipoFuente.Location = New System.Drawing.Point(969, 63)
        Me.combox_tipoFuente.Name = "combox_tipoFuente"
        Me.combox_tipoFuente.Size = New System.Drawing.Size(218, 28)
        Me.combox_tipoFuente.TabIndex = 24
        '
        'text_tasaCrecimiento
        '
        Me.text_tasaCrecimiento.DecimalPlaces = 2
        Me.text_tasaCrecimiento.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.text_tasaCrecimiento.Location = New System.Drawing.Point(602, 116)
        Me.text_tasaCrecimiento.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.text_tasaCrecimiento.Minimum = New Decimal(New Integer() {25, 0, 0, 65536})
        Me.text_tasaCrecimiento.Name = "text_tasaCrecimiento"
        Me.text_tasaCrecimiento.Size = New System.Drawing.Size(193, 27)
        Me.text_tasaCrecimiento.TabIndex = 25
        Me.text_tasaCrecimiento.ThousandsSeparator = True
        Me.text_tasaCrecimiento.Value = New Decimal(New Integer() {25, 0, 0, 65536})
        '
        'NuevoProyecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.text_tasaCrecimiento)
        Me.Controls.Add(Me.combox_tipoFuente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.text_elevacionTanque)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.text_elevacionPuente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.text_dotacion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.text_poblacionInicial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.text_comunidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.text_municipio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.text_departamento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.text_pais)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NuevoProyecto"
        Me.Size = New System.Drawing.Size(1235, 618)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.text_tasaCrecimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents text_pais As TextBox
    Friend WithEvents text_departamento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents text_municipio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents text_poblacionInicial As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents text_comunidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents text_elevacionPuente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents text_dotacion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents text_elevacionTanque As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents combox_tipoFuente As ComboBox
    Friend WithEvents text_tasaCrecimiento As NumericUpDown
End Class
