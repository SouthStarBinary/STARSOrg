Imports System.Data.SqlClient

Public Class frmTutor
    'declare all objects
    Private objTutors As CTutorsCourses
    Private objSemesters As CSemesters
    Private objCourses As CCourses
    Private objMemebers As CMembers
    Private arrSemesters As ArrayList 'stores semestersIDs for easy loading
    Private arrClbCurrentState As ArrayList 'stores preset/database loaded checkedListBox Checked state
    Private strSemester As String 'stores current semesterID

#Region "Toolbar Stuff"
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbLogout.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRsvp.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter
        'we need to do this only because we put the graphic image in the BackgroundImage property instead of the Image property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbLogout.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRsvp.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave
        'we need to do this only because we put the graphic image in the BackgroundImage property instead of the Image property
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
        intNextAction = ACTION_EVENT
        Me.Hide()
    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
        intNextAction = ACTION_HELP
        Me.Hide()
    End Sub

    Private Sub tsbLogOut_Click(sender As Object, e As EventArgs) Handles tsbLogout.Click
        intNextAction = ACTION_LOGOUT
        Me.Hide()
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        intNextAction = ACTION_MEMBER
        Me.Hide()
    End Sub

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        intNextAction = ACTION_ROLE
        Me.Hide()
    End Sub

    Private Sub tsbRSVP_Click(sender As Object, e As EventArgs) Handles tsbRsvp.Click
        intNextAction = ACTION_RSVP
        Me.Hide()
    End Sub

    Private Sub tsbSemesters_Click(sender As Object, e As EventArgs) Handles tsbSemester.Click
        intNextAction = ACTION_SEMESTER
        Me.Hide()
    End Sub

    Private Sub tsbTutor_Click(sender As Object, e As EventArgs) Handles tsbTutor.Click
        'nothing to do here
    End Sub

    Private Sub tsbAdmin_Click(sender As Object, e As EventArgs) Handles tsbAdmin.Click
        intNextAction = ACTION_ADMIN
        Me.Hide()
    End Sub
