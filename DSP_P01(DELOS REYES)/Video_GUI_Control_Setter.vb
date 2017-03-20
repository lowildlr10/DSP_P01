Public Class Video_GUI_Control_Setter
    Private Effect_Toggle As Integer = 0

    Public Sub input_Effect_Toggle(ByVal toggle As Integer)
        Effect_Toggle = toggle
    End Sub

    Public Sub RGB_Effect()
        Main_Video.lbl_Effect.Text = "RGB EFFECTS"
        Main_Video.color_Pick.Text = "CONVERT TO RGB"
        Main_Video.color_Pick.Visible = True
        Main_Video.color_Pick.Enabled = True
        Main_Video.threshold_grp.Visible = False
        Main_Video.threshold_grp.Enabled = False
        Effect_Toggle = 1
    End Sub

    Public Sub Equalization_Effect()
        Main_Video.lbl_Effect.Text = "EQUALIZATION EFFECTS"
        Main_Video.color_Pick.Text = "CONVERT TO EQUALIZATION RGB"
        Main_Video.color_Pick.Visible = True
        Main_Video.color_Pick.Enabled = True
        Main_Video.threshold_grp.Visible = False
        Main_Video.threshold_grp.Enabled = False
        Effect_Toggle = 2
    End Sub

    Public Sub Negative_Effect()
        Main_Video.lbl_Effect.Text = "NEGATIVE EFFECTS"
        Main_Video.color_Pick.Text = "CONVERT TO NEGATIVE RGB"
        Main_Video.color_Pick.Visible = True
        Main_Video.color_Pick.Enabled = True
        Main_Video.threshold_grp.Visible = False
        Main_Video.threshold_grp.Enabled = False
        Effect_Toggle = 3
    End Sub

    Public Sub Threshold_Effect()
        Main_Video.lbl_Effect.Text = "THRESHOLD EFFECTS"
        Main_Video.color_Pick.Text = "CONVERT TO THRESHOLD RGB"
        Main_Video.color_Pick.Visible = True
        Main_Video.color_Pick.Enabled = True
        Main_Video.threshold_grp.Visible = True
        Main_Video.threshold_grp.Enabled = True
        Main_Video.input01.Enabled = False
        Main_Video.input01.Visible = False
        Main_Video.input02.Enabled = True
        Main_Video.input02.Visible = True
        Main_Video.input03.Enabled = False
        Main_Video.input03.Visible = False
        Main_Video.Label4.Visible = False
        Main_Video.Label5.Visible = True
        Main_Video.Label6.Visible = False
        Main_Video.Label5.Text = "INPUT:"
        Main_Video.Label1.Visible = False
        Main_Video.Label2.Visible = True
        Main_Video.Label3.Visible = False
        Main_Video.input02.Maximum = 255
        Main_Video.input02.Minimum = 0
        Main_Video.input02.Value = 0
        Main_Video.Label2.Text = 0
        Effect_Toggle = 4
    End Sub

    Public Sub Power_Effect()
        Main_Video.lbl_Effect.Text = "POWER EFFECTS"
        Main_Video.color_Pick.Text = "CONVERT TO POWER RGB"
        Main_Video.color_Pick.Visible = True
        Main_Video.color_Pick.Enabled = True
        Main_Video.threshold_grp.Visible = True
        Main_Video.threshold_grp.Enabled = True
        Main_Video.input01.Enabled = False
        Main_Video.input01.Visible = False
        Main_Video.input02.Enabled = True
        Main_Video.input02.Visible = True
        Main_Video.input03.Enabled = False
        Main_Video.input03.Visible = False
        Main_Video.Label4.Visible = False
        Main_Video.Label5.Visible = True
        Main_Video.Label6.Visible = False
        Main_Video.Label5.Text = "POWER:"
        Main_Video.Label1.Visible = False
        Main_Video.Label2.Visible = True
        Main_Video.Label3.Visible = False
        Main_Video.input02.Maximum = 25
        Main_Video.input02.Minimum = 0
        Main_Video.input02.Value = 0
        Main_Video.Label2.Text = 0
        Effect_Toggle = 5
    End Sub

    Public Sub Root_Effect()
        Main_Video.lbl_Effect.Text = "ROOT EFFECTS"
        Main_Video.color_Pick.Text = "CONVERT TO ROOT RGB"
        Main_Video.color_Pick.Visible = True
        Main_Video.color_Pick.Enabled = True
        Main_Video.threshold_grp.Visible = True
        Main_Video.threshold_grp.Enabled = True
        Main_Video.input01.Enabled = False
        Main_Video.input01.Visible = False
        Main_Video.input02.Enabled = True
        Main_Video.input02.Visible = True
        Main_Video.input03.Enabled = False
        Main_Video.input03.Visible = False
        Main_Video.Label4.Visible = False
        Main_Video.Label5.Visible = True
        Main_Video.Label6.Visible = False
        Main_Video.Label5.Text = "ROOT:"
        Main_Video.Label1.Visible = False
        Main_Video.Label2.Visible = True
        Main_Video.Label3.Visible = False
        Main_Video.Label2.Text = Main_Video.input02.Value / 10000
        Main_Video.input02.Maximum = 10000
        Main_Video.input02.Minimum = 0
        Main_Video.input02.Value = 0
        Main_Video.Label2.Text = 0
        Effect_Toggle = 6
    End Sub

    Public Sub Logarithm_Effect()
        Main_Video.lbl_Effect.Text = "LOGARITHM EFFECTS"
        Main_Video.color_Pick.Text = "CONVERT TO LOGARITHM RGB"
        Main_Video.color_Pick.Visible = True
        Main_Video.color_Pick.Enabled = True
        Main_Video.threshold_grp.Visible = False
        Main_Video.threshold_grp.Enabled = False
        Effect_Toggle = 7
    End Sub

    Public Sub AntiLogarithm_Effect()
        Main_Video.lbl_Effect.Text = "ANTI-LOGARITHM EFFECTS"
        Main_Video.color_Pick.Text = "CONVERT TO ANTI-LOGARITHM RGB"
        Main_Video.color_Pick.Visible = True
        Main_Video.color_Pick.Enabled = True
        Main_Video.threshold_grp.Visible = False
        Main_Video.threshold_grp.Enabled = False
        Effect_Toggle = 8
    End Sub

    Public Sub GraylevelSlicing_Effect()
        Main_Video.lbl_Effect.Text = "GRAYLEVEL SLICING EFFECTS"
        Main_Video.color_Pick.Text = "CONVERT TO GRAYLEVEL RGB"
        Main_Video.threshold_grp.Text = "GRAYLEVEL VALUES"
        Main_Video.color_Pick.Visible = True
        Main_Video.color_Pick.Enabled = True
        Main_Video.threshold_grp.Visible = True
        Main_Video.threshold_grp.Enabled = True
        Main_Video.Label1.Visible = True
        Main_Video.Label3.Visible = True
        Main_Video.Label4.Visible = True
        Main_Video.Label6.Visible = True
        Main_Video.input01.Visible = True
        Main_Video.input02.Visible = True
        Main_Video.input03.Visible = True
        Main_Video.input01.Enabled = True
        Main_Video.input02.Enabled = True
        Main_Video.input03.Enabled = True
        Main_Video.Label4.Text = "MIN:"
        Main_Video.Label6.Text = "EQ VAL:"
        Main_Video.Label5.Text = "MAX:"
        Main_Video.Label4.Visible = True
        Main_Video.Label6.Visible = True
        Main_Video.Label2.Text = Main_Form.input02.Value
        Main_Video.input02.Maximum = 255
        Main_Video.input02.Minimum = 0
        Main_Video.input01.Value = 0
        Main_Video.Label1.Text = 0
        Main_Video.input02.Value = 0
        Main_Video.Label2.Text = 0
        Main_Video.input03.Value = 0
        Main_Video.Label3.Text = 0
        Effect_Toggle = 9
    End Sub

    Public Sub BitPlaneSlicing_Effect()
        Main_Video.lbl_Effect.Text = "BITPLANE SLICING EFFECTS"
        Main_Video.color_Pick.Text = "CONVERT TO BITPLANE RGB"
        Main_Video.color_Pick.Visible = True
        Main_Video.color_Pick.Enabled = True
        Main_Video.threshold_grp.Visible = True
        Main_Video.threshold_grp.Enabled = True
        Main_Video.Label1.Visible = False
        Main_Video.Label3.Visible = False
        Main_Video.Label4.Visible = False
        Main_Video.Label6.Visible = False
        Main_Video.input01.Visible = False
        Main_Video.input03.Visible = False
        Main_Video.Label5.Text = "BIT:"
        Main_Video.input02.Maximum = 8
        Main_Video.input02.Minimum = 1
        Main_Video.input02.Value = 1
        Main_Video.Label2.Text = 1 & "st"
        Effect_Toggle = 10
    End Sub

    Public Sub HSI_Effect()
        Main_Video.lbl_Effect.Text = "HSI EFFECTS"
        Main_Video.color_Pick.Text = "CONVERT TO HSI"
        Main_Video.color_Pick.Visible = True
        Main_Video.color_Pick.Enabled = True
        Main_Video.threshold_grp.Visible = False
        Main_Video.threshold_grp.Enabled = False
        Effect_Toggle = 11
    End Sub

    Public Function main_Slide_Scroll() As Integer
        Dim t As Integer
        If Main_Video.Slide_Set.Value = 0 Then
            Main_Video.color_Text.Text = "ORIGINAL"
            Main_Video.color_Text.ForeColor = Color.Black
            Main_Video.color_Disp.BackColor = Color.DimGray
            t = 0
        ElseIf Main_Video.Slide_Set.Value = 1 Then
            Main_Video.color_Text.Text = "BLACK AND WHITE"
            Main_Video.color_Text.ForeColor = Color.Black
            Main_Video.color_Disp.BackColor = Color.Black
            t = 1
        ElseIf Main_Video.Slide_Set.Value = 2 Then
            Main_Video.color_Text.Text = "RED"
            Main_Video.color_Text.ForeColor = Color.Red
            Main_Video.color_Disp.BackColor = Color.Red
            t = 2
        ElseIf Main_Video.Slide_Set.Value = 3 Then
            Main_Video.color_Text.Text = "GREEN"
            Main_Video.color_Text.ForeColor = Color.Green
            Main_Video.color_Disp.BackColor = Color.Green
            t = 3
        ElseIf Main_Video.Slide_Set.Value = 4 Then
            Main_Video.color_Text.Text = "BLUE"
            Main_Video.color_Text.ForeColor = Color.Blue
            Main_Video.color_Disp.BackColor = Color.Blue
            t = 4
        Else

        End If

        Return t
    End Function
End Class
