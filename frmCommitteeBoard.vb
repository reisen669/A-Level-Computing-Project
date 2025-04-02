
Imports System.Data
Imports System.Data.OleDb

Public Class frmCommitteeBoard

    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
    Dim dataFile As String = "Beserah Primary School English Language Society Management System.accdb"
    Dim connString As String = provider & dataFile      'Path of database file
    Dim myConnection As New OleDbConnection             'Joins provider and path

    Dim dr As OleDbDataReader             'Data reader to read data from Access Database
    Dim validationFlag As Boolean = True
    Dim searchFlag As Boolean = False


    Sub StartConnection()
        'Connects the programme with the database
        myConnection.ConnectionString = connString
        myConnection.Open()
    End Sub

    Sub CloseConnection()
        'Closes the connection between the programme and the database
        myConnection.Close()
    End Sub

    Sub GenerateYear()
        'Automatically generates the year by taking the year of the input day
        txtYear.Text = Date.Now.Year
    End Sub

    Sub ClearFieldsOtherThanYear()
        'Clears all the fields except the year
        txtChiefAdvisor.Text = ""
        txtAdvisor1.Text = ""
        txtAdvisor2.Text = ""
        txtAdvisor3.Text = ""
        txtChairperson.Text = ""
        txtViceChairperson.Text = ""
        txtSecretary.Text = ""
        txtTreasurer.Text = ""
    End Sub

    Sub FocusCursor()
        'Focus cursor at the chief advisor text box
        txtChiefAdvisor.Focus()
    End Sub


    Private Sub txtChiefAdvisor_TextChanged(sender As Object, e As EventArgs) Handles txtChiefAdvisor.TextChanged
        ValidateChiefAdvisor()
    End Sub

    Private Sub txtAdvisor1_TextChanged(sender As Object, e As EventArgs) Handles txtAdvisor1.TextChanged
        ValidateAdvisor1()
    End Sub

    Private Sub txtAdvisor2_TextChanged(sender As Object, e As EventArgs) Handles txtAdvisor2.TextChanged
        ValidateAdvisor2()
    End Sub

    Private Sub txtAdvisor3_TextChanged(sender As Object, e As EventArgs) Handles txtAdvisor3.TextChanged
        ValidateAdvisor3()
    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged
        ValidateYear()
    End Sub


    Sub ValidateChiefAdvisor()
        'Chief advisor name cannot be too long, numbers are not allowed
        Dim length As Integer = txtChiefAdvisor.Text.Length
        Dim i As Integer = 0

        If length - 1 > 50 Then
            lblError.Text = "The chief advisor is too long! (>50 characters)"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If

        For i = 0 To length - 1
            If Asc(txtChiefAdvisor.Text.Substring(i, 1)) >= 48 And Asc(txtChiefAdvisor.Text.Substring(i, 1)) <= 57 Then
                lblError.Text = "Chief advisor cannot contain numbers!"
                lblError.Visible = True
                validationFlag = False
                Exit Sub
            Else
                validationFlag = True
                lblError.Visible = False
            End If
        Next
    End Sub

    Sub ValidateAdvisor1()
        'Advisor 1 name cannot be too long, numbers are not allowed
        Dim length As Integer = txtAdvisor1.Text.Length
        Dim i As Integer = 0

        If length - 1 > 50 Then
            lblError.Text = "The advisor 1 is too long! (>50 characters)"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If

        For i = 0 To length - 1
            If Asc(txtAdvisor1.Text.Substring(i, 1)) >= 48 And Asc(txtAdvisor1.Text.Substring(i, 1)) <= 57 Then
                lblError.Text = "Advisor 1 cannot contain numbers!"
                lblError.Visible = True
                validationFlag = False
                Exit Sub
            Else
                validationFlag = True
                lblError.Visible = False
            End If
        Next
    End Sub

    Sub ValidateAdvisor2()
        'Advisor 2 name cannot be too long, numbers are not allowed
        Dim length As Integer = txtAdvisor2.Text.Length
        Dim i As Integer = 0

        If length - 1 > 50 Then
            lblError.Text = "The advisor 2 is too long! (>50 characters)"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If

        For i = 0 To length - 1
            If Asc(txtAdvisor2.Text.Substring(i, 1)) >= 48 And Asc(txtAdvisor2.Text.Substring(i, 1)) <= 57 Then
                lblError.Text = "Advisor 2 cannot contain numbers!"
                lblError.Visible = True
                validationFlag = False
                Exit Sub
            Else
                validationFlag = True
                lblError.Visible = False
            End If
        Next
    End Sub

    Sub ValidateAdvisor3()
        'Advisor 3 name cannot be too long, numbers are not allowed
        Dim length As Integer = txtAdvisor3.Text.Length
        Dim i As Integer = 0

        If length - 1 > 50 Then
            lblError.Text = "The advisor 3 is too long! (>50 characters)"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If

        For i = 0 To length - 1
            If Asc(txtAdvisor3.Text.Substring(i, 1)) >= 48 And Asc(txtAdvisor3.Text.Substring(i, 1)) <= 57 Then
                lblError.Text = "Advisor 3 cannot contain numbers!"
                lblError.Visible = True
                validationFlag = False
                Exit Sub
            Else
                validationFlag = True
                lblError.Visible = False
            End If
        Next
    End Sub

    Sub ValidateYear()
        'Must be a valid, 4 digit year
        Dim length As Integer = txtYear.Text.Length
        Dim i As Integer = 0

        If (length <> 4) Then
            lblError.Text = "Year can only contain 4 digits!"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If

        If IsNumeric(txtYear.Text) = False Then
            lblError.Text = "Year must contain numbers!"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If
    End Sub

    Sub BlankField()
        'To ensure certain fields are not blank

        If txtYear.Text = "" Then
            lblBlank.Text = "Year cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

        If txtChiefAdvisor.Text = "" Then
            lblBlank.Text = "Chief advisor cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

        If txtAdvisor1.Text = "" Then
            lblBlank.Text = "Advisor 1 cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

        If txtAdvisor2.Text = "" Then
            lblBlank.Text = "Advisor 2 cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

        If txtAdvisor3.Text = "" Then
            lblBlank.Text = "Advisor 3 cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

    End Sub


    Private Sub frmCommitteeMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateYear()
        ClearFieldsOtherThanYear()
        FocusCursor()

        'The text boxes and error label are hidden from view when this form is loaded
        txtChairperson.Visible = False
        txtViceChairperson.Visible = False
        txtSecretary.Visible = False
        txtTreasurer.Visible = False
        lblError.Text = ""
        lblBlank.Text = ""
    End Sub


    Sub Chairperson()
        'Loads chairperson's name from the database

        StartConnection()
        Dim sql As String = "SELECT [Member Name] " & _
                            "FROM tblMemberRecord " & _
                            "WHERE (([Condition]='Active') AND ([Position]='Chairperson'))"
        Dim cmd As New OleDbCommand(sql, myConnection)
        dr = cmd.ExecuteReader

        While dr.Read()
            txtChairperson.Text = dr("Member Name").ToString
        End While

        CloseConnection()
    End Sub

    Sub ViceChairperson()
        'Loads vice chairperson's name from the database

        StartConnection()
        Dim sql As String = "SELECT [Member Name] " & _
                            "FROM tblMemberRecord " & _
                             "WHERE (([Condition]='Active') AND ([Position]='Vice Chairperson'))"
        Dim cmd As New OleDbCommand(sql, myConnection)
        dr = cmd.ExecuteReader

        While dr.Read()
            txtViceChairperson.Text = dr("Member Name").ToString
        End While

        CloseConnection()
    End Sub

    Sub Secretary()
        'Loads secretary's name from the database

        StartConnection()
        Dim sql As String = "SELECT [Member Name] " & _
                            "FROM tblMemberRecord " & _
                            "WHERE (([Condition]='Active') AND ([Position]='Secretary'))"
        Dim cmd As New OleDbCommand(sql, myConnection)
        dr = cmd.ExecuteReader

        While dr.Read()
            txtSecretary.Text = dr("Member Name").ToString
        End While

        CloseConnection()
    End Sub

    Sub Treasurer()
        'Loads treasurer's name from the database

        StartConnection()
        Dim sql As String = "SELECT [Member Name] " & _
                            "FROM tblMemberRecord " & _
                            "WHERE (([Condition]='Active') AND ([Position]='Treasurer'))"
        Dim cmd As New OleDbCommand(sql, myConnection)
        dr = cmd.ExecuteReader

        While dr.Read()
            txtTreasurer.Text = dr("Member Name").ToString
        End While

        CloseConnection()
    End Sub


    Sub SaveCommitteeBoard()
        'Adds committee members' records into database

        StartConnection()
        Dim sql As String = "INSERT INTO tblCommitteeBoard([Chief Advisor], [Advisor 1], [Advisor 2], [Advisor 3], [Year], " & _
                            "[Chairperson], [Vice Chairperson], [Secretary], [Treasurer]) " & _
                            "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Dim cmd As New OleDbCommand(sql, myConnection)

        With cmd.Parameters
            .Add(New OleDbParameter("[Chief Advisor]", CType(txtChiefAdvisor.Text, String)))
            .Add(New OleDbParameter("[Advisor 1]", CType(txtAdvisor1.Text, String)))
            .Add(New OleDbParameter("[Advisor 2]", CType(txtAdvisor2.Text, String)))
            .Add(New OleDbParameter("[Advisor 3]", CType(txtAdvisor3.Text, String)))
            .Add(New OleDbParameter("[Year]", CType(txtYear.Text, Integer)))
            .Add(New OleDbParameter("[Chairperson]", CType(txtChairperson.Text, String)))
            .Add(New OleDbParameter("[Vice Chairperson]", CType(txtViceChairperson.Text, String)))
            .Add(New OleDbParameter("[Secretary]", CType(txtSecretary.Text, String)))
            .Add(New OleDbParameter("[Treasurer]", CType(txtTreasurer.Text, String)))
        End With

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        CloseConnection()
        ClearFieldsOtherThanYear()
        FocusCursor()
        txtYear.Text = ""
        GenerateYear()
        lblError.Text = ""
        lblBlank.Text = ""
    End Sub

    Sub SearchCommitteeBoard()
        'Searches a specific year's committee board in the database 

        ClearFieldsOtherThanYear()
        txtYear.Text = ""

        StartConnection()
        'Pops out an input box to enter the specific year
        Dim Year As Integer = CInt(InputBox("Enter year: ", "Search Committee Board"))
        Dim sql As String = "SELECT * FROM tblCommitteeBoard " & _
                            "WHERE [Year]=" & Year
        Dim cmd As New OleDbCommand(sql, myConnection)
        dr = cmd.ExecuteReader

        'Fills up the information of the committee board
        While dr.Read()
            txtYear.Text = Year
            txtChiefAdvisor.Text = dr("Chief Advisor").ToString
            txtAdvisor1.Text = dr("Advisor 1").ToString
            txtAdvisor2.Text = dr("Advisor 2").ToString
            txtAdvisor3.Text = dr("Advisor 3").ToString
            txtChairperson.Text = dr("Chairperson").ToString
            txtViceChairperson.Text = dr("Vice Chairperson").ToString
            txtSecretary.Text = dr("Secretary").ToString
            txtTreasurer.Text = dr("Treasurer").ToString

            searchFlag = True
        End While

        If searchFlag = False Then
            MsgBox("Year " & Year & " not found!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error")
        End If

        CloseConnection()
    End Sub

    Sub UpdateCommitteeBoard()
        'Updates a year's committee member record in the database

        StartConnection()
        Dim Year As Integer = CInt(txtYear.Text)
        Dim sql As String = "UPDATE tblCommitteeBoard " & _
                            "SET [Chief Advisor]='" & txtChiefAdvisor.Text & "'," & _
                            "[Advisor 1]='" & txtAdvisor1.Text & "'," & _
                            "[Advisor 2]='" & txtAdvisor2.Text & "'," & _
                            "[Advisor 3]='" & txtAdvisor3.Text & "' " & _
                            "WHERE [Year]=" & Year
        Dim cmd As New OleDbCommand(sql, myConnection)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        CloseConnection()
        ClearFieldsOtherThanYear()
        FocusCursor()
        txtYear.Text = ""
        GenerateYear()
        lblError.Text = ""
        lblBlank.Text = ""
    End Sub


    Private Sub lnkPrint_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkPrint.LinkClicked
        'Print preview with the link labels, buttons and error labels hidden
        lnkPrint.Hide()
        lnkHelp.Hide()
        btnMainMenu.Hide()
        btnSave.Hide()
        btnSearch.Hide()
        btnUpdate.Hide()
        btnClear.Hide()
        lblBlank.Hide()
        lblError.Hide()

        prtCommitteeBoard.PrintAction = Printing.PrintAction.PrintToPreview

        'Print action
        prtCommitteeBoard.Print()

        'Allows the link labels, buttons and error labels to show again
        lnkPrint.Show()
        lnkHelp.Show()
        btnMainMenu.Show()
        btnSave.Show()
        btnSearch.Show()
        btnUpdate.Show()
        btnClear.Show()
        lblBlank.Show()
        lblError.Show()
    End Sub

    Private Sub lnkHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkHelp.LinkClicked
        'Opens the index of help page
        System.Diagnostics.Process.Start("Help\Index.htm")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Saves committee board details into database after validation

        BlankField()

        If validationFlag = True Then
            Chairperson()
            ViceChairperson()
            Secretary()
            Treasurer()

            SaveCommitteeBoard()
            MsgBox("Committee board added successfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Success")
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchCommitteeBoard()

        'Allows the contents of text boxes to be displayed
        txtChairperson.Visible = True
        txtViceChairperson.Visible = True
        txtSecretary.Visible = True
        txtTreasurer.Visible = True
        lblError.Text = ""
        lblBlank.Text = ""
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        'Closes the committee board form and opens the main menu
        Me.Hide()
        frmMainMenu.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFieldsOtherThanYear()
        FocusCursor()
        txtYear.Text = ""
        GenerateYear()
        lblError.Text = ""
        lblBlank.Text = ""
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Updates committee board details into database after validation

        BlankField()

        If validationFlag = True Then
            Chairperson()
            ViceChairperson()
            Secretary()
            Treasurer()

            UpdateCommitteeBoard()
            MsgBox("Committee board updated successfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Success")
        End If
    End Sub

End Class