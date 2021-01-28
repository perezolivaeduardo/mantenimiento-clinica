Imports System.Windows.Forms

Public Class servicios_agregar_producto

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click



        Dim ix As MsgBoxResult, msg, msgtitulo As String
        msg = "Seguro que quiere agregar estos productos al Servicio? "
        msgtitulo = "Agregar Productos"
        ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
        If ix = MsgBoxResult.No Then Exit Sub

        Dim adap As New mantenimientoDataSetTableAdapters.inv_movimintosTableAdapter
        adap.Insert(0, 0, Id_productoTextBox.Text, txtcantidad.Text, 0, txtcomentario.Text, txtid.Text)
        adap.Dispose()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub servicios_agregar_producto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.inv_productos' Puede moverla o quitarla según sea necesario.
        Me.Inv_productosTableAdapter.Fill(Me.MantenimientoDataSet.inv_productos)

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Dim adap As New PRODUCTO_NUEVO
        adap.ShowDialog()
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.inv_productos' Puede moverla o quitarla según sea necesario.
        Me.Inv_productosTableAdapter.Fill(Me.MantenimientoDataSet.inv_productos)
    End Sub
End Class
