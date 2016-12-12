<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.cauhoi = New System.Windows.Forms.Label()
        Me.trogiup = New System.Windows.Forms.Label()
        Me.traloi = New System.Windows.Forms.TextBox()
        Me.btntrogiup = New System.Windows.Forms.Button()
        Me.btntraloi = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sochucai = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cauhoi
        '
        Me.cauhoi.AutoSize = True
        Me.cauhoi.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cauhoi.Location = New System.Drawing.Point(4, 113)
        Me.cauhoi.Name = "cauhoi"
        Me.cauhoi.Size = New System.Drawing.Size(167, 46)
        Me.cauhoi.TabIndex = 0
        Me.cauhoi.Text = "Welcome"
        '
        'trogiup
        '
        Me.trogiup.AutoSize = True
        Me.trogiup.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.trogiup.Location = New System.Drawing.Point(12, 247)
        Me.trogiup.Name = "trogiup"
        Me.trogiup.Size = New System.Drawing.Size(73, 31)
        Me.trogiup.TabIndex = 1
        Me.trogiup.Text = "Help:"
        '
        'traloi
        '
        Me.traloi.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.traloi.Location = New System.Drawing.Point(12, 321)
        Me.traloi.Name = "traloi"
        Me.traloi.Size = New System.Drawing.Size(436, 38)
        Me.traloi.TabIndex = 2
        '
        'btntrogiup
        '
        Me.btntrogiup.Font = New System.Drawing.Font("Times New Roman", 20.0!)
        Me.btntrogiup.Location = New System.Drawing.Point(429, 247)
        Me.btntrogiup.Name = "btntrogiup"
        Me.btntrogiup.Size = New System.Drawing.Size(145, 40)
        Me.btntrogiup.TabIndex = 3
        Me.btntrogiup.Text = "Help"
        Me.btntrogiup.UseVisualStyleBackColor = True
        '
        'btntraloi
        '
        Me.btntraloi.Font = New System.Drawing.Font("Times New Roman", 20.0!)
        Me.btntraloi.Location = New System.Drawing.Point(454, 320)
        Me.btntraloi.Name = "btntraloi"
        Me.btntraloi.Size = New System.Drawing.Size(108, 38)
        Me.btntraloi.TabIndex = 4
        Me.btntraloi.Text = "Answer"
        Me.btntraloi.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(589, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 336)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'sochucai
        '
        Me.sochucai.AutoSize = True
        Me.sochucai.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.sochucai.Location = New System.Drawing.Point(57, 288)
        Me.sochucai.Name = "sochucai"
        Me.sochucai.Size = New System.Drawing.Size(82, 21)
        Me.sochucai.TabIndex = 7
        Me.sochucai.Text = "Có tất cả:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(804, 436)
        Me.Controls.Add(Me.sochucai)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btntraloi)
        Me.Controls.Add(Me.btntrogiup)
        Me.Controls.Add(Me.traloi)
        Me.Controls.Add(Me.trogiup)
        Me.Controls.Add(Me.cauhoi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kiểm tra điền chữ - Thầy Đức"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cauhoi As Label
    Friend WithEvents trogiup As Label
    Friend WithEvents traloi As TextBox
    Friend WithEvents btntrogiup As Button
    Friend WithEvents btntraloi As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents sochucai As Label
    Friend WithEvents Timer1 As Timer
End Class
