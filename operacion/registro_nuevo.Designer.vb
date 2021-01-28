<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro_nuevo
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
        Dim Id_servicioLabel As System.Windows.Forms.Label
        Dim FolioLabel As System.Windows.Forms.Label
        Dim Id_depto_solicitaLabel As System.Windows.Forms.Label
        Dim Quien_solicitaLabel As System.Windows.Forms.Label
        Dim Fechayhora_solicitudLabel As System.Windows.Forms.Label
        Dim AreaLabel As System.Windows.Forms.Label
        Dim UbicacionLabel As System.Windows.Forms.Label
        Dim ReporteLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Id_solicitanteLabel As System.Windows.Forms.Label
        Dim CuartoLabel As System.Windows.Forms.Label
        Dim UbicacionLabel1 As System.Windows.Forms.Label
        Dim CuartoLabel1 As System.Windows.Forms.Label
        Dim ReporteLabel1 As System.Windows.Forms.Label
        Dim Fechayhora_solicitudLabel1 As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim FechaprogramacionLabel As System.Windows.Forms.Label
        Dim Id_equipoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MantenimientoDataSet = New Mantenimineto.mantenimientoDataSet()
        Me.ReportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportesTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.reportesTableAdapter()
        Me.TableAdapterManager = New Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager()
        Me.DepartamentosTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.departamentosTableAdapter()
        Me.Id_servicioTextBox = New System.Windows.Forms.TextBox()
        Me.FolioTextBox = New System.Windows.Forms.TextBox()
        Me.Id_depto_solicitaTextBox = New System.Windows.Forms.TextBox()
        Me.DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentoComboBox = New System.Windows.Forms.ComboBox()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Quien_solicitaTextBox = New System.Windows.Forms.TextBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.hora = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AreasTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.areasTableAdapter()
        Me.AreaComboBox = New System.Windows.Forms.ComboBox()
        Me.Id_areaTextBox = New System.Windows.Forms.TextBox()
        Me.UbicacionTextBox = New System.Windows.Forms.TextBox()
        Me.ReporteTextBox = New System.Windows.Forms.TextBox()
        Me.Fechayhora_solicitudTextBox = New System.Windows.Forms.TextBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox()
        Me.Id_solicitanteTextBox = New System.Windows.Forms.TextBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.staffTableAdapter()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CuartoTextBox = New System.Windows.Forms.TextBox()
        Me.Fechayhora_registro = New System.Windows.Forms.DateTimePicker()
        Me.btn_depto = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btn_equipo = New System.Windows.Forms.Button()
        Me.txtequipo = New System.Windows.Forms.TextBox()
        Me.Id_equipoTextBox = New System.Windows.Forms.TextBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Sql_reportesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sql_reportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaprogramacionTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.Fechayhora_solicitudDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ReporteTextBox1 = New System.Windows.Forms.TextBox()
        Me.CuartoTextBox1 = New System.Windows.Forms.TextBox()
        Me.UbicacionTextBox1 = New System.Windows.Forms.TextBox()
        Me.Sql_reportesTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.sql_reportesTableAdapter()
        Id_servicioLabel = New System.Windows.Forms.Label()
        FolioLabel = New System.Windows.Forms.Label()
        Id_depto_solicitaLabel = New System.Windows.Forms.Label()
        Quien_solicitaLabel = New System.Windows.Forms.Label()
        Fechayhora_solicitudLabel = New System.Windows.Forms.Label()
        AreaLabel = New System.Windows.Forms.Label()
        UbicacionLabel = New System.Windows.Forms.Label()
        ReporteLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Id_solicitanteLabel = New System.Windows.Forms.Label()
        CuartoLabel = New System.Windows.Forms.Label()
        UbicacionLabel1 = New System.Windows.Forms.Label()
        CuartoLabel1 = New System.Windows.Forms.Label()
        ReporteLabel1 = New System.Windows.Forms.Label()
        Fechayhora_solicitudLabel1 = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        FechaprogramacionLabel = New System.Windows.Forms.Label()
        Id_equipoLabel = New System.Windows.Forms.Label()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.Sql_reportesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_reportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_servicioLabel
        '
        Id_servicioLabel.AutoSize = True
        Id_servicioLabel.Location = New System.Drawing.Point(431, 84)
        Id_servicioLabel.Name = "Id_servicioLabel"
        Id_servicioLabel.Size = New System.Drawing.Size(30, 18)
        Id_servicioLabel.TabIndex = 1
        Id_servicioLabel.Text = "ID :"
        '
        'FolioLabel
        '
        FolioLabel.AutoSize = True
        FolioLabel.Location = New System.Drawing.Point(126, 88)
        FolioLabel.Name = "FolioLabel"
        FolioLabel.Size = New System.Drawing.Size(40, 18)
        FolioLabel.TabIndex = 3
        FolioLabel.Text = "folio:"
        FolioLabel.Visible = False
        '
        'Id_depto_solicitaLabel
        '
        Id_depto_solicitaLabel.AutoSize = True
        Id_depto_solicitaLabel.Location = New System.Drawing.Point(6, 131)
        Id_depto_solicitaLabel.Name = "Id_depto_solicitaLabel"
        Id_depto_solicitaLabel.Size = New System.Drawing.Size(156, 18)
        Id_depto_solicitaLabel.TabIndex = 5
        Id_depto_solicitaLabel.Text = "Departamento solicita:"
        '
        'Quien_solicitaLabel
        '
        Quien_solicitaLabel.AutoSize = True
        Quien_solicitaLabel.Location = New System.Drawing.Point(65, 194)
        Quien_solicitaLabel.Name = "Quien_solicitaLabel"
        Quien_solicitaLabel.Size = New System.Drawing.Size(101, 18)
        Quien_solicitaLabel.TabIndex = 10
        Quien_solicitaLabel.Text = "Quien solicita:"
        '
        'Fechayhora_solicitudLabel
        '
        Fechayhora_solicitudLabel.AutoSize = True
        Fechayhora_solicitudLabel.Location = New System.Drawing.Point(55, 228)
        Fechayhora_solicitudLabel.Name = "Fechayhora_solicitudLabel"
        Fechayhora_solicitudLabel.Size = New System.Drawing.Size(111, 18)
        Fechayhora_solicitudLabel.TabIndex = 12
        Fechayhora_solicitudLabel.Text = "Fecha solicitud:"
        '
        'AreaLabel
        '
        AreaLabel.AutoSize = True
        AreaLabel.Location = New System.Drawing.Point(124, 276)
        AreaLabel.Name = "AreaLabel"
        AreaLabel.Size = New System.Drawing.Size(42, 18)
        AreaLabel.TabIndex = 17
        AreaLabel.Text = "Area:"
        '
        'UbicacionLabel
        '
        UbicacionLabel.AutoSize = True
        UbicacionLabel.Location = New System.Drawing.Point(88, 308)
        UbicacionLabel.Name = "UbicacionLabel"
        UbicacionLabel.Size = New System.Drawing.Size(78, 18)
        UbicacionLabel.TabIndex = 20
        UbicacionLabel.Text = "Ubicacion:"
        '
        'ReporteLabel
        '
        ReporteLabel.AutoSize = True
        ReporteLabel.Location = New System.Drawing.Point(101, 370)
        ReporteLabel.Name = "ReporteLabel"
        ReporteLabel.Size = New System.Drawing.Size(65, 18)
        ReporteLabel.TabIndex = 22
        ReporteLabel.Text = "Reporte:"
        '
        'Label2
        '
        Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(60, 508)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(102, 18)
        Label2.TabIndex = 27
        Label2.Text = "Comentarios :"
        '
        'Id_solicitanteLabel
        '
        Id_solicitanteLabel.AutoSize = True
        Id_solicitanteLabel.Location = New System.Drawing.Point(73, 161)
        Id_solicitanteLabel.Name = "Id_solicitanteLabel"
        Id_solicitanteLabel.Size = New System.Drawing.Size(93, 18)
        Id_solicitanteLabel.TabIndex = 28
        Id_solicitanteLabel.Text = "Id solicitante:"
        '
        'CuartoLabel
        '
        CuartoLabel.AutoSize = True
        CuartoLabel.Location = New System.Drawing.Point(109, 338)
        CuartoLabel.Name = "CuartoLabel"
        CuartoLabel.Size = New System.Drawing.Size(57, 18)
        CuartoLabel.TabIndex = 31
        CuartoLabel.Text = "Cuarto:"
        '
        'UbicacionLabel1
        '
        UbicacionLabel1.AutoSize = True
        UbicacionLabel1.Location = New System.Drawing.Point(28, 25)
        UbicacionLabel1.Name = "UbicacionLabel1"
        UbicacionLabel1.Size = New System.Drawing.Size(78, 18)
        UbicacionLabel1.TabIndex = 0
        UbicacionLabel1.Text = "Ubicacion:"
        '
        'CuartoLabel1
        '
        CuartoLabel1.AutoSize = True
        CuartoLabel1.Location = New System.Drawing.Point(389, 28)
        CuartoLabel1.Name = "CuartoLabel1"
        CuartoLabel1.Size = New System.Drawing.Size(54, 18)
        CuartoLabel1.TabIndex = 2
        CuartoLabel1.Text = "cuarto:"
        '
        'ReporteLabel1
        '
        ReporteLabel1.AutoSize = True
        ReporteLabel1.Location = New System.Drawing.Point(47, 66)
        ReporteLabel1.Name = "ReporteLabel1"
        ReporteLabel1.Size = New System.Drawing.Size(59, 18)
        ReporteLabel1.TabIndex = 4
        ReporteLabel1.Text = "reporte:"
        '
        'Fechayhora_solicitudLabel1
        '
        Fechayhora_solicitudLabel1.AutoSize = True
        Fechayhora_solicitudLabel1.Location = New System.Drawing.Point(515, 27)
        Fechayhora_solicitudLabel1.Name = "Fechayhora_solicitudLabel1"
        Fechayhora_solicitudLabel1.Size = New System.Drawing.Size(57, 18)
        Fechayhora_solicitudLabel1.TabIndex = 6
        Fechayhora_solicitudLabel1.Text = "Fecha :"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(8, 126)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(109, 18)
        ObservacionesLabel.TabIndex = 8
        ObservacionesLabel.Text = "observaciones:"
        '
        'FechaprogramacionLabel
        '
        FechaprogramacionLabel.AutoSize = True
        FechaprogramacionLabel.Location = New System.Drawing.Point(6, 166)
        FechaprogramacionLabel.Name = "FechaprogramacionLabel"
        FechaprogramacionLabel.Size = New System.Drawing.Size(143, 18)
        FechaprogramacionLabel.TabIndex = 10
        FechaprogramacionLabel.Text = "Fecha Programada :"
        '
        'Id_equipoLabel
        '
        Id_equipoLabel.AutoSize = True
        Id_equipoLabel.Location = New System.Drawing.Point(93, 616)
        Id_equipoLabel.Name = "Id_equipoLabel"
        Id_equipoLabel.Size = New System.Drawing.Size(0, 18)
        Id_equipoLabel.TabIndex = 35
        '
        'MantenimientoDataSet
        '
        Me.MantenimientoDataSet.DataSetName = "mantenimientoDataSet"
        Me.MantenimientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportesBindingSource
        '
        Me.ReportesBindingSource.DataMember = "reportes"
        Me.ReportesBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'ReportesTableAdapter
        '
        Me.ReportesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.actividadesTableAdapter = Nothing
        Me.TableAdapterManager.areasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriasTableAdapter = Nothing
        Me.TableAdapterManager.departamentosTableAdapter = Me.DepartamentosTableAdapter
        Me.TableAdapterManager.equipos_redTableAdapter = Nothing
        Me.TableAdapterManager.equiposTableAdapter = Nothing
        Me.TableAdapterManager.permisosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.reportes_tareasTableAdapter = Nothing
        Me.TableAdapterManager.reportesTableAdapter = Me.ReportesTableAdapter
        Me.TableAdapterManager.rutinasTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.sys_funcionesTableAdapter = Nothing
        Me.TableAdapterManager.sys_tareas_preventivasTableAdapter = Nothing
        Me.TableAdapterManager.tareasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DepartamentosTableAdapter
        '
        Me.DepartamentosTableAdapter.ClearBeforeFill = True
        '
        'Id_servicioTextBox
        '
        Me.Id_servicioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportesBindingSource, "id_servicio", True))
        Me.Id_servicioTextBox.Enabled = False
        Me.Id_servicioTextBox.ForeColor = System.Drawing.Color.Red
        Me.Id_servicioTextBox.Location = New System.Drawing.Point(231, 516)
        Me.Id_servicioTextBox.Name = "Id_servicioTextBox"
        Me.Id_servicioTextBox.Size = New System.Drawing.Size(92, 24)
        Me.Id_servicioTextBox.TabIndex = 2
        Me.Id_servicioTextBox.TabStop = False
        '
        'FolioTextBox
        '
        Me.FolioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportesBindingSource, "folio", True))
        Me.FolioTextBox.Location = New System.Drawing.Point(170, 85)
        Me.FolioTextBox.Name = "FolioTextBox"
        Me.FolioTextBox.Size = New System.Drawing.Size(100, 24)
        Me.FolioTextBox.TabIndex = 4
        Me.FolioTextBox.Text = "S/N"
        Me.FolioTextBox.Visible = False
        '
        'Id_depto_solicitaTextBox
        '
        Me.Id_depto_solicitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportesBindingSource, "id_depto_solicita", True))
        Me.Id_depto_solicitaTextBox.Enabled = False
        Me.Id_depto_solicitaTextBox.Location = New System.Drawing.Point(170, 128)
        Me.Id_depto_solicitaTextBox.Name = "Id_depto_solicitaTextBox"
        Me.Id_depto_solicitaTextBox.Size = New System.Drawing.Size(41, 24)
        Me.Id_depto_solicitaTextBox.TabIndex = 6
        Me.Id_depto_solicitaTextBox.TabStop = False
        '
        'DepartamentosBindingSource
        '
        Me.DepartamentosBindingSource.DataMember = "departamentos"
        Me.DepartamentosBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'DepartamentoComboBox
        '
        Me.DepartamentoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReportesBindingSource, "id_depto_solicita", True))
        Me.DepartamentoComboBox.DataSource = Me.DepartamentosBindingSource
        Me.DepartamentoComboBox.DisplayMember = "Departamento"
        Me.DepartamentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartamentoComboBox.FormattingEnabled = True
        Me.DepartamentoComboBox.Location = New System.Drawing.Point(217, 126)
        Me.DepartamentoComboBox.Name = "DepartamentoComboBox"
        Me.DepartamentoComboBox.Size = New System.Drawing.Size(206, 26)
        Me.DepartamentoComboBox.TabIndex = 8
        Me.DepartamentoComboBox.ValueMember = "id_depto"
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_SALIR.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_SALIR.Location = New System.Drawing.Point(445, 672)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(75, 29)
        Me.BTN_SALIR.TabIndex = 9
        Me.BTN_SALIR.Text = "SALIR"
        Me.BTN_SALIR.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(344, 671)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Quien_solicitaTextBox
        '
        Me.Quien_solicitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportesBindingSource, "quien_solicita", True))
        Me.Quien_solicitaTextBox.Location = New System.Drawing.Point(174, 188)
        Me.Quien_solicitaTextBox.MaxLength = 50
        Me.Quien_solicitaTextBox.Name = "Quien_solicitaTextBox"
        Me.Quien_solicitaTextBox.Size = New System.Drawing.Size(368, 24)
        Me.Quien_solicitaTextBox.TabIndex = 11
        '
        'fecha
        '
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(174, 228)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(113, 24)
        Me.fecha.TabIndex = 13
        '
        'hora
        '
        Me.hora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.hora.Location = New System.Drawing.Point(403, 228)
        Me.hora.Name = "hora"
        Me.hora.Size = New System.Drawing.Size(139, 24)
        Me.hora.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(338, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "HORA :"
        '
        'AreasBindingSource
        '
        Me.AreasBindingSource.DataMember = "areas"
        Me.AreasBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'AreasTableAdapter
        '
        Me.AreasTableAdapter.ClearBeforeFill = True
        '
        'AreaComboBox
        '
        Me.AreaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReportesBindingSource, "id_area", True))
        Me.AreaComboBox.DataSource = Me.AreasBindingSource
        Me.AreaComboBox.DisplayMember = "Area"
        Me.AreaComboBox.FormattingEnabled = True
        Me.AreaComboBox.Location = New System.Drawing.Point(231, 268)
        Me.AreaComboBox.Name = "AreaComboBox"
        Me.AreaComboBox.Size = New System.Drawing.Size(311, 26)
        Me.AreaComboBox.TabIndex = 18
        Me.AreaComboBox.ValueMember = "id_area"
        '
        'Id_areaTextBox
        '
        Me.Id_areaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportesBindingSource, "id_area", True))
        Me.Id_areaTextBox.Location = New System.Drawing.Point(173, 270)
        Me.Id_areaTextBox.Name = "Id_areaTextBox"
        Me.Id_areaTextBox.Size = New System.Drawing.Size(42, 24)
        Me.Id_areaTextBox.TabIndex = 20
        '
        'UbicacionTextBox
        '
        Me.UbicacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportesBindingSource, "Ubicacion", True))
        Me.UbicacionTextBox.Location = New System.Drawing.Point(173, 305)
        Me.UbicacionTextBox.Name = "UbicacionTextBox"
        Me.UbicacionTextBox.Size = New System.Drawing.Size(369, 24)
        Me.UbicacionTextBox.TabIndex = 21
        '
        'ReporteTextBox
        '
        Me.ReporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportesBindingSource, "reporte", True))
        Me.ReporteTextBox.Location = New System.Drawing.Point(173, 367)
        Me.ReporteTextBox.Multiline = True
        Me.ReporteTextBox.Name = "ReporteTextBox"
        Me.ReporteTextBox.Size = New System.Drawing.Size(369, 135)
        Me.ReporteTextBox.TabIndex = 23
        '
        'Fechayhora_solicitudTextBox
        '
        Me.Fechayhora_solicitudTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportesBindingSource, "fechayhora_solicitud", True))
        Me.Fechayhora_solicitudTextBox.Location = New System.Drawing.Point(206, 433)
        Me.Fechayhora_solicitudTextBox.Name = "Fechayhora_solicitudTextBox"
        Me.Fechayhora_solicitudTextBox.Size = New System.Drawing.Size(255, 24)
        Me.Fechayhora_solicitudTextBox.TabIndex = 25
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.ForeColor = System.Drawing.Color.Red
        Me.lblid.Location = New System.Drawing.Point(467, 80)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(70, 24)
        Me.lblid.TabIndex = 26
        Me.lblid.Text = "000000"
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportesBindingSource, "comentarios", True))
        Me.ComentariosTextBox.Location = New System.Drawing.Point(170, 508)
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(372, 86)
        Me.ComentariosTextBox.TabIndex = 28
        '
        'Id_solicitanteTextBox
        '
        Me.Id_solicitanteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportesBindingSource, "id_solicitante", True))
        Me.Id_solicitanteTextBox.Location = New System.Drawing.Point(170, 158)
        Me.Id_solicitanteTextBox.Name = "Id_solicitanteTextBox"
        Me.Id_solicitanteTextBox.Size = New System.Drawing.Size(41, 24)
        Me.Id_solicitanteTextBox.TabIndex = 29
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
        'NombreComboBox
        '
        Me.NombreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReportesBindingSource, "id_solicitante", True))
        Me.NombreComboBox.DataSource = Me.StaffBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(217, 158)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(320, 26)
        Me.NombreComboBox.TabIndex = 30
        Me.NombreComboBox.ValueMember = "id_usuario"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(546, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CuartoTextBox
        '
        Me.CuartoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportesBindingSource, "cuarto", True))
        Me.CuartoTextBox.Location = New System.Drawing.Point(174, 335)
        Me.CuartoTextBox.Name = "CuartoTextBox"
        Me.CuartoTextBox.Size = New System.Drawing.Size(65, 24)
        Me.CuartoTextBox.TabIndex = 32
        '
        'Fechayhora_registro
        '
        Me.Fechayhora_registro.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReportesBindingSource, "fechayhora_registro", True))
        Me.Fechayhora_registro.Location = New System.Drawing.Point(231, 403)
        Me.Fechayhora_registro.Name = "Fechayhora_registro"
        Me.Fechayhora_registro.Size = New System.Drawing.Size(200, 24)
        Me.Fechayhora_registro.TabIndex = 33
        '
        'btn_depto
        '
        Me.btn_depto.Location = New System.Drawing.Point(429, 127)
        Me.btn_depto.Name = "btn_depto"
        Me.btn_depto.Size = New System.Drawing.Size(44, 23)
        Me.btn_depto.TabIndex = 34
        Me.btn_depto.Text = "..."
        Me.btn_depto.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(546, 271)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 23)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Id_equipoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FolioTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_depto)
        Me.SplitContainer1.Panel1.Controls.Add(CuartoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ReporteTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CuartoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Id_servicioLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NombreComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(FolioLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Id_solicitanteLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_depto_solicitaTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_solicitanteTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Id_depto_solicitaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComentariosTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DepartamentoComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BTN_SALIR)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblid)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(ReporteLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Quien_solicitaTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(UbicacionLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Quien_solicitaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.UbicacionTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.fecha)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_areaTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Fechayhora_solicitudLabel)
        Me.SplitContainer1.Panel1.Controls.Add(AreaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.hora)
        Me.SplitContainer1.Panel1.Controls.Add(Me.AreaComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Fechayhora_solicitudTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Fechayhora_registro)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_servicioTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1333, 713)
        Me.SplitContainer1.SplitterDistance = 601
        Me.SplitContainer1.TabIndex = 36
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btn_equipo)
        Me.Panel1.Controls.Add(Me.txtequipo)
        Me.Panel1.Controls.Add(Me.Id_equipoTextBox)
        Me.Panel1.Location = New System.Drawing.Point(168, 600)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 36)
        Me.Panel1.TabIndex = 37
        Me.Panel1.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(27, 603)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(135, 22)
        Me.CheckBox1.TabIndex = 39
        Me.CheckBox1.Text = "Asociar Equipo :"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btn_equipo
        '
        Me.btn_equipo.Location = New System.Drawing.Point(380, 5)
        Me.btn_equipo.Name = "btn_equipo"
        Me.btn_equipo.Size = New System.Drawing.Size(32, 23)
        Me.btn_equipo.TabIndex = 38
        Me.btn_equipo.Text = "..."
        Me.btn_equipo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_equipo.UseVisualStyleBackColor = True
        '
        'txtequipo
        '
        Me.txtequipo.Enabled = False
        Me.txtequipo.Location = New System.Drawing.Point(54, 4)
        Me.txtequipo.Name = "txtequipo"
        Me.txtequipo.Size = New System.Drawing.Size(320, 24)
        Me.txtequipo.TabIndex = 37
        '
        'Id_equipoTextBox
        '
        Me.Id_equipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReportesBindingSource, "id_equipo", True))
        Me.Id_equipoTextBox.Enabled = False
        Me.Id_equipoTextBox.Location = New System.Drawing.Point(3, 4)
        Me.Id_equipoTextBox.Name = "Id_equipoTextBox"
        Me.Id_equipoTextBox.Size = New System.Drawing.Size(45, 24)
        Me.Id_equipoTextBox.TabIndex = 36
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(728, 713)
        Me.SplitContainer2.SplitterDistance = 47
        Me.SplitContainer2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGreen
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(728, 46)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Reportes Pendientes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Sql_reportesDataGridView)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.AutoScroll = True
        Me.SplitContainer3.Panel2.BackColor = System.Drawing.Color.LightGreen
        Me.SplitContainer3.Panel2.Controls.Add(FechaprogramacionLabel)
        Me.SplitContainer3.Panel2.Controls.Add(Me.FechaprogramacionTextBox)
        Me.SplitContainer3.Panel2.Controls.Add(ObservacionesLabel)
        Me.SplitContainer3.Panel2.Controls.Add(Me.ObservacionesTextBox)
        Me.SplitContainer3.Panel2.Controls.Add(Fechayhora_solicitudLabel1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.Fechayhora_solicitudDateTimePicker)
        Me.SplitContainer3.Panel2.Controls.Add(ReporteLabel1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.ReporteTextBox1)
        Me.SplitContainer3.Panel2.Controls.Add(CuartoLabel1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.CuartoTextBox1)
        Me.SplitContainer3.Panel2.Controls.Add(UbicacionLabel1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.UbicacionTextBox1)
        Me.SplitContainer3.Size = New System.Drawing.Size(728, 662)
        Me.SplitContainer3.SplitterDistance = 425
        Me.SplitContainer3.TabIndex = 0
        '
        'Sql_reportesDataGridView
        '
        Me.Sql_reportesDataGridView.AllowUserToAddRows = False
        Me.Sql_reportesDataGridView.AllowUserToDeleteRows = False
        Me.Sql_reportesDataGridView.AutoGenerateColumns = False
        Me.Sql_reportesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Sql_reportesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Sql_reportesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sql_reportesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn33})
        Me.Sql_reportesDataGridView.DataSource = Me.Sql_reportesBindingSource
        Me.Sql_reportesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sql_reportesDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Sql_reportesDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Sql_reportesDataGridView.Name = "Sql_reportesDataGridView"
        Me.Sql_reportesDataGridView.ReadOnly = True
        Me.Sql_reportesDataGridView.RowHeadersVisible = False
        Me.Sql_reportesDataGridView.Size = New System.Drawing.Size(728, 425)
        Me.Sql_reportesDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_servicio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 47
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "reporte"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Reporte"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 86
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Ubicacion"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Ubicacion"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 99
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "folio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "folio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Departamento"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Departamento"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 127
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "id_responsable"
        Me.DataGridViewTextBoxColumn4.HeaderText = "id_responsable"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "responsable"
        Me.DataGridViewTextBoxColumn5.HeaderText = "responsable"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_solicitante"
        Me.DataGridViewTextBoxColumn6.HeaderText = "id_solicitante"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "solicitante"
        Me.DataGridViewTextBoxColumn7.HeaderText = "solicitante"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 99
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "quien_solicita"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Solicita"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 81
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "fechayhora_solicitud"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn9.HeaderText = "F.Solicitud"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Registra"
        Me.DataGridViewTextBoxColumn10.HeaderText = "id_quien_registra"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 144
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Registra"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Registro"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 89
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "fechayhora_registro"
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn12.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 74
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "id_area"
        Me.DataGridViewTextBoxColumn13.HeaderText = "id_area"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "cuarto"
        Me.DataGridViewTextBoxColumn19.HeaderText = "cuarto"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 75
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Area"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Area"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 63
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn17.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "fechaprogramacion"
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn18.HeaderText = "Fecha probable"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 123
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "observaciones"
        Me.DataGridViewTextBoxColumn21.HeaderText = "observaciones"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 130
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "STATUS"
        Me.DataGridViewTextBoxColumn33.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Width = 91
        '
        'Sql_reportesBindingSource
        '
        Me.Sql_reportesBindingSource.DataMember = "sql_reportes"
        Me.Sql_reportesBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'FechaprogramacionTextBox
        '
        Me.FechaprogramacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "fechaprogramacion", True))
        Me.FechaprogramacionTextBox.Enabled = False
        Me.FechaprogramacionTextBox.Location = New System.Drawing.Point(152, 163)
        Me.FechaprogramacionTextBox.Name = "FechaprogramacionTextBox"
        Me.FechaprogramacionTextBox.Size = New System.Drawing.Size(205, 24)
        Me.FechaprogramacionTextBox.TabIndex = 11
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "observaciones", True))
        Me.ObservacionesTextBox.Enabled = False
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(123, 123)
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(569, 24)
        Me.ObservacionesTextBox.TabIndex = 9
        '
        'Fechayhora_solicitudDateTimePicker
        '
        Me.Fechayhora_solicitudDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Sql_reportesBindingSource, "fechayhora_solicitud", True))
        Me.Fechayhora_solicitudDateTimePicker.Enabled = False
        Me.Fechayhora_solicitudDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fechayhora_solicitudDateTimePicker.Location = New System.Drawing.Point(578, 25)
        Me.Fechayhora_solicitudDateTimePicker.Name = "Fechayhora_solicitudDateTimePicker"
        Me.Fechayhora_solicitudDateTimePicker.Size = New System.Drawing.Size(114, 24)
        Me.Fechayhora_solicitudDateTimePicker.TabIndex = 7
        '
        'ReporteTextBox1
        '
        Me.ReporteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "reporte", True))
        Me.ReporteTextBox1.Enabled = False
        Me.ReporteTextBox1.Location = New System.Drawing.Point(123, 60)
        Me.ReporteTextBox1.Multiline = True
        Me.ReporteTextBox1.Name = "ReporteTextBox1"
        Me.ReporteTextBox1.Size = New System.Drawing.Size(569, 54)
        Me.ReporteTextBox1.TabIndex = 5
        '
        'CuartoTextBox1
        '
        Me.CuartoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "cuarto", True))
        Me.CuartoTextBox1.Enabled = False
        Me.CuartoTextBox1.Location = New System.Drawing.Point(449, 25)
        Me.CuartoTextBox1.Name = "CuartoTextBox1"
        Me.CuartoTextBox1.Size = New System.Drawing.Size(58, 24)
        Me.CuartoTextBox1.TabIndex = 3
        '
        'UbicacionTextBox1
        '
        Me.UbicacionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "Ubicacion", True))
        Me.UbicacionTextBox1.Enabled = False
        Me.UbicacionTextBox1.Location = New System.Drawing.Point(123, 25)
        Me.UbicacionTextBox1.Name = "UbicacionTextBox1"
        Me.UbicacionTextBox1.Size = New System.Drawing.Size(260, 24)
        Me.UbicacionTextBox1.TabIndex = 1
        '
        'Sql_reportesTableAdapter
        '
        Me.Sql_reportesTableAdapter.ClearBeforeFill = True
        '
        'registro_nuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BTN_SALIR
        Me.ClientSize = New System.Drawing.Size(1333, 713)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "registro_nuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Registro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.Sql_reportesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_reportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MantenimientoDataSet As Mantenimineto.mantenimientoDataSet
    Friend WithEvents ReportesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportesTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.reportesTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DepartamentosTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.departamentosTableAdapter
    Friend WithEvents Id_servicioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FolioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_depto_solicitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DepartamentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartamentoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_SALIR As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Quien_solicitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents hora As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AreasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AreasTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.areasTableAdapter
    Friend WithEvents AreaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Id_areaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UbicacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReporteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fechayhora_solicitudTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents ComentariosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_solicitanteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.staffTableAdapter
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CuartoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fechayhora_registro As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_depto As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Sql_reportesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_reportesTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.sql_reportesTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Sql_reportesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents FechaprogramacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObservacionesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fechayhora_solicitudDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReporteTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CuartoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents UbicacionTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_equipo As System.Windows.Forms.Button
    Friend WithEvents txtequipo As System.Windows.Forms.TextBox
    Friend WithEvents Id_equipoTextBox As System.Windows.Forms.TextBox
End Class
