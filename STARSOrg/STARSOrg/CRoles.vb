Imports System.Data.SqlClient
Public Class CRoles
    'Represents the ROLE table and its associatd business rules 
    Private _Role As CRole

    'constructor 
    Public Sub New()
        'instantiate the CRole object
        _Role = New CRole
    End Sub

    Public ReadOnly Property CurrentObject() As CRole
        Get
            Return _Role
        End Get
    End Property

    Public Sub Clear()
        _Role = New CRole
    End Sub

    Public Sub CreateNewRole()
        'call this when clearing the edit portion of the screen to add a new role
        Clear()
        _Role.IsNewRole = True
    End Sub

    Public Function Save() As Integer
        Return _Role.Save
    End Function

    Public Function GetAllRoles() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllRoles", Nothing)
    End Function

    Public Function GetRoleByRoleID(strID As String) As CRole
        Dim params As New ArrayList
        params.Add(New SqlParameter("roleID", strID))
        FillObject(myDB.GetDataReaderBySP("sp_getRoleByRoleID", params))
        Return _Role
    End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CRole
        Using sqlDR
            If sqlDR.Read() Then 'found the role record 
                With _Role
                    .RoleID = sqlDR.Item("RoleID") & ""
                    .RoleDescription = sqlDR.Item("RoleDescription") & ""
                End With
            Else
                'did not get a matching role record
            End If
        End Using
        sqlDR.Close()
        Return _Role
    End Function
End Class
