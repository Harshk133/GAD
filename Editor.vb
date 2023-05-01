Public Class Editor
    Private Sub FastColoredTextBox1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub FastColoredTextBox1_Load_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs)
        'WebBrowser1.DocumentText = FastColoredTextBox1.Text
        If FastColoredTextBox1.Visible = True Then
            FastColoredTextBox1.Visible = False
            WebBrowser1.DocumentText = FastColoredTextBox1.Text
            WebBrowser1.Visible = True
        Else
            FastColoredTextBox1.Visible = True
            WebBrowser1.Visible = False
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)
        FastColoredTextBox1.Copy()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs)
        FastColoredTextBox1.Paste()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)
        FastColoredTextBox1.Undo()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs)
        FastColoredTextBox1.Redo()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        FastColoredTextBox1.Clear()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub FastColoredTextBox1_Load_2(sender As Object, e As EventArgs) Handles FastColoredTextBox1.Load

    End Sub

    Private Sub PictureBox11_Click_1(sender As Object, e As EventArgs) Handles PictureBox11.Click
        FastColoredTextBox1.Paste()
    End Sub

    Private Sub PictureBox10_Click_1(sender As Object, e As EventArgs) Handles PictureBox10.Click
        FastColoredTextBox1.Copy()
    End Sub

    Private Sub PictureBox9_Click_1(sender As Object, e As EventArgs) Handles PictureBox9.Click
        FastColoredTextBox1.Undo()
    End Sub

    Private Sub PictureBox8_Click_1(sender As Object, e As EventArgs) Handles PictureBox8.Click
        FastColoredTextBox1.Redo()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FastColoredTextBox1.Clear()
    End Sub

    Private Sub PictureBox12_Click_1(sender As Object, e As EventArgs) Handles PictureBox12.Click
        If FastColoredTextBox1.Visible = True Then
            FastColoredTextBox1.Visible = False
            WebBrowser1.DocumentText = FastColoredTextBox1.Text
            WebBrowser1.Visible = True
        Else
            FastColoredTextBox1.Visible = True
            WebBrowser1.Visible = False
        End If
    End Sub
End Class
