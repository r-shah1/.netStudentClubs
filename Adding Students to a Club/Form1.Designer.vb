<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstAllStudents = New System.Windows.Forms.ListBox()
        Me.lstMemberStudents = New System.Windows.Forms.ListBox()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnRemoveStudent = New System.Windows.Forms.Button()
        Me.lblClubTotalMembers = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboClubs = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(62, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(733, 428)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(89, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Current Club:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "General Student List"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(444, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Membership List"
        '
        'lstAllStudents
        '
        Me.lstAllStudents.FormattingEnabled = True
        Me.lstAllStudents.ItemHeight = 16
        Me.lstAllStudents.Items.AddRange(New Object() {"Adams, Ben", "Baker, Sally", "Canseco, Juan", "Davis, Sharon", "Etienne, Jean", "Gonzalez, Jose", "Johnson, Eric", "Koenig, Johann", "Matsunaga, Akiko", "Nakamura, Ken", "Ramirez Maria"})
        Me.lstAllStudents.Location = New System.Drawing.Point(92, 213)
        Me.lstAllStudents.Name = "lstAllStudents"
        Me.lstAllStudents.Size = New System.Drawing.Size(176, 244)
        Me.lstAllStudents.TabIndex = 5
        '
        'lstMemberStudents
        '
        Me.lstMemberStudents.FormattingEnabled = True
        Me.lstMemberStudents.ItemHeight = 16
        Me.lstMemberStudents.Location = New System.Drawing.Point(447, 213)
        Me.lstMemberStudents.Name = "lstMemberStudents"
        Me.lstMemberStudents.Size = New System.Drawing.Size(176, 244)
        Me.lstMemberStudents.TabIndex = 6
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Location = New System.Drawing.Point(311, 282)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(96, 96)
        Me.btnAddStudent.TabIndex = 7
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'btnRemoveStudent
        '
        Me.btnRemoveStudent.Location = New System.Drawing.Point(654, 282)
        Me.btnRemoveStudent.Name = "btnRemoveStudent"
        Me.btnRemoveStudent.Size = New System.Drawing.Size(96, 96)
        Me.btnRemoveStudent.TabIndex = 8
        Me.btnRemoveStudent.Text = "Remove Student"
        Me.btnRemoveStudent.UseVisualStyleBackColor = True
        '
        'lblClubTotalMembers
        '
        Me.lblClubTotalMembers.Location = New System.Drawing.Point(629, 411)
        Me.lblClubTotalMembers.Name = "lblClubTotalMembers"
        Me.lblClubTotalMembers.Size = New System.Drawing.Size(146, 21)
        Me.lblClubTotalMembers.TabIndex = 9
        Me.lblClubTotalMembers.Text = "0 Members"
        Me.lblClubTotalMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(62, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(713, 48)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Location = New System.Drawing.Point(62, 469)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(733, 27)
        Me.lblStatus.TabIndex = 11
        '
        'cboClubs
        '
        Me.cboClubs.FormattingEnabled = True
        Me.cboClubs.Location = New System.Drawing.Point(271, 108)
        Me.cboClubs.Name = "cboClubs"
        Me.cboClubs.Size = New System.Drawing.Size(162, 24)
        Me.cboClubs.TabIndex = 12
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(341, 499)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(171, 47)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 558)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.cboClubs)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblClubTotalMembers)
        Me.Controls.Add(Me.btnRemoveStudent)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.lstMemberStudents)
        Me.Controls.Add(Me.lstAllStudents)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lstAllStudents As ListBox
    Friend WithEvents lstMemberStudents As ListBox
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnRemoveStudent As Button
    Friend WithEvents lblClubTotalMembers As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents cboClubs As ComboBox
    Friend WithEvents btnClose As Button
End Class
