Public Class Main_Form

#Region "Variables"
    Private Edit_Mode As Boolean = False
    Private histogram_draw As Boolean = False
    Private setter As New GUI_Control_Setter
    Private Point_Proc As New PointProcessing_Executor
    Private Filter_Proc As New FilterProcessing_Executor
    Private h1 As Histogram_Process
    Private h2 As Histogram_Process
    Private h3 As Histogram_Process
    Private h4 As Histogram_Process
    Private Effect_Toggle As Integer = 0
    Private t As Integer = 0
    Private _hide As Integer = 0
    Private pixel_value As String
    Private filterType As String = ""
    Private dir_file As String
    Private original_image As Bitmap
    Private i As Integer = 0
    Private Redo() As Bitmap
    Private img_width, img_height As Integer
#End Region

#Region "Encapsulation"
    Public Sub _getFilteredHistogram(ByVal _h1, ByVal _h2, ByVal _h3, ByVal _h4, ByVal histo_draw, ByVal pixval, ByVal orig_img)
        histogram_draw = histo_draw
        h1 = _h1
        h2 = _h2
        h3 = _h3
        h4 = _h4
        pixel_value = pixval
        original_image = orig_img
    End Sub

    Public Sub _getFilterType(ByVal _filterType As String)
        filterType = _filterType
    End Sub

    Public Sub _getCustomFilters(ByVal _f() As Single)
        lbl_Filter.Text = "$AVED!"
        Filter_Proc.custom_Filters(_f)
    End Sub
#End Region

#Region "Image Import"
    Private Sub Img_Import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Import.Click
        Dim p1 As Point
        Dim tF As New OpenFileDialog
        tF.Filter = "BITMAP Image .bmp|*.bmp|JPEG Image .jpg|*.jpg|PNG Image .png|*.png|GIF Image .gif|*.gif|ICO Image .ico|*.ico|All Files...|*" '*.bmp|*.bmp

        If tF.ShowDialog = Windows.Forms.DialogResult.OK Then
            dir_file = tF.FileName
            Img_preview.BackgroundImage = Image.FromFile(dir_file)
            original_image = Image.FromFile(dir_file)

            img_width = original_image.Width - 1
            img_height = original_image.Height - 1

            p1.X = 984
            p1.Y = 595
            panel_Image.Show()
            btn_Panel_Hide.Text = "<<<<"
            _hide = 0

            Me.Size = p1
            Me.CenterToScreen()

            status_indicator.Text = "IMPORTED"
        End If

        If dir_file <> "" Then
            panel_Image.Enabled = True
            Img_preview.Visible = True
        End If

        histogram_draw = False
        Refresh()
    End Sub

    Private Sub Menu_Import_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu_Import.Click
        Dim p1 As Point
        Dim tF As New OpenFileDialog
        tF.Filter = "BITMAP Image .bmp|*.bmp|JPEG Image .jpg|*.jpg|PNG Image .png|*.png|GIF Image .gif|*.gif|ICO Image .ico|*.ico|All Files...|*" '*.bmp|*.bmp

        If tF.ShowDialog = Windows.Forms.DialogResult.OK Then
            dir_file = tF.FileName
            Img_preview.BackgroundImage = Image.FromFile(dir_file)
            original_image = Image.FromFile(dir_file)

            img_width = original_image.Width - 1
            img_height = original_image.Height - 1

            p1.X = 984
            p1.Y = 595
            panel_Image.Show()
            btn_Panel_Hide.Text = "<<<<"
            _hide = 0

            Me.Size = p1
            Me.CenterToScreen()

            status_indicator.Text = "IMPORTED"
        End If

        If dir_file <> "" Then
            panel_Image.Enabled = True
            Img_preview.Visible = True
        End If

        histogram_draw = False
        Refresh()
    End Sub

    Private Sub Img_preview_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Img_preview.DragDrop
        Try
            Dim p1 As Point

            dir_file = CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString
            Img_preview.BackgroundImage = Image.FromFile(dir_file)
            original_image = Image.FromFile(dir_file)

            img_width = original_image.Width - 1
            img_height = original_image.Height - 1

            p1.X = 984
            p1.Y = 595
            panel_Image.Show()
            btn_Panel_Hide.Text = "<<<<"
            _hide = 0

            Me.Size = p1
            Me.CenterToScreen()
            status_indicator.Text = "IMPORTED"

            If dir_file <> "" Then
                panel_Image.Enabled = True
                Img_preview.Visible = True
            End If

            Me.Activate()

            histogram_draw = False
            Refresh()
        Catch ex As Exception
            status_indicator.Text = "ERROR"
            MsgBox("IMPORT IMAGE FILE ONLY.", MsgBoxStyle.Exclamation, "ERROR")
        End Try
    End Sub

    Private Sub Img_preview_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Img_preview.DragEnter
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Main_Form_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Try
            Dim p1 As Point

            dir_file = CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString
            Img_preview.BackgroundImage = Image.FromFile(dir_file)
            original_image = Image.FromFile(dir_file)

            img_width = original_image.Width - 1
            img_height = original_image.Height - 1

            p1.X = 984
            p1.Y = 595
            panel_Image.Show()
            btn_Panel_Hide.Text = "<<<<"
            _hide = 0

            Me.Size = p1
            Me.CenterToScreen()
            status_indicator.Text = "IMPORTED"

            If dir_file <> "" Then
                panel_Image.Enabled = True
                Img_preview.Visible = True
            End If

            Me.Activate()

            histogram_draw = False
            Refresh()
        Catch ex As Exception
            status_indicator.Text = "ERROR"
            MsgBox("IMPORT IMAGE FILE ONLY.", MsgBoxStyle.Exclamation, "ERROR")
        End Try
    End Sub

    Private Sub Main_Form_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
