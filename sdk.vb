
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Module sdk
    Public usuario As New mi_usuario
    Public email_mantenimiento As String = "mantenimiento@clinicaesperanza.com.mx"
    Public fileini As String
    Public filepdf As String
    Public mi_compu As String = "MATRIX"
    Public logfile As String = "logfile.log"

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


    Function ExtraerImagen_red(ByVal id As String) As Byte()
        Dim Cnx As New SqlClient.SqlConnection(My.Settings.mantenimientoConnectionString)
        Try
            Dim SqlSelect As String = "Select foto From equipos_red Where id = '[ID]' "
            SqlSelect = SqlSelect.Replace("[ID]", id)
            Dim Command As New SqlCommand(SqlSelect, Cnx)
            Cnx.Open()
            Dim MyPhoto() As Byte = CType(Command.ExecuteScalar(), Byte())
            Cnx.Close()
            Return MyPhoto
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Function

    Function Extraer_Foto(ByVal id As String) As Byte()
        Dim Cnx As New SqlClient.SqlConnection(My.Settings.mantenimientoConnectionString)
        Try
            Dim SqlSelect As String = "Select foto From fotos Where id_imagen = '[ID]' "
            SqlSelect = SqlSelect.Replace("[ID]", id)
            Dim Command As New SqlCommand(SqlSelect, Cnx)
            Cnx.Open()
            Dim MyPhoto() As Byte = CType(Command.ExecuteScalar(), Byte())
            Cnx.Close()
            Return MyPhoto
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Function


    Public Sub save_foto_red(ByVal foto As Image, ByVal id As String)
        'cadena de conexion
        Dim conectar As New SqlConnection(My.Settings.mantenimientoConnectionString.ToString)
        conectar.Open()

        Dim ms As New MemoryStream
        foto.Save(ms, foto.RawFormat)
        Dim arrImage() As Byte = ms.GetBuffer

        'realizamos la operacion SQL 
        Dim modificar As New SqlClient.SqlCommand()
        modificar.CommandType = System.Data.CommandType.Text
        modificar.CommandText = "Update equipos_red  set foto=@imagen WHERE id = '[ID]'"
        modificar.CommandText = modificar.CommandText.Replace("[ID]", id)
        modificar.Parameters.Add(New SqlParameter("@Imagen", SqlDbType.Image)).Value = arrImage

        'reliazamos la conexion
        modificar.Connection = conectar
        Try
            If ((modificar.ExecuteNonQuery <> 0)) Then
                MsgBox("DATOS ACTUALIZADOS")
            End If
            '  Operaciones.CargarInformacion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
    Public Function fn_null(ByVal variable) As String
        fn_null = IIf(variable.Equals(DBNull.Value), "", variable)
    End Function

    Public Sub save_foto_reporte(ByVal foto As Image, ByVal id As String, id_reporte As String)
        'cadena de conexion
        Dim conectar As New SqlConnection(My.Settings.mantenimientoConnectionString.ToString)
        conectar.Open()
        Dim ms As New MemoryStream
        foto.Save(ms, foto.RawFormat)
        Dim arrImage() As Byte = ms.GetBuffer

        'realizamos la operacion SQL 
        Dim modificar As New SqlClient.SqlCommand()
        modificar.CommandType = System.Data.CommandType.Text
        modificar.CommandText = "Update fotos  set foto=@imagen WHERE id_imagen = '[ID]'"
        modificar.CommandText = modificar.CommandText.Replace("[ID]", id)
        modificar.Parameters.Add(New SqlParameter("@Imagen", SqlDbType.Image)).Value = arrImage

        'reliazamos la conexion
        modificar.Connection = conectar
        Try
            If ((modificar.ExecuteNonQuery <> 0)) Then
            End If
            '  Operaciones.CargarInformacion()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
End Module
