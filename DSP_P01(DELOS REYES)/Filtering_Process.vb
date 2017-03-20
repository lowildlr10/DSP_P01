Public Class Filtering_Process
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

    Public Sub New(ByVal img As Image, ByVal _Filter(,) As Single)
        _img = img
        Filter_Process(_Filter)
    End Sub

    Public Sub Filter_Process(ByVal Filter(,) As Single)
        Dim img_Original As Bitmap = _img.Clone
        Dim img_BW As Bitmap = _img.Clone
        Dim img_R As Bitmap = _img.Clone
        Dim img_G As Bitmap = _img.Clone
        Dim img_B As Bitmap = _img.Clone
        Dim ratio_BW(,) As Integer
        Dim ratio_Red(,) As Integer
        Dim ratio_Green(,) As Integer
        Dim ratio_Blue(,) As Integer
        Dim BWmin As Integer = Integer.MaxValue
        Dim BWmax As Integer = Integer.MinValue
        Dim Rmin As Integer = Integer.MaxValue
        Dim Rmax As Integer = Integer.MinValue
        Dim Gmin As Integer = Integer.MaxValue
        Dim Gmax As Integer = Integer.MinValue
        Dim Bmin As Integer = Integer.MaxValue
        Dim Bmax As Integer = Integer.MinValue
        Dim ave, R, G, B As Integer
        Dim m, n As Integer

        m = _img.Height - 1
        n = _img.Width - 1

        ReDim _arrayofBW(m, n)
        ReDim _arrayofRed(m, n)
        ReDim _arrayofGreen(m, n)
        ReDim _arrayofBlue(m, n)
        ReDim ratio_BW(m, n)
        ReDim ratio_Red(m, n)
        ReDim ratio_Green(m, n)
        ReDim ratio_Blue(m, n)

        For x As Integer = 1 To m - 1
            For y As Integer = 1 To n - 1
                R = 0
                G = 0
                B = 0

                For Ix As Integer = 0 To Filter.GetUpperBound(0)
                    For Iy As Integer = 0 To Filter.GetUpperBound(1)
                        With _img.GetPixel(x + Ix - 1, y + Iy - 1)
                            R += .R * Filter(Ix, Iy)
                            G += .G * Filter(Ix, Iy)
                            B += .B * Filter(Ix, Iy)
                        End With
                    Next
                Next

                ave = CInt((CInt(R) + CInt(G) + CInt(B)) / 3)

                _arrayofBW(x, y) = ave
                _arrayofRed(x, y) = CInt(R)
                _arrayofGreen(x, y) = CInt(G)
                _arrayofBlue(x, y) = CInt(B)
            Next
        Next

        For Each element As Integer In _arrayofBW
            BWmin = Math.Min(BWmin, element)
            BWmax = Math.Max(BWmax, element)
        Next
        For Each element As Integer In _arrayofRed
            Rmin = Math.Min(Rmin, element)
            Rmax = Math.Max(Rmax, element)
        Next
        For Each element As Integer In _arrayofGreen
            Gmin = Math.Min(Gmin, element)
            Gmax = Math.Max(Gmax, element)
        Next
        For Each element As Integer In _arrayofBlue
            Bmin = Math.Min(Bmin, element)
            Bmax = Math.Max(Bmax, element)
        Next

        For i As Integer = 0 To _img.Height - 1
            For j As Integer = 0 To _img.Width - 1
                ratio_BW(i, j) = CInt((255 * CInt(_arrayofBW(i, j) - BWmin)) / CInt(BWmax - BWmin))
                ratio_Red(i, j) = CInt((255 * CInt(_arrayofRed(i, j) - Rmin)) / CInt(Rmax - Rmin))
                ratio_Green(i, j) = CInt((255 * CInt(_arrayofGreen(i, j) - Gmin)) / CInt(Gmax - Gmin))
                ratio_Blue(i, j) = CInt((255 * CInt(_arrayofBlue(i, j) - Bmin)) / CInt(Bmax - Bmin))
            Next
        Next
 
        For x As Integer = 0 To _img.Height - 1
            For y As Integer = 0 To _img.Width - 1
                _arrayofBW(x, y) = ratio_BW(x, y)
                _arrayofRed(x, y) = ratio_Red(x, y)
                _arrayofGreen(x, y) = ratio_Green(x, y)
                _arrayofBlue(x, y) = ratio_Blue(x, y)

                _pixelBW &= _arrayofBW(x, y) & vbTab
                _pixelRED &= _arrayofRed(x, y) & vbTab
                _pixelGREEN &= _arrayofGreen(x, y) & vbTab
                _pixelBLUE &= _arrayofBlue(x, y) & vbTab

                img_Original.SetPixel(x, y, Color.FromArgb(255, _arrayofRed(x, y), _arrayofGreen(x, y), _arrayofBlue(x, y)))
                img_BW.SetPixel(x, y, Color.FromArgb(255, _arrayofBW(x, y), _arrayofBW(x, y), _arrayofBW(x, y)))
                img_R.SetPixel(x, y, Color.FromArgb(255, _arrayofRed(x, y), 0, 0))
                img_G.SetPixel(x, y, Color.FromArgb(255, 0, _arrayofGreen(x, y), 0))
                img_B.SetPixel(x, y, Color.FromArgb(255, 0, 0, _arrayofBlue(x, y)))

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
