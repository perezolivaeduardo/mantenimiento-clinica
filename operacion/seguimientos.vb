Imports Microsoft.Win32
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class seguimientos
    Dim se_cargo_todo As Boolean = False
    Private Sub seuimientos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.inv_productos' Puede moverla o quitarla según sea necesario.
        Me.Inv_productosTableAdapter.Fill(Me.MantenimientoDataSet.inv_productos)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.inv_movimintos' Puede moverla o quitarla según sea necesario.
        Me.Inv_movimintosTableAdapter.Fill(Me.MantenimientoDataSet.inv_movimintos)
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Me.Sql_reportesTableAdapter.FillBytodos_los_pendientes(Me.MantenimientoDataSet.sql_reportes)

        Me.Sql_tareasTableAdapter.Fill(Me.MantenimientoDataSet.sql_tareas)
        btn_terminar.Enabled = tiene_permiso(usuario.id, funciones.CerrarReporte)
        btn_VoBo.Enabled = tiene_permiso(usuario.id, funciones.VoBo)
        btn_nueva_actividad.Enabled = tiene_permiso(usuario.id, funciones.RegistrarActividades)
        Dim f As String
        f = "grupo = 0"
        Sql_reportesBindingSource.Filter = f
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles btn_nueva_actividad.Click
        My.Forms.nueva_actividad.id_reporte.Text = Id_servicioTextBox.Text
        My.Forms.nueva_actividad.ShowDialog()
        Me.Sql_tareasTableAdapter.Fill(Me.MantenimientoDataSet.sql_tareas)
    End Sub

    Private Sub MandarPorCorreoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MandarPorCorreoToolStripMenuItem.Click
        Dim email As String
        Dim frmdetinatario As New Dialogo_destinatario
        frmdetinatario.ShowDialog()
        If frmdetinatario.DialogResult = Windows.Forms.DialogResult.OK Then
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            email = frmdetinatario.email
            If email.Length > 5 Then
                My.Forms.boleta.mandar_boleta(Id_servicioTextBox.Text, email)
            End If
            Windows.Forms.Cursor.Current = Cursors.Default
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btn_VoBo.Click
        If Id_statusTextBox.Text <> 97 Then
            MsgBox("La tarea no esta como terminada")
            Exit Sub
        End If
        My.Forms.CERRAR_REPORTE.id_servicio.Text = Id_servicioTextBox.Text
        My.Forms.CERRAR_REPORTE.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btn_terminar.Click
        If tiene_permiso(usuario.id, funciones.CerrarReporte) = True Then
            My.Forms.terminar_tarea.id_servicio.Text = Id_servicioTextBox.Text
            My.Forms.terminar_tarea.id_atendio.Text = Id_atendioTextBox.Text
            My.Forms.terminar_tarea.ShowDialog()
        Else
            MsgBox("No tiene permiso para terminar reportes")
        End If

    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Me.Cursor = Cursors.WaitCursor
        If se_cargo_todo = False Then
            Sql_reportesBindingSource.Filter = "grupo = 1"
            Me.Sql_reportesTableAdapter.Fill(Me.MantenimientoDataSet.sql_reportes)
            se_cargo_todo = True
        End If
        Dim f As String
        f = "grupo = 1"
        Sql_reportesBindingSource.Filter = f
        Windows.Forms.Cursor.Current = Cursors.Default
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click, Button3.Click
        Me.Cursor = Cursors.WaitCursor
        If se_cargo_todo = False Then
            Me.Sql_reportesTableAdapter.Fill(Me.MantenimientoDataSet.sql_reportes)
            se_cargo_todo = True
        End If

        Sql_reportesBindingSource.Filter = ""
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim f As String
        f = "grupo = 0"
        Sql_reportesBindingSource.Filter = f
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub filtro_TextChanged(sender As System.Object, e As System.EventArgs) Handles filtro.TextChanged
        Dim f, sql As String
        f = filtro.Text
        sql = "departamento like '%[f]%' or area  like '%[f]%' or reporte  like '%[f]%' or ubicacion  like '%[f]%' or solicitante  like '%[f]%'"
        sql = sql.Replace("[f]", f)
        Try
            Sql_reportesBindingSource.Filter = sql
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtcuarto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtcuarto.TextChanged
        Dim f, sql As String
        f = filtro.Text
        sql = "cuarto = [f] "
        sql = sql.Replace("[f]", f)
        Try
            Sql_reportesBindingSource.Filter = sql
        Catch ex As Exception
        End Try

    End Sub

    Private Sub califica()
        For j = 0 To Sql_reportesDataGridView.RowCount - 1
            With Sql_reportesDataGridView.Rows(j)

                If .Cells("id_status").Value = 97 Then ' terminada
                    .DefaultCellStyle.ForeColor = Color.Green
                Else
                    If .Cells("id_status").Value = 98 Then ' terminada
                        .DefaultCellStyle.ForeColor = Color.Blue
                    Else
                        .DefaultCellStyle.ForeColor = Color.DarkRed
                    End If
                End If
            End With
        Next
    End Sub

    Private Sub Sql_reportesDataGridView_DataBindingComplete(sender As System.Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles Sql_reportesDataGridView.DataBindingComplete
        califica()
    End Sub

    Private Sub ToolStripButton3_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim f As String
        If se_cargo_todo = False Then
            Me.Sql_reportesTableAdapter.Fill(Me.MantenimientoDataSet.sql_reportes)
            se_cargo_todo = True
        End If

        f = "id_status = 97 and departamento='Supervision'"
        Sql_reportesBindingSource.Filter = f
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub Sql_reportesDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Sql_reportesDataGridView.CellClick
        Try
            Dim id As Integer, f As String
            id = Sql_reportesDataGridView.CurrentRow.Cells(0).Value
            f = "id_servicio = " + id.ToString
            SqltareasBindingSource.Filter = f
            Inv_movimintosBindingSource.Filter = f
            Me.Sql_fotosTableAdapter.Fill(Me.MantenimientoDataSet.sql_fotos, id)
            foto.Image = Nothing
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
        Dim id As Integer, sv As String
        id = Sql_reportesDataGridView.CurrentRow.Cells(0).Value
        Try
            sv = Sql_reportesDataGridView.CurrentRow.Cells(1).Value
        Catch ex As Exception
            sv = 0
        End Try

        Dim frmP As New servicios_agregar_producto
        frmP.txtid.Text = id.ToString
        frmP.txtreporte.Text = sv
        frmP.ShowDialog()
        If frmP.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.Inv_movimintosTableAdapter.Fill(Me.MantenimientoDataSet.inv_movimintos)
        End If
    End Sub

    Private Sub Inv_movimintosDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Inv_movimintosDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click


        Dim ix As MsgBoxResult, msg, msgtitulo As String
        msg = "Seguro que quiere borrar producto "
        msgtitulo = "Borrar Producto"
        ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
        If ix = MsgBoxResult.No Then Exit Sub

        Inv_movimintosBindingSource.RemoveCurrent()
        Me.Validate()
        Me.Inv_movimintosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)



    End Sub

    Private Sub AsignarEquipoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AsignarEquipoToolStripMenuItem.Click
        Try
            Dim id As Integer, f As String, id_equipo As Integer, equipo As String
            id = Sql_reportesDataGridView.CurrentRow.Cells(0).Value
            f = "id_servicio = " + id.ToString

            Dim dlg_equipo As New selecciona_equipo
            dlg_equipo.ShowDialog()
            id_equipo = dlg_equipo.Id_equipoTextBox.Text
            equipo = dlg_equipo.DescripcionTextBox.Text
            Dim adap As New mantenimientoDataSetTableAdapters.reportesTableAdapter
            adap.AsignaEquipo(id_equipo, id)
            EquipoTextBox.Text = equipo
        Catch ex As Exception

        End Try
    End Sub


    Private Sub ToolStripButton8_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton8.Click
        Sql_reportesBindingSource.Filter = "id_equipo >0"
    End Sub

    Private Sub AbrirSeguimientoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AbrirSeguimientoToolStripMenuItem.Click
        If Id_statusTextBox.Text < 90 Then
            MsgBox("Solo se puede Abrir reportes Terminados o Con Vo.Bo.")
        End If

        Dim id As Integer
        id = Sql_reportesDataGridView.CurrentRow.Cells(0).Value
        Dim adap As New mantenimientoDataSetTableAdapters.reportesTableAdapter
        adap.cambiar_estatus(6, id)
        Id_statusTextBox.Text = 6
        STATUSTextBox.Text = "Abierta"
    End Sub


    Private Sub AsignarCuartoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AsignarCuartoToolStripMenuItem.Click
        Dim id As Integer, cto As Integer
        id = Sql_reportesDataGridView.CurrentRow.Cells(0).Value
        cto = InputBox("Teclee numero de cuarto o '0' para salir", "Asigna Cuarto", "")

    End Sub

    Private Sub QuitarSeguimientoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QuitarSeguimientoToolStripMenuItem.Click



        Dim ix As MsgBoxResult, msg, msgtitulo As String
        msg = "Seguro que quiere desvincular el equipo del # de servicio ?"
        msgtitulo = "Desvincular Equipo"
        ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
        If ix = MsgBoxResult.No Then Exit Sub



        Try
            Dim id As Integer, f As String, id_equipo As Integer, equipo As String
            id = Sql_reportesDataGridView.CurrentRow.Cells(0).Value
            f = "id_servicio = " + id.ToString

            Dim adap As New mantenimientoDataSetTableAdapters.reportesTableAdapter
            adap.AsignaEquipo(0, id)
            EquipoTextBox.Text = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_ver_equipo_Click(sender As System.Object, e As System.EventArgs) Handles btn_ver_equipo.Click
        Dim frm As New equipos
        frm.cargar(1)
        frm.ShowDialog()
    End Sub


    Private Sub ToolStripButton9_Click(sender As System.Object, e As System.EventArgs) Handles btn_agregar_foto.Click
        Dim id As Integer, f As String
        id = Sql_reportesDataGridView.CurrentRow.Cells(0).Value

        Dim frm As New fotos_reportes
        frm.txtidreporte.Text = id
        frm.txtreporte.Text = ReporteTextBox.Text
        frm.ShowDialog()
        Me.Sql_fotosTableAdapter.Fill(Me.MantenimientoDataSet.sql_fotos, id)

    End Sub

    Private Sub Sql_fotosDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Sql_fotosDataGridView.CellClick
        btn_quitar_foto.Enabled = True
    End Sub

    Private Sub btn_quitar_foto_Click(sender As System.Object, e As System.EventArgs) Handles btn_quitar_foto.Click
        Dim id_foto As Integer
        id_foto = Sql_fotosDataGridView.CurrentRow.Cells(0).Value
        Dim adap As New mantenimientoDataSetTableAdapters.fotosTableAdapter
        adap.borrar_foto(id_foto)
        Me.Sql_fotosTableAdapter.Fill(Me.MantenimientoDataSet.sql_fotos, id_foto)
        foto.Image = Nothing
    End Sub

    Private Sub Sql_fotosDataGridView_Click(sender As System.Object, e As System.EventArgs) Handles Sql_fotosDataGridView.Click
        Dim id_foto As Integer
        id_foto = Sql_fotosDataGridView.CurrentRow.Cells(0).Value
        Try
            Dim ms As New MemoryStream(Extraer_Foto(id_foto))
            foto.Image = Image.FromStream(ms)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub VoBoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VoBoToolStripMenuItem.Click
        If usuario.perfil = perfil.administrador Then

            If Id_statusTextBox.Text <> 97 Then
                MsgBox("Solo se puede Abrir reportes Terminados o Con Vo.Bo.")
            End If

            Dim id As Integer
            id = Sql_reportesDataGridView.CurrentRow.Cells(0).Value
            Dim adap As New mantenimientoDataSetTableAdapters.reportesTableAdapter
            adap.cambiar_estatus(98, id)
            Id_statusTextBox.Text = 98
            STATUSTextBox.Text = "VoBo"
        Else
            MsgBox("No tiene Autorizaracion")
        End If

    End Sub
End Class