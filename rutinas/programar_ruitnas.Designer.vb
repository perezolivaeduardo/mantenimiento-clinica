<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class programar_ruitnas
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
        Dim Id_rutinaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim DiaLabel As System.Windows.Forms.Label
        Dim TipoLabel1 As System.Windows.Forms.Label
        Dim Dia_mesLabel1 As System.Windows.Forms.Label
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.dia = New System.Windows.Forms.TextBox()
        Me.resultado = New System.Windows.Forms.TextBox()
        Me.kdia = New System.Windows.Forms.NumericUpDown()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Sql_rutinasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sql_rutinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MantenimientoDataSet = New Mantenimineto.mantenimientoDataSet()
        Me.NdiaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_tipoTextBox = New System.Windows.Forms.TextBox()
        Me.Dia_mesTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.DiaTextBox = New System.Windows.Forms.TextBox()
        Me.txtsiguiente = New System.Windows.Forms.TextBox()
        Me.ufecha = New System.Windows.Forms.TextBox()
        Me.Id_rutinaTextBox = New System.Windows.Forms.TextBox()
        Me.Rutinas_programacionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rutinas_programacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.calendario = New System.Windows.Forms.MonthCalendar()
        Me.Sql_rutinasTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.sql_rutinasTableAdapter()
        Me.TableAdapterManager = New Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager()
        Me.Rutinas_programacionTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.rutinas_programacionTableAdapter()
        Me.RutinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RutinasTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.rutinasTableAdapter()
        Id_rutinaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        DiaLabel = New System.Windows.Forms.Label()
        TipoLabel1 = New System.Windows.Forms.Label()
        Dia_mesLabel1 = New System.Windows.Forms.Label()
        CType(Me.kdia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.Sql_rutinasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_rutinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rutinas_programacionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rutinas_programacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RutinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_rutinaLabel
        '
        Id_rutinaLabel.AutoSize = True
        Id_rutinaLabel.Location = New System.Drawing.Point(16, 20)
        Id_rutinaLabel.Name = "Id_rutinaLabel"
        Id_rutinaLabel.Size = New System.Drawing.Size(47, 13)
        Id_rutinaLabel.TabIndex = 0
        Id_rutinaLabel.Text = "id rutina:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(16, 46)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(57, 13)
        Label1.TabIndex = 3
        Label1.Text = "U. Fecha :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 72)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(60, 13)
        Label2.TabIndex = 5
        Label2.Text = "Siguiente  :"
        '
        'DiaLabel
        '
        DiaLabel.AutoSize = True
        DiaLabel.Location = New System.Drawing.Point(227, 49)
        DiaLabel.Name = "DiaLabel"
        DiaLabel.Size = New System.Drawing.Size(24, 13)
        DiaLabel.TabIndex = 10
        DiaLabel.Text = "dia:"
        '
        'TipoLabel1
        '
        TipoLabel1.AutoSize = True
        TipoLabel1.Location = New System.Drawing.Point(224, 20)
        TipoLabel1.Name = "TipoLabel1"
        TipoLabel1.Size = New System.Drawing.Size(27, 13)
        TipoLabel1.TabIndex = 11
        TipoLabel1.Text = "tipo:"
        '
        'Dia_mesLabel1
        '
        Dia_mesLabel1.AutoSize = True
        Dia_mesLabel1.Location = New System.Drawing.Point(205, 75)
        Dia_mesLabel1.Name = "Dia_mesLabel1"
        Dia_mesLabel1.Size = New System.Drawing.Size(46, 13)
        Dia_mesLabel1.TabIndex = 13
        Dia_mesLabel1.Text = "dia mes:"
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(103, 68)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(500, 20)
        Me.fecha.TabIndex = 0
        '
        'dia
        '
        Me.dia.Location = New System.Drawing.Point(367, 68)
        Me.dia.Name = "dia"
        Me.dia.Size = New System.Drawing.Size(42, 20)
        Me.dia.TabIndex = 2
        '
        'resultado
        '
        Me.resultado.Location = New System.Drawing.Point(103, 120)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(146, 20)
        Me.resultado.TabIndex = 3
        '
        'kdia
        '
        Me.kdia.Location = New System.Drawing.Point(103, 94)
        Me.kdia.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.kdia.Name = "kdia"
        Me.kdia.Size = New System.Drawing.Size(120, 20)
        Me.kdia.TabIndex = 4
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 30)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Rutinas_programacionDataGridView)
        Me.SplitContainer1.Panel2.Controls.Add(Me.calendario)
        Me.SplitContainer1.Size = New System.Drawing.Size(1174, 562)
        Me.SplitContainer1.SplitterDistance = 653
        Me.SplitContainer1.TabIndex = 5
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.Sql_rutinasDataGridView)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.NdiaTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Id_tipoTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Dia_mesLabel1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Dia_mesTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(TipoLabel1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TipoTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(DiaLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.DiaTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Label2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtsiguiente)
        Me.SplitContainer2.Panel2.Controls.Add(Label1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ufecha)
        Me.SplitContainer2.Panel2.Controls.Add(Id_rutinaLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Id_rutinaTextBox)
        Me.SplitContainer2.Size = New System.Drawing.Size(653, 562)
        Me.SplitContainer2.SplitterDistance = 311
        Me.SplitContainer2.TabIndex = 0
        '
        'Sql_rutinasDataGridView
        '
        Me.Sql_rutinasDataGridView.AllowUserToAddRows = False
        Me.Sql_rutinasDataGridView.AllowUserToDeleteRows = False
        Me.Sql_rutinasDataGridView.AutoGenerateColumns = False
        Me.Sql_rutinasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Sql_rutinasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Sql_rutinasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sql_rutinasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.id_tipo, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn8})
        Me.Sql_rutinasDataGridView.DataSource = Me.Sql_rutinasBindingSource
        Me.Sql_rutinasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Sql_rutinasDataGridView.Name = "Sql_rutinasDataGridView"
        Me.Sql_rutinasDataGridView.RowHeadersVisible = False
        Me.Sql_rutinasDataGridView.Size = New System.Drawing.Size(634, 292)
        Me.Sql_rutinasDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "id_rutina"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 43
        '
        'id_tipo
        '
        Me.id_tipo.DataPropertyName = "id_tipo"
        Me.id_tipo.HeaderText = "T"
        Me.id_tipo.Name = "id_tipo"
        Me.id_tipo.Width = 39
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 49
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "dia"
        Me.DataGridViewTextBoxColumn2.HeaderText = "dia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 46
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "dia_mes"
        Me.DataGridViewTextBoxColumn3.HeaderText = "dia_mes"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 71
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "lugar_en_el_mes"
        Me.DataGridViewTextBoxColumn4.HeaderText = "#"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 39
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "tarea"
        Me.DataGridViewTextBoxColumn7.HeaderText = "tarea"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 56
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "status"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 41
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "detalle"
        Me.DataGridViewTextBoxColumn8.HeaderText = "detalle"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 63
        '
        'Sql_rutinasBindingSource
        '
        Me.Sql_rutinasBindingSource.DataMember = "sql_rutinas"
        Me.Sql_rutinasBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'MantenimientoDataSet
        '
        Me.MantenimientoDataSet.DataSetName = "mantenimientoDataSet"
        Me.MantenimientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NdiaTextBox
        '
        Me.NdiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_rutinasBindingSource, "ndia", True))
        Me.NdiaTextBox.Location = New System.Drawing.Point(363, 49)
        Me.NdiaTextBox.Name = "NdiaTextBox"
        Me.NdiaTextBox.Size = New System.Drawing.Size(25, 20)
        Me.NdiaTextBox.TabIndex = 16
        '
        'Id_tipoTextBox
        '
        Me.Id_tipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_rutinasBindingSource, "id_tipo", True))
        Me.Id_tipoTextBox.Location = New System.Drawing.Point(363, 17)
        Me.Id_tipoTextBox.Name = "Id_tipoTextBox"
        Me.Id_tipoTextBox.Size = New System.Drawing.Size(21, 20)
        Me.Id_tipoTextBox.TabIndex = 15
        '
        'Dia_mesTextBox
        '
        Me.Dia_mesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_rutinasBindingSource, "dia_mes", True))
        Me.Dia_mesTextBox.Location = New System.Drawing.Point(257, 72)
        Me.Dia_mesTextBox.Name = "Dia_mesTextBox"
        Me.Dia_mesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Dia_mesTextBox.TabIndex = 14
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_rutinasBindingSource, "tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(257, 17)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TipoTextBox.TabIndex = 12
        '
        'DiaTextBox
        '
        Me.DiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_rutinasBindingSource, "dia", True))
        Me.DiaTextBox.Location = New System.Drawing.Point(257, 46)
        Me.DiaTextBox.Name = "DiaTextBox"
        Me.DiaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DiaTextBox.TabIndex = 11
        '
        'txtsiguiente
        '
        Me.txtsiguiente.Location = New System.Drawing.Point(78, 69)
        Me.txtsiguiente.Name = "txtsiguiente"
        Me.txtsiguiente.Size = New System.Drawing.Size(100, 20)
        Me.txtsiguiente.TabIndex = 4
        '
        'ufecha
        '
        Me.ufecha.Location = New System.Drawing.Point(78, 43)
        Me.ufecha.Name = "ufecha"
        Me.ufecha.Size = New System.Drawing.Size(100, 20)
        Me.ufecha.TabIndex = 2
        '
        'Id_rutinaTextBox
        '
        Me.Id_rutinaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_rutinasBindingSource, "id_rutina", True))
        Me.Id_rutinaTextBox.Location = New System.Drawing.Point(78, 17)
        Me.Id_rutinaTextBox.Name = "Id_rutinaTextBox"
        Me.Id_rutinaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_rutinaTextBox.TabIndex = 1
        '
        'Rutinas_programacionDataGridView
        '
        Me.Rutinas_programacionDataGridView.AllowUserToAddRows = False
        Me.Rutinas_programacionDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Rutinas_programacionDataGridView.AutoGenerateColumns = False
        Me.Rutinas_programacionDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Rutinas_programacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Rutinas_programacionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.Rutinas_programacionDataGridView.DataSource = Me.Rutinas_programacionBindingSource
        Me.Rutinas_programacionDataGridView.Location = New System.Drawing.Point(8, 223)
        Me.Rutinas_programacionDataGridView.Name = "Rutinas_programacionDataGridView"
        Me.Rutinas_programacionDataGridView.RowHeadersVisible = False
        Me.Rutinas_programacionDataGridView.Size = New System.Drawing.Size(497, 326)
        Me.Rutinas_programacionDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id_rutina"
        Me.DataGridViewTextBoxColumn5.HeaderText = "id_rutina"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "id_usuario_realizo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "id_usuario_realizo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn11.HeaderText = "status"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Fechayhoraderealizacion"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Fechayhoraderealizacion"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "comentarios"
        Me.DataGridViewTextBoxColumn13.HeaderText = "comentarios"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "horaderegistro"
        Me.DataGridViewTextBoxColumn14.HeaderText = "horaderegistro"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "fechayhoradeverificacion"
        Me.DataGridViewTextBoxColumn15.HeaderText = "fechayhoradeverificacion"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "id_usuario_verifico"
        Me.DataGridViewTextBoxColumn16.HeaderText = "id_usuario_verifico"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'Rutinas_programacionBindingSource
        '
        Me.Rutinas_programacionBindingSource.DataMember = "rutinas_programacion"
        Me.Rutinas_programacionBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'calendario
        '
        Me.calendario.CalendarDimensions = New System.Drawing.Size(2, 1)
        Me.calendario.Dock = System.Windows.Forms.DockStyle.Top
        Me.calendario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calendario.Location = New System.Drawing.Point(0, 0)
        Me.calendario.Name = "calendario"
        Me.calendario.TabIndex = 0
        '
        'Sql_rutinasTableAdapter
        '
        Me.Sql_rutinasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.actividadesTableAdapter = Nothing
        Me.TableAdapterManager.areasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriasTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.departamentosTableAdapter = Nothing
        Me.TableAdapterManager.equiposTableAdapter = Nothing
        Me.TableAdapterManager.permisosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.reportes_tareasTableAdapter = Nothing
        Me.TableAdapterManager.reportesTableAdapter = Nothing
        Me.TableAdapterManager.rutinas_programacionTableAdapter = Nothing
        Me.TableAdapterManager.rutinasTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.sys_funcionesTableAdapter = Nothing
        Me.TableAdapterManager.sys_tareas_preventivasTableAdapter = Nothing
        Me.TableAdapterManager.tareasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Rutinas_programacionTableAdapter
        '
        Me.Rutinas_programacionTableAdapter.ClearBeforeFill = True
        '
        'RutinasBindingSource
        '
        Me.RutinasBindingSource.DataMember = "rutinas"
        Me.RutinasBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'RutinasTableAdapter
        '
        Me.RutinasTableAdapter.ClearBeforeFill = True
        '
        'programar_ruitnas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 627)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.kdia)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.dia)
        Me.Controls.Add(Me.fecha)
        Me.Name = "programar_ruitnas"
        Me.Text = "programar_ruitnas"
        CType(Me.kdia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.Sql_rutinasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_rutinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rutinas_programacionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rutinas_programacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RutinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dia As System.Windows.Forms.TextBox
    Friend WithEvents resultado As System.Windows.Forms.TextBox
    Friend WithEvents kdia As System.Windows.Forms.NumericUpDown
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents MantenimientoDataSet As Mantenimineto.mantenimientoDataSet
    Friend WithEvents Sql_rutinasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_rutinasTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.sql_rutinasTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sql_rutinasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Rutinas_programacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rutinas_programacionTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.rutinas_programacionTableAdapter
    Friend WithEvents Rutinas_programacionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ufecha As System.Windows.Forms.TextBox
    Friend WithEvents Id_rutinaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents txtsiguiente As System.Windows.Forms.TextBox
    Friend WithEvents RutinasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RutinasTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.rutinasTableAdapter
    Friend WithEvents Dia_mesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_tipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NdiaTextBox As System.Windows.Forms.TextBox
End Class
