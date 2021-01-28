Public Class Catalogo_de_productos

    Private Sub Inv_productosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub Catalogo_de_productos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.inv_productos' Puede moverla o quitarla según sea necesario.
        Me.Inv_productosTableAdapter.Fill(Me.MantenimientoDataSet.inv_productos)

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.Inv_productosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)
        Close()

    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Dim adap As New PRODUCTO_NUEVO
        adap.ShowDialog()
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.inv_productos' Puede moverla o quitarla según sea necesario.
        Me.Inv_productosTableAdapter.Fill(Me.MantenimientoDataSet.inv_productos)

    End Sub

    Private Sub btn_quitar_Click(sender As System.Object, e As System.EventArgs) Handles btn_quitar.Click
        txtfiltro.Text = ""
    End Sub

    Private Sub txtfiltro_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtfiltro.TextChanged
        Inv_productosBindingSource.Filter = "Descripcion like '%" + txtfiltro.Text + "%'"
    End Sub
End Class