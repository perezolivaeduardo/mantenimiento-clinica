Public Class solicitar_mantenimiento_preventivo

    Private Sub Sys_tareas_preventivasBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.Sys_tareas_preventivasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)

    End Sub

    Private Sub solicitar_mantenimiento_preventivo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.staff' Puede moverla o quitarla según sea necesario.
        Me.StaffTableAdapter.FillBymantenimiento(Me.MantenimientoDataSet.staff)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.sys_tareas_preventivas' Puede moverla o quitarla según sea necesario.
        Me.Sys_tareas_preventivasTableAdapter.Fill(Me.MantenimientoDataSet.sys_tareas_preventivas)
        For j = 0 To Sys_tareas_preventivasDataGridView.RowCount - 2
            Sys_tareas_preventivasDataGridView.Rows(j).Cells("incluir").Value = True
        Next



    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim ix As MsgBoxResult, msg, msgtitulo As String
        msg = "Seguro que quiere programar Mantenimiento "
        msgtitulo = "Programar Mantenimiento"
        ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
        If ix = MsgBoxResult.No Then Exit Sub



        guardar_registro()
    End Sub

    Private Sub guardar_registro()

        'registra el reporte
        '===================================
        Dim adapRep As New mantenimientoDataSetTableAdapters.reportesTableAdapter
        Dim nservicio As Integer = adapRep.siguiente_reporte
        Dim fecha_null As New Nullable(Of Date)
        fecha_null = Now.Date
        adapRep.Insert(nservicio, "", 1, usuario.id, usuario.nombre, Now.Date, usuario.id, Now.Date, 0, "Cuarto", txttarea.Text, "P", fecha_asignada.Value.ToShortDateString, txtcuarto.Text, fecha_null, _
                       txtcomentarios.Text, 0, 0, 0, 0, fecha_null, 2, "", 0)

        'Guarda la tarea
        '================================
        Dim adapTarea As New mantenimientoDataSetTableAdapters.reportes_tareasTableAdapter
        For j = 0 To Sys_tareas_preventivasDataGridView.Rows.Count - 1
            With Sys_tareas_preventivasDataGridView.Rows(j)
                Dim id As Integer, tarea As String
                id = .Cells(0).Value
                tarea = .Cells(2).Value
                If .Cells(3).Value = True Then
                    adapTarea.Insert(nservicio, id, tarea, False, "")
                End If
            End With
        Next

        Me.Dispose()


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class