Public Class catalogo_tareas

    

    Private Sub catalogo_tareas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.sys_tareas_preventivas' Puede moverla o quitarla según sea necesario.
        Me.Sys_tareas_preventivasTableAdapter.Fill(Me.MantenimientoDataSet.sys_tareas_preventivas)

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.Sys_tareas_preventivasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)
        Me.Dispose()
    End Sub
End Class