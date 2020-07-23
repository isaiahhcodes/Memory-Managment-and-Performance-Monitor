Imports System
Imports System.IO
Imports System.PlatformID
Imports System.IO.File
Imports System.Math

Public Class DashboardForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs)
        Me.Hide()
        cpuSubform.Show()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs)
        Me.Hide()
        ramSubform.Show()
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs)
        Me.Hide()
        HistoryForm.Show()
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs)
        Me.Hide()
        SettingsForm.Show()
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'CPU MONITOR
        cpuProgressbar.Value = PerformanceCounter1.NextValue
        cpuMonitorLBL.Text = cpuProgressbar.Value.ToString + "%"
        'RAM MONITOR
        ramProgressbar.Value = PerformanceCounter2.NextValue
        ramUsageLBL.Text = ramProgressbar.Value.ToString + "%"
        'HARD DISK MONITOR
        Dim dvr As New DriveInfo(Environ("SystemDrive"))
        diskLbl.Text = (Int(My.Computer.FileSystem.GetDriveInfo(Environ("SystemDrive")).TotalFreeSpace / 1073741824) & " GB / 237 GB")
        diskProgressbar.Value = 87

    End Sub


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles systemInfoBTN.Click
        'System Information
        computernameTXTBX.Text = System.Environment.MachineName
        osTEXTBX.Text = My.Computer.Info.OSFullName
        platformTXTBX.Text = My.Computer.Info.OSPlatform
        userTXTBX.Text = System.Environment.UserName
        versionTXTBX.Text = My.Computer.Info.OSVersion
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Hide()
        cpuSubform.Show()

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.Hide()
        ramSubform.Show()

    End Sub

    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Me.Hide()
        SettingsForm.Show()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Me.Hide()
        HistoryForm.Show()
    End Sub


End Class
