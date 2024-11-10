Public Class Form1
    Dim baris As Long
    Dim kolom As Long

    Dim CustomFilter(2, 2) As Integer
    Dim FilterNorm As Integer
    Dim FilterBias As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdGreyScale.Enabled = False
        cmdSmooth.Enabled = False
        cmdSharpen.Enabled = False

        Picture1.SizeMode = 4
        Picture2.SizeMode = 4

        Me.Width = 1000
    End Sub

    Private Sub cmdLoadPicture_Click(sender As Object, e As EventArgs) Handles cmdLoadPicture.Click
        Dim PictureName As String

        OpenFileDialog1.Filter = "Images|*.BPM;*.GIF;*.JPG|All Files|*.*"
        OpenFileDialog1.ShowDialog()
        PictureName = OpenFileDialog1.FileName

        If PictureName <> "" Then
            Picture1.Image = Image.FromFile(PictureName)
            cmdGreyScale.Enabled = True
            cmdSmooth.Enabled = True
            cmdSharpen.Enabled = True

            Dim gambar As New Bitmap(Picture1.Image)
            baris = gambar.Height
            kolom = gambar.Width
            ToolStripProgressBar1.Minimum = 0
            ToolStripProgressBar1.Maximum = kolom
        Else
            cmdGreyScale.Enabled = False
            cmdSmooth.Enabled = False
            cmdSharpen.Enabled = False
        End If
    End Sub

    Private Sub cmdGreyScale_Click(sender As Object, e As EventArgs) Handles cmdGreyScale.Click
        ToolStripStatusLabel1.Text = "Please wait..."
        Refresh()

        Dim i As Integer, j As Integer
        Dim red As Integer, green As Integer, blue As Integer, grey As Integer

        Picture2.Image = Picture1.Image
        Picture1.Refresh()

        Dim gambar As New Bitmap(Picture2.Image)
        baris = gambar.Height
        kolom = gambar.Width

        For i = 0 To baris - 1
            For j = 0 To kolom - 1
                red = CInt(gambar.GetPixel(j, i).R)
                green = CInt(gambar.GetPixel(j, i).G)
                blue = CInt(gambar.GetPixel(j, i).B)
                grey = Int((red + green + blue) / 3)
                gambar.SetPixel(j, i, Color.FromArgb(grey, grey, grey))
            Next
            ToolStripProgressBar1.Increment(1)
        Next
        Picture2.Image = gambar
        Picture2.Refresh()
        ToolStripStatusLabel1.Text = "Ready..."
    End Sub

    Private Sub cmdSmooth_Click(sender As Object, e As EventArgs) Handles cmdSmooth.Click
        ToolStripStatusLabel1.Text = "Please wait..."
        Refresh()
        Dim i As Integer, j As Integer
        Dim Dx As Integer = 1
        Dim Dy As Integer = 1
        Dim red As Integer, green As Integer, blue As Integer
        Picture2.Image = Picture1.Image
        Picture1.Refresh()
        Dim gambar As New Bitmap(Picture2.Image)
        baris = gambar.Height
        kolom = gambar.Width
        For i = 1 To baris - 2
            For j = 1 To kolom - 2
                red = CInt(CInt(gambar.GetPixel(j - 1, i - 1).R) + CInt(gambar.GetPixel(j, i - 1).R) +
                    CInt(gambar.GetPixel(j + 1, i - 1).R) + CInt(gambar.GetPixel(j - 1, i).R) +
                    CInt(gambar.GetPixel(j, i).R) + CInt(gambar.GetPixel(j + 1, i).R) +
                    CInt(gambar.GetPixel(j - 1, i + 1).R) + CInt(gambar.GetPixel(j, i + 1).R) +
                    CInt(gambar.GetPixel(j + 1, i + 1).R)) / 9

                green = CInt(CInt(gambar.GetPixel(j - 1, i - 1).G) + CInt(gambar.GetPixel(j, i - 1).G) +
                    CInt(gambar.GetPixel(j + 1, i - 1).G) + CInt(gambar.GetPixel(j - 1, i).G) +
                    CInt(gambar.GetPixel(j, i).G) + CInt(gambar.GetPixel(j + 1, i).G) +
                    CInt(gambar.GetPixel(j - 1, i + 1).G) + CInt(gambar.GetPixel(j, i + 1).G) +
                    CInt(gambar.GetPixel(j, i).G)) / 9
                blue = CInt(CInt(gambar.GetPixel(j - 1, i - 1).B) + CInt(gambar.GetPixel(j, i).B) +
                                    CInt(gambar.GetPixel(j + 1, i - 1).B) + CInt(gambar.GetPixel(j - 1, i).B) +
                                    CInt(gambar.GetPixel(j, i).B) + CInt(gambar.GetPixel(j + 1, i).B) +
                                    CInt(gambar.GetPixel(j - 1, i + 1).B) + CInt(gambar.GetPixel(j, i + 1).B) +
                                    CInt(gambar.GetPixel(j, i).B)) / 9

                If red > 255 Then red = 255
                If red < 0 Then red = 0

                If green > 255 Then green = 255
                If green < 0 Then green = 0

                If blue > 255 Then blue = 255
                If blue < 0 Then blue = 0

                gambar.SetPixel(j, i, Color.FromArgb(red, green, blue))
            Next
            ToolStripProgressBar1.Increment(1)
        Next

        Picture2.Image = gambar
        Picture2.Refresh()

        ToolStripStatusLabel1.Text = "Ready..."
        Refresh()
    End Sub

    Private Sub cmdSharpen_Click(sender As Object, e As EventArgs) Handles cmdSharpen.Click
        ToolStripStatusLabel1.Text = "Please wait..."
        Refresh()

        Dim i As Integer, j As Integer
        Dim Dx As Integer = 1
        Dim Dy As Integer = 1
        Dim red As Integer, green As Integer, blue As Integer

        Picture2.Image = Picture1.Image
        Picture1.Refresh()

        Dim gambar As New Bitmap(Picture2.Image)
        baris = gambar.Height
        kolom = gambar.Width
        For i = 1 To baris - 2
            For j = 1 To kolom - 2
                red = CInt((gambar.GetPixel(j, i).R) + CInt((gambar.GetPixel(j, i).R) - CInt(gambar.GetPixel((j - Dx), (i - Dy)).R)))
                green = CInt((gambar.GetPixel(j, i).G) + CInt((gambar.GetPixel(j, i).G) - CInt(gambar.GetPixel((j - Dx), (i - Dy)).G)))
                blue = CInt((gambar.GetPixel(j, i).B) + CInt((gambar.GetPixel(j, i).B) - CInt(gambar.GetPixel((j - Dx), (i - Dy)).B)))

                If red > 255 Then red = 255
                If red < 0 Then red = 0

                If green > 255 Then green = 255
                If green < 0 Then green = 0

                If blue > 255 Then blue = 255
                If blue < 0 Then blue = 0

                gambar.SetPixel(j, i, Color.FromArgb(red, green, blue))
            Next
            ToolStripProgressBar1.Increment(1)
        Next

        Picture2.Image = gambar
        Picture2.Refresh()

        ToolStripStatusLabel1.Text = "Ready..."
        Refresh()
    End Sub

    Private Sub cmdSavePicture_Click(sender As Object, e As EventArgs) Handles cmdSavePicture.Click
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName <> "" Then
            Picture2.Image.Save(SaveFileDialog1.FileName + ".jpg")
        End If
    End Sub
End Class