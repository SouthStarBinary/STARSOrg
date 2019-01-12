Imports System.Data.SqlClient


Public Class CEvent
    'represents a single record in the role table

    'class instance vars

    Private _mstrEventID As Integer 'represents EventID field in EVENT table  integer length 4 so textbox needs to match
    Private _mstrEventDescription As String
    Private _mstrEventTypeID As String
    Private _mstrSemesterID As String
    Private _mdtmStartDate As Date
    Private _mdtmEndDate As Date
    Private _mstrLocation As String
    Private _isNewEvent As Boolean   'lets us know if its an INSERT or UPDATE

    'constructor
    Public Sub New()
        _mstrEventID = 0
        _mstrEventDescription = ""
        _mstrEventTypeID = ""
        _mstrSemesterID = ""
        _mdtmStartDate = Today.Date
        _mdtmEndDate = Today.Date
        _mstrLocation = ""
    End Sub
#Region "Exposed Properties"
    Public Property EventID As Integer
        Get
            Return _mstrEventID
        End Get
        Set(intVal As Integer)
            _mstrEventID = intVal
        End Set
    End Property
    Public Property EventDescription As String
        Get
            Return _mstrEventDescription
        End Get
        Set(strVal As String)
            _mstrEventDescription = strVal
        End Set
    End Property
    Public Property EventTypeID As String
        Get
            Return _mstrEventTypeID
        End Get
        Set(strVal As String)
            _mstrEventTypeID = strVal
        End Set
    End Property
    Public Property SemesterID As String
        Get
            Return _mstrSemesterID
        End Get
        Set(strVal As String)
            _mstrSemesterID = strVal
        End Set
    End Property
    Public Property StartDate As Date
        Get
            Return _mdtmStartDate
        End Get
        Set(strVal As Date)
            _mdtmStartDate = strVal
        End Set
    End Property
    Public Property EndDate As Date
        Get
            Return _mdtmEndDate
        End Get
        Set(strVal As Date)
            _mdtmEndDate = strVal
        End Set
    End Property
    Public Property Location As String
        Get
            Return _mstrLocation
        End Get
        Set(strVal As String)
            _mstrLocation = strVal
        End Set
    End Property
    Public Property IsNewEvent As Boolean
        Get
            Return _isNewEvent
        End Get
        Set(blnVal As Boolean)
            _isNewEvent = blnVal
        End Set
    End Property
    Public ReadOnly Property GetSaveParameters() As ArrayList
        'this property's code will create the parameters for the stored procedure to save a record
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("eventID", _mstrEventID))
            params.Add(New SqlParameter("eventDescription", _mstrEventDescription))
            params.Add(New SqlParameter("eventTypeID", _mstrEventTypeID))
            params.Add(New SqlParameter("semesterID", _mstrSemesterID))
            params.Add(New SqlParameter("startDate", _mdtmStartDate))
            params.Add(New SqlParameter("endDate", _mdtmEndDate))
            params.Add(New SqlParameter("location", _mstrLocation))

            Return params
        End Get
    End Property
#End Region
    Public Function Save() As Integer
        'Return -1 If the ID already exists (And we cannot create a New record With duplicate ID)
        If IsNewEvent Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("eventID", _mstrEventID))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckEventIDExists", params)
            If Not strResult = 0 Then
                Return -1 'not UNIQUE!!!!
            End If
        End If
        'if not a new role, or if it is new anad has a unique ID, then do the save (update, or insert)
        Return myDB.ExecSP("sp_saveEvent", GetSaveParameters())
    End Function




End Class
