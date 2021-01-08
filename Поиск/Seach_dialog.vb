Public Class Search_dialog
    Dim res As DialogResult
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        res = FolderBrowserDialog1.ShowDialog()
        If res = 1 Then
            TextBox3.Text = FolderBrowserDialog1.SelectedPath
        Else
            TextBox3.Text = "C:\"
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("ВНИМАНИЕ!" & Chr(10) & "Расширение следует указывать БЕЗ знаков '.' и '*' (точек, звёздочек и т.п.)" & Chr(10) & "Пример:" & Chr(10) & "txt", , "Справка")
    End Sub
End Class