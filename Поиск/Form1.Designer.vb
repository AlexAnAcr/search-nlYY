<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ПоискToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НайтиОбъектToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СписокФайловToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СписокПапокToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НайтиФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПросмотретьСодержимоеФайлаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КопироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОчиститьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ПоискToolStripMenuItem, Me.ОчиститьToolStripMenuItem, Me.СправкаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(604, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "Меню"
        '
        'ПоискToolStripMenuItem
        '
        Me.ПоискToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.НайтиОбъектToolStripMenuItem, Me.НайтиФайлToolStripMenuItem, Me.ПросмотретьСодержимоеФайлаToolStripMenuItem, Me.КопироватьToolStripMenuItem})
        Me.ПоискToolStripMenuItem.Name = "ПоискToolStripMenuItem"
        Me.ПоискToolStripMenuItem.Size = New System.Drawing.Size(50, 21)
        Me.ПоискToolStripMenuItem.Text = "Файл"
        '
        'НайтиОбъектToolStripMenuItem
        '
        Me.НайтиОбъектToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СписокФайловToolStripMenuItem, Me.СписокПапокToolStripMenuItem})
        Me.НайтиОбъектToolStripMenuItem.Name = "НайтиОбъектToolStripMenuItem"
        Me.НайтиОбъектToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.НайтиОбъектToolStripMenuItem.Text = "Список"
        '
        'СписокФайловToolStripMenuItem
        '
        Me.СписокФайловToolStripMenuItem.Name = "СписокФайловToolStripMenuItem"
        Me.СписокФайловToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.СписокФайловToolStripMenuItem.Text = "Список файлов"
        '
        'СписокПапокToolStripMenuItem
        '
        Me.СписокПапокToolStripMenuItem.Name = "СписокПапокToolStripMenuItem"
        Me.СписокПапокToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.СписокПапокToolStripMenuItem.Text = "Список папок"
        '
        'НайтиФайлToolStripMenuItem
        '
        Me.НайтиФайлToolStripMenuItem.Name = "НайтиФайлToolStripMenuItem"
        Me.НайтиФайлToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.НайтиФайлToolStripMenuItem.Text = "Найти файл"
        '
        'ПросмотретьСодержимоеФайлаToolStripMenuItem
        '
        Me.ПросмотретьСодержимоеФайлаToolStripMenuItem.Name = "ПросмотретьСодержимоеФайлаToolStripMenuItem"
        Me.ПросмотретьСодержимоеФайлаToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.ПросмотретьСодержимоеФайлаToolStripMenuItem.Text = "Просмотреть содержимое"
        '
        'КопироватьToolStripMenuItem
        '
        Me.КопироватьToolStripMenuItem.Name = "КопироватьToolStripMenuItem"
        Me.КопироватьToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.КопироватьToolStripMenuItem.Text = "Копировать путь"
        '
        'ОчиститьToolStripMenuItem
        '
        Me.ОчиститьToolStripMenuItem.Name = "ОчиститьToolStripMenuItem"
        Me.ОчиститьToolStripMenuItem.Size = New System.Drawing.Size(74, 21)
        Me.ОчиститьToolStripMenuItem.Text = "Очистить"
        '
        'СправкаToolStripMenuItem
        '
        Me.СправкаToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СправкаToolStripMenuItem1, Me.ОПрограммеToolStripMenuItem})
        Me.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        Me.СправкаToolStripMenuItem.Size = New System.Drawing.Size(70, 21)
        Me.СправкаToolStripMenuItem.Text = "Справка"
        '
        'СправкаToolStripMenuItem1
        '
        Me.СправкаToolStripMenuItem1.Name = "СправкаToolStripMenuItem1"
        Me.СправкаToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.СправкаToolStripMenuItem1.Text = "Справка"
        '
        'ОПрограммеToolStripMenuItem
        '
        Me.ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        Me.ОПрограммеToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ОПрограммеToolStripMenuItem.Text = "О программе"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(0, 27)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(604, 352)
        Me.ListBox1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(604, 382)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(220, 85)
        Me.Name = "Form1"
        Me.Text = "Поиск"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ПоискToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents НайтиОбъектToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents НайтиФайлToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОчиститьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СписокФайловToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СписокПапокToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПросмотретьСодержимоеФайлаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents КопироватьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
