Module modGlobal
    'contains all variables, constants, procedures and functions that need to be accessed in more than one form 

#Region "Screen Constants"
    Public Const ACTION_NONE = 0
    Public Const ACTION_HOME = 1
    Public Const ACTION_MEMBER = 2
    Public Const ACTION_ROLE = 3
    Public Const ACTION_EVENT = 4
    Public Const ACTION_RSVP = 5
    Public Const ACTION_COURSE = 6
    Public Const ACTION_SEMESTER = 7
    Public Const ACTION_HELP = 8
    Public Const ACTION_TUTOR = 9
    Public Const ACTION_ADMIN = 10 'might change this later
    Public Const ACTION_LOGOUT = 11
#End Region
    Public PID As String
    Public username As String
    Public secRole As String
    Public intNextAction As Integer
    'add CDB from henry books later Project > add existing item
    Public myDB As New CDB
End Module
