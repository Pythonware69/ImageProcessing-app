<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmdLoadPicture = New System.Windows.Forms.Button()
        Me.cmdGreyScale = New System.Windows.Forms.Button()
        Me.cmdSmooth = New System.Windows.Forms.Button()
        Me.cmdSharpen = New System.Windows.Forms.Button()
        Me.Picture1 = New System.Windows.Forms.PictureBox()
        Me.Picture2 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmdSavePicture = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdLoadPicture
        '
        Me.cmdLoadPicture.Location = New System.Drawing.Point(88, 59)
        Me.cmdLoadPicture.Name = "cmdLoadPicture"
        Me.cmdLoadPicture.Size = New System.Drawing.Size(360, 208)
        Me.cmdLoadPicture.TabIndex = 0
        Me.cmdLoadPicture.Text = "Load Picture"
        Me.cmdLoadPicture.UseVisualStyleBackColor = True
        '
        'cmdGreyScale
        '
        Me.cmdGreyScale.Location = New System.Drawing.Point(500, 59)
        Me.cmdGreyScale.Name = "cmdGreyScale"
        Me.cmdGreyScale.Size = New System.Drawing.Size(283, 38)
        Me.cmdGreyScale.TabIndex = 1
        Me.cmdGreyScale.Text = "Grey scale"
        Me.cmdGreyScale.UseVisualStyleBackColor = True
        '
        'cmdSmooth
        '
        Me.cmdSmooth.Location = New System.Drawing.Point(500, 131)
        Me.cmdSmooth.Name = "cmdSmooth"
        Me.cmdSmooth.Size = New System.Drawing.Size(283, 36)
        Me.cmdSmooth.TabIndex = 2
        Me.cmdSmooth.Text = "Smooth"
        Me.cmdSmooth.UseVisualStyleBackColor = True
        '
        'cmdSharpen
        '
        Me.cmdSharpen.Location = New System.Drawing.Point(500, 200)
        Me.cmdSharpen.Name = "cmdSharpen"
        Me.cmdSharpen.Size = New System.Drawing.Size(283, 39)
        Me.cmdSharpen.TabIndex = 3
        Me.cmdSharpen.Text = "Sharpen"
        Me.cmdSharpen.UseVisualStyleBackColor = True
        '
        'Picture1
        '
        Me.Picture1.Location = New System.Drawing.Point(88, 273)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Size = New System.Drawing.Size(360, 235)
        Me.Picture1.TabIndex = 5
        Me.Picture1.TabStop = False
        '
        'Picture2
        '
        Me.Picture2.Location = New System.Drawing.Point(500, 273)
        Me.Picture2.Name = "Picture2"
        Me.Picture2.Size = New System.Drawing.Size(283, 235)
        Me.Picture2.TabIndex = 6
        Me.Picture2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 514)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(360, 22)
        Me.TextBox1.TabIndex = 7
        '
        'cmdSavePicture
        '
        Me.cmdSavePicture.Location = New System.Drawing.Point(500, 514)
        Me.cmdSavePicture.Name = "cmdSavePicture"
        Me.cmdSavePicture.Size = New System.Drawing.Size(283, 35)
        Me.cmdSavePicture.TabIndex = 8
        Me.cmdSavePicture.Text = "Save As"
        Me.cmdSavePicture.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 580)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(894, 26)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 18)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(50, 20)
        Me.ToolStripStatusLabel1.Text = "Ready"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 606)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmdSavePicture)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Picture2)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.cmdSharpen)
        Me.Controls.Add(Me.cmdSmooth)
        Me.Controls.Add(Me.cmdGreyScale)
        Me.Controls.Add(Me.cmdLoadPicture)
        Me.Name = "Form1"
        Me.Text = "Raster-Filtering Ezra"
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdLoadPicture As Button
    Friend WithEvents cmdGreyScale As Button
    Friend WithEvents cmdSmooth As Button
    Friend WithEvents cmdSharpen As Button
    Friend WithEvents Picture1 As PictureBox
    Friend WithEvents Picture2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cmdSavePicture As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
