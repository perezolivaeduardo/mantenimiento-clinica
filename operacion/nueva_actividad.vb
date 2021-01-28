Public Class nueva_actividad


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim adap As New mantenimientoDataSetTableAdapters.tareasTableAdapter
        adap.Insert(id_reporte.Text, fecha.Value, usuario.id, Id_actividadTextBox.Text, Text, descripcion.Text)

        boleta.mandar_seguimiento(id_reporte.Text, email_mantenimiento, descripcion.Text)

    End Sub

    Private Sub nueva_actividad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.areas' Puede moverla o quitarla según sea necesario.
        Me.ActividadesTableAdapter.Fill(Me.MantenimientoDataSet.actividades)

    End Sub
End Class