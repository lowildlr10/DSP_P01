Public Class Power_Process
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

    Public Sub New(ByVal img As Image, ByVal input As Integer)
        t = input
        _img = img
        Power_Process()
    End Sub

    Private Sub Power_Process()
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
                Dim powR As Double = 255 * ((col.R / 255) ^ t)
                Dim powG As Double = 255 * ((col.G / 255) ^ t)
                Dim powB As Double = 255 * ((col.B / 255) ^ t)
                Dim bw As Double = (powR + powG + powB) / 3

                _arrayofBW(x, y) = bw
                _arrayofRed(x, y) = powR
                _arrayofGreen(x, y) = powG
                _arrayofBlue(x, y) = powB

                _pixelBW &= CInt(bw) & vbTab
                _pixelRED &= CInt(powR) & vbTab
                _pixelGREEN &= CInt(powG) & vbTab
                _pixelBLUE &= CInt(powB) & vbTab

                img_Original.SetPixel(x, y, Color.FromArgb(255, powR, powG, powB))
                img_BW.SetPixel(x, y, Color.FromArgb(255, bw, bw, bw))
                img_R.SetPixel(x, y, Color.FromArgb(255, powR, 0, 0))
                img_G.SetPixel(x, y, Color.FromArgb(255, 0, powG, 0))
                img_B.SetPixel(x, y, Color.FromArgb(255, 0, 0, powB))

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
