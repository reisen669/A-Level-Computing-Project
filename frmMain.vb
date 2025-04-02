Public Class frmMainMenu
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Displays simple instructions when pointed
        With ToolTip1
            .SetToolTip(btnMemberRecord, "Opens member record form")
            .SetToolTip(btnEventRecord, "Opens event record form")
            .SetToolTip(btnCommitteeBoard, "Opens committee board form")
            .SetToolTip(btnPresentList, "Lists out the present members in a specific event")
            .SetToolTip(btnPotentialContestants, "Lists out the active members who have high english grades and are listed as potential contestants")
        End With
    End Sub

    Private Sub btnMemberRecord_Click(sender As Object, e As EventArgs) Handles btnMemberRecord.Click
        'Closes the main menu and opens the member record form
        Me.Hide()
        frmMemberRecord.Show()
    End Sub

    Private Sub btnEventRecord_Click(sender As Object, e As EventArgs) Handles btnEventRecord.Click
        'Closes the main menu and opens the event record form
        Me.Hide()
        frmEventRecord.Show()
    End Sub

    Private Sub btnCommitteeBoard_Click(sender As Object, e As EventArgs) Handles btnCommitteeBoard.Click
        'Closes the main menu and opens committee board form
        Me.Hide()
        frmCommitteeBoard.Show()
    End Sub

    Private Sub btnPresentList_Click(sender As Object, e As EventArgs) Handles btnPresentList.Click
        'Closes the main menu and opens the present list form
        Me.Hide()
        frmPresentList.Show()
    End Sub

    Private Sub btnPotentialContestants_Click(sender As Object, e As EventArgs) Handles btnPotentialContestants.Click
        'Closes the main menu and opens the potential contestant list form
        Me.Hide()
        frmPotentialContestantList.Show()
    End Sub

    Private Sub lnkHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkHelp.LinkClicked
        'Opens the index of help page
        System.Diagnostics.Process.Start("Help\Index.htm")
    End Sub
End Class
