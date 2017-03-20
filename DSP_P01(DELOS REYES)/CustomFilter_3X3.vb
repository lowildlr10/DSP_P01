Public Class CustomFilter_3X3
    Private filterType As String = ""

    Private Sub btn_Filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Filter.Click
        Dim _F() As Single = {Val(F1.Text), Val(F2.Text), Val(F3.Text), Val(F4.Text), _
                             Val(F5.Text), Val(F6.Text), Val(F7.Text), Val(F8.Text), Val(F9.Text)}

        filterType = "CUSTOM"

        Main_Form._getFilterType(filterType)
        Main_Form._getCustomFilters(_F)

        Main_Form.combo_Filter2.Text = Nothing
        Main_Form.lbl_Filter.Text = "$AVED!"
        Me.Close()
    End Sub

    Private Sub CustomFilter_3X3_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Main_Form.combo_Filter2.Text = Nothing
        If filterType = "" Then
            Main_Form._getFilterType(filterType)
        Else
            Main_Form._getFilterType(filterType)
        End If
    End Sub

    Private Sub CustomFilter_3X3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim F() As TextBox = {F1, F2, F3, F4, F5, F6, F7, F8, F9}
        Main_Form.lbl_Filter.Text = Nothing

        For i As Integer = 0 To F.Length - 1
            F(i).Text = 0
        Next

        filterType = ""
    End Sub
End Class