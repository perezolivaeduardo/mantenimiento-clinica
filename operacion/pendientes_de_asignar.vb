Public Class pendientes_de_asignar

    Private Sub pendientes_de_asignar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ProveedoresTableAdapter.Fill(Me.MantenimientoDataSet.proveedores)
        Me.StaffTableAdapter.FillByasignables(Me.MantenimientoDataSet.staff)
        Me.Sql_reportesTableAdapter.FillBysin_asignar(Me.MantenimientoDataSet.sql_reportes)
        If usuario.perfil = 4 Then
            Sql_reportesBindingSource.Filter = "grupo_equipo <> 1"
            Me.Text = "Pendientes de Asignar "
        Else
            Me.Text = "Pendientes de Asignar COMPLETO"
        End If
        cerrar_asignar()
        lblpendientes.Text = Sql_reportesDataGridView.Rows.Count.ToString + " Pendientes"
    End Sub

    Private Sub NombreComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles staff.SelectedIndexChanged
        id_user.Text = staff.SelectedValue
    End Sub

    Private Sub id_user_TextChanged(sender As System.Object, e As System.EventArgs) Handles id_user.TextChanged
        Panel2.Visible = False
        If id_user.Text = "99" Then
            Panel2.Visible = True
        End If
        genera_texto()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        cerrar_asignar()
    End Sub

    Private Sub cerrar_asignar()
        SplitContainer2.Panel2Collapsed = True
        SplitContainer1.Panel1Collapsed = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        SplitContainer2.Panel2Collapsed = False
        SplitContainer1.Panel1Collapsed = True
    End Sub

    Private Sub boton_preventivo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles boton_preventivo.CheckedChanged, boton_correctivo.CheckedChanged
        genera_texto()
    End Sub

    Private Sub genera_texto()
        Dim comentarios As String
        If boton_correctivo.Checked Then
            comentarios = "Se asigna este mantenimiento correctivo a "
        Else
            comentarios = "Se asigna este mantenimiento preventivo a "

        End If

        If id_user.Text <> "99" Then
            comentarios += staff.Text
        Else
            comentarios += " proveedodor externo " + proveedor.Text
        End If

        If boton_programada.Checked = True Then
            comentarios += " Con fecha programada para el " + fecha.Value.ToLongDateString
        Else
            comentarios += " Con fecha limite de entrega para el " + fecha.Value.ToLongDateString

        End If
        descripcion.Text = comentarios
    End Sub

    Private Sub Id_proveedorTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles Id_proveedorTextBox.TextChanged
        genera_texto()
    End Sub

    Private Sub fecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles fecha.ValueChanged
        genera_texto()
    End Sub

    Private Sub boton_limite_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles boton_limite.CheckedChanged
        genera_texto()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'asignar tarea
        Dim tipo As String
        If boton_preventivo.Checked = True Then
            tipo = "P"
        Else
            tipo = "C"
        End If

        'Registra datos en registro principal
        Dim adap As New mantenimientoDataSetTableAdapters.reportesTableAdapter
        adap.asignar(tipo, fecha.Value, id_user.Text, 2, Id_servicioTextBox.Text)

        'agregar actividad 
        Dim adapt As New mantenimientoDataSetTableAdapters.tareasTableAdapter
        adapt.Insert(Id_servicioTextBox.Text, fecha_Asignacion.Value, usuario.id, 1, descripcion.Text, mis_comentarios.Text)
        cerrar_asignar()
        Me.Sql_reportesTableAdapter.FillBysin_asignar(Me.MantenimientoDataSet.sql_reportes)

        If notifica.CheckState = True Then
            boleta.mandar_boleta(Id_servicioTextBox.Text, EmailTextBox.Text)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles filtro.TextChanged
        Dim f, sql As String
        f = filtro.Text
        sql = "departamento like '%[f]%' or area  like '%[f]%' or reporte  like '%[f]%' or ubicacion  like '%[f]%' "
        sql = sql.Replace("[f]", f)
        Try
            Sql_reportesBindingSource.Filter = sql
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Sql_reportesDataGridView_DataBindingComplete(sender As System.Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles Sql_reportesDataGridView.DataBindingComplete
        lblpendientes.Text = Sql_reportesDataGridView.Rows.Count.ToString + " Pendientes"
    End Sub
End Class