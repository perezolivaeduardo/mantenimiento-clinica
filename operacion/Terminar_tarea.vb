Public Class terminar_tarea


    Private Sub CERRAR_REPORTE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.reportes' Puede moverla o quitarla según sea necesario.
        Me.ReportesTableAdapter.Fill(Me.MantenimientoDataSet.reportes)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.staff' Puede moverla o quitarla según sea necesario.
        Me.StaffTableAdapter.FillByasignables(Me.MantenimientoDataSet.staff)
        StaffBindingSource.Position = StaffBindingSource.Find("id_usuario", id_atendio.Text)
    End Sub

    Private Sub BTN_CANCELAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_CANCELAR.Click
        Me.Dispose()
    End Sub

    Private Sub BTN_CERRAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_CERRAR.Click
        Dim ix As MsgBoxResult
        ix = MsgBox("Seguro que quiere dar por teminado este reporte", MsgBoxStyle.YesNo, "Terminar Tarea")
        If ix = MsgBoxResult.Yes Then
            Dim adap As New mantenimientoDataSetTableAdapters.reportesTableAdapter
            adap.VoBo(ObservacionesTextBox.Text, Id_usuarioTextBox.Text, id_servicio.Text)
            adap.cambiar_estatus(97, id_servicio.Text) 'terminar tarea

            Dim activ As New mantenimientoDataSetTableAdapters.tareasTableAdapter
            activ.Insert(id_servicio.Text, Now.Date, Id_usuarioTextBox.Text, 20, ObservacionesTextBox.Text, "registro VoBo" + usuario.nombre)
            MsgBox("Registro Actualizado")
        End If
        Me.Dispose()
    End Sub

    Private Sub id_servicio_TextChanged(sender As System.Object, e As System.EventArgs) Handles id_servicio.TextChanged

    End Sub

    Private Sub id_atendio_TextChanged(sender As System.Object, e As System.EventArgs) Handles id_atendio.TextChanged
        StaffBindingSource.Position = StaffBindingSource.Find("id_usuario", id_atendio.Text)
    End Sub
End Class