Public Class Reportes_abiertos

    Private Sub Reportes_abiertos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Public Sub cargar(ByVal depto As Integer)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.sql_reportes' Puede moverla o quitarla según sea necesario.
        Me.Sql_reportesTableAdapter.FillBydepto(Me.MantenimientoDataSet.sql_reportes, depto)

    End Sub

End Class