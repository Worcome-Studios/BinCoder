Imports System.IO
Public Class TextEditor
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Public TECLA As String
    Dim MIASCII As String

    Private Sub TextEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If My.Settings.OfflineMode = False Then
                AppService.StartAppService(False, False, True, False, True)
                Threading.Thread.Sleep(150)
            End If
        Catch ex As Exception
            MsgBox("ERROR CRITICO CON 'AppService'", MsgBoxStyle.Critical, "Worcome Security")
        End Try
        Try
            If Len(Command$) Then
                Dim PATH As String = Command$()
                PATH = PATH.Replace("""", "")
                If PATH.Substring(PATH.LastIndexOf(".") + 1, 3) = "txt" Or PATH.Substring(PATH.LastIndexOf(".") + 1, 3) = "rtf" Then
                    RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(PATH)
                    If RichTextBox1.Text.Contains("[TAG]BIN_CODER") Then
                        RichTextBox1.Text.Remove("[TAG]BIN_CODER")
                    End If

                Else
                    MsgBox("Error al Abrir el Archivo" & vbCrLf & "Alojado en: " & PATH, MsgBoxStyle.Critical, "Worcome Security")
                End If
            End If
        Catch ex As Exception
        End Try
        Me.Text = "Documento sin Titulo | Wor: BinCoder"
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        ToolStripTextBox1.Text = "Sin Titulo"
        RichTextBox1.Clear()
        Me.Text = "Documento sin Titulo | Wor: BinCoder"
        YaIO = False
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub FuenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuenteToolStripMenuItem.Click
        Try
            Dim dlg As FontDialog = New FontDialog
            dlg.Font = RichTextBox1.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.Font = dlg.Font
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = RichTextBox1.ForeColor
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.ForeColor = dlg.Color
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
            RichTextBox1.Text = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName).ReadToEnd
            GuardarToolStripMenuItem.Enabled = True
            ToolStripTextBox1.Text = OpenFileDialog1.FileName
            Me.Text = OpenFileDialog1.FileName & " | Wor: BinCoder"
            If RichTextBox1.Text.Contains("[TAG]BIN_CODER") Then
                RichTextBox1.Text.Remove("[TAG]BIN_CODER")
            End If
            YaIO = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarComoToolStripMenuItem.Click
        SaveFileDialog1.FileName = ToolStripTextBox1.Text
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
            ToolStripTextBox1.Text = SaveFileDialog1.FileName
            YaIO = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LeerToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeerToolStripMenuItem.Click
        NotifyIcon1.ShowBalloonTip(3, "Wor: BinCoder", "Leyendo", ToolTipIcon.Info)
        Dim sapi As Object
        sapi = CreateObject("sapi.spvoice")
        sapi.speak(RichTextBox1.Text)
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        Me.Text = ToolStripTextBox1.Text & " | Wor: BinCoder"
    End Sub

    Private Sub TextEditor_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub TextEditor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Quiere salir de BinCoder?", "Worcome Security", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Dim YaIO As Boolean = False
    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        Try
            If YaIO = False Then
                SaveFileDialog1.FileName = "Documento sin Titulo"
                SaveFileDialog1.ShowDialog()
            ElseIf YaIO = True Then
                My.Computer.FileSystem.WriteAllText(OpenFileDialog1.FileName, RichTextBox1.Text, False)
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub RichTextBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            MIMENU()
        End If
    End Sub

    'Pendiente de Revidaasdion
    Private Sub MIMENU()

        Dim MENU As New ContextMenu

        Dim COPIAR As New MenuItem("Copiar")
        AddHandler COPIAR.Click, AddressOf COPIAR_Click

        Dim PEGAR As New MenuItem("Pegar")
        AddHandler PEGAR.Click, AddressOf PEGAR_Click

        Dim CORTAR As New MenuItem("Cortar")
        AddHandler CORTAR.Click, AddressOf CORTAR_Click

        MENU.MenuItems.Add(COPIAR)
        MENU.MenuItems.Add(PEGAR)
        MENU.MenuItems.Add(CORTAR)

        RichTextBox1.ContextMenu = MENU

    End Sub

    Private Sub COPIAR_Click()
        RichTextBox1.Copy()
    End Sub

    Private Sub PEGAR_Click()
        SaveFileDialog1.DefaultExt = ".rtf"
        RichTextBox1.Paste()
    End Sub

    Private Sub CORTAR_Click()
        RichTextBox1.Cut()
    End Sub

    Private Sub HoraYFechaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HoraYFechaToolStripMenuItem.Click
        RichTextBox1.AppendText(" " & (DateAndTime.Today) & "  ")
        RichTextBox1.AppendText((Format(DateAndTime.TimeOfDay, "HH")) & ":")
        RichTextBox1.AppendText((Format(DateAndTime.TimeOfDay, "mm")) & ":")
        RichTextBox1.AppendText((Format(DateAndTime.TimeOfDay, "ss")) & " ")
        RichTextBox1.AppendText((Format(DateAndTime.TimeOfDay, "tt")) & " ")
        NotifyIcon1.ShowBalloonTip(3, "Wor: BinCoder", "Fecha y Hora Insertado", ToolTipIcon.Info)
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click
        Hightlight.Show()
    End Sub

    Private Sub ToBindCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToBindCodeToolStripMenuItem.Click
        Try
            ToBindCodeToolStripMenuItem.Enabled = False
            ATeztoToolStripMenuItem.Enabled = True
            Dim CARACTERES As Char() = RichTextBox1.Text.ToCharArray
            RichTextBox1.Clear()
            For Each CARACTER In CARACTERES
                Dim TEXTO As Byte() = System.Text.Encoding.Unicode.GetBytes(CARACTER)
                RichTextBox1.Text += Convert.ToString(TEXTO(0), 2).PadLeft(8, "0")
            Next
        Catch ex As Exception
        End Try
        NotifyIcon1.ShowBalloonTip(3, "Wor: BinCoder", "Texto > Binario", ToolTipIcon.Info)
    End Sub

    Private Sub ATextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ATeztoToolStripMenuItem.Click
        Try
            ToBindCodeToolStripMenuItem.Enabled = True
            ATeztoToolStripMenuItem.Enabled = False
            Dim BINARIOS As Char() = RichTextBox1.Text.ToCharArray
            Dim MIARRAY(1) As Byte
            RichTextBox1.Clear()
            For I = 0 To BINARIOS.Length - 8 Step 8
                Dim MIBYTE As String = BINARIOS(I) & BINARIOS(I + 1) & BINARIOS(I + 2) & BINARIOS(I + 3) & BINARIOS(I + 4) & BINARIOS(I + 5) & BINARIOS(I + 6) & BINARIOS(I + 7)
                Dim CONVERSION As String = Convert.ToInt32(MIBYTE, 2)
                MIARRAY(0) = CONVERSION
                RichTextBox1.Text += System.Text.Encoding.Unicode.GetString(MIARRAY)
            Next
        Catch ex As Exception
            NotifyIcon1.ShowBalloonTip(3, "Wor: BinCoder", "Binario > Texto", ToolTipIcon.Info)
        End Try
    End Sub

    Private Sub DevModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevModeToolStripMenuItem.Click
        TextEditorDEV.Show()
        NotifyIcon1.ShowBalloonTip(3, "Wor: BinCoder", "BinCoder Developer Mode", ToolTipIcon.Info)
        Me.Hide()
    End Sub

    Private Sub AbrirBinCoderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirBinCoderToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub AbrirBinCoderDEVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirBinCoderDEVToolStripMenuItem.Click
        TextEditorDEV.Show()
    End Sub

    Private Sub SenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SenderToolStripMenuItem.Click
        GmailSender.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        End
    End Sub

    Private Sub DeharToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeharToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RehacerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RehacerToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub ModoConsentradoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModoConsentradoToolStripMenuItem.Click
        If ModoConsentradoToolStripMenuItem.Text = "Activar Modo Consentrado" Then
            Me.TopMost = True
            ModoConsentradoToolStripMenuItem.Text = "Desactivar Modo Consentrado"
        Else
            Me.TopMost = False
            ModoConsentradoToolStripMenuItem.Text = "Activar Modo Consentrado"
        End If
    End Sub

    Private Sub OpcionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpcionesToolStripMenuItem.Click
        If OptionPanel.Visible = False Then
            OptionPanel.Visible = True
        Else
            OptionPanel.Visible = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = Nothing Or ComboBox1.Text = Nothing Then
            MsgBox("Seleccione un Tema", MsgBoxStyle.Critical, "Worcome Security")
            ComboBox1.SelectedItem = "Default (Rappy)"
            ComboBox1.Focus()
        Else
            'Temas de BinCoder
            If ComboBox1.SelectedItem = "Default (Rappy)" Then
                MenuStrip1.BackColor = Color.Orange
                OptionPanel.BackColor = Color.Wheat
                RichTextBox1.BackColor = Color.White
                RichTextBox1.ForeColor = Color.Black
                TextEditorDEV.MenuStrip1.BackColor = Color.DodgerBlue
                TextEditorDEV.FastColoredTextBox1.BookmarkColor = Color.PowderBlue
                TextEditorDEV.FastColoredTextBox1.FoldingIndicatorColor = Color.Green
                TextEditorDEV.FastColoredTextBox1.IndentBackColor = Color.DodgerBlue
                TextEditorDEV.FastColoredTextBox1.BackColor = Color.White
                TextEditorDEV.FastColoredTextBox1.ForeColor = Color.Black
            ElseIf ComboBox1.SelectedItem = "Hacker" Then
                MenuStrip1.BackColor = Color.Green
                OptionPanel.BackColor = Color.LimeGreen
                RichTextBox1.BackColor = Color.Black
                RichTextBox1.ForeColor = Color.LimeGreen
                TextEditorDEV.MenuStrip1.BackColor = Color.Green
                TextEditorDEV.FastColoredTextBox1.BookmarkColor = Color.PowderBlue
                TextEditorDEV.FastColoredTextBox1.FoldingIndicatorColor = Color.Green
                TextEditorDEV.FastColoredTextBox1.IndentBackColor = Color.LimeGreen
                TextEditorDEV.FastColoredTextBox1.BackColor = Color.Black
                TextEditorDEV.FastColoredTextBox1.ForeColor = Color.LimeGreen
            ElseIf ComboBox1.SelectedItem = "Dark" Then
                MenuStrip1.BackColor = Color.DarkGray
                OptionPanel.BackColor = Color.DimGray
                RichTextBox1.BackColor = Color.Black
                RichTextBox1.ForeColor = Color.White
                TextEditorDEV.MenuStrip1.BackColor = Color.DarkGray
                TextEditorDEV.FastColoredTextBox1.BookmarkColor = Color.PowderBlue
                TextEditorDEV.FastColoredTextBox1.FoldingIndicatorColor = Color.Green
                TextEditorDEV.FastColoredTextBox1.IndentBackColor = Color.Gray
                TextEditorDEV.FastColoredTextBox1.BackColor = Color.Black
                TextEditorDEV.FastColoredTextBox1.ForeColor = Color.White
            ElseIf ComboBox1.SelectedItem = "Vampire" Then
                MenuStrip1.BackColor = Color.Red
                OptionPanel.BackColor = Color.OrangeRed
                RichTextBox1.BackColor = Color.White
                RichTextBox1.ForeColor = Color.OrangeRed
                TextEditorDEV.MenuStrip1.BackColor = Color.Red
                TextEditorDEV.FastColoredTextBox1.BookmarkColor = Color.PowderBlue
                TextEditorDEV.FastColoredTextBox1.FoldingIndicatorColor = Color.Green
                TextEditorDEV.FastColoredTextBox1.IndentBackColor = Color.OrangeRed
                TextEditorDEV.FastColoredTextBox1.BackColor = Color.White
                TextEditorDEV.FastColoredTextBox1.ForeColor = Color.OrangeRed
            End If
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        OptionPanel.Visible = False
    End Sub

    Private Sub EnviarATextEditorDEVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarATextEditorDEVToolStripMenuItem.Click
        TextEditorDEV.FastColoredTextBox1.Text = RichTextBox1.Text
        TextEditorDEV.Show()
        TextEditorDEV.Focus()
    End Sub

    Private Sub CryptoActionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CryptoActionsToolStripMenuItem.Click
        CryptoActions.Show()
        CryptoActions.Focus()
    End Sub
End Class