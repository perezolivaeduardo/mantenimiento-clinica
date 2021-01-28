<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CERRAR_REPORTE
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim Fechayhora_reparacionLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Me.MantenimientoDataSet = New Mantenimineto.mantenimientoDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.staffTableAdapter()
        Me.TableAdapterManager = New Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager()
        Me.ReportesTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.reportesTableAdapter()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.ReportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Fechayhora_reparacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.BTN_CERRAR = New System.Windows.Forms.Button()
        Me.BTN_CANCELAR = New System.Windows.Forms.Button()
        Me.Id_usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_servicio = New System.Windows.Forms.TextBox()
        NombreLabel = New System.Windows.Forms.Label()
        Fechayhora_reparacionLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(13, 61)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(271, 18)
        NombreLabel.TabIndex = 1
        NombreLabel.Text = "QUIEN SUPERVISO DE TERMINADO :"
        '
        'Fechayhora_reparacionLabel
        '
        Fechayhora_reparacionLabel.AutoSize = True
        Fechayhora_reparacionLabel.Location = New System.Drawing.Point(13, 110)
        Fechayhora_reparacionLabel.Name = "Fechayhora_reparacionLabel"
        Fechayhora_reparacionLabel.Size = New System.Drawing.Size(192, 18)
        Fechayhora_reparacionLabel.TabIndex = 2
        Fechayhora_reparacionLabel.Text = "FECHA DE REPARACION :"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(13, 152)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(144, 18)
        ObservacionesLabel.TabIndex = 4
        ObservacionesLabel.Text = "OBSERVACIONES :"
        '
        'MantenimientoDataSet
        '
        Me.MantenimientoDataSet.DataSetName = "mantenimientoDataSet"
        Me.MantenimientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "staff"
        Me.StaffBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.actividadesTableAdapter = Nothing
        Me.TableAdapterManager.areasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriasTableAdapter = Nothing
        Me.TableAdapterManager.departamentosTableAdapter = Nothing
        Me.TableAdapterManager.equipos_redTableAdapter = Nothing
        Me.TableAdapterManager.equiposTableAdapter = Nothing
        Me.TableAdapterManager.inv_documentosTableAdapter = Nothing
        Me.TableAdapterManager.inv_movimintosTableAdapter = Nothing
        Me.TableAdapterManager.inv_productosTableAdapter = Nothing
        Me.TableAdapterManager.permisosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.reportes_tareasTableAdapter = Nothing
        Me.TableAdapterManager.reportesTableAdapter = Me.ReportesTableAdapter
        Me.TableAdapterManager.rutinasTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.sys_funcionesTableAdapter = Nothing
        Me.TableAdapterManager.sys_tareas_preventivasTableAdapter = Nothing
        Me.TableAdapterManager.tareasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReportesTableAdapter
        '
        Me.ReportesTableAdapter.ClearBeforeFill = True
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataSource = Me.StaffBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(292, 61)
        Me.NombreComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(258, 26)
        Me.NombreComboBox.TabIndex = 2
        Me.NombreComboBox.ValueMember = "id_usuario"
        '
        'ReportesBindingSource
        '
        Me.ReportesBindingSource.DataMember = "reportes"
        Me.ReportesBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'Fechayhora_reparacionDateTimePicker
        '
        Me.Fechayhora_reparacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReportesBindingSource, "fechayhora_reparacion", True))
        Me.Fechayhora_reparacionDateTimePicker.Location = New System.Drawing.Point(211, 105)
        Me.Fechayhora_reparacionDateTimePicker.Name = "Fechayhora_reparacionDateTimePicker"
        Me.Fechayhora_reparacionDateTimePicker.Size = New System.Drawing.Size(339, 24)
        Me.Fechayhora_reparacionDateTimePicker.TabIndex = 3
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportesBindingSource, "observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(12, 173)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(534, 125)
        Me.ObservacionesTextBox.TabIndex = 5
        '
        'BTN_CERRAR
        '
        Me.BTN_CERRAR.Location = New System.Drawing.Point(279, 317)
        Me.BTN_CERRAR.Name = "BTN_CERRAR"
        Me.BTN_CERRAR.Size = New System.Drawing.Size(97, 35)
        Me.BTN_CERRAR.TabIndex = 6
        Me.BTN_CERRAR.Text = "Vo.Bo."
        Me.BTN_CERRAR.UseVisualStyleBackColor = True
        '
        'BTN_CANCELAR
        '
        Me.BTN_CANCELAR.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_CANCELAR.Location = New System.Drawing.Point(381, 317)
        Me.BTN_CANCELAR.Name = "BTN_CANCELAR"
        Me.BTN_CANCELAR.Size = New System.Drawing.Size(165, 35)
        Me.BTN_CANCELAR.TabIndex = 7
        Me.BTN_CANCELAR.Text = "SALIR"
        Me.BTN_CANCELAR.UseVisualStyleBackColor = True
        '
        'Id_usuarioTextBox
        '
        Me.Id_usuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "id_usuario", True))
        Me.Id_usuarioTextBox.Enabled = False
        Me.Id_usuarioTextBox.Location = New System.Drawing.Point(12, 304)
        Me.Id_usuarioTextBox.Name = "Id_usuarioTextBox"
        Me.Id_usuarioTextBox.Size = New System.Drawing.Size(32, 24)
        Me.Id_usuarioTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(398, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Reporte :"
        '
        'id_servicio
        '
        Me.id_servicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.id_servicio.Enabled = False
        Me.id_servicio.Location = New System.Drawing.Point(474, 12)
        Me.id_servicio.Name = "id_servicio"
        Me.id_servicio.Size = New System.Drawing.Size(72, 24)
        Me.id_servicio.TabIndex = 11
        '
        'CERRAR_REPORTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BTN_CANCELAR
        Me.ClientSize = New System.Drawing.Size(570, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.id_servicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Id_usuarioTextBox)
        Me.Controls.Add(Me.BTN_CANCELAR)
        Me.Controls.Add(Me.BTN_CERRAR)
        Me.Controls.Add(ObservacionesLabel)
        Me.Controls.Add(Me.ObservacionesTextBox)
        Me.Controls.Add(Fechayhora_reparacionLabel)
        Me.Controls.Add(Me.Fechayhora_reparacionDateTimePicker)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreComboBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CERRAR_REPORTE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VISTO BUENO"
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MantenimientoDataSet As Mantenimineto.mantenimientoDataSet
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.staffTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReportesTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.reportesTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ReportesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Fechayhora_reparacionDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ObservacionesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BTN_CERRAR As System.Windows.Forms.Button
    Friend WithEvents BTN_CANCELAR As System.Windows.Forms.Button
    Friend WithEvents Id_usuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents id_servicio As System.Windows.Forms.TextBox
End Class
