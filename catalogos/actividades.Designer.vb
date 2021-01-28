<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class actividades
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
        Me.ActividadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActividadesTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.actividadesTableAdapter()
        Me.TableAdapterManager = New Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager()
        Me.ActividadesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ActividadesDataGridView = New System.Windows.Forms.DataGridView()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActividadesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActividadesBindingNavigator.SuspendLayout()
        CType(Me.ActividadesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MantenimientoDataSet
        '
        Me.MantenimientoDataSet.DataSetName = "mantenimientoDataSet"
        Me.MantenimientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActividadesBindingSource
        '
        Me.ActividadesBindingSource.DataMember = "actividades"
        Me.ActividadesBindingSource.DataSource = Me.MantenimientoDataSet
        '
        'ActividadesTableAdapter
        '
        Me.ActividadesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.actividadesTableAdapter = Me.ActividadesTableAdapter
        Me.TableAdapterManager.areasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.departamentosTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.reportesTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.tareasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ActividadesBindingNavigator
        '
        Me.ActividadesBindingNavigator.AddNewItem = Nothing
        Me.ActividadesBindingNavigator.BindingSource = Me.ActividadesBindingSource
        Me.ActividadesBindingNavigator.CountItem = Nothing
        Me.ActividadesBindingNavigator.DeleteItem = Nothing
        Me.ActividadesBindingNavigator.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ActividadesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ActividadesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ActividadesBindingNavigator.MoveFirstItem = Nothing
        Me.ActividadesBindingNavigator.MoveLastItem = Nothing
        Me.ActividadesBindingNavigator.MoveNextItem = Nothing
        Me.ActividadesBindingNavigator.MovePreviousItem = Nothing
        Me.ActividadesBindingNavigator.Name = "ActividadesBindingNavigator"
        Me.ActividadesBindingNavigator.PositionItem = Nothing
        Me.ActividadesBindingNavigator.Size = New System.Drawing.Size(367, 71)
        Me.ActividadesBindingNavigator.TabIndex = 0
        Me.ActividadesBindingNavigator.Text = "BindingNavigator1"
        '
        'ActividadesDataGridView
        '
        Me.ActividadesDataGridView.AutoGenerateColumns = False
        Me.ActividadesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ActividadesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActividadesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ActividadesDataGridView.DataSource = Me.ActividadesBindingSource
        Me.ActividadesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActividadesDataGridView.Location = New System.Drawing.Point(0, 71)
        Me.ActividadesDataGridView.Name = "ActividadesDataGridView"
        Me.ActividadesDataGridView.RowHeadersVisible = False
        Me.ActividadesDataGridView.Size = New System.Drawing.Size(367, 379)
        Me.ActividadesDataGridView.TabIndex = 1
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_actividad"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "actividad"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ACTIVIDAD"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'actividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 450)
        Me.Controls.Add(Me.ActividadesDataGridView)
        Me.Controls.Add(Me.ActividadesBindingNavigator)
        Me.Name = "actividades"
        Me.Text = "actividades"
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActividadesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActividadesBindingNavigator.ResumeLayout(False)
        Me.ActividadesBindingNavigator.PerformLayout()
        CType(Me.ActividadesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MantenimientoDataSet As Mantenimineto.mantenimientoDataSet
    Friend WithEvents ActividadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActividadesTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.actividadesTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ActividadesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ActividadesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
