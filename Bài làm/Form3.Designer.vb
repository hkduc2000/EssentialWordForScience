<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.cauhoitracnghiem = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.D = New System.Windows.Forms.Button()
        Me.C = New System.Windows.Forms.Button()
        Me.B = New System.Windows.Forms.Button()
        Me.A = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cauhoitracnghiem
        '
        Me.cauhoitracnghiem.AutoSize = True
        Me.cauhoitracnghiem.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.cauhoitracnghiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cauhoitracnghiem.Location = New System.Drawing.Point(12, 129)
        Me.cauhoitracnghiem.Name = "cauhoitracnghiem"
        Me.cauhoitracnghiem.Size = New System.Drawing.Size(173, 31)
        Me.cauhoitracnghiem.TabIndex = 0
        Me.cauhoitracnghiem.Text = "Welcome back"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(539, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 375)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'D
        '
        Me.D.BackgroundImage = CType(resources.GetObject("D.BackgroundImage"), System.Drawing.Image)
        Me.D.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.D.Location = New System.Drawing.Point(263, 294)
        Me.D.Name = "D"
        Me.D.Size = New System.Drawing.Size(249, 57)
        Me.D.TabIndex = 4
        Me.D.UseVisualStyleBackColor = True
        '
        'C
        '
        Me.C.BackgroundImage = CType(resources.GetObject("C.BackgroundImage"), System.Drawing.Image)
        Me.C.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.C.Location = New System.Drawing.Point(8, 294)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(249, 57)
        Me.C.TabIndex = 3
        Me.C.UseVisualStyleBackColor = True
        '
        'B
        '
        Me.B.BackgroundImage = CType(resources.GetObject("B.BackgroundImage"), System.Drawing.Image)
        Me.B.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.B.Location = New System.Drawing.Point(263, 237)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(249, 57)
        Me.B.TabIndex = 2
        Me.B.UseVisualStyleBackColor = True
        '
        'A
        '
        Me.A.BackgroundImage = CType(resources.GetObject("A.BackgroundImage"), System.Drawing.Image)
        Me.A.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.A.Location = New System.Drawing.Point(8, 237)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(249, 57)
        Me.A.TabIndex = 1
        Me.A.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 436)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.D)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.cauhoitracnghiem)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kiểm tra trắc nghiệm - Cô Đào"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cauhoitracnghiem As Label
    Public WithEvents A As Button
    Public WithEvents B As Button
    Public WithEvents C As Button
    Public WithEvents D As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
