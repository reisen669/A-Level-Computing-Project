<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemberRecord
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
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.lblMemberName = New System.Windows.Forms.Label()
        Me.lblMemberClass = New System.Windows.Forms.Label()
        Me.lblHighestEnglishGrade = New System.Windows.Forms.Label()
        Me.lblGuardian = New System.Windows.Forms.Label()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.txtMemberID = New System.Windows.Forms.TextBox()
        Me.txtMemberName = New System.Windows.Forms.TextBox()
        Me.txtGuardian = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.cboMemberClass = New System.Windows.Forms.ComboBox()
        Me.cboHighestEnglishGrade = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblPotentialContestant = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPotentialContestant = New System.Windows.Forms.TextBox()
        Me.lblCondition = New System.Windows.Forms.Label()
        Me.cboCondition = New System.Windows.Forms.ComboBox()
        Me.lnkHelp = New System.Windows.Forms.LinkLabel()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblBlank = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMemberID
        '
        Me.lblMemberID.AutoSize = True
        Me.lblMemberID.Location = New System.Drawing.Point(38, 42)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(67, 15)
        Me.lblMemberID.TabIndex = 1
        Me.lblMemberID.Text = "Member ID"
        '
        'lblMemberName
        '
        Me.lblMemberName.AutoSize = True
        Me.lblMemberName.Location = New System.Drawing.Point(38, 62)
        Me.lblMemberName.Name = "lblMemberName"
        Me.lblMemberName.Size = New System.Drawing.Size(84, 15)
        Me.lblMemberName.TabIndex = 2
        Me.lblMemberName.Text = "Member Name"
        '
        'lblMemberClass
        '
        Me.lblMemberClass.AutoSize = True
        Me.lblMemberClass.Location = New System.Drawing.Point(38, 84)
        Me.lblMemberClass.Name = "lblMemberClass"
        Me.lblMemberClass.Size = New System.Drawing.Size(83, 15)
        Me.lblMemberClass.TabIndex = 3
        Me.lblMemberClass.Text = "Member Class"
        '
        'lblHighestEnglishGrade
        '
        Me.lblHighestEnglishGrade.AutoSize = True
        Me.lblHighestEnglishGrade.Location = New System.Drawing.Point(38, 131)
        Me.lblHighestEnglishGrade.Name = "lblHighestEnglishGrade"
        Me.lblHighestEnglishGrade.Size = New System.Drawing.Size(126, 15)
        Me.lblHighestEnglishGrade.TabIndex = 5
        Me.lblHighestEnglishGrade.Text = "Highest English Grade"
        '
        'lblGuardian
        '
        Me.lblGuardian.AutoSize = True
        Me.lblGuardian.Location = New System.Drawing.Point(38, 157)
        Me.lblGuardian.Name = "lblGuardian"
        Me.lblGuardian.Size = New System.Drawing.Size(55, 15)
        Me.lblGuardian.TabIndex = 7
        Me.lblGuardian.Text = "Guardian"
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Location = New System.Drawing.Point(38, 179)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(94, 15)
        Me.lblContactNumber.TabIndex = 8
        Me.lblContactNumber.Text = "Contact Number"
        '
        'txtMemberID
        '
        Me.txtMemberID.Location = New System.Drawing.Point(127, 34)
        Me.txtMemberID.MaxLength = 5
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.Size = New System.Drawing.Size(95, 22)
        Me.txtMemberID.TabIndex = 9
        '
        'txtMemberName
        '
        Me.txtMemberName.Location = New System.Drawing.Point(127, 59)
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(279, 22)
        Me.txtMemberName.TabIndex = 10
        '
        'txtGuardian
        '
        Me.txtGuardian.Location = New System.Drawing.Point(137, 154)
        Me.txtGuardian.Name = "txtGuardian"
        Me.txtGuardian.Size = New System.Drawing.Size(279, 22)
        Me.txtGuardian.TabIndex = 12
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(137, 176)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(117, 22)
        Me.txtContactNumber.TabIndex = 13
        '
        'cboMemberClass
        '
        Me.cboMemberClass.FormattingEnabled = True
        Me.cboMemberClass.Items.AddRange(New Object() {"1A", "1B", "1C", "1D", "2A", "2B", "2C", "2D", "3A", "3B", "3C", "3D", "4A", "4B", "4C", "4D", "5A", "5B", "5C", "5D", "6A", "6B", "6C", "6D"})
        Me.cboMemberClass.Location = New System.Drawing.Point(127, 81)
        Me.cboMemberClass.Name = "cboMemberClass"
        Me.cboMemberClass.Size = New System.Drawing.Size(47, 23)
        Me.cboMemberClass.TabIndex = 19
        '
        'cboHighestEnglishGrade
        '
        Me.cboHighestEnglishGrade.FormattingEnabled = True
        Me.cboHighestEnglishGrade.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F"})
        Me.cboHighestEnglishGrade.Location = New System.Drawing.Point(164, 128)
        Me.cboHighestEnglishGrade.Name = "cboHighestEnglishGrade"
        Me.cboHighestEnglishGrade.Size = New System.Drawing.Size(37, 23)
        Me.cboHighestEnglishGrade.TabIndex = 21
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(401, 287)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(66, 22)
        Me.btnInsert.TabIndex = 23
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(257, 287)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 22)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(86, 287)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(66, 22)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(14, 287)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 22)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(9, 328)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(80, 22)
        Me.btnMainMenu.TabIndex = 27
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(38, 108)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(51, 15)
        Me.lblPosition.TabIndex = 28
        Me.lblPosition.Text = "Position"
        '
        'cboPosition
        '
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Items.AddRange(New Object() {"Chairperson", "Vice Chairperson", "Secretary", "Treasurer", "None"})
        Me.cboPosition.Location = New System.Drawing.Point(127, 105)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(170, 23)
        Me.cboPosition.TabIndex = 29
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(329, 287)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(66, 22)
        Me.btnUpdate.TabIndex = 30
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblPotentialContestant
        '
        Me.lblPotentialContestant.AutoSize = True
        Me.lblPotentialContestant.Location = New System.Drawing.Point(207, 131)
        Me.lblPotentialContestant.Name = "lblPotentialContestant"
        Me.lblPotentialContestant.Size = New System.Drawing.Size(0, 15)
        Me.lblPotentialContestant.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 32
        '
        'txtPotentialContestant
        '
        Me.txtPotentialContestant.Location = New System.Drawing.Point(210, 129)
        Me.txtPotentialContestant.Name = "txtPotentialContestant"
        Me.txtPotentialContestant.Size = New System.Drawing.Size(125, 22)
        Me.txtPotentialContestant.TabIndex = 33
        '
        'lblCondition
        '
        Me.lblCondition.AutoSize = True
        Me.lblCondition.Location = New System.Drawing.Point(252, 42)
        Me.lblCondition.Name = "lblCondition"
        Me.lblCondition.Size = New System.Drawing.Size(60, 15)
        Me.lblCondition.TabIndex = 35
        Me.lblCondition.Text = "Condition"
        '
        'cboCondition
        '
        Me.cboCondition.FormattingEnabled = True
        Me.cboCondition.Items.AddRange(New Object() {"Inactive", "Active"})
        Me.cboCondition.Location = New System.Drawing.Point(317, 34)
        Me.cboCondition.Name = "cboCondition"
        Me.cboCondition.Size = New System.Drawing.Size(89, 23)
        Me.cboCondition.TabIndex = 36
        '
        'lnkHelp
        '
        Me.lnkHelp.AutoSize = True
        Me.lnkHelp.Location = New System.Drawing.Point(447, 9)
        Me.lnkHelp.Name = "lnkHelp"
        Me.lnkHelp.Size = New System.Drawing.Size(32, 15)
        Me.lnkHelp.TabIndex = 39
        Me.lnkHelp.TabStop = True
        Me.lnkHelp.Text = "Help"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(43, 243)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(35, 15)
        Me.lblError.TabIndex = 37
        Me.lblError.Text = "____"
        '
        'lblBlank
        '
        Me.lblBlank.AutoSize = True
        Me.lblBlank.Location = New System.Drawing.Point(43, 228)
        Me.lblBlank.Name = "lblBlank"
        Me.lblBlank.Size = New System.Drawing.Size(35, 15)
        Me.lblBlank.TabIndex = 38
        Me.lblBlank.Text = "____"
        '
        'frmMemberRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(491, 362)
        Me.Controls.Add(Me.lnkHelp)
        Me.Controls.Add(Me.lblBlank)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.cboCondition)
        Me.Controls.Add(Me.lblCondition)
        Me.Controls.Add(Me.txtPotentialContestant)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPotentialContestant)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cboPosition)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.cboHighestEnglishGrade)
        Me.Controls.Add(Me.cboMemberClass)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.txtGuardian)
        Me.Controls.Add(Me.txtMemberName)
        Me.Controls.Add(Me.txtMemberID)
        Me.Controls.Add(Me.lblContactNumber)
        Me.Controls.Add(Me.lblGuardian)
        Me.Controls.Add(Me.lblHighestEnglishGrade)
        Me.Controls.Add(Me.lblMemberClass)
        Me.Controls.Add(Me.lblMemberName)
        Me.Controls.Add(Me.lblMemberID)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMemberRecord"
        Me.Text = "Member Record"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMemberID As System.Windows.Forms.Label
    Friend WithEvents lblMemberName As System.Windows.Forms.Label
    Friend WithEvents lblMemberClass As System.Windows.Forms.Label
    Friend WithEvents lblHighestEnglishGrade As System.Windows.Forms.Label
    Friend WithEvents lblGuardian As System.Windows.Forms.Label
    Friend WithEvents lblContactNumber As System.Windows.Forms.Label
    Friend WithEvents txtMemberID As System.Windows.Forms.TextBox
    Friend WithEvents txtMemberName As System.Windows.Forms.TextBox
    Friend WithEvents txtGuardian As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboMemberClass As System.Windows.Forms.ComboBox
    Friend WithEvents cboHighestEnglishGrade As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents cboPosition As System.Windows.Forms.ComboBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblPotentialContestant As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPotentialContestant As System.Windows.Forms.TextBox
    Friend WithEvents lblCondition As System.Windows.Forms.Label
    Friend WithEvents cboCondition As System.Windows.Forms.ComboBox
    Friend WithEvents lnkHelp As System.Windows.Forms.LinkLabel
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblBlank As System.Windows.Forms.Label
End Class
