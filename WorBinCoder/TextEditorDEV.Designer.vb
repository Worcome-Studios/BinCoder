<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextEditorDEV
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TextEditorDEV))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RehacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.LeerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoraYFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivarModoConsentradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LenguajesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalizadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSharpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualBasicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HTMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PHPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JavaScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarABinCoderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToBindCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ATeztoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FastColoredTextBox1 = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.FastColoredTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditorToolStripMenuItem, Me.FormatoToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "Menu"
        '
        'EditorToolStripMenuItem
        '
        Me.EditorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.EditorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.DeshacerToolStripMenuItem, Me.RehacerToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripTextBox1, Me.ToolStripTextBox2, Me.LeerToolStripMenuItem, Me.HoraYFechaToolStripMenuItem, Me.SenderToolStripMenuItem, Me.ActivarModoConsentradoToolStripMenuItem, Me.LenguajesToolStripMenuItem, Me.EnviarABinCoderToolStripMenuItem, Me.ToolStripMenuItem1, Me.GuardarToolStripMenuItem, Me.GuardarComoToolStripMenuItem, Me.ToolStripMenuItem4, Me.AboutToolStripMenuItem, Me.ToolStripMenuItem3, Me.VolverToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.EditorToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Files_Edit_file_icon
        Me.EditorToolStripMenuItem.Name = "EditorToolStripMenuItem"
        Me.EditorToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditorToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.EditorToolStripMenuItem.Text = "&Editor"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.NuevoToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.New_32
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.AbrirToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Folder_48
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Flecha_Izq
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.DeshacerToolStripMenuItem.Text = "Deshacer"
        '
        'RehacerToolStripMenuItem
        '
        Me.RehacerToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Flecha_Der
        Me.RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
        Me.RehacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RehacerToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.RehacerToolStripMenuItem.Text = "Rehacer"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(333, 6)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "Sin Titulo"
        Me.ToolStripTextBox1.Visible = False
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox2.Text = "Ruta de Guardado"
        Me.ToolStripTextBox2.ToolTipText = "Saltate la el Molesto paso, Clickeando en ""Guardar Como"""
        Me.ToolStripTextBox2.Visible = False
        '
        'LeerToolStripMenuItem
        '
        Me.LeerToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.audio_volume_medium_panel
        Me.LeerToolStripMenuItem.Name = "LeerToolStripMenuItem"
        Me.LeerToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.LeerToolStripMenuItem.Text = "Leer"
        '
        'HoraYFechaToolStripMenuItem
        '
        Me.HoraYFechaToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.event_icon
        Me.HoraYFechaToolStripMenuItem.Name = "HoraYFechaToolStripMenuItem"
        Me.HoraYFechaToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.HoraYFechaToolStripMenuItem.Text = "Fecha y Hora"
        '
        'SenderToolStripMenuItem
        '
        Me.SenderToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Gmail_Logo
        Me.SenderToolStripMenuItem.Name = "SenderToolStripMenuItem"
        Me.SenderToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.SenderToolStripMenuItem.Text = "Sender"
        '
        'ActivarModoConsentradoToolStripMenuItem
        '
        Me.ActivarModoConsentradoToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.images
        Me.ActivarModoConsentradoToolStripMenuItem.Name = "ActivarModoConsentradoToolStripMenuItem"
        Me.ActivarModoConsentradoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ActivarModoConsentradoToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.ActivarModoConsentradoToolStripMenuItem.Text = "Activar Modo Consentrado"
        '
        'LenguajesToolStripMenuItem
        '
        Me.LenguajesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalizadoToolStripMenuItem, Me.CSharpToolStripMenuItem, Me.VisualBasicToolStripMenuItem, Me.HTMLToolStripMenuItem, Me.SQLToolStripMenuItem, Me.PHPToolStripMenuItem, Me.JavaScriptToolStripMenuItem})
        Me.LenguajesToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Files_Edit_file_icon
        Me.LenguajesToolStripMenuItem.Name = "LenguajesToolStripMenuItem"
        Me.LenguajesToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.LenguajesToolStripMenuItem.Text = "Lenguajes"
        Me.LenguajesToolStripMenuItem.ToolTipText = "Elige un Lenguaje de Programacion para Consentrarte"
        '
        'PersonalizadoToolStripMenuItem
        '
        Me.PersonalizadoToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.android_developer
        Me.PersonalizadoToolStripMenuItem.Name = "PersonalizadoToolStripMenuItem"
        Me.PersonalizadoToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.PersonalizadoToolStripMenuItem.Text = "Personalizado"
        '
        'CSharpToolStripMenuItem
        '
        Me.CSharpToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.csharp3
        Me.CSharpToolStripMenuItem.Name = "CSharpToolStripMenuItem"
        Me.CSharpToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.CSharpToolStripMenuItem.Text = "CSharp"
        '
        'VisualBasicToolStripMenuItem
        '
        Me.VisualBasicToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.visualbasic
        Me.VisualBasicToolStripMenuItem.Name = "VisualBasicToolStripMenuItem"
        Me.VisualBasicToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.VisualBasicToolStripMenuItem.Text = "VisualBasic"
        '
        'HTMLToolStripMenuItem
        '
        Me.HTMLToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.HTML5_logo_and_wordmark_svg
        Me.HTMLToolStripMenuItem.Name = "HTMLToolStripMenuItem"
        Me.HTMLToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.HTMLToolStripMenuItem.Text = "HTML"
        '
        'SQLToolStripMenuItem
        '
        Me.SQLToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.sql_file_icon_0
        Me.SQLToolStripMenuItem.Name = "SQLToolStripMenuItem"
        Me.SQLToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.SQLToolStripMenuItem.Text = "SQL"
        '
        'PHPToolStripMenuItem
        '
        Me.PHPToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.php
        Me.PHPToolStripMenuItem.Name = "PHPToolStripMenuItem"
        Me.PHPToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.PHPToolStripMenuItem.Text = "PHP"
        '
        'JavaScriptToolStripMenuItem
        '
        Me.JavaScriptToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.logo_javascript
        Me.JavaScriptToolStripMenuItem.Name = "JavaScriptToolStripMenuItem"
        Me.JavaScriptToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.JavaScriptToolStripMenuItem.Text = "JavaScript"
        '
        'EnviarABinCoderToolStripMenuItem
        '
        Me.EnviarABinCoderToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Flecha_Der
        Me.EnviarABinCoderToolStripMenuItem.Name = "EnviarABinCoderToolStripMenuItem"
        Me.EnviarABinCoderToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.EnviarABinCoderToolStripMenuItem.Text = "Enviar a BinCoder"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(333, 6)
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.ForeColor = System.Drawing.Color.Green
        Me.GuardarToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Save_32
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'GuardarComoToolStripMenuItem
        '
        Me.GuardarComoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.GuardarComoToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen
        Me.GuardarComoToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Save_32
        Me.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        Me.GuardarComoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GuardarComoToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.GuardarComoToolStripMenuItem.Text = "Guardar Como"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(333, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Ball_info_32
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(333, 6)
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Flecha_Izq
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.VolverToolStripMenuItem.Text = "Volver"
        Me.VolverToolStripMenuItem.ToolTipText = "Esto quedara Abierto"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Button_Close_icon
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(336, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        Me.SalirToolStripMenuItem.ToolTipText = "Forma Segura de Cerrado"
        '
        'FormatoToolStripMenuItem
        '
        Me.FormatoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FormatoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuenteToolStripMenuItem, Me.ColorToolStripMenuItem, Me.ToolStripMenuItem5, Me.ToBindCodeToolStripMenuItem, Me.ATeztoToolStripMenuItem})
        Me.FormatoToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Paste_32
        Me.FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        Me.FormatoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FormatoToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.FormatoToolStripMenuItem.Text = "&Formato"
        '
        'FuenteToolStripMenuItem
        '
        Me.FuenteToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Font_32
        Me.FuenteToolStripMenuItem.Name = "FuenteToolStripMenuItem"
        Me.FuenteToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.FuenteToolStripMenuItem.Text = "Fuente"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.color
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(216, 6)
        '
        'ToBindCodeToolStripMenuItem
        '
        Me.ToBindCodeToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.codigo_binario_318_46836
        Me.ToBindCodeToolStripMenuItem.Name = "ToBindCodeToolStripMenuItem"
        Me.ToBindCodeToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.ToBindCodeToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.ToBindCodeToolStripMenuItem.Text = "A Binario"
        '
        'ATeztoToolStripMenuItem
        '
        Me.ATeztoToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources._41214
        Me.ATeztoToolStripMenuItem.Name = "ATeztoToolStripMenuItem"
        Me.ATeztoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.ATeztoToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.ATeztoToolStripMenuItem.Text = "A Texto"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Todos los Archivos|*.*"
        Me.OpenFileDialog1.InitialDirectory = "C:\"
        Me.OpenFileDialog1.Title = "Abrir un Archivo..."
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = resources.GetString("SaveFileDialog1.Filter")
        Me.SaveFileDialog1.InitialDirectory = "C:\"
        Me.SaveFileDialog1.Title = "Guardar Archivo..."
        '
        'FastColoredTextBox1
        '
        Me.FastColoredTextBox1.AutoScrollMinSize = New System.Drawing.Size(29, 18)
        Me.FastColoredTextBox1.BackBrush = Nothing
        Me.FastColoredTextBox1.CharHeight = 18
        Me.FastColoredTextBox1.CharWidth = 9
        Me.FastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FastColoredTextBox1.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.FastColoredTextBox1.IndentBackColor = System.Drawing.Color.DodgerBlue
        Me.FastColoredTextBox1.IsReplaceMode = False
        Me.FastColoredTextBox1.LineNumberColor = System.Drawing.Color.Black
        Me.FastColoredTextBox1.Location = New System.Drawing.Point(0, 28)
        Me.FastColoredTextBox1.Name = "FastColoredTextBox1"
        Me.FastColoredTextBox1.Paddings = New System.Windows.Forms.Padding(0)
        Me.FastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FastColoredTextBox1.ServiceLinesColor = System.Drawing.Color.Black
        Me.FastColoredTextBox1.Size = New System.Drawing.Size(884, 484)
        Me.FastColoredTextBox1.TabIndex = 2
        Me.FastColoredTextBox1.ToolTip = Nothing
        Me.FastColoredTextBox1.Zoom = 100
        '
        'TextEditorDEV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 512)
        Me.Controls.Add(Me.FastColoredTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(250, 150)
        Me.Name = "TextEditorDEV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wor: BinCoderDEV"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.FastColoredTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FuenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LeerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HoraYFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToBindCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ATeztoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FastColoredTextBox1 As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LenguajesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalizadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CSharpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualBasicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HTMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SQLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PHPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JavaScriptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeshacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RehacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActivarModoConsentradoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents EnviarABinCoderToolStripMenuItem As ToolStripMenuItem
End Class
