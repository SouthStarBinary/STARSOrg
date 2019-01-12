Imports System.Data.SqlClient

Public Class CTutorCourse
    'represents all records in the member_Semester table
    Private _mstrukid As String
    Private _mstrPID As String
    Private _mstrSemesterID As String
    Private _mstrCourseID As String
    Private _isNewTutor As Boolean
    'constructor 
    Public Sub New()
        _mstrukid = ""
        _mstrPID = ""
        _mstrCourseID = ""
        _mstrSemesterID = ""
    End Sub
#Region "Exposed Properties"
    Public Property SemesterID As String
        Get
            Return _mstrSemesterID
        End Get
        Set(strVal As String)
            _mstrSemesterID = strVal
        End Set
    End Property
    Public Property CourseID As String
        Get
            Return _mstrCourseID
        End Get
        Set(strVal As String)
            _mstrCourseID = strVal
        End Set
    End Property
    Public Property ukid As String
        Get
            Return _mstrukid
        End Get
        Set(strVal As String)
            _mstrukid = strVal
        End Set
    End Property
    Public Property PID As String
        Get
            Return _mstrPID
        End Get
        Set(strVal As String)
            _mstrPID = strVal
        End Set
    End Property
    Public Property IsNewTutor As Boolean
        Get
            Return _isNewTutor
        End Get
        Set(blnVal As Boolean)
            _isNewTutor = blnVal
        End Set
    End Property
    Public ReadOnly Property GetSaveParameters() As ArrayList
        'this property's code will create the parameters for the stored procedure to save a record
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("ukid", _mstrukid))
            params.Add(New SqlParameter("pid", _mstrPID))
            params.Add(New SqlParameter("semesterID", _mstrSemesterID))
            params.Add(New SqlParameter("courseID", _mstrCourseID))
            Return params
        End Get
    End Property
#End Region
    Public Function Save() As Integer
        'return -1 if the ID already exists (and we cannot create a new record with duplicate ID)
        If IsNewTutor Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("ukid", _mstrukid))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckukidExists", params)
            If Not strResult = 0 Then
                Return -1 'not unique
            End If
        End If
        'if not a new Semester or it is new and has a unique id, then do the save (update or insert)
        Return myDB.ExecSP("sp_saveTutor", GetSaveParameters())
    End Function

    Public Function Delete() As Integer
        'return -1 if the ID already exists (and we cannot create a new record with duplicate ID)
        If IsNewTutor Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("ukid", _mstrukid))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckukidExists", params)
            If Not strResult = 0 Then
                Return -1 'not unique
            End If
        End If
        'if not a new Semester or it is new and has a unique id, then do the save (update or insert)
        Return myDB.ExecSP("sp_deleteTutor", GetSaveParameters())
    End Function
End Class

