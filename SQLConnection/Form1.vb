Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlClient.SqlConnection
        conn.ConnectionString = "Persist Security Info=true;Server=XPS;Database=BETANIA;User Id=sa;Password=123;Integrated Security=true;"

        Dim cmd As SqlCommand = New SqlCommand("")


        Try
            conn.Open()
            MsgBox(conn.State.ToString)
        Catch ex As Exception
            MsgBox(ex.ToString)

        Finally
            conn.Close()
        End Try


    End Sub
End Class
