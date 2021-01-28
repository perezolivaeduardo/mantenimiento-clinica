<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista_de_Trabajo
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
        Me.sql_reportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mantenimientoDataSet = New Mantenimineto.mantenimientoDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.sql_reportesTableAdapter = New Mantenimineto.mantenimientoDataSetTableAdapters.sql_reportesTableAdapter()
        CType(Me.sql_reportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mantenimientoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sql_reportesBindingSource
        '
        Me.sql_reportesBindingSource.DataMember = "sql_reportes"
        Me.sql_reportesBindingSource.DataSource = Me.mantenimientoDataSet
        '
        'mantenimientoDataSet
        '
        Me.mantenimientoDataSet.DataSetName = "mantenimientoDataSet"
        Me.mantenimientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.sql_reportesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Mantenimineto.hojadetrabajo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(650, 431)
        Me.ReportViewer1.TabIndex = 0
        '
        'sql_reportesTableAdapter
        '
        Me.sql_reportesTableAdapter.ClearBeforeFill = True
        '
        'Lista_de_Trabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(650, 431)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Lista_de_Trabajo"
        Me.Text = "Lista de Trabajo"
        CType(Me.sql_reportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mantenimientoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sql_reportesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents mantenimientoDataSet As Mantenimineto.mantenimientoDataSet
    Friend WithEvents sql_reportesTableAdapter As Mantenimineto.mantenimientoDataSetTableAdapters.sql_reportesTableAdapter
End Class
