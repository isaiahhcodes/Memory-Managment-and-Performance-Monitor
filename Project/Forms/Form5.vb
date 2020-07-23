Public Class SettingsForm
    'Scanner Button If statment
    Dim btnScanClicked As Boolean = False
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        Me.Hide()
        DashboardForm.Show()
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

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click
        Me.Hide()
        DashboardForm.Show()

    End Sub

    'Scans temporary files, Temp cache, Internet Cache, Downloads Files (Memory Hogs)
    Private Sub Scan()
        HistoryForm.historyListbox.Items.Add("System Scan Completed!         " +
                                             TimeOfDay.ToString(" h:mm:ss tt"))
        lblComplete.Visible = True
        ListView1.View = View.Details
        ListView1.Columns.Add("Filename")
        ListView1.Columns.Add("Size")
        ListView1.Columns.Add("Creation date")
        For Each file In FileIO.FileSystem.GetFiles("C:\Users\offic\Downloads")
            Dim item As ListViewItem = ListView1.Items.Add(FileIO.FileSystem.GetName(file))
            item.SubItems.Add(FileIO.FileSystem.GetFileInfo(file).Length)
            item.SubItems.Add(FileIO.FileSystem.GetFileInfo(file).CreationTime)
        Next
        For Each column As ColumnHeader In ListView1.Columns
            column.Width = -1
        Next
    End Sub

    'File Deletion Method
    Private Sub Delete()

        HistoryForm.historyListbox.Items.Add("File Deletion Completed!         " +
                                             TimeOfDay.ToString(" h:mm:ss tt"))
        Dim directory As New IO.DirectoryInfo("C:\Users\offic\Downloads")

        For Each file As IO.FileInfo In directory.GetFiles
            file.Delete()
        Next
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click

        'Refresh Scan Method
        If btnScanClicked = True Then
            Timer1.Start()
        Else
            ListView1.Clear()
            lblComplete.Visible = False
            scanBar.Value = 0
            Timer1.Start()
        End If

    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        'Call method for Delete
        Call Delete()
        ListView1.Clear()
        lblFilesCleaned.Visible = True
        lblComplete.Visible = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Call method for scanner
        scanBar.Increment(10)
        If scanBar.Value = 100 Then
            Timer1.Stop()
            Call Scan()
        End If
    End Sub
End Class