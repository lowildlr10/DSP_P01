Public Class Histogram_Process
    Private _data(255) As Integer
    Private _pen As Pen

    Public Sub New()
        ReDim _data(255)
    End Sub
    Public Sub New(ByVal input(,) As Integer, ByVal pen As Pen, ByVal img_height As Integer, ByVal img_width As Integer)
        _pen = pen

        For i As Integer = 0 To img_height
            For j As Integer = 0 To img_width
                If input(i, j) < _data.Length Then
                    _data(input(i, j)) += 1
                End If
            Next
        Next
    End Sub

    Public Sub ToImage(ByVal e As Graphics)
        For i As Integer = 0 To _data.Length - 1
            e.DrawLine(_pen, i, 212, i, 212 - _data(i))
        Next
    End Sub
End Class
