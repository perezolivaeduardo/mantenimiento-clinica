'Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.Odbc

Module mysql_sdk
    'Public cadenadeconexion As String = "DSN=swooxadmin"
    Public cadenadeconexion As String = "Driver={MySQL ODBC 3.51 Driver};option=3;port=3306;server=swoox.com.mx;uid=swooxcom_movil;pwd=integral2015;database=swooxcom_fotos"

    Public conexion As OdbcConnection
    Public query As String
    Public query2 As String

    Public ds As DataSet
    Public dt As DataTable
    Public dr As Odbc.OdbcDataReader

    Public Function Conectar() As Boolean
        conexion = New OdbcConnection
        conexion.ConnectionString = cadenadeconexion
        Try
            conexion.Open()
            If conexion.State = ConnectionState.Open Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            escribe_log("Abrir Conexion SWOOX", ex.Message)
            Debug.Print(ex.ToString)
            Return False

        End Try


    End Function

    Public Sub desconectar()
        Try
            conexion.Close()
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub

    Public Function leer_fotos(ByVal id As Integer) As DataRow
        'Dim sql = "select * from clientes where id =" + id.ToString
        'Try
        '    swleer_cliente = leer_swoox(sql).Rows(0)
        'Catch ex As Exception
        '    swleer_cliente = Nothing
        'End Try

        'Clipboard.SetText(sql)
    End Function

    Public Function leer(ByVal sql As String) As OdbcDataReader
        Dim comando As New OdbcCommand
        comando.Connection = conexion
        comando.CommandText = sql
        Dim lector As OdbcDataReader
        Try
            lector = comando.ExecuteReader
        Catch ex As Exception
            lector = Nothing
        End Try
        Return lector
    End Function

    Public Function leer_swoox(ByVal sql As String) As DataTable

        If Conectar() = False Then
            ' MsgBox("No se pudo Conectar a servidor SWOOX")
            Return Nothing
            Exit Function
        End If
        Dim cmd As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter

        cmd.Connection = conexion
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text

        da.SelectCommand = cmd
        dt = New DataTable
        da = New Odbc.OdbcDataAdapter(cmd)
        Try
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dt
    End Function

    Public Function mysql_cmd(ByVal sql As String) As Boolean
        If Conectar() = False Then
            MsgBox("No se pudo Conectar a servidor SWOOX")
            mysql_cmd = False
        End If
        Dim cmd As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter

        cmd.CommandText = sql
        cmd.Connection = conexion
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        mysql_cmd = True
    End Function

    Public Function mysql_insertar_codigo(ByVal codigo As String,
                                           ByVal iduser As Integer,
                                           ByVal tipo As Integer,
                                           ByVal descuento As Integer)
        Dim sql As String
        sql = "INSERT INTO `tb_codigos`(`codigo`, `usado`, `id_usuario`,`tipo`,`descuento`) VALUES ('[codigo]',0,'[usuario]','[tipo]','[descuento]')"
        sql = sql.Replace("[codigo]", codigo)
        sql = sql.Replace("[usuario]", iduser)
        sql = sql.Replace("[tipo]", tipo)
        sql = sql.Replace("[descuento]", descuento.ToString)

        'If Conectar() = False Then
        '    MsgBox("No se pudo Conectar a servidor SWOOX")
        '    Return False
        'End If

        Dim cmd As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter

        cmd.CommandText = sql
        cmd.Connection = conexion
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        mysql_insertar_codigo = True

    End Function

    Public Function mysql_insert_seguimiento(ByVal idcli_swoox As Integer,
                                             ByVal id_user As Integer, _
                                             ByVal id_suceso As Integer, _
                                             ByVal descripcion As String, _
                                             ByVal cfecha As Date, _
                                             ByVal chora As String, _
                                                    Optional ByVal duracion As String = "00:00") As Boolean
        Dim sql As String
        Dim id As Integer
        Dim rcerrado As String = 0
        If id_suceso > 6 And id_suceso < 10 Then rcerrado = "1" 'pone cerrados los seguimientos automaticos
        'determina siguiente id de seguimieto
        id = leer_swoox("SELECT MAX( id ) +1 FROM  `tb_seguimientos` ").Rows(0).Item(0)

        sql = "INSERT INTO `tb_seguimientos`(`id`, `id_cliente`, `id_user`, `id_suceso`, `id_tipo`, `fecha`, `descripcion`, `cita_fecha`, `cita_hora`, `duracion`, `cerrado`) " _
        & "VALUES ([id],[id_cli],[id_user],[id_suceso], '0','[fecha]','[descripcion]','[cfecha]','[chora]','[cdura]','[cerrado]')"
        sql = sql.Replace("[id]", id)
        sql = sql.Replace("[id_cli]", idcli_swoox)
        sql = sql.Replace("[id_user]", id_user)
        sql = sql.Replace("[id_suceso]", id_suceso)
        sql = sql.Replace("[fecha]", Format(Date.Now, "yyyyMMdd"))
        sql = sql.Replace("[descripcion]", descripcion)
        sql = sql.Replace("[cfecha]", Format(cfecha, "yyyyMMdd"))
        sql = sql.Replace("[chora]", chora)
        sql = sql.Replace("[cdura]", duracion)
        sql = sql.Replace("[cerrado]", rcerrado)

        If Conectar() = False Then
            MsgBox("No se pudo Conectar a servidor SWOOX")
            mysql_insert_seguimiento = False
        End If

        Dim cmd As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter

        cmd.CommandText = sql
        cmd.Connection = conexion
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        mysql_insert_seguimiento = True

    End Function

    Public Function mysql_fotos() As DataTable
        Dim sql As String
        sql = "SELECT id,descripcion,estatus FROM fotos_reportes "
        mysql_fotos = leer_swoox(sql)
    End Function

    Public Function fotos_cambia_status(ByVal id As Integer, ByVal estatus As Integer) As Boolean
        Dim sql As String
        sql = "update fotos_reportes SET estatus=[estatus] where id=[id]"
        sql = sql.Replace("[estatus]", estatus.ToString)
        sql = sql.Replace("[id]", id.ToString)
        Return mysql_cmd(sql)
    End Function
    Function Extraerfoto(ByVal id As String) As Byte()
        Dim Cnx As New SqlClient.SqlConnection(My.Settings.mantenimientoConnectionString)
        Try
            Dim sql As String = "Select foto From fotos_reportes Where id = '[ID]' "
            sql = sql.Replace("[ID]", id)
            Dim Command As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim cmd As New Odbc.OdbcCommand
            cmd.CommandText = Sql
            cmd.Connection = conexion
            cmd.CommandText = Sql
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()

            Cnx.Open()
            Dim MyPhoto() As Byte = CType(cmd.ExecuteScalar(), Byte())
            Cnx.Close()
            Return MyPhoto
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try

    End Function

    Public Function mysql_detalle_resumen() As DataTable
        Dim sql, fe As String
        sql = "SELECT tb_seguimientos.id_user as usr,tb_users.name as Vendedor,tb_sucesos.Descripcion as Tarea,count(tb_seguimientos.id_cliente) as '#' FROM tb_seguimientos INNER JOIN tb_sucesos ON tb_seguimientos.id_suceso = tb_sucesos.id_suceso " _
        & " INNER JOIN tb_users ON tb_seguimientos.id_user = tb_users.id_user where tb_seguimientos.cerrado=0 and tb_seguimientos.cita_fecha<='[fecha]' group by tb_users.name,   tb_sucesos.Descripcion"
        fe = Format(Now.Date, "yyyyMMdd")
        sql = sql.Replace("[fecha]", fe)
        mysql_detalle_resumen = leer_swoox(sql)
    End Function

    Public Function mysql_seguimientos_pendietes() As DataTable
        Dim sql, fe As String
        sql = "SELECT tb_seguimientos.id_user as usr,tb_seguimientos.id,tb_sucesos.icono,tb_seguimientos.id_cliente as IDC," _
        & " clientes.empresa, clientes.nombre, tb_sucesos.Descripcion as seguimiento, " _
        & " tb_seguimientos.fecha,tb_seguimientos.descripcion,tb_seguimientos.cita_fecha " _
        & " FROM tb_seguimientos INNER JOIN tb_sucesos ON tb_seguimientos.id_suceso = tb_sucesos.id_suceso " _
        & " INNER JOIN clientes ON tb_seguimientos.id_cliente = clientes.id " _
        & " where tb_seguimientos.cerrado=0 and tb_seguimientos.cita_fecha<='[fecha]' "
        fe = Format(Now.Date, "yyyyMMdd")
        sql = sql.Replace("[fecha]", fe)
        mysql_seguimientos_pendietes = leer_swoox(sql)
    End Function

    Public Function mysql_seguimientos_x_cliente(ByVal id As Integer) As DataTable
        Dim sql, fe As String
        sql = "SELECT tb_seguimientos.id,tb_seguimientos.id_user,tb_seguimientos.id_cliente,tb_sucesos.icono," _
        & " tb_sucesos.Descripcion as seguimiento, " _
        & " tb_seguimientos.fecha as fecha_registro,tb_seguimientos.descripcion,tb_seguimientos.cita_fecha as fecha,tb_seguimientos.cita_hora as hora,tb_seguimientos.cerrado " _
        & " FROM tb_seguimientos INNER JOIN tb_sucesos ON tb_seguimientos.id_suceso = tb_sucesos.id_suceso " _
        & " INNER JOIN clientes ON tb_seguimientos.id_cliente = clientes.id " _
        & " where clientes.id_sae = " + id.ToString
        fe = Format(Now.Date, "yyyyMMdd")
        sql = sql.Replace("[fecha]", fe)
        mysql_seguimientos_x_cliente = leer_swoox(sql)
    End Function

    Public Function mysql_acutualiza_agente(ByVal id_cliente As Integer, ByVal id_vendedor As Integer) As Boolean
        Dim sql As String

        sql = "update clientes SET id_user=[id_user] where id_sae=[id_sae]"
        sql = sql.Replace("[id_user]", id_vendedor.ToString)
        sql = sql.Replace("[id_sae]", id_cliente.ToString)
        Return mysql_cmd(sql)
    End Function

    Public Function sw_actualiza_id_sae(ByVal id_sia As Integer, ByVal id_woox As Integer)
        Dim sql As String
        sql = "update clientes SET id_sae=[id_sae] where id=[id_woox]"
        sql = sql.Replace("[id_sae]", id_sia.ToString)
        sql = sql.Replace("[id_woox]", id_woox.ToString)
        Return mysql_cmd(sql)
    End Function
    Public Function sw_actualiza_fiscales(ByVal id_woox As Integer, _
                                          ByVal razon As String, _
                                          ByVal rfc As String)
        Dim sql As String
        sql = "update clientes SET fiscal_razon='[razon]', fical_rfc='[rfc]' " _
        & " where id=[id_woox]"
        sql = sql.Replace("[id_woox]", id_woox.ToString)
        sql = sql.Replace("[razon]", razon)
        sql = sql.Replace("[rfc]", rfc)
        Return mysql_cmd(sql)
    End Function

    Public Function sw_nuevo_cliente(ByVal id As Integer) As Integer
        'Dim dr, drv As DataRow
        'dr = leer_cliente(id)


        'Dim sql As String
        'sql = "INSERT INTO `clientes`(`id`, `nombre`, `empresa`, `sexo`, `email`, `telefono1`, `extencion`, `telefono2`, `movil`, `Pagina_WEB`, `puesto`, `zona`, `pais`, `estado`, `ciudad`, `colonia`, `direccion`, `cp`, `Origen`, `Comentarios`, `Estatus`, `Fecha_Ult_cotizacion`, `Importe_Cotizacion`, `Fecha_Ult_Pedido`, `Importe_Pedido`, `fecha_Ult_Compra`, `Importe_Compra`, `Facturas_Vencidas`, `Importe_Vencido`, `Adeudo_total`, `id_user`, `fiscal_razon`, `fical_rfc`, `fiscal_direccion`, `fiscal_colonia`, `fiscal_ciudad`, `fiscal_municipio`, `fiscal_estado`, `fiscal_cp`, `fiscal_email`, `giro`, `nivel`, `id_origen`, `lat`, `lng`, `id_sae`, `depurado`, `seguimientos`) " _
        '& "VALUES ([id],'[nombre]','[empresa]','','[email]','[telefono1]','','','','[pagina_web]','','','México','[estado]','[ciudad]', " _
        '& "'[colonia]','[direccion]','[cp]',0,'',0,'',0,'',0,'',0,0,0,0,'[id_user]','[fiscal-razon]','[fiscal-rfc]','[fiscal-direccion]'," _
        '& "'[fiscal-colonia]','[fiscal-ciudad]','[fiscal-municipio]','[fiscal-estado]','[fiscal-cp]','[fiscal-email]','',0,1,0,0,'[value-id-sae]',0,0)"

        'sql = sql.Replace("[id]", id)
        'sql = sql.Replace("[nombre]", dr("nombre"))
        'sql = sql.Replace("[empresa]", fn_null(dr("comercial")))
        'sql = sql.Replace("[email]", fn_null(dr("MAIL")))
        'sql = sql.Replace("[telefono1]", fn_null(dr("telefono")))
        'sql = sql.Replace("[pagina_web]", fn_null(dr("pag_web")))
        'sql = sql.Replace("[estado]", fn_null(dr("estado")))
        'sql = sql.Replace("[ciudad]", fn_null(dr("localidad")))
        'sql = sql.Replace("[colonia]", fn_null(dr("colonia")))
        'sql = sql.Replace("[direccion]", fn_null(dr("calle")))
        'sql = sql.Replace("[cp]", fn_null(dr("codigo")))
        'sql = sql.Replace("[id_user]", usuario.id_swoox)
        'sql = sql.Replace("[fiscal-razon]", fn_null(dr("nombre")))
        'sql = sql.Replace("[fiscal-rfc]", fn_null(dr("rfc")))
        'sql = sql.Replace("[fiscal-direccion]", fn_null(dr("calle")))
        'sql = sql.Replace("[fiscal-colonia]", fn_null(dr("colonia")))
        'sql = sql.Replace("[fiscal-ciudad]", fn_null(dr("localidad")))
        'sql = sql.Replace("[fiscal-municipio]", fn_null(dr("municipio")))
        'sql = sql.Replace("[fiscal-estado]", fn_null(dr("estado")))
        'sql = sql.Replace("[fiscal-cp]", fn_null(dr("codigo")))
        'sql = sql.Replace("[fiscal-email]", fn_null(dr("MAIL")))
        'sql = sql.Replace("[value-id-sae]", fn_null(id))

        'If Conectar() = False Then
        '    MsgBox("No se pudo Conectar a servidor SWOOX")
        '    sw_nuevo_cliente = False
        'End If

        'Dim cmd As New Odbc.OdbcCommand
        'Dim da As New Odbc.OdbcDataAdapter
        'Try
        '    cmd.CommandText = sql
        '    cmd.Connection = conexion
        '    cmd.CommandText = sql
        '    cmd.CommandType = CommandType.Text
        '    cmd.ExecuteNonQuery()
        '    sw_nuevo_cliente = True
        'Catch ex As Exception
        '    sw_nuevo_cliente = False
        'End Try





    End Function

    Public Function fn_CalculaDistancia _
        (ByVal latitud1 As Decimal, ByVal longitud1 As Decimal, ByVal latitud2 As Decimal, ByVal longitud2 As Decimal, _
        ByVal unidad_metrica As String) As Decimal

        'Unidad Metrica: K=kilometros  M=millas 
        Dim distancia As Decimal

        '--Radio de la tierra según WGS84
        Dim radius As Decimal = 6378.137

        Dim deg2radMultiplier As Decimal = Math.PI / 180
        latitud1 = latitud1 * deg2radMultiplier
        longitud1 = longitud1 * deg2radMultiplier
        latitud2 = latitud2 * deg2radMultiplier
        longitud2 = longitud2 * deg2radMultiplier

        Dim dlongitud As Decimal = longitud2 - longitud1

        distancia = Math.Acos(Math.Sin(latitud1) * Math.Sin(latitud2) + Math.Cos(latitud1) * Math.Cos(latitud2) * Math.Cos(dlongitud)) * radius

        If unidad_metrica = "M" Then distancia = distancia * 1000
        Return distancia

    End Function
    Public Sub escribe_log(ByVal titulo As String, ByVal log As String)
        titulo += " : " + Now.ToString
        My.Computer.FileSystem.WriteAllText(logfile, titulo, True)
        My.Computer.FileSystem.WriteAllText(logfile, log, True)
    End Sub
End Module
