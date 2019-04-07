Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"

        If opf.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If

    End Sub
End Class
