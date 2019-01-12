Imports System.Data.SqlClient

Public Class CEvents
    'represents the Event table and its associated business rules   2nd tier    19 pt 4
    Private _Event As CEvent

    'constructor
    Public Sub New()
        _Event = New CEvent

    End Sub

    'expose the CEvent object as callers of the class

    ' a whole CEvent record
    Public ReadOnly Property CurrentObject() As CEvent
        Get
            Return _Event
        End Get
    End Property

    Public Sub Clear()
        _Event = New CEvent
    End Sub
    Public Sub CreateNewEvent()
        'call this when clearing the edit portion of the screen to add a new Event
        Clear()
        _Event.IsNewEvent = True
    End Sub

    Public Function Save() As Integer
        Return _Event.Save
    End Function

    Public Function GetAllEvents() As SqlDataReader
        Return myDB.GetDataReaderBySP("sp_getAllEvents", Nothing)
    End Function

    Public Function GetEventByEventID(intID As Integer) As CEvent
        Dim params As New ArrayList
        params.Add(New SqlParameter("eventID", intID))
        FillObject(myDB.GetDataReaderBySP("sp_GetEventByEventID", params))
        Return _Event

    End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CEvent
        Using sqlDR
            If sqlDR.Read() Then   'found the event record
                With _Event
                    .EventID = sqlDR.Item("EventID") & ""
                    .EventDescription = sqlDR.Item("EventDescription") & ""
                    .EventTypeID = sqlDR.Item("EventTypeID") & ""
                    .SemesterID = sqlDR.Item("SemesterID") & ""
                    .StartDate = sqlDR.Item("StartDate") & ""
                    .EndDate = sqlDR.Item("EndDate") & ""
                    .Location = sqlDR.Item("Location") & ""

                End With
            Else
                'did not get a matching event record, no record was returned 
            End If
        End Using
        sqlDR.Close()
        Return _Event
    End Function

End Class
