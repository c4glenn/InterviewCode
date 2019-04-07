Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSelectImage.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"

        If opf.ShowDialog = DialogResult.OK Then
            Try
                picImage.Image = Image.FromFile(opf.FileName)
            Catch ex As Exception
                MessageBox.Show("Something is wrong with the file you selected")
            End Try

        End If

    End Sub
End Class
