<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Departamentos
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
        Me.MantenimientoDataSet = New Mantenimineto.mantenimientoDataSet()
        Me.DepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartamentosTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.departamentosTableAdapter()
        Me.TableAdapterManager = New Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager()
        Me.StaffTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.staffTableAdapter()
        Me.DepartamentosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.DepartamentosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartamentosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DepartamentosBindingNavigator.SuspendLayout()
        CType(Me.DepartamentosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MantenimientoDataSet
        '
        Me.MantenimientoDataSet.DataSetName = "mantenimientoDataSet"
        Me.MantenimientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DepartamentosBindingSource
        '
        Me.DepartamentosBindingSource.DataMember = "departamentos"
        Me.DepartamentosBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'DepartamentosTableAdapter
        '
        Me.DepartamentosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.actividadesTableAdapter = Nothing
        Me.TableAdapterManager.areasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.departamentosTableAdapter = Me.DepartamentosTableAdapter
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.reportesTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.tareasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'DepartamentosBindingNavigator
        '
        Me.DepartamentosBindingNavigator.AddNewItem = Nothing
        Me.DepartamentosBindingNavigator.BindingSource = Me.DepartamentosBindingSource
        Me.DepartamentosBindingNavigator.CountItem = Nothing
        Me.DepartamentosBindingNavigator.DeleteItem = Nothing
        Me.DepartamentosBindingNavigator.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.DepartamentosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.DepartamentosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DepartamentosBindingNavigator.MoveFirstItem = Nothing
        Me.DepartamentosBindingNavigator.MoveLastItem = Nothing
        Me.DepartamentosBindingNavigator.MoveNextItem = Nothing
        Me.DepartamentosBindingNavigator.MovePreviousItem = Nothing
        Me.DepartamentosBindingNavigator.Name = "DepartamentosBindingNavigator"
        Me.DepartamentosBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.DepartamentosBindingNavigator.PositionItem = Nothing
        Me.DepartamentosBindingNavigator.Size = New System.Drawing.Size(456, 71)
        Me.DepartamentosBindingNavigator.TabIndex = 0
        Me.DepartamentosBindingNavigator.Text = "BindingNavigator1"
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
        'DepartamentosDataGridView
        '
        Me.DepartamentosDataGridView.AllowUserToDeleteRows = False
        Me.DepartamentosDataGridView.AllowUserToResizeColumns = False
        Me.DepartamentosDataGridView.AllowUserToResizeRows = False
        Me.DepartamentosDataGridView.AutoGenerateColumns = False
        Me.DepartamentosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DepartamentosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.DepartamentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DepartamentosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DepartamentosDataGridView.DataSource = Me.DepartamentosBindingSource
        Me.DepartamentosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DepartamentosDataGridView.Location = New System.Drawing.Point(0, 71)
        Me.DepartamentosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.DepartamentosDataGridView.Name = "DepartamentosDataGridView"
        Me.DepartamentosDataGridView.RowHeadersVisible = False
        Me.DepartamentosDataGridView.Size = New System.Drawing.Size(456, 400)
        Me.DepartamentosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_depto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 47
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Departamento"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Departamento"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 127
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id_usuario"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.StaffBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "id Responsable"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "id_usuario"
        Me.DataGridViewTextBoxColumn3.Width = 123
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "staff"
        Me.StaffBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'Departamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 471)
        Me.Controls.Add(Me.DepartamentosDataGridView)
        Me.Controls.Add(Me.DepartamentosBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Departamentos"
        Me.Text = "Departamentos"
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartamentosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DepartamentosBindingNavigator.ResumeLayout(False)
        Me.DepartamentosBindingNavigator.PerformLayout()
        CType(Me.DepartamentosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MantenimientoDataSet As Mantenimineto.mantenimientoDataSet
    Friend WithEvents DepartamentosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartamentosTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.departamentosTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DepartamentosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents DepartamentosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents StaffTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.staffTableAdapter
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
