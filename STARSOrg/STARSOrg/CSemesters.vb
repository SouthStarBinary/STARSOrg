Imports System.Data.SqlClient
Public Class CSemesters
    'Represents the SEMESTER table and its associated business rules
    Private _Semester As CSemester

    'Constructor
    Public Sub New()
        'instantiate the CSemester object 
        _Semester = New CSemester
    End Sub

    Public ReadOnly Property CurrentObject() As CSemester
        Get
            Return _Semester
        End Get
    End Property

    Public Sub Clear()
        _Semester = New CSemester
    End Sub

    Public Sub CreateNewSemester()
        'call this when clearing the edit portion of the screen to add a new semester
        Clear()
        _Semester.IsNewSemester = True
    End Sub

    Public Function Save() As Integer
        Return _Semester.Save
    End Function

    Public Function GetAllSemesters() As SqlDataReader
        Return MyDB.GetDataReaderBySP("sp_getAllSemesters", Nothing)
    End Function

    Public Function GetSemesterBySemesterID(strID As String) As CSemester
        Dim params As New ArrayList
        params.Add(New SqlParameter("semesterID", strID))
        FillObject(MyDB.GetDataReaderBySP("sp_getSemesterBySemesterID", params))
        Return _Semester
    End Function

    Public Function FillObject(objDR As SqlDataReader) As CSemester
        If objDR.Read() Then 'found the semester record
            With _Semester
                .SemesterID = objDR.Item("SemesterID")
                .SemesterDescription = objDR.Item("SemesterDescription")
            End With
        Else
            'did not get a matching semester record
        End If
        objDR.Close()
        Return _Semester
    End Function
End Class
