<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.btnMemberRecord = New System.Windows.Forms.Button()
        Me.btnEventRecord = New System.Windows.Forms.Button()
        Me.btnCommitteeBoard = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPresentList = New System.Windows.Forms.Button()
        Me.btnPotentialContestants = New System.Windows.Forms.Button()
        Me.lnkHelp = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btnMemberRecord
        '
        Me.btnMemberRecord.Location = New System.Drawing.Point(54, 38)
        Me.btnMemberRecord.Name = "btnMemberRecord"
        Me.btnMemberRecord.Size = New System.Drawing.Size(160, 29)
        Me.btnMemberRecord.TabIndex = 0
        Me.btnMemberRecord.Text = "Member Record"
        Me.btnMemberRecord.UseVisualStyleBackColor = True
        '
        'btnEventRecord
        '
        Me.btnEventRecord.Location = New System.Drawing.Point(54, 95)
        Me.btnEventRecord.Name = "btnEventRecord"
        Me.btnEventRecord.Size = New System.Drawing.Size(160, 29)
        Me.btnEventRecord.TabIndex = 1
        Me.btnEventRecord.Text = "Event Record"
        Me.btnEventRecord.UseVisualStyleBackColor = True
        '
        'btnCommitteeBoard
        '
        Me.btnCommitteeBoard.Location = New System.Drawing.Point(54, 151)
        Me.btnCommitteeBoard.Name = "btnCommitteeBoard"
        Me.btnCommitteeBoard.Size = New System.Drawing.Size(160, 29)
        Me.btnCommitteeBoard.TabIndex = 2
        Me.btnCommitteeBoard.Text = "Committee Board"
        Me.btnCommitteeBoard.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(106, 52)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 16)
        Me.LinkLabel1.TabIndex = 3
        '
        'btnPresentList
        '
        Me.btnPresentList.Location = New System.Drawing.Point(54, 205)
        Me.btnPresentList.Name = "btnPresentList"
        Me.btnPresentList.Size = New System.Drawing.Size(160, 29)
        Me.btnPresentList.TabIndex = 5
        Me.btnPresentList.Text = "Present List"
        Me.btnPresentList.UseVisualStyleBackColor = True
        '
        'btnPotentialContestants
        '
        Me.btnPotentialContestants.Location = New System.Drawing.Point(54, 262)
        Me.btnPotentialContestants.Name = "btnPotentialContestants"
        Me.btnPotentialContestants.Size = New System.Drawing.Size(160, 29)
        Me.btnPotentialContestants.TabIndex = 6
        Me.btnPotentialContestants.Text = "Potential Contestant List"
        Me.btnPotentialContestants.UseVisualStyleBackColor = True
        '
        'lnkHelp
        '
        Me.lnkHelp.AutoSize = True
        Me.lnkHelp.Location = New System.Drawing.Point(205, 9)
        Me.lnkHelp.Name = "lnkHelp"
        Me.lnkHelp.Size = New System.Drawing.Size(37, 16)
        Me.lnkHelp.TabIndex = 61
        Me.lnkHelp.TabStop = True
        Me.lnkHelp.Text = "Help"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(254, 335)
        Me.Controls.Add(Me.lnkHelp)
        Me.Controls.Add(Me.btnPotentialContestants)
        Me.Controls.Add(Me.btnPresentList)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnCommitteeBoard)
        Me.Controls.Add(Me.btnEventRecord)
        Me.Controls.Add(Me.btnMemberRecord)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMemberRecord As System.Windows.Forms.Button
    Friend WithEvents btnEventRecord As System.Windows.Forms.Button
    Friend WithEvents btnCommitteeBoard As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnPresentList As System.Windows.Forms.Button
    Friend WithEvents btnPotentialContestants As System.Windows.Forms.Button
    Friend WithEvents lnkHelp As System.Windows.Forms.LinkLabel

End Class
