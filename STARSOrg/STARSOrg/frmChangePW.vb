Imports System.Data.SqlClient
Public Class frmChangePW
    Private objAudits As CAudits
    Private objSecuritys As CSecuritys

    Private Sub frmChangePW_Load(sender As Object, e As EventArgs) Handles Me.Load
        objAudits = New CAudits
        objSecuritys = New CSecuritys
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim objReader As SqlDataReader
        Dim blnFound As Boolean = False
        Try
            'Dim security As CSecurity
            objReader = objSecuritys.GetAllSecuritys
            Do While objReader.Read

                If mskUser.Text.Equals(objReader.Item("UserID")) And mskPass.Text.Equals(objReader.Item("Password")) Then
                    PID = objReader.Item("PID")
                    username = objReader.Item("UserID")
                    secRole = objReader.Item("SecRole")
                    With objAudits.CurrentObject
                        .PID = PID
                        .AccessTime = Today
                        .Success = 1
                    End With
                    blnFound = True
                End If

            Loop

            If blnFound = False Then
                With objAudits.CurrentObject
                    .PID = "9999999"
                    .AccessTime = Today
                    .Success = 0
                End With
                errP.SetError(mskUser, "Wrong User")
                errP.SetError(mskPass, "Wrong Password")
            Else
                MessageBox.Show("Login in successful. Please change your password.")
                mskNewPass.Enabled = True
                mskConfirmPass.Enabled = True
                btnConfirm.Enabled = True
            End If

            objReader.Close()
            objAudits.Save()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean

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
            'objSecuritys.CurrentObject.Password = mskConfirmPass.Text
            With objSecuritys.CurrentObject
                .PID = PID
                .UserID = username
                .Password = mskConfirmPass.Text
                .SecurityRole = secRole
            End With
            Try
                Me.Cursor = Cursors.WaitCursor
                intResult = objSecuritys.Save()
                If intResult = -1 Then

                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If

        If intResult = 1 Then
            MessageBox.Show("Password Successfully Changed!")
            Me.Close()
        End If
    End Sub

End Class