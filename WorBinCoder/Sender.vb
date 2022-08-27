Imports System.Net.Mail
Public Class GmailSender

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MISMTP As New SmtpClient
        Dim MENSAJE As New MailMessage
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Rellene los Casilleros de Informacion")
        Else
            Try
                MENSAJE.From = New MailAddress(TextBox1.Text)
                MENSAJE.To.Add(TextBox3.Text)
                MENSAJE.Subject = TextBox4.Text
                MENSAJE.Body = RichTextBox1.Text
                MISMTP.Host = "SMTP.GMAIL.COM"
                MISMTP.EnableSsl = True
                MISMTP.Credentials = New Net.NetworkCredential(TextBox1.Text, TextBox2.Text)
                MISMTP.Send(MENSAJE)
                MsgBox("Enviado Correctamente a: " & TextBox3.Text, MsgBoxStyle.Information, "Worcome Security")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Worcome Security")
                LinkLabel1.Visible = True
            End Try
        End If
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        If TextBox2.PasswordChar = "●" Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "●"
        End If
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        About.Show()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("No hay Nada para Guardar", MsgBoxStyle.Information, "Worcome Security")
            Label8.ForeColor = Color.Red
        Else
            My.Settings.Gmail = TextBox1.Text
            My.Settings.Contraseña = TextBox2.Text
            My.Settings.Save()
            My.Settings.Reload()
            Label8.Text = "Guardado"
            Label8.ForeColor = Color.Green
        End If
    End Sub

    Private Sub Sender_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.Gmail = "" Or My.Settings.Contraseña = "" Then
            Label8.Text = "Guardar Credenciales"
            Label8.ForeColor = Color.Red
        End If
        Label8.Text = "Guardado"
        Label8.ForeColor = Color.Green
        TextBox1.Text = My.Settings.Gmail
        TextBox2.Text = My.Settings.Contraseña
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        RichTextBox1.Text = RichTextBox1.Text & vbCrLf & TextEditorDEV.FastColoredTextBox1.Text
        TextBox4.Text = TextBox4.Text & " - " & TextEditorDEV.ToolStripTextBox1.Text
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        RichTextBox1.Text = RichTextBox1.Text & vbCrLf & TextEditor.RichTextBox1.Text
        TextBox4.Text = TextBox4.Text & " - " & TextEditor.ToolStripTextBox1.Text
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://myaccount.google.com/security?utm_source=OGB#connectedapps")
        MsgBox("Dirigase a Aplicaciones Menos Seguras y vea que Este SI como Respuesta", MsgBoxStyle.Information, "Worcome Security")
    End Sub
End Class
