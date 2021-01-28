Module sdk_mail
    Public smtp As New cartero
    Public Cr As String = Microsoft.VisualBasic.Chr(13)
    Public Lf As String = Microsoft.VisualBasic.Chr(10)

    Function buzon() As cartero
        buzon.servidor = "clinicaesperanza.com.mx"
        buzon.user = "facturacion@clinicaesperanza.com.mx"
        buzon.pw = "hope"
        buzon.puerto = 26
        buzon.email = "facturacion@clinicaesperanza.com.mx"

        'buzon.servidor = "programacionintegral.com"
        'buzon.user = "clinicaesperanza@programacionintegral.com"
        'buzon.pw = "integral"
        'buzon.puerto = 26
        'buzon.email = "clinicaesperanza@programacionintegral.com"



    End Function

    Function buzon_solicitud() As cartero
        buzon_solicitud.servidor = "clinicaesperanza.com.mx"
        buzon_solicitud.user = "honorarios@clinicaesperanza.com.mx"
        buzon_solicitud.pw = "Hope2014"
        buzon_solicitud.puerto = 26
        buzon_solicitud.email = "honorarios@clinicaesperanza.com.mx"
    End Function

    Function buzon_soporte() As cartero
        buzon_soporte.servidor = "clinicaesperanza.com.mx"
        buzon_soporte.user = "soporte@clinicaesperanza.com.mx"
        buzon_soporte.pw = "Hope2014"
        buzon_soporte.puerto = 26
        buzon_soporte.email = "soporte@clinicaesperanza.com.mx"
    End Function


    Structure cartero
        Dim servidor As String
        Dim user As String
        Dim pw As String
        Dim email As String
        Dim puerto As String
    End Structure

    Public Function mandar_correo(ByVal para As String, ByVal asunto As String, ByVal mensaje As String, ByVal attach As String) As Boolean
        smtp = buzon()
        Dim message As New Net.Mail.MailMessage(smtp.email, para, asunto, mensaje)
        Dim emailClient As New Net.Mail.SmtpClient(smtp.servidor, smtp.puerto)
        emailClient.Credentials = New Net.NetworkCredential(smtp.user, smtp.pw)
        If attach.Length > 0 Then
            Dim attachement As New System.Net.Mail.Attachment(attach)
            message.Attachments.Add(attachement)
        End If


        Try
            emailClient.Send(message)
            mandar_correo = True
            Exit Function
        Catch ex As Exception
            MsgBox(ex.Message)
            mandar_correo = True
        End Try
        mandar_correo = False
    End Function

    Public Function mandar_soporte(ByVal para As String, ByVal asunto As String, ByVal mensaje As String, ByVal attach As String) As Boolean
        smtp = buzon_soporte()
        Dim message As New Net.Mail.MailMessage(smtp.email, para, asunto, mensaje)
        Dim emailClient As New Net.Mail.SmtpClient(smtp.servidor, smtp.puerto)
        emailClient.Credentials = New Net.NetworkCredential(smtp.user, smtp.pw)
        If attach.Length > 0 Then
            Dim attachement As New System.Net.Mail.Attachment(attach)
            message.Attachments.Add(attachement)
        End If

        Try
            emailClient.Send(message)
            mandar_soporte = True
            Exit Function
        Catch ex As Exception
            MsgBox(ex.Message)
            mandar_soporte = True
        End Try
        mandar_soporte = False
    End Function

    'Función que comprueba si una diección de email es válida
    '*********************************************************************************
    Public Function Validar_Email(ByVal Email As String) As Boolean

        Dim i As Integer, iLen As Integer, caracter As String
        Dim pos As Integer, bp As Boolean, iPos As Integer, iPos2 As Integer

        On Error GoTo Err_Sub

        Email = Trim$(Email)

        If Email = vbNullString Then
            Exit Function
        End If

        Email = LCase$(Email)
        iLen = Len(Email)


        For i = 1 To iLen
            caracter = Mid(Email, i, 1)

            If (Not (caracter Like "[a-z]")) And (Not (caracter Like "[0-9]")) Then

                If InStr(1, "_-" & "." & "@", caracter) > 0 Then
                    If bp = True Then
                        Exit Function
                    Else
                        bp = True

                        If i = 1 Or i = iLen Then
                            Exit Function
                        End If

                        If caracter = "@" Then
                            If iPos = 0 Then
                                iPos = i
                            Else

                                Exit Function
                            End If
                        End If
                        If caracter = "." Then
                            iPos2 = i
                        End If

                    End If
                Else

                    Exit Function
                End If
            Else
                bp = False
            End If
        Next i
        If iPos = 0 Or iPos2 = 0 Then
            Exit Function
        End If

        If iPos2 < iPos Then
            Exit Function
        End If


        Validar_Email = True

        Exit Function
Err_Sub:
        On Error Resume Next
        Validar_Email = False
    End Function

    Public Function mandar_reporte(ByVal para As String, ByVal asunto As String, ByVal mensaje As String, ByVal attach As String) As Boolean
        smtp = buzon_soporte()
        Dim message As New Net.Mail.MailMessage(smtp.email, para, asunto, mensaje)
        Dim emailClient As New Net.Mail.SmtpClient(smtp.servidor, smtp.puerto)
        emailClient.Credentials = New Net.NetworkCredential(smtp.user, smtp.pw)
        If attach.Length > 0 Then
            Dim attachement As New System.Net.Mail.Attachment(attach)
            message.Attachments.Add(attachement)
        End If

        Try
            emailClient.Send(message)
            mandar_reporte = True
            Exit Function
        Catch ex As Exception
            MsgBox(ex.Message)
            mandar_reporte = True
        End Try
        mandar_reporte = False
    End Function

  


End Module
