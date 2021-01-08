Public Class Form4
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Form4_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Form2.Cb1.Text = "Список файлов" Then
            Try
                Dim dat As String = IO.Path.GetExtension(Form1.ListBox1.SelectedItem)
                If dat = ".txt" Then
                    Button2.Visible = False
                    TextBox1.Visible = True
                    ListBox1.Visible = False
                    TextBox1.Text = My.Computer.FileSystem.ReadAllText(Form1.ListBox1.SelectedItem)
                Else
                    MsgBox("Файл не текстовый!", , "Ошибка Просмотреть содержимое")
                End If
            Catch ex As Exception
                MsgBox("Данный файл защищён от просмотра!", , "Ошибка Просмотреть содержимое")
            End Try
        End If
        If Form2.Cb1.Text = "Список папок" Then
            Try
                ListBox1.Items.Clear()
                TextBox1.Visible = False
                ListBox1.Visible = True
                Button2.Visible = True
                Dim direct() As String
                Dim direct1() As String
                Dim select1 As String
                select1 = Form1.ListBox1.SelectedItem
                direct = IO.Directory.GetDirectories(select1)
                direct1 = IO.Directory.GetFiles(select1)
                ListBox1.Items.AddRange(direct)
                ListBox1.Items.Add("------------------------------------------------------------------------Файлы---------------------------------------------------------------------------------------")
                ListBox1.Items.AddRange(direct1)
            Catch ex As Exception
                MsgBox("Данная папка защищена от просмотра!", , "Ошибка Просмотреть содержимое")
                Me.Close()
            End Try
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.ListBox1.SelectedItem <> "------------------------------------------------------------------------Файлы---------------------------------------------------------------------------------------" Then
            Dim select2 As String = Me.ListBox1.SelectedItem
            Try
                ListBox1.Items.AddRange(IO.Directory.GetDirectories(select2))
                ListBox1.Items.Clear()
                ListBox1.Items.AddRange(IO.Directory.GetDirectories(select2))
                ListBox1.Items.Add("------------------------------------------------------------------------Файлы---------------------------------------------------------------------------------------")
                ListBox1.Items.AddRange(IO.Directory.GetFiles(select2))
            Catch ex As Exception
                Try
                    Dim dat As String = IO.Path.GetExtension(select2)
                    If dat = ".txt" Then
                        Button2.Visible = False
                        TextBox1.Visible = True
                        ListBox1.Visible = False
                        TextBox1.Text = IO.File.ReadAllText(select2)
                    Else
                        MsgBox("Файл не текстовый!", , "Ошибка Просмотреть содержимое")
                    End If
                Catch ex1 As Exception
                    MsgBox("Папка (файл) защищен(а) от просмотра!", , "Ошибка Просмотреть содержимое")
                End Try
            End Try
        End If
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class