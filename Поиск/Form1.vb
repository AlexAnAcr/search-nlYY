Public Class Form1
    Dim result As DialogResult
    Private Sub СписокФайловToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СписокФайловToolStripMenuItem.Click
        Form2.Cb1.Text = "Список файлов"
        Form2.Left = Me.Left + 40
        Form2.Top = Me.Top + 40
        result = Form2.ShowDialog()
        If result = DialogResult.OK Then
            progress.Left = Me.Left + 100
            progress.Top = Me.Top + 100
            progress.ShowDialog()
        End If
    End Sub
    Private Sub СписокПапокToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СписокПапокToolStripMenuItem.Click
        Form2.Cb1.Text = "Список папок"
        Form2.Left = Me.Left + 20
        Form2.Top = Me.Top + 20
        result = Form2.ShowDialog()
        If result = DialogResult.OK Then
            progress.Left = Me.Left + 100
            progress.Top = Me.Top + 100
            progress.ShowDialog()
        End If
    End Sub
    Private Sub ПросмотретьСодержимоеФайлаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПросмотретьСодержимоеФайлаToolStripMenuItem.Click
        Form4.Left = Me.Left + 20
        Form4.Top = Me.Top + 20
        Form4.ShowDialog()
    End Sub
    Private Sub ОчиститьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОчиститьToolStripMenuItem.Click
        If Me.ListBox1.Items.Count > 0 Then
            Dim res As MsgBoxResult
            res = MsgBox("После очистки все результаты поиска сотруться!", MsgBoxStyle.OkCancel, "Очистка")
            If res = MsgBoxResult.Ok Then
                Me.ListBox1.Items.Clear()
            End If
        End If
    End Sub
    Private Sub НайтиФайлToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles НайтиФайлToolStripMenuItem.Click
        Search_dialog.Left = Me.Left + 20
        Search_dialog.Top = Me.Top + 20
        result = Search_dialog.ShowDialog()
        If result = DialogResult.OK And Search_dialog.TextBox1.Text <> "" Then
            Form5.Left = Me.Left + 100
            Form5.Top = Me.Top + 100
            Form5.ShowDialog()
        End If
    End Sub
    Private Sub КопироватьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles КопироватьToolStripMenuItem.Click
        If ListBox1.SelectedIndex > -1 Then
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(Me.ListBox1.SelectedItem)
        End If
    End Sub
    Private Sub СправкаToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СправкаToolStripMenuItem1.Click
        Form6.Show()
        Form6.Left = Me.Left + 50
        Form6.Top = Me.Top + 50
    End Sub
End Class
