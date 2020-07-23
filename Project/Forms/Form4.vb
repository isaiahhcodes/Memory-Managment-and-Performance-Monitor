Public Class HistoryForm
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

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs)
        Me.Hide()
        SettingsForm.Show()
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click
        Me.Hide()
        DashboardForm.Show()
    End Sub
End Class