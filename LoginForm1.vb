Public Class LoginForm


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim sql As String = "select * from Staff where pw='" + pwtxt.Text + "'"
        Dim dr As DataRow
        If leer_tabla(sql).Rows.Count = 0 Then
            MsgBox("Verifique Contraseña")
            pwtxt.Text = ""
            Exit Sub
        End If

        dr = leer_tabla(sql).Rows(0)
        usuario.id = dr("id_usuario")
        usuario.nombre = dr("nombre")
        usuario.email = dr("email")
        usuario.skype = dr("skype")
        usuario.perfil = dr("perfil")
        usuario.depto = dr("id_depto")
        If Recordar.Checked = True Then
            My.Settings.pw = pwtxt.Text
        End If
        Me.Close()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Recordar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Recordar.CheckedChanged
        My.Settings.Save()
    End Sub

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Recordar.Checked = True Then
            pwtxt.Text = My.Settings.pw
        End If
    End Sub
End Class
