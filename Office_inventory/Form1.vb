Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventory()
    End Sub

    Public Sub LoadInventory()
        Try
            Connection()
            Dim sql As String = "SELECT * FROM Items"
            Dim adapter As New MySqlDataAdapter(sql, con)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvInventory.DataSource = table
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnOpenAdd_Click(sender As Object, e As EventArgs) Handles btnOpenAdd.Click
        frmAddItem.ShowDialog()
        LoadInventory() ' Refresh the grid after adding
    End Sub

End Class