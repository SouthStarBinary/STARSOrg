Imports System.Data.SqlClient
Public Class frmSecurity
    Private formAdmin As frmAdmin
    Private objSecuritys As CSecuritys
    Private objAudits As CAudits
    Private formChangePW As frmChangePW

    Private Sub frmSecurity_Load(sender As Object, e As EventArgs) Handles Me.Load
        objSecuritys = New CSecuritys
        objAudits = New CAudits
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
                    Me.Close()
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
            End If

            objReader.Close()
            objAudits.Save()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lblPassChange_Click(sender As Object, e As EventArgs) Handles lblPassChange.Click
        MessageBox.Show("Change Password Form Here")
        formChangePW = New frmChangePW
        formChangePW.ShowDialog()
    End Sub

    Private Sub btnGuestLogin_Click(sender As Object, e As EventArgs) Handles btnGuestLogin.Click
        PID = "0000001"
        secRole = "GUEST"
        With objAudits.CurrentObject
            .PID = PID
            .AccessTime = Today
            .Success = 1
        End With
        objAudits.Save()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        intNextAction = ACTION_LOGOUT
        Me.Hide()
    End Sub
End Class