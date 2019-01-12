Imports System.Data.SqlClient

Public Class CSecurity
    Private _PID As String
    Private _strUserID As String
    Private _intPassword As String
    Private _strSecRole As String
    Private _isNewAcc As Boolean

    Public Sub New()
        _PID = 0
        _strUserID = ""
        _intPassword = ""
        _strSecRole = ""
    End Sub

    Public Property PID As String
        Get
            Return _PID
        End Get
        Set(value As String)
            _PID = value
        End Set
    End Property

    Public Property UserID As String
        Get
            Return _strUserID
        End Get
        Set(value As String)
            _strUserID = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _intPassword
        End Get
        Set(value As String)
            _intPassword = value
        End Set
    End Property

    Public Property SecurityRole As String
        Get
            Return _strSecRole
        End Get
        Set(value As String)
            _strSecRole = value
        End Set
    End Property

    Public Property IsNewAcc As Boolean
        Get
            Return _isNewAcc
        End Get
        Set(blnVal As Boolean)
            _isNewAcc = blnVal
        End Set
    End Property

    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _PID))
            params.Add(New SqlParameter("UserID", _strUserID))
            params.Add(New SqlParameter("Password", _intPassword))
            params.Add(New SqlParameter("SecRole", _strSecRole))
            Return params
        End Get
    End Property

    Public Function Save() As Integer
        'return -1 if the ID already exists (and we cannot create a new record with duplicate ID)
        If IsNewAcc Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _PID)) 'first parameter must match the name of the parameter name of table exactly. Second value is the value you're putting in
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckPIDExits", params)
            If Not strResult = 0 Then
                Return -1 'not unique!!
            End If
        End If
        'if not a new role, or it is new and has a unique ID, then do the save (update or insert)
        Return myDB.ExecSP("sp_saveSecurity", GetSaveParameters())
    End Function

End Class
