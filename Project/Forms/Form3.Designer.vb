<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ramSubform
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ramSubform))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.autoFlushCHBX = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.myRamBtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuThinButton26 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel3 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.t2 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.t4 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.t3 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.t1 = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel5 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.ramUsagelbl = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ramProgressbar = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.BunifuGradientPanel3.SuspendLayout()
        Me.BunifuGradientPanel5.SuspendLayout()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.autoFlushCHBX)
        Me.Panel1.Controls.Add(Me.myRamBtn)
        Me.Panel1.Controls.Add(Me.BunifuThinButton26)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.BunifuGradientPanel3)
        Me.Panel1.Location = New System.Drawing.Point(-8, -33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 375)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(194, 329)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Auto Flush"
        '
        'autoFlushCHBX
        '
        Me.autoFlushCHBX.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.autoFlushCHBX.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.autoFlushCHBX.Checked = False
        Me.autoFlushCHBX.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.autoFlushCHBX.ForeColor = System.Drawing.Color.White
        Me.autoFlushCHBX.Location = New System.Drawing.Point(168, 329)
        Me.autoFlushCHBX.Name = "autoFlushCHBX"
        Me.autoFlushCHBX.Size = New System.Drawing.Size(20, 20)
        Me.autoFlushCHBX.TabIndex = 31
        '
        'myRamBtn
        '
        Me.myRamBtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.myRamBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.myRamBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.myRamBtn.BorderRadius = 0
        Me.myRamBtn.ButtonText = "Clean"
        Me.myRamBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.myRamBtn.DisabledColor = System.Drawing.Color.Gray
        Me.myRamBtn.Iconcolor = System.Drawing.Color.Transparent
        Me.myRamBtn.Iconimage = Nothing
        Me.myRamBtn.Iconimage_right = Nothing
        Me.myRamBtn.Iconimage_right_Selected = Nothing
        Me.myRamBtn.Iconimage_Selected = Nothing
        Me.myRamBtn.IconMarginLeft = 0
        Me.myRamBtn.IconMarginRight = 0
        Me.myRamBtn.IconRightVisible = True
        Me.myRamBtn.IconRightZoom = 0R
        Me.myRamBtn.IconVisible = True
        Me.myRamBtn.IconZoom = 90.0R
        Me.myRamBtn.IsTab = False
        Me.myRamBtn.Location = New System.Drawing.Point(289, 320)
        Me.myRamBtn.Name = "myRamBtn"
        Me.myRamBtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.myRamBtn.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.myRamBtn.OnHoverTextColor = System.Drawing.Color.White
        Me.myRamBtn.selected = False
        Me.myRamBtn.Size = New System.Drawing.Size(143, 38)
        Me.myRamBtn.TabIndex = 30
        Me.myRamBtn.Text = "Clean"
        Me.myRamBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.myRamBtn.Textcolor = System.Drawing.Color.White
        Me.myRamBtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuThinButton26
        '
        Me.BunifuThinButton26.ActiveBorderThickness = 1
        Me.BunifuThinButton26.ActiveCornerRadius = 20
        Me.BunifuThinButton26.ActiveFillColor = System.Drawing.Color.Black
        Me.BunifuThinButton26.ActiveForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton26.ActiveLineColor = System.Drawing.Color.Black
        Me.BunifuThinButton26.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.BunifuThinButton26.BackgroundImage = CType(resources.GetObject("BunifuThinButton26.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton26.ButtonText = "Back"
        Me.BunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton26.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton26.IdleBorderThickness = 1
        Me.BunifuThinButton26.IdleCornerRadius = 20
        Me.BunifuThinButton26.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton26.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton26.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton26.Location = New System.Drawing.Point(20, 318)
        Me.BunifuThinButton26.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton26.Name = "BunifuThinButton26"
        Me.BunifuThinButton26.Size = New System.Drawing.Size(84, 46)
        Me.BunifuThinButton26.TabIndex = 5
        Me.BunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(49, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(361, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "___________________________________________________________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(193, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "MY RAM"
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel3.Controls.Add(Me.t2)
        Me.BunifuGradientPanel3.Controls.Add(Me.t4)
        Me.BunifuGradientPanel3.Controls.Add(Me.t3)
        Me.BunifuGradientPanel3.Controls.Add(Me.t1)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuCustomLabel4)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuCustomLabel3)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuCustomLabel2)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuGradientPanel5)
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.SystemColors.AppWorkspace
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(20, 82)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Quality = 10
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(412, 231)
        Me.BunifuGradientPanel3.TabIndex = 4
        '
        't2
        '
        Me.t2.BorderColor = System.Drawing.Color.SeaGreen
        Me.t2.Enabled = False
        Me.t2.Location = New System.Drawing.Point(187, 63)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(150, 20)
        Me.t2.TabIndex = 27
        '
        't4
        '
        Me.t4.BorderColor = System.Drawing.Color.SeaGreen
        Me.t4.Enabled = False
        Me.t4.Location = New System.Drawing.Point(187, 123)
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(150, 20)
        Me.t4.TabIndex = 26
        '
        't3
        '
        Me.t3.BorderColor = System.Drawing.Color.SeaGreen
        Me.t3.Enabled = False
        Me.t3.Location = New System.Drawing.Point(187, 93)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(150, 20)
        Me.t3.TabIndex = 25
        '
        't1
        '
        Me.t1.BorderColor = System.Drawing.Color.SeaGreen
        Me.t1.Enabled = False
        Me.t1.Location = New System.Drawing.Point(187, 34)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(150, 20)
        Me.t1.TabIndex = 24
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(31, 126)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(150, 13)
        Me.BunifuCustomLabel4.TabIndex = 23
        Me.BunifuCustomLabel4.Text = "Available Virtual Memory:"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(54, 96)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(127, 13)
        Me.BunifuCustomLabel3.TabIndex = 22
        Me.BunifuCustomLabel3.Text = "Total Virtual Memory:"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(20, 66)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(161, 13)
        Me.BunifuCustomLabel1.TabIndex = 21
        Me.BunifuCustomLabel1.Text = "Available Physical Memory:"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(43, 37)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(138, 13)
        Me.BunifuCustomLabel2.TabIndex = 20
        Me.BunifuCustomLabel2.Text = "Total Physical Memory:"
        '
        'BunifuGradientPanel5
        '
        Me.BunifuGradientPanel5.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel5.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel5.Controls.Add(Me.ramUsagelbl)
        Me.BunifuGradientPanel5.Controls.Add(Me.Label15)
        Me.BunifuGradientPanel5.Controls.Add(Me.ramProgressbar)
        Me.BunifuGradientPanel5.GradientBottomLeft = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel5.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel5.Location = New System.Drawing.Point(23, 149)
        Me.BunifuGradientPanel5.Name = "BunifuGradientPanel5"
        Me.BunifuGradientPanel5.Quality = 10
        Me.BunifuGradientPanel5.Size = New System.Drawing.Size(337, 60)
        Me.BunifuGradientPanel5.TabIndex = 18
        '
        'ramUsagelbl
        '
        Me.ramUsagelbl.AutoSize = True
        Me.ramUsagelbl.BackColor = System.Drawing.Color.Transparent
        Me.ramUsagelbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ramUsagelbl.ForeColor = System.Drawing.Color.White
        Me.ramUsagelbl.Location = New System.Drawing.Point(291, 23)
        Me.ramUsagelbl.Name = "ramUsagelbl"
        Me.ramUsagelbl.Size = New System.Drawing.Size(17, 20)
        Me.ramUsagelbl.TabIndex = 18
        Me.ramUsagelbl.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(15, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 15)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Monitor"
        '
        'ramProgressbar
        '
        Me.ramProgressbar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ramProgressbar.BorderRadius = 5
        Me.ramProgressbar.Location = New System.Drawing.Point(18, 29)
        Me.ramProgressbar.MaximumValue = 100
        Me.ramProgressbar.Name = "ramProgressbar"
        Me.ramProgressbar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ramProgressbar.Size = New System.Drawing.Size(267, 10)
        Me.ramProgressbar.TabIndex = 0
        Me.ramProgressbar.Value = 0
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'PerformanceCounter1
        '
        Me.PerformanceCounter1.CategoryName = "Memory"
        Me.PerformanceCounter1.CounterName = "% Committed Bytes In Use"
        '
        'Timer2
        '
        '
        'ramSubform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 341)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ramSubform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programs"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuGradientPanel3.ResumeLayout(False)
        Me.BunifuGradientPanel3.PerformLayout()
        Me.BunifuGradientPanel5.ResumeLayout(False)
        Me.BunifuGradientPanel5.PerformLayout()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel3 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BunifuThinButton26 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents myRamBtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents t2 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents t4 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents t3 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents t1 As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuGradientPanel5 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents ramUsagelbl As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ramProgressbar As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents PerformanceCounter1 As PerformanceCounter
    Friend WithEvents Label1 As Label
    Friend WithEvents autoFlushCHBX As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Timer2 As Timer
End Class
