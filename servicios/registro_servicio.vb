Public Class registro_servicio


    Private Sub registro_nuevo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.StaffTableAdapter.Fill(Me.MantenimientoDataSet.staff)
        Me.AreasTableAdapter.Fill(Me.MantenimientoDataSet.areas)
        Me.DepartamentosTableAdapter.Fill(Me.MantenimientoDataSet.departamentos)


        ReportesBindingSource.AddNew()
        Me.DepartamentosBindingSource.MoveFirst()
        Id_servicioTextBox.Text = Format(ReportesTableAdapter.siguiente_reporte, "00000")
        Fechayhora_solicitudTextBox.Text = String.Format("{0}T{1}", Format(fecha.Value, "yyyy-MM-dd"), Format(hora.Value, "HH:mm:ss"))
        Fechayhora_registro.Value = Now.Date
        Id_depto_solicitaTextBox.Text = usuario.depto

        Try
            StaffBindingSource.Position = StaffBindingSource.Find("id_usuario", usuario.id)
            DepartamentosBindingSource.Position = DepartamentosBindingSource.Find("id_depto", usuario.depto)
            AreasBindingSource.MoveFirst()
        Catch ex As Exception

        End Try

        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.sql_reportes' Puede moverla o quitarla según sea necesario.
        Me.Sql_reportesTableAdapter.FillBydepto(Me.MantenimientoDataSet.sql_reportes, usuario.depto)

        If usuario.perfil = 0 Then
            Button1.Enabled = False
            Button3.Enabled = False
        End If
    End Sub

    Private Sub DepartamentoComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles DepartamentoComboBox.SelectedIndexChanged
        Id_depto_solicitaTextBox.Text = DepartamentoComboBox.SelectedValue
    End Sub


    Private Sub BTN_SALIR_Click(sender As System.Object, e As System.EventArgs) Handles BTN_SALIR.Click
        ReportesBindingSource.CancelEdit()
        Me.Close()
    End Sub


    Private Sub AreaComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles AreaComboBox.SelectedIndexChanged
        Id_areaTextBox.Text = AreaComboBox.SelectedValue
    End Sub

    Private Sub fecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles fecha.ValueChanged, hora.ValueChanged
        Fechayhora_solicitudTextBox.Text = String.Format("{0}T{1}", Format(fecha.Value, "yyyy-MM-dd"), Format(hora.Value, "HH:mm:ss"))
    End Sub

    Private Sub Id_servicioTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles Id_servicioTextBox.TextChanged
        lblid.Text = Id_servicioTextBox.Text
    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles NombreComboBox.SelectedIndexChanged
        Try
            Id_solicitanteTextBox.Text = NombreComboBox.SelectedValue
            If NombreComboBox.SelectedValue > 0 Then
                Quien_solicitaTextBox.Text = NombreComboBox.Text
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Forms.staff_nuevo.ShowDialog()
        MantenimientoDataSet.Clear()
        Me.StaffTableAdapter.Fill(Me.MantenimientoDataSet.staff)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim ns, EQ, depto, quien As Integer
        ns = Id_servicioTextBox.Text
        EQ = Id_equipoTextBox.Text
        depto = Id_depto_solicitaTextBox.Text
        quien = Id_solicitanteTextBox.Text

        If EQ < 1 Then
            MsgBox("Debe seleccionar Un equipo !!!")
            Exit Sub
        End If
        If depto < 1 Then
            MsgBox("Debe seleccionar Un departamento !!!")
            Exit Sub
        End If
        If quien < 1 Then
            MsgBox("Debe indicar quien solicita !!!")
            Exit Sub
        End If

        Me.Validate()
        Me.ReportesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)
        Me.Dispose()

        My.Forms.boleta.mandar_boleta(ns, email_mantenimiento)
        Me.Close()
    End Sub

    Private Sub btn_depto_Click(sender As System.Object, e As System.EventArgs) Handles btn_depto.Click
        My.Forms.Departamentos.ShowDialog()
        Me.DepartamentosTableAdapter.Fill(Me.MantenimientoDataSet.departamentos)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        My.Forms.Areas.ShowDialog()
        Me.AreasTableAdapter.Fill(Me.MantenimientoDataSet.areas)
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub btn_equipo_Click(sender As System.Object, e As System.EventArgs) Handles btn_equipo.Click
        Dim dlg_equipo As New selecciona_equipo
        dlg_equipo.ShowDialog()
        Id_equipoTextBox.Text = dlg_equipo.Id_equipoTextBox.Text
        txtequipo.Text = dlg_equipo.DescripcionTextBox.Text
        Id_areaTextBox.Text = dlg_equipo.AreaTextBox.Text
    End Sub

   
End Class