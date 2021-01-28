Public Class bloqueo_cerrar

    Private Sub BloqueosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub bloqueo_cerrar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        Dim ix As MsgBoxResult, msg, msgtitulo As String
        msg = "Seguro que quiere Desbloquear Habitacion " + CuartoTextBox.Text
        msgtitulo = "Desbloquear"
        ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
        If ix = MsgBoxResult.No Then Exit Sub

        StatusTextBox.Text = "1"
        Me.Validate()
        Me.BloqueosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClinicaDataSet)


        Dim cmd As String
        cmd = "update cuartosycamas set activo=-1 where cuarto=" + CuartoTextBox.Text
        acc_comando(cmd)
    End Sub

    Public Sub cargar(ByVal id As Integer)
        Me.BloqueosTableAdapter.FillByid(Me.ClinicaDataSet.bloqueos, id)

    End Sub
End Class