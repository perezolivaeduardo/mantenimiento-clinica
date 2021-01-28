Public Class Permisos

  

    Private Sub Permisos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.staff' Puede moverla o quitarla según sea necesario.
        Me.StaffTableAdapter.Fill(Me.MantenimientoDataSet.staff)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.sys_funciones' Puede moverla o quitarla según sea necesario.
        Me.Sys_funcionesTableAdapter.Fill(Me.MantenimientoDataSet.sys_funciones)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.permisos' Puede moverla o quitarla según sea necesario.
        Me.PermisosTableAdapter.Fill(Me.MantenimientoDataSet.permisos)

    End Sub

    Private Sub StaffDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StaffDataGridView.CellClick
        Dim id As Integer, f As String
        id = StaffDataGridView.CurrentRow.Cells(0).Value
        f = "id_usuario=" + id.ToString
        PermisosBindingSource.Filter = f
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Dim id As Integer, f As String
        id = StaffDataGridView.CurrentRow.Cells(0).Value
        Dim tbl As DataTable = leer_tabla("select * from sys_funciones")
        Dim adap As New mantenimientoDataSetTableAdapters.permisosTableAdapter
        For j = 0 To tbl.Rows.Count - 1
            Dim id_funcion As Integer = tbl.Rows(j).Item(0)
            Try
                adap.Insert(id, id_funcion, False)
            Catch ex As Exception

            End Try
        Next
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.permisos' Puede moverla o quitarla según sea necesario.
        Me.PermisosTableAdapter.Fill(Me.MantenimientoDataSet.permisos)


    End Sub

    Private Sub PermisosDataGridView_DataError(sender As System.Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles PermisosDataGridView.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PermisosDataGridView_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PermisosDataGridView.CellEndEdit
        Me.Validate()
        Me.PermisosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)
    End Sub
End Class