#End Region

#Region "Status Indicator"
    Private Sub ABOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABOUTToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        status_indicator.Text = "CLOSE"
        End
    End Sub

    Private Sub Btn_Import_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Btn_Import.MouseMove
        status_indicator.Text = "IMPORT"
    End Sub

    Private Sub btn_ClearAll_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_ClearAll.MouseMove
        status_indicator.Text = "CLEAR"
    End Sub

    Private Sub btn_Restore_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_Restore.MouseMove
        status_indicator.Text = "RESTORE IMAGE DEFAULTS"
    End Sub

    Private Sub StatusStrip1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StatusStrip1.MouseMove
        If dir_file = "" Then
            status_indicator.Text = "NO IMPORTED IMAGE"
        Else
            status_indicator.Text = "READY"
        End If
    End Sub

    Private Sub MenuStrip1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuStrip1.MouseMove
        If dir_file = Nothing Then
            status_indicator.Text = "NO IMPORTED IMAGE"
        Else
            status_indicator.Text = "READY"
        End If
    End Sub

    Private Sub Main_Form_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If dir_file = Nothing Then
            status_indicator.Text = "NO IMPORTED IMAGE"
        Else
            status_indicator.Text = "READY"
        End If
    End Sub

    Private Sub btn_pixel_Values_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_pixel_Values.MouseMove
        status_indicator.Text = "SHOW PIXEL VALUES"
    End Sub

    Private Sub btn_Img_Save_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_Img_Save.MouseMove
        status_indicator.Text = "SAVE IMAGE AS..."
    End Sub

    Private Sub btn_Undo_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn_Undo.MouseMove
        status_indicator.Text = "UNDO"
    End Sub
#End Region

