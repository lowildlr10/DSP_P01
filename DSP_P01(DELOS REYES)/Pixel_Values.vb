Public Class Pixel_Values
    Private in_pixels As String

    Public Sub store_pixel_values(ByVal pixel As String)
        in_pixels = pixel
    End Sub

    Private Sub Pixel_Values_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        generated_Pixel_Values.Clear()
        Main_Form.BringToFront()
    End Sub

    Private Sub Pixel_Values_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        generated_Pixel_Values.Text = in_pixels
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText _
            (SaveFileDialog1.FileName, generated_Pixel_Values.Text, True)
            Main_Form.status_indicator.Text = "SAVED"
        End If
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        generated_Pixel_Values.Clear()
        Me.Close()
        Main_Form.BringToFront()
    End Sub
End Class