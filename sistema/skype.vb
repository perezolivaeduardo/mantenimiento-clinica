Imports SKYPE4COMLib

Public Class skype
    '  Public WithEvents skype As New SKYPE4COMLib.Skype
    Private Sub skype_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    '    Try
    '        skype.SendMessage(para.Text, mensaje.Text)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub

    'Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
    '    Dim scel(0 To 0) As String
    '    scel(0) = cel.Text
    '    Try
    '        skype.SendSms(scel(0), cel.Text)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub

    Private Sub cel_TextChanged(sender As System.Object, e As System.EventArgs) Handles cel.TextChanged

    End Sub
End Class