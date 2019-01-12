<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMember
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
        Me.grpMembers = New System.Windows.Forms.GroupBox()
        Me.lstMembers = New System.Windows.Forms.ListBox()
        Me.grpNewMember = New System.Windows.Forms.GroupBox()
        Me.chkNewMem = New System.Windows.Forms.CheckBox()
        Me.grpAddMember = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPID = New System.Windows.Forms.TextBox()
        Me.mskPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtPhoto = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtMI = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.btnReload = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtVal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.picMember = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMember = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRole = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEvent = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRSVP = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCourse = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSemester = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLogOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbTutor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.tsbAdmin = New System.Windows.Forms.ToolStripButton()
        Me.grpMembers.SuspendLayout()
        Me.grpNewMember.SuspendLayout()
        Me.grpAddMember.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(927, 45)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "MEMBERS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpMembers
        '
        Me.grpMembers.Controls.Add(Me.lstMembers)
        Me.grpMembers.Location = New System.Drawing.Point(24, 290)
        Me.grpMembers.Name = "grpMembers"
        Me.grpMembers.Size = New System.Drawing.Size(276, 176)
        Me.grpMembers.TabIndex = 11
        Me.grpMembers.TabStop = False
        Me.grpMembers.Text = "Members"
        '
        'lstMembers
        '
        Me.lstMembers.FormattingEnabled = True
        Me.lstMembers.HorizontalScrollbar = True
        Me.lstMembers.Location = New System.Drawing.Point(15, 20)
        Me.lstMembers.Name = "lstMembers"
        Me.lstMembers.Size = New System.Drawing.Size(251, 147)
        Me.lstMembers.TabIndex = 2
        '
        'grpNewMember
        '
        Me.grpNewMember.Controls.Add(Me.chkNewMem)
        Me.grpNewMember.Location = New System.Drawing.Point(24, 126)
        Me.grpNewMember.Name = "grpNewMember"
        Me.grpNewMember.Size = New System.Drawing.Size(276, 48)
        Me.grpNewMember.TabIndex = 10
        Me.grpNewMember.TabStop = False
        Me.grpNewMember.Text = "Add"
        '
        'chkNewMem
        '
        Me.chkNewMem.AutoSize = True
        Me.chkNewMem.Location = New System.Drawing.Point(24, 21)
        Me.chkNewMem.Name = "chkNewMem"
        Me.chkNewMem.Size = New System.Drawing.Size(111, 17)
        Me.chkNewMem.TabIndex = 0
        Me.chkNewMem.Text = "Add New Member"
        Me.chkNewMem.UseVisualStyleBackColor = True
        '
        'grpAddMember
        '
        Me.grpAddMember.Controls.Add(Me.btnCancel)
        Me.grpAddMember.Controls.Add(Me.btnSave)
        Me.grpAddMember.Controls.Add(Me.txtPID)
        Me.grpAddMember.Controls.Add(Me.mskPhone)
        Me.grpAddMember.Controls.Add(Me.txtPhoto)
        Me.grpAddMember.Controls.Add(Me.txtEmail)
        Me.grpAddMember.Controls.Add(Me.txtLName)
        Me.grpAddMember.Controls.Add(Me.txtMI)
        Me.grpAddMember.Controls.Add(Me.txtFName)
        Me.grpAddMember.Controls.Add(Me.Label4)
        Me.grpAddMember.Controls.Add(Me.Label7)
        Me.grpAddMember.Controls.Add(Me.Label8)
        Me.grpAddMember.Controls.Add(Me.Label6)
        Me.grpAddMember.Controls.Add(Me.Label5)
        Me.grpAddMember.Controls.Add(Me.Label3)
        Me.grpAddMember.Controls.Add(Me.Label2)
        Me.grpAddMember.Location = New System.Drawing.Point(327, 126)
        Me.grpAddMember.Name = "grpAddMember"
        Me.grpAddMember.Size = New System.Drawing.Size(375, 308)
        Me.grpAddMember.TabIndex = 12
        Me.grpAddMember.TabStop = False
        Me.grpAddMember.Text = "Add New Member"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(236, 265)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 30)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(93, 265)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(127, 30)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtPID
        '
        Me.txtPID.Location = New System.Drawing.Point(93, 36)
        Me.txtPID.MaxLength = 7
        Me.txtPID.Name = "txtPID"
        Me.txtPID.Size = New System.Drawing.Size(266, 20)
        Me.txtPID.TabIndex = 3
        '
        'mskPhone
        '
        Me.mskPhone.Location = New System.Drawing.Point(92, 201)
        Me.mskPhone.Mask = "(999) 000-0000"
        Me.mskPhone.Name = "mskPhone"
        Me.mskPhone.Size = New System.Drawing.Size(267, 20)
        Me.mskPhone.TabIndex = 8
        '
        'txtPhoto
        '
        Me.txtPhoto.Location = New System.Drawing.Point(93, 234)
        Me.txtPhoto.MaxLength = 30
        Me.txtPhoto.Name = "txtPhoto"
        Me.txtPhoto.Size = New System.Drawing.Size(266, 20)
        Me.txtPhoto.TabIndex = 9
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(93, 168)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(266, 20)
        Me.txtEmail.TabIndex = 7
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(93, 135)
        Me.txtLName.MaxLength = 75
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(266, 20)
        Me.txtLName.TabIndex = 6
        '
        'txtMI
        '
        Me.txtMI.Location = New System.Drawing.Point(93, 102)
        Me.txtMI.MaxLength = 1
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(266, 20)
        Me.txtMI.TabIndex = 5
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(93, 69)
        Me.txtFName.MaxLength = 50
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(266, 20)
        Me.txtFName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "PID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Middle Initial"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Photo Path"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First Name"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(563, 440)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(124, 26)
        Me.btnPrint.TabIndex = 12
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.btnReload)
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.txtVal)
        Me.grpSearch.Controls.Add(Me.Label9)
        Me.grpSearch.Location = New System.Drawing.Point(24, 180)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(276, 98)
        Me.grpSearch.TabIndex = 16
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search By Last Name"
        '
        'btnReload
        '
        Me.btnReload.Location = New System.Drawing.Point(14, 57)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(123, 26)
        Me.btnReload.TabIndex = 5
        Me.btnReload.Text = "Reload"
        Me.btnReload.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(143, 57)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(123, 26)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtVal
        '
        Me.txtVal.Location = New System.Drawing.Point(92, 31)
        Me.txtVal.Name = "txtVal"
        Me.txtVal.Size = New System.Drawing.Size(174, 20)
        Me.txtVal.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Search Value:"
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'picMember
        '
        Me.picMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMember.Location = New System.Drawing.Point(723, 153)
        Me.picMember.Name = "picMember"
        Me.picMember.Size = New System.Drawing.Size(228, 242)
        Me.picMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMember.TabIndex = 15
        Me.picMember.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator11, Me.tsbHome, Me.ToolStripSeparator1, Me.tsbMember, Me.ToolStripSeparator2, Me.tsbRole, Me.ToolStripSeparator3, Me.tsbEvent, Me.ToolStripSeparator4, Me.tsbRSVP, Me.ToolStripSeparator5, Me.tsbCourse, Me.ToolStripSeparator6, Me.tsbSemester, Me.ToolStripSeparator8, Me.tsbLogOut, Me.ToolStripSeparator7, Me.tsbHelp, Me.ToolStripSeparator9, Me.ToolStripSeparator10, Me.tsbTutor, Me.ToolStripSeparator12, Me.tsbAdmin})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(978, 50)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.AutoSize = False
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHome
        '
        Me.tsbHome.AutoSize = False
        Me.tsbHome.BackgroundImage = Global.STARSOrg.My.Resources.Resources.home
        Me.tsbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHome.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHome.Name = "tsbHome"
        Me.tsbHome.Size = New System.Drawing.Size(48, 48)
        Me.tsbHome.Text = "HOME"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(10, 50)
        '
        'tsbMember
        '
        Me.tsbMember.AutoSize = False
        Me.tsbMember.BackgroundImage = Global.STARSOrg.My.Resources.Resources.member
        Me.tsbMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMember.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.tsbMember.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMember.Name = "tsbMember"
        Me.tsbMember.Size = New System.Drawing.Size(48, 48)
        Me.tsbMember.Text = "MEMBER"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRole
        '
        Me.tsbRole.AutoSize = False
        Me.tsbRole.BackgroundImage = Global.STARSOrg.My.Resources.Resources.roles
        Me.tsbRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRole.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.tsbRole.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRole.Name = "tsbRole"
        Me.tsbRole.Size = New System.Drawing.Size(48, 48)
        Me.tsbRole.Text = "ROLES"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(10, 50)
        '
        'tsbEvent
        '
        Me.tsbEvent.AutoSize = False
        Me.tsbEvent.BackgroundImage = Global.STARSOrg.My.Resources.Resources.events
        Me.tsbEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEvent.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.tsbEvent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEvent.Name = "tsbEvent"
        Me.tsbEvent.Size = New System.Drawing.Size(48, 48)
        Me.tsbEvent.Text = "EVENTS"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRSVP
        '
        Me.tsbRSVP.AutoSize = False
        Me.tsbRSVP.BackgroundImage = Global.STARSOrg.My.Resources.Resources.rsvp
        Me.tsbRSVP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRSVP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRSVP.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.tsbRSVP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRSVP.Name = "tsbRSVP"
        Me.tsbRSVP.Size = New System.Drawing.Size(48, 48)
        Me.tsbRSVP.Text = "RSVP"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(10, 50)
        '
        'tsbCourse
        '
        Me.tsbCourse.AutoSize = False
        Me.tsbCourse.BackgroundImage = Global.STARSOrg.My.Resources.Resources.courses
        Me.tsbCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCourse.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.tsbCourse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCourse.Name = "tsbCourse"
        Me.tsbCourse.Size = New System.Drawing.Size(48, 48)
        Me.tsbCourse.Text = "COURSES"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(10, 50)
        '
        'tsbSemester
        '
        Me.tsbSemester.AutoSize = False
        Me.tsbSemester.BackgroundImage = Global.STARSOrg.My.Resources.Resources.semesters
        Me.tsbSemester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbSemester.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSemester.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.tsbSemester.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSemester.Name = "tsbSemester"
        Me.tsbSemester.Size = New System.Drawing.Size(48, 48)
        Me.tsbSemester.Text = "SEMESTER"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(10, 50)
        '
        'tsbLogOut
        '
        Me.tsbLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbLogOut.AutoSize = False
        Me.tsbLogOut.BackgroundImage = Global.STARSOrg.My.Resources.Resources.logout
        Me.tsbLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLogOut.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.tsbLogOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogOut.Name = "tsbLogOut"
        Me.tsbLogOut.Size = New System.Drawing.Size(48, 48)
        Me.tsbLogOut.Text = "LOG OUT"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator7.AutoSize = False
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHelp
        '
        Me.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbHelp.AutoSize = False
        Me.tsbHelp.BackgroundImage = Global.STARSOrg.My.Resources.Resources.help
        Me.tsbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHelp.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHelp.Name = "tsbHelp"
        Me.tsbHelp.Size = New System.Drawing.Size(48, 48)
        Me.tsbHelp.Text = "HELP"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator9.AutoSize = False
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(10, 50)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.AutoSize = False
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(10, 50)
        '
        'tsbTutor
        '
        Me.tsbTutor.AutoSize = False
        Me.tsbTutor.BackgroundImage = Global.STARSOrg.My.Resources.Resources.tutors
        Me.tsbTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbTutor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbTutor.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.tsbTutor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTutor.Name = "tsbTutor"
        Me.tsbTutor.Size = New System.Drawing.Size(48, 48)
        Me.tsbTutor.Text = "TUTORS"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.AutoSize = False
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(10, 50)
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(863, 401)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(88, 33)
        Me.btnBrowse.TabIndex = 18
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'ofdOpen
        '
        Me.ofdOpen.FileName = "OpenFileDialog1"
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
        'frmMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.picMember)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.grpAddMember)
        Me.Controls.Add(Me.grpMembers)
        Me.Controls.Add(Me.grpNewMember)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMember"
        Me.grpMembers.ResumeLayout(False)
        Me.grpNewMember.ResumeLayout(False)
        Me.grpNewMember.PerformLayout()
        Me.grpAddMember.ResumeLayout(False)
        Me.grpAddMember.PerformLayout()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents grpMembers As GroupBox
    Friend WithEvents lstMembers As ListBox
    Friend WithEvents grpNewMember As GroupBox
    Friend WithEvents chkNewMem As CheckBox
    Friend WithEvents grpAddMember As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtPID As TextBox
    Friend WithEvents mskPhone As MaskedTextBox
    Friend WithEvents txtPhoto As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtMI As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents picMember As PictureBox
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtVal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents tsbHome As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbMember As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbRole As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbEvent As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbRSVP As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbCourse As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbSemester As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tsbLogOut As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsbHelp As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents tsbTutor As ToolStripButton
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents btnBrowse As Button
    Friend WithEvents ofdOpen As OpenFileDialog
    Friend WithEvents btnReload As Button
    Friend WithEvents tsbAdmin As ToolStripButton
End Class
