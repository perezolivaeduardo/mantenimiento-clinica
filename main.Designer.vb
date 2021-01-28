<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblusuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblver = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_nuevo = New System.Windows.Forms.ToolStripButton()
        Me.btn_pendientes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.BTN_CATALOGO = New System.Windows.Forms.ToolStripSplitButton()
        Me.DEPARTAMENTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AREASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROVEEDORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CATEGORIASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EQUIPOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PERMISOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STAFFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SkypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.INFORMACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RUTINASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EQUIPOSREDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_seguimiento = New System.Windows.Forms.ToolStripButton()
        Me.BTN_REPORTES = New System.Windows.Forms.ToolStripSplitButton()
        Me.HOJADETRABAJOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENDIENTESDEVObOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTN_PENDIENTES_USUARIO = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_imprimir_pendientes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.lblpendientes = New System.Windows.Forms.LinkLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblusuario, Me.lblver})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 521)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1382, 25)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblusuario
        '
        Me.lblusuario.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(61, 20)
        Me.lblusuario.Text = "Usuaio :"
        '
        'lblver
        '
        Me.lblver.Name = "lblver"
        Me.lblver.Size = New System.Drawing.Size(17, 20)
        Me.lblver.Text = "V."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_nuevo, Me.btn_pendientes, Me.ToolStripButton2, Me.BTN_CATALOGO, Me.btn_seguimiento, Me.BTN_REPORTES, Me.btn_imprimir_pendientes, Me.ToolStripButton1, Me.ToolStripLabel1, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1382, 39)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btn_nuevo.Image = Global.Mantenimineto.My.Resources.Resources.REPORTES_mybusinesspos
        Me.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(145, 36)
        Me.btn_nuevo.Text = "Nuevo Reporte"
        '
        'btn_pendientes
        '
        Me.btn_pendientes.Enabled = False
        Me.btn_pendientes.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btn_pendientes.Image = Global.Mantenimineto.My.Resources.Resources.asignar1
        Me.btn_pendientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_pendientes.Name = "btn_pendientes"
        Me.btn_pendientes.Size = New System.Drawing.Size(191, 36)
        Me.btn_pendientes.Text = "Pendientes de Asignar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Mantenimineto.My.Resources.Resources.Restart
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'BTN_CATALOGO
        '
        Me.BTN_CATALOGO.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BTN_CATALOGO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTN_CATALOGO.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DEPARTAMENTOSToolStripMenuItem, Me.AREASToolStripMenuItem, Me.PROVEEDORESToolStripMenuItem, Me.CATEGORIASToolStripMenuItem, Me.EQUIPOSToolStripMenuItem, Me.PERMISOSToolStripMenuItem, Me.PRODUCTOSToolStripMenuItem, Me.STAFFToolStripMenuItem, Me.SkypeToolStripMenuItem, Me.ToolStripSeparator1, Me.INFORMACIONToolStripMenuItem, Me.RUTINASToolStripMenuItem, Me.EQUIPOSREDToolStripMenuItem, Me.TestToolStripMenuItem})
        Me.BTN_CATALOGO.Enabled = False
        Me.BTN_CATALOGO.Image = Global.Mantenimineto.My.Resources.Resources.Application
        Me.BTN_CATALOGO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTN_CATALOGO.Name = "BTN_CATALOGO"
        Me.BTN_CATALOGO.Size = New System.Drawing.Size(48, 36)
        Me.BTN_CATALOGO.Text = "ToolStripSplitButton1"
        '
        'DEPARTAMENTOSToolStripMenuItem
        '
        Me.DEPARTAMENTOSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DEPARTAMENTOSToolStripMenuItem.Name = "DEPARTAMENTOSToolStripMenuItem"
        Me.DEPARTAMENTOSToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.DEPARTAMENTOSToolStripMenuItem.Text = "DEPARTAMENTOS"
        '
        'AREASToolStripMenuItem
        '
        Me.AREASToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AREASToolStripMenuItem.Name = "AREASToolStripMenuItem"
        Me.AREASToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.AREASToolStripMenuItem.Text = "AREAS"
        '
        'PROVEEDORESToolStripMenuItem
        '
        Me.PROVEEDORESToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PROVEEDORESToolStripMenuItem.Name = "PROVEEDORESToolStripMenuItem"
        Me.PROVEEDORESToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.PROVEEDORESToolStripMenuItem.Text = "PROVEEDORES"
        '
        'CATEGORIASToolStripMenuItem
        '
        Me.CATEGORIASToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CATEGORIASToolStripMenuItem.Name = "CATEGORIASToolStripMenuItem"
        Me.CATEGORIASToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.CATEGORIASToolStripMenuItem.Text = "CATEGORIAS"
        '
        'EQUIPOSToolStripMenuItem
        '
        Me.EQUIPOSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.EQUIPOSToolStripMenuItem.Name = "EQUIPOSToolStripMenuItem"
        Me.EQUIPOSToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.EQUIPOSToolStripMenuItem.Text = "EQUIPOS"
        '
        'PERMISOSToolStripMenuItem
        '
        Me.PERMISOSToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PERMISOSToolStripMenuItem.Name = "PERMISOSToolStripMenuItem"
        Me.PERMISOSToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.PERMISOSToolStripMenuItem.Text = "PERMISOS"
        '
        'PRODUCTOSToolStripMenuItem
        '
        Me.PRODUCTOSToolStripMenuItem.Name = "PRODUCTOSToolStripMenuItem"
        Me.PRODUCTOSToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.PRODUCTOSToolStripMenuItem.Text = "PRODUCTOS"
        '
        'STAFFToolStripMenuItem
        '
        Me.STAFFToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.STAFFToolStripMenuItem.Name = "STAFFToolStripMenuItem"
        Me.STAFFToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.STAFFToolStripMenuItem.Text = "STAFF"
        '
        'SkypeToolStripMenuItem
        '
        Me.SkypeToolStripMenuItem.Name = "SkypeToolStripMenuItem"
        Me.SkypeToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.SkypeToolStripMenuItem.Text = "skype"
        Me.SkypeToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(201, 6)
        '
        'INFORMACIONToolStripMenuItem
        '
        Me.INFORMACIONToolStripMenuItem.Name = "INFORMACIONToolStripMenuItem"
        Me.INFORMACIONToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.INFORMACIONToolStripMenuItem.Text = "INFORMACION"
        '
        'RUTINASToolStripMenuItem
        '
        Me.RUTINASToolStripMenuItem.Name = "RUTINASToolStripMenuItem"
        Me.RUTINASToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.RUTINASToolStripMenuItem.Text = "RUTINAS"
        '
        'EQUIPOSREDToolStripMenuItem
        '
        Me.EQUIPOSREDToolStripMenuItem.Name = "EQUIPOSREDToolStripMenuItem"
        Me.EQUIPOSREDToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.EQUIPOSREDToolStripMenuItem.Text = "EQUIPOS RED"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.TestToolStripMenuItem.Text = "test"
        '
        'btn_seguimiento
        '
        Me.btn_seguimiento.Enabled = False
        Me.btn_seguimiento.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btn_seguimiento.Image = Global.Mantenimineto.My.Resources.Resources.seguimiento
        Me.btn_seguimiento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_seguimiento.Name = "btn_seguimiento"
        Me.btn_seguimiento.Size = New System.Drawing.Size(129, 36)
        Me.btn_seguimiento.Text = "Seguimiento"
        '
        'BTN_REPORTES
        '
        Me.BTN_REPORTES.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTN_REPORTES.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOJADETRABAJOToolStripMenuItem, Me.PENDIENTESDEVObOToolStripMenuItem, Me.ToolStripSeparator2, Me.BTN_PENDIENTES_USUARIO})
        Me.BTN_REPORTES.Image = Global.Mantenimineto.My.Resources.Resources.printer1
        Me.BTN_REPORTES.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTN_REPORTES.Name = "BTN_REPORTES"
        Me.BTN_REPORTES.Size = New System.Drawing.Size(48, 36)
        Me.BTN_REPORTES.Text = "ToolStripButton6"
        '
        'HOJADETRABAJOToolStripMenuItem
        '
        Me.HOJADETRABAJOToolStripMenuItem.Name = "HOJADETRABAJOToolStripMenuItem"
        Me.HOJADETRABAJOToolStripMenuItem.Size = New System.Drawing.Size(312, 24)
        Me.HOJADETRABAJOToolStripMenuItem.Text = "HOJA DE TRABAJO"
        '
        'PENDIENTESDEVObOToolStripMenuItem
        '
        Me.PENDIENTESDEVObOToolStripMenuItem.Name = "PENDIENTESDEVObOToolStripMenuItem"
        Me.PENDIENTESDEVObOToolStripMenuItem.Size = New System.Drawing.Size(312, 24)
        Me.PENDIENTESDEVObOToolStripMenuItem.Text = "PENDIENTES DE VoBo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(309, 6)
        '
        'BTN_PENDIENTES_USUARIO
        '
        Me.BTN_PENDIENTES_USUARIO.Name = "BTN_PENDIENTES_USUARIO"
        Me.BTN_PENDIENTES_USUARIO.Size = New System.Drawing.Size(312, 24)
        Me.BTN_PENDIENTES_USUARIO.Text = "IMPRIMIR PENDIENTE DE USUARIO"
        '
        'btn_imprimir_pendientes
        '
        Me.btn_imprimir_pendientes.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_imprimir_pendientes.Image = Global.Mantenimineto.My.Resources.Resources.asignar1
        Me.btn_imprimir_pendientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_imprimir_pendientes.Name = "btn_imprimir_pendientes"
        Me.btn_imprimir_pendientes.Size = New System.Drawing.Size(186, 36)
        Me.btn_imprimir_pendientes.Text = "Imprimir Pendientes"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Mantenimineto.My.Resources.Resources.bloqueo
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "Bloqueos"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(64, 36)
        Me.ToolStripLabel1.Text = "Bitacora"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(155, 36)
        Me.ToolStripButton3.Text = "Mant. Preventivo"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(107, 36)
        Me.ToolStripButton4.Text = "Servicios "
        '
        'lblpendientes
        '
        Me.lblpendientes.AutoSize = True
        Me.lblpendientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblpendientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblpendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpendientes.LinkColor = System.Drawing.Color.Chartreuse
        Me.lblpendientes.Location = New System.Drawing.Point(0, 39)
        Me.lblpendientes.Name = "lblpendientes"
        Me.lblpendientes.Size = New System.Drawing.Size(21, 29)
        Me.lblpendientes.TabIndex = 2
        Me.lblpendientes.TabStop = True
        Me.lblpendientes.Text = "-"
        Me.lblpendientes.Visible = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1382, 546)
        Me.Controls.Add(Me.lblpendientes)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.Text = "Modulo de Mantenimiento"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblusuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_pendientes As System.Windows.Forms.ToolStripButton
    Friend WithEvents BTN_CATALOGO As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents DEPARTAMENTOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AREASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PROVEEDORESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_seguimiento As System.Windows.Forms.ToolStripButton
    Friend WithEvents CATEGORIASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BTN_REPORTES As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents HOJADETRABAJOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EQUIPOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PERMISOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_imprimir_pendientes As System.Windows.Forms.ToolStripButton
    Friend WithEvents STAFFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SkypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents INFORMACIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblpendientes As System.Windows.Forms.LinkLabel
    Friend WithEvents PENDIENTESDEVObOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblver As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BTN_PENDIENTES_USUARIO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents RUTINASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents EQUIPOSREDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRODUCTOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
