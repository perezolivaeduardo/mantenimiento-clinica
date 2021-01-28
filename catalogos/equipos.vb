Public Class equipos

    Dim individual As Boolean = False

    Private Sub EquiposBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles EquiposBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EquiposBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)

    End Sub

    Private Sub equipos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.sql_equipos' Puede moverla o quitarla según sea necesario.
        Me.Sql_equiposTableAdapter.Fill(Me.MantenimientoDataSet.sql_equipos)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.MantenimientoDataSet.categorias)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.areas' Puede moverla o quitarla según sea necesario.
        Me.AreasTableAdapter.Fill(Me.MantenimientoDataSet.areas)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.equipos' Puede moverla o quitarla según sea necesario.
        Me.EquiposTableAdapter.Fill(Me.MantenimientoDataSet.equipos)


    End Sub

    Private Sub AreaComboBox_TextChanged(sender As System.Object, e As System.EventArgs)
        AreaTextBox.Text = AreaComboBox.SelectedValue
    End Sub

    Private Sub Sql_equiposDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Sql_equiposDataGridView.CellClick
        Dim id As Integer
        id = Sql_equiposDataGridView.CurrentRow.Cells("dgvidequipo").Value
        EquiposBindingSource.Position = EquiposBindingSource.Find("id_equipo", id)

    End Sub

    Private Sub txtfiltro_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtfiltro.TextChanged
        Dim f, sql As String
        sql = "area like '%[F]%' or categoria like '%[F]%' or descripcion like '%[F]%' or etiqueta like '%[F]%'"
        sql = sql.Replace("[F]", txtfiltro.Text)
        Sql_equiposBindingSource.Filter = sql
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.EquiposBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)
        Me.Close()
    End Sub

    Public Sub cargar(ByVal id As Integer)
        individual = True
    End Sub
End Class