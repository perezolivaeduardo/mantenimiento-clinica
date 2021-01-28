<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class equipos
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
        Dim AreaLabel1 As System.Windows.Forms.Label
        Dim Id_categoriaLabel As System.Windows.Forms.Label
        Dim Id_equipoLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim CuartoLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim Meses_mantenimientoLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim Fecha_ult_mantenimientoLabel As System.Windows.Forms.Label
        Dim SerieLabel As System.Windows.Forms.Label
        Dim Fecha_ultima_reparacionLabel As System.Windows.Forms.Label
        Dim Fecha_compraLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim ProveedorLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(equipos))
        Dim EtiquetaLabel As System.Windows.Forms.Label
        Me.MantenimientoDataSet = New Mantenimineto.mantenimientoDataSet()
        Me.EquiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EquiposTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.equiposTableAdapter()
        Me.TableAdapterManager = New Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager()
        Me.AreasTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.areasTableAdapter()
        Me.CategoriasTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.categoriasTableAdapter()
        Me.EquiposBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EquiposBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.Sql_equiposDataGridView = New System.Windows.Forms.DataGridView()
        Me.Sql_equiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Id_categoriaTextBox = New System.Windows.Forms.TextBox()
        Me.AreaComboBox = New System.Windows.Forms.ComboBox()
        Me.Id_equipoTextBox = New System.Windows.Forms.TextBox()
        Me.CuartoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.Meses_mantenimientoTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_ult_mantenimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_ultima_reparacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SerieTextBox = New System.Windows.Forms.TextBox()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_compraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Sql_equiposTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.sql_equiposTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.etiqueta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvidequipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtiquetaTextBox = New System.Windows.Forms.TextBox()
        AreaLabel1 = New System.Windows.Forms.Label()
        Id_categoriaLabel = New System.Windows.Forms.Label()
        Id_equipoLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        CuartoLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        Meses_mantenimientoLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        Fecha_ult_mantenimientoLabel = New System.Windows.Forms.Label()
        SerieLabel = New System.Windows.Forms.Label()
        Fecha_ultima_reparacionLabel = New System.Windows.Forms.Label()
        Fecha_compraLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        ProveedorLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        EtiquetaLabel = New System.Windows.Forms.Label()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquiposBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EquiposBindingNavigator.SuspendLayout()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.Sql_equiposDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sql_equiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AreaLabel1
        '
        AreaLabel1.AutoSize = True
        AreaLabel1.Location = New System.Drawing.Point(145, 366)
        AreaLabel1.Name = "AreaLabel1"
        AreaLabel1.Size = New System.Drawing.Size(52, 20)
        AreaLabel1.TabIndex = 91
        AreaLabel1.Text = "Area:"
        '
        'Id_categoriaLabel
        '
        Id_categoriaLabel.AutoSize = True
        Id_categoriaLabel.Location = New System.Drawing.Point(108, 423)
        Id_categoriaLabel.Name = "Id_categoriaLabel"
        Id_categoriaLabel.Size = New System.Drawing.Size(89, 20)
        Id_categoriaLabel.TabIndex = 90
        Id_categoriaLabel.Text = "categoria:"
        '
        'Id_equipoLabel
        '
        Id_equipoLabel.AutoSize = True
        Id_equipoLabel.Location = New System.Drawing.Point(159, 30)
        Id_equipoLabel.Name = "Id_equipoLabel"
        Id_equipoLabel.Size = New System.Drawing.Size(38, 20)
        Id_equipoLabel.TabIndex = 63
        Id_equipoLabel.Text = "ID :"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(194, 447)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(129, 20)
        ObservacionesLabel.TabIndex = 88
        ObservacionesLabel.Text = "observaciones:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(92, 63)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(105, 20)
        DescripcionLabel.TabIndex = 65
        DescripcionLabel.Text = "descripcion:"
        '
        'CuartoLabel
        '
        CuartoLabel.AutoSize = True
        CuartoLabel.Location = New System.Drawing.Point(132, 393)
        CuartoLabel.Name = "CuartoLabel"
        CuartoLabel.Size = New System.Drawing.Size(65, 20)
        CuartoLabel.TabIndex = 86
        CuartoLabel.Text = "cuarto:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(134, 93)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(63, 20)
        MarcaLabel.TabIndex = 67
        MarcaLabel.Text = "marca:"
        '
        'Meses_mantenimientoLabel
        '
        Meses_mantenimientoLabel.AutoSize = True
        Meses_mantenimientoLabel.Location = New System.Drawing.Point(16, 333)
        Meses_mantenimientoLabel.Name = "Meses_mantenimientoLabel"
        Meses_mantenimientoLabel.Size = New System.Drawing.Size(181, 20)
        Meses_mantenimientoLabel.TabIndex = 83
        Meses_mantenimientoLabel.Text = "Mantenimiento cada :"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Location = New System.Drawing.Point(125, 123)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(72, 20)
        ModeloLabel.TabIndex = 69
        ModeloLabel.Text = "modelo:"
        '
        'Fecha_ult_mantenimientoLabel
        '
        Fecha_ult_mantenimientoLabel.AutoSize = True
        Fecha_ult_mantenimientoLabel.Location = New System.Drawing.Point(9, 304)
        Fecha_ult_mantenimientoLabel.Name = "Fecha_ult_mantenimientoLabel"
        Fecha_ult_mantenimientoLabel.Size = New System.Drawing.Size(188, 20)
        Fecha_ult_mantenimientoLabel.TabIndex = 81
        Fecha_ult_mantenimientoLabel.Text = "Ultimo mantenimiento:"
        '
        'SerieLabel
        '
        SerieLabel.AutoSize = True
        SerieLabel.Location = New System.Drawing.Point(144, 153)
        SerieLabel.Name = "SerieLabel"
        SerieLabel.Size = New System.Drawing.Size(53, 20)
        SerieLabel.TabIndex = 71
        SerieLabel.Text = "serie:"
        '
        'Fecha_ultima_reparacionLabel
        '
        Fecha_ultima_reparacionLabel.AutoSize = True
        Fecha_ultima_reparacionLabel.Location = New System.Drawing.Point(42, 274)
        Fecha_ultima_reparacionLabel.Name = "Fecha_ultima_reparacionLabel"
        Fecha_ultima_reparacionLabel.Size = New System.Drawing.Size(155, 20)
        Fecha_ultima_reparacionLabel.TabIndex = 79
        Fecha_ultima_reparacionLabel.Text = "Ultima reparacion:"
        '
        'Fecha_compraLabel
        '
        Fecha_compraLabel.AutoSize = True
        Fecha_compraLabel.Location = New System.Drawing.Point(74, 184)
        Fecha_compraLabel.Name = "Fecha_compraLabel"
        Fecha_compraLabel.Size = New System.Drawing.Size(123, 20)
        Fecha_compraLabel.TabIndex = 73
        Fecha_compraLabel.Text = "fecha compra:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Location = New System.Drawing.Point(145, 243)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(52, 20)
        ValorLabel.TabIndex = 77
        ValorLabel.Text = "valor:"
        '
        'ProveedorLabel
        '
        ProveedorLabel.AutoSize = True
        ProveedorLabel.Location = New System.Drawing.Point(103, 213)
        ProveedorLabel.Name = "ProveedorLabel"
        ProveedorLabel.Size = New System.Drawing.Size(94, 20)
        ProveedorLabel.TabIndex = 75
        ProveedorLabel.Text = "proveedor:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(266, 333)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(66, 20)
        Label3.TabIndex = 95
        Label3.Text = "Meses."
        '
        'MantenimientoDataSet
        '
        Me.MantenimientoDataSet.DataSetName = "mantenimientoDataSet"
        Me.MantenimientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EquiposBindingSource
        '
        Me.EquiposBindingSource.DataMember = "equipos"
        Me.EquiposBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'EquiposTableAdapter
        '
        Me.EquiposTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.actividadesTableAdapter = Nothing
        Me.TableAdapterManager.areasTableAdapter = Me.AreasTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriasTableAdapter = Me.CategoriasTableAdapter
        Me.TableAdapterManager.departamentosTableAdapter = Nothing
        Me.TableAdapterManager.equipos_redTableAdapter = Nothing
        Me.TableAdapterManager.equiposTableAdapter = Me.EquiposTableAdapter
        Me.TableAdapterManager.fotosTableAdapter = Nothing
        Me.TableAdapterManager.inv_documentosTableAdapter = Nothing
        Me.TableAdapterManager.inv_movimintosTableAdapter = Nothing
        Me.TableAdapterManager.inv_productosTableAdapter = Nothing
        Me.TableAdapterManager.permisosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.reportes_tareasTableAdapter = Nothing
        Me.TableAdapterManager.reportesTableAdapter = Nothing
        Me.TableAdapterManager.rutinasTableAdapter = Nothing
        Me.TableAdapterManager.sql_fotosTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.sys_funcionesTableAdapter = Nothing
        Me.TableAdapterManager.sys_tareas_preventivasTableAdapter = Nothing
        Me.TableAdapterManager.tareasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AreasTableAdapter
        '
        Me.AreasTableAdapter.ClearBeforeFill = True
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'EquiposBindingNavigator
        '
        Me.EquiposBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EquiposBindingNavigator.BindingSource = Me.EquiposBindingSource
        Me.EquiposBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EquiposBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EquiposBindingNavigator.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.EquiposBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EquiposBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.EquiposBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EquiposBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EquiposBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EquiposBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EquiposBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EquiposBindingNavigator.Name = "EquiposBindingNavigator"
        Me.EquiposBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EquiposBindingNavigator.Size = New System.Drawing.Size(1252, 39)
        Me.EquiposBindingNavigator.TabIndex = 30
        Me.EquiposBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 36)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 39)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'EquiposBindingNavigatorSaveItem
        '
        Me.EquiposBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EquiposBindingNavigatorSaveItem.Image = CType(resources.GetObject("EquiposBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EquiposBindingNavigatorSaveItem.Name = "EquiposBindingNavigatorSaveItem"
        Me.EquiposBindingNavigatorSaveItem.Size = New System.Drawing.Size(36, 36)
        Me.EquiposBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Mantenimineto.My.Resources.Resources.Restart
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'AreasBindingSource
        '
        Me.AreasBindingSource.DataMember = "areas"
        Me.AreasBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "categorias"
        Me.CategoriasBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 39)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1252, 689)
        Me.SplitContainer1.SplitterDistance = 612
        Me.SplitContainer1.TabIndex = 62
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtfiltro)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Sql_equiposDataGridView)
        Me.SplitContainer2.Size = New System.Drawing.Size(612, 689)
        Me.SplitContainer2.SplitterDistance = 62
        Me.SplitContainer2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar :"
        '
        'txtfiltro
        '
        Me.txtfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfiltro.Location = New System.Drawing.Point(94, 8)
        Me.txtfiltro.MaxLength = 30
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(437, 27)
        Me.txtfiltro.TabIndex = 0
        '
        'Sql_equiposDataGridView
        '
        Me.Sql_equiposDataGridView.AllowUserToAddRows = False
        Me.Sql_equiposDataGridView.AllowUserToDeleteRows = False
        Me.Sql_equiposDataGridView.AllowUserToResizeColumns = False
        Me.Sql_equiposDataGridView.AllowUserToResizeRows = False
        Me.Sql_equiposDataGridView.AutoGenerateColumns = False
        Me.Sql_equiposDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Sql_equiposDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Sql_equiposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sql_equiposDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.etiqueta, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.dgvidequipo, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.Sql_equiposDataGridView.DataSource = Me.Sql_equiposBindingSource
        Me.Sql_equiposDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sql_equiposDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Sql_equiposDataGridView.Name = "Sql_equiposDataGridView"
        Me.Sql_equiposDataGridView.ReadOnly = True
        Me.Sql_equiposDataGridView.RowHeadersVisible = False
        Me.Sql_equiposDataGridView.Size = New System.Drawing.Size(612, 623)
        Me.Sql_equiposDataGridView.TabIndex = 0
        '
        'Sql_equiposBindingSource
        '
        Me.Sql_equiposBindingSource.DataMember = "sql_equipos"
        Me.Sql_equiposBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(636, 664)
        Me.TabControl1.TabIndex = 63
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(EtiquetaLabel)
        Me.TabPage1.Controls.Add(Me.EtiquetaTextBox)
        Me.TabPage1.Controls.Add(Label3)
        Me.TabPage1.Controls.Add(Me.ObservacionesTextBox)
        Me.TabPage1.Controls.Add(Me.CategoriaComboBox)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(AreaLabel1)
        Me.TabPage1.Controls.Add(Me.Id_categoriaTextBox)
        Me.TabPage1.Controls.Add(Me.AreaComboBox)
        Me.TabPage1.Controls.Add(Id_categoriaLabel)
        Me.TabPage1.Controls.Add(Id_equipoLabel)
        Me.TabPage1.Controls.Add(ObservacionesLabel)
        Me.TabPage1.Controls.Add(Me.Id_equipoTextBox)
        Me.TabPage1.Controls.Add(Me.CuartoTextBox)
        Me.TabPage1.Controls.Add(DescripcionLabel)
        Me.TabPage1.Controls.Add(CuartoLabel)
        Me.TabPage1.Controls.Add(Me.DescripcionTextBox)
        Me.TabPage1.Controls.Add(Me.AreaTextBox)
        Me.TabPage1.Controls.Add(MarcaLabel)
        Me.TabPage1.Controls.Add(Me.Meses_mantenimientoTextBox)
        Me.TabPage1.Controls.Add(Me.MarcaTextBox)
        Me.TabPage1.Controls.Add(Meses_mantenimientoLabel)
        Me.TabPage1.Controls.Add(ModeloLabel)
        Me.TabPage1.Controls.Add(Me.Fecha_ult_mantenimientoDateTimePicker)
        Me.TabPage1.Controls.Add(Me.ModeloTextBox)
        Me.TabPage1.Controls.Add(Fecha_ult_mantenimientoLabel)
        Me.TabPage1.Controls.Add(SerieLabel)
        Me.TabPage1.Controls.Add(Me.Fecha_ultima_reparacionDateTimePicker)
        Me.TabPage1.Controls.Add(Me.SerieTextBox)
        Me.TabPage1.Controls.Add(Fecha_ultima_reparacionLabel)
        Me.TabPage1.Controls.Add(Fecha_compraLabel)
        Me.TabPage1.Controls.Add(Me.ValorTextBox)
        Me.TabPage1.Controls.Add(Me.Fecha_compraDateTimePicker)
        Me.TabPage1.Controls.Add(ValorLabel)
        Me.TabPage1.Controls.Add(ProveedorLabel)
        Me.TabPage1.Controls.Add(Me.ProveedorTextBox)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(628, 631)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Generales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquiposBindingSource, "observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(190, 468)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(400, 133)
        Me.ObservacionesTextBox.TabIndex = 89
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EquiposBindingSource, "id_categoria", True))
        Me.CategoriaComboBox.DataSource = Me.CategoriasBindingSource
        Me.CategoriaComboBox.DisplayMember = "categoria"
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Location = New System.Drawing.Point(266, 418)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(330, 28)
        Me.CategoriaComboBox.TabIndex = 94
        Me.CategoriaComboBox.ValueMember = "id_categoria"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Mantenimineto.My.Resources.Resources.equipos
        Me.PictureBox1.Location = New System.Drawing.Point(26, 477)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'Id_categoriaTextBox
        '
        Me.Id_categoriaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquiposBindingSource, "id_categoria", True))
        Me.Id_categoriaTextBox.Location = New System.Drawing.Point(203, 420)
        Me.Id_categoriaTextBox.Name = "Id_categoriaTextBox"
        Me.Id_categoriaTextBox.ReadOnly = True
        Me.Id_categoriaTextBox.Size = New System.Drawing.Size(57, 26)
        Me.Id_categoriaTextBox.TabIndex = 92
        '
        'AreaComboBox
        '
        Me.AreaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EquiposBindingSource, "area", True))
        Me.AreaComboBox.DataSource = Me.AreasBindingSource
        Me.AreaComboBox.DisplayMember = "Area"
        Me.AreaComboBox.FormattingEnabled = True
        Me.AreaComboBox.Location = New System.Drawing.Point(266, 363)
        Me.AreaComboBox.Name = "AreaComboBox"
        Me.AreaComboBox.Size = New System.Drawing.Size(330, 28)
        Me.AreaComboBox.TabIndex = 93
        Me.AreaComboBox.ValueMember = "id_area"
        '
        'Id_equipoTextBox
        '
        Me.Id_equipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquiposBindingSource, "id_equipo", True))
        Me.Id_equipoTextBox.Location = New System.Drawing.Point(203, 28)
        Me.Id_equipoTextBox.Name = "Id_equipoTextBox"
        Me.Id_equipoTextBox.Size = New System.Drawing.Size(57, 26)
        Me.Id_equipoTextBox.TabIndex = 64
        '
        'CuartoTextBox
        '
        Me.CuartoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquiposBindingSource, "cuarto", True))
        Me.CuartoTextBox.Location = New System.Drawing.Point(203, 390)
        Me.CuartoTextBox.Name = "CuartoTextBox"
        Me.CuartoTextBox.Size = New System.Drawing.Size(57, 26)
        Me.CuartoTextBox.TabIndex = 87
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquiposBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(203, 60)
        Me.DescripcionTextBox.MaxLength = 50
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(400, 26)
        Me.DescripcionTextBox.TabIndex = 66
        '
        'AreaTextBox
        '
        Me.AreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquiposBindingSource, "area", True))
        Me.AreaTextBox.Location = New System.Drawing.Point(203, 360)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.ReadOnly = True
        Me.AreaTextBox.Size = New System.Drawing.Size(57, 26)
        Me.AreaTextBox.TabIndex = 85
        '
        'Meses_mantenimientoTextBox
        '
        Me.Meses_mantenimientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquiposBindingSource, "meses_mantenimiento", True))
        Me.Meses_mantenimientoTextBox.Location = New System.Drawing.Point(203, 330)
        Me.Meses_mantenimientoTextBox.MaxLength = 2
        Me.Meses_mantenimientoTextBox.Name = "Meses_mantenimientoTextBox"
        Me.Meses_mantenimientoTextBox.Size = New System.Drawing.Size(57, 26)
        Me.Meses_mantenimientoTextBox.TabIndex = 84
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquiposBindingSource, "marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(203, 90)
        Me.MarcaTextBox.MaxLength = 20
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(400, 26)
        Me.MarcaTextBox.TabIndex = 68
        '
        'Fecha_ult_mantenimientoDateTimePicker
        '
        Me.Fecha_ult_mantenimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EquiposBindingSource, "fecha_ult_mantenimiento", True))
        Me.Fecha_ult_mantenimientoDateTimePicker.Location = New System.Drawing.Point(203, 300)
        Me.Fecha_ult_mantenimientoDateTimePicker.Name = "Fecha_ult_mantenimientoDateTimePicker"
        Me.Fecha_ult_mantenimientoDateTimePicker.Size = New System.Drawing.Size(400, 26)
        Me.Fecha_ult_mantenimientoDateTimePicker.TabIndex = 82
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquiposBindingSource, "modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(203, 120)
        Me.ModeloTextBox.MaxLength = 30
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ModeloTextBox.TabIndex = 70
        '
        'Fecha_ultima_reparacionDateTimePicker
        '
        Me.Fecha_ultima_reparacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EquiposBindingSource, "fecha_ultima_reparacion", True))
        Me.Fecha_ultima_reparacionDateTimePicker.Location = New System.Drawing.Point(203, 270)
        Me.Fecha_ultima_reparacionDateTimePicker.Name = "Fecha_ultima_reparacionDateTimePicker"
        Me.Fecha_ultima_reparacionDateTimePicker.Size = New System.Drawing.Size(400, 26)
        Me.Fecha_ultima_reparacionDateTimePicker.TabIndex = 80
        '
        'SerieTextBox
        '
        Me.SerieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquiposBindingSource, "serie", True))
        Me.SerieTextBox.Location = New System.Drawing.Point(203, 150)
        Me.SerieTextBox.MaxLength = 20
        Me.SerieTextBox.Name = "SerieTextBox"
        Me.SerieTextBox.Size = New System.Drawing.Size(200, 26)
        Me.SerieTextBox.TabIndex = 72
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquiposBindingSource, "valor", True))
        Me.ValorTextBox.Location = New System.Drawing.Point(203, 240)
        Me.ValorTextBox.MaxLength = 10
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ValorTextBox.TabIndex = 78
        '
        'Fecha_compraDateTimePicker
        '
        Me.Fecha_compraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EquiposBindingSource, "fecha_compra", True))
        Me.Fecha_compraDateTimePicker.Location = New System.Drawing.Point(203, 180)
        Me.Fecha_compraDateTimePicker.Name = "Fecha_compraDateTimePicker"
        Me.Fecha_compraDateTimePicker.Size = New System.Drawing.Size(400, 26)
        Me.Fecha_compraDateTimePicker.TabIndex = 74
        '
        'ProveedorTextBox
        '
        Me.ProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquiposBindingSource, "proveedor", True))
        Me.ProveedorTextBox.Location = New System.Drawing.Point(203, 210)
        Me.ProveedorTextBox.Name = "ProveedorTextBox"
        Me.ProveedorTextBox.Size = New System.Drawing.Size(400, 26)
        Me.ProveedorTextBox.TabIndex = 76
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(628, 631)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimientos y Servicios"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(636, 25)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "FICHA DEL EQUIPO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sql_equiposTableAdapter
        '
        Me.Sql_equiposTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_categoria"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 28
        '
        'etiqueta
        '
        Me.etiqueta.DataPropertyName = "etiqueta"
        Me.etiqueta.HeaderText = "etiqueta"
        Me.etiqueta.Name = "etiqueta"
        Me.etiqueta.ReadOnly = True
        Me.etiqueta.Width = 84
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "categoria"
        Me.DataGridViewTextBoxColumn2.HeaderText = "categoria"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 94
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id_area"
        Me.DataGridViewTextBoxColumn3.HeaderText = "id_area"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 81
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Area"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Area"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 63
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cuarto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "cuarto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'dgvidequipo
        '
        Me.dgvidequipo.DataPropertyName = "id_equipo"
        Me.dgvidequipo.HeaderText = "ID"
        Me.dgvidequipo.Name = "dgvidequipo"
        Me.dgvidequipo.ReadOnly = True
        Me.dgvidequipo.Width = 47
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 109
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn8.HeaderText = "marca"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 75
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "modelo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "modelo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 83
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "serie"
        Me.DataGridViewTextBoxColumn10.HeaderText = "serie"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 65
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "fecha_compra"
        Me.DataGridViewTextBoxColumn11.HeaderText = "fecha_compra"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 128
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "proveedor"
        Me.DataGridViewTextBoxColumn12.HeaderText = "proveedor"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "valor"
        Me.DataGridViewTextBoxColumn13.HeaderText = "valor"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 65
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "fecha_ultima_reparacion"
        Me.DataGridViewTextBoxColumn14.HeaderText = "fecha_ultima_reparacion"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 194
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "fecha_ult_mantenimiento"
        Me.DataGridViewTextBoxColumn15.HeaderText = "fecha_ult_mantenimiento"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 197
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "meses_mantenimiento"
        Me.DataGridViewTextBoxColumn16.HeaderText = "meses_mantenimiento"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 183
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "observaciones"
        Me.DataGridViewTextBoxColumn17.HeaderText = "observaciones"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 130
        '
        'EtiquetaLabel
        '
        EtiquetaLabel.AutoSize = True
        EtiquetaLabel.Location = New System.Drawing.Point(266, 30)
        EtiquetaLabel.Name = "EtiquetaLabel"
        EtiquetaLabel.Size = New System.Drawing.Size(82, 20)
        EtiquetaLabel.TabIndex = 95
        EtiquetaLabel.Text = "Etiqueta:"
        '
        'EtiquetaTextBox
        '
        Me.EtiquetaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EquiposBindingSource, "etiqueta", True))
        Me.EtiquetaTextBox.Location = New System.Drawing.Point(352, 27)
        Me.EtiquetaTextBox.Name = "EtiquetaTextBox"
        Me.EtiquetaTextBox.Size = New System.Drawing.Size(251, 26)
        Me.EtiquetaTextBox.TabIndex = 96
        '
        'equipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1252, 728)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.EquiposBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "equipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INVENTARIO DE EQUIPOS"
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquiposBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EquiposBindingNavigator.ResumeLayout(False)
        Me.EquiposBindingNavigator.PerformLayout()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.Sql_equiposDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sql_equiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MantenimientoDataSet As Mantenimineto.mantenimientoDataSet
    Friend WithEvents EquiposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EquiposTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.equiposTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EquiposBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EquiposBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents AreasTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.areasTableAdapter
    Friend WithEvents AreasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriasTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.categoriasTableAdapter
    Friend WithEvents CategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Sql_equiposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sql_equiposTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.sql_equiposTableAdapter
    Friend WithEvents Sql_equiposDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ObservacionesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoriaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Id_categoriaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AreaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Id_equipoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CuartoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AreaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Meses_mantenimientoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_ult_mantenimientoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ModeloTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_ultima_reparacionDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SerieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ValorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_compraDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProveedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents etiqueta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvidequipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EtiquetaTextBox As System.Windows.Forms.TextBox
End Class
