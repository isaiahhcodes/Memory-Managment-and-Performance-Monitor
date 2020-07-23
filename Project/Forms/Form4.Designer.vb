<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoryForm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuThinButton26 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel3 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.objectsCleaned = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.afterCollection = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.beforeCollection = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.maxGenerations = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.historyListbox = New System.Windows.Forms.ListBox()
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
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.BunifuGradientPanel3)
        Me.Panel1.Location = New System.Drawing.Point(-7, -19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 469)
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
        Me.BunifuThinButton26.Location = New System.Drawing.Point(35, 387)
        Me.BunifuThinButton26.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton26.Name = "BunifuThinButton26"
        Me.BunifuThinButton26.Size = New System.Drawing.Size(84, 46)
        Me.BunifuThinButton26.TabIndex = 5
        Me.BunifuThinButton26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "LOG"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(18, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(667, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "_________________________________________________________________________________" &
    "_____________________________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(317, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "REPORT"
        '
        'BunifuGradientPanel3
        '
        Me.BunifuGradientPanel3.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel3.Controls.Add(Me.objectsCleaned)
        Me.BunifuGradientPanel3.Controls.Add(Me.Label9)
        Me.BunifuGradientPanel3.Controls.Add(Me.afterCollection)
        Me.BunifuGradientPanel3.Controls.Add(Me.beforeCollection)
        Me.BunifuGradientPanel3.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel3.Controls.Add(Me.maxGenerations)
        Me.BunifuGradientPanel3.Controls.Add(Me.Label8)
        Me.BunifuGradientPanel3.Controls.Add(Me.Label7)
        Me.BunifuGradientPanel3.Controls.Add(Me.Label6)
        Me.BunifuGradientPanel3.Controls.Add(Me.historyListbox)
        Me.BunifuGradientPanel3.GradientBottomLeft = System.Drawing.SystemColors.AppWorkspace
        Me.BunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.BunifuGradientPanel3.Location = New System.Drawing.Point(35, 107)
        Me.BunifuGradientPanel3.Name = "BunifuGradientPanel3"
        Me.BunifuGradientPanel3.Quality = 10
        Me.BunifuGradientPanel3.Size = New System.Drawing.Size(639, 272)
        Me.BunifuGradientPanel3.TabIndex = 4
        '
        'objectsCleaned
        '
        Me.objectsCleaned.AutoSize = True
        Me.objectsCleaned.BackColor = System.Drawing.Color.Transparent
        Me.objectsCleaned.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.objectsCleaned.ForeColor = System.Drawing.Color.White
        Me.objectsCleaned.Location = New System.Drawing.Point(522, 248)
        Me.objectsCleaned.Name = "objectsCleaned"
        Me.objectsCleaned.Size = New System.Drawing.Size(13, 15)
        Me.objectsCleaned.TabIndex = 30
        Me.objectsCleaned.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(400, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 15)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Total Objects Cleaned:"
        '
        'afterCollection
        '
        Me.afterCollection.BorderColor = System.Drawing.Color.SeaGreen
        Me.afterCollection.Enabled = False
        Me.afterCollection.Location = New System.Drawing.Point(417, 175)
        Me.afterCollection.Name = "afterCollection"
        Me.afterCollection.ReadOnly = True
        Me.afterCollection.Size = New System.Drawing.Size(140, 20)
        Me.afterCollection.TabIndex = 28
        '
        'beforeCollection
        '
        Me.beforeCollection.BorderColor = System.Drawing.Color.SeaGreen
        Me.beforeCollection.Enabled = False
        Me.beforeCollection.Location = New System.Drawing.Point(417, 113)
        Me.beforeCollection.Name = "beforeCollection"
        Me.beforeCollection.ReadOnly = True
        Me.beforeCollection.Size = New System.Drawing.Size(140, 20)
        Me.beforeCollection.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(470, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "RAM"
        '
        'maxGenerations
        '
        Me.maxGenerations.BorderColor = System.Drawing.Color.SeaGreen
        Me.maxGenerations.Enabled = False
        Me.maxGenerations.Location = New System.Drawing.Point(416, 51)
        Me.maxGenerations.Name = "maxGenerations"
        Me.maxGenerations.ReadOnly = True
        Me.maxGenerations.Size = New System.Drawing.Size(140, 20)
        Me.maxGenerations.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(427, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 15)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Maximum Generations"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(390, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Memory cleaned after full collection"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(400, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Memory used before collection"
        '
        'historyListbox
        '
        Me.historyListbox.FormattingEnabled = True
        Me.historyListbox.Location = New System.Drawing.Point(0, 0)
        Me.historyListbox.Name = "historyListbox"
        Me.historyListbox.Size = New System.Drawing.Size(339, 277)
        Me.historyListbox.TabIndex = 0
        '
        'HistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HistoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuGradientPanel3.ResumeLayout(False)
        Me.BunifuGradientPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuGradientPanel3 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuThinButton26 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
    Friend WithEvents historyListbox As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents afterCollection As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents beforeCollection As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents maxGenerations As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents objectsCleaned As Label
    Friend WithEvents Label9 As Label
End Class
