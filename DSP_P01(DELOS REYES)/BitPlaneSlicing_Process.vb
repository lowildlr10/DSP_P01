Public Class BitPlaneSlicing_Process
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

    Private Nth_Bit As Integer

    Public Sub New(ByVal img As Image, ByVal bit As Integer)
        _img = img
        Nth_Bit = bit
        RGB_Process()
    End Sub

    Private Sub RGB_Process()
        Dim img_Original As Bitmap = _img.Clone
        Dim img_BW As Bitmap = _img.Clone
        Dim img_R As Bitmap = _img.Clone
        Dim img_G As Bitmap = _img.Clone
        Dim img_B As Bitmap = _img.Clone
        Dim ave, R, G, B As Integer
        Dim NumBin01(,), NumBin02(,), NumBin03(,), NumBin04(,), nthBit01(,), nthBit02(,), _
         nthBit03(,), nthBit04(,) As String
        Dim m, n As Integer

        m = _img.Height - 1
        n = _img.Width - 1

        ReDim NumBin01(m, n)
        ReDim NumBin02(m, n)
        ReDim NumBin03(m, n)
        ReDim NumBin04(m, n)
        ReDim nthBit01(m, n)
        ReDim nthBit02(m, n)
        ReDim nthBit03(m, n)
        ReDim nthBit04(m, n)
        ReDim _arrayofBW(m, n)
        ReDim _arrayofRed(m, n)
        ReDim _arrayofGreen(m, n)
        ReDim _arrayofBlue(m, n)

        For x As Integer = 0 To _img.Height - 1
            For y As Integer = 0 To _img.Width - 1
                Dim col As Color = _img.GetPixel(x, y)
                Dim nth As Integer = 0
                Dim firBit(,), secBit(,), thrBit(,), fthBit(,), fifBit(,), sixBit(,), _
                    sevBit(,), ethBit(,) As String

                ReDim firBit(m, n), secBit(m, n), thrBit(m, n), fthBit(m, n), fifBit(m, n), _
                sixBit(m, n), sevBit(m, n), ethBit(m, n)

                _arrayofBW(x, y) = CInt((CInt(col.R) + CInt(col.G) + CInt(col.B)) / 3)
                _arrayofRed(x, y) = col.R
                _arrayofGreen(x, y) = col.G
                _arrayofBlue(x, y) = col.B

                NumBin01(x, y) = Convert.ToString(_arrayofBW(x, y), 2).PadLeft(8, "0"c)
                NumBin02(x, y) = Convert.ToString(_arrayofRed(x, y), 2).PadLeft(8, "0"c)
                NumBin03(x, y) = Convert.ToString(_arrayofGreen(x, y), 2).PadLeft(8, "0"c)
                NumBin04(x, y) = Convert.ToString(_arrayofBlue(x, y), 2).PadLeft(8, "0"c)

                If Nth_Bit = 1 Then
                    nthBit01(x, y) = NumBin01(x, y)(7 - nth)
                    nthBit02(x, y) = NumBin02(x, y)(7 - nth)
                    nthBit03(x, y) = NumBin03(x, y)(7 - nth)
                    nthBit04(x, y) = NumBin04(x, y)(7 - nth)
                ElseIf Nth_Bit = 2 Then
                    nthBit01(x, y) = NumBin01(x, y)(6 - nth)
                    nthBit02(x, y) = NumBin02(x, y)(6 - nth)
                    nthBit03(x, y) = NumBin03(x, y)(6 - nth)
                    nthBit04(x, y) = NumBin04(x, y)(6 - nth)
                ElseIf Nth_Bit = 3 Then
                    nthBit01(x, y) = NumBin01(x, y)(5 - nth)
                    nthBit02(x, y) = NumBin02(x, y)(5 - nth)
                    nthBit03(x, y) = NumBin03(x, y)(5 - nth)
                    nthBit04(x, y) = NumBin04(x, y)(5 - nth)
                ElseIf Nth_Bit = 4 Then
                    nthBit01(x, y) = NumBin01(x, y)(4 - nth)
                    nthBit02(x, y) = NumBin02(x, y)(4 - nth)
                    nthBit03(x, y) = NumBin03(x, y)(4 - nth)
                    nthBit04(x, y) = NumBin04(x, y)(4 - nth)
                ElseIf Nth_Bit = 5 Then
                    nthBit01(x, y) = NumBin01(x, y)(3 - nth)
                    nthBit02(x, y) = NumBin02(x, y)(3 - nth)
                    nthBit03(x, y) = NumBin03(x, y)(3 - nth)
                    nthBit04(x, y) = NumBin04(x, y)(3 - nth)
                ElseIf Nth_Bit = 6 Then
                    nthBit01(x, y) = NumBin01(x, y)(2 - nth)
                    nthBit02(x, y) = NumBin02(x, y)(2 - nth)
                    nthBit03(x, y) = NumBin03(x, y)(2 - nth)
                    nthBit04(x, y) = NumBin04(x, y)(2 - nth)
                ElseIf Nth_Bit = 7 Then
                    nthBit01(x, y) = NumBin01(x, y)(1 - nth)
                    nthBit02(x, y) = NumBin02(x, y)(1 - nth)
                    nthBit03(x, y) = NumBin03(x, y)(1 - nth)
                    nthBit04(x, y) = NumBin04(x, y)(1 - nth)
                Else
                    nthBit01(x, y) = NumBin01(x, y)(0 - nth)
                    nthBit02(x, y) = NumBin02(x, y)(0 - nth)
                    nthBit03(x, y) = NumBin03(x, y)(0 - nth)
                    nthBit04(x, y) = NumBin04(x, y)(0 - nth)
                End If

                'BW
                If nthBit01(x, y) = "1" Then
                    nthBit01(x, y) = 255
                Else
                    nthBit01(x, y) = 0
                End If

                'RED
                If nthBit02(x, y) = "1" Then
                    nthBit02(x, y) = 255
                Else
                    nthBit02(x, y) = 0
                End If

                'GREEN
                If nthBit03(x, y) = "1" Then
                    nthBit03(x, y) = 255
                Else
                    nthBit03(x, y) = 0
                End If

                'BLUE
                If nthBit04(x, y) = "1" Then
                    nthBit04(x, y) = 255
                Else
                    nthBit04(x, y) = 0
                End If

                ave = nthBit01(x, y)
                R = nthBit02(x, y)
                G = nthBit03(x, y)
                B = nthBit04(x, y)

                _arrayofBW(x, y) = ave
                _arrayofRed(x, y) = R
                _arrayofGreen(x, y) = G
                _arrayofBlue(x, y) = B

                _pixelBW &= ave & vbTab
                _pixelRED &= R & vbTab
                _pixelGREEN &= G & vbTab
                _pixelBLUE &= B & vbTab

                img_Original.SetPixel(x, y, Color.FromArgb(255, R, G, B))
                img_BW.SetPixel(x, y, Color.FromArgb(255, ave, ave, ave))
                img_R.SetPixel(x, y, Color.FromArgb(255, R, 0, 0))
                img_G.SetPixel(x, y, Color.FromArgb(255, 0, G, 0))
                img_B.SetPixel(x, y, Color.FromArgb(255, 0, 0, B))

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
