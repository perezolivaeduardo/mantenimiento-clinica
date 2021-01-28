Public Class hojadetrabajo

    Private Sub hojadetrabajo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.staff' Puede moverla o quitarla según sea necesario.
        Me.StaffTableAdapter.Fill(Me.MantenimientoDataSet.staff)
    End Sub

    Private Sub btn_salir_Click(sender As System.Object, e As System.EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If todas.Checked = False Then
            My.Forms.Lista_de_Trabajo.reporte_individual(Id_usuarioTextBox.Text)
            My.Forms.Lista_de_Trabajo.ShowDialog()
        Else

            Dim ix As MsgBoxResult, msg, msgtitulo As String
            msg = "Seguro que quiere Imprimir el reporte "
            msgtitulo = "Imprimir Reporte de Pendientes"
            ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
            If ix = MsgBoxResult.No Then Exit Sub

            My.Forms.Lista_de_Trabajo.todos_los_pendientes()
            My.Forms.Lista_de_Trabajo.ShowDialog()
        End If

    End Sub
End Class