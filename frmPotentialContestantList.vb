
Imports System.Data
Imports System.Data.OleDb

Public Class frmPotentialContestantList
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
    Dim dataFile As String = "Beserah Primary School English Language Society Management System.accdb"
    Dim connString As String = provider & dataFile      'Path of database file
    Dim myConnection As New OleDbConnection             'Joins provider and path

    Dim dr As OleDbDataReader             'Data reader to read data from Access Database


    Sub StartConnection()
        'Connects the programme with the database
        myConnection.ConnectionString = connString
        myConnection.Open()
    End Sub

    Sub CloseConnection()
        'Closes the connection between the programme and the database
        myConnection.Close()
    End Sub


    Private Sub frmPotentialContestant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Searches a specific member in the database through its ID and then displays it

        StartConnection()
        Dim sql As String = "SELECT tblMemberRecord.[Highest English Grade], tblMemberRecord.[Potential Contestant], " & _
                            "tblMemberRecord.[Member Name], tblMemberRecord.[Member ID] FROM tblMemberRecord " & _
                            "WHERE (tblMemberRecord.[Potential Contestant]='Potential Contestant') " & _
                            "ORDER BY tblMemberRecord.[Highest English Grade], tblMemberRecord.[Member ID]"
        Dim cmd As New OleDbCommand(sql, myConnection)
        dr = cmd.ExecuteReader

        While dr.Read()
            dgvPotentialContestantList.Rows.Add(dr("Highest English Grade").ToString, dr("Member ID").ToString, dr("Member Name").ToString)
        End While

        CloseConnection()
    End Sub


    Private Sub lnkPrint_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkPrint.LinkClicked
        'Print preview with the link labels and button hidden
        lnkPrint.Hide()
        lnkHelp.Hide()
        btnMainMenu.Hide()
        prtPotentialContestant.PrintAction = Printing.PrintAction.PrintToPreview

        'Print action
        prtPotentialContestant.Print()

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
        'Closes the potential contestant list form and opens main menu
        Me.Hide()
        frmMainMenu.Show()
    End Sub

End Class