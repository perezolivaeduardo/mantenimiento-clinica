Public Class staff_nuevo

    Private Sub staff_nuevo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.staff' Puede moverla o quitarla según sea necesario.
        StaffBindingSource.AddNew()
        Id_usuarioTextBox.Text = StaffTableAdapter.siguiente
        NombreTextBox.Focus()
    End Sub

    Private Sub btn_nuevo_Click(sender As System.Object, e As System.EventArgs) Handles btn_nuevo.Click
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        StaffBindingSource.CancelEdit()
        Me.Dispose()
        Me.Close()

    End Sub
End Class