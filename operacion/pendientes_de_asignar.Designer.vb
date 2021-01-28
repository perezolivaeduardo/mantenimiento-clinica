<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pendientes_de_asignar
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
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim ReporteLabel As System.Windows.Forms.Label
        Dim UbicacionLabel As System.Windows.Forms.Label
        Dim AreaLabel As System.Windows.Forms.Label
        Dim Fechayhora_registroLabel As System.Windows.Forms.Label
        Dim RegistraLabel As System.Windows.Forms.Label
        Dim Fechayhora_solicitudLabel As System.Windows.Forms.Label
        Dim Quien_solicitaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim EquipoLabel As System.Windows.Forms.Label
        Me.Sql_reportesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grupo_equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sql_reportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MantenimientoDataSet = New Mantenimineto.mantenimientoDataSet()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EquipoTextBox = New System.Windows.Forms.TextBox()
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Fechayhora_registroTextBox = New System.Windows.Forms.TextBox()
        Me.Fechayhora_solicitudTextBox = New System.Windows.Forms.TextBox()
        Me.ReporteTextBox = New System.Windows.Forms.TextBox()
        Me.UbicacionTextBox = New System.Windows.Forms.TextBox()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.RegistraTextBox = New System.Windows.Forms.TextBox()
        Me.Quien_solicitaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_servicioTextBox = New System.Windows.Forms.TextBox()
        Me.notifica = New System.Windows.Forms.CheckBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.proveedor = New System.Windows.Forms.ComboBox()
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Id_proveedorTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mis_comentarios = New System.Windows.Forms.TextBox()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.boton_programada = New System.Windows.Forms.RadioButton()
        Me.boton_limite = New System.Windows.Forms.RadioButton()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.boton_correctivo = New System.Windows.Forms.RadioButton()
        Me.boton_preventivo = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.staff = New System.Windows.Forms.ComboBox()
        Me.fecha_Asignacion = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id_user = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sql_reportesTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.sql_reportesTableAdapter()
        Me.TableAdapterManager = New Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager()
        Me.StaffTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.staffTableAdapter()
        Me.ProveedoresTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.proveedoresTableAdapter()
        Me.ReportesTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.reportesTableAdapter()
        Me.filtro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblpendientes = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        ReporteLabel = New System.Windows.Forms.Label()
        UbicacionLabel = New System.Windows.Forms.Label()
        AreaLabel = New System.Windows.Forms.Label()
        Fechayhora_registroLabel = New System.Windows.Forms.Label()
        RegistraLabel = New System.Windows.Forms.Label()
        Fechayhora_solicitudLabel = New System.Windows.Forms.Label()
        Quien_solicitaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        EquipoLabel = New System.Windows.Forms.Label()
        CType(Me.Sql_reportesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_reportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ReportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Location = New System.Drawing.Point(48, 321)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(95, 18)
        ComentariosLabel.TabIndex = 32
        ComentariosLabel.Text = "comentarios:"
        '
        'ReporteLabel
        '
        ReporteLabel.AutoSize = True
        ReporteLabel.Location = New System.Drawing.Point(74, 226)
        ReporteLabel.Name = "ReporteLabel"
        ReporteLabel.Size = New System.Drawing.Size(69, 18)
        ReporteLabel.TabIndex = 30
        ReporteLabel.Text = "Reporte :"
        '
        'UbicacionLabel
        '
        UbicacionLabel.AutoSize = True
        UbicacionLabel.Location = New System.Drawing.Point(65, 186)
        UbicacionLabel.Name = "UbicacionLabel"
        UbicacionLabel.Size = New System.Drawing.Size(78, 18)
        UbicacionLabel.TabIndex = 28
        UbicacionLabel.Text = "Ubicacion:"
        '
        'AreaLabel
        '
        AreaLabel.AutoSize = True
        AreaLabel.Location = New System.Drawing.Point(101, 156)
        AreaLabel.Name = "AreaLabel"
        AreaLabel.Size = New System.Drawing.Size(42, 18)
        AreaLabel.TabIndex = 26
        AreaLabel.Text = "Area:"
        '
        'Fechayhora_registroLabel
        '
        Fechayhora_registroLabel.AutoSize = True
        Fechayhora_registroLabel.Location = New System.Drawing.Point(6, 129)
        Fechayhora_registroLabel.Name = "Fechayhora_registroLabel"
        Fechayhora_registroLabel.Size = New System.Drawing.Size(137, 18)
        Fechayhora_registroLabel.TabIndex = 25
        Fechayhora_registroLabel.Text = "Fecha de Registro :"
        '
        'RegistraLabel
        '
        RegistraLabel.AutoSize = True
        RegistraLabel.Location = New System.Drawing.Point(75, 98)
        RegistraLabel.Name = "RegistraLabel"
        RegistraLabel.Size = New System.Drawing.Size(68, 18)
        RegistraLabel.TabIndex = 23
        RegistraLabel.Text = "Registro:"
        '
        'Fechayhora_solicitudLabel
        '
        Fechayhora_solicitudLabel.AutoSize = True
        Fechayhora_solicitudLabel.Location = New System.Drawing.Point(30, 58)
        Fechayhora_solicitudLabel.Name = "Fechayhora_solicitudLabel"
        Fechayhora_solicitudLabel.Size = New System.Drawing.Size(113, 18)
        Fechayhora_solicitudLabel.TabIndex = 22
        Fechayhora_solicitudLabel.Text = "Fecha Solicitud:"
        '
        'Quien_solicitaLabel
        '
        Quien_solicitaLabel.AutoSize = True
        Quien_solicitaLabel.Location = New System.Drawing.Point(84, 13)
        Quien_solicitaLabel.Name = "Quien_solicitaLabel"
        Quien_solicitaLabel.Size = New System.Drawing.Size(60, 18)
        Quien_solicitaLabel.TabIndex = 20
        Quien_solicitaLabel.Text = "Solicita:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(81, 140)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(73, 18)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Asignar a:"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(9, 9)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(85, 18)
        NombreLabel1.TabIndex = 19
        NombreLabel1.Text = "Proveedor :"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(105, 166)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(49, 18)
        EmailLabel.TabIndex = 22
        EmailLabel.Text = "Email:"
        '
        'EquipoLabel
        '
        EquipoLabel.AutoSize = True
        EquipoLabel.Location = New System.Drawing.Point(65, 424)
        EquipoLabel.Name = "EquipoLabel"
        EquipoLabel.Size = New System.Drawing.Size(56, 18)
        EquipoLabel.TabIndex = 37
        EquipoLabel.Text = "equipo:"
        '
        'Sql_reportesDataGridView
        '
        Me.Sql_reportesDataGridView.AllowUserToAddRows = False
        Me.Sql_reportesDataGridView.AllowUserToDeleteRows = False
        Me.Sql_reportesDataGridView.AllowUserToResizeColumns = False
        Me.Sql_reportesDataGridView.AllowUserToResizeRows = False
        Me.Sql_reportesDataGridView.AutoGenerateColumns = False
        Me.Sql_reportesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Sql_reportesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Sql_reportesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sql_reportesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.grupo_equipo})
        Me.Sql_reportesDataGridView.DataSource = Me.Sql_reportesBindingSource
        Me.Sql_reportesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sql_reportesDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Sql_reportesDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.Sql_reportesDataGridView.Name = "Sql_reportesDataGridView"
        Me.Sql_reportesDataGridView.ReadOnly = True
        Me.Sql_reportesDataGridView.RowHeadersVisible = False
        Me.Sql_reportesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Sql_reportesDataGridView.Size = New System.Drawing.Size(521, 558)
        Me.Sql_reportesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_servicio"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 47
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "folio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "folio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 61
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "reporte"
        Me.DataGridViewTextBoxColumn16.HeaderText = "reporte"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 80
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Area"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Area"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 63
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
        Me.DataGridViewTextBoxColumn4.Width = 133
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "responsable"
        Me.DataGridViewTextBoxColumn5.HeaderText = "responsable"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 114
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_solicitante"
        Me.DataGridViewTextBoxColumn6.HeaderText = "id_solicitante"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 118
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
        Me.DataGridViewTextBoxColumn8.HeaderText = "quien_solicita"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 122
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "fechayhora_solicitud"
        Me.DataGridViewTextBoxColumn9.HeaderText = "fechayhora_solicitud"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 168
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "id_quien_registra"
        Me.DataGridViewTextBoxColumn10.HeaderText = "id_quien_registra"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 144
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Registra"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Registra"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 88
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "fechayhora_registro"
        Me.DataGridViewTextBoxColumn12.HeaderText = "fechayhora_registro"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 164
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "id_area"
        Me.DataGridViewTextBoxColumn13.HeaderText = "id_area"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 81
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Ubicacion"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Ubicacion"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 99
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn17.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 57
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "fechaprogramacion"
        Me.DataGridViewTextBoxColumn18.HeaderText = "fechaprogramacion"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 161
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "cuarto"
        Me.DataGridViewTextBoxColumn19.HeaderText = "cuarto"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 75
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "fechayhora_reparacion"
        Me.DataGridViewTextBoxColumn20.HeaderText = "fechayhora_reparacion"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 184
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "observaciones"
        Me.DataGridViewTextBoxColumn21.HeaderText = "observaciones"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 130
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "id_atendio"
        Me.DataGridViewTextBoxColumn22.HeaderText = "id_atendio"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Atendio"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Atendio"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 82
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "id_superviso"
        Me.DataGridViewTextBoxColumn24.HeaderText = "id_superviso"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        Me.DataGridViewTextBoxColumn24.Width = 116
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "superviso"
        Me.DataGridViewTextBoxColumn25.HeaderText = "superviso"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Width = 97
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "id_usuario"
        Me.DataGridViewTextBoxColumn26.HeaderText = "id_usuario"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 101
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "id_recibio"
        Me.DataGridViewTextBoxColumn27.HeaderText = "id_recibio"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        Me.DataGridViewTextBoxColumn27.Width = 96
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Recibio"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Recibio"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Width = 83
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "fechayhora_recibido"
        Me.DataGridViewTextBoxColumn29.HeaderText = "fechayhora_recibido"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Width = 166
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "estatus"
        Me.DataGridViewTextBoxColumn30.HeaderText = "estatus"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Width = 81
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "comentarios"
        Me.DataGridViewTextBoxColumn31.HeaderText = "comentarios"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Width = 116
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "id_status"
        Me.DataGridViewTextBoxColumn32.HeaderText = "id_status"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Width = 92
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "STATUS"
        Me.DataGridViewTextBoxColumn33.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Width = 91
        '
        'grupo_equipo
        '
        Me.grupo_equipo.DataPropertyName = "grupo_equipo"
        Me.grupo_equipo.HeaderText = "grupo_equipo"
        Me.grupo_equipo.Name = "grupo_equipo"
        Me.grupo_equipo.ReadOnly = True
        Me.grupo_equipo.Width = 123
        '
        'Sql_reportesBindingSource
        '
        Me.Sql_reportesBindingSource.DataMember = "sql_reportes"
        Me.Sql_reportesBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'MantenimientoDataSet
        '
        Me.MantenimientoDataSet.DataSetName = "mantenimientoDataSet"
        Me.MantenimientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(13, 50)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Sql_reportesDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1185, 558)
        Me.SplitContainer1.SplitterDistance = 521
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 2
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer2.Panel1.Controls.Add(EquipoLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.EquipoTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ComentariosTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Fechayhora_registroTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Fechayhora_solicitudTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(ComentariosLabel)
        Me.SplitContainer2.Panel1.Controls.Add(ReporteLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ReporteTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(UbicacionLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.UbicacionTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(AreaLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.AreaTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Fechayhora_registroLabel)
        Me.SplitContainer2.Panel1.Controls.Add(RegistraLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.RegistraTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Fechayhora_solicitudLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Quien_solicitaLabel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Quien_solicitaTextBox)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Id_servicioTextBox)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.notifica)
        Me.SplitContainer2.Panel2.Controls.Add(EmailLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.EmailTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel2.Controls.Add(Me.mis_comentarios)
        Me.SplitContainer2.Panel2.Controls.Add(Me.descripcion)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.boton_correctivo)
        Me.SplitContainer2.Panel2.Controls.Add(Me.boton_preventivo)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel2.Controls.Add(NombreLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.staff)
        Me.SplitContainer2.Panel2.Controls.Add(Me.fecha_Asignacion)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.id_user)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer2.Size = New System.Drawing.Size(658, 558)
        Me.SplitContainer2.SplitterDistance = 588
        Me.SplitContainer2.TabIndex = 0
        '
        'EquipoTextBox
        '
        Me.EquipoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.EquipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "equipo", True))
        Me.EquipoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EquipoTextBox.Location = New System.Drawing.Point(149, 420)
        Me.EquipoTextBox.Name = "EquipoTextBox"
        Me.EquipoTextBox.Size = New System.Drawing.Size(387, 27)
        Me.EquipoTextBox.TabIndex = 38
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "comentarios", True))
        Me.ComentariosTextBox.Enabled = False
        Me.ComentariosTextBox.Location = New System.Drawing.Point(149, 318)
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(386, 86)
        Me.ComentariosTextBox.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(422, 495)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 29)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Asiganar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Fechayhora_registroTextBox
        '
        Me.Fechayhora_registroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "fechayhora_registro", True))
        Me.Fechayhora_registroTextBox.Enabled = False
        Me.Fechayhora_registroTextBox.Location = New System.Drawing.Point(149, 123)
        Me.Fechayhora_registroTextBox.Name = "Fechayhora_registroTextBox"
        Me.Fechayhora_registroTextBox.Size = New System.Drawing.Size(131, 24)
        Me.Fechayhora_registroTextBox.TabIndex = 35
        '
        'Fechayhora_solicitudTextBox
        '
        Me.Fechayhora_solicitudTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "fechayhora_solicitud", True))
        Me.Fechayhora_solicitudTextBox.Enabled = False
        Me.Fechayhora_solicitudTextBox.Location = New System.Drawing.Point(149, 52)
        Me.Fechayhora_solicitudTextBox.Name = "Fechayhora_solicitudTextBox"
        Me.Fechayhora_solicitudTextBox.Size = New System.Drawing.Size(131, 24)
        Me.Fechayhora_solicitudTextBox.TabIndex = 34
        '
        'ReporteTextBox
        '
        Me.ReporteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "reporte", True))
        Me.ReporteTextBox.Enabled = False
        Me.ReporteTextBox.Location = New System.Drawing.Point(149, 223)
        Me.ReporteTextBox.Multiline = True
        Me.ReporteTextBox.Name = "ReporteTextBox"
        Me.ReporteTextBox.Size = New System.Drawing.Size(386, 89)
        Me.ReporteTextBox.TabIndex = 31
        '
        'UbicacionTextBox
        '
        Me.UbicacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "Ubicacion", True))
        Me.UbicacionTextBox.Enabled = False
        Me.UbicacionTextBox.Location = New System.Drawing.Point(149, 183)
        Me.UbicacionTextBox.Name = "UbicacionTextBox"
        Me.UbicacionTextBox.Size = New System.Drawing.Size(386, 24)
        Me.UbicacionTextBox.TabIndex = 29
        '
        'AreaTextBox
        '
        Me.AreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "Area", True))
        Me.AreaTextBox.Enabled = False
        Me.AreaTextBox.Location = New System.Drawing.Point(149, 153)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.Size = New System.Drawing.Size(386, 24)
        Me.AreaTextBox.TabIndex = 27
        '
        'RegistraTextBox
        '
        Me.RegistraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "Registra", True))
        Me.RegistraTextBox.Enabled = False
        Me.RegistraTextBox.Location = New System.Drawing.Point(149, 95)
        Me.RegistraTextBox.Name = "RegistraTextBox"
        Me.RegistraTextBox.Size = New System.Drawing.Size(386, 24)
        Me.RegistraTextBox.TabIndex = 24
        '
        'Quien_solicitaTextBox
        '
        Me.Quien_solicitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "quien_solicita", True))
        Me.Quien_solicitaTextBox.Enabled = False
        Me.Quien_solicitaTextBox.Location = New System.Drawing.Point(150, 13)
        Me.Quien_solicitaTextBox.Name = "Quien_solicitaTextBox"
        Me.Quien_solicitaTextBox.Size = New System.Drawing.Size(386, 24)
        Me.Quien_solicitaTextBox.TabIndex = 21
        '
        'Id_servicioTextBox
        '
        Me.Id_servicioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "id_servicio", True))
        Me.Id_servicioTextBox.Enabled = False
        Me.Id_servicioTextBox.Location = New System.Drawing.Point(268, 352)
        Me.Id_servicioTextBox.Name = "Id_servicioTextBox"
        Me.Id_servicioTextBox.Size = New System.Drawing.Size(100, 24)
        Me.Id_servicioTextBox.TabIndex = 37
        '
        'notifica
        '
        Me.notifica.AutoSize = True
        Me.notifica.Location = New System.Drawing.Point(17, 166)
        Me.notifica.Name = "notifica"
        Me.notifica.Size = New System.Drawing.Size(82, 22)
        Me.notifica.TabIndex = 24
        Me.notifica.Text = "Notificar"
        Me.notifica.UseVisualStyleBackColor = True
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(158, 163)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(315, 24)
        Me.EmailTextBox.TabIndex = 23
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "staff"
        Me.StaffBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.proveedor)
        Me.Panel2.Controls.Add(Me.Id_proveedorTextBox)
        Me.Panel2.Controls.Add(NombreLabel1)
        Me.Panel2.Location = New System.Drawing.Point(54, 208)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(428, 38)
        Me.Panel2.TabIndex = 22
        Me.Panel2.Visible = False
        '
        'proveedor
        '
        Me.proveedor.DataSource = Me.ProveedoresBindingSource
        Me.proveedor.DisplayMember = "Nombre"
        Me.proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.proveedor.FormattingEnabled = True
        Me.proveedor.Location = New System.Drawing.Point(139, 5)
        Me.proveedor.Name = "proveedor"
        Me.proveedor.Size = New System.Drawing.Size(274, 26)
        Me.proveedor.TabIndex = 20
        Me.proveedor.ValueMember = "id_proveedor"
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'Id_proveedorTextBox
        '
        Me.Id_proveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "id_proveedor", True))
        Me.Id_proveedorTextBox.Enabled = False
        Me.Id_proveedorTextBox.Location = New System.Drawing.Point(100, 6)
        Me.Id_proveedorTextBox.Name = "Id_proveedorTextBox"
        Me.Id_proveedorTextBox.Size = New System.Drawing.Size(33, 24)
        Me.Id_proveedorTextBox.TabIndex = 21
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(397, 485)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 39)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Asignar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(299, 484)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 40)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 388)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 18)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Comentarios :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Descripcion :"
        '
        'mis_comentarios
        '
        Me.mis_comentarios.Location = New System.Drawing.Point(161, 385)
        Me.mis_comentarios.Multiline = True
        Me.mis_comentarios.Name = "mis_comentarios"
        Me.mis_comentarios.Size = New System.Drawing.Size(315, 94)
        Me.mis_comentarios.TabIndex = 15
        '
        'descripcion
        '
        Me.descripcion.Location = New System.Drawing.Point(161, 303)
        Me.descripcion.Multiline = True
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(317, 76)
        Me.descripcion.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.boton_programada)
        Me.Panel1.Controls.Add(Me.boton_limite)
        Me.Panel1.Controls.Add(Me.fecha)
        Me.Panel1.Location = New System.Drawing.Point(163, 253)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 46)
        Me.Panel1.TabIndex = 13
        '
        'boton_programada
        '
        Me.boton_programada.AutoSize = True
        Me.boton_programada.Checked = True
        Me.boton_programada.Location = New System.Drawing.Point(3, 11)
        Me.boton_programada.Name = "boton_programada"
        Me.boton_programada.Size = New System.Drawing.Size(108, 22)
        Me.boton_programada.TabIndex = 11
        Me.boton_programada.TabStop = True
        Me.boton_programada.Text = "Programada"
        Me.boton_programada.UseVisualStyleBackColor = True
        '
        'boton_limite
        '
        Me.boton_limite.AutoSize = True
        Me.boton_limite.Location = New System.Drawing.Point(122, 11)
        Me.boton_limite.Name = "boton_limite"
        Me.boton_limite.Size = New System.Drawing.Size(65, 22)
        Me.boton_limite.TabIndex = 12
        Me.boton_limite.Text = "Limite"
        Me.boton_limite.UseVisualStyleBackColor = True
        '
        'fecha
        '
        Me.fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha.Location = New System.Drawing.Point(193, 10)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(122, 24)
        Me.fecha.TabIndex = 7
        '
        'boton_correctivo
        '
        Me.boton_correctivo.AutoSize = True
        Me.boton_correctivo.Location = New System.Drawing.Point(280, 100)
        Me.boton_correctivo.Name = "boton_correctivo"
        Me.boton_correctivo.Size = New System.Drawing.Size(95, 22)
        Me.boton_correctivo.TabIndex = 10
        Me.boton_correctivo.TabStop = True
        Me.boton_correctivo.Text = "Correctivo"
        Me.boton_correctivo.UseVisualStyleBackColor = True
        '
        'boton_preventivo
        '
        Me.boton_preventivo.AutoSize = True
        Me.boton_preventivo.Location = New System.Drawing.Point(160, 99)
        Me.boton_preventivo.Name = "boton_preventivo"
        Me.boton_preventivo.Size = New System.Drawing.Size(95, 22)
        Me.boton_preventivo.TabIndex = 9
        Me.boton_preventivo.TabStop = True
        Me.boton_preventivo.Text = "Preventivo"
        Me.boton_preventivo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tipo :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha :"
        '
        'staff
        '
        Me.staff.DataSource = Me.StaffBindingSource
        Me.staff.DisplayMember = "Nombre"
        Me.staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.staff.FormattingEnabled = True
        Me.staff.Location = New System.Drawing.Point(197, 131)
        Me.staff.Name = "staff"
        Me.staff.Size = New System.Drawing.Size(276, 26)
        Me.staff.TabIndex = 5
        Me.staff.ValueMember = "id_usuario"
        '
        'fecha_Asignacion
        '
        Me.fecha_Asignacion.Enabled = False
        Me.fecha_Asignacion.Location = New System.Drawing.Point(160, 60)
        Me.fecha_Asignacion.Name = "fecha_Asignacion"
        Me.fecha_Asignacion.Size = New System.Drawing.Size(274, 24)
        Me.fecha_Asignacion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha asignacion :"
        '
        'id_user
        '
        Me.id_user.Location = New System.Drawing.Point(158, 133)
        Me.id_user.Name = "id_user"
        Me.id_user.Size = New System.Drawing.Size(33, 24)
        Me.id_user.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ASIGNAR TAREA"
        '
        'ReportesBindingSource
        '
        Me.ReportesBindingSource.DataMember = "reportes"
        Me.ReportesBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'Sql_reportesTableAdapter
        '
        Me.Sql_reportesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.actividadesTableAdapter = Nothing
        Me.TableAdapterManager.areasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriasTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.departamentosTableAdapter = Nothing
        Me.TableAdapterManager.equipos_redTableAdapter = Nothing
        Me.TableAdapterManager.equiposTableAdapter = Nothing
        Me.TableAdapterManager.inv_documentosTableAdapter = Nothing
        Me.TableAdapterManager.inv_movimintosTableAdapter = Nothing
        Me.TableAdapterManager.inv_productosTableAdapter = Nothing
        Me.TableAdapterManager.permisosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.reportes_tareasTableAdapter = Nothing
        Me.TableAdapterManager.reportesTableAdapter = Nothing
        Me.TableAdapterManager.rutinasTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.sys_funcionesTableAdapter = Nothing
        Me.TableAdapterManager.sys_tareas_preventivasTableAdapter = Nothing
        Me.TableAdapterManager.tareasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
        '
        'ReportesTableAdapter
        '
        Me.ReportesTableAdapter.ClearBeforeFill = True
        '
        'filtro
        '
        Me.filtro.Location = New System.Drawing.Point(68, 19)
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(480, 24)
        Me.filtro.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Filtro :"
        '
        'lblpendientes
        '
        Me.lblpendientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblpendientes.Location = New System.Drawing.Point(961, 9)
        Me.lblpendientes.Name = "lblpendientes"
        Me.lblpendientes.Size = New System.Drawing.Size(245, 24)
        Me.lblpendientes.TabIndex = 5
        Me.lblpendientes.Text = "Label8"
        Me.lblpendientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pendientes_de_asignar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 621)
        Me.Controls.Add(Me.lblpendientes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.filtro)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "pendientes_de_asignar"
        Me.Text = "Pendientes de Asignar"
        CType(Me.Sql_reportesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_reportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ReportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MantenimientoDataSet As Mantenimineto.mantenimientoDataSet
    Friend WithEvents Sql_reportesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_reportesTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.sql_reportesTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sql_reportesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Fechayhora_registroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fechayhora_solicitudTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComentariosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReporteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UbicacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AreaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegistraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Quien_solicitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents fecha_Asignacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents id_user As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.staffTableAdapter
    Friend WithEvents staff As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mis_comentarios As System.Windows.Forms.TextBox
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents boton_programada As System.Windows.Forms.RadioButton
    Friend WithEvents boton_limite As System.Windows.Forms.RadioButton
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents boton_correctivo As System.Windows.Forms.RadioButton
    Friend WithEvents boton_preventivo As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.proveedoresTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Id_proveedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReportesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportesTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.reportesTableAdapter
    Friend WithEvents Id_servicioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents notifica As System.Windows.Forms.CheckBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents filtro As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents EquipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grupo_equipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblpendientes As System.Windows.Forms.Label
End Class
