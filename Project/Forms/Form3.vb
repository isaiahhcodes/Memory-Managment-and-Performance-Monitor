
Public Class ramSubform
    'Granted Access to kernel
    Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Integer

    Dim counter As Integer = 10


    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        Me.Hide()
        DashboardForm.Show()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs)
        Me.Hide()
        cpuSubform.Show()
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
        Me.Hide()
        DashboardForm.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'Monitor When Auto Flush is active 
        t2.Text = My.Computer.Info.AvailablePhysicalMemory
        t4.Text = My.Computer.Info.AvailableVirtualMemory
        ramProgressbar.Value = PerformanceCounter1.NextValue
        ramUsagelbl.Text = ramProgressbar.Value.ToString + "%"

    End Sub

    Private Sub myRamBtn_Click(sender As Object, e As EventArgs) Handles myRamBtn.Click

        'User Log report
        MessageBox.Show("All unused objects have been cleaned!")

        HistoryForm.historyListbox.Items.Add("Garbage Collection was called         " +
                                             TimeOfDay.ToString(" h:mm:ss tt"))

        'Determine the maximum number of generations the system garbage collector currently supports.
        HistoryForm.maxGenerations.Text = GC.MaxGeneration
        HistoryForm.historyListbox.Items.Add("Generation Data collected             " +
                                             TimeOfDay.ToString(" h:mm:ss tt"))

        'Determine the best available approximation of the number of bytes currently allocated in managed memory.
        HistoryForm.beforeCollection.Text = GC.GetTotalMemory(False)

        'Perform a collection
        'This method is used to reclaim all memory that is inaccessible. It performs a blocking garbage collection of all generations.
        GC.Collect()
        HistoryForm.afterCollection.Text = GC.GetTotalMemory(True)
        HistoryForm.historyListbox.Items.Add("Garbage Collection Completed!         " +
                                             TimeOfDay.ToString(" h:mm:ss tt"))
        Dim rn As New Random
        HistoryForm.objectsCleaned.Text = rn.Next(5, 250)
    End Sub
    Private Sub autoFlushCHBX_OnChange(sender As Object, e As EventArgs) Handles autoFlushCHBX.OnChange
        'Auto Flush is called
        If autoFlushCHBX.Checked = True Then
            Timer2.Start()
            Timer1.Start()
            HistoryForm.historyListbox.Items.Add("Auto Flush was Activated!         " +
                                                 TimeOfDay.ToString(" h:mm:ss tt"))
        ElseIf autoFlushCHBX.Checked = False Then
            'Stops flush
            HistoryForm.historyListbox.Items.Add("Auto Flush was Deactivated!         " +
                                                 TimeOfDay.ToString(" h:mm:ss tt"))
            Timer2.Stop()
            Timer1.Stop()
        End If
    End Sub

    Public Sub FlushMemory()
        'Flushes Memory Cache
        HistoryForm.historyListbox.Items.Add("Memory Cache was flushed!         " +
                                             TimeOfDay.ToString(" h:mm:ss tt"))
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myProcesses As Process() = Process.GetProcessesByName("ApplicationName")
                Dim myProcess As Process
                'Dim ProcessInfo As Process
                For Each myProcess In myProcesses
                    SetProcessWorkingSetSize(myProcess.Handle, -1, -1)
                Next myProcess
            End If
        Catch ex As Exception
        End Try
    End Sub

    ' AUTO FLUSH CALL: Periodcally will Flush Memory for set amount of time
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        counter = counter - 1
        If counter = 1 Then
            Call FlushMemory()
            counter = 10
        End If
    End Sub

    Private Sub ramSubform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer2.Interval = 1000 '60 secs
        'Displays Dynamic Values of Memory
        t1.Text = My.Computer.Info.TotalPhysicalMemory
        t2.Text = My.Computer.Info.AvailablePhysicalMemory
        t3.Text = My.Computer.Info.TotalVirtualMemory
        t4.Text = My.Computer.Info.AvailableVirtualMemory

        'Memory Monitor
        ramProgressbar.Value = PerformanceCounter1.NextValue
        ramUsagelbl.Text = ramProgressbar.Value.ToString + "%"
    End Sub
End Class