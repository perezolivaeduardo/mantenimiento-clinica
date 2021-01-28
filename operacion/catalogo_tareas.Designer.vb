<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class catalogo_tareas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(catalogo_tareas))
        Me.MantenimientoDataSet = New Mantenimineto.mantenimientoDataSet()
        Me.Sys_tareas_preventivasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sys_tareas_preventivasTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.sys_tareas_preventivasTableAdapter()
        Me.TableAdapterManager = New Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager()
        Me.Sys_tareas_preventivasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Sys_tareas_preventivasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sys_tareas_preventivasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sys_tareas_preventivasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sys_tareas_preventivasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Sys_tareas_preventivasBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'MantenimientoDataSet
        '
        Me.MantenimientoDataSet.DataSetName = "mantenimientoDataSet"
        Me.MantenimientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sys_tareas_preventivasBindingSource
        '
        Me.Sys_tareas_preventivasBindingSource.DataMember = "sys_tareas_preventivas"
        Me.Sys_tareas_preventivasBindingSource.DataSource = Me.MantenimientoDataSet
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
        Me.TableAdapterManager.reportesTableAdapter = Nothing
        Me.TableAdapterManager.rutinasTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.statusTableAdapter = Nothing
        Me.TableAdapterManager.sys_funcionesTableAdapter = Nothing
        Me.TableAdapterManager.sys_tareas_preventivasTableAdapter = Me.Sys_tareas_preventivasTableAdapter
        Me.TableAdapterManager.tareasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sys_tareas_preventivasDataGridView
        '
        Me.Sys_tareas_preventivasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sys_tareas_preventivasDataGridView.AutoGenerateColumns = False
        Me.Sys_tareas_preventivasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Sys_tareas_preventivasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Sys_tareas_preventivasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sys_tareas_preventivasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Sys_tareas_preventivasDataGridView.DataSource = Me.Sys_tareas_preventivasBindingSource
        Me.Sys_tareas_preventivasDataGridView.Location = New System.Drawing.Point(0, 42)
        Me.Sys_tareas_preventivasDataGridView.Name = "Sys_tareas_preventivasDataGridView"
        Me.Sys_tareas_preventivasDataGridView.RowHeadersVisible = False
        Me.Sys_tareas_preventivasDataGridView.Size = New System.Drawing.Size(487, 336)
        Me.Sys_tareas_preventivasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_tarea"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 43
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "area"
        Me.DataGridViewTextBoxColumn2.HeaderText = "area"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 53
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tarea"
        Me.DataGridViewTextBoxColumn3.HeaderText = "tarea"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(86, 36)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'Sys_tareas_preventivasBindingNavigator
        '
        Me.Sys_tareas_preventivasBindingNavigator.AddNewItem = Nothing
        Me.Sys_tareas_preventivasBindingNavigator.BindingSource = Me.Sys_tareas_preventivasBindingSource
        Me.Sys_tareas_preventivasBindingNavigator.CountItem = Nothing
        Me.Sys_tareas_preventivasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Sys_tareas_preventivasBindingNavigator.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.Sys_tareas_preventivasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorDeleteItem, Me.ToolStripButton1})
        Me.Sys_tareas_preventivasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Sys_tareas_preventivasBindingNavigator.MoveFirstItem = Nothing
        Me.Sys_tareas_preventivasBindingNavigator.MoveLastItem = Nothing
        Me.Sys_tareas_preventivasBindingNavigator.MoveNextItem = Nothing
        Me.Sys_tareas_preventivasBindingNavigator.MovePreviousItem = Nothing
        Me.Sys_tareas_preventivasBindingNavigator.Name = "Sys_tareas_preventivasBindingNavigator"
        Me.Sys_tareas_preventivasBindingNavigator.PositionItem = Nothing
        Me.Sys_tareas_preventivasBindingNavigator.Size = New System.Drawing.Size(487, 39)
        Me.Sys_tareas_preventivasBindingNavigator.TabIndex = 0
        Me.Sys_tareas_preventivasBindingNavigator.Text = "BindingNavigator1"
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
        'catalogo_tareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 390)
        Me.Controls.Add(Me.Sys_tareas_preventivasDataGridView)
        Me.Controls.Add(Me.Sys_tareas_preventivasBindingNavigator)
        Me.Name = "catalogo_tareas"
        Me.Text = "catalogo_tareas"
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sys_tareas_preventivasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sys_tareas_preventivasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sys_tareas_preventivasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Sys_tareas_preventivasBindingNavigator.ResumeLayout(False)
        Me.Sys_tareas_preventivasBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MantenimientoDataSet As Mantenimineto.mantenimientoDataSet
    Friend WithEvents Sys_tareas_preventivasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sys_tareas_preventivasTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.sys_tareas_preventivasTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sys_tareas_preventivasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sys_tareas_preventivasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
