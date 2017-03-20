Public Class Hue_Process
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

    Public Sub New(ByVal img As Image)
        _img = img
        Hue_Process()
    End Sub

    Private Sub Hue_Process()
        Dim img_Original As Bitmap = _img.Clone
        Dim img_BW As Bitmap = _img.Clone
        Dim img_R As Bitmap = _img.Clone
        Dim img_G As Bitmap = _img.Clone
        Dim img_B As Bitmap = _img.Clone
        Dim ave, R, G, B As Integer
        Dim m, n As Integer

        Dim hue, h1, h2, h3, p As Double

        m = _img.Height - 1
        n = _img.Width - 1

        ReDim _arrayofBW(m, n)
        ReDim _arrayofRed(m, n)
        ReDim _arrayofGreen(m, n)
        ReDim _arrayofBlue(m, n)

        For x As Integer = 0 To _img.Height - 1
            For y As Integer = 0 To _img.Width - 1
                Dim col As Color = _img.GetPixel(x, y)

                R = col.R
                G = col.G
                B = col.B

                h1 = (((R - G) + (R - B)) / 2)
                h2 = Math.Sqrt(((R - G) * (R - G)) + ((R - B) * (G - B)))

                If h1 = 0 And h2 = 0 Then
                    h3 = Math.Acos(1)
                Else
                    h3 = Math.Acos(h1 / h2)
                End If

                p = h3 * (180 / Math.PI)

                If B <= G Then
                    hue = p
                ElseIf B > G Then
                    hue = 360 - p
                End If

                If hue > 255 Then
                    hue = 255
                ElseIf hue < 0 Then
                    hue = 0
                End If

                ave = CInt((CInt(hue) + CInt(hue) + CInt(hue)) / 3)

                _arrayofBW(x, y) = ave
                _arrayofRed(x, y) = CInt(hue)
                _arrayofGreen(x, y) = CInt(hue)
                _arrayofBlue(x, y) = CInt(hue)

                _pixelBW &= ave & vbTab
                _pixelRED &= CInt(hue) & vbTab
                _pixelGREEN &= CInt(hue) & vbTab
                _pixelBLUE &= CInt(hue) & vbTab

                img_Original.SetPixel(x, y, Color.FromArgb(255, hue, hue, hue))
                img_BW.SetPixel(x, y, Color.FromArgb(255, ave, ave, ave))
                img_R.SetPixel(x, y, Color.FromArgb(255, hue, 0, 0))
                img_G.SetPixel(x, y, Color.FromArgb(255, 0, hue, 0))
                img_B.SetPixel(x, y, Color.FromArgb(255, 0, 0, hue))

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
