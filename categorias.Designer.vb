<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CATEGORIAS
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
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriasTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.categoriasTableAdapter()
        Me.TableAdapterManager = New Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager()
        Me.CategoriasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.CategoriasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CategoriasBindingNavigator.SuspendLayout()
        CType(Me.CategoriasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MantenimientoDataSet
        '
        Me.MantenimientoDataSet.DataSetName = "mantenimientoDataSet"
        Me.MantenimientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "categorias"
        Me.CategoriasBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.actividadesTableAdapter = Nothing
        Me.TableAdapterManager.areasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.categoriasTableAdapter = Me.CategoriasTableAdapter
        Me.TableAdapterManager.departamentosTableAdapter = Nothing
        Me.TableAdapterManager.equiposTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.reportesTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.tareasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CategoriasBindingNavigator
        '
        Me.CategoriasBindingNavigator.AddNewItem = Nothing
        Me.CategoriasBindingNavigator.BindingSource = Me.CategoriasBindingSource
        Me.CategoriasBindingNavigator.CountItem = Nothing
        Me.CategoriasBindingNavigator.DeleteItem = Nothing
        Me.CategoriasBindingNavigator.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.CategoriasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.CategoriasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CategoriasBindingNavigator.MoveFirstItem = Nothing
        Me.CategoriasBindingNavigator.MoveLastItem = Nothing
        Me.CategoriasBindingNavigator.MoveNextItem = Nothing
        Me.CategoriasBindingNavigator.MovePreviousItem = Nothing
        Me.CategoriasBindingNavigator.Name = "CategoriasBindingNavigator"
        Me.CategoriasBindingNavigator.PositionItem = Nothing
        Me.CategoriasBindingNavigator.Size = New System.Drawing.Size(605, 71)
        Me.CategoriasBindingNavigator.TabIndex = 0
        Me.CategoriasBindingNavigator.Text = "BindingNavigator1"
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
        'CategoriasDataGridView
        '
        Me.CategoriasDataGridView.AllowUserToResizeColumns = False
        Me.CategoriasDataGridView.AllowUserToResizeRows = False
        Me.CategoriasDataGridView.AutoGenerateColumns = False
        Me.CategoriasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CategoriasDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CategoriasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CategoriasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.CategoriasDataGridView.DataSource = Me.CategoriasBindingSource
        Me.CategoriasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CategoriasDataGridView.Location = New System.Drawing.Point(0, 71)
        Me.CategoriasDataGridView.Name = "CategoriasDataGridView"
        Me.CategoriasDataGridView.RowHeadersVisible = False
        Me.CategoriasDataGridView.Size = New System.Drawing.Size(605, 446)
        Me.CategoriasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_categoria"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 47
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "categoria"
        Me.DataGridViewTextBoxColumn2.HeaderText = "categoria"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 94
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'CATEGORIAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 517)
        Me.Controls.Add(Me.CategoriasDataGridView)
        Me.Controls.Add(Me.CategoriasBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CATEGORIAS"
        Me.Text = "CATEGORIAS"
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CategoriasBindingNavigator.ResumeLayout(False)
        Me.CategoriasBindingNavigator.PerformLayout()
        CType(Me.CategoriasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MantenimientoDataSet As Mantenimineto.mantenimientoDataSet
    Friend WithEvents CategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriasTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.categoriasTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoriasBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CategoriasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
