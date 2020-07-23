<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuThinButton26 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblFilesCleaned = New System.Windows.Forms.Label()
        Me.lblComplete = New System.Windows.Forms.Label()
        Me.scanBar = New System.Windows.Forms.ProgressBar()
        Me.btnClean = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnScan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel3 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.BunifuGradientPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuThinButton26)
        Me.Panel1.Controls.Add(Me.lblFilesCleaned)
        Me.Panel1.Controls.Add(Me.lblComplete)
        Me.Panel1.Controls.Add(Me.scanBar)
        Me.Panel1.Controls.Add(Me.btnClean)
        Me.Panel1.Controls.Add(Me.btnScan)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.BunifuGradientPanel3)
        Me.Panel1.Location = New System.Drawing.Point(-7, -19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(689, 488)
        Me.Panel1.TabIndex = 1
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
        Me.BunifuThinButton26.Location = New System.Drawing.Point(21, 409)
        Me.BunifuThinButton26.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton26.Name = "BunifuThinButton26"
        Me.BunifuThinButton26.Size = New System.Drawing.Size(84, 46)
        Me.BunifuThinButton26.TabIndex = 5
        Me.BunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFilesCleaned
        '
        Me.lblFilesCleaned.AutoSize = True
        Me.lblFilesCleaned.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilesCleaned.ForeColor = System.Drawing.Color.White
        Me.lblFilesCleaned.Location = New System.Drawing.Point(20, 391)
        Me.lblFilesCleaned.Name = "lblFilesCleaned"
        Me.lblFilesCleaned.Size = New System.Drawing.Size(79, 15)
        Me.lblFilesCleaned.TabIndex = 35
        Me.lblFilesCleaned.Text = "Files Cleaned!"
        Me.lblFilesCleaned.Visible = False
        '
        'lblComplete
        '
        Me.lblComplete.AutoSize = True
        Me.lblComplete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplete.ForeColor = System.Drawing.Color.White
        Me.lblComplete.Location = New System.Drawing.Point(17, 391)
        Me.lblComplete.Name = "lblComplete"
        Me.lblComplete.Size = New System.Drawing.Size(90, 15)
        Me.lblComplete.TabIndex = 34
        Me.lblComplete.Text = "Scan Complete!"
        Me.lblComplete.Visible = False
        '
        'scanBar
        '
        Me.scanBar.Location = New System.Drawing.Point(23, 370)
        Me.scanBar.Name = "scanBar"
        Me.scanBar.Size = New System.Drawing.Size(639, 15)
        Me.scanBar.TabIndex = 33
        '
        'btnClean
        '
        Me.btnClean.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnClean.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClean.BorderRadius = 0
        Me.btnClean.ButtonText = "Clean"
        Me.btnClean.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClean.DisabledColor = System.Drawing.Color.Gray
        Me.btnClean.Iconcolor = System.Drawing.Color.Transparent
        Me.btnClean.Iconimage = Nothing
        Me.btnClean.Iconimage_right = Nothing
        Me.btnClean.Iconimage_right_Selected = Nothing
        Me.btnClean.Iconimage_Selected = Nothing
        Me.btnClean.IconMarginLeft = 0
        Me.btnClean.IconMarginRight = 0
        Me.btnClean.IconRightVisible = True
        Me.btnClean.IconRightZoom = 0R
        Me.btnClean.IconVisible = True
        Me.btnClean.IconZoom = 90.0R
        Me.btnClean.IsTab = False
        Me.btnClean.Location = New System.Drawing.Point(519, 391)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnClean.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnClean.OnHoverTextColor = System.Drawing.Color.White
        Me.btnClean.selected = False
        Me.btnClean.Size = New System.Drawing.Size(143, 38)
        Me.btnClean.TabIndex = 31
        Me.btnClean.Text = "Clean"
        Me.btnClean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnClean.Textcolor = System.Drawing.Color.White
        Me.btnClean.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnScan
        '
        Me.btnScan.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnScan.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnScan.BorderRadius = 0
        Me.btnScan.ButtonText = "Scan"
        Me.btnScan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnScan.DisabledColor = System.Drawing.Color.Gray
        Me.btnScan.Iconcolor = System.Drawing.Color.Transparent
        Me.btnScan.Iconimage = Nothing
        Me.btnScan.Iconimage_right = Nothing
        Me.btnScan.Iconimage_right_Selected = Nothing
        Me.btnScan.Iconimage_Selected = Nothing
        Me.btnScan.IconMarginLeft = 0
        Me.btnScan.IconMarginRight = 0
        Me.btnScan.IconRightVisible = True
        Me.btnScan.IconRightZoom = 0R
        Me.btnScan.IconVisible = True
        Me.btnScan.IconZoom = 90.0R
        Me.btnScan.IsTab = False
        Me.btnScan.Location = New System.Drawing.Point(352, 392)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnScan.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnScan.OnHoverTextColor = System.Drawing.Color.White
        Me.btnScan.selected = False
        Me.btnScan.Size = New System.Drawing.Size(143, 38)
        Me.btnScan.TabIndex = 30
        Me.btnScan.Text = "Scan"
        Me.btnScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnScan.Textcolor = System.Drawing.Color.White
        Me.btnScan.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(23, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(631, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "_________________________________________________________________________________" &
    "_______________________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(296, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "CLEANER"
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel3.Controls.Add(Me.ListView1)
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.SystemColors.AppWorkspace
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(23, 69)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Quality = 10
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(639, 295)
        Me.BunifuGradientPanel3.TabIndex = 4
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(633, 289)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Timer1
        '
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuGradientPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuGradientPanel3 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuThinButton26 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnScan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnClean As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents scanBar As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblComplete As Label
    Friend WithEvents lblFilesCleaned As Label
End Class
