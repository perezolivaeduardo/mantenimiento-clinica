Public Class boleta

    Private Sub boleta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Public Sub mandar_boleta(ByVal id As Integer, ByVal email As String)
        'TODO: esta línea de código carga datos en la tabla 'mantenimientoDataSet.sql_reportes' Puede moverla o quitarla según sea necesario.
        Me.sql_reportesTableAdapter.FillByid(Me.mantenimientoDataSet.sql_reportes, id)
        Me.ReportViewer1.RefreshReport()
        Dim file As String
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Temp
        file = path + "\boleta" + Format(id, "0000") + ".pdf"

        Dim asunto As String
        asunto = "REQUISICION DE MANTENIMIENTO #" + Format(id, "0000")

        '===============================================================================================
        ' GENERA EL PDF DEL ARCHIVO
        '===============================================================================================
        Dim warnings As Microsoft.Reporting.WinForms.Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim deviceInfo As String
        Dim bytes As Byte()
        Dim lr As New Microsoft.Reporting.WinForms.LocalReport
        lr.ReportPath = "boleta.rdlc"

        deviceInfo = "<DeviceInfo><SimplePageHeaders>True</SimplePageHeaders></DeviceInfo>"
        bytes = ReportViewer1.LocalReport.Render("pdf", deviceInfo, mimeType, encoding, extension, streamids, warnings)
        Dim fs As New System.IO.FileStream(file, System.IO.FileMode.Create)
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()
        If mandar_reporte(email, asunto, "Se anexa Hoja de Requisicion", file) = True Then
            MsgBox("Mensaje Enviado")
        Else
            MsgBox("No se envio!!!", MsgBoxStyle.Exclamation)
        End If

        Me.Close()
    End Sub

    Public Sub mandar_seguimiento(ByVal id As Integer, ByVal email As String, ByVal comentario As String)
        'TODO: esta línea de código carga datos en la tabla 'mantenimientoDataSet.sql_reportes' Puede moverla o quitarla según sea necesario.
        Me.sql_reportesTableAdapter.FillByid(Me.mantenimientoDataSet.sql_reportes, id)
        Me.ReportViewer1.RefreshReport()
        Dim file As String
        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Temp
        file = path + "\boleta" + Format(id, "0000") + ".pdf"

        Dim asunto As String
        asunto = " SEGUIMIENTO AL REPORTE #" + Format(id, "0000")

        '===============================================================================================
        ' GENERA EL PDF DEL ARCHIVO
        '===============================================================================================
        Dim warnings As Microsoft.Reporting.WinForms.Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim deviceInfo As String
        Dim bytes As Byte()
        Dim lr As New Microsoft.Reporting.WinForms.LocalReport
        lr.ReportPath = "boleta.rdlc"

        deviceInfo = "<DeviceInfo><SimplePageHeaders>True</SimplePageHeaders></DeviceInfo>"
        bytes = ReportViewer1.LocalReport.Render("pdf", deviceInfo, mimeType, encoding, extension, streamids, warnings)
        Dim fs As New System.IO.FileStream(file, System.IO.FileMode.Create)
        fs.Write(bytes, 0, bytes.Length)
        fs.Close()
        If mandar_reporte(email, asunto, comentario, file) = True Then
            MsgBox("Mensaje Enviado")
        Else
            MsgBox("No se envio!!!", MsgBoxStyle.Exclamation)
        End If

        Me.Close()
    End Sub

End Class