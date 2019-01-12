Imports System.Data.SqlClient

Public Class frmSemester
    Private objSemesters As CSemesters
    Private blnClearing As Boolean
    Private blnReloading As Boolean
    Private SemesterReport As frmSemesterReport


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

    Private Sub tsbHome_Click(sender As Object, e As EventArgs)
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

    Private Sub frmSemester_Load(sender As Object, e As EventArgs) Handles Me.Load
        objSemesters = New CSemesters
        SemesterReport = New frmSemesterReport
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
    Private Sub LoadSemesters()
        Dim objDR As SqlDataReader
        lstSemesters.Items.Clear()
        Try
            objDR = objSemesters.GetAllSemesters()
            Do While objDR.Read
                lstSemesters.Items.Add(objDR.Item("SemesterID"))
            Loop
            objDR.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading Semester values: " & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If objSemesters.CurrentObject.SemesterID <> "" Then
            lstSemesters.SelectedIndex = lstSemesters.FindStringExact(objSemesters.CurrentObject.SemesterID)
        End If
        blnReloading = False
    End Sub
    Private Sub frmSemester_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadSemesters()
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnSemModify.Click
        Dim blnErrors As Boolean
        'validate
        If Not ValidateTextBoxLength(txtModSemDesc, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objSemesters.CurrentObject
            .SemesterDescription = txtModSemDesc.Text
        End With
        objSemesters.Save()
        tslSemStatus.Text = "Semester Modified!"
        txtModSemDesc.Clear()
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadSemesters()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSemSave.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        'validate
        If Not ValidateTextBoxLength(txtNewSemID, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtNewSemDesc, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objSemesters.CurrentObject
            .SemesterID = txtNewSemID.Text
            .SemesterDescription = txtNewSemDesc.Text
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objSemesters.Save
            If intResult = -1 Then 'id not unique
                MessageBox.Show("Semester ID must be unique, unable to save Semester record", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to save Semester record", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadSemesters()
        tslSemStatus.Text = "Semester Saved!"
        txtNewSemID.Clear()
        txtNewSemDesc.Clear()
    End Sub
    Private Sub LoadSelectedSemester()
        Try
            objSemesters.GetSemesterBySemesterID(lstSemesters.SelectedItem.ToString)
            With objSemesters.CurrentObject
                txtModSemID.Text = .SemesterID
                txtModSemDesc.Text = .SemesterDescription
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Semester values: " & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstSemesters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSemesters.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If
        If blnReloading Then
            Exit Sub
        End If
        If lstSemesters.SelectedIndex = -1 Then
            Exit Sub
        End If
        txtModSemID.Clear()
        txtModSemDesc.Clear()
        LoadSelectedSemester()
    End Sub
    Private Sub btnSemesterReport_Click(sender As Object, e As EventArgs) Handles btnSemReport.Click
        Dim sqlDA As SqlDataAdapter
        Dim dt As New DataTable
        SemesterReport.dgrSemesters.Refresh()
        sqlDA = MyDB.GetDataAdapterBySP("sp_getAllSemesters", Nothing)
        sqlDA.Fill(dt)
        SemesterReport.dgrSemesters.DataSource = dt
        SemesterReport.dgrSemesters.AutoGenerateColumns = True
        SemesterReport.ShowDialog()
        LoadSelectedSemester()
    End Sub
End Class