Imports System.Data.SqlClient
Public Class CAudit
    Private _ukid As Integer
    Private _strPID As String
    Private _dateAccessTime As Date
    Private _strSuccess As Integer

    Public Sub New()
        _strPID = ""
    End Sub

    Public Property ukid As Integer
        Get
            Return _ukid
        End Get
        Set(value As Integer)
            _ukid = value
        End Set
    End Property

    Public Property PID As String
        Get
            Return _strPID
        End Get
        Set(value As String)
            _strPID = value
        End Set
    End Property

    Public Property AccessTime As Date
        Get
            Return _dateAccessTime
        End Get
        Set(value As Date)
            _dateAccessTime = value
        End Set
    End Property

    Public Property Success As Integer
        Get
            Return _strSuccess
        End Get
        Set(value As Integer)
            _strSuccess = value
        End Set
    End Property

    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("ukid", _ukid))
            params.Add(New SqlParameter("PID", _strPID))
            params.Add(New SqlParameter("ACCESSTIMESTAMP", _dateAccessTime))
            params.Add(New SqlParameter("SUCCESS", _strSuccess))
            Return params
        End Get
    End Property

    Public Function Save() As Integer
        Return myDB.ExecSP("sp_saveAudit", GetSaveParameters())
    End Function
End Class
