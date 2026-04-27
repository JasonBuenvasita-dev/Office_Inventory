<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddItem
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtMinStock = New System.Windows.Forms.TextBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblMinStock = New System.Windows.Forms.Label()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(130, 17)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(200, 22)
        Me.txtItemName.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(130, 137)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(200, 22)
        Me.txtPrice.TabIndex = 4
        '
        'txtMinStock
        '
        Me.txtMinStock.Location = New System.Drawing.Point(130, 177)
        Me.txtMinStock.Name = "txtMinStock"
        Me.txtMinStock.Size = New System.Drawing.Size(200, 22)
        Me.txtMinStock.TabIndex = 5
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(130, 217)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(200, 22)
        Me.txtBarcode.TabIndex = 6
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Office Supplies", "Electronics", "Furniture", "Other"})
        Me.cmbCategory.Location = New System.Drawing.Point(130, 57)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(200, 24)
        Me.cmbCategory.TabIndex = 2
        '
        'cmbUnit
        '
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Items.AddRange(New Object() {"Piece", "Box", "Pack", "Ream", "Set"})
        Me.cmbUnit.Location = New System.Drawing.Point(130, 97)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(200, 24)
        Me.cmbUnit.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(130, 270)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 30)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(240, 270)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 30)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblItemName
        '
        Me.lblItemName.Location = New System.Drawing.Point(20, 20)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(100, 23)
        Me.lblItemName.TabIndex = 0
        Me.lblItemName.Text = "Item Name:"
        '
        'lblCategory
        '
        Me.lblCategory.Location = New System.Drawing.Point(20, 60)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(100, 23)
        Me.lblCategory.TabIndex = 2
        Me.lblCategory.Text = "Category:"
        '
        'lblUnit
        '
        Me.lblUnit.Location = New System.Drawing.Point(20, 100)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(100, 23)
        Me.lblUnit.TabIndex = 3
        Me.lblUnit.Text = "Unit:"
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(20, 140)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice.TabIndex = 4
        Me.lblPrice.Text = "Cost Price:"
        '
        'lblMinStock
        '
        Me.lblMinStock.Location = New System.Drawing.Point(20, 180)
        Me.lblMinStock.Name = "lblMinStock"
        Me.lblMinStock.Size = New System.Drawing.Size(100, 23)
        Me.lblMinStock.TabIndex = 5
        Me.lblMinStock.Text = "Min Stock:"
        '
        'lblBarcode
        '
        Me.lblBarcode.Location = New System.Drawing.Point(20, 220)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(100, 23)
        Me.lblBarcode.TabIndex = 6
        Me.lblBarcode.Text = "Barcode:"
        '
        'frmAddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 330)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.lblUnit)
        Me.Controls.Add(Me.cmbUnit)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblMinStock)
        Me.Controls.Add(Me.txtMinStock)
        Me.Controls.Add(Me.lblBarcode)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "frmAddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Item"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtMinStock As TextBox
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents cmbUnit As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblUnit As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblMinStock As Label
    Friend WithEvents lblBarcode As Label

End Class