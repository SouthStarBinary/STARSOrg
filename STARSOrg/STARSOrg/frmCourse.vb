Imports System.Data.SqlClient
Public Class frmCourse
    Private objCourses As CCourses
    Private blnClearing As Boolean
    Private blnReloading As Boolean
    Private CourseReport As frmCourseReport


#Region "Toolbar"
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs)
        'We need to do this only because we put the gfx image in the BackgroundImage property instead of the Image property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs)
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

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        'nothing to do here
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

    Private Sub frmCourse_Load(sender As Object, e As EventArgs) Handles Me.Load
        objCourses = New CCourses
        CourseReport = New frmCourseReport

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
    Private Sub LoadCourses()
        Dim objDR As SqlDataReader
        lstCourses.Items.Clear()
        Try
            objDR = objCourses.GetAllCourses()
            Do While objDR.Read
                lstCourses.Items.Add(objDR.Item("CourseID"))
            Loop
            objDR.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading Course values: " & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If objCourses.CurrentObject.CourseID <> "" Then
            lstCourses.SelectedIndex = lstCourses.FindStringExact(objCourses.CurrentObject.CourseID)
        End If
        blnReloading = False
    End Sub
    Private Sub frmCourse_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadCourses()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnCourseModify.Click
        Dim blnErrors As Boolean
        'validate
        If Not ValidateTextBoxLength(txtModName, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objCourses.CurrentObject
            .CourseName = txtModName.Text
        End With
        objCourses.Save()
        tslCourseStatus.Text = "Course Modified!"
        txtModName.Clear()
        blnReloading = True
        LoadCourses()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnCourseSave.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        'validate
        If Not ValidateTextBoxLength(txtNewID, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtNewName, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objCourses.CurrentObject
            .CourseID = txtNewID.Text
            .CourseName = txtNewName.Text
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objCourses.Save
            If intResult = -1 Then 'id not unique
                MessageBox.Show("Course ID must be unique, unable to save Course record", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to save Course record", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        tslCourseStatus.Text = "Course Saved!"
        txtNewID.Clear()
        txtNewName.Clear()
        LoadCourses()
    End Sub
    Private Sub LoadSelectedCourse()
        Try
            objCourses.GetCourseByCourseID(lstCourses.SelectedItem.ToString)
            With objCourses.CurrentObject
                txtModID.Text = .CourseID
                txtModName.Text = .CourseName
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Course values: " & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCourses.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If
        If blnReloading Then
            Exit Sub
        End If
        If lstCourses.SelectedIndex = -1 Then
            Exit Sub
        End If
        txtModID.Clear()
        txtModName.Clear()
        LoadSelectedCourse()
    End Sub
    Private Sub btnCourseReport_Click(sender As Object, e As EventArgs) Handles btnCourseReport.Click
        Dim sqlDA As SqlDataAdapter
        Dim dt As New DataTable
        CourseReport.dgrCourses.Refresh()
        sqlDA = MyDB.GetDataAdapterBySP("sp_getAllCourses", Nothing)
        sqlDA.Fill(dt)
        CourseReport.dgrCourses.DataSource = dt
        CourseReport.dgrCourses.AutoGenerateColumns = True
        CourseReport.ShowDialog()
        LoadSelectedCourse()
    End Sub
End Class