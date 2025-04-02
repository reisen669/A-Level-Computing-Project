
Imports System.Data
Imports System.Data.OleDb

Public Class frmEventAttendance
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
    Dim dataFile As String = "Beserah Primary School English Club Management System.accdb"
    Dim connString As String = provider & dataFile
    Dim myConnection As New OleDbConnection
    Dim dr As OleDbDataReader

    Private Sub frmEventAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Displays simple instructions when pointed
        With ToolTip1
            .SetToolTip(txtEventID, "The specific event ID entered")
            .SetToolTip(txtEventName, "The name of the specific event")
            .SetToolTip(txtEventDate, "The date of the specific event")
        End With

        'Connects the programme with the database
        myConnection.ConnectionString = connString
        myConnection.Open()

        'Searches EventRecord table for the specific event ID and displays it
        Dim EventID As String = InputBox("Enter enter the event ID: ", "Specific Event")
        Dim sql As String = "SELECT * FROM EventRecord " & _
                            "WHERE EventID='" & EventID & "'"
        Dim cmd As New OleDbCommand(sql, myConnection)
        dr = cmd.ExecuteReader

        'Fills up the information about the event and allows the user to take attendance of members
        While dr.Read()
            txtEventID.Text = dr("EventID").ToString
            txtEventName.Text = dr("EventName").ToString
            txtEventDate.Text = dr("EventDate").ToShortDate

            lblStudentID.Text = "ID: " & dr("StudentID").ToString
            lblStudentName.Text = "Name: " & dr("StudentName").ToString
            lblTG.Text = "TG:" & dr("TG").ToString
        End While

        'Closes the connection between the programme and the database
        myConnection.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Print preview with the link label hidden
        LinkLabel1.Hide()
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview

        'Print action
        PrintForm1.Print()

        'Allows the link label to show again
        LinkLabel1.Show()
    End Sub

    Private Sub InsertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertToolStripMenuItem.Click
        'Connects the programme with the database
        myConnection.ConnectionString = connString
        myConnection.Open()

        ''Inserts a new record into EventAttendance table 
        'Dim sql As String
        'sql = "INSERT INTO Event Record([MemberID], [MemberName], [MemberClass], [HighestEnglishGrade], [PotentialContestant], [Guardian], [ContactNumber]) " & _
        '      "VALUES (?, ?, ?, ?, ?, ?, ? )"
        'Dim cmd As OleDbCommand = New OleDbCommand(sql, myConnection)
        'With cmd.Parameters
        '    .Add(New OleDbParameter("MemberID", CType(txtMemberID.Text, String)))
        '    .Add(New OleDbParameter("MemberName", CType(txtMemberName.Text, String)))
        '    .Add(New OleDbParameter("MemberClass", CType(cboMemberClass.Text, String)))
        '    .Add(New OleDbParameter("HighestEnglishGrade", CType(cboHighestEnglishGrade.Text, String)))
        '    .Add(New OleDbParameter("PotentialContestant", CType(chkPotentialContestant.Text, Boolean)))
        '    .Add(New OleDbParameter("Guardian", CType(txtGuardian.Text, String)))
        '    .Add(New OleDbParameter("ContactNumber", CType(txtContactNumber.Text, String)))
        'End With

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Clear all the text boxes
        txtEventID.Text = ""
        txtEventName.Text = ""
        txtEventDate.Text = ""

        'Focus cursor at the first text box
        txtMemberID.Focus()

        'Closes the connection between the programme and the database
        myConnection.Close()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        'Connects the programme with the database
        myConnection.ConnectionString = connString
        myConnection.Open()

        ''Updates a specific member record in the EventAttendance table 
        'Dim MemberID As String = txtMemberID.Text
        'Dim sql As String = "UPDATE EventRecord " & _
        '                    "SET [MemberName]='" & txtMemberName.Text & "'," & _
        '                    "[MemberClass]='" & cboMemberClass.Text & "'," & _
        '                    "[HighestEnglishGrade]='" & cboHighestEnglishGrade.Text & "'," & _
        '                    "[PotentialContestant]='" & CType(chkPotentialContestant.Checked, Boolean) & "'," & _
        '                    "[Guardian]='" & txtGuardian.Text & "'," & _
        '                    "[ContactNumber]='" & txtContactNumber.Text & "' " & _
        '                    "WHERE MemberID='" & MemberID & "'"
        'Dim cmd As New OleDbCommand(sql, myConnection)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Closes the connection between the programme and the database
        myConnection.Close()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        'Connects the programme with the database
        myConnection.ConnectionString = connString
        myConnection.Open()

        ''Deletes a specific member record from the EventAttendance table
        'Dim MemberID As String = txtMemberID.Text
        'Dim sql As String = "DELETE FROM MemberRecord " & _
        '                    "WHERE MemberID='" & MemberID & "'"
        'Dim cmd As New OleDbCommand(sql, myConnection)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Clear all the text boxes
       txtEventID.Text = ""
        txtEventName.Text = ""
        txtEventDate.Text = ""

        'Focus cursor at the first text box
        txtMemberID.Focus()

        'Closes the connection between the programme and the database
        myConnection.Close()
    End Sub
End Class