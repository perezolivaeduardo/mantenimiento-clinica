<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bloqueo
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
        Dim FechaLabel As System.Windows.Forms.Label
        Dim CuartoLabel As System.Windows.Forms.Label
        Dim MotivoLabel As System.Windows.Forms.Label
        Dim DiasLabel As System.Windows.Forms.Label
        Dim HorasLabel As System.Windows.Forms.Label
        Dim Usuario_registraLabel As System.Windows.Forms.Label
        Dim SolicitaLabel As System.Windows.Forms.Label
        Me.CuartoTextBox = New System.Windows.Forms.TextBox()
        Me.BloqueosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSet = New Mantenimineto.clinicaDataSet()
        Me.MotivoTextBox = New System.Windows.Forms.TextBox()
        Me.DiasTextBox = New System.Windows.Forms.TextBox()
        Me.HorasTextBox = New System.Windows.Forms.TextBox()
        Me.btn_bloquear = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Usuario_registraTextBox = New System.Windows.Forms.TextBox()
        Me.SolicitaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaTextBox = New System.Windows.Forms.TextBox()
        Me.Inicia_bloqueoTextBox = New System.Windows.Forms.TextBox()
        Me.BloqueosTableAdapter = New Mantenimineto.clinicaDataSetTableAdapters.bloqueosTableAdapter()
        Me.TableAdapterManager = New Mantenimineto.clinicaDataSetTableAdapters.TableAdapterManager()
        FechaLabel = New System.Windows.Forms.Label()
        CuartoLabel = New System.Windows.Forms.Label()
        MotivoLabel = New System.Windows.Forms.Label()
        DiasLabel = New System.Windows.Forms.Label()
        HorasLabel = New System.Windows.Forms.Label()
        Usuario_registraLabel = New System.Windows.Forms.Label()
        SolicitaLabel = New System.Windows.Forms.Label()
        CType(Me.BloqueosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(27, 20)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(53, 18)
        FechaLabel.TabIndex = 1
        FechaLabel.Text = "Fecha:"
        '
        'CuartoLabel
        '
        CuartoLabel.AutoSize = True
        CuartoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CuartoLabel.Location = New System.Drawing.Point(23, 54)
        CuartoLabel.Name = "CuartoLabel"
        CuartoLabel.Size = New System.Drawing.Size(57, 18)
        CuartoLabel.TabIndex = 3
        CuartoLabel.Text = "Cuarto:"
        '
        'MotivoLabel
        '
        MotivoLabel.AutoSize = True
        MotivoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MotivoLabel.Location = New System.Drawing.Point(23, 120)
        MotivoLabel.Name = "MotivoLabel"
        MotivoLabel.Size = New System.Drawing.Size(57, 18)
        MotivoLabel.TabIndex = 4
        MotivoLabel.Text = "Motivo:"
        '
        'DiasLabel
        '
        DiasLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        DiasLabel.AutoSize = True
        DiasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DiasLabel.Location = New System.Drawing.Point(247, 217)
        DiasLabel.Name = "DiasLabel"
        DiasLabel.Size = New System.Drawing.Size(39, 18)
        DiasLabel.TabIndex = 6
        DiasLabel.Text = "dias:"
        '
        'HorasLabel
        '
        HorasLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        HorasLabel.AutoSize = True
        HorasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HorasLabel.Location = New System.Drawing.Point(348, 217)
        HorasLabel.Name = "HorasLabel"
        HorasLabel.Size = New System.Drawing.Size(50, 18)
        HorasLabel.TabIndex = 8
        HorasLabel.Text = "horas:"
        '
        'Usuario_registraLabel
        '
        Usuario_registraLabel.AutoSize = True
        Usuario_registraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Usuario_registraLabel.Location = New System.Drawing.Point(33, 256)
        Usuario_registraLabel.Name = "Usuario_registraLabel"
        Usuario_registraLabel.Size = New System.Drawing.Size(114, 18)
        Usuario_registraLabel.TabIndex = 13
        Usuario_registraLabel.Text = "usuario registra:"
        '
        'SolicitaLabel
        '
        SolicitaLabel.AutoSize = True
        SolicitaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SolicitaLabel.Location = New System.Drawing.Point(22, 84)
        SolicitaLabel.Name = "SolicitaLabel"
        SolicitaLabel.Size = New System.Drawing.Size(58, 18)
        SolicitaLabel.TabIndex = 15
        SolicitaLabel.Text = "solicita:"
        '
        'CuartoTextBox
        '
        Me.CuartoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "cuarto", True))
        Me.CuartoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuartoTextBox.Location = New System.Drawing.Point(86, 51)
        Me.CuartoTextBox.Name = "CuartoTextBox"
        Me.CuartoTextBox.Size = New System.Drawing.Size(43, 24)
        Me.CuartoTextBox.TabIndex = 4
        '
        'BloqueosBindingSource
        '
        Me.BloqueosBindingSource.DataMember = "bloqueos"
        Me.BloqueosBindingSource.DataSource = Me.ClinicaDataSet
        '
        'ClinicaDataSet
        '
        Me.ClinicaDataSet.DataSetName = "clinicaDataSet"
        Me.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MotivoTextBox
        '
        Me.MotivoTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MotivoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "motivo", True))
        Me.MotivoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotivoTextBox.Location = New System.Drawing.Point(86, 120)
        Me.MotivoTextBox.Multiline = True
        Me.MotivoTextBox.Name = "MotivoTextBox"
        Me.MotivoTextBox.Size = New System.Drawing.Size(359, 76)
        Me.MotivoTextBox.TabIndex = 5
        '
        'DiasTextBox
        '
        Me.DiasTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DiasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "dias", True))
        Me.DiasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiasTextBox.Location = New System.Drawing.Point(292, 214)
        Me.DiasTextBox.Name = "DiasTextBox"
        Me.DiasTextBox.Size = New System.Drawing.Size(39, 24)
        Me.DiasTextBox.TabIndex = 7
        '
        'HorasTextBox
        '
        Me.HorasTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HorasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "horas", True))
        Me.HorasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HorasTextBox.Location = New System.Drawing.Point(404, 214)
        Me.HorasTextBox.Name = "HorasTextBox"
        Me.HorasTextBox.Size = New System.Drawing.Size(36, 24)
        Me.HorasTextBox.TabIndex = 9
        '
        'btn_bloquear
        '
        Me.btn_bloquear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_bloquear.Enabled = False
        Me.btn_bloquear.Location = New System.Drawing.Point(284, 289)
        Me.btn_bloquear.Name = "btn_bloquear"
        Me.btn_bloquear.Size = New System.Drawing.Size(75, 23)
        Me.btn_bloquear.TabIndex = 10
        Me.btn_bloquear.Text = "Bloquear"
        Me.btn_bloquear.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(365, 289)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tiempo Estimado de Bloqueo"
        '
        'Usuario_registraTextBox
        '
        Me.Usuario_registraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "usuario_registra", True))
        Me.Usuario_registraTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usuario_registraTextBox.Location = New System.Drawing.Point(153, 253)
        Me.Usuario_registraTextBox.Name = "Usuario_registraTextBox"
        Me.Usuario_registraTextBox.ReadOnly = True
        Me.Usuario_registraTextBox.Size = New System.Drawing.Size(33, 24)
        Me.Usuario_registraTextBox.TabIndex = 14
        '
        'SolicitaTextBox
        '
        Me.SolicitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "solicita", True))
        Me.SolicitaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolicitaTextBox.Location = New System.Drawing.Point(86, 81)
        Me.SolicitaTextBox.Name = "SolicitaTextBox"
        Me.SolicitaTextBox.Size = New System.Drawing.Size(354, 24)
        Me.SolicitaTextBox.TabIndex = 16
        '
        'FechaTextBox
        '
        Me.FechaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "fecha", True))
        Me.FechaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaTextBox.Location = New System.Drawing.Point(86, 20)
        Me.FechaTextBox.Name = "FechaTextBox"
        Me.FechaTextBox.Size = New System.Drawing.Size(155, 24)
        Me.FechaTextBox.TabIndex = 18
        '
        'Inicia_bloqueoTextBox
        '
        Me.Inicia_bloqueoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloqueosBindingSource, "inicia_bloqueo", True))
        Me.Inicia_bloqueoTextBox.Location = New System.Drawing.Point(153, 301)
        Me.Inicia_bloqueoTextBox.Name = "Inicia_bloqueoTextBox"
        Me.Inicia_bloqueoTextBox.Size = New System.Drawing.Size(33, 20)
        Me.Inicia_bloqueoTextBox.TabIndex = 20
        Me.Inicia_bloqueoTextBox.Visible = False
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
        'Bloqueo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 324)
        Me.Controls.Add(Me.Inicia_bloqueoTextBox)
        Me.Controls.Add(Me.FechaTextBox)
        Me.Controls.Add(SolicitaLabel)
        Me.Controls.Add(Me.SolicitaTextBox)
        Me.Controls.Add(Usuario_registraLabel)
        Me.Controls.Add(Me.Usuario_registraTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_bloquear)
        Me.Controls.Add(HorasLabel)
        Me.Controls.Add(Me.HorasTextBox)
        Me.Controls.Add(DiasLabel)
        Me.Controls.Add(Me.DiasTextBox)
        Me.Controls.Add(MotivoLabel)
        Me.Controls.Add(Me.MotivoTextBox)
        Me.Controls.Add(CuartoLabel)
        Me.Controls.Add(Me.CuartoTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Name = "Bloqueo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bloqueo"
        CType(Me.BloqueosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClinicaDataSet As Mantenimineto.clinicaDataSet
    Friend WithEvents BloqueosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BloqueosTableAdapter As Mantenimineto.clinicaDataSetTableAdapters.bloqueosTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimineto.clinicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CuartoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotivoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HorasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btn_bloquear As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Usuario_registraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SolicitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Inicia_bloqueoTextBox As System.Windows.Forms.TextBox
End Class
