Imports System.Data.SqlClient
Public Class frmRole
    Private objRoles As CRoles
    Private blnClearing As Boolean
    Private blnReloading As Boolean

#Region "ToolBar STuff"
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

    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        intNextAction = ACTION_HOME
        Me.Hide()
    End Sub

    Private Sub tsbCourse_DisplayChanged(sender As Object, e As EventArgs) Handles tsbCourse.Click
        intNextAction = ACTION_COURSE
        Me.Hide()
    End Sub

    Private Sub tsbEvent_Click(sender As Object, e As EventArgs) Handles tsbEvent.Click
        intNextAction = ACTION_EVENT
        Me.Hide()
    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
        intNextAction = ACTION_HELP
        Me.Hide()
    End Sub

    Private Sub tsbLogout_Click(sender As Object, e As EventArgs) Handles tsbLogout.Click
        intNextAction = ACTION_LOGOUT
        Me.Hide()
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        intNextAction = ACTION_MEMBER
        Me.Hide()
    End Sub

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        'Nothing to do here
    End Sub

    Private Sub tsbRsvp_Click(sender As Object, e As EventArgs) Handles tsbRsvp.Click
        intNextAction = ACTION_RSVP
        Me.Hide()
    End Sub

    Private Sub tsbSemester_Click(sender As Object, e As EventArgs) Handles tsbSemester.Click
        intNextAction = ACTION_SEMESTER
        Me.Hide()
    End Sub

    Private Sub tsbTutor_Click(sender As Object, e As EventArgs) Handles tsbTutor.Click
        intNextAction = ACTION_TUTOR
        Me.Hide()
    End Sub

    Private Sub tsbAdmin_Click(sender As Object, e As EventArgs) Handles tsbAdmin.Click
        intNextAction = ACTION_ADMIN
        Me.Hide()
    End Sub


#End Region
    Private Sub frmRole_Load(sender As Object, e As EventArgs) Handles Me.Load
        objRoles = New CRoles
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
    End Sub

    Private Sub LoadRoles()
        Dim objReader As SqlDataReader
        lstRoles.Items.Clear()
        Try
            objReader = objRoles.GetAllRoles
            Do While objReader.Read
                lstRoles.Items.Add(objReader.Item("RoleID"))
            Loop
            objReader.Close()
        Catch ex As Exception
            'could have CDB throw the error and trap it here
        End Try
    End Sub

    Private Sub frmRole_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadRoles()
        grpEdit.Enabled = False
    End Sub

    Private Sub lstRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRoles.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If
        If blnReloading Then
            Exit Sub
        End If
        If lstRoles.SelectedIndex = -1 Then
            'nothing to do
            Exit Sub
        End If
        chkNew.Checked = False
        LoadSelectedRecord()
        grpEdit.Enabled = True
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            objRoles.GetRoleByRoleID(lstRoles.SelectedItem.ToString)
            With objRoles.CurrentObject
                txtRoleID.Text = .RoleID
                txtDesc.Text = .RoleDescription
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Role values", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub chkNew_CheckedChanged(sender As Object, e As EventArgs) Handles chkNew.CheckedChanged
        If blnClearing Then
            Exit Sub
        End If
        If chkNew.Checked Then
            txtRoleID.Clear()
            txtDesc.Clear()
            lstRoles.SelectedIndex = -1
            grpRoles.Enabled = False
            grpEdit.Enabled = True
            objRoles.CreateNewRole()
            txtRoleID.Focus()
        Else
            grpRoles.Enabled = True
            grpEdit.Enabled = False
            objRoles.CurrentObject.IsNewRole = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        'first do validation
        If Not validateTextBoxLength(txtRoleID, errP) Then
            blnErrors = True
        End If
        If Not validateTextBoxLength(txtDesc, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objRoles.CurrentObject
            .RoleID = txtRoleID.Text
            .RoleDescription = txtDesc.Text
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objRoles.Save
            If intResult = -1 Then 'id not unique
                MessageBox.Show("RoleID must be unique. Unable to save Role Record", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to save Role record: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadRoles()
        chkNew.Checked = False
        grpRoles.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        chkNew.Checked = False
        errP.Clear()
        If lstRoles.SelectedIndex <> -1 Then
            LoadSelectedRecord() 'reload wahat was selected in case user had messed up the form
        Else ' disable the edit area - nothing was curretnly selected
            grpEdit.Enabled = False
            objRoles.CurrentObject.IsNewRole = False
            grpRoles.Enabled = True
        End If
    End Sub

End Class