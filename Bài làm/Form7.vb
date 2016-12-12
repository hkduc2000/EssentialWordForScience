Public Class form7
    Dim socauhoi, vitri1, vitri2 As Integer
    Dim tienganh, tiengviet, traloi1, traloi2 As String
    Dim mang(20) As Integer
    Dim dem As Integer = 20
    Dim d4, d2, tam As Integer
    Dim chuadung As Boolean = True
    Dim d3 As Integer
    Dim time As Integer
    Dim Sttest1() As String = IO.File.ReadAllLines(Path & "text\" & textchono1)
    Dim Sttest2() As String = IO.File.ReadAllLines(Path & "text\" & textchono2)
    Dim kimduc

    Private Sub a1_Click(sender As Object, e As EventArgs) Handles a1.Click
        click(a1)
    End Sub
    Private Sub a1_MouseEnter(sender As Object, e As EventArgs) Handles a1.MouseEnter
        enter(a1)
    End Sub
    Private Sub a1_MouseLeave(sender As Object, e As EventArgs) Handles a1.MouseLeave
        Leave(a1)
    End Sub
    Private Sub a2_Click(sender As Object, e As EventArgs) Handles a2.Click
        click(a2)
    End Sub
    Private Sub a2_MouseEnter(sender As Object, e As EventArgs) Handles a2.MouseEnter
        enter(a2)
    End Sub
    Private Sub a2_MouseLeave(sender As Object, e As EventArgs) Handles a2.MouseLeave
        leave(a2)
    End Sub
    Private Sub a3_Click(sender As Object, e As EventArgs) Handles a3.Click
        click(a3)
    End Sub
    Private Sub a3_MouseEnter(sender As Object, e As EventArgs) Handles a3.MouseEnter
        enter(a3)
    End Sub
    Private Sub a3_MouseLeave(sender As Object, e As EventArgs) Handles a3.MouseLeave
        leave(a3)
    End Sub
    Private Sub a4_Click(sender As Object, e As EventArgs) Handles a4.Click
        click(a4)
    End Sub
    Private Sub a4_MouseEnter(sender As Object, e As EventArgs) Handles a4.MouseEnter
        enter(a4)
    End Sub
    Private Sub a4_MouseLeave(sender As Object, e As EventArgs) Handles a4.MouseLeave
        leave(a4)
    End Sub
    Private Sub a5_Click(sender As Object, e As EventArgs) Handles a5.Click
        click(a5)
    End Sub
    Private Sub a5_MouseEnter(sender As Object, e As EventArgs) Handles a5.MouseEnter
        enter(a5)
    End Sub
    Private Sub a5_MouseLeave(sender As Object, e As EventArgs) Handles a5.MouseLeave
        leave(a5)
    End Sub
    Private Sub a6_Click(sender As Object, e As EventArgs) Handles a6.Click
        click(a6)
    End Sub
    Private Sub a6_MouseEnter(sender As Object, e As EventArgs) Handles a6.MouseEnter
        enter(a6)
    End Sub
    Private Sub a6_MouseLeave(sender As Object, e As EventArgs) Handles a6.MouseLeave
        leave(a6)
    End Sub
    Private Sub a7_Click(sender As Object, e As EventArgs) Handles a7.Click
        click(a7)
    End Sub
    Private Sub a7_MouseEnter(sender As Object, e As EventArgs) Handles a7.MouseEnter
        enter(a7)
    End Sub
    Private Sub a7_MouseLeave(sender As Object, e As EventArgs) Handles a7.MouseLeave
        leave(a7)
    End Sub
    Private Sub a8_Click(sender As Object, e As EventArgs) Handles a8.Click
        click(a8)
    End Sub
    Private Sub a8_MouseEnter(sender As Object, e As EventArgs) Handles a8.MouseEnter
        enter(a8)
    End Sub
    Private Sub a8_MouseLeave(sender As Object, e As EventArgs) Handles a8.MouseLeave
        leave(a8)
    End Sub
    Private Sub a9_Click(sender As Object, e As EventArgs) Handles a9.Click
        click(a9)
    End Sub
    Private Sub a9_MouseEnter(sender As Object, e As EventArgs) Handles a9.MouseEnter
        enter(a9)
    End Sub
    Private Sub a9_MouseLeave(sender As Object, e As EventArgs) Handles a9.MouseLeave
        leave(a9)
    End Sub
    Private Sub a10_Click(sender As Object, e As EventArgs) Handles a10.Click
        click(a10)
    End Sub
    Private Sub a10_MouseEnter(sender As Object, e As EventArgs) Handles a10.MouseEnter
        enter(a10)
    End Sub
    Private Sub a10_MouseLeave(sender As Object, e As EventArgs) Handles a10.MouseLeave
        leave(a10)
    End Sub
    Private Sub a11_Click(sender As Object, e As EventArgs) Handles a11.Click
        click(a11)
    End Sub
    Private Sub a11_MouseEnter(sender As Object, e As EventArgs) Handles a11.MouseEnter
        enter(a11)
    End Sub
    Private Sub a11_MouseLeave(sender As Object, e As EventArgs) Handles a11.MouseLeave
        leave(a11)
    End Sub
    Private Sub a12_Click(sender As Object, e As EventArgs) Handles a12.Click
        click(a12)
    End Sub
    Private Sub a12_MouseEnter(sender As Object, e As EventArgs) Handles a12.MouseEnter
        enter(a12)
    End Sub
    Private Sub a12_MouseLeave(sender As Object, e As EventArgs) Handles a12.MouseLeave
        leave(a12)
    End Sub
    Private Sub a13_Click(sender As Object, e As EventArgs) Handles a13.Click
        click(a13)
    End Sub
    Private Sub a13_MouseEnter(sender As Object, e As EventArgs) Handles a13.MouseEnter
        enter(a13)
    End Sub
    Private Sub a13_MouseLeave(sender As Object, e As EventArgs) Handles a13.MouseLeave
        leave(a13)
    End Sub
    Private Sub a14_Click(sender As Object, e As EventArgs) Handles a14.Click
        click(a14)
    End Sub
    Private Sub a14_MouseEnter(sender As Object, e As EventArgs) Handles a14.MouseEnter
        enter(a14)
    End Sub
    Private Sub a14_MouseLeave(sender As Object, e As EventArgs) Handles a14.MouseLeave
        leave(a14)
    End Sub
    Private Sub a15_Click(sender As Object, e As EventArgs) Handles a15.Click
        click(a15)
    End Sub
    Private Sub a15_MouseEnter(sender As Object, e As EventArgs) Handles a15.MouseEnter
        enter(a15)
    End Sub
    Private Sub a15_MouseLeave(sender As Object, e As EventArgs) Handles a15.MouseLeave
        leave(a15)
    End Sub
    Private Sub a16_Click(sender As Object, e As EventArgs) Handles a16.Click
        click(a16)
    End Sub
    Private Sub a16_MouseEnter(sender As Object, e As EventArgs) Handles a16.MouseEnter
        enter(a16)
    End Sub
    Private Sub a16_MouseLeave(sender As Object, e As EventArgs) Handles a16.MouseLeave
        leave(a16)
    End Sub
    Private Sub a17_Click(sender As Object, e As EventArgs) Handles a17.Click
        click(a17)
    End Sub
    Private Sub a17_MouseEnter(sender As Object, e As EventArgs) Handles a17.MouseEnter
        enter(a17)
    End Sub
    Private Sub a17_MouseLeave(sender As Object, e As EventArgs) Handles a17.MouseLeave
        leave(a17)
    End Sub
    Private Sub a18_Click(sender As Object, e As EventArgs) Handles a18.Click
        click(a18)
    End Sub
    Private Sub a18_MouseEnter(sender As Object, e As EventArgs) Handles a18.MouseEnter
        enter(a18)
    End Sub
    Private Sub a18_MouseLeave(sender As Object, e As EventArgs) Handles a18.MouseLeave
        leave(a18)
    End Sub
    Private Sub a19_Click(sender As Object, e As EventArgs) Handles a19.Click
        click(a19)
    End Sub
    Private Sub a19_MouseEnter(sender As Object, e As EventArgs) Handles a19.MouseEnter
        enter(a19)
    End Sub
    Private Sub a19_MouseLeave(sender As Object, e As EventArgs) Handles a19.MouseLeave
        leave(a19)
    End Sub
    Private Sub a0_Click(sender As Object, e As EventArgs) Handles a0.Click
        click(a0)
    End Sub
    Private Sub a0_MouseEnter(sender As Object, e As EventArgs) Handles a0.MouseEnter
        enter(a0)
    End Sub
    Private Sub a0_MouseLeave(sender As Object, e As EventArgs) Handles a0.MouseLeave
        leave(a0)
    End Sub
    Sub click(ByVal duc)
        If d2 = 0 Then
            ' If duc.BackColor = Color.BurlyWood Then          
            duc.BackColor = Color.Peru
            traloi1 = duc.Text
            kimduc = duc
            d2 = d2 + 1
            '  Else duc.BackColor = Color.BurlyWood
            ' d2 = 0
            'End If
            ' ElseIf duc.BackColor = Color.BurlyWood Then
            '    duc.BackColor = Color.Peru
            '   traloi2 = duc.Text
            '  d2 = d2 + 1
        ElseIf duc.name = kimduc.name Then
            duc.BackColor = Color.BurlyWood
            d2 = 0
        Else duc.BackColor = Color.Peru
            traloi2 = duc.text
            d2 = d2 + 1
        End If
        If d2 = 2 Then
            'kiem tra dap an:
            For i = 0 To Sttest1.GetUpperBound(0)
                If (traloi1 = Sttest1(i) And traloi2 = Sttest2(i)) Or (traloi1 = Sttest2(i) And traloi2 = Sttest1(i)) Then
                    Call BeLazy()
                    Randomize()
                    tam = Int(5 * Rnd())
                    PictureBox1.Image = Image.FromFile(Path & "picture\bạn\true" & tam & ".jpg")
                    playaudio(Path & "picture\bạn\true" & tam & ".wav")
                    d4 = d4 + 1
                    If d4 = 10 Then
                        Randomize()
                        tam = Int(3 * Rnd())
                        PictureBox1.Image = Image.FromFile(Path & "picture\bạn\win" & Int(3 * Rnd()) & ".jpg")
                        playaudio(Path & "picture\bạn\win" & Int(3 * Rnd()) & ".wav")
                        Timer1.Enabled = False
                        a0.Enabled = False
                        a1.Enabled = False
                        a2.Enabled = False
                        a3.Enabled = False
                        a4.Enabled = False
                        a5.Enabled = False
                        a6.Enabled = False
                        a7.Enabled = False
                        a8.Enabled = False
                        a9.Enabled = False
                        a10.Enabled = False
                        a11.Enabled = False
                        a12.Enabled = False
                        a13.Enabled = False
                        a14.Enabled = False
                        a15.Enabled = False
                        a16.Enabled = False
                        a17.Enabled = False
                        a18.Enabled = False
                        a19.Enabled = False

                    Else Select Case d3
                            Case 1
                                Call BeLazy()
                                Call BeLazy()
                                PictureBox1.Image = Image.FromFile(Path & "picture\bạn\cohoi2.jpg")
                            Case 2
                                Call BeLazy()
                                Call BeLazy()
                                PictureBox1.Image = Image.FromFile(Path & "picture\bạn\cohoi1.jpg")
                        End Select
                    End If

                    duc.visible = False
                    kimduc.visible = False
                    chuadung = False
                ElseIf i = Sttest1.GetUpperBound(0) And chuadung = True Then
                    Randomize()
                    tam = Int(6 * Rnd())
                    PictureBox1.Image = Image.FromFile(Path & "picture\bạn\false" & tam & ".jpg")
                    playaudio(Path & "picture\bạn\false" & tam & ".wav")
                    d3 = d3 + 1
                    Select Case d3
                        Case 1
                            Call BeLazy()
                            Call BeLazy()
                            PictureBox1.Image = Image.FromFile(Path & "picture\bạn\cohoi2.jpg")
                        Case 2
                            Call BeLazy()
                            Call BeLazy()
                            PictureBox1.Image = Image.FromFile(Path & "picture\bạn\cohoi1.jpg")
                        Case 3
                            Call BeLazy()
                            Call BeLazy()
                            Randomize()
                            tam = Int(4 * Rnd())
                            PictureBox1.Image = Image.FromFile(Path & "picture\bạn\lose" & Int(4 * Rnd()) & ".jpg")
                            playaudio(Path & "picture\bạn\lose" & tam & ".wav")
                            Timer1.Enabled = False
                            a0.Enabled = False
                            a1.Enabled = False
                            a2.Enabled = False
                            a3.Enabled = False
                            a4.Enabled = False
                            a5.Enabled = False
                            a6.Enabled = False
                            a7.Enabled = False
                            a8.Enabled = False
                            a9.Enabled = False
                            a10.Enabled = False
                            a11.Enabled = False
                            a12.Enabled = False
                            a13.Enabled = False
                            a14.Enabled = False
                            a15.Enabled = False
                            a16.Enabled = False
                            a17.Enabled = False
                            a18.Enabled = False
                            a19.Enabled = False
                            lammoi.Enabled = True
                    End Select

                End If
            Next
            chuadung = True
            d2 = 0

            duc.BackColor = Color.Gainsboro
            kimduc.BackColor = Color.Gainsboro
            'dem so lan sai
        End If
    End Sub


    Sub leave(duc)
        If duc.BackColor = Color.BurlyWood Then
            duc.BackColor = Color.Gainsboro
        End If
    End Sub
    Sub enter(duc)
        If duc.BackColor = Color.Gainsboro Then
            duc.BackColor = Color.BurlyWood
        End If
    End Sub

    Sub diencauhoi(ByVal a As String, ByVal b As String)
        Select Case a
            Case 1
                a1.Text = b
            Case 2
                a2.Text = b
            Case 3
                a3.Text = b
            Case 4
                a4.Text = b
            Case 5
                a5.Text = b
            Case 6
                a6.Text = b
            Case 7
                a7.Text = b
            Case 8
                a8.Text = b
            Case 9
                a9.Text = b
            Case 10
                a10.Text = b
            Case 11
                a11.Text = b
            Case 12
                a12.Text = b
            Case 13
                a13.Text = b
            Case 14
                a14.Text = b
            Case 15
                a15.Text = b
            Case 16
                a16.Text = b
            Case 17
                a17.Text = b
            Case 18
                a18.Text = b
            Case 19
                a19.Text = b
            Case 0
                a0.Text = b
        End Select
    End Sub

    Sub xoaarray(ByVal vitri As Integer)
        Dim j As Integer = 0
        Dim tam As Array
        dem = dem - 1
        Array.Clear(mang, vitri, 1)
        tam = mang
        ReDim mang(dem)
        For i = 0 To vitri - 1
            mang(j) = tam(i)
            j = j + 1
        Next
        For i = vitri + 1 To UBound(tam) - 1
            mang(j) = tam(i)
            j = j + 1
        Next
    End Sub

    Private Sub a1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        tam = Int(3 * Rnd())
        PictureBox1.Image = Image.FromFile(Path & "picture\bạn\hello" & tam & ".jpg")
        Call BeLazy()
        playaudio(Path & "picture\bạn\hello" & tam & ".wav")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles lammoi.Click
        Dim a As String
        ReDim mang(20)
        For i = 0 To 19
            mang(i) = i
        Next
        Do
            Randomize()
            socauhoi = Int((Sttest1.GetUpperBound(0) + 1) * Rnd())
            Randomize()
            vitri1 = Int((UBound(mang) - 1) * Rnd())
            diencauhoi(mang(vitri1), Sttest1(socauhoi))
            xoaarray(vitri1)
            Randomize()
            vitri2 = Int((UBound(mang)) - 1 * Rnd())
            diencauhoi(mang(vitri2), Sttest2(socauhoi))
            xoaarray(vitri2)
            '   For i = 0 To UBound(mang) - 1
            ' MsgBox(mang(i))
            '  Next
            '  xoaarray(mang, vitri2, mang)
        Loop Until UBound(mang) = 0
        time = 90
        dem = 20
        Timer1.Enabled = True
        a0.Enabled = True
        a1.Enabled = True
        a2.Enabled = True
        a3.Enabled = True
        a4.Enabled = True
        a5.Enabled = True
        a6.Enabled = True
        a7.Enabled = True
        a8.Enabled = True
        a9.Enabled = True
        a10.Enabled = True
        a11.Enabled = True
        a12.Enabled = True
        a13.Enabled = True
        a14.Enabled = True
        a15.Enabled = True
        a16.Enabled = True
        a17.Enabled = True
        a18.Enabled = True
        a19.Enabled = True
        a0.Visible = True
        a1.Visible = True
        a2.Visible = True
        a3.Visible = True
        a4.Visible = True
        a5.Visible = True
        a6.Visible = True
        a7.Visible = True
        a8.Visible = True
        a9.Visible = True
        a10.Visible = True
        a11.Visible = True
        a12.Visible = True
        a13.Visible = True
        a14.Visible = True
        a15.Visible = True
        a16.Visible = True
        a17.Visible = True
        a18.Visible = True
        a19.Visible = True
        d3 = 0
        d4 = 0

        PictureBox1.Image = Image.FromFile(Path & "picture\bạn\cohoi3.jpg")
        Call BeLazy()
        playaudio(Path & "picture\bạn\batdau.wav")
        lammoi.Enabled = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = time - 1
        Label1.Text = "Time: " & time & " Giây"
        If time = 0 Then
            Randomize()
            tam = Int(4 * Rnd())
            PictureBox1.Image = Image.FromFile(Path & "picture\bạn\lose" & Int(4 * Rnd()) & ".jpg")
            playaudio(Path & "picture\bạn\lose" & tam & ".wav")
            Timer1.Enabled = False
            a0.Enabled = False
            a1.Enabled = False
            a2.Enabled = False
            a3.Enabled = False
            a4.Enabled = False
            a5.Enabled = False
            a6.Enabled = False
            a7.Enabled = False
            a8.Enabled = False
            a9.Enabled = False
            a10.Enabled = False
            a11.Enabled = False
            a12.Enabled = False
            a13.Enabled = False
            a14.Enabled = False
            a15.Enabled = False
            a16.Enabled = False
            a17.Enabled = False
            a18.Enabled = False
            a19.Enabled = False
        End If
    End Sub

End Class