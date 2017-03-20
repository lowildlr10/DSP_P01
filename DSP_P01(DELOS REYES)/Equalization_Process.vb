Public Class Equalization_Process
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

    Private ave, R, G, B As Integer
    Private m, n As Integer
    Private pixBW(,), pixR(,), pixG(,), pixB(,), pixTemp(,) As Integer
    Private freqBW(,), freqR(,), freqG(,), freqB(,) As Integer
    Private newFreqBW(), newFreqR(), newFreqG(), newFreqB() As Integer
    Private CDFBW(), CDFR(), CDFG(), CDFB() As Integer
    Private transBW(), transR(), transG(), transB() As Integer
    Private newPixelsBW(), newPixelsR(), newPixelsG(), newPixelsB() As Integer
    Private hs As New HashSet(Of Integer)

    Public Sub New(ByVal img As Image, ByVal _toggle As Integer)
        _img = img
        Equalize_Process(_toggle)
    End Sub

    Private Sub Equalize_Process(ByVal t As Integer)
        Dim img_Original As Bitmap = _img.Clone
        Dim img_BW As Bitmap = _img.Clone
        Dim img_R As Bitmap = _img.Clone
        Dim img_G As Bitmap = _img.Clone
        Dim img_B As Bitmap = _img.Clone

        m = _img.Height - 1
        n = _img.Width - 1

        ReDim _arrayofBW(m, n)
        ReDim _arrayofRed(m, n)
        ReDim _arrayofGreen(m, n)
        ReDim _arrayofBlue(m, n)
        ReDim pixBW(m, n)
        ReDim pixR(m, n)
        ReDim pixG(m, n)
        ReDim pixB(m, n)
        ReDim pixTemp(m, n)
        ReDim freqBW(m, n)
        ReDim freqR(m, n)
        ReDim freqG(m, n)
        ReDim freqB(m, n)

        For x As Integer = 0 To m
            For y As Integer = 0 To n
                Dim col As Color = _img.GetPixel(x, y)
                _arrayofBW(x, y) = CInt((CInt(col.R) + CInt(col.G) + CInt(col.B)) / 3)
                pixBW(x, y) = _arrayofBW(x, y)
                _arrayofRed(x, y) = CInt(col.R)
                pixR(x, y) = _arrayofRed(x, y)
                _arrayofGreen(x, y) = CInt(col.G)
                pixG(x, y) = _arrayofGreen(x, y)
                _arrayofBlue(x, y) = CInt(col.B)
                pixB(x, y) = _arrayofBlue(x, y)
            Next
        Next

        If t = 1 Then
            BW()
        End If
        If t = 2 Then
            Red()
        End If
        If t = 3 Then
            Green()
        End If
        If t = 4 Then
            Blue()
        End If
        If t = 5 Then
            original()
        End If
    End Sub

    Private Sub BW()
        'SORTING
        For x1 As Integer = 0 To _img.Height - 1
            For y1 As Integer = 0 To _img.Width - 1
                For x2 As Integer = 0 To _img.Height - 1
                    For y2 As Integer = 0 To _img.Width - 1
                        Dim temp As Integer
                        If pixBW(x1, y1) < pixBW(x2, y2) Then
                            temp = pixBW(x1, y1)
                            pixBW(x1, y1) = pixBW(x2, y2)
                            pixBW(x2, y2) = temp
                        End If
                    Next
                Next
            Next
        Next

        'FREQUENCY COUNT
        For x1 As Integer = 0 To _img.Height - 1
            For y1 As Integer = 0 To _img.Width - 1
                For x2 As Integer = 0 To _img.Height - 1
                    For y2 As Integer = 0 To _img.Width - 1
                        If pixBW(x1, y1) = pixBW(x2, y2) Then
                            freqBW(x1, y1) += 1
                        End If
                        If pixBW(x1, y1) = 0 Or pixBW(x2, y2) = 0 Then
                            freqBW(x1, y1) = 0
                        End If
                    Next
                Next
            Next
        Next

        For Each pixels As Integer In pixBW
            If Not hs.Contains(pixels) Then
                hs.Add(pixels)
            End If
        Next
        newPixelsBW = hs.ToArray
        hs.Clear()

        ReDim newFreqBW(newPixelsBW.Length - 1)
        ReDim CDFBW(newPixelsBW.Length - 1)
        ReDim transBW(newPixelsBW.Length - 1)

        'FREQUENCY COUNT
        For z As Integer = 0 To newFreqBW.Length - 1
            For x As Integer = 0 To _img.Height - 1
                For y As Integer = 0 To _img.Width - 1
                    If newPixelsBW(z) = pixBW(x, y) Then
                        newFreqBW(z) = freqBW(x, y)
                    End If
                Next
            Next
        Next

        'CFD
        CDFBW(0) = newFreqBW(0)
        For i As Integer = 1 To newFreqBW.Length - 1
            CDFBW(i) = CDFBW(i - 1) + newFreqBW(i)
        Next

        'TRANSFORMATION
        For i As Integer = 0 To newPixelsBW.Length - 1
            transBW(i) = CInt((((CDFBW(i) - CDFBW(0)) / ((_img.Height * _img.Width) - CDFBW(0))) * 255))
        Next
        For x As Integer = 0 To _img.Height - 1
            For y As Integer = 0 To _img.Width - 1
                For i As Integer = 0 To newPixelsBW.Length - 1
                    If _arrayofBW(x, y) = newPixelsBW(i) Then
                        pixTemp(x, y) = transBW(i)
                    End If
                Next
            Next
        Next

        FinalTouch(1)
    End Sub

    Private Sub Red()
        'SORTING
        For x1 As Integer = 0 To _img.Height - 1
            For y1 As Integer = 0 To _img.Width - 1
                For x2 As Integer = 0 To _img.Height - 1
                    For y2 As Integer = 0 To _img.Width - 1
                        Dim temp As Integer
                        If pixR(x1, y1) < pixR(x2, y2) Then
                            temp = pixR(x1, y1)
                            pixR(x1, y1) = pixR(x2, y2)
                            pixR(x2, y2) = temp
                        End If
                    Next
                Next
            Next
        Next

        'FREQUENCY COUNT
        For x1 As Integer = 0 To _img.Height - 1
            For y1 As Integer = 0 To _img.Width - 1
                For x2 As Integer = 0 To _img.Height - 1
                    For y2 As Integer = 0 To _img.Width - 1
                        If pixR(x1, y1) = pixR(x2, y2) Then
                            freqR(x1, y1) += 1
                        End If
                        If pixR(x1, y1) = 0 Or pixR(x2, y2) = 0 Then
                            freqR(x1, y1) = 0
                        End If
                    Next
                Next
            Next
        Next

        For Each pixels As Integer In pixR
            If Not hs.Contains(pixels) Then
                hs.Add(pixels)
            End If
        Next
        newPixelsR = hs.ToArray
        hs.Clear()
        ReDim newFreqR(newPixelsR.Length - 1)
        ReDim CDFR(newPixelsR.Length - 1)
        ReDim transR(newPixelsR.Length - 1)

        'FREQUENCY COUNT
        For z As Integer = 0 To newFreqR.Length - 1
            For x As Integer = 0 To _img.Height - 1
                For y As Integer = 0 To _img.Width - 1
                    If newPixelsR(z) = pixR(x, y) Then
                        newFreqR(z) = freqR(x, y)
                    End If
                Next
            Next
        Next

        'CDF
        CDFR(0) = newFreqR(0)
        For i As Integer = 1 To newFreqR.Length - 1
            CDFR(i) = CDFR(i - 1) + newFreqR(i)
        Next

        'TRANSFORMATION
        For i As Integer = 0 To newPixelsR.Length - 1
            transR(i) = CInt((((CDFR(i) - CDFR(0)) / ((_img.Height * _img.Width) - CDFR(0))) * 255))
        Next
        For x As Integer = 0 To _img.Height - 1
            For y As Integer = 0 To _img.Width - 1
                For i As Integer = 0 To newPixelsR.Length - 1
                    If _arrayofRed(x, y) = newPixelsR(i) Then
                        pixTemp(x, y) = transR(i)
                    End If
                Next
            Next
        Next

        FinalTouch(2)
    End Sub

    Private Sub Green()
        'SORTING
        For x1 As Integer = 0 To _img.Height - 1
            For y1 As Integer = 0 To _img.Width - 1
                For x2 As Integer = 0 To _img.Height - 1
                    For y2 As Integer = 0 To _img.Width - 1
                        Dim temp As Integer
                        If pixG(x1, y1) < pixG(x2, y2) Then
                            temp = pixG(x1, y1)
                            pixG(x1, y1) = pixG(x2, y2)
                            pixG(x2, y2) = temp
                        End If
                    Next
                Next
            Next
        Next

        'FREQUENCY COUNT
        For x1 As Integer = 0 To _img.Height - 1
            For y1 As Integer = 0 To _img.Width - 1
                For x2 As Integer = 0 To _img.Height - 1
                    For y2 As Integer = 0 To _img.Width - 1
                        If pixG(x1, y1) = pixG(x2, y2) Then
                            freqG(x1, y1) += 1
                        End If
                        If pixG(x1, y1) = 0 Or pixG(x2, y2) = 0 Then
                            freqG(x1, y1) = 0
                        End If
                    Next
                Next
            Next
        Next

        For Each pixels As Integer In pixG
            If Not hs.Contains(pixels) Then
                hs.Add(pixels)
            End If
        Next
        newPixelsG = hs.ToArray
        hs.Clear()
        ReDim newFreqG(newPixelsG.Length - 1)
        ReDim CDFG(newPixelsG.Length - 1)
        ReDim transG(newPixelsG.Length - 1)

        'FREQUENCY COUNT
        For z As Integer = 0 To newFreqG.Length - 1
            For x As Integer = 0 To _img.Height - 1
                For y As Integer = 0 To _img.Width - 1
                    If newPixelsG(z) = pixG(x, y) Then
                        newFreqG(z) = freqG(x, y)
                    End If
                Next
            Next
        Next

        'CDF
        CDFG(0) = newFreqG(0)
        For i As Integer = 1 To newFreqG.Length - 1
            CDFG(i) = CDFG(i - 1) + newFreqG(i)
        Next

        'TRANSFORMATION
        For i As Integer = 0 To newPixelsG.Length - 1
            transG(i) = CInt((((CDFG(i) - CDFG(0)) / ((_img.Height * _img.Width) - CDFG(0))) * 255))
        Next
        For x As Integer = 0 To _img.Height - 1
            For y As Integer = 0 To _img.Width - 1
                For i As Integer = 0 To newPixelsG.Length - 1
                    If _arrayofGreen(x, y) = newPixelsG(i) Then
                        pixTemp(x, y) = transG(i)
                    End If
                Next
            Next
        Next

        FinalTouch(3)
    End Sub

    Private Sub Blue()
        'SORTING
        For x1 As Integer = 0 To _img.Height - 1
            For y1 As Integer = 0 To _img.Width - 1
                For x2 As Integer = 0 To _img.Height - 1
                    For y2 As Integer = 0 To _img.Width - 1
                        Dim temp As Integer
                        If pixB(x1, y1) < pixB(x2, y2) Then
                            temp = pixB(x1, y1)
                            pixB(x1, y1) = pixB(x2, y2)
                            pixB(x2, y2) = temp
                        End If
                    Next
                Next
            Next
        Next

        'FREQUENCY COUNT
        For x1 As Integer = 0 To _img.Height - 1
            For y1 As Integer = 0 To _img.Width - 1
                For x2 As Integer = 0 To _img.Height - 1
                    For y2 As Integer = 0 To _img.Width - 1
                        If pixB(x1, y1) = pixB(x2, y2) Then
                            freqB(x1, y1) += 1
                        End If
                        If pixB(x1, y1) = 0 Or pixB(x2, y2) = 0 Then
                            freqB(x1, y1) = 0
                        End If
                    Next
                Next
            Next
        Next

        For Each pixels As Integer In pixB
            If Not hs.Contains(pixels) Then
                hs.Add(pixels)
            End If
        Next
        newPixelsB = hs.ToArray
        hs.Clear()
        ReDim newFreqB(newPixelsB.Length - 1)
        ReDim CDFB(newPixelsB.Length - 1)
        ReDim transB(newPixelsB.Length - 1)

        'FREQUENCY COUNT
        For z As Integer = 0 To newFreqB.Length - 1
            For x As Integer = 0 To _img.Height - 1
                For y As Integer = 0 To _img.Width - 1
                    If newPixelsB(z) = pixB(x, y) Then
                        newFreqB(z) = freqB(x, y)
                    End If
                Next
            Next
        Next

        'CDF
        CDFB(0) = newFreqB(0)
        For i As Integer = 1 To newFreqB.Length - 1
            CDFB(i) = CDFB(i - 1) + newFreqB(i)
        Next

        'TRANSFORMATION
        For i As Integer = 0 To newPixelsB.Length - 1
            transB(i) = CInt((((CDFB(i) - CDFB(0)) / ((_img.Height * _img.Width) - CDFB(0))) * 255))
        Next
        For x As Integer = 0 To _img.Height - 1
            For y As Integer = 0 To _img.Width - 1
                For i As Integer = 0 To newPixelsB.Length - 1
                    If _arrayofBlue(x, y) = newPixelsB(i) Then
                        pixTemp(x, y) = transB(i)
                    End If
                Next
            Next
        Next

        FinalTouch(4)
    End Sub

    Private Sub original()
        'SORTING AND FREQUENCY COUNT
        For x1 As Integer = 0 To _img.Height - 1
            For y1 As Integer = 0 To _img.Width - 1
                For x2 As Integer = 0 To _img.Height - 1
                    For y2 As Integer = 0 To _img.Width - 1
                        Dim temp As Integer
                        If pixR(x1, y1) < pixR(x2, y2) Then
                            temp = pixR(x1, y1)
                            pixR(x1, y1) = pixR(x2, y2)
                            pixR(x2, y2) = temp
                        End If

                        If pixG(x1, y1) < pixG(x2, y2) Then
                            temp = pixG(x1, y1)
                            pixG(x1, y1) = pixG(x2, y2)
                            pixG(x2, y2) = temp
                        End If

                        If pixB(x1, y1) < pixB(x2, y2) Then
                            temp = pixB(x1, y1)
                            pixB(x1, y1) = pixB(x2, y2)
                            pixB(x2, y2) = temp
                        End If
                    Next
                Next
            Next
        Next

        For x1 As Integer = 0 To _img.Height - 1
            For y1 As Integer = 0 To _img.Width - 1
                For x2 As Integer = 0 To _img.Height - 1
                    For y2 As Integer = 0 To _img.Width - 1

                        If pixR(x1, y1) = pixR(x2, y2) Then
                            freqR(x1, y1) += 1
                        End If
                        If pixR(x1, y1) = 0 Or pixR(x2, y2) = 0 Then
                            freqR(x1, y1) = 0
                        End If

                        If pixG(x1, y1) = pixG(x2, y2) Then
                            freqG(x1, y1) += 1
                        End If
                        If pixG(x1, y1) = 0 Or pixG(x2, y2) = 0 Then
                            freqG(x1, y1) = 0
                        End If

                        If pixB(x1, y1) = pixB(x2, y2) Then
                            freqB(x1, y1) += 1
                        End If
                        If pixB(x1, y1) = 0 Or pixB(x2, y2) = 0 Then
                            freqB(x1, y1) = 0
                        End If
                    Next
                Next
            Next
        Next

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''RED
        For Each pixels As Integer In pixR
            If Not hs.Contains(pixels) Then
                hs.Add(pixels)
            End If
        Next
        newPixelsR = hs.ToArray
        hs.Clear()
        ReDim newFreqR(newPixelsR.Length - 1)
        ReDim CDFR(newPixelsR.Length - 1)
        ReDim transR(newPixelsR.Length - 1)

        'FREQUENCY COUNT
        For z As Integer = 0 To newFreqR.Length - 1
            For x As Integer = 0 To _img.Height - 1
                For y As Integer = 0 To _img.Width - 1
                    If newPixelsR(z) = pixR(x, y) Then
                        newFreqR(z) = freqR(x, y)
                    End If
                Next
            Next
        Next

        'CDF
        CDFR(0) = newFreqR(0)
        For i As Integer = 1 To newFreqR.Length - 1
            CDFR(i) = CDFR(i - 1) + newFreqR(i)
        Next

        'TRANSFORMATION
        For i As Integer = 0 To newPixelsR.Length - 1
            transR(i) = CInt((((CDFR(i) - CDFR(0)) / ((_img.Height * _img.Width) - CDFR(0))) * 255))
        Next
        For x As Integer = 0 To _img.Height - 1
            For y As Integer = 0 To _img.Width - 1
                For i As Integer = 0 To newPixelsR.Length - 1
                    If _arrayofRed(x, y) = newPixelsR(i) Then
                        pixTemp(x, y) = transR(i)
                    End If
                Next
            Next
        Next

        For x As Integer = 0 To _img.Height - 1
            For y As Integer = 0 To _img.Width - 1
                _arrayofRed(x, y) = pixTemp(x, y)
            Next
        Next

        ReDim pixTemp(m, n)

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''GREEN
        For Each pixels As Integer In pixG
            If Not hs.Contains(pixels) Then
                hs.Add(pixels)
            End If
        Next
        newPixelsG = hs.ToArray
        hs.Clear()
        ReDim newFreqG(newPixelsG.Length - 1)
        ReDim CDFG(newPixelsG.Length - 1)
        ReDim transG(newPixelsG.Length - 1)

        'FREQUENCY COUNT
        For z As Integer = 0 To newFreqG.Length - 1
            For x As Integer = 0 To _img.Height - 1
                For y As Integer = 0 To _img.Width - 1
                    If newPixelsG(z) = pixG(x, y) Then
                        newFreqG(z) = freqG(x, y)
                    End If
                Next
            Next
        Next

        'CDF
        CDFG(0) = newFreqG(0)
        For i As Integer = 1 To newFreqG.Length - 1
            CDFG(i) = CDFG(i - 1) + newFreqG(i)
        Next

        'TRANSFORMATION
        For i As Integer = 0 To newPixelsG.Length - 1
            transG(i) = CInt((((CDFG(i) - CDFG(0)) / ((_img.Height * _img.Width) - CDFG(0))) * 255))
        Next
        For x As Integer = 0 To _img.Height - 1
            For y As Integer = 0 To _img.Width - 1
                For i As Integer = 0 To newPixelsG.Length - 1
                    If _arrayofGreen(x, y) = newPixelsG(i) Then
                        pixTemp(x, y) = transG(i)
                    End If
                Next
            Next
        Next

        For x As Integer = 0 To _img.Height - 1
            For y As Integer = 0 To _img.Width - 1
                _arrayofGreen(x, y) = pixTemp(x, y)
            Next
        Next

        ReDim pixTemp(m, n)

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''BLUE
        For Each pixels As Integer In pixB
            If Not hs.Contains(pixels) Then
                hs.Add(pixels)
            End If
        Next
        newPixelsB = hs.ToArray
        hs.Clear()
        ReDim newFreqB(newPixelsB.Length - 1)
        ReDim CDFB(newPixelsB.Length - 1)
        ReDim transB(newPixelsB.Length - 1)

        'FREQUENCY COUNT
        For z As Integer = 0 To newFreqB.Length - 1
            For x As Integer = 0 To _img.Height - 1
                For y As Integer = 0 To _img.Width - 1
                    If newPixelsB(z) = pixB(x, y) Then
                        newFreqB(z) = freqB(x, y)
                    End If
                Next
            Next
        Next

        'CDF
        CDFB(0) = newFreqB(0)
        For i As Integer = 1 To newFreqB.Length - 1
            CDFB(i) = CDFB(i - 1) + newFreqB(i)
        Next

        'TRANSFORMATION
        For i As Integer = 0 To newPixelsB.Length - 1
            transB(i) = CInt((((CDFB(i) - CDFB(0)) / ((_img.Height * _img.Width) - CDFB(0))) * 255))
        Next
        For x As Integer = 0 To _img.Height - 1
            For y As Integer = 0 To _img.Width - 1
                For i As Integer = 0 To newPixelsB.Length - 1
                    If _arrayofBlue(x, y) = newPixelsB(i) Then
                        pixTemp(x, y) = transB(i)
                    End If
                Next
            Next
        Next

        For x As Integer = 0 To _img.Height - 1
            For y As Integer = 0 To _img.Width - 1
                _arrayofBlue(x, y) = pixTemp(x, y)
            Next
        Next

        ReDim pixTemp(m, n)

        FinalTouch(5)
    End Sub

    Private Sub FinalTouch(ByVal t As Integer)
        Dim img_Original As Bitmap = _img.Clone
        Dim img_BW As Bitmap = _img.Clone
        Dim img_R As Bitmap = _img.Clone
        Dim img_G As Bitmap = _img.Clone
        Dim img_B As Bitmap = _img.Clone

        For x As Integer = 0 To m
            For y As Integer = 0 To n
                If t = 1 Then
                    _arrayofBW(x, y) = pixTemp(x, y)
                    _pixelBW &= _arrayofBW(x, y) & vbTab
                    ave = _arrayofBW(x, y)
                    img_BW.SetPixel(x, y, Color.FromArgb(255, ave, ave, ave))
                    _img_BW = img_BW
                ElseIf t = 2 Then
                    _arrayofRed(x, y) = pixTemp(x, y)
                    _pixelRED &= _arrayofRed(x, y) & vbTab
                    R = _arrayofRed(x, y)
                    img_R.SetPixel(x, y, Color.FromArgb(255, R, 0, 0))
                    _img_R = img_R
                ElseIf t = 3 Then
                    _arrayofGreen(x, y) = pixTemp(x, y)
                    _pixelGREEN &= _arrayofGreen(x, y) & vbTab
                    G = _arrayofGreen(x, y)
                    img_G.SetPixel(x, y, Color.FromArgb(255, 0, G, 0))
                    _img_G = img_G
                ElseIf t = 4 Then
                    _arrayofBlue(x, y) = pixTemp(x, y)
                    _pixelBLUE &= _arrayofBlue(x, y) & vbTab
                    B = _arrayofBlue(x, y)
                    img_B.SetPixel(x, y, Color.FromArgb(255, 0, 0, B))
                    _img_B = img_B
                ElseIf t = 5 Then
                    _pixelRED &= _arrayofRed(x, y) & vbTab
                    _pixelGREEN &= _arrayofGreen(x, y) & vbTab
                    _pixelBLUE &= _arrayofBlue(x, y) & vbTab
                    R = _arrayofRed(x, y)
                    G = _arrayofGreen(x, y)
                    B = _arrayofBlue(x, y)
                    img_Original.SetPixel(x, y, Color.FromArgb(255, R, G, B))
                    _img_Original = img_Original
                    _img_B = img_B
                End If
            Next
            If t = 1 Then
                _pixelBW &= vbCrLf
            ElseIf t = 2 Then
                _pixelRED &= vbCrLf
            ElseIf t = 3 Then
                _pixelGREEN &= vbCrLf
            ElseIf t = 4 Then
                _pixelBLUE &= vbCrLf
            End If
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
