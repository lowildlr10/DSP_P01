<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Video
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Video))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.prg_Status = New System.Windows.Forms.ToolStripProgressBar
        Me.lbl_Status = New System.Windows.Forms.ToolStripStatusLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.color_Pick = New System.Windows.Forms.GroupBox
        Me.color_Disp = New System.Windows.Forms.Label
        Me.btn_Pick = New System.Windows.Forms.Button
        Me.color_Text = New System.Windows.Forms.Label
        Me.Slide_Set = New System.Windows.Forms.TrackBar
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip
        Me.lbl_Effect = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.histogram_grp = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Capture_Display = New System.Windows.Forms.PictureBox
        Me.Display_Effect = New System.Windows.Forms.PictureBox
        Me.Histogram_Preview = New System.Windows.Forms.PictureBox
        Me.btn_RGB = New System.Windows.Forms.ToolStripButton
        Me.btn_Equalization = New System.Windows.Forms.ToolStripButton
        Me.btn_Negative = New System.Windows.Forms.ToolStripButton
        Me.btn_Threshold = New System.Windows.Forms.ToolStripButton
        Me.btn_Power = New System.Windows.Forms.ToolStripButton
        Me.btn_Root = New System.Windows.Forms.ToolStripButton
        Me.btn_Logarithm = New System.Windows.Forms.ToolStripButton
        Me.btn_AntiLogarithm = New System.Windows.Forms.ToolStripButton
        Me.btn_GraylevelSlicing = New System.Windows.Forms.ToolStripButton
        Me.btn_BitPlaneSlcing = New System.Windows.Forms.ToolStripButton
        Me.btn_HSI = New System.Windows.Forms.ToolStripButton
        Me.btn_StartStop = New System.Windows.Forms.ToolStripButton
        Me.lbl_Time = New System.Windows.Forms.ToolStripLabel
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.threshold_grp.SuspendLayout()
        CType(Me.input03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.input02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.input01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.color_Pick.SuspendLayout()
        CType(Me.Slide_Set, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.histogram_grp.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Capture_Display, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Display_Effect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Histogram_Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_StartStop, Me.ToolStripSeparator2, Me.lbl_Time})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(683, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.prg_Status, Me.lbl_Status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 588)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(683, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'prg_Status
        '
        Me.prg_Status.AutoSize = False
        Me.prg_Status.MarqueeAnimationSpeed = 50
        Me.prg_Status.Maximum = 10
        Me.prg_Status.Name = "prg_Status"
        Me.prg_Status.Size = New System.Drawing.Size(50, 16)
        Me.prg_Status.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.prg_Status.Visible = False
        '
        'lbl_Status
        '
        Me.lbl_Status.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(43, 17)
        Me.lbl_Status.Text = "READY"
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'threshold_grp
        '
        Me.threshold_grp.BackColor = System.Drawing.SystemColors.ControlDark
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
        Me.threshold_grp.Location = New System.Drawing.Point(183, 167)
        Me.threshold_grp.Name = "threshold_grp"
        Me.threshold_grp.Size = New System.Drawing.Size(488, 76)
        Me.threshold_grp.TabIndex = 10
        Me.threshold_grp.TabStop = False
        Me.threshold_grp.Text = "THRESHOLD VALUE"
        Me.threshold_grp.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
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
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "0"
        '
        'input03
        '
        Me.input03.AutoSize = False
        Me.input03.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.input03.LargeChange = 255
        Me.input03.Location = New System.Drawing.Point(131, 53)
        Me.input03.Maximum = 255
        Me.input03.Name = "input03"
        Me.input03.Size = New System.Drawing.Size(351, 18)
        Me.input03.TabIndex = 12
        Me.input03.TickFrequency = 0
        Me.input03.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "0"
        '
        'input02
        '
        Me.input02.AutoSize = False
        Me.input02.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.input02.LargeChange = 255
        Me.input02.Location = New System.Drawing.Point(131, 35)
        Me.input02.Maximum = 255
        Me.input02.Name = "input02"
        Me.input02.Size = New System.Drawing.Size(351, 18)
        Me.input02.TabIndex = 10
        Me.input02.TickFrequency = 0
        Me.input02.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "0"
        '
        'input01
        '
        Me.input01.AutoSize = False
        Me.input01.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.input01.LargeChange = 255
        Me.input01.Location = New System.Drawing.Point(131, 17)
        Me.input01.Maximum = 255
        Me.input01.Name = "input01"
        Me.input01.Size = New System.Drawing.Size(351, 18)
        Me.input01.TabIndex = 8
        Me.input01.TickFrequency = 0
        Me.input01.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'color_Pick
        '
        Me.color_Pick.BackColor = System.Drawing.SystemColors.ControlDark
        Me.color_Pick.Controls.Add(Me.color_Disp)
        Me.color_Pick.Controls.Add(Me.btn_Pick)
        Me.color_Pick.Controls.Add(Me.color_Text)
        Me.color_Pick.Controls.Add(Me.Slide_Set)
        Me.color_Pick.Enabled = False
        Me.color_Pick.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.color_Pick.Location = New System.Drawing.Point(182, 90)
        Me.color_Pick.Name = "color_Pick"
        Me.color_Pick.Size = New System.Drawing.Size(488, 71)
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
        Me.btn_Pick.BackColor = System.Drawing.Color.Lime
        Me.btn_Pick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Pick.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Pick.Location = New System.Drawing.Point(340, 26)
        Me.btn_Pick.Name = "btn_Pick"
        Me.btn_Pick.Size = New System.Drawing.Size(142, 29)
        Me.btn_Pick.TabIndex = 7
        Me.btn_Pick.Text = "APPLY"
        Me.btn_Pick.UseVisualStyleBackColor = False
        '
        'color_Text
        '
        Me.color_Text.AutoSize = True
        Me.color_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.color_Text.Location = New System.Drawing.Point(53, 46)
        Me.color_Text.Name = "color_Text"
        Me.color_Text.Size = New System.Drawing.Size(50, 9)
        Me.color_Text.TabIndex = 2
        Me.color_Text.Text = "ORIGINAL"
        '
        'Slide_Set
        '
        Me.Slide_Set.AutoSize = False
        Me.Slide_Set.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Slide_Set.LargeChange = 255
        Me.Slide_Set.Location = New System.Drawing.Point(44, 26)
        Me.Slide_Set.Maximum = 4
        Me.Slide_Set.Name = "Slide_Set"
        Me.Slide_Set.Size = New System.Drawing.Size(290, 18)
        Me.Slide_Set.TabIndex = 0
        Me.Slide_Set.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'ToolStrip3
        '
        Me.ToolStrip3.AutoSize = False
        Me.ToolStrip3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip3.Enabled = False
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_Effect, Me.ToolStripSeparator1, Me.btn_RGB, Me.btn_Equalization, Me.btn_Negative, Me.btn_Threshold, Me.btn_Power, Me.btn_Root, Me.btn_Logarithm, Me.btn_AntiLogarithm, Me.btn_GraylevelSlicing, Me.btn_BitPlaneSlcing, Me.btn_HSI})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 39)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip3.Size = New System.Drawing.Size(683, 39)
        Me.ToolStrip3.TabIndex = 7
        Me.ToolStrip3.Text = "ToolStrip2"
        '
        'lbl_Effect
        '
        Me.lbl_Effect.AutoSize = False
        Me.lbl_Effect.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Effect.Name = "lbl_Effect"
        Me.lbl_Effect.Size = New System.Drawing.Size(200, 36)
        Me.lbl_Effect.Text = "VIDEO EFFECTS"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'histogram_grp
        '
        Me.histogram_grp.Controls.Add(Me.Histogram_Preview)
        Me.histogram_grp.Enabled = False
        Me.histogram_grp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.histogram_grp.Location = New System.Drawing.Point(332, 251)
        Me.histogram_grp.Name = "histogram_grp"
        Me.histogram_grp.Size = New System.Drawing.Size(338, 323)
        Me.histogram_grp.TabIndex = 11
        Me.histogram_grp.TabStop = False
        Me.histogram_grp.Text = "HISTOGRAM"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Display_Effect)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 251)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 323)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LIVE FEED (WITH EFFECTS)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Capture_Display)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(137, 136)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ORIGINAL LIVE FEED"
        '
        'Capture_Display
        '
        Me.Capture_Display.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Capture_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Capture_Display.Location = New System.Drawing.Point(19, 22)
        Me.Capture_Display.Name = "Capture_Display"
        Me.Capture_Display.Size = New System.Drawing.Size(100, 100)
        Me.Capture_Display.TabIndex = 1
        Me.Capture_Display.TabStop = False
        '
        'Display_Effect
        '
        Me.Display_Effect.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Display_Effect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Display_Effect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Display_Effect.Location = New System.Drawing.Point(6, 17)
        Me.Display_Effect.Name = "Display_Effect"
        Me.Display_Effect.Size = New System.Drawing.Size(300, 300)
        Me.Display_Effect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Display_Effect.TabIndex = 3
        Me.Display_Effect.TabStop = False
        '
        'Histogram_Preview
        '
        Me.Histogram_Preview.BackColor = System.Drawing.Color.LightGray
        Me.Histogram_Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Histogram_Preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Histogram_Preview.Location = New System.Drawing.Point(6, 17)
        Me.Histogram_Preview.Name = "Histogram_Preview"
        Me.Histogram_Preview.Size = New System.Drawing.Size(326, 300)
        Me.Histogram_Preview.TabIndex = 0
        Me.Histogram_Preview.TabStop = False
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
        'btn_Equalization
        '
        Me.btn_Equalization.AutoSize = False
        Me.btn_Equalization.BackColor = System.Drawing.Color.Transparent
        Me.btn_Equalization.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Equalization.Image = CType(resources.GetObject("btn_Equalization.Image"), System.Drawing.Image)
        Me.btn_Equalization.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Equalization.Name = "btn_Equalization"
        Me.btn_Equalization.Size = New System.Drawing.Size(40, 36)
        Me.btn_Equalization.Text = "EQUALIZATION"
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
        'btn_Logarithm
        '
        Me.btn_Logarithm.AutoSize = False
        Me.btn_Logarithm.BackColor = System.Drawing.Color.Transparent
        Me.btn_Logarithm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Logarithm.Image = CType(resources.GetObject("btn_Logarithm.Image"), System.Drawing.Image)
        Me.btn_Logarithm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Logarithm.Name = "btn_Logarithm"
        Me.btn_Logarithm.Size = New System.Drawing.Size(40, 36)
        Me.btn_Logarithm.Text = "LOGARITHMIC"
        '
        'btn_AntiLogarithm
        '
        Me.btn_AntiLogarithm.AutoSize = False
        Me.btn_AntiLogarithm.BackColor = System.Drawing.Color.Transparent
        Me.btn_AntiLogarithm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_AntiLogarithm.Image = CType(resources.GetObject("btn_AntiLogarithm.Image"), System.Drawing.Image)
        Me.btn_AntiLogarithm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_AntiLogarithm.Name = "btn_AntiLogarithm"
        Me.btn_AntiLogarithm.Size = New System.Drawing.Size(40, 36)
        Me.btn_AntiLogarithm.Text = "ANTI LOGARITHMIC"
        '
        'btn_GraylevelSlicing
        '
        Me.btn_GraylevelSlicing.AutoSize = False
        Me.btn_GraylevelSlicing.BackColor = System.Drawing.Color.Transparent
        Me.btn_GraylevelSlicing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_GraylevelSlicing.Image = CType(resources.GetObject("btn_GraylevelSlicing.Image"), System.Drawing.Image)
        Me.btn_GraylevelSlicing.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_GraylevelSlicing.Name = "btn_GraylevelSlicing"
        Me.btn_GraylevelSlicing.Size = New System.Drawing.Size(40, 36)
        Me.btn_GraylevelSlicing.Text = "GRAYLEVEL SLICING"
        '
        'btn_BitPlaneSlcing
        '
        Me.btn_BitPlaneSlcing.AutoSize = False
        Me.btn_BitPlaneSlcing.BackColor = System.Drawing.Color.Transparent
        Me.btn_BitPlaneSlcing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_BitPlaneSlcing.Image = CType(resources.GetObject("btn_BitPlaneSlcing.Image"), System.Drawing.Image)
        Me.btn_BitPlaneSlcing.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_BitPlaneSlcing.Name = "btn_BitPlaneSlcing"
        Me.btn_BitPlaneSlcing.Size = New System.Drawing.Size(40, 36)
        Me.btn_BitPlaneSlcing.Text = "BIT PLANE SLICING"
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
        'btn_StartStop
        '
        Me.btn_StartStop.AutoSize = False
        Me.btn_StartStop.BackColor = System.Drawing.Color.Lime
        Me.btn_StartStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_StartStop.Image = Global.DSP_P01_DELOS_REYES_.My.Resources.Resources.play_6_xxl
        Me.btn_StartStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_StartStop.Name = "btn_StartStop"
        Me.btn_StartStop.Size = New System.Drawing.Size(40, 36)
        Me.btn_StartStop.Text = "START CAPTURING"
        '
        'lbl_Time
        '
        Me.lbl_Time.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_Time.Image = Global.DSP_P01_DELOS_REYES_.My.Resources.Resources.page_loader
        Me.lbl_Time.Name = "lbl_Time"
        Me.lbl_Time.Size = New System.Drawing.Size(16, 36)
        Me.lbl_Time.Visible = False
        '
        'Timer2
        '
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'Main_Video
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(683, 610)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.histogram_grp)
        Me.Controls.Add(Me.threshold_grp)
        Me.Controls.Add(Me.ToolStrip3)
        Me.Controls.Add(Me.color_Pick)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main_Video"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DIGITAL SIGNAL PROCESSING VIDEO"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.threshold_grp.ResumeLayout(False)
        Me.threshold_grp.PerformLayout()
        CType(Me.input03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.input02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.input01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.color_Pick.ResumeLayout(False)
        Me.color_Pick.PerformLayout()
        CType(Me.Slide_Set, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.histogram_grp.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Capture_Display, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Display_Effect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Histogram_Preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Capture_Display As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Display_Effect As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents threshold_grp As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents input03 As System.Windows.Forms.TrackBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents input02 As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents input01 As System.Windows.Forms.TrackBar
    Friend WithEvents color_Pick As System.Windows.Forms.GroupBox
    Friend WithEvents color_Disp As System.Windows.Forms.Label
    Friend WithEvents btn_Pick As System.Windows.Forms.Button
    Friend WithEvents color_Text As System.Windows.Forms.Label
    Friend WithEvents Slide_Set As System.Windows.Forms.TrackBar
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_RGB As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Equalization As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Negative As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Threshold As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Power As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Root As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_Logarithm As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_AntiLogarithm As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_GraylevelSlicing As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_BitPlaneSlcing As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_HSI As System.Windows.Forms.ToolStripButton
    Friend WithEvents histogram_grp As System.Windows.Forms.GroupBox
    Friend WithEvents Histogram_Preview As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Effect As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_StartStop As System.Windows.Forms.ToolStripButton
    Friend WithEvents prg_Status As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lbl_Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_Time As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
