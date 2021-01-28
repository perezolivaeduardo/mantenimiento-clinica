Public Class listado_de_tareas

    Private Sub listado_de_tareas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.sql_tareas' Puede moverla o quitarla según sea necesario.
        Me.Sql_tareasTableAdapter.FillBybitacora(Me.MantenimientoDataSet.sql_tareas)

    End Sub
End Class