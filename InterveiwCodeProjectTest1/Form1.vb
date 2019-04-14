Public Class Form1

    Dim bm As Bitmap 'Creates the bitmap as a global variable to be accessed anywhere

    'runs when the select image button is selected
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSelectImage.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.jpg;*.png;*.gif;*.jpeg;*.Bmp)|*.jpg;*.png;*.gif;*.jpeg;*.Bmp" 'garuntees that it will be an image file


        If opf.ShowDialog = DialogResult.OK Then 'If they select ok 

            Try
                Dim importedImage As Image = Image.FromFile(opf.FileName) 'import the selected image

                'Loads the Picture and allows the PictureBox to be clicked
                picImage.Image = importedImage
                picImage.Enabled = True


                bm = New Bitmap(picImage.Image) 'Create the bitmap (how I get the color of the pixel)

                getHSL(bm.GetPixel(0, 0)) 'Preload the response with the top left pixel

            Catch ex As Exception 'Executes If the image is corupted or not an image file
                MessageBox.Show("Something is wrong with the file you selected")
            End Try



        End If
    End Sub


    'Runs when the PictureBox is clicked
    Private Sub picImage_MouseClick(sender As Object, e As MouseEventArgs) Handles picImage.MouseClick

        'get the scale factor between the image and the PictureBox
        'this is so if the image isn't the same size as the PictureBox it will make it so clicking on a pixel will give the corisponding pixel on the image
        Dim heightscale As Double = bm.Height / picImage.Height
        Dim widthScale As Double = bm.Width / picImage.Width

        'Call the converter with the ajusted pixel's color
        getHSL(bm.GetPixel(e.X * widthScale, e.Y * heightscale))

    End Sub



    'code based off algorithm on https://www.rapidtables.com/convert/color/rgb-to-hsl.html
    Sub getHSL(ByRef c As Color)


        Dim max As Double
        Dim min As Double
        Dim diff As Double

        'Make the RGB values between 0.0 and 1.0
        Dim R As Double = c.R / 255
        Dim G As Double = c.G / 255
        Dim B As Double = c.B / 255

        Dim H As Double
        Dim S As Double
        Dim L As Double


        ' Get the maximum and minimum RGB values
        max = R
        If max < G Then max = G
        If max < B Then max = B

        min = R
        If min > G Then min = G
        If min > B Then min = B

        'Find the difference in the max and min RGB values
        diff = max - min

        'Find the L value 
        L = (max + min) / 2

        'if there is little to no difference, H and S are 0
        If diff < 0.00001 Then
            S = 0
            H = 0
        Else

            S = diff / (1 - Math.Abs((2 * L) - 1)) 'Find S

            'H depends on which color is more prominant
            If max = R Then 'Red is the most prominant
                H = 60 * (((G - B) / diff) Mod 6)
            ElseIf max = G Then 'Green is the most prominant
                H = 60 * (((B - R) / diff) + 2)
            Else 'Blue is the most prominant
                H = 60 * (((R - G) / diff) + 4)
            End If

        End If

        'put the values in the right labels formated correctly
        lblHue.Text = Math.Abs(H).ToString("#0.#")
        lblSaturation.Text = S.ToString("##0.#%")
        lblLightness.Text = L.ToString("##0.#%")


    End Sub

End Class
