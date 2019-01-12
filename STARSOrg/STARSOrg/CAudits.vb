Imports System.Data.SqlClient
Public Class CAudits
    Private _Audit As CAudit

    Public Sub New()
        _Audit = New CAudit
    End Sub

    Public ReadOnly Property CurrentObject() As CAudit
        Get
            Return _Audit
        End Get
    End Property

    Public Sub Clear()
        _Audit = New CAudit
    End Sub

    'Public Sub CreateNewAudit()
    '    'call this when clearing the edit portion of the screen to add a new role
    '    Clear()
    '    _Audit.IsNewRole = True
    'End Sub

    Public Function Save() As Integer
        Return _Audit.Save()
    End Function

    Public Function GetAllAudits() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllAudits", Nothing)
    End Function

    Public Function GetRoleByUkid(strID As String) As CAudit
        Dim params As New ArrayList
        params.Add(New SqlParameter("ukid", strID))
        FillObject(myDB.GetDataReaderBySP("sp_getAuditByUkid", params))
        Return _Audit
    End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CAudit
        Using sqlDR
            If sqlDR.Read() Then 'found the role record 
                With _Audit
                    .ukid = sqlDR.Item("ukid") & ""
                    .PID = sqlDR.Item("PID") & ""
                    .AccessTime = sqlDR.Item("ACCESSTIMESTAMP") & ""
                    .Success = sqlDR.Item("SUCCESS") & ""
                End With
            Else
                'did not get a matching role record
            End If
        End Using
        sqlDR.Close()
        Return _Audit
    End Function
End Class
