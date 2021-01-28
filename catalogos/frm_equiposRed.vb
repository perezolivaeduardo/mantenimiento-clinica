Imports Microsoft.Win32
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class frm_equiposRed

    Private Sub Equipos_redBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.Equipos_redBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)

    End Sub

    Private Sub frm_equiposRed_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.equipos_red' Puede moverla o quitarla según sea necesario.
        Me.Equipos_redTableAdapter.Fill(Me.MantenimientoDataSet.equipos_red)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        With OpenFileDialog
            .InitialDirectory = ""
            .FileName = "Todos los Archivos"
            .Filter = "Todos los Archivos|*.*|JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*.bmp"
            .FilterIndex = 2
        End With
        If OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With foto
                .Image = Image.FromFile(OpenFileDialog.FileName)
                .SizeMode = PictureBoxSizeMode.CenterImage
                .BorderStyle = BorderStyle.Fixed3D
                '.................................
            End With
        End If
    End Sub

    Private Sub Btn_actualizar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_actualizar.Click
        Dim id As String
        id = Equipos_redDataGridView.CurrentRow.Cells(0).Value
        save_foto_red(foto.Image, id)
    End Sub


    Private Sub Equipos_redDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Equipos_redDataGridView.CellClick
        Try
            Dim id As String
            id = Equipos_redDataGridView.CurrentRow.Cells(0).Value
            Dim ms As New MemoryStream(ExtraerImagen_red(id))
            foto.Image = Image.FromStream(ms)
        Catch ex As Exception

        End Try

      


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar.Click
        Me.Validate()
        Me.Equipos_redBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MantenimientoDataSet)

    End Sub

   
End Class