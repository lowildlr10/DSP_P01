Public Class Saturation_Process
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
        Saturation_Process()
    End Sub

    Private Sub Saturation_Process()
        Dim img_Original As Bitmap = _img.Clone
        Dim img_BW As Bitmap = _img.Clone
        Dim img_R As Bitmap = _img.Clone
        Dim img_G As Bitmap = _img.Clone
        Dim img_B As Bitmap = _img.Clone
        Dim ave, R, G, B As Integer
        Dim m, n As Integer

        Dim sat, s, p As Double

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

                p = R + G + B

                If p <= 0 Then
                    sat = 0
                Else
                    If B < G Then
                        If B < R Then
                            s = B
                        End If
                    ElseIf R < B Then
                        If R < G Then
                            s = R
                        End If
                    ElseIf G < B Then
                        If G < R Then
                            s = G
                        End If
                    End If

                    sat = 255 * (1 - (3 / p) * s)

                    If sat <= 0 Then
                        sat = 0
                    End If

                End If

                ave = CInt((CInt(sat) + CInt(sat) + CInt(sat)) / 3)

                _arrayofBW(x, y) = ave
                _arrayofRed(x, y) = CInt(sat)
                _arrayofGreen(x, y) = CInt(sat)
                _arrayofBlue(x, y) = CInt(sat)

                _pixelBW &= CInt((CInt(ave) + CInt(ave) + CInt(ave)) / 3) & vbTab
                _pixelRED &= CInt(sat) & vbTab
                _pixelGREEN &= CInt(sat) & vbTab
                _pixelBLUE &= CInt(sat) & vbTab

                img_Original.SetPixel(x, y, Color.FromArgb(255, sat, sat, sat))
                img_BW.SetPixel(x, y, Color.FromArgb(255, ave, ave, ave))
                img_R.SetPixel(x, y, Color.FromArgb(255, sat, 0, 0))
                img_G.SetPixel(x, y, Color.FromArgb(255, 0, sat, 0))
                img_B.SetPixel(x, y, Color.FromArgb(255, 0, 0, sat))

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
