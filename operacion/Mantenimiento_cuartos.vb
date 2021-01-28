Public Class Mantenimiento_cuartos
    Dim tblcuartos As DataTable
    Dim se_cargo_todo As Boolean = False
    Private Sub seuimientos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.reportes_tareas' Puede moverla o quitarla según sea necesario.
        Me.Reportes_tareasTableAdapter.Fill(Me.MantenimientoDataSet.reportes_tareas)
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Me.Sql_reportesTableAdapter.FillBycuartos(Me.MantenimientoDataSet.sql_reportes)
        Me.Sql_tareasTableAdapter.Fill(Me.MantenimientoDataSet.sql_tareas)
        btn_terminar.Enabled = tiene_permiso(usuario.id, funciones.CerrarReporte)
        btn_VoBo.Enabled = tiene_permiso(usuario.id, funciones.VoBo)
        btn_nueva_actividad.Enabled = tiene_permiso(usuario.id, funciones.RegistrarActividades)
        Dim f As String
        f = "grupo = 0"
        Sql_reportesBindingSource.Filter = f
        Windows.Forms.Cursor.Current = Cursors.Default

        Dim adap As New clinicaDataSetTableAdapters.cuartosTableAdapter

        tblcuartos = adap.GetData
        For j = 0 To tblcuartos.Rows.Count - 1
            TabCuartos.TabPages.Add(tblcuartos.Rows(j).Item(0), "Cuarto " + tblcuartos.Rows(j).Item(0).ToString)
        Next j

        Reportes_tareasBindingSource.Filter = "id_reporte=0"
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
        Dim f As String
        f = "grupo = 0 and cuarto = " + CuartoTextBox.Text
        Sql_reportesBindingSource.Filter = f
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

   

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim f As String
        f = "grupo = 0 and cuarto = " + CuartoTextBox.Text
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
        f = "id_status = 97 and departamento='Supervision' "
        Sql_reportesBindingSource.Filter = f
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub Sql_reportesDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Sql_reportesDataGridView.CellClick
        Try
            Dim id As Integer, f, f1 As String
            id = Sql_reportesDataGridView.CurrentRow.Cells(0).Value
            f = "id_servicio = " + id.ToString
            f1 = "id_reporte = " + id.ToString
            SqltareasBindingSource.Filter = f
            Reportes_tareasBindingSource.Filter = f1
        Catch ex As Exception

        End Try


    End Sub

    Private Sub TabCuartos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabCuartos.SelectedIndexChanged
        Dim ix As Integer = TabCuartos.SelectedIndex
        txtcuarto.Text = tblcuartos.Rows(ix).Item(0)
        Dim f, sql As String
        f = txtcuarto.Text
        sql = "cuarto = [f] "
        sql = sql.Replace("[f]", f)
        Try
            Sql_reportesBindingSource.Filter = sql
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ModificarTipoCorrectivoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarTipoCorrectivoToolStripMenuItem.Click
        Dim nadap As New mantenimientoDataSetTableAdapters.reportesTableAdapter
        nadap.Actualiza_tipo("C", Id_servicioTextBox.Text)
        nadap.Dispose()
        TipoTextBox.Text = "C"

    End Sub

    Private Sub ModificarTipoPreventivoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarTipoPreventivoToolStripMenuItem.Click
        Dim nadap As New mantenimientoDataSetTableAdapters.reportesTableAdapter
        nadap.Actualiza_tipo("P", Id_servicioTextBox.Text)
        nadap.Dispose()
        TipoTextBox.Text = "P"
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        My.Forms.catalogo_tareas.ShowDialog()
    End Sub

    Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
        Dim frmmto As New solicitar_mantenimiento_preventivo
        frmmto.txtcuarto.Text = txtcuarto.Text
        frmmto.ShowDialog()

    End Sub

    

    Private Sub Reportes_tareasDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Reportes_tareasDataGridView.CellEndEdit
        Me.Validate()
        Me.Reportes_tareasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)
    End Sub

    Private Sub TabPage3_Click(sender As System.Object, e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click
        My.Forms.hoja_de_mantenimiento.cargar(txtcuarto.Text)
        My.Forms.hoja_de_mantenimiento.ShowDialog()
    End Sub
End Class