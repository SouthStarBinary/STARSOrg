Imports System.Data.SqlClient

Public Class CTutorsCourses

    'represents the ROLE table and its associated business rules
    Private _Tutor As CTutorCourse

    'constructor
    Public Sub New()
        'instantiaite the CTutor object
        _Tutor = New CTutorCourse
    End Sub

    Public ReadOnly Property CurrentObject As CTutorCourse
        Get
            Return _Tutor
        End Get
    End Property

    Public Sub Clear()
        _Tutor = New CTutorCourse
    End Sub

    Public Sub CreateNewTutor()
        'call this when clearing the edit portion of the screen to add a new role
        Clear()
        _Tutor.IsNewTutor = True
    End Sub

    Public Function Save()
        Return _Tutor.Save
    End Function

    Public Function Delete()
        Return _Tutor.Delete
    End Function

    Public Function GetAllTutorCourses() As SqlDataReader
        Return myDB.getDataReaderBySP("dbo.sp_getAllTutors", Nothing)
    End Function

    Public Function GetTutorCoursesByTutorID(strID As String, strSemId As String) As SqlDataReader
        Dim params As New ArrayList
        params.Add(New SqlParameter("PID", strID))
        params.Add(New SqlParameter("semesterID", strSemId))
        Return myDB.getDataReaderBySP("sp_getTutorCoursesByTutorID", params)
    End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CTutorCourse
        Using sqlDR
            If sqlDR.Read Then 'found the role record
                With _Tutor
                    .ukid = sqlDR.Item("ukid") & ""
                    .PID = sqlDR.Item("PID") & ""
                    .CourseID = sqlDR.Item("CourseID") & ""
                    .SemesterID = sqlDR.Item("SemesterID") & ""
                End With
            Else
                'did not get a matching role record
            End If
        End Using
        sqlDR.Close()
        Return _Tutor
    End Function
End Class
