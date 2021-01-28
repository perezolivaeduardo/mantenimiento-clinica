Public Class hoja_de_mantenimiento

    Private Sub hoja_de_mantenimiento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
    End Sub
    Public Sub cargar(ByVal cuarto As String)
        'TODO: esta línea de código carga datos en la tabla 'mantenimientoDataSet.sys_tareas_preventivas' Puede moverla o quitarla según sea necesario.
        Me.sys_tareas_preventivasTableAdapter.Fill(Me.mantenimientoDataSet.sys_tareas_preventivas)


        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.EnableHyperlinks = True
        Dim rp(0 To 1) As Microsoft.Reporting.WinForms.ReportParameter
        rp(0) = New Microsoft.Reporting.WinForms.ReportParameter("FECHA", "Fecha de trabajo :" + Now.Date.ToShortDateString, False)
        rp(1) = New Microsoft.Reporting.WinForms.ReportParameter("CUARTO", cuarto, False)

        Me.ReportViewer1.LocalReport.SetParameters(rp)





        Me.ReportViewer1.RefreshReport()
    End Sub
End Class