Imports Microsoft.Win32
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class fotos_reportes

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Btn_agregar.Click
        If txtdescripcion.TextLength = 0 Then
            MsgBox("Escriba Una descripcion de la foto para poder asignarla.")
            Exit Sub
        End If
        Dim x() As Byte
        Dim adap As New mantenimientoDataSetTableAdapters.fotosTableAdapter
        adap.Insert(txtidreporte.Text, x, txtdescripcion.Text)
        Dim id_foto As Integer
        id_foto = adap.ultimo_id
        save_foto_reporte(imagen.Image, id_foto, txtidreporte.Text)
        MsgBox("Asignada")
        Me.Close()
    End Sub

    Private Sub dgv_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick

        Try
            Dim id As String
            id = dgv.CurrentRow.Cells(0).Value

            Dim ms As New MemoryStream(Extraerfoto(id))
            imagen.Image = Image.FromStream(ms)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub fotos_reportes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgv.DataSource = mysql_fotos()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim id As String
        id = dgv.CurrentRow.Cells(0).Value
        fotos_cambia_status(id, 1)
        dgv.DataSource = mysql_fotos()
    End Sub

    Private Sub btn_cargar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cargar.Click
        dgv.DataSource = mysql_fotos()
    End Sub
End Class