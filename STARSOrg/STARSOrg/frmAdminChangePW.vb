Imports System.Data.SqlClient
Public Class frmAdminChangePW
    Private objSecuritys As CSecuritys

    Private Sub frmAdminChangePW_Load(sender As Object, e As EventArgs) Handles Me.Load
        objSecuritys = New CSecuritys
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
            Try
                'objSecuritys.CurrentObject.Password = mskConfirmPass.Text
                With objSecuritys.CurrentObject
                    .PID = lblUser.Text.ToString
                    '.UserID = username
                    .Password = mskConfirmPass.Text
                    '.SecurityRole = secRole
                End With
                intResult = objSecuritys.Save()
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