#Region "Image Save"
    Private Sub btn_Img_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Img_Save.Click
        If dir_file <> Nothing Then
            SaveFileDialog1.Filter = "JPEG Image .jpg|*.jpg|BITMAP Image .bmp|*.bmp|PNG Image .png|*.png|GIF Image .gif|*.gif|ICO Image .ico|*.ico" '(*.bmp*)|*.bmp
            SaveFileDialog1.FileName = "Untitled"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                If SaveFileDialog1.FilterIndex = 1 Then
                    Img_preview.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                ElseIf SaveFileDialog1.FilterIndex = 2 Then
                    Img_preview.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                ElseIf SaveFileDialog1.FilterIndex = 3 Then
                    Img_preview.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)
                ElseIf SaveFileDialog1.FilterIndex = 4 Then
                    Img_preview.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                ElseIf SaveFileDialog1.FilterIndex = 5 Then
                    Img_preview.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Icon)
                End If
                MsgBox("IMAGE SAVED SUCCESSFULLY.", MsgBoxStyle.Information, "INFO")
                status_indicator.Text = "SAVED"
            End If
        Else
            MsgBox("NO IMPORTED IMAGE.", MsgBoxStyle.Critical, "ERROR")
            status_indicator.Text = "NO IMPORTED IMAGE"
        End If
    End Sub

    Private Sub SAVEASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEASToolStripMenuItem.Click
        If dir_file <> Nothing Then
            SaveFileDialog1.Filter = "JPEG Image .jpg|*.jpg|BITMAP Image .bmp|*.bmp|PNG Image .png|*.png|GIF Image .gif|*.gif|ICO Image .ico|*.ico" '(*.bmp*)|*.bmp
            SaveFileDialog1.FileName = "Untitled"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                If SaveFileDialog1.FilterIndex = 1 Then
                    Img_preview.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                ElseIf SaveFileDialog1.FilterIndex = 2 Then
                    Img_preview.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                ElseIf SaveFileDialog1.FilterIndex = 3 Then
                    Img_preview.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)
                ElseIf SaveFileDialog1.FilterIndex = 4 Then
                    Img_preview.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                ElseIf SaveFileDialog1.FilterIndex = 5 Then
                    Img_preview.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Icon)
                End If
                MsgBox("IMAGE SAVED SUCCESSFULLY.", MsgBoxStyle.Information, "INFO")
                status_indicator.Text = "SAVED"
            End If
        Else
            MsgBox("NO IMPORTED IMAGE.", MsgBoxStyle.Critical, "ERROR")
            status_indicator.Text = "NO IMPORTED IMAGE"
        End If
    End Sub

    Private Sub SAVEIMAGEASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEIMAGEASToolStripMenuItem.Click
        If dir_file <> Nothing Then
            SaveFileDialog1.Filter = "JPEG Image .jpg|*.jpg|BITMAP Image .bmp|*.bmp|PNG Image .png|*.png|GIF Image .gif|*.gif|ICO Image .ico|*.ico" '(*.bmp*)|*.bmp
            SaveFileDialog1.FileName = "Untitled"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                If SaveFileDialog1.FilterIndex = 1 Then
                    Img_preview.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                ElseIf SaveFileDialog1.FilterIndex = 2 Then
                    Img_preview.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                ElseIf SaveFileDialog1.FilterIndex = 3 Then
                    Img_preview.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)
                ElseIf SaveFileDialog1.FilterIndex = 4 Then
                    Img_preview.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                ElseIf SaveFileDialog1.FilterIndex = 5 Then
                    Img_preview.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Icon)
                End If
                MsgBox("IMAGE SAVED SUCCESSFULLY.", MsgBoxStyle.Information, "INFO")
                status_indicator.Text = "SAVED"
            End If
        Else
            MsgBox("NO IMPORTED IMAGE.", MsgBoxStyle.Critical, "ERROR")
            status_indicator.Text = "NO IMPORTED IMAGE"
        End If
    End Sub
#End Region

#Region "Track Bars"
    Private Sub Slide_Set_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Slide_Set.Scroll
        t = setter.main_Slide_Scroll
    End Sub

    Private Sub TrackBar1_Scroll_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles input02.Scroll
        If Effect_Toggle = 5 Then
            Label2.Text = input02.Value
            input02.Minimum = 1
            input02.Maximum = 25
        ElseIf Effect_Toggle = 6 Then
            Label2.Text = "1/" & input02.Value
            input02.Minimum = 1
            input02.Maximum = 25
        ElseIf Effect_Toggle = 10 Then
            If input02.Value = 1 Then
                Label2.Text = input02.Value & "st"
            ElseIf input02.Value = 2 Then
                Label2.Text = input02.Value & "nd"
            ElseIf input02.Value = 3 Then
                Label2.Text = input02.Value & "rd"
            Else
                Label2.Text = input02.Value & "th"
            End If
        Else
            Label2.Text = input02.Value
            input02.Maximum = 255
            input02.Minimum = 0
        End If
    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles input03.Scroll
        Label3.Text = input03.Value
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles input01.Scroll
        Label1.Text = input01.Value
    End Sub
