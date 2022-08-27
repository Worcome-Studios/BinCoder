<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextEditor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TextEditor))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RehacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.LeerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoraYFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModoConsentradoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarATextEditorDEVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarComoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToBindCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ATeztoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CryptoActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirBinCoderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirBinCoderDEVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.OptionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Orange
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditorToolStripMenuItem, Me.FormatoToolStripMenuItem, Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(892, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "Menu"
        '
        'EditorToolStripMenuItem
        '
        Me.EditorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.DeharToolStripMenuItem, Me.RehacerToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripTextBox1, Me.LeerToolStripMenuItem, Me.HoraYFechaToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.SenderToolStripMenuItem, Me.ModoConsentradoToolStripMenuItem, Me.DevModeToolStripMenuItem, Me.EnviarATextEditorDEVToolStripMenuItem, Me.ToolStripMenuItem1, Me.GuardarToolStripMenuItem, Me.GuardarComoToolStripMenuItem, Me.ToolStripMenuItem4, Me.AboutToolStripMenuItem, Me.ToolStripMenuItem3, Me.SalirToolStripMenuItem})
        Me.EditorToolStripMenuItem.Name = "EditorToolStripMenuItem"
        Me.EditorToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditorToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.EditorToolStripMenuItem.Text = "&Editor"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.NuevoToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.New_32
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        Me.NuevoToolStripMenuItem.ToolTipText = "Comienza desde Cero"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.AbrirToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Folder_48
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        Me.AbrirToolStripMenuItem.ToolTipText = "Abre un Archivo"
        '
        'DeharToolStripMenuItem
        '
        Me.DeharToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Flecha_Izq
        Me.DeharToolStripMenuItem.Name = "DeharToolStripMenuItem"
        Me.DeharToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.DeharToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.DeharToolStripMenuItem.Text = "Deshacer"
        '
        'RehacerToolStripMenuItem
        '
        Me.RehacerToolStripMenuItem.Enabled = False
        Me.RehacerToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Flecha_Der
        Me.RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
        Me.RehacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RehacerToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.RehacerToolStripMenuItem.Text = "Rehacer"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(261, 6)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "Sin Titulo"
        Me.ToolStripTextBox1.ToolTipText = "Pon el Nombre y si quieres el Formato"
        '
        'LeerToolStripMenuItem
        '
        Me.LeerToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.audio_volume_medium_panel
        Me.LeerToolStripMenuItem.Name = "LeerToolStripMenuItem"
        Me.LeerToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.LeerToolStripMenuItem.Text = "Leer"
        Me.LeerToolStripMenuItem.ToolTipText = "Lee el Texto Escrito"
        '
        'HoraYFechaToolStripMenuItem
        '
        Me.HoraYFechaToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.event_icon
        Me.HoraYFechaToolStripMenuItem.Name = "HoraYFechaToolStripMenuItem"
        Me.HoraYFechaToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.HoraYFechaToolStripMenuItem.Text = "Fecha y Hora"
        Me.HoraYFechaToolStripMenuItem.ToolTipText = "Inserta la Fecha y la Hora"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Actions_find_and_replace_icon
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.BuscarToolStripMenuItem.Text = "Buscar y Reemplazar"
        Me.BuscarToolStripMenuItem.ToolTipText = "Busca y Cambia una Palabra"
        '
        'SenderToolStripMenuItem
        '
        Me.SenderToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Gmail_Logo
        Me.SenderToolStripMenuItem.Name = "SenderToolStripMenuItem"
        Me.SenderToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.SenderToolStripMenuItem.Text = "Sender"
        Me.SenderToolStripMenuItem.ToolTipText = "Envia tu Texto por Correo"
        '
        'ModoConsentradoToolStripMenuItem
        '
        Me.ModoConsentradoToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.images
        Me.ModoConsentradoToolStripMenuItem.Name = "ModoConsentradoToolStripMenuItem"
        Me.ModoConsentradoToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.ModoConsentradoToolStripMenuItem.Text = "Activar Modo Consentrado"
        Me.ModoConsentradoToolStripMenuItem.ToolTipText = "Concentrate en lo que Escribes"
        '
        'DevModeToolStripMenuItem
        '
        Me.DevModeToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.android_developer
        Me.DevModeToolStripMenuItem.Name = "DevModeToolStripMenuItem"
        Me.DevModeToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.DevModeToolStripMenuItem.Text = "Dev Mode"
        Me.DevModeToolStripMenuItem.ToolTipText = "Crea como Desarrollador"
        '
        'EnviarATextEditorDEVToolStripMenuItem
        '
        Me.EnviarATextEditorDEVToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Flecha_Der
        Me.EnviarATextEditorDEVToolStripMenuItem.Name = "EnviarATextEditorDEVToolStripMenuItem"
        Me.EnviarATextEditorDEVToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.EnviarATextEditorDEVToolStripMenuItem.Text = "Enviar a TextEditorDEV"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(261, 6)
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen
        Me.GuardarToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Save_32
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        Me.GuardarToolStripMenuItem.ToolTipText = "Guarda un Archivo"
        '
        'GuardarComoToolStripMenuItem
        '
        Me.GuardarComoToolStripMenuItem.ForeColor = System.Drawing.Color.LimeGreen
        Me.GuardarComoToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Save_32
        Me.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem"
        Me.GuardarComoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.GuardarComoToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.GuardarComoToolStripMenuItem.Text = "Guardar Como..."
        Me.GuardarComoToolStripMenuItem.ToolTipText = "Guarda un Archivo como"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(261, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Ball_info_32
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        Me.AboutToolStripMenuItem.ToolTipText = "Es Bueno Informarte"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(261, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.SalirToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Button_Close_icon
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(264, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        Me.SalirToolStripMenuItem.ToolTipText = "Cerrar Todo con Seguridad"
        '
        'FormatoToolStripMenuItem
        '
        Me.FormatoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuenteToolStripMenuItem, Me.ColorToolStripMenuItem, Me.ToolStripMenuItem5, Me.ToBindCodeToolStripMenuItem, Me.ATeztoToolStripMenuItem, Me.CryptoActionsToolStripMenuItem})
        Me.FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        Me.FormatoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FormatoToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.FormatoToolStripMenuItem.Text = "&Formato"
        '
        'FuenteToolStripMenuItem
        '
        Me.FuenteToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Font_32
        Me.FuenteToolStripMenuItem.Name = "FuenteToolStripMenuItem"
        Me.FuenteToolStripMenuItem.Size = New System.Drawing.Size(251, 24)
        Me.FuenteToolStripMenuItem.Text = "Fuente"
        Me.FuenteToolStripMenuItem.ToolTipText = "Cambia el Tipo de Letra"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.color
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(251, 24)
        Me.ColorToolStripMenuItem.Text = "Color"
        Me.ColorToolStripMenuItem.ToolTipText = "Pon Color a tu Texto"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(248, 6)
        '
        'ToBindCodeToolStripMenuItem
        '
        Me.ToBindCodeToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.codigo_binario_318_46836
        Me.ToBindCodeToolStripMenuItem.Name = "ToBindCodeToolStripMenuItem"
        Me.ToBindCodeToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.ToBindCodeToolStripMenuItem.Size = New System.Drawing.Size(251, 24)
        Me.ToBindCodeToolStripMenuItem.Text = "A BinCode"
        Me.ToBindCodeToolStripMenuItem.ToolTipText = "Transforma tu Texto a Codigo Binario"
        '
        'ATeztoToolStripMenuItem
        '
        Me.ATeztoToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources._41214
        Me.ATeztoToolStripMenuItem.Name = "ATeztoToolStripMenuItem"
        Me.ATeztoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.ATeztoToolStripMenuItem.Size = New System.Drawing.Size(251, 24)
        Me.ATeztoToolStripMenuItem.Text = "A Texto"
        Me.ATeztoToolStripMenuItem.ToolTipText = "Transforma tu Codigo Binario a Texto"
        '
        'CryptoActionsToolStripMenuItem
        '
        Me.CryptoActionsToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Crypto_key_svg
        Me.CryptoActionsToolStripMenuItem.Name = "CryptoActionsToolStripMenuItem"
        Me.CryptoActionsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CryptoActionsToolStripMenuItem.Size = New System.Drawing.Size(251, 24)
        Me.CryptoActionsToolStripMenuItem.Text = "CryptoActions"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Todos los Archivos|*.*"
        Me.OpenFileDialog1.InitialDirectory = "C:\"
        Me.OpenFileDialog1.Title = "Abrir un Archivo..."
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Texto (.txt)|*.txt|Docs (.rtf)|*.rtf|JavaScript (.js; *.jsm)|*.js|CMD (.cmd; .bat" &
    ")|*.cmd; *.bat|MS (.ini; .inf)|*.ini; *.inf|HTML (.html)|*.html|Todos los Archiv" &
    "os|*.*"
        Me.SaveFileDialog1.InitialDirectory = "C:\"
        Me.SaveFileDialog1.Title = "Guardar Archivo..."
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipTitle = "Wor: BinCoder"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirBinCoderToolStripMenuItem, Me.AbrirBinCoderDEVToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(174, 70)
        '
        'AbrirBinCoderToolStripMenuItem
        '
        Me.AbrirBinCoderToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Flecha_Der
        Me.AbrirBinCoderToolStripMenuItem.Name = "AbrirBinCoderToolStripMenuItem"
        Me.AbrirBinCoderToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AbrirBinCoderToolStripMenuItem.Text = "Abrir BinCoder"
        '
        'AbrirBinCoderDEVToolStripMenuItem
        '
        Me.AbrirBinCoderDEVToolStripMenuItem.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Flecha_Der
        Me.AbrirBinCoderDEVToolStripMenuItem.Name = "AbrirBinCoderDEVToolStripMenuItem"
        Me.AbrirBinCoderDEVToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AbrirBinCoderDEVToolStripMenuItem.Text = "Abrir BinCoderDEV"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Image = Global.Wor_Bin_Coder.My.Resources.Resources.Button_Close_icon
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'OptionPanel
        '
        Me.OptionPanel.BackColor = System.Drawing.Color.Wheat
        Me.OptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OptionPanel.Controls.Add(Me.Label3)
        Me.OptionPanel.Controls.Add(Me.ComboBox1)
        Me.OptionPanel.Controls.Add(Me.Label2)
        Me.OptionPanel.Controls.Add(Me.Label1)
        Me.OptionPanel.Location = New System.Drawing.Point(313, 66)
        Me.OptionPanel.Name = "OptionPanel"
        Me.OptionPanel.Size = New System.Drawing.Size(267, 401)
        Me.OptionPanel.TabIndex = 2
        Me.OptionPanel.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(249, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "X"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Default (Rappy)", "Hacker", "Dark", "Vampire"})
        Me.ComboBox1.Location = New System.Drawing.Point(11, 79)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(243, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Text = "Default (Rappy)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tema:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Opciones"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 28)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(892, 472)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = ""
        '
        'TextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 500)
        Me.Controls.Add(Me.OptionPanel)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wor: BinCoder"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.OptionPanel.ResumeLayout(False)
        Me.OptionPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarComoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LeerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HoraYFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToBindCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ATeztoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AbrirBinCoderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirBinCoderDEVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RehacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeharToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModoConsentradoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionPanel As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EnviarATextEditorDEVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CryptoActionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
