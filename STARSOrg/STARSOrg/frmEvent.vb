Imports System.Data.SqlClient
Public Class frmEvent
    Private objEvents As CEvents
    Private blnClearing As Boolean
    Private blnReloading As Boolean


#Region "Tool Bar Stuff"


    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbRoles.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter
        'We need to do this only because we put the gfx image in the BackgroundImage property instead of the Image property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbLogOut.MouseLeave, tsbMember.MouseLeave, tsbRoles.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave
        'We need to do this only because we put the gfx image in the BackgroundImage property instead of the Image property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        intNextAction = ACTION_HOME
        Me.Hide()
    End Sub

    Private Sub tsbCourse_Click(sender As Object, e As EventArgs) Handles tsbCourse.Click
        intNextAction = ACTION_COURSE
        Me.Hide()
    End Sub

    Private Sub tsbEvent_Click(sender As Object, e As EventArgs) Handles tsbEvent.Click
        'Nothing to do Here -  we are already in EVENT form

    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
        intNextAction = ACTION_HELP
        Me.Hide()
    End Sub

    Private Sub tsbLogOut_Click(sender As Object, e As EventArgs) Handles tsbLogOut.Click
        intNextAction = ACTION_LOGOUT
        Me.Hide()
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        intNextAction = ACTION_MEMBER
        Me.Hide()
    End Sub

    Private Sub tsbRoles_Click(sender As Object, e As EventArgs) Handles tsbRoles.Click
        intNextAction = ACTION_ROLE
        Me.Hide()
    End Sub

    Private Sub tsbRSVP_Click(sender As Object, e As EventArgs) Handles tsbRSVP.Click
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
    Private Sub frmEvent_Load(sender As Object, e As EventArgs) Handles Me.Load
        objEvents = New CEvents

        If (secRole = "ADMIN") Then
            tsbAdmin.Visible = True
        End If

        If (secRole = "MEMBER") Then
            tsbMember.Visible = False
            tsbEvent.Visible = False
            tsbCourse.Visible = False
            tsbSemester.Visible = False
            tsbRoles.Visible = False
        End If

    End Sub

    Private Sub LoadEvents()
        Dim objReader As SqlDataReader
        lstEvents.Items.Clear()
        Try
            objReader = objEvents.GetAllEvents
            Do While objReader.Read
                lstEvents.Items.Add(objReader.Item("EventID"))   'objReader.Item   reading a column that is returned in the data reader by saying objReader    the name in quotes must match the name of the column returned in the data reader......might even be an alias    as something

            Loop
            objReader.Close()

        Catch ex As Exception
            'could have CBD throw the error and trap it here
        End Try
        'If objEvents.CurrentObject.EventID <> 0 Then
        '    lstEvents.SelectedIndex = lstEvents.FindStringExact(objEvents.CurrentObject.EventID)
        'End If
    End Sub

    Private Sub frmEvent_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadEvents()
        grpEdit.Enabled = False

    End Sub

    Private Sub lstEvents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEvents.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If

        If blnReloading Then
            Exit Sub
        End If
        If lstEvents.SelectedIndex = -1 Then
            Exit Sub
        End If
        chkNew.Checked = False                 'turning off checkbox
        LoadSelectedRecord()
        grpEdit.Enabled = True
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            objEvents.GetEventByEventID(lstEvents.SelectedItem.ToString)
            With objEvents.CurrentObject
                txtEventID.Text = .EventID
                txtEventDescription.Text = .EventDescription
                txtEventTypeID.Text = .EventTypeID
                txtSemesterID.Text = .SemesterID
                dtmStartDate.Value = .StartDate
                dtmEndDate.Value = .EndDate
                txtLocation.Text = .Location

            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Event Values: " & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub chkNew_CheckedChanged(sender As Object, e As EventArgs) Handles chkNew.CheckedChanged
        If blnClearing Then
            Exit Sub
        End If
        If chkNew.Checked Then
            'ClearScreenControls(Me)
            txtEventID.Clear()
            txtEventDescription.Clear()
            txtEventTypeID.Clear()
            txtSemesterID.Clear()
            txtLocation.Clear()
            dtmStartDate.Value = Today.Date
            dtmEndDate.Value = Today.Date
            txtSemesterID.Clear()
            lstEvents.SelectedIndex = -1
            grpEvents.Enabled = False
            grpEdit.Enabled = True
            objEvents.CreateNewEvent()
            txtEventID.Focus()


        Else
            grpEvents.Enabled = True
            grpEdit.Enabled = True
            objEvents.CurrentObject.IsNewEvent = False
        End If
    End Sub

    Private Sub btnSaveEvent_Click(sender As Object, e As EventArgs) Handles btnSaveEvent.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        'first do validation
        'If Not ValidateTextBoxLength(txtEventID, errP) Then
        '    blnErrors = True
        'End If
        If Not ValidateTextBoxLength(txtEventDescription, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtEventTypeID, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtSemesterID, errP) Then
            blnErrors = True
        End If
        'If Not ValidateTextBoxLength(dtmStartDate, errP) Then
        '    blnErrors = True
        'End If
        'If Not ValidateTextBoxLength(dtmEndDate, errP) Then
        '    blnErrors = True
        'End If
        If Not ValidateTextBoxLength(txtLocation, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objEvents.CurrentObject
            ' .EventID = txtEventID.Text
            .EventDescription = txtEventDescription.Text
            .EventTypeID = txtEventTypeID.Text
            .SemesterID = txtSemesterID.Text
            .StartDate = dtmStartDate.Value
            .EndDate = dtmEndDate.Value
            .Location = txtLocation.Text

        End With

        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objEvents.Save
            If intResult = -1 Then   'id not unique
                MessageBox.Show("Event ID must be unique, unable to save Event record", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to save Event record: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadEvents()
        chkNew.Checked = False
        grpEvents.Enabled = True



    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        chkNew.Checked = False
        errP.Clear()
        If lstEvents.SelectedIndex <> -1 Then
            LoadSelectedRecord()       'reload what was selected in case user messed up the form
        Else      'disable the edit area, nothing was currently selected
            grpEdit.Enabled = False
        End If
        blnClearing = False
        objEvents.CurrentObject.IsNewEvent = False
        grpEvents.Enabled = True
    End Sub
End Class