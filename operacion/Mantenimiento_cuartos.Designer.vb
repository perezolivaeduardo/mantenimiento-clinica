<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mantenimiento_cuartos
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
        Dim FolioLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Quien_solicitaLabel As System.Windows.Forms.Label
        Dim Fechayhora_solicitudLabel As System.Windows.Forms.Label
        Dim Fechayhora_solicitudLabel1 As System.Windows.Forms.Label
        Dim RegistraLabel As System.Windows.Forms.Label
        Dim Fechayhora_registroLabel As System.Windows.Forms.Label
        Dim AreaLabel As System.Windows.Forms.Label
        Dim UbicacionLabel As System.Windows.Forms.Label
        Dim ReporteLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim CuartoLabel As System.Windows.Forms.Label
        Dim FechaprogramacionLabel As System.Windows.Forms.Label
        Dim AtendioLabel As System.Windows.Forms.Label
        Dim STATUSLabel As System.Windows.Forms.Label
        Dim Id_tareaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ActividadLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim ComentariosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mantenimiento_cuartos))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.TabCuartos = New System.Windows.Forms.TabControl()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtcuarto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.filtro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Sql_reportesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.idstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MandarPorCorreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ModificarTipoCorrectivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarTipoPreventivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sql_reportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MantenimientoDataSet = New Mantenimineto.mantenimientoDataSet()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Id_statusTextBox = New System.Windows.Forms.TextBox()
        Me.Id_atendioTextBox = New System.Windows.Forms.TextBox()
        Me.btn_terminar = New System.Windows.Forms.Button()
        Me.btn_VoBo = New System.Windows.Forms.Button()
        Me.STATUSTextBox = New System.Windows.Forms.TextBox()
        Me.AtendioTextBox = New System.Windows.Forms.TextBox()
        Me.FechaprogramacionTextBox = New System.Windows.Forms.TextBox()
        Me.CuartoTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.ReporteTextBox = New System.Windows.Forms.TextBox()
        Me.UbicacionTextBox = New System.Windows.Forms.TextBox()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.Fechayhora_registroTextBox = New System.Windows.Forms.TextBox()
        Me.RegistraTextBox = New System.Windows.Forms.TextBox()
        Me.Fechayhora_solicitudDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fechayhora_solicitudTextBox = New System.Windows.Forms.TextBox()
        Me.Quien_solicitaTextBox = New System.Windows.Forms.TextBox()
        Me.FolioTextBox = New System.Windows.Forms.TextBox()
        Me.Id_servicioTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Sql_tareasDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdtareaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdservicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActividadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComentariosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SqltareasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ComentariosTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.ActividadTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Id_tareaTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Reportes_tareasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvreporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tarea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Reportes_tareasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Sql_reportesTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.sql_reportesTableAdapter()
        Me.Sql_tareasTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.sql_tareasTableAdapter()
        Me.TableAdapterManager = New Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager()
        Me.Reportes_tareasTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.reportes_tareasTableAdapter()
        Me.btn_nueva_actividad = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        FolioLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Quien_solicitaLabel = New System.Windows.Forms.Label()
        Fechayhora_solicitudLabel = New System.Windows.Forms.Label()
        Fechayhora_solicitudLabel1 = New System.Windows.Forms.Label()
        RegistraLabel = New System.Windows.Forms.Label()
        Fechayhora_registroLabel = New System.Windows.Forms.Label()
        AreaLabel = New System.Windows.Forms.Label()
        UbicacionLabel = New System.Windows.Forms.Label()
        ReporteLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        CuartoLabel = New System.Windows.Forms.Label()
        FechaprogramacionLabel = New System.Windows.Forms.Label()
        AtendioLabel = New System.Windows.Forms.Label()
        STATUSLabel = New System.Windows.Forms.Label()
        Id_tareaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ActividadLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        ComentariosLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.Sql_reportesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Sql_reportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.Sql_tareasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SqltareasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Reportes_tareasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reportes_tareasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FolioLabel
        '
        FolioLabel.AutoSize = True
        FolioLabel.Location = New System.Drawing.Point(11, 21)
        FolioLabel.Name = "FolioLabel"
        FolioLabel.Size = New System.Drawing.Size(40, 18)
        FolioLabel.TabIndex = 1
        FolioLabel.Text = "folio:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(365, 21)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(30, 18)
        Label1.TabIndex = 3
        Label1.Text = "ID :"
        '
        'Quien_solicitaLabel
        '
        Quien_solicitaLabel.AutoSize = True
        Quien_solicitaLabel.Location = New System.Drawing.Point(3, 62)
        Quien_solicitaLabel.Name = "Quien_solicitaLabel"
        Quien_solicitaLabel.Size = New System.Drawing.Size(101, 18)
        Quien_solicitaLabel.TabIndex = 4
        Quien_solicitaLabel.Text = "Quien solicita:"
        '
        'Fechayhora_solicitudLabel
        '
        Fechayhora_solicitudLabel.AutoSize = True
        Fechayhora_solicitudLabel.Location = New System.Drawing.Point(7, 109)
        Fechayhora_solicitudLabel.Name = "Fechayhora_solicitudLabel"
        Fechayhora_solicitudLabel.Size = New System.Drawing.Size(111, 18)
        Fechayhora_solicitudLabel.TabIndex = 6
        Fechayhora_solicitudLabel.Text = "Fecha solicitud:"
        '
        'Fechayhora_solicitudLabel1
        '
        Fechayhora_solicitudLabel1.AutoSize = True
        Fechayhora_solicitudLabel1.Location = New System.Drawing.Point(230, 109)
        Fechayhora_solicitudLabel1.Name = "Fechayhora_solicitudLabel1"
        Fechayhora_solicitudLabel1.Size = New System.Drawing.Size(49, 18)
        Fechayhora_solicitudLabel1.TabIndex = 8
        Fechayhora_solicitudLabel1.Text = "Hora :"
        '
        'RegistraLabel
        '
        RegistraLabel.AutoSize = True
        RegistraLabel.Location = New System.Drawing.Point(17, 154)
        RegistraLabel.Name = "RegistraLabel"
        RegistraLabel.Size = New System.Drawing.Size(72, 18)
        RegistraLabel.TabIndex = 10
        RegistraLabel.Text = "Registro :"
        '
        'Fechayhora_registroLabel
        '
        Fechayhora_registroLabel.AutoSize = True
        Fechayhora_registroLabel.Location = New System.Drawing.Point(17, 197)
        Fechayhora_registroLabel.Name = "Fechayhora_registroLabel"
        Fechayhora_registroLabel.Size = New System.Drawing.Size(137, 18)
        Fechayhora_registroLabel.TabIndex = 12
        Fechayhora_registroLabel.Text = "Fecha de Registro :"
        '
        'AreaLabel
        '
        AreaLabel.AutoSize = True
        AreaLabel.Location = New System.Drawing.Point(317, 200)
        AreaLabel.Name = "AreaLabel"
        AreaLabel.Size = New System.Drawing.Size(42, 18)
        AreaLabel.TabIndex = 14
        AreaLabel.Text = "Area:"
        '
        'UbicacionLabel
        '
        UbicacionLabel.AutoSize = True
        UbicacionLabel.Location = New System.Drawing.Point(18, 245)
        UbicacionLabel.Name = "UbicacionLabel"
        UbicacionLabel.Size = New System.Drawing.Size(78, 18)
        UbicacionLabel.TabIndex = 16
        UbicacionLabel.Text = "Ubicacion:"
        '
        'ReporteLabel
        '
        ReporteLabel.AutoSize = True
        ReporteLabel.Location = New System.Drawing.Point(37, 290)
        ReporteLabel.Name = "ReporteLabel"
        ReporteLabel.Size = New System.Drawing.Size(65, 18)
        ReporteLabel.TabIndex = 18
        ReporteLabel.Text = "Reporte:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(60, 371)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(36, 18)
        TipoLabel.TabIndex = 20
        TipoLabel.Text = "tipo:"
        '
        'CuartoLabel
        '
        CuartoLabel.AutoSize = True
        CuartoLabel.Location = New System.Drawing.Point(141, 371)
        CuartoLabel.Name = "CuartoLabel"
        CuartoLabel.Size = New System.Drawing.Size(54, 18)
        CuartoLabel.TabIndex = 22
        CuartoLabel.Text = "cuarto:"
        '
        'FechaprogramacionLabel
        '
        FechaprogramacionLabel.AutoSize = True
        FechaprogramacionLabel.Location = New System.Drawing.Point(14, 410)
        FechaprogramacionLabel.Name = "FechaprogramacionLabel"
        FechaprogramacionLabel.Size = New System.Drawing.Size(143, 18)
        FechaprogramacionLabel.TabIndex = 24
        FechaprogramacionLabel.Text = "Fecha Programada :"
        '
        'AtendioLabel
        '
        AtendioLabel.AutoSize = True
        AtendioLabel.Location = New System.Drawing.Point(15, 457)
        AtendioLabel.Name = "AtendioLabel"
        AtendioLabel.Size = New System.Drawing.Size(85, 18)
        AtendioLabel.TabIndex = 26
        AtendioLabel.Text = "Asignado a:"
        '
        'STATUSLabel
        '
        STATUSLabel.AutoSize = True
        STATUSLabel.Location = New System.Drawing.Point(26, 502)
        STATUSLabel.Name = "STATUSLabel"
        STATUSLabel.Size = New System.Drawing.Size(70, 18)
        STATUSLabel.TabIndex = 28
        STATUSLabel.Text = "STATUS:"
        '
        'Id_tareaLabel
        '
        Id_tareaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Id_tareaLabel.AutoSize = True
        Id_tareaLabel.Location = New System.Drawing.Point(35, 32)
        Id_tareaLabel.Name = "Id_tareaLabel"
        Id_tareaLabel.Size = New System.Drawing.Size(63, 18)
        Id_tareaLabel.TabIndex = 2
        Id_tareaLabel.Text = "ID tarea:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(50, 63)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(48, 18)
        FechaLabel.TabIndex = 3
        FechaLabel.Text = "fecha:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(32, 127)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(66, 18)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'ActividadLabel
        '
        ActividadLabel.AutoSize = True
        ActividadLabel.Location = New System.Drawing.Point(29, 97)
        ActividadLabel.Name = "ActividadLabel"
        ActividadLabel.Size = New System.Drawing.Size(69, 18)
        ActividadLabel.TabIndex = 6
        ActividadLabel.Text = "actividad:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(7, 164)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(91, 18)
        DescripcionLabel.TabIndex = 8
        DescripcionLabel.Text = "Descripcion:"
        '
        'ComentariosLabel
        '
        ComentariosLabel.AutoSize = True
        ComentariosLabel.Location = New System.Drawing.Point(0, 251)
        ComentariosLabel.Name = "ComentariosLabel"
        ComentariosLabel.Size = New System.Drawing.Size(98, 18)
        ComentariosLabel.TabIndex = 10
        ComentariosLabel.Text = "Comentarios:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton5, Me.ToolStripButton3, Me.ToolStripSeparator2, Me.ToolStripButton4, Me.ToolStripButton6, Me.ToolStripButton7})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1148, 71)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 71)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 71)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1148, 671)
        Me.SplitContainer1.SplitterDistance = 657
        Me.SplitContainer1.TabIndex = 1
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TabCuartos)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtcuarto)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer3.Panel1.Controls.Add(Me.filtro)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.Sql_reportesDataGridView)
        Me.SplitContainer3.Size = New System.Drawing.Size(657, 671)
        Me.SplitContainer3.SplitterDistance = 129
        Me.SplitContainer3.TabIndex = 3
        '
        'TabCuartos
        '
        Me.TabCuartos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabCuartos.Location = New System.Drawing.Point(0, 51)
        Me.TabCuartos.Multiline = True
        Me.TabCuartos.Name = "TabCuartos"
        Me.TabCuartos.SelectedIndex = 0
        Me.TabCuartos.Size = New System.Drawing.Size(657, 78)
        Me.TabCuartos.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(537, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 25)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Quitar Filtro"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtcuarto
        '
        Me.txtcuarto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcuarto.Enabled = False
        Me.txtcuarto.Location = New System.Drawing.Point(470, 9)
        Me.txtcuarto.Name = "txtcuarto"
        Me.txtcuarto.Size = New System.Drawing.Size(61, 24)
        Me.txtcuarto.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(403, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cuarto :"
        '
        'filtro
        '
        Me.filtro.Location = New System.Drawing.Point(81, 9)
        Me.filtro.Name = "filtro"
        Me.filtro.Size = New System.Drawing.Size(310, 24)
        Me.filtro.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.filtro, "Puede buscar por Area, departamento,  ubicacion o solicitante")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Buscar :"
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
        Me.Sql_reportesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.idstatus, Me.id_status, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn2})
        Me.Sql_reportesDataGridView.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Sql_reportesDataGridView.DataSource = Me.Sql_reportesBindingSource
        Me.Sql_reportesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sql_reportesDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Sql_reportesDataGridView.Name = "Sql_reportesDataGridView"
        Me.Sql_reportesDataGridView.ReadOnly = True
        Me.Sql_reportesDataGridView.RowHeadersVisible = False
        Me.Sql_reportesDataGridView.Size = New System.Drawing.Size(657, 538)
        Me.Sql_reportesDataGridView.TabIndex = 0
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
        Me.DataGridViewTextBoxColumn16.HeaderText = "reporte"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 80
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Ubicacion"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Ubicacion"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 99
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
        Me.DataGridViewTextBoxColumn4.Width = 103
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
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 93
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
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 112
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
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 67
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
        'idstatus
        '
        Me.idstatus.DataPropertyName = "id_status"
        Me.idstatus.HeaderText = "id_status"
        Me.idstatus.Name = "idstatus"
        Me.idstatus.ReadOnly = True
        Me.idstatus.Width = 92
        '
        'id_status
        '
        Me.id_status.DataPropertyName = "id_status"
        Me.id_status.HeaderText = "id_status"
        Me.id_status.Name = "id_status"
        Me.id_status.ReadOnly = True
        Me.id_status.Width = 92
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "STATUS"
        Me.DataGridViewTextBoxColumn33.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Width = 91
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "folio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "folio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 61
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MandarPorCorreoToolStripMenuItem, Me.ToolStripSeparator1, Me.ModificarTipoCorrectivoToolStripMenuItem, Me.ModificarTipoPreventivoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(212, 76)
        '
        'MandarPorCorreoToolStripMenuItem
        '
        Me.MandarPorCorreoToolStripMenuItem.Name = "MandarPorCorreoToolStripMenuItem"
        Me.MandarPorCorreoToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.MandarPorCorreoToolStripMenuItem.Text = "Mandar por Correo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(208, 6)
        '
        'ModificarTipoCorrectivoToolStripMenuItem
        '
        Me.ModificarTipoCorrectivoToolStripMenuItem.Name = "ModificarTipoCorrectivoToolStripMenuItem"
        Me.ModificarTipoCorrectivoToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ModificarTipoCorrectivoToolStripMenuItem.Text = "Modificar Tipo Correctivo"
        '
        'ModificarTipoPreventivoToolStripMenuItem
        '
        Me.ModificarTipoPreventivoToolStripMenuItem.Name = "ModificarTipoPreventivoToolStripMenuItem"
        Me.ModificarTipoPreventivoToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ModificarTipoPreventivoToolStripMenuItem.Text = "Modificar Tipo Preventivo"
        '
        'Sql_reportesBindingSource
        '
        Me.Sql_reportesBindingSource.AllowNew = False
        Me.Sql_reportesBindingSource.DataMember = "sql_reportes"
        Me.Sql_reportesBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'MantenimientoDataSet
        '
        Me.MantenimientoDataSet.DataSetName = "mantenimientoDataSet"
        Me.MantenimientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(487, 671)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Id_statusTextBox)
        Me.TabPage1.Controls.Add(Me.Id_atendioTextBox)
        Me.TabPage1.Controls.Add(Me.btn_terminar)
        Me.TabPage1.Controls.Add(Me.btn_VoBo)
        Me.TabPage1.Controls.Add(STATUSLabel)
        Me.TabPage1.Controls.Add(Me.STATUSTextBox)
        Me.TabPage1.Controls.Add(AtendioLabel)
        Me.TabPage1.Controls.Add(Me.AtendioTextBox)
        Me.TabPage1.Controls.Add(FechaprogramacionLabel)
        Me.TabPage1.Controls.Add(Me.FechaprogramacionTextBox)
        Me.TabPage1.Controls.Add(CuartoLabel)
        Me.TabPage1.Controls.Add(Me.CuartoTextBox)
        Me.TabPage1.Controls.Add(TipoLabel)
        Me.TabPage1.Controls.Add(Me.TipoTextBox)
        Me.TabPage1.Controls.Add(ReporteLabel)
        Me.TabPage1.Controls.Add(Me.ReporteTextBox)
        Me.TabPage1.Controls.Add(UbicacionLabel)
        Me.TabPage1.Controls.Add(Me.UbicacionTextBox)
        Me.TabPage1.Controls.Add(AreaLabel)
        Me.TabPage1.Controls.Add(Me.AreaTextBox)
        Me.TabPage1.Controls.Add(Fechayhora_registroLabel)
        Me.TabPage1.Controls.Add(Me.Fechayhora_registroTextBox)
        Me.TabPage1.Controls.Add(RegistraLabel)
        Me.TabPage1.Controls.Add(Me.RegistraTextBox)
        Me.TabPage1.Controls.Add(Fechayhora_solicitudLabel1)
        Me.TabPage1.Controls.Add(Me.Fechayhora_solicitudDateTimePicker)
        Me.TabPage1.Controls.Add(Fechayhora_solicitudLabel)
        Me.TabPage1.Controls.Add(Me.Fechayhora_solicitudTextBox)
        Me.TabPage1.Controls.Add(Quien_solicitaLabel)
        Me.TabPage1.Controls.Add(Me.Quien_solicitaTextBox)
        Me.TabPage1.Controls.Add(Label1)
        Me.TabPage1.Controls.Add(FolioLabel)
        Me.TabPage1.Controls.Add(Me.FolioTextBox)
        Me.TabPage1.Controls.Add(Me.Id_servicioTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(479, 640)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reporte"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Id_statusTextBox
        '
        Me.Id_statusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "id_status", True))
        Me.Id_statusTextBox.Location = New System.Drawing.Point(208, 499)
        Me.Id_statusTextBox.Name = "Id_statusTextBox"
        Me.Id_statusTextBox.Size = New System.Drawing.Size(32, 24)
        Me.Id_statusTextBox.TabIndex = 34
        '
        'Id_atendioTextBox
        '
        Me.Id_atendioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "id_atendio", True))
        Me.Id_atendioTextBox.Location = New System.Drawing.Point(439, 487)
        Me.Id_atendioTextBox.Name = "Id_atendioTextBox"
        Me.Id_atendioTextBox.Size = New System.Drawing.Size(22, 24)
        Me.Id_atendioTextBox.TabIndex = 33
        '
        'btn_terminar
        '
        Me.btn_terminar.Location = New System.Drawing.Point(26, 558)
        Me.btn_terminar.Name = "btn_terminar"
        Me.btn_terminar.Size = New System.Drawing.Size(128, 28)
        Me.btn_terminar.TabIndex = 31
        Me.btn_terminar.Text = "Terminar tarea"
        Me.btn_terminar.UseVisualStyleBackColor = True
        '
        'btn_VoBo
        '
        Me.btn_VoBo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_VoBo.Location = New System.Drawing.Point(354, 557)
        Me.btn_VoBo.Name = "btn_VoBo"
        Me.btn_VoBo.Size = New System.Drawing.Size(107, 28)
        Me.btn_VoBo.TabIndex = 30
        Me.btn_VoBo.Text = "Dar VoBo"
        Me.btn_VoBo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_VoBo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btn_VoBo, "Opcion para recibir trabajo terminado.")
        Me.btn_VoBo.UseVisualStyleBackColor = True
        '
        'STATUSTextBox
        '
        Me.STATUSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "STATUS", True))
        Me.STATUSTextBox.Location = New System.Drawing.Point(102, 499)
        Me.STATUSTextBox.Name = "STATUSTextBox"
        Me.STATUSTextBox.Size = New System.Drawing.Size(100, 24)
        Me.STATUSTextBox.TabIndex = 29
        '
        'AtendioTextBox
        '
        Me.AtendioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "Atendio", True))
        Me.AtendioTextBox.Location = New System.Drawing.Point(102, 457)
        Me.AtendioTextBox.Name = "AtendioTextBox"
        Me.AtendioTextBox.Size = New System.Drawing.Size(359, 24)
        Me.AtendioTextBox.TabIndex = 27
        '
        'FechaprogramacionTextBox
        '
        Me.FechaprogramacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "fechaprogramacion", True))
        Me.FechaprogramacionTextBox.Location = New System.Drawing.Point(160, 407)
        Me.FechaprogramacionTextBox.Name = "FechaprogramacionTextBox"
        Me.FechaprogramacionTextBox.Size = New System.Drawing.Size(100, 24)
        Me.FechaprogramacionTextBox.TabIndex = 25
        '
        'CuartoTextBox
        '
        Me.CuartoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "cuarto", True))
        Me.CuartoTextBox.Location = New System.Drawing.Point(201, 368)
        Me.CuartoTextBox.Name = "CuartoTextBox"
        Me.CuartoTextBox.Size = New System.Drawing.Size(40, 24)
        Me.CuartoTextBox.TabIndex = 23
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(102, 368)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(31, 24)
        Me.TipoTextBox.TabIndex = 21
        '
        'ReporteTextBox
        '
        Me.ReporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "reporte", True))
        Me.ReporteTextBox.Location = New System.Drawing.Point(102, 287)
        Me.ReporteTextBox.Multiline = True
        Me.ReporteTextBox.Name = "ReporteTextBox"
        Me.ReporteTextBox.Size = New System.Drawing.Size(359, 70)
        Me.ReporteTextBox.TabIndex = 19
        '
        'UbicacionTextBox
        '
        Me.UbicacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "Ubicacion", True))
        Me.UbicacionTextBox.Location = New System.Drawing.Point(102, 242)
        Me.UbicacionTextBox.Name = "UbicacionTextBox"
        Me.UbicacionTextBox.Size = New System.Drawing.Size(363, 24)
        Me.UbicacionTextBox.TabIndex = 17
        '
        'AreaTextBox
        '
        Me.AreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "Area", True))
        Me.AreaTextBox.Location = New System.Drawing.Point(365, 197)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.Size = New System.Drawing.Size(100, 24)
        Me.AreaTextBox.TabIndex = 15
        '
        'Fechayhora_registroTextBox
        '
        Me.Fechayhora_registroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "fechayhora_registro", True))
        Me.Fechayhora_registroTextBox.Location = New System.Drawing.Point(160, 197)
        Me.Fechayhora_registroTextBox.Name = "Fechayhora_registroTextBox"
        Me.Fechayhora_registroTextBox.Size = New System.Drawing.Size(116, 24)
        Me.Fechayhora_registroTextBox.TabIndex = 13
        '
        'RegistraTextBox
        '
        Me.RegistraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "Registra", True))
        Me.RegistraTextBox.Location = New System.Drawing.Point(106, 151)
        Me.RegistraTextBox.Name = "RegistraTextBox"
        Me.RegistraTextBox.Size = New System.Drawing.Size(363, 24)
        Me.RegistraTextBox.TabIndex = 11
        '
        'Fechayhora_solicitudDateTimePicker
        '
        Me.Fechayhora_solicitudDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Sql_reportesBindingSource, "fechayhora_solicitud", True))
        Me.Fechayhora_solicitudDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Fechayhora_solicitudDateTimePicker.Location = New System.Drawing.Point(285, 104)
        Me.Fechayhora_solicitudDateTimePicker.Name = "Fechayhora_solicitudDateTimePicker"
        Me.Fechayhora_solicitudDateTimePicker.Size = New System.Drawing.Size(130, 24)
        Me.Fechayhora_solicitudDateTimePicker.TabIndex = 9
        '
        'Fechayhora_solicitudTextBox
        '
        Me.Fechayhora_solicitudTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "fechayhora_solicitud", True))
        Me.Fechayhora_solicitudTextBox.Location = New System.Drawing.Point(124, 106)
        Me.Fechayhora_solicitudTextBox.Name = "Fechayhora_solicitudTextBox"
        Me.Fechayhora_solicitudTextBox.Size = New System.Drawing.Size(100, 24)
        Me.Fechayhora_solicitudTextBox.TabIndex = 7
        '
        'Quien_solicitaTextBox
        '
        Me.Quien_solicitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "quien_solicita", True))
        Me.Quien_solicitaTextBox.Location = New System.Drawing.Point(106, 59)
        Me.Quien_solicitaTextBox.Name = "Quien_solicitaTextBox"
        Me.Quien_solicitaTextBox.Size = New System.Drawing.Size(363, 24)
        Me.Quien_solicitaTextBox.TabIndex = 5
        '
        'FolioTextBox
        '
        Me.FolioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "folio", True))
        Me.FolioTextBox.Location = New System.Drawing.Point(57, 18)
        Me.FolioTextBox.Name = "FolioTextBox"
        Me.FolioTextBox.Size = New System.Drawing.Size(100, 24)
        Me.FolioTextBox.TabIndex = 2
        '
        'Id_servicioTextBox
        '
        Me.Id_servicioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sql_reportesBindingSource, "id_servicio", True))
        Me.Id_servicioTextBox.Enabled = False
        Me.Id_servicioTextBox.ForeColor = System.Drawing.Color.Red
        Me.Id_servicioTextBox.Location = New System.Drawing.Point(401, 18)
        Me.Id_servicioTextBox.Name = "Id_servicioTextBox"
        Me.Id_servicioTextBox.Size = New System.Drawing.Size(69, 24)
        Me.Id_servicioTextBox.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(479, 640)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Actividades"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.Sql_tareasDataGridView)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStrip2)
        Me.SplitContainer2.Panel2.Controls.Add(ComentariosLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ComentariosTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(DescripcionLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.DescripcionTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(ActividadLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ActividadTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(NombreLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.NombreTextBox)
        Me.SplitContainer2.Panel2.Controls.Add(FechaLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.FechaDateTimePicker)
        Me.SplitContainer2.Panel2.Controls.Add(Id_tareaLabel)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Id_tareaTextBox)
        Me.SplitContainer2.Size = New System.Drawing.Size(473, 639)
        Me.SplitContainer2.SplitterDistance = 171
        Me.SplitContainer2.TabIndex = 0
        '
        'Sql_tareasDataGridView
        '
        Me.Sql_tareasDataGridView.AllowUserToAddRows = False
        Me.Sql_tareasDataGridView.AllowUserToDeleteRows = False
        Me.Sql_tareasDataGridView.AllowUserToResizeColumns = False
        Me.Sql_tareasDataGridView.AllowUserToResizeRows = False
        Me.Sql_tareasDataGridView.AutoGenerateColumns = False
        Me.Sql_tareasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Sql_tareasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Sql_tareasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sql_tareasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtareaDataGridViewTextBoxColumn, Me.IdservicioDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ActividadDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ComentariosDataGridViewTextBoxColumn})
        Me.Sql_tareasDataGridView.DataSource = Me.SqltareasBindingSource
        Me.Sql_tareasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sql_tareasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Sql_tareasDataGridView.Name = "Sql_tareasDataGridView"
        Me.Sql_tareasDataGridView.ReadOnly = True
        Me.Sql_tareasDataGridView.RowHeadersVisible = False
        Me.Sql_tareasDataGridView.Size = New System.Drawing.Size(473, 171)
        Me.Sql_tareasDataGridView.TabIndex = 0
        '
        'IdtareaDataGridViewTextBoxColumn
        '
        Me.IdtareaDataGridViewTextBoxColumn.DataPropertyName = "id_tarea"
        Me.IdtareaDataGridViewTextBoxColumn.HeaderText = "id_tarea"
        Me.IdtareaDataGridViewTextBoxColumn.Name = "IdtareaDataGridViewTextBoxColumn"
        Me.IdtareaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdtareaDataGridViewTextBoxColumn.Width = 85
        '
        'IdservicioDataGridViewTextBoxColumn
        '
        Me.IdservicioDataGridViewTextBoxColumn.DataPropertyName = "id_servicio"
        Me.IdservicioDataGridViewTextBoxColumn.HeaderText = "id_servicio"
        Me.IdservicioDataGridViewTextBoxColumn.Name = "IdservicioDataGridViewTextBoxColumn"
        Me.IdservicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdservicioDataGridViewTextBoxColumn.Width = 103
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 69
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 87
        '
        'ActividadDataGridViewTextBoxColumn
        '
        Me.ActividadDataGridViewTextBoxColumn.DataPropertyName = "actividad"
        Me.ActividadDataGridViewTextBoxColumn.HeaderText = "actividad"
        Me.ActividadDataGridViewTextBoxColumn.Name = "ActividadDataGridViewTextBoxColumn"
        Me.ActividadDataGridViewTextBoxColumn.ReadOnly = True
        Me.ActividadDataGridViewTextBoxColumn.Width = 90
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 109
        '
        'ComentariosDataGridViewTextBoxColumn
        '
        Me.ComentariosDataGridViewTextBoxColumn.DataPropertyName = "comentarios"
        Me.ComentariosDataGridViewTextBoxColumn.HeaderText = "comentarios"
        Me.ComentariosDataGridViewTextBoxColumn.Name = "ComentariosDataGridViewTextBoxColumn"
        Me.ComentariosDataGridViewTextBoxColumn.ReadOnly = True
        Me.ComentariosDataGridViewTextBoxColumn.Width = 116
        '
        'SqltareasBindingSource
        '
        Me.SqltareasBindingSource.DataMember = "sql_tareas"
        Me.SqltareasBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_nueva_actividad})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 393)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(473, 71)
        Me.ToolStrip2.TabIndex = 12
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ComentariosTextBox
        '
        Me.ComentariosTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComentariosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SqltareasBindingSource, "comentarios", True))
        Me.ComentariosTextBox.Enabled = False
        Me.ComentariosTextBox.Location = New System.Drawing.Point(101, 251)
        Me.ComentariosTextBox.Multiline = True
        Me.ComentariosTextBox.Name = "ComentariosTextBox"
        Me.ComentariosTextBox.Size = New System.Drawing.Size(363, 82)
        Me.ComentariosTextBox.TabIndex = 11
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SqltareasBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Enabled = False
        Me.DescripcionTextBox.Location = New System.Drawing.Point(101, 161)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(363, 84)
        Me.DescripcionTextBox.TabIndex = 9
        '
        'ActividadTextBox
        '
        Me.ActividadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SqltareasBindingSource, "actividad", True))
        Me.ActividadTextBox.Enabled = False
        Me.ActividadTextBox.Location = New System.Drawing.Point(101, 97)
        Me.ActividadTextBox.Name = "ActividadTextBox"
        Me.ActividadTextBox.Size = New System.Drawing.Size(100, 24)
        Me.ActividadTextBox.TabIndex = 7
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SqltareasBindingSource, "Nombre", True))
        Me.NombreTextBox.Enabled = False
        Me.NombreTextBox.Location = New System.Drawing.Point(101, 127)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 24)
        Me.NombreTextBox.TabIndex = 5
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SqltareasBindingSource, "fecha", True))
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SqltareasBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(101, 59)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(136, 24)
        Me.FechaDateTimePicker.TabIndex = 4
        '
        'Id_tareaTextBox
        '
        Me.Id_tareaTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Id_tareaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SqltareasBindingSource, "id_tarea", True))
        Me.Id_tareaTextBox.Enabled = False
        Me.Id_tareaTextBox.Location = New System.Drawing.Point(101, 29)
        Me.Id_tareaTextBox.Name = "Id_tareaTextBox"
        Me.Id_tareaTextBox.Size = New System.Drawing.Size(100, 24)
        Me.Id_tareaTextBox.TabIndex = 3
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Reportes_tareasDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(479, 640)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tareas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Reportes_tareasDataGridView
        '
        Me.Reportes_tareasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Reportes_tareasDataGridView.AutoGenerateColumns = False
        Me.Reportes_tareasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Reportes_tareasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Reportes_tareasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Reportes_tareasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn32, Me.dgvreporte, Me.DataGridViewTextBoxColumn35, Me.tarea, Me.DataGridViewTextBoxColumn37, Me.DataGridViewCheckBoxColumn1})
        Me.Reportes_tareasDataGridView.DataSource = Me.Reportes_tareasBindingSource
        Me.Reportes_tareasDataGridView.Location = New System.Drawing.Point(6, 45)
        Me.Reportes_tareasDataGridView.Name = "Reportes_tareasDataGridView"
        Me.Reportes_tareasDataGridView.RowHeadersVisible = False
        Me.Reportes_tareasDataGridView.Size = New System.Drawing.Size(465, 351)
        Me.Reportes_tareasDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn32.HeaderText = "id"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Visible = False
        Me.DataGridViewTextBoxColumn32.Width = 21
        '
        'dgvreporte
        '
        Me.dgvreporte.DataPropertyName = "id_reporte"
        Me.dgvreporte.HeaderText = "id_reporte"
        Me.dgvreporte.Name = "dgvreporte"
        Me.dgvreporte.Visible = False
        Me.dgvreporte.Width = 60
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "id_tara"
        Me.DataGridViewTextBoxColumn35.HeaderText = "id_tara"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Width = 77
        '
        'tarea
        '
        Me.tarea.DataPropertyName = "tarea"
        Me.tarea.HeaderText = "tarea"
        Me.tarea.Name = "tarea"
        Me.tarea.Width = 66
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "comentarios"
        Me.DataGridViewTextBoxColumn37.HeaderText = "comentarios"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "realizada"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "realizada"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 73
        '
        'Reportes_tareasBindingSource
        '
        Me.Reportes_tareasBindingSource.DataMember = "reportes_tareas"
        Me.Reportes_tareasBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'Sql_reportesTableAdapter
        '
        Me.Sql_reportesTableAdapter.ClearBeforeFill = True
        '
        'Sql_tareasTableAdapter
        '
        Me.Sql_tareasTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.reportes_tareasTableAdapter = Me.Reportes_tareasTableAdapter
        Me.TableAdapterManager.reportesTableAdapter = Nothing
        Me.TableAdapterManager.rutinasTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.sys_funcionesTableAdapter = Nothing
        Me.TableAdapterManager.sys_tareas_preventivasTableAdapter = Nothing
        Me.TableAdapterManager.tareasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Reportes_tareasTableAdapter
        '
        Me.Reportes_tareasTableAdapter.ClearBeforeFill = True
        '
        'btn_nueva_actividad
        '
        Me.btn_nueva_actividad.Image = Global.Mantenimineto.My.Resources.Resources.nueva_actividad
        Me.btn_nueva_actividad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_nueva_actividad.Name = "btn_nueva_actividad"
        Me.btn_nueva_actividad.Size = New System.Drawing.Size(162, 68)
        Me.btn_nueva_actividad.Text = "Nueva Actividad"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Mantenimineto.My.Resources.Resources.Restart
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Mantenimineto.My.Resources.Resources.vobo
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(155, 68)
        Me.ToolStripButton2.Text = "Ver Terminadas"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = Global.Mantenimineto.My.Resources.Resources.todo2
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(152, 68)
        Me.ToolStripButton5.Text = "Ver Pendientes"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(179, 68)
        Me.ToolStripButton3.Text = "Pendientes de VoBo"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton4.Image = Global.Mantenimineto.My.Resources.Resources.asignar1
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(151, 68)
        Me.ToolStripButton4.Text = "Lista de Tareas"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(216, 68)
        Me.ToolStripButton6.Text = "Programar Mantenimiento"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = Global.Mantenimineto.My.Resources.Resources.printer1
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(68, 68)
        Me.ToolStripButton7.Text = "ToolStripButton7"
        '
        'Mantenimiento_cuartos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 742)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Mantenimiento_cuartos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento a Cuartos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.Sql_reportesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Sql_reportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.Sql_tareasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SqltareasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Reportes_tareasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reportes_tareasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents MantenimientoDataSet As Mantenimineto.mantenimientoDataSet
    Friend WithEvents Sql_reportesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_reportesTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.sql_reportesTableAdapter
    Friend WithEvents Sql_reportesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents STATUSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AtendioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaprogramacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CuartoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReporteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UbicacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AreaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fechayhora_registroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RegistraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fechayhora_solicitudDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fechayhora_solicitudTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Quien_solicitaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FolioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_servicioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Sql_tareasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ComentariosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ActividadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Id_tareaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_nueva_actividad As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MandarPorCorreoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_VoBo As System.Windows.Forms.Button
    Friend WithEvents btn_terminar As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents filtro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtcuarto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SqltareasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_tareasTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.sql_tareasTableAdapter
    Friend WithEvents IdtareaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdservicioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActividadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComentariosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents idstatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_atendioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Id_statusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabCuartos As System.Windows.Forms.TabControl
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ModificarTipoCorrectivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarTipoPreventivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Reportes_tareasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Reportes_tareasTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.reportes_tareasTableAdapter
    Friend WithEvents Reportes_tareasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvreporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tarea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
End Class
