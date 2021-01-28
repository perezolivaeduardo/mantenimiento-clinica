<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nueva_actividad
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
        Dim ActividadLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.MantenimientoDataSet = New Mantenimineto.mantenimientoDataSet()
        Me.ActividadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActividadesTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.actividadesTableAdapter()
        Me.TableAdapterManager = New Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager()
        Me.ActividadComboBox = New System.Windows.Forms.ComboBox()
        Me.Id_actividadTextBox = New System.Windows.Forms.TextBox()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.id_reporte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        ActividadLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ActividadLabel
        '
        ActividadLabel.AutoSize = True
        ActividadLabel.Location = New System.Drawing.Point(26, 47)
        ActividadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ActividadLabel.Name = "ActividadLabel"
        ActividadLabel.Size = New System.Drawing.Size(70, 18)
        ActividadLabel.TabIndex = 1
        ActividadLabel.Text = "Actividad:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(39, 86)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(57, 18)
        Label2.TabIndex = 10
        Label2.Text = "Fecha :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(2, 113)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(94, 18)
        Label3.TabIndex = 11
        Label3.Text = "Comentario :"
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
        Me.TableAdapterManager.categoriasTableAdapter = Nothing
        Me.TableAdapterManager.departamentosTableAdapter = Nothing
        Me.TableAdapterManager.equiposTableAdapter = Nothing
        Me.TableAdapterManager.proveedoresTableAdapter = Nothing
        Me.TableAdapterManager.reportesTableAdapter = Nothing
        Me.TableAdapterManager.staffTableAdapter = Nothing
        Me.TableAdapterManager.tareasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ActividadComboBox
        '
        Me.ActividadComboBox.DataSource = Me.ActividadesBindingSource
        Me.ActividadComboBox.DisplayMember = "actividad"
        Me.ActividadComboBox.FormattingEnabled = True
        Me.ActividadComboBox.Location = New System.Drawing.Point(103, 47)
        Me.ActividadComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ActividadComboBox.Name = "ActividadComboBox"
        Me.ActividadComboBox.Size = New System.Drawing.Size(331, 26)
        Me.ActividadComboBox.TabIndex = 2
        Me.ActividadComboBox.ValueMember = "id_actividad"
        '
        'Id_actividadTextBox
        '
        Me.Id_actividadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ActividadesBindingSource, "id_actividad", True))
        Me.Id_actividadTextBox.Location = New System.Drawing.Point(149, 134)
        Me.Id_actividadTextBox.Name = "Id_actividadTextBox"
        Me.Id_actividadTextBox.Size = New System.Drawing.Size(41, 24)
        Me.Id_actividadTextBox.TabIndex = 3
        '
        'descripcion
        '
        Me.descripcion.Location = New System.Drawing.Point(103, 110)
        Me.descripcion.Multiline = True
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(331, 106)
        Me.descripcion.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(289, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(370, 252)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'id_reporte
        '
        Me.id_reporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.id_reporte.Location = New System.Drawing.Point(402, 12)
        Me.id_reporte.Name = "id_reporte"
        Me.id_reporte.Size = New System.Drawing.Size(50, 24)
        Me.id_reporte.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(323, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Reporte #"
        '
        'fecha
        '
        Me.fecha.Location = New System.Drawing.Point(103, 80)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(200, 24)
        Me.fecha.TabIndex = 9
        '
        'nueva_actividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(464, 296)
        Me.ControlBox = False
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.id_reporte)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(ActividadLabel)
        Me.Controls.Add(Me.ActividadComboBox)
        Me.Controls.Add(Me.Id_actividadTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "nueva_actividad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar una Actividad"
        CType(Me.MantenimientoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActividadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MantenimientoDataSet As Mantenimineto.mantenimientoDataSet
    Friend WithEvents ActividadesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActividadesTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.actividadesTableAdapter
    Friend WithEvents TableAdapterManager As Mantenimineto.mantenimientoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ActividadComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Id_actividadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents id_reporte As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fecha As System.Windows.Forms.DateTimePicker
End Class
