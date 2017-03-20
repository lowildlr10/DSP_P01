Public Class GUI_Control_Setter
    Private Effect_Toggle As Integer = 0

    Public Sub input_Effect_Toggle(ByVal toggle As Integer)
        Effect_Toggle = toggle
    End Sub

    Public Sub RGB_Effect()
        Main_Form.effect_Text.Text = "RGB EFFECTS"
        Main_Form.color_Pick.Text = "CONVERT TO RGB"
        Main_Form.color_Pick.Visible = True
        Main_Form.color_Pick.Enabled = True
        Main_Form.histogram_grp.Visible = True
        Main_Form.histogram_grp.Enabled = True
        Main_Form.threshold_grp.Visible = False
        Main_Form.threshold_grp.Enabled = False
        Main_Form.Filters_grp.Visible = False
        Main_Form.Filters_grp.Enabled = False
        Effect_Toggle = 1
    End Sub

    Public Sub Equ_Effect()
        Main_Form.effect_Text.Text = "EQUALIZATION EFFECTS"
        Main_Form.color_Pick.Text = "CONVERT TO EQUILIZED RGB"
        Main_Form.color_Pick.Visible = True
        Main_Form.color_Pick.Enabled = True
        Main_Form.histogram_grp.Visible = True
        Main_Form.histogram_grp.Enabled = True
        Main_Form.threshold_grp.Visible = False
        Main_Form.threshold_grp.Enabled = False
        Main_Form.Filters_grp.Visible = False
        Main_Form.Filters_grp.Enabled = False
        Effect_Toggle = 2
    End Sub

    Public Sub Neg_Effect()
        Main_Form.effect_Text.Text = "NEGATIVE EFFECTS"
        Main_Form.color_Pick.Text = "CONVERT TO NEGATIVE RGB"
        Main_Form.color_Pick.Visible = True
        Main_Form.color_Pick.Enabled = True
        Main_Form.histogram_grp.Visible = True
        Main_Form.histogram_grp.Enabled = True
        Main_Form.threshold_grp.Visible = False
        Main_Form.threshold_grp.Enabled = False
        Main_Form.Filters_grp.Visible = False
        Main_Form.Filters_grp.Enabled = False
        Effect_Toggle = 3
    End Sub

    Public Sub Thr_Effect()
        Main_Form.effect_Text.Text = "THRESHOLD EFFECTS"
        Main_Form.color_Pick.Text = "CONVERT TO THRESHOLD RGB"
        Main_Form.threshold_grp.Text = "THRESHOLD VALUE"
        Main_Form.color_Pick.Visible = True
        Main_Form.color_Pick.Enabled = True
        Main_Form.histogram_grp.Visible = True
        Main_Form.histogram_grp.Enabled = True
        Main_Form.threshold_grp.Visible = True
        Main_Form.threshold_grp.Enabled = True
        Main_Form.Label1.Visible = False
        Main_Form.Label3.Visible = False
        Main_Form.Label4.Visible = False
        Main_Form.Label6.Visible = False
        Main_Form.input01.Visible = False
        Main_Form.input03.Visible = False
        Main_Form.Filters_grp.Visible = False
        Main_Form.Filters_grp.Enabled = False
        Main_Form.Label5.Text = "INPUT:"
        Effect_Toggle = 4
        Main_Form.input02.Maximum = 255
        Main_Form.input02.Minimum = 0
        Main_Form.input02.Value = 0
        Main_Form.Label2.Text = 0
    End Sub

    Public Sub Pow_Effect()
        Main_Form.effect_Text.Text = "POWER LAW EFFECTS"
        Main_Form.color_Pick.Text = "CONVERT TO POWER RGB"
        Main_Form.threshold_grp.Text = "POWER LAW VALUE (X^n)"
        Main_Form.color_Pick.Visible = True
        Main_Form.color_Pick.Enabled = True
        Main_Form.histogram_grp.Visible = True
        Main_Form.histogram_grp.Enabled = True
        Main_Form.threshold_grp.Visible = True
        Main_Form.threshold_grp.Enabled = True
        Main_Form.Label1.Visible = False
        Main_Form.Label3.Visible = False
        Main_Form.Label4.Visible = False
        Main_Form.Label6.Visible = False
        Main_Form.input01.Visible = False
        Main_Form.input03.Visible = False
        Main_Form.Filters_grp.Visible = False
        Main_Form.Filters_grp.Enabled = False
        Main_Form.Label5.Text = "POWER:"
        Effect_Toggle = 5
        Main_Form.input02.Maximum = 25
        Main_Form.input02.Minimum = 0
        Main_Form.input02.Value = 0
        Main_Form.Label2.Text = 0
    End Sub

    Public Sub Log_Effect()
        Main_Form.effect_Text.Text = "LOGARITHMIC EFFECTS"
        Main_Form.color_Pick.Text = "CONVERT TO LOGARITHMIC RGB"
        Main_Form.color_Pick.Visible = True
        Main_Form.color_Pick.Enabled = True
        Main_Form.histogram_grp.Visible = True
        Main_Form.histogram_grp.Enabled = True
        Main_Form.threshold_grp.Visible = False
        Main_Form.threshold_grp.Enabled = False
        Main_Form.Filters_grp.Visible = False
        Main_Form.Filters_grp.Enabled = False
        Effect_Toggle = 6
    End Sub

    Public Sub Root_Effect()
        Main_Form.effect_Text.Text = "ROOT EFFECTS"
        Main_Form.color_Pick.Text = "CONVERT TO ROOT RGB"
        Main_Form.threshold_grp.Text = "ROOT VALUE (X^(1/n))"
        Main_Form.color_Pick.Visible = True
        Main_Form.color_Pick.Enabled = True
        Main_Form.histogram_grp.Visible = True
        Main_Form.histogram_grp.Enabled = True
        Main_Form.threshold_grp.Visible = True
        Main_Form.threshold_grp.Enabled = True
        Main_Form.Label1.Visible = False
        Main_Form.Label3.Visible = False
        Main_Form.Label4.Visible = False
        Main_Form.Label6.Visible = False
        Main_Form.input01.Visible = False
        Main_Form.input03.Visible = False
        Main_Form.Filters_grp.Visible = False
        Main_Form.Filters_grp.Enabled = False
        Main_Form.Label5.Text = "ROOT:"
        Effect_Toggle = 7
        Main_Form.Label2.Text = Main_Form.input02.Value / 10000
        Main_Form.input02.Minimum = 0
        Main_Form.input02.Maximum = 10000
        Main_Form.input02.Value = 0
        Main_Form.Label2.Text = 0
    End Sub

    Public Sub AntiLog_Effect()
        Main_Form.effect_Text.Text = "ANTI LOGARITHMIC EFFECTS"
        Main_Form.color_Pick.Text = "CONVERT TO ANTI LOGARITHMIC RGB"
        Main_Form.color_Pick.Visible = True
        Main_Form.color_Pick.Enabled = True
        Main_Form.histogram_grp.Visible = True
        Main_Form.histogram_grp.Enabled = True
        Main_Form.threshold_grp.Visible = False
        Main_Form.threshold_grp.Enabled = False
        Main_Form.Filters_grp.Visible = False
        Main_Form.Filters_grp.Enabled = False
        Effect_Toggle = 8
    End Sub

    Public Sub Graylevel_Effect()
        Main_Form.effect_Text.Text = "GRAYLEVEL SLICING EFFECTS"
        Main_Form.color_Pick.Text = "CONVERT TO GRAYLEVEL RGB"
        Main_Form.threshold_grp.Text = "GRAYLEVEL VALUES"
        Main_Form.color_Pick.Visible = True
        Main_Form.color_Pick.Enabled = True
        Main_Form.histogram_grp.Visible = True
        Main_Form.histogram_grp.Enabled = True
        Main_Form.threshold_grp.Visible = True
        Main_Form.threshold_grp.Enabled = True
        Main_Form.Label1.Visible = True
        Main_Form.Label3.Visible = True
        Main_Form.Label4.Visible = True
        Main_Form.Label6.Visible = True
        Main_Form.input01.Visible = True
        Main_Form.input03.Visible = True
        Main_Form.Label4.Text = "MIN:"
        Main_Form.Label6.Text = "EQ VAL:"
        Main_Form.Label5.Text = "MAX:"
        Main_Form.Label4.Visible = True
        Main_Form.Label6.Visible = True
        Main_Form.Filters_grp.Visible = False
        Main_Form.Filters_grp.Enabled = False
        Effect_Toggle = 9
        Main_Form.Label2.Text = Main_Form.input02.Value
        Main_Form.input02.Maximum = 255
        Main_Form.input02.Minimum = 0
        Main_Form.input01.Value = 0
        Main_Form.Label1.Text = 0
        Main_Form.input02.Value = 0
        Main_Form.Label2.Text = 0
        Main_Form.input03.Value = 0
        Main_Form.Label3.Text = 0
    End Sub

    Public Sub BitPlane_Effect()
        Main_Form.effect_Text.Text = "BITPLANE SLICING EFFECTS"
        Main_Form.color_Pick.Text = "CONVERT TO BITPLANE RGB"
        Main_Form.color_Pick.Visible = True
        Main_Form.color_Pick.Enabled = True
        Main_Form.histogram_grp.Visible = True
        Main_Form.histogram_grp.Enabled = True
        Main_Form.threshold_grp.Visible = True
        Main_Form.threshold_grp.Enabled = True
        Main_Form.Label1.Visible = False
        Main_Form.Label3.Visible = False
        Main_Form.Label4.Visible = False
        Main_Form.Label6.Visible = False
        Main_Form.input01.Visible = False
        Main_Form.input03.Visible = False
        Main_Form.Filters_grp.Visible = False
        Main_Form.Filters_grp.Enabled = False
        Main_Form.Label5.Text = "BIT:"
        Effect_Toggle = 10
        Main_Form.input02.Maximum = 8
        Main_Form.input02.Minimum = 1
        Main_Form.input02.Value = 1
        Main_Form.Label2.Text = 1 & "st"
    End Sub

    Public Sub Filtering_Effect()
        Main_Form.effect_Text.Text = "FILTERING EFFECTS"
        Main_Form.color_Pick.Text = "CONVERT TO SPATIAL FILTERING RGB"
        Main_Form.color_Pick.Visible = True
        Main_Form.color_Pick.Enabled = True
        Main_Form.histogram_grp.Visible = True
        Main_Form.histogram_grp.Enabled = True
        Main_Form.threshold_grp.Visible = False
        Main_Form.threshold_grp.Enabled = False
        Main_Form.Filters_grp.Visible = True
        Main_Form.Filters_grp.Enabled = True
        Main_Form.combo_Filter.Text = Nothing
        Main_Form.combo_Filter2.Text = Nothing
        Main_Form.lbl_Filter.Text = Nothing
    End Sub

    Public Sub Hue_Effect()
        Main_Form.effect_Text.Text = "HUE EFFECTS"
        Main_Form.color_Pick.Text = "CONVERT TO HUE RGB"
        Main_Form.color_Pick.Visible = True
        Main_Form.color_Pick.Enabled = True
        Main_Form.histogram_grp.Visible = True
        Main_Form.histogram_grp.Enabled = True
        Main_Form.threshold_grp.Visible = False
        Main_Form.threshold_grp.Enabled = False
        Main_Form.Filters_grp.Visible = False
        Main_Form.Filters_grp.Enabled = False
        Effect_Toggle = 12
    End Sub

    Public Sub Saturation_Effect()
        Main_Form.effect_Text.Text = "SATURATION EFFECTS"
        Main_Form.color_Pick.Text = "CONVERT TO SATURATION RGB"
        Main_Form.color_Pick.Visible = True
        Main_Form.color_Pick.Enabled = True
        Main_Form.histogram_grp.Visible = True
        Main_Form.histogram_grp.Enabled = True
        Main_Form.threshold_grp.Visible = False
        Main_Form.threshold_grp.Enabled = False
        Main_Form.Filters_grp.Visible = False
        Main_Form.Filters_grp.Enabled = False
        Effect_Toggle = 13
    End Sub

    Public Sub Intensity_Effect()
        Main_Form.effect_Text.Text = "INTENSITY EFFECTS"
        Main_Form.color_Pick.Text = "CONVERT TO INTENSITY RGB"
        Main_Form.color_Pick.Visible = True
        Main_Form.color_Pick.Enabled = True
        Main_Form.histogram_grp.Visible = True
        Main_Form.histogram_grp.Enabled = True
        Main_Form.threshold_grp.Visible = False
        Main_Form.threshold_grp.Enabled = False
        Main_Form.Filters_grp.Visible = False
        Main_Form.Filters_grp.Enabled = False
        Effect_Toggle = 14
    End Sub

    Public Sub HSI_Effect()
        Main_Form.effect_Text.Text = "HSI EFFECTS"
        Main_Form.color_Pick.Text = "CONVERT TO HSI"
        Main_Form.color_Pick.Visible = True
        Main_Form.color_Pick.Enabled = True
        Main_Form.histogram_grp.Visible = True
        Main_Form.histogram_grp.Enabled = True
        Main_Form.threshold_grp.Visible = False
        Main_Form.threshold_grp.Enabled = False
        Main_Form.Filters_grp.Visible = False
        Main_Form.Filters_grp.Enabled = False
        Effect_Toggle = 15
    End Sub

    Public Sub CLEAR_ALL()
        Main_Form.color_Pick.Text = "CONVERT TO RGB"
        Main_Form.color_Pick.Visible = False
        Main_Form.color_Pick.Enabled = False
        Main_Form.color_Text.Text = "ORIGINAL"
        Main_Form.histogram_grp.Visible = False
        Main_Form.histogram_grp.Enabled = False
        Main_Form.threshold_grp.Visible = False
        Main_Form.threshold_grp.Enabled = False
        Main_Form.Filters_grp.Visible = False
        Main_Form.Filters_grp.Enabled = False
        Main_Form.combo_Filter.Text = Nothing
        Main_Form.combo_Filter2.Items.Clear()
        Effect_Toggle = 0
        Main_Form.Img_preview.Visible = False
        Main_Form.panel_Image.Enabled = False
        Main_Form.effect_Text.Text = "IMAGE EFFECTS"
        Main_Form.Slide_Set.Value = 0
        Main_Form.input01.Value = 0
        Main_Form.Img_preview.BackgroundImage = Nothing
        Main_Form.status_indicator.Text = "CLEARED"
        Main_Form.panel_Image.Enabled = False
        Main_Form.Slide_Set.Value = 0
        Main_Form.color_Disp.BackColor = Color.DimGray
        Main_Form.color_Text.Text = "ORIGINAL"
        Main_Form.color_Text.ForeColor = Color.Black
        Main_Form.Histogram_Preview.BackgroundImage = Nothing
        Main_Form.Refresh()
    End Sub

    Public Sub Restore()
        Main_Form.panel_Image.Visible = False
        Main_Form.panel_Image.Visible = True
        Main_Form.Histogram_Preview.BackgroundImage = Nothing
        Main_Form.color_Disp.BackColor = Color.DimGray
        Main_Form.color_Text.Text = "ORIGINAL"
        Main_Form.color_Text.ForeColor = Color.Black
        Main_Form.status_indicator.Text = "RESTORED"
        Main_Form.Slide_Set.Value = 0
        Main_Form.combo_Filter2.Text = ""
        Main_Form.combo_Filter.Text = ""
    End Sub

    Public Function main_Slide_Scroll() As Integer
        Dim t As Integer
        If Main_Form.Slide_Set.Value = 0 Then
            Main_Form.color_Text.Text = "ORIGINAL"
            Main_Form.color_Text.ForeColor = Color.Black
            Main_Form.color_Disp.BackColor = Color.DimGray
            t = 0
        ElseIf Main_Form.Slide_Set.Value = 1 Then
            Main_Form.color_Text.Text = "BLACK AND WHITE"
            Main_Form.color_Text.ForeColor = Color.Black
            Main_Form.color_Disp.BackColor = Color.Black
            t = 1
        ElseIf Main_Form.Slide_Set.Value = 2 Then
            Main_Form.color_Text.Text = "RED"
            Main_Form.color_Text.ForeColor = Color.Red
            Main_Form.color_Disp.BackColor = Color.Red
            t = 2
        ElseIf Main_Form.Slide_Set.Value = 3 Then
            Main_Form.color_Text.Text = "GREEN"
            Main_Form.color_Text.ForeColor = Color.Green
            Main_Form.color_Disp.BackColor = Color.Green
            t = 3
        ElseIf Main_Form.Slide_Set.Value = 4 Then
            Main_Form.color_Text.Text = "BLUE"
            Main_Form.color_Text.ForeColor = Color.Blue
            Main_Form.color_Disp.BackColor = Color.Blue
            t = 4
        Else

        End If

        Return t
    End Function
End Class
