Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PercabanganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PercabanganToolStripMenuItem.Click

    End Sub

    Private Sub DiriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiriToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OrangTuaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangTuaToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub
End Class
