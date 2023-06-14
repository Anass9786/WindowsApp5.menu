Imports System.Data.SqlClient
Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim stgCon As New SqlConnection(StrCon)
        Dim stgCmd As New SqlCommand("Select * from stagiaire", stgCon)
        Dim StgDr As SqlDataReader
        stgCon.Open()
        StgDr = stgCmd.ExecuteReader
        Me.ComboBox1.Items.Clear()
        Do While StgDr.Read
            Me.ComboBox1.Items.Add(StgDr("idstg"))
        Loop
        StgDr.Close()
        stgCon.Close()
    End Sub
End Class