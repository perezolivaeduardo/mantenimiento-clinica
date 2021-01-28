<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rutinas
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
        Dim TipoLabel As System.Windows.Forms.Label
        Dim Dia_semanaLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim TareaLabel As System.Windows.Forms.Label
        Dim DetalleLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rutinas))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Lugar_en_el_mesTextBox = New System.Windows.Forms.TextBox()
        Me.RutinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MantenimientoDataSet = New Mantenimineto.mantenimientoDataSet()
        Me.Dia_mesTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.combo_tipo = New System.Windows.Forms.ComboBox()
        Me.combodia = New System.Windows.Forms.ComboBox()
        Me.Id_rutinaTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.Dia_semanaTextBox = New System.Windows.Forms.TextBox()
        Me.StatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.TareaTextBox = New System.Windows.Forms.TextBox()
        Me.DetalleTextBox = New System.Windows.Forms.TextBox()
        Me.Sql_rutinasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lugar_en_el_mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_rutina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sql_rutinasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RutinasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btn_programar = New System.Windows.Forms.ToolStripButton()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sql_rutinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RutinasTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.rutinasTableAdapter()
        Me.TableAdapterManager = New Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager()
        Me.StaffTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.staffTableAdapter()
        Me.Sql_rutinasTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.sql_rutinasTableAdapter()
        TipoLabel = New System.Windows.Forms.Label()
        Dia_semanaLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        TareaLabel = New System.Windows.Forms.Label()
        DetalleLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.RutinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_rutinasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_rutinasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RutinasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RutinasBindingNavigator.SuspendLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_rutinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(43, 51)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(42, 16)
        TipoLabel.TabIndex = 2
        TipoLabel.Text = "Tipo :"
        '
        'Dia_semanaLabel
        '
        Dia_semanaLabel.AutoSize = True
        Dia_semanaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dia_semanaLabel.Location = New System.Drawing.Point(6, 88)
        Dia_semanaLabel.Name = "Dia_semanaLabel"
        Dia_semanaLabel.Size = New System.Drawing.Size(84, 16)
        Dia_semanaLabel.TabIndex = 4
        Dia_semanaLabel.Text = "Dia semana:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.Location = New System.Drawing.Point(27, 511)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(51, 16)
        StatusLabel.TabIndex = 10
        StatusLabel.Text = "Activo :"
        '
        'TareaLabel
        '
        TareaLabel.AutoSize = True
        TareaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TareaLabel.Location = New System.Drawing.Point(36, 163)
        TareaLabel.Name = "TareaLabel"
        TareaLabel.Size = New System.Drawing.Size(48, 16)
        TareaLabel.TabIndex = 12
        TareaLabel.Text = "Tarea:"
        '
        'DetalleLabel
        '
        DetalleLabel.AutoSize = True
        DetalleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DetalleLabel.Location = New System.Drawing.Point(29, 189)
        DetalleLabel.Name = "DetalleLabel"
        DetalleLabel.Size = New System.Drawing.Size(54, 16)
        DetalleLabel.TabIndex = 14
        DetalleLabel.Text = "Detalle:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.combo_tipo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.combodia)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_rutinaTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(TipoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TipoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Dia_semanaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Dia_semanaTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(StatusLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StatusCheckBox)
        Me.SplitContainer1.Panel1.Controls.Add(TareaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TareaTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(DetalleLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DetalleTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Sql_rutinasDataGridView)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RutinasBindingNavigator)
        Me.SplitContainer1.Size = New System.Drawing.Size(1130, 542)
        Me.SplitContainer1.SplitterDistance = 355
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.Lugar_en_el_mesTextBox)
        Me.Panel1.Controls.Add(Me.Dia_mesTextBox)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(30, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(307, 29)
        Me.Panel1.TabIndex = 23
        Me.Panel1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(160, 4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(114, 20)
        Me.RadioButton2.TabIndex = 24
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Dia en el Mes :"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(9, 5)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(104, 20)
        Me.RadioButton1.TabIndex = 23
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Dia del Mes :"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Lugar_en_el_mesTextBox
        '
        Me.Lugar_en_el_mesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "lugar_en_el_mes", True))
        Me.Lugar_en_el_mesTextBox.Enabled = False
        Me.Lugar_en_el_mesTextBox.Location = New System.Drawing.Point(280, 3)
        Me.Lugar_en_el_mesTextBox.Name = "Lugar_en_el_mesTextBox"
        Me.Lugar_en_el_mesTextBox.Size = New System.Drawing.Size(22, 22)
        Me.Lugar_en_el_mesTextBox.TabIndex = 22
        '
        'RutinasBindingSource
        '
        Me.RutinasBindingSource.DataMember = "rutinas"
        Me.RutinasBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'MantenimientoDataSet
        '
        Me.MantenimientoDataSet.DataSetName = "mantenimientoDataSet"
        Me.MantenimientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Dia_mesTextBox
        '
        Me.Dia_mesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "dia_mes", True))
        Me.Dia_mesTextBox.Enabled = False
        Me.Dia_mesTextBox.Location = New System.Drawing.Point(119, 4)
        Me.Dia_mesTextBox.Name = "Dia_mesTextBox"
        Me.Dia_mesTextBox.Size = New System.Drawing.Size(22, 22)
        Me.Dia_mesTextBox.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(196, 507)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(277, 507)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'combo_tipo
        '
        Me.combo_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_tipo.FormattingEnabled = True
        Me.combo_tipo.Items.AddRange(New Object() {"Diaria", "Semanal", "Cada 2 Semanas", "Mensual", "bimestral", "Trimestral", "Semestral", "Anua l"})
        Me.combo_tipo.Location = New System.Drawing.Point(121, 47)
        Me.combo_tipo.Name = "combo_tipo"
        Me.combo_tipo.Size = New System.Drawing.Size(216, 24)
        Me.combo_tipo.TabIndex = 19
        '
        'combodia
        '
        Me.combodia.AutoCompleteCustomSource.AddRange(New String() {"Definir", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"})
        Me.combodia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combodia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combodia.FormattingEnabled = True
        Me.combodia.Items.AddRange(New Object() {"Definir", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"})
        Me.combodia.Location = New System.Drawing.Point(121, 84)
        Me.combodia.Name = "combodia"
        Me.combodia.Size = New System.Drawing.Size(216, 24)
        Me.combodia.TabIndex = 18
        '
        'Id_rutinaTextBox
        '
        Me.Id_rutinaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "id_rutina", True))
        Me.Id_rutinaTextBox.Enabled = False
        Me.Id_rutinaTextBox.Location = New System.Drawing.Point(310, 21)
        Me.Id_rutinaTextBox.Name = "Id_rutinaTextBox"
        Me.Id_rutinaTextBox.ReadOnly = True
        Me.Id_rutinaTextBox.Size = New System.Drawing.Size(27, 20)
        Me.Id_rutinaTextBox.TabIndex = 1
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "tipo", True))
        Me.TipoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoTextBox.Location = New System.Drawing.Point(93, 48)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.ReadOnly = True
        Me.TipoTextBox.Size = New System.Drawing.Size(22, 22)
        Me.TipoTextBox.TabIndex = 3
        '
        'Dia_semanaTextBox
        '
        Me.Dia_semanaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "dia_semana", True))
        Me.Dia_semanaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dia_semanaTextBox.Location = New System.Drawing.Point(93, 85)
        Me.Dia_semanaTextBox.Name = "Dia_semanaTextBox"
        Me.Dia_semanaTextBox.ReadOnly = True
        Me.Dia_semanaTextBox.Size = New System.Drawing.Size(22, 22)
        Me.Dia_semanaTextBox.TabIndex = 5
        '
        'StatusCheckBox
        '
        Me.StatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RutinasBindingSource, "status", True))
        Me.StatusCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusCheckBox.Location = New System.Drawing.Point(93, 506)
        Me.StatusCheckBox.Name = "StatusCheckBox"
        Me.StatusCheckBox.Size = New System.Drawing.Size(36, 24)
        Me.StatusCheckBox.TabIndex = 11
        Me.StatusCheckBox.UseVisualStyleBackColor = True
        '
        'TareaTextBox
        '
        Me.TareaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "tarea", True))
        Me.TareaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TareaTextBox.Location = New System.Drawing.Point(93, 160)
        Me.TareaTextBox.Name = "TareaTextBox"
        Me.TareaTextBox.Size = New System.Drawing.Size(244, 22)
        Me.TareaTextBox.TabIndex = 13
        '
        'DetalleTextBox
        '
        Me.DetalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "detalle", True))
        Me.DetalleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetalleTextBox.Location = New System.Drawing.Point(93, 186)
        Me.DetalleTextBox.Multiline = True
        Me.DetalleTextBox.Name = "DetalleTextBox"
        Me.DetalleTextBox.Size = New System.Drawing.Size(244, 276)
        Me.DetalleTextBox.TabIndex = 15
        '
        'Sql_rutinasDataGridView
        '
        Me.Sql_rutinasDataGridView.AllowUserToAddRows = False
        Me.Sql_rutinasDataGridView.AllowUserToDeleteRows = False
        Me.Sql_rutinasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sql_rutinasDataGridView.AutoGenerateColumns = False
        Me.Sql_rutinasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Sql_rutinasDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Sql_rutinasDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Sql_rutinasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sql_rutinasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.lugar_en_el_mes, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.id_rutina})
        Me.Sql_rutinasDataGridView.DataSource = Me.Sql_rutinasBindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Sql_rutinasDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.Sql_rutinasDataGridView.Location = New System.Drawing.Point(3, 47)
        Me.Sql_rutinasDataGridView.Name = "Sql_rutinasDataGridView"
        Me.Sql_rutinasDataGridView.RowHeadersVisible = False
        Me.Sql_rutinasDataGridView.Size = New System.Drawing.Size(756, 446)
        Me.Sql_rutinasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 57
        '
        'lugar_en_el_mes
        '
        Me.lugar_en_el_mes.DataPropertyName = "lugar_en_el_mes"
        Me.lugar_en_el_mes.HeaderText = "Lugar"
        Me.lugar_en_el_mes.Name = "lugar_en_el_mes"
        Me.lugar_en_el_mes.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "dia"
        Me.DataGridViewTextBoxColumn2.HeaderText = "dia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 52
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "dia_mes"
        Me.DataGridViewTextBoxColumn3.HeaderText = "dia_mes"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 89
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "status"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Visible = False
        Me.DataGridViewCheckBoxColumn1.Width = 54
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "tarea"
        Me.DataGridViewTextBoxColumn6.HeaderText = "tarea"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 66
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "detalle"
        Me.DataGridViewTextBoxColumn7.HeaderText = "detalle"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'id_rutina
        '
        Me.id_rutina.DataPropertyName = "id_rutina"
        Me.id_rutina.HeaderText = "ID"
        Me.id_rutina.Name = "id_rutina"
        Me.id_rutina.Visible = False
        Me.id_rutina.Width = 47
        '
        'Sql_rutinasBindingSource1
        '
        Me.Sql_rutinasBindingSource1.DataMember = "sql_rutinas"
        Me.Sql_rutinasBindingSource1.DataSource = Me.MantenimientoDataSet
        '
        'RutinasBindingNavigator
        '
        Me.RutinasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RutinasBindingNavigator.BindingSource = Me.RutinasBindingSource
        Me.RutinasBindingNavigator.CountItem = Nothing
        Me.RutinasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RutinasBindingNavigator.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.RutinasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1, Me.btn_programar})
        Me.RutinasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RutinasBindingNavigator.MoveFirstItem = Nothing
        Me.RutinasBindingNavigator.MoveLastItem = Nothing
        Me.RutinasBindingNavigator.MoveNextItem = Nothing
        Me.RutinasBindingNavigator.MovePreviousItem = Nothing
        Me.RutinasBindingNavigator.Name = "RutinasBindingNavigator"
        Me.RutinasBindingNavigator.PositionItem = Nothing
        Me.RutinasBindingNavigator.Size = New System.Drawing.Size(771, 39)
        Me.RutinasBindingNavigator.TabIndex = 1
        Me.RutinasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(121, 36)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(86, 36)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = Global.Mantenimineto.My.Resources.Resources.Restart
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(65, 36)
        Me.ToolStripButton1.Text = "Salir"
        '
        'btn_programar
        '
        Me.btn_programar.Image = Global.Mantenimineto.My.Resources.Resources.todo
        Me.btn_programar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_programar.Name = "btn_programar"
        Me.btn_programar.Size = New System.Drawing.Size(141, 36)
        Me.btn_programar.Text = "Programar Rutinas"
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "staff"
        Me.StaffBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'Sql_rutinasBindingSource
        '
        Me.Sql_rutinasBindingSource.DataSource = Me.MantenimientoDataSet
        Me.Sql_rutinasBindingSource.Position = 0
        '
        'RutinasTableAdapter
        '
        Me.RutinasTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.rutinas_programacionTableAdapter = Nothing
        Me.TableAdapterManager.rutinasTableAdapter = Me.RutinasTableAdapter
        Me.TableAdapterManager.staffTableAdapter = Me.StaffTableAdapter
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
        'Sql_rutinasTableAdapter
        '
        Me.Sql_rutinasTableAdapter.ClearBeforeFill = True
        '
        'rutinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 542)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "rutinas"
        Me.Text = "rutinas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RutinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_rutinasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_rutinasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RutinasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RutinasBindingNavigator.ResumeLayout(False)
        Me.RutinasBindingNavigator.PerformLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_rutinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MantenimientoDataSet As Mantenimineto.mantenimientoDataSet
    Friend WithEvents RutinasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RutinasTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.rutinasTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RutinasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Id_rutinaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dia_semanaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dia_mesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TareaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DetalleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StaffTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.staffTableAdapter
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents combodia As System.Windows.Forms.ComboBox
    Friend WithEvents combo_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Sql_rutinasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_rutinasTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.sql_rutinasTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sql_rutinasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Sql_rutinasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Lugar_en_el_mesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lugar_en_el_mes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_rutina As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_programar As System.Windows.Forms.ToolStripButton
End Class
