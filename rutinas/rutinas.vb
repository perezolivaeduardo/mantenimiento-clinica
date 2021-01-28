Public Class rutinas

    Private Sub RutinasBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.RutinasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.sql_rutinas' Puede moverla o quitarla según sea necesario.
        Me.Sql_rutinasTableAdapter.Fill(Me.MantenimientoDataSet.sql_rutinas)
    End Sub

    Private Sub rutinas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.sql_rutinas' Puede moverla o quitarla según sea necesario.
        Me.Sql_rutinasTableAdapter.Fill(Me.MantenimientoDataSet.sql_rutinas)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.staff' Puede moverla o quitarla según sea necesario.
        Me.StaffTableAdapter.FillByasignables(Me.MantenimientoDataSet.staff)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.rutinas' Puede moverla o quitarla según sea necesario.
        Me.RutinasTableAdapter.Fill(Me.MantenimientoDataSet.rutinas)

    End Sub

    Private Sub comodia_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles combodia.SelectedIndexChanged
        Dia_semanaTextBox.Text = combodia.SelectedIndex
    End Sub

    Private Sub combo_tipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles combo_tipo.SelectedIndexChanged
        TipoTextBox.Text = combo_tipo.SelectedIndex
        If TipoTextBox.Text > 2 Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        SplitContainer1.Panel1Collapsed = False
        StatusCheckBox.Checked = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Validate()
        Me.RutinasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.RutinasBindingSource.CancelEdit()
        SplitContainer1.Panel1Collapsed = True
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_Click(sender As System.Object, e As System.EventArgs) Handles RadioButton1.Click
        Dia_mesTextBox.Enabled = True
        Lugar_en_el_mesTextBox.Enabled = False
    End Sub

    Private Sub RadioButton2_Click(sender As System.Object, e As System.EventArgs) Handles RadioButton2.Click
        Dia_mesTextBox.Enabled = False
        Lugar_en_el_mesTextBox.Enabled = True
    End Sub

    Private Sub Sql_rutinasDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Sql_rutinasDataGridView.CellClick
        Dim id As Integer
        id = Sql_rutinasDataGridView.CurrentRow.Cells("id_rutina").Value
        RutinasBindingSource.Position = RutinasBindingSource.Find("id_rutina", id)
    End Sub

    Private Sub TipoTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles TipoTextBox.TextChanged
        Try
            combo_tipo.SelectedIndex = TipoTextBox.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Dia_semanaTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles Dia_semanaTextBox.TextChanged
        Try
            combodia.SelectedIndex = Dia_semanaTextBox.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click


        Dim ix As MsgBoxResult, msg, msgtitulo As String
        msg = "Seguro que quiere Eliminar Rutina"
        msgtitulo = "Eliminar Rutina"
        ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
        If ix = MsgBoxResult.No Then Exit Sub
        RutinasBindingSource.RemoveCurrent()

        Me.Validate()
        Me.RutinasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.sql_rutinas' Puede moverla o quitarla según sea necesario.
        Me.Sql_rutinasTableAdapter.Fill(Me.MantenimientoDataSet.sql_rutinas)


    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles btn_programar.Click
        My.Forms.programar_ruitnas.Show()
    End Sub
End Class