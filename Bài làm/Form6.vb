Imports System
Imports System.IO
Imports System.Text

Public Class Form6
    Dim anh, viet, chude As System.IO.StreamWriter
    Dim a, b As Integer
    Dim english, vietnamese, edit As System.IO.StreamWriter

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim m, n, tam, x, y As String

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        '   If chontudexoa.SelectedIndex = Nothing Then
        '    MsgBox("Bạn chưa chọn từ để xóa!")
        ' Else
        Dim newList As List(Of String) = hienthitu.Lines.ToList
        newList.RemoveAt(chontudexoa.SelectedIndex)
        hienthitu.Lines = newList.ToArray
        xoadong(m, chontudexoa.SelectedIndex)
        xoadong(n, chontudexoa.SelectedIndex)
    End Sub
    Private Sub themchude_Click(sender As Object, e As EventArgs) Handles themchude.Click
        chonchude.Enabled = False
        suachude.Enabled = False
        add.Enabled = True
        tienganh.Enabled = True
        tiengviet.Enabled = True
        delete.Enabled = True
        chontudexoa.Enabled = True
        chonanh.Enabled = True
        Dim St() As String = IO.File.ReadAllLines(Path & "text\currenttext.txt")
        Dim chude = New System.IO.StreamWriter(Application.StartupPath & "\text\currenttext.txt")
        Dim fs As FileStream
        Dim duongdan As String
        a = CInt(St(0)) + 1
        b = CInt(St(1)) + 1
        If tenchude.Text = Nothing Then
            MsgBox("Bạn chưa nhập tên chủ đề!")
        Else
            Select Case dvtv.SelectedIndex
              '  Case Nothing
              '      MsgBox("Bạn chưa chọn giới động vật hoặc thực vật để thêm chủ đề vào!")
                Case 0
                    edit = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\text\stchudedv.txt", True)
                    edit.WriteLine(tenchude.Text)
                    edit.Close()
                    m = Path & "text\Động vật\a" & a & ".1.txt"
                    n = Path & "text\Động vật\a" & a & ".2.txt"
                    chude.WriteLine(a, False)
                    chude.WriteLine(St(1))
                    chude.Close()
                Case 1
                    edit = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\text\stchudetv.txt", True)
                    edit.WriteLine(tenchude.Text)
                    edit.Close()
                    m = Path & "text\Thực vật\b" & b & ".1.txt"
                    n = Path & "text\Thực vật\b" & b & ".2.txt"
                    chude.WriteLine(St(0), False)
                    chude.WriteLine(b)
                    chude.Close()
            End Select
        End If
    End Sub
    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        english = My.Computer.FileSystem.OpenTextFileWriter(m, True)
        vietnamese = My.Computer.FileSystem.OpenTextFileWriter(n, True)
        If tienganh.Text = Nothing Or tiengviet.Text = Nothing Then
                    MsgBox("Bạn chưa nhập nghĩa tiếng anh hoặc tiếng việt của từ!")
                Else english.WriteLine(tienganh.Text)
                    vietnamese.WriteLine(tiengviet.Text)
            hienthitu.Text &= tienganh.Text & ": " & Space(50 - tienganh.Text.Length * 2) & tiengviet.Text & vbCrLf
        End If
        vietnamese.Close()
        english.Close()
        chontudexoa.Items.Add(tienganh.Text)
        tienganh.Text = Nothing
        tiengviet.Text = Nothing
    End Sub
    Private Sub chonanh_Click(sender As Object, e As EventArgs) Handles chonanh.Click
        OpenFileDialog1.Filter = "Bitmaps(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|All Files(*.*)|*.*"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            anhminhhoa.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
        End If
        If dvtv.SelectedIndex = 0 Then
            anhminhhoa.Image.Save("picture\Động vật\p" & a & ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
        Else anhminhhoa.Image.Save("picture\Thực vật\q" & b & ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        chonanh.Enabled = False
    End Sub
End Class