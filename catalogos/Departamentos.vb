Public Class Departamentos

  
    Private Sub Departamentos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.staff' Puede moverla o quitarla según sea necesario.
        Me.StaffTableAdapter.Fill(Me.MantenimientoDataSet.staff)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.departamentos' Puede moverla o quitarla según sea necesario.
        Me.DepartamentosTableAdapter.Fill(Me.MantenimientoDataSet.departamentos)

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.DepartamentosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)
        Me.Dispose()
    End Sub

    Private Sub DepartamentosDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DepartamentosDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class