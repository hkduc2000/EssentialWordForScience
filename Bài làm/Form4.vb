Public Class Form4
    Dim Sttest1() As String = IO.File.ReadAllLines(Path & "text\" & textktdientu1)
    Dim Sttest2() As String = IO.File.ReadAllLines(Path & "text\" & textktdientu2)
    Dim socauhoi, m, n, tam As Integer
    Dim dapan, help As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        help = "Gợi ý: "
        traloi.Text = Nothing
        m = 0
        Randomize()
        socauhoi = Int(Sttest2.GetUpperBound(0) * Rnd())
        cauhoi.Text = "What does it mean in English?" & vbCrLf & Sttest2(socauhoi)
        For i = 1 To Sttest1(socauhoi).Length
            help &= "_ "
        Next
        trogiup.Text = help
        traloi.Enabled = True
        btntrogiup.Enabled = True
        btntraloi.Enabled = True
        PictureBox1.Image = Image.FromFile(Path & "picture\thầy giáo\question.jpg")
        sochucai.Text = "Có tất cả: " & Sttest1(socauhoi).Length & " kí tự (tính cả dấu cách)"
        Timer1.Enabled = False
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        playaudio(Path & "sound\thaychao" & Int(1 * Rnd()) & ".wav")
        PictureBox1.Image = Image.FromFile(Path & "picture\thầy giáo\welcome.jpg")
        Timer1.Enabled = True
        ' Randomize()
        'socauhoi = Int(Sttest2.GetUpperBound(0) * Rnd())
        ' cauhoi.Text = "What does it mean in English?" & vbCrLf & Sttest2(socauhoi)
        ' help = "Gợi ý: "
        'For i = 1 To Sttest1(socauhoi).Length
        'help &= "_ "
        ' Next
        'trogiup.Text = help
        ' PictureBox1.Image = Image.FromFile(Path & "picture\thầy giáo\question.jpg")
        ' sochucai.Text = "Có tất cả: " & Sttest1(socauhoi).Length & " kí tự (tính cả dấu cách)"
    End Sub
    Private Sub btntrogiup_Click(sender As Object, e As EventArgs) Handles btntrogiup.Click
        If m < Sttest1(socauhoi).Length - 1 Then
            help = Replace(help, "_", Sttest1(socauhoi)(m), 1, 1, 1)
            trogiup.Text = help
        Else btntrogiup.Enabled = False
            traloi.Enabled = False
            btntraloi.Enabled = False
            help = Replace(help, "_", Sttest1(socauhoi)(m), 1, 1, 1)
            trogiup.Text = help
            Randomize()
            tam = Int(9 * Rnd())
            PictureBox1.Image = Image.FromFile(Path & "picture\thầy giáo\false" & tam & ".jpg")
            playaudio(Path & "picture\thầy giáo\false" & tam & ".wav")
            Timer1.Enabled = True
        End If
        m = m + 1
    End Sub

    Private Sub btntraloi_Click(sender As Object, e As EventArgs) Handles btntraloi.Click
        dapan = traloi.Text
        dapan = LTrim(dapan)
        dapan = RTrim(dapan)
        If dapan = Sttest1(socauhoi) Or S1(dapan) = Sttest1(socauhoi) Then
            Randomize()
            tam = Int(8 * Rnd())
            PictureBox1.Image = Image.FromFile(Path & "picture\thầy giáo\true" & tam & ".jpg")
            playaudio(Path & "picture\thầy giáo\true" & tam & ".wav")
        Else
            Randomize()
            tam = Int(9 * Rnd())
            PictureBox1.Image = Image.FromFile(Path & "picture\thầy giáo\false" & tam & ".jpg")
            playaudio(Path & "picture\thầy giáo\false" & tam & ".wav")
        End If
        traloi.Enabled = False
        For i = m To Sttest1(socauhoi).Length - 1
            help = Replace(help, "_", Sttest1(socauhoi)(i), 1, 1)
        Next
        trogiup.Text = help
        Timer1.Enabled = True
    End Sub
End Class