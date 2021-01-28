Public Class bloqueos

    Private Sub bloqueos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.bloqueos' Puede moverla o quitarla según sea necesario.
        Me.BloqueosTableAdapter.Fill(Me.ClinicaDataSet.bloqueos)
        BloqueosBindingSource.Filter = "Status = 0"
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        My.Forms.Bloqueo.ShowDialog()
        Me.BloqueosTableAdapter.Fill(Me.ClinicaDataSet.bloqueos)
        BloqueosBindingSource.Filter = "Status = 0"
    End Sub

    Private Sub BloqueosDataGridView_DataBindingComplete(sender As System.Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles BloqueosDataGridView.DataBindingComplete
        If BloqueosDataGridView.Rows.Count = 0 Then
            lblstatus.Text = "Sin Registros en la consulta"
        Else
            lblstatus.Text = BloqueosDataGridView.Rows.Count.ToString + " Registros en la consulta"
        End If

    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        BloqueosBindingSource.Filter = ""
    End Sub

    Private Sub BloqueosDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BloqueosDataGridView.CellClick
        If BloqueosDataGridView.CurrentRow.Cells("dgvstatus").Value = 0 Then
            btn_liberar.Enabled = True
        Else
            btn_liberar.Enabled = True
        End If
    End Sub

    Private Sub btn_liberar_Click(sender As System.Object, e As System.EventArgs) Handles btn_liberar.Click
        desbloquear()
    End Sub

    Private Sub desbloquear()
        Dim id As Integer
        id = BloqueosDataGridView.CurrentRow.Cells(0).Value
        My.Forms.bloqueo_cerrar.cargar(id)
        My.Forms.bloqueo_cerrar.ShowDialog()
    End Sub
End Class