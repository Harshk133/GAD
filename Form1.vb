Public Class Form1
    Private Sub load_editor()
        Dim Editor As New Editor
        With Editor
            .Dock = DockStyle.Fill
        End With
        Dim t As New TabPage
        With t
            .Text = "New Document"
            .Name = "New Editor"
        End With
        t.Controls.Add(Editor)
        Me.TabControl1.Controls.Add(t)

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_editor()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
