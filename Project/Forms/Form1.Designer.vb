<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.PerformanceCounter2 = New System.Diagnostics.PerformanceCounter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.userTXTBX = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.versionTXTBX = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.platformTXTBX = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.osTEXTBX = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.computernameTXTBX = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.systemInfoBTN = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuThinButton26 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuGradientPanel4 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel8 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.diskProgressbar = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.BunifuGradientPanel7 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.diskLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel3 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ramProgressbar = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.ramUsageLBL = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.cpuProgressbar = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.cpuMonitorLBL = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerformanceCounter2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.BunifuGradientPanel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel8.SuspendLayout()
        Me.BunifuGradientPanel7.SuspendLayout()
        Me.BunifuGradientPanel3.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(667, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "_________________________________________________________________________________" &
    "_____________________________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(307, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "DASHBOARD"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Silver
        Me.Label14.Location = New System.Drawing.Point(13, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 17)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Computer Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Silver
        Me.Label10.Location = New System.Drawing.Point(333, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Current User"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Silver
        Me.Label11.Location = New System.Drawing.Point(364, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 17)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Version"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(61, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Platform"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Silver
        Me.Label13.Location = New System.Drawing.Point(9, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 17)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Operating System"
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
        'PerformanceCounter2
        '
        Me.PerformanceCounter2.CategoryName = "Memory"
        Me.PerformanceCounter2.CounterName = "% Committed Bytes In Use"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.userTXTBX)
        Me.GroupBox1.Controls.Add(Me.versionTXTBX)
        Me.GroupBox1.Controls.Add(Me.platformTXTBX)
        Me.GroupBox1.Controls.Add(Me.osTEXTBX)
        Me.GroupBox1.Controls.Add(Me.computernameTXTBX)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(43, 249)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 136)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SYSTEM INFORMATION"
        '
        'userTXTBX
        '
        Me.userTXTBX.BorderColor = System.Drawing.Color.SeaGreen
        Me.userTXTBX.Enabled = False
        Me.userTXTBX.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userTXTBX.Location = New System.Drawing.Point(421, 26)
        Me.userTXTBX.Name = "userTXTBX"
        Me.userTXTBX.Size = New System.Drawing.Size(185, 25)
        Me.userTXTBX.TabIndex = 20
        '
        'versionTXTBX
        '
        Me.versionTXTBX.BorderColor = System.Drawing.Color.SeaGreen
        Me.versionTXTBX.Enabled = False
        Me.versionTXTBX.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.versionTXTBX.Location = New System.Drawing.Point(421, 58)
        Me.versionTXTBX.Name = "versionTXTBX"
        Me.versionTXTBX.Size = New System.Drawing.Size(185, 25)
        Me.versionTXTBX.TabIndex = 19
        '
        'platformTXTBX
        '
        Me.platformTXTBX.BorderColor = System.Drawing.Color.SeaGreen
        Me.platformTXTBX.Enabled = False
        Me.platformTXTBX.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.platformTXTBX.Location = New System.Drawing.Point(134, 90)
        Me.platformTXTBX.Name = "platformTXTBX"
        Me.platformTXTBX.Size = New System.Drawing.Size(184, 25)
        Me.platformTXTBX.TabIndex = 18
        '
        'osTEXTBX
        '
        Me.osTEXTBX.BorderColor = System.Drawing.Color.SeaGreen
        Me.osTEXTBX.Enabled = False
        Me.osTEXTBX.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.osTEXTBX.Location = New System.Drawing.Point(134, 58)
        Me.osTEXTBX.Name = "osTEXTBX"
        Me.osTEXTBX.Size = New System.Drawing.Size(184, 25)
        Me.osTEXTBX.TabIndex = 17
        '
        'computernameTXTBX
        '
        Me.computernameTXTBX.BorderColor = System.Drawing.Color.SeaGreen
        Me.computernameTXTBX.Enabled = False
        Me.computernameTXTBX.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.computernameTXTBX.Location = New System.Drawing.Point(134, 26)
        Me.computernameTXTBX.Name = "computernameTXTBX"
        Me.computernameTXTBX.Size = New System.Drawing.Size(184, 25)
        Me.computernameTXTBX.TabIndex = 16
        '
        'systemInfoBTN
        '
        Me.systemInfoBTN.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.systemInfoBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.systemInfoBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.systemInfoBTN.BorderRadius = 0
        Me.systemInfoBTN.ButtonText = "Show System Info"
        Me.systemInfoBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.systemInfoBTN.DisabledColor = System.Drawing.Color.Gray
        Me.systemInfoBTN.Iconcolor = System.Drawing.Color.Transparent
        Me.systemInfoBTN.Iconimage = Nothing
        Me.systemInfoBTN.Iconimage_right = Nothing
        Me.systemInfoBTN.Iconimage_right_Selected = Nothing
        Me.systemInfoBTN.Iconimage_Selected = Nothing
        Me.systemInfoBTN.IconMarginLeft = 0
        Me.systemInfoBTN.IconMarginRight = 0
        Me.systemInfoBTN.IconRightVisible = True
        Me.systemInfoBTN.IconRightZoom = 0R
        Me.systemInfoBTN.IconVisible = True
        Me.systemInfoBTN.IconZoom = 90.0R
        Me.systemInfoBTN.IsTab = False
        Me.systemInfoBTN.Location = New System.Drawing.Point(517, 390)
        Me.systemInfoBTN.Name = "systemInfoBTN"
        Me.systemInfoBTN.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.systemInfoBTN.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.systemInfoBTN.OnHoverTextColor = System.Drawing.Color.White
        Me.systemInfoBTN.selected = False
        Me.systemInfoBTN.Size = New System.Drawing.Size(143, 38)
        Me.systemInfoBTN.TabIndex = 28
        Me.systemInfoBTN.Text = "Show System Info"
        Me.systemInfoBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.systemInfoBTN.Textcolor = System.Drawing.Color.White
        Me.systemInfoBTN.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Scanner"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(359, 390)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(143, 38)
        Me.BunifuFlatButton1.TabIndex = 29
        Me.BunifuFlatButton1.Text = "Scanner"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Report"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(201, 390)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(143, 38)
        Me.BunifuFlatButton2.TabIndex = 30
        Me.BunifuFlatButton2.Text = "Report"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BunifuThinButton26.ButtonText = "Exit"
        Me.BunifuThinButton26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton26.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton26.IdleBorderThickness = 1
        Me.BunifuThinButton26.IdleCornerRadius = 20
        Me.BunifuThinButton26.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton26.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton26.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton26.Location = New System.Drawing.Point(14, 393)
        Me.BunifuThinButton26.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton26.Name = "BunifuThinButton26"
        Me.BunifuThinButton26.Size = New System.Drawing.Size(84, 46)
        Me.BunifuThinButton26.TabIndex = 5
        Me.BunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuGradientPanel4
        '
        Me.BunifuGradientPanel4.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel4.Controls.Add(Me.PictureBox2)
        Me.BunifuGradientPanel4.Controls.Add(Me.BunifuGradientPanel8)
        Me.BunifuGradientPanel4.Controls.Add(Me.diskProgressbar)
        Me.BunifuGradientPanel4.Controls.Add(Me.BunifuGradientPanel7)
        Me.BunifuGradientPanel4.Controls.Add(Me.diskLbl)
        Me.BunifuGradientPanel4.Controls.Add(Me.Label5)
        Me.BunifuGradientPanel4.GradientBottomLeft = System.Drawing.SystemColors.AppWorkspace
        Me.BunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel4.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel4.Location = New System.Drawing.Point(486, 54)
        Me.BunifuGradientPanel4.Name = "BunifuGradientPanel4"
        Me.BunifuGradientPanel4.Quality = 10
        Me.BunifuGradientPanel4.Size = New System.Drawing.Size(199, 171)
        Me.BunifuGradientPanel4.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(72, 66)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(55, 38)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'BunifuGradientPanel8
        '
        Me.BunifuGradientPanel8.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel8.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel8.Controls.Add(Me.Label7)
        Me.BunifuGradientPanel8.GradientBottomLeft = System.Drawing.SystemColors.AppWorkspace
        Me.BunifuGradientPanel8.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel8.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel8.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel8.Location = New System.Drawing.Point(582, 74)
        Me.BunifuGradientPanel8.Name = "BunifuGradientPanel8"
        Me.BunifuGradientPanel8.Quality = 10
        Me.BunifuGradientPanel8.Size = New System.Drawing.Size(154, 42)
        Me.BunifuGradientPanel8.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(32, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Analzye Disk"
        '
        'diskProgressbar
        '
        Me.diskProgressbar.animated = False
        Me.diskProgressbar.animationIterval = 5
        Me.diskProgressbar.animationSpeed = 300
        Me.diskProgressbar.BackColor = System.Drawing.Color.Transparent
        Me.diskProgressbar.BackgroundImage = CType(resources.GetObject("diskProgressbar.BackgroundImage"), System.Drawing.Image)
        Me.diskProgressbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.diskProgressbar.ForeColor = System.Drawing.Color.White
        Me.diskProgressbar.LabelVisible = False
        Me.diskProgressbar.LineProgressThickness = 8
        Me.diskProgressbar.LineThickness = 5
        Me.diskProgressbar.Location = New System.Drawing.Point(48, 34)
        Me.diskProgressbar.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.diskProgressbar.MaxValue = 100
        Me.diskProgressbar.Name = "diskProgressbar"
        Me.diskProgressbar.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.diskProgressbar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.diskProgressbar.Size = New System.Drawing.Size(103, 103)
        Me.diskProgressbar.TabIndex = 19
        Me.diskProgressbar.Value = 0
        '
        'BunifuGradientPanel7
        '
        Me.BunifuGradientPanel7.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel7.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel7.Controls.Add(Me.Label6)
        Me.BunifuGradientPanel7.GradientBottomLeft = System.Drawing.SystemColors.AppWorkspace
        Me.BunifuGradientPanel7.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel7.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel7.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel7.Location = New System.Drawing.Point(344, 74)
        Me.BunifuGradientPanel7.Name = "BunifuGradientPanel7"
        Me.BunifuGradientPanel7.Quality = 10
        Me.BunifuGradientPanel7.Size = New System.Drawing.Size(154, 42)
        Me.BunifuGradientPanel7.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(32, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Analzye RAM"
        '
        'diskLbl
        '
        Me.diskLbl.AutoSize = True
        Me.diskLbl.BackColor = System.Drawing.Color.Transparent
        Me.diskLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diskLbl.ForeColor = System.Drawing.Color.White
        Me.diskLbl.Location = New System.Drawing.Point(48, 137)
        Me.diskLbl.Name = "diskLbl"
        Me.diskLbl.Size = New System.Drawing.Size(40, 20)
        Me.diskLbl.TabIndex = 9
        Me.diskLbl.Text = "0 GB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(70, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "C: DISK"
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel3.Controls.Add(Me.BunifuImageButton3)
        Me.BunifuGradientPanel3.Controls.Add(Me.ramProgressbar)
        Me.BunifuGradientPanel3.Controls.Add(Me.ramUsageLBL)
        Me.BunifuGradientPanel3.Controls.Add(Me.Label4)
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.SystemColors.AppWorkspace
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(252, 54)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Quality = 10
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(199, 171)
        Me.BunifuGradientPanel3.TabIndex = 2
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(74, 65)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(54, 41)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 20
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'ramProgressbar
        '
        Me.ramProgressbar.animated = False
        Me.ramProgressbar.animationIterval = 5
        Me.ramProgressbar.animationSpeed = 300
        Me.ramProgressbar.BackColor = System.Drawing.Color.Transparent
        Me.ramProgressbar.BackgroundImage = CType(resources.GetObject("ramProgressbar.BackgroundImage"), System.Drawing.Image)
        Me.ramProgressbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.ramProgressbar.ForeColor = System.Drawing.Color.White
        Me.ramProgressbar.LabelVisible = False
        Me.ramProgressbar.LineProgressThickness = 8
        Me.ramProgressbar.LineThickness = 5
        Me.ramProgressbar.Location = New System.Drawing.Point(48, 34)
        Me.ramProgressbar.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.ramProgressbar.MaxValue = 100
        Me.ramProgressbar.Name = "ramProgressbar"
        Me.ramProgressbar.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.ramProgressbar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ramProgressbar.Size = New System.Drawing.Size(103, 103)
        Me.ramProgressbar.TabIndex = 19
        Me.ramProgressbar.Value = 0
        '
        'ramUsageLBL
        '
        Me.ramUsageLBL.AutoSize = True
        Me.ramUsageLBL.BackColor = System.Drawing.Color.Transparent
        Me.ramUsageLBL.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ramUsageLBL.ForeColor = System.Drawing.Color.White
        Me.ramUsageLBL.Location = New System.Drawing.Point(92, 137)
        Me.ramUsageLBL.Name = "ramUsageLBL"
        Me.ramUsageLBL.Size = New System.Drawing.Size(17, 20)
        Me.ramUsageLBL.TabIndex = 8
        Me.ramUsageLBL.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(81, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "RAM"
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuImageButton2)
        Me.BunifuGradientPanel2.Controls.Add(Me.cpuProgressbar)
        Me.BunifuGradientPanel2.Controls.Add(Me.cpuMonitorLBL)
        Me.BunifuGradientPanel2.Controls.Add(Me.Label3)
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.SystemColors.AppWorkspace
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(30, 54)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(199, 171)
        Me.BunifuGradientPanel2.TabIndex = 1
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = Global.Project.My.Resources.Resources.cpu_xxl
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(69, 67)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(54, 41)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 19
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'cpuProgressbar
        '
        Me.cpuProgressbar.animated = False
        Me.cpuProgressbar.animationIterval = 5
        Me.cpuProgressbar.animationSpeed = 300
        Me.cpuProgressbar.BackColor = System.Drawing.Color.Transparent
        Me.cpuProgressbar.BackgroundImage = CType(resources.GetObject("cpuProgressbar.BackgroundImage"), System.Drawing.Image)
        Me.cpuProgressbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.cpuProgressbar.ForeColor = System.Drawing.Color.White
        Me.cpuProgressbar.LabelVisible = False
        Me.cpuProgressbar.LineProgressThickness = 8
        Me.cpuProgressbar.LineThickness = 5
        Me.cpuProgressbar.Location = New System.Drawing.Point(43, 34)
        Me.cpuProgressbar.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.cpuProgressbar.MaxValue = 100
        Me.cpuProgressbar.Name = "cpuProgressbar"
        Me.cpuProgressbar.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.cpuProgressbar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.cpuProgressbar.Size = New System.Drawing.Size(103, 103)
        Me.cpuProgressbar.TabIndex = 18
        Me.cpuProgressbar.Value = 0
        '
        'cpuMonitorLBL
        '
        Me.cpuMonitorLBL.AutoSize = True
        Me.cpuMonitorLBL.BackColor = System.Drawing.Color.Transparent
        Me.cpuMonitorLBL.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpuMonitorLBL.ForeColor = System.Drawing.Color.White
        Me.cpuMonitorLBL.Location = New System.Drawing.Point(81, 137)
        Me.cpuMonitorLBL.Name = "cpuMonitorLBL"
        Me.cpuMonitorLBL.Size = New System.Drawing.Size(17, 20)
        Me.cpuMonitorLBL.TabIndex = 7
        Me.cpuMonitorLBL.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(81, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CPU"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(718, 450)
        Me.Controls.Add(Me.BunifuThinButton26)
        Me.Controls.Add(Me.BunifuFlatButton2)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.systemInfoBTN)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuGradientPanel4)
        Me.Controls.Add(Me.BunifuGradientPanel3)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerformanceCounter2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.BunifuGradientPanel4.ResumeLayout(False)
        Me.BunifuGradientPanel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel8.ResumeLayout(False)
        Me.BunifuGradientPanel8.PerformLayout()
        Me.BunifuGradientPanel7.ResumeLayout(False)
        Me.BunifuGradientPanel7.PerformLayout()
        Me.BunifuGradientPanel3.ResumeLayout(False)
        Me.BunifuGradientPanel3.PerformLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel3 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuGradientPanel4 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cpuMonitorLBL As Label
    Friend WithEvents ramUsageLBL As Label
    Friend WithEvents diskLbl As Label
    Friend WithEvents cpuProgressbar As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents ramProgressbar As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents diskProgressbar As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BunifuThinButton26 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PerformanceCounter1 As PerformanceCounter
    Friend WithEvents PerformanceCounter2 As PerformanceCounter
    Friend WithEvents BunifuGradientPanel7 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuGradientPanel8 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents userTXTBX As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents versionTXTBX As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents platformTXTBX As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents osTEXTBX As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents computernameTXTBX As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents systemInfoBTN As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
End Class
