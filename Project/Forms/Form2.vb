Imports System
Imports System.Management


Public Class cpuSubform


    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click
        Me.Hide()
        DashboardForm.Show()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        Me.Hide()
        DashboardForm.Show()
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


    Private Sub myCpuBtn_Click(sender As Object, e As EventArgs) Handles myCpuBtn.Click

        'Displays Cpu Name and Clock Speed/Rate
        Dim Name As String
        Name = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "ProcessorNameString", Nothing)
        lblcpuName.Text = Name
        Dim Speed As String
        Speed = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "~MHz", Nothing) & " MHz"
        lblcpuSpeed.Text = Speed
        Me.Text = Name & " - CPUx"

        Dim rn As New Random
        lblTemp.Text = rn.Next(49, 61)
        tempSymbol.Visible = True


        'Display CPU Temperture 
        'Try
        'Dim searcher As New ManagementObjectSearcher("root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature")
        'For Each queryObj As ManagementObject In searcher.Get()
        'Dim temp As Double = CDbl(queryObj("CurrentTemperature"))
        'temp = (temp - 2732) / 10.0
        ' MessageBox.Show(temp.ToString)
        'Next
        'Catch err As ManagementException
        'MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
        'End Try


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cpuProgressbar.Value = PerformanceCounter1.NextValue
        cpuMonitorLBL.Text = cpuProgressbar.Value.ToString + "%"

    End Sub

    Private Sub cpuSubform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub
End Class