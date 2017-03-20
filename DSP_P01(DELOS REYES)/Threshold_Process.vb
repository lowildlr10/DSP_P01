Public Class Threshold_Process
    Private _img As Bitmap

    Private _arrayofOriginal(,) As Integer
    Private _arrayofBW(,) As Integer
    Private _arrayofRed(,) As Integer
    Private _arrayofGreen(,) As Integer
    Private _arrayofBlue(,) As Integer

    Private _pixelOriginal As String
    Private _pixelBW As String
    Private _pixelRED As String
    Private _pixelGREEN As String
    Private _pixelBLUE As String

    Private _img_Original As Bitmap
    Private _img_BW As Bitmap
    Private _img_R As Bitmap
    Private _img_G As Bitmap
    Private _img_B As Bitmap

    Dim toggle As Integer = 0
    Dim t As Integer = 0

    Public Sub New(ByVal img As Image, ByVal input As Integer, ByVal tog As Integer)
        toggle = tog
        t = input
        _img = img
        Threshold_Process()
    End Sub

    Public Sub Threshold_Process()
        Dim img_Original As Bitmap = _img.Clone
        Dim img_BW As Bitmap = _img.Clone
        Dim img_R As Bitmap = _img.Clone
        Dim img_G As Bitmap = _img.Clone
        Dim img_B As Bitmap = _img.Clone
        Dim m, n As Integer

        m = _img.Height - 1
        n = _img.Width - 1

        ReDim _arrayofBW(m, n)
        ReDim _arrayofRed(m, n)
        ReDim _arrayofGreen(m, n)
        ReDim _arrayofBlue(m, n)


        For x As Integer = 0 To _img.Height - 1
            For y As Integer = 0 To _img.Width - 1
                Dim col As Color = _img.GetPixel(x, y)

                Dim Th_R_Original, Th_G_Original, Th_B_Original As Integer
                Dim Th_R_BW, Th_R_Red, Th_R_Green, Th_R_Blue As Integer

                Th_R_Original = col.R
                Th_G_Original = col.G
                Th_B_Original = col.B
                Th_R_BW = CInt((CInt(col.R) + CInt(col.G) + CInt(col.B)) / 3)
                Th_R_Red = col.R
                Th_R_Green = col.G
                Th_R_Blue = col.B

                If toggle = 0 Then
                    'Threshold Original Image
                    If Th_R_Original > t Then
                        Th_R_Original = 255
                    Else
                        Th_R_Original = 0
                    End If

                    If Th_G_Original > t Then
                        Th_G_Original = 255
                    Else
                        Th_G_Original = 0
                    End If

                    If Th_B_Original > t Then
                        Th_B_Original = 255
                    Else
                        Th_B_Original = 0
                    End If
                    img_Original.SetPixel(x, y, Color.FromArgb(255, Th_R_Original, Th_G_Original, Th_B_Original))
                    _pixelOriginal &= CInt(CInt(Th_R_Original) + CInt(Th_G_Original) + CInt(Th_B_Original))
                ElseIf toggle = 1 Then
                    'Threshold BW Image
                    If Th_R_BW > t Then
                        Th_R_BW = 255
                    Else
                        Th_R_BW = 0
                    End If
                    _pixelBW &= CInt((CInt(Th_R_BW) + CInt(Th_R_BW) + CInt(Th_R_BW)) / 3) & vbTab
                    _arrayofBW(x, y) = CInt((CInt(Th_R_BW) + CInt(Th_R_BW) + CInt(Th_R_BW)) / 3)
                    img_BW.SetPixel(x, y, Color.FromArgb(255, Th_R_BW, Th_R_BW, Th_R_BW))
                ElseIf toggle = 2 Then
                    'Threshold Red Image
                    If Th_R_Red > t Then
                        Th_R_Red = 255
                    Else
                        Th_R_Red = 0
                    End If
                    _pixelRED &= CInt(Th_R_Red) & vbTab
                    _arrayofRed(x, y) = Th_R_Red
                    img_R.SetPixel(x, y, Color.FromArgb(255, Th_R_Red, 0, 0))
                ElseIf toggle = 3 Then
                    'Threshold Green Image
                    If Th_R_Green > t Then
                        Th_R_Green = 255
                    Else
                        Th_R_Green = 0
                    End If
                    _pixelGREEN &= CInt(Th_R_Green) & vbTab
                    _arrayofGreen(x, y) = Th_R_Green
                    img_G.SetPixel(x, y, Color.FromArgb(255, 0, Th_R_Green, 0))
                ElseIf toggle = 4 Then
                    'Threshold Blue Image
                    If Th_R_Blue > t Then

                        Th_R_Blue = 255
                    Else
                        Th_R_Blue = 0
                    End If
                    _pixelBLUE &= CInt(Th_R_Blue) & vbTab
                    _arrayofBlue(x, y) = Th_R_Blue
                    img_B.SetPixel(x, y, Color.FromArgb(255, 0, 0, Th_R_Blue))
                Else
                End If

                _img_Original = img_Original
                _img_BW = img_BW
                _img_R = img_R
                _img_G = img_G
                _img_B = img_B
            Next
            _pixelOriginal &= vbCrLf
            _pixelBW &= vbCrLf
            _pixelRED &= vbCrLf
            _pixelGREEN &= vbCrLf
            _pixelBLUE &= vbCrLf
        Next
    End Sub

    Public Function ToArrayOriginal() As Integer(,)
        Return _arrayofOriginal
    End Function

    Public Function ToArrayBW() As Integer(,)
        Return _arrayofBW
    End Function

    Public Function ToArrayRed() As Integer(,)
        Return _arrayofRed
    End Function

    Public Function ToArrayGreen() As Integer(,)
        Return _arrayofGreen
    End Function

    Public Function ToArrayBlue() As Integer(,)
        Return _arrayofBlue
    End Function

    Public Function pixelOriginal() As String
        Return _pixelOriginal
    End Function

    Public Function pixelBW() As String
        Return _pixelBW
    End Function

    Public Function pixelRED() As String
        Return _pixelRED
    End Function

    Public Function pixelGREEN() As String
        Return _pixelGREEN
    End Function

    Public Function pixelBLUE() As String
        Return _pixelBLUE
    End Function

    Public Function ImgOriginal() As Bitmap
        Return _img_Original
    End Function

    Public Function ImgBW() As Bitmap
        Return _img_BW
    End Function

    Public Function ImgRED() As Bitmap
        Return _img_R
    End Function

    Public Function ImgGREEN() As Bitmap
        Return _img_G
    End Function

    Public Function ImgBLUE() As Bitmap
        Return _img_B
    End Function
End Class
