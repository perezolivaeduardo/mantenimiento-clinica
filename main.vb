Public Class main

    Private Sub main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        inicializa()

        If My.Computer.Name = "MATRIX" Then
            Dim ix As MsgBoxResult
            ix = MsgBox("Modo local", MsgBoxStyle.YesNo, "")
            If ix = MsgBoxResult.Yes Then
                My.Settings.cadena = My.Settings.cadena_local
                My.Settings.dbcadena = My.Settings.dbcadena_local
                email_mantenimiento = "sistemas@programacionintegral.com"
            Else
                My.Settings.cadena = My.Settings.cadena_on_line
            End If
        Else
            My.Settings.cadena = My.Settings.cadena_on_line
        End If

        My.Forms.LoginForm.ShowDialog()
        If My.Forms.LoginForm.DialogResult = Windows.Forms.DialogResult.Cancel Then
            End
        End If
        lblusuario.Text = usuario.nombre
        If usuario.perfil = perfil.administrador Then
            BTN_CATALOGO.Enabled = True
        End If

        btn_pendientes.Enabled = tiene_permiso(usuario.id, funciones.AsignarReporte)
        btn_seguimiento.Enabled = tiene_permiso(usuario.id, funciones.darSeguimiento)
        lblpendientes.Enabled = tiene_permiso(usuario.id, funciones.darSeguimiento)
        BTN_REPORTES.Enabled = tiene_permiso(usuario.id, funciones.ImprimirReporte)
        btn_imprimir_pendientes.Enabled = tiene_permiso(usuario.id, funciones.ImprimirPendientes)
        If usuario.perfil > 0 Then
            lblpendientes.Text = pendientes.ToString + " Reportes pendientes"
            lblpendientes.Visible = True
        End If
        Try
            If usuario.perfil = 0 Then
                My.Forms.registro_nuevo.ShowDialog()
            End If
        Catch ex As Exception

        End Try
        lblver.Text = "Ver." + My.Application.Info.Version.ToString

        BTN_PENDIENTES_USUARIO.Text = "Pendientes de " + UCase(usuario.nombre)
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles btn_nuevo.Click
        My.Forms.registro_nuevo.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles btn_pendientes.Click
        Dim frmp As New pendientes_de_asignar
        frmp.ShowDialog()
    End Sub

    Private Sub PROVEEDORESToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PROVEEDORESToolStripMenuItem.Click
        My.Forms.proveedores.Show()
    End Sub

    Private Sub DEPARTAMENTOSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DEPARTAMENTOSToolStripMenuItem.Click
        My.Forms.Departamentos.Show()
    End Sub

    Private Sub AREASToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AREASToolStripMenuItem.Click
        My.Forms.Areas.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles btn_seguimiento.Click
        My.Forms.seguimientos.Show()
    End Sub



    Private Sub CATEGORIASToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CATEGORIASToolStripMenuItem.Click
        My.Forms.CATEGORIAS.Show()
    End Sub

    Private Sub HOJADETRABAJOToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HOJADETRABAJOToolStripMenuItem.Click
        My.Forms.hojadetrabajo.ShowDialog()
    End Sub

    Private Sub EQUIPOSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EQUIPOSToolStripMenuItem.Click
        My.Forms.equipos.ShowDialog()
    End Sub

    Private Sub PERMISOSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PERMISOSToolStripMenuItem.Click
        My.Forms.Permisos.Show()
    End Sub

    Private Sub STAFFToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles STAFFToolStripMenuItem.Click
        My.Forms.staff.Show()
    End Sub

    Private Sub btn_imprimir_pendientes_Click(sender As System.Object, e As System.EventArgs) Handles btn_imprimir_pendientes.Click
        If My.Settings.imprimir_directo = True Then

            Dim ix As MsgBoxResult, msg, msgtitulo As String
            msg = "Seguro que quiere Imprimir Pendientes "
            msgtitulo = "Reporte de Pendientes"
            ix = MsgBox(msg, MsgBoxStyle.YesNo, msgtitulo)
            If ix = MsgBoxResult.No Then Exit Sub

            My.Forms.Lista_de_Trabajo.todos_los_pendientes()
            My.Forms.Lista_de_Trabajo.Show()

        Else
            My.Forms.hojadetrabajo.Show()

        End If

    End Sub

    Private Sub SkypeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SkypeToolStripMenuItem.Click
        My.Forms.skype.Show()
    End Sub

    Private Sub INFORMACIONToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles INFORMACIONToolStripMenuItem.Click
        MsgBox(My.Settings.mantenimientoConnectionString)
    End Sub

    Private Sub lblpendientes_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblpendientes.LinkClicked
        My.Forms.seguimientos.Show()
    End Sub

    Private Sub PENDIENTESDEVObOToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PENDIENTESDEVObOToolStripMenuItem.Click
        Dim frmarea As New Seleccionar_area
        frmarea.ShowDialog()
        Dim area As String
        area = frmarea.karea
        My.Forms.Lista_de_Trabajo.pendientes_voBo(area, 97)
        My.Forms.Lista_de_Trabajo.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        My.Forms.bloqueos.Show()
    End Sub


    Private Sub BTN_PENDIENTES_USUARIO_Click(sender As System.Object, e As System.EventArgs) Handles BTN_PENDIENTES_USUARIO.Click
        My.Forms.Lista_de_Trabajo.pendientes_por_usuario(usuario.nick)
        My.Forms.Lista_de_Trabajo.ShowDialog()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripLabel1.Click
        My.Forms.listado_de_tareas.Show()
    End Sub

    Private Sub RUTINASToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RUTINASToolStripMenuItem.Click
        My.Forms.rutinas.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        My.Forms.Mantenimiento_cuartos.Show()
    End Sub

    Private Sub EQUIPOSREDToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EQUIPOSREDToolStripMenuItem.Click
        frm_equiposRed.Show()
    End Sub

    Private Sub PRODUCTOSToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PRODUCTOSToolStripMenuItem.Click
        My.Forms.Catalogo_de_productos.Show()
    End Sub

    Private Sub ToolStripButton4_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        Dim frm As New registro_servicio
        frm.ShowDialog()
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TestToolStripMenuItem.Click
        My.Settings.aviso = "Esto es un aviso del administrador"
    End Sub

    Private Sub lblusuario_Click(sender As System.Object, e As System.EventArgs) Handles lblusuario.Click
        My.Forms.fotos_reportes.Show()

    End Sub
End Class
