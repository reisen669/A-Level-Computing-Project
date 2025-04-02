<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPotentialContestantList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPotentialContestantList))
        Me.lnkPrint = New System.Windows.Forms.LinkLabel()
        Me.prtPotentialContestant = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.lblSchoolName = New System.Windows.Forms.Label()
        Me.lblSocietyName = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dgvPotentialContestantList = New System.Windows.Forms.DataGridView()
        Me.clmHighestEnglishGrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMemberName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lnkHelp = New System.Windows.Forms.LinkLabel()
        CType(Me.dgvPotentialContestantList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lnkPrint
        '
        Me.lnkPrint.AutoSize = True
        Me.lnkPrint.Location = New System.Drawing.Point(592, 67)
        Me.lnkPrint.Name = "lnkPrint"
        Me.lnkPrint.Size = New System.Drawing.Size(43, 15)
        Me.lnkPrint.TabIndex = 1
        Me.lnkPrint.TabStop = True
        Me.lnkPrint.Text = "PRINT"
        '
        'prtPotentialContestant
        '
        Me.prtPotentialContestant.DocumentName = "document"
        Me.prtPotentialContestant.Form = Me
        Me.prtPotentialContestant.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.prtPotentialContestant.PrinterSettings = CType(resources.GetObject("prtPotentialContestant.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.prtPotentialContestant.PrintFileName = Nothing
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(21, 543)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(90, 23)
        Me.btnMainMenu.TabIndex = 2
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'lblSchoolName
        '
        Me.lblSchoolName.AutoSize = True
        Me.lblSchoolName.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolName.Location = New System.Drawing.Point(163, 19)
        Me.lblSchoolName.Name = "lblSchoolName"
        Me.lblSchoolName.Size = New System.Drawing.Size(383, 36)
        Me.lblSchoolName.TabIndex = 3
        Me.lblSchoolName.Text = "Sekolah Kebangsaan Beserah"
        '
        'lblSocietyName
        '
        Me.lblSocietyName.AutoSize = True
        Me.lblSocietyName.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocietyName.Location = New System.Drawing.Point(190, 55)
        Me.lblSocietyName.Name = "lblSocietyName"
        Me.lblSocietyName.Size = New System.Drawing.Size(295, 31)
        Me.lblSocietyName.TabIndex = 4
        Me.lblSocietyName.Text = "English Language Society"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(57, 129)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(286, 27)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "List of Potential Contestants"
        '
        'dgvPotentialContestantList
        '
        Me.dgvPotentialContestantList.BackgroundColor = System.Drawing.Color.White
        Me.dgvPotentialContestantList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPotentialContestantList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmHighestEnglishGrade, Me.clmMemberID, Me.clmMemberName})
        Me.dgvPotentialContestantList.Location = New System.Drawing.Point(62, 160)
        Me.dgvPotentialContestantList.Name = "dgvPotentialContestantList"
        Me.dgvPotentialContestantList.Size = New System.Drawing.Size(534, 364)
        Me.dgvPotentialContestantList.TabIndex = 6
        '
        'clmHighestEnglishGrade
        '
        Me.clmHighestEnglishGrade.HeaderText = "Highest English Grade"
        Me.clmHighestEnglishGrade.Name = "clmHighestEnglishGrade"
        Me.clmHighestEnglishGrade.ReadOnly = True
        Me.clmHighestEnglishGrade.Width = 60
        '
        'clmMemberID
        '
        Me.clmMemberID.HeaderText = "Member ID"
        Me.clmMemberID.Name = "clmMemberID"
        Me.clmMemberID.ReadOnly = True
        Me.clmMemberID.Width = 80
        '
        'clmMemberName
        '
        Me.clmMemberName.HeaderText = "Member Name"
        Me.clmMemberName.Name = "clmMemberName"
        Me.clmMemberName.ReadOnly = True
        Me.clmMemberName.Width = 350
        '
        'lnkHelp
        '
        Me.lnkHelp.AutoSize = True
        Me.lnkHelp.Location = New System.Drawing.Point(646, 9)
        Me.lnkHelp.Name = "lnkHelp"
        Me.lnkHelp.Size = New System.Drawing.Size(32, 15)
        Me.lnkHelp.TabIndex = 40
        Me.lnkHelp.TabStop = True
        Me.lnkHelp.Text = "Help"
        '
        'frmPotentialContestantList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(690, 578)
        Me.Controls.Add(Me.lnkHelp)
        Me.Controls.Add(Me.dgvPotentialContestantList)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSocietyName)
        Me.Controls.Add(Me.lblSchoolName)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lnkPrint)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPotentialContestantList"
        Me.Text = "Potential Contestant List"
        CType(Me.dgvPotentialContestantList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lnkPrint As System.Windows.Forms.LinkLabel
    Friend WithEvents prtPotentialContestant As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSocietyName As System.Windows.Forms.Label
    Friend WithEvents lblSchoolName As System.Windows.Forms.Label
    Friend WithEvents dgvPotentialContestantList As System.Windows.Forms.DataGridView
    Friend WithEvents clmHighestEnglishGrade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMemberName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lnkHelp As System.Windows.Forms.LinkLabel
End Class
