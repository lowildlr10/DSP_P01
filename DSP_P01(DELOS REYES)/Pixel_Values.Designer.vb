<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pixel_Values
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pixel_Values))
        Me.generated_Pixel_Values = New System.Windows.Forms.RichTextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btn_Save = New System.Windows.Forms.ToolStripButton
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.btn_Close = New System.Windows.Forms.Button
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'generated_Pixel_Values
        '
        Me.generated_Pixel_Values.BackColor = System.Drawing.SystemColors.Menu
        Me.generated_Pixel_Values.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.generated_Pixel_Values.Location = New System.Drawing.Point(12, 38)
        Me.generated_Pixel_Values.Name = "generated_Pixel_Values"
        Me.generated_Pixel_Values.Size = New System.Drawing.Size(786, 454)
        Me.generated_Pixel_Values.TabIndex = 2
        Me.generated_Pixel_Values.Text = ""
        Me.generated_Pixel_Values.WordWrap = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_Save})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(810, 35)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_Save
        '
        Me.btn_Save.AutoSize = False
        Me.btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_Save.Image = CType(resources.GetObject("btn_Save.Image"), System.Drawing.Image)
        Me.btn_Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(40, 33)
        Me.btn_Save.Text = "SAVE ALL AS..."
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(12, 499)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(786, 30)
        Me.btn_Close.TabIndex = 4
        Me.btn_Close.Text = "CLOSE"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'Pixel_Values
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(810, 541)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.generated_Pixel_Values)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Pixel_Values"
        Me.Opacity = 0.9
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PIXEL VALUES"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents generated_Pixel_Values As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btn_Save As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btn_Close As System.Windows.Forms.Button
End Class
