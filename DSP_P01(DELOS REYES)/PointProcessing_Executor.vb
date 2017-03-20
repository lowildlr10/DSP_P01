Public Class PointProcessing_Executor
    Private h1 As Histogram_Process
    Private h2 As Histogram_Process
    Private h3 As Histogram_Process
    Private h4 As Histogram_Process
    Private original_image As Bitmap
    Private t As Integer
    Private Effect_Toggle As Integer
    Private img_width, img_height As Integer
    Private pixel_value As String
    Private Edit_Mode As Boolean = False

    Public Sub Store(ByVal img As Image, ByVal effecttoggle As Integer, ByVal toggle As Integer, _
                   ByVal EditMode As Boolean, ByVal pixelvalue As String, _
                   ByVal imgHeight As Integer, ByVal imgWidth As Integer)
        original_image = img
        Effect_Toggle = effecttoggle
        t = toggle
        Edit_Mode = EditMode
        pixel_value = pixelvalue
        img_height = imgHeight
        img_width = imgWidth

        Process_Execute()
    End Sub

    Public Sub Process_Execute()
        Dim input1 As Double = Main_Form.input01.Value
        Dim input2 As Double = Main_Form.input02.Value
        Dim input3 As Double = Main_Form.input03.Value

        If Effect_Toggle = 1 Then
            Dim imgDat As New RGB_Process(original_image)

            h1 = New Histogram_Process(imgDat.ToArrayBW, Pens.DimGray, img_height, img_width)
            h2 = New Histogram_Process(imgDat.ToArrayRed, Pens.Red, img_height, img_width)
            h3 = New Histogram_Process(imgDat.ToArrayGreen, Pens.Green, img_height, img_width)
            h4 = New Histogram_Process(imgDat.ToArrayBlue, Pens.Blue, img_height, img_width)

            If Main_Form.color_Disp.BackColor = Color.Black Then
                Main_Form.Img_preview.BackgroundImage = imgDat.ImgBW
                pixel_value = imgDat.pixelBW
                If Edit_Mode = True Then
                    original_image = imgDat.ImgBW
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                Main_Form.Img_preview.BackgroundImage = imgDat.ImgRED
                pixel_value = imgDat.pixelRED
                If Edit_Mode = True Then
                    original_image = imgDat.ImgRED
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                Main_Form.Img_preview.BackgroundImage = imgDat.ImgGREEN
                pixel_value = imgDat.pixelGREEN
                If Edit_Mode = True Then
                    original_image = imgDat.ImgGREEN
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                Main_Form.Img_preview.BackgroundImage = imgDat.ImgBLUE
                pixel_value = imgDat.pixelBLUE
                If Edit_Mode = True Then
                    original_image = imgDat.ImgBLUE
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                h1 = New Histogram_Process(imgDat.ToArrayBW, Pens.Black, img_height, img_width)
                h2 = New Histogram_Process(imgDat.ToArrayRed, Pens.Black, img_height, img_width)
                h3 = New Histogram_Process(imgDat.ToArrayGreen, Pens.Black, img_height, img_width)
                h4 = New Histogram_Process(imgDat.ToArrayBlue, Pens.Black, img_height, img_width)
                Main_Form.Img_preview.BackgroundImage = imgDat.ImgOriginal
                Main_Form.status_indicator.Text = "FINISHED"
            Else
            End If
        ElseIf Effect_Toggle = 2 Then
            Dim color_toggle As Integer

            If Main_Form.color_Disp.BackColor = Color.Black Then
                color_toggle = 1
            ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                color_toggle = 2
            ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                color_toggle = 3
            ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                color_toggle = 4
            ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                color_toggle = 5
            End If

            Dim ImgEqualization As New Equalization_Process(original_image, color_toggle)

            h1 = New Histogram_Process(ImgEqualization.ToArrayBW, Pens.DimGray, img_height, img_width)
            h2 = New Histogram_Process(ImgEqualization.ToArrayRed, Pens.Red, img_height, img_width)
            h3 = New Histogram_Process(ImgEqualization.ToArrayGreen, Pens.Green, img_height, img_width)
            h4 = New Histogram_Process(ImgEqualization.ToArrayBlue, Pens.Blue, img_height, img_width)

            If Main_Form.color_Disp.BackColor = Color.Black Then
                Main_Form.Img_preview.BackgroundImage = ImgEqualization.ImgBW
                pixel_value = ImgEqualization.pixelBW
                If Edit_Mode = True Then
                    original_image = ImgEqualization.ImgBW
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                Main_Form.Img_preview.BackgroundImage = ImgEqualization.ImgRED
                pixel_value = ImgEqualization.pixelRED
                If Edit_Mode = True Then
                    original_image = ImgEqualization.ImgRED
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                Main_Form.Img_preview.BackgroundImage = ImgEqualization.ImgGREEN
                pixel_value = ImgEqualization.pixelGREEN
                If Edit_Mode = True Then
                    original_image = ImgEqualization.ImgGREEN
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                Main_Form.Img_preview.BackgroundImage = ImgEqualization.ImgBLUE
                pixel_value = ImgEqualization.pixelBLUE
                If Edit_Mode = True Then
                    original_image = ImgEqualization.ImgBLUE
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                Main_Form.Img_preview.BackgroundImage = ImgEqualization.ImgOriginal
                h1 = New Histogram_Process(ImgEqualization.ToArrayBW, Pens.Black, img_height, img_width)
                h2 = New Histogram_Process(ImgEqualization.ToArrayRed, Pens.Black, img_height, img_width)
                h3 = New Histogram_Process(ImgEqualization.ToArrayGreen, Pens.Black, img_height, img_width)
                h4 = New Histogram_Process(ImgEqualization.ToArrayBlue, Pens.Black, img_height, img_width)
                If Edit_Mode = True Then
                    original_image = ImgEqualization.ImgOriginal
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            Else
            End If

        ElseIf Effect_Toggle = 3 Then
            Dim ImgNegative As New Negative_Process(original_image)

            h1 = New Histogram_Process(ImgNegative.ToArrayBW, Pens.DimGray, img_height, img_width)
            h2 = New Histogram_Process(ImgNegative.ToArrayRed, Pens.Red, img_height, img_width)
            h3 = New Histogram_Process(ImgNegative.ToArrayGreen, Pens.Green, img_height, img_width)
            h4 = New Histogram_Process(ImgNegative.ToArrayBlue, Pens.Blue, img_height, img_width)

            If Main_Form.color_Disp.BackColor = Color.Black Then
                Main_Form.Img_preview.BackgroundImage = ImgNegative.ImgBW
                pixel_value = ImgNegative.pixelBW
                If Edit_Mode = True Then
                    original_image = ImgNegative.ImgBW
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                Main_Form.Img_preview.BackgroundImage = ImgNegative.ImgRED
                pixel_value = ImgNegative.pixelRED
                If Edit_Mode = True Then
                    original_image = ImgNegative.ImgRED
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                Main_Form.Img_preview.BackgroundImage = ImgNegative.ImgGREEN
                pixel_value = ImgNegative.pixelGREEN
                If Edit_Mode = True Then
                    original_image = ImgNegative.ImgGREEN
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                Main_Form.Img_preview.BackgroundImage = ImgNegative.ImgBLUE
                pixel_value = ImgNegative.pixelBLUE
                If Edit_Mode = True Then
                    original_image = ImgNegative.ImgBLUE
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                Main_Form.Img_preview.BackgroundImage = ImgNegative.ImgOriginal
                h1 = New Histogram_Process(ImgNegative.ToArrayBW, Pens.Black, img_height, img_width)
                h2 = New Histogram_Process(ImgNegative.ToArrayRed, Pens.Black, img_height, img_width)
                h3 = New Histogram_Process(ImgNegative.ToArrayGreen, Pens.Black, img_height, img_width)
                h4 = New Histogram_Process(ImgNegative.ToArrayBlue, Pens.Black, img_height, img_width)
                If Edit_Mode = True Then
                    original_image = ImgNegative.ImgOriginal
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            Else
            End If
        ElseIf Effect_Toggle = 4 Then
            Dim ImgThreshold As New Threshold_Process(original_image, CInt(input2), t)

            h1 = New Histogram_Process(ImgThreshold.ToArrayBW, Pens.DimGray, img_height, img_width)
            h2 = New Histogram_Process(ImgThreshold.ToArrayRed, Pens.Red, img_height, img_width)
            h3 = New Histogram_Process(ImgThreshold.ToArrayGreen, Pens.Green, img_height, img_width)
            h4 = New Histogram_Process(ImgThreshold.ToArrayBlue, Pens.Blue, img_height, img_width)

            If Main_Form.color_Disp.BackColor = Color.Black Then
                Main_Form.Img_preview.BackgroundImage = ImgThreshold.ImgBW
                pixel_value = ImgThreshold.pixelBW
                If Edit_Mode = True Then
                    original_image = ImgThreshold.ImgBW
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                Main_Form.Img_preview.BackgroundImage = ImgThreshold.ImgRED
                pixel_value = ImgThreshold.pixelRED
                If Edit_Mode = True Then
                    original_image = ImgThreshold.ImgRED
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                Main_Form.Img_preview.BackgroundImage = ImgThreshold.ImgGREEN
                pixel_value = ImgThreshold.pixelGREEN
                If Edit_Mode = True Then
                    original_image = ImgThreshold.ImgGREEN
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                Main_Form.Img_preview.BackgroundImage = ImgThreshold.ImgBLUE
                pixel_value = ImgThreshold.pixelBLUE
                If Edit_Mode = True Then
                    original_image = ImgThreshold.ImgBLUE
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                Main_Form.Img_preview.BackgroundImage = ImgThreshold.ImgOriginal
                h1 = New Histogram_Process(ImgThreshold.ToArrayBW, Pens.Black, img_height, img_width)
                h2 = New Histogram_Process(ImgThreshold.ToArrayRed, Pens.Black, img_height, img_width)
                h3 = New Histogram_Process(ImgThreshold.ToArrayGreen, Pens.Black, img_height, img_width)
                h4 = New Histogram_Process(ImgThreshold.ToArrayBlue, Pens.Black, img_height, img_width)
                If Edit_Mode = True Then
                    original_image = ImgThreshold.ImgOriginal
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            Else
            End If
        ElseIf Effect_Toggle = 5 Then
            Dim ImgPower As New Power_Process(original_image, CInt(input2))

            h1 = New Histogram_Process(ImgPower.ToArrayBW, Pens.DimGray, img_height, img_width)
            h2 = New Histogram_Process(ImgPower.ToArrayRed, Pens.Red, img_height, img_width)
            h3 = New Histogram_Process(ImgPower.ToArrayGreen, Pens.Green, img_height, img_width)
            h4 = New Histogram_Process(ImgPower.ToArrayBlue, Pens.Blue, img_height, img_width)

            If Main_Form.color_Disp.BackColor = Color.Black Then
                Main_Form.Img_preview.BackgroundImage = ImgPower.ImgBW
                pixel_value = ImgPower.pixelBW
                If Edit_Mode = True Then
                    original_image = ImgPower.ImgBW
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                Main_Form.Img_preview.BackgroundImage = ImgPower.ImgRED
                pixel_value = ImgPower.pixelRED
                If Edit_Mode = True Then
                    original_image = ImgPower.ImgRED
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                Main_Form.Img_preview.BackgroundImage = ImgPower.ImgGREEN
                pixel_value = ImgPower.pixelGREEN
                If Edit_Mode = True Then
                    original_image = ImgPower.ImgGREEN
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                Main_Form.Img_preview.BackgroundImage = ImgPower.ImgBLUE
                pixel_value = ImgPower.pixelBLUE
                If Edit_Mode = True Then
                    original_image = ImgPower.ImgBLUE
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                Main_Form.Img_preview.BackgroundImage = ImgPower.ImgOriginal
                h1 = New Histogram_Process(ImgPower.ToArrayBW, Pens.Black, img_height, img_width)
                h2 = New Histogram_Process(ImgPower.ToArrayRed, Pens.Black, img_height, img_width)
                h3 = New Histogram_Process(ImgPower.ToArrayGreen, Pens.Black, img_height, img_width)
                h4 = New Histogram_Process(ImgPower.ToArrayBlue, Pens.Black, img_height, img_width)
                If Edit_Mode = True Then
                    original_image = ImgPower.ImgOriginal
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            Else
            End If
        ElseIf Effect_Toggle = 6 Then
            Dim ImgLogarithmic As New Logarithmic_Process(original_image)

            h1 = New Histogram_Process(ImgLogarithmic.ToArrayBW, Pens.DimGray, img_height, img_width)
            h2 = New Histogram_Process(ImgLogarithmic.ToArrayRed, Pens.Red, img_height, img_width)
            h3 = New Histogram_Process(ImgLogarithmic.ToArrayGreen, Pens.Green, img_height, img_width)
            h4 = New Histogram_Process(ImgLogarithmic.ToArrayBlue, Pens.Blue, img_height, img_width)

            If Main_Form.color_Disp.BackColor = Color.Black Then
                Main_Form.Img_preview.BackgroundImage = ImgLogarithmic.ImgBW
                pixel_value = ImgLogarithmic.pixelBW
                If Edit_Mode = True Then
                    original_image = ImgLogarithmic.ImgBW
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                Main_Form.Img_preview.BackgroundImage = ImgLogarithmic.ImgRED
                pixel_value = ImgLogarithmic.pixelRED
                If Edit_Mode = True Then
                    original_image = ImgLogarithmic.ImgRED
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                Main_Form.Img_preview.BackgroundImage = ImgLogarithmic.ImgGREEN
                pixel_value = ImgLogarithmic.pixelGREEN
                If Edit_Mode = True Then
                    original_image = ImgLogarithmic.ImgGREEN
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                Main_Form.Img_preview.BackgroundImage = ImgLogarithmic.ImgBLUE
                pixel_value = ImgLogarithmic.pixelBLUE
                If Edit_Mode = True Then
                    original_image = ImgLogarithmic.ImgBLUE
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                Main_Form.Img_preview.BackgroundImage = ImgLogarithmic.ImgOriginal
                h1 = New Histogram_Process(ImgLogarithmic.ToArrayBW, Pens.Black, img_height, img_width)
                h2 = New Histogram_Process(ImgLogarithmic.ToArrayRed, Pens.Black, img_height, img_width)
                h3 = New Histogram_Process(ImgLogarithmic.ToArrayGreen, Pens.Black, img_height, img_width)
                h4 = New Histogram_Process(ImgLogarithmic.ToArrayBlue, Pens.Black, img_height, img_width)
                If Edit_Mode = True Then
                    original_image = ImgLogarithmic.ImgOriginal
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            Else
            End If
        ElseIf Effect_Toggle = 7 Then
            Dim ImgRoot As New Root_Process(original_image, input2)

            h1 = New Histogram_Process(ImgRoot.ToArrayBW, Pens.DimGray, img_height, img_width)
            h2 = New Histogram_Process(ImgRoot.ToArrayRed, Pens.Red, img_height, img_width)
            h3 = New Histogram_Process(ImgRoot.ToArrayGreen, Pens.Green, img_height, img_width)
            h4 = New Histogram_Process(ImgRoot.ToArrayBlue, Pens.Blue, img_height, img_width)

            If Main_Form.color_Disp.BackColor = Color.Black Then
                Main_Form.Img_preview.BackgroundImage = ImgRoot.ImgBW
                pixel_value = ImgRoot.pixelBW
                If Edit_Mode = True Then
                    original_image = ImgRoot.ImgBW
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                Main_Form.Img_preview.BackgroundImage = ImgRoot.ImgRED
                pixel_value = ImgRoot.pixelRED
                If Edit_Mode = True Then
                    original_image = ImgRoot.ImgRED
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                Main_Form.Img_preview.BackgroundImage = ImgRoot.ImgGREEN
                pixel_value = ImgRoot.pixelGREEN
                If Edit_Mode = True Then
                    original_image = ImgRoot.ImgGREEN
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                Main_Form.Img_preview.BackgroundImage = ImgRoot.ImgBLUE
                pixel_value = ImgRoot.pixelBLUE
                If Edit_Mode = True Then
                    original_image = ImgRoot.ImgBLUE
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                Main_Form.Img_preview.BackgroundImage = ImgRoot.ImgOriginal
                h1 = New Histogram_Process(ImgRoot.ToArrayBW, Pens.Black, img_height, img_width)
                h2 = New Histogram_Process(ImgRoot.ToArrayRed, Pens.Black, img_height, img_width)
                h3 = New Histogram_Process(ImgRoot.ToArrayGreen, Pens.Black, img_height, img_width)
                h4 = New Histogram_Process(ImgRoot.ToArrayBlue, Pens.Black, img_height, img_width)
                If Edit_Mode = True Then
                    original_image = ImgRoot.ImgOriginal
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            Else
            End If
        ElseIf Effect_Toggle = 8 Then
            Dim ImgAntiLogarithmic As New AntiLogarithmic_Process(original_image)

            h1 = New Histogram_Process(ImgAntiLogarithmic.ToArrayBW, Pens.DimGray, img_height, img_width)
            h2 = New Histogram_Process(ImgAntiLogarithmic.ToArrayRed, Pens.Red, img_height, img_width)
            h3 = New Histogram_Process(ImgAntiLogarithmic.ToArrayGreen, Pens.Green, img_height, img_width)
            h4 = New Histogram_Process(ImgAntiLogarithmic.ToArrayBlue, Pens.Blue, img_height, img_width)

            If Main_Form.color_Disp.BackColor = Color.Black Then
                Main_Form.Img_preview.BackgroundImage = ImgAntiLogarithmic.ImgBW
                pixel_value = ImgAntiLogarithmic.pixelBW
                If Edit_Mode = True Then
                    original_image = ImgAntiLogarithmic.ImgBW
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                Main_Form.Img_preview.BackgroundImage = ImgAntiLogarithmic.ImgRED
                pixel_value = ImgAntiLogarithmic.pixelRED
                If Edit_Mode = True Then
                    original_image = ImgAntiLogarithmic.ImgRED
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                Main_Form.Img_preview.BackgroundImage = ImgAntiLogarithmic.ImgGREEN
                pixel_value = ImgAntiLogarithmic.pixelGREEN
                If Edit_Mode = True Then
                    original_image = ImgAntiLogarithmic.ImgGREEN
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                Main_Form.Img_preview.BackgroundImage = ImgAntiLogarithmic.ImgBLUE
                pixel_value = ImgAntiLogarithmic.pixelBLUE
                If Edit_Mode = True Then
                    original_image = ImgAntiLogarithmic.ImgBLUE
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                Main_Form.Img_preview.BackgroundImage = ImgAntiLogarithmic.ImgOriginal
                h1 = New Histogram_Process(ImgAntiLogarithmic.ToArrayBW, Pens.Black, img_height, img_width)
                h2 = New Histogram_Process(ImgAntiLogarithmic.ToArrayRed, Pens.Black, img_height, img_width)
                h3 = New Histogram_Process(ImgAntiLogarithmic.ToArrayGreen, Pens.Black, img_height, img_width)
                h4 = New Histogram_Process(ImgAntiLogarithmic.ToArrayBlue, Pens.Black, img_height, img_width)
                If Edit_Mode = True Then
                    original_image = ImgAntiLogarithmic.ImgOriginal
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            Else
            End If
        ElseIf Effect_Toggle = 9 Then
            Dim ImgGraylevelSlicing As New GraylevelSlicing_Process(original_image, input1, input2, input3)

            h1 = New Histogram_Process(ImgGraylevelSlicing.ToArrayBW, Pens.DimGray, img_height, img_width)
            h2 = New Histogram_Process(ImgGraylevelSlicing.ToArrayRed, Pens.Red, img_height, img_width)
            h3 = New Histogram_Process(ImgGraylevelSlicing.ToArrayGreen, Pens.Green, img_height, img_width)
            h4 = New Histogram_Process(ImgGraylevelSlicing.ToArrayBlue, Pens.Blue, img_height, img_width)

            If Main_Form.color_Disp.BackColor = Color.Black Then
                Main_Form.Img_preview.BackgroundImage = ImgGraylevelSlicing.ImgBW
                pixel_value = ImgGraylevelSlicing.pixelBW
                If Edit_Mode = True Then
                    original_image = ImgGraylevelSlicing.ImgBW
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                Main_Form.Img_preview.BackgroundImage = ImgGraylevelSlicing.ImgRED
                pixel_value = ImgGraylevelSlicing.pixelRED
                If Edit_Mode = True Then
                    original_image = ImgGraylevelSlicing.ImgRED
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                Main_Form.Img_preview.BackgroundImage = ImgGraylevelSlicing.ImgGREEN
                pixel_value = ImgGraylevelSlicing.pixelGREEN
                If Edit_Mode = True Then
                    original_image = ImgGraylevelSlicing.ImgGREEN
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                Main_Form.Img_preview.BackgroundImage = ImgGraylevelSlicing.ImgBLUE
                pixel_value = ImgGraylevelSlicing.pixelBLUE
                If Edit_Mode = True Then
                    original_image = ImgGraylevelSlicing.ImgBLUE
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                Main_Form.Img_preview.BackgroundImage = ImgGraylevelSlicing.ImgOriginal
                h1 = New Histogram_Process(ImgGraylevelSlicing.ToArrayBW, Pens.Black, img_height, img_width)
                h2 = New Histogram_Process(ImgGraylevelSlicing.ToArrayRed, Pens.Black, img_height, img_width)
                h3 = New Histogram_Process(ImgGraylevelSlicing.ToArrayGreen, Pens.Black, img_height, img_width)
                h4 = New Histogram_Process(ImgGraylevelSlicing.ToArrayBlue, Pens.Black, img_height, img_width)
                If Edit_Mode = True Then
                    original_image = ImgGraylevelSlicing.ImgOriginal
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            Else
            End If
        ElseIf Effect_Toggle = 10 Then
            Dim ImgBitPlaneSlicing As New BitPlaneSlicing_Process(original_image, CInt(input2))

            h1 = New Histogram_Process(ImgBitPlaneSlicing.ToArrayBW, Pens.DimGray, img_height, img_width)
            h2 = New Histogram_Process(ImgBitPlaneSlicing.ToArrayRed, Pens.Red, img_height, img_width)
            h3 = New Histogram_Process(ImgBitPlaneSlicing.ToArrayGreen, Pens.Green, img_height, img_width)
            h4 = New Histogram_Process(ImgBitPlaneSlicing.ToArrayBlue, Pens.Blue, img_height, img_width)

            If Main_Form.color_Disp.BackColor = Color.Black Then
                Main_Form.Img_preview.BackgroundImage = ImgBitPlaneSlicing.ImgBW
                pixel_value = ImgBitPlaneSlicing.pixelBW
                If Edit_Mode = True Then
                    original_image = ImgBitPlaneSlicing.ImgBW
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                Main_Form.Img_preview.BackgroundImage = ImgBitPlaneSlicing.ImgRED
                pixel_value = ImgBitPlaneSlicing.pixelRED
                If Edit_Mode = True Then
                    original_image = ImgBitPlaneSlicing.ImgRED
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                Main_Form.Img_preview.BackgroundImage = ImgBitPlaneSlicing.ImgGREEN
                pixel_value = ImgBitPlaneSlicing.pixelGREEN
                If Edit_Mode = True Then
                    original_image = ImgBitPlaneSlicing.ImgGREEN
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                Main_Form.Img_preview.BackgroundImage = ImgBitPlaneSlicing.ImgBLUE
                pixel_value = ImgBitPlaneSlicing.pixelBLUE
                If Edit_Mode = True Then
                    original_image = ImgBitPlaneSlicing.ImgBLUE
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                Main_Form.Img_preview.BackgroundImage = ImgBitPlaneSlicing.ImgOriginal
                h1 = New Histogram_Process(ImgBitPlaneSlicing.ToArrayBW, Pens.Black, img_height, img_width)
                h2 = New Histogram_Process(ImgBitPlaneSlicing.ToArrayRed, Pens.Black, img_height, img_width)
                h3 = New Histogram_Process(ImgBitPlaneSlicing.ToArrayGreen, Pens.Black, img_height, img_width)
                h4 = New Histogram_Process(ImgBitPlaneSlicing.ToArrayBlue, Pens.Black, img_height, img_width)
                If Edit_Mode = True Then
                    original_image = ImgBitPlaneSlicing.ImgOriginal
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            Else
            End If
        ElseIf Effect_Toggle = 12 Then
            Dim ImgHue As New Hue_Process(original_image)

            h1 = New Histogram_Process(ImgHue.ToArrayBW, Pens.DimGray, img_height, img_width)
            h2 = New Histogram_Process(ImgHue.ToArrayRed, Pens.Red, img_height, img_width)
            h3 = New Histogram_Process(ImgHue.ToArrayGreen, Pens.Green, img_height, img_width)
            h4 = New Histogram_Process(ImgHue.ToArrayBlue, Pens.Blue, img_height, img_width)

            If Main_Form.color_Disp.BackColor = Color.Black Then
                Main_Form.Img_preview.BackgroundImage = ImgHue.ImgBW
                pixel_value = ImgHue.pixelBW
                If Edit_Mode = True Then
                    original_image = ImgHue.ImgBW
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                Main_Form.Img_preview.BackgroundImage = ImgHue.ImgRED
                pixel_value = ImgHue.pixelRED
                If Edit_Mode = True Then
                    original_image = ImgHue.ImgRED
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                Main_Form.Img_preview.BackgroundImage = ImgHue.ImgGREEN
                pixel_value = ImgHue.pixelGREEN
                If Edit_Mode = True Then
                    original_image = ImgHue.ImgGREEN
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                Main_Form.Img_preview.BackgroundImage = ImgHue.ImgBLUE
                pixel_value = ImgHue.pixelBLUE
                If Edit_Mode = True Then
                    original_image = ImgHue.ImgBLUE
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                Main_Form.Img_preview.BackgroundImage = ImgHue.ImgOriginal
                h1 = New Histogram_Process(ImgHue.ToArrayBW, Pens.Black, img_height, img_width)
                h2 = New Histogram_Process(ImgHue.ToArrayRed, Pens.Black, img_height, img_width)
                h3 = New Histogram_Process(ImgHue.ToArrayGreen, Pens.Black, img_height, img_width)
                h4 = New Histogram_Process(ImgHue.ToArrayBlue, Pens.Black, img_height, img_width)
                If Edit_Mode = True Then
                    original_image = ImgHue.ImgOriginal
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            Else
            End If
        ElseIf Effect_Toggle = 13 Then
            Dim ImgSaturation As New Saturation_Process(original_image)

            h1 = New Histogram_Process(ImgSaturation.ToArrayBW, Pens.DimGray, img_height, img_width)
            h2 = New Histogram_Process(ImgSaturation.ToArrayRed, Pens.Red, img_height, img_width)
            h3 = New Histogram_Process(ImgSaturation.ToArrayGreen, Pens.Green, img_height, img_width)
            h4 = New Histogram_Process(ImgSaturation.ToArrayBlue, Pens.Blue, img_height, img_width)

            If Main_Form.color_Disp.BackColor = Color.Black Then
                Main_Form.Img_preview.BackgroundImage = ImgSaturation.ImgBW
                pixel_value = ImgSaturation.pixelBW
                If Edit_Mode = True Then
                    original_image = ImgSaturation.ImgBW
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                Main_Form.Img_preview.BackgroundImage = ImgSaturation.ImgRED
                pixel_value = ImgSaturation.pixelRED
                If Edit_Mode = True Then
                    original_image = ImgSaturation.ImgRED
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                Main_Form.Img_preview.BackgroundImage = ImgSaturation.ImgGREEN
                pixel_value = ImgSaturation.pixelGREEN
                If Edit_Mode = True Then
                    original_image = ImgSaturation.ImgGREEN
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                Main_Form.Img_preview.BackgroundImage = ImgSaturation.ImgBLUE
                pixel_value = ImgSaturation.pixelBLUE
                If Edit_Mode = True Then
                    original_image = ImgSaturation.ImgBLUE
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                Main_Form.Img_preview.BackgroundImage = ImgSaturation.ImgOriginal
                h1 = New Histogram_Process(ImgSaturation.ToArrayBW, Pens.Black, img_height, img_width)
                h2 = New Histogram_Process(ImgSaturation.ToArrayRed, Pens.Black, img_height, img_width)
                h3 = New Histogram_Process(ImgSaturation.ToArrayGreen, Pens.Black, img_height, img_width)
                h4 = New Histogram_Process(ImgSaturation.ToArrayBlue, Pens.Black, img_height, img_width)
                If Edit_Mode = True Then
                    original_image = ImgSaturation.ImgOriginal
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            Else
            End If
        ElseIf Effect_Toggle = 14 Then
            Dim ImgIntensity As New Intensity_Process(original_image)

            h1 = New Histogram_Process(ImgIntensity.ToArrayBW, Pens.DimGray, img_height, img_width)
            h2 = New Histogram_Process(ImgIntensity.ToArrayRed, Pens.Red, img_height, img_width)
            h3 = New Histogram_Process(ImgIntensity.ToArrayGreen, Pens.Green, img_height, img_width)
            h4 = New Histogram_Process(ImgIntensity.ToArrayBlue, Pens.Blue, img_height, img_width)

            If Main_Form.color_Disp.BackColor = Color.Black Then
                Main_Form.Img_preview.BackgroundImage = ImgIntensity.ImgBW
                pixel_value = ImgIntensity.pixelBW
                If Edit_Mode = True Then
                    original_image = ImgIntensity.ImgBW
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                Main_Form.Img_preview.BackgroundImage = ImgIntensity.ImgRED
                pixel_value = ImgIntensity.pixelRED
                If Edit_Mode = True Then
                    original_image = ImgIntensity.ImgRED
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                Main_Form.Img_preview.BackgroundImage = ImgIntensity.ImgGREEN
                pixel_value = ImgIntensity.pixelGREEN
                If Edit_Mode = True Then
                    original_image = ImgIntensity.ImgGREEN
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                Main_Form.Img_preview.BackgroundImage = ImgIntensity.ImgBLUE
                pixel_value = ImgIntensity.pixelBLUE
                If Edit_Mode = True Then
                    original_image = ImgIntensity.ImgBLUE
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                Main_Form.Img_preview.BackgroundImage = ImgIntensity.ImgOriginal
                h1 = New Histogram_Process(ImgIntensity.ToArrayBW, Pens.Black, img_height, img_width)
                h2 = New Histogram_Process(ImgIntensity.ToArrayRed, Pens.Black, img_height, img_width)
                h3 = New Histogram_Process(ImgIntensity.ToArrayGreen, Pens.Black, img_height, img_width)
                h4 = New Histogram_Process(ImgIntensity.ToArrayBlue, Pens.Black, img_height, img_width)
                If Edit_Mode = True Then
                    original_image = ImgIntensity.ImgOriginal
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            Else
            End If
        ElseIf Effect_Toggle = 15 Then
            Dim ImgHSI As New HSI_Process(original_image)

            h1 = New Histogram_Process(ImgHSI.ToArrayBW, Pens.DimGray, img_height, img_width)
            h2 = New Histogram_Process(ImgHSI.ToArrayRed, Pens.Red, img_height, img_width)
            h3 = New Histogram_Process(ImgHSI.ToArrayGreen, Pens.Green, img_height, img_width)
            h4 = New Histogram_Process(ImgHSI.ToArrayBlue, Pens.Blue, img_height, img_width)

            If Main_Form.color_Disp.BackColor = Color.Black Then
                Main_Form.Img_preview.BackgroundImage = ImgHSI.ImgBW
                pixel_value = ImgHSI.pixelBW
                If Edit_Mode = True Then
                    original_image = ImgHSI.ImgBW
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                Main_Form.Img_preview.BackgroundImage = ImgHSI.ImgRED
                pixel_value = ImgHSI.pixelRED
                If Edit_Mode = True Then
                    original_image = ImgHSI.ImgRED
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                Main_Form.Img_preview.BackgroundImage = ImgHSI.ImgGREEN
                pixel_value = ImgHSI.pixelGREEN
                If Edit_Mode = True Then
                    original_image = ImgHSI.ImgGREEN
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                Main_Form.Img_preview.BackgroundImage = ImgHSI.ImgBLUE
                pixel_value = ImgHSI.pixelBLUE
                If Edit_Mode = True Then
                    original_image = ImgHSI.ImgBLUE
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                Main_Form.Img_preview.BackgroundImage = ImgHSI.ImgOriginal
                h1 = New Histogram_Process(ImgHSI.ToArrayBW, Pens.Black, img_height, img_width)
                h2 = New Histogram_Process(ImgHSI.ToArrayRed, Pens.Black, img_height, img_width)
                h3 = New Histogram_Process(ImgHSI.ToArrayGreen, Pens.Black, img_height, img_width)
                h4 = New Histogram_Process(ImgHSI.ToArrayBlue, Pens.Black, img_height, img_width)
                If Edit_Mode = True Then
                    original_image = ImgHSI.ImgOriginal
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            Else
            End If
        Else
        End If
    End Sub

    Public Function _Original_Image() As Bitmap
        Return original_image
    End Function

    Public Function _Pixel_Values() As String
        Return pixel_value
    End Function

    Public Function _h1()
        Return h1
    End Function

    Public Function _h2()
        Return h2
    End Function

    Public Function _h3()
        Return h3
    End Function

    Public Function _h4()
        Return h4
    End Function
End Class
