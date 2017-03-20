Public Class FilterProcessing_Executor
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
    Private _f(8) As Integer

    Public Sub custom_Filters(ByVal f() As Single)
        For i As Integer = 0 To _f.Length - 1
            _f(i) = f(i)
        Next
    End Sub

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
        Dim filterType As String = Main_Form.combo_Filter2.Text

        If Effect_Toggle = 11 Then
            If Effect_Toggle = 11 Then
                If filterType = "SIMPLE LAPLACIAN" Then
                    Dim spatial As New Filtering_Process(original_image, New Single(,) { _
                           {0, -1, 0}, _
                           {-1, 4, -1}, _
                           {0, -1, 0}})
                    h1 = New Histogram_Process(spatial.ToArrayBW, Pens.DimGray, img_height, img_width)
                    h2 = New Histogram_Process(spatial.ToArrayRed, Pens.Red, img_height, img_width)
                    h3 = New Histogram_Process(spatial.ToArrayGreen, Pens.Green, img_height, img_width)
                    h4 = New Histogram_Process(spatial.ToArrayBlue, Pens.Blue, img_height, img_width)

                    If Main_Form.color_Disp.BackColor = Color.Black Then
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgBW
                        pixel_value = spatial.pixelBW
                        If Edit_Mode = True Then
                            original_image = spatial.ImgBW
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgRED
                        pixel_value = spatial.pixelRED
                        If Edit_Mode = True Then
                            original_image = spatial.ImgRED
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgGREEN
                        pixel_value = spatial.pixelGREEN
                        If Edit_Mode = True Then
                            original_image = spatial.ImgGREEN
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgBLUE
                        pixel_value = spatial.pixelBLUE
                        If Edit_Mode = True Then
                            original_image = spatial.ImgBLUE
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                        h1 = New Histogram_Process(spatial.ToArrayBW, Pens.Black, img_height, img_width)
                        h2 = New Histogram_Process(spatial.ToArrayRed, Pens.Black, img_height, img_width)
                        h3 = New Histogram_Process(spatial.ToArrayGreen, Pens.Black, img_height, img_width)
                        h4 = New Histogram_Process(spatial.ToArrayBlue, Pens.Black, img_height, img_width)
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgOriginal
                        Main_Form.status_indicator.Text = "FINISHED"
                    Else
                    End If
                ElseIf filterType = "VARIANT LAPLACIAN" Then
                    Dim spatial As New Filtering_Process(original_image, New Single(,) { _
                           {1, 1, 1}, _
                           {1, -8, 1}, _
                           {1, 1, 1}})
                    h1 = New Histogram_Process(spatial.ToArrayBW, Pens.DimGray, img_height, img_width)
                    h2 = New Histogram_Process(spatial.ToArrayRed, Pens.Red, img_height, img_width)
                    h3 = New Histogram_Process(spatial.ToArrayGreen, Pens.Green, img_height, img_width)
                    h4 = New Histogram_Process(spatial.ToArrayBlue, Pens.Blue, img_height, img_width)

                    If Main_Form.color_Disp.BackColor = Color.Black Then
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgBW
                        pixel_value = spatial.pixelBW
                        If Edit_Mode = True Then
                            original_image = spatial.ImgBW
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgRED
                        pixel_value = spatial.pixelRED
                        If Edit_Mode = True Then
                            original_image = spatial.ImgRED
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgGREEN
                        pixel_value = spatial.pixelGREEN
                        If Edit_Mode = True Then
                            original_image = spatial.ImgGREEN
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgBLUE
                        pixel_value = spatial.pixelBLUE
                        If Edit_Mode = True Then
                            original_image = spatial.ImgBLUE
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                        h1 = New Histogram_Process(spatial.ToArrayBW, Pens.Black, img_height, img_width)
                        h2 = New Histogram_Process(spatial.ToArrayRed, Pens.Black, img_height, img_width)
                        h3 = New Histogram_Process(spatial.ToArrayGreen, Pens.Black, img_height, img_width)
                        h4 = New Histogram_Process(spatial.ToArrayBlue, Pens.Black, img_height, img_width)
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgOriginal
                        Main_Form.status_indicator.Text = "FINISHED"
                    Else
                    End If
                ElseIf filterType = "SIMPLE AVERAGING" Then
                    Dim spatial As New Filtering_Process(original_image, New Single(,) { _
                           {1 / 9, 1 / 9, 1 / 9}, _
                           {1 / 9, 1 / 9, 1 / 9}, _
                           {1 / 9, 1 / 9, 1 / 9}})
                    h1 = New Histogram_Process(spatial.ToArrayBW, Pens.DimGray, img_height, img_width)
                    h2 = New Histogram_Process(spatial.ToArrayRed, Pens.Red, img_height, img_width)
                    h3 = New Histogram_Process(spatial.ToArrayGreen, Pens.Green, img_height, img_width)
                    h4 = New Histogram_Process(spatial.ToArrayBlue, Pens.Blue, img_height, img_width)

                    If Main_Form.color_Disp.BackColor = Color.Black Then
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgBW
                        pixel_value = spatial.pixelBW
                        If Edit_Mode = True Then
                            original_image = spatial.ImgBW
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgRED
                        pixel_value = spatial.pixelRED
                        If Edit_Mode = True Then
                            original_image = spatial.ImgRED
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgGREEN
                        pixel_value = spatial.pixelGREEN
                        If Edit_Mode = True Then
                            original_image = spatial.ImgGREEN
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgBLUE
                        pixel_value = spatial.pixelBLUE
                        If Edit_Mode = True Then
                            original_image = spatial.ImgBLUE
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                        h1 = New Histogram_Process(spatial.ToArrayBW, Pens.Black, img_height, img_width)
                        h2 = New Histogram_Process(spatial.ToArrayRed, Pens.Black, img_height, img_width)
                        h3 = New Histogram_Process(spatial.ToArrayGreen, Pens.Black, img_height, img_width)
                        h4 = New Histogram_Process(spatial.ToArrayBlue, Pens.Black, img_height, img_width)
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgOriginal
                        Main_Form.status_indicator.Text = "FINISHED"
                    End If
                ElseIf filterType = "WEIGHTED SMOOTHING" Then
                    Dim spatial As New Filtering_Process(original_image, New Single(,) { _
                           {1 / 16, 2 / 16, 1 / 16}, _
                           {2 / 16, 4 / 16, 2 / 16}, _
                           {1 / 16, 2 / 16, 1 / 16}})
                    h1 = New Histogram_Process(spatial.ToArrayBW, Pens.DimGray, img_height, img_width)
                    h2 = New Histogram_Process(spatial.ToArrayRed, Pens.Red, img_height, img_width)
                    h3 = New Histogram_Process(spatial.ToArrayGreen, Pens.Green, img_height, img_width)
                    h4 = New Histogram_Process(spatial.ToArrayBlue, Pens.Blue, img_height, img_width)

                    If Main_Form.color_Disp.BackColor = Color.Black Then
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgBW
                        pixel_value = spatial.pixelBW
                        If Edit_Mode = True Then
                            original_image = spatial.ImgBW
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgRED
                        pixel_value = spatial.pixelRED
                        If Edit_Mode = True Then
                            original_image = spatial.ImgRED
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgGREEN
                        pixel_value = spatial.pixelGREEN
                        If Edit_Mode = True Then
                            original_image = spatial.ImgGREEN
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgBLUE
                        pixel_value = spatial.pixelBLUE
                        If Edit_Mode = True Then
                            original_image = spatial.ImgBLUE
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                        h1 = New Histogram_Process(spatial.ToArrayBW, Pens.Black, img_height, img_width)
                        h2 = New Histogram_Process(spatial.ToArrayRed, Pens.Black, img_height, img_width)
                        h3 = New Histogram_Process(spatial.ToArrayGreen, Pens.Black, img_height, img_width)
                        h4 = New Histogram_Process(spatial.ToArrayBlue, Pens.Black, img_height, img_width)
                        Main_Form.Img_preview.BackgroundImage = spatial.ImgOriginal
                        Main_Form.status_indicator.Text = "FINISHED"
                    End If
                ElseIf filterType = "SOBEL" Then
                    Dim spatial1 As New Filtering_Process(original_image, New Single(,) { _
                             {-1, -2, -1}, _
                             {0, 0, 0}, _
                             {1, 2, 1}})
                    Dim spatial2 As New Filtering_Process(spatial1.ImgOriginal, New Single(,) { _
                           {-1, 0, 1}, _
                           {-2, 0, 2}, _
                           {-1, 0, 1}})
                    h1 = New Histogram_Process(spatial2.ToArrayBW, Pens.DimGray, img_height, img_width)
                    h2 = New Histogram_Process(spatial2.ToArrayRed, Pens.Red, img_height, img_width)
                    h3 = New Histogram_Process(spatial2.ToArrayGreen, Pens.Green, img_height, img_width)
                    h4 = New Histogram_Process(spatial2.ToArrayBlue, Pens.Blue, img_height, img_width)

                    If Main_Form.color_Disp.BackColor = Color.Black Then
                        Main_Form.Img_preview.BackgroundImage = spatial2.ImgBW
                        pixel_value = spatial2.pixelBW
                        If Edit_Mode = True Then
                            original_image = spatial2.ImgBW
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                        Main_Form.Img_preview.BackgroundImage = spatial2.ImgRED
                        pixel_value = spatial2.pixelRED
                        If Edit_Mode = True Then
                            original_image = spatial2.ImgRED
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                        Main_Form.Img_preview.BackgroundImage = spatial2.ImgGREEN
                        pixel_value = spatial2.pixelGREEN
                        If Edit_Mode = True Then
                            original_image = spatial2.ImgGREEN
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                        Main_Form.Img_preview.BackgroundImage = spatial2.ImgBLUE
                        pixel_value = spatial2.pixelBLUE
                        If Edit_Mode = True Then
                            original_image = spatial2.ImgBLUE
                        End If
                        Main_Form.status_indicator.Text = "FINISHED"
                    ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                        h1 = New Histogram_Process(spatial2.ToArrayBW, Pens.Black, img_height, img_width)
                        h2 = New Histogram_Process(spatial2.ToArrayRed, Pens.Black, img_height, img_width)
                        h3 = New Histogram_Process(spatial2.ToArrayGreen, Pens.Black, img_height, img_width)
                        h4 = New Histogram_Process(spatial2.ToArrayBlue, Pens.Black, img_height, img_width)
                        Main_Form.Img_preview.BackgroundImage = spatial2.ImgOriginal
                        Main_Form.status_indicator.Text = "FINISHED"
                    End If
                Else
                End If
            Else
            End If
        ElseIf Effect_Toggle = 12 Then

        ElseIf Effect_Toggle = 13 Then
            Dim custom As New Filtering_Process(original_image, New Single(,) { _
                           {_f(0), _f(1), _f(2)}, _
                           {_f(3), _f(4), _f(5)}, _
                           {_f(6), _f(7), _f(8)}})
            h1 = New Histogram_Process(custom.ToArrayBW, Pens.DimGray, img_height, img_width)
            h2 = New Histogram_Process(custom.ToArrayRed, Pens.Red, img_height, img_width)
            h3 = New Histogram_Process(custom.ToArrayGreen, Pens.Green, img_height, img_width)
            h4 = New Histogram_Process(custom.ToArrayBlue, Pens.Blue, img_height, img_width)

            If Main_Form.color_Disp.BackColor = Color.Black Then
                Main_Form.Img_preview.BackgroundImage = custom.ImgBW
                pixel_value = custom.pixelBW
                If Edit_Mode = True Then
                    original_image = custom.ImgBW
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Red Then
                Main_Form.Img_preview.BackgroundImage = custom.ImgRED
                pixel_value = custom.pixelRED
                If Edit_Mode = True Then
                    original_image = custom.ImgRED
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Green Then
                Main_Form.Img_preview.BackgroundImage = custom.ImgGREEN
                pixel_value = custom.pixelGREEN
                If Edit_Mode = True Then
                    original_image = custom.ImgGREEN
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.Blue Then
                Main_Form.Img_preview.BackgroundImage = custom.ImgBLUE
                pixel_value = custom.pixelBLUE
                If Edit_Mode = True Then
                    original_image = custom.ImgBLUE
                End If
                Main_Form.status_indicator.Text = "FINISHED"
            ElseIf Main_Form.color_Disp.BackColor = Color.DimGray Then
                h1 = New Histogram_Process(custom.ToArrayBW, Pens.Black, img_height, img_width)
                h2 = New Histogram_Process(custom.ToArrayRed, Pens.Black, img_height, img_width)
                h3 = New Histogram_Process(custom.ToArrayGreen, Pens.Black, img_height, img_width)
                h4 = New Histogram_Process(custom.ToArrayBlue, Pens.Black, img_height, img_width)
                Main_Form.Img_preview.BackgroundImage = custom.ImgOriginal
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
