Public Class GraylevelSlicing_Process
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
    Dim t2 As Integer = 0
    Dim t3 As Integer = 0

    Public Sub New(ByVal img As Image, ByVal input As Integer, ByVal input2 As Integer, ByVal input3 As Integer)
        t = input
        t2 = input2
        t3 = input3
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
                Dim powR As Double = col.R
                Dim powG As Double = col.G
                Dim powB As Double = col.B
                Dim bw As Double = (powR + powG + powB) / 3

                If bw <= t3 Then
                    If bw >= t2 Then
                        bw = t
                    Else
                        bw = powR
                    End If
                End If

                If powR <= t3 Then
                    If powR >= t2 Then
                        powR = t
                    Else
                        powR = powR
                    End If
                End If

                If powG <= t3 Then
                    If powG >= t2 Then
                        powG = t
                    Else
                        powG = powG
                    End If
                End If

                If powB <= t3 Then
                    If powB >= t2 Then
                        powB = t
                    Else
                        powB = powB
                    End If
                End If

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
