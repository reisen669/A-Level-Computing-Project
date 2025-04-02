<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresentList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPresentList))
        Me.lblEventNameAndID = New System.Windows.Forms.Label()
        Me.lblEventDate = New System.Windows.Forms.Label()
        Me.lblEventVenue = New System.Windows.Forms.Label()
        Me.lnkPrint = New System.Windows.Forms.LinkLabel()
        Me.prtPresentList = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSocietyName = New System.Windows.Forms.Label()
        Me.lblSchoolName = New System.Windows.Forms.Label()
        Me.dgvPresentList = New System.Windows.Forms.DataGridView()
        Me.clmMemberID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmMemberName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lnkHelp = New System.Windows.Forms.LinkLabel()
        CType(Me.dgvPresentList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEventNameAndID
        '
        Me.lblEventNameAndID.AutoSize = True
        Me.lblEventNameAndID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventNameAndID.Location = New System.Drawing.Point(232, 121)
        Me.lblEventNameAndID.Name = "lblEventNameAndID"
        Me.lblEventNameAndID.Size = New System.Drawing.Size(164, 21)
        Me.lblEventNameAndID.TabIndex = 3
        Me.lblEventNameAndID.Text = "lblEventNameAndID"
        '
        'lblEventDate
        '
        Me.lblEventDate.AutoSize = True
        Me.lblEventDate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventDate.Location = New System.Drawing.Point(268, 142)
        Me.lblEventDate.Name = "lblEventDate"
        Me.lblEventDate.Size = New System.Drawing.Size(104, 21)
        Me.lblEventDate.TabIndex = 4
        Me.lblEventDate.Text = "lblEventDate"
        '
        'lblEventVenue
        '
        Me.lblEventVenue.AutoSize = True
        Me.lblEventVenue.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventVenue.Location = New System.Drawing.Point(257, 163)
        Me.lblEventVenue.Name = "lblEventVenue"
        Me.lblEventVenue.Size = New System.Drawing.Size(115, 21)
        Me.lblEventVenue.TabIndex = 5
        Me.lblEventVenue.Text = "lblEventVenue"
        '
        'lnkPrint
        '
        Me.lnkPrint.AutoSize = True
        Me.lnkPrint.Location = New System.Drawing.Point(593, 66)
        Me.lnkPrint.Name = "lnkPrint"
        Me.lnkPrint.Size = New System.Drawing.Size(43, 15)
        Me.lnkPrint.TabIndex = 6
        Me.lnkPrint.TabStop = True
        Me.lnkPrint.Text = "PRINT"
        '
        'prtPresentList
        '
        Me.prtPresentList.DocumentName = "document"
        Me.prtPresentList.Form = Me
        Me.prtPresentList.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.prtPresentList.PrinterSettings = CType(resources.GetObject("prtPresentList.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.prtPresentList.PrintFileName = Nothing
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(12, 622)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(88, 23)
        Me.btnMainMenu.TabIndex = 7
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(58, 204)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(249, 27)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "List of Members Present"
        '
        'lblSocietyName
        '
        Me.lblSocietyName.AutoSize = True
        Me.lblSocietyName.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSocietyName.Location = New System.Drawing.Point(184, 54)
        Me.lblSocietyName.Name = "lblSocietyName"
        Me.lblSocietyName.Size = New System.Drawing.Size(295, 31)
        Me.lblSocietyName.TabIndex = 9
        Me.lblSocietyName.Text = "English Language Society"
        '
        'lblSchoolName
        '
        Me.lblSchoolName.AutoSize = True
        Me.lblSchoolName.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolName.Location = New System.Drawing.Point(157, 18)
        Me.lblSchoolName.Name = "lblSchoolName"
        Me.lblSchoolName.Size = New System.Drawing.Size(383, 36)
        Me.lblSchoolName.TabIndex = 8
        Me.lblSchoolName.Text = "Sekolah Kebangsaan Beserah"
        '
        'dgvPresentList
        '
        Me.dgvPresentList.AllowUserToOrderColumns = True
        Me.dgvPresentList.BackgroundColor = System.Drawing.Color.White
        Me.dgvPresentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPresentList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmMemberID, Me.clmMemberName})
        Me.dgvPresentList.Location = New System.Drawing.Point(63, 234)
        Me.dgvPresentList.Name = "dgvPresentList"
        Me.dgvPresentList.Size = New System.Drawing.Size(543, 382)
        Me.dgvPresentList.TabIndex = 11
        '
        'clmMemberID
        '
        Me.clmMemberID.HeaderText = "Member ID"
        Me.clmMemberID.Name = "clmMemberID"
        Me.clmMemberID.ReadOnly = True
        '
        'clmMemberName
        '
        Me.clmMemberName.HeaderText = "Member Name"
        Me.clmMemberName.Name = "clmMemberName"
        Me.clmMemberName.ReadOnly = True
        Me.clmMemberName.Width = 400
        '
        'lnkHelp
        '
        Me.lnkHelp.AutoSize = True
        Me.lnkHelp.BackColor = System.Drawing.SystemColors.Control
        Me.lnkHelp.Location = New System.Drawing.Point(647, 9)
        Me.lnkHelp.Name = "lnkHelp"
        Me.lnkHelp.Size = New System.Drawing.Size(32, 15)
        Me.lnkHelp.TabIndex = 41
        Me.lnkHelp.TabStop = True
        Me.lnkHelp.Text = "Help"
        '
        'frmPresentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(691, 655)
        Me.Controls.Add(Me.lnkHelp)
        Me.Controls.Add(Me.dgvPresentList)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSocietyName)
        Me.Controls.Add(Me.lblSchoolName)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lnkPrint)
        Me.Controls.Add(Me.lblEventVenue)
        Me.Controls.Add(Me.lblEventDate)
        Me.Controls.Add(Me.lblEventNameAndID)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmPresentList"
        Me.Text = "Present List"
        CType(Me.dgvPresentList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEventNameAndID As System.Windows.Forms.Label
    Friend WithEvents lblEventDate As System.Windows.Forms.Label
    Friend WithEvents lblEventVenue As System.Windows.Forms.Label
    Friend WithEvents lnkPrint As System.Windows.Forms.LinkLabel
    Friend WithEvents prtPresentList As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSocietyName As System.Windows.Forms.Label
    Friend WithEvents lblSchoolName As System.Windows.Forms.Label
    Friend WithEvents dgvPresentList As System.Windows.Forms.DataGridView
    Friend WithEvents clmMemberID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmMemberName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lnkHelp As System.Windows.Forms.LinkLabel
End Class
