Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub MainTextBox_TextChanged(sender As Object, e As EventArgs) Handles MainTextBox.TextChanged
        ResultTextBox.Text = MainTextBox.Text.ToString().Replace(" ", "🤸")
    End Sub

    Private Sub CopyBtn_MouseEnter(sender As Object, e As EventArgs) Handles CopyBtn.MouseEnter
        CopyBtn.Image = My.Resources.CopyButtonHover
    End Sub

    Private Sub CopyBtn_MouseLeave(sender As Object, e As EventArgs) Handles CopyBtn.MouseLeave
        CopyBtn.Image = My.Resources.CopyButtonNHover
    End Sub

    Private Sub CopyBtn_Click(sender As Object, e As EventArgs) Handles CopyBtn.Click
        If Not String.IsNullOrEmpty(ResultTextBox.Text) Then
            Clipboard.SetText(ResultTextBox.Text)

            MessageBox.Show("Copied Successfully!", "Copied to Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
