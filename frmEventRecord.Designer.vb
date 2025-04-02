<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblEventID = New System.Windows.Forms.Label()
        Me.txtEventAdvisor = New System.Windows.Forms.TextBox()
        Me.dtpEventDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEventAdvisor = New System.Windows.Forms.Label()
        Me.txtEventID = New System.Windows.Forms.TextBox()
        Me.txtEventChiefAdvisor = New System.Windows.Forms.TextBox()
        Me.lblEventName = New System.Windows.Forms.Label()
        Me.lblEventChiefAdvisor = New System.Windows.Forms.Label()
        Me.txtEventLevel = New System.Windows.Forms.TextBox()
        Me.txtEventName = New System.Windows.Forms.TextBox()
        Me.lblEventVenue = New System.Windows.Forms.Label()
        Me.lblEventLevel = New System.Windows.Forms.Label()
        Me.txtEventVenue = New System.Windows.Forms.TextBox()
        Me.lblEventDate = New System.Windows.Forms.Label()
        Me.lblEvent = New System.Windows.Forms.Label()
        Me.lblAttendance = New System.Windows.Forms.Label()
        Me.lblRemark = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lstMemberList = New System.Windows.Forms.ListBox()
        Me.lstPresentList = New System.Windows.Forms.ListBox()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblBlank = New System.Windows.Forms.Label()
        Me.lnkHelp = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'lblEventID
        '
        Me.lblEventID.AutoSize = True
        Me.lblEventID.Location = New System.Drawing.Point(36, 52)
        Me.lblEventID.Name = "lblEventID"
        Me.lblEventID.Size = New System.Drawing.Size(54, 15)
        Me.lblEventID.TabIndex = 24
        Me.lblEventID.Text = "Event ID"
        '
        'txtEventAdvisor
        '
        Me.txtEventAdvisor.Location = New System.Drawing.Point(160, 187)
        Me.txtEventAdvisor.Name = "txtEventAdvisor"
        Me.txtEventAdvisor.Size = New System.Drawing.Size(362, 22)
        Me.txtEventAdvisor.TabIndex = 36
        '
        'dtpEventDate
        '
        Me.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEventDate.Location = New System.Drawing.Point(116, 114)
        Me.dtpEventDate.Name = "dtpEventDate"
        Me.dtpEventDate.Size = New System.Drawing.Size(106, 22)
        Me.dtpEventDate.TabIndex = 37
        '
        'lblEventAdvisor
        '
        Me.lblEventAdvisor.AutoSize = True
        Me.lblEventAdvisor.Location = New System.Drawing.Point(36, 190)
        Me.lblEventAdvisor.Name = "lblEventAdvisor"
        Me.lblEventAdvisor.Size = New System.Drawing.Size(84, 15)
        Me.lblEventAdvisor.TabIndex = 35
        Me.lblEventAdvisor.Text = "Event Advisor"
        '
        'txtEventID
        '
        Me.txtEventID.Location = New System.Drawing.Point(116, 49)
        Me.txtEventID.Name = "txtEventID"
        Me.txtEventID.Size = New System.Drawing.Size(89, 22)
        Me.txtEventID.TabIndex = 30
        '
        'txtEventChiefAdvisor
        '
        Me.txtEventChiefAdvisor.Location = New System.Drawing.Point(160, 162)
        Me.txtEventChiefAdvisor.Name = "txtEventChiefAdvisor"
        Me.txtEventChiefAdvisor.Size = New System.Drawing.Size(362, 22)
        Me.txtEventChiefAdvisor.TabIndex = 33
        '
        'lblEventName
        '
        Me.lblEventName.AutoSize = True
        Me.lblEventName.Location = New System.Drawing.Point(36, 74)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(71, 15)
        Me.lblEventName.TabIndex = 25
        Me.lblEventName.Text = "Event Name"
        '
        'lblEventChiefAdvisor
        '
        Me.lblEventChiefAdvisor.AutoSize = True
        Me.lblEventChiefAdvisor.Location = New System.Drawing.Point(36, 165)
        Me.lblEventChiefAdvisor.Name = "lblEventChiefAdvisor"
        Me.lblEventChiefAdvisor.Size = New System.Drawing.Size(118, 15)
        Me.lblEventChiefAdvisor.TabIndex = 29
        Me.lblEventChiefAdvisor.Text = "Event Chief Advisor "
        '
        'txtEventLevel
        '
        Me.txtEventLevel.Location = New System.Drawing.Point(116, 140)
        Me.txtEventLevel.Name = "txtEventLevel"
        Me.txtEventLevel.Size = New System.Drawing.Size(150, 22)
        Me.txtEventLevel.TabIndex = 32
        '
        'txtEventName
        '
        Me.txtEventName.Location = New System.Drawing.Point(116, 71)
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.Size = New System.Drawing.Size(406, 22)
        Me.txtEventName.TabIndex = 34
        '
        'lblEventVenue
        '
        Me.lblEventVenue.AutoSize = True
        Me.lblEventVenue.Location = New System.Drawing.Point(36, 96)
        Me.lblEventVenue.Name = "lblEventVenue"
        Me.lblEventVenue.Size = New System.Drawing.Size(74, 15)
        Me.lblEventVenue.TabIndex = 26
        Me.lblEventVenue.Text = "Event Venue"
        '
        'lblEventLevel
        '
        Me.lblEventLevel.AutoSize = True
        Me.lblEventLevel.Location = New System.Drawing.Point(36, 143)
        Me.lblEventLevel.Name = "lblEventLevel"
        Me.lblEventLevel.Size = New System.Drawing.Size(70, 15)
        Me.lblEventLevel.TabIndex = 28
        Me.lblEventLevel.Text = "Event Level"
        '
        'txtEventVenue
        '
        Me.txtEventVenue.Location = New System.Drawing.Point(116, 93)
        Me.txtEventVenue.Name = "txtEventVenue"
        Me.txtEventVenue.Size = New System.Drawing.Size(406, 22)
        Me.txtEventVenue.TabIndex = 31
        '
        'lblEventDate
        '
        Me.lblEventDate.AutoSize = True
        Me.lblEventDate.Location = New System.Drawing.Point(36, 120)
        Me.lblEventDate.Name = "lblEventDate"
        Me.lblEventDate.Size = New System.Drawing.Size(66, 15)
        Me.lblEventDate.TabIndex = 27
        Me.lblEventDate.Text = "Event Date"
        '
        'lblEvent
        '
        Me.lblEvent.AutoSize = True
        Me.lblEvent.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvent.Location = New System.Drawing.Point(21, 35)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(47, 17)
        Me.lblEvent.TabIndex = 38
        Me.lblEvent.Text = "Event"
        '
        'lblAttendance
        '
        Me.lblAttendance.AutoSize = True
        Me.lblAttendance.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendance.Location = New System.Drawing.Point(529, 35)
        Me.lblAttendance.Name = "lblAttendance"
        Me.lblAttendance.Size = New System.Drawing.Size(83, 17)
        Me.lblAttendance.TabIndex = 39
        Me.lblAttendance.Text = "Attendance"
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.Location = New System.Drawing.Point(36, 217)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(52, 15)
        Me.lblRemark.TabIndex = 40
        Me.lblRemark.Text = "Remarks"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(94, 214)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(428, 55)
        Me.txtRemark.TabIndex = 41
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(455, 329)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 42
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(94, 329)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 43
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(293, 329)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 44
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(15, 329)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 45
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(24, 371)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(96, 23)
        Me.btnMainMenu.TabIndex = 46
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(374, 329)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 48
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lstMemberList
        '
        Me.lstMemberList.FormattingEnabled = True
        Me.lstMemberList.ItemHeight = 15
        Me.lstMemberList.Location = New System.Drawing.Point(532, 74)
        Me.lstMemberList.Name = "lstMemberList"
        Me.lstMemberList.Size = New System.Drawing.Size(222, 244)
        Me.lstMemberList.TabIndex = 54
        '
        'lstPresentList
        '
        Me.lstPresentList.FormattingEnabled = True
        Me.lstPresentList.ItemHeight = 15
        Me.lstPresentList.Location = New System.Drawing.Point(841, 74)
        Me.lstPresentList.Name = "lstPresentList"
        Me.lstPresentList.Size = New System.Drawing.Size(225, 244)
        Me.lstPresentList.TabIndex = 55
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(760, 139)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(75, 23)
        Me.btnMove.TabIndex = 56
        Me.btnMove.Text = "Move"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(979, 329)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 57
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(36, 296)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(28, 15)
        Me.lblError.TabIndex = 58
        Me.lblError.Text = "___"
        '
        'lblBlank
        '
        Me.lblBlank.AutoSize = True
        Me.lblBlank.Location = New System.Drawing.Point(36, 281)
        Me.lblBlank.Name = "lblBlank"
        Me.lblBlank.Size = New System.Drawing.Size(28, 15)
        Me.lblBlank.TabIndex = 59
        Me.lblBlank.Text = "___"
        '
        'lnkHelp
        '
        Me.lnkHelp.AutoSize = True
        Me.lnkHelp.Location = New System.Drawing.Point(1034, 9)
        Me.lnkHelp.Name = "lnkHelp"
        Me.lnkHelp.Size = New System.Drawing.Size(32, 15)
        Me.lnkHelp.TabIndex = 60
        Me.lnkHelp.TabStop = True
        Me.lnkHelp.Text = "Help"
        '
        'frmEventRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1078, 423)
        Me.Controls.Add(Me.lnkHelp)
        Me.Controls.Add(Me.lblBlank)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.lstPresentList)
        Me.Controls.Add(Me.lstMemberList)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.lblRemark)
        Me.Controls.Add(Me.lblAttendance)
        Me.Controls.Add(Me.lblEvent)
        Me.Controls.Add(Me.lblEventID)
        Me.Controls.Add(Me.txtEventAdvisor)
        Me.Controls.Add(Me.dtpEventDate)
        Me.Controls.Add(Me.lblEventAdvisor)
        Me.Controls.Add(Me.txtEventID)
        Me.Controls.Add(Me.txtEventChiefAdvisor)
        Me.Controls.Add(Me.lblEventName)
        Me.Controls.Add(Me.lblEventChiefAdvisor)
        Me.Controls.Add(Me.txtEventLevel)
        Me.Controls.Add(Me.txtEventName)
        Me.Controls.Add(Me.lblEventVenue)
        Me.Controls.Add(Me.lblEventLevel)
        Me.Controls.Add(Me.txtEventVenue)
        Me.Controls.Add(Me.lblEventDate)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmEventRecord"
        Me.Text = "Event Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblEventID As System.Windows.Forms.Label
    Friend WithEvents txtEventAdvisor As System.Windows.Forms.TextBox
    Friend WithEvents dtpEventDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEventAdvisor As System.Windows.Forms.Label
    Friend WithEvents txtEventID As System.Windows.Forms.TextBox
    Friend WithEvents txtEventChiefAdvisor As System.Windows.Forms.TextBox
    Friend WithEvents lblEventName As System.Windows.Forms.Label
    Friend WithEvents lblEventChiefAdvisor As System.Windows.Forms.Label
    Friend WithEvents txtEventLevel As System.Windows.Forms.TextBox
    Friend WithEvents txtEventName As System.Windows.Forms.TextBox
    Friend WithEvents lblEventVenue As System.Windows.Forms.Label
    Friend WithEvents lblEventLevel As System.Windows.Forms.Label
    Friend WithEvents txtEventVenue As System.Windows.Forms.TextBox
    Friend WithEvents lblEventDate As System.Windows.Forms.Label
    Friend WithEvents lblEvent As System.Windows.Forms.Label
    Friend WithEvents lblAttendance As System.Windows.Forms.Label
    Friend WithEvents lblRemark As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lstMemberList As System.Windows.Forms.ListBox
    Friend WithEvents lstPresentList As System.Windows.Forms.ListBox
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblBlank As System.Windows.Forms.Label
    Friend WithEvents lnkHelp As System.Windows.Forms.LinkLabel
End Class
