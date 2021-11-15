<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaProyeccion
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
        Me.label_tasa = New System.Windows.Forms.Label()
        Me.label_dotacion = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_perdidas = New System.Windows.Forms.TextBox()
        Me.txt_consumoP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_consumoC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_consumoI = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabla_proyectos = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.listaCalculos = New System.Windows.Forms.DataGridView()
        Me.txt_poblacion0 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.text_años = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_factorcmd = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_almacenamiento = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_cmh = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tabla_proyectos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.listaCalculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.text_años, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_tasa
        '
        Me.label_tasa.AutoSize = True
        Me.label_tasa.Location = New System.Drawing.Point(28, 20)
        Me.label_tasa.Name = "label_tasa"
        Me.label_tasa.Size = New System.Drawing.Size(147, 20)
        Me.label_tasa.TabIndex = 0
        Me.label_tasa.Text = "Tasa de crecimiento: "
        '
        'label_dotacion
        '
        Me.label_dotacion.AutoSize = True
        Me.label_dotacion.Location = New System.Drawing.Point(224, 20)
        Me.label_dotacion.Name = "label_dotacion"
        Me.label_dotacion.Size = New System.Drawing.Size(77, 20)
        Me.label_dotacion.TabIndex = 1
        Me.label_dotacion.Text = "Dotación: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Perdidas técnicas:"
        '
        'txt_perdidas
        '
        Me.txt_perdidas.Location = New System.Drawing.Point(201, 69)
        Me.txt_perdidas.Name = "txt_perdidas"
        Me.txt_perdidas.Size = New System.Drawing.Size(125, 27)
        Me.txt_perdidas.TabIndex = 3
        '
        'txt_consumoP
        '
        Me.txt_consumoP.Location = New System.Drawing.Point(201, 134)
        Me.txt_consumoP.Name = "txt_consumoP"
        Me.txt_consumoP.Size = New System.Drawing.Size(125, 27)
        Me.txt_consumoP.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Consumo Público o inst:"
        '
        'txt_consumoC
        '
        Me.txt_consumoC.Location = New System.Drawing.Point(491, 73)
        Me.txt_consumoC.Name = "txt_consumoC"
        Me.txt_consumoC.Size = New System.Drawing.Size(125, 27)
        Me.txt_consumoC.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(342, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Consumo comercial:"
        '
        'txt_consumoI
        '
        Me.txt_consumoI.Location = New System.Drawing.Point(478, 138)
        Me.txt_consumoI.Name = "txt_consumoI"
        Me.txt_consumoI.Size = New System.Drawing.Size(138, 27)
        Me.txt_consumoI.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(342, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Consumo Insutrial:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.Location = New System.Drawing.Point(224, 200)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Padding = New System.Windows.Forms.Padding(0, 0, 100, 0)
        Me.btn_cancelar.Size = New System.Drawing.Size(202, 39)
        Me.btn_cancelar.TabIndex = 36
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_guardar.FlatAppearance.BorderSize = 0
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(18, 452)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Padding = New System.Windows.Forms.Padding(0, 0, 100, 0)
        Me.btn_guardar.Size = New System.Drawing.Size(202, 39)
        Me.btn_guardar.TabIndex = 35
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_calcular
        '
        Me.btn_calcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_calcular.FlatAppearance.BorderSize = 0
        Me.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_calcular.ForeColor = System.Drawing.Color.White
        Me.btn_calcular.Location = New System.Drawing.Point(16, 200)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Padding = New System.Windows.Forms.Padding(0, 0, 100, 0)
        Me.btn_calcular.Size = New System.Drawing.Size(202, 39)
        Me.btn_calcular.TabIndex = 34
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tabla_proyectos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 506)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1121, 179)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registros Proyección de Poblacion y consumo"
        '
        'tabla_proyectos
        '
        Me.tabla_proyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_proyectos.Location = New System.Drawing.Point(15, 26)
        Me.tabla_proyectos.Name = "tabla_proyectos"
        Me.tabla_proyectos.RowHeadersWidth = 51
        Me.tabla_proyectos.RowTemplate.Height = 29
        Me.tabla_proyectos.Size = New System.Drawing.Size(1106, 147)
        Me.tabla_proyectos.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.listaCalculos)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1130, 179)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proyección de Poblacion y consumo"
        '
        'listaCalculos
        '
        Me.listaCalculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaCalculos.Location = New System.Drawing.Point(15, 26)
        Me.listaCalculos.Name = "listaCalculos"
        Me.listaCalculos.RowHeadersWidth = 51
        Me.listaCalculos.RowTemplate.Height = 29
        Me.listaCalculos.Size = New System.Drawing.Size(1115, 147)
        Me.listaCalculos.TabIndex = 0
        '
        'txt_poblacion0
        '
        Me.txt_poblacion0.Location = New System.Drawing.Point(766, 73)
        Me.txt_poblacion0.Name = "txt_poblacion0"
        Me.txt_poblacion0.Size = New System.Drawing.Size(125, 27)
        Me.txt_poblacion0.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(635, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 20)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Población Inicial:"
        '
        'text_años
        '
        Me.text_años.Location = New System.Drawing.Point(766, 133)
        Me.text_años.Name = "text_años"
        Me.text_años.Size = New System.Drawing.Size(125, 27)
        Me.text_años.TabIndex = 42
        Me.text_años.ThousandsSeparator = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(640, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 20)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Años:"
        '
        'txt_factorcmd
        '
        Me.txt_factorcmd.Location = New System.Drawing.Point(1008, 69)
        Me.txt_factorcmd.Name = "txt_factorcmd"
        Me.txt_factorcmd.Size = New System.Drawing.Size(125, 27)
        Me.txt_factorcmd.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(913, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Factor CMD:"
        '
        'txt_almacenamiento
        '
        Me.txt_almacenamiento.Location = New System.Drawing.Point(771, 206)
        Me.txt_almacenamiento.Name = "txt_almacenamiento"
        Me.txt_almacenamiento.Size = New System.Drawing.Size(125, 27)
        Me.txt_almacenamiento.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(640, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 20)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Almacenamiento:"
        '
        'txt_cmh
        '
        Me.txt_cmh.Location = New System.Drawing.Point(1008, 132)
        Me.txt_cmh.Name = "txt_cmh"
        Me.txt_cmh.Size = New System.Drawing.Size(125, 27)
        Me.txt_cmh.TabIndex = 48
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(913, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 20)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Factor CMH:"
        '
        'NuevaProyeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txt_cmh)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_factorcmd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_almacenamiento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.text_años)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_poblacion0)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.txt_consumoI)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_consumoC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_consumoP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_perdidas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label_dotacion)
        Me.Controls.Add(Me.label_tasa)
        Me.Name = "NuevaProyeccion"
        Me.Size = New System.Drawing.Size(1148, 720)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.tabla_proyectos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.listaCalculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.text_años, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_tasa As Label
    Friend WithEvents label_dotacion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_perdidas As TextBox
    Friend WithEvents txt_consumoP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_consumoC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_consumoI As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_calcular As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tabla_proyectos As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents listaCalculos As DataGridView
    Friend WithEvents txt_poblacion0 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Public WithEvents text_años As NumericUpDown
    Friend WithEvents txt_factorcmd As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_almacenamiento As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_cmh As TextBox
    Friend WithEvents Label11 As Label
End Class
