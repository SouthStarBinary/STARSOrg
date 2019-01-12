Imports System.Data.SqlClient

Module modDB
    'connection string
    Public gstrConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jeanp\Desktop\Windows Programming\STARSOrg\STARSOrg\STARSDB.mdf;Integrated Security=True"
    'Database Objects
    Public objSQLConn As SqlConnection
    Public objSQLCommand As SqlCommand

End Module
