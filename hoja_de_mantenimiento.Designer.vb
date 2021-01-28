<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hoja_de_mantenimiento
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mantenimientoDataSet = New Mantenimineto.mantenimientoDataSet()
        Me.sys_tareas_preventivasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sys_tareas_preventivasTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.sys_tareas_preventivasTableAdapter()
        CType(Me.mantenimientoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sys_tareas_preventivasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.sys_tareas_preventivasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Mantenimineto.orden_de_trabajo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 21)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(548, 563)
        Me.ReportViewer1.TabIndex = 0
        '
        'mantenimientoDataSet
        '
        Me.mantenimientoDataSet.DataSetName = "mantenimientoDataSet"
        Me.mantenimientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sys_tareas_preventivasBindingSource
        '
        Me.sys_tareas_preventivasBindingSource.DataMember = "sys_tareas_preventivas"
        Me.sys_tareas_preventivasBindingSource.DataSource = Me.mantenimientoDataSet
        '
        'sys_tareas_preventivasTableAdapter
        '
        Me.sys_tareas_preventivasTableAdapter.ClearBeforeFill = True
        '
        'hoja_de_mantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 596)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "hoja_de_mantenimiento"
        Me.Text = "hoja_de_mantenimiento"
        CType(Me.mantenimientoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sys_tareas_preventivasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sys_tareas_preventivasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents mantenimientoDataSet As Mantenimineto.mantenimientoDataSet
    Friend WithEvents sys_tareas_preventivasTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.sys_tareas_preventivasTableAdapter
End Class
