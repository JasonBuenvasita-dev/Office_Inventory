Imports MySql.Data.MySqlClient

Module Module1
    Public connString As String = "server=localhost;userid=root;password=buenavista12345;database=OfficeStockSystem"
    Public con As New MySqlConnection(connString)

    Public Sub Connection()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message)
        End Try
    End Sub
End Module