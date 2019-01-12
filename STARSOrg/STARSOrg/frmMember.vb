Imports System.Data.SqlClient
Imports System.IO
Public Class frmMember
    Private objMembers As CMembers
    Private blnClearing As Boolean
    Private blnReloading As Boolean
    ' Private sqlDR As SqlDataReader
    Private strFileName As String
    Private dt As DataTable

#Region "Toolbar Stuff"

    Private Sub tsbHome_MouseEnter(sender As Object, e As EventArgs) Handles tsbHome.MouseEnter, tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter, tsbTutor.MouseEnter, tsbSemester.MouseEnter
        'we need to do this only because we put the graphics images as background image instead of image property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbHome_MouseLeave(sender As Object, e As EventArgs) Handles tsbHome.MouseLeave, tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbLogOut.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave, tsbTutor.MouseLeave, tsbSemester.MouseLeave
        'we need to do this only because we put the graphics images as background image instead of image property
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

    Private Sub tsbLogOut_Click(sender As Object, e As EventArgs) Handles tsbLogOut.Click
        intNextAction = ACTION_LOGOUT
        Me.Hide()
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs)
        'nothing to do here
    End Sub

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
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

    Private Sub frmMember_Load(sender As Object, e As EventArgs) Handles Me.Load
        objMembers = New CMembers

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

    Private Sub LoadMembers()
        Dim objReader As SqlDataReader
        lstMembers.Items.Clear()
        Try
            objReader = objMembers.GetAllMembers
            Do While objReader.Read
                lstMembers.Items.Add(objReader.Item("PID") & " " & objReader.Item("LName") & " " & objReader.Item("FName") & " " & objReader.Item("MI") & " " & objReader.Item("Email") & " " & objReader.Item("Phone"))
            Loop
            objReader.Close()
        Catch ex As Exception
            'could have CDB throw the error and trao it here
        End Try
        blnReloading = False
    End Sub

    Private Sub frmRole_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadMembers()
        grpAddMember.Enabled = False

    End Sub

    Private Sub lstMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMembers.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If
        If blnReloading Then
            Exit Sub
        End If
        If lstMembers.SelectedIndex = -1 Then
            'nothing to do here
            Exit Sub
        End If
        chkNewMem.Checked = False
        LoadSelectedRecord()
        grpAddMember.Enabled = False
        GetMemberImage()
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            objMembers.GetMemberByPID(lstMembers.SelectedItem.ToString)
            With objMembers.CurrentObject
                txtPID.Text = .PID
                txtFName.Text = .FName
                txtLName.Text = .LName
                txtMI.Text = .MI
                txtEmail.Text = .Email
                mskPhone.Text = .Phone
                txtPhoto.Text = .PhotoPath
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Members Values", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkNewMem_CheckedChanged(sender As Object, e As EventArgs) Handles chkNewMem.CheckedChanged
        If blnClearing Then
            Exit Sub
        End If
        If chkNewMem.Checked Then
            txtPID.Clear()
            txtFName.Clear()
            txtLName.Clear()
            txtMI.Clear()
            txtEmail.Clear()
            mskPhone.Clear()
            txtPhoto.Clear()
            lstMembers.SelectedIndex = -1
            grpMembers.Enabled = False
            grpAddMember.Enabled = True
            objMembers.CreateNewMember()
            txtPID.Focus()
        Else
            grpMembers.Enabled = True
            grpAddMember.Enabled = False
            objMembers.CurrentObject.IsNewMember = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        'first do validation
        If Not validateTextBoxLength(txtPID, errP) Then
            blnErrors = True
        End If
        If Not validateTextBoxLength(txtFName, errP) Then
            blnErrors = True
        End If
        If Not validateTextBoxLength(txtLName, errP) Then
            blnErrors = True
        End If
        If Not validateTextBoxLength(txtMI, errP) Then
            blnErrors = True
        End If
        If Not validateTextBoxLength(txtEmail, errP) Then
            blnErrors = True
        End If
        If Not ValidateMaskedTextBoxLength(mskPhone, errP) Then
            blnErrors = True
        End If
        If Not validateTextBoxLength(txtPhoto, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objMembers.CurrentObject
            .PID = txtPID.Text
            .FName = txtFName.Text
            .LName = txtLName.Text
            .MI = txtMI.Text
            .Email = txtEmail.Text
            .Phone = mskPhone.Text
            .PhotoPath = txtPhoto.Text
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objMembers.Save
            If intResult = -1 Then
                MessageBox.Show("PID must be unique. Unable to save Member record", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to save Member record: " & ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadMembers()
        chkNewMem.Checked = False
        grpMembers.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        chkNewMem.Checked = True
        errP.Clear()
        If lstMembers.SelectedIndex <> -1 Then
            LoadSelectedRecord() 'reload what was slected in case user hd messed up the form
        Else 'disable the edit area
            grpAddMember.Enabled = True
        End If
        blnClearing = False
        objMembers.CurrentObject.IsNewMember = False
        grpMembers.Enabled = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim blnErrors As Boolean
        Dim objReader As SqlDataReader
        Dim params As New ArrayList
        If txtVal.Text.Length = 0 Then 'missing search value
            errP.SetError(txtVal, "You must enter a search value here")
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        lstMembers.Items.Clear()

        Try
            params.Add(New SqlParameter("@lastname", txtVal.Text))
            objReader = myDB.GetDataReaderBySP("dbo.sp_getMemberbyLastName", params)
            Do While objReader.Read
                lstMembers.Items.Add(objReader.Item("PID") & " " & objReader.Item("LName") & " " & objReader.Item("FName") & " " & objReader.Item("MI") & " " & objReader.Item("Email") & " " & objReader.Item("Phone"))
            Loop
            objReader.Close()

        Catch ex As Exception
            'could have CDB throw the error and trap it here
        End Try
        blnReloading = False

    End Sub
    Private Sub GetMemberImage()
        Dim strImage As String

        If lstMembers.SelectedItem = "* Muscle Malcom *" Then
            strImage = "image1.png"
            picMember.Load("Resources\" & strImage)
        ElseIf lstMembers.SelectedItem = "* Clown Krusty *" Then
            strImage = "image2.jpg"
            picMember.Load("Resources\" & strImage)
        End If

    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim MemberReport As New frmMemberReport
        Me.Cursor = Cursors.WaitCursor
        MemberReport.Display()
    End Sub

    Private Sub lstMembers_Click(sender As Object, e As EventArgs) Handles lstMembers.Click
        GetMemberImage()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim intResult As Integer

        ofdOpen.InitialDirectory = Application.StartupPath
        ofdOpen.Filter = "Image files (*.png)|*.png|All Files (*.*)|*.*"
        ofdOpen.FilterIndex = 1

        intResult = ofdOpen.ShowDialog()
        If intResult = DialogResult.Cancel Then
            Exit Sub
        End If
        strFileName = ofdOpen.FileName
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        LoadMembers()
    End Sub

End Class