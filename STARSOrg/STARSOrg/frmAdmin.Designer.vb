<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvwMembers = New System.Windows.Forms.ListView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.cboSecPriv = New System.Windows.Forms.ComboBox()
        Me.mskNewPass = New System.Windows.Forms.MaskedTextBox()
        Me.mskConfirmPass = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.L = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.chkNewCreds = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPID = New System.Windows.Forms.TextBox()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMember = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRole = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEvent = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRsvp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCourse = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSemester = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbTutor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLogout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAdmin = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lvwMembers)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpSearch)
        Me.SplitContainer1.Size = New System.Drawing.Size(836, 490)
        Me.SplitContainer1.SplitterDistance = 349
        Me.SplitContainer1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Member Credentials"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lvwMembers
        '
        Me.lvwMembers.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwMembers.FullRowSelect = True
        Me.lvwMembers.GridLines = True
        Me.lvwMembers.Location = New System.Drawing.Point(10, 81)
        Me.lvwMembers.Name = "lvwMembers"
        Me.lvwMembers.Size = New System.Drawing.Size(336, 397)
        Me.lvwMembers.TabIndex = 14
        Me.lvwMembers.UseCompatibleStateImageBehavior = False
        Me.lvwMembers.View = System.Windows.Forms.View.Details
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(342, 14)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Members Security Roles"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.cboSecPriv)
        Me.grpSearch.Controls.Add(Me.mskNewPass)
        Me.grpSearch.Controls.Add(Me.mskConfirmPass)
        Me.grpSearch.Controls.Add(Me.Label8)
        Me.grpSearch.Controls.Add(Me.L)
        Me.grpSearch.Controls.Add(Me.btnConfirm)
        Me.grpSearch.Controls.Add(Me.chkNewCreds)
        Me.grpSearch.Controls.Add(Me.Label6)
        Me.grpSearch.Controls.Add(Me.Label5)
        Me.grpSearch.Controls.Add(Me.Label4)
        Me.grpSearch.Controls.Add(Me.txtUser)
        Me.grpSearch.Controls.Add(Me.txtPID)
        Me.grpSearch.Location = New System.Drawing.Point(12, 81)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(459, 226)
        Me.grpSearch.TabIndex = 11
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Assign New Credentials"
        '
        'cboSecPriv
        '
        Me.cboSecPriv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSecPriv.FormattingEnabled = True
        Me.cboSecPriv.Location = New System.Drawing.Point(25, 150)
        Me.cboSecPriv.Name = "cboSecPriv"
        Me.cboSecPriv.Size = New System.Drawing.Size(121, 21)
        Me.cboSecPriv.TabIndex = 22
        '
        'mskNewPass
        '
        Me.mskNewPass.Enabled = False
        Me.mskNewPass.Location = New System.Drawing.Point(186, 43)
        Me.mskNewPass.Name = "mskNewPass"
        Me.mskNewPass.Size = New System.Drawing.Size(125, 20)
        Me.mskNewPass.TabIndex = 21
        Me.mskNewPass.UseSystemPasswordChar = True
        '
        'mskConfirmPass
        '
        Me.mskConfirmPass.Enabled = False
        Me.mskConfirmPass.Location = New System.Drawing.Point(186, 97)
        Me.mskConfirmPass.Name = "mskConfirmPass"
        Me.mskConfirmPass.Size = New System.Drawing.Size(125, 20)
        Me.mskConfirmPass.TabIndex = 20
        Me.mskConfirmPass.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(186, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Confirm Password"
        '
        'L
        '
        Me.L.AutoSize = True
        Me.L.Location = New System.Drawing.Point(186, 27)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(78, 13)
        Me.L.TabIndex = 18
        Me.L.Text = "New Password"
        '
        'btnConfirm
        '
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.Location = New System.Drawing.Point(236, 146)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirm.TabIndex = 17
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'chkNewCreds
        '
        Me.chkNewCreds.AutoSize = True
        Me.chkNewCreds.Location = New System.Drawing.Point(316, 19)
        Me.chkNewCreds.Name = "chkNewCreds"
        Me.chkNewCreds.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkNewCreds.Size = New System.Drawing.Size(137, 17)
        Me.chkNewCreds.TabIndex = 14
        Me.chkNewCreds.Text = "Assign New Credentials"
        Me.chkNewCreds.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Security Privilege"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "PID"
        '
        'txtUser
        '
        Me.txtUser.Enabled = False
        Me.txtUser.Location = New System.Drawing.Point(25, 95)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(126, 20)
        Me.txtUser.TabIndex = 9
        '
        'txtPID
        '
        Me.txtPID.BackColor = System.Drawing.Color.White
        Me.txtPID.Location = New System.Drawing.Point(25, 43)
        Me.txtPID.Name = "txtPID"
        Me.txtPID.ReadOnly = True
        Me.txtPID.Size = New System.Drawing.Size(126, 20)
        Me.txtPID.TabIndex = 8
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator9, Me.tsbHome, Me.ToolStripSeparator7, Me.tsbMember, Me.ToolStripSeparator6, Me.tsbRole, Me.ToolStripSeparator5, Me.tsbEvent, Me.ToolStripSeparator4, Me.tsbRsvp, Me.ToolStripSeparator3, Me.tsbCourse, Me.ToolStripSeparator2, Me.tsbSemester, Me.ToolStripSeparator12, Me.tsbTutor, Me.ToolStripSeparator10, Me.tsbLogout, Me.ToolStripSeparator8, Me.tsbHelp, Me.ToolStripSeparator1, Me.ToolStripSeparator11, Me.tsbAdmin})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(836, 50)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.AutoSize = False
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(10, 50)
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
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.AutoSize = False
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(10, 50)
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
        Me.tsbMember.Text = "MEMBERS"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(10, 50)
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
        Me.tsbRole.Text = "ROLES"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(10, 50)
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRsvp
        '
        Me.tsbRsvp.AutoSize = False
        Me.tsbRsvp.BackgroundImage = Global.STARSOrg.My.Resources.Resources.rsvp
        Me.tsbRsvp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRsvp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRsvp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRsvp.Name = "tsbRsvp"
        Me.tsbRsvp.Size = New System.Drawing.Size(48, 48)
        Me.tsbRsvp.Text = "RSVP"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(10, 50)
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
        Me.tsbCourse.Text = "COURES"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(10, 50)
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
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.AutoSize = False
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(10, 50)
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
        Me.tsbTutor.Text = "TUTORS"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator10.AutoSize = False
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(10, 50)
        '
        'tsbLogout
        '
        Me.tsbLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbLogout.AutoSize = False
        Me.tsbLogout.BackgroundImage = Global.STARSOrg.My.Resources.Resources.logout
        Me.tsbLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLogout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogout.Name = "tsbLogout"
        Me.tsbLogout.Size = New System.Drawing.Size(48, 48)
        Me.tsbLogout.Text = "LOGOUT"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(10, 50)
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
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(10, 50)
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator11.AutoSize = False
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(10, 50)
        '
        'tsbAdmin
        '
        Me.tsbAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAdmin.Image = CType(resources.GetObject("tsbAdmin.Image"), System.Drawing.Image)
        Me.tsbAdmin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdmin.Name = "tsbAdmin"
        Me.tsbAdmin.Size = New System.Drawing.Size(23, 47)
        Me.tsbAdmin.Text = "ToolStripButton1"
        Me.tsbAdmin.Visible = False
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 490)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPID As TextBox
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents Label7 As Label
    Friend WithEvents lvwMembers As ListView
    Friend WithEvents Label8 As Label
    Friend WithEvents L As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents chkNewCreds As CheckBox
    Friend WithEvents mskNewPass As MaskedTextBox
    Friend WithEvents mskConfirmPass As MaskedTextBox
    Friend WithEvents cboSecPriv As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents tsbHome As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsbMember As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbRole As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbEvent As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbRsvp As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbCourse As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbSemester As ToolStripButton
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents tsbTutor As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents tsbLogout As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tsbHelp As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents tsbAdmin As ToolStripButton
    Friend WithEvents Label1 As Label
End Class
