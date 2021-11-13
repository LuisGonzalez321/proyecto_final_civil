<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculoBomba
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
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.text_caudal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.text_coeficiente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.text_densidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.text_alturaBombeo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label_resultadoW = New System.Windows.Forms.Label()
        Me.label_resultadoHP = New System.Windows.Forms.Label()
        Me.lista_bomba = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.lista_bomba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_cancelar.FlatAppearance.BorderSize = 0
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.ForeColor = System.Drawing.Color.White
        Me.btn_cancelar.Location = New System.Drawing.Point(452, 177)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Padding = New System.Windows.Forms.Padding(0, 0, 88, 0)
        Me.btn_cancelar.Size = New System.Drawing.Size(177, 29)
        Me.btn_cancelar.TabIndex = 33
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_guardar.FlatAppearance.BorderSize = 0
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.ForeColor = System.Drawing.Color.White
        Me.btn_guardar.Location = New System.Drawing.Point(452, 139)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Padding = New System.Windows.Forms.Padding(0, 0, 88, 0)
        Me.btn_guardar.Size = New System.Drawing.Size(177, 29)
        Me.btn_guardar.TabIndex = 32
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btn_nuevo.FlatAppearance.BorderSize = 0
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.ForeColor = System.Drawing.Color.White
        Me.btn_nuevo.Location = New System.Drawing.Point(644, 139)
        Me.btn_nuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Padding = New System.Windows.Forms.Padding(0, 0, 88, 0)
        Me.btn_nuevo.Size = New System.Drawing.Size(177, 29)
        Me.btn_nuevo.TabIndex = 31
        Me.btn_nuevo.Text = "Calcular"
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'text_caudal
        '
        Me.text_caudal.Location = New System.Drawing.Point(230, 140)
        Me.text_caudal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.text_caudal.Name = "text_caudal"
        Me.text_caudal.Size = New System.Drawing.Size(181, 23)
        Me.text_caudal.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Caudal(M3/s)"
        '
        'text_coeficiente
        '
        Me.text_coeficiente.Location = New System.Drawing.Point(230, 104)
        Me.text_coeficiente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.text_coeficiente.Name = "text_coeficiente"
        Me.text_coeficiente.Size = New System.Drawing.Size(181, 23)
        Me.text_coeficiente.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Coeficiente gravedad:"
        '
        'text_densidad
        '
        Me.text_densidad.Location = New System.Drawing.Point(230, 64)
        Me.text_densidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.text_densidad.Name = "text_densidad"
        Me.text_densidad.Size = New System.Drawing.Size(181, 23)
        Me.text_densidad.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Densidad del agua:"
        '
        'text_alturaBombeo
        '
        Me.text_alturaBombeo.Location = New System.Drawing.Point(230, 28)
        Me.text_alturaBombeo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.text_alturaBombeo.Name = "text_alturaBombeo"
        Me.text_alturaBombeo.Size = New System.Drawing.Size(181, 23)
        Me.text_alturaBombeo.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Altura de bombeo:"
        '
        'label_resultadoW
        '
        Me.label_resultadoW.AutoSize = True
        Me.label_resultadoW.Location = New System.Drawing.Point(549, 97)
        Me.label_resultadoW.Name = "label_resultadoW"
        Me.label_resultadoW.Size = New System.Drawing.Size(79, 15)
        Me.label_resultadoW.TabIndex = 34
        Me.label_resultadoW.Text = "Resultado W :"
        '
        'label_resultadoHP
        '
        Me.label_resultadoHP.AutoSize = True
        Me.label_resultadoHP.Location = New System.Drawing.Point(549, 41)
        Me.label_resultadoHP.Name = "label_resultadoHP"
        Me.label_resultadoHP.Size = New System.Drawing.Size(84, 15)
        Me.label_resultadoHP.TabIndex = 35
        Me.label_resultadoHP.Text = "Resultado HP :"
        '
        'lista_bomba
        '
        Me.lista_bomba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.lista_bomba.Location = New System.Drawing.Point(90, 208)
        Me.lista_bomba.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lista_bomba.Name = "lista_bomba"
        Me.lista_bomba.RowHeadersWidth = 51
        Me.lista_bomba.RowTemplate.Height = 29
        Me.lista_bomba.Size = New System.Drawing.Size(752, 141)
        Me.lista_bomba.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 15)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Lista de calculo de bombas del proyecto"
        '
        'CalculoBomba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lista_bomba)
        Me.Controls.Add(Me.label_resultadoHP)
        Me.Controls.Add(Me.label_resultadoW)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.text_caudal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.text_coeficiente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.text_densidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.text_alturaBombeo)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CalculoBomba"
        Me.Size = New System.Drawing.Size(996, 355)
        CType(Me.lista_bomba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents text_caudal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents text_coeficiente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents text_densidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents text_alturaBombeo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents label_resultadoW As Label
    Friend WithEvents label_resultadoHP As Label
    Friend WithEvents lista_bomba As DataGridView
    Friend WithEvents Label4 As Label
End Class
