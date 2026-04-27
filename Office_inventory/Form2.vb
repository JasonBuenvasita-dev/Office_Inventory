Imports MySql.Data.MySqlClient

Public Class frmAddItem

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate required fields
        If txtItemName.Text.Trim() = "" Then
            MsgBox("Please enter an item name.")
            Exit Sub
        End If

        If txtPrice.Text.Trim() = "" Then
            MsgBox("Please enter a cost price.")
            Exit Sub
        End If

        If txtMinStock.Text.Trim() = "" Then
            MsgBox("Please enter a minimum stock level.")
            Exit Sub
        End If

        Try
            Connection()

            Dim sql As String = "INSERT INTO Items (ItemName, Category, Unit, CostPrice, MinStockLevel, Barcode) " &
                                "VALUES (@name, @cat, @unit, @price, @min, @code)"

            Using cmd As New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@name", txtItemName.Text.Trim())
                cmd.Parameters.AddWithValue("@cat", cmbCategory.Text)
                cmd.Parameters.AddWithValue("@unit", cmbUnit.Text)
                cmd.Parameters.AddWithValue("@price", Decimal.Parse(txtPrice.Text))
                cmd.Parameters.AddWithValue("@min", Integer.Parse(txtMinStock.Text))
                cmd.Parameters.AddWithValue("@code", txtBarcode.Text.Trim())
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Item Saved Successfully!")
            Me.Close()

        Catch ex As FormatException
            MsgBox("Please enter valid numbers for Price and Min Stock.")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class