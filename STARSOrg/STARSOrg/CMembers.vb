Imports System.Data.SqlClient
Public Class CMembers
    Private _Member As CMember


    Public Sub New()
        _Member = New CMember
    End Sub

    Public ReadOnly Property CurrentObject() As CMember
        Get
            Return _Member
        End Get
    End Property

    Public Sub Clear()
        _Member = New CMember
    End Sub
    Public Sub CreateNewMember()
        'call this when clearing the edit portion otf the screen to add a new role
        Clear()
        _Member.IsNewMember = True
    End Sub

    Public Function Save() As Integer
        Return _Member.Save
    End Function

    Public Function GetAllMembers() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllMembers", Nothing)
    End Function

    Public Function GetMemberByPID(strID As String) As CMember
        Dim params As New ArrayList
        params.Add(New SqlParameter("PID", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetMemberByPID", params))
        Return _Member
    End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CMember
        Using sqlDR
            If sqlDR.Read() Then
                With _Member
                    .PID = sqlDR.Item("PID") & ""
                    .FName = sqlDR.Item("FName") & ""
                    .LName = sqlDR.Item("LName") & ""
                    .MI = sqlDR.Item("MI") & ""
                    .Email = sqlDR.Item("Email") & ""
                    .Phone = sqlDR.Item("Phone") & ""
                    .PhotoPath = sqlDR.Item("PhotoPath") & ""
                End With
            Else
                'did not get a matching role record
            End If
        End Using
        sqlDR.Close()
        Return _Member
    End Function




    Public Function GetReportData() As SqlDataAdapter
        Return myDB.GetDataAdapterBySP("dbo.sp_getAllMembers", Nothing)
    End Function




End Class