#End Region

#Region "Effect Setters"
    Private Sub btn_RGB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RGB.Click
        setter.input_Effect_Toggle(1)
        Effect_Toggle = 1
        setter.RGB_Effect()
    End Sub

    Private Sub btn_Equalizer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Equalizer.Click
        setter.input_Effect_Toggle(2)
        Effect_Toggle = 2
        setter.Equ_Effect()
    End Sub

    Private Sub btn_Negative_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Negative.Click
        setter.input_Effect_Toggle(3)
        Effect_Toggle = 3
        setter.Neg_Effect()
    End Sub

    Private Sub btn_Threshold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Threshold.Click
        setter.input_Effect_Toggle(4)
        Effect_Toggle = 4
        setter.Thr_Effect()
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Power.Click
        setter.input_Effect_Toggle(5)
        Effect_Toggle = 5
        setter.Pow_Effect()
    End Sub

    Private Sub btn_Logarithmic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Logarithmic.Click
        setter.input_Effect_Toggle(6)
        Effect_Toggle = 6
        setter.Log_Effect()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Root.Click
        setter.input_Effect_Toggle(7)
        Effect_Toggle = 7
        setter.Root_Effect()
    End Sub

    Private Sub btn_AntiLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AntiLog.Click
        setter.input_Effect_Toggle(8)
        Effect_Toggle = 8
        setter.AntiLog_Effect()
    End Sub

    Private Sub btn_GrayLevelSlicing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GrayLevelSlicing.Click
        setter.input_Effect_Toggle(9)
        Effect_Toggle = 9
        setter.Graylevel_Effect()
    End Sub

    Private Sub btn_BitPlaneSlicing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BitPlaneSlicing.Click
        setter.input_Effect_Toggle(10)
        Effect_Toggle = 10
        setter.BitPlane_Effect()
    End Sub

    Private Sub btn_SpatialFiltering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Filtering.Click
        setter.Filtering_Effect()
    End Sub

    Private Sub btn_Hue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Hue.Click
        setter.input_Effect_Toggle(12)
        Effect_Toggle = 12
        setter.Hue_Effect()
    End Sub

    Private Sub btn_Saturation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Saturation.Click
        setter.input_Effect_Toggle(13)
        Effect_Toggle = 13
        setter.Saturation_Effect()
    End Sub

    Private Sub btn_Intensity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Intensity.Click
        setter.input_Effect_Toggle(14)
        Effect_Toggle = 14
        setter.Intensity_Effect()
    End Sub

    Private Sub btn_HSI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HSI.Click
        setter.input_Effect_Toggle(15)
        Effect_Toggle = 15
        setter.HSI_Effect()
    End Sub
#End Region

#Region "Restore and Clear"
    Private Sub btn_Restore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Restore.Click
        If dir_file <> "" Then
            i = 0
            ReDim Redo(i)
            Img_preview.BackgroundImage = Image.FromFile(dir_file)
            original_image = Image.FromFile(dir_file)

            setter.Restore()
            pixel_value = Nothing
            t = 0
            histogram_draw = False
            Refresh()
        Else
            MsgBox("NO IMPORTED IMAGE.", MsgBoxStyle.Critical, "ERROR")
            status_indicator.Text = "NO IMPORTED IMAGE"
        End If
    End Sub

    Private Sub btn_Undo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Undo.Click
        If dir_file <> "" Then
            If Edit_Mode = True Then
                If i > 0 Then
                    i -= 1
                    ReDim Preserve Redo(i)
                    Img_preview.BackgroundImage = Redo(i)
                    original_image = Redo(i)

                    pixel_value = Nothing

                    histogram_draw = False
                    Refresh()
                Else
                    MsgBox("NOTHING TO REDO.", MsgBoxStyle.Exclamation, "ERROR")
                End If
            Else
                Img_preview.BackgroundImage = Image.FromFile(dir_file)
                histogram_draw = False
                Refresh()
            End If
        Else
            MsgBox("NO IMPORTED IMAGE.", MsgBoxStyle.Critical, "ERROR")
            status_indicator.Text = "NO IMPORTED IMAGE"
        End If
    End Sub

    Private Sub btn_ClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ClearAll.Click
        Dim p1 As Point
        p1.X = 652
        p1.Y = 595
        panel_Image.Hide()
        btn_Panel_Hide.Text = ">>>>"
        _hide = 1

        Me.Size = p1
        Me.CenterToScreen()

        original_image = Nothing
        filterType = ""
        img_height = Nothing
        img_width = Nothing
        histogram_draw = False
        pixel_value = Nothing
        dir_file = Nothing
        setter.CLEAR_ALL()
        Effect_Toggle = 0
        t = 0
    End Sub
