Imports System.IO
Imports System.Text

Module sdk
    Public usuario As New mi_usuario
    Public email_mantenimiento As String = "mantenimiento@clinicaesperanza.com.mx"
    Public fileini As String
    Public filepdf As String
    Public mi_compu As String = "MATRIX"

    Structure mi_usuario
        Dim id As Integer
        Dim nick As String
        Dim nombre As String
        Dim perfil As Integer
        Dim email As String
        Dim skype As String
        Dim depto As Integer
    End Structure

    Function leer_tabla(ByVal cmd As String) As DataTable
        Dim da As New SqlClient.SqlDataAdapter
        Dim tbl As New DataTable
        Dim cs As String = My.Settings.mantenimientoConnectionString
        da = New Data.SqlClient.SqlDataAdapter(cmd, cs)
        Dim commandbuilder As New Data.SqlClient.SqlCommandBuilder(da)
        da.Fill(tbl)
        leer_tabla = tbl

    End Function

    Function acc_leer_tabla(ByVal sql As String) As DataTable


        Dim da As New OleDb.OleDbDataAdapter
        Dim tbl As New DataTable
        Dim cs As String = My.Settings.clinicaConnectionString
        da = New Data.OleDb.OleDbDataAdapter(sql, cs)
        da.Fill(tbl)
        acc_leer_tabla = tbl
    End Function

    Function acc_comando(ByVal cmd As String) As Boolean
        Try
            Using conection As New OleDb.OleDbConnection(My.Settings.clinicaConnectionString) 'SqlClient.SqlConnection(My.Settings.catalogosCS)
                conection.Open()
                Dim AdaptadorDeDatos As New OleDb.OleDbDataAdapter  'Data.SqlClient.SqlDataAdapter
                Dim Command As OleDb.OleDbCommand = New OleDb.OleDbCommand(cmd, conection)  'New Data.SqlClient.SqlCommand(cmd, conection)
                AdaptadorDeDatos.UpdateCommand = Command
                AdaptadorDeDatos.UpdateCommand.ExecuteNonQuery()
                AdaptadorDeDatos.Dispose()
                acc_comando = True
            End Using
        Catch ex As Exception
            MsgBox("No se aplico comando " + cmd)
            MsgBox(ex.Message)
            acc_comando = False
        End Try

    End Function

    Enum perfil As Integer
        persona
        administrador
        personal_manetenimineto
        supervisor
        gerente
        usuario
    End Enum

    Enum funciones As Integer
        dummy
        registrarReporte
        AsignarReporte
        RegistrarActividades
        CerrarReporte
        CancelarReporte
        ImprimirReporte
        darSeguimiento
        ImprimirPendientes
        VoBo
    End Enum

    Public Sub inicializa()

        filepdf = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "reporte.pdf"


    End Sub

    Public Function fn_existe(ByVal file As String) As Boolean
        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists(file)
        fn_existe = fileExists

    End Function

    Public Function tiene_permiso(ByVal id As Integer, ByVal funcion As Integer)
        Dim tiene As Boolean, sql As String
        sql = "select permiso from permisos where id_usuario=[ID] and id_funcion=[FUNCION]"
        sql = sql.Replace("[ID]", id.ToString)
        sql = sql.Replace("[FUNCION]", funcion.ToString)
        Try
            tiene = leer_tabla(sql).Rows(0).Item(0)
        Catch ex As Exception
            tiene = False
        End Try
        tiene_permiso = tiene
    End Function

    Public Function pendientes() As Integer
        Dim sql As String = "SELECT COUNT(reportes.id_servicio) AS pendientes FROM reportes INNER JOIN status ON reportes.estatus = status.id_status WHERE status.GRUPO = 0"
        pendientes = leer_tabla(sql).Rows(0).Item(0)
    End Function

    Public Function primero_del_mes(ByVal fecha As Date) As Date
        Return DateSerial(fecha.Year, fecha.Month, 1)
    End Function

    Public Function siguiente_dia(ByVal fecha As Date, ByVal dia As Integer) As Date
        'Busca el siguiente dia de la semana, determinando primero el dia anterior  a la fecha
        ' p.ej. si es jueves y ando buscando el miercoles, primero determina cual es el dia imediato anterior y luego le suma 7
        Dim dia_de_fecha As Integer = fecha.DayOfWeek
        Dim siguiente_dia_x As Integer = 7

        siguiente_dia_x = 7 - (dia_de_fecha - dia)

        If dia > dia_de_fecha Then
            siguiente_dia_x -= 7
        End If
        Return fecha.AddDays(siguiente_dia_x)
    End Function

    Public Function ultima_fecha(ByVal id As Integer) As Date
        Dim sql As String, ufecha As Date
        sql = "SELECT MAX(fecha) AS fecha FROM rutinas_programacion WHERE  id_rutina = @id"
        sql = sql.Replace("@id", id.ToString)
        Try
            ufecha = leer_tabla(sql).Rows(0).Item(0)
        Catch ex As Exception
            ufecha = Now.Date.AddDays(-1)
        End Try
        Return ufecha

    End Function

End Module
