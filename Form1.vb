Public Class Form1
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub QuiterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuiterToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ExàToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExàToolStripMenuItem.Click

    End Sub

    Private Sub FfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FfToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub EX04TotripMenuItem_Click(sender As Object, e As EventArgs) Handles EX04ToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub EX05ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EX05ToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub EX06ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EX06ToolStripMenuItem.Click
        Form7.Show()
    End Sub

    Private Sub EX07ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EX07ToolStripMenuItem.Click
        Form8.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
