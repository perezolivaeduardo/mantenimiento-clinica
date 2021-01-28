Public Class CERRAR_REPORTE
    Private Sub StaffBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)
    End Sub

    Private Sub CERRAR_REPORTE_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.reportes' Puede moverla o quitarla según sea necesario.
        Me.ReportesTableAdapter.Fill(Me.MantenimientoDataSet.reportes)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.staff' Puede moverla o quitarla según sea necesario.
        Me.StaffTableAdapter.Fill(Me.MantenimientoDataSet.staff)
    End Sub

    Private Sub BTN_CANCELAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_CANCELAR.Click
        Me.Dispose()
    End Sub

    Private Sub BTN_CERRAR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_CERRAR.Click
        Dim ix As MsgBoxResult
        ix = MsgBox("Seguro que quiere darle el VoBo a este reporte", MsgBoxStyle.YesNo, "VoBo")
        If ix = MsgBoxResult.Yes Then
            Dim adap As New mantenimientoDataSetTableAdapters.reportesTableAdapter
            adap.VoBo(ObservacionesTextBox.Text, Id_usuarioTextBox.Text, id_servicio.Text)
            adap.cambiar_estatus(98, id_servicio.Text)

            Dim activ As New mantenimientoDataSetTableAdapters.tareasTableAdapter
            activ.Insert(id_servicio.Text, Now.Date, Id_usuarioTextBox.Text, 20, ObservacionesTextBox.Text, "registro VoBo" + usuario.nombre)
            MsgBox("Registro Actualizado")
        End If
    End Sub
End Class