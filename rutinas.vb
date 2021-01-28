Public Class rutinas

    Private Sub RutinasBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.RutinasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)

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

    Private Sub NombreComboBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles NombreComboBox.TextChanged
        Id_usuarioTextBox.Text = NombreComboBox.SelectedValue
    End Sub

    Private Sub combo_tipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles combo_tipo.SelectedIndexChanged
        TipoTextBox.Text = combo_tipo.SelectedIndex
    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        SplitContainer1.Panel1Collapsed = False
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
End Class