<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class skype
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
        Me.mensaje = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.para = New System.Windows.Forms.TextBox()
        Me.cel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'mensaje
        '
        Me.mensaje.Location = New System.Drawing.Point(23, 66)
        Me.mensaje.Multiline = True
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(438, 127)
        Me.mensaje.TabIndex = 0
        Me.mensaje.Text = "Mensaje de prueba"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(305, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CHAT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(386, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "SMS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'para
        '
        Me.para.Location = New System.Drawing.Point(23, 40)
        Me.para.Name = "para"
        Me.para.Size = New System.Drawing.Size(213, 20)
        Me.para.TabIndex = 3
        Me.para.Text = "live:yadipm_1"
        '
        'cel
        '
        Me.cel.Location = New System.Drawing.Point(361, 40)
        Me.cel.Name = "cel"
        Me.cel.Size = New System.Drawing.Size(100, 20)
        Me.cel.TabIndex = 4
        Me.cel.Text = "9992771556"
        '
        'skype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 240)
        Me.Controls.Add(Me.cel)
        Me.Controls.Add(Me.para)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mensaje)
        Me.Name = "skype"
        Me.Text = "skype"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mensaje As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents para As System.Windows.Forms.TextBox
    Friend WithEvents cel As System.Windows.Forms.TextBox
End Class
