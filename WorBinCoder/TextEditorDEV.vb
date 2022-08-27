Public Class TextEditorDEV

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Public TECLA As String
    Dim MIASCII As String

    Private Sub TextEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Documento sin Titulo | Wor: BinCoder DEV"
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        FastColoredTextBox1.Clear()
        Me.Text = "Documento sin Titulo | Wor: BinCoder DEV"
        YaIO = False
    End Sub

    Private Sub FuenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuenteToolStripMenuItem.Click
        Try
            Dim dlg As FontDialog = New FontDialog
            dlg.Font = FastColoredTextBox1.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                FastColoredTextBox1.Font = dlg.Font
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = FastColoredTextBox1.ForeColor
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                FastColoredTextBox1.ForeColor = dlg.Color
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Try
            OpenFileDialog1.OpenFile()
            FastColoredTextBox1.Text = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName).ReadToEnd
            GuardarToolStripMenuItem.Enabled = True
            Me.Text = OpenFileDialog1.FileName & " | Wor: BinCoder DEV"
            If FastColoredTextBox1.Text.Contains("[TAG]BIN_CODER") Then
                FastColoredTextBox1.Text.Remove("[TAG]BIN_CODER")
            End If
            YaIO = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LeerToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeerToolStripMenuItem.Click
        TextEditor.NotifyIcon1.ShowBalloonTip(3, "Wor: BinCoderDEV", "Leyendo", ToolTipIcon.Info)
        Dim sapi As Object
        sapi = CreateObject("sapi.spvoice")
        sapi.speak(FastColoredTextBox1.Text)
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        Me.Text = ToolStripTextBox1.Text & " | Wor: BinCoder DEV"
    End Sub

    Private Sub TextEditorDEV_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Quiere salir de BinCoderDEV?", "Worcome Security", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            TextEditor.Show()
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    Dim YaIO As Boolean = False
    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        Try
            If YaIO = False Then
                SaveFileDialog1.FileName = "Documento sin Titulo.txt"
                SaveFileDialog1.ShowDialog()
            ElseIf YaIO = True Then
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox1.Text, False)
                My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, FastColoredTextBox1.Text, False)
                My.Settings.Save()
                My.Settings.Reload()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub HoraYFechaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HoraYFechaToolStripMenuItem.Click
        FastColoredTextBox1.AppendText(" " & (DateAndTime.Today) & "   ")
        FastColoredTextBox1.AppendText((Format(DateAndTime.TimeOfDay, "HH")) & ":")
        FastColoredTextBox1.AppendText((Format(DateAndTime.TimeOfDay, "mm") & ":"))
        FastColoredTextBox1.AppendText((Format(DateAndTime.TimeOfDay, "ss") & " "))
        FastColoredTextBox1.AppendText((Format(DateAndTime.TimeOfDay, "tt") & " "))
    End Sub

    Private Sub ToBindCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToBindCodeToolStripMenuItem.Click
        Try
            ToBindCodeToolStripMenuItem.Enabled = False
            ATeztoToolStripMenuItem.Enabled = True
            Dim CARACTERES As Char() = FastColoredTextBox1.Text.ToCharArray
            FastColoredTextBox1.Clear()
            For Each CARACTER In CARACTERES
                Dim TEXTO As Byte() = System.Text.Encoding.Unicode.GetBytes(CARACTER)
                FastColoredTextBox1.Text += Convert.ToString(TEXTO(0), 2).PadLeft(8, "0")
            Next
            SaveFileDialog1.Filter = "WorCode|*.WorCODE|Texto (.txt)|*.txt|JavaScript (.js; *.jsm)|*.js|Java Source (.java)|*.java|JavaServer (.jsp)|*.jsp|C++ (.cc; .cxx)|*.cc|C# (.cs)|*.cs|C (.c)|*.c|JSON (.json)|*.json|PHP (.php)|*.php|VisualBasic (.vb; .vbs)|*.vb; *.vbs|YAML (.yml; *.yaml)|*.yml; *.yaml|CMD (.cmd; .bat)|*.cmd; *.bat|ASP (.asp)|*.asp|CSS (.css)|*.css|MS (.ini; .inf)|*.ini; *.inf|HTML (.html)|*.html|Todos los Archivos|*.*"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ATextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ATeztoToolStripMenuItem.Click
        Try
            ToBindCodeToolStripMenuItem.Enabled = True
            ATeztoToolStripMenuItem.Enabled = False
            Dim BINARIOS As Char() = FastColoredTextBox1.Text.ToCharArray
            Dim MIARRAY(1) As Byte
            FastColoredTextBox1.Clear()
            For I = 0 To BINARIOS.Length - 8 Step 8
                Dim MIBYTE As String = BINARIOS(I) & BINARIOS(I + 1) & BINARIOS(I + 2) & BINARIOS(I + 3) & BINARIOS(I + 4) & BINARIOS(I + 5) & BINARIOS(I + 6) & BINARIOS(I + 7)
                Dim CONVERSION As String = Convert.ToInt32(MIBYTE, 2)
                MIARRAY(0) = CONVERSION
                FastColoredTextBox1.Text += System.Text.Encoding.Unicode.GetString(MIARRAY)
            Next
            SaveFileDialog1.Filter = "Todos los Archivos|*.*|Texto (.txt)|*.txt|JavaScript (.js; *.jsm)|*.js|Java Source (.java)|*.java|JavaServer (.jsp)|*.jsp|C++ (.cc; .cxx)|*.cc|C# (.cs)|*.cs|C (.c)|*.c|JSON (.json)|*.json|PHP (.php)|*.php|VisualBasic (.vb; .vbs)|*.vb; *.vbs|YAML (.yml; *.yaml)|*.yml; *.yaml|CMD (.cmd; .bat)|*.cmd; *.bat|ASP (.asp)|*.asp|CSS (.css)|*.css|MS (.ini; .inf)|*.ini; *.inf|HTML (.html)|*.html|WorCode|*.WorCode"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub VolverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        TextEditor.Show()
    End Sub

    Private Sub PersonalizadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalizadoToolStripMenuItem.Click
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Custom
    End Sub

    Private Sub CSharpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSharpToolStripMenuItem.Click
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp
    End Sub

    Private Sub VBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisualBasicToolStripMenuItem.Click
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB
    End Sub

    Private Sub SQLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SQLToolStripMenuItem.Click
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.SQL
    End Sub

    Private Sub PHPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PHPToolStripMenuItem.Click
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP
    End Sub

    Private Sub JavaScriptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JavaScriptToolStripMenuItem.Click
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS
    End Sub

    Private Sub HTMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HTMLToolStripMenuItem.Click
        FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub SenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SenderToolStripMenuItem.Click
        GmailSender.Show()
    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarComoToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, FastColoredTextBox1.Text, False)
            GuardarToolStripMenuItem.Enabled = True
            My.Settings.Save()
            My.Settings.Reload()
            YaIO = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeshacerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeshacerToolStripMenuItem.Click
        FastColoredTextBox1.Undo()
    End Sub

    Private Sub RehacerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RehacerToolStripMenuItem.Click
        FastColoredTextBox1.Redo()
    End Sub

    Private Sub ModoConsentradoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivarModoConsentradoToolStripMenuItem.Click
        If ActivarModoConsentradoToolStripMenuItem.Text = "Activar Modo Consentrado" Then
            Me.TopMost = True
            ActivarModoConsentradoToolStripMenuItem.Text = "Desactivar Modo Consentrado"
        Else
            Me.TopMost = False
            ActivarModoConsentradoToolStripMenuItem.Text = "Activar Modo Consentrado"
        End If
    End Sub

    Private Sub EnviarABinCoderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarABinCoderToolStripMenuItem.Click
        TextEditor.RichTextBox1.Text = FastColoredTextBox1.Text
        TextEditor.Show()
        TextEditor.Focus()
    End Sub
End Class