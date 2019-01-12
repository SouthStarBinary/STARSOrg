<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvent
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
        Me.btnSaveEvent = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtEventID = New System.Windows.Forms.TextBox()
        Me.txtEventDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEventTypeID = New System.Windows.Forms.TextBox()
        Me.txtSemesterID = New System.Windows.Forms.TextBox()
        Me.dtmStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtmEndDate = New System.Windows.Forms.DateTimePicker()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMember = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRoles = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEvent = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRSVP = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCourse = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSemester = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLogOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbTutor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpEdit = New System.Windows.Forms.GroupBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.grpNew = New System.Windows.Forms.GroupBox()
        Me.lstEvents = New System.Windows.Forms.ListBox()
        Me.grpEvents = New System.Windows.Forms.GroupBox()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tsbAdmin = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.grpEdit.SuspendLayout()
        Me.grpNew.SuspendLayout()
        Me.grpEvents.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaveEvent
        '
        Me.btnSaveEvent.Location = New System.Drawing.Point(66, 320)
        Me.btnSaveEvent.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSaveEvent.Name = "btnSaveEvent"
        Me.btnSaveEvent.Size = New System.Drawing.Size(176, 34)
        Me.btnSaveEvent.TabIndex = 0
        Me.btnSaveEvent.Text = "Save Event"
        Me.btnSaveEvent.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(260, 320)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 34)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtEventID
        '
        Me.txtEventID.Location = New System.Drawing.Point(167, 32)
        Me.txtEventID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEventID.MaxLength = 4
        Me.txtEventID.Name = "txtEventID"
        Me.txtEventID.ReadOnly = True
        Me.txtEventID.Size = New System.Drawing.Size(179, 20)
        Me.txtEventID.TabIndex = 2
        '
        'txtEventDescription
        '
        Me.txtEventDescription.Location = New System.Drawing.Point(167, 69)
        Me.txtEventDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEventDescription.MaxLength = 500
        Me.txtEventDescription.Multiline = True
        Me.txtEventDescription.Name = "txtEventDescription"
        Me.txtEventDescription.Size = New System.Drawing.Size(179, 43)
        Me.txtEventDescription.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Event ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Event Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 133)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Event Type ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Semester ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 210)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Start Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 247)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "End Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 283)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Location:"
        '
        'txtEventTypeID
        '
        Me.txtEventTypeID.Location = New System.Drawing.Point(167, 131)
        Me.txtEventTypeID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEventTypeID.MaxLength = 15
        Me.txtEventTypeID.Name = "txtEventTypeID"
        Me.txtEventTypeID.Size = New System.Drawing.Size(179, 20)
        Me.txtEventTypeID.TabIndex = 11
        '
        'txtSemesterID
        '
        Me.txtSemesterID.Location = New System.Drawing.Point(167, 168)
        Me.txtSemesterID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSemesterID.MaxLength = 4
        Me.txtSemesterID.Name = "txtSemesterID"
        Me.txtSemesterID.Size = New System.Drawing.Size(179, 20)
        Me.txtSemesterID.TabIndex = 12
        '
        'dtmStartDate
        '
        Me.dtmStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmStartDate.Location = New System.Drawing.Point(167, 206)
        Me.dtmStartDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtmStartDate.Name = "dtmStartDate"
        Me.dtmStartDate.Size = New System.Drawing.Size(179, 20)
        Me.dtmStartDate.TabIndex = 13
        '
        'dtmEndDate
        '
        Me.dtmEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmEndDate.Location = New System.Drawing.Point(167, 243)
        Me.dtmEndDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtmEndDate.Name = "dtmEndDate"
        Me.dtmEndDate.Size = New System.Drawing.Size(179, 20)
        Me.dtmEndDate.TabIndex = 14
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(167, 280)
        Me.txtLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLocation.MaxLength = 50
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(179, 20)
        Me.txtLocation.TabIndex = 15
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbHome, Me.ToolStripSeparator2, Me.tsbMember, Me.ToolStripSeparator3, Me.tsbRoles, Me.ToolStripSeparator4, Me.tsbEvent, Me.ToolStripSeparator5, Me.tsbRSVP, Me.ToolStripSeparator6, Me.tsbCourse, Me.ToolStripSeparator7, Me.tsbSemester, Me.ToolStripSeparator10, Me.tsbLogOut, Me.ToolStripSeparator8, Me.ToolStripSeparator9, Me.tsbHelp, Me.ToolStripSeparator1, Me.tsbTutor, Me.ToolStripSeparator11, Me.tsbAdmin})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(804, 50)
        Me.ToolStrip1.TabIndex = 18
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'tsbRoles
        '
        Me.tsbRoles.AutoSize = False
        Me.tsbRoles.BackgroundImage = Global.STARSOrg.My.Resources.Resources.roles
        Me.tsbRoles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRoles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRoles.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRoles.Name = "tsbRoles"
        Me.tsbRoles.Size = New System.Drawing.Size(48, 48)
        Me.tsbRoles.Text = "ROLES"
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
        Me.tsbEvent.Text = "EVENTS"
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
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(10, 50)
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
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator10.AutoSize = False
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(10, 50)
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
        Me.tsbLogOut.Text = "LOG OUT"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(10, 50)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator9.AutoSize = False
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(10, 50)
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(10, 50)
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
        Me.tsbTutor.Text = "SEMESTER"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.AutoSize = False
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(10, 50)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(61, 32)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Event ID:"
        '
        'grpEdit
        '
        Me.grpEdit.Controls.Add(Me.Label8)
        Me.grpEdit.Controls.Add(Me.txtLocation)
        Me.grpEdit.Controls.Add(Me.dtmEndDate)
        Me.grpEdit.Controls.Add(Me.dtmStartDate)
        Me.grpEdit.Controls.Add(Me.txtSemesterID)
        Me.grpEdit.Controls.Add(Me.btnSaveEvent)
        Me.grpEdit.Controls.Add(Me.btnCancel)
        Me.grpEdit.Controls.Add(Me.txtEventTypeID)
        Me.grpEdit.Controls.Add(Me.Label7)
        Me.grpEdit.Controls.Add(Me.Label6)
        Me.grpEdit.Controls.Add(Me.Label5)
        Me.grpEdit.Controls.Add(Me.Label4)
        Me.grpEdit.Controls.Add(Me.Label3)
        Me.grpEdit.Controls.Add(Me.Label2)
        Me.grpEdit.Controls.Add(Me.txtEventDescription)
        Me.grpEdit.Controls.Add(Me.txtEventID)
        Me.grpEdit.Location = New System.Drawing.Point(372, 70)
        Me.grpEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.grpEdit.Name = "grpEdit"
        Me.grpEdit.Padding = New System.Windows.Forms.Padding(2)
        Me.grpEdit.Size = New System.Drawing.Size(390, 373)
        Me.grpEdit.TabIndex = 20
        Me.grpEdit.TabStop = False
        Me.grpEdit.Text = "Edit Event"
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.Location = New System.Drawing.Point(26, 28)
        Me.chkNew.Margin = New System.Windows.Forms.Padding(2)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(101, 17)
        Me.chkNew.TabIndex = 21
        Me.chkNew.Text = "Add New Event"
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'grpNew
        '
        Me.grpNew.Controls.Add(Me.chkNew)
        Me.grpNew.Location = New System.Drawing.Point(28, 102)
        Me.grpNew.Margin = New System.Windows.Forms.Padding(2)
        Me.grpNew.Name = "grpNew"
        Me.grpNew.Padding = New System.Windows.Forms.Padding(2)
        Me.grpNew.Size = New System.Drawing.Size(243, 70)
        Me.grpNew.TabIndex = 22
        Me.grpNew.TabStop = False
        Me.grpNew.Text = "New Event"
        '
        'lstEvents
        '
        Me.lstEvents.FormattingEnabled = True
        Me.lstEvents.Location = New System.Drawing.Point(23, 38)
        Me.lstEvents.Margin = New System.Windows.Forms.Padding(2)
        Me.lstEvents.Name = "lstEvents"
        Me.lstEvents.Size = New System.Drawing.Size(197, 173)
        Me.lstEvents.TabIndex = 23
        '
        'grpEvents
        '
        Me.grpEvents.Controls.Add(Me.lstEvents)
        Me.grpEvents.Location = New System.Drawing.Point(28, 203)
        Me.grpEvents.Margin = New System.Windows.Forms.Padding(2)
        Me.grpEvents.Name = "grpEvents"
        Me.grpEvents.Padding = New System.Windows.Forms.Padding(2)
        Me.grpEvents.Size = New System.Drawing.Size(243, 240)
        Me.grpEvents.TabIndex = 24
        Me.grpEvents.TabStop = False
        Me.grpEvents.Text = "Events"
        '
        'errP
        '
        Me.errP.ContainerControl = Me
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
        'frmEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 453)
        Me.Controls.Add(Me.grpEvents)
        Me.Controls.Add(Me.grpNew)
        Me.Controls.Add(Me.grpEdit)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmEvent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add or Update Event"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpEdit.ResumeLayout(False)
        Me.grpEdit.PerformLayout()
        Me.grpNew.ResumeLayout(False)
        Me.grpNew.PerformLayout()
        Me.grpEvents.ResumeLayout(False)
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSaveEvent As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtEventID As TextBox
    Friend WithEvents txtEventDescription As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEventTypeID As TextBox
    Friend WithEvents txtSemesterID As TextBox
    Friend WithEvents dtmStartDate As DateTimePicker
    Friend WithEvents dtmEndDate As DateTimePicker
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbHome As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbMember As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbRoles As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbEvent As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbRSVP As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbCourse As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsbSemester As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents tsbLogOut As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents tsbHelp As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbTutor As ToolStripButton
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents Label8 As Label
    Friend WithEvents grpEdit As GroupBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents grpNew As GroupBox
    Friend WithEvents lstEvents As ListBox
    Friend WithEvents grpEvents As GroupBox
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents tsbAdmin As ToolStripButton
End Class
