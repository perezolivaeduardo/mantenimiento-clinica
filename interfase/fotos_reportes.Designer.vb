<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fotos_reportes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_agregar = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.txtidreporte = New System.Windows.Forms.TextBox()
        Me.txtreporte = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_cargar = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_agregar
        '
        Me.Btn_agregar.Location = New System.Drawing.Point(799, 425)
        Me.Btn_agregar.Name = "Btn_agregar"
        Me.Btn_agregar.Size = New System.Drawing.Size(115, 39)
        Me.Btn_agregar.TabIndex = 0
        Me.Btn_agregar.Text = "Asignar Foto"
        Me.Btn_agregar.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(25, 65)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(512, 254)
        Me.dgv.TabIndex = 1
        '
        'imagen
        '
        Me.imagen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imagen.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.imagen.Location = New System.Drawing.Point(543, 28)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(371, 392)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagen.TabIndex = 2
        Me.imagen.TabStop = False
        '
        'txtidreporte
        '
        Me.txtidreporte.Location = New System.Drawing.Point(89, 12)
        Me.txtidreporte.Name = "txtidreporte"
        Me.txtidreporte.Size = New System.Drawing.Size(100, 20)
        Me.txtidreporte.TabIndex = 3
        '
        'txtreporte
        '
        Me.txtreporte.Location = New System.Drawing.Point(89, 39)
        Me.txtreporte.Name = "txtreporte"
        Me.txtreporte.Size = New System.Drawing.Size(448, 20)
        Me.txtreporte.TabIndex = 4
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(25, 345)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(512, 66)
        Me.txtdescripcion.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "# Reporte :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Reporte :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Descripcion de la foto"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(543, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 39)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Borrar Foto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_cargar
        '
        Me.btn_cargar.Location = New System.Drawing.Point(12, 417)
        Me.btn_cargar.Name = "btn_cargar"
        Me.btn_cargar.Size = New System.Drawing.Size(115, 39)
        Me.btn_cargar.TabIndex = 10
        Me.btn_cargar.Text = "Cargar"
        Me.btn_cargar.UseVisualStyleBackColor = True
        '
        'fotos_reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 476)
        Me.Controls.Add(Me.btn_cargar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.txtreporte)
        Me.Controls.Add(Me.txtidreporte)
        Me.Controls.Add(Me.imagen)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Btn_agregar)
        Me.Name = "fotos_reportes"
        Me.Text = "Asignar Fotos a Reportes"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_agregar As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents imagen As System.Windows.Forms.PictureBox
    Friend WithEvents txtidreporte As System.Windows.Forms.TextBox
    Friend WithEvents txtreporte As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_cargar As System.Windows.Forms.Button
End Class
