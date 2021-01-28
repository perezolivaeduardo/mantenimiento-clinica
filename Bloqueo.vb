Public Class Bloqueo

    Private Sub Bloqueo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.bloqueos' Puede moverla o quitarla según sea necesario.
        Me.BloqueosTableAdapter.Fill(Me.ClinicaDataSet.bloqueos)
        Me.BloqueosBindingSource.AddNew()
        FechaTextBox.Text = Now.ToString
        Inicia_bloqueoTextBox.Text = Now.ToString
    End Sub

    Private Sub CuartoTextBox_Leave(sender As System.Object, e As System.EventArgs) Handles CuartoTextBox.Leave
        Dim sql As String = "Select activo from cuartosycamas where cuarto =" + CuartoTextBox.Text
        If acc_leer_tabla(sql).Rows.Count > 0 Then
            Dim activa As Boolean
            activa = acc_leer_tabla(sql).Rows(0).Item(0)
            If activa Then
                btn_bloquear.Enabled = True
            Else
                MsgBox("Habitacion Bloqueada")
                btn_bloquear.Enabled = False
            End If

        Else
            btn_bloquear.Enabled = False
        End If
        Usuario_registraTextBox.Text = usuario.id

    End Sub

    Private Sub btn_bloquear_Click(sender As System.Object, e As System.EventArgs) Handles btn_bloquear.Click
        Me.Validate()
        Me.BloqueosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClinicaDataSet)
        Dim cmd As String
        cmd = "update cuartosycamas set activo=0 where cuarto=" + CuartoTextBox.Text
        acc_comando(cmd)

        'manda correo
        Dim msg As String
        msg = "Se bloqueo el cuarto " + CuartoTextBox.Text + ", solicitado por : " + SolicitaTextBox.Text + ", Motivo :" + MotivoTextBox.Text
        email_mantenimiento = "sistemas@programacionintegral.com"
        mandar_correo(email_mantenimiento, "Bloqueo Cto. " + CuartoTextBox.Text, msg, "")
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.BloqueosBindingSource.CancelEdit()
        Me.Dispose()
        Me.Close()
    End Sub

End Class