Public Class Form3
    Dim cauhoi, dapandung As String
    Dim socauhoi As Integer
    Dim tam As Integer
    Sub tracnghiem(ByVal duongdana As String, ByVal duongdanv As String)
        Dim dapan1, dapan2, dapan3, socauhoi As String
        Dim vitri1, vitri2, vitri3, vitri4 As Integer
        Dim Sttest1() As String = IO.File.ReadAllLines(Path & "text\" & duongdana)
        Dim Sttest2() As String = IO.File.ReadAllLines(Path & "text\" & duongdanv)
        Randomize()
        socauhoi = Int(Sttest2.GetUpperBound(0) * Rnd())
        cauhoi = Sttest1(socauhoi)
        dapandung = Sttest2(socauhoi)
        cauhoitracnghiem.Text = "What does it mean in Vietnamese:" & vbCrLf & cauhoi
        Do
            dapan1 = Sttest2(Int((Sttest2.GetUpperBound(0) + 1) * Rnd()))
        Loop Until dapan1 <> dapandung
        Do
            Randomize()
            dapan2 = Sttest2(Int((Sttest2.GetUpperBound(0) + 1) * Rnd()))
        Loop Until dapan2 <> dapan1 And dapan2 <> dapandung
        Do
            Randomize()
            dapan3 = Sttest2(Int((Sttest2.GetUpperBound(0) + 1) * Rnd()))
        Loop Until dapan3 <> dapan1 And dapan3 <> dapan2 And dapan3 <> dapandung

        'tìm vị trí cho đáp án
        Randomize()
        vitri1 = Int((4 * Rnd()) + 1)
        Do
            Randomize()
            vitri2 = Int((4 * Rnd()) + 1)
        Loop Until vitri2 <> vitri1
        Do
            Randomize()
            vitri3 = Int((4 * Rnd()) + 1)
        Loop Until vitri3 <> vitri1 And vitri3 <> vitri2
        Do
            Randomize()
            vitri4 = Int((4 * Rnd()) + 1)
        Loop Until vitri4 <> vitri3 And vitri4 <> vitri2 And vitri4 <> vitri1
        'vitri4 là vị trí đáp ánư
        Select Case vitri1
            Case 1
                A.Text = dapan1
            Case 2
                B.Text = dapan1
            Case 3
                C.Text = dapan1
            Case 4
                D.Text = dapan1
        End Select
        Select Case vitri2
            Case 1
                A.Text = dapan2
            Case 2
                B.Text = dapan2
            Case 3
                C.Text = dapan2
            Case 4
                D.Text = dapan2
        End Select
        Select Case vitri3
            Case 1
                A.Text = dapan3
            Case 2
                B.Text = dapan3
            Case 3
                C.Text = dapan3
            Case 4
                D.Text = dapan3
        End Select
        Select Case vitri4
            Case 1
                A.Text = Sttest2(socauhoi)
            Case 2
                B.Text = Sttest2(socauhoi)
            Case 3
                C.Text = Sttest2(socauhoi)
            Case 4
                D.Text = Sttest2(socauhoi)
        End Select
    End Sub
    Private Sub tieptuc_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim caua, caub, cauc, caud As String
        Randomize()
        playaudio(Path & "sound\cochao" & Int(1 * Rnd()) & ".wav")
        PictureBox1.Image = Image.FromFile(Path & "picture\Cô giáo\welcome.jpg")
        Timer1.Enabled = True
    End Sub

    Private Sub A_Click(sender As Object, e As EventArgs) Handles A.Click
        If A.Text = dapandung Then
            Randomize()
            tam = Int(5 * Rnd())
            PictureBox1.Image = Image.FromFile(Path & "picture\Cô giáo\true" & tam & ".jpg")
            playaudio(Path & "picture\Cô giáo\true" & tam & ".wav")
        Else Randomize()
            tam = Int(6 * Rnd())
            PictureBox1.Image = Image.FromFile(Path & "picture\Cô giáo\false" & tam & ".jpg")
            playaudio(Path & "picture\Cô giáo\false" & tam & ".wav")
        End If
        B.Enabled = False
        C.Enabled = False
        D.Enabled = False
        BeLazy()
        Timer1.Enabled = True
    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles B.Click
        If B.Text = dapandung Then
            Randomize()
            tam = Int(5 * Rnd())
            PictureBox1.Image = Image.FromFile(Path & "picture\Cô giáo\true" & tam & ".jpg")
            playaudio(Path & "picture\Cô giáo\true" & tam & ".wav")
        Else Randomize()
            tam = Int(6 * Rnd())
            PictureBox1.Image = Image.FromFile(Path & "picture\Cô giáo\false" & tam & ".jpg")
            playaudio(Path & "picture\Cô giáo\false" & tam & ".wav")
        End If
        A.Enabled = False
        C.Enabled = False
        D.Enabled = False
        BeLazy()
        Timer1.Enabled = True
    End Sub

    Private Sub C_Click(sender As Object, e As EventArgs) Handles C.Click
        If C.Text = dapandung Then
            Randomize()
            tam = Int(5 * Rnd())
            PictureBox1.Image = Image.FromFile(Path & "picture\Cô giáo\true" & tam & ".jpg")
            playaudio(Path & "picture\Cô giáo\true" & tam & ".wav")
        Else Randomize()
            tam = Int(6 * Rnd())
            PictureBox1.Image = Image.FromFile(Path & "picture\Cô giáo\false" & tam & ".jpg")
            playaudio(Path & "picture\Cô giáo\false" & tam & ".wav")
        End If
        B.Enabled = False
        A.Enabled = False
        D.Enabled = False
        BeLazy()
        Timer1.Enabled = True
    End Sub



    Private Sub D_Click(sender As Object, e As EventArgs) Handles D.Click
        If D.Text = dapandung Then
            Randomize()
            tam = Int(5 * Rnd())
            PictureBox1.Image = Image.FromFile(Path & "picture\Cô giáo\true" & tam & ".jpg")
            playaudio(Path & "picture\Cô giáo\true" & tam & ".wav")
        Else Randomize()
            tam = Int(6 * Rnd())
            PictureBox1.Image = Image.FromFile(Path & "picture\Cô giáo\false" & tam & ".jpg")
            playaudio(Path & "picture\Cô giáo\false" & tam & ".wav")
        End If
        B.Enabled = False
        C.Enabled = False
        A.Enabled = False
        BeLazy()
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '  Dim caua, caub, cauc, caud As String
        tracnghiem(textkttracnghiem1, textkttracnghiem2)
        A.Enabled = True
        B.Enabled = True
        C.Enabled = True
        D.Enabled = True
        PictureBox1.Image = Image.FromFile(Path & "picture\Cô giáo\question.jpg")
        Timer1.Enabled = False
    End Sub

End Class