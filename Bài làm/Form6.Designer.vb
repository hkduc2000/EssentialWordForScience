<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.tienganh = New System.Windows.Forms.TextBox()
        Me.tiengviet = New System.Windows.Forms.TextBox()
        Me.hienthitu = New System.Windows.Forms.RichTextBox()
        Me.add = New System.Windows.Forms.Button()
        Me.suachude = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chonchude = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chonanh = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dvtv = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tenchude = New System.Windows.Forms.TextBox()
        Me.themchude = New System.Windows.Forms.Button()
        Me.chontudexoa = New System.Windows.Forms.ComboBox()
        Me.xoachude = New System.Windows.Forms.Button()
        Me.anhminhhoa = New System.Windows.Forms.PictureBox()
        CType(Me.anhminhhoa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tienganh
        '
        resources.ApplyResources(Me.tienganh, "tienganh")
        Me.tienganh.Name = "tienganh"
        '
        'tiengviet
        '
        resources.ApplyResources(Me.tiengviet, "tiengviet")
        Me.tiengviet.Name = "tiengviet"
        '
        'hienthitu
        '
        resources.ApplyResources(Me.hienthitu, "hienthitu")
        Me.hienthitu.Name = "hienthitu"
        '
        'add
        '
        Me.add.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.add, "add")
        Me.add.Name = "add"
        Me.add.UseVisualStyleBackColor = True
        '
        'suachude
        '
        resources.ApplyResources(Me.suachude, "suachude")
        Me.suachude.Name = "suachude"
        Me.suachude.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'chonchude
        '
        resources.ApplyResources(Me.chonchude, "chonchude")
        Me.chonchude.FormattingEnabled = True
        Me.chonchude.Items.AddRange(New Object() {resources.GetString("chonchude.Items"), resources.GetString("chonchude.Items1")})
        Me.chonchude.Name = "chonchude"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'chonanh
        '
        Me.chonanh.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.chonanh, "chonanh")
        Me.chonanh.Name = "chonanh"
        Me.chonanh.UseVisualStyleBackColor = True
        '
        'delete
        '
        resources.ApplyResources(Me.delete, "delete")
        Me.delete.Name = "delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'dvtv
        '
        resources.ApplyResources(Me.dvtv, "dvtv")
        Me.dvtv.FormattingEnabled = True
        Me.dvtv.Items.AddRange(New Object() {resources.GetString("dvtv.Items"), resources.GetString("dvtv.Items1")})
        Me.dvtv.Name = "dvtv"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tenchude
        '
        resources.ApplyResources(Me.tenchude, "tenchude")
        Me.tenchude.Name = "tenchude"
        '
        'themchude
        '
        resources.ApplyResources(Me.themchude, "themchude")
        Me.themchude.Name = "themchude"
        Me.themchude.UseVisualStyleBackColor = True
        '
        'chontudexoa
        '
        resources.ApplyResources(Me.chontudexoa, "chontudexoa")
        Me.chontudexoa.FormattingEnabled = True
        Me.chontudexoa.Name = "chontudexoa"
        '
        'xoachude
        '
        resources.ApplyResources(Me.xoachude, "xoachude")
        Me.xoachude.Name = "xoachude"
        Me.xoachude.UseVisualStyleBackColor = True
        '
        'anhminhhoa
        '
        Me.anhminhhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.anhminhhoa, "anhminhhoa")
        Me.anhminhhoa.Name = "anhminhhoa"
        Me.anhminhhoa.TabStop = False
        '
        'Form6
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.xoachude)
        Me.Controls.Add(Me.themchude)
        Me.Controls.Add(Me.tenchude)
        Me.Controls.Add(Me.dvtv)
        Me.Controls.Add(Me.chonanh)
        Me.Controls.Add(Me.chontudexoa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chonchude)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.suachude)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.hienthitu)
        Me.Controls.Add(Me.tiengviet)
        Me.Controls.Add(Me.tienganh)
        Me.Controls.Add(Me.anhminhhoa)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form6"
        CType(Me.anhminhhoa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tienganh As TextBox
    Friend WithEvents tiengviet As TextBox
    Friend WithEvents hienthitu As RichTextBox
    Friend WithEvents add As Button
    Friend WithEvents suachude As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents chonchude As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents anhminhhoa As PictureBox
    Friend WithEvents chonanh As Button
    Friend WithEvents delete As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dvtv As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents tenchude As TextBox
    Friend WithEvents themchude As Button
    Friend WithEvents chontudexoa As ComboBox
    Friend WithEvents xoachude As Button
End Class
