
Module Module1
    Public Path = Application.StartupPath & "\"
    Public textkttracnghiem1, textkttracnghiem2, textktdientu1, textktdientu2, textchono1, textchono2 As String


    ' Sub dienchu(ByVal textv As String, ByVal texta As String, byref )

    '  End Sub
    Function S1(ByVal St1 As String) As String
        Dim a
        Try
            For i = 0 To UBound(a)

                a(i) = UCase(Left(a(i), 1)) & Right(a(i), Len(a(i)) - 1)
            Next
        Catch
        End Try
    End Function


    Sub xoadong(ByVal tentext As String, ByVal dongcanxoa As Integer)
        Dim docfile() As String = IO.File.ReadAllLines(tentext)
        Dim ghifile As System.IO.StreamWriter
        ghifile = My.Computer.FileSystem.OpenTextFileWriter(tentext, False)
        For i = 0 To docfile.GetUpperBound(0)
            If i <> dongcanxoa Then
                ghifile.WriteLine(docfile(i))
            End If
        Next
        ghifile.Close()
    End Sub
    Public Function xoaDauUni(nhap As String) As String    ' Xoa dau tieng Viet font Unicode
        '---------------------------------------------------------------------------------------
        ' Function : xoaDauUni
        ' Author      : phantronghiep07
        ' Phone      : 0915 080 282
        '---------------------------------------------------------------------------------------
        Dim maAcii = New Integer() {7845, 7847, 7849, 7851, 7853, 226, 225, 224, 7843, 227, 7841, 7855, 7857, 7859, 7861, 7863, 259, 250, 249, 7911, 361, 7909, 7913, 7915, 7917, 7919, 7921, 432, 7871, 7873, 7875, 7877, 7879, 234, 233, 232, 7867, 7869, 7865, 7889, 7891, 7893, 7895, 7897, 244, 243, 242, 7887, 245, 7885, 7899, 7901, 7903, 7905, 7907, 417, 237, 236, 7881, 297, 7883, 253, 7923, 7927, 7929, 7925, 273, 7844, 7846, 7848, 7850, 7852, 194, 193, 192, 7842, 195, 7840, 7854, 7856, 7858, 7860, 7862, 258, 218, 217, 7910, 360, 7908, 7912, 7914, 7916, 7918, 7920, 431, 7870, 7872, 7874, 7876, 7878, 202, 201, 200, 7866, 7868, 7864, 7888, 7890, 7892, 7894, 7896, 212, 211, 210, 7886, 213, 7884, 7898, 7900, 7902, 7904, 7906, 416, 205, 204, 7880, 296, 7882, 221, 7922, 7926, 7928, 7924, 272}
        Dim i As Integer
        Dim kyTu()
        kyTu = New String() {"a", "u", "e", "o", "i", "y", "d", "A", "U", "E", "O", "I", "Y", "D"}

        xoaDauUni = nhap
        For i = 0 To 133
            If i <= 16 Then xoaDauUni = Replace(xoaDauUni, ChrW(maAcii(i)), kyTu(0)) 'a
            If 16 < i And i <= 27 Then xoaDauUni = Replace(xoaDauUni, ChrW(maAcii(i)), kyTu(1)) 'u
            If 27 < i And i <= 38 Then xoaDauUni = Replace(xoaDauUni, ChrW(maAcii(i)), kyTu(2)) 'e
            If 38 < i And i <= 55 Then xoaDauUni = Replace(xoaDauUni, ChrW(maAcii(i)), kyTu(3)) 'o
            If 55 < i And i <= 60 Then xoaDauUni = Replace(xoaDauUni, ChrW(maAcii(i)), kyTu(4)) 'i
            If 60 < i And i <= 65 Then xoaDauUni = Replace(xoaDauUni, ChrW(maAcii(i)), kyTu(5)) 'y
            If i = 66 Then xoaDauUni = Replace(xoaDauUni, ChrW(maAcii(i)), kyTu(6)) 'd
            If 66 < i And i <= 83 Then xoaDauUni = Replace(xoaDauUni, ChrW(maAcii(i)), kyTu(7)) 'A
            If 83 < i And i <= 94 Then xoaDauUni = Replace(xoaDauUni, ChrW(maAcii(i)), kyTu(8)) 'U
            If 94 < i And i <= 105 Then xoaDauUni = Replace(xoaDauUni, ChrW(maAcii(i)), kyTu(9)) 'E
            If 105 < i And i <= 122 Then xoaDauUni = Replace(xoaDauUni, ChrW(maAcii(i)), kyTu(10)) 'O
            If 122 < i And i <= 127 Then xoaDauUni = Replace(xoaDauUni, ChrW(maAcii(i)), kyTu(11)) 'I
            If 127 < i And i <= 132 Then xoaDauUni = Replace(xoaDauUni, ChrW(maAcii(i)), kyTu(12)) 'Y
            If i = 133 Then xoaDauUni = Replace(xoaDauUni, ChrW(maAcii(i)), kyTu(13)) 'D
        Next i


    End Function

    Private ReadOnly VietnameseSigns As String() = New String() {"aAeEoOuUiIdDyY", "áàạảãăắằẵẳâẩẫấầậ", "ÁÃẠÀẢẲẴẰẮẶẤẦẪẨẬ", "éèẹẻẽêếềệễể", "ÉÈẸẼẺÊẾỀỆỂỄ", "óòọỏõôốồỗổộơớờỡởợ",
                                                                                "ÒÓÕỎỌÔỒỐỖỔỘƠỠỜỞỚỢ", "úùụủũưứừựửữ", "ÚÙỤŨỦƯỮỪỨỬỰ", "íìịĩỉ", "ÍÌĨỊỈ", "đ",
                                                                                "Đ", "ýỳỵỷỹ", "ÝỲỴỶỸ"}
    Public Function xoadau(ByVal str As String) As String
        For i As Integer = 1 To VietnameseSigns.Length - 1
            For j As Integer = 0 To VietnameseSigns(i).Length - 1
                str = Replace(str, VietnameseSigns(i)(j), VietnameseSigns(0)(i - 1))
            Next
        Next
        Return str
    End Function
    '  Sub PlayBackgroundSoundResource()
    '   My.Computer.Audio.Play(Path & "music\song" & Int(2 * Rnd()) & ".wav",
    '       AudioPlayMode.BackgroundLoop)
    ' End Sub
    Sub playaudio(ByVal duongdan As String)
        My.Computer.Audio.Play(duongdan)
    End Sub
    Sub BeLazy()
        For i = 1 To 5
            Threading.Thread.Sleep(100)
            Application.DoEvents()
        Next
    End Sub
End Module
