Public Class Form2
    Dim res As DialogResult
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        res = FBD1.ShowDialog()
        If res = 1 Then
            TextBox1.Text = FBD1.SelectedPath
        Else
            TextBox1.Text = "C:\"
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class