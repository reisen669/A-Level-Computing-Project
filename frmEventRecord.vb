
Imports System.Data
Imports System.Data.OleDb

Public Class frmEventRecord

    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
    Dim dataFile As String = "Beserah Primary School English Language Society Management System.accdb"
    Dim connString As String = provider & dataFile      'Path of database file
    Dim myConnection As New OleDbConnection             'Joins provider and path

    Dim dr As OleDbDataReader             'Data reader to read data from Access Database

    Dim validationFlag As Boolean = False
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

    Sub GenerateEventID()
        'The programme finds the maximum event ID from the database and adds 1 to it to generate the new event ID

        StartConnection()
        Dim sql As String = "SELECT MAX([Event ID]) As [MAX] FROM tblEventRecord"
        Dim cmd As New OleDbCommand(sql, myConnection)
        dr = cmd.ExecuteReader

        While dr.Read()
            If dr("Max").ToString = "" Then
                txtEventID.Text = "1101"
            Else
                txtEventID.Text = ((dr("MAX")) + 1).ToString
            End If
        End While

        CloseConnection()
    End Sub

    Sub ClearFields()
        'Clear all the fields
        txtEventID.Text = ""
        txtEventName.Text = ""
        txtEventVenue.Text = ""
        dtpEventDate.Text = Date.Now
        txtEventLevel.Text = ""
        txtEventChiefAdvisor.Text = ""
        txtEventAdvisor.Text = ""
        txtRemark.Text = ""
    End Sub

    Sub FocusCursor()
        'Focus cursor at the event name text box
        txtEventName.Focus()
    End Sub


    Private Sub txtEventName_TextChanged(sender As Object, e As EventArgs) Handles txtEventName.TextChanged
        ValidateEventName()
    End Sub

    Private Sub txtEventVenue_TextChanged(sender As Object, e As EventArgs) Handles txtEventVenue.TextChanged
        ValidateEventVenue()
    End Sub

    Private Sub txtEventLevel_TextChanged(sender As Object, e As EventArgs) Handles txtEventLevel.TextChanged
        ValidateEventLevel()
    End Sub

    Private Sub txtEventChiefAdvisor_TextChanged(sender As Object, e As EventArgs) Handles txtEventChiefAdvisor.TextChanged
        ValidateEventChiefAdvisor()
    End Sub

    Private Sub txtEventAdvisor_TextChanged(sender As Object, e As EventArgs) Handles txtEventAdvisor.TextChanged
        ValidateEventAdvisor()
    End Sub

    Private Sub txtRemark_TextChanged(sender As Object, e As EventArgs) Handles txtRemark.TextChanged
        ValidateRemark()
    End Sub


    Sub ValidateEventName()
        'Event name cannot be too long
        Dim length As Integer = txtEventName.Text.Length

        If length > 30 Then
            lblError.Text = "The event name is too long! (>30 characters)"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If
    End Sub

    Sub ValidateEventVenue()
        'Event venue cannot be too long
        Dim length As Integer = txtEventVenue.Text.Length

        If length > 30 Then
            lblError.Text = "The event venue is too long! (>30 characters)"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If
    End Sub

    Sub ValidateEventLevel()
        'Event level cannot be too long, numbers are not allowed
        Dim length As Integer = txtEventLevel.Text.Length
        Dim i As Integer = 0

        If length > 20 Then
            lblError.Text = "The event level is too long! (>20 characters)"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If

        For i = 0 To length - 1
            If Asc(txtEventLevel.Text.Substring(i, 1)) >= 48 And Asc(txtEventLevel.Text.Substring(i, 1)) <= 57 Then
                lblError.Text = "Event level cannot contain numbers!"
                lblError.Visible = True
                validationFlag = False
                Exit Sub
            Else
                validationFlag = True
                lblError.Visible = False
            End If
        Next
    End Sub

    Sub ValidateEventChiefAdvisor()
        'Event chief advisor cannot be too long, numbers are not allowed
        Dim length As Integer = txtEventChiefAdvisor.Text.Length
        Dim i As Integer = 0

        If length > 50 Then
            lblError.Text = "The event chief advisor is too long! (>50 characters)"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If

        For i = 0 To length - 1
            If Asc(txtEventChiefAdvisor.Text.Substring(i, 1)) >= 48 And Asc(txtEventChiefAdvisor.Text.Substring(i, 1)) <= 57 Then
                lblError.Text = "Event chief advisor cannot contain numbers!"
                lblError.Visible = True
                validationFlag = False
                Exit Sub
            Else
                validationFlag = True
                lblError.Visible = False
            End If
        Next
    End Sub

    Sub ValidateEventAdvisor()
        'Event advisor cannot be too long, numbers are not allowed
        Dim length As Integer = txtEventAdvisor.Text.Length
        Dim i As Integer = 0

        If length > 50 Then
            lblError.Text = "The event advisor is too long! (>50 characters)"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If

        For i = 0 To length - 1
            If Asc(txtEventAdvisor.Text.Substring(i, 1)) >= 48 And Asc(txtEventAdvisor.Text.Substring(i, 1)) <= 57 Then
                lblError.Text = "Event advisor cannot contain numbers!"
                lblError.Visible = True
                validationFlag = False
                Exit Sub
            Else
                validationFlag = True
                lblError.Visible = False
            End If
        Next
    End Sub

    Sub ValidateRemark()
        'Remark cannot be too long
        Dim length As Integer = txtRemark.Text.Length

        If length > 100 Then
            lblError.Text = "The remark is too long! (>100 characters)"
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

        If txtEventID.Text = "" Then
            lblBlank.Text = "Event ID cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

        If txtEventName.Text = "" Then
            lblBlank.Text = "Event name cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

        If txtEventVenue.Text = "" Then
            lblBlank.Text = "Event venue cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

        If txtEventLevel.Text = "" Then
            lblBlank.Text = "Event level cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

        If txtEventChiefAdvisor.Text = "" Then
            lblBlank.Text = "Event chief advisor cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

        If txtEventAdvisor.Text = "" Then
            lblBlank.Text = "Event advisor cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If
    End Sub


    Private Sub frmEventRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On loading, a connection is opened to connect VB and MS Access

        'Displays simple instructions when pointed
        With ToolTip1
            .SetToolTip(txtEventID, "Enter the event ID (e.g. EV1029)")
            .SetToolTip(txtEventName, "Enter the name of event (e.g. Mr Tack Tan)")
            .SetToolTip(txtEventVenue, "Enter the venue of event (e.g. School hall)")
            .SetToolTip(dtpEventDate, "Select the date of event (e.g. 10/10/2014)")
            .SetToolTip(txtEventLevel, "Enter the level of event (e.g. International)")
            .SetToolTip(txtEventChiefAdvisor, "Enter the name of chief advisor of the event (e.g. Mrs Amirah Haida bt Ahmad Azmi)")
            .SetToolTip(txtEventAdvisor, "Enter the name of advisor of the event (e.g. Mrs Lee Yin Man)")
            .SetToolTip(txtRemark, "Enter the remark of this event (e.g. time, duration and detail of the event)")
            .SetToolTip(btnClear, "Clears all the fields under the event heading")
            .SetToolTip(btnInsert, "Creates a new event record in the database")
            .SetToolTip(btnInsert, "Updates an existing event record in the database")
            .SetToolTip(btnSearch, "Searches for a specific event in the database")
            .SetToolTip(btnDelete, "Deletes an event record from database")
            .SetToolTip(btnMainMenu, "Go to the main menu")
            .SetToolTip(lstMemberList, "List of members who were absent in an event")
            .SetToolTip(lstPresentList, "List of members who were present in an event")
        End With

        ClearFields()
        FocusCursor()
        GenerateEventID()            'The event ID is loaded automatically 
        ClearListBoxes()
        LoadMemberList()             'The member list is loaded automatically
        lblError.Visible = False     'Makes the error label invisible to the user when this form is loaded
        lblBlank.Visible = False     'Makes the blank label invisible to the user when this form is loaded
    End Sub


    Sub InsertNewEvent()
        'Adds new event record into database

        StartConnection()
        Dim sql As String = "INSERT INTO tblEventRecord([Event ID], [Event Name], [Event Venue], [Event Date], [Event Level], " & _
                            "[Event Chief Advisor], [Event Advisor], [Remark]) " & _
                            "VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Dim cmd As New OleDbCommand(sql, myConnection)

        With cmd.Parameters
            .Add(New OleDbParameter("[Event ID]", CType(txtEventID.Text, Integer)))
            .Add(New OleDbParameter("[Event Name]", CType(txtEventName.Text, String)))
            .Add(New OleDbParameter("[Event Venue]", CType(txtEventVenue.Text, String)))
            .Add(New OleDbParameter("[Event Date]", CType(dtpEventDate.Text, Date)))
            .Add(New OleDbParameter("[Event Level]", CType(txtEventLevel.Text, String)))
            .Add(New OleDbParameter("[Event Chief Advisor]", CType(txtEventChiefAdvisor.Text, String)))
            .Add(New OleDbParameter("[Event Advisor]", CType(txtEventAdvisor.Text, String)))
            .Add(New OleDbParameter("[Remark]", CType(txtRemark.Text, String)))
        End With

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        CloseConnection()
        ClearFields()
        FocusCursor()
        GenerateEventID()
        ClearListBoxes()
        LoadMemberList()
    End Sub

    Sub UpdateEvent()
        'Updates a specific event record in the database

        StartConnection()
        Dim EventID As Integer = CInt(txtEventID.Text)
        Dim sql As String = "UPDATE tblEventRecord " & _
                            "SET [Event Name]='" & txtEventName.Text & "'," & _
                            "[Event Venue]='" & txtEventVenue.Text & "'," & _
                            "[Event Date]='" & dtpEventDate.Text & "'," & _
                            "[Event Level]='" & txtEventLevel.Text & "'," & _
                            "[Event Chief Advisor]='" & txtEventChiefAdvisor.Text & "'," & _
                            "[Event Advisor]='" & txtEventAdvisor.Text & "'," & _
                            "[Remark]='" & txtRemark.Text & "' " & _
                            "WHERE [Event ID]=" & EventID
        Dim cmd As New OleDbCommand(sql, myConnection)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        CloseConnection()
        ClearFields()
        FocusCursor()
        GenerateEventID()
        ClearListBoxes()
        LoadMemberList()
    End Sub

    Sub SearchEvent()
        'Searches for a specific event in the database through its ID and displays its information

        StartConnection()

        'Pops out an input box to enter the specific event's ID
        Dim EventID As Integer = CInt(InputBox("Enter Event ID: ", "Search Event"))
        Dim sql As String = "SELECT * FROM tblEventRecord " & _
                            "WHERE [Event ID]=" & EventID
        Dim cmd As New OleDbCommand(sql, myConnection)
        dr = cmd.ExecuteReader

        'Fills up the information about the event
        While dr.Read()
            txtEventID.Text = dr("Event ID").ToString
            txtEventName.Text = dr("Event Name").ToString
            txtEventVenue.Text = dr("Event Venue").ToString
            dtpEventDate.Text = dr("Event Date").ToString
            txtEventLevel.Text = dr("Event Level").ToString
            txtEventChiefAdvisor.Text = dr("Event Chief Advisor").ToString
            txtEventAdvisor.Text = dr("Event Advisor").ToString
            txtRemark.Text = dr("Remark").ToString

            searchFlag = True
        End While

        If searchFlag = False Then
            MsgBox("Event ID " & EventID & " not found!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error")
        End If

        CloseConnection()
    End Sub

    Sub DeleteEvent()
        'Deletes an event record from the database based on the event ID

        StartConnection()
        Dim EventID As Integer = CInt(txtEventID.Text)
        Dim sql As String = "SELECT tblEventRecord.[Event ID] FROM tblEventRecord INNER JOIN tblEventAttendance ON " & _
                            "tblEventRecord.[Event ID] = tblEventAttendance.[Event ID]" & _
                            "WHERE (((tblEventRecord.[Event ID])=" & EventID & "))"

        Dim cmd As New OleDbCommand(sql, myConnection)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        CloseConnection()
        ClearFields()
        FocusCursor()
        GenerateEventID()
        ClearListBoxes()
        LoadMemberList()
    End Sub


    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        'Saves event details into database after validation

        BlankField()

        If validationFlag = True Then
            InsertNewEvent()
            MsgBox("Event record added successfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Success")
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Updates event details in database after validation

        BlankField()

        If validationFlag = True Then
            UpdateEvent()
            MsgBox("Event record updated successfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Success")
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchEvent()

        'If the event exists in the database then searches for the attendance of that event
        If searchFlag = True Then
            SearchAttendance()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
        FocusCursor()
        GenerateEventID()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtEventID.Text = "" Then
            MsgBox("Please enter the event ID whose record is to be deleted!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        'Prompts out a message box to confirm deletion, deletes the specific event record if deletion is confirmed
        If MsgBox("Are you sure you want to delete this record?", _
                  MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Confirmation") = MsgBoxResult.Yes Then
            DeleteEvent()
            MsgBox("Event record deleted successfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Success")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        'Closes the event record form and opens main menu
        Me.Hide()
        frmMainMenu.Show()
    End Sub


    Sub ClearListBoxes()
        'clear member and present lists
        lstMemberList.Items.Clear()
        lstPresentList.Items.Clear()
    End Sub

    Sub LoadMemberList()
        'Loads a list of member IDs and their names 
        'To allow attendance to be taken

        StartConnection()
        Dim sql As String = "SELECT tblMemberRecord.[Member ID], tblMemberRecord.[Member Name], tblMemberRecord.Condition " & _
                            "FROM tblMemberRecord WHERE(((tblMemberRecord.Condition) = 'Active')) ORDER BY tblMemberRecord.[Member ID]"
        Dim cmd As New OleDbCommand(sql, myConnection)
        dr = cmd.ExecuteReader

        'Fills up list box with the names and IDs of the members
        While dr.Read()
            lstMemberList.Items.Add(dr("Member ID").ToString & " " & _
                                    dr("Member Name").ToString)
        End While

        CloseConnection()
    End Sub


    Sub InsertNewAttendance()
        'Adds attendances of an event into database

        StartConnection()
        Dim sql As String
        Dim i As Integer = 0
        Dim PresentMemberID As Integer
        Dim AbsentMemberID As Integer
        Dim Present As String = "1"            'Sets the value for presence
        Dim Absent As String = ""              'Sets the value for absence

        For i = 0 To lstPresentList.Items.Count - 1
            'Extract the member IDs from the list box 
            PresentMemberID = CInt(lstPresentList.Items.Item(i).ToString.Substring(0, 5))

            sql = "INSERT INTO tblEventAttendance([Event ID], [Member ID], [Attendance]) VALUES (?, ?, ?)"
            Dim cmd As New OleDbCommand(sql, myConnection)

            With cmd.Parameters
                .Add(New OleDbParameter("[Event ID]", CType(txtEventID.Text, Integer)))
                .Add(New OleDbParameter("[Member ID]", CType(PresentMemberID, Integer)))
                .Add(New OleDbParameter("[Attendance]", CType(Present, String)))
            End With

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Next

        For i = 0 To lstMemberList.Items.Count - 1
            'Extract the member IDs from the list box 
            AbsentMemberID = CInt(lstMemberList.Items.Item(i).ToString.Substring(0, 5))

            sql = "INSERT INTO tblEventAttendance([Event ID], [Member ID], [Attendance]) VALUES (?, ?, ?)"
            Dim cmd As New OleDbCommand(sql, myConnection)

            With cmd.Parameters
                .Add(New OleDbParameter("[Event ID]", CType(txtEventID.Text, Integer)))
                .Add(New OleDbParameter("[Member ID]", CType(AbsentMemberID, Integer)))
                .Add(New OleDbParameter("[Attendance]", CType(Absent, String)))
            End With

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

        CloseConnection()
        ClearFields()
        FocusCursor()
        GenerateEventID()
        ClearListBoxes()
        LoadMemberList()
    End Sub

    Sub SearchAttendance()
        'Searches a specific event's attendance in the database through its ID and displays its information

        ClearListBoxes()
        LoadMemberList()
        StartConnection()
        Dim EventID As Integer = CInt(txtEventID.Text)
        Dim sql As String = "SELECT tblEventAttendance.[Event ID], tblEventAttendance.[Member ID], tblEventAttendance.Attendance, " & _
                            "tblMemberRecord.[Member Name] FROM tblMemberRecord INNER JOIN tblEventAttendance " & _
                            "ON tblMemberRecord.[Member ID] = tblEventAttendance.[Member ID]" & _
                            "WHERE (((tblEventAttendance.[Event ID])=" & EventID & _
                            ")) ORDER BY tblEventAttendance.[Member ID]"
        Dim cmd As New OleDbCommand(sql, myConnection)
        dr = cmd.ExecuteReader

        'If a member was present in the event, then move the member to the present list 
        While dr.Read()
            If dr("Attendance").ToString = "1" Then
                lstPresentList.Items.Add(dr("Member ID").ToString & " " & dr("Member Name").ToString)
                lstMemberList.Items.Remove(dr("Member ID").ToString & " " & dr("Member Name").ToString)
            End If
        End While

        CloseConnection()
    End Sub


    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        'Moves selected item from one list box to another
        If lstMemberList.SelectedIndex <> -1 Then
            lstPresentList.Items.Add(lstMemberList.SelectedItem)
            lstMemberList.Items.Remove(lstMemberList.SelectedItem)
        End If

        If lstPresentList.SelectedIndex <> -1 Then
            lstMemberList.Items.Add(lstPresentList.SelectedItem)
            lstPresentList.Items.Remove(lstPresentList.SelectedItem)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Prompts out a message box to confirm insertion of attendances into database, adds attendances of the event if confirmed
        If MsgBox("Please check the data again. Are you sure you want to insert this attendance list?", _
                  MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Confirmation") = MsgBoxResult.Yes Then
            InsertNewAttendance()
            MsgBox("The attendance list has been added successfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Success")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub lnkHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkHelp.LinkClicked
        'Opens the index of help page
        System.Diagnostics.Process.Start("Help\Index.htm")
    End Sub
End Class
