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
        Dim Dia_mesLabel As System.Windows.Forms.Label
        Dim Id_usuarioLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim TareaLabel As System.Windows.Forms.Label
        Dim DetalleLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rutinas))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.combo_tipo = New System.Windows.Forms.ComboBox()
        Me.combodia = New System.Windows.Forms.ComboBox()
        Me.NombreComboBox = New System.Windows.Forms.ComboBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MantenimientoDataSet = New Mantenimineto.mantenimientoDataSet()
        Me.Id_rutinaTextBox = New System.Windows.Forms.TextBox()
        Me.RutinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.Dia_semanaTextBox = New System.Windows.Forms.TextBox()
        Me.Dia_mesTextBox = New System.Windows.Forms.TextBox()
        Me.Id_usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.StatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.TareaTextBox = New System.Windows.Forms.TextBox()
        Me.DetalleTextBox = New System.Windows.Forms.TextBox()
        Me.Sql_rutinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RutinasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.RutinasTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.rutinasTableAdapter()
        Me.TableAdapterManager = New Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager()
        Me.StaffTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.staffTableAdapter()
        Me.Sql_rutinasTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.sql_rutinasTableAdapter()
        Me.Sql_rutinasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sql_rutinasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        TipoLabel = New System.Windows.Forms.Label()
        Dia_semanaLabel = New System.Windows.Forms.Label()
        Dia_mesLabel = New System.Windows.Forms.Label()
        Id_usuarioLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        TareaLabel = New System.Windows.Forms.Label()
        DetalleLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RutinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_rutinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RutinasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RutinasBindingNavigator.SuspendLayout()
        CType(Me.Sql_rutinasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_rutinasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(43, 76)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(27, 13)
        TipoLabel.TabIndex = 2
        TipoLabel.Text = "tipo:"
        '
        'Dia_semanaLabel
        '
        Dia_semanaLabel.AutoSize = True
        Dia_semanaLabel.Location = New System.Drawing.Point(6, 102)
        Dia_semanaLabel.Name = "Dia_semanaLabel"
        Dia_semanaLabel.Size = New System.Drawing.Size(64, 13)
        Dia_semanaLabel.TabIndex = 4
        Dia_semanaLabel.Text = "dia semana:"
        '
        'Dia_mesLabel
        '
        Dia_mesLabel.AutoSize = True
        Dia_mesLabel.Location = New System.Drawing.Point(24, 128)
        Dia_mesLabel.Name = "Dia_mesLabel"
        Dia_mesLabel.Size = New System.Drawing.Size(46, 13)
        Dia_mesLabel.TabIndex = 6
        Dia_mesLabel.Text = "dia mes:"
        '
        'Id_usuarioLabel
        '
        Id_usuarioLabel.AutoSize = True
        Id_usuarioLabel.Location = New System.Drawing.Point(15, 154)
        Id_usuarioLabel.Name = "Id_usuarioLabel"
        Id_usuarioLabel.Size = New System.Drawing.Size(55, 13)
        Id_usuarioLabel.TabIndex = 8
        Id_usuarioLabel.Text = "id usuario:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(27, 182)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(43, 13)
        StatusLabel.TabIndex = 10
        StatusLabel.Text = "Activo :"
        '
        'TareaLabel
        '
        TareaLabel.AutoSize = True
        TareaLabel.Location = New System.Drawing.Point(36, 210)
        TareaLabel.Name = "TareaLabel"
        TareaLabel.Size = New System.Drawing.Size(34, 13)
        TareaLabel.TabIndex = 12
        TareaLabel.Text = "tarea:"
        '
        'DetalleLabel
        '
        DetalleLabel.AutoSize = True
        DetalleLabel.Location = New System.Drawing.Point(29, 236)
        DetalleLabel.Name = "DetalleLabel"
        DetalleLabel.Size = New System.Drawing.Size(41, 13)
        DetalleLabel.TabIndex = 14
        DetalleLabel.Text = "detalle:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.combo_tipo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.combodia)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NombreComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_rutinaTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(TipoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TipoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Dia_semanaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Dia_semanaTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Dia_mesLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Dia_mesTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Id_usuarioLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Id_usuarioTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(StatusLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StatusCheckBox)
        Me.SplitContainer1.Panel1.Controls.Add(TareaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TareaTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(DetalleLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DetalleTextBox)
        Me.SplitContainer1.Panel1Collapsed = True
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Sql_rutinasDataGridView)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RutinasBindingNavigator)
        Me.SplitContainer1.Size = New System.Drawing.Size(911, 464)
        Me.SplitContainer1.SplitterDistance = 355
        Me.SplitContainer1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(181, 416)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(262, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'combo_tipo
        '
        Me.combo_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_tipo.FormattingEnabled = True
        Me.combo_tipo.Items.AddRange(New Object() {"Diaria", "Semanal", "Mensual", "bimestral", "Semestral", "Anual"})
        Me.combo_tipo.Location = New System.Drawing.Point(121, 72)
        Me.combo_tipo.Name = "combo_tipo"
        Me.combo_tipo.Size = New System.Drawing.Size(216, 21)
        Me.combo_tipo.TabIndex = 19
        '
        'combodia
        '
        Me.combodia.AutoCompleteCustomSource.AddRange(New String() {"Definir", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"})
        Me.combodia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combodia.FormattingEnabled = True
        Me.combodia.Items.AddRange(New Object() {"Definir", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"})
        Me.combodia.Location = New System.Drawing.Point(121, 98)
        Me.combodia.Name = "combodia"
        Me.combodia.Size = New System.Drawing.Size(216, 21)
        Me.combodia.TabIndex = 18
        '
        'NombreComboBox
        '
        Me.NombreComboBox.DataSource = Me.StaffBindingSource
        Me.NombreComboBox.DisplayMember = "Nombre"
        Me.NombreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NombreComboBox.FormattingEnabled = True
        Me.NombreComboBox.Location = New System.Drawing.Point(121, 151)
        Me.NombreComboBox.Name = "NombreComboBox"
        Me.NombreComboBox.Size = New System.Drawing.Size(216, 21)
        Me.NombreComboBox.TabIndex = 17
        Me.NombreComboBox.ValueMember = "id_usuario"
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "staff"
        Me.StaffBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'MantenimientoDataSet
        '
        Me.MantenimientoDataSet.DataSetName = "mantenimientoDataSet"
        Me.MantenimientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Id_rutinaTextBox
        '
        Me.Id_rutinaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "id_rutina", True))
        Me.Id_rutinaTextBox.Enabled = False
        Me.Id_rutinaTextBox.Location = New System.Drawing.Point(310, 12)
        Me.Id_rutinaTextBox.Name = "Id_rutinaTextBox"
        Me.Id_rutinaTextBox.Size = New System.Drawing.Size(27, 20)
        Me.Id_rutinaTextBox.TabIndex = 1
        Me.Id_rutinaTextBox.Visible = False
        '
        'RutinasBindingSource
        '
        Me.RutinasBindingSource.DataMember = "rutinas"
        Me.RutinasBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(93, 73)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.ReadOnly = True
        Me.TipoTextBox.Size = New System.Drawing.Size(22, 20)
        Me.TipoTextBox.TabIndex = 3
        '
        'Dia_semanaTextBox
        '
        Me.Dia_semanaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "dia_semana", True))
        Me.Dia_semanaTextBox.Location = New System.Drawing.Point(93, 99)
        Me.Dia_semanaTextBox.Name = "Dia_semanaTextBox"
        Me.Dia_semanaTextBox.ReadOnly = True
        Me.Dia_semanaTextBox.Size = New System.Drawing.Size(22, 20)
        Me.Dia_semanaTextBox.TabIndex = 5
        '
        'Dia_mesTextBox
        '
        Me.Dia_mesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "dia_mes", True))
        Me.Dia_mesTextBox.Location = New System.Drawing.Point(93, 125)
        Me.Dia_mesTextBox.Name = "Dia_mesTextBox"
        Me.Dia_mesTextBox.Size = New System.Drawing.Size(22, 20)
        Me.Dia_mesTextBox.TabIndex = 7
        '
        'Id_usuarioTextBox
        '
        Me.Id_usuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "id_usuario", True))
        Me.Id_usuarioTextBox.Location = New System.Drawing.Point(93, 151)
        Me.Id_usuarioTextBox.Name = "Id_usuarioTextBox"
        Me.Id_usuarioTextBox.ReadOnly = True
        Me.Id_usuarioTextBox.Size = New System.Drawing.Size(22, 20)
        Me.Id_usuarioTextBox.TabIndex = 9
        '
        'StatusCheckBox
        '
        Me.StatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.RutinasBindingSource, "status", True))
        Me.StatusCheckBox.Location = New System.Drawing.Point(93, 177)
        Me.StatusCheckBox.Name = "StatusCheckBox"
        Me.StatusCheckBox.Size = New System.Drawing.Size(36, 24)
        Me.StatusCheckBox.TabIndex = 11
        Me.StatusCheckBox.UseVisualStyleBackColor = True
        '
        'TareaTextBox
        '
        Me.TareaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "tarea", True))
        Me.TareaTextBox.Location = New System.Drawing.Point(93, 207)
        Me.TareaTextBox.Name = "TareaTextBox"
        Me.TareaTextBox.Size = New System.Drawing.Size(244, 20)
        Me.TareaTextBox.TabIndex = 13
        '
        'DetalleTextBox
        '
        Me.DetalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RutinasBindingSource, "detalle", True))
        Me.DetalleTextBox.Location = New System.Drawing.Point(93, 233)
        Me.DetalleTextBox.Multiline = True
        Me.DetalleTextBox.Name = "DetalleTextBox"
        Me.DetalleTextBox.Size = New System.Drawing.Size(244, 177)
        Me.DetalleTextBox.TabIndex = 15
        '
        'Sql_rutinasBindingSource
        '
        Me.Sql_rutinasBindingSource.DataSource = Me.MantenimientoDataSet
        Me.Sql_rutinasBindingSource.Position = 0
        '
        'RutinasBindingNavigator
        '
        Me.RutinasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RutinasBindingNavigator.BindingSource = Me.RutinasBindingSource
        Me.RutinasBindingNavigator.CountItem = Nothing
        Me.RutinasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RutinasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1})
        Me.RutinasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RutinasBindingNavigator.MoveFirstItem = Nothing
        Me.RutinasBindingNavigator.MoveLastItem = Nothing
        Me.RutinasBindingNavigator.MoveNextItem = Nothing
        Me.RutinasBindingNavigator.MovePreviousItem = Nothing
        Me.RutinasBindingNavigator.Name = "RutinasBindingNavigator"
        Me.RutinasBindingNavigator.PositionItem = Nothing
        Me.RutinasBindingNavigator.Size = New System.Drawing.Size(911, 25)
        Me.RutinasBindingNavigator.TabIndex = 1
        Me.RutinasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(105, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(70, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Image = Global.Mantenimineto.My.Resources.Resources.Restart
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton1.Text = "Salir"
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
        Me.TableAdapterManager.reportesTableAdapter = Nothing
        Me.TableAdapterManager.rutinasTableAdapter = Me.RutinasTableAdapter
        Me.TableAdapterManager.staffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.sys_funcionesTableAdapter = Nothing
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
        'Sql_rutinasBindingSource1
        '
        Me.Sql_rutinasBindingSource1.DataMember = "sql_rutinas"
        Me.Sql_rutinasBindingSource1.DataSource = Me.MantenimientoDataSet
        '
        'Sql_rutinasDataGridView
        '
        Me.Sql_rutinasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sql_rutinasDataGridView.AutoGenerateColumns = False
        Me.Sql_rutinasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Sql_rutinasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Sql_rutinasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sql_rutinasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Sql_rutinasDataGridView.DataSource = Me.Sql_rutinasBindingSource1
        Me.Sql_rutinasDataGridView.Location = New System.Drawing.Point(3, 47)
        Me.Sql_rutinasDataGridView.Name = "Sql_rutinasDataGridView"
        Me.Sql_rutinasDataGridView.RowHeadersVisible = False
        Me.Sql_rutinasDataGridView.Size = New System.Drawing.Size(882, 392)
        Me.Sql_rutinasDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "id_usuario"
        Me.DataGridViewTextBoxColumn4.HeaderText = "id_usuario"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 69
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "status"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "tarea"
        Me.DataGridViewTextBoxColumn6.HeaderText = "tarea"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 56
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "detalle"
        Me.DataGridViewTextBoxColumn7.HeaderText = "detalle"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 63
        '
        'rutinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 464)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "rutinas"
        Me.Text = "rutinas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RutinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_rutinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RutinasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RutinasBindingNavigator.ResumeLayout(False)
        Me.RutinasBindingNavigator.PerformLayout()
        CType(Me.Sql_rutinasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_rutinasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Id_usuarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TareaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DetalleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StaffTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.staffTableAdapter
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents combodia As System.Windows.Forms.ComboBox
    Friend WithEvents NombreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents combo_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Sql_rutinasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_rutinasTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.sql_rutinasTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sql_rutinasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Sql_rutinasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