#End Region

#Region "Refresh"
    Private Sub REFRESHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHToolStripMenuItem.Click
        Refresh()
    End Sub

    Private Sub REFRESHToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHToolStripMenuItem1.Click
        Refresh()
    End Sub
#End Region

#Region "GUI Displays and Customize"
    Private Sub Histogram_Preview_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Histogram_Preview.Paint
        If histogram_draw = True Then
            If color_Disp.BackColor = Color.Black Then
                If h1 IsNot Nothing Then
                    h1.ToImage(e.Graphics)
                End If
            ElseIf color_Disp.BackColor = Color.Red Then
                If h2 IsNot Nothing Then
                    h2.ToImage(e.Graphics)
                End If
            ElseIf color_Disp.BackColor = Color.Green Then
                If h3 IsNot Nothing Then
                    h3.ToImage(e.Graphics)
                End If
            ElseIf color_Disp.BackColor = Color.Blue Then
                If h4 IsNot Nothing Then
                    h4.ToImage(e.Graphics)
                End If
            ElseIf color_Disp.BackColor = Color.DimGray Then
                If h2 IsNot Nothing And h3 IsNot Nothing And h4 IsNot Nothing Then
                    h2.ToImage(e.Graphics)
                    h3.ToImage(e.Graphics)
                    h4.ToImage(e.Graphics)
                End If
            End If
        End If
    End Sub

    Private Sub btn_pixel_Values_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pixel_Values.Click
        If dir_file <> "" Then
            If pixel_value <> "" Then
                Pixel_Values.Show()
                Pixel_Values.BringToFront()
                Pixel_Values.generated_Pixel_Values.Text = pixel_value
            Else
                MsgBox("PIXEL VALUES NOT AVAILABLE", MsgBoxStyle.Critical, "ERROR")
                status_indicator.Text = "..."
            End If
        Else
            MsgBox("NO IMPORTED IMAGE.", MsgBoxStyle.Critical, "ERROR")
            status_indicator.Text = "NO IMPORTED IMAGE"
        End If
    End Sub

    Private Sub btn_Panel_Hide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Panel_Hide.Click
        Dim p1 As Point
        If _hide = 0 Then
            p1.X = 652
            p1.Y = 595
            panel_Image.Hide()
            btn_Panel_Hide.Text = ">>>>"
            _hide = 1
        Else
            p1.X = 984
            p1.Y = 595
            panel_Image.Show()
            btn_Panel_Hide.Text = "<<<<"
            _hide = 0
        End If

        Me.Size = p1
    End Sub

    Private Sub checkbox_EditMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkbox_EditMode.CheckedChanged
        If checkbox_EditMode.Checked = False Then
            Edit_Mode = False
            Me.Text = "DIGITAL SIGNAL PROCESSING IMAGE (EFFECTS TESTING ONLY)"
        Else
            Edit_Mode = True
            Me.Text = "DIGITAL SIGNAL PROCESSING IMAGE"
        End If
    End Sub
#End Region

