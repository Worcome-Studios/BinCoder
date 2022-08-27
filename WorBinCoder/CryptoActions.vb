Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class CryptoActions
    Public DefaultCryptoKey As String = "ACdXtioqqwMvkaoMCt44hqDcdp8vZE" 'Default Cryptography Key
    Public Shared des As New TripleDESCryptoServiceProvider
    Public Shared hashmd5 As New MD5CryptoServiceProvider

    Private Sub CryptoActions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DefaultCryptoKey = My.Settings.CryptoKey
        TextBox1.Text = DefaultCryptoKey
    End Sub

#Region "Crypto"
    Sub CreatePrivateKey()
        Try
            Dim obj As New Random()
            Dim posibles As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
            Dim longitud As Integer = posibles.Length
            Dim letra As Char
            Dim longitudnuevacadena As Integer = 30
            Dim nuevacadena As String = Nothing
            For i As Integer = 0 To longitudnuevacadena - 1
                letra = posibles(obj.[Next](longitud))
                nuevacadena += letra.ToString()
            Next
            TextBox1.Text = nuevacadena
            My.Settings.CryptoKey = nuevacadena
            My.Settings.Save()
            My.Settings.Reload()
        Catch ex As Exception
            My.Settings.CryptoKey = DefaultCryptoKey
            My.Settings.Save()
            My.Settings.Reload()
            Console.WriteLine("[CryptoActions@CreatePrivateKey]Error: " & ex.Message)
        End Try
    End Sub

    Function Encriptar(ByVal texto As String) As String
        If Trim(texto) = "" Then
            Encriptar = ""
        Else
            DES.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(DefaultCryptoKey))
            DES.Mode = CipherMode.ECB
            Dim encrypt As ICryptoTransform = DES.CreateEncryptor()
            Dim buff() As Byte = UnicodeEncoding.ASCII.GetBytes(texto)
            Encriptar = Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Encriptar
    End Function

    Function Desencriptar(ByVal texto As String) As String
        If Trim(texto) = "" Then
            Desencriptar = ""
        Else
            DES.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(DefaultCryptoKey))
            DES.Mode = CipherMode.ECB
            Dim desencrypta As ICryptoTransform = DES.CreateDecryptor()
            Dim buff() As Byte = Convert.FromBase64String(texto)
            Desencriptar = UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return Desencriptar
    End Function

    Sub CallEncrypt(ByVal FileIN As String, ByVal FileOUT As String)
        Try
            Dim buffer As Byte()
            Using fs As New FileStream(FileIN, FileMode.Open, FileAccess.Read)
                Using ms As New MemoryStream()
                    Encrypt(fs, ms, My.Settings.CryptoKey)
                    buffer = ms.ToArray()
                End Using
            End Using
            Using fs As New FileStream(FileOUT, FileMode.CreateNew, FileAccess.Write)
                fs.Write(buffer, 0, buffer.Length)
            End Using
        Catch ex As Exception
            Console.WriteLine("[CryptoActions@CallEncrypt]Error: " & ex.Message)
        End Try
    End Sub
    Sub CallDecrypt(ByVal FileIN As String, ByVal FileOUT As String)
        Try
            Dim buffer As Byte() = Nothing
            Using fs As New FileStream(FileIN, FileMode.Open, FileAccess.Read)
                Using ms As New MemoryStream()
                    Decrypt(fs, ms, My.Settings.CryptoKey)
                    buffer = ms.ToArray()
                End Using
            End Using
            Using fs As New FileStream(FileOUT, FileMode.CreateNew, FileAccess.Write)
                fs.Write(buffer, 0, buffer.Length)
            End Using
        Catch ex As Exception
            Console.WriteLine("[CryptoActions@CallDecrypt]Error: " & ex.Message)
        End Try
    End Sub

    Friend Shared Sub Decrypt(inStream As Stream, outStream As Stream, pwd As String)
        Try
            Dim aes As New AesCryptoServiceProvider()
            aes.Mode = CipherMode.CFB
            aes.Key() = GetDeriveBytes(pwd, 32)
            aes.IV = GetDeriveBytes(pwd, 16)
            Dim stream As New CryptoStream(inStream, aes.CreateDecryptor(), CryptoStreamMode.Read)
            Dim length As Integer = 2048
            Dim buffer As Byte() = New Byte(length - 1) {}
            Try
                Dim i As Integer = stream.Read(buffer, 0, length)
                Do While (i > 0)
                    outStream.Write(buffer, 0, i)
                    i = stream.Read(buffer, 0, length)
                Loop
            Finally
                aes.Dispose()
                buffer = Nothing
            End Try
        Catch ex As Exception
            Console.WriteLine("[CryptoActions@Decrypt]Error: " & ex.Message)
        End Try
    End Sub
    Friend Shared Sub Encrypt(inStream As Stream, outStream As Stream, pwd As String)
        Try
            Dim aes As New AesCryptoServiceProvider()
            aes.Mode = CipherMode.CFB
            aes.Key() = GetDeriveBytes(pwd, 32)
            aes.IV = GetDeriveBytes(pwd, 16)
            Dim stream As New CryptoStream(outStream, aes.CreateEncryptor(), CryptoStreamMode.Write)
            Dim length As Integer = 2048
            Dim buffer As Byte() = New Byte(length - 1) {}
            Try
                Dim i As Integer = inStream.Read(buffer, 0, length)
                Do While (i > 0)
                    stream.Write(buffer, 0, i)
                    i = inStream.Read(buffer, 0, length)
                Loop
            Finally
                stream.FlushFinalBlock()
                aes.Dispose()
                buffer = Nothing
            End Try
        Catch ex As Exception
            Console.WriteLine("[CryptoActions@Encrypt]Error: " & ex.Message)
        End Try
    End Sub
    Friend Shared Function GetDeriveBytes(password As String, size As Integer) As Byte()
        If ((String.IsNullOrWhiteSpace(password)) OrElse (password.Length < 8)) Then
            MsgBox("Error en el Modulo 'GetDeriveBytes'" & vbCrLf & "La llave criptografica debe tener mas de 8 caracteres", MsgBoxStyle.Critical, "SystemTrail Modules")
        End If
        If ((size < 1) OrElse (size > 128)) Then
            MsgBox("Error en el Modulo 'GetDeriveBytes'" & vbCrLf & "El tamaño tiene que estar comprendido entre 1 y 128.", MsgBoxStyle.Critical, "SystemTrail Modules")
        End If
        Dim pwd As Byte() = UTF8Encoding.UTF8.GetBytes(password)
        Dim salt As Byte() = UTF8Encoding.UTF8.GetBytes(Convert.ToBase64String(pwd))
        Using bytes As New Rfc2898DeriveBytes(pwd, salt, 1000)
            ' Devolver la clave pseudoaletoria.
            Return bytes.GetBytes(size)
        End Using
    End Function
