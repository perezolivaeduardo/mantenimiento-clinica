<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class solicitar_mantenimiento_preventivo
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.txtcuarto = New System.Windows.Forms.TextBox()
        Me.txttarea = New System.Windows.Forms.TextBox()
        Me.Sys_tareas_preventivasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Incluir = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Sys_tareas_preventivasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MantenimientoDataSet = New Mantenimineto.mantenimientoDataSet()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sys_tareas_preventivasTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.sys_tareas_preventivasTableAdapter()
        Me.TableAdapterManager = New Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager()
        Me.StaffTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.staffTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.fecha_asignada = New System.Windows.Forms.DateTimePicker()
        Me.txtcomentarios = New System.Windows.Forms.TextBox()
        NombreLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.Sys_tareas_preventivasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sys_tareas_preventivasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(12, 82)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(85, 18)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Asignado a:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(36, 15)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(61, 18)
        Label1.TabIndex = 5
        Label1.Text = "Cuarto :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(48, 47)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(49, 18)
        Label2.TabIndex = 6
        Label2.Text = "tarea :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(36, 112)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(57, 18)
        Label3.TabIndex = 10
        Label3.Text = "Fecha :"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(12, 138)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(102, 18)
        Label4.TabIndex = 12
        Label4.Text = "Comentarios :"
        '
        'txtcuarto
        '
        Me.txtcuarto.Enabled = False
        Me.txtcuarto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcuarto.Location = New System.Drawing.Point(114, 9)
        Me.txtcuarto.Name = "txtcuarto"
        Me.txtcuarto.Size = New System.Drawing.Size(52, 24)
        Me.txtcuarto.TabIndex = 0
        '
        'txttarea
        '
        Me.txttarea.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttarea.Location = New System.Drawing.Point(114, 44)
        Me.txttarea.Name = "txttarea"
        Me.txttarea.Size = New System.Drawing.Size(320, 24)
        Me.txttarea.TabIndex = 1
        Me.txttarea.Text = "Mantenimineto Preventivo"
        '
        'Sys_tareas_preventivasDataGridView
        '
        Me.Sys_tareas_preventivasDataGridView.AutoGenerateColumns = False
        Me.Sys_tareas_preventivasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.Sys_tareas_preventivasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Sys_tareas_preventivasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sys_tareas_preventivasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Incluir})
        Me.Sys_tareas_preventivasDataGridView.DataSource = Me.Sys_tareas_preventivasBindingSource
        Me.Sys_tareas_preventivasDataGridView.Location = New System.Drawing.Point(12, 220)
        Me.Sys_tareas_preventivasDataGridView.Name = "Sys_tareas_preventivasDataGridView"
        Me.Sys_tareas_preventivasDataGridView.RowHeadersVisible = False
        Me.Sys_tareas_preventivasDataGridView.Size = New System.Drawing.Size(484, 283)
        Me.Sys_tareas_preventivasDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_tarea"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_tarea"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "area"
        Me.DataGridViewTextBoxColumn2.HeaderText = "area"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 53
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tarea"
        Me.DataGridViewTextBoxColumn3.HeaderText = "tarea"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Incluir
        '
        Me.Incluir.HeaderText = "incluir"
        Me.Incluir.Name = "Incluir"
        Me.Incluir.Width = 40
        '
        'Sys_tareas_preventivasBindingSource
        '
        Me.Sys_tareas_preventivasBindingSource.DataMember = "sys_tareas_preventivas"
        Me.Sys_tareas_preventivasBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'MantenimientoDataSet
        '
        Me.MantenimientoDataSet.DataSetName = "mantenimientoDataSet"
        Me.MantenimientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataSource = Me.StaffBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NombreComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(114, 74)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(320, 26)
        Me.NombreComboBox.TabIndex = 4
        Me.NombreComboBox.ValueMember = "id_usuario"
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "staff"
        Me.StaffBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'Sys_tareas_preventivasTableAdapter
        '
        Me.Sys_tareas_preventivasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.actividadesTableAdapter = Nothing
        Me.TableAdapterManager.areasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriasTableAdapter = Nothing
        Me.TableAdapterManager.departamentosTableAdapter = Nothing
        Me.TableAdapterManager.equiposTableAdapter = Nothing
        Me.TableAdapterManager.permisosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.reportes_tareasTableAdapter = Nothing
        Me.TableAdapterManager.reportesTableAdapter = Nothing
        Me.TableAdapterManager.rutinasTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.sys_funcionesTableAdapter = Nothing
        Me.TableAdapterManager.sys_tareas_preventivasTableAdapter = Me.Sys_tareas_preventivasTableAdapter
        Me.TableAdapterManager.tareasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(345, 509)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(426, 509)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'fecha_asignada
        '
        Me.fecha_asignada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_asignada.Location = New System.Drawing.Point(114, 107)
        Me.fecha_asignada.Name = "fecha_asignada"
        Me.fecha_asignada.Size = New System.Drawing.Size(320, 24)
        Me.fecha_asignada.TabIndex = 9
        '
        'txtcomentarios
        '
        Me.txtcomentarios.Location = New System.Drawing.Point(114, 138)
        Me.txtcomentarios.Multiline = True
        Me.txtcomentarios.Name = "txtcomentarios"
        Me.txtcomentarios.Size = New System.Drawing.Size(320, 76)
        Me.txtcomentarios.TabIndex = 11
        '
        'solicitar_mantenimiento_preventivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 543)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.txtcomentarios)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.fecha_asignada)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreComboBox)
        Me.Controls.Add(Me.Sys_tareas_preventivasDataGridView)
        Me.Controls.Add(Me.txttarea)
        Me.Controls.Add(Me.txtcuarto)
        Me.Name = "solicitar_mantenimiento_preventivo"
        Me.Text = "solicitar_mantenimiento_preventivo"
        CType(Me.Sys_tareas_preventivasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sys_tareas_preventivasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcuarto As System.Windows.Forms.TextBox
    Friend WithEvents txttarea As System.Windows.Forms.TextBox
    Friend WithEvents MantenimientoDataSet As Mantenimineto.mantenimientoDataSet
    Friend WithEvents Sys_tareas_preventivasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sys_tareas_preventivasTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.sys_tareas_preventivasTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sys_tareas_preventivasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Incluir As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StaffTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.staffTableAdapter
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents fecha_asignada As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcomentarios As System.Windows.Forms.TextBox
End Class
