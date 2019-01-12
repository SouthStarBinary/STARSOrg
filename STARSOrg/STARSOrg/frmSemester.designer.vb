<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemester
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMember = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRole = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEvent = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRSVP = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCourse = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSemester = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbTutor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLogOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.grpEditSemester = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtModSemDesc = New System.Windows.Forms.TextBox()
        Me.lstSemesters = New System.Windows.Forms.ListBox()
        Me.btnSemModify = New System.Windows.Forms.Button()
        Me.txtModSemID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpNewSemester = New System.Windows.Forms.GroupBox()
        Me.txtNewSemDesc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSemSave = New System.Windows.Forms.Button()
        Me.txtNewSemID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSemReport = New System.Windows.Forms.Button()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslSemStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsbAdmin = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.grpEditSemester.SuspendLayout()
        Me.grpNewSemester.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(760, 57)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SEMESTERS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.tsbHome, Me.ToolStripSeparator2, Me.tsbMember, Me.ToolStripSeparator3, Me.tsbRole, Me.ToolStripSeparator4, Me.tsbEvent, Me.ToolStripSeparator5, Me.tsbRSVP, Me.ToolStripSeparator10, Me.tsbCourse, Me.ToolStripSeparator7, Me.tsbSemester, Me.ToolStripSeparator8, Me.tsbTutor, Me.ToolStripSeparator9, Me.ToolStripSeparator1, Me.tsbHelp, Me.ToolStripSeparator11, Me.tsbLogOut, Me.ToolStripSeparator12, Me.tsbAdmin})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 50)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHome
        '
        Me.tsbHome.AutoSize = False
        Me.tsbHome.BackgroundImage = Global.STARSOrg.My.Resources.Resources.home
        Me.tsbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHome.Name = "tsbHome"
        Me.tsbHome.Size = New System.Drawing.Size(48, 48)
        Me.tsbHome.Text = "HOME"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(10, 50)
        '
        'tsbMember
        '
        Me.tsbMember.AutoSize = False
        Me.tsbMember.BackgroundImage = Global.STARSOrg.My.Resources.Resources.member
        Me.tsbMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMember.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMember.Name = "tsbMember"
        Me.tsbMember.Size = New System.Drawing.Size(48, 48)
        Me.tsbMember.Text = "MEMBER"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRole
        '
        Me.tsbRole.AutoSize = False
        Me.tsbRole.BackgroundImage = Global.STARSOrg.My.Resources.Resources.roles
        Me.tsbRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRole.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRole.Name = "tsbRole"
        Me.tsbRole.Size = New System.Drawing.Size(48, 48)
        Me.tsbRole.Text = "ROLE"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(10, 50)
        '
        'tsbEvent
        '
        Me.tsbEvent.AutoSize = False
        Me.tsbEvent.BackgroundImage = Global.STARSOrg.My.Resources.Resources.events
        Me.tsbEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEvent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEvent.Name = "tsbEvent"
        Me.tsbEvent.Size = New System.Drawing.Size(48, 48)
        Me.tsbEvent.Text = "EVENT"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRSVP
        '
        Me.tsbRSVP.AutoSize = False
        Me.tsbRSVP.BackgroundImage = Global.STARSOrg.My.Resources.Resources.rsvp
        Me.tsbRSVP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRSVP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRSVP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRSVP.Name = "tsbRSVP"
        Me.tsbRSVP.Size = New System.Drawing.Size(48, 48)
        Me.tsbRSVP.Text = "RSVP"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.AutoSize = False
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(10, 50)
        '
        'tsbCourse
        '
        Me.tsbCourse.AutoSize = False
        Me.tsbCourse.BackgroundImage = Global.STARSOrg.My.Resources.Resources.courses
        Me.tsbCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCourse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCourse.Name = "tsbCourse"
        Me.tsbCourse.Size = New System.Drawing.Size(48, 48)
        Me.tsbCourse.Text = "COURSE"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.AutoSize = False
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(10, 50)
        '
        'tsbSemester
        '
        Me.tsbSemester.AutoSize = False
        Me.tsbSemester.BackgroundImage = Global.STARSOrg.My.Resources.Resources.semesters
        Me.tsbSemester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbSemester.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSemester.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSemester.Name = "tsbSemester"
        Me.tsbSemester.Size = New System.Drawing.Size(48, 48)
        Me.tsbSemester.Text = "SEMESTER"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(10, 50)
        '
        'tsbTutor
        '
        Me.tsbTutor.AutoSize = False
        Me.tsbTutor.BackgroundImage = Global.STARSOrg.My.Resources.Resources.tutors
        Me.tsbTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbTutor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbTutor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTutor.Name = "tsbTutor"
        Me.tsbTutor.Size = New System.Drawing.Size(48, 48)
        Me.tsbTutor.Text = "TUTOR"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.AutoSize = False
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(10, 50)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHelp
        '
        Me.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbHelp.AutoSize = False
        Me.tsbHelp.BackgroundImage = Global.STARSOrg.My.Resources.Resources.help
        Me.tsbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHelp.Name = "tsbHelp"
        Me.tsbHelp.Size = New System.Drawing.Size(48, 48)
        Me.tsbHelp.Text = "HELP"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator11.AutoSize = False
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(10, 50)
        '
        'tsbLogOut
        '
        Me.tsbLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbLogOut.AutoSize = False
        Me.tsbLogOut.BackgroundImage = Global.STARSOrg.My.Resources.Resources.logout
        Me.tsbLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLogOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogOut.Name = "tsbLogOut"
        Me.tsbLogOut.Size = New System.Drawing.Size(48, 48)
        Me.tsbLogOut.Text = "LOGOUT"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator12.AutoSize = False
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(10, 50)
        '
        'grpEditSemester
        '
        Me.grpEditSemester.Controls.Add(Me.Label6)
        Me.grpEditSemester.Controls.Add(Me.Label5)
        Me.grpEditSemester.Controls.Add(Me.txtModSemDesc)
        Me.grpEditSemester.Controls.Add(Me.lstSemesters)
        Me.grpEditSemester.Controls.Add(Me.btnSemModify)
        Me.grpEditSemester.Controls.Add(Me.txtModSemID)
        Me.grpEditSemester.Controls.Add(Me.Label2)
        Me.grpEditSemester.Location = New System.Drawing.Point(406, 136)
        Me.grpEditSemester.Name = "grpEditSemester"
        Me.grpEditSemester.Size = New System.Drawing.Size(333, 291)
        Me.grpEditSemester.TabIndex = 11
        Me.grpEditSemester.TabStop = False
        Me.grpEditSemester.Text = "Edit Semester"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Semester Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Semester ID"
        '
        'txtModSemDesc
        '
        Me.txtModSemDesc.Location = New System.Drawing.Point(121, 206)
        Me.txtModSemDesc.MaxLength = 100
        Me.txtModSemDesc.Name = "txtModSemDesc"
        Me.txtModSemDesc.Size = New System.Drawing.Size(200, 20)
        Me.txtModSemDesc.TabIndex = 5
        '
        'lstSemesters
        '
        Me.lstSemesters.FormattingEnabled = True
        Me.lstSemesters.Location = New System.Drawing.Point(121, 30)
        Me.lstSemesters.Name = "lstSemesters"
        Me.lstSemesters.Size = New System.Drawing.Size(200, 108)
        Me.lstSemesters.TabIndex = 4
        '
        'btnSemModify
        '
        Me.btnSemModify.Location = New System.Drawing.Point(118, 249)
        Me.btnSemModify.Name = "btnSemModify"
        Me.btnSemModify.Size = New System.Drawing.Size(100, 25)
        Me.btnSemModify.TabIndex = 6
        Me.btnSemModify.Text = "Modify"
        Me.btnSemModify.UseVisualStyleBackColor = True
        '
        'txtModSemID
        '
        Me.txtModSemID.Location = New System.Drawing.Point(121, 163)
        Me.txtModSemID.MaxLength = 4
        Me.txtModSemID.Name = "txtModSemID"
        Me.txtModSemID.ReadOnly = True
        Me.txtModSemID.Size = New System.Drawing.Size(200, 20)
        Me.txtModSemID.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "List of Semesters"
        '
        'grpNewSemester
        '
        Me.grpNewSemester.Controls.Add(Me.txtNewSemDesc)
        Me.grpNewSemester.Controls.Add(Me.Label4)
        Me.grpNewSemester.Controls.Add(Me.btnSemSave)
        Me.grpNewSemester.Controls.Add(Me.txtNewSemID)
        Me.grpNewSemester.Controls.Add(Me.Label3)
        Me.grpNewSemester.Location = New System.Drawing.Point(25, 136)
        Me.grpNewSemester.Name = "grpNewSemester"
        Me.grpNewSemester.Size = New System.Drawing.Size(335, 176)
        Me.grpNewSemester.TabIndex = 10
        Me.grpNewSemester.TabStop = False
        Me.grpNewSemester.Text = "New Semester"
        '
        'txtNewSemDesc
        '
        Me.txtNewSemDesc.Location = New System.Drawing.Point(157, 77)
        Me.txtNewSemDesc.MaxLength = 100
        Me.txtNewSemDesc.Name = "txtNewSemDesc"
        Me.txtNewSemDesc.Size = New System.Drawing.Size(159, 20)
        Me.txtNewSemDesc.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "New Semester Description"
        '
        'btnSemSave
        '
        Me.btnSemSave.Location = New System.Drawing.Point(116, 123)
        Me.btnSemSave.Name = "btnSemSave"
        Me.btnSemSave.Size = New System.Drawing.Size(100, 25)
        Me.btnSemSave.TabIndex = 3
        Me.btnSemSave.Text = "Save"
        Me.btnSemSave.UseVisualStyleBackColor = True
        '
        'txtNewSemID
        '
        Me.txtNewSemID.Location = New System.Drawing.Point(157, 39)
        Me.txtNewSemID.MaxLength = 4
        Me.txtNewSemID.Name = "txtNewSemID"
        Me.txtNewSemID.Size = New System.Drawing.Size(159, 20)
        Me.txtNewSemID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "New Semester ID"
        '
        'btnSemReport
        '
        Me.btnSemReport.Location = New System.Drawing.Point(94, 348)
        Me.btnSemReport.Name = "btnSemReport"
        Me.btnSemReport.Size = New System.Drawing.Size(200, 50)
        Me.btnSemReport.TabIndex = 7
        Me.btnSemReport.Text = "View Report"
        Me.btnSemReport.UseVisualStyleBackColor = True
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslSemStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslSemStatus
        '
        Me.tslSemStatus.AutoSize = False
        Me.tslSemStatus.Name = "tslSemStatus"
        Me.tslSemStatus.Size = New System.Drawing.Size(600, 17)
        '
        'tsbAdmin
        '
        Me.tsbAdmin.BackgroundImage = Global.STARSOrg.My.Resources.Resources.STARS_National_LOGO
        Me.tsbAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsbAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAdmin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdmin.Name = "tsbAdmin"
        Me.tsbAdmin.Size = New System.Drawing.Size(23, 47)
        Me.tsbAdmin.Text = "ADMIN"
        Me.tsbAdmin.Visible = False
        '
        'frmSemester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnSemReport)
        Me.Controls.Add(Me.grpEditSemester)
        Me.Controls.Add(Me.grpNewSemester)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSemester"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Semester Management"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpEditSemester.ResumeLayout(False)
        Me.grpEditSemester.PerformLayout()
        Me.grpNewSemester.ResumeLayout(False)
        Me.grpNewSemester.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbHome As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbMember As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbRole As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbEvent As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbRSVP As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents tsbCourse As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsbSemester As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tsbTutor As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbHelp As ToolStripButton
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents tsbLogOut As ToolStripButton
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents grpEditSemester As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtModSemDesc As TextBox
    Friend WithEvents lstSemesters As ListBox
    Friend WithEvents btnSemModify As Button
    Friend WithEvents txtModSemID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents grpNewSemester As GroupBox
    Friend WithEvents txtNewSemDesc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSemSave As Button
    Friend WithEvents txtNewSemID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSemReport As Button
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tslSemStatus As ToolStripStatusLabel
    Friend WithEvents tsbAdmin As ToolStripButton
End Class
