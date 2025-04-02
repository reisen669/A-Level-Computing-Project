<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommitteeBoard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommitteeBoard))
        Me.lblChiefAdvisor = New System.Windows.Forms.Label()
        Me.lblAdvisors = New System.Windows.Forms.Label()
        Me.txtChiefAdvisor = New System.Windows.Forms.TextBox()
        Me.txtAdvisor1 = New System.Windows.Forms.TextBox()
        Me.txtAdvisor2 = New System.Windows.Forms.TextBox()
        Me.txtChairperson = New System.Windows.Forms.TextBox()
        Me.txtAdvisor3 = New System.Windows.Forms.TextBox()
        Me.txtViceChairperson = New System.Windows.Forms.TextBox()
        Me.txtTreasurer = New System.Windows.Forms.TextBox()
        Me.txtSecretary = New System.Windows.Forms.TextBox()
        Me.lblChairperson = New System.Windows.Forms.Label()
        Me.lblViceChairperson = New System.Windows.Forms.Label()
        Me.lblSecretary = New System.Windows.Forms.Label()
        Me.lblTreasurer = New System.Windows.Forms.Label()
        Me.lnkPrint = New System.Windows.Forms.LinkLabel()
        Me.prtCommitteeBoard = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.lblYear = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSocietyName = New System.Windows.Forms.Label()
        Me.lblSchoolName = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lnkHelp = New System.Windows.Forms.LinkLabel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblBlank = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblChiefAdvisor
        '
        Me.lblChiefAdvisor.AutoSize = True
        Me.lblChiefAdvisor.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChiefAdvisor.Location = New System.Drawing.Point(62, 190)
        Me.lblChiefAdvisor.Name = "lblChiefAdvisor"
        Me.lblChiefAdvisor.Size = New System.Drawing.Size(114, 21)
        Me.lblChiefAdvisor.TabIndex = 0
        Me.lblChiefAdvisor.Text = "Chief Advisor"
        '
        'lblAdvisors
        '
        Me.lblAdvisors.AutoSize = True
        Me.lblAdvisors.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvisors.Location = New System.Drawing.Point(62, 232)
        Me.lblAdvisors.Name = "lblAdvisors"
        Me.lblAdvisors.Size = New System.Drawing.Size(78, 21)
        Me.lblAdvisors.TabIndex = 1
        Me.lblAdvisors.Text = "Advisors"
        '
        'txtChiefAdvisor
        '
        Me.txtChiefAdvisor.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChiefAdvisor.Location = New System.Drawing.Point(210, 187)
        Me.txtChiefAdvisor.Name = "txtChiefAdvisor"
        Me.txtChiefAdvisor.Size = New System.Drawing.Size(411, 29)
        Me.txtChiefAdvisor.TabIndex = 6
        '
        'txtAdvisor1
        '
        Me.txtAdvisor1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdvisor1.Location = New System.Drawing.Point(210, 229)
        Me.txtAdvisor1.Name = "txtAdvisor1"
        Me.txtAdvisor1.Size = New System.Drawing.Size(411, 29)
        Me.txtAdvisor1.TabIndex = 7
        '
        'txtAdvisor2
        '
        Me.txtAdvisor2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdvisor2.Location = New System.Drawing.Point(210, 271)
        Me.txtAdvisor2.Name = "txtAdvisor2"
        Me.txtAdvisor2.Size = New System.Drawing.Size(411, 29)
        Me.txtAdvisor2.TabIndex = 8
        '
        'txtChairperson
        '
        Me.txtChairperson.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChairperson.Location = New System.Drawing.Point(211, 417)
        Me.txtChairperson.Name = "txtChairperson"
        Me.txtChairperson.Size = New System.Drawing.Size(411, 29)
        Me.txtChairperson.TabIndex = 9
        '
        'txtAdvisor3
        '
        Me.txtAdvisor3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdvisor3.Location = New System.Drawing.Point(210, 319)
        Me.txtAdvisor3.Name = "txtAdvisor3"
        Me.txtAdvisor3.Size = New System.Drawing.Size(411, 29)
        Me.txtAdvisor3.TabIndex = 10
        '
        'txtViceChairperson
        '
        Me.txtViceChairperson.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViceChairperson.Location = New System.Drawing.Point(211, 460)
        Me.txtViceChairperson.Name = "txtViceChairperson"
        Me.txtViceChairperson.Size = New System.Drawing.Size(411, 29)
        Me.txtViceChairperson.TabIndex = 11
        '
        'txtTreasurer
        '
        Me.txtTreasurer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTreasurer.Location = New System.Drawing.Point(211, 544)
        Me.txtTreasurer.Name = "txtTreasurer"
        Me.txtTreasurer.Size = New System.Drawing.Size(411, 29)
        Me.txtTreasurer.TabIndex = 13
        '
        'txtSecretary
        '
        Me.txtSecretary.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecretary.Location = New System.Drawing.Point(211, 501)
        Me.txtSecretary.Name = "txtSecretary"
        Me.txtSecretary.Size = New System.Drawing.Size(411, 29)
        Me.txtSecretary.TabIndex = 14
        '
        'lblChairperson
        '
        Me.lblChairperson.AutoSize = True
        Me.lblChairperson.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChairperson.Location = New System.Drawing.Point(63, 420)
        Me.lblChairperson.Name = "lblChairperson"
        Me.lblChairperson.Size = New System.Drawing.Size(101, 21)
        Me.lblChairperson.TabIndex = 15
        Me.lblChairperson.Text = "Chairperson"
        '
        'lblViceChairperson
        '
        Me.lblViceChairperson.AutoSize = True
        Me.lblViceChairperson.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViceChairperson.Location = New System.Drawing.Point(63, 463)
        Me.lblViceChairperson.Name = "lblViceChairperson"
        Me.lblViceChairperson.Size = New System.Drawing.Size(139, 21)
        Me.lblViceChairperson.TabIndex = 16
        Me.lblViceChairperson.Text = "Vice Chairperson"
        '
        'lblSecretary
        '
        Me.lblSecretary.AutoSize = True
        Me.lblSecretary.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretary.Location = New System.Drawing.Point(63, 505)
        Me.lblSecretary.Name = "lblSecretary"
        Me.lblSecretary.Size = New System.Drawing.Size(80, 21)
        Me.lblSecretary.TabIndex = 17
        Me.lblSecretary.Text = "Secretary"
        '
        'lblTreasurer
        '
        Me.lblTreasurer.AutoSize = True
        Me.lblTreasurer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTreasurer.Location = New System.Drawing.Point(63, 547)
        Me.lblTreasurer.Name = "lblTreasurer"
        Me.lblTreasurer.Size = New System.Drawing.Size(80, 21)
        Me.lblTreasurer.TabIndex = 18
        Me.lblTreasurer.Text = "Treasurer"
        '
        'lnkPrint
        '
        Me.lnkPrint.AutoSize = True
        Me.lnkPrint.Location = New System.Drawing.Point(603, 71)
        Me.lnkPrint.Name = "lnkPrint"
        Me.lnkPrint.Size = New System.Drawing.Size(43, 15)
        Me.lnkPrint.TabIndex = 19
        Me.lnkPrint.TabStop = True
        Me.lnkPrint.Text = "PRINT"
        '
        'prtCommitteeBoard
        '
        Me.prtCommitteeBoard.DocumentName = "document"
        Me.prtCommitteeBoard.Form = Me
        Me.prtCommitteeBoard.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.prtCommitteeBoard.PrinterSettings = CType(resources.GetObject("prtCommitteeBoard.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.prtCommitteeBoard.PrintFileName = Nothing
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(113, 157)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(43, 21)
        Me.lblYear.TabIndex = 20
        Me.lblYear.Text = "Year"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(585, 645)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(423, 645)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(29, 645)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(94, 23)
        Me.btnMainMenu.TabIndex = 23
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(210, 154)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(48, 29)
        Me.txtYear.TabIndex = 24
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(62, 111)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(183, 27)
        Me.lblTitle.TabIndex = 30
        Me.lblTitle.Text = "Committee Board"
        '
        'lblSocietyName
        '
        Me.lblSocietyName.AutoSize = True
        Me.lblSocietyName.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocietyName.Location = New System.Drawing.Point(181, 59)
        Me.lblSocietyName.Name = "lblSocietyName"
        Me.lblSocietyName.Size = New System.Drawing.Size(295, 31)
        Me.lblSocietyName.TabIndex = 29
        Me.lblSocietyName.Text = "English Language Society"
        '
        'lblSchoolName
        '
        Me.lblSchoolName.AutoSize = True
        Me.lblSchoolName.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolName.Location = New System.Drawing.Point(154, 23)
        Me.lblSchoolName.Name = "lblSchoolName"
        Me.lblSchoolName.Size = New System.Drawing.Size(383, 36)
        Me.lblSchoolName.TabIndex = 28
        Me.lblSchoolName.Text = "Sekolah Kebangsaan Beserah"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(129, 645)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 33
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lnkHelp
        '
        Me.lnkHelp.AutoSize = True
        Me.lnkHelp.Location = New System.Drawing.Point(649, 9)
        Me.lnkHelp.Name = "lnkHelp"
        Me.lnkHelp.Size = New System.Drawing.Size(32, 15)
        Me.lnkHelp.TabIndex = 40
        Me.lnkHelp.TabStop = True
        Me.lnkHelp.Text = "Help"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(504, 645)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 41
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.White
        Me.lblError.Location = New System.Drawing.Point(78, 604)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(28, 15)
        Me.lblError.TabIndex = 42
        Me.lblError.Text = "___"
        '
        'lblBlank
        '
        Me.lblBlank.AutoSize = True
        Me.lblBlank.BackColor = System.Drawing.Color.White
        Me.lblBlank.Location = New System.Drawing.Point(78, 589)
        Me.lblBlank.Name = "lblBlank"
        Me.lblBlank.Size = New System.Drawing.Size(28, 15)
        Me.lblBlank.TabIndex = 43
        Me.lblBlank.Text = "___"
        '
        'frmCommitteeBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(693, 672)
        Me.Controls.Add(Me.lblBlank)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lnkHelp)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSocietyName)
        Me.Controls.Add(Me.lblSchoolName)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lnkPrint)
        Me.Controls.Add(Me.lblTreasurer)
        Me.Controls.Add(Me.lblSecretary)
        Me.Controls.Add(Me.lblViceChairperson)
        Me.Controls.Add(Me.lblChairperson)
        Me.Controls.Add(Me.txtSecretary)
        Me.Controls.Add(Me.txtTreasurer)
        Me.Controls.Add(Me.txtViceChairperson)
        Me.Controls.Add(Me.txtAdvisor3)
        Me.Controls.Add(Me.txtChairperson)
        Me.Controls.Add(Me.txtAdvisor2)
        Me.Controls.Add(Me.txtAdvisor1)
        Me.Controls.Add(Me.txtChiefAdvisor)
        Me.Controls.Add(Me.lblAdvisors)
        Me.Controls.Add(Me.lblChiefAdvisor)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCommitteeBoard"
        Me.Text = "Committee Board"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChiefAdvisor As System.Windows.Forms.Label
    Friend WithEvents lblAdvisors As System.Windows.Forms.Label
    Friend WithEvents txtChiefAdvisor As System.Windows.Forms.TextBox
    Friend WithEvents txtAdvisor1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAdvisor2 As System.Windows.Forms.TextBox
    Friend WithEvents txtChairperson As System.Windows.Forms.TextBox
    Friend WithEvents txtAdvisor3 As System.Windows.Forms.TextBox
    Friend WithEvents txtViceChairperson As System.Windows.Forms.TextBox
    Friend WithEvents txtTreasurer As System.Windows.Forms.TextBox
    Friend WithEvents txtSecretary As System.Windows.Forms.TextBox
    Friend WithEvents lblTreasurer As System.Windows.Forms.Label
    Friend WithEvents lblSecretary As System.Windows.Forms.Label
    Friend WithEvents lblViceChairperson As System.Windows.Forms.Label
    Friend WithEvents lblChairperson As System.Windows.Forms.Label
    Friend WithEvents lnkPrint As System.Windows.Forms.LinkLabel
    Friend WithEvents prtCommitteeBoard As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSocietyName As System.Windows.Forms.Label
    Friend WithEvents lblSchoolName As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lnkHelp As System.Windows.Forms.LinkLabel
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblBlank As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
End Class
