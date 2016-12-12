<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Me.labelhuongdan = New System.Windows.Forms.Label()
        Me.huongdansudung = New System.Windows.Forms.RichTextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.chon = New System.Windows.Forms.Label()
        Me.batdau = New System.Windows.Forms.Button()
        Me.kiemtra1 = New System.Windows.Forms.Button()
        Me.kiemtra2 = New System.Windows.Forms.Button()
        Me.tienganh = New System.Windows.Forms.RichTextBox()
        Me.search = New System.Windows.Forms.TextBox()
        Me.ketquatim = New System.Windows.Forms.ListBox()
        Me.co = New System.Windows.Forms.Button()
        Me.thay = New System.Windows.Forms.Button()
        Me.anhminhhoa = New System.Windows.Forms.PictureBox()
        Me.close = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.PictureBox()
        Me.hoctu = New System.Windows.Forms.Button()
        Me.ontap = New System.Windows.Forms.Button()
        Me.start = New System.Windows.Forms.PictureBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.home = New System.Windows.Forms.PictureBox()
        Me.thucvat = New System.Windows.Forms.Button()
        Me.dongvat = New System.Windows.Forms.Button()
        Me.ban = New System.Windows.Forms.Button()
        Me.kiemtra3 = New System.Windows.Forms.Button()
        CType(Me.anhminhhoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.home, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelhuongdan
        '
        Me.labelhuongdan.AutoSize = True
        Me.labelhuongdan.Cursor = System.Windows.Forms.Cursors.Default
        Me.labelhuongdan.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.labelhuongdan.Location = New System.Drawing.Point(209, 210)
        Me.labelhuongdan.Name = "labelhuongdan"
        Me.labelhuongdan.Size = New System.Drawing.Size(404, 32)
        Me.labelhuongdan.TabIndex = 42
        Me.labelhuongdan.Text = "Hướng dẫn sử dụng phần mềm "
        '
        'huongdansudung
        '
        Me.huongdansudung.Cursor = System.Windows.Forms.Cursors.Default
        Me.huongdansudung.Location = New System.Drawing.Point(45, 245)
        Me.huongdansudung.Name = "huongdansudung"
        Me.huongdansudung.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.huongdansudung.Size = New System.Drawing.Size(714, 126)
        Me.huongdansudung.TabIndex = 41
        Me.huongdansudung.Text = ""
        '
        'ListBox1
        '
        Me.ListBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListBox1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Location = New System.Drawing.Point(16, 84)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(345, 298)
        Me.ListBox1.TabIndex = 52
        Me.ListBox1.Visible = False
        '
        'chon
        '
        Me.chon.AutoSize = True
        Me.chon.Cursor = System.Windows.Forms.Cursors.Default
        Me.chon.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.chon.Location = New System.Drawing.Point(4, 26)
        Me.chon.Name = "chon"
        Me.chon.Size = New System.Drawing.Size(247, 22)
        Me.chon.TabIndex = 53
        Me.chon.Text = "Chọn 1 trong các chủ đề sau:"
        Me.chon.Visible = False
        '
        'batdau
        '
        Me.batdau.CausesValidation = False
        Me.batdau.Cursor = System.Windows.Forms.Cursors.Hand
        Me.batdau.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.batdau.Location = New System.Drawing.Point(592, 388)
        Me.batdau.Name = "batdau"
        Me.batdau.Size = New System.Drawing.Size(191, 46)
        Me.batdau.TabIndex = 55
        Me.batdau.Text = "Chọn chủ đề"
        Me.batdau.UseVisualStyleBackColor = True
        Me.batdau.Visible = False
        '
        'kiemtra1
        '
        Me.kiemtra1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kiemtra1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.kiemtra1.Location = New System.Drawing.Point(494, 388)
        Me.kiemtra1.Name = "kiemtra1"
        Me.kiemtra1.Size = New System.Drawing.Size(145, 36)
        Me.kiemtra1.TabIndex = 62
        Me.kiemtra1.Text = "Bài tập 2"
        Me.kiemtra1.UseVisualStyleBackColor = True
        Me.kiemtra1.Visible = False
        '
        'kiemtra2
        '
        Me.kiemtra2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kiemtra2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.kiemtra2.Location = New System.Drawing.Point(641, 388)
        Me.kiemtra2.Name = "kiemtra2"
        Me.kiemtra2.Size = New System.Drawing.Size(145, 36)
        Me.kiemtra2.TabIndex = 63
        Me.kiemtra2.Text = "Bài tập 3"
        Me.kiemtra2.UseVisualStyleBackColor = True
        Me.kiemtra2.Visible = False
        '
        'tienganh
        '
        Me.tienganh.Cursor = System.Windows.Forms.Cursors.Default
        Me.tienganh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.tienganh.Location = New System.Drawing.Point(359, 36)
        Me.tienganh.Name = "tienganh"
        Me.tienganh.Size = New System.Drawing.Size(433, 346)
        Me.tienganh.TabIndex = 64
        Me.tienganh.Text = ""
        Me.tienganh.Visible = False
        '
        'search
        '
        Me.search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.search.Location = New System.Drawing.Point(16, 51)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(232, 27)
        Me.search.TabIndex = 65
        Me.search.Visible = False
        '
        'ketquatim
        '
        Me.ketquatim.Cursor = System.Windows.Forms.Cursors.Default
        Me.ketquatim.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ketquatim.FormattingEnabled = True
        Me.ketquatim.HorizontalScrollbar = True
        Me.ketquatim.ItemHeight = 20
        Me.ketquatim.Location = New System.Drawing.Point(18, 76)
        Me.ketquatim.Name = "ketquatim"
        Me.ketquatim.Size = New System.Drawing.Size(230, 144)
        Me.ketquatim.TabIndex = 67
        Me.ketquatim.Visible = False
        '
        'co
        '
        Me.co.Cursor = System.Windows.Forms.Cursors.Hand
        Me.co.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.co.Location = New System.Drawing.Point(635, 44)
        Me.co.Name = "co"
        Me.co.Size = New System.Drawing.Size(131, 36)
        Me.co.TabIndex = 69
        Me.co.Text = "Cô Đào"
        Me.co.UseVisualStyleBackColor = True
        Me.co.Visible = False
        '
        'thay
        '
        Me.thay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.thay.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.thay.Location = New System.Drawing.Point(45, 44)
        Me.thay.Name = "thay"
        Me.thay.Size = New System.Drawing.Size(131, 36)
        Me.thay.TabIndex = 70
        Me.thay.Text = "Thầy Đức"
        Me.thay.UseVisualStyleBackColor = True
        Me.thay.Visible = False
        '
        'anhminhhoa
        '
        Me.anhminhhoa.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.anhminhhoa.Image = CType(resources.GetObject("anhminhhoa.Image"), System.Drawing.Image)
        Me.anhminhhoa.Location = New System.Drawing.Point(400, 36)
        Me.anhminhhoa.Name = "anhminhhoa"
        Me.anhminhhoa.Size = New System.Drawing.Size(386, 346)
        Me.anhminhhoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.anhminhhoa.TabIndex = 59
        Me.anhminhhoa.TabStop = False
        Me.anhminhhoa.Visible = False
        '
        'close
        '
        Me.close.BackgroundImage = CType(resources.GetObject("close.BackgroundImage"), System.Drawing.Image)
        Me.close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close.Location = New System.Drawing.Point(16, 219)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(232, 28)
        Me.close.TabIndex = 68
        Me.close.UseVisualStyleBackColor = True
        Me.close.Visible = False
        '
        'btnsearch
        '
        Me.btnsearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), System.Drawing.Image)
        Me.btnsearch.Location = New System.Drawing.Point(254, 48)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(107, 30)
        Me.btnsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnsearch.TabIndex = 66
        Me.btnsearch.TabStop = False
        Me.btnsearch.Visible = False
        '
        'hoctu
        '
        Me.hoctu.BackgroundImage = CType(resources.GetObject("hoctu.BackgroundImage"), System.Drawing.Image)
        Me.hoctu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hoctu.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hoctu.ForeColor = System.Drawing.Color.Snow
        Me.hoctu.Location = New System.Drawing.Point(234, 76)
        Me.hoctu.Name = "hoctu"
        Me.hoctu.Size = New System.Drawing.Size(335, 77)
        Me.hoctu.TabIndex = 49
        Me.hoctu.Text = "Học từ mới"
        Me.hoctu.UseVisualStyleBackColor = True
        Me.hoctu.Visible = False
        '
        'ontap
        '
        Me.ontap.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ontap.BackgroundImage = CType(resources.GetObject("ontap.BackgroundImage"), System.Drawing.Image)
        Me.ontap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ontap.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ontap.ForeColor = System.Drawing.Color.Snow
        Me.ontap.Location = New System.Drawing.Point(234, 165)
        Me.ontap.Name = "ontap"
        Me.ontap.Size = New System.Drawing.Size(335, 77)
        Me.ontap.TabIndex = 48
        Me.ontap.Text = "Ôn tập"
        Me.ontap.UseVisualStyleBackColor = False
        Me.ontap.Visible = False
        '
        'start
        '
        Me.start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.start.Image = CType(resources.GetObject("start.Image"), System.Drawing.Image)
        Me.start.Location = New System.Drawing.Point(319, 377)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(169, 57)
        Me.start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.start.TabIndex = 44
        Me.start.TabStop = False
        '
        'logo
        '
        Me.logo.Cursor = System.Windows.Forms.Cursors.Default
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(156, 36)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(504, 163)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 43
        Me.logo.TabStop = False
        '
        'home
        '
        Me.home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.home.Image = CType(resources.GetObject("home.Image"), System.Drawing.Image)
        Me.home.Location = New System.Drawing.Point(762, 0)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(30, 30)
        Me.home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.home.TabIndex = 1
        Me.home.TabStop = False
        '
        'thucvat
        '
        Me.thucvat.BackgroundImage = CType(resources.GetObject("thucvat.BackgroundImage"), System.Drawing.Image)
        Me.thucvat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.thucvat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.thucvat.Font = New System.Drawing.Font("Times New Roman", 29.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.thucvat.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.thucvat.Location = New System.Drawing.Point(400, 36)
        Me.thucvat.Name = "thucvat"
        Me.thucvat.Size = New System.Drawing.Size(350, 350)
        Me.thucvat.TabIndex = 51
        Me.thucvat.Text = "FLORA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(THỰC VẬT)"
        Me.thucvat.UseVisualStyleBackColor = True
        Me.thucvat.Visible = False
        '
        'dongvat
        '
        Me.dongvat.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Untitled
        Me.dongvat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dongvat.Font = New System.Drawing.Font("Times New Roman", 29.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.dongvat.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.dongvat.Location = New System.Drawing.Point(56, 36)
        Me.dongvat.Name = "dongvat"
        Me.dongvat.Size = New System.Drawing.Size(350, 350)
        Me.dongvat.TabIndex = 50
        Me.dongvat.Text = "  FAUNAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ĐỘNG VẬT)"
        Me.dongvat.UseVisualStyleBackColor = True
        Me.dongvat.Visible = False
        '
        'ban
        '
        Me.ban.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ban.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ban.Location = New System.Drawing.Point(336, 184)
        Me.ban.Name = "ban"
        Me.ban.Size = New System.Drawing.Size(131, 36)
        Me.ban.TabIndex = 74
        Me.ban.Text = "Bạn Ngọc"
        Me.ban.UseVisualStyleBackColor = True
        Me.ban.Visible = False
        '
        'kiemtra3
        '
        Me.kiemtra3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kiemtra3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.kiemtra3.Location = New System.Drawing.Point(343, 388)
        Me.kiemtra3.Name = "kiemtra3"
        Me.kiemtra3.Size = New System.Drawing.Size(145, 36)
        Me.kiemtra3.TabIndex = 75
        Me.kiemtra3.Text = "Bài tập 1"
        Me.kiemtra3.UseVisualStyleBackColor = True
        Me.kiemtra3.Visible = False
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.home
        Me.ClientSize = New System.Drawing.Size(804, 436)
        Me.Controls.Add(Me.kiemtra3)
        Me.Controls.Add(Me.ban)
        Me.Controls.Add(Me.thay)
        Me.Controls.Add(Me.co)
        Me.Controls.Add(Me.anhminhhoa)
        Me.Controls.Add(Me.close)
        Me.Controls.Add(Me.ketquatim)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.kiemtra2)
        Me.Controls.Add(Me.kiemtra1)
        Me.Controls.Add(Me.batdau)
        Me.Controls.Add(Me.chon)
        Me.Controls.Add(Me.hoctu)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.labelhuongdan)
        Me.Controls.Add(Me.huongdansudung)
        Me.Controls.Add(Me.home)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.tienganh)
        Me.Controls.Add(Me.thucvat)
        Me.Controls.Add(Me.dongvat)
        Me.Controls.Add(Me.ontap)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Essential words for biology -  EWB"
        CType(Me.anhminhhoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnsearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.home, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo As PictureBox
    Friend WithEvents labelhuongdan As Label
    Friend WithEvents huongdansudung As RichTextBox
    Friend WithEvents start As PictureBox
    Friend WithEvents ontap As Button
    Friend WithEvents hoctu As Button
    Friend WithEvents home As PictureBox
    Friend WithEvents dongvat As Button
    Friend WithEvents thucvat As Button
    Friend WithEvents chon As Label
    Friend WithEvents batdau As Button
    Friend WithEvents anhminhhoa As PictureBox
    Friend WithEvents kiemtra1 As Button
    Friend WithEvents kiemtra2 As Button
    Friend WithEvents tienganh As RichTextBox
    Friend WithEvents search As TextBox
    Friend WithEvents btnsearch As PictureBox
    Friend WithEvents ketquatim As ListBox
    Public WithEvents ListBox1 As ListBox
    Friend WithEvents close As Button
    Friend WithEvents co As Button
    Friend WithEvents thay As Button
    Friend WithEvents ban As Button
    Friend WithEvents kiemtra3 As Button
End Class
