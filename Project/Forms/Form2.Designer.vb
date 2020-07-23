<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cpuSubform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cpuSubform))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuThinButton26 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuGradientPanel5 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.cpuMonitorLBL = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cpuProgressbar = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.BunifuGradientPanel3 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.tempSymbol = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblTemp = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblcpuSpeed = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblcpuName = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.myCpuBtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.BunifuGradientPanel5.SuspendLayout()
        Me.BunifuGradientPanel3.SuspendLayout()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "___________________________________________________________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(195, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "MY CPU"
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
        Me.BunifuThinButton26.Location = New System.Drawing.Point(14, 311)
        Me.BunifuThinButton26.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton26.Name = "BunifuThinButton26"
        Me.BunifuThinButton26.Size = New System.Drawing.Size(84, 48)
        Me.BunifuThinButton26.TabIndex = 5
        Me.BunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuGradientPanel5
        '
        Me.BunifuGradientPanel5.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel5.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel5.Controls.Add(Me.cpuMonitorLBL)
        Me.BunifuGradientPanel5.Controls.Add(Me.Label15)
        Me.BunifuGradientPanel5.Controls.Add(Me.cpuProgressbar)
        Me.BunifuGradientPanel5.GradientBottomLeft = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuGradientPanel5.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel5.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel5.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel5.Location = New System.Drawing.Point(35, 152)
        Me.BunifuGradientPanel5.Name = "BunifuGradientPanel5"
        Me.BunifuGradientPanel5.Quality = 10
        Me.BunifuGradientPanel5.Size = New System.Drawing.Size(337, 60)
        Me.BunifuGradientPanel5.TabIndex = 17
        '
        'cpuMonitorLBL
        '
        Me.cpuMonitorLBL.AutoSize = True
        Me.cpuMonitorLBL.BackColor = System.Drawing.Color.Transparent
        Me.cpuMonitorLBL.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpuMonitorLBL.ForeColor = System.Drawing.Color.White
        Me.cpuMonitorLBL.Location = New System.Drawing.Point(291, 23)
        Me.cpuMonitorLBL.Name = "cpuMonitorLBL"
        Me.cpuMonitorLBL.Size = New System.Drawing.Size(17, 20)
        Me.cpuMonitorLBL.TabIndex = 18
        Me.cpuMonitorLBL.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(15, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 15)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "CPU MONITOR"
        '
        'cpuProgressbar
        '
        Me.cpuProgressbar.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cpuProgressbar.BorderRadius = 5
        Me.cpuProgressbar.Location = New System.Drawing.Point(18, 29)
        Me.cpuProgressbar.MaximumValue = 100
        Me.cpuProgressbar.Name = "cpuProgressbar"
        Me.cpuProgressbar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cpuProgressbar.Size = New System.Drawing.Size(267, 10)
        Me.cpuProgressbar.TabIndex = 0
        Me.cpuProgressbar.Value = 0
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel3.Controls.Add(Me.tempSymbol)
        Me.BunifuGradientPanel3.Controls.Add(Me.lblTemp)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuCustomLabel4)
        Me.BunifuGradientPanel3.Controls.Add(Me.lblcpuSpeed)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuCustomLabel3)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuCustomLabel2)
        Me.BunifuGradientPanel3.Controls.Add(Me.lblcpuName)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuGradientPanel5)
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.SystemColors.AppWorkspace
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(14, 72)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Quality = 10
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(412, 231)
        Me.BunifuGradientPanel3.TabIndex = 3
        '
        'tempSymbol
        '
        Me.tempSymbol.AutoSize = True
        Me.tempSymbol.BackColor = System.Drawing.Color.Transparent
        Me.tempSymbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tempSymbol.ForeColor = System.Drawing.Color.White
        Me.tempSymbol.Location = New System.Drawing.Point(139, 96)
        Me.tempSymbol.Name = "tempSymbol"
        Me.tempSymbol.Size = New System.Drawing.Size(24, 13)
        Me.tempSymbol.TabIndex = 24
        Me.tempSymbol.Text = "° C"
        Me.tempSymbol.Visible = False
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.BackColor = System.Drawing.Color.Transparent
        Me.lblTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemp.ForeColor = System.Drawing.Color.White
        Me.lblTemp.Location = New System.Drawing.Point(121, 96)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(0, 13)
        Me.lblTemp.TabIndex = 23
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(108, 11)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(195, 13)
        Me.BunifuCustomLabel4.TabIndex = 22
        Me.BunifuCustomLabel4.Text = "To display CPU Information, click LOAD"
        '
        'lblcpuSpeed
        '
        Me.lblcpuSpeed.AutoSize = True
        Me.lblcpuSpeed.BackColor = System.Drawing.Color.Transparent
        Me.lblcpuSpeed.ForeColor = System.Drawing.Color.White
        Me.lblcpuSpeed.Location = New System.Drawing.Point(121, 67)
        Me.lblcpuSpeed.Name = "lblcpuSpeed"
        Me.lblcpuSpeed.Size = New System.Drawing.Size(0, 13)
        Me.lblcpuSpeed.TabIndex = 21
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(32, 67)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(83, 13)
        Me.BunifuCustomLabel3.TabIndex = 20
        Me.BunifuCustomLabel3.Text = "Clock Speed:"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(42, 39)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(72, 13)
        Me.BunifuCustomLabel2.TabIndex = 19
        Me.BunifuCustomLabel2.Text = "CPU Name:"
        '
        'lblcpuName
        '
        Me.lblcpuName.AutoSize = True
        Me.lblcpuName.BackColor = System.Drawing.Color.Transparent
        Me.lblcpuName.ForeColor = System.Drawing.Color.White
        Me.lblcpuName.Location = New System.Drawing.Point(120, 39)
        Me.lblcpuName.Name = "lblcpuName"
        Me.lblcpuName.Size = New System.Drawing.Size(0, 13)
        Me.lblcpuName.TabIndex = 18
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(33, 96)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(82, 13)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Temperature:"
        '
        'myCpuBtn
        '
        Me.myCpuBtn.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.myCpuBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.myCpuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.myCpuBtn.BorderRadius = 0
        Me.myCpuBtn.ButtonText = "Load"
        Me.myCpuBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.myCpuBtn.DisabledColor = System.Drawing.Color.Gray
        Me.myCpuBtn.Iconcolor = System.Drawing.Color.Transparent
        Me.myCpuBtn.Iconimage = Nothing
        Me.myCpuBtn.Iconimage_right = Nothing
        Me.myCpuBtn.Iconimage_right_Selected = Nothing
        Me.myCpuBtn.Iconimage_Selected = Nothing
        Me.myCpuBtn.IconMarginLeft = 0
        Me.myCpuBtn.IconMarginRight = 0
        Me.myCpuBtn.IconRightVisible = True
        Me.myCpuBtn.IconRightZoom = 0R
        Me.myCpuBtn.IconVisible = True
        Me.myCpuBtn.IconZoom = 90.0R
        Me.myCpuBtn.IsTab = False
        Me.myCpuBtn.Location = New System.Drawing.Point(283, 312)
        Me.myCpuBtn.Name = "myCpuBtn"
        Me.myCpuBtn.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.myCpuBtn.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.myCpuBtn.OnHoverTextColor = System.Drawing.Color.White
        Me.myCpuBtn.selected = False
        Me.myCpuBtn.Size = New System.Drawing.Size(143, 38)
        Me.myCpuBtn.TabIndex = 29
        Me.myCpuBtn.Text = "Load"
        Me.myCpuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.myCpuBtn.Textcolor = System.Drawing.Color.White
        Me.myCpuBtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'PerformanceCounter1
        '
        Me.PerformanceCounter1.CategoryName = "Processor"
        Me.PerformanceCounter1.CounterName = "% Processor Time"
        Me.PerformanceCounter1.InstanceName = "_Total"
        '
        'cpuSubform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(466, 362)
        Me.Controls.Add(Me.myCpuBtn)
        Me.Controls.Add(Me.BunifuThinButton26)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuGradientPanel3)
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cpuSubform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.BunifuGradientPanel5.ResumeLayout(False)
        Me.BunifuGradientPanel5.PerformLayout()
        Me.BunifuGradientPanel3.ResumeLayout(False)
        Me.BunifuGradientPanel3.PerformLayout()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel3 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents cpuMonitorLBL As Label
    Friend WithEvents BunifuGradientPanel5 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Label15 As Label
    Friend WithEvents cpuProgressbar As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuThinButton26 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents myCpuBtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblcpuSpeed As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblcpuName As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PerformanceCounter1 As PerformanceCounter
    Friend WithEvents lblTemp As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents tempSymbol As Bunifu.Framework.UI.BunifuCustomLabel
End Class
