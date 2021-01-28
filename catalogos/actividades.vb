Public Class actividades

    Private Sub ActividadesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ActividadesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)

    End Sub

    Private Sub actividades_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.actividades' Puede moverla o quitarla según sea necesario.
        Me.ActividadesTableAdapter.Fill(Me.MantenimientoDataSet.actividades)

    End Sub
End Class