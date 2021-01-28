<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bloqueo_cerrar
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
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim CuartoLabel As System.Windows.Forms.Label
        Dim CamaLabel As System.Windows.Forms.Label
        Dim Usuario_registraLabel As System.Windows.Forms.Label
        Dim SolicitaLabel As System.Windows.Forms.Label
        Dim Fecha_liberadoLabel As System.Windows.Forms.Label
        Dim MotivoLabel As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Me.ClinicaDataSet = New Mantenimineto.clinicaDataSet()
        Me.BloqueosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloqueosTableAdapter = New Mantenimineto.clinicaDataSetTableAdapters.bloqueosTableAdapter()
        Me.TableAdapterManager = New Mantenimineto.clinicaDataSetTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.FechaTextBox = New System.Windows.Forms.TextBox()
        Me.CuartoTextBox = New System.Windows.Forms.TextBox()
        Me.CamaTextBox = New System.Windows.Forms.TextBox()
        Me.Usuario_registraTextBox = New System.Windows.Forms.TextBox()
        Me.SolicitaTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_liberadoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MotivoTextBox = New System.Windows.Forms.TextBox()
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        CuartoLabel = New System.Windows.Forms.Label()
        CamaLabel = New System.Windows.Forms.Label()
        Usuario_registraLabel = New System.Windows.Forms.Label()
        SolicitaLabel = New System.Windows.Forms.Label()
        Fecha_liberadoLabel = New System.Windows.Forms.Label()
        MotivoLabel = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloqueosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(356, 15)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(26, 18)
        IdLabel.TabIndex = 1
        IdLabel.Text = "ID:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(74, 58)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(53, 18)
        FechaLabel.TabIndex = 3
        FechaLabel.Text = "Fecha:"
        '
        'CuartoLabel
        '
        CuartoLabel.AutoSize = True
        CuartoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CuartoLabel.Location = New System.Drawing.Point(70, 88)
        CuartoLabel.Name = "CuartoLabel"
        CuartoLabel.Size = New System.Drawing.Size(57, 18)
        CuartoLabel.TabIndex = 5
        CuartoLabel.Text = "Cuarto:"
        '
        'CamaLabel
        '
        CamaLabel.AutoSize = True
        CamaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CamaLabel.Location = New System.Drawing.Point(75, 122)
        CamaLabel.Name = "CamaLabel"
        CamaLabel.Size = New System.Drawing.Size(52, 18)
        CamaLabel.TabIndex = 7
        CamaLabel.Text = "Cama:"
        '
        'Usuario_registraLabel
        '
        Usuario_registraLabel.AutoSize = True
        Usuario_registraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Usuario_registraLabel.Location = New System.Drawing.Point(56, 152)
        Usuario_registraLabel.Name = "Usuario_registraLabel"
        Usuario_registraLabel.Size = New System.Drawing.Size(71, 18)
        Usuario_registraLabel.TabIndex = 9
        Usuario_registraLabel.Text = "Bloqueo :"
        '
        'SolicitaLabel
        '
        SolicitaLabel.AutoSize = True
        SolicitaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SolicitaLabel.Location = New System.Drawing.Point(67, 181)
        SolicitaLabel.Name = "SolicitaLabel"
        SolicitaLabel.Size = New System.Drawing.Size(60, 18)
        SolicitaLabel.TabIndex = 11
        SolicitaLabel.Text = "Solicita:"
        '
        'Fecha_liberadoLabel
        '
        Fecha_liberadoLabel.AutoSize = True
        Fecha_liberadoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_liberadoLabel.Location = New System.Drawing.Point(2, 300)
        Fecha_liberadoLabel.Name = "Fecha_liberadoLabel"
        Fecha_liberadoLabel.Size = New System.Drawing.Size(125, 18)
        Fecha_liberadoLabel.TabIndex = 19
        Fecha_liberadoLabel.Text = "Fecha Liberacion:"
        '
        'MotivoLabel
        '
        MotivoLabel.AutoSize = True
        MotivoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MotivoLabel.Location = New System.Drawing.Point(70, 220)
        MotivoLabel.Name = "MotivoLabel"
        MotivoLabel.Size = New System.Drawing.Size(57, 18)
        MotivoLabel.TabIndex = 21
        MotivoLabel.Text = "Motivo:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComentariosLabel.Location = New System.Drawing.Point(29, 340)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(98, 18)
        ComentariosLabel.TabIndex = 23
        ComentariosLabel.Text = "Comentarios:"
        '
        'ClinicaDataSet
        '
        Me.ClinicaDataSet.DataSetName = "clinicaDataSet"
        Me.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BloqueosBindingSource
        '
        Me.BloqueosBindingSource.DataMember = "bloqueos"
        Me.BloqueosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'BloqueosTableAdapter
        '
        Me.BloqueosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bloqueosTableAdapter = Me.BloqueosTableAdapter
        Me.TableAdapterManager.cuartosycamasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimineto.clinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "Id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(385, 12)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(39, 24)
        Me.IdTextBox.TabIndex = 2
        '
        'FechaTextBox
        '
        Me.FechaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "fecha", True))
        Me.FechaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaTextBox.Location = New System.Drawing.Point(133, 58)
        Me.FechaTextBox.Name = "FechaTextBox"
        Me.FechaTextBox.Size = New System.Drawing.Size(103, 24)
        Me.FechaTextBox.TabIndex = 4
        '
        'CuartoTextBox
        '
        Me.CuartoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "cuarto", True))
        Me.CuartoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuartoTextBox.Location = New System.Drawing.Point(133, 88)
        Me.CuartoTextBox.Name = "CuartoTextBox"
        Me.CuartoTextBox.Size = New System.Drawing.Size(200, 24)
        Me.CuartoTextBox.TabIndex = 6
        '
        'CamaTextBox
        '
        Me.CamaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "cama", True))
        Me.CamaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CamaTextBox.Location = New System.Drawing.Point(134, 122)
        Me.CamaTextBox.Name = "CamaTextBox"
        Me.CamaTextBox.Size = New System.Drawing.Size(54, 24)
        Me.CamaTextBox.TabIndex = 8
        '
        'Usuario_registraTextBox
        '
        Me.Usuario_registraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "usuario_registra", True))
        Me.Usuario_registraTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario_registraTextBox.Location = New System.Drawing.Point(134, 152)
        Me.Usuario_registraTextBox.Name = "Usuario_registraTextBox"
        Me.Usuario_registraTextBox.Size = New System.Drawing.Size(62, 24)
        Me.Usuario_registraTextBox.TabIndex = 10
        '
        'SolicitaTextBox
        '
        Me.SolicitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "solicita", True))
        Me.SolicitaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolicitaTextBox.Location = New System.Drawing.Point(134, 182)
        Me.SolicitaTextBox.Name = "SolicitaTextBox"
        Me.SolicitaTextBox.Size = New System.Drawing.Size(290, 24)
        Me.SolicitaTextBox.TabIndex = 12
        '
        'Fecha_liberadoDateTimePicker
        '
        Me.Fecha_liberadoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BloqueosBindingSource, "fecha_liberado", True))
        Me.Fecha_liberadoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "fecha_liberado", True))
        Me.Fecha_liberadoDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_liberadoDateTimePicker.Location = New System.Drawing.Point(134, 293)
        Me.Fecha_liberadoDateTimePicker.Name = "Fecha_liberadoDateTimePicker"
        Me.Fecha_liberadoDateTimePicker.Size = New System.Drawing.Size(290, 24)
        Me.Fecha_liberadoDateTimePicker.TabIndex = 20
        '
        'MotivoTextBox
        '
        Me.MotivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "motivo", True))
        Me.MotivoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotivoTextBox.Location = New System.Drawing.Point(134, 220)
        Me.MotivoTextBox.MaxLength = 255
        Me.MotivoTextBox.Multiline = True
        Me.MotivoTextBox.Name = "MotivoTextBox"
        Me.MotivoTextBox.Size = New System.Drawing.Size(290, 67)
        Me.MotivoTextBox.TabIndex = 22
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "comentarios", True))
        Me.ComentariosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComentariosTextBox.Location = New System.Drawing.Point(135, 323)
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(290, 72)
        Me.ComentariosTextBox.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(263, 430)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Desbloquear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(354, 430)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "status", True))
        Me.StatusTextBox.Enabled = False
        Me.StatusTextBox.Location = New System.Drawing.Point(135, 401)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.ReadOnly = True
        Me.StatusTextBox.Size = New System.Drawing.Size(38, 20)
        Me.StatusTextBox.TabIndex = 27
        '
        'bloqueo_cerrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 483)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaTextBox)
        Me.Controls.Add(CuartoLabel)
        Me.Controls.Add(Me.CuartoTextBox)
        Me.Controls.Add(CamaLabel)
        Me.Controls.Add(Me.CamaTextBox)
        Me.Controls.Add(Usuario_registraLabel)
        Me.Controls.Add(Me.Usuario_registraTextBox)
        Me.Controls.Add(SolicitaLabel)
        Me.Controls.Add(Me.SolicitaTextBox)
        Me.Controls.Add(Fecha_liberadoLabel)
        Me.Controls.Add(Me.Fecha_liberadoDateTimePicker)
        Me.Controls.Add(MotivoLabel)
        Me.Controls.Add(Me.MotivoTextBox)
        Me.Controls.Add(ComentariosLabel)
        Me.Controls.Add(Me.ComentariosTextBox)
        Me.Name = "bloqueo_cerrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desbloquear"
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloqueosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClinicaDataSet As Mantenimineto.clinicaDataSet
    Friend WithEvents BloqueosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BloqueosTableAdapter As Mantenimineto.clinicaDataSetTableAdapters.bloqueosTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimineto.clinicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CuartoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Usuario_registraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SolicitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_liberadoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MotivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComentariosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
End Class
