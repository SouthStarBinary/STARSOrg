Imports System.Data.SqlClient
Public Class CSecuritys
    Private _Security As CSecurity

    Public Sub New()
        _Security = New CSecurity
    End Sub

    Public ReadOnly Property CurrentObject() As CSecurity
        Get
            Return _Security
        End Get
    End Property

    Public Sub Clear()
        _Security = New CSecurity
    End Sub

    Public Sub CreateNewSecurity()
        'call this when clearing the edit portion of the screen to add a new role
        Clear()
        _Security.IsNewAcc = True
    End Sub

    Public Function Save() As Integer
        Return _Security.Save
    End Function

    Public Function GetAllSecuritys() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllSecuritys", Nothing)
    End Function

    Public Function GetSecurityByPID(strID As String) As CSecurity
        Dim params As New ArrayList
        params.Add(New SqlParameter("PID", strID))
        FillObject(myDB.GetDataReaderBySP("sp_getSecurityByPID", params))
        Return _Security
    End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CSecurity
        Using sqlDR
            If sqlDR.Read() Then 'found the role record 
                With _Security
                    .PID = sqlDR.Item("PID") & ""
                    .UserID = sqlDR.Item("UserID") & ""
                    .Password = sqlDR.Item("Password") & ""
                    .SecurityRole = sqlDR.Item("SecRole") & ""
                End With
            Else
                'did not get a matching role record
            End If
        End Using
        sqlDR.Close()
        Return _Security
    End Function
End Class
