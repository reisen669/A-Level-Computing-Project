
Imports System.Data
Imports System.Data.OleDb

Public Class frmPresentList
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
    Dim dataFile As String = "Beserah Primary School English Language Society Management System.accdb"
    Dim connString As String = provider & dataFile      'Path of database file
    Dim myConnection As New OleDbConnection             'Joins provider and path

    Dim dr As OleDbDataReader             'Data reader to read data from Access Database

    Dim validationFlag As Boolean = True
    Dim searchFlag As Boolean = False
    Dim EventID As Integer

    Sub StartConnection()
        'Connects the programme with the database
        myConnection.ConnectionString = connString
        myConnection.Open()
    End Sub

    Sub CloseConnection()
        'Closes the connection between the programme and the database
        myConnection.Close()
    End Sub

   
    Private Sub frmPresentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchForEvent()
    End Sub

    Sub SearchForEvent()
        'Searches for the present list of a specific event in the database through the event ID and displays its information

        StartConnection()
        EventID = CInt(InputBox("Event ID: ", "Search for present list of event"))
        Dim sql As String = "SELECT tblEventAttendance.[Event ID], tblEventRecord.[Event Name], tblEventRecord.[Event Venue], " & _
                            "tblEventRecord.[Event Date], tblEventAttendance.[Member ID], tblMemberRecord.[Member Name], " & _
                            "tblEventAttendance.Attendance FROM tblMemberRecord INNER JOIN (tblEventRecord INNER JOIN " & _
                            "tblEventAttendance ON tblEventRecord.[Event ID] = tblEventAttendance.[Event ID]) ON " & _
                            "tblMemberRecord.[Member ID] = tblEventAttendance.[Member ID]" & _
                            "WHERE (((tblEventAttendance.[Event ID])=" & EventID & ") AND ((tblEventAttendance.Attendance)='1')) " & _
                            "ORDER BY tblEventAttendance.[Member ID]"
        Dim cmd As New OleDbCommand(sql, myConnection)
        dr = cmd.ExecuteReader

        While dr.Read()
            lblEventNameAndID.Text = dr("Event Name").ToString & " ( ID: " & dr("Event ID").ToString & " )"
            lblEventDate.Text = dr("Event Date").ToShortDateString
            lblEventVenue.Text = dr("Event Venue").ToString
            dgvPresentList.Rows.Add(dr("Member ID").ToString, dr("Member Name").ToString)
        End While

        CloseConnection()
    End Sub


    Private Sub lnkPrint_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkPrint.LinkClicked
        'Print preview with the link labels and button hidden
        lnkPrint.Hide()
        lnkHelp.Hide()
        btnMainMenu.Hide()
        prtPresentList.PrintAction = Printing.PrintAction.PrintToPreview

        'Print action
        prtPresentList.Print()

        'Allows the link labels and button to show again
        lnkPrint.Show()
        lnkHelp.Show()
        btnMainMenu.Show()
    End Sub

    Private Sub lnkHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkHelp.LinkClicked
        'Opens the index of help page
        System.Diagnostics.Process.Start("Help\Index.htm")
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        'Closes the present list form and opens the main menu
        Me.Hide()
        frmMainMenu.Show()
    End Sub

End Class