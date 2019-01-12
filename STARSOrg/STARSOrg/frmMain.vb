Public Class frmMain
    Private RoleInfo As frmRole
    Private RoleEvents As frmEvent
    Private RoleSecurity As frmSecurity
    Private formAdmin As frmAdmin
    Private RoleMember As frmMember
    Private RoleCourse As frmCourse
    Private RoleSemester As frmSemester
    Private RoleTutors As frmTutor

    'occurs when the mouse enters the boundries of the control
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbLogout.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRsvp.MouseEnter, tsbTutor.MouseEnter, tsbSemester.MouseEnter
        'We need to do this only because we put the graphic image in the BackgroundImage property instead of the image property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub
    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbLogout.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRsvp.MouseLeave, tsbTutor.MouseLeave, tsbSemester.MouseLeave
        'We need to do this only because we put the graphic image in the BackgroundImage property instead of the image property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub PerformNextAction()
        'get the next action selected on the child form, and then simulate the click of the toolstrip button 
        Select Case intNextAction
            Case ACTION_COURSE
                tsbCourse.PerformClick()
            Case ACTION_EVENT
                tsbEvent.PerformClick()
            Case ACTION_HELP
                tsbHelp.PerformClick()
            Case ACTION_HOME
                tsbHome.PerformClick()
            Case ACTION_LOGOUT
                tsbLogout.PerformClick()
            Case ACTION_MEMBER
                tsbMember.PerformClick()
            Case ACTION_ROLE
                tsbRole.PerformClick()
            Case ACTION_RSVP
                tsbRsvp.PerformClick()
            Case ACTION_SEMESTER
                tsbSemester.PerformClick()
            Case ACTION_TUTOR
                tsbTutor.PerformClick()
            Case ACTION_ADMIN
                tsbAdmin.PerformClick()
            Case Else
                'do nothing
        End Select
    End Sub

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        Me.Hide()
        RoleInfo.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'initialize everything here 
        'instantiate a form object for each form in the application
        RoleInfo = New frmRole
        RoleEvents = New frmEvent
        RoleSecurity = New frmSecurity
        formAdmin = New frmAdmin
        RoleMember = New frmMember
        RoleCourse = New frmCourse
        RoleSemester = New frmSemester
        RoleTutors = New frmTutor
        Me.Hide()

        'myDB = New CDB
        Try
            myDB.OpenDB()
        Catch ex As Exception
            MessageBox.Show("Unable to open database. Connection string = " & gstrConn, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EndProgram()
        End Try

        RoleSecurity.ShowDialog()
        If (secRole = "ADMIN") Then
            tsbAdmin.Visible = True
        End If

        If (secRole = "MEMBER") Then
            tsbMember.Visible = False
            tsbEvent.Visible = False
            tsbCourse.Visible = False
            tsbSemester.Visible = False
            tsbRole.Visible = False
        End If

        If (secRole = "GUEST") Then
            tsbMember.Visible = False
            tsbEvent.Visible = False
            tsbCourse.Visible = False
            tsbSemester.Visible = False
            tsbRole.Visible = False
            tsbTutor.Visible = False
        End If
        'formAdmin.ShowDialog()
    End Sub

    Private Sub EndProgram()
        'Close each form except main
        Dim f As Form
        Me.Cursor = Cursors.WaitCursor
        For Each f In Application.OpenForms
            If f.Name <> Me.Name Then
                If Not f Is Nothing Then
                    f.Close()
                End If
            End If
        Next
        'Close database connection
        If Not objSQLConn Is Nothing Then
            objSQLConn.Close()
            objSQLConn.Dispose()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbAdmin_Click(sender As Object, e As EventArgs) Handles tsbAdmin.Click
        Me.Hide()
        formAdmin.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub

    Private Sub tsbLogout_Click(sender As Object, e As EventArgs) Handles tsbLogout.Click
        EndProgram()
        Application.Exit()
    End Sub

    Private Sub tsbEvent_Click(sender As Object, e As EventArgs) Handles tsbEvent.Click
        Me.Hide()
        RoleEvents.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        Me.Hide()
        RoleMember.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub

    Private Sub tsbCourse_Click(sender As Object, e As EventArgs) Handles tsbCourse.Click
        Me.Hide()
        RoleCourse.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub

    Private Sub tsbSemester_Click(sender As Object, e As EventArgs) Handles tsbSemester.Click
        Me.Hide()
        RoleSemester.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub

    Private Sub tsbTutor_Click(sender As Object, e As EventArgs) Handles tsbTutor.Click
        Me.Hide()
        RoleTutors.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub
End Class
