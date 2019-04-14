Public Class Form1


    Dim bm As Bitmap
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSelectImage.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.jpg;*.png;*.gif;*.jpeg;*.Bmp)|*.jpg;*.png;*.gif;*.jpeg;*.Bmp"


        If opf.ShowDialog = DialogResult.OK Then

            Try
                Dim importedImage As Image = Image.FromFile(opf.FileName)
                bm = New Bitmap(importedImage)
                picImage.Image = bm
                picImage.Enabled = True

            Catch ex As Exception
                MessageBox.Show("Something is wrong with the file you selected")
            End Try

        End If
    End Sub
    Private Sub picImage_MouseClick(sender As Object, e As MouseEventArgs) Handles picImage.MouseClick

        getHSV(e)



    End Sub

    Sub getHS(ByRef e As MouseEventArgs)
        Try
            Dim c As Color = bm.GetPixel(e.X, e.Y)
            lblHue.Text = (c.GetHue).ToString("##.00")
            lblSaturation.Text = c.GetSaturation.ToString("0.000")
            'lblValue.Text = c.
        Catch ex As Exception

        End Try
    End Sub
    'code based off algorithm on https://www.rapidtables.com/convert/color/rgb-to-hsl.html
    Sub getHSV(ByRef e As MouseEventArgs)
        Dim max As Double
        Dim min As Double
        Dim diff As Double

        Dim c As Color = bm.GetPixel(e.X, e.Y)

        Dim R As Double = c.R / 255
        Dim G As Double = c.G / 255
        Dim B As Double = c.B / 255

        Dim H As Double
        Dim S As Double
        Dim L As Double


        ' Get the maximum and minimum RGB components.
        max = R
        If max < G Then max = G
        If max < B Then max = B

        min = R
        If min > G Then min = G
        If min > B Then min = B

        diff = max - min
        L = (max + min) / 2
        If diff < 0.00001 Then
            S = 0
            H = 0
        Else
            S = diff / (1 - Math.Abs((2 * L) - 1))
            If max = R Then
                H = 60 * (((G - B) / diff) Mod 6)
            ElseIf max = G Then
                H = 60 * (((B - R) / diff) + 2)
            Else
                 H = 60 * ((R - R) / diff) + 4)
            End If

        End If

        lblHue.Text = H.ToString("##.00")
        lblSaturation.Text = S.ToString("###.##%")
        lblLightness.Text = L.ToString("###.##%")


    End Sub



End Class