#End Region

#Region "Controles"
    Private Sub btnCrearLlave_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("¿Quiere crear una llave criptografica nueva?", "Worcome Security", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            CreatePrivateKey()
        End If
    End Sub

    Private Sub btnEncriptarFichero_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenFileIN As New OpenFileDialog
        Dim SaveFileOUT As New SaveFileDialog
        OpenFileIN.Title = "Archivo a encriptar..."
        OpenFileIN.FileName = Nothing
        OpenFileIN.Filter = "All file types|*.*"
        OpenFileIN.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        OpenFileIN.Multiselect = False
        SaveFileOUT.Title = "Guardar archivo encriptado..."
        SaveFileOUT.FileName = Nothing
        SaveFileOUT.Filter = "Text File(*.txt)|*.txt|All file types|*.*"
        SaveFileOUT.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        If OpenFileIN.ShowDialog = DialogResult.OK Then
            If SaveFileOUT.ShowDialog = DialogResult.OK Then
                SaveFileOUT.FileName = OpenFileIN.FileName + ".enc"
                CallEncrypt(OpenFileIN.FileName, SaveFileOUT.FileName)
                MsgBox("Archivo encriptado", MsgBoxStyle.Information, "Worcome Security")
            Else
                MsgBox("Debe mencionar donde quiere guardar el archivo cuando sea encriptado", MsgBoxStyle.Critical, "Worcome Security")
            End If
        Else
            MsgBox("Debe seleccionar un archivo para encriptar", MsgBoxStyle.Critical, "Worcome Security")
        End If
    End Sub

    Private Sub btnDesencriptarFichero_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OpenFileIN As New OpenFileDialog
        Dim SaveFileOUT As New SaveFileDialog
        OpenFileIN.Title = "Archivo a desencriptar..."
        OpenFileIN.FileName = Nothing
        OpenFileIN.Filter = "All file types|*.*"
        OpenFileIN.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        OpenFileIN.Multiselect = False
        SaveFileOUT.Title = "Guardar archivo desencriptado..."
        SaveFileOUT.FileName = Nothing
        SaveFileOUT.Filter = "Text File(*.txt)|*.txt|All file types|*.*"
        SaveFileOUT.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        If OpenFileIN.ShowDialog = DialogResult.OK Then
            If SaveFileOUT.ShowDialog = DialogResult.OK Then
                SaveFileOUT.FileName = OpenFileIN.FileName + ".den"
                CallDecrypt(OpenFileIN.FileName, SaveFileOUT.FileName)
                MsgBox("Archivo desencriptado", MsgBoxStyle.Information, "Worcome Security")
            Else
                MsgBox("Debe mencionar donde quiere guardar el archivo cuando sea desencriptado", MsgBoxStyle.Critical, "Worcome Security")
            End If
        Else
            MsgBox("Debe seleccionar un archivo para desencriptar", MsgBoxStyle.Critical, "Worcome Security")
        End If
    End Sub

    Private Sub btnCifrarTexto_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Width = 810
        Label2.Text = "<"
        TextBoxCifrar.Visible = True
        TextBoxDecifrar.Visible = False
        If TextBoxCifrar.Text = Nothing Then
            MsgBox("Escriba el texto a cifrar en el campo de texto", MsgBoxStyle.Information, "Worcome Security")
        Else
            Dim Texto As String = TextBoxCifrar.Text
            TextBoxCifrar.Text = Encriptar(Texto)
            MsgBox("Texto cifrado", MsgBoxStyle.Information, "Worcome Security")
        End If
    End Sub

    Private Sub btnDescifrarTexto_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Width = 810
        TextBoxDecifrar.Visible = True
        TextBoxCifrar.Visible = False
        Label2.Text = "<"
        If TextBoxDecifrar.Text = Nothing Then
            MsgBox("Escriba el texto cifrado en el campo de texto", MsgBoxStyle.Information, "Worcome Security")
        Else
            Dim Texto As String = TextBoxDecifrar.Text
            TextBoxDecifrar.Text = Desencriptar(Texto)
            MsgBox("Texto descifrado", MsgBoxStyle.Information, "Worcome Security")
        End If
    End Sub

    Private Sub btnEscribirLlave_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim TXBVR = InputBox("Escriba su propia llave criptografica", "Worcome Security", DefaultCryptoKey)
        If TXBVR = Nothing Then
            MsgBox("No se han guardado cambios", MsgBoxStyle.Information, "Worcome Security")
        Else
            My.Settings.CryptoKey = TXBVR
            DefaultCryptoKey = TXBVR
            My.Settings.Save()
            My.Settings.Reload()
            MsgBox("Lave criptografica guardada", MsgBoxStyle.Information, "Worcome Security")
            Me.Close()
        End If
    End Sub

    Private Sub LabelHideORShow_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Label2.Text = ">" Then
            Me.Width = 810
            Label2.Text = "<"
        ElseIf Label2.Text = "<" Then
            Me.Width = 360
            Label2.Text = ">"
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If TextBox1.PasswordChar = "●" Then
            TextBox1.PasswordChar = Nothing
            Label3.Text = "Hide"
        Else
            TextBox1.PasswordChar = "●"
            Label3.Text = "Show"
        End If
    End Sub
#End Region
End Class