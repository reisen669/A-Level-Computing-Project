
Imports System.Data
Imports System.Data.OleDb

Public Class frmMemberRecord

    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
    Dim dataFile As String = "Beserah Primary School English Language Society Management System.accdb"
    Dim connString As String = provider & dataFile      'Path of database file
    Dim myConnection As New OleDbConnection             'Joins provider and path

    'Data reader to read data from Access Database
    Dim dr As OleDbDataReader

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


    Private Sub txtMemberID_TextChanged(sender As Object, e As EventArgs) Handles txtMemberID.TextChanged
        ValidateMemberID()
    End Sub

    Private Sub txtMemberName_TextChanged(sender As Object, e As EventArgs) Handles txtMemberName.TextChanged
        ValidateMemberName()
    End Sub

    Private Sub txtGuardian_TextChanged(sender As Object, e As EventArgs) Handles txtGuardian.TextChanged
        ValidateGuardian()
    End Sub

    Private Sub txtContactNumber_TextChanged(sender As Object, e As EventArgs) Handles txtContactNumber.TextChanged
        ValidateContactNumber()
    End Sub

    Private Sub txtPotentialContestant_TextChanged(sender As Object, e As EventArgs) Handles txtPotentialContestant.TextChanged
        AutoSetPotentialContestant()
    End Sub


    Sub ValidateMemberID()
        'Only 5 digits allowed for member ID
        Dim length As Integer = txtMemberID.Text.Length
        Dim i As Integer = 0

        If length <> 5 Then
            lblError.Text = "Member ID must contain 5 digits only!"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If

        If IsNumeric(txtMemberID.Text) = False Then
            lblError.Text = "Member ID can only contain numbers!"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If

    End Sub

    Sub ValidateMemberName()
        'Member name cannot be too long, numbers are not allowed
        Dim length As Integer = txtMemberName.Text.Length
        Dim i As Integer = 0

        If length > 50 Then
            lblError.Text = "The member name is too long! (>50 characters)"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If

        For i = 0 To length - 1
            If Asc(txtMemberName.Text.Substring(i, 1)) >= 48 And Asc(txtMemberName.Text.Substring(i, 1)) <= 57 Then
                lblError.Text = "Member name cannot contain numbers!"
                lblError.Visible = True
                validationFlag = False
                Exit Sub
            Else
                validationFlag = True
                lblError.Visible = False
            End If
        Next
    End Sub

    Sub AutoSetPotentialContestant()
        'Automatically set member as potential contestant if condition is active and highest english grade achieved by member is A or B

        If cboCondition.Text = "Active" Then
            If (cboHighestEnglishGrade.Text = "B") Or (cboHighestEnglishGrade.Text = "A") Then
                txtPotentialContestant.Text = "Potential Contestant"
                txtPotentialContestant.Visible = True
            End If
        Else
            txtPotentialContestant.Text = ""
        End If
        
    End Sub

    Sub ValidateGuardian()
        'Guardian cannot be too long, numbers are not allowed
        Dim length As Integer = txtGuardian.Text.Length
        Dim i As Integer = 0

        If length > 50 Then
            lblError.Text = "The guardian is too long! (>50 characters)"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If

        For i = 0 To length - 1
            If Asc(txtGuardian.Text.Substring(i, 1)) >= 48 And Asc(txtGuardian.Text.Substring(i, 1)) <= 57 Then
                lblError.Text = "Guardian cannot contain numbers!"
                lblError.Visible = True
                validationFlag = False
                Exit Sub
            Else
                validationFlag = True
                lblError.Visible = False
            End If
        Next
    End Sub

    Sub ValidateContactNumber()
        'Guardian cannot be too long or too short, only numbers are allowed
        Dim length As Integer = txtContactNumber.Text.Length

        If length > 11 Then
            lblError.Text = "The contact number is too long! (>11 numbers)"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        ElseIf length < 9 Then
            lblError.Text = "The contact number is too short! (<9 numbers)"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If

        If IsNumeric(txtContactNumber.Text) = False Then
            lblError.Text = "Contact number can only contain numbers!"
            lblError.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblError.Visible = False
        End If

    End Sub

    Sub BlankText()
        'To ensure certain fields are not blank

        If txtMemberID.Text = "" Then
            lblBlank.Text = "Member ID cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

        If cboCondition.Text = "" Then
            lblBlank.Text = "Condition cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

        If txtMemberName.Text = "" Then
            lblBlank.Text = "Member name cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

        If cboMemberClass.Text = "" Then
            lblBlank.Text = "Member class cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

        If cboPosition.Text = "" Then
            lblBlank.Text = "Position cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

        If cboHighestEnglishGrade.Text = "" Then
            lblBlank.Text = "Highest english grade cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

        If txtGuardian.Text = "" Then
            lblBlank.Text = "Guardian cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If

        If txtContactNumber.Text = "" Then
            lblBlank.Text = "Contact number cannot be blank!"
            lblBlank.Visible = True
            validationFlag = False
            Exit Sub
        Else
            validationFlag = True
            lblBlank.Visible = False
        End If
    End Sub


    Sub ClearFields()
        'Clear all the fields
        txtMemberID.Text = ""
        cboCondition.Text = "Active"
        txtMemberName.Text = ""
        cboMemberClass.Text = "1A"
        cboPosition.Text = "None"
        cboHighestEnglishGrade.Text = "F"
        txtPotentialContestant.Visible = False      'Makes the potential contestant text box invisible
        txtPotentialContestant.Text = ""
        txtGuardian.Text = ""
        txtContactNumber.Text = ""
    End Sub

    Sub FocusCursor()
        'Focus cursor at the member ID text box
        txtMemberID.Focus()
    End Sub


    Private Sub frmMemberRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On loading, a connection is opened to connect VB and MS Access

        'Displays simple instructions when pointed
        With ToolTip1
            .SetToolTip(txtMemberID, "Enter member ID (e.g. EL0903)")
            .SetToolTip(cboCondition, "Current condition of the member, active if is a student of the school, inactive if graduated or transferred")
            .SetToolTip(txtMemberName, "Enter the name of member (e.g. Gan Bee Hua)")
            .SetToolTip(cboMemberClass, "Select the class of member")
            .SetToolTip(cboPosition, "Select the position of member in this society")
            .SetToolTip(cboHighestEnglishGrade, "Select the highest english grade achieved by the member")
            .SetToolTip(lblPotentialContestant, "A member is a potential contestant only if he/ she achieved highest english grade of A or B")
            .SetToolTip(txtGuardian, "Enter the name of the guardian of the member (e.g. Gan Woo Beng)")
            .SetToolTip(txtContactNumber, "Enter the contact number of the guardian (e.g. 0199376428)")
            .SetToolTip(btnClear, "Clears all the fields")
            .SetToolTip(btnInsert, "Creates a new member record in the database")
            .SetToolTip(btnUpdate, "Updates an existing member record in the database")
            .SetToolTip(btnSearch, "Searches for a specific member in the database")
            .SetToolTip(btnDelete, "Deletes a member record from database")
            .SetToolTip(btnMainMenu, "Go to the main menu")
        End With

        ClearFields()
        FocusCursor()
        lblError.Visible = False        'Makes the error label invisible to the user when this form is loaded
        lblBlank.Visible = False        'Makes the blank label invisible to the user when this form is loaded
    End Sub


    Sub InsertNewMember()
        'Adds a new member record into database

        StartConnection()
        Dim sql As String = "INSERT INTO tblMemberRecord([Member ID], [Condition], [Member Name], [Member Class], [Position], [Highest English Grade], " & _
                            "[Potential Contestant], [Guardian], [Contact Number]) " & _
                            "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Dim cmd As New OleDbCommand(sql, myConnection)

        With cmd.Parameters
            .Add(New OleDbParameter("[Member ID]", CType(txtMemberID.Text, Integer)))
            .Add(New OleDbParameter("[Condition]", CType(cboCondition.Text, String)))
            .Add(New OleDbParameter("[Member Name]", CType(txtMemberName.Text, String)))
            .Add(New OleDbParameter("[Member Class]", CType(cboMemberClass.Text, String)))
            .Add(New OleDbParameter("[Position]", CType(cboPosition.Text, String)))
            .Add(New OleDbParameter("[Highest English Grade]", CType(cboHighestEnglishGrade.Text, String)))
            .Add(New OleDbParameter("[Potential Contestant]", CType(txtPotentialContestant.Text, String)))
            .Add(New OleDbParameter("[Guardian]", CType(txtGuardian.Text, String)))
            .Add(New OleDbParameter("[Contact Number]", CType(txtContactNumber.Text, String)))
        End With

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        CloseConnection()
        ClearFields()
        FocusCursor()
    End Sub

    Sub UpdateMember()
        'Updates a specific member record in the database

        StartConnection()
        Dim MemberID As Integer = CInt(txtMemberID.Text)
        Dim sql As String = "UPDATE tblMemberRecord " & _
                            "SET [Member Name]='" & txtMemberName.Text & "'," & _
                             "[Condition]='" & cboCondition.Text & "'," & _
                            "[Member Class]='" & cboMemberClass.Text & "'," & _
                            "[Position]='" & cboPosition.Text & "'," & _
                            "[Highest English Grade]='" & cboHighestEnglishGrade.Text & "'," & _
                            "[Potential Contestant]='" & txtPotentialContestant.Text & "'," & _
                            "[Guardian]='" & txtGuardian.Text & "'," & _
                            "[Contact Number]='" & txtContactNumber.Text & "' " & _
                            "WHERE [Member ID]=" & MemberID
        Dim cmd As New OleDbCommand(sql, myConnection)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        CloseConnection()
        ClearFields()
        FocusCursor()
    End Sub

    Sub SearchMember()
        'Searches for a specific member in the database through its ID and then displays it

        StartConnection()

        'Pops out an input box to enter the specific member's ID
        Dim MemberID As Integer = CInt(InputBox("Enter Member ID: ", "Search Member"))
        Dim sql As String = "SELECT * FROM tblMemberRecord " & _
                            "WHERE [Member ID]=" & MemberID
        Dim cmd As New OleDbCommand(sql, myConnection)
        dr = cmd.ExecuteReader

        'Fills up the information about the member
        While dr.Read()
            txtMemberID.Text = dr("Member ID").ToString
            cboCondition.Text = dr("Condition").ToString
            txtMemberName.Text = dr("Member Name").ToString
            cboMemberClass.Text = dr("Member Class").ToString
            cboPosition.Text = dr("Position").ToString
            cboHighestEnglishGrade.Text = dr("Highest English Grade").ToString
            txtPotentialContestant.Text = dr("Potential Contestant").ToString
            txtGuardian.Text = dr("Guardian").ToString
            txtContactNumber.Text = dr("Contact Number").ToString

            searchFlag = True
        End While

        If txtPotentialContestant.Text = "Potential Contestant" Then
            txtPotentialContestant.Visible = True
        End If

        If searchFlag = False Then
            MsgBox("Member ID " & MemberID & " not found!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error")
        End If

        CloseConnection()
    End Sub

    Sub DeleteMember()
        'Deletes a member record from the database

        StartConnection()
        Dim MemberID As Integer = CInt(txtMemberID.Text)
        Dim sql As String = "DELETE FROM tblMemberRecord " & _
                            "WHERE [Member ID]=" & MemberID
        Dim cmd As New OleDbCommand(sql, myConnection)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        CloseConnection()
        ClearFields()
        FocusCursor()
    End Sub


    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        'Saves member details into database after validation

        BlankText()
        AutoSetPotentialContestant()

        If validationFlag = True Then
            InsertNewMember()
            MsgBox("Member record added successfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Success")
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Updates member details in database after validation

        BlankText()
        AutoSetPotentialContestant()

        If validationFlag = True Then
            UpdateMember()
            MsgBox("Member record updated successfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Success")
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchMember()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
        FocusCursor()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtMemberID.Text = "" Then
            MsgBox("Please enter the member ID whose record is to be deleted!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        'Prompts out a message box to confirm deletion, deletes the specific member record if deletion is confirmed
        If MsgBox("Are you sure you want to delete this record?", _
                  MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Confirmation") = MsgBoxResult.Yes Then
            DeleteMember()
            MsgBox("Member record deleted successfully!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Success")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        'Closes the member record form and opens the main menu
        Me.Hide()
        frmMainMenu.Show()
    End Sub

    Private Sub lnkHelp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkHelp.LinkClicked
        'Opens the index of help page
        System.Diagnostics.Process.Start("Help\Index.htm")
    End Sub
End Class