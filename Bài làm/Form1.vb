Public Class form1
    Dim d As String
    Dim stchudedv() As String = IO.File.ReadAllLines(Path & "text\stchudedv.txt")
    Dim stchudetv() As String = IO.File.ReadAllLines(Path & "text\stchudetv.txt")
    Sub chonchude(a As Integer)
        d = ListBox1.Items(a)
        Try
            anhminhhoa.Image = Image.FromFile(Path & "picture\anhminhhoa\" & ListBox1.Items(a) & ".jpg")
        Catch
            anhminhhoa.Image = Image.FromFile(Path & "picture\background\backanhminhhoa.jpg")
        End Try
    End Sub
    Sub bieudientudv(ByVal m As Integer)
        Try
            anhminhhoa.Image = Image.FromFile(Path & "picture\Động vật\" & "p" & m & ".jpg")
        Catch
        End Try
        Dim St1() As String = IO.File.ReadAllLines(Path & "text\Động vật\" & "a" & m & ".1.txt")
        Dim St2() As String = IO.File.ReadAllLines(Path & "text\Động vật\" & "a" & m & ".2.txt")
        For i = 0 To St1.GetUpperBound(0)
            tienganh.Text += St1(i) & " :" & Space(60 - St1(i).Length * 2) & St2(i) & vbCrLf
        Next
        textkttracnghiem1 = "Động vật\a" & m & ".1.txt"
        textkttracnghiem2 = "Động vật\a" & m & ".2.txt"
        textktdientu1 = "Động vật\a" & m & ".1.txt"
        textktdientu2 = "Động vật\a" & m & ".2.txt"
        textchono1 = "Động vật\a" & m & ".1.txt"
        textchono2 = "Động vật\a" & m & ".2.txt"
    End Sub
    Sub bieudientutv(ByVal m As Integer)
        Try
            anhminhhoa.Image = Image.FromFile(Path & "picture\Thực vật\" & "q" & m & ".jpg")
        Catch
        End Try
        Dim St1() As String = IO.File.ReadAllLines(Path & "text\Thực vật\" & "b" & m & ".1.txt")
        Dim St2() As String = IO.File.ReadAllLines(Path & "text\Thực vật\" & "b" & m & ".2.txt")
        For i = 0 To St1.GetUpperBound(0)
            tienganh.Text += St1(i) & " :" & Space(60 - St1(i).Length * 2) & St2(i) & vbCrLf
        Next
        textkttracnghiem1 = "Thực vật\b" & m & ".1.txt"
        textkttracnghiem2 = "Thực vật\b" & m & ".2.txt"
        textktdientu1 = "Thực vật\b" & m & ".1.txt"

        textktdientu2 = "Thực vật\b" & m & ".2.txt"
        textchono1 = "Thực vật\b" & m & ".1.txt"
        textchono2 = "Thực vật\b" & m & ".2.txt"
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles start.Click
        huongdansudung.Visible = False
        logo.Visible = False
        labelhuongdan.Visible = False
        start.Visible = False
        hoctu.Visible = True
        ontap.Visible = True
        BackgroundImage = Image.FromFile(Path & "picture\background\home3.jpg")
        home.Visible = True
    End Sub
    Private Sub hoctu_Click(sender As Object, e As EventArgs) Handles hoctu.Click
        dongvat.Visible = True
        thucvat.Visible = True
        hoctu.Visible = False
        ontap.Visible = False
        BackgroundImage = Image.FromFile(Path & "picture\background\home.jpg")
        thay.Visible = False
        co.Visible = False
        'thayco.Visible = False

    End Sub

    Private Sub dongvat_Click(sender As Object, e As EventArgs) Handles dongvat.Click
        For i = 0 To stchudedv.GetUpperBound(0)
            ListBox1.Items.Add(stchudedv(i))
        Next
        batdau.Visible = True
        ListBox1.Visible = True
        anhminhhoa.Visible = True
        'anhminhhoachude.Visible = True
        dongvat.Visible = False
        thucvat.Visible = False
        chon.Visible = True
        search.Visible = True
        btnsearch.Visible = True
        BackgroundImage = Image.FromFile(Path & "picture\background\home4.jpg")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        chonchude(ListBox1.SelectedIndex)
    End Sub

    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click
        home.Visible = False
        anhminhhoa.Visible = False
        batdau.Visible = False
        btnsearch.Visible = False
        close.Visible = False
        chon.Visible = False
        dongvat.Visible = False
        thucvat.Visible = False
        hoctu.Visible = False
        huongdansudung.Visible = True
        ketquatim.Visible = False
        kiemtra1.Visible = False
        kiemtra2.Visible = False
        kiemtra3.Visible = False
        labelhuongdan.Visible = True
        ListBox1.Visible = False
        logo.Visible = True
        ontap.Visible = False
        search.Visible = False
        start.Visible = True
        tienganh.Visible = False
        tienganh.Text = Nothing
        thucvat.Visible = False
        thay.Visible = False
        co.Visible = False
        ban.Visible = False

        ontap.Top = 165
        ontap.Left = 234
        'thayco.Visible = False
        ListBox1.Items.Clear()
        search.Text = ""
        ketquatim.Items.Clear()
        anhminhhoa.Top = 36
        anhminhhoa.Left = 400
        anhminhhoa.Height = 346
        anhminhhoa.Width = 386
        anhminhhoa.Image = Image.FromFile(Path & "picture\background\backanhminhhoa.jpg")
        BackgroundImage = Image.FromFile(Path & "picture\background\home.jpg")
    End Sub

    Private Sub batdau_Click(sender As Object, e As EventArgs) Handles batdau.Click
        If d = "" Then
            MsgBox("Bạn chưa chọn chủ để để học")
        Else
            BackgroundImage = Image.FromFile(Path & "picture\background\home2.jpg")
            batdau.Visible = False
            chon.Visible = False
            ListBox1.Visible = False
            'anhminhhoachude.Visible = False
            anhminhhoa.Visible = True
            tienganh.Visible = True
            'tiengviet.Visible = True
            kiemtra1.Visible = True
            kiemtra2.Visible = True
            kiemtra3.Visible = True
            anhminhhoa.Height = 310
            anhminhhoa.Width = 342
            anhminhhoa.Top = 51
            anhminhhoa.Left = 8
            search.Visible = False
            ketquatim.Visible = False
            btnsearch.Visible = False
            close.Visible = False
            For i = 0 To stchudedv.GetUpperBound(0)
                If d = stchudedv(i) Then
                    bieudientudv(i)
                End If
            Next
            For i = 0 To stchudetv.GetUpperBound(0)
                If d = stchudetv(i) Then
                    bieudientutv(i)
                End If
            Next
        End If
    End Sub

    Private Sub kiemtra_Click(sender As Object, e As EventArgs) Handles kiemtra1.Click
        Dim a As New Form3()
        a.ShowDialog()
    End Sub

    Private Sub kiemtra2_Click(sender As Object, e As EventArgs) Handles kiemtra2.Click
        Dim a As New Form4()
        a.ShowDialog()
    End Sub

    Private Sub search_MouseDown(sender As Object, e As MouseEventArgs) Handles search.MouseDown
        ketquatim.Visible = True
        close.Visible = True
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        Dim x As Integer
        Dim pos As Integer

        ketquatim.Items.Clear()
        For i = 0 To ListBox1.Items.Count - 1
            pos = 0
            pos = InStr(1, xoadau(ListBox1.Items(i)), xoadau(search.Text), 1)
            ' If Microsoft.VisualBasic.Left(ListBox1.Items(i), search.Text.Length) = search.Text Then
            If pos <> 0 Then
                ketquatim.Items.Add(ListBox1.Items(i))
            End If
            ' End If
        Next

    End Sub

    Private Sub ketquatim_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ketquatim.SelectedIndexChanged
        d = ketquatim.Items(ketquatim.SelectedIndex)
        Try
            anhminhhoa.Image = Image.FromFile(Path & "picture\anhminhhoa\" & ketquatim.Items(ketquatim.SelectedIndex) & ".jpg")
        Catch
            anhminhhoa.Image = Image.FromFile(Path & "picture\background\backanhminhhoa.jpg")
        End Try
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        ketquatim.Visible = False
        close.Visible = False
        search.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim pos As Integer
        BackgroundImage = Image.FromFile(Path & "picture\background\home.jpg")
        playaudio(Path & "sound/sound0.wav")
    End Sub

    Private Sub ontap_Click(sender As Object, e As EventArgs) Handles ontap.Click
        BackgroundImage = Image.FromFile(Path & "picture\background\home3.1.jpg")
        thay.Visible = True
        co.Visible = True
        ban.Visible = True
        'thayco.Visible = True
        hoctu.Visible = False
        ontap.Top = 26
        ontap.Left = 236
    End Sub
    Private Sub thay_Click(sender As Object, e As EventArgs) Handles thay.Click
        textktdientu1 = "texttong1.txt"
        textktdientu2 = "texttong2.txt"
        Dim a As New Form4()
        a.ShowDialog()
    End Sub

    Private Sub co_Click(sender As Object, e As EventArgs) Handles co.Click
        textkttracnghiem1 = "texttong1.txt"
        textkttracnghiem2 = "texttong2.txt"
        Dim a As New Form3()
        a.ShowDialog()
    End Sub
    Private Sub thucvat_Click(sender As Object, e As EventArgs) Handles thucvat.Click
        For i = 0 To stchudetv.GetUpperBound(0)
            ListBox1.Items.Add(stchudetv(i))
        Next
        batdau.Visible = True
        ListBox1.Visible = True
        anhminhhoa.Visible = True
        'anhminhhoachude.Visible = True
        dongvat.Visible = False
        thucvat.Visible = False
        chon.Visible = True
        search.Visible = True
        btnsearch.Visible = True
        BackgroundImage = Image.FromFile(Path & "picture\background\home4.jpg")
    End Sub
    Private Sub ban_Click(sender As Object, e As EventArgs) Handles ban.Click
        textchono1 = "texttong1.txt"
        textchono2 = "texttong2.txt"
        Dim a As New form7()
        a.ShowDialog()

    End Sub

    Private Sub kiemtra3_Click(sender As Object, e As EventArgs) Handles kiemtra3.Click
        Dim a As New form7()
        a.ShowDialog()
    End Sub
End Class