#Region "Filters Control"
    Private Sub combo_Filter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_Filter.SelectedIndexChanged
        If combo_Filter.Text = "SPATIAL FILTERS" Then
            Effect_Toggle = 11
            lbl_Filter.Text = combo_Filter.Text & " TYPE:"
            combo_Filter2.Items.Clear()
            filterType = ""
            combo_Filter2.Items.Add("SIMPLE LAPLACIAN")
            combo_Filter2.Items.Add("VARIANT LAPLACIAN")
            combo_Filter2.Items.Add("SIMPLE AVERAGING")
            combo_Filter2.Items.Add("WEIGHTED SMOOTHING")
            combo_Filter2.Items.Add("SOBEL")
        ElseIf combo_Filter.Text = "FREQUENCY FILTERS" Then
            Effect_Toggle = 12
            lbl_Filter.Text = combo_Filter.Text & " TYPE:"
            combo_Filter2.Items.Clear()
            filterType = ""
        ElseIf combo_Filter.Text = "CUSTOM FILTERS..." Then
            Effect_Toggle = 13
            lbl_Filter.Text = ""
            combo_Filter2.Items.Clear()
            combo_Filter2.Items.Add("3X3 FILTER")
        End If
    End Sub

    Private Sub combo_Filter2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_Filter2.SelectedIndexChanged
        filterType = combo_Filter2.Text
        If filterType = "3X3 FILTER" Then
            CustomFilter_3X3.ShowDialog()
        End If
    End Sub
#End Region

#Region "Main Process Control"
    Private Sub Main_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Img_preview.AllowDrop = True
        _hide = 1
    End Sub

    Private Sub DIGITALSIGNALPROCESSINGIMAGEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIGITALSIGNALPROCESSINGIMAGEToolStripMenuItem.Click
        Dim p1 As Point
        p1.X = 652
        p1.Y = 595
        panel_Image.Hide()
        btn_Panel_Hide.Text = ">>>>"
        _hide = 1

        Me.Size = p1
        Me.CenterToScreen()

        original_image = Nothing
        filterType = ""
        img_height = Nothing
        img_width = Nothing
        histogram_draw = False
        pixel_value = Nothing
        dir_file = Nothing
        setter.CLEAR_ALL()
        Effect_Toggle = 0
        t = 0

        Main_Video.Show()

        Me.WindowState = FormWindowState.Minimized
        Me.Enabled = False
        Me.Visible = False
    End Sub

    Private Sub btn_Pick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Pick.Click
        If Edit_Mode = True Then
            ReDim Preserve Redo(i)
            Redo(i) = Img_preview.BackgroundImage
            original_image = Redo(i)
            i += 1
        End If

        If Effect_Toggle = 11 Then
            If filterType = "" Then
                MsgBox("SELECT A FILTER TYPE.", MsgBoxStyle.Exclamation, "ERROR")
            ElseIf filterType = "CUSTOM" Then
                combo_Filter2.Text = Nothing
                Filter_Proc.Store(original_image, Effect_Toggle, t, Edit_Mode, pixel_value, img_height, img_width)
                original_image = Filter_Proc._Original_Image
                pixel_value = Filter_Proc._Pixel_Values
                h1 = Filter_Proc._h1
                h2 = Filter_Proc._h2
                h3 = Filter_Proc._h3
                h4 = Filter_Proc._h4

                histogram_draw = True
                Refresh()
            Else
                Filter_Proc.Store(original_image, Effect_Toggle, t, Edit_Mode, pixel_value, img_height, img_width)
                original_image = Filter_Proc._Original_Image
                pixel_value = Filter_Proc._Pixel_Values
                h1 = Filter_Proc._h1
                h2 = Filter_Proc._h2
                h3 = Filter_Proc._h3
                h4 = Filter_Proc._h4

                histogram_draw = True
                Refresh()
            End If
        ElseIf Effect_Toggle <> 11 And Effect_Toggle > 0 Then
            Point_Proc.Store(original_image, Effect_Toggle, t, Edit_Mode, pixel_value, img_height, img_width)
            original_image = Point_Proc._Original_Image
            pixel_value = Point_Proc._Pixel_Values
            h1 = Point_Proc._h1
            h2 = Point_Proc._h2
            h3 = Point_Proc._h3
            h4 = Point_Proc._h4

            histogram_draw = True
            Refresh()
        Else
        End If
    End Sub
#End Region

End Class

