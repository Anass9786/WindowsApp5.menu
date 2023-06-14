Imports System.Data.SqlClient
Module Glob
    Public StrCon As String = "Data Source=ANCH-97\SQLEXPRESS;Initial Catalog=test2;Integrated Security=True"
    Public StgCon As New SqlConnection(StrCon)
    Public StgCmd As New SqlCommand("", StgCon)
    Public StgDr As SqlDataReader

End Module