Public Class Form1
    Dim bm As Bitmap
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSelectImage.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.jpg;*.png;*.gif;*.jpeg;*.Bmp)|*.jpg;*.png;*.gif;*.jpeg;*.Bmp" 'garuntees that it will be an image file


        If opf.ShowDialog = DialogResult.OK Then 'If they slect

            Try
                Dim importedImage As Image = Image.FromFile(opf.FileName)
                picImage.Image = importedImage
                picImage.Enabled = True
                bm = New Bitmap(picImage.Image)

                getHSL(bm.GetPixel(0, 0))

            Catch ex As Exception
                MessageBox.Show("Something is wrong with the file you selected")
            End Try



        End If
    End Sub

    Private Sub picImage_MouseClick(sender As Object, e As MouseEventArgs) Handles picImage.MouseClick
        Dim heightscale As Double = bm.Height / picImage.Height
        Dim widthScale As Double = bm.Width / picImage.Width
        getHSL(bm.GetPixel(e.X * widthScale, e.Y * heightscale))
    End Sub



    'code based off algorithm on https://www.rapidtables.com/convert/color/rgb-to-hsl.html
    Sub getHSL(ByRef c As Color)
        Dim max As Double
        Dim min As Double
        Dim diff As Double

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
                H = 60 * (((R - G) / diff) + 4)
            End If

        End If

        lblHue.Text = Math.Abs(H).ToString("#0.#")
        lblSaturation.Text = S.ToString("##0.#%")
        lblLightness.Text = L.ToString("##0.#%")


    End Sub

End Class
