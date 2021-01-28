Public Class programar_ruitnas

    Private Sub calendario_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs)

    End Sub

    Private Sub fecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles fecha.ValueChanged
        dia.Text = fecha.Value.DayOfWeek
    End Sub

    Private Sub kdia_ValueChanged(sender As System.Object, e As System.EventArgs) Handles kdia.ValueChanged
        resultado.Text = siguiente_dia(fecha.Value, kdia.Value)
    End Sub

    Private Sub programar_ruitnas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.rutinas' Puede moverla o quitarla según sea necesario.
        Me.RutinasTableAdapter.Fill(Me.MantenimientoDataSet.rutinas)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.rutinas_programacion' Puede moverla o quitarla según sea necesario.
        Me.Rutinas_programacionTableAdapter.Fill(Me.MantenimientoDataSet.rutinas_programacion)
        'TODO: esta línea de código carga datos en la tabla 'MantenimientoDataSet.sql_rutinas' Puede moverla o quitarla según sea necesario.
        Me.Sql_rutinasTableAdapter.Fill(Me.MantenimientoDataSet.sql_rutinas)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Me.calendario.BoldedDates = New System.DateTime() _
                     {New System.DateTime(2018, 4, 1, 0, 0, 0, 0), _
                      New System.DateTime(2018, 4, 8, 0, 0, 0, 0), _
                      New System.DateTime(2018, 4, 15, 0, 0, 0, 0), _
                      New System.DateTime(2018, 4, 22, 0, 0, 0, 0), _
                      New System.DateTime(2018, 4, 29, 0, 0, 0, 0), _
                      New System.DateTime(2018, 5, 6, 0, 0, 0, 0)}

    End Sub

    Private Sub Sql_rutinasDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Sql_rutinasDataGridView.CellClick
        ufecha.Text = ultima_fecha(Id_rutinaTextBox.Text)

        If Id_tipoTextBox.Text = "0" Then ' diario
            txtsiguiente.Text = CDate(ufecha.Text).AddDays(1)
        End If

        If Id_tipoTextBox.Text = "1" Then
            txtsiguiente.Text = siguiente_dia(ufecha.Text, NdiaTextBox.Text)
        End If


    End Sub
End Class