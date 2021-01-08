Public Class Form5
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Form5_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim dop As String
        Dim Length As Integer
        Dim dat1_l As Integer = 1
        Dim pb As Double
        Dim pb1 As Integer
        Dim name1 As String
        Dim name2 As String
        Dim dat As String
        Dim dat1(1) As String
        Dim test As String
        Dim ok As Boolean = False
        If Search_dialog.TextBox2.Text = "" Then
            dop = "*"
        Else
            dop = "*." & Search_dialog.TextBox2.Text
        End If
        Try
            Dim Files() As String = IO.Directory.GetFiles(Search_dialog.TextBox3.Text, dop, IO.SearchOption.AllDirectories)
            Length = Files.Length
            If Length = 0 Then
                MsgBox("В этом месте нет ни одного файла!")
                Me.Close()
            End If
            pb = Files.Length / 50
            pb = Math.Floor(pb)
            dat = Search_dialog.TextBox1.Text
            ProgressBar1.Value = 43
            For a1 = 0 To Files.Length - 1 Step 1
                If a1 > Files.Length - 1 Then
                    Exit For
                End If
                name1 = FileIO.FileSystem.GetName(Files(a1))
                If dop = "*" Then
                    name2 = FileIO.FileSystem.GetFileInfo(Files(a1)).Extension
                    test = dat & name2
                    pb1 = Math.IEEERemainder(a1, pb)
                    If pb1 = 0 Then
                        ProgressBar1.Value = ProgressBar1.Value + 1
                    End If
                    If test = name1 Then
                        ok = True
                        Array.Resize(dat1, dat1.Length + 1)
                        dat1(dat1_l) = Files(a1)
                        dat1_l += 1
                    End If
                Else
                    If pb1 = 0 Then
                        ProgressBar1.Value = ProgressBar1.Value + 1
                    End If
                    If dat = name1 Then
                        ok = True
                        Array.Resize(dat1, dat1.Length + 1)
                        dat1(dat1_l) = Files(a1)
                        dat1_l += 1
                    End If
                End If
            Next
            If ok = True Then
                Form1.ListBox1.Items.Clear()
                For a1 = 1 To dat1_l - 1 Step 1
                    Form1.ListBox1.Items.Add(dat1(a1))
                Next
                ProgressBar1.Value = 100
                Me.Close()
            Else
                ProgressBar1.Value = 100
                MsgBox("Ничего не найдено. Попробуйте повторить поиск в другом месте." & Chr(10) & "----Отчёт----" & Chr(10) & " В указанной папке файлов: " & Files.Length & Chr(10) & "Найдено файлов: " & dat1_l - 1 & Chr(10) & Chr(10) & "Дополнительно:" & Chr(10) & "Имя искомого файла: " & dat & Chr(10) & "Расширение искомого файла: " & dop)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Во время поиска произошла ошибка! Возможно, файл или папка на пути поиска были защищены от просмотра.", , "Ошибка Поиск")
            Me.Close()
        End Try
    End Sub
End Class