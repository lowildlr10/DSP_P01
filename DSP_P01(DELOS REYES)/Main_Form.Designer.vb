<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.status_indicator = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_Import = New System.Windows.Forms.ToolStripMenuItem
        Me.SAVEIMAGEASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADDONSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DIGITALSIGNALPROCESSINGIMAGEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Tool_strip = New System.Windows.Forms.ToolStrip
        Me.Btn_Import = New System.Windows.Forms.ToolStripButton
        Me.btn_Img_Save = New System.Windows.Forms.ToolStripButton
        Me.btn_ClearAll = New System.Windows.Forms.ToolStripButton
        Me.btn_Restore = New System.Windows.Forms.ToolStripButton
        Me.btn_Undo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btn_pixel_Values = New System.Windows.Forms.ToolStripButton
        Me.Img_preview = New System.Windows.Forms.PictureBox
        Me.context_Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SAVEASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REFRESHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.panel_Image = New System.Windows.Forms.Panel
        Me.Filters_grp = New System.Windows.Forms.GroupBox
        Me.combo_Filter2 = New System.Windows.Forms.ComboBox
        Me.lbl_Filter = New System.Windows.Forms.Label
        Me.combo_Filter = New System.Windows.Forms.ComboBox
        Me.threshold_grp = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.input03 = New System.Windows.Forms.TrackBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.input02 = New System.Windows.Forms.TrackBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.input01 = New System.Windows.Forms.TrackBar
        Me.histogram_grp = New System.Windows.Forms.GroupBox
        Me.Histogram_Preview = New System.Windows.Forms.PictureBox
        Me.color_Pick = New System.Windows.Forms.GroupBox
        Me.color_Disp = New System.Windows.Forms.Label
        Me.btn_Pick = New System.Windows.Forms.Button
        Me.color_Text = New System.Windows.Forms.Label
        Me.Slide_Set = New System.Windows.Forms.TrackBar
        Me.Effect_Tools = New System.Windows.Forms.ToolStrip
        Me.btn_RGB = New System.Windows.Forms.ToolStripButton
        Me.btn_Equalizer = New System.Windows.Forms.ToolStripButton
        Me.btn_Negative = New System.Windows.Forms.ToolStripButton
        Me.btn_Threshold = New System.Windows.Forms.ToolStripButton
        Me.btn_Power = New System.Windows.Forms.ToolStripButton
        Me.btn_Root = New System.Windows.Forms.ToolStripButton
        Me.btn_Logarithmic = New System.Windows.Forms.ToolStripButton
        Me.btn_AntiLog = New System.Windows.Forms.ToolStripButton
        Me.btn_GrayLevelSlicing = New System.Windows.Forms.ToolStripButton
        Me.btn_BitPlaneSlicing = New System.Windows.Forms.ToolStripButton
        Me.btn_Filtering = New System.Windows.Forms.ToolStripButton
        Me.btn_Hue = New System.Windows.Forms.ToolStripButton
        Me.btn_Saturation = New System.Windows.Forms.ToolStripButton
        Me.btn_Intensity = New System.Windows.Forms.ToolStripButton
        Me.btn_HSI = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.effect_Text = New System.Windows.Forms.ToolStripLabel
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.btn_Panel_Hide = New System.Windows.Forms.Button
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.REFRESHToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.checkbox_EditMode = New System.Windows.Forms.CheckBox
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Tool_strip.SuspendLayout()
        CType(Me.Img_preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.context_Menu.SuspendLayout()
        Me.panel_Image.SuspendLayout()
        Me.Filters_grp.SuspendLayout()
        Me.threshold_grp.SuspendLayout()
        CType(Me.input03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.input02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.input01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.histogram_grp.SuspendLayout()
        CType(Me.Histogram_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.color_Pick.SuspendLayout()
        CType(Me.Slide_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Effect_Tools.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.status_indicator})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 544)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(646, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        '
        'status_indicator
        '
        Me.status_indicator.Name = "status_indicator"
        Me.status_indicator.Size = New System.Drawing.Size(125, 17)
        Me.status_indicator.Text = "NO IMPORTED IMAGE"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.ADDONSToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(646, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Import, Me.SAVEIMAGEASToolStripMenuItem, Me.ToolStripSeparator1, Me.EXITToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'Menu_Import
        '
        Me.Menu_Import.Image = CType(resources.GetObject("Menu_Import.Image"), System.Drawing.Image)
        Me.Menu_Import.Name = "Menu_Import"
        Me.Menu_Import.Size = New System.Drawing.Size(166, 22)
        Me.Menu_Import.Text = "IMPORT"
        '
        'SAVEIMAGEASToolStripMenuItem
        '
        Me.SAVEIMAGEASToolStripMenuItem.Image = CType(resources.GetObject("SAVEIMAGEASToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SAVEIMAGEASToolStripMenuItem.Name = "SAVEIMAGEASToolStripMenuItem"
        Me.SAVEIMAGEASToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.SAVEIMAGEASToolStripMenuItem.Text = "SAVE IMAGE AS..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Image = CType(resources.GetObject("EXITToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'ADDONSToolStripMenuItem
        '
        Me.ADDONSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DIGITALSIGNALPROCESSINGIMAGEToolStripMenuItem})
        Me.ADDONSToolStripMenuItem.Name = "ADDONSToolStripMenuItem"
        Me.ADDONSToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.ADDONSToolStripMenuItem.Text = "SWITCH TO..."
        '
        'DIGITALSIGNALPROCESSINGIMAGEToolStripMenuItem
        '
        Me.DIGITALSIGNALPROCESSINGIMAGEToolStripMenuItem.Image = CType(resources.GetObject("DIGITALSIGNALPROCESSINGIMAGEToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DIGITALSIGNALPROCESSINGIMAGEToolStripMenuItem.Name = "DIGITALSIGNALPROCESSINGIMAGEToolStripMenuItem"
        Me.DIGITALSIGNALPROCESSINGIMAGEToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.DIGITALSIGNALPROCESSINGIMAGEToolStripMenuItem.Text = "DIGITAL SIGNAL PROCESSING VIDEO"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABOUTToolStripMenuItem})
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ABOUTToolStripMenuItem.Text = "ABOUT"
        '
        'Tool_strip
        '
        Me.Tool_strip.AutoSize = False
        Me.Tool_strip.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Tool_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Import, Me.btn_Img_Save, Me.btn_ClearAll, Me.btn_Restore, Me.btn_Undo, Me.ToolStripSeparator2, Me.btn_pixel_Values})
        Me.Tool_strip.Location = New System.Drawing.Point(0, 24)
        Me.Tool_strip.Name = "Tool_strip"
        Me.Tool_strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Tool_strip.Size = New System.Drawing.Size(646, 34)
        Me.Tool_strip.TabIndex = 2
        '
        'Btn_Import
        '
        Me.Btn_Import.AutoSize = False
        Me.Btn_Import.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Import.Image = CType(resources.GetObject("Btn_Import.Image"), System.Drawing.Image)
        Me.Btn_Import.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Import.Name = "Btn_Import"
        Me.Btn_Import.Size = New System.Drawing.Size(33, 31)
        Me.Btn_Import.Text = "IMPORT"
        '
        'btn_Img_Save
        '
        Me.btn_Img_Save.AutoSize = False
        Me.btn_Img_Save.BackColor = System.Drawing.Color.Transparent
        Me.btn_Img_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Img_Save.Image = CType(resources.GetObject("btn_Img_Save.Image"), System.Drawing.Image)
        Me.btn_Img_Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Img_Save.Name = "btn_Img_Save"
        Me.btn_Img_Save.Size = New System.Drawing.Size(33, 31)
        Me.btn_Img_Save.Text = "SAVE IMAGE AS..."
        '
        'btn_ClearAll
        '
        Me.btn_ClearAll.AutoSize = False
        Me.btn_ClearAll.BackColor = System.Drawing.Color.Transparent
        Me.btn_ClearAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_ClearAll.Image = CType(resources.GetObject("btn_ClearAll.Image"), System.Drawing.Image)
        Me.btn_ClearAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_ClearAll.Name = "btn_ClearAll"
        Me.btn_ClearAll.Size = New System.Drawing.Size(33, 31)
        Me.btn_ClearAll.Text = "CLEAR ALL"
        '
        'btn_Restore
        '
        Me.btn_Restore.AutoSize = False
        Me.btn_Restore.BackColor = System.Drawing.Color.Transparent
        Me.btn_Restore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Restore.Image = CType(resources.GetObject("btn_Restore.Image"), System.Drawing.Image)
        Me.btn_Restore.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Restore.Name = "btn_Restore"
        Me.btn_Restore.Size = New System.Drawing.Size(33, 31)
        Me.btn_Restore.Text = "RESTORE IMAGE DEFAULTS"
        '
        'btn_Undo
        '
        Me.btn_Undo.AutoSize = False
        Me.btn_Undo.BackColor = System.Drawing.Color.Transparent
        Me.btn_Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Undo.Image = CType(resources.GetObject("btn_Undo.Image"), System.Drawing.Image)
        Me.btn_Undo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Undo.Name = "btn_Undo"
        Me.btn_Undo.Size = New System.Drawing.Size(33, 31)
        Me.btn_Undo.Text = "UNDO"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'btn_pixel_Values
        '
        Me.btn_pixel_Values.AutoSize = False
        Me.btn_pixel_Values.BackColor = System.Drawing.Color.Transparent
        Me.btn_pixel_Values.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_pixel_Values.Image = CType(resources.GetObject("btn_pixel_Values.Image"), System.Drawing.Image)
        Me.btn_pixel_Values.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_pixel_Values.Name = "btn_pixel_Values"
        Me.btn_pixel_Values.Size = New System.Drawing.Size(33, 31)
        Me.btn_pixel_Values.Text = "SHOW PIXEL VALUES"
        '
        'Img_preview
        '
        Me.Img_preview.BackColor = System.Drawing.Color.White
        Me.Img_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Img_preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Img_preview.ContextMenuStrip = Me.context_Menu
        Me.Img_preview.Location = New System.Drawing.Point(52, 89)
        Me.Img_preview.Name = "Img_preview"
        Me.Img_preview.Size = New System.Drawing.Size(535, 424)
        Me.Img_preview.TabIndex = 4
        Me.Img_preview.TabStop = False
        Me.Img_preview.Visible = False
        '
        'context_Menu
        '
        Me.context_Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SAVEASToolStripMenuItem, Me.REFRESHToolStripMenuItem})
        Me.context_Menu.Name = "context_Menu"
        Me.context_Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.context_Menu.Size = New System.Drawing.Size(128, 48)
        '
        'SAVEASToolStripMenuItem
        '
        Me.SAVEASToolStripMenuItem.Name = "SAVEASToolStripMenuItem"
        Me.SAVEASToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.SAVEASToolStripMenuItem.Text = "SAVE AS..."
        '
        'REFRESHToolStripMenuItem
        '
        Me.REFRESHToolStripMenuItem.Name = "REFRESHToolStripMenuItem"
        Me.REFRESHToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.REFRESHToolStripMenuItem.Text = "REFRESH"
        '
        'panel_Image
        '
        Me.panel_Image.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panel_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_Image.Controls.Add(Me.Filters_grp)
        Me.panel_Image.Controls.Add(Me.threshold_grp)
        Me.panel_Image.Controls.Add(Me.histogram_grp)
        Me.panel_Image.Controls.Add(Me.color_Pick)
        Me.panel_Image.Controls.Add(Me.Effect_Tools)
        Me.panel_Image.Controls.Add(Me.ToolStrip1)
        Me.panel_Image.Enabled = False
        Me.panel_Image.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel_Image.Location = New System.Drawing.Point(645, 54)
        Me.panel_Image.Name = "panel_Image"
        Me.panel_Image.Size = New System.Drawing.Size(333, 500)
        Me.panel_Image.TabIndex = 5
        '
        'Filters_grp
        '
        Me.Filters_grp.Controls.Add(Me.combo_Filter2)
        Me.Filters_grp.Controls.Add(Me.lbl_Filter)
        Me.Filters_grp.Controls.Add(Me.combo_Filter)
        Me.Filters_grp.Enabled = False
        Me.Filters_grp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filters_grp.Location = New System.Drawing.Point(3, 168)
        Me.Filters_grp.Name = "Filters_grp"
        Me.Filters_grp.Size = New System.Drawing.Size(323, 76)
        Me.Filters_grp.TabIndex = 18
        Me.Filters_grp.TabStop = False
        Me.Filters_grp.Text = "FILTERS"
        Me.Filters_grp.Visible = False
        '
        'combo_Filter2
        '
        Me.combo_Filter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Filter2.FormattingEnabled = True
        Me.combo_Filter2.Location = New System.Drawing.Point(155, 46)
        Me.combo_Filter2.Name = "combo_Filter2"
        Me.combo_Filter2.Size = New System.Drawing.Size(157, 23)
        Me.combo_Filter2.TabIndex = 3
        '
        'lbl_Filter
        '
        Me.lbl_Filter.AutoSize = True
        Me.lbl_Filter.Location = New System.Drawing.Point(6, 46)
        Me.lbl_Filter.Name = "lbl_Filter"
        Me.lbl_Filter.Size = New System.Drawing.Size(0, 15)
        Me.lbl_Filter.TabIndex = 2
        '
        'combo_Filter
        '
        Me.combo_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_Filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_Filter.FormattingEnabled = True
        Me.combo_Filter.Items.AddRange(New Object() {"SPATIAL FILTERS", "FREQUENCY FILTERS", "CUSTOM FILTERS..."})
        Me.combo_Filter.Location = New System.Drawing.Point(9, 17)
        Me.combo_Filter.Name = "combo_Filter"
        Me.combo_Filter.Size = New System.Drawing.Size(304, 21)
        Me.combo_Filter.TabIndex = 0
        '
        'threshold_grp
        '
        Me.threshold_grp.Controls.Add(Me.Label6)
        Me.threshold_grp.Controls.Add(Me.Label4)
        Me.threshold_grp.Controls.Add(Me.Label5)
        Me.threshold_grp.Controls.Add(Me.Label3)
        Me.threshold_grp.Controls.Add(Me.input03)
        Me.threshold_grp.Controls.Add(Me.Label2)
        Me.threshold_grp.Controls.Add(Me.input02)
        Me.threshold_grp.Controls.Add(Me.Label1)
        Me.threshold_grp.Controls.Add(Me.input01)
        Me.threshold_grp.Enabled = False
        Me.threshold_grp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.threshold_grp.Location = New System.Drawing.Point(3, 168)
        Me.threshold_grp.Name = "threshold_grp"
        Me.threshold_grp.Size = New System.Drawing.Size(323, 76)
        Me.threshold_grp.TabIndex = 10
        Me.threshold_grp.TabStop = False
        Me.threshold_grp.Text = "THRESHOLD VALUE"
        Me.threshold_grp.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "INPUT:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "INPUT:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "INPUT:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "0"
        '
        'input03
        '
        Me.input03.AutoSize = False
        Me.input03.BackColor = System.Drawing.Color.DimGray
        Me.input03.LargeChange = 255
        Me.input03.Location = New System.Drawing.Point(131, 53)
        Me.input03.Maximum = 255
        Me.input03.Name = "input03"
        Me.input03.Size = New System.Drawing.Size(186, 18)
        Me.input03.TabIndex = 12
        Me.input03.TickFrequency = 0
        Me.input03.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "0"
        '
        'input02
        '
        Me.input02.AutoSize = False
        Me.input02.BackColor = System.Drawing.Color.DimGray
        Me.input02.LargeChange = 255
        Me.input02.Location = New System.Drawing.Point(131, 35)
        Me.input02.Maximum = 255
        Me.input02.Name = "input02"
        Me.input02.Size = New System.Drawing.Size(186, 18)
        Me.input02.TabIndex = 10
        Me.input02.TickFrequency = 0
        Me.input02.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "0"
        '
        'input01
        '
        Me.input01.AutoSize = False
        Me.input01.BackColor = System.Drawing.Color.DimGray
        Me.input01.LargeChange = 255
        Me.input01.Location = New System.Drawing.Point(131, 17)
        Me.input01.Maximum = 255
        Me.input01.Name = "input01"
        Me.input01.Size = New System.Drawing.Size(186, 18)
        Me.input01.TabIndex = 8
        Me.input01.TickFrequency = 0
        Me.input01.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'histogram_grp
        '
        Me.histogram_grp.Controls.Add(Me.Histogram_Preview)
        Me.histogram_grp.Enabled = False
        Me.histogram_grp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.histogram_grp.Location = New System.Drawing.Point(3, 250)
        Me.histogram_grp.Name = "histogram_grp"
        Me.histogram_grp.Size = New System.Drawing.Size(323, 235)
        Me.histogram_grp.TabIndex = 9
        Me.histogram_grp.TabStop = False
        Me.histogram_grp.Text = "HISTOGRAM"
        Me.histogram_grp.Visible = False
        '
        'Histogram_Preview
        '
        Me.Histogram_Preview.BackColor = System.Drawing.Color.LightGray
        Me.Histogram_Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Histogram_Preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Histogram_Preview.Location = New System.Drawing.Point(6, 17)
        Me.Histogram_Preview.Name = "Histogram_Preview"
        Me.Histogram_Preview.Size = New System.Drawing.Size(311, 212)
        Me.Histogram_Preview.TabIndex = 0
        Me.Histogram_Preview.TabStop = False
        '
        'color_Pick
        '
        Me.color_Pick.Controls.Add(Me.color_Disp)
        Me.color_Pick.Controls.Add(Me.btn_Pick)
        Me.color_Pick.Controls.Add(Me.color_Text)
        Me.color_Pick.Controls.Add(Me.Slide_Set)
        Me.color_Pick.Enabled = False
        Me.color_Pick.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.color_Pick.Location = New System.Drawing.Point(3, 91)
        Me.color_Pick.Name = "color_Pick"
        Me.color_Pick.Size = New System.Drawing.Size(323, 71)
        Me.color_Pick.TabIndex = 8
        Me.color_Pick.TabStop = False
        Me.color_Pick.Text = "RGB COLORS"
        Me.color_Pick.Visible = False
        '
        'color_Disp
        '
        Me.color_Disp.BackColor = System.Drawing.Color.DimGray
        Me.color_Disp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.color_Disp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.color_Disp.Location = New System.Drawing.Point(6, 26)
        Me.color_Disp.Name = "color_Disp"
        Me.color_Disp.Size = New System.Drawing.Size(32, 29)
        Me.color_Disp.TabIndex = 6
        '
        'btn_Pick
        '
        Me.btn_Pick.BackColor = System.Drawing.Color.Transparent
        Me.btn_Pick.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pick.Location = New System.Drawing.Point(233, 26)
        Me.btn_Pick.Name = "btn_Pick"
        Me.btn_Pick.Size = New System.Drawing.Size(76, 29)
        Me.btn_Pick.TabIndex = 7
        Me.btn_Pick.Text = "PROCESS"
        Me.btn_Pick.UseVisualStyleBackColor = False
        '
        'color_Text
        '
        Me.color_Text.AutoSize = True
        Me.color_Text.Font = New System.Drawing.Font("Segoe UI Semibold", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.color_Text.Location = New System.Drawing.Point(53, 46)
        Me.color_Text.Name = "color_Text"
        Me.color_Text.Size = New System.Drawing.Size(41, 11)
        Me.color_Text.TabIndex = 2
        Me.color_Text.Text = "ORIGINAL"
        '
        'Slide_Set
        '
        Me.Slide_Set.AutoSize = False
        Me.Slide_Set.BackColor = System.Drawing.Color.DimGray
        Me.Slide_Set.LargeChange = 255
        Me.Slide_Set.Location = New System.Drawing.Point(44, 26)
        Me.Slide_Set.Maximum = 4
        Me.Slide_Set.Name = "Slide_Set"
        Me.Slide_Set.Size = New System.Drawing.Size(183, 18)
        Me.Slide_Set.TabIndex = 0
        Me.Slide_Set.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Effect_Tools
        '
        Me.Effect_Tools.AutoSize = False
        Me.Effect_Tools.BackColor = System.Drawing.Color.Transparent
        Me.Effect_Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_RGB, Me.btn_Equalizer, Me.btn_Negative, Me.btn_Threshold, Me.btn_Power, Me.btn_Root, Me.btn_Logarithmic, Me.btn_AntiLog, Me.btn_GrayLevelSlicing, Me.btn_BitPlaneSlicing, Me.btn_Filtering, Me.btn_Hue, Me.btn_Saturation, Me.btn_Intensity, Me.btn_HSI})
        Me.Effect_Tools.Location = New System.Drawing.Point(0, 39)
        Me.Effect_Tools.Name = "Effect_Tools"
        Me.Effect_Tools.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Effect_Tools.Size = New System.Drawing.Size(329, 39)
        Me.Effect_Tools.TabIndex = 4
        Me.Effect_Tools.Text = "ToolStrip2"
        '
        'btn_RGB
        '
        Me.btn_RGB.AutoSize = False
        Me.btn_RGB.BackColor = System.Drawing.Color.Transparent
        Me.btn_RGB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_RGB.Image = CType(resources.GetObject("btn_RGB.Image"), System.Drawing.Image)
        Me.btn_RGB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_RGB.Name = "btn_RGB"
        Me.btn_RGB.Size = New System.Drawing.Size(40, 36)
        Me.btn_RGB.Text = "RGB"
        '
        'btn_Equalizer
        '
        Me.btn_Equalizer.AutoSize = False
        Me.btn_Equalizer.BackColor = System.Drawing.Color.Transparent
        Me.btn_Equalizer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Equalizer.Image = CType(resources.GetObject("btn_Equalizer.Image"), System.Drawing.Image)
        Me.btn_Equalizer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Equalizer.Name = "btn_Equalizer"
        Me.btn_Equalizer.Size = New System.Drawing.Size(40, 36)
        Me.btn_Equalizer.Text = "EQUALIZATION"
        '
        'btn_Negative
        '
        Me.btn_Negative.AutoSize = False
        Me.btn_Negative.BackColor = System.Drawing.Color.Transparent
        Me.btn_Negative.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Negative.Image = CType(resources.GetObject("btn_Negative.Image"), System.Drawing.Image)
        Me.btn_Negative.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Negative.Name = "btn_Negative"
        Me.btn_Negative.Size = New System.Drawing.Size(40, 36)
        Me.btn_Negative.Text = "NEGATIVE"
        '
        'btn_Threshold
        '
        Me.btn_Threshold.AutoSize = False
        Me.btn_Threshold.BackColor = System.Drawing.Color.Transparent
        Me.btn_Threshold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Threshold.Image = CType(resources.GetObject("btn_Threshold.Image"), System.Drawing.Image)
        Me.btn_Threshold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Threshold.Name = "btn_Threshold"
        Me.btn_Threshold.Size = New System.Drawing.Size(40, 36)
        Me.btn_Threshold.Text = "THRESHOLD"
        '
        'btn_Power
        '
        Me.btn_Power.AutoSize = False
        Me.btn_Power.BackColor = System.Drawing.Color.Transparent
        Me.btn_Power.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Power.Image = CType(resources.GetObject("btn_Power.Image"), System.Drawing.Image)
        Me.btn_Power.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Power.Name = "btn_Power"
        Me.btn_Power.Size = New System.Drawing.Size(40, 36)
        Me.btn_Power.Text = "POWER"
        '
        'btn_Root
        '
        Me.btn_Root.AutoSize = False
        Me.btn_Root.BackColor = System.Drawing.Color.Transparent
        Me.btn_Root.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Root.Image = CType(resources.GetObject("btn_Root.Image"), System.Drawing.Image)
        Me.btn_Root.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Root.Name = "btn_Root"
        Me.btn_Root.Size = New System.Drawing.Size(40, 36)
        Me.btn_Root.Text = "ROOT"
        '
        'btn_Logarithmic
        '
        Me.btn_Logarithmic.AutoSize = False
        Me.btn_Logarithmic.BackColor = System.Drawing.Color.Transparent
        Me.btn_Logarithmic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Logarithmic.Image = CType(resources.GetObject("btn_Logarithmic.Image"), System.Drawing.Image)
        Me.btn_Logarithmic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Logarithmic.Name = "btn_Logarithmic"
        Me.btn_Logarithmic.Size = New System.Drawing.Size(40, 36)
        Me.btn_Logarithmic.Text = "LOGARITHMIC"
        '
        'btn_AntiLog
        '
        Me.btn_AntiLog.AutoSize = False
        Me.btn_AntiLog.BackColor = System.Drawing.Color.Transparent
        Me.btn_AntiLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_AntiLog.Image = CType(resources.GetObject("btn_AntiLog.Image"), System.Drawing.Image)
        Me.btn_AntiLog.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_AntiLog.Name = "btn_AntiLog"
        Me.btn_AntiLog.Size = New System.Drawing.Size(40, 36)
        Me.btn_AntiLog.Text = "ANTI LOGARITHMIC"
        '
        'btn_GrayLevelSlicing
        '
        Me.btn_GrayLevelSlicing.AutoSize = False
        Me.btn_GrayLevelSlicing.BackColor = System.Drawing.Color.Transparent
        Me.btn_GrayLevelSlicing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_GrayLevelSlicing.Image = CType(resources.GetObject("btn_GrayLevelSlicing.Image"), System.Drawing.Image)
        Me.btn_GrayLevelSlicing.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_GrayLevelSlicing.Name = "btn_GrayLevelSlicing"
        Me.btn_GrayLevelSlicing.Size = New System.Drawing.Size(40, 36)
        Me.btn_GrayLevelSlicing.Text = "GRAYLEVEL SLICING"
        '
        'btn_BitPlaneSlicing
        '
        Me.btn_BitPlaneSlicing.AutoSize = False
        Me.btn_BitPlaneSlicing.BackColor = System.Drawing.Color.Transparent
        Me.btn_BitPlaneSlicing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_BitPlaneSlicing.Image = CType(resources.GetObject("btn_BitPlaneSlicing.Image"), System.Drawing.Image)
        Me.btn_BitPlaneSlicing.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_BitPlaneSlicing.Name = "btn_BitPlaneSlicing"
        Me.btn_BitPlaneSlicing.Size = New System.Drawing.Size(40, 36)
        Me.btn_BitPlaneSlicing.Text = "BIT PLANE SLICING"
        '
        'btn_Filtering
        '
        Me.btn_Filtering.AutoSize = False
        Me.btn_Filtering.BackColor = System.Drawing.Color.Transparent
        Me.btn_Filtering.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Filtering.Image = CType(resources.GetObject("btn_Filtering.Image"), System.Drawing.Image)
        Me.btn_Filtering.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Filtering.Name = "btn_Filtering"
        Me.btn_Filtering.Size = New System.Drawing.Size(40, 36)
        Me.btn_Filtering.Text = "FILTERING"
        '
        'btn_Hue
        '
        Me.btn_Hue.AutoSize = False
        Me.btn_Hue.BackColor = System.Drawing.Color.Transparent
        Me.btn_Hue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Hue.Image = CType(resources.GetObject("btn_Hue.Image"), System.Drawing.Image)
        Me.btn_Hue.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Hue.Name = "btn_Hue"
        Me.btn_Hue.Size = New System.Drawing.Size(40, 36)
        Me.btn_Hue.Text = "HUE"
        '
        'btn_Saturation
        '
        Me.btn_Saturation.AutoSize = False
        Me.btn_Saturation.BackColor = System.Drawing.Color.Transparent
        Me.btn_Saturation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Saturation.Image = CType(resources.GetObject("btn_Saturation.Image"), System.Drawing.Image)
        Me.btn_Saturation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Saturation.Name = "btn_Saturation"
        Me.btn_Saturation.Size = New System.Drawing.Size(40, 36)
        Me.btn_Saturation.Text = "SATURATION"
        '
        'btn_Intensity
        '
        Me.btn_Intensity.AutoSize = False
        Me.btn_Intensity.BackColor = System.Drawing.Color.Transparent
        Me.btn_Intensity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Intensity.Image = CType(resources.GetObject("btn_Intensity.Image"), System.Drawing.Image)
        Me.btn_Intensity.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Intensity.Name = "btn_Intensity"
        Me.btn_Intensity.Size = New System.Drawing.Size(40, 36)
        Me.btn_Intensity.Text = "INTENSITY"
        '
        'btn_HSI
        '
        Me.btn_HSI.AutoSize = False
        Me.btn_HSI.BackColor = System.Drawing.Color.Transparent
        Me.btn_HSI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_HSI.Image = CType(resources.GetObject("btn_HSI.Image"), System.Drawing.Image)
        Me.btn_HSI.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_HSI.Name = "btn_HSI"
        Me.btn_HSI.Size = New System.Drawing.Size(40, 36)
        Me.btn_HSI.Text = "HSI"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.WindowText
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.effect_Text})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(329, 39)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'effect_Text
        '
        Me.effect_Text.AutoSize = False
        Me.effect_Text.BackColor = System.Drawing.Color.Transparent
        Me.effect_Text.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.effect_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.effect_Text.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.effect_Text.Image = CType(resources.GetObject("effect_Text.Image"), System.Drawing.Image)
        Me.effect_Text.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.effect_Text.Name = "effect_Text"
        Me.effect_Text.Size = New System.Drawing.Size(320, 36)
        Me.effect_Text.Text = "IMAGE EFFECTS"
        '
        'btn_Panel_Hide
        '
        Me.btn_Panel_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Panel_Hide.Font = New System.Drawing.Font("Segoe UI Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Panel_Hide.Location = New System.Drawing.Point(625, 61)
        Me.btn_Panel_Hide.Name = "btn_Panel_Hide"
        Me.btn_Panel_Hide.Size = New System.Drawing.Size(19, 480)
        Me.btn_Panel_Hide.TabIndex = 6
        Me.btn_Panel_Hide.Text = ">>>>"
        Me.btn_Panel_Hide.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REFRESHToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(122, 26)
        '
        'REFRESHToolStripMenuItem1
        '
        Me.REFRESHToolStripMenuItem1.Name = "REFRESHToolStripMenuItem1"
        Me.REFRESHToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.REFRESHToolStripMenuItem1.Text = "REFRESH"
        '
        'checkbox_EditMode
        '
        Me.checkbox_EditMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkbox_EditMode.AutoSize = True
        Me.checkbox_EditMode.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.checkbox_EditMode.Location = New System.Drawing.Point(470, 32)
        Me.checkbox_EditMode.Name = "checkbox_EditMode"
        Me.checkbox_EditMode.Size = New System.Drawing.Size(168, 17)
        Me.checkbox_EditMode.TabIndex = 7
        Me.checkbox_EditMode.Text = "PERMANENT APPLY EFFECTS"
        Me.checkbox_EditMode.UseVisualStyleBackColor = False
        '
        'Main_Form
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(646, 566)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.btn_Panel_Hide)
        Me.Controls.Add(Me.checkbox_EditMode)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Img_preview)
        Me.Controls.Add(Me.Tool_strip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.panel_Image)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DIGITAL SIGNAL PROCESSING IMAGE (EFFECTS TESTING ONLY)"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Tool_strip.ResumeLayout(False)
        Me.Tool_strip.PerformLayout()
        CType(Me.Img_preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.context_Menu.ResumeLayout(False)
        Me.panel_Image.ResumeLayout(False)
        Me.Filters_grp.ResumeLayout(False)
        Me.Filters_grp.PerformLayout()
        Me.threshold_grp.ResumeLayout(False)
        Me.threshold_grp.PerformLayout()
        CType(Me.input03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.input02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.input01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.histogram_grp.ResumeLayout(False)
        CType(Me.Histogram_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.color_Pick.ResumeLayout(False)
        Me.color_Pick.PerformLayout()
        CType(Me.Slide_Set, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Effect_Tools.ResumeLayout(False)
        Me.Effect_Tools.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Tool_strip As System.Windows.Forms.ToolStrip
    Friend WithEvents Btn_Import As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_ClearAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents Img_preview As System.Windows.Forms.PictureBox
    Friend WithEvents status_indicator As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents panel_Image As System.Windows.Forms.Panel
    Friend WithEvents Menu_Import As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_Restore As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents color_Text As System.Windows.Forms.Label
    Friend WithEvents Slide_Set As System.Windows.Forms.TrackBar
    Friend WithEvents HELPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Effect_Tools As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_RGB As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Equalizer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Negative As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Threshold As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Power As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Logarithmic As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_AntiLog As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_BitPlaneSlicing As System.Windows.Forms.ToolStripButton
    Friend WithEvents effect_Text As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btn_Pick As System.Windows.Forms.Button
    Friend WithEvents color_Disp As System.Windows.Forms.Label
    Friend WithEvents color_Pick As System.Windows.Forms.GroupBox
    Friend WithEvents histogram_grp As System.Windows.Forms.GroupBox
    Friend WithEvents threshold_grp As System.Windows.Forms.GroupBox
    Friend WithEvents Histogram_Preview As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents input01 As System.Windows.Forms.TrackBar
    Friend WithEvents btn_pixel_Values As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Img_Save As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SAVEIMAGEASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_Panel_Hide As System.Windows.Forms.Button
    Friend WithEvents btn_GrayLevelSlicing As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Root As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents input03 As System.Windows.Forms.TrackBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents input02 As System.Windows.Forms.TrackBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents context_Menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SAVEASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REFRESHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents REFRESHToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents checkbox_EditMode As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Filtering As System.Windows.Forms.ToolStripButton
    Friend WithEvents Filters_grp As System.Windows.Forms.GroupBox
    Friend WithEvents combo_Filter As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Filter As System.Windows.Forms.Label
    Friend WithEvents combo_Filter2 As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Undo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ADDONSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DIGITALSIGNALPROCESSINGIMAGEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_Hue As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Saturation As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Intensity As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_HSI As System.Windows.Forms.ToolStripButton

End Class
