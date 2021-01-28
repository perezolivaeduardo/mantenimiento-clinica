Public Class Lista_de_Trabajo

   

    Public Sub reporte_individual(ByVal id As Integer)
        'TODO: esta línea de código carga datos en la tabla 'mantenimientoDataSet.sql_reportes' Puede moverla o quitarla según sea necesario.
        Me.sql_reportesTableAdapter.FillBypendientes(Me.mantenimientoDataSet.sql_reportes, id)
        Me.ReportViewer1.RefreshReport()
    End Sub
    Public Sub todos_los_pendientes()
        'TODO: esta línea de código carga datos en la tabla 'mantenimientoDataSet.sql_reportes' Puede moverla o quitarla según sea necesario.
        Me.sql_reportesTableAdapter.FillBytodos_los_pendientes(Me.mantenimientoDataSet.sql_reportes)
        Me.ReportViewer1.RefreshReport()
        If My.Settings.imprimir_directo Then
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
            lr.ReportPath = "hojadetrabajo.rdlc"
            deviceInfo = "<DeviceInfo><SimplePageHeaders>True</SimplePageHeaders></DeviceInfo>"
            bytes = ReportViewer1.LocalReport.Render("pdf", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            Dim fs As New System.IO.FileStream(filepdf, System.IO.FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
        End If
    End Sub

    Public Sub pendientes_voBo(ByVal area As String, status As Integer)
        'TODO: esta línea de código carga datos en la tabla 'mantenimientoDataSet.sql_reportes' Puede moverla o quitarla según sea necesario.
        Me.sql_reportesTableAdapter.FillByAreayStatus(Me.mantenimientoDataSet.sql_reportes, area, status)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub pendientes_por_usuario(ByVal id As Integer)
        'TODO: esta línea de código carga datos en la tabla 'mantenimientoDataSet.sql_reportes' Puede moverla o quitarla según sea necesario.
        Me.sql_reportesTableAdapter.FillBypendientes(Me.mantenimientoDataSet.sql_reportes, id)
        Me.ReportViewer1.RefreshReport()
        If My.Settings.imprimir_directo Then
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
            lr.ReportPath = "hojadetrabajo.rdlc"
            deviceInfo = "<DeviceInfo><SimplePageHeaders>True</SimplePageHeaders></DeviceInfo>"
            bytes = ReportViewer1.LocalReport.Render("pdf", deviceInfo, mimeType, encoding, extension, streamids, warnings)
            Dim fs As New System.IO.FileStream(filepdf, System.IO.FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
        End If
    End Sub
    
End Class