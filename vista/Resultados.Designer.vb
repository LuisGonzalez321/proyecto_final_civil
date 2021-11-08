<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resultados
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
        Me.label_consumoMaximoDia = New System.Windows.Forms.Label()
        Me.c = New System.Windows.Forms.Label()
        Me.label_almacenamiento = New System.Windows.Forms.Label()
        Me.label_clasificacionAgua = New System.Windows.Forms.Label()
        Me.label_potencia = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label_consumoMaximoDia
        '
        Me.label_consumoMaximoDia.AutoSize = True
        Me.label_consumoMaximoDia.Location = New System.Drawing.Point(33, 37)
        Me.label_consumoMaximoDia.Name = "label_consumoMaximoDia"
        Me.label_consumoMaximoDia.Size = New System.Drawing.Size(194, 20)
        Me.label_consumoMaximoDia.TabIndex = 0
        Me.label_consumoMaximoDia.Text = "Consumo maximo dia(LPS): "
        '
        'c
        '
        Me.c.AutoSize = True
        Me.c.Location = New System.Drawing.Point(33, 84)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(203, 20)
        Me.c.TabIndex = 1
        Me.c.Text = "Consumo maximo hora(LPS): "
        '
        'label_almacenamiento
        '
        Me.label_almacenamiento.AutoSize = True
        Me.label_almacenamiento.Location = New System.Drawing.Point(33, 131)
        Me.label_almacenamiento.Name = "label_almacenamiento"
        Me.label_almacenamiento.Size = New System.Drawing.Size(125, 20)
        Me.label_almacenamiento.TabIndex = 2
        Me.label_almacenamiento.Text = "Almacenamiento:"
        '
        'label_clasificacionAgua
        '
        Me.label_clasificacionAgua.AutoSize = True
        Me.label_clasificacionAgua.Location = New System.Drawing.Point(33, 178)
        Me.label_clasificacionAgua.Name = "label_clasificacionAgua"
        Me.label_clasificacionAgua.Size = New System.Drawing.Size(157, 20)
        Me.label_clasificacionAgua.TabIndex = 3
        Me.label_clasificacionAgua.Text = "Clasificacion del agua:"
        '
        'label_potencia
        '
        Me.label_potencia.AutoSize = True
        Me.label_potencia.Location = New System.Drawing.Point(33, 225)
        Me.label_potencia.Name = "label_potencia"
        Me.label_potencia.Size = New System.Drawing.Size(97, 20)
        Me.label_potencia.TabIndex = 4
        Me.label_potencia.Text = "Potencia(HP):"
        '
        'Resultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.label_potencia)
        Me.Controls.Add(Me.label_clasificacionAgua)
        Me.Controls.Add(Me.label_almacenamiento)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.label_consumoMaximoDia)
        Me.Name = "Resultados"
        Me.Size = New System.Drawing.Size(474, 271)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_consumoMaximoDia As Label
    Friend WithEvents c As Label
    Friend WithEvents label_almacenamiento As Label
    Friend WithEvents label_clasificacionAgua As Label
    Friend WithEvents label_potencia As Label
End Class