#End Region

    Private Sub frmTutor_Load(sender As Object, e As EventArgs) Handles Me.Load
        'initialize
        objTutors = New CTutorsCourses
        objSemesters = New CSemesters
        objCourses = New CCourses
        objMemebers = New CMembers
        arrSemesters = New ArrayList
        arrClbCurrentState = New ArrayList
        LoadSemesters()
        LoadMemberName()
        grpCourses.Enabled = False 'user must first pick a tutor
        btnTutReport.Enabled = False 'user must first pick a tutor
        btnMemReport.Enabled = False 'user must first pick a tutor
        btnSave.Enabled = False 'user must first update CheckedListBox/Courses
        lstSemester.ClearSelected()
        clbCourses.Items.Clear()

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

    Private Sub Clear()
        'clears Courses CheckedListBox and both Checked State storing array
        Dim i As Integer
        For i = 0 To clbCourses.Items.Count - 1
            clbCourses.SetItemCheckState(i, CheckState.Unchecked)
        Next
        clbCourses.Items.Clear()
        arrClbCurrentState.Clear()
    End Sub

    Private Sub lstSemesters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSemester.SelectedIndexChanged
        btnMemReport.Enabled = True
        grpCourses.Enabled = True
        Try
            strSemester = arrSemesters(lstSemester.SelectedIndex) 'loads using index of currently selected index
        Catch ex As ArgumentOutOfRangeException
        End Try
        Clear()
        If lstSemester.SelectedIndex <> -1 Then
            LoadCourses()
            LoadTutorCourses()
        End If
    End Sub

    Private Sub LoadSemesters()
        Dim objReader As SqlDataReader
        lstSemester.Items.Clear()
        Try
            objReader = objSemesters.GetAllSemesters
            Do While objReader.Read
                lstSemester.Items.Add(objReader.Item("SemesterDescription"))
                'stores SemesterID in the order it gets added to CheckListBox
                arrSemesters.Add(objReader.Item("SemesterID"))
            Loop
            objReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading Semesters", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadMemberName()
        Try
            'using current tutor "PID", get member first and last name
            lblTutor.Text = objMemebers.GetMemberByPID(PID).FName & " " _
                & objMemebers.CurrentObject.LName
        Catch ex As Exception
            MessageBox.Show("Error loading tutor name", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadCourses()
        Dim objReader As SqlDataReader
        Try
            objReader = objCourses.GetAllCourses
            Do While objReader.Read
                clbCourses.Items.Add(objReader.Item("CourseID"))
            Loop
            objReader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Database error", MessageBoxButtons.OK)
            'could have CDB throw the error and trap it here
        End Try

    End Sub

    Private Sub LoadTutorCourses()
        Dim objReader As SqlDataReader
        Dim i As Integer
        'get a list of all courses for this tutor in the selected semester
        Try
            objReader = objTutors.GetTutorCoursesByTutorID(PID, strSemester)
            Do While objReader.Read
                'for each course returned in this datareader, find it in the clb and turn it on.
                For i = 0 To clbCourses.Items.Count - 1
                    If clbCourses.Items(i).ToString = objReader.Item("CourseID") Then
                        clbCourses.SetItemCheckState(i, CheckState.Checked)
                    End If
                Next
            Loop
            objReader.Close()
            'fill array with checkBoxStatus
            For i = 0 To clbCourses.Items.Count - 1
                If clbCourses.GetItemCheckState(i) Then
                    arrClbCurrentState.Add(True)
                Else
                    arrClbCurrentState.Add(False)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Database Error", MessageBoxButtons.OK)
            'could have CDB throw the error and trap it here
        End Try
    End Sub

    Private Sub clbCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbCourses.SelectedIndexChanged
        btnSave.Enabled = True
        btnTutReport.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim i As Integer

        For i = 0 To clbCourses.Items.Count - 1
            'split CheckLitBox item by spaces
            'string(0) is "cgs" string(1) is "3010" and a space in between to recreate CourseID
            If arrClbCurrentState(i) <> clbCourses.GetItemCheckState(i) Then
                objTutors.Clear()
                With objTutors.CurrentObject
                    .PID = PID
                    .CourseID = clbCourses.Items(i).ToString
                    .SemesterID = strSemester
                End With

                Try
                    Me.Cursor = Cursors.WaitCursor
                    If clbCourses.GetItemCheckState(i) = 1 Then
                        objTutors.Save()
                    Else
                        objTutors.Delete()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Unable to save Tutor Course: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Me.Cursor = Cursors.Default
            End If
        Next
        Clear()
        grpCourses.Enabled = False
        btnSave.Enabled = False
        btnTutReport.Enabled = False
        btnMemReport.Enabled = False
    End Sub


    Private Sub btnTutReport_Click(sender As Object, e As EventArgs) Handles btnTutReport.Click
        Dim sqlDA As SqlDataAdapter
        Dim dt As New DataTable
        Dim frmTutReport As New frmTutbySemReport
        frmTutReport.Refresh()
        Dim params As New ArrayList
        MessageBox.Show("CourseID: " & clbCourses.SelectedItem.ToString & " SemesterId" & strSemester)
        params.Add(New SqlParameter("courseID", clbCourses.SelectedItem.ToString))
        params.Add(New SqlParameter("semesterID", strSemester))
        sqlDA = myDB.getDataAdapterBySP("sp_getAllTutorsCoursesByTutorID", params)
        sqlDA.Fill(dt)
        frmTutReport.dgvTutReport.DataSource = dt
        frmTutReport.dgvTutReport.AutoGenerateColumns = True
        frmTutReport.lblCourse.Text = "Course: " & clbCourses.SelectedItem.ToString
        frmTutReport.lblSemester.Text = "Semester: " & lstSemester.SelectedItem
        frmTutReport.ShowDialog()

    End Sub

    Private Sub btnMemReport_Click(sender As Object, e As EventArgs) Handles btnMemReport.Click
        Dim sqlDA As SqlDataAdapter
        Dim dt As New DataTable
        Dim frmTutReport As New frmTutorsReport
        frmTutReport.Refresh()
        Dim params As New ArrayList
        params.Add(New SqlParameter("semesterID", strSemester))
        sqlDA = myDB.getDataAdapterBySP("sp_getAllTutorsBySemesterID", params)
        sqlDA.Fill(dt)
        frmTutReport.dgvTutReport.DataSource = dt
        frmTutReport.dgvTutReport.AutoGenerateColumns = True
        frmTutReport.lblTutor.Text = "Tutor: " & PID
        frmTutReport.lblSemester.Text = "Semester: " & lstSemester.SelectedItem
        frmTutReport.ShowDialog()
    End Sub
End Class