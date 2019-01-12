Imports System.Data.SqlClient
Public Class frmAdmin
    Private formAdminChangePW As frmAdminChangePW
    Private sqlDA As SqlDataAdapter
    Private dt As DataTable
    Private objMembers As CMembers
    Private objSecuritys As CSecuritys
    Private sqlDR As SqlDataReader
    Private blnReloading As Boolean

#Region "Column Constants"
    Private Const PID As Integer = 0
    Private Const FNAME As Integer = 1
    Private Const LNAME As Integer = 2
    Private Const USERID As Integer = 3
    Private Const SECROLE As Integer = 4
#End Region

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

#End Region

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        sqlDA = New SqlDataAdapter
        objMembers = New CMembers
        objSecuritys = New CSecuritys
        LoadMemberCredentials()
        LoadComboBox()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        formAdminChangePW = New frmAdminChangePW
        formAdminChangePW.lblUser.Text = txtPID.Text
        formAdminChangePW.ShowDialog()
    End Sub

    Private Sub LoadComboBox()
        cboSecPriv.Items.Clear()
        With cboSecPriv.Items
            .Add("ADMIN")
            .Add("OFFICER")
            .Add("MEMBER")
            .Add("GUEST")
        End With
    End Sub

    Private Sub LoadMemberCredentials()
        'make only members that don't have a sec role load in
        Dim objReader As SqlDataReader
        Dim dtReader As DataTableReader
        sqlDA = myDB.GetDataAdapterBySP("sp_getAllSecuritys", Nothing)
        dt = New DataTable
        sqlDA.Fill(dt)
        lvwMembers.Items.Clear()
        lvwMembers.Columns.Clear()
        lvwMembers.Columns.Add("PID").Width = 150
        lvwMembers.Columns.Add("Last Name").Width = 150
        lvwMembers.Columns.Add("First Name").Width = 150
        Try
            objReader = objMembers.GetAllMembers
            dtReader = dt.CreateDataReader
            Do While objReader.Read
                dtReader.Read()
                Dim lviRow As New ListViewItem(DirectCast(objReader.Item("PID"), String))
                Dim lviCol As New ListViewItem.ListViewSubItem

                lviCol.Text = objReader.Item("LName")
                lviRow.SubItems.Add(lviCol)
                lviCol = New ListViewItem.ListViewSubItem
                lviCol.Text = objReader.Item("FName")
                lviRow.SubItems.Add(lviCol)
                lviCol = New ListViewItem.ListViewSubItem
                'If dtReader.Item("PID") And dtReader.Item("PID").Equals(objReader.Item("PID")) Then
                '    lviCol.Text = dtReader.Item("UserID")
                '    lviRow.SubItems.Add(lviCol)
                '    lviCol = New ListViewItem.ListViewSubItem
                '    lviCol.Text = dtReader.Item("SecRole")
                '    lviRow.SubItems.Add(lviCol)
                'Else
                '    lviCol.Text = ""
                '    lviRow.SubItems.Add(lviCol)
                '    lviRow.SubItems.Add(lviCol)
                'End If

                lvwMembers.Items.Add(lviRow)
            Loop
            objReader.Close()
            dtReader.Close()

        Catch ex As Exception
            'could have CDB throw the error and trao it here
            MessageBox.Show(ex.ToString)
        End Try
        blnReloading = False
    End Sub

    Private Sub lvwMembers_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lvwMembers.ItemSelectionChanged

        Dim lvwItem As ListViewItem = New ListViewItem
        lvwItem = e.Item
        Dim objSecurity As CSecurity = New CSecurity
        txtUser.Clear()
        txtPID.Text = lvwItem.Text
        'objSecurity = objSecuritys.GetSecurityByPID(txtPID.Text)
        'txtUser.Text = lvwItem.SubItems.Item(USERID).Text 
        txtUser.Text = objSecurity.UserID
        If txtUser.Text.Equals(objSecurity.UserID) Then
            txtUser.Clear()
            cboSecPriv.SelectedIndex = Nothing
            Exit Sub
        End If
        Select Case objSecurity.SecurityRole
            Case "ADMIN"
                cboSecPriv.SelectedIndex() = 0
            Case "OFFICER"
                cboSecPriv.SelectedIndex() = 1
            Case "MEMBER"
                cboSecPriv.SelectedIndex() = 2
            Case "GUEST"
                cboSecPriv.SelectedIndex() = 3

        End Select
    End Sub

    Private Sub chkNewCreds_CheckedChanged(sender As Object, e As EventArgs) Handles chkNewCreds.CheckedChanged
        If chkNewCreds.Checked Then
            txtUser.Enabled = True
            mskNewPass.Enabled = True
            mskConfirmPass.Enabled = True
            btnConfirm.Enabled = True
        Else
            mskNewPass.Clear()
            mskConfirmPass.Clear()
            txtUser.Clear()
            mskNewPass.Enabled = False
            mskConfirmPass.Enabled = False
            btnConfirm.Enabled = False
            txtUser.Enabled = False
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        If btnConfirm.Enabled Then

            'If ValidateTextBoxLength(txtUser, errP) Then
            '    blnErrors = True
            'End If

            'If Not ValidateCombo(cboSecPriv, errP) Then
            '    blnErrors = True
            'End If

            If Not ValidateMaskedTextBoxLength(mskNewPass, errP) Then
                blnErrors = True
            End If

            If Not ValidateMaskedTextBoxLength(mskConfirmPass, errP) Then
                blnErrors = True
            End If

            If blnErrors = True Then
                MessageBox.Show("Field(s) can't be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not mskNewPass.Text.Equals(mskConfirmPass.Text) Then
                errP.SetError(mskNewPass, "Password does not match confirmed password")
                errP.SetError(mskConfirmPass, "Password does not match new password")
            Else
                Try
                    'objSecuritys.CurrentObject.Password = mskConfirmPass.Text
                    With objSecuritys.CurrentObject
                        .PID = txtPID.Text
                        .UserID = txtUser.Text
                        .Password = mskConfirmPass.Text
                        .SecurityRole = cboSecPriv.Items.Item(cboSecPriv.SelectedIndex())
                    End With
                    intResult = objSecuritys.Save()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            End If

            If intResult = 1 Then
                MessageBox.Show("Credentials Successfully Created!")
                chkNewCreds.CheckState = 0
            End If
        End If
        LoadMemberCredentials()
    End Sub
End Class