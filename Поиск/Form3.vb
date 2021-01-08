Public Class progress
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub progress_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim fd As Integer
        Dim way As String
        Dim direct() As String
        Form1.ListBox1.Items.Clear()
        fd = Form2.Cb1.SelectedIndex
        way = Form2.TextBox1.Text
        If fd = 0 Then
            direct = IO.Directory.GetFiles(way)
            Form1.ListBox1.Items.AddRange(direct)
            Me.Close()
        Else
            direct = IO.Directory.GetDirectories(way)
            Form1.ListBox1.Items.AddRange(direct)
            Me.Close()
        End If
    End Sub
